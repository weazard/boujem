using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

public static class DecryptStrings
{
    public static void Main(string[] args)
    {
        string dir = @"C:\fdc";
        Environment.CurrentDirectory = dir;
        AppDomain.CurrentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs eventArgs)
        {
            string path = Path.Combine(dir, new AssemblyName(eventArgs.Name).Name + ".dll");
            return File.Exists(path) ? Assembly.LoadFrom(path) : null;
        };
        Assembly asm = Assembly.LoadFrom(Path.Combine(dir, "U.V.S. Nirmana.exe"));
        Type textType = asm.GetType("#=qylp6qUNKsVhvfdDlLuvMcw==", true);
        foreach (MethodInfo method in textType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            if (method.Name.IndexOf("qTPA2", StringComparison.Ordinal) >= 0)
                method.Invoke(null, null);
        }
        Type decType = asm.GetType("#=qOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN$WeA=", true);
        MethodInfo dec = null;
        foreach (MethodInfo method in decType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            if (method.Name.IndexOf("qjAG", StringComparison.Ordinal) >= 0)
                dec = method;
        }
        SortedSet<int> ids = new SortedSet<int>();
        foreach (string line in File.ReadAllLines(args[0]))
        {
            int value;
            if (int.TryParse(line.Trim(), out value))
                ids.Add(value);
        }
        using (StreamWriter writer = new StreamWriter(args[1]))
        {
            foreach (int id in ids)
            {
                object value = dec.Invoke(null, new object[] { id });
                writer.Write(id);
                writer.Write('\t');
                writer.Write((value == null ? "" : value.ToString()).Replace("\r", "\\r").Replace("\n", "\\n").Replace("\t", "\\t"));
                writer.WriteLine();
            }
        }
    }
}
