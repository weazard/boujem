using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;

public static class DumpGameData
{
    static Assembly asm;

    public static void Main(string[] args)
    {
        string dir = @"C:\fdc";
        string outDir = args.Length > 0 ? args[0] : @"Z:\tmp\nirmana_analysis";
        Directory.CreateDirectory(outDir);
        Environment.CurrentDirectory = dir;
        AppDomain.CurrentDomain.AssemblyResolve += delegate(object sender, ResolveEventArgs eventArgs)
        {
            string path = Path.Combine(dir, new AssemblyName(eventArgs.Name).Name + ".dll");
            return File.Exists(path) ? Assembly.LoadFrom(path) : null;
        };

        asm = Assembly.LoadFrom(Path.Combine(dir, "U.V.S. Nirmana.exe"));
        InitLocalization();
        InitGameLogicResourceContainer();
        InvokeStaticByName("ToolType", "qBEPG");
        InvokeStaticByName("Puzzle", "qySD");

        DumpTools(Path.Combine(outDir, "tools.tsv"));
        DumpLevels(Path.Combine(outDir, "levels.tsv"));
        DumpSignals(Path.Combine(outDir, "signals.tsv"));
    }

    static void InitLocalization()
    {
        Type textType = asm.GetType("#=qylp6qUNKsVhvfdDlLuvMcw==", true);
        foreach (MethodInfo method in textType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            if (method.Name.IndexOf("qTPA2", StringComparison.Ordinal) >= 0)
                method.Invoke(null, null);
        }
    }

    static void InitGameLogicResourceContainer()
    {
        Type gameLogic = asm.GetType("GameLogic", true);
        object instance = Activator.CreateInstance(gameLogic);
        gameLogic.GetField("#=qBtBzdF9aBIy2anWoRXn4Mg==", BindingFlags.Public | BindingFlags.Instance).SetValue(instance, @"Z:\tmp\nirmana_runtime");
        Directory.CreateDirectory(@"Z:\tmp\nirmana_runtime");
        FieldInfo singleton = gameLogic.GetField("#=qG7TFSM3ZjeboSgKnWHLPxw==", BindingFlags.Public | BindingFlags.Static);
        singleton.SetValue(null, instance);
        object content = gameLogic.GetField("#=qbTsHMlQ9oIUAp5C_dF9gxg==", BindingFlags.Public | BindingFlags.Instance).GetValue(instance);
        object resources = content.GetType().GetField("#=qU7BEzuVhhNmentVssbQ0rQ==", BindingFlags.Public | BindingFlags.Instance).GetValue(content);
        Type textureType = asm.GetType("Texture", true);
        object dummyTexture = FormatterServices.GetUninitializedObject(textureType);
        FillNullAssets(resources, textureType, dummyTexture, new List<object>());
    }

    static void FillNullAssets(object obj, Type textureType, object dummyTexture, List<object> seen)
    {
        if (obj == null) return;
        Type type = obj.GetType();
        if (type.IsPrimitive || type == typeof(string) || type.IsEnum) return;
        foreach (object prior in seen)
            if (object.ReferenceEquals(prior, obj))
                return;
        seen.Add(obj);

        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            if (field.FieldType == textureType)
            {
                if (field.GetValue(obj) == null)
                    field.SetValue(obj, dummyTexture);
            }
            else if (field.FieldType.IsArray && field.FieldType.GetElementType() == textureType)
            {
                if (field.GetValue(obj) == null)
                    field.SetValue(obj, Array.CreateInstance(textureType, 0));
            }
            else if (field.FieldType.IsArray && field.FieldType.GetElementType().Assembly == asm)
            {
                if (field.GetValue(obj) == null)
                    field.SetValue(obj, Array.CreateInstance(field.FieldType.GetElementType(), 0));
            }
            else if (!field.FieldType.IsValueType && field.FieldType.Assembly == asm)
            {
                object child = field.GetValue(obj);
                if (child == null && !field.FieldType.IsAbstract)
                {
                    try
                    {
                        child = Activator.CreateInstance(field.FieldType);
                    }
                    catch
                    {
                        child = FormatterServices.GetUninitializedObject(field.FieldType);
                    }
                    field.SetValue(obj, child);
                }
                FillNullAssets(child, textureType, dummyTexture, seen);
            }
        }
    }

    static void InvokeStaticByName(string typeName, string nameFragment)
    {
        Type type = asm.GetType(typeName, true);
        foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static))
        {
            if (method.Name.IndexOf(nameFragment, StringComparison.Ordinal) >= 0)
            {
                method.Invoke(null, null);
                return;
            }
        }
        throw new Exception("Method not found: " + typeName + " / " + nameFragment);
    }

    static void DumpTools(string path)
    {
        Type toolType = asm.GetType("ToolType", true);
        List<object> tools = StaticInstances(toolType);
        tools.Sort((a, b) => IntField(a, "#=qTTksYjEee69Pcr1D4U0bHQ==").CompareTo(IntField(b, "#=qTTksYjEee69Pcr1D4U0bHQ==")));

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("id\tname\twidth\theight\tports\tplaceable\tpseudo\tflippable\talternate_sprite");
        foreach (object tool in tools)
        {
            int id = IntField(tool, "#=qTTksYjEee69Pcr1D4U0bHQ==");
            string name = Text(Field(tool, "#=q9RCprYw3GjX7Mn4eMrER8g=="));
            object size = Field(tool, "#=qxlghEOn8SNsprdhZjOfoLg==");
            string ports = Ports((Array)Field(tool, "#=q9aK36D1jI7y6_LwMvdWriQ=="));
            bool placeable = BoolField(tool, "#=qMPKUi1A_sNr6Ua5YmFclVO9I$7cCy57UxxTzZTV_n$Y=");
            bool pseudo = BoolField(tool, "#=qpYhfguy8tWFUDUVdCGCX5A==");
            bool flippable = BoolField(tool, "#=qWdPQYcbnzRbUtvKYa6jcgg==");
            bool alt = BoolField(tool, "#=q6WeZ2FmqRJHY7cxiWcbUyQ==");
            sb.AppendLine(Tsv(id, name, X(size), Y(size), ports, placeable, pseudo, flippable, alt));
        }
        File.WriteAllText(path, sb.ToString());
    }

    static void DumpLevels(string path)
    {
        Type puzzleType = asm.GetType("Puzzle", true);
        List<object> puzzles = StaticInstances(puzzleType);
        puzzles.Sort((a, b) => IntField(a, "#=qTTksYjEee69Pcr1D4U0bHQ==").CompareTo(IntField(b, "#=qTTksYjEee69Pcr1D4U0bHQ==")));

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("id\tlocation\ttitle\tunlock_value\tavailable_tools\taux_tools\tobjectives\tbriefing\tmeditation");
        foreach (object puzzle in puzzles)
        {
            int id = IntField(puzzle, "#=qTTksYjEee69Pcr1D4U0bHQ==");
            string location = Text(Field(puzzle, "#=q01FISqA19rc_ByG2EREhJw=="));
            string title = Text(Field(puzzle, "#=qACkjcMy25VrkMXfLODVIrw=="));
            string briefing = Text(Field(puzzle, "#=qKt_Jz_YP0oYw1geJCoySeQ=="));
            string meditation = Text(Field(puzzle, "#=q93HBdVuk2JuuWbsB3VD9Cg=="));
            int unlock = IntField(puzzle, "#=q582dTCx6klS9JdX$i3YWDA==");
            string objectives = TextArray((Array)Field(puzzle, "#=qtCT0e0Qdn6MbbjMphn_KAw=="));
            string available = ToolArray((Array)Field(puzzle, "#=q$$v4OS5GH6ieTkKlQFdQKA=="));
            string aux = ToolArray((Array)Field(puzzle, "#=qeNXlPBUDRKq13nkfZUBhsg=="));
            sb.AppendLine(Tsv(id, location, title, unlock, available, aux, objectives, briefing, meditation));
        }
        File.WriteAllText(path, sb.ToString());
    }

    static void DumpSignals(string path)
    {
        Type puzzleType = asm.GetType("Puzzle", true);
        List<object> puzzles = StaticInstances(puzzleType);
        puzzles.Sort((a, b) => IntField(a, "#=qTTksYjEee69Pcr1D4U0bHQ==").CompareTo(IntField(b, "#=qTTksYjEee69Pcr1D4U0bHQ==")));

        StringBuilder sb = new StringBuilder();
        sb.AppendLine("level_id\tlevel_title\tkind\tdirection\trow\tname\tsequence\thighlighted\tflag");
        foreach (object puzzle in puzzles)
        {
            int id = IntField(puzzle, "#=qTTksYjEee69Pcr1D4U0bHQ==");
            string title = Text(Field(puzzle, "#=qACkjcMy25VrkMXfLODVIrw=="));
            IEnumerable signals = (IEnumerable)Field(puzzle, "#=qkrP8n4Zmn2O91NoSRPoAvQ==");
            foreach (object signal in signals)
            {
                string name = Plain(Field(signal, "#=qLdNlz2n$NjncKD3NEDYlHg=="));
                string kind = Field(signal, "#=qdpdWBZew48Xcw7vSseWw_Q==").ToString();
                string direction = Field(signal, "#=qtk6F7s2ZLJZnx1voWcVmxQ==").ToString();
                int row = IntField(signal, "#=qtU8cwQsmhnnMiLxqFWWtZw==");
                Array colors = (Array)Field(signal, "#=qmNR1CUyYCDC3ZRMT5HfkVQ==");
                bool highlighted = BoolField(signal, "#=q82BJ1GIYUy0wrUImGNOm7w==");
                bool flag = BoolField(signal, "#=qcTMtpYk1o8PUTJ99c3zrLQ==");
                sb.AppendLine(Tsv(id, title, kind, direction, row, name, Sequence(colors, kind, direction), highlighted, flag));
            }
        }
        File.WriteAllText(path, sb.ToString());
    }

    static List<object> StaticInstances(Type type)
    {
        List<object> list = new List<object>();
        HashSet<object> seen = new HashSet<object>();
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Static))
        {
            if (field.FieldType == type)
            {
                object value = field.GetValue(null);
                if (value != null && seen.Add(value))
                    list.Add(value);
            }
        }
        return list;
    }

    static object Field(object obj, string name)
    {
        FieldInfo field = obj.GetType().GetField(name, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
        if (field == null) throw new Exception("Missing field: " + obj.GetType().FullName + "." + name);
        return field.GetValue(obj);
    }

    static int IntField(object obj, string name)
    {
        return (int)Field(obj, name);
    }

    static bool BoolField(object obj, string name)
    {
        return (bool)Field(obj, name);
    }

    static int X(object index)
    {
        return (int)index.GetType().GetField("X").GetValue(index);
    }

    static int Y(object index)
    {
        return (int)index.GetType().GetField("Y").GetValue(index);
    }

    static string Text(object localized)
    {
        if (localized == null) return "";
        return localized.ToString();
    }

    static string Plain(object localized)
    {
        if (localized == null) return "";
        MethodInfo method = localized.GetType().GetMethod("#=qusAj4OUHIbQ_SwVSVrDP3HdmCyRZTlDERCZI8lVkBKI=", BindingFlags.Public | BindingFlags.Instance);
        return method == null ? localized.ToString() : (string)method.Invoke(localized, null);
    }

    static string TextArray(Array values)
    {
        if (values == null) return "";
        List<string> parts = new List<string>();
        foreach (object value in values)
            parts.Add(Text(value).Replace("\r", " ").Replace("\n", " "));
        return string.Join(" || ", parts.ToArray());
    }

    static string ToolArray(Array values)
    {
        if (values == null) return "";
        List<string> parts = new List<string>();
        foreach (object value in values)
        {
            if (value == null) continue;
            parts.Add(IntField(value, "#=qTTksYjEee69Pcr1D4U0bHQ==") + ":" + Text(Field(value, "#=q9RCprYw3GjX7Mn4eMrER8g==")));
        }
        return string.Join(", ", parts.ToArray());
    }

    static string Ports(Array ports)
    {
        if (ports == null) return "";
        List<string> parts = new List<string>();
        foreach (object port in ports)
        {
            string direction = Field(port, "#=q80UN4139NTrMV3hZWns45w==").ToString();
            int lane = IntField(port, "#=qrX0fhJ3$p2ngldkFpOb5KQ==");
            parts.Add(direction + lane);
        }
        return string.Join(",", parts.ToArray());
    }

    static string Sequence(Array colors, string kind, string direction)
    {
        if (colors == null) return "";
        StringBuilder sb = new StringBuilder();
        foreach (object color in colors)
        {
            string c = color.ToString();
            if (kind == "Matrix")
                sb.Append(c == "None" ? '.' : '1');
            else
                sb.Append(c == "Green" ? 'G' : c == "Red" ? 'R' : c == "Yellow" ? 'Y' : '.');
        }
        return sb.ToString();
    }

    static string Tsv(params object[] values)
    {
        string[] cells = new string[values.Length];
        for (int i = 0; i < values.Length; i++)
        {
            string text = values[i] == null ? "" : values[i].ToString();
            text = text.Replace("\t", " ").Replace("\r", " ").Replace("\n", " ");
            cells[i] = text;
        }
        return string.Join("\t", cells);
    }
}
