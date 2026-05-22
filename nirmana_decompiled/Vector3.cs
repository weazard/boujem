using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct Vector3(float x, float y, float z)
{
	public float X = x;

	public float Y = y;

	public float Z = z;

	public static Vector3 Zero = new Vector3(0f, 0f, 0f);

	public Vector2 XY => new Vector2(X, Y);

	public override string ToString()
	{
		return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757096), X, Y, Z);
	}

	public float Length()
	{
		return (float)Math.Sqrt(X * X + Y * Y + Z * Z);
	}

	public float LengthSquared()
	{
		return X * X + Y * Y + Z * Z;
	}

	public Vector3 Normalized()
	{
		float num = Length();
		if (num == 0f)
		{
			return this;
		}
		return this * (1f / num);
	}

	public Vector3 ScaledToLength(float newLength)
	{
		float num = Length();
		return newLength / num * this;
	}

	public Vector3 ClampedToLength(float limit)
	{
		Vector3 result = this;
		if (Length() > limit)
		{
			result = ScaledToLength(limit);
		}
		return result;
	}

	public Vector3 Rounded()
	{
		return new Vector3((float)Math.Round(X, MidpointRounding.AwayFromZero), (float)Math.Round(Y, MidpointRounding.AwayFromZero), (float)Math.Round(Z, MidpointRounding.AwayFromZero));
	}

	public Vector3 Floored()
	{
		return new Vector3((float)Math.Floor(X), (float)Math.Floor(Y), (float)Math.Floor(Z));
	}

	public Vector3 FlooredToEven()
	{
		return new Vector3((float)Math.Floor(X / 2f) * 2f, (float)Math.Floor(Y / 2f) * 2f, (float)Math.Floor(Z / 2f) * 2f);
	}

	public Vector3 RotatedX(float radians)
	{
		float num = (float)Math.Sin(radians);
		float num2 = (float)Math.Cos(radians);
		return new Vector3(X, Y * num2 + (0f - Z) * num, Z * num2 + Y * num);
	}

	public Vector3 RotatedY(float radians)
	{
		float num = (float)Math.Sin(radians);
		float num2 = (float)Math.Cos(radians);
		return new Vector3(X * num2 + Z * num, Y, Z * num2 + (0f - X) * num);
	}

	public Vector3 RotatedZ(float radians)
	{
		float num = (float)Math.Sin(radians);
		float num2 = (float)Math.Cos(radians);
		return new Vector3(X * num2 + (0f - Y) * num, Y * num2 + X * num, Z);
	}

	public static float Distance(Vector3 a, Vector3 b)
	{
		return (a - b).Length();
	}

	public static float Dot(Vector3 a, Vector3 b)
	{
		return a.X * b.X + a.Y * b.Y;
	}

	public static Vector3 Cross(Vector3 a, Vector3 b)
	{
		return new Vector3(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
	}

	public static Vector3 operator -(Vector3 a)
	{
		return new Vector3(0f - a.X, 0f - a.Y, 0f - a.Z);
	}

	public static Vector3 operator +(Vector3 a, Vector3 b)
	{
		return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
	}

	public static Vector3 operator -(Vector3 a, Vector3 b)
	{
		return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
	}

	public static Vector3 operator *(float s, Vector3 v)
	{
		return new Vector3(s * v.X, s * v.Y, s * v.Z);
	}

	public static Vector3 operator *(Vector3 v, float s)
	{
		return new Vector3(s * v.X, s * v.Y, s * v.Z);
	}

	public static Vector3 operator *(Vector3 a, Vector3 b)
	{
		return new Vector3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
	}
}
