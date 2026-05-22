using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct Index2(int x, int y) : IEquatable<Index2>, IComparable<Index2>
{
	private sealed class _0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D : IEnumerator<Index2>, IEnumerable<Index2>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0023_003DqZ3_0024Nzunq00EG0hKA0lB8OA_003D_003D;

		private Index2 _0023_003DqaxAGadQV4s3QNWua_a92vQ_003D_003D;

		private int _0023_003Dq1dvtLa0WCtjSTjgdzZCasusNIXSYZ7uJoxz4ABkO_qw_003D;

		public Index2 _0023_003DqEPmA3sVnpkW5IpPYhjGWqA_003D_003D;

		public Index2 _0023_003DqYL4zR5rI_0024xYXOkbH5aJd8Q_003D_003D;

		private Index2[] _0023_003DqF1H_sMaU_UUo3IDBqC7FHA_003D_003D;

		private int _0023_003Dqr2VLnawW_0024v_0024alKR_UTEN6w_003D_003D;

		[DebuggerHidden]
		public _0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D(int _0023_003DqANWMgXdihT4IKtlftnTuSw_003D_003D)
		{
			_0023_003DqZ3_0024Nzunq00EG0hKA0lB8OA_003D_003D = _0023_003DqANWMgXdihT4IKtlftnTuSw_003D_003D;
			_0023_003Dq1dvtLa0WCtjSTjgdzZCasusNIXSYZ7uJoxz4ABkO_qw_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003DqCbOYX020BORhEEyPgERhaC9iNMuMO2NwxZt3dpGO3ck_003D()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qCbOYX020BORhEEyPgERhaC9iNMuMO2NwxZt3dpGO3ck=
			this._0023_003DqCbOYX020BORhEEyPgERhaC9iNMuMO2NwxZt3dpGO3ck_003D();
		}

		private bool MoveNext()
		{
			switch (_0023_003DqZ3_0024Nzunq00EG0hKA0lB8OA_003D_003D)
			{
			default:
				return false;
			case 0:
				_0023_003DqZ3_0024Nzunq00EG0hKA0lB8OA_003D_003D = -1;
				_0023_003DqF1H_sMaU_UUo3IDBqC7FHA_003D_003D = AdjacentOffsets;
				_0023_003Dqr2VLnawW_0024v_0024alKR_UTEN6w_003D_003D = 0;
				break;
			case 1:
				_0023_003DqZ3_0024Nzunq00EG0hKA0lB8OA_003D_003D = -1;
				_0023_003Dqr2VLnawW_0024v_0024alKR_UTEN6w_003D_003D++;
				break;
			}
			if (_0023_003Dqr2VLnawW_0024v_0024alKR_UTEN6w_003D_003D < _0023_003DqF1H_sMaU_UUo3IDBqC7FHA_003D_003D.Length)
			{
				Index2 index = _0023_003DqF1H_sMaU_UUo3IDBqC7FHA_003D_003D[_0023_003Dqr2VLnawW_0024v_0024alKR_UTEN6w_003D_003D];
				_0023_003DqaxAGadQV4s3QNWua_a92vQ_003D_003D = _0023_003DqEPmA3sVnpkW5IpPYhjGWqA_003D_003D + index;
				_0023_003DqZ3_0024Nzunq00EG0hKA0lB8OA_003D_003D = 1;
				return true;
			}
			_0023_003DqF1H_sMaU_UUo3IDBqC7FHA_003D_003D = null;
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private Index2 _0023_003DqxPiIV2EgUKGq6QJZK_2C0PPEU95oCHW4ZM3MvJxvw78frHk3cV2zlqX2qN3sef6u2QZRFWJVDS8gJILejMgwxA_003D_003D()
		{
			return _0023_003DqaxAGadQV4s3QNWua_a92vQ_003D_003D;
		}

		Index2 IEnumerator<Index2>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qxPiIV2EgUKGq6QJZK_2C0PPEU95oCHW4ZM3MvJxvw78frHk3cV2zlqX2qN3sef6u2QZRFWJVDS8gJILejMgwxA==
			return this._0023_003DqxPiIV2EgUKGq6QJZK_2C0PPEU95oCHW4ZM3MvJxvw78frHk3cV2zlqX2qN3sef6u2QZRFWJVDS8gJILejMgwxA_003D_003D();
		}

		[DebuggerHidden]
		private void _0023_003Dq9WdPiQKMyN8KtiIYGQWllqLyqNGoPGLyzqCVe54EjmH2Z6EQQDMGIOBGiqVjLNaH()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q9WdPiQKMyN8KtiIYGQWllqLyqNGoPGLyzqCVe54EjmH2Z6EQQDMGIOBGiqVjLNaH
			this._0023_003Dq9WdPiQKMyN8KtiIYGQWllqLyqNGoPGLyzqCVe54EjmH2Z6EQQDMGIOBGiqVjLNaH();
		}

		[DebuggerHidden]
		private object _0023_003Dq_VaRX2mhFN9LDnS4VP3LPAm6mVQxx56X3lDJ_0024xYakp8aNfK9tdVIf60qMVgTaaMA()
		{
			return _0023_003DqaxAGadQV4s3QNWua_a92vQ_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q_VaRX2mhFN9LDnS4VP3LPAm6mVQxx56X3lDJ$xYakp8aNfK9tdVIf60qMVgTaaMA
			return this._0023_003Dq_VaRX2mhFN9LDnS4VP3LPAm6mVQxx56X3lDJ_0024xYakp8aNfK9tdVIf60qMVgTaaMA();
		}

		[DebuggerHidden]
		private IEnumerator<Index2> _0023_003DqW_0024fAu0832BYkxRrkvDRGXK_0024ImSgD6pym7PGJo0TWv5JN5KeQSwhxjJ93X64RKk2o_1BqPCyL48NZRiDHd1rFIw_003D_003D()
		{
			_0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D _0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D2;
			if (_0023_003DqZ3_0024Nzunq00EG0hKA0lB8OA_003D_003D == -2 && _0023_003Dq1dvtLa0WCtjSTjgdzZCasusNIXSYZ7uJoxz4ABkO_qw_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003DqZ3_0024Nzunq00EG0hKA0lB8OA_003D_003D = 0;
				_0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D2 = this;
			}
			else
			{
				_0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D2 = new _0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D(0);
			}
			_0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D2._0023_003DqEPmA3sVnpkW5IpPYhjGWqA_003D_003D = _0023_003DqYL4zR5rI_0024xYXOkbH5aJd8Q_003D_003D;
			return _0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D2;
		}

		IEnumerator<Index2> IEnumerable<Index2>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qW$fAu0832BYkxRrkvDRGXK$ImSgD6pym7PGJo0TWv5JN5KeQSwhxjJ93X64RKk2o_1BqPCyL48NZRiDHd1rFIw==
			return this._0023_003DqW_0024fAu0832BYkxRrkvDRGXK_0024ImSgD6pym7PGJo0TWv5JN5KeQSwhxjJ93X64RKk2o_1BqPCyL48NZRiDHd1rFIw_003D_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003DqoQGmWHk3m8mKAUiZBHu665rDJyg7Bg5zxV2k7bvbsXDZluv0_0024lroUxY_WQAcay3E()
		{
			return _0023_003DqW_0024fAu0832BYkxRrkvDRGXK_0024ImSgD6pym7PGJo0TWv5JN5KeQSwhxjJ93X64RKk2o_1BqPCyL48NZRiDHd1rFIw_003D_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qoQGmWHk3m8mKAUiZBHu665rDJyg7Bg5zxV2k7bvbsXDZluv0$lroUxY_WQAcay3E
			return this._0023_003DqoQGmWHk3m8mKAUiZBHu665rDJyg7Bg5zxV2k7bvbsXDZluv0_0024lroUxY_WQAcay3E();
		}
	}

	public int X = x;

	public int Y = y;

	public static readonly Index2 Zero = new Index2(0, 0);

	public static readonly Index2 MinValue = new Index2(int.MinValue, int.MinValue);

	public static readonly Index2 MaxValue = new Index2(int.MaxValue, int.MaxValue);

	public static readonly Index2 Right = new Index2(1, 0);

	public static readonly Index2 Up = new Index2(0, 1);

	public static readonly Index2 Left = new Index2(-1, 0);

	public static readonly Index2 Down = new Index2(0, -1);

	public static readonly Index2[] AdjacentOffsets = new Index2[4]
	{
		new Index2(1, 0),
		new Index2(0, 1),
		new Index2(-1, 0),
		new Index2(0, -1)
	};

	public override string ToString()
	{
		return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777023), X, Y);
	}

	public Vector2 ToVector2()
	{
		return new Vector2(X, Y);
	}

	public Vector3 ToVector3(float z)
	{
		return new Vector3(X, Y, z);
	}

	public bool IsLargerThan(Index2 other)
	{
		if (X <= other.X)
		{
			return Y > other.Y;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		Index2? index = obj as Index2?;
		if (!index.HasValue)
		{
			return false;
		}
		Index2 value = this;
		Index2? index2 = index;
		return value == index2;
	}

	public override int GetHashCode()
	{
		return (391 + X.GetHashCode()) * 23 + Y.GetHashCode();
	}

	public static bool operator ==(Index2 a, Index2 b)
	{
		if (a.X == b.X)
		{
			return a.Y == b.Y;
		}
		return false;
	}

	public static bool operator !=(Index2 a, Index2 b)
	{
		if (a.X == b.X)
		{
			return a.Y != b.Y;
		}
		return true;
	}

	public static Index2 operator -(Index2 a)
	{
		return new Index2(-a.X, -a.Y);
	}

	public static Index2 operator +(Index2 a, Index2 b)
	{
		return new Index2(a.X + b.X, a.Y + b.Y);
	}

	public static Index2 operator -(Index2 a, Index2 b)
	{
		return new Index2(a.X - b.X, a.Y - b.Y);
	}

	public static Index2 operator *(int s, Index2 a)
	{
		return new Index2(s * a.X, s * a.Y);
	}

	public static Index2 operator *(Index2 a, int s)
	{
		return new Index2(s * a.X, s * a.Y);
	}

	public static Index2 operator *(Index2 a, Index2 b)
	{
		return new Index2(a.X * b.X, a.Y * b.Y);
	}

	public static Index2 operator /(Index2 a, int s)
	{
		return new Index2(a.X / s, a.Y / s);
	}

	public static int MaxDistance(Index2 a, Index2 b)
	{
		return Math.Max(Math.Abs(a.X - b.X), Math.Abs(a.Y - b.Y));
	}

	public static int ManhattanDistance(Index2 a, Index2 b)
	{
		return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
	}

	public int ManhattanLength()
	{
		return Math.Abs(X) + Math.Abs(Y);
	}

	public bool Equals(Index2 other)
	{
		return this == other;
	}

	public int CompareTo(Index2 other)
	{
		if (Y < other.Y)
		{
			return -1;
		}
		if (Y > other.Y)
		{
			return 1;
		}
		if (X < other.X)
		{
			return -1;
		}
		if (X > other.X)
		{
			return 1;
		}
		return 0;
	}

	public static Index2 Min(Index2 a, Index2 b)
	{
		return new Index2(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y));
	}

	public static Index2 Max(Index2 a, Index2 b)
	{
		return new Index2(Math.Max(a.X, b.X), Math.Max(a.Y, b.Y));
	}

	public Index2 Clamped(int limit)
	{
		return new Index2(Utility._0023_003DqPketCwwzMXFnMETn36UPyQ_003D_003D(X, -limit, limit), Utility._0023_003DqPketCwwzMXFnMETn36UPyQ_003D_003D(Y, -limit, limit));
	}

	public Index2 Rotated(QuarterRotations rotation)
	{
		return rotation.Turns switch
		{
			0 => new Index2(X, Y), 
			1 => new Index2(-Y, X), 
			2 => new Index2(-X, -Y), 
			3 => new Index2(Y, -X), 
			_ => throw new ArgumentOutOfRangeException(), 
		};
	}

	public Index2 GuessDirection()
	{
		if (X > 0)
		{
			return new Index2(1, 0);
		}
		if (Y > 0)
		{
			return new Index2(0, 1);
		}
		if (X < 0)
		{
			return new Index2(-1, 0);
		}
		return new Index2(0, -1);
	}

	public QuarterRotations GuessRotation()
	{
		if (X > 0)
		{
			return QuarterRotations.Rotate0;
		}
		if (Y > 0)
		{
			return QuarterRotations.Rotate90;
		}
		if (X < 0)
		{
			return QuarterRotations.Rotate180;
		}
		return QuarterRotations.Rotate270;
	}

	public Index2 RotatedAround(Index2 pivot, QuarterRotations rotation)
	{
		return (this - pivot).Rotated(rotation) + pivot;
	}

	[IteratorStateMachine(typeof(_0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D))]
	public IEnumerable<Index2> Neighbors()
	{
		return new _0023_003DqrXrm_SvJLD1T8KSA7LW7LV7pDLvisjH9At4aSPDY6j0_003D(-2)
		{
			_0023_003DqYL4zR5rI_0024xYXOkbH5aJd8Q_003D_003D = this
		};
	}

	public Range2 ToRange()
	{
		return new Range2(this, this + new Index2(1, 1));
	}
}
