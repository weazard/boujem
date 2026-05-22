using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

public struct Range2 : IEquatable<Range2>
{
	private sealed class _0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D : IEnumerator<Index2>, IEnumerable<Index2>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0023_003DqJph9EmGEyP_GF3vIv2bvMw_003D_003D;

		private Index2 _0023_003DqbodCNqbOyMmE741vORSHOQ_003D_003D;

		private int _0023_003DqyaZk6Zekf97ky6j9cQWFiITxMIK2zvm_0024OxmsWFFqBC8_003D;

		public Range2 _0023_003DqPqX71FyuuG4HWWV60aoidw_003D_003D;

		public Range2 _0023_003DqYGHguaKmFOijvjdwRxwDLg_003D_003D;

		private int _0023_003Dq8GjVjSE_0024XL_0024_0024Z0PT7iuy1Q_003D_003D;

		private int _0023_003DqlYuC_l_0024yjXCHagFn_0024VOdUw_003D_003D;

		[DebuggerHidden]
		public _0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D(int _0023_003DqBH9SaONkW_002411W9hocfqfWg_003D_003D)
		{
			_0023_003DqJph9EmGEyP_GF3vIv2bvMw_003D_003D = _0023_003DqBH9SaONkW_002411W9hocfqfWg_003D_003D;
			_0023_003DqyaZk6Zekf97ky6j9cQWFiITxMIK2zvm_0024OxmsWFFqBC8_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003Dqktfji1rbhbBhIRzvB90iuPTFBYcZhquz2GTJafOQFyI_003D()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qktfji1rbhbBhIRzvB90iuPTFBYcZhquz2GTJafOQFyI=
			this._0023_003Dqktfji1rbhbBhIRzvB90iuPTFBYcZhquz2GTJafOQFyI_003D();
		}

		private bool MoveNext()
		{
			int num = _0023_003DqJph9EmGEyP_GF3vIv2bvMw_003D_003D;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_0023_003DqJph9EmGEyP_GF3vIv2bvMw_003D_003D = -1;
				_0023_003DqlYuC_l_0024yjXCHagFn_0024VOdUw_003D_003D++;
				goto IL_0080;
			}
			_0023_003DqJph9EmGEyP_GF3vIv2bvMw_003D_003D = -1;
			_0023_003Dq8GjVjSE_0024XL_0024_0024Z0PT7iuy1Q_003D_003D = _0023_003DqPqX71FyuuG4HWWV60aoidw_003D_003D.End.Y - 1;
			goto IL_00a8;
			IL_0080:
			if (_0023_003DqlYuC_l_0024yjXCHagFn_0024VOdUw_003D_003D < _0023_003DqPqX71FyuuG4HWWV60aoidw_003D_003D.End.X)
			{
				_0023_003DqbodCNqbOyMmE741vORSHOQ_003D_003D = new Index2(_0023_003DqlYuC_l_0024yjXCHagFn_0024VOdUw_003D_003D, _0023_003Dq8GjVjSE_0024XL_0024_0024Z0PT7iuy1Q_003D_003D);
				_0023_003DqJph9EmGEyP_GF3vIv2bvMw_003D_003D = 1;
				return true;
			}
			_0023_003Dq8GjVjSE_0024XL_0024_0024Z0PT7iuy1Q_003D_003D--;
			goto IL_00a8;
			IL_00a8:
			if (_0023_003Dq8GjVjSE_0024XL_0024_0024Z0PT7iuy1Q_003D_003D >= _0023_003DqPqX71FyuuG4HWWV60aoidw_003D_003D.Start.Y)
			{
				_0023_003DqlYuC_l_0024yjXCHagFn_0024VOdUw_003D_003D = _0023_003DqPqX71FyuuG4HWWV60aoidw_003D_003D.Start.X;
				goto IL_0080;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private Index2 _0023_003DqcTHFsgZY4_OkpbtUzeF9ZrslUwgq2RZbrEh7iI9v00OhvT4StPcsb_ZRGDXb9BQjfpVyoaIqEQsk5A7DxJWnnQ_003D_003D()
		{
			return _0023_003DqbodCNqbOyMmE741vORSHOQ_003D_003D;
		}

		Index2 IEnumerator<Index2>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qcTHFsgZY4_OkpbtUzeF9ZrslUwgq2RZbrEh7iI9v00OhvT4StPcsb_ZRGDXb9BQjfpVyoaIqEQsk5A7DxJWnnQ==
			return this._0023_003DqcTHFsgZY4_OkpbtUzeF9ZrslUwgq2RZbrEh7iI9v00OhvT4StPcsb_ZRGDXb9BQjfpVyoaIqEQsk5A7DxJWnnQ_003D_003D();
		}

		[DebuggerHidden]
		private void _0023_003Dq8jvocoU6azLVbFVVTXYuuR0AThVudhKC92IYiH6hiVGPbj6yhYVUr_L6Ii1aCX6H()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q8jvocoU6azLVbFVVTXYuuR0AThVudhKC92IYiH6hiVGPbj6yhYVUr_L6Ii1aCX6H
			this._0023_003Dq8jvocoU6azLVbFVVTXYuuR0AThVudhKC92IYiH6hiVGPbj6yhYVUr_L6Ii1aCX6H();
		}

		[DebuggerHidden]
		private object _0023_003DqSZ_mb8hO1wajINPhNwc75aaP2LoUMOj5VefZJLfnscY5u2wTsgTZYuGTbzpRL91B()
		{
			return _0023_003DqbodCNqbOyMmE741vORSHOQ_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qSZ_mb8hO1wajINPhNwc75aaP2LoUMOj5VefZJLfnscY5u2wTsgTZYuGTbzpRL91B
			return this._0023_003DqSZ_mb8hO1wajINPhNwc75aaP2LoUMOj5VefZJLfnscY5u2wTsgTZYuGTbzpRL91B();
		}

		[DebuggerHidden]
		private IEnumerator<Index2> _0023_003DqHS7ZlZQsQ0eBi8wEUgiATwwgGR7R7poocifTnum6wyLuc1RJ2NiBv8iuz_0024ZfMSWIfQh5z916gTPtxmKb0bJfZw_003D_003D()
		{
			_0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D _0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D2;
			if (_0023_003DqJph9EmGEyP_GF3vIv2bvMw_003D_003D == -2 && _0023_003DqyaZk6Zekf97ky6j9cQWFiITxMIK2zvm_0024OxmsWFFqBC8_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003DqJph9EmGEyP_GF3vIv2bvMw_003D_003D = 0;
				_0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D2 = this;
			}
			else
			{
				_0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D2 = new _0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D(0);
			}
			_0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D2._0023_003DqPqX71FyuuG4HWWV60aoidw_003D_003D = _0023_003DqYGHguaKmFOijvjdwRxwDLg_003D_003D;
			return _0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D2;
		}

		IEnumerator<Index2> IEnumerable<Index2>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qHS7ZlZQsQ0eBi8wEUgiATwwgGR7R7poocifTnum6wyLuc1RJ2NiBv8iuz$ZfMSWIfQh5z916gTPtxmKb0bJfZw==
			return this._0023_003DqHS7ZlZQsQ0eBi8wEUgiATwwgGR7R7poocifTnum6wyLuc1RJ2NiBv8iuz_0024ZfMSWIfQh5z916gTPtxmKb0bJfZw_003D_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003DqtzZDVtLrDaVMkbqP5mi9drYoLdxM7mELU9MR2WLo_00247bFpuM_00242yU2_0024_qhBH2MeXpo()
		{
			return _0023_003DqHS7ZlZQsQ0eBi8wEUgiATwwgGR7R7poocifTnum6wyLuc1RJ2NiBv8iuz_0024ZfMSWIfQh5z916gTPtxmKb0bJfZw_003D_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qtzZDVtLrDaVMkbqP5mi9drYoLdxM7mELU9MR2WLo$7bFpuM$2yU2$_qhBH2MeXpo
			return this._0023_003DqtzZDVtLrDaVMkbqP5mi9drYoLdxM7mELU9MR2WLo_00247bFpuM_00242yU2_0024_qhBH2MeXpo();
		}
	}

	private sealed class _0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D : IEnumerator<Index2>, IEnumerable<Index2>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0023_003DqXYg_tbGreSFlIpHEoTjZMQ_003D_003D;

		private Index2 _0023_003DqKTss4vgvYKL7fT9D5uLExw_003D_003D;

		private int _0023_003DqLscc2JmISjSEkZRf1y1cIntjolNpsOfIbvbNy4unS7c_003D;

		public Range2 _0023_003DqN1IDi_0024Pqkj5e2KGeAe3Zxg_003D_003D;

		public Range2 _0023_003DqbrzSJfiVw22zbKDaZNIrJw_003D_003D;

		private int _0023_003DqsBLfJF7db0mINa52t8ZuPg_003D_003D;

		private int _0023_003DqwT1t1zIxl7QGtpWdjLHVhg_003D_003D;

		[DebuggerHidden]
		public _0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D(int _0023_003DqqAtjRsRirm_0024UdFWviC3ZWA_003D_003D)
		{
			_0023_003DqXYg_tbGreSFlIpHEoTjZMQ_003D_003D = _0023_003DqqAtjRsRirm_0024UdFWviC3ZWA_003D_003D;
			_0023_003DqLscc2JmISjSEkZRf1y1cIntjolNpsOfIbvbNy4unS7c_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003DqkIdJ85vjGEf4JroiuygpASRuFR893e0_0024NVjoQZKqo4k_003D()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qkIdJ85vjGEf4JroiuygpASRuFR893e0$NVjoQZKqo4k=
			this._0023_003DqkIdJ85vjGEf4JroiuygpASRuFR893e0_0024NVjoQZKqo4k_003D();
		}

		private bool MoveNext()
		{
			int num = _0023_003DqXYg_tbGreSFlIpHEoTjZMQ_003D_003D;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_0023_003DqXYg_tbGreSFlIpHEoTjZMQ_003D_003D = -1;
				_0023_003DqwT1t1zIxl7QGtpWdjLHVhg_003D_003D++;
				goto IL_007e;
			}
			_0023_003DqXYg_tbGreSFlIpHEoTjZMQ_003D_003D = -1;
			_0023_003DqsBLfJF7db0mINa52t8ZuPg_003D_003D = _0023_003DqN1IDi_0024Pqkj5e2KGeAe3Zxg_003D_003D.Start.Y;
			goto IL_00a6;
			IL_007e:
			if (_0023_003DqwT1t1zIxl7QGtpWdjLHVhg_003D_003D < _0023_003DqN1IDi_0024Pqkj5e2KGeAe3Zxg_003D_003D.End.X)
			{
				_0023_003DqKTss4vgvYKL7fT9D5uLExw_003D_003D = new Index2(_0023_003DqwT1t1zIxl7QGtpWdjLHVhg_003D_003D, _0023_003DqsBLfJF7db0mINa52t8ZuPg_003D_003D);
				_0023_003DqXYg_tbGreSFlIpHEoTjZMQ_003D_003D = 1;
				return true;
			}
			_0023_003DqsBLfJF7db0mINa52t8ZuPg_003D_003D++;
			goto IL_00a6;
			IL_00a6:
			if (_0023_003DqsBLfJF7db0mINa52t8ZuPg_003D_003D < _0023_003DqN1IDi_0024Pqkj5e2KGeAe3Zxg_003D_003D.End.Y)
			{
				_0023_003DqwT1t1zIxl7QGtpWdjLHVhg_003D_003D = _0023_003DqN1IDi_0024Pqkj5e2KGeAe3Zxg_003D_003D.Start.X;
				goto IL_007e;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private Index2 _0023_003Dq6fnO1hxx0KbuSH3j6iAmMaU1i7TvjXrE9eCi_0024SbkZIMyGl2wGDv6I6oM6Jir7ke4wVdKeRsmlyLYUHnADFP0WA_003D_003D()
		{
			return _0023_003DqKTss4vgvYKL7fT9D5uLExw_003D_003D;
		}

		Index2 IEnumerator<Index2>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q6fnO1hxx0KbuSH3j6iAmMaU1i7TvjXrE9eCi$SbkZIMyGl2wGDv6I6oM6Jir7ke4wVdKeRsmlyLYUHnADFP0WA==
			return this._0023_003Dq6fnO1hxx0KbuSH3j6iAmMaU1i7TvjXrE9eCi_0024SbkZIMyGl2wGDv6I6oM6Jir7ke4wVdKeRsmlyLYUHnADFP0WA_003D_003D();
		}

		[DebuggerHidden]
		private void _0023_003DqLWq7gaijcHP_0024taDthKaCWSiD_0024YHPeOVminhXP07aE8KBgQmMh7z5h9VT7gfNeX9C()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qLWq7gaijcHP$taDthKaCWSiD$YHPeOVminhXP07aE8KBgQmMh7z5h9VT7gfNeX9C
			this._0023_003DqLWq7gaijcHP_0024taDthKaCWSiD_0024YHPeOVminhXP07aE8KBgQmMh7z5h9VT7gfNeX9C();
		}

		[DebuggerHidden]
		private object _0023_003DqyWir5TYQpcLk_0024MZIfYtMxCqt48gGShubq69uE1H3CCt2RvdR7VZs87D8EhTxEsc4()
		{
			return _0023_003DqKTss4vgvYKL7fT9D5uLExw_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qyWir5TYQpcLk$MZIfYtMxCqt48gGShubq69uE1H3CCt2RvdR7VZs87D8EhTxEsc4
			return this._0023_003DqyWir5TYQpcLk_0024MZIfYtMxCqt48gGShubq69uE1H3CCt2RvdR7VZs87D8EhTxEsc4();
		}

		[DebuggerHidden]
		private IEnumerator<Index2> _0023_003DqrtA36ngea6K50bjY0rgdgWGgChWsnu7yxKVwH_0024WMSgjWy1Ig_FXNeGmnzkHU3Bf_0024ugoqhzPyHVqA5YMXT9Ceug_003D_003D()
		{
			_0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D _0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D2;
			if (_0023_003DqXYg_tbGreSFlIpHEoTjZMQ_003D_003D == -2 && _0023_003DqLscc2JmISjSEkZRf1y1cIntjolNpsOfIbvbNy4unS7c_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003DqXYg_tbGreSFlIpHEoTjZMQ_003D_003D = 0;
				_0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D2 = this;
			}
			else
			{
				_0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D2 = new _0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D(0);
			}
			_0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D2._0023_003DqN1IDi_0024Pqkj5e2KGeAe3Zxg_003D_003D = _0023_003DqbrzSJfiVw22zbKDaZNIrJw_003D_003D;
			return _0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D2;
		}

		IEnumerator<Index2> IEnumerable<Index2>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qrtA36ngea6K50bjY0rgdgWGgChWsnu7yxKVwH$WMSgjWy1Ig_FXNeGmnzkHU3Bf$ugoqhzPyHVqA5YMXT9Ceug==
			return this._0023_003DqrtA36ngea6K50bjY0rgdgWGgChWsnu7yxKVwH_0024WMSgjWy1Ig_FXNeGmnzkHU3Bf_0024ugoqhzPyHVqA5YMXT9Ceug_003D_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003DqOjjMsEHIacZjYrdaU5nlCw7j7ILvqdylm8olHvcbjFMbL73mKChJQNfWd222C2NI()
		{
			return _0023_003DqrtA36ngea6K50bjY0rgdgWGgChWsnu7yxKVwH_0024WMSgjWy1Ig_FXNeGmnzkHU3Bf_0024ugoqhzPyHVqA5YMXT9Ceug_003D_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qOjjMsEHIacZjYrdaU5nlCw7j7ILvqdylm8olHvcbjFMbL73mKChJQNfWd222C2NI
			return this._0023_003DqOjjMsEHIacZjYrdaU5nlCw7j7ILvqdylm8olHvcbjFMbL73mKChJQNfWd222C2NI();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Range2, Range2, Range2> _003C_003E9__21_0;

		internal Range2 _0023_003DqXjSjdm8T_0DuIvDbVm72qKHH2DwXhPJ5w_rpG1ywhrM_003D(Range2 _0023_003DqSYxy_0024iFH92n6F_0024OOyL65uQ_003D_003D, Range2 _0023_003Dqefe95ST4hWq8DCSEW7iX8g_003D_003D)
		{
			return _0023_003DqSYxy_0024iFH92n6F_0024OOyL65uQ_003D_003D.UnionedWith(_0023_003Dqefe95ST4hWq8DCSEW7iX8g_003D_003D);
		}
	}

	public readonly Index2 Start;

	public readonly Index2 End;

	public static readonly Range2 Empty;

	public static readonly Range2 Undefined;

	public Index2 Size => End - Start;

	public IEnumerable<Index2> Indexes
	{
		[IteratorStateMachine(typeof(_0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D))]
		get
		{
			return new _0023_003DqNYV9kFo42_0024Q6aHf7exUMJIsCaj0HtB_ZUKSu4UzaP0w_003D(-2)
			{
				_0023_003DqbrzSJfiVw22zbKDaZNIrJw_003D_003D = this
			};
		}
	}

	public IEnumerable<Index2> IndexesTopDown
	{
		[IteratorStateMachine(typeof(_0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D))]
		get
		{
			return new _0023_003DqdPyFQd99UuI2AnIeOSC75NAuzTBdM1JdmQJmoLJUqOU_003D(-2)
			{
				_0023_003DqYGHguaKmFOijvjdwRxwDLg_003D_003D = this
			};
		}
	}

	public Range2(Index2 start, Index2 end)
	{
		Start = start;
		End = end;
	}

	public Range2(int startX, int startY, int endX, int endY)
	{
		Start = new Index2(startX, startY);
		End = new Index2(endX, endY);
	}

	static Range2()
	{
		Empty = new Range2(Index2.Zero, Index2.Zero);
		Undefined = new Range2(int.MaxValue, int.MaxValue, int.MinValue, int.MinValue);
	}

	public static Range2 FromZero(Index2 size)
	{
		return new Range2(Index2.Zero, size);
	}

	public static Range2 WithSize(Index2 start, Index2 size)
	{
		return new Range2(start, start + size);
	}

	public static Range2 WithSize(int x, int y, int width, int height)
	{
		return WithSize(new Index2(x, y), new Index2(width, height));
	}

	public override string ToString()
	{
		return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811442), Start, Size);
	}

	public bool IsEmpty()
	{
		if (Start.X < End.X)
		{
			return Start.Y >= End.Y;
		}
		return true;
	}

	public bool Contains(Index2 index)
	{
		if (index.X >= Start.X && index.X < End.X && index.Y >= Start.Y)
		{
			return index.Y < End.Y;
		}
		return false;
	}

	public bool Contains(Range2 range)
	{
		if (range.Start.X >= Start.X && range.End.X <= End.X && range.Start.Y >= Start.Y)
		{
			return range.End.Y <= End.Y;
		}
		return false;
	}

	public bool Overlaps(Range2 other)
	{
		return End.X > other.Start.X && other.End.X > Start.X && End.Y > other.Start.Y && other.End.Y > Start.Y;
	}

	public static Range2 Union(Index2 a, Index2 b)
	{
		return new Range2(new Index2(Math.Min(a.X, b.X), Math.Min(a.Y, b.Y)), new Index2(Math.Max(a.X, b.X) + 1, Math.Max(a.Y, b.Y) + 1));
	}

	public static Range2 UnionAll(IEnumerable<Range2> sequence)
	{
		return sequence.Aggregate(Undefined, _003C_003Ec._003C_003E9._0023_003DqXjSjdm8T_0DuIvDbVm72qKHH2DwXhPJ5w_rpG1ywhrM_003D);
	}

	public Range2 UnionedWith(Index2 point)
	{
		if (IsEmpty())
		{
			return new Range2(point, point + new Index2(1, 1));
		}
		return new Range2(new Index2(Math.Min(Start.X, point.X), Math.Min(Start.Y, point.Y)), new Index2(Math.Max(End.X, point.X + 1), Math.Max(End.Y, point.Y + 1)));
	}

	public Range2 UnionedWith(Range2 other)
	{
		if (IsEmpty())
		{
			return other;
		}
		return UnionedWith(other.Start).UnionedWith(other.End - new Index2(1, 1));
	}

	public Range2 Translated(Index2 delta)
	{
		return new Range2(Start + delta, End + delta);
	}

	public Range2 Rotated(QuarterRotations rotation)
	{
		Index2 index = End - new Index2(1, 1);
		return Union(Start.Rotated(rotation), index.Rotated(rotation));
	}

	public Range2 Expanded(int w, int h)
	{
		Index2 index = new Index2(w, h);
		return new Range2(Start - index, End + 2 * index);
	}

	public Bounds2 ToBounds2()
	{
		return Bounds2.WithSize(Start.ToVector2(), Size.ToVector2());
	}

	public override bool Equals(object obj)
	{
		Range2? range = obj as Range2?;
		if (!range.HasValue)
		{
			return false;
		}
		Range2 value = this;
		Range2? range2 = range;
		return value == range2;
	}

	public override int GetHashCode()
	{
		return (391 + Start.GetHashCode()) * 23 + End.GetHashCode();
	}

	public bool Equals(Range2 other)
	{
		return this == other;
	}

	public static bool operator ==(Range2 a, Range2 b)
	{
		if (a.Start == b.Start)
		{
			return a.End == b.End;
		}
		return false;
	}

	public static bool operator !=(Range2 a, Range2 b)
	{
		return !(a == b);
	}
}
