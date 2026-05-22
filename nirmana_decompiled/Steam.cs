using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;

public static class Steam
{
	private sealed class _0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D<_0023_003DqAuCl__LMsBT1kW57YyojQQ_003D_003D>
	{
		public CallResult<_0023_003DqAuCl__LMsBT1kW57YyojQQ_003D_003D> _0023_003DqcUrhob6kNv_0024bMjIMMUBFYQ_003D_003D;

		public CallResult<_0023_003DqAuCl__LMsBT1kW57YyojQQ_003D_003D>.APIDispatchDelegate _0023_003DqIgXiFKKacbx4MYrY4oCfnQ_003D_003D;

		internal void _0023_003DqT8HDH5GuCAkcOppztxCAcKdar3G7L5aNqtAzR9tJ5ag_003D(_0023_003DqAuCl__LMsBT1kW57YyojQQ_003D_003D _0023_003DqzNHL2Mj8_73szFHEQdysvw_003D_003D, bool _0023_003DqVFM36mrAl_0024J14E2ImQmfrw_003D_003D)
		{
			_0023_003Dq01UCIImSXo_0024vZUt7VzWMeQ_003D_003D.Remove(_0023_003DqcUrhob6kNv_0024bMjIMMUBFYQ_003D_003D);
			_0023_003DqIgXiFKKacbx4MYrY4oCfnQ_003D_003D(_0023_003DqzNHL2Mj8_73szFHEQdysvw_003D_003D, _0023_003DqVFM36mrAl_0024J14E2ImQmfrw_003D_003D);
		}
	}

	private sealed class _0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D> : IEnumerator<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D>, IEnumerable<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D>, IEnumerable, IEnumerator, IDisposable where _0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D : struct
	{
		private int _0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D;

		private _0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D _0023_003Dqw5Es3BtW4XmELafcnPoICA_003D_003D;

		private int _0023_003Dq_4TrXm0DrZawjn4E3KY8t_4uqhBeeoz12guda4MO_0024ek_003D;

		private Func<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D, bool> _0023_003DqvFhIuckcMxXiACNa4Ct0sg_003D_003D;

		public Func<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D, bool> _0023_003DqO_0024olJ0W9TM4wpqjhUApc8A_003D_003D;

		private List<object> _0023_003DqLZ6oiX5aohuxaOoOSuq25w_003D_003D;

		private List<object>.Enumerator _0023_003DqCPU0BpRRr_0024YKh1ApFax24g_003D_003D;

		private object _0023_003DqKQRLXS0asQx2kR6cZhbhYA_003D_003D;

		[DebuggerHidden]
		public _0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D(int _0023_003DqAhkLbhmDHi17_0024aCYh2GMGg_003D_003D)
		{
			_0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D = _0023_003DqAhkLbhmDHi17_0024aCYh2GMGg_003D_003D;
			_0023_003Dq_4TrXm0DrZawjn4E3KY8t_4uqhBeeoz12guda4MO_0024ek_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003DqTAyAX7hnx2HbwPXfjz0mjyG1iipRNYK0XSnriMiPKcs_003D()
		{
			int num = _0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_0023_003Dq3WNS7AshSdeRricduvBWMQ_003D_003D();
				}
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qTAyAX7hnx2HbwPXfjz0mjyG1iipRNYK0XSnriMiPKcs=
			this._0023_003DqTAyAX7hnx2HbwPXfjz0mjyG1iipRNYK0XSnriMiPKcs_003D();
		}

		private bool MoveNext()
		{
			try
			{
				int num = _0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D = -3;
					_0023_003DqLZ6oiX5aohuxaOoOSuq25w_003D_003D.Add(_0023_003DqKQRLXS0asQx2kR6cZhbhYA_003D_003D);
					goto IL_00ba;
				}
				_0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D = -1;
				_0023_003DqLZ6oiX5aohuxaOoOSuq25w_003D_003D = new List<object>();
				_0023_003DqCPU0BpRRr_0024YKh1ApFax24g_003D_003D = _0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.GetEnumerator();
				_0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D = -3;
				goto IL_00c1;
				IL_00ba:
				_0023_003DqKQRLXS0asQx2kR6cZhbhYA_003D_003D = null;
				goto IL_00c1;
				IL_00c1:
				if (_0023_003DqCPU0BpRRr_0024YKh1ApFax24g_003D_003D.MoveNext())
				{
					_0023_003DqKQRLXS0asQx2kR6cZhbhYA_003D_003D = _0023_003DqCPU0BpRRr_0024YKh1ApFax24g_003D_003D.Current;
					_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D? val = _0023_003DqKQRLXS0asQx2kR6cZhbhYA_003D_003D as _0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D?;
					if (val.HasValue && _0023_003DqvFhIuckcMxXiACNa4Ct0sg_003D_003D(val.Value))
					{
						_0023_003Dqw5Es3BtW4XmELafcnPoICA_003D_003D = val.Value;
						_0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D = 1;
						return true;
					}
					goto IL_00ba;
				}
				_0023_003Dq3WNS7AshSdeRricduvBWMQ_003D_003D();
				_0023_003DqCPU0BpRRr_0024YKh1ApFax24g_003D_003D = default(List<object>.Enumerator);
				foreach (object item in _0023_003DqLZ6oiX5aohuxaOoOSuq25w_003D_003D)
				{
					_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Remove(item);
				}
				return false;
			}
			catch
			{
				//try-fault
				_0023_003DqTAyAX7hnx2HbwPXfjz0mjyG1iipRNYK0XSnriMiPKcs_003D();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _0023_003Dq3WNS7AshSdeRricduvBWMQ_003D_003D()
		{
			_0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D = -1;
			((IDisposable)_0023_003DqCPU0BpRRr_0024YKh1ApFax24g_003D_003D/*cast due to constrained. prefix*/).Dispose();
		}

		[DebuggerHidden]
		private _0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D _0023_003DqXEekcsjHinHznXQUyVjN2rkIuJLeYKHP2R9f6a1Tqa4HG4CFdPUM1b3dlj8w7ugN8ZcBiqcNBatvccsOwFzIsw_003D_003D()
		{
			return _0023_003Dqw5Es3BtW4XmELafcnPoICA_003D_003D;
		}

		_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D IEnumerator<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qXEekcsjHinHznXQUyVjN2rkIuJLeYKHP2R9f6a1Tqa4HG4CFdPUM1b3dlj8w7ugN8ZcBiqcNBatvccsOwFzIsw==
			return this._0023_003DqXEekcsjHinHznXQUyVjN2rkIuJLeYKHP2R9f6a1Tqa4HG4CFdPUM1b3dlj8w7ugN8ZcBiqcNBatvccsOwFzIsw_003D_003D();
		}

		[DebuggerHidden]
		private void _0023_003Dq2TH3J_0024GRWLFlvvd5gM8LdMDuG7MDDaOmJOxIthb_1zPsDEyJ5B6oLwEDD_0024a5hlQy()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q2TH3J$GRWLFlvvd5gM8LdMDuG7MDDaOmJOxIthb_1zPsDEyJ5B6oLwEDD$a5hlQy
			this._0023_003Dq2TH3J_0024GRWLFlvvd5gM8LdMDuG7MDDaOmJOxIthb_1zPsDEyJ5B6oLwEDD_0024a5hlQy();
		}

		[DebuggerHidden]
		private object _0023_003DqesmN_0024bLG06iPCggmgIwmFrAqOKcsAHgZztqfwfJh8lTIjvfEvXCpPRRJtWWxYcRl()
		{
			return _0023_003Dqw5Es3BtW4XmELafcnPoICA_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qesmN$bLG06iPCggmgIwmFrAqOKcsAHgZztqfwfJh8lTIjvfEvXCpPRRJtWWxYcRl
			return this._0023_003DqesmN_0024bLG06iPCggmgIwmFrAqOKcsAHgZztqfwfJh8lTIjvfEvXCpPRRJtWWxYcRl();
		}

		[DebuggerHidden]
		private IEnumerator<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D> _0023_003Dqofp2Sv8xXOmsL8Pvbla7I7eIRQyIdWtivWKHTQCI1krxAH7_K4SZWT1czbUfEqTRna84LzXdk9Pb3bkmhd__7A_003D_003D()
		{
			_0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D> _0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D2;
			if (_0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D == -2 && _0023_003Dq_4TrXm0DrZawjn4E3KY8t_4uqhBeeoz12guda4MO_0024ek_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003DqLodt9AHqqcg8S1R8GV1Pwg_003D_003D = 0;
				_0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D2 = this;
			}
			else
			{
				_0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D2 = new _0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D>(0);
			}
			_0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D2._0023_003DqvFhIuckcMxXiACNa4Ct0sg_003D_003D = _0023_003DqO_0024olJ0W9TM4wpqjhUApc8A_003D_003D;
			return _0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D2;
		}

		IEnumerator<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D> IEnumerable<_0023_003Dqnq8tC2FfOrhNhG3seFdVNg_003D_003D>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qofp2Sv8xXOmsL8Pvbla7I7eIRQyIdWtivWKHTQCI1krxAH7_K4SZWT1czbUfEqTRna84LzXdk9Pb3bkmhd__7A==
			return this._0023_003Dqofp2Sv8xXOmsL8Pvbla7I7eIRQyIdWtivWKHTQCI1krxAH7_K4SZWT1czbUfEqTRna84LzXdk9Pb3bkmhd__7A_003D_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003DqHS7ZlZQsQ0eBi8wEUgiAT9zS33HztjtV0mW11w2_00241AaInEW8nP2ZLoQLb_iV5oBO()
		{
			return _0023_003Dqofp2Sv8xXOmsL8Pvbla7I7eIRQyIdWtivWKHTQCI1krxAH7_K4SZWT1czbUfEqTRna84LzXdk9Pb3bkmhd__7A_003D_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qHS7ZlZQsQ0eBi8wEUgiAT9zS33HztjtV0mW11w2$1AaInEW8nP2ZLoQLb_iV5oBO
			return this._0023_003DqHS7ZlZQsQ0eBi8wEUgiAT9zS33HztjtV0mW11w2_00241AaInEW8nP2ZLoQLb_iV5oBO();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Callback<LobbyDataUpdate_t>.DispatchDelegate _003C_003E9__12_0;

		public static Callback<LobbyChatUpdate_t>.DispatchDelegate _003C_003E9__12_1;

		public static Callback<LobbyChatMsg_t>.DispatchDelegate _003C_003E9__12_2;

		public static Callback<GameLobbyJoinRequested_t>.DispatchDelegate _003C_003E9__12_3;

		public static Callback<GameOverlayActivated_t>.DispatchDelegate _003C_003E9__12_4;

		public static Callback<P2PSessionRequest_t>.DispatchDelegate _003C_003E9__12_5;

		public static Callback<ItemInstalled_t>.DispatchDelegate _003C_003E9__12_6;

		public static Callback<DownloadItemResult_t>.DispatchDelegate _003C_003E9__12_7;

		public static Callback<RemoteStoragePublishedFileSubscribed_t>.DispatchDelegate _003C_003E9__12_8;

		public static Callback<RemoteStoragePublishedFileUnsubscribed_t>.DispatchDelegate _003C_003E9__12_9;

		internal void _0023_003DqDpJklAXvZzhMFLmikZ1nsjO7d2WMY4JhVAa6I7c_WX8_003D(LobbyDataUpdate_t _0023_003DqDUS_0024C481iAr6t6UAGF4xXw_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqDUS_0024C481iAr6t6UAGF4xXw_003D_003D);
		}

		internal void _0023_003DqendMh2ja_0024Q_0024B2Ifl4RoPQfmowbvnckBRqXf3AQ5W22w_003D(LobbyChatUpdate_t _0023_003DqDUS_0024C481iAr6t6UAGF4xXw_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqDUS_0024C481iAr6t6UAGF4xXw_003D_003D);
		}

		internal void _0023_003DqGX03z3WQGpHONxbwKeMmpxi0SMF_0024aqiBSoVYen6CsrU_003D(LobbyChatMsg_t _0023_003Dq_0024mvr1YuFHXm_qjfBCNMoKA_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003Dq_0024mvr1YuFHXm_qjfBCNMoKA_003D_003D);
		}

		internal void _0023_003DqBajVWh5PYuGcGfX5OHle0p5llaRQn4p9RlqL1Lf1XFw_003D(GameLobbyJoinRequested_t _0023_003DqCuJO4IyACtBxOzH1rvLLVw_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqCuJO4IyACtBxOzH1rvLLVw_003D_003D);
		}

		internal void _0023_003Dq3EWdn2qCf3zpQp2T9vCuS348xZDiim_WKSiG_0024bFQVA4_003D(GameOverlayActivated_t _0023_003DqNOBboDSpfSGqoXukrGoNZQ_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqNOBboDSpfSGqoXukrGoNZQ_003D_003D);
		}

		internal void _0023_003DqcG5rx4U_0024Y8pkfpyp_0024X5ZTIvcp1sJPW6SAuLxfIGZc4g_003D(P2PSessionRequest_t _0023_003Dq6Hhky9lLNHxdSm_0024u5xa73g_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003Dq6Hhky9lLNHxdSm_0024u5xa73g_003D_003D);
		}

		internal void _0023_003DqG_0024u4xLrnlR9X47BZwuBBGWp3HfL3GV7LBslAHu1v4MU_003D(ItemInstalled_t _0023_003DqS4cmwwGDx6P0vSalXl5a1g_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqS4cmwwGDx6P0vSalXl5a1g_003D_003D);
		}

		internal void _0023_003DqyhcAbfMyfo9Ei_0024W4FxHcg1x99j2DYq_0024raIipYmrH83o_003D(DownloadItemResult_t _0023_003DqCOcIknyy9WRy_0024ofWouk0fA_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqCOcIknyy9WRy_0024ofWouk0fA_003D_003D);
		}

		internal void _0023_003DqFdkaTO1uaA9GXvb_0024MCet7mNpPFOn724bc6Q4clwHUlM_003D(RemoteStoragePublishedFileSubscribed_t _0023_003DqUZPzNDNMESiEy9VOig0y3w_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqUZPzNDNMESiEy9VOig0y3w_003D_003D);
		}

		internal void _0023_003DqZWx6GRnirDKF1f_hL1In6V4fGSlTExRWSD6o8RuzlM8_003D(RemoteStoragePublishedFileUnsubscribed_t _0023_003DqMd_BMGHKkYvDC6gGChEASg_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqMd_BMGHKkYvDC6gGChEASg_003D_003D);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__14<T> where T : struct
	{
		public static readonly _003C_003Ec__14<T> _003C_003E9 = new _003C_003Ec__14<T>();

		public static Func<T, bool> _003C_003E9__14_0;

		internal bool _0023_003Dq7PErE53fDvwsgHy2QB8I7dL3nliI0A16z3Rc9zlD8iw_003D(T _0023_003DqFcX83Z0SeiG_00240wl7binCYA_003D_003D)
		{
			return true;
		}
	}

	private static Callback<LobbyDataUpdate_t> _0023_003DqTBPtFVGrnlVzi17Tt674Xw23TP6WKYTm9ffhh_0024hHmzw_003D;

	private static Callback<LobbyChatUpdate_t> _0023_003Dq8uOPz7JpkmRIHSDbeKLjhh8WAnOHjaTFSuj6arJcvdE_003D;

	private static Callback<LobbyChatMsg_t> _0023_003DqnVeLRscB2OfiOmN2_0024COb2hXkBSv4lxstgJ4smQBydns_003D;

	private static Callback<GameLobbyJoinRequested_t> _0023_003DqxCEc34lzWOs5LDmaEzQ_00240cV3enOhpDyHVoXdGZLthtw_003D;

	private static Callback<GameOverlayActivated_t> _0023_003Dq2VSiNJvN8DE4usElI28fUx4xHPLj0tmAo94sA6gmRQw_003D;

	private static Callback<P2PSessionRequest_t> _0023_003DqaE_nA36rnDaEfuxsGAi2xZGVN98VjddFKZXRNVaatZw_003D;

	private static Callback<ItemInstalled_t> _0023_003DqDlQqmQUnkt3UfH_0024uH69uGx6_9VNVtFmk_T1ZQfjiAnc_003D;

	private static Callback<DownloadItemResult_t> _0023_003DqjejujjQYYKpO6xwmGi2_K_dSFjVlxSjov25Gl51jKYk_003D;

	private static Callback<RemoteStoragePublishedFileSubscribed_t> _0023_003DqxjOJfgkt1HqeASD5cjxJpPha2pAUoAfHPwKYbvFJEVA_003D;

	private static Callback<RemoteStoragePublishedFileUnsubscribed_t> _0023_003DqsGCr4DO4wliE5Bz0hrk5abg5Bi9advGPlFlTdout0bs_003D;

	private static List<object> _0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D = new List<object>();

	private static List<object> _0023_003Dq01UCIImSXo_0024vZUt7VzWMeQ_003D_003D = new List<object>();

	public static void _0023_003DqwuclgQpB8l8sng2o39V8Mg_003D_003D()
	{
		_0023_003DqTBPtFVGrnlVzi17Tt674Xw23TP6WKYTm9ffhh_0024hHmzw_003D = Callback<LobbyDataUpdate_t>.Create(_003C_003Ec._003C_003E9._0023_003DqDpJklAXvZzhMFLmikZ1nsjO7d2WMY4JhVAa6I7c_WX8_003D);
		_0023_003Dq8uOPz7JpkmRIHSDbeKLjhh8WAnOHjaTFSuj6arJcvdE_003D = Callback<LobbyChatUpdate_t>.Create(delegate(LobbyChatUpdate_t _0023_003DqDUS_0024C481iAr6t6UAGF4xXw_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqDUS_0024C481iAr6t6UAGF4xXw_003D_003D);
		});
		_0023_003DqnVeLRscB2OfiOmN2_0024COb2hXkBSv4lxstgJ4smQBydns_003D = Callback<LobbyChatMsg_t>.Create(delegate(LobbyChatMsg_t _0023_003Dq_0024mvr1YuFHXm_qjfBCNMoKA_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003Dq_0024mvr1YuFHXm_qjfBCNMoKA_003D_003D);
		});
		_0023_003DqxCEc34lzWOs5LDmaEzQ_00240cV3enOhpDyHVoXdGZLthtw_003D = Callback<GameLobbyJoinRequested_t>.Create(_003C_003Ec._003C_003E9._0023_003DqBajVWh5PYuGcGfX5OHle0p5llaRQn4p9RlqL1Lf1XFw_003D);
		_0023_003Dq2VSiNJvN8DE4usElI28fUx4xHPLj0tmAo94sA6gmRQw_003D = Callback<GameOverlayActivated_t>.Create(delegate(GameOverlayActivated_t _0023_003DqNOBboDSpfSGqoXukrGoNZQ_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqNOBboDSpfSGqoXukrGoNZQ_003D_003D);
		});
		_0023_003DqaE_nA36rnDaEfuxsGAi2xZGVN98VjddFKZXRNVaatZw_003D = Callback<P2PSessionRequest_t>.Create(delegate(P2PSessionRequest_t _0023_003Dq6Hhky9lLNHxdSm_0024u5xa73g_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003Dq6Hhky9lLNHxdSm_0024u5xa73g_003D_003D);
		});
		_0023_003DqDlQqmQUnkt3UfH_0024uH69uGx6_9VNVtFmk_T1ZQfjiAnc_003D = Callback<ItemInstalled_t>.Create(delegate(ItemInstalled_t _0023_003DqS4cmwwGDx6P0vSalXl5a1g_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqS4cmwwGDx6P0vSalXl5a1g_003D_003D);
		});
		_0023_003DqjejujjQYYKpO6xwmGi2_K_dSFjVlxSjov25Gl51jKYk_003D = Callback<DownloadItemResult_t>.Create(delegate(DownloadItemResult_t _0023_003DqCOcIknyy9WRy_0024ofWouk0fA_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqCOcIknyy9WRy_0024ofWouk0fA_003D_003D);
		});
		_0023_003DqxjOJfgkt1HqeASD5cjxJpPha2pAUoAfHPwKYbvFJEVA_003D = Callback<RemoteStoragePublishedFileSubscribed_t>.Create(delegate(RemoteStoragePublishedFileSubscribed_t _0023_003DqUZPzNDNMESiEy9VOig0y3w_003D_003D)
		{
			_0023_003DqDqhIFwoQ_00242zdezMGyGMHQw_003D_003D.Add(_0023_003DqUZPzNDNMESiEy9VOig0y3w_003D_003D);
		});
		_0023_003DqsGCr4DO4wliE5Bz0hrk5abg5Bi9advGPlFlTdout0bs_003D = Callback<RemoteStoragePublishedFileUnsubscribed_t>.Create(_003C_003Ec._003C_003E9._0023_003DqZWx6GRnirDKF1f_hL1In6V4fGSlTExRWSD6o8RuzlM8_003D);
	}

	public static void _0023_003DqCHJse8PnPgpSGH2n910m2w_003D_003D()
	{
		SteamAPI.RunCallbacks();
	}

	public static IEnumerable<T> _0023_003Dqm60GhIu7hRA__Vs439G7em787ggh0OVYt6Q469gml7Y_003D<T>() where T : struct
	{
		return _0023_003Dq0sMtvvcuTl1OV_V874w_1oWJlKy18mA8LOU6bTvOvlY_003D<T>(_003C_003Ec__14<T>._003C_003E9._0023_003Dq7PErE53fDvwsgHy2QB8I7dL3nliI0A16z3Rc9zlD8iw_003D);
	}

	[IteratorStateMachine(typeof(_0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D))]
	public static IEnumerable<T> _0023_003Dq0sMtvvcuTl1OV_V874w_1oWJlKy18mA8LOU6bTvOvlY_003D<T>(Func<T, bool> _0023_003DqCzd2EYxlhGioi7M_0024Cx_0024HgA_003D_003D) where T : struct
	{
		return new _0023_003DqzVO5U2ElNkL0ycSHCveRDH5xuhJXpgcUK6mLDBogNyA_003D<T>(-2)
		{
			_0023_003DqO_0024olJ0W9TM4wpqjhUApc8A_003D_003D = _0023_003DqCzd2EYxlhGioi7M_0024Cx_0024HgA_003D_003D
		};
	}

	public static void _0023_003Dq7b19I6VxiSbi_A6zXKd2sg_003D_003D<T>(this SteamAPICall_t _0023_003Dqf2KrnLC2Z4006Upkqi9g9Q_003D_003D, CallResult<T>.APIDispatchDelegate _0023_003DqHldr1Z47bgKgPE5Da9dn2Q_003D_003D)
	{
		_0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D<T> _0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D2 = new _0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D<T>();
		_0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D2._0023_003DqIgXiFKKacbx4MYrY4oCfnQ_003D_003D = _0023_003DqHldr1Z47bgKgPE5Da9dn2Q_003D_003D;
		_0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D2._0023_003DqcUrhob6kNv_0024bMjIMMUBFYQ_003D_003D = CallResult<T>.Create();
		_0023_003Dq01UCIImSXo_0024vZUt7VzWMeQ_003D_003D.Add(_0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D2._0023_003DqcUrhob6kNv_0024bMjIMMUBFYQ_003D_003D);
		_0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D2._0023_003DqcUrhob6kNv_0024bMjIMMUBFYQ_003D_003D.Set(_0023_003Dqf2KrnLC2Z4006Upkqi9g9Q_003D_003D, _0023_003DqvdssRy1C8yvCvQhf3XTwefbxUdsR1RRDPSxvURc_0024nYY_003D2._0023_003DqT8HDH5GuCAkcOppztxCAcKdar3G7L5aNqtAzR9tJ5ag_003D);
	}
}
