using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct Color(float r, float g, float b, float a)
{
	public float R = r;

	public float G = g;

	public float B = b;

	public float A = a;

	public static readonly Color White = new Color(1f, 1f, 1f, 1f);

	public static readonly Color Black = new Color(0f, 0f, 0f, 1f);

	public static readonly Color VeryLightGray = new Color(0.9f, 0.9f, 0.9f, 1f);

	public static readonly Color LightGray = new Color(0.75f, 0.75f, 0.75f, 1f);

	public static readonly Color MediumGray = new Color(0.5f, 0.5f, 0.5f, 1f);

	public static readonly Color DarkGray = new Color(0.25f, 0.25f, 0.25f, 1f);

	public static readonly Color Transparent = new Color(0f, 0f, 0f, 0f);

	public static readonly Color Red = new Color(1f, 0f, 0f, 1f);

	public static readonly Color Green = new Color(0f, 1f, 0f, 1f);

	public static readonly Color Blue = new Color(0f, 0f, 1f, 1f);

	public static readonly Color Yellow = new Color(1f, 1f, 0f, 1f);

	public static readonly Color Magenta = new Color(1f, 0f, 1f, 1f);

	public static readonly Color Cyan = new Color(0f, 1f, 1f, 1f);

	public static readonly Color Debug = Magenta.WithAlpha(0.5f);

	public Color WithAlpha(float a)
	{
		return new Color(R, G, B, a);
	}

	public static Color FromHex(int hex)
	{
		return new Color((float)((hex >> 16) & 0xFF) / 255f, (float)((hex >> 8) & 0xFF) / 255f, (float)(hex & 0xFF) / 255f, 1f);
	}

	public static Color Gray(int brightness)
	{
		brightness = Utility._0023_003DqPketCwwzMXFnMETn36UPyQ_003D_003D(brightness, 0, 255);
		float num = (float)brightness / 255f;
		return new Color(num, num, num, 1f);
	}

	public PackedColor Packed()
	{
		return new PackedColor((byte)(255f * R), (byte)(255f * G), (byte)(255f * B), (byte)(255f * A));
	}

	public Color WithPremultipliedAlpha()
	{
		return new Color(R * A, G * A, B * A, A);
	}

	public static Color Lerp(Color a, Color b, float t)
	{
		return new Color(Utility._0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(a.R, b.R, t), Utility._0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(a.G, b.G, t), Utility._0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(a.B, b.B, t), Utility._0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(a.A, b.A, t));
	}

	public static Color operator *(Color a, Color b)
	{
		return new Color(a.R * b.R, a.G * b.G, a.B * b.B, a.A * b.A);
	}

	public override bool Equals(object obj)
	{
		Color? color = obj as Color?;
		if (!color.HasValue)
		{
			return false;
		}
		if (R == color.Value.R && G == color.Value.G && B == color.Value.B)
		{
			return A == color.Value.A;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((391 + R.GetHashCode()) * 23 + G.GetHashCode()) * 23 + B.GetHashCode()) * 23 + A.GetHashCode();
	}

	public static bool operator ==(Color a, Color b)
	{
		if (a.R == b.R && a.G == b.G && a.B == b.B)
		{
			return a.A == b.A;
		}
		return false;
	}

	public static bool operator !=(Color a, Color b)
	{
		if (a.R == b.R && a.G == b.G && a.B == b.B)
		{
			return a.A != b.A;
		}
		return true;
	}
}
