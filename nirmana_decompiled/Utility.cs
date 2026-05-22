using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

public static class Utility
{
	private sealed class _0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D> : IEnumerator<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D>, IEnumerable<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D;

		private _0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D _0023_003DqJ1L7CX_0024DNuQcaCMyKkF_0024FA_003D_003D;

		private int _0023_003Dq_e0S0kPRBaF0UlAHchUzFso1GnFuRfRIuW6K5FPoawU_003D;

		private IEnumerable<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D> _0023_003DqJwoWWjo_QJgR_00241X4uSfxRA_003D_003D;

		public IEnumerable<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D> _0023_003Dq8bJLc7wW4EGONCzImVS5YA_003D_003D;

		private IEnumerable<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D> _0023_003DqxxGHYkZDccW8AfBvJl2W3Q_003D_003D;

		public IEnumerable<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D> _0023_003DqluGhmKlMtARDcYb3krdITA_003D_003D;

		private ReliableRandom _0023_003Dqyx4HvWf5yZPOdHADWNErrA_003D_003D;

		public ReliableRandom _0023_003Dq_v8XMPPFgRLJTDbIXBZILg_003D_003D;

		private int _0023_003DqgxjQ59y0tOJp_0024k_yHCJ8k6vbB_0024BSjvuUUVjQijdd3Bs_003D;

		private int _0023_003DqRfJDYn9Ecvy9X0z9jc94YK6hfI_uNz8bhh21paI0v0Y_003D;

		[DebuggerHidden]
		public _0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D(int _0023_003DqGZvKefAga46JU__dq_0024spAg_003D_003D)
		{
			_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D = _0023_003DqGZvKefAga46JU__dq_0024spAg_003D_003D;
			_0023_003Dq_e0S0kPRBaF0UlAHchUzFso1GnFuRfRIuW6K5FPoawU_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003DqcfMkidfR288dXUB4fEzr_0024FDRMSM30E5Zm6t4QanyPNw_003D()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qcfMkidfR288dXUB4fEzr$FDRMSM30E5Zm6t4QanyPNw=
			this._0023_003DqcfMkidfR288dXUB4fEzr_0024FDRMSM30E5Zm6t4QanyPNw_003D();
		}

		private bool MoveNext()
		{
			switch (_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D)
			{
			default:
				return false;
			case 0:
				_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D = -1;
				_0023_003DqJwoWWjo_QJgR_00241X4uSfxRA_003D_003D = _0023_003DqJwoWWjo_QJgR_00241X4uSfxRA_003D_003D.ToArray();
				_0023_003DqxxGHYkZDccW8AfBvJl2W3Q_003D_003D = _0023_003DqxxGHYkZDccW8AfBvJl2W3Q_003D_003D.ToArray();
				_0023_003DqgxjQ59y0tOJp_0024k_yHCJ8k6vbB_0024BSjvuUUVjQijdd3Bs_003D = _0023_003DqJwoWWjo_QJgR_00241X4uSfxRA_003D_003D.Count();
				_0023_003DqRfJDYn9Ecvy9X0z9jc94YK6hfI_uNz8bhh21paI0v0Y_003D = _0023_003DqxxGHYkZDccW8AfBvJl2W3Q_003D_003D.Count();
				break;
			case 1:
				_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D = -1;
				_0023_003DqJwoWWjo_QJgR_00241X4uSfxRA_003D_003D = _0023_003DqJwoWWjo_QJgR_00241X4uSfxRA_003D_003D.Skip(1);
				_0023_003DqgxjQ59y0tOJp_0024k_yHCJ8k6vbB_0024BSjvuUUVjQijdd3Bs_003D--;
				break;
			case 2:
				_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D = -1;
				_0023_003DqxxGHYkZDccW8AfBvJl2W3Q_003D_003D = _0023_003DqxxGHYkZDccW8AfBvJl2W3Q_003D_003D.Skip(1);
				_0023_003DqRfJDYn9Ecvy9X0z9jc94YK6hfI_uNz8bhh21paI0v0Y_003D--;
				break;
			}
			if (_0023_003DqgxjQ59y0tOJp_0024k_yHCJ8k6vbB_0024BSjvuUUVjQijdd3Bs_003D > 0 || _0023_003DqRfJDYn9Ecvy9X0z9jc94YK6hfI_uNz8bhh21paI0v0Y_003D > 0)
			{
				float _0023_003Dq0SCP701d9_UIkMOf_00242wM8_VA16Gmfrnq_0024msuetwjb3k_003D = (float)_0023_003DqgxjQ59y0tOJp_0024k_yHCJ8k6vbB_0024BSjvuUUVjQijdd3Bs_003D / (float)(_0023_003DqgxjQ59y0tOJp_0024k_yHCJ8k6vbB_0024BSjvuUUVjQijdd3Bs_003D + _0023_003DqRfJDYn9Ecvy9X0z9jc94YK6hfI_uNz8bhh21paI0v0Y_003D);
				if (_0023_003Dqyx4HvWf5yZPOdHADWNErrA_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(_0023_003Dq0SCP701d9_UIkMOf_00242wM8_VA16Gmfrnq_0024msuetwjb3k_003D))
				{
					_0023_003DqJ1L7CX_0024DNuQcaCMyKkF_0024FA_003D_003D = _0023_003DqJwoWWjo_QJgR_00241X4uSfxRA_003D_003D.First();
					_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D = 1;
					return true;
				}
				_0023_003DqJ1L7CX_0024DNuQcaCMyKkF_0024FA_003D_003D = _0023_003DqxxGHYkZDccW8AfBvJl2W3Q_003D_003D.First();
				_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D = 2;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private _0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D _0023_003Dq4aguD3A4KdRzwoD_rveLBXDZCk0bKbGZ6zzXLqXLY7l5iZWvLA1i_0024AYnR8aVFnNTzYvj3f8jG7RtxGM_Lnr3cg_003D_003D()
		{
			return _0023_003DqJ1L7CX_0024DNuQcaCMyKkF_0024FA_003D_003D;
		}

		_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D IEnumerator<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q4aguD3A4KdRzwoD_rveLBXDZCk0bKbGZ6zzXLqXLY7l5iZWvLA1i$AYnR8aVFnNTzYvj3f8jG7RtxGM_Lnr3cg==
			return this._0023_003Dq4aguD3A4KdRzwoD_rveLBXDZCk0bKbGZ6zzXLqXLY7l5iZWvLA1i_0024AYnR8aVFnNTzYvj3f8jG7RtxGM_Lnr3cg_003D_003D();
		}

		[DebuggerHidden]
		private void _0023_003DqSpgF1O7EQY32lqAi4pKb2KmmHHTZRy6fL5AHtDz1MOF5bGaAOYbC7khIpTL7rxtL()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qSpgF1O7EQY32lqAi4pKb2KmmHHTZRy6fL5AHtDz1MOF5bGaAOYbC7khIpTL7rxtL
			this._0023_003DqSpgF1O7EQY32lqAi4pKb2KmmHHTZRy6fL5AHtDz1MOF5bGaAOYbC7khIpTL7rxtL();
		}

		[DebuggerHidden]
		private object _0023_003Dql6NSszl0UptAVNCSTm5xc8QVkyH4TBZNoW1Hw8ccczukHSn1ucT4s9VbrlehXDKC()
		{
			return _0023_003DqJ1L7CX_0024DNuQcaCMyKkF_0024FA_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=ql6NSszl0UptAVNCSTm5xc8QVkyH4TBZNoW1Hw8ccczukHSn1ucT4s9VbrlehXDKC
			return this._0023_003Dql6NSszl0UptAVNCSTm5xc8QVkyH4TBZNoW1Hw8ccczukHSn1ucT4s9VbrlehXDKC();
		}

		[DebuggerHidden]
		private IEnumerator<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D> _0023_003DqRW_z1XhFfmJqdp9UrU5_dLF7nef_pQg62OPJ1wKJlrcVl2H4T1IwiQOuvwu95p3FDwGihMFTMj0IWJP3_00242cipA_003D_003D()
		{
			_0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D> _0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D2;
			if (_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D == -2 && _0023_003Dq_e0S0kPRBaF0UlAHchUzFso1GnFuRfRIuW6K5FPoawU_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003DqJWYJYvLsb69_YsFZ7chotA_003D_003D = 0;
				_0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D2 = this;
			}
			else
			{
				_0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D2 = new _0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D>(0);
			}
			_0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D2._0023_003Dqyx4HvWf5yZPOdHADWNErrA_003D_003D = _0023_003Dq_v8XMPPFgRLJTDbIXBZILg_003D_003D;
			_0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D2._0023_003DqJwoWWjo_QJgR_00241X4uSfxRA_003D_003D = _0023_003Dq8bJLc7wW4EGONCzImVS5YA_003D_003D;
			_0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D2._0023_003DqxxGHYkZDccW8AfBvJl2W3Q_003D_003D = _0023_003DqluGhmKlMtARDcYb3krdITA_003D_003D;
			return _0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D2;
		}

		IEnumerator<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D> IEnumerable<_0023_003DqydVbcQS7nQjJOn3Z5yl8Zw_003D_003D>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qRW_z1XhFfmJqdp9UrU5_dLF7nef_pQg62OPJ1wKJlrcVl2H4T1IwiQOuvwu95p3FDwGihMFTMj0IWJP3$2cipA==
			return this._0023_003DqRW_z1XhFfmJqdp9UrU5_dLF7nef_pQg62OPJ1wKJlrcVl2H4T1IwiQOuvwu95p3FDwGihMFTMj0IWJP3_00242cipA_003D_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003Dqo0K1fVR4BNP6_ZeIrkMOn_vLu0ODb5NEhMlDQdig0uUhfEHjdyLKqw2oU663twXA()
		{
			return _0023_003DqRW_z1XhFfmJqdp9UrU5_dLF7nef_pQg62OPJ1wKJlrcVl2H4T1IwiQOuvwu95p3FDwGihMFTMj0IWJP3_00242cipA_003D_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qo0K1fVR4BNP6_ZeIrkMOn_vLu0ODb5NEhMlDQdig0uUhfEHjdyLKqw2oU663twXA
			return this._0023_003Dqo0K1fVR4BNP6_ZeIrkMOn_vLu0ODb5NEhMlDQdig0uUhfEHjdyLKqw2oU663twXA();
		}
	}

	private sealed class _0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D> : IEnumerator<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D>, IEnumerable<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0023_003DqaAqMyTurM33eLCT_00240meABQ_003D_003D;

		private _0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D _0023_003DqTZ6KflVNydAEuA__b4qF0Q_003D_003D;

		private int _0023_003Dq8dHgXpYw9TvT_WjCIJB_0024S1KKQawvYHw9CONEm6TieI4_003D;

		private IList<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D> _0023_003DqKJ2rdz8SK5Iq3uj32xRsxQ_003D_003D;

		public IList<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D> _0023_003Dq8UH7Dl8xlpleXpYwZh78Og_003D_003D;

		private int _0023_003DqfEYpcRtpTEr2v6z297E_0024cA_003D_003D;

		[DebuggerHidden]
		public _0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D(int _0023_003DqP4mKTr_zsyrFgZArVJQJBA_003D_003D)
		{
			_0023_003DqaAqMyTurM33eLCT_00240meABQ_003D_003D = _0023_003DqP4mKTr_zsyrFgZArVJQJBA_003D_003D;
			_0023_003Dq8dHgXpYw9TvT_WjCIJB_0024S1KKQawvYHw9CONEm6TieI4_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003DqwNs_00242VqejV8bZhXQ5NqlPyO5Yzb9yheSsmI6Zh3Ru3Y_003D()
		{
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qwNs$2VqejV8bZhXQ5NqlPyO5Yzb9yheSsmI6Zh3Ru3Y=
			this._0023_003DqwNs_00242VqejV8bZhXQ5NqlPyO5Yzb9yheSsmI6Zh3Ru3Y_003D();
		}

		private bool MoveNext()
		{
			switch (_0023_003DqaAqMyTurM33eLCT_00240meABQ_003D_003D)
			{
			default:
				return false;
			case 0:
				_0023_003DqaAqMyTurM33eLCT_00240meABQ_003D_003D = -1;
				_0023_003DqfEYpcRtpTEr2v6z297E_0024cA_003D_003D = _0023_003DqKJ2rdz8SK5Iq3uj32xRsxQ_003D_003D.Count - 1;
				break;
			case 1:
				_0023_003DqaAqMyTurM33eLCT_00240meABQ_003D_003D = -1;
				_0023_003DqfEYpcRtpTEr2v6z297E_0024cA_003D_003D--;
				break;
			}
			if (_0023_003DqfEYpcRtpTEr2v6z297E_0024cA_003D_003D >= 0)
			{
				_0023_003DqTZ6KflVNydAEuA__b4qF0Q_003D_003D = _0023_003DqKJ2rdz8SK5Iq3uj32xRsxQ_003D_003D[_0023_003DqfEYpcRtpTEr2v6z297E_0024cA_003D_003D];
				_0023_003DqaAqMyTurM33eLCT_00240meABQ_003D_003D = 1;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		private _0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D _0023_003DqZrqT_0024mDcyMu08xV7wCC8oV9dx9BPopLdymN7lWXA149gDo2jB8UTxp89EJq6WCXzrNOFbDst_0024rR3JuxZg9efPQ_003D_003D()
		{
			return _0023_003DqTZ6KflVNydAEuA__b4qF0Q_003D_003D;
		}

		_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D IEnumerator<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qZrqT$mDcyMu08xV7wCC8oV9dx9BPopLdymN7lWXA149gDo2jB8UTxp89EJq6WCXzrNOFbDst$rR3JuxZg9efPQ==
			return this._0023_003DqZrqT_0024mDcyMu08xV7wCC8oV9dx9BPopLdymN7lWXA149gDo2jB8UTxp89EJq6WCXzrNOFbDst_0024rR3JuxZg9efPQ_003D_003D();
		}

		[DebuggerHidden]
		private void _0023_003DqcwSXkjqDIhM2KFFCmfGjZ_00240VLVo78_002462UniiqQ_H01cV3MF6sxsb6VvuSEcy66vE()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qcwSXkjqDIhM2KFFCmfGjZ$0VLVo78$62UniiqQ_H01cV3MF6sxsb6VvuSEcy66vE
			this._0023_003DqcwSXkjqDIhM2KFFCmfGjZ_00240VLVo78_002462UniiqQ_H01cV3MF6sxsb6VvuSEcy66vE();
		}

		[DebuggerHidden]
		private object _0023_003Dqtdh84dF9MT1oqhymbUmA1H3E4asz_KgvvJVFSj4xNbRoMShaaYWhpESk8f07h6Rt()
		{
			return _0023_003DqTZ6KflVNydAEuA__b4qF0Q_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qtdh84dF9MT1oqhymbUmA1H3E4asz_KgvvJVFSj4xNbRoMShaaYWhpESk8f07h6Rt
			return this._0023_003Dqtdh84dF9MT1oqhymbUmA1H3E4asz_KgvvJVFSj4xNbRoMShaaYWhpESk8f07h6Rt();
		}

		[DebuggerHidden]
		private IEnumerator<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D> _0023_003DqSpgF1O7EQY32lqAi4pKb2NoonIn6sIWiyZQq84Yw0EhOCzKgMEeRxL_0024CQxim0tRj7iWtXbJmH1wJ0u2wiQ2wzA_003D_003D()
		{
			_0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D> _0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D2;
			if (_0023_003DqaAqMyTurM33eLCT_00240meABQ_003D_003D == -2 && _0023_003Dq8dHgXpYw9TvT_WjCIJB_0024S1KKQawvYHw9CONEm6TieI4_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003DqaAqMyTurM33eLCT_00240meABQ_003D_003D = 0;
				_0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D2 = this;
			}
			else
			{
				_0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D2 = new _0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D>(0);
			}
			_0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D2._0023_003DqKJ2rdz8SK5Iq3uj32xRsxQ_003D_003D = _0023_003Dq8UH7Dl8xlpleXpYwZh78Og_003D_003D;
			return _0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D2;
		}

		IEnumerator<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D> IEnumerable<_0023_003DqZgXSGyuOMZE4wYv0wmxTHQ_003D_003D>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qSpgF1O7EQY32lqAi4pKb2NoonIn6sIWiyZQq84Yw0EhOCzKgMEeRxL$CQxim0tRj7iWtXbJmH1wJ0u2wiQ2wzA==
			return this._0023_003DqSpgF1O7EQY32lqAi4pKb2NoonIn6sIWiyZQq84Yw0EhOCzKgMEeRxL_0024CQxim0tRj7iWtXbJmH1wJ0u2wiQ2wzA_003D_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003Dqyd6HxCGOWTWzr_0024PJmpKZlSW55N_0024zepDiK8i84vPKlu4EcUeWF6MvEEur7MQimCbE()
		{
			return _0023_003DqSpgF1O7EQY32lqAi4pKb2NoonIn6sIWiyZQq84Yw0EhOCzKgMEeRxL_0024CQxim0tRj7iWtXbJmH1wJ0u2wiQ2wzA_003D_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qyd6HxCGOWTWzr$PJmpKZlSW55N$zepDiK8i84vPKlu4EcUeWF6MvEEur7MQimCbE
			return this._0023_003Dqyd6HxCGOWTWzr_0024PJmpKZlSW55N_0024zepDiK8i84vPKlu4EcUeWF6MvEEur7MQimCbE();
		}
	}

	private sealed class _0023_003Dqsa9Xi2OekBcJF_00240vQb0QzsSEFH_0024pLa5Yz3Xph9tPvY8_003D<_0023_003DqO5NXto6amPsjauIbG9GHXA_003D_003D, _0023_003DqGzI62wLhSOWY7FSq5gH4Yw_003D_003D>
	{
		public Func<_0023_003DqO5NXto6amPsjauIbG9GHXA_003D_003D, _0023_003DqGzI62wLhSOWY7FSq5gH4Yw_003D_003D> _0023_003Dqx8ypK5XIBn8SM00fG5fGLw_003D_003D;

		public Dictionary<_0023_003DqGzI62wLhSOWY7FSq5gH4Yw_003D_003D, int> _0023_003DqzngLJFBPxxIlFxOMhBKvwTpbQZ2anDrRV3j66o_7Eq0_003D;

		public int _0023_003DqDtPwEEuRghIA70lzVMdfmQ_003D_003D;

		internal int _0023_003Dqj8L74EJ2NuL_WuOZN1eck1tPclI_0024kelDgbP4CYsqeis_003D(_0023_003DqO5NXto6amPsjauIbG9GHXA_003D_003D _0023_003DqXbEROrx9DAqX2_0024Qwh0doFQ_003D_003D)
		{
			_0023_003DqGzI62wLhSOWY7FSq5gH4Yw_003D_003D key = _0023_003Dqx8ypK5XIBn8SM00fG5fGLw_003D_003D(_0023_003DqXbEROrx9DAqX2_0024Qwh0doFQ_003D_003D);
			if (_0023_003DqzngLJFBPxxIlFxOMhBKvwTpbQZ2anDrRV3j66o_7Eq0_003D.ContainsKey(key))
			{
				return _0023_003DqzngLJFBPxxIlFxOMhBKvwTpbQZ2anDrRV3j66o_7Eq0_003D[key];
			}
			return _0023_003DqDtPwEEuRghIA70lzVMdfmQ_003D_003D;
		}
	}

	private sealed class _0023_003DqVjnUf_0024fektJ4NwKpK3I7uLTJtxf4IEBuFMCFDlZtGwY_003D<_0023_003DqIa3ZoyKTDUFPrRHWJ_0024mdJQ_003D_003D>
	{
		public Func<_0023_003DqIa3ZoyKTDUFPrRHWJ_0024mdJQ_003D_003D, int> _0023_003DqLcXWpP_bTtH3MQH15nRXNg_003D_003D;

		internal int _0023_003Dqe3VHJir68MXlnQUjRhZ7kn84y_0024lH55TGJfCkSqqHkuM_003D(_0023_003DqIa3ZoyKTDUFPrRHWJ_0024mdJQ_003D_003D _0023_003DqoYSk6pwgwt6d26P80Y_00249PA_003D_003D)
		{
			return -_0023_003DqLcXWpP_bTtH3MQH15nRXNg_003D_003D(_0023_003DqoYSk6pwgwt6d26P80Y_00249PA_003D_003D);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__66<T>
	{
		public static readonly _003C_003Ec__66<T> _003C_003E9 = new _003C_003Ec__66<T>();

		public static Func<T, T> _003C_003E9__66_0;

		internal T _0023_003Dqh58zRHr5S8xIYaR7qOgnexDW42V8cAFHRpKaG70Qlpg_003D(T _0023_003DqlUmgd8EbVy_HH1xe2Za8fQ_003D_003D)
		{
			return _0023_003DqlUmgd8EbVy_HH1xe2Za8fQ_003D_003D;
		}
	}

	public static int _0023_003DqPketCwwzMXFnMETn36UPyQ_003D_003D(int _0023_003Dqeq6xWHxrA7DD3XuTnq5dxg_003D_003D, int _0023_003DqFcA9j83FwHBPEx6_0024NjQ9LQ_003D_003D, int _0023_003DqW67cbdDvU8Hr9ZmQa7wqwg_003D_003D)
	{
		return Math.Min(Math.Max(_0023_003Dqeq6xWHxrA7DD3XuTnq5dxg_003D_003D, _0023_003DqFcA9j83FwHBPEx6_0024NjQ9LQ_003D_003D), _0023_003DqW67cbdDvU8Hr9ZmQa7wqwg_003D_003D);
	}

	public static float _0023_003Dqkau7hU_0024BFCWNvu_HoHnSyw_003D_003D(float _0023_003DqXv_EfEVHYpaWL4B3iO2Yaw_003D_003D, float _0023_003DqIkPhg9a5kWwomQxiPh6Osw_003D_003D, float _0023_003DqRXgm75fiwDxnF_0024efQp7ljw_003D_003D)
	{
		return Math.Min(Math.Max(_0023_003DqXv_EfEVHYpaWL4B3iO2Yaw_003D_003D, _0023_003DqIkPhg9a5kWwomQxiPh6Osw_003D_003D), _0023_003DqRXgm75fiwDxnF_0024efQp7ljw_003D_003D);
	}

	public static float _0023_003DqhX63_mvn8wj4TTdla_0024eWXA_003D_003D(float _0023_003Dqz8uegCxyTtVHmBKueHnX9w_003D_003D)
	{
		return _0023_003Dqkau7hU_0024BFCWNvu_HoHnSyw_003D_003D(_0023_003Dqz8uegCxyTtVHmBKueHnX9w_003D_003D, 0f, 1f);
	}

	public static ulong _0023_003DqDAwyqc0dtemkxgYrVhWg5g_003D_003D(ulong _0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D)
	{
		_0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D ^= _0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D >> 33;
		_0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D *= 18397679294719823053uL;
		_0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D ^= _0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D >> 33;
		_0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D *= 14181476777654086739uL;
		_0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D ^= _0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D >> 33;
		return _0023_003DqEWdP6d4lXZEZfGdoCtC5aw_003D_003D;
	}

	public static int _0023_003DqmDpSVbUIGdNI6cWqJJ_0024w3Q_003D_003D(int _0023_003Dqk0XahqwKgkp_tNP_v039Bg_003D_003D, int _0023_003Dq3x9Isax1PAL8KLupK5pBgg_003D_003D)
	{
		return (_0023_003Dqk0XahqwKgkp_tNP_v039Bg_003D_003D % _0023_003Dq3x9Isax1PAL8KLupK5pBgg_003D_003D + _0023_003Dq3x9Isax1PAL8KLupK5pBgg_003D_003D) % _0023_003Dq3x9Isax1PAL8KLupK5pBgg_003D_003D;
	}

	public static float _0023_003DqLUeKvmw04VCjEAOgpE6s4g_003D_003D(float _0023_003DqNjEvYrWjjdhbu0r7jANAbA_003D_003D, float _0023_003Dq93TzQrb31mAcNGWRsWGxHw_003D_003D)
	{
		return (_0023_003DqNjEvYrWjjdhbu0r7jANAbA_003D_003D % _0023_003Dq93TzQrb31mAcNGWRsWGxHw_003D_003D + _0023_003Dq93TzQrb31mAcNGWRsWGxHw_003D_003D) % _0023_003Dq93TzQrb31mAcNGWRsWGxHw_003D_003D;
	}

	public static float _0023_003DqL0WyWrsm1DmSfxP7dLGQgw_003D_003D(float _0023_003DqG5v3i6xvwJt_0024OZlKx_el4Q_003D_003D, float _0023_003DqmdGmYPW3DRonImQE16UNRg_003D_003D)
	{
		return _0023_003DqLUeKvmw04VCjEAOgpE6s4g_003D_003D(_0023_003DqG5v3i6xvwJt_0024OZlKx_el4Q_003D_003D - _0023_003DqmdGmYPW3DRonImQE16UNRg_003D_003D + (float)Math.PI, (float)Math.PI * 2f) - (float)Math.PI;
	}

	public static float _0023_003Dqw_0024oPIIpRZ_j_SuaKXS8Adw_003D_003D(float _0023_003DqRfBZbcNez4YaRBSOT64ybw_003D_003D, float _0023_003Dq0FBCA7DiDKd1f8FTKudRrg_003D_003D, float _0023_003Dq3qVqpj8fQqpCooMBNCN5Uw_003D_003D)
	{
		float num = (_0023_003Dq0FBCA7DiDKd1f8FTKudRrg_003D_003D - _0023_003DqRfBZbcNez4YaRBSOT64ybw_003D_003D) % ((float)Math.PI * 2f);
		float num2 = 2f * num % ((float)Math.PI * 2f) - num;
		return _0023_003DqRfBZbcNez4YaRBSOT64ybw_003D_003D + _0023_003Dq3qVqpj8fQqpCooMBNCN5Uw_003D_003D * num2;
	}

	public static float _0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(float _0023_003DqfvU_0024eby2kr8Dq_0Auaj8GA_003D_003D, float _0023_003DqMc3J3Cuxk1KbDfBkhN5_0024UA_003D_003D, float _0023_003DqK9e3dWdHeSKNV_FxvZE3bg_003D_003D)
	{
		return _0023_003DqfvU_0024eby2kr8Dq_0Auaj8GA_003D_003D + _0023_003DqK9e3dWdHeSKNV_FxvZE3bg_003D_003D * (_0023_003DqMc3J3Cuxk1KbDfBkhN5_0024UA_003D_003D - _0023_003DqfvU_0024eby2kr8Dq_0Auaj8GA_003D_003D);
	}

	public static Vector2 _0023_003DqUEMoWYNt5wFOV16oZOsRdw_003D_003D(Vector2 _0023_003DqDpDsDM_ikRlvaZYtcH6gHw_003D_003D, Vector2 _0023_003DqzaMhLdyazVUGS9DI6rGu4A_003D_003D, float _0023_003DqVkNKPFCreD_UGItmWzn1cQ_003D_003D)
	{
		return _0023_003DqDpDsDM_ikRlvaZYtcH6gHw_003D_003D + _0023_003DqVkNKPFCreD_UGItmWzn1cQ_003D_003D * (_0023_003DqzaMhLdyazVUGS9DI6rGu4A_003D_003D - _0023_003DqDpDsDM_ikRlvaZYtcH6gHw_003D_003D);
	}

	public static Vector2 _0023_003DqKdzkMGpE3GbwylRh9tEyIw_003D_003D(Vector2 _0023_003DqM1CBM7zwvmcxiKHVXBOpHw_003D_003D, Vector2 _0023_003DqTyEgmZaV0V9713_fQmuLnQ_003D_003D, Vector2 _0023_003Dq85WeKHYvCQf9j9vps_0024pp6g_003D_003D)
	{
		return new Vector2(_0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(_0023_003DqM1CBM7zwvmcxiKHVXBOpHw_003D_003D.X, _0023_003DqTyEgmZaV0V9713_fQmuLnQ_003D_003D.X, _0023_003Dq85WeKHYvCQf9j9vps_0024pp6g_003D_003D.X), _0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(_0023_003DqM1CBM7zwvmcxiKHVXBOpHw_003D_003D.Y, _0023_003DqTyEgmZaV0V9713_fQmuLnQ_003D_003D.Y, _0023_003Dq85WeKHYvCQf9j9vps_0024pp6g_003D_003D.Y));
	}

	public static float _0023_003DqjUbJri0C5K6aV_0024oJdhOW6_0pMjjIIjDpzitwTXtorvA_003D(float _0023_003DqUglHoTVQZH_00243ECFaOYUXwg_003D_003D, float _0023_003Dq2BBp95qURQfS5AMC1Lo3Vw_003D_003D, float _0023_003DqScarnxzP9On6xR0D_VXhwQ_003D_003D, float _0023_003DqOxvEQjbX0K3bOh8pHw1Rqg_003D_003D, float _0023_003Dq1lAypH5svnMYeyAHrcaNuQ_003D_003D)
	{
		return _0023_003DqOxvEQjbX0K3bOh8pHw1Rqg_003D_003D + (_0023_003Dq1lAypH5svnMYeyAHrcaNuQ_003D_003D - _0023_003DqOxvEQjbX0K3bOh8pHw1Rqg_003D_003D) * _0023_003DqhX63_mvn8wj4TTdla_0024eWXA_003D_003D((_0023_003DqUglHoTVQZH_00243ECFaOYUXwg_003D_003D - _0023_003Dq2BBp95qURQfS5AMC1Lo3Vw_003D_003D) / (_0023_003DqScarnxzP9On6xR0D_VXhwQ_003D_003D - _0023_003Dq2BBp95qURQfS5AMC1Lo3Vw_003D_003D));
	}

	public static float _0023_003Dq6anbWb2gO7GB5Sg3NkxPXw_003D_003D(float _0023_003Dqt8L8h40634Wcg77uw8gSmw_003D_003D)
	{
		return 1f - (float)Math.Cos(Math.PI / 2.0 * (double)_0023_003Dqt8L8h40634Wcg77uw8gSmw_003D_003D);
	}

	public static float _0023_003DqkYABqOOt3rfGE7kQYhgsBNBxiPS0LXFz3JbV_0024IIXI4U_003D(float _0023_003DqsFEQm0XU2uKcVghhgqbQrg_003D_003D, float _0023_003DqTuiwVYVWkRVpOCLFT1FEzg_003D_003D, float _0023_003DqeN3pAB7TROvjhWtErinyuQ_003D_003D, float _0023_003Dq0h0n5tYJs8j_0024phEhn2XAuw_003D_003D, float _0023_003DqwVlXz2CZmtK0cgi8auNFkw_003D_003D)
	{
		return _0023_003Dq0h0n5tYJs8j_0024phEhn2XAuw_003D_003D + (_0023_003DqwVlXz2CZmtK0cgi8auNFkw_003D_003D - _0023_003Dq0h0n5tYJs8j_0024phEhn2XAuw_003D_003D) * _0023_003Dq6anbWb2gO7GB5Sg3NkxPXw_003D_003D(_0023_003DqhX63_mvn8wj4TTdla_0024eWXA_003D_003D((_0023_003DqsFEQm0XU2uKcVghhgqbQrg_003D_003D - _0023_003DqTuiwVYVWkRVpOCLFT1FEzg_003D_003D) / (_0023_003DqeN3pAB7TROvjhWtErinyuQ_003D_003D - _0023_003DqTuiwVYVWkRVpOCLFT1FEzg_003D_003D)));
	}

	public static float _0023_003DqtR7w_0024i_hp_0024kiZSI4a0JLBQ_003D_003D(float _0023_003Dqt2jhu_WpR5tQ6HJyDAEH3Q_003D_003D)
	{
		return (float)Math.Sin(Math.PI / 2.0 * (double)_0023_003Dqt2jhu_WpR5tQ6HJyDAEH3Q_003D_003D);
	}

	public static float _0023_003Dqxd_rvzJCRATP8s2RjK5HbGceropAiBs8oB7iMubF0B8_003D(float _0023_003DqYA2wZWG4_2B2Ce6NV_6Leg_003D_003D, float _0023_003DqHaUwZzU_aj8B9vKnpg963w_003D_003D, float _0023_003DqRw8OBdACj5EN4M01K31mNg_003D_003D, float _0023_003DqY10sH_00248yLrU4cF10hxUQXw_003D_003D, float _0023_003Dq_80AZBsvfVX_qyW8TT49Ng_003D_003D)
	{
		return _0023_003DqY10sH_00248yLrU4cF10hxUQXw_003D_003D + (_0023_003Dq_80AZBsvfVX_qyW8TT49Ng_003D_003D - _0023_003DqY10sH_00248yLrU4cF10hxUQXw_003D_003D) * _0023_003DqtR7w_0024i_hp_0024kiZSI4a0JLBQ_003D_003D(_0023_003DqhX63_mvn8wj4TTdla_0024eWXA_003D_003D((_0023_003DqYA2wZWG4_2B2Ce6NV_6Leg_003D_003D - _0023_003DqHaUwZzU_aj8B9vKnpg963w_003D_003D) / (_0023_003DqRw8OBdACj5EN4M01K31mNg_003D_003D - _0023_003DqHaUwZzU_aj8B9vKnpg963w_003D_003D)));
	}

	public static float _0023_003DqtCoKzrxgn4sCJwp9BCaErg_003D_003D(float _0023_003Dq_Jt8Yypl_qnxloQ9FPKaPw_003D_003D)
	{
		return 0.5f * (1f - (float)Math.Cos(Math.PI * (double)_0023_003Dq_Jt8Yypl_qnxloQ9FPKaPw_003D_003D));
	}

	public static float _0023_003Dq_0024NPEEaHkguj5pXw_0024NIOKlgEK0YIhkpCGIbmC_awsB18_003D(float _0023_003Dq6RDJ53RPAaoux_0024m4KJHi3A_003D_003D, float _0023_003DqMsguQBzAF8lPXFDsnqzFgA_003D_003D, float _0023_003DqpjI3IPlWPpfNXOBHmUWXLw_003D_003D, float _0023_003DqIHo9YysbVRp6S3x7mtV0IQ_003D_003D, float _0023_003Dqx0dpKLikQsa7aioHPulFUQ_003D_003D)
	{
		return _0023_003DqIHo9YysbVRp6S3x7mtV0IQ_003D_003D + (_0023_003Dqx0dpKLikQsa7aioHPulFUQ_003D_003D - _0023_003DqIHo9YysbVRp6S3x7mtV0IQ_003D_003D) * _0023_003DqtCoKzrxgn4sCJwp9BCaErg_003D_003D(_0023_003DqhX63_mvn8wj4TTdla_0024eWXA_003D_003D((_0023_003Dq6RDJ53RPAaoux_0024m4KJHi3A_003D_003D - _0023_003DqMsguQBzAF8lPXFDsnqzFgA_003D_003D) / (_0023_003DqpjI3IPlWPpfNXOBHmUWXLw_003D_003D - _0023_003DqMsguQBzAF8lPXFDsnqzFgA_003D_003D)));
	}

	public static float _0023_003DqLUPtzgvbUJMi1tyZpd0DCw_003D_003D(float _0023_003DqLdk3qbY7d6AmHlhbLDOyQw_003D_003D)
	{
		if (!(_0023_003DqLdk3qbY7d6AmHlhbLDOyQw_003D_003D < 0.5f))
		{
			return 1f - (float)Math.Pow(-2f * _0023_003DqLdk3qbY7d6AmHlhbLDOyQw_003D_003D + 2f, 3.0) / 2f;
		}
		return 4f * _0023_003DqLdk3qbY7d6AmHlhbLDOyQw_003D_003D * _0023_003DqLdk3qbY7d6AmHlhbLDOyQw_003D_003D * _0023_003DqLdk3qbY7d6AmHlhbLDOyQw_003D_003D;
	}

	public static void _0023_003Dq_GTamelpPVTBg03Zhu8qgQ_003D_003D<T>(T[] _0023_003Dqq6smWlsmdwslzenVoqI2Ow_003D_003D, T _0023_003DqGJ3PUvlx3ayLDoyBSH9gGA_003D_003D)
	{
		for (int i = 0; i < _0023_003Dqq6smWlsmdwslzenVoqI2Ow_003D_003D.Length; i++)
		{
			_0023_003Dqq6smWlsmdwslzenVoqI2Ow_003D_003D[i] = _0023_003DqGJ3PUvlx3ayLDoyBSH9gGA_003D_003D;
		}
	}

	public static string _0023_003DqjV3mks7RJF58Y0poLzeu_YUQQgLUIHhOqpUe2ruWgzE_003D(ReliableRandom _0023_003DqzpQvrV1a983Hp1_SqW55JQ_003D_003D, int _0023_003DqToPgLqavPw5fhx_Jz9tWHg_003D_003D)
	{
		string text = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756831);
		StringBuilder stringBuilder = new StringBuilder(_0023_003DqToPgLqavPw5fhx_Jz9tWHg_003D_003D);
		for (int i = 0; i < _0023_003DqToPgLqavPw5fhx_Jz9tWHg_003D_003D; i++)
		{
			stringBuilder.Append(text[_0023_003DqzpQvrV1a983Hp1_SqW55JQ_003D_003D._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(0, text.Length)]);
		}
		return stringBuilder.ToString();
	}

	public static char _0023_003Dq0z9S_0024br_0024CiknCpP7BP63Kg_003D_003D(int _0023_003DqgKGCLGIsIHMirnfTSkth_0024w_003D_003D)
	{
		switch (_0023_003DqgKGCLGIsIHMirnfTSkth_0024w_003D_003D)
		{
		default:
			throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756842));
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		case 9:
			return (char)(48 + _0023_003DqgKGCLGIsIHMirnfTSkth_0024w_003D_003D);
		case 10:
		case 11:
		case 12:
		case 13:
		case 14:
		case 15:
			return (char)(65 + (_0023_003DqgKGCLGIsIHMirnfTSkth_0024w_003D_003D - 10));
		}
	}

	public static bool _0023_003DqjaczG5Ts5wSYNtttMqj_0024RoPu8Fb6Ek3UDkkEKAQ1TeQ_003D(char _0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D, out int _0023_003DquMNchDdg_0024oAr3SGhIFTc7w_003D_003D)
	{
		if (_0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D >= '0' && _0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D <= '9')
		{
			_0023_003DquMNchDdg_0024oAr3SGhIFTc7w_003D_003D = _0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D - 48;
			return true;
		}
		if (_0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D >= 'A' && _0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D <= 'F')
		{
			_0023_003DquMNchDdg_0024oAr3SGhIFTc7w_003D_003D = 10 + (_0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D - 65);
			return true;
		}
		if (_0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D >= 'a' && _0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D <= 'f')
		{
			_0023_003DquMNchDdg_0024oAr3SGhIFTc7w_003D_003D = 10 + (_0023_003DqhNmcxWnH83NT9K0KyZhKDg_003D_003D - 97);
			return true;
		}
		_0023_003DquMNchDdg_0024oAr3SGhIFTc7w_003D_003D = 0;
		return false;
	}

	public static int _0023_003DqesT_FIMLL33TFybdMhiLBQ_003D_003D(_0023_003Dq1gL_0024CIEzk66xXEU451_0024efw_003D_003D _0023_003DqM1VyunmhQejZs0TmGuMTOA_003D_003D)
	{
		return _0023_003DqM1VyunmhQejZs0TmGuMTOA_003D_003D switch
		{
			_0023_003Dq1gL_0024CIEzk66xXEU451_0024efw_003D_003D.R => 1, 
			_0023_003Dq1gL_0024CIEzk66xXEU451_0024efw_003D_003D.RGBA => 4, 
			_ => throw new _0023_003DqP1Lvlriw8JdzHp67vrhOBYFwzXCcBrFvFv_m_d2KdZA_003D(), 
		};
	}

	public static string _0023_003DqdV8QbWd1YmxtMnAs_5_00243xQ_003D_003D(this string _0023_003DqUXqY_QWVAKzi95A4edvmww_003D_003D, Range _0023_003DqbC_0024Ett9jsAfxbeon_wLdpw_003D_003D)
	{
		return _0023_003DqUXqY_QWVAKzi95A4edvmww_003D_003D.Substring(_0023_003DqbC_0024Ett9jsAfxbeon_wLdpw_003D_003D.Start, _0023_003DqbC_0024Ett9jsAfxbeon_wLdpw_003D_003D.Size);
	}

	public static void _0023_003DqSn0PAYg7NM9hn0eKTWsUUQ_003D_003D<T>(this IEnumerable<T> _0023_003DqZSDbMfb9Cfa3byklEvU6qQ_003D_003D, Action<T> _0023_003DqTNhYam5bRqhCW2FIj6e_0024vg_003D_003D)
	{
		foreach (T item in _0023_003DqZSDbMfb9Cfa3byklEvU6qQ_003D_003D)
		{
			_0023_003DqTNhYam5bRqhCW2FIj6e_0024vg_003D_003D(item);
		}
	}

	public static void _0023_003Dq_0024nGY_9C6ahFCtVXoNp4K1w_003D_003D<T>(ReliableRandom _0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D, IList<T> _0023_003DqxtG0U8p_0024kNSYE82LIyhEUg_003D_003D)
	{
		for (int num = _0023_003DqxtG0U8p_0024kNSYE82LIyhEUg_003D_003D.Count - 1; num >= 1; num--)
		{
			int index = _0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(0, num + 1);
			T value = _0023_003DqxtG0U8p_0024kNSYE82LIyhEUg_003D_003D[num];
			_0023_003DqxtG0U8p_0024kNSYE82LIyhEUg_003D_003D[num] = _0023_003DqxtG0U8p_0024kNSYE82LIyhEUg_003D_003D[index];
			_0023_003DqxtG0U8p_0024kNSYE82LIyhEUg_003D_003D[index] = value;
		}
	}

	public static List<T> _0023_003DqVnPE5yJ4CqQnLuk3oROR7Q_003D_003D<T>(this IEnumerable<T> _0023_003DqvOlCGmEPGtJugUp8Uu_0024T7w_003D_003D, ReliableRandom _0023_003DqRjwGYn5gDuFpST1AJNsC3Q_003D_003D)
	{
		List<T> list = _0023_003DqvOlCGmEPGtJugUp8Uu_0024T7w_003D_003D.ToList();
		_0023_003Dq_0024nGY_9C6ahFCtVXoNp4K1w_003D_003D(_0023_003DqRjwGYn5gDuFpST1AJNsC3Q_003D_003D, list);
		return list;
	}

	public static Maybe<T> _0023_003DqhLKNAP41uwwHTwGo6ZQwQA_003D_003D<T>(this IList<T> _0023_003DqCsGsVarJ6_PtFHlbMqtTjw_003D_003D, ReliableRandom _0023_003Dq3bcItHk2tWT4uder7amVZQ_003D_003D)
	{
		if (_0023_003DqCsGsVarJ6_PtFHlbMqtTjw_003D_003D.Count == 0)
		{
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		}
		return _0023_003Dq3bcItHk2tWT4uder7amVZQ_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(_0023_003DqCsGsVarJ6_PtFHlbMqtTjw_003D_003D);
	}

	public static Maybe<T> _0023_003DqQWl9u3tfTfw_0024HeYvh16MvA_003D_003D<T>(this IEnumerable<T> _0023_003Dq96UNDueit32SGToBLchavw_003D_003D, ReliableRandom _0023_003DqnwHaCEXfF_LVW5MzJPCNmA_003D_003D)
	{
		return _0023_003Dq96UNDueit32SGToBLchavw_003D_003D.ToArray()._0023_003DqhLKNAP41uwwHTwGo6ZQwQA_003D_003D(_0023_003DqnwHaCEXfF_LVW5MzJPCNmA_003D_003D);
	}

	[IteratorStateMachine(typeof(_0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D))]
	public static IEnumerable<T> _0023_003Dq0vfAHpqYD9ePHGWq6_uY3w_003D_003D<T>(ReliableRandom _0023_003Dqx2D8znMRxLrk_0024PhqYyTfGw_003D_003D, IEnumerable<T> _0023_003DqfMiFNJQpwtPo7Dgrks2I0A_003D_003D, IEnumerable<T> _0023_003DqyshBlGdMk8VHxC28AXfsaA_003D_003D)
	{
		return new _0023_003Dq81BUjUyswRIQ4kwCZe4OfbrsO_RJmtwU_0024eiyyYX0cEg_003D<T>(-2)
		{
			_0023_003Dq_v8XMPPFgRLJTDbIXBZILg_003D_003D = _0023_003Dqx2D8znMRxLrk_0024PhqYyTfGw_003D_003D,
			_0023_003Dq8bJLc7wW4EGONCzImVS5YA_003D_003D = _0023_003DqfMiFNJQpwtPo7Dgrks2I0A_003D_003D,
			_0023_003DqluGhmKlMtARDcYb3krdITA_003D_003D = _0023_003DqyshBlGdMk8VHxC28AXfsaA_003D_003D
		};
	}

	public static IOrderedEnumerable<TSource> _0023_003DqNi5rr3loyTkNnQNLegNEJkQFFWAkNK27Mi15kO6_0024oUU_003D<TSource, TKey>(this IEnumerable<TSource> _0023_003DqUK0fhIL392_0024ulcgYf9PjBg_003D_003D, Func<TSource, TKey> _0023_003DqCTqEj264QufG2xAUlS5p6Q_003D_003D, IEnumerable<TKey> _0023_003DqeEm0pTx9o2z0ibRF9c_0024OLg_003D_003D)
	{
		_0023_003Dqsa9Xi2OekBcJF_00240vQb0QzsSEFH_0024pLa5Yz3Xph9tPvY8_003D<TSource, TKey> CS_0024_003C_003E8__locals9 = new _0023_003Dqsa9Xi2OekBcJF_00240vQb0QzsSEFH_0024pLa5Yz3Xph9tPvY8_003D<TSource, TKey>();
		CS_0024_003C_003E8__locals9._0023_003Dqx8ypK5XIBn8SM00fG5fGLw_003D_003D = _0023_003DqCTqEj264QufG2xAUlS5p6Q_003D_003D;
		CS_0024_003C_003E8__locals9._0023_003DqzngLJFBPxxIlFxOMhBKvwTpbQZ2anDrRV3j66o_7Eq0_003D = new Dictionary<TKey, int>();
		CS_0024_003C_003E8__locals9._0023_003DqDtPwEEuRghIA70lzVMdfmQ_003D_003D = 0;
		foreach (TKey item in _0023_003DqeEm0pTx9o2z0ibRF9c_0024OLg_003D_003D)
		{
			CS_0024_003C_003E8__locals9._0023_003DqzngLJFBPxxIlFxOMhBKvwTpbQZ2anDrRV3j66o_7Eq0_003D[item] = CS_0024_003C_003E8__locals9._0023_003DqDtPwEEuRghIA70lzVMdfmQ_003D_003D++;
		}
		return _0023_003DqUK0fhIL392_0024ulcgYf9PjBg_003D_003D.OrderBy(delegate(TSource _0023_003DqXbEROrx9DAqX2_0024Qwh0doFQ_003D_003D)
		{
			TKey key = CS_0024_003C_003E8__locals9._0023_003Dqx8ypK5XIBn8SM00fG5fGLw_003D_003D(_0023_003DqXbEROrx9DAqX2_0024Qwh0doFQ_003D_003D);
			return CS_0024_003C_003E8__locals9._0023_003DqzngLJFBPxxIlFxOMhBKvwTpbQZ2anDrRV3j66o_7Eq0_003D.ContainsKey(key) ? CS_0024_003C_003E8__locals9._0023_003DqzngLJFBPxxIlFxOMhBKvwTpbQZ2anDrRV3j66o_7Eq0_003D[key] : CS_0024_003C_003E8__locals9._0023_003DqDtPwEEuRghIA70lzVMdfmQ_003D_003D;
		});
	}

	public static Maybe<T> _0023_003DqwgC4EGrGw3mLo2TGE6erqQ_003D_003D<T>(this IEnumerable<T> _0023_003DqTCh3b_WxML0cD2MSd_eAKQ_003D_003D)
	{
		IEnumerator<T> enumerator = _0023_003DqTCh3b_WxML0cD2MSd_eAKQ_003D_003D.GetEnumerator();
		if (enumerator.MoveNext())
		{
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqviLfXxoe0_lhumqA0McvDA_003D_003D(enumerator.Current);
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public static Maybe<T> _0023_003DqzCziFrFQETjLGiNXYpsrKA_003D_003D<T>(this IEnumerable<T> _0023_003DqsXP_00242fi4nqymWf1B4_PhuA_003D_003D, Predicate<T> _0023_003DqN9HuFY09G8mE7TrqcdK1lg_003D_003D)
	{
		foreach (T item in _0023_003DqsXP_00242fi4nqymWf1B4_PhuA_003D_003D)
		{
			if (_0023_003DqN9HuFY09G8mE7TrqcdK1lg_003D_003D(item))
			{
				return item;
			}
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public static Maybe<T> _0023_003DqebgHsLLhE18NPaPsJP7h7w_003D_003D<T>(this IList<T> _0023_003DqX36SFDhmer43ek6bBXlgvQ_003D_003D)
	{
		if (_0023_003DqX36SFDhmer43ek6bBXlgvQ_003D_003D.Count > 0)
		{
			return _0023_003DqX36SFDhmer43ek6bBXlgvQ_003D_003D[_0023_003DqX36SFDhmer43ek6bBXlgvQ_003D_003D.Count - 1];
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public static Maybe<T> _0023_003Dq6dw1msOAwkWbO6qpFFMFFw_003D_003D<T>(this IEnumerable<T> _0023_003Dq5LVu9mwnzN8OldaD9om4ww_003D_003D)
	{
		if (_0023_003Dq5LVu9mwnzN8OldaD9om4ww_003D_003D.Any())
		{
			return _0023_003Dq5LVu9mwnzN8OldaD9om4ww_003D_003D.Last();
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public static Maybe<T> _0023_003DqPmNbs5qjgTOdoxwZ2F2nrw_003D_003D<T>(this IEnumerable<T> _0023_003DqzwzKsxXNTdQjL_gQbNz__0024A_003D_003D, Func<T, bool> _0023_003DqoG2tZfK6dk4XtUB2zLOeJA_003D_003D)
	{
		return _0023_003DqzwzKsxXNTdQjL_gQbNz__0024A_003D_003D.Where(_0023_003DqoG2tZfK6dk4XtUB2zLOeJA_003D_003D)._0023_003Dq6dw1msOAwkWbO6qpFFMFFw_003D_003D();
	}

	public static Maybe<int> _0023_003DqeMMd9Uyes_LaQungraWf__U_0024uMgTDo9MfiZcDetCM9U_003D<T>(this IEnumerable<T> _0023_003Dq5inA6i5_0024vX1ZiO0VYsXeDA_003D_003D, T _0023_003DqDNL5DrePaK_00247GFL_0024E38h3A_003D_003D) where T : IEquatable<T>
	{
		int num = 0;
		foreach (T item in _0023_003Dq5inA6i5_0024vX1ZiO0VYsXeDA_003D_003D)
		{
			if (item.Equals(_0023_003DqDNL5DrePaK_00247GFL_0024E38h3A_003D_003D))
			{
				return num;
			}
			num++;
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public static int _0023_003DqwNWqyeZ3_0024ar_0024p7n5W_3Fpw_003D_003D<T>(this T[] _0023_003DqaaC_0024tdlYwEo8yN7t9Sp1ag_003D_003D, T _0023_003DqwMI35S5gM3hkm7Tfoh2xgA_003D_003D)
	{
		for (int i = 0; i < _0023_003DqaaC_0024tdlYwEo8yN7t9Sp1ag_003D_003D.Length; i++)
		{
			if (_0023_003DqaaC_0024tdlYwEo8yN7t9Sp1ag_003D_003D[i].Equals(_0023_003DqwMI35S5gM3hkm7Tfoh2xgA_003D_003D))
			{
				return i;
			}
		}
		return -1;
	}

	public static Maybe<int> _0023_003DqUxDKTRyhtJLaa3A157rmCN_0024H8xhZnvtKROfAWvT_0024tLc_003D<T>(this IEnumerable<T> _0023_003DqpMrbr0eN91pFGv_oxOr0sg_003D_003D, Func<T, bool> _0023_003DqqOtCZwo7rwZqQ79W_xpReA_003D_003D)
	{
		int num = 0;
		foreach (T item in _0023_003DqpMrbr0eN91pFGv_oxOr0sg_003D_003D)
		{
			if (_0023_003DqqOtCZwo7rwZqQ79W_xpReA_003D_003D(item))
			{
				return num;
			}
			num++;
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public static void _0023_003Dq8vsTI3Hkeg_0024P950FESEgoNPn_FPw_X4kW6GyiE4Phd0_003D<T>(this List<T> _0023_003DqhCK0_xREk4T88QlIR6eOYw_003D_003D, int _0023_003DqL7zFmH93Xx8y4ll4UpuDoQ_003D_003D)
	{
		_0023_003DqhCK0_xREk4T88QlIR6eOYw_003D_003D.RemoveRange(_0023_003DqL7zFmH93Xx8y4ll4UpuDoQ_003D_003D, _0023_003DqhCK0_xREk4T88QlIR6eOYw_003D_003D.Count - _0023_003DqL7zFmH93Xx8y4ll4UpuDoQ_003D_003D);
	}

	public static List<T> _0023_003DqT3xIsDkzi_7_205QYyjWag_003D_003D<T>(this List<T> _0023_003DqbRiOhwUel9alXHpbl1EbpQ_003D_003D, T _0023_003DqpLYkBf1qloFYCKcMYgdPGA_003D_003D)
	{
		List<T> list = _0023_003DqbRiOhwUel9alXHpbl1EbpQ_003D_003D.ToList();
		list.Add(_0023_003DqpLYkBf1qloFYCKcMYgdPGA_003D_003D);
		return list;
	}

	public static T _0023_003Dq9cPgdzUl7_SRAAS_Rguupw_003D_003D<T>(this List<T> _0023_003Dq0UmKYurcUv_Kd01yYc_c_A_003D_003D)
	{
		int index = _0023_003Dq0UmKYurcUv_Kd01yYc_c_A_003D_003D.Count - 1;
		T result = _0023_003Dq0UmKYurcUv_Kd01yYc_c_A_003D_003D[index];
		_0023_003Dq0UmKYurcUv_Kd01yYc_c_A_003D_003D.RemoveAt(index);
		return result;
	}

	public static void _0023_003DqldZlAV705aD_0024yRXq6ivlew_003D_003D<T>(this List<T> _0023_003DqRj3UJkQw4dQ4Ym3HPDyJzA_003D_003D)
	{
		_0023_003DqRj3UJkQw4dQ4Ym3HPDyJzA_003D_003D.RemoveAt(_0023_003DqRj3UJkQw4dQ4Ym3HPDyJzA_003D_003D.Count - 1);
	}

	public static string _0023_003DqaT_00248Pb5ixk3Jgz4yjh0VOw_003D_003D(this string _0023_003DqJAHPcA9dgsd37QbqTJDI2Q_003D_003D)
	{
		return _0023_003DqJAHPcA9dgsd37QbqTJDI2Q_003D_003D.Replace('‘', '\'').Replace('’', '\'').Replace('“', '"')
			.Replace('”', '"')
			.Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756901), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065789454))
			.Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808010), string.Empty);
	}

	public static bool _0023_003Dqmydex8eAV4kKL8V3Qlhoyg_003D_003D<T>(this IList<T> _0023_003Dq561Upi0IT0f3DjRBdfrrxg_003D_003D) where T : IEquatable<T>
	{
		for (int i = 0; i < _0023_003Dq561Upi0IT0f3DjRBdfrrxg_003D_003D.Count; i++)
		{
			for (int j = i + 1; j < _0023_003Dq561Upi0IT0f3DjRBdfrrxg_003D_003D.Count; j++)
			{
				if (_0023_003Dq561Upi0IT0f3DjRBdfrrxg_003D_003D[i].Equals(_0023_003Dq561Upi0IT0f3DjRBdfrrxg_003D_003D[j]))
				{
					return false;
				}
			}
		}
		return true;
	}

	public static int _0023_003DqooLp58vGSfRketzaUh_lsA_003D_003D(int _0023_003Dqh1l0iC7YUy_ILrKbLg_0024qkg_003D_003D, int _0023_003Dq0KwQ18xc4yTwGAzmUf4piQ_003D_003D)
	{
		_0023_003Dqh1l0iC7YUy_ILrKbLg_0024qkg_003D_003D = Math.Abs(_0023_003Dqh1l0iC7YUy_ILrKbLg_0024qkg_003D_003D);
		return _0023_003Dqh1l0iC7YUy_ILrKbLg_0024qkg_003D_003D / (int)Math.Pow(10.0, _0023_003Dq0KwQ18xc4yTwGAzmUf4piQ_003D_003D) % 10;
	}

	public static string _0023_003DqHgbuGJzh9Te2cJwZs44MnKLzEeTaUN_9WG_7Ivgbuuw_003D(int _0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D)
	{
		if (_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D >= 1000000000)
		{
			return _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756928);
		}
		if (_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D >= 100000000)
		{
			return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756913), (float)_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D / 1000000f);
		}
		if (_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D >= 1000000)
		{
			return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756936), (float)_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D / 1000000f);
		}
		if (_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D >= 100000)
		{
			return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756952), (float)_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D / 1000f);
		}
		if (_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D >= 10000)
		{
			return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756971), (float)_0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D / 1000f);
		}
		return _0023_003DqgtWO_7YpFFGjz3t95Uajmg_003D_003D.ToString();
	}

	public static string _0023_003Dqtc5sNgYvIGnVTWVUGTR5GA_003D_003D(this string _0023_003DqMgCHBE5Zx53NGg11hTnucQ_003D_003D)
	{
		return _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065705613) + _0023_003DqMgCHBE5Zx53NGg11hTnucQ_003D_003D + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065705613);
	}

	public static string _0023_003DqRJ45dZLPef4hMrVZobZRDQ_003D_003D(this string _0023_003DqURzgQrnzHTNwyN2COds_0024Jg_003D_003D, bool _0023_003DqDRj_00241D98Z8gs4ics4kIjoQ_003D_003D)
	{
		if (!_0023_003DqDRj_00241D98Z8gs4ics4kIjoQ_003D_003D)
		{
			return _0023_003DqURzgQrnzHTNwyN2COds_0024Jg_003D_003D;
		}
		return _0023_003DqURzgQrnzHTNwyN2COds_0024Jg_003D_003D._0023_003Dqtc5sNgYvIGnVTWVUGTR5GA_003D_003D();
	}

	public static string _0023_003DqF7_7AizW2rzSoo4iay2DnA_003D_003D(this string _0023_003DqBbTqLcmB2KzOPqcdVBcNbg_003D_003D)
	{
		return _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065792029) + _0023_003DqBbTqLcmB2KzOPqcdVBcNbg_003D_003D + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065792029);
	}

	public static string _0023_003DqLGinzsH2bcUg8sjRwlkR2Q_003D_003D(this string _0023_003DqnavjAJf3_0024J9Bp_0024enZanlwA_003D_003D, bool _0023_003Dqy9pkt_kMqPQueF4vIXLNnw_003D_003D)
	{
		if (!_0023_003Dqy9pkt_kMqPQueF4vIXLNnw_003D_003D)
		{
			return _0023_003DqnavjAJf3_0024J9Bp_0024enZanlwA_003D_003D;
		}
		return _0023_003DqnavjAJf3_0024J9Bp_0024enZanlwA_003D_003D._0023_003DqF7_7AizW2rzSoo4iay2DnA_003D_003D();
	}

	public static string _0023_003DqYLZxBz9H4hfpqG7rb94bFw_003D_003D(this string _0023_003DqUlaIYPzNDCZMIuutavm6CA_003D_003D)
	{
		return _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756987) + _0023_003DqUlaIYPzNDCZMIuutavm6CA_003D_003D + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756987);
	}

	public static string _0023_003Dq0_0024Ku4hkUPiHHlItaZOwtR6tHbQwH4NQ96KPpzD_CJEQ_003D(this string _0023_003Dq3FOMF5A_0024___0024NS628rCuV3w_003D_003D)
	{
		return _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757006) + _0023_003Dq3FOMF5A_0024___0024NS628rCuV3w_003D_003D + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757006);
	}

	public static string _0023_003DqkLEPiDsPkM7hVLfqLvdJ5b9Snc0F60BB9qs3u__0024JjI4_003D(this string _0023_003DqZInV5GvosbCx3IpqQJb7sA_003D_003D)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < _0023_003DqZInV5GvosbCx3IpqQJb7sA_003D_003D.Length; i++)
		{
			stringBuilder.Append(_0023_003DqZInV5GvosbCx3IpqQJb7sA_003D_003D[i]);
			if (i < _0023_003DqZInV5GvosbCx3IpqQJb7sA_003D_003D.Length - 1)
			{
				stringBuilder.Append(' ');
			}
		}
		return stringBuilder.ToString();
	}

	public static string _0023_003DqSwIx3opeQHapfBW6H5Ma4EBhjdblvzlEV1v_EPH3Zrw_003D(this string _0023_003Dq4l8YUzNwCyGZnq89NSM7VQ_003D_003D)
	{
		return _0023_003Dq4l8YUzNwCyGZnq89NSM7VQ_003D_003D.Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065705643), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756997)).Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065705613), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777743)).Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065792029), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757024))
			.Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756987), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757015))
			.Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757006), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757036));
	}

	public static T[] _0023_003DqcGwKASyUC2G1qUpx5ORczg_003D_003D<T>(T[] _0023_003DqT7_0024_0024Lz_oo8niwci1tI41Og_003D_003D)
	{
		T[] array = new T[_0023_003DqT7_0024_0024Lz_oo8niwci1tI41Og_003D_003D.Length];
		Array.Copy(_0023_003DqT7_0024_0024Lz_oo8niwci1tI41Og_003D_003D, array, _0023_003DqT7_0024_0024Lz_oo8niwci1tI41Og_003D_003D.Length);
		return array;
	}

	public static TValue _0023_003Dqmvo0AD8tTwhMe_kxqHx9mGEQ_OFbqWmNklzYC8v8pFY_003D<TKey, TValue>(this IDictionary<TKey, TValue> _0023_003DqTQ6BFy7uV7JTSTeYiJsuqA_003D_003D, TKey _0023_003Dq4f7sLPUbtw8jaqtgCCZm1w_003D_003D, TValue _0023_003DqsfRToyFlEZfg8sybHYx3Ag_003D_003D)
	{
		if (!_0023_003DqTQ6BFy7uV7JTSTeYiJsuqA_003D_003D.TryGetValue(_0023_003Dq4f7sLPUbtw8jaqtgCCZm1w_003D_003D, out var value))
		{
			value = _0023_003DqsfRToyFlEZfg8sybHYx3Ag_003D_003D;
			_0023_003DqTQ6BFy7uV7JTSTeYiJsuqA_003D_003D[_0023_003Dq4f7sLPUbtw8jaqtgCCZm1w_003D_003D] = _0023_003DqsfRToyFlEZfg8sybHYx3Ag_003D_003D;
		}
		return value;
	}

	public static void _0023_003DqAqdrZWqRgxOSVmuMVEB8Yw_003D_003D<K, V>(this IDictionary<K, List<V>> _0023_003DqNHQsGJwRNHJpy7uiq4viVw_003D_003D, K _0023_003DqzL8yMQLeT_0024qCCZW_0024IJc_0024AA_003D_003D, V _0023_003DqWgXVeExjEa_00242BffEPss1VA_003D_003D)
	{
		if (!_0023_003DqNHQsGJwRNHJpy7uiq4viVw_003D_003D.TryGetValue(_0023_003DqzL8yMQLeT_0024qCCZW_0024IJc_0024AA_003D_003D, out var value))
		{
			value = new List<V>();
			_0023_003DqNHQsGJwRNHJpy7uiq4viVw_003D_003D.Add(_0023_003DqzL8yMQLeT_0024qCCZW_0024IJc_0024AA_003D_003D, value);
		}
		value.Add(_0023_003DqWgXVeExjEa_00242BffEPss1VA_003D_003D);
	}

	public static string _0023_003DqdFakUsysdzboAC7dZ3UzTBqLrRe9Dc_f0V9djBfAYzk_003D(Type _0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D)
	{
		if (_0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D.IsArray)
		{
			return _0023_003DqdFakUsysdzboAC7dZ3UzTBqLrRe9Dc_f0V9djBfAYzk_003D(_0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D.GetElementType()) + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757053);
		}
		if (_0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D.IsGenericType)
		{
			string text = _0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D.Name;
			int num = text.IndexOf('`');
			if (num > 0)
			{
				text = text.Remove(num);
			}
			text += _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757048);
			bool flag = true;
			Type[] genericArguments = _0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D.GetGenericArguments();
			foreach (Type _0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D2 in genericArguments)
			{
				if (!flag)
				{
					text += _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065787888);
				}
				flag = false;
				text += _0023_003DqdFakUsysdzboAC7dZ3UzTBqLrRe9Dc_f0V9djBfAYzk_003D(_0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D2);
			}
			return text + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757072);
		}
		return _0023_003DqjY9E61w99T28a5KZl_zmkA_003D_003D.Name;
	}

	public static int _0023_003DqKaKs84b_2ueW6F6p3ad5wg_003D_003D(this IEnumerable<int> _0023_003Dq8KOw3hujr23vYCXX5hQq3w_003D_003D, int _0023_003DqK2Iiesx5xU_RkJe58eSVcg_003D_003D)
	{
		if (_0023_003Dq8KOw3hujr23vYCXX5hQq3w_003D_003D.Any())
		{
			return _0023_003Dq8KOw3hujr23vYCXX5hQq3w_003D_003D.Max();
		}
		return _0023_003DqK2Iiesx5xU_RkJe58eSVcg_003D_003D;
	}

	public static T _0023_003Dq7vlz_x1rterIXWOJOcZBhw_003D_003D<T>(this IEnumerable<T> _0023_003DqsPrz7POLKHYarGMjXnAN9g_003D_003D)
	{
		int num = _0023_003DqsPrz7POLKHYarGMjXnAN9g_003D_003D.Count();
		return _0023_003DqsPrz7POLKHYarGMjXnAN9g_003D_003D.OrderBy(_003C_003Ec__66<T>._003C_003E9._0023_003Dqh58zRHr5S8xIYaR7qOgnexDW42V8cAFHRpKaG70Qlpg_003D).Skip(num / 2).First();
	}

	public static int _0023_003DqplK8cFn1A03oUP4_0024Cl1k0Q_003D_003D(int _0023_003Dq6_00244vdzJvTM0_kDJQ53Y2sw_003D_003D)
	{
		if (_0023_003Dq6_00244vdzJvTM0_kDJQ53Y2sw_003D_003D < 0)
		{
			throw new ArgumentOutOfRangeException(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757064), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757088));
		}
		return (int)Math.Pow(2.0, Math.Ceiling(Math.Log(_0023_003Dq6_00244vdzJvTM0_kDJQ53Y2sw_003D_003D, 2.0)));
	}

	public static string _0023_003Dqua0xsPLkZsCNnloHPfn3rQ_003D_003D(this string _0023_003DqmdO09gSjdatFSqlyAYib_0024A_003D_003D, string _0023_003DqCjlaxECSMCQnuhjp5KoluQ_003D_003D, string _0023_003Dq5xpNBUI1Peh048u763ywWg_003D_003D)
	{
		int num = _0023_003DqmdO09gSjdatFSqlyAYib_0024A_003D_003D.IndexOf(_0023_003DqCjlaxECSMCQnuhjp5KoluQ_003D_003D);
		if (num >= 0)
		{
			return _0023_003DqmdO09gSjdatFSqlyAYib_0024A_003D_003D.Substring(0, num) + _0023_003Dq5xpNBUI1Peh048u763ywWg_003D_003D + _0023_003DqmdO09gSjdatFSqlyAYib_0024A_003D_003D.Substring(num + _0023_003DqCjlaxECSMCQnuhjp5KoluQ_003D_003D.Length);
		}
		return _0023_003DqmdO09gSjdatFSqlyAYib_0024A_003D_003D;
	}

	public static IEnumerable<TSource> _0023_003DqS_TJx6_aH1Jr2f8dlamGOg_003D_003D<TSource>(this IEnumerable<TSource> _0023_003DqktKNatpHSej4MgB6GD39KA_003D_003D, TSource _0023_003DqHTiOumtaHLG8_0024qGiuNYq5w_003D_003D)
	{
		return _0023_003DqktKNatpHSej4MgB6GD39KA_003D_003D.Concat(new TSource[1] { _0023_003DqHTiOumtaHLG8_0024qGiuNYq5w_003D_003D });
	}

	public static bool _0023_003DqDHmvCu0iDXMVAPSTeckGcg_003D_003D<T>(this IList<T> _0023_003DqvhIPW4SAC_856VJv6dow1Q_003D_003D, int _0023_003DqlQET7ApPpIVmZlCrYZVgNw_003D_003D)
	{
		if (0 <= _0023_003DqlQET7ApPpIVmZlCrYZVgNw_003D_003D)
		{
			return _0023_003DqlQET7ApPpIVmZlCrYZVgNw_003D_003D < _0023_003DqvhIPW4SAC_856VJv6dow1Q_003D_003D.Count;
		}
		return false;
	}

	[IteratorStateMachine(typeof(_0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D))]
	public static IEnumerable<T> _0023_003DqKfxDUAPNzUuXuWbLAR7Hrw_003D_003D<T>(this IList<T> _0023_003DqBgrMlubT7_sJ8iU8Z10Waw_003D_003D)
	{
		return new _0023_003DqQG6_YV25mkReZ6judmvtfojbbW0GGZKWPfHKh_BMdnw_003D<T>(-2)
		{
			_0023_003Dq8UH7Dl8xlpleXpYwZh78Og_003D_003D = _0023_003DqBgrMlubT7_sJ8iU8Z10Waw_003D_003D
		};
	}

	public static List<T> _0023_003DqKklv5nSOwZwqXqGUfY2k6g_003D_003D<T>(this IEnumerable<T> _0023_003DqOVLuj6tZFqlpzwX0_JZtXw_003D_003D, Func<T, int> _0023_003DqUXyIqQPCmV9poHeBREgw7w_003D_003D)
	{
		List<T> list = new List<T>();
		int num = int.MinValue;
		foreach (T item in _0023_003DqOVLuj6tZFqlpzwX0_JZtXw_003D_003D)
		{
			int num2 = _0023_003DqUXyIqQPCmV9poHeBREgw7w_003D_003D(item);
			if (num2 > num)
			{
				num = num2;
				list.Clear();
			}
			if (num2 == num)
			{
				list.Add(item);
			}
		}
		return list;
	}

	public static List<T> _0023_003DqAd5mpzaY8Wu1ivh7HJBdzQ_003D_003D<T>(this IEnumerable<T> _0023_003DqFLBi0VwaqkZYEA_0024RemLx9Q_003D_003D, Func<T, int> _0023_003Dq9MtiLY3MIrDkLf85O37iyg_003D_003D)
	{
		_0023_003DqVjnUf_0024fektJ4NwKpK3I7uLTJtxf4IEBuFMCFDlZtGwY_003D<T> CS_0024_003C_003E8__locals2 = new _0023_003DqVjnUf_0024fektJ4NwKpK3I7uLTJtxf4IEBuFMCFDlZtGwY_003D<T>();
		CS_0024_003C_003E8__locals2._0023_003DqLcXWpP_bTtH3MQH15nRXNg_003D_003D = _0023_003Dq9MtiLY3MIrDkLf85O37iyg_003D_003D;
		return _0023_003DqFLBi0VwaqkZYEA_0024RemLx9Q_003D_003D._0023_003DqKklv5nSOwZwqXqGUfY2k6g_003D_003D((T _0023_003DqoYSk6pwgwt6d26P80Y_00249PA_003D_003D) => -CS_0024_003C_003E8__locals2._0023_003DqLcXWpP_bTtH3MQH15nRXNg_003D_003D(_0023_003DqoYSk6pwgwt6d26P80Y_00249PA_003D_003D));
	}

	public static bool _0023_003Dq_0024sAyWKsdUpF_wY_lSPoUuQ_003D_003D<T>(IList<T> _0023_003Dq_0024uMlI3v_kq1HHTaGZFNC1A_003D_003D, IList<T> _0023_003DqFGK6jepuMume6TXsdLCgJA_003D_003D, Func<T, T, bool> _0023_003Dqcw9Txj1ZJpBG0HgybOCWWQ_003D_003D)
	{
		if (_0023_003Dq_0024uMlI3v_kq1HHTaGZFNC1A_003D_003D.Count != _0023_003DqFGK6jepuMume6TXsdLCgJA_003D_003D.Count)
		{
			return false;
		}
		for (int i = 0; i < _0023_003Dq_0024uMlI3v_kq1HHTaGZFNC1A_003D_003D.Count; i++)
		{
			if (!_0023_003Dqcw9Txj1ZJpBG0HgybOCWWQ_003D_003D(_0023_003Dq_0024uMlI3v_kq1HHTaGZFNC1A_003D_003D[i], _0023_003DqFGK6jepuMume6TXsdLCgJA_003D_003D[i]))
			{
				return false;
			}
		}
		return true;
	}

	public static float _0023_003DqiEmQBVkZ8gPVKv1iILyGPw_003D_003D(this float _0023_003DqcAWXp6GZTDA_pMO0yuynqQ_003D_003D)
	{
		return 2f * (float)Math.Round(0.5f * _0023_003DqcAWXp6GZTDA_pMO0yuynqQ_003D_003D);
	}

	public static float _0023_003DqdegsMpujN8Z49yVxNns_cA_003D_003D(this float _0023_003DqTO_zVdu5cwPrqJ0zkKcbPQ_003D_003D)
	{
		return (float)Math.Floor(_0023_003DqTO_zVdu5cwPrqJ0zkKcbPQ_003D_003D / 2f) * 2f;
	}

	public static HashSet<T> _0023_003Dq8_kYyj3Kna1y014CWnfYkw_003D_003D<T>(this IEnumerable<T> _0023_003Dqw4OfP_0024sOwQV0rsw1BMleDw_003D_003D)
	{
		return new HashSet<T>(_0023_003Dqw4OfP_0024sOwQV0rsw1BMleDw_003D_003D);
	}

	public static float _0023_003DqreV3rmn8muBgCl0ppnnzdA_003D_003D(this float _0023_003DqGlh4Ow6S0xy4uhuR0_qC5Q_003D_003D)
	{
		return _0023_003DqGlh4Ow6S0xy4uhuR0_qC5Q_003D_003D * _0023_003DqGlh4Ow6S0xy4uhuR0_qC5Q_003D_003D;
	}

	public static byte[] _0023_003DqoKjZuEUznNJD9_0024NqzWYopQ_003D_003D(byte[] _0023_003Dqci7_00240M03uY5m9CBRRHXtOQ_003D_003D)
	{
		MemoryStream memoryStream = new MemoryStream(_0023_003Dqci7_00240M03uY5m9CBRRHXtOQ_003D_003D);
		try
		{
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				GZipStream gZipStream = new GZipStream(memoryStream2, CompressionMode.Compress);
				try
				{
					memoryStream.CopyTo(gZipStream);
					gZipStream.Close();
					return memoryStream2.ToArray();
				}
				finally
				{
					((IDisposable)gZipStream).Dispose();
				}
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static byte[] _0023_003DqO_UWZnAvMx7jCHnL2bCwnCM0Ey_0024DWAxUQjBsOMZyHQo_003D(byte[] _0023_003DqAMq9KmBDujGtpiHOL3CvsQ_003D_003D)
	{
		MemoryStream memoryStream = new MemoryStream(_0023_003DqAMq9KmBDujGtpiHOL3CvsQ_003D_003D);
		try
		{
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
				try
				{
					gZipStream.CopyTo(memoryStream2);
					return memoryStream2.ToArray();
				}
				finally
				{
					((IDisposable)gZipStream).Dispose();
				}
			}
			finally
			{
				((IDisposable)memoryStream2).Dispose();
			}
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	public static bool _0023_003DqXE4Vvr9kOTs8AwoD4eZOCQ_003D_003D<T>(T _0023_003DqfvU_0024eby2kr8Dq_0Auaj8GA_003D_003D, T _0023_003Dqv6sNqFvY_hpmHEwSwYYenw_003D_003D, Predicate<T> _0023_003DqlJ2id_rgNuweMqIE6eCq2Q_003D_003D, Predicate<T> _0023_003Dq1NFRm_0024kAlK3Wpb3ViRI_00249Q_003D_003D)
	{
		if (!_0023_003DqlJ2id_rgNuweMqIE6eCq2Q_003D_003D(_0023_003DqfvU_0024eby2kr8Dq_0Auaj8GA_003D_003D) || !_0023_003Dq1NFRm_0024kAlK3Wpb3ViRI_00249Q_003D_003D(_0023_003Dqv6sNqFvY_hpmHEwSwYYenw_003D_003D))
		{
			if (_0023_003Dq1NFRm_0024kAlK3Wpb3ViRI_00249Q_003D_003D(_0023_003DqfvU_0024eby2kr8Dq_0Auaj8GA_003D_003D))
			{
				return _0023_003DqlJ2id_rgNuweMqIE6eCq2Q_003D_003D(_0023_003Dqv6sNqFvY_hpmHEwSwYYenw_003D_003D);
			}
			return false;
		}
		return true;
	}

	public static List<string> _0023_003DqxnuVY_00246fOx141y9w0ivelw_003D_003D(string _0023_003DqBtxKlOPyg9UTHIcSepUCMA_003D_003D)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		bool flag2 = false;
		foreach (char c in _0023_003DqBtxKlOPyg9UTHIcSepUCMA_003D_003D)
		{
			switch (c)
			{
			case '"':
				flag2 = !flag2;
				if (flag)
				{
					stringBuilder.Append('"');
					flag = false;
				}
				else
				{
					flag = true;
				}
				continue;
			case ',':
				if (!flag2)
				{
					list.Add(stringBuilder.ToString().Trim());
					stringBuilder.Length = 0;
					flag = false;
					flag2 = false;
					continue;
				}
				break;
			}
			stringBuilder.Append(c);
			flag = false;
		}
		list.Add(stringBuilder.ToString().Trim());
		return list;
	}
}
