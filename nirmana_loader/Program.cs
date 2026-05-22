// See https://aka.ms/new-console-template for more information
using System.Reflection;

var asmPath = "/Users/edik/Applications/Sikarugir/Untitled.app/Contents/SharedSupport/prefix/drive_c/fdc/U.V.S. Nirmana.exe";
var asm = Assembly.LoadFrom(asmPath);
Console.WriteLine($"Loaded {asm.FullName}");
var t = asm.GetType("Puzzle");
Console.WriteLine($"Puzzle type: {t}");
foreach (var m in t!.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
{
    if (m.Name.Contains("qySD"))
    {
        Console.WriteLine($"Invoking {m.Name}");
        m.Invoke(null, null);
        Console.WriteLine("Invoked");
    }
}
