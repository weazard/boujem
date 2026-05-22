using System;
using System.IO;
using System.Reflection;

public static class NetFxLoader
{
    public static void Main()
    {
        string dir = @"C:\fdc";
        string asmPath = Path.Combine(dir, "U.V.S. Nirmana.exe");
        Environment.CurrentDirectory = dir;
        AppDomain.CurrentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs args)
        {
            string name = new AssemblyName(args.Name).Name + ".dll";
            string path = Path.Combine(dir, name);
            return File.Exists(path) ? Assembly.LoadFrom(path) : null;
        };

        Assembly asm = Assembly.LoadFrom(asmPath);
        Console.WriteLine("Loaded " + asm.FullName);
        Type text = asm.GetType("#=qylp6qUNKsVhvfdDlLuvMcw==", true);
        foreach (MethodInfo method in text.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            if (method.Name.IndexOf("qTPA2", StringComparison.Ordinal) >= 0)
            {
                Console.WriteLine("Invoking text init " + method.Name);
                method.Invoke(null, null);
            }
        }
        Type decType = asm.GetType("#=qOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN$WeA=", true);
        MethodInfo dec = null;
        foreach (MethodInfo method in decType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            if (method.Name.IndexOf("qjAG", StringComparison.Ordinal) >= 0)
            {
                dec = method;
            }
        }
        int[] probes = new int[] { -2065805519, -2065759202, -2065775396, -2065778099, -2065778113 };
        foreach (int id in probes)
        {
            Console.WriteLine(id + " => " + dec.Invoke(null, new object[] { id }));
        }
        Type puzzle = asm.GetType("Puzzle", true);
        foreach (MethodInfo method in puzzle.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            if (method.Name.IndexOf("qySD", StringComparison.Ordinal) >= 0)
            {
                Console.WriteLine("Invoking " + method.Name);
                method.Invoke(null, null);
                Console.WriteLine("Invoked");
            }
        }
    }
}
