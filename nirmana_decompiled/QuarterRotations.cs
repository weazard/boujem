using System;

public struct QuarterRotations(int turns) : IEquatable<QuarterRotations>
{
	public readonly int Turns = Utility._0023_003DqmDpSVbUIGdNI6cWqJJ_0024w3Q_003D_003D(turns, 4);

	public static readonly QuarterRotations Rotate0 = new QuarterRotations(0);

	public static readonly QuarterRotations Rotate90 = new QuarterRotations(1);

	public static readonly QuarterRotations Rotate180 = new QuarterRotations(2);

	public static readonly QuarterRotations Rotate270 = new QuarterRotations(3);

	private static readonly string[] Representations = new string[4]
	{
		_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811356),
		_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811347),
		_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811365),
		_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811386)
	};

	public bool IsZero => Turns == 0;

	public override string ToString()
	{
		return Representations[Turns];
	}

	public override int GetHashCode()
	{
		int turns = Turns;
		return turns.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj is QuarterRotations other)
		{
			return Equals(other);
		}
		return false;
	}

	public bool Equals(QuarterRotations other)
	{
		return Turns == other.Turns;
	}

	public static bool operator ==(QuarterRotations a, QuarterRotations b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(QuarterRotations a, QuarterRotations b)
	{
		return !a.Equals(b);
	}

	public float ToRadians()
	{
		return (float)(Turns * 90) * ((float)Math.PI / 180f);
	}

	public QuarterRotations Opposite()
	{
		return new QuarterRotations(Turns + 2);
	}

	public QuarterRotations RotatedCounterclockwise()
	{
		return new QuarterRotations(Turns + 1);
	}

	public QuarterRotations RotatedClockwise()
	{
		return new QuarterRotations(Turns - 1);
	}

	public static QuarterRotations operator +(QuarterRotations a, QuarterRotations b)
	{
		return new QuarterRotations(a.Turns + b.Turns);
	}

	public static QuarterRotations operator -(QuarterRotations a, QuarterRotations b)
	{
		return new QuarterRotations(a.Turns - b.Turns);
	}

	public static QuarterRotations Rounded(float radians)
	{
		float num = radians * (180f / (float)Math.PI);
		for (num += 45f; num < 0f; num += 360f)
		{
		}
		num %= 360f;
		return new QuarterRotations((int)Math.Floor(num / 90f));
	}

	public Vector2 AppliedTo(Vector2 v)
	{
		return Utility._0023_003DqmDpSVbUIGdNI6cWqJJ_0024w3Q_003D_003D(Turns, 4) switch
		{
			0 => v, 
			1 => new Vector2(0f - v.Y, v.X), 
			2 => new Vector2(0f - v.X, 0f - v.Y), 
			3 => new Vector2(v.Y, 0f - v.X), 
			_ => throw new _0023_003DqP1Lvlriw8JdzHp67vrhOBYFwzXCcBrFvFv_m_d2KdZA_003D(), 
		};
	}
}
