namespace BmSDK.Framework;

/// <summary>
/// Items held by several owners at once (the keys each mod keeps from the game). An item stays held
/// until every owner has let go, and one owner holds it at most once however often it asks.
/// </summary>
internal sealed class HoldSet<T>
    where T : notnull
{
    private readonly Dictionary<T, int> _counts = [];
    private readonly Dictionary<object, HashSet<T>> _byOwner = [];

    public bool IsHeld(T item) => _counts.ContainsKey(item);

    /// <summary>Returns true when the item was free until now.</summary>
    public bool Hold(object owner, T item)
    {
        if (!_byOwner.TryGetValue(owner, out var held))
        {
            _byOwner[owner] = held = [];
        }

        if (!held.Add(item))
        {
            return false;
        }

        _counts.TryGetValue(item, out var count);
        _counts[item] = count + 1;
        return count == 0;
    }

    /// <summary>Returns true when the owner was the last to hold the item.</summary>
    public bool Release(object owner, T item)
    {
        if (!_byOwner.TryGetValue(owner, out var held) || !held.Remove(item))
        {
            return false;
        }

        return Drop(item);
    }

    /// <summary>Lets go of everything an owner holds. Returns the items nobody holds any more.</summary>
    public List<T> ReleaseOwner(object owner)
    {
        var freed = new List<T>();
        if (_byOwner.Remove(owner, out var held))
        {
            foreach (var item in held)
            {
                if (Drop(item))
                {
                    freed.Add(item);
                }
            }
        }

        return freed;
    }

    private bool Drop(T item)
    {
        var count = _counts[item] - 1;
        if (count == 0)
        {
            _counts.Remove(item);
            return true;
        }

        _counts[item] = count;
        return false;
    }
}
