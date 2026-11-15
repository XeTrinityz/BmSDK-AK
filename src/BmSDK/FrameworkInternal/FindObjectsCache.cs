using System.Buffers;

namespace BmSDK.Framework;

/// <summary>
/// Indexes every live wrapper by its managed type, for <see cref="Game.FindObjects{T}"/>.
/// </summary>
/// <remarks>
/// Each wrapper sits in one bucket, the list for its exact type, and remembers its index there
/// (<see cref="GameObject.CacheBucket"/>, <see cref="GameObject.CacheIndex"/>), so registering and
/// unregistering an object allocates nothing and removal is a swap with the bucket's last entry. The
/// game creates and destroys tens of thousands of objects while streaming the city, and the earlier
/// design (a linked-list node per type in the object's class chain, plus an array of them and a
/// dictionary entry) left that many long-lived allocations to the garbage collector, which showed up
/// as gen1 pauses of 20-40 ms (Team-BmSDK/BmSDK-AK#13). A query gathers the buckets whose type derives
/// from T once, and again whenever a new type appears.
/// </remarks>
internal static class FindObjectsCache
{
    private static readonly Dictionary<Type, List<GameObject>> s_buckets = [];
    private static readonly Dictionary<Type, List<GameObject>[]> s_queryBuckets = [];
    private static int s_bucketsVersion;
    private static int s_queryVersion = -1;

    /// <summary>
    /// Enumerates the live objects of type T, leaving out actors that are being destroyed. Objects
    /// created or destroyed while enumerating may be missed, as before.
    /// </summary>
    public static IEnumerable<T> FindObjects<T>()
        where T : GameObject
    {
        List<GameObject>[] buckets;
        lock (MarshalUtil.WrapperLock)
        {
            buckets = BucketsFor(typeof(T));
        }

        // Loading threads add and remove entries while this runs. Each bucket is copied under one lock,
        // rather than locked for every entry: a query over a common type used to take the lock thousands
        // of times a call, against loading threads that take it for every object they create. The lock
        // isn't held across the yield, so the caller's own code never runs inside it.
        foreach (var bucket in buckets)
        {
            GameObject[] snapshot;
            var count = 0;
            lock (MarshalUtil.WrapperLock)
            {
                snapshot = ArrayPool<GameObject>.Shared.Rent(Math.Max(bucket.Count, 1));
                foreach (var obj in bucket)
                {
                    // An actor the game has destroyed or queued for destruction lingers in the index
                    // until the engine frees it, and is nothing a script wants to act on. Read under
                    // the lock: a wrapper still in the index can't have had its object freed yet.
                    if (obj is Engine.Actor { IsAlive: false })
                    {
                        continue;
                    }

                    snapshot[count++] = obj;
                }
            }

            try
            {
                for (var i = 0; i < count; i++)
                {
                    // Destroyed since the copy was taken.
                    if (snapshot[i].Ptr != IntPtr.Zero)
                    {
                        yield return (T)snapshot[i];
                    }
                }
            }
            finally
            {
                Array.Clear(snapshot, 0, count);
                ArrayPool<GameObject>.Shared.Return(snapshot);
            }
        }
    }

    private static List<GameObject>[] BucketsFor(Type type)
    {
        if (s_queryVersion != s_bucketsVersion)
        {
            s_queryBuckets.Clear();
            s_queryVersion = s_bucketsVersion;
        }

        if (!s_queryBuckets.TryGetValue(type, out var buckets))
        {
            var list = new List<List<GameObject>>();
            foreach (var (bucketType, bucket) in s_buckets)
            {
                if (type.IsAssignableFrom(bucketType))
                {
                    list.Add(bucket);
                }
            }

            buckets = [.. list];
            s_queryBuckets[type] = buckets;
        }

        return buckets;
    }

    // Register and Unregister are only called with MarshalUtil.WrapperLock held.
    public static void Register(GameObject obj)
    {
        // Omit CDOs, invalid objects from type cache
        if (!obj.IsValid || obj.IsClassDefaultObject || obj.CacheBucket != null)
        {
            return;
        }

        var type = obj.GetType();
        if (!s_buckets.TryGetValue(type, out var bucket))
        {
            bucket = [];
            s_buckets[type] = bucket;
            s_bucketsVersion++;
        }

        obj.CacheBucket = bucket;
        obj.CacheIndex = bucket.Count;
        bucket.Add(obj);
    }

    public static void Unregister(GameObject obj)
    {
        var bucket = obj.CacheBucket;
        if (bucket == null)
        {
            return;
        }

        // Swap the last entry into the hole, so removal is O(1) and nothing is allocated.
        var index = obj.CacheIndex;
        var last = bucket[^1];
        bucket[index] = last;
        last.CacheIndex = index;
        bucket.RemoveAt(bucket.Count - 1);

        obj.CacheBucket = null;
        obj.CacheIndex = -1;
    }
}
