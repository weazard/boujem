using System;
using System.Collections.Generic;
using System.Linq;

public struct Bounds2
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Bounds2, Bounds2, Bounds2> _003C_003E9__55_0;

		internal Bounds2 _0023_003DqewNe34UegkmkwMG6caoCO_NB8PPu97_ol5HIiorE2bk_003D(Bounds2 _0023_003Dqok0zXujYfDN3iyERUaMJXA_003D_003D, Bounds2 _0023_003Dqn9fDbIH7Diw8XSK1t4aC0A_003D_003D)
		{
			return _0023_003Dqok0zXujYfDN3iyERUaMJXA_003D_003D.UnionedWith(_0023_003Dqn9fDbIH7Diw8XSK1t4aC0A_003D_003D);
		}
	}

	public Vector2 Min;

	public Vector2 Max;

	public static readonly Bounds2 Empty = WithCorners(Vector2.Zero, Vector2.Zero);

	public static readonly Bounds2 Undefined = WithCorners(float.PositiveInfinity, float.PositiveInfinity, float.NegativeInfinity, float.NegativeInfinity);

	public Vector2 Size => Max - Min;

	public float Width => Max.X - Min.X;

	public float Height => Max.Y - Min.Y;

	public float Left => Min.X;

	public float Right => Max.X;

	public float Bottom => Min.Y;

	public float Top => Max.Y;

	public Vector2 Center => Min + 0.5f * (Max - Min);

	public Vector2 BottomLeft => Min;

	public Vector2 BottomCenter => new Vector2(Min.X + 0.5f * (Max.X - Min.X), Min.Y);

	public Vector2 BottomRight => new Vector2(Max.X, Min.Y);

	public Vector2 TopLeft => new Vector2(Min.X, Max.Y);

	public Vector2 TopCenter => new Vector2(Min.X + 0.5f * (Max.X - Min.X), Max.Y);

	public Vector2 TopRight => Max;

	public Vector2 LeftCenter => new Vector2(Min.X, Min.Y + 0.5f * (Max.Y - Min.Y));

	public Vector2 RightCenter => new Vector2(Max.X, Min.Y + 0.5f * (Max.Y - Min.Y));

	public bool IsEmpty
	{
		get
		{
			if (!(Min.X >= Max.X))
			{
				return Min.Y >= Max.Y;
			}
			return true;
		}
	}

	public static Bounds2 WithCorners(Vector2 a, Vector2 b)
	{
		return new Bounds2
		{
			Min = new Vector2(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y)),
			Max = new Vector2(Math.Max(a.X, b.X), Math.Max(a.Y, b.Y))
		};
	}

	public static Bounds2 WithCorners(float minX, float minY, float maxX, float maxY)
	{
		return new Bounds2
		{
			Min = new Vector2(minX, minY),
			Max = new Vector2(maxX, maxY)
		};
	}

	public static Bounds2 WithSize(float x, float y, float width, float height)
	{
		return new Bounds2
		{
			Min = new Vector2(x, y),
			Max = new Vector2(x + width, y + height)
		};
	}

	public static Bounds2 WithSize(Vector2 position, Vector2 size)
	{
		return WithSize(position.X, position.Y, size.X, size.Y);
	}

	public Bounds2 WithPosition(Vector2 position)
	{
		return WithSize(position, Size);
	}

	public Bounds2 WithSize(Vector2 size)
	{
		return WithSize(Min, size);
	}

	public Bounds2 Normalized()
	{
		return WithCorners(Math.Min(Min.X, Max.X), Math.Min(Min.Y, Max.Y), Math.Max(Min.X, Max.X), Math.Max(Min.Y, Max.Y));
	}

	public override string ToString()
	{
		return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065774616), new object[4] { Min.X, Min.Y, Width, Height });
	}

	public Vector2 GetPositionForCentering(Vector2 innerSize)
	{
		return (Min + 0.5f * (Size - innerSize)).Rounded();
	}

	public Bounds2 Expanded(Vector2 amount)
	{
		return new Bounds2
		{
			Min = Min - amount,
			Max = Max + amount
		};
	}

	public Bounds2 Expanded(float amount)
	{
		return Expanded(new Vector2(amount, amount));
	}

	public Bounds2 Expanded(float dx, float dy)
	{
		return Expanded(new Vector2(dx, dy));
	}

	public Bounds2 Expanded(float left, float right, float bottom, float top)
	{
		return new Bounds2
		{
			Min = new Vector2(Min.X - left, Min.Y - bottom),
			Max = new Vector2(Max.X + right, Max.Y + top)
		};
	}

	public Bounds2 UnionedWith(Vector2 point)
	{
		return new Bounds2
		{
			Min = new Vector2(Math.Min(Min.X, point.X), Math.Min(Min.Y, point.Y)),
			Max = new Vector2(Math.Max(Max.X, point.X), Math.Max(Max.Y, point.Y))
		};
	}

	public Bounds2 UnionedWith(float x, float y)
	{
		return UnionedWith(new Vector2(x, y));
	}

	public Bounds2 UnionedWith(Vector2 position, Vector2 size)
	{
		return UnionedWith(position).UnionedWith(position + size);
	}

	public Bounds2 UnionedWith(Bounds2 other)
	{
		if (IsEmpty)
		{
			return other;
		}
		return UnionedWith(other.Min).UnionedWith(other.Max);
	}

	public static Bounds2 UnionAll(IEnumerable<Bounds2> allBounds)
	{
		return allBounds.Aggregate(Empty, _003C_003Ec._003C_003E9._0023_003DqewNe34UegkmkwMG6caoCO_NB8PPu97_ol5HIiorE2bk_003D);
	}

	public Bounds2 IntersectedWith(Bounds2 other)
	{
		float num = Math.Max(Min.X, other.Min.X);
		float num2 = Math.Max(Min.Y, other.Min.Y);
		float num3 = Math.Min(Max.X, other.Max.X);
		float num4 = Math.Min(Max.Y, other.Max.Y);
		if (num >= num3 || num2 >= num4)
		{
			return Empty;
		}
		return new Bounds2
		{
			Min = new Vector2(num, num2),
			Max = new Vector2(num3, num4)
		};
	}

	public bool Contains(Vector2 point)
	{
		if (Min.X <= point.X && point.X <= Max.X && Min.Y <= point.Y)
		{
			return point.Y <= Max.Y;
		}
		return false;
	}

	public bool Contains(Bounds2 bounds)
	{
		if (Contains(bounds.Min))
		{
			return Contains(bounds.Max);
		}
		return false;
	}

	public bool Overlaps(Bounds2 bounds)
	{
		if (!(bounds.Max.X < Min.X) && !(bounds.Min.X > Max.X) && !(bounds.Max.Y < Min.Y))
		{
			return !(bounds.Min.Y > Max.Y);
		}
		return false;
	}

	public Bounds2 Translated(float dx, float dy)
	{
		return Translated(new Vector2(dx, dy));
	}

	public Bounds2 Translated(Vector2 offset)
	{
		return new Bounds2
		{
			Min = Min + offset,
			Max = Max + offset
		};
	}

	public Vector2 GetEdgePosition(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D edge)
	{
		return edge switch
		{
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)0 => new Vector2(Min.X, Max.Y), 
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)1 => new Vector2((Min.X + Max.X) / 2f, Max.Y), 
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)2 => new Vector2(Max.X, Max.Y), 
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)3 => new Vector2(Min.X, (Min.Y + Max.Y) / 2f), 
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)4 => new Vector2((Min.X + Max.X) / 2f, (Min.Y + Max.Y) / 2f), 
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)5 => new Vector2(Max.X, (Min.Y + Max.Y) / 2f), 
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)6 => new Vector2(Min.X, Min.Y), 
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)7 => new Vector2((Min.X + Max.X) / 2f, Min.Y), 
			(_0023_003DquOuF1xxiAy4SGKuOTmyoqw_003D_003D)8 => new Vector2(Max.X, Min.Y), 
			_ => throw new _0023_003DqP1Lvlriw8JdzHp67vrhOBYFwzXCcBrFvFv_m_d2KdZA_003D(), 
		};
	}

	public Bounds2 GetCenteredSubregion(float width, float height)
	{
		return WithSize(Left + 0.5f * (Width - width), Bottom + 0.5f * (Height - height), width, height).Rounded();
	}

	public Bounds2 GetCenteredSubregion(Vector2 size)
	{
		return GetCenteredSubregion(size.X, size.Y);
	}

	public Bounds2 RoundedToEven()
	{
		return WithSize(Min.RoundedToEven(), Size.RoundedToEven());
	}

	public Bounds2 Rounded()
	{
		return WithSize(Min.Rounded(), Size.Rounded());
	}

	public Bounds2 MirroredX(float axis)
	{
		Min.X = axis - Min.X;
		Max.X = axis - Max.X;
		return this;
	}

	public Bounds2 MirroredY(float axis)
	{
		Min.Y = axis - Min.Y;
		Max.Y = axis - Max.Y;
		return this;
	}

	public Bounds2 FitWithin(Bounds2 region, float margin)
	{
		region = region.Expanded(0f - margin);
		Bounds2 result = this;
		if (result.Left < region.Left)
		{
			result = result.Translated(region.Left - result.Left, 0f);
		}
		if (result.Bottom < region.Bottom)
		{
			result = result.Translated(0f, region.Bottom - result.Bottom);
		}
		if (result.Right > region.Right)
		{
			result = result.Translated(region.Right - result.Right, 0f);
		}
		if (result.Top > region.Top)
		{
			result = result.Translated(0f, region.Top - result.Top);
		}
		return result;
	}
}
