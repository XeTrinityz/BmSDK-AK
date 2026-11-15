using System.Diagnostics;
using System.Text;
using BmSDK.Printer;

// Builds src/BmSDK/Generated from the dumper's JSON lines files.
//   BmSDK.Printer --out <dir> [--report <file>] <dump file or folder>...
// Folders are read in time order. See Dump for how copies of the same class are picked from.

string? outDir = null;
string? reportFile = null;
var inputs = new List<string>();
for (var i = 0; i < args.Length; i++)
{
    if (args[i] == "--out" && i + 1 < args.Length)
    {
        outDir = args[++i];
    }
    else if (args[i] == "--report" && i + 1 < args.Length)
    {
        reportFile = args[++i];
    }
    else
    {
        inputs.Add(args[i]);
    }
}

if (outDir is null || inputs.Count == 0)
{
    Console.Error.WriteLine("Usage: BmSDK.Printer --out <dir> [--report <file>] <dump file or folder>...");
    return 1;
}

var files = inputs.SelectMany(p => Directory.Exists(p) ? Dump.FilesIn(p) : [p]).ToList();
var timer = Stopwatch.StartNew();
var dump = Dump.Load(files);
Console.WriteLine($"{dump.Classes.Count} classes loaded in {timer.Elapsed.TotalSeconds:0.0}s, {dump.Report.Count(l => !l.StartsWith(' '))} with more than one version");
if (reportFile is not null)
{
    File.WriteAllLines(reportFile, dump.Report);
}

var builder = new InfoBuilder(dump);
var classes = dump.Classes.Values
    .OrderBy(c => c.Path, StringComparer.Ordinal)
    .Select(builder.Class)
    .ToList();

var byPath = classes.ToDictionary(c => c.PathName, StringComparer.Ordinal);
foreach (var cls in classes)
{
    cls.Super = cls.SuperPath is not null ? byPath.GetValueOrDefault(cls.SuperPath) : null;
}

// The output folder is replaced, so only touch one that is empty or was written by a generator.
if (Directory.Exists(outDir))
{
    if (Directory.EnumerateFileSystemEntries(outDir).Any() && !File.Exists(Path.Combine(outDir, "StaticInit.g.cs")))
    {
        Console.Error.WriteLine($"{outDir} isn't a generated folder, not touching it");
        return 1;
    }
    Directory.Delete(outDir, true);
}
Directory.CreateDirectory(outDir);

var utf8 = new UTF8Encoding(false);
foreach (var cls in classes)
{
    var printer = new Printer(dump.Build);
    printer.PrintFile(cls);
    var dir = Path.Combine(outDir, cls.PackageName);
    Directory.CreateDirectory(dir);
    File.WriteAllText(Path.Combine(dir, cls.ManagedName + ".g.cs"), printer.ToString(), utf8);
}
File.WriteAllText(Path.Combine(outDir, "StaticInit.g.cs"), Printer.StaticInit(classes), utf8);

Console.WriteLine($"Wrote {classes.Count} classes to {outDir} in {timer.Elapsed.TotalSeconds:0.0}s");
return 0;
