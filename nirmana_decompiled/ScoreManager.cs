using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Steamworks;

public sealed class ScoreManager
{
	private sealed class _0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D : IEnumerator<string>, IEnumerable<string>, IEnumerable, IEnumerator, IDisposable
	{
		private int _0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D;

		private string _0023_003DqshD_88kDr4RJAxrvgYYFTg_003D_003D;

		private int _0023_003DqI83T7UcYXKFmGK2qnVPoFmALG3foYJvvGnjB4lZGYK4_003D;

		public ScoreManager _0023_003Dq9QHHsHc69IWhmRrR30dJ1Q_003D_003D;

		private IEnumerator<Puzzle> _0023_003DqwH9A5YIWBnSjsA0jV2_0024d_w_003D_003D;

		private Puzzle _0023_003DqX6WRggtR5E1usC64h5WvKA_003D_003D;

		private _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D[] _0023_003DqB7MwthqRvxE7Ethnr8RogA_003D_003D;

		private int _0023_003DqXdToRERxuBV5KmtlWjYh6g_003D_003D;

		[DebuggerHidden]
		public _0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D(int _0023_003Dq2DqqKN41YbNuJzIpe2zwCg_003D_003D)
		{
			_0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D = _0023_003Dq2DqqKN41YbNuJzIpe2zwCg_003D_003D;
			_0023_003DqI83T7UcYXKFmGK2qnVPoFmALG3foYJvvGnjB4lZGYK4_003D = Environment.CurrentManagedThreadId;
		}

		[DebuggerHidden]
		private void _0023_003Dq4_rUpr6kuYVpnj9KXImnySalFx698z83LWfqyt9sLu4_003D()
		{
			int num = _0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_0023_003Dqd1AGED9GiW_75JrqEYfRXw_003D_003D();
				}
			}
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q4_rUpr6kuYVpnj9KXImnySalFx698z83LWfqyt9sLu4=
			this._0023_003Dq4_rUpr6kuYVpnj9KXImnySalFx698z83LWfqyt9sLu4_003D();
		}

		private bool MoveNext()
		{
			try
			{
				int num = _0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D;
				ScoreManager scoreManager = _0023_003Dq9QHHsHc69IWhmRrR30dJ1Q_003D_003D;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D = -3;
					_0023_003DqXdToRERxuBV5KmtlWjYh6g_003D_003D++;
					goto IL_00aa;
				}
				_0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D = -1;
				_0023_003DqwH9A5YIWBnSjsA0jV2_0024d_w_003D_003D = ContentType<Puzzle>._0023_003Dq_0024K0RE2SHcO4TbjmjudlM4g_003D_003D().GetEnumerator();
				_0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D = -3;
				goto IL_00c8;
				IL_00aa:
				if (_0023_003DqXdToRERxuBV5KmtlWjYh6g_003D_003D < _0023_003DqB7MwthqRvxE7Ethnr8RogA_003D_003D.Length)
				{
					_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqjuBK9TvfpsrUrrbiEr1Y5A_003D_003D = _0023_003DqB7MwthqRvxE7Ethnr8RogA_003D_003D[_0023_003DqXdToRERxuBV5KmtlWjYh6g_003D_003D];
					_0023_003DqshD_88kDr4RJAxrvgYYFTg_003D_003D = scoreManager._0023_003Dq65VfEClgOTsEKZ6UWG8WLQ_003D_003D(_0023_003DqX6WRggtR5E1usC64h5WvKA_003D_003D, _0023_003DqjuBK9TvfpsrUrrbiEr1Y5A_003D_003D);
					_0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D = 1;
					return true;
				}
				_0023_003DqB7MwthqRvxE7Ethnr8RogA_003D_003D = null;
				_0023_003DqX6WRggtR5E1usC64h5WvKA_003D_003D = null;
				goto IL_00c8;
				IL_00c8:
				if (_0023_003DqwH9A5YIWBnSjsA0jV2_0024d_w_003D_003D.MoveNext())
				{
					_0023_003DqX6WRggtR5E1usC64h5WvKA_003D_003D = _0023_003DqwH9A5YIWBnSjsA0jV2_0024d_w_003D_003D.Current;
					_0023_003DqB7MwthqRvxE7Ethnr8RogA_003D_003D = _0023_003DqSu3jnh60RT8z6kwX0VxdgQ_003D_003D;
					_0023_003DqXdToRERxuBV5KmtlWjYh6g_003D_003D = 0;
					goto IL_00aa;
				}
				_0023_003Dqd1AGED9GiW_75JrqEYfRXw_003D_003D();
				_0023_003DqwH9A5YIWBnSjsA0jV2_0024d_w_003D_003D = null;
				return false;
			}
			catch
			{
				//try-fault
				_0023_003Dq4_rUpr6kuYVpnj9KXImnySalFx698z83LWfqyt9sLu4_003D();
				throw;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _0023_003Dqd1AGED9GiW_75JrqEYfRXw_003D_003D()
		{
			_0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D = -1;
			if (_0023_003DqwH9A5YIWBnSjsA0jV2_0024d_w_003D_003D != null)
			{
				_0023_003DqwH9A5YIWBnSjsA0jV2_0024d_w_003D_003D.Dispose();
			}
		}

		[DebuggerHidden]
		private string _0023_003DqIkyAdeZlYXjEI6GOYrQ8DY9a4yJpcNTtKk64fU5rJd5tgmKDt4akTXqiUgLl8DPvP0EssZGqXgZOUVIafac21KUDiROzSCHVi5Y24Jz0HfY_003D()
		{
			return _0023_003DqshD_88kDr4RJAxrvgYYFTg_003D_003D;
		}

		string IEnumerator<string>.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qIkyAdeZlYXjEI6GOYrQ8DY9a4yJpcNTtKk64fU5rJd5tgmKDt4akTXqiUgLl8DPvP0EssZGqXgZOUVIafac21KUDiROzSCHVi5Y24Jz0HfY=
			return this._0023_003DqIkyAdeZlYXjEI6GOYrQ8DY9a4yJpcNTtKk64fU5rJd5tgmKDt4akTXqiUgLl8DPvP0EssZGqXgZOUVIafac21KUDiROzSCHVi5Y24Jz0HfY_003D();
		}

		[DebuggerHidden]
		private void _0023_003Dq2upPVQEc6UwN6rcZ_rUJYyGOBvIMZ2gAGSFK_BJLB_0024UhCHnM6ei8YGJApG_PHVBJ()
		{
			throw new NotSupportedException();
		}

		void IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=q2upPVQEc6UwN6rcZ_rUJYyGOBvIMZ2gAGSFK_BJLB$UhCHnM6ei8YGJApG_PHVBJ
			this._0023_003Dq2upPVQEc6UwN6rcZ_rUJYyGOBvIMZ2gAGSFK_BJLB_0024UhCHnM6ei8YGJApG_PHVBJ();
		}

		[DebuggerHidden]
		private object _0023_003Dqd0aTnoQBJurePQO2LjB5mUXFT0WBnQFcqcv_0024esyf0AFC8o_0024_tdB1YE2hYvd_0024gKl3()
		{
			return _0023_003DqshD_88kDr4RJAxrvgYYFTg_003D_003D;
		}

		object IEnumerator.get_Current()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qd0aTnoQBJurePQO2LjB5mUXFT0WBnQFcqcv$esyf0AFC8o$_tdB1YE2hYvd$gKl3
			return this._0023_003Dqd0aTnoQBJurePQO2LjB5mUXFT0WBnQFcqcv_0024esyf0AFC8o_0024_tdB1YE2hYvd_0024gKl3();
		}

		[DebuggerHidden]
		private IEnumerator<string> _0023_003DqzyMgP9C26hxabY_0024OHOHV5vgsMnKmL47EjqT3KqkvUfy1zDxHXRRAkcoiLss8ZCVGti1drn7go3c_002471TEtkBHhciwvje2wDWK6b05EOhlo3k_003D()
		{
			_0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D _0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D2;
			if (_0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D == -2 && _0023_003DqI83T7UcYXKFmGK2qnVPoFmALG3foYJvvGnjB4lZGYK4_003D == Environment.CurrentManagedThreadId)
			{
				_0023_003DqQOzl0Mkh9v8HPqRAomqOgg_003D_003D = 0;
				_0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D2 = this;
			}
			else
			{
				_0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D2 = new _0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D(0);
				_0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D2._0023_003Dq9QHHsHc69IWhmRrR30dJ1Q_003D_003D = _0023_003Dq9QHHsHc69IWhmRrR30dJ1Q_003D_003D;
			}
			return _0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D2;
		}

		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qzyMgP9C26hxabY$OHOHV5vgsMnKmL47EjqT3KqkvUfy1zDxHXRRAkcoiLss8ZCVGti1drn7go3c$71TEtkBHhciwvje2wDWK6b05EOhlo3k=
			return this._0023_003DqzyMgP9C26hxabY_0024OHOHV5vgsMnKmL47EjqT3KqkvUfy1zDxHXRRAkcoiLss8ZCVGti1drn7go3c_002471TEtkBHhciwvje2wDWK6b05EOhlo3k_003D();
		}

		[DebuggerHidden]
		private IEnumerator _0023_003DqHNGICUpeofJixD8OpeTYDBXAOiVvUH3X1syaa7nMGgoEG6n6o2BY54jGE1kQUTLs()
		{
			return _0023_003DqzyMgP9C26hxabY_0024OHOHV5vgsMnKmL47EjqT3KqkvUfy1zDxHXRRAkcoiLss8ZCVGti1drn7go3c_002471TEtkBHhciwvje2wDWK6b05EOhlo3k_003D();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in #=qHNGICUpeofJixD8OpeTYDBXAOiVvUH3X1syaa7nMGgoEG6n6o2BY54jGE1kQUTLs
			return this._0023_003DqHNGICUpeofJixD8OpeTYDBXAOiVvUH3X1syaa7nMGgoEG6n6o2BY54jGE1kQUTLs();
		}
	}

	private sealed class _0023_003DqE31FfApUSq6Q_0024eByEbHvGSDInxuYPRYzJ0UXBGBeO3A_003D
	{
		public float[] _0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D;

		internal float _0023_003DqcwHy0HAFEoCHH_0024BLV9OhJzn6pE0aIwCanwGddJiEBts_003D(float _0023_003DqhQZ6lOFywEpKLqTg44a77A_003D_003D)
		{
			return _0023_003DqhQZ6lOFywEpKLqTg44a77A_003D_003D / _0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D.Max();
		}
	}

	private sealed class _0023_003DqnOLj54kIvFQ5gu6pzObc5kdNvjzFz0Yd9BkDHIkJjHo_003D
	{
		public _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D;

		internal int _0023_003DqMnQU92wYjc_xvS8oondrZ7gmIw_0024SfcpwEWDCIOup17OBp62LtD7RKhVNUgycj2lk(_0023_003DqdIs8DPoCFMGsGsoyP6nE8Q_003D_003D _0023_003Dq9KBdHkZP3jwOt2t4qemupQ_003D_003D)
		{
			return _0023_003Dq9KBdHkZP3jwOt2t4qemupQ_003D_003D._0023_003DqDgQ63SpiYSjN_00240OjnKo98g_003D_003D(_0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D);
		}

		internal int _0023_003Dq74aSy1RhGgi8W2T5tz7tmA05hB1awShBNmYzk0P3OcMrIyUZxtmGaPAmNHD2P_VH(_0023_003DqdIs8DPoCFMGsGsoyP6nE8Q_003D_003D _0023_003DqtP0xw1GJqw1paulEYGJWnw_003D_003D)
		{
			return _0023_003DqtP0xw1GJqw1paulEYGJWnw_003D_003D._0023_003DqDgQ63SpiYSjN_00240OjnKo98g_003D_003D(_0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D);
		}
	}

	private sealed class _0023_003DqTbHujJozIUc6vtGRwJiolRejDvuUv942PYCstoInBlg_003D
	{
		public List<LeaderboardEntry> _0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D;

		public string _0023_003Dqnc2tVateOAJpSiG87gzppw_003D_003D;

		internal void _0023_003DqR8Kan6rlC5qCoam_00247QE82sBCemFFtgTKERIPM29f8g27iETWdAK9dnaGKk1DX5hSrdwxgSwChC24wyBRLbsbhA_003D_003D()
		{
			if (_0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Count == _0023_003Dq1BE__0024qf20vBohRV05G2e7yarF8qQea_D1eUSJ1tYCLQ_003D)
			{
				LeaderboardEntry item = _0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Where((LeaderboardEntry _0023_003DqFs7yCEIeGAw1z3FJMQDtVg_003D_003D) => !_0023_003DqFs7yCEIeGAw1z3FJMQDtVg_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D && !_0023_003DqFs7yCEIeGAw1z3FJMQDtVg_003D_003D._0023_003Dq2EIXUqW4ClXl5LtZ6XC3Gw_003D_003D).OrderByDescending(_003C_003Ec._003C_003E9._0023_003Dqyo6eJgsQskNangsDPhgMy3MbqT8mWv3vhSnTuxxFnDw_003D).First();
				_0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Remove(item);
			}
		}

		internal void _0023_003DqhXggPAvmgV9Fy_0024lCRnwpAR9OBZEu1KE9q3QFcuqNM88_003D(int _0023_003DqXgJhH6u9UEBipkzEBjRkpQ_003D_003D)
		{
			_0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(SteamFriends.GetPersonaName(), _0023_003DqXgJhH6u9UEBipkzEBjRkpQ_003D_003D, _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: false, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
		}

		internal bool _0023_003DqZOfA8lUioDHaMFX53JPXaMzNtJtUEw8v7v5d7amKku0_003D(LeaderboardEntry _0023_003DqwzoVp12AJ1N_kisF31EjxA_003D_003D)
		{
			return _0023_003DqwzoVp12AJ1N_kisF31EjxA_003D_003D._0023_003DqkxnOcnB6AcA4PlmvdHPFlA_003D_003D != _0023_003Dqnc2tVateOAJpSiG87gzppw_003D_003D;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0023_003DqtlDhosyhYYq5a0seIyFJRCuRKw_xSLPYnVs1DYjqwnY_003D
	{
		public ReliableRandom _0023_003DqTXLSNXise7WGPCZ_0024VryWQg_003D_003D;
	}

	private sealed class _0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D
	{
		public ScoreManager _0023_003DqpesPMt_NJd_2yg0pbEPV_A_003D_003D;

		public string _0023_003DqzfAgJhDSkZ95__J9xF_eCHPP6FEEgfRODtTXmdBGhrY_003D;

		internal void _0023_003Dq27HE71F3wnjXASZtn5tdYnQodqtgwE01emWtf5P8vjY_003D(LeaderboardScoreUploaded_t _0023_003DqhpDzoA8zj8fZcoBKFYmkYQ_003D_003D, bool _0023_003DqS_00249YpEjbaAiytH0VlllUBQ_003D_003D)
		{
			_0023_003DqpesPMt_NJd_2yg0pbEPV_A_003D_003D._0023_003DqL_iH1t4R9Hec42oMhNi4MfnPgW_0024y351zykblUjIgsx0_003D(_0023_003DqzfAgJhDSkZ95__J9xF_eCHPP6FEEgfRODtTXmdBGhrY_003D, _0023_003DqShF3KiQGSfYb6mW70dg5_w_003D_003D: true);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Action<byte[]> _003C_003E9__10_0;

		public static Action _003C_003E9__10_1;

		public static Func<string, string> _003C_003E9__13_2;

		public static Action _003C_003E9__13_1;

		public static Func<LeaderboardEntry, bool> _003C_003E9__19_0;

		public static Func<LeaderboardEntry, int> _003C_003E9__19_1;

		public static Func<LeaderboardEntry, bool> _003C_003E9__20_0;

		public static Func<LeaderboardEntry, int> _003C_003E9__20_1;

		public static Func<LeaderboardEntry, bool> _003C_003E9__21_4;

		public static Func<LeaderboardEntry, int> _003C_003E9__21_5;

		public static Func<LeaderboardEntry, bool> _003C_003E9__21_6;

		public static Func<LeaderboardEntry, int> _003C_003E9__21_7;

		public static Predicate<LeaderboardEntry> _003C_003E9__21_8;

		public static Func<LeaderboardEntry, int> _003C_003E9__21_2;

		public static Func<string, int> _003C_003E9__22_1;

		public static Func<int, float> _003C_003E9__22_2;

		internal void _0023_003DqO5yyrPef_MOj0XXOTo_0024wl_fVlP80zIbx7gVuJMq56tU_003D(byte[] _0023_003DqcFcUZ3pvY7p2nVHBgJ_4CQ_003D_003D)
		{
		}

		internal void _0023_003Dqt7tszhgCllQHLNVzld4KsUQImrNhkJ4vPVIVA4MACow_003D()
		{
		}

		internal string _0023_003DqOUbpLg05LqEKYfKo_0024nHcY3zxBg5gR6qC9Zy7kCno5Y0_003D(string _0023_003DqM81BNO6XtaqLhiXluBZavA_003D_003D)
		{
			return _0023_003DqM81BNO6XtaqLhiXluBZavA_003D_003D.Trim();
		}

		internal void _0023_003DqRB3Ro16jFpV7DnlesjKj5KJq8BDxeEyB7px_hEFikco_003D()
		{
		}

		internal bool _0023_003DqOwYHgL2XgMfIAU_DqhgG2ab6TN4zHmjed36_0024Uk9SvIAy1DiqxBRIKDf4K0NaQlAx(LeaderboardEntry _0023_003Dqb_002472FbCzsKP7m0h3YhFiEQ_003D_003D)
		{
			return !_0023_003Dqb_002472FbCzsKP7m0h3YhFiEQ_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D;
		}

		internal int _0023_003DqYPMHm68LZR_0024qRVHRZ3L5V6Wfcb83mWHgz_rnqCDPUYxfQnIWMI_s9Gm93yQBFnwy(LeaderboardEntry _0023_003Dqy5mq7BdXkel_PGKILBBtPA_003D_003D)
		{
			return _0023_003Dqy5mq7BdXkel_PGKILBBtPA_003D_003D._0023_003Dq7ayRO0XV_3aLpU2Nf0nfKQ_003D_003D;
		}

		internal bool _0023_003DqycKJWMjiY1DEPSpPWrLm_LNzBOrE_6iiFttxV31cYiqZEcBPLocXJcasfi2u_0024G6U(LeaderboardEntry _0023_003DqJbTulU_SZ9uQ1anZ8ApH9A_003D_003D)
		{
			return _0023_003DqJbTulU_SZ9uQ1anZ8ApH9A_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D;
		}

		internal int _0023_003DqSuUAgGapitlT82W5ww2BU3PL_0024NHJ3nrLjQL2n5Dl5PW8aZa_dkkScDTG17UbfFxc(LeaderboardEntry _0023_003Dq_0024zwkIINvdM7xwSIpIk_vMw_003D_003D)
		{
			return _0023_003Dq_0024zwkIINvdM7xwSIpIk_vMw_003D_003D._0023_003Dq7ayRO0XV_3aLpU2Nf0nfKQ_003D_003D;
		}

		internal bool _0023_003DqvX_0024txm8R2U_00249x9R707gUxqMc6idGdRyh_002455JD_6GYrY_003D(LeaderboardEntry _0023_003DqFs7yCEIeGAw1z3FJMQDtVg_003D_003D)
		{
			if (!_0023_003DqFs7yCEIeGAw1z3FJMQDtVg_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D)
			{
				return !_0023_003DqFs7yCEIeGAw1z3FJMQDtVg_003D_003D._0023_003Dq2EIXUqW4ClXl5LtZ6XC3Gw_003D_003D;
			}
			return false;
		}

		internal int _0023_003Dqyo6eJgsQskNangsDPhgMy3MbqT8mWv3vhSnTuxxFnDw_003D(LeaderboardEntry _0023_003DqyEmFyHnXkMqRN_0024NX0rGTXw_003D_003D)
		{
			return _0023_003DqyEmFyHnXkMqRN_0024NX0rGTXw_003D_003D._0023_003Dq7ayRO0XV_3aLpU2Nf0nfKQ_003D_003D;
		}

		internal bool _0023_003DqbSuDBswKOhxC19aycsAfPuQqRjX894Q3JozJFM3J0fQ_003D(LeaderboardEntry _0023_003DqDr_o_0024RdlkvxCEZXfV7JOcQ_003D_003D)
		{
			return _0023_003DqDr_o_0024RdlkvxCEZXfV7JOcQ_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D;
		}

		internal int _0023_003DqVxM0j0gcdVekRa5naKlEs2tiN05MdJ7ifZd5EdH7WEE_003D(LeaderboardEntry _0023_003DqEA8Vrh_0024xEA6w3Qzaw0fvJQ_003D_003D)
		{
			return _0023_003DqEA8Vrh_0024xEA6w3Qzaw0fvJQ_003D_003D._0023_003Dq7ayRO0XV_3aLpU2Nf0nfKQ_003D_003D;
		}

		internal bool _0023_003Dq8Cdw_00241w2fIa_0024Zinq_ArkOi1PZuh1_3i0HREWSigJX_Q_003D(LeaderboardEntry _0023_003DqD6Ph57q_0024oQE7WMXCNlJqIA_003D_003D)
		{
			return _0023_003DqD6Ph57q_0024oQE7WMXCNlJqIA_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D;
		}

		internal int _0023_003Dq2GN5poAU22ST6hEMw_APtXNOKbUzcL2LfYFDnjoKLLo_003D(LeaderboardEntry _0023_003DqXxO1WcAhXUWZcE19F0sdyg_003D_003D)
		{
			return _0023_003DqXxO1WcAhXUWZcE19F0sdyg_003D_003D._0023_003Dq7ayRO0XV_3aLpU2Nf0nfKQ_003D_003D;
		}

		internal int _0023_003DqvT1h_0024mN_0024TjzaP62ujufFSpUdrCEDghoNr593cYdrErs_003D(string _0023_003Dq3hiacNtODO3C9yEcHTeKFg_003D_003D)
		{
			return int.Parse(_0023_003Dq3hiacNtODO3C9yEcHTeKFg_003D_003D);
		}

		internal float _0023_003DqYYyMcKuR_0024cxT4JKts41yk33yNMXryxTwKKxbsEcBD_o_003D(int _0023_003DqDLFLVRwO9CV61RaySW_0024MYg_003D_003D)
		{
			return _0023_003DqDLFLVRwO9CV61RaySW_0024MYg_003D_003D;
		}
	}

	private static readonly bool _0023_003DqZj1zmEuVL1_0024uSpLODwJG7dNgjiZqhIuJmGuYMryG_0024NA_003D = false;

	public static readonly _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D[] _0023_003DqSu3jnh60RT8z6kwX0VxdgQ_003D_003D = new _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D[3]
	{
		(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D)0,
		(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D)1,
		(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D)2
	};

	public static readonly int _0023_003Dq1BE__0024qf20vBohRV05G2e7yarF8qQea_D1eUSJ1tYCLQ_003D = 7;

	private Dictionary<string, string> _0023_003DqLFdGGV5PzHwpjituX5kp6w_003D_003D = new Dictionary<string, string>();

	private _0023_003Dqbun0gnLKUL2TRRKL3X4cw79BBWY9VJ0CN2LAIWs73Tk_003D _0023_003Dq96EFhq5PXlqazNqwOoY1GOJGG4cp9fx61xn16VU_p_0024Q_003D = new _0023_003Dqbun0gnLKUL2TRRKL3X4cw79BBWY9VJ0CN2LAIWs73Tk_003D(new Index2(169, 99));

	private Dictionary<string, _0023_003DqXJkfnefYbWCgm7FdX3GzTA_003D_003D> _0023_003Dq7OgbakVgjMOjAtKjJz8Zqw67XprZDHFQnZGaxRhl8iQ_003D = new Dictionary<string, _0023_003DqXJkfnefYbWCgm7FdX3GzTA_003D_003D>();

	private Dictionary<string, int> _0023_003Dq1hl7crhFi9nO0SRNgJeP_SVpnsGmXmtXYOizHkdd_0024jU_003D = new Dictionary<string, int>();

	private Dictionary<string, int> _0023_003DqA9wiUEbYo0Xzh28xIjkdIjHpT0i8Rgp3WR7b70hzJzA_003D = new Dictionary<string, int>();

	private Dictionary<string, DateTime> _0023_003Dqn7R438K_QLdq8DL0X1hS9oMdKbqHEBXChZpaET05wYk_003D = new Dictionary<string, DateTime>();

	public ScoreManager()
	{
		_0023_003DqMoCnv6nJC3vk_eFiN7_0024Qf7tJ8i3zzOLb_0024xtrM3ncLPA_003D();
	}

	public void _0023_003Dqv3XvSdZBVC0q5R5LydXGoQ_003D_003D(Solution _0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D, _0023_003DqdIs8DPoCFMGsGsoyP6nE8Q_003D_003D _0023_003DqQ9z9lA4gUBXzs8XJzm7fyA_003D_003D, bool _0023_003DqUrQm_CT_WqP6izFMOpDbwA_003D_003D)
	{
		_0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D._0023_003Dq9JNAw6UbHXmYPWrUYpEu8g_003D_003D = true;
		_0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D._0023_003Dqwh2qGxbuVGHsKw7inCgUDg_003D_003D = _0023_003DqQ9z9lA4gUBXzs8XJzm7fyA_003D_003D;
		GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqafQkToSqEoEp4dAoBq_0024GrWlUHZSgopZISF4nz1xpxSE_003D._0023_003DqkrnPIYrPBEFj9gOvDMUgFA_003D_003D(_0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D);
		_0023_003DqdIs8DPoCFMGsGsoyP6nE8Q_003D_003D _0023_003DqDsl00PGYUp3pfhYAvPYBBw_003D_003D = _0023_003DqQ9z9lA4gUBXzs8XJzm7fyA_003D_003D;
		if (GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqoKP_fgYXEOwOASjqgMKebw_003D_003D._0023_003Dq36EC0Od_OgVrVa9__0024YT9yg_003D_003D(_0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D._0023_003DqOOSioU9k5K_rBQpHpCEhWA_003D_003D)._0023_003DqY3i1VPb6dvRhYnN7vG1PAA_003D_003D(out var _0023_003DqiERL2gKH0e_0024eSPIKV5MMjA_003D_003D))
		{
			_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D[] array = _0023_003DqSu3jnh60RT8z6kwX0VxdgQ_003D_003D;
			foreach (_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D2 in array)
			{
				_0023_003DqDsl00PGYUp3pfhYAvPYBBw_003D_003D._0023_003Dqvz48xTz794m67GOFgw88tg_003D_003D(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D2, Math.Min(_0023_003DqDsl00PGYUp3pfhYAvPYBBw_003D_003D._0023_003DqDgQ63SpiYSjN_00240OjnKo98g_003D_003D(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D2), _0023_003DqiERL2gKH0e_0024eSPIKV5MMjA_003D_003D._0023_003DqDgQ63SpiYSjN_00240OjnKo98g_003D_003D(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D2)));
			}
		}
		GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqoKP_fgYXEOwOASjqgMKebw_003D_003D._0023_003Dq0p3HBONIPBFvuKRvSvCz_w_003D_003D(_0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D._0023_003DqOOSioU9k5K_rBQpHpCEhWA_003D_003D, _0023_003DqDsl00PGYUp3pfhYAvPYBBw_003D_003D);
		if (_0023_003DqUrQm_CT_WqP6izFMOpDbwA_003D_003D)
		{
			string _0023_003DqSqOZBz1UBqm1BmJa2PLrOA_003D_003D = string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710971), new object[4]
			{
				_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003Dq9F544pPbkLIt_PKF7XYPbBchx1xq40aJ1vdcRJ_vskc_003D(_0023_003DqxfHWivu4AcveXMF67xyhGA_003D_003D: false),
				_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065711002),
				_0023_003Dqjtd0RhaH_eDUMwKnGl0SnA_003D_003D._0023_003DqrcFyDgnrvb0dNoJ1UZ6njw_003D_003D,
				GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqoKP_fgYXEOwOASjqgMKebw_003D_003D._0023_003DqHvUBV5fQG7OBr_6Wts9ub2YasnWlNOSKNESqr3h6WXQ_003D()
			});
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D[] array = _0023_003DqSu3jnh60RT8z6kwX0VxdgQ_003D_003D;
			foreach (_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D3 in array)
			{
				dictionary[_0023_003Dq65VfEClgOTsEKZ6UWG8WLQ_003D_003D(_0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D._0023_003DqOOSioU9k5K_rBQpHpCEhWA_003D_003D, _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D3)] = _0023_003DqQ9z9lA4gUBXzs8XJzm7fyA_003D_003D._0023_003DqDgQ63SpiYSjN_00240OjnKo98g_003D_003D(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D3).ToString();
			}
			GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqNoLhDLkG7xlHdD_nvslYFQ_003D_003D._0023_003Dq0hUfvR7eiibjr78tiSKK3g_003D_003D(_0023_003DqSqOZBz1UBqm1BmJa2PLrOA_003D_003D, dictionary, delegate
			{
			}, _003C_003Ec._003C_003E9._0023_003Dqt7tszhgCllQHLNVzld4KsUQImrNhkJ4vPVIVA4MACow_003D);
			array = _0023_003DqSu3jnh60RT8z6kwX0VxdgQ_003D_003D;
			foreach (_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D4 in array)
			{
				_0023_003Dqm6hxSf75nfs8xFBEUei0hqdEVob_00241VBkJ7FOnMO4BXg_003D(_0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D._0023_003DqOOSioU9k5K_rBQpHpCEhWA_003D_003D, _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D4, _0023_003DqQ9z9lA4gUBXzs8XJzm7fyA_003D_003D._0023_003DqDgQ63SpiYSjN_00240OjnKo98g_003D_003D(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D4));
			}
			_0023_003DqT5ykNtEgFQeGpS3iwxQE_0024A_003D_003D._0023_003DqlDmXy6bcHIVVpmXac2U1Mg_003D_003D(_0023_003DqR2cI_rxH2pCNeHZcbBvq1g_003D_003D._0023_003DqOOSioU9k5K_rBQpHpCEhWA_003D_003D, _0023_003DqQ9z9lA4gUBXzs8XJzm7fyA_003D_003D);
		}
	}

	private string _0023_003Dq65VfEClgOTsEKZ6UWG8WLQ_003D_003D(Puzzle _0023_003Dq5uKzkNkx_D_0024h3DQNMDMvBw_003D_003D, _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqjuBK9TvfpsrUrrbiEr1Y5A_003D_003D)
	{
		return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065711014), new object[4]
		{
			_0023_003Dq5uKzkNkx_D_0024h3DQNMDMvBw_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D,
			10,
			_0023_003Dq5uKzkNkx_D_0024h3DQNMDMvBw_003D_003D._0023_003DqZ2p1r5g4RodZTCmRtOK3WZbgNDA15ypeeimkWP0ZyIk_003D,
			(int)_0023_003DqjuBK9TvfpsrUrrbiEr1Y5A_003D_003D
		});
	}

	[IteratorStateMachine(typeof(_0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D))]
	private IEnumerable<string> _0023_003DqX0_0024EgHuF0XXOq6k8_0024sIjWNvKtn57SMFOCtSXruBJlf0_003D()
	{
		return new _0023_003DqC5pHh5Y4S_0024dRItjGjJ8KKRZe8CMj9x0Ibju_a2JQDpY_003D(-2)
		{
			_0023_003Dq9QHHsHc69IWhmRrR30dJ1Q_003D_003D = this
		};
	}

	private void _0023_003DqMoCnv6nJC3vk_eFiN7_0024Qf7tJ8i3zzOLb_0024xtrM3ncLPA_003D()
	{
		string _0023_003DqSqOZBz1UBqm1BmJa2PLrOA_003D_003D = string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065711054), _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003Dq9F544pPbkLIt_PKF7XYPbBchx1xq40aJ1vdcRJ_vskc_003D(_0023_003DqxfHWivu4AcveXMF67xyhGA_003D_003D: false), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065711067), _0023_003Dqjtd0RhaH_eDUMwKnGl0SnA_003D_003D._0023_003DqrcFyDgnrvb0dNoJ1UZ6njw_003D_003D);
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (string item in _0023_003DqX0_0024EgHuF0XXOq6k8_0024sIjWNvKtn57SMFOCtSXruBJlf0_003D())
		{
			dictionary[item] = string.Empty;
		}
		GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqNoLhDLkG7xlHdD_nvslYFQ_003D_003D._0023_003Dq0hUfvR7eiibjr78tiSKK3g_003D_003D(_0023_003DqSqOZBz1UBqm1BmJa2PLrOA_003D_003D, dictionary, delegate(byte[] _0023_003Dq1gan0ArtZuLtMof7coCIiQ_003D_003D)
		{
			foreach (string item2 in from _0023_003DqM81BNO6XtaqLhiXluBZavA_003D_003D in Encoding.ASCII.GetString(Utility._0023_003DqO_UWZnAvMx7jCHnL2bCwnCM0Ey_0024DWAxUQjBsOMZyHQo_003D(_0023_003Dq1gan0ArtZuLtMof7coCIiQ_003D_003D)).Split(new char[1] { '\n' })
				select _0023_003DqM81BNO6XtaqLhiXluBZavA_003D_003D.Trim())
			{
				string[] array = item2.Split(new char[1] { ':' });
				if (array.Length == 2)
				{
					_0023_003DqLFdGGV5PzHwpjituX5kp6w_003D_003D[array[0]] = array[1];
				}
			}
		}, _003C_003Ec._003C_003E9._0023_003DqRB3Ro16jFpV7DnlesjKj5KJq8BDxeEyB7px_hEFikco_003D);
	}

	private void _0023_003Dqm6hxSf75nfs8xFBEUei0hqdEVob_00241VBkJ7FOnMO4BXg_003D(Puzzle _0023_003DqJmqLpxs2xrZMJxypakm3sQ_003D_003D, _0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqauOlpx7UV04D_00242R4AnFsyQ_003D_003D, int _0023_003DqD9ZnZhsM7_0024BeOidlBB_rrQ_003D_003D)
	{
		_0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D _0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D2 = new _0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D();
		_0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D2._0023_003DqpesPMt_NJd_2yg0pbEPV_A_003D_003D = this;
		if (GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqL6HlhJGiNttvtnaf4SI4UQ_003D_003D._0023_003DqvqF11jKkjrqHCsL_9NbVpvZTymm4_0024glCNLIMoZa32HI_003D._0023_003DqZxUpT7HAhYFdvPR24cR3Rw_003D_003D())
		{
			_0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D2._0023_003DqzfAgJhDSkZ95__J9xF_eCHPP6FEEgfRODtTXmdBGhrY_003D = _0023_003Dq65VfEClgOTsEKZ6UWG8WLQ_003D_003D(_0023_003DqJmqLpxs2xrZMJxypakm3sQ_003D_003D, _0023_003DqauOlpx7UV04D_00242R4AnFsyQ_003D_003D);
			if (_0023_003Dq7OgbakVgjMOjAtKjJz8Zqw67XprZDHFQnZGaxRhl8iQ_003D.ContainsKey(_0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D2._0023_003DqzfAgJhDSkZ95__J9xF_eCHPP6FEEgfRODtTXmdBGhrY_003D))
			{
				SteamUserStats.UploadLeaderboardScore(new SteamLeaderboard_t(_0023_003Dq7OgbakVgjMOjAtKjJz8Zqw67XprZDHFQnZGaxRhl8iQ_003D[_0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D2._0023_003DqzfAgJhDSkZ95__J9xF_eCHPP6FEEgfRODtTXmdBGhrY_003D]._0023_003DqMDhobIUnLfdcIZ5Cc2t1VQ_003D_003D), ELeaderboardUploadScoreMethod.k_ELeaderboardUploadScoreMethodKeepBest, _0023_003DqD9ZnZhsM7_0024BeOidlBB_rrQ_003D_003D, null, 0)._0023_003Dq7b19I6VxiSbi_A6zXKd2sg_003D_003D<LeaderboardScoreUploaded_t>(_0023_003DqYsfT4xIYi8ItkIYg9gcKV9vNM3iyDqOihRhGcZM2HLg_003D2._0023_003Dq27HE71F3wnjXASZtn5tdYnQodqtgwE01emWtf5P8vjY_003D);
			}
		}
	}

	private void _0023_003DqL_iH1t4R9Hec42oMhNi4MfnPgW_0024y351zykblUjIgsx0_003D(string _0023_003DqkwUDNLk_2CpqfcshftxTjfPp_0024WiLLdF9P8OVuMZVudw_003D, bool _0023_003DqShF3KiQGSfYb6mW70dg5_w_003D_003D)
	{
		if (_0023_003DqShF3KiQGSfYb6mW70dg5_w_003D_003D || !_0023_003Dqn7R438K_QLdq8DL0X1hS9oMdKbqHEBXChZpaET05wYk_003D.TryGetValue(_0023_003DqkwUDNLk_2CpqfcshftxTjfPp_0024WiLLdF9P8OVuMZVudw_003D, out var value) || !(DateTime.Now - value < TimeSpan.FromSeconds(10.0)))
		{
			_0023_003Dqn7R438K_QLdq8DL0X1hS9oMdKbqHEBXChZpaET05wYk_003D[_0023_003DqkwUDNLk_2CpqfcshftxTjfPp_0024WiLLdF9P8OVuMZVudw_003D] = DateTime.Now;
			SteamUserStats.FindOrCreateLeaderboard(_0023_003DqkwUDNLk_2CpqfcshftxTjfPp_0024WiLLdF9P8OVuMZVudw_003D, ELeaderboardSortMethod.k_ELeaderboardSortMethodAscending, ELeaderboardDisplayType.k_ELeaderboardDisplayTypeNumeric)._0023_003Dq7b19I6VxiSbi_A6zXKd2sg_003D_003D<LeaderboardFindResult_t>(_0023_003DqsYZcyxSWiMtqB7_8Lbb7M3d77pzi2BnFjz2LbWwGSHA_003D);
		}
	}

	private void _0023_003DqsYZcyxSWiMtqB7_8Lbb7M3d77pzi2BnFjz2LbWwGSHA_003D(LeaderboardFindResult_t _0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D, bool _0023_003Dq0l0I2f4chDa7ks8H622JEg_003D_003D)
	{
		if (_0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D.m_bLeaderboardFound == 0 || _0023_003Dq0l0I2f4chDa7ks8H622JEg_003D_003D)
		{
			return;
		}
		string leaderboardName = SteamUserStats.GetLeaderboardName(_0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D.m_hSteamLeaderboard);
		if (!_0023_003Dq7OgbakVgjMOjAtKjJz8Zqw67XprZDHFQnZGaxRhl8iQ_003D.ContainsKey(leaderboardName))
		{
			_0023_003Dq7OgbakVgjMOjAtKjJz8Zqw67XprZDHFQnZGaxRhl8iQ_003D[leaderboardName] = new _0023_003DqXJkfnefYbWCgm7FdX3GzTA_003D_003D(_0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D.m_hSteamLeaderboard.m_SteamLeaderboard);
		}
		int num = SteamUserStats.GetLeaderboardEntryCount(_0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D.m_hSteamLeaderboard) / 100 + 1;
		SteamUserStats.DownloadLeaderboardEntries(_0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D.m_hSteamLeaderboard, ELeaderboardDataRequest.k_ELeaderboardDataRequestGlobal, num, num)._0023_003Dq7b19I6VxiSbi_A6zXKd2sg_003D_003D(delegate(LeaderboardScoresDownloaded_t _0023_003DqCd0as4IEnumcul9GIHu6kQ_003D_003D, bool _0023_003DqBi_0024T9qfhCjQAuqw1OeOW6A_003D_003D)
		{
			if (!_0023_003DqBi_0024T9qfhCjQAuqw1OeOW6A_003D_003D && _0023_003DqCd0as4IEnumcul9GIHu6kQ_003D_003D.m_cEntryCount == 1)
			{
				SteamUserStats.GetDownloadedLeaderboardEntry(_0023_003DqCd0as4IEnumcul9GIHu6kQ_003D_003D.m_hSteamLeaderboardEntries, 0, out var pLeaderboardEntry, null, 0);
				string leaderboardName2 = SteamUserStats.GetLeaderboardName(_0023_003DqCd0as4IEnumcul9GIHu6kQ_003D_003D.m_hSteamLeaderboard);
				_0023_003Dq1hl7crhFi9nO0SRNgJeP_SVpnsGmXmtXYOizHkdd_0024jU_003D[leaderboardName2] = pLeaderboardEntry.m_nScore;
			}
		});
		num = SteamUserStats.GetLeaderboardEntryCount(_0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D.m_hSteamLeaderboard) / 10 + 1;
		SteamUserStats.DownloadLeaderboardEntries(_0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D.m_hSteamLeaderboard, ELeaderboardDataRequest.k_ELeaderboardDataRequestGlobal, num, num)._0023_003Dq7b19I6VxiSbi_A6zXKd2sg_003D_003D(delegate(LeaderboardScoresDownloaded_t _0023_003DqSAMs5dRKzqgCIpxDI2SvKw_003D_003D, bool _0023_003DqxMtaKToqdlYoshtMRGtWHg_003D_003D)
		{
			if (!_0023_003DqxMtaKToqdlYoshtMRGtWHg_003D_003D && _0023_003DqSAMs5dRKzqgCIpxDI2SvKw_003D_003D.m_cEntryCount == 1)
			{
				SteamUserStats.GetDownloadedLeaderboardEntry(_0023_003DqSAMs5dRKzqgCIpxDI2SvKw_003D_003D.m_hSteamLeaderboardEntries, 0, out var pLeaderboardEntry, null, 0);
				string leaderboardName2 = SteamUserStats.GetLeaderboardName(_0023_003DqSAMs5dRKzqgCIpxDI2SvKw_003D_003D.m_hSteamLeaderboard);
				_0023_003DqA9wiUEbYo0Xzh28xIjkdIjHpT0i8Rgp3WR7b70hzJzA_003D[leaderboardName2] = pLeaderboardEntry.m_nScore;
			}
		});
		SteamUserStats.DownloadLeaderboardEntries(_0023_003Dqv_vcbPWilp6F4_0024oc5F9YhQ_003D_003D.m_hSteamLeaderboard, ELeaderboardDataRequest.k_ELeaderboardDataRequestFriends, 0, 0)._0023_003Dq7b19I6VxiSbi_A6zXKd2sg_003D_003D<LeaderboardScoresDownloaded_t>(_0023_003Dq3LpOE2ixl0WEKyNlYMsXeqi7BlZdbkqV8MBJuUL9qOtnODiUFzJfuv3Z9lBTrDHd);
	}

	private void _0023_003DqOTl0AYLMRlrEKgRQoelan9Dd_Xv_0024xvk_0024VzIuXOEeyI9OatucNKSFLEppFTbwK9Rx(LeaderboardScoresDownloaded_t _0023_003DqCd0as4IEnumcul9GIHu6kQ_003D_003D, bool _0023_003DqBi_0024T9qfhCjQAuqw1OeOW6A_003D_003D)
	{
		if (!_0023_003DqBi_0024T9qfhCjQAuqw1OeOW6A_003D_003D && _0023_003DqCd0as4IEnumcul9GIHu6kQ_003D_003D.m_cEntryCount == 1)
		{
			SteamUserStats.GetDownloadedLeaderboardEntry(_0023_003DqCd0as4IEnumcul9GIHu6kQ_003D_003D.m_hSteamLeaderboardEntries, 0, out var pLeaderboardEntry, null, 0);
			string leaderboardName = SteamUserStats.GetLeaderboardName(_0023_003DqCd0as4IEnumcul9GIHu6kQ_003D_003D.m_hSteamLeaderboard);
			_0023_003Dq1hl7crhFi9nO0SRNgJeP_SVpnsGmXmtXYOizHkdd_0024jU_003D[leaderboardName] = pLeaderboardEntry.m_nScore;
		}
	}

	private void _0023_003Dq7dk_0024NLqo_nvfQ9_0024fLs0VmSQmo3a4M21TUV81PTpGxkQjFG__akJgaXV34yrs2N1i(LeaderboardScoresDownloaded_t _0023_003DqSAMs5dRKzqgCIpxDI2SvKw_003D_003D, bool _0023_003DqxMtaKToqdlYoshtMRGtWHg_003D_003D)
	{
		if (!_0023_003DqxMtaKToqdlYoshtMRGtWHg_003D_003D && _0023_003DqSAMs5dRKzqgCIpxDI2SvKw_003D_003D.m_cEntryCount == 1)
		{
			SteamUserStats.GetDownloadedLeaderboardEntry(_0023_003DqSAMs5dRKzqgCIpxDI2SvKw_003D_003D.m_hSteamLeaderboardEntries, 0, out var pLeaderboardEntry, null, 0);
			string leaderboardName = SteamUserStats.GetLeaderboardName(_0023_003DqSAMs5dRKzqgCIpxDI2SvKw_003D_003D.m_hSteamLeaderboard);
			_0023_003DqA9wiUEbYo0Xzh28xIjkdIjHpT0i8Rgp3WR7b70hzJzA_003D[leaderboardName] = pLeaderboardEntry.m_nScore;
		}
	}

	private void _0023_003Dq3LpOE2ixl0WEKyNlYMsXeqi7BlZdbkqV8MBJuUL9qOtnODiUFzJfuv3Z9lBTrDHd(LeaderboardScoresDownloaded_t _0023_003DqNNeYWuTNct5tuW__0024__0024tt4w_003D_003D, bool _0023_003DqhatQsZBhlO5xqYSKuvQf_g_003D_003D)
	{
		if (!_0023_003DqhatQsZBhlO5xqYSKuvQf_g_003D_003D)
		{
			List<LeaderboardEntry> list = new List<LeaderboardEntry>();
			for (int i = 0; i < _0023_003DqNNeYWuTNct5tuW__0024__0024tt4w_003D_003D.m_cEntryCount; i++)
			{
				SteamUserStats.GetDownloadedLeaderboardEntry(_0023_003DqNNeYWuTNct5tuW__0024__0024tt4w_003D_003D.m_hSteamLeaderboardEntries, i, out var pLeaderboardEntry, null, 0);
				list.Add(new LeaderboardEntry(SteamFriends.GetFriendPersonaName(pLeaderboardEntry.m_steamIDUser), pLeaderboardEntry.m_nScore, pLeaderboardEntry.m_steamIDUser == SteamUser.GetSteamID(), _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
			}
			list = (from _0023_003Dqy5mq7BdXkel_PGKILBBtPA_003D_003D in list
				orderby !_0023_003Dqy5mq7BdXkel_PGKILBBtPA_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D
				orderby _0023_003Dqy5mq7BdXkel_PGKILBBtPA_003D_003D._0023_003Dq7ayRO0XV_3aLpU2Nf0nfKQ_003D_003D
				select _0023_003Dqy5mq7BdXkel_PGKILBBtPA_003D_003D).ToList();
			while (list.Count > _0023_003Dq1BE__0024qf20vBohRV05G2e7yarF8qQea_D1eUSJ1tYCLQ_003D && !list[list.Count - 1]._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D)
			{
				list.RemoveAt(list.Count - 1);
			}
			while (list.Count > _0023_003Dq1BE__0024qf20vBohRV05G2e7yarF8qQea_D1eUSJ1tYCLQ_003D)
			{
				list.RemoveAt(list.Count - 2);
			}
			string leaderboardName = SteamUserStats.GetLeaderboardName(_0023_003DqNNeYWuTNct5tuW__0024__0024tt4w_003D_003D.m_hSteamLeaderboard);
			if (!string.IsNullOrEmpty(leaderboardName))
			{
				_0023_003Dq7OgbakVgjMOjAtKjJz8Zqw67XprZDHFQnZGaxRhl8iQ_003D[leaderboardName]._0023_003Dqnhue_0024WavKoQ4kb4AqqpOhQ_003D_003D = list;
			}
		}
	}

	public Dictionary<_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D, _0023_003Dq__0024KNguMZcw2pxvSrhRb7gg_003D_003D> _0023_003DqGmJRsyTl_e5rQGD_0024MUYGGIPVuAjktM90A2_00241dWfrI7o_0024DvSJMRuo9x7lB68WgK0_(Puzzle _0023_003DqQKCNQDvV7wBQrVUNkruXGA_003D_003D, Maybe<_0023_003DqdIs8DPoCFMGsGsoyP6nE8Q_003D_003D> _0023_003DqLVPrLBYMNJ9YauZrmcxM2Q_003D_003D, Maybe<_0023_003DqdIs8DPoCFMGsGsoyP6nE8Q_003D_003D> _0023_003DqMfeSi323mJh5VLo5azt30A_003D_003D)
	{
		Dictionary<_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D, _0023_003Dq__0024KNguMZcw2pxvSrhRb7gg_003D_003D> dictionary = new Dictionary<_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D, _0023_003Dq__0024KNguMZcw2pxvSrhRb7gg_003D_003D>();
		_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D[] array = _0023_003DqSu3jnh60RT8z6kwX0VxdgQ_003D_003D;
		for (int i = 0; i < array.Length; i++)
		{
			_0023_003DqnOLj54kIvFQ5gu6pzObc5kdNvjzFz0Yd9BkDHIkJjHo_003D CS_0024_003C_003E8__locals8 = new _0023_003DqnOLj54kIvFQ5gu6pzObc5kdNvjzFz0Yd9BkDHIkJjHo_003D();
			CS_0024_003C_003E8__locals8._0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D = array[i];
			string text = _0023_003Dq65VfEClgOTsEKZ6UWG8WLQ_003D_003D(_0023_003DqQKCNQDvV7wBQrVUNkruXGA_003D_003D, CS_0024_003C_003E8__locals8._0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D);
			dictionary[CS_0024_003C_003E8__locals8._0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D] = new _0023_003Dq__0024KNguMZcw2pxvSrhRb7gg_003D_003D
			{
				_0023_003DqEn5XAylN_0024aTxhNYIWYDuqA_003D_003D = CS_0024_003C_003E8__locals8._0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D,
				_0023_003DqQpPu4nkWR2oyIPqpUj4u8w_003D_003D = text,
				_0023_003DqDQHLQ_0024Iw3vKNJK0flnvrxw_003D_003D = _0023_003Dq6cf4Ybd3fCTg6PA_wUmsiumzP2xZLm2Xpd38TvB3HeQ_003D(text),
				_0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D = _0023_003DqLVPrLBYMNJ9YauZrmcxM2Q_003D_003D._0023_003DqNLK1vk9_00242e7TtB5lccHXyA_003D_003D((_0023_003DqdIs8DPoCFMGsGsoyP6nE8Q_003D_003D _0023_003Dq9KBdHkZP3jwOt2t4qemupQ_003D_003D) => _0023_003Dq9KBdHkZP3jwOt2t4qemupQ_003D_003D._0023_003DqDgQ63SpiYSjN_00240OjnKo98g_003D_003D(CS_0024_003C_003E8__locals8._0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D)),
				_0023_003DqFX7_U5elNIDGX2EvRofQSQ_003D_003D = _0023_003DqMfeSi323mJh5VLo5azt30A_003D_003D._0023_003DqNLK1vk9_00242e7TtB5lccHXyA_003D_003D<int>(CS_0024_003C_003E8__locals8._0023_003Dq74aSy1RhGgi8W2T5tz7tmA05hB1awShBNmYzk0P3OcMrIyUZxtmGaPAmNHD2P_VH)
			};
			_0023_003DqL_iH1t4R9Hec42oMhNi4MfnPgW_0024y351zykblUjIgsx0_003D(text, _0023_003DqShF3KiQGSfYb6mW70dg5_w_003D_003D: false);
			if (_0023_003DqZj1zmEuVL1_0024uSpLODwJG7dNgjiZqhIuJmGuYMryG_0024NA_003D)
			{
				dictionary[CS_0024_003C_003E8__locals8._0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D]._0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D = (from _0023_003Dq_0024zwkIINvdM7xwSIpIk_vMw_003D_003D in _0023_003DqXJHJEt5O_FiJ08ZNtzmPfmp6gKA_0024FDOPOJojcEeyTaw_003D(text, _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D)
					where _0023_003Dq_0024zwkIINvdM7xwSIpIk_vMw_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D
					select _0023_003Dq_0024zwkIINvdM7xwSIpIk_vMw_003D_003D._0023_003Dq7ayRO0XV_3aLpU2Nf0nfKQ_003D_003D)._0023_003DqwgC4EGrGw3mLo2TGE6erqQ_003D_003D();
				dictionary[CS_0024_003C_003E8__locals8._0023_003DqxEdhq_jvDLcO1JyK_0024EyCmQ_003D_003D]._0023_003DqFX7_U5elNIDGX2EvRofQSQ_003D_003D = _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
			}
		}
		return dictionary;
	}

	public List<LeaderboardEntry> _0023_003DqXJHJEt5O_FiJ08ZNtzmPfmp6gKA_0024FDOPOJojcEeyTaw_003D(string _0023_003DqGb0k0BjNFNC3h8c08pmcwg_003D_003D, Maybe<int> _0023_003DqqxbqlASHQhnMkBIYEntRzA_003D_003D)
	{
		_0023_003DqTbHujJozIUc6vtGRwJiolRejDvuUv942PYCstoInBlg_003D CS_0024_003C_003E8__locals22 = new _0023_003DqTbHujJozIUc6vtGRwJiolRejDvuUv942PYCstoInBlg_003D();
		CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D = new List<LeaderboardEntry>();
		if (_0023_003Dq7OgbakVgjMOjAtKjJz8Zqw67XprZDHFQnZGaxRhl8iQ_003D.TryGetValue(_0023_003DqGb0k0BjNFNC3h8c08pmcwg_003D_003D, out var value))
		{
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.AddRange(value._0023_003Dqnhue_0024WavKoQ4kb4AqqpOhQ_003D_003D);
		}
		if (_0023_003DqZj1zmEuVL1_0024uSpLODwJG7dNgjiZqhIuJmGuYMryG_0024NA_003D)
		{
			_0023_003DqtlDhosyhYYq5a0seIyFJRCuRKw_xSLPYnVs1DYjqwnY_003D _0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D = default(_0023_003DqtlDhosyhYYq5a0seIyFJRCuRKw_xSLPYnVs1DYjqwnY_003D);
			_0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D._0023_003DqTXLSNXise7WGPCZ_0024VryWQg_003D_003D = new ReliableRandom((ulong)_0023_003DqGb0k0BjNFNC3h8c08pmcwg_003D_003D.GetHashCode());
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Clear();
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065711101), _0023_003DqL06LkT_002414LqdXuKkPdsRsB4IFNpqR7UNnTkW4qzJX90yiTLOuvHNy9K3YHFlOYgV(ref _0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D), _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: false, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710095), _0023_003DqL06LkT_002414LqdXuKkPdsRsB4IFNpqR7UNnTkW4qzJX90yiTLOuvHNy9K3YHFlOYgV(ref _0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D), _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: false, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710107), _0023_003DqL06LkT_002414LqdXuKkPdsRsB4IFNpqR7UNnTkW4qzJX90yiTLOuvHNy9K3YHFlOYgV(ref _0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D), _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: false, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710122), _0023_003DqL06LkT_002414LqdXuKkPdsRsB4IFNpqR7UNnTkW4qzJX90yiTLOuvHNy9K3YHFlOYgV(ref _0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D), _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: false, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710140), _0023_003DqL06LkT_002414LqdXuKkPdsRsB4IFNpqR7UNnTkW4qzJX90yiTLOuvHNy9K3YHFlOYgV(ref _0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D), _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: true, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
		}
		if (GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqL6HlhJGiNttvtnaf4SI4UQ_003D_003D._0023_003DqPB1hHRH97n7_0024rnRC1VtpFZi_00247XFLGpO6LOVjRyszo28_003D._0023_003DqZxUpT7HAhYFdvPR24cR3Rw_003D_003D() && _0023_003Dq1hl7crhFi9nO0SRNgJeP_SVpnsGmXmtXYOizHkdd_0024jU_003D.TryGetValue(_0023_003DqGb0k0BjNFNC3h8c08pmcwg_003D_003D, out var value2))
		{
			CS_0024_003C_003E8__locals22._0023_003DqR8Kan6rlC5qCoam_00247QE82sBCemFFtgTKERIPM29f8g27iETWdAK9dnaGKk1DX5hSrdwxgSwChC24wyBRLbsbhA_003D_003D();
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809318)), value2, _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: false, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: true));
		}
		if (GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqL6HlhJGiNttvtnaf4SI4UQ_003D_003D._0023_003DqtYbSX2KfVUxBDhPFZ7N06b45W3bwuwG_0024Acsp47wxFEg_003D._0023_003DqZxUpT7HAhYFdvPR24cR3Rw_003D_003D() && _0023_003DqA9wiUEbYo0Xzh28xIjkdIjHpT0i8Rgp3WR7b70hzJzA_003D.TryGetValue(_0023_003DqGb0k0BjNFNC3h8c08pmcwg_003D_003D, out var value3))
		{
			CS_0024_003C_003E8__locals22._0023_003DqR8Kan6rlC5qCoam_00247QE82sBCemFFtgTKERIPM29f8g27iETWdAK9dnaGKk1DX5hSrdwxgSwChC24wyBRLbsbhA_003D_003D();
			CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809329)), value3, _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: false, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: true));
		}
		if (_0023_003DqqxbqlASHQhnMkBIYEntRzA_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D() && !_0023_003DqZj1zmEuVL1_0024uSpLODwJG7dNgjiZqhIuJmGuYMryG_0024NA_003D)
		{
			Maybe<int> maybe = CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Where(_003C_003Ec._003C_003E9._0023_003DqbSuDBswKOhxC19aycsAfPuQqRjX894Q3JozJFM3J0fQ_003D).Select(_003C_003Ec._003C_003E9._0023_003DqVxM0j0gcdVekRa5naKlEs2tiN05MdJ7ifZd5EdH7WEE_003D)._0023_003DqwgC4EGrGw3mLo2TGE6erqQ_003D_003D();
			if (_0023_003DqqxbqlASHQhnMkBIYEntRzA_003D_003D != maybe)
			{
				CS_0024_003C_003E8__locals22._0023_003DqR8Kan6rlC5qCoam_00247QE82sBCemFFtgTKERIPM29f8g27iETWdAK9dnaGKk1DX5hSrdwxgSwChC24wyBRLbsbhA_003D_003D();
				CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.RemoveAll((LeaderboardEntry _0023_003DqD6Ph57q_0024oQE7WMXCNlJqIA_003D_003D) => _0023_003DqD6Ph57q_0024oQE7WMXCNlJqIA_003D_003D._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D);
				maybe._0023_003DqrauG0EMfCPa1HDKhJE_VWg_003D_003D(delegate(int _0023_003DqXgJhH6u9UEBipkzEBjRkpQ_003D_003D)
				{
					CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(SteamFriends.GetPersonaName(), _0023_003DqXgJhH6u9UEBipkzEBjRkpQ_003D_003D, _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: false, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
				});
				CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.Add(new LeaderboardEntry(SteamFriends.GetPersonaName(), _0023_003DqqxbqlASHQhnMkBIYEntRzA_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D(), _0023_003DqRI_lI9rszJR0c_RmsTkUHA_003D_003D: true, _0023_003DqChBKAwUT9kXflOdu6ADhVA_003D_003D: false));
			}
		}
		CS_0024_003C_003E8__locals22._0023_003Dqnc2tVateOAJpSiG87gzppw_003D_003D = SteamFriends.GetPersonaName();
		CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D = CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D.OrderBy(CS_0024_003C_003E8__locals22._0023_003DqZOfA8lUioDHaMFX53JPXaMzNtJtUEw8v7v5d7amKku0_003D).OrderBy(_003C_003Ec._003C_003E9._0023_003Dq2GN5poAU22ST6hEMw_APtXNOKbUzcL2LfYFDnjoKLLo_003D).ToList();
		return CS_0024_003C_003E8__locals22._0023_003DqNnHoyD85P2Mi0VKehopvzQ_003D_003D;
	}

	private Maybe<_0023_003DqzAXFSn5YAc4v4FDYB8lbVQ_003D_003D> _0023_003Dq6cf4Ybd3fCTg6PA_wUmsiumzP2xZLm2Xpd38TvB3HeQ_003D(string _0023_003Dquz3e1OTu4JzSQJBYSbsnpQ_003D_003D)
	{
		if (_0023_003DqZj1zmEuVL1_0024uSpLODwJG7dNgjiZqhIuJmGuYMryG_0024NA_003D)
		{
			_0023_003DqE31FfApUSq6Q_0024eByEbHvGSDInxuYPRYzJ0UXBGBeO3A_003D CS_0024_003C_003E8__locals12 = new _0023_003DqE31FfApUSq6Q_0024eByEbHvGSDInxuYPRYzJ0UXBGBeO3A_003D();
			CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D = Enumerable.Repeat(0f, 12).ToArray();
			ReliableRandom reliableRandom = new ReliableRandom((ulong)_0023_003Dquz3e1OTu4JzSQJBYSbsnpQ_003D_003D.GetHashCode());
			int num = reliableRandom._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(2, 6);
			int[] array = ((!_0023_003Dquz3e1OTu4JzSQJBYSbsnpQ_003D_003D.EndsWith(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065789274))) ? new int[12]
			{
				1, 3, 7, 10, 10, 7, 5, 3, 2, 2,
				1, 1
			} : new int[10] { 0, 1, 5, 9, 10, 7, 4, 2, 1, 1 });
			for (int i = 0; i < array.Length; i++)
			{
				int num2 = num + i - 3;
				if (num2 >= 0 && num2 < CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D.Length)
				{
					CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D[num2] = (float)array[i] / 10f;
				}
			}
			for (int j = num + 1; j < CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D.Length; j++)
			{
				if (CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D[j] > 0f)
				{
					CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D[j] = Utility._0023_003Dqkau7hU_0024BFCWNvu_HoHnSyw_003D_003D(CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D[j] + reliableRandom._0023_003DqSyiKIUiszDjYE8r6rKhg6g_003D_003D(-0.2f, 0.2f), 0.1f, CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D[j - 1]);
				}
			}
			CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D = CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D.Select((float _0023_003DqhQZ6lOFywEpKLqTg44a77A_003D_003D) => _0023_003DqhQZ6lOFywEpKLqTg44a77A_003D_003D / CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D.Max()).ToArray();
			return new _0023_003DqzAXFSn5YAc4v4FDYB8lbVQ_003D_003D
			{
				_0023_003Dqi4BE5BKWLn1bCP50s0xT5Q_003D_003D = 12,
				_0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D = CS_0024_003C_003E8__locals12._0023_003DqVSoO_y3JskIT7UsNpKSaYw_003D_003D
			};
		}
		try
		{
			if (_0023_003DqLFdGGV5PzHwpjituX5kp6w_003D_003D.TryGetValue(_0023_003Dquz3e1OTu4JzSQJBYSbsnpQ_003D_003D, out var value))
			{
				int[] array2 = (from _0023_003Dq3hiacNtODO3C9yEcHTeKFg_003D_003D in value.Split(new char[1] { ',' })
					select int.Parse(_0023_003Dq3hiacNtODO3C9yEcHTeKFg_003D_003D)).ToArray();
				if (array2.Length >= 2)
				{
					List<float> list = array2.Skip(1).Select((Func<int, float>)((int _0023_003DqDLFLVRwO9CV61RaySW_0024MYg_003D_003D) => _0023_003DqDLFLVRwO9CV61RaySW_0024MYg_003D_003D)).ToList();
					float num3 = list.Max();
					if (num3 > 0f)
					{
						for (int num4 = 0; num4 < list.Count; num4++)
						{
							list[num4] /= num3;
						}
					}
					return new _0023_003DqzAXFSn5YAc4v4FDYB8lbVQ_003D_003D
					{
						_0023_003Dqi4BE5BKWLn1bCP50s0xT5Q_003D_003D = array2[0],
						_0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D = list.ToArray()
					};
				}
			}
		}
		catch
		{
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public void _0023_003DqDKEKcgQ5Uue0kg4HMY130w_003D_003D(_0023_003Dq__0024KNguMZcw2pxvSrhRb7gg_003D_003D _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D, Vector2 _0023_003DqnsNB9PT5y912cwI2ly6_4A_003D_003D)
	{
		_0023_003Dqz_0024jqTD7XKLjab8encrJttGP__6YkwIIfbPmXG4_0024Bsc4_003D._0023_003DqTUw5TTQutAgf20wrMy_0024RhlONBWOHyNlbkwixUIz8lPc_003D _0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D;
		G._0023_003DqCNSP5a8AZ9sPy86nFsDdeg_003D_003D(_0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D._0023_003DqOhKQjevLwTZwnFUBk3iLZA_003D_003D, _0023_003DqnsNB9PT5y912cwI2ly6_4A_003D_003D);
		if (!_0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqDQHLQ_0024Iw3vKNJK0flnvrxw_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D() || _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqDQHLQ_0024Iw3vKNJK0flnvrxw_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D()._0023_003Dqi4BE5BKWLn1bCP50s0xT5Q_003D_003D <= 0 || _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqDQHLQ_0024Iw3vKNJK0flnvrxw_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D()._0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D.Length == 0 || !GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqL6HlhJGiNttvtnaf4SI4UQ_003D_003D._0023_003DqUzHuDvNarH3C2PGLKoREiQBJ_0024cjt4vN8RlVqnWGXNfQ_003D._0023_003DqZxUpT7HAhYFdvPR24cR3Rw_003D_003D())
		{
			return;
		}
		float[] _0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D = _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqDQHLQ_0024Iw3vKNJK0flnvrxw_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D()._0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D;
		using (G._0023_003DqfxNFsh3EN79X9_w5TqfddQ_003D_003D())
		{
			G._0023_003Dq2Wv1naNy0PI3lcDUHo_AqQ_003D_003D(_0023_003Dq96EFhq5PXlqazNqwOoY1GOJGG4cp9fx61xn16VU_p_0024Q_003D._0023_003Dq_0024k13XkVYnzFiO_0024gJsUfVsw_003D_003D(Color.Black));
			G._0023_003DqL6KefVaC7_0024Y1uv6kdUs19g_003D_003D(Color.White, Vector2.Zero, new Vector2(169f, 3f));
			for (int i = 0; i < _0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D.Length; i++)
			{
				int num = (int)Math.Round(_0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D[i] * (float)_0023_003Dq96EFhq5PXlqazNqwOoY1GOJGG4cp9fx61xn16VU_p_0024Q_003D._0023_003DqAs01Ca892d66YUDNd0tv8A_003D_003D().Y);
				G._0023_003DqL6KefVaC7_0024Y1uv6kdUs19g_003D_003D(Color.White, new Vector2(i * 14, 0f), new Vector2(15f, num));
				if (i == 0 || _0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D[i - 1] < _0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D[i])
				{
					G._0023_003DqL6KefVaC7_0024Y1uv6kdUs19g_003D_003D(Color.Black, new Vector2(i * 14, num - 1), new Vector2(1f, 1f));
				}
				if (i == _0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D.Length - 1 || _0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D[i + 1] < _0023_003DqCpEYdXis0ENaBLQdQLcJW0QJB6_0024a6PbD6TfRCA_jJmk_003D[i])
				{
					G._0023_003DqL6KefVaC7_0024Y1uv6kdUs19g_003D_003D(Color.Black, new Vector2(i * 14 + 14, num - 1), new Vector2(1f, 1f));
				}
			}
		}
		using (G._0023_003DqfxNFsh3EN79X9_w5TqfddQ_003D_003D())
		{
			G._0023_003Dq_Hvyo_TIMiK0JMDg6sZNCA_003D_003D(_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqCAoUWKNIWRQE6VKaI9FWLg_003D_003D()._0023_003Dq5SvYc_0024yF8eSZqeSBSFPrQA_003D_003D);
			G._0023_003DqCYtuV_c_0024hY4cQutcT1tDCA_003D_003D(1, _0023_003Dq96EFhq5PXlqazNqwOoY1GOJGG4cp9fx61xn16VU_p_0024Q_003D._0023_003DqsoD_0024cdvWjmdddMifSJTL_QcjA9S_0024_0024DBdwIQxZoNtZtg_003D(_0023_003DqzwVwGoc4cIefyybhsdvyag_003D_003D: true)._0023_003Dql8VZ7KS5o_8nFSPRS4A7Jw_003D_003D);
			G._0023_003DqCNSP5a8AZ9sPy86nFsDdeg_003D_003D(_0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D._0023_003Dqr9OpUVqD3yYTf4BiDGa2bg_003D_003D, _0023_003DqnsNB9PT5y912cwI2ly6_4A_003D_003D);
		}
		if (_0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			float num2 = Math.Min(_0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D(), 12) * 14 - 7;
			G._0023_003DqCNSP5a8AZ9sPy86nFsDdeg_003D_003D(_0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D._0023_003DqdxmYDpBaVz0uVjMlOUs1QA_003D_003D, _0023_003DqnsNB9PT5y912cwI2ly6_4A_003D_003D + new Vector2(num2 - 5f, 0f));
			string _0023_003DqvQrSLWoCkcKyXEWLbTOjaA_003D_003D = _0023_003Dq7WHPsJgCV9zPo4ufQvxKeA_003D_003D(_0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqEn5XAylN_0024aTxhNYIWYDuqA_003D_003D, _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
			Maybe<float> maybe = _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
			bool flag = false;
			if (_0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqFX7_U5elNIDGX2EvRofQSQ_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D() && _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D != _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqFX7_U5elNIDGX2EvRofQSQ_003D_003D)
			{
				flag = _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D() < _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqFX7_U5elNIDGX2EvRofQSQ_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D();
				string text = _0023_003Dq7WHPsJgCV9zPo4ufQvxKeA_003D_003D(_0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqEn5XAylN_0024aTxhNYIWYDuqA_003D_003D, _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqFX7_U5elNIDGX2EvRofQSQ_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
				string text2 = _0023_003Dq7WHPsJgCV9zPo4ufQvxKeA_003D_003D(_0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqEn5XAylN_0024aTxhNYIWYDuqA_003D_003D, _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
				_0023_003DqvQrSLWoCkcKyXEWLbTOjaA_003D_003D = string.Format(flag ? _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710172) : _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710150), text, text2);
				maybe = G._0023_003Dqf4sximcw0REZ0wX0tV1pZg_003D_003D(flag ? text2 : text, Vector2.Zero, _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003Dq4XMzGETtp0xId_0024vvTZgNcg_003D_003D()._0023_003DqnOUGLtKmdlp1hfore1CIyQ_003D_003D._0023_003DqHjJHbhKPQiHkzVKDUE4F5w_003D_003D(Language.English), Color.White).Measure().Width;
				num2 += 1f;
			}
			TextDrawingOptions textDrawingOptions = G._0023_003Dqf4sximcw0REZ0wX0tV1pZg_003D_003D(_0023_003DqvQrSLWoCkcKyXEWLbTOjaA_003D_003D, Vector2.Zero, _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003Dq4XMzGETtp0xId_0024vvTZgNcg_003D_003D()._0023_003DqnOUGLtKmdlp1hfore1CIyQ_003D_003D._0023_003DqHjJHbhKPQiHkzVKDUE4F5w_003D_003D(Language.English), Color.FromHex(13035998)).WithAdditionalCharacterSpacing(0f, 11f);
			float width = textDrawingOptions.Measure().Width;
			num2 = Utility._0023_003Dqkau7hU_0024BFCWNvu_HoHnSyw_003D_003D(num2, width / 2f, (float)_0023_003Dq96EFhq5PXlqazNqwOoY1GOJGG4cp9fx61xn16VU_p_0024Q_003D._0023_003DqAs01Ca892d66YUDNd0tv8A_003D_003D().X - width / 2f);
			textDrawingOptions.WithPosition(_0023_003DqnsNB9PT5y912cwI2ly6_4A_003D_003D + new Vector2(num2 - width / 2f + 1f, 126f)).Draw();
			if (maybe._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
			{
				Vector2 _0023_003DqAgmAl169UChqgIVvrP1DRg_003D_003D = _0023_003DqnsNB9PT5y912cwI2ly6_4A_003D_003D + new Vector2(3f, 127f).Translated(num2 - width / 2f + maybe._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D() - 1f, 0f).Rounded();
				G._0023_003DqujVpBxwqG0KWXGeQJ4WpQw93tVSP48aN0S018xfMzVE_003D(_0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D._0023_003Dqay_0024CsZL4Bqui8mqtbSC2oA_003D_003D, _0023_003DqAgmAl169UChqgIVvrP1DRg_003D_003D, flag ? QuarterRotations.Rotate180 : QuarterRotations.Rotate0);
			}
		}
		for (int j = 1; j < 13; j++)
		{
			string text3 = _0023_003Dq7WHPsJgCV9zPo4ufQvxKeA_003D_003D(_0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqEn5XAylN_0024aTxhNYIWYDuqA_003D_003D, j);
			Vector2 _0023_003DqP55a1SOgIwU9HClqa6y0YA_003D_003D = _0023_003DqnsNB9PT5y912cwI2ly6_4A_003D_003D + new Vector2(j * 14 - 6, -15f);
			if (j == 12 && _0023_003DqOd97PvtigHkUIuyg7FyRZw_003D_003D._0023_003DqEn5XAylN_0024aTxhNYIWYDuqA_003D_003D == (_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D)2)
			{
				text3 += _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777727);
				_0023_003DqP55a1SOgIwU9HClqa6y0YA_003D_003D.X += 2f;
			}
			G._0023_003Dqf4sximcw0REZ0wX0tV1pZg_003D_003D(text3, _0023_003DqP55a1SOgIwU9HClqa6y0YA_003D_003D, _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003Dq4XMzGETtp0xId_0024vvTZgNcg_003D_003D()._0023_003Dq2R55ePSl6p7ict_EoS_0024IUQ_003D_003D, Color.FromHex(6132107)).AlignedCenter().Draw();
		}
	}

	public void _0023_003DqiI4e0NvDbzRK908vdD70pNgTn_50yDdOCREkva_0024gBQo_003D(_0023_003Dq__0024KNguMZcw2pxvSrhRb7gg_003D_003D _0023_003DqT7FVZGA_GZVQnysI5bR1AQ_003D_003D, Vector2 _0023_003Dq9aFDPdt6VFE2rNyxz9NDdw_003D_003D)
	{
		_0023_003Dqz_0024jqTD7XKLjab8encrJttGP__6YkwIIfbPmXG4_0024Bsc4_003D._0023_003DqTUw5TTQutAgf20wrMy_0024RhlONBWOHyNlbkwixUIz8lPc_003D _0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D;
		for (int i = 0; i < _0023_003Dq1BE__0024qf20vBohRV05G2e7yarF8qQea_D1eUSJ1tYCLQ_003D; i++)
		{
			G._0023_003DqCNSP5a8AZ9sPy86nFsDdeg_003D_003D(_0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D._0023_003Dq2NEFbSkU_Y7AH8W_0024IJEuzw_003D_003D, _0023_003Dq9aFDPdt6VFE2rNyxz9NDdw_003D_003D + new Vector2(0f, i * -18));
		}
		if (!GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqL6HlhJGiNttvtnaf4SI4UQ_003D_003D._0023_003DqvqF11jKkjrqHCsL_9NbVpvZTymm4_0024glCNLIMoZa32HI_003D._0023_003DqZxUpT7HAhYFdvPR24cR3Rw_003D_003D())
		{
			return;
		}
		List<LeaderboardEntry> list = _0023_003DqXJHJEt5O_FiJ08ZNtzmPfmp6gKA_0024FDOPOJojcEeyTaw_003D(_0023_003DqT7FVZGA_GZVQnysI5bR1AQ_003D_003D._0023_003DqQpPu4nkWR2oyIPqpUj4u8w_003D_003D, _0023_003DqT7FVZGA_GZVQnysI5bR1AQ_003D_003D._0023_003DqX_Qg07ysmRyMAB9Dv7bIVA_003D_003D);
		for (int j = 0; j < list.Count; j++)
		{
			LeaderboardEntry leaderboardEntry = list[j];
			bool _0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D = leaderboardEntry._0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D;
			string _0023_003DqvQrSLWoCkcKyXEWLbTOjaA_003D_003D = leaderboardEntry._0023_003DqkxnOcnB6AcA4PlmvdHPFlA_003D_003D._0023_003Dq_0024ciClXEtToqRdTh7YIZK8Q_003D_003D(_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003Dq4XMzGETtp0xId_0024vvTZgNcg_003D_003D()._0023_003DqnOUGLtKmdlp1hfore1CIyQ_003D_003D._0023_003DqHjJHbhKPQiHkzVKDUE4F5w_003D_003D(Language.English))._0023_003DqSwIx3opeQHapfBW6H5Ma4EBhjdblvzlEV1v_EPH3Zrw_003D().ToUpper();
			string _0023_003DqvQrSLWoCkcKyXEWLbTOjaA_003D_003D2 = _0023_003Dq7WHPsJgCV9zPo4ufQvxKeA_003D_003D(_0023_003DqT7FVZGA_GZVQnysI5bR1AQ_003D_003D._0023_003DqEn5XAylN_0024aTxhNYIWYDuqA_003D_003D, leaderboardEntry._0023_003Dq7ayRO0XV_3aLpU2Nf0nfKQ_003D_003D);
			G._0023_003DqCNSP5a8AZ9sPy86nFsDdeg_003D_003D(_0023_003DqJH_xXB9GEL6Aca5m1KzerQ_003D_003D ? _0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D._0023_003DqMjuFC3N_002408yFrJBylKP5mA_003D_003D : _0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D._0023_003Dq6SYiMVC0iqrMSJpTdIIStA_003D_003D, _0023_003Dq9aFDPdt6VFE2rNyxz9NDdw_003D_003D);
			Vector2 _0023_003DqP55a1SOgIwU9HClqa6y0YA_003D_003D = _0023_003Dq9aFDPdt6VFE2rNyxz9NDdw_003D_003D + new Vector2(9f, 4f);
			if (leaderboardEntry._0023_003Dq2EIXUqW4ClXl5LtZ6XC3Gw_003D_003D)
			{
				G._0023_003DqCNSP5a8AZ9sPy86nFsDdeg_003D_003D(_0023_003Dq7dWVtCm8Raqjs9pKN45c2A_003D_003D._0023_003Dqyls8i_PYaXI9Vi1zgXfnWQ_003D_003D, _0023_003Dq9aFDPdt6VFE2rNyxz9NDdw_003D_003D + new Vector2(7f, 3f));
				_0023_003DqP55a1SOgIwU9HClqa6y0YA_003D_003D.X += 9f;
			}
			Color _0023_003DqjwtZ4Jh_paO9u4CfeII6aA_003D_003D = Color.FromHex(1646622);
			Bounds2 bounds = G._0023_003Dqf4sximcw0REZ0wX0tV1pZg_003D_003D(_0023_003DqvQrSLWoCkcKyXEWLbTOjaA_003D_003D2, _0023_003Dq9aFDPdt6VFE2rNyxz9NDdw_003D_003D + new Vector2(163f, 4f), _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003Dq4XMzGETtp0xId_0024vvTZgNcg_003D_003D()._0023_003DqnOUGLtKmdlp1hfore1CIyQ_003D_003D._0023_003DqHjJHbhKPQiHkzVKDUE4F5w_003D_003D(Language.English), _0023_003DqjwtZ4Jh_paO9u4CfeII6aA_003D_003D).AlignedRight().DrawAndMeasure();
			G._0023_003Dqf4sximcw0REZ0wX0tV1pZg_003D_003D(_0023_003DqvQrSLWoCkcKyXEWLbTOjaA_003D_003D, _0023_003DqP55a1SOgIwU9HClqa6y0YA_003D_003D, _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003Dq4XMzGETtp0xId_0024vvTZgNcg_003D_003D()._0023_003DqnOUGLtKmdlp1hfore1CIyQ_003D_003D._0023_003DqHjJHbhKPQiHkzVKDUE4F5w_003D_003D(Language.English), _0023_003DqjwtZ4Jh_paO9u4CfeII6aA_003D_003D).WithTruncateWidth(150f - bounds.Width).Draw();
			_0023_003Dq9aFDPdt6VFE2rNyxz9NDdw_003D_003D.Y -= 18f;
		}
	}

	public static string _0023_003Dq7WHPsJgCV9zPo4ufQvxKeA_003D_003D(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqncikGu_0024Qy8sAPXUv6IpODw_003D_003D, int _0023_003Dq_0024ECA5STX0L61S0Rmkl5syA_003D_003D)
	{
		if (_0023_003DqncikGu_0024Qy8sAPXUv6IpODw_003D_003D == (_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D)2)
		{
			return (_0023_003Dq_0024ECA5STX0L61S0Rmkl5syA_003D_003D - 1).ToString();
		}
		return _0023_003Dq_0024ECA5STX0L61S0Rmkl5syA_003D_003D.ToString();
	}

	public static _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003Dq2CAH9TsEzWIkP1Q_3K7YGA_003D_003D(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D _0023_003DqksIrbtRU1MZzlhrpub8fzA_003D_003D)
	{
		return _0023_003DqksIrbtRU1MZzlhrpub8fzA_003D_003D switch
		{
			(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D)0 => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710186)), 
			(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D)1 => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710206)), 
			(_0023_003DqPWUclSuDX2kZFCYiZ0UZgA_003D_003D)2 => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065710193)), 
			_ => throw new _0023_003DqP1Lvlriw8JdzHp67vrhOBYFwzXCcBrFvFv_m_d2KdZA_003D(), 
		};
	}

	private void _0023_003Dq1u_OeBFO_bHg3MjRmMBSXpPfQ5M3WQe6i48AW_0024ZtWs4_003D(byte[] _0023_003Dq1gan0ArtZuLtMof7coCIiQ_003D_003D)
	{
		foreach (string item in from _0023_003DqM81BNO6XtaqLhiXluBZavA_003D_003D in Encoding.ASCII.GetString(Utility._0023_003DqO_UWZnAvMx7jCHnL2bCwnCM0Ey_0024DWAxUQjBsOMZyHQo_003D(_0023_003Dq1gan0ArtZuLtMof7coCIiQ_003D_003D)).Split(new char[1] { '\n' })
			select _0023_003DqM81BNO6XtaqLhiXluBZavA_003D_003D.Trim())
		{
			string[] array = item.Split(new char[1] { ':' });
			if (array.Length == 2)
			{
				_0023_003DqLFdGGV5PzHwpjituX5kp6w_003D_003D[array[0]] = array[1];
			}
		}
	}

	internal static int _0023_003DqL06LkT_002414LqdXuKkPdsRsB4IFNpqR7UNnTkW4qzJX90yiTLOuvHNy9K3YHFlOYgV(ref _0023_003DqtlDhosyhYYq5a0seIyFJRCuRKw_xSLPYnVs1DYjqwnY_003D _0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D)
	{
		int num = 12;
		return _0023_003Dq6DlwdOFMzXqPRJYEkxLClw_003D_003D._0023_003DqTXLSNXise7WGPCZ_0024VryWQg_003D_003D._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(num * 2 / 5, num * 4 / 5);
	}
}
