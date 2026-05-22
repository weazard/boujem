using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;

public sealed class Puzzle : ContentType<Puzzle>
{
	private sealed class _0023_003Dq_0024lUoJvE9haBX4MEfCEJkjsETfA1WK6ghrDz9K1doPyw_003D
	{
		public List<SignalColor> _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D;

		internal SignalColor _0023_003Dq_0024MOB5G_0024K5qW6PKgiRQAXTw_003D_003D(int _0023_003DqEE04qCJvGJ_sHw3PK7pmkA_003D_003D, ReliableRandom _0023_003DqkOy5sPGXu8b9hlDkYTA_mg_003D_003D)
		{
			return _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqEE04qCJvGJ_sHw3PK7pmkA_003D_003D];
		}

		internal SignalColor _0023_003DqDf8iZNqR7pw7jzagKYC9LA_003D_003D(int _0023_003Dqh4OQ3wnJv2cBCw44U0jOBw_003D_003D)
		{
			return _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dqh4OQ3wnJv2cBCw44U0jOBw_003D_003D];
		}

		internal bool _0023_003DqLVUYV7kKA5zE4X_00242noZiCQ_003D_003D(int _0023_003DqTM6KKNigu1Cn5KeWBAJWTw_003D_003D)
		{
			return _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqTM6KKNigu1Cn5KeWBAJWTw_003D_003D] == SignalColor.Yellow;
		}

		internal bool _0023_003DqXzZH6Xrsccq7lwrb5zCAkw_003D_003D(int _0023_003Dqlk44C4dCNpTQu2jhjIJOzg_003D_003D)
		{
			if (_0023_003Dqlk44C4dCNpTQu2jhjIJOzg_003D_003D > 0 && _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dqlk44C4dCNpTQu2jhjIJOzg_003D_003D] == SignalColor.Yellow)
			{
				return _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dqlk44C4dCNpTQu2jhjIJOzg_003D_003D - 1] == SignalColor.Yellow;
			}
			return false;
		}

		internal bool _0023_003DqO9U_0024KyD08gZIWkXgXhVWVw_003D_003D(int _0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D)
		{
			if (_0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D > 1 && _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D] == SignalColor.Yellow && _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D - 1] == SignalColor.Yellow)
			{
				return _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D - 2] == SignalColor.Yellow;
			}
			return false;
		}

		internal bool _0023_003DqdM4p1mLoJmkRlxoYJ9soww_003D_003D(int _0023_003DqAwc9pkGHJXWScOkTG6IGlw_003D_003D)
		{
			return _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqAwc9pkGHJXWScOkTG6IGlw_003D_003D] == SignalColor.Red;
		}

		internal bool _0023_003DqvpbFAr1AJbCSUdW4RSHdaw_003D_003D(int _0023_003DqfU_M8PuvyVKaC1m1Sq9T1g_003D_003D)
		{
			if (_0023_003DqfU_M8PuvyVKaC1m1Sq9T1g_003D_003D > 0 && _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqfU_M8PuvyVKaC1m1Sq9T1g_003D_003D] == SignalColor.Red)
			{
				return _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqfU_M8PuvyVKaC1m1Sq9T1g_003D_003D - 1] == SignalColor.Red;
			}
			return false;
		}

		internal bool _0023_003DqGcdgfRVDXM5qE_00244IYBS8ug_003D_003D(int _0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D)
		{
			if (_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D > 1 && _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D] == SignalColor.Red && _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D - 1] == SignalColor.Red)
			{
				return _0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D - 2] == SignalColor.Red;
			}
			return false;
		}
	}

	private sealed class _0023_003Dq1wZlSQGY8Lre1K0jr9CGEaI_WFExitTi68NBQJdg00E_003D
	{
		public List<SignalColor> _0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D;

		internal bool _0023_003DqXuG971b6dtAg9MZ9I6v_uQmKkROGeW_1cWIFtLRHYqyVFHXKu78xB_0024P_0024cpZJxZnT(SignalColor _0023_003DqqVKLgrH7NWh_KXwZZYg8aQ_003D_003D)
		{
			return _0023_003DqqVKLgrH7NWh_KXwZZYg8aQ_003D_003D == _0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D[0];
		}
	}

	private sealed class _0023_003DqaVBWQ1MdfGPGI_0024XyU_409uP4Gx9MFhmKeFfsY25jYNM_003D
	{
		public List<int> _0023_003DqT5hH5foLZyiO_udCQ3aeeA_003D_003D;

		internal SignalColor _0023_003DqR5ltZ59fLvi8Fpg2PeyjsNOY9n2dHitRfTh2jQasEwg_003D(int _0023_003DqC8VJrGGXDORYbTxcQoY3eQ_003D_003D, ReliableRandom _0023_003Dqmla_0024J2bJpTyiXA6bxa2D_Q_003D_003D)
		{
			if (_0023_003DqT5hH5foLZyiO_udCQ3aeeA_003D_003D[_0023_003DqC8VJrGGXDORYbTxcQoY3eQ_003D_003D] != 1)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqVbaJV31t5_IAm8pOqT3567Sd7gr_7c4Q7LfZA6U1wp8_003D(int _0023_003Dq8v9_0024Jxmwjc7YOuQSb69_0024oA_003D_003D, ReliableRandom _0023_003DqcgfStxMwbT0ilCTzgRpgOA_003D_003D)
		{
			if (_0023_003DqT5hH5foLZyiO_udCQ3aeeA_003D_003D[_0023_003Dq8v9_0024Jxmwjc7YOuQSb69_0024oA_003D_003D] != 2)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqnotKeOKcwCAnpTKK_Pyh0_0024WvT8HHyfE3YYnchhGgRaw_003D(int _0023_003DqbwEu4mSNLtzEzSWWvchaGA_003D_003D)
		{
			if (_0023_003DqT5hH5foLZyiO_udCQ3aeeA_003D_003D[_0023_003DqbwEu4mSNLtzEzSWWvchaGA_003D_003D] == 0)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}
	}

	private sealed class _0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D
	{
		public List<int> _0023_003DqEyAHny9GBgCclArrUAVIBA_003D_003D;

		public List<bool> _0023_003DqD0nxVBjf4tbnuUWEQGrfrw_003D_003D;

		public List<bool> _0023_003DqF6aETNuauk1FUEnWlI3hmw_003D_003D;

		internal void _0023_003DqY_gpkek_0024i0M5gGM8u3XkP5QQR0pukntqnvuQHNmGZFU_003D(int _0023_003DqsIX157Y5AIdfS6PwCTgGAw_003D_003D, int _0023_003Dqp_G_8RJAsqGverLepypF8w_003D_003D)
		{
			for (int i = 0; i < _0023_003Dqp_G_8RJAsqGverLepypF8w_003D_003D; i++)
			{
				_0023_003DqEyAHny9GBgCclArrUAVIBA_003D_003D.Add(_0023_003DqsIX157Y5AIdfS6PwCTgGAw_003D_003D);
				switch (_0023_003DqsIX157Y5AIdfS6PwCTgGAw_003D_003D)
				{
				case 0:
					_0023_003DqD0nxVBjf4tbnuUWEQGrfrw_003D_003D.Add(item: false);
					_0023_003DqF6aETNuauk1FUEnWlI3hmw_003D_003D.Add(item: false);
					break;
				case 1:
					_0023_003DqD0nxVBjf4tbnuUWEQGrfrw_003D_003D.Add(i % 2 < 1);
					_0023_003DqF6aETNuauk1FUEnWlI3hmw_003D_003D.Add(!_0023_003DqD0nxVBjf4tbnuUWEQGrfrw_003D_003D.Last());
					break;
				case 2:
					_0023_003DqD0nxVBjf4tbnuUWEQGrfrw_003D_003D.Add(i % 4 < 2);
					_0023_003DqF6aETNuauk1FUEnWlI3hmw_003D_003D.Add(!_0023_003DqD0nxVBjf4tbnuUWEQGrfrw_003D_003D.Last());
					break;
				}
			}
		}

		internal bool _0023_003DqabWFopD8nGvk83_42qcuRg_003D_003D(int _0023_003Dqqfi39ZChw2vg6kIWDjK3AA_003D_003D, ReliableRandom _0023_003DqqkMk6BPqPAAjIS5zJ8f83Q_003D_003D)
		{
			return _0023_003DqEyAHny9GBgCclArrUAVIBA_003D_003D[_0023_003Dqqfi39ZChw2vg6kIWDjK3AA_003D_003D] == 1;
		}

		internal bool _0023_003DqzSIyiPmczFt15DLF1SWQcQ_003D_003D(int _0023_003DqC8VJrGGXDORYbTxcQoY3eQ_003D_003D, ReliableRandom _0023_003DqkcQpMFuttBfC9_0024VHlzkq6Q_003D_003D)
		{
			return _0023_003DqEyAHny9GBgCclArrUAVIBA_003D_003D[_0023_003DqC8VJrGGXDORYbTxcQoY3eQ_003D_003D] == 2;
		}

		internal SignalColor _0023_003Dqkq0MKvBxYQsPRBhkA4gYDg_003D_003D(int _0023_003DqnFsLovcCsReGliTXNI_0024PaA_003D_003D)
		{
			if (!_0023_003DqD0nxVBjf4tbnuUWEQGrfrw_003D_003D[_0023_003DqnFsLovcCsReGliTXNI_0024PaA_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqAHcK4cPC8SGk9qY_wrWbrw_003D_003D(int _0023_003DqHs_Kp1Ckz1xr_ck9gG5GwA_003D_003D)
		{
			if (!_0023_003DqF6aETNuauk1FUEnWlI3hmw_003D_003D[_0023_003DqHs_Kp1Ckz1xr_ck9gG5GwA_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}
	}

	private sealed class _0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D
	{
		public List<SignalColor> _0023_003DqkHFWX_0024vfpomhMidem4r7Rw_003D_003D;

		internal SignalColor _0023_003Dq3XucFrIhqTh1qnrDsaSLJw_003D_003D(int _0023_003DqbYs_0024SyjwlV6e8STl9u5_0024bQ_003D_003D)
		{
			return _0023_003DqkHFWX_0024vfpomhMidem4r7Rw_003D_003D[_0023_003DqbYs_0024SyjwlV6e8STl9u5_0024bQ_003D_003D];
		}
	}

	private sealed class _0023_003DqEMX30hlpGUHtSAjI_00249zLCEXZa6C2rB6k6Ghz_ialKus_003D
	{
		public SignalColor[] _0023_003Dq_EiDn0GJK_0024Gwzv4SrGjk9g_003D_003D;

		public SignalColor[] _0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D;

		internal SignalColor _0023_003Dqcivs3wnEA4vd2O3VdptGWA_003D_003D(int _0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D)
		{
			return _0023_003Dq_EiDn0GJK_0024Gwzv4SrGjk9g_003D_003D[_0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D];
		}

		internal SignalColor _0023_003DqwGHdz3jg3_0024HJVKxjWRjKAw_003D_003D(int _0023_003DqF2nYr5pxx03B0NNzHBQk9A_003D_003D)
		{
			return _0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D[_0023_003DqF2nYr5pxx03B0NNzHBQk9A_003D_003D];
		}

		internal bool _0023_003DqsLos5_8VAEur45AJ50PFLg_003D_003D(int _0023_003DqBZt9vK2MwmphkNwcOcCqFw_003D_003D)
		{
			if (_0023_003Dq_EiDn0GJK_0024Gwzv4SrGjk9g_003D_003D[_0023_003DqBZt9vK2MwmphkNwcOcCqFw_003D_003D] == SignalColor.Green)
			{
				return _0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D[_0023_003DqBZt9vK2MwmphkNwcOcCqFw_003D_003D] == SignalColor.None;
			}
			return false;
		}

		internal bool _0023_003DqMNw_0024Ys8kWKpbyeofYu84Fw_003D_003D(int _0023_003Dq_BaM5wn4H2rLBTbqWQKw3A_003D_003D)
		{
			if (_0023_003Dq_EiDn0GJK_0024Gwzv4SrGjk9g_003D_003D[_0023_003Dq_BaM5wn4H2rLBTbqWQKw3A_003D_003D] == SignalColor.None)
			{
				return _0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D[_0023_003Dq_BaM5wn4H2rLBTbqWQKw3A_003D_003D] == SignalColor.Red;
			}
			return false;
		}

		internal bool _0023_003DqSVLPUVgzwWpohoB_00242uU_0024sw_003D_003D(int _0023_003Dq7tJaI6tWt1kdNOTTiIc5Hg_003D_003D)
		{
			if (_0023_003Dq_EiDn0GJK_0024Gwzv4SrGjk9g_003D_003D[_0023_003Dq7tJaI6tWt1kdNOTTiIc5Hg_003D_003D] == SignalColor.Green)
			{
				return _0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D[_0023_003Dq7tJaI6tWt1kdNOTTiIc5Hg_003D_003D] == SignalColor.Red;
			}
			return false;
		}
	}

	private sealed class _0023_003DqgGM_Vg_hWoUhV9J3HjC_0024iTShqRsxZfV8Tm8enACBX7A_003D
	{
		public List<int> _0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D;

		internal bool _0023_003Dqmi8iT_Ng7fVEwC0jiUH33g_003D_003D(int _0023_003Dqqfi39ZChw2vg6kIWDjK3AA_003D_003D, ReliableRandom _0023_003DqU9goiX4rLWVF14KHrJdA_0024w_003D_003D)
		{
			return _0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D[_0023_003Dqqfi39ZChw2vg6kIWDjK3AA_003D_003D] > 0;
		}

		internal SignalColor _0023_003Dq00Ih_ZWWaFnNie7Vf7Dcfw_003D_003D(int _0023_003DqQx0GHTxuBvocMCaeJChTbA_003D_003D)
		{
			if (_0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D[_0023_003DqQx0GHTxuBvocMCaeJChTbA_003D_003D] != 1)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003Dqpge0pLP8qkZYb09jfSHnCw_003D_003D(int _0023_003DqCBZl07j72CjTgK1mVy_fnA_003D_003D)
		{
			if (_0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D[_0023_003DqCBZl07j72CjTgK1mVy_fnA_003D_003D] != 2)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqGqewZ5IBKg1LNlrWSHXwmA_003D_003D(int _0023_003Dq4Y4sK5jc5sRQQ17iE7XRLw_003D_003D)
		{
			if (_0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D[_0023_003Dq4Y4sK5jc5sRQQ17iE7XRLw_003D_003D] != 3)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqsN82wW_0024MBi_0024ZX5gOQLhJCA_003D_003D(int _0023_003DqxP_gna_bb_g59qFhQkrPOQ_003D_003D)
		{
			if (_0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D[_0023_003DqxP_gna_bb_g59qFhQkrPOQ_003D_003D] != 4)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003Dq2hzS84z1ft2nj8ux3IJEAw_003D_003D(int _0023_003DqGP_hRTfiJS1W6nJoYAl61g_003D_003D)
		{
			if (_0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D[_0023_003DqGP_hRTfiJS1W6nJoYAl61g_003D_003D] != 5)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}
	}

	private sealed class _0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D
	{
		public List<bool> _0023_003DqF3P12g5d2GMdi55TbYqrbw_003D_003D;

		internal SignalColor _0023_003DqpWELsCqbVSUro56Nr2yQwm0VYL5rooSmxTvM_b5B09Q_003D(int _0023_003Dq4UTyZ6AKzMVwQx7ToVpabw_003D_003D, ReliableRandom _0023_003DqqbXgIJf9vCVLi_0024_0024OAUXcIA_003D_003D)
		{
			if (!_0023_003DqF3P12g5d2GMdi55TbYqrbw_003D_003D[_0023_003Dq4UTyZ6AKzMVwQx7ToVpabw_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}
	}

	private sealed class _0023_003DqjackqGwzs_0024LGcF4Jgwor5GN3ASwbD2kO6u8avlnlk7Q_003D
	{
		public bool[] _0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D;

		internal bool _0023_003DqxQhDUyxgE1rpIyII9ThYIQ_003D_003D(int _0023_003DqKe0Q_DiOUST6x1888HdbSA_003D_003D, ReliableRandom _0023_003DqKBgrm20a8HQ4Jqo5flPZaA_003D_003D)
		{
			return _0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[_0023_003DqKe0Q_DiOUST6x1888HdbSA_003D_003D];
		}

		internal SignalColor _0023_003Dq1rvzUh4MWPxQMKiI9hCqqA_003D_003D(int _0023_003DqdFgUVAm5cyMXDtUjdH0Jtw_003D_003D)
		{
			if (!_0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[_0023_003DqdFgUVAm5cyMXDtUjdH0Jtw_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqW18Td21UaDUAVU9OUKzRUw_003D_003D(int _0023_003DqwqyMRTrtkK6q3ApnXpgMxA_003D_003D)
		{
			if (!_0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[_0023_003DqwqyMRTrtkK6q3ApnXpgMxA_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003Dqsk_0024LxJPXG2U4VES3o5aRIA_003D_003D(int _0023_003DqW2_iQ2GRJATWr2h8odURlw_003D_003D)
		{
			if (!_0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[_0023_003DqW2_iQ2GRJATWr2h8odURlw_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003Dq6f180okoddYKPcRH9VbghQ_003D_003D(int _0023_003Dq2nkDLf5zUFyrYcedeQoN0w_003D_003D)
		{
			if (!_0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[_0023_003Dq2nkDLf5zUFyrYcedeQoN0w_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}
	}

	private sealed class _0023_003DqJURZj4Mud24qs96Z7b3bhblS6PuWnQslWSSts_hE2J8_003D
	{
		public List<int> _0023_003DqtaPernHfKBXs_0024yp7nLDCPA_003D_003D;

		internal SignalColor _0023_003DqJgnedqEpjIem_0024YZZODyhDY8_hkTiLkblKMut7HHsEjQ_003D(int _0023_003DqJxog5jlMg84SmDD3EXPGZg_003D_003D, ReliableRandom _0023_003DqbZQIGoV5d3TjsfrT3pLQUw_003D_003D)
		{
			if (_0023_003DqtaPernHfKBXs_0024yp7nLDCPA_003D_003D[_0023_003DqJxog5jlMg84SmDD3EXPGZg_003D_003D] != 1)
			{
				return SignalColor.Green;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqV8rtB7vILLb2NDzEexZN_4gh2CXEkSz_0024rykkpNcGzr8_003D(int _0023_003Dq4euo2bUsshlSQvYv69Ae2g_003D_003D, ReliableRandom _0023_003Dq3QUuC_00247hEGWs7XcmsSYcKw_003D_003D)
		{
			if (_0023_003DqtaPernHfKBXs_0024yp7nLDCPA_003D_003D[_0023_003Dq4euo2bUsshlSQvYv69Ae2g_003D_003D] != 2)
			{
				return SignalColor.Green;
			}
			return SignalColor.Red;
		}
	}

	private sealed class _0023_003DqkdVKtQOcW9dFO2d1vuW4nFDRNKYtqK_1Te6_GvX_26o_003D
	{
		public SignalColor[] _0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D;

		public SignalColor[] _0023_003Dqxp1_0024T7D6QD2FY7yIbAFK8A_003D_003D;

		internal SignalColor _0023_003DqtFNoN1e0zdBxOLjVNhUUfU8Psjhlrq7w_00248609BHDSCc_003D(int _0023_003DqQGGGgDFznbBadFwPtH2jUQ_003D_003D)
		{
			if (_0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D[_0023_003DqQGGGgDFznbBadFwPtH2jUQ_003D_003D] != _0023_003Dqxp1_0024T7D6QD2FY7yIbAFK8A_003D_003D[_0023_003DqQGGGgDFznbBadFwPtH2jUQ_003D_003D])
			{
				return SignalColor.None;
			}
			return _0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D[_0023_003DqQGGGgDFznbBadFwPtH2jUQ_003D_003D];
		}

		internal SignalColor _0023_003DqXONFKwS3rF_eD5gdNbTFJ6Nrw_0024Zu5t8VaNiqT_0024ozeuk_003D(int _0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D)
		{
			if (_0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D[_0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D] != _0023_003Dqxp1_0024T7D6QD2FY7yIbAFK8A_003D_003D[_0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D])
			{
				return SignalColor.None;
			}
			return _0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D[_0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D];
		}
	}

	private sealed class _0023_003DqKFW4YJeQXiVGFHuA426XgkX5dOhr2u8VBG8HK_s3it4_003D
	{
		public SignalColor[] _0023_003DqWZLWcq2HKxBPBYwe7MNBew_003D_003D;

		internal SignalColor _0023_003DqAfkpUSvGO2q3lZ2dTnUweg_003D_003D(int _0023_003DqCjqS7f3mH0j7aABptzXNfA_003D_003D, ReliableRandom _0023_003DqU9goiX4rLWVF14KHrJdA_0024w_003D_003D)
		{
			return _0023_003DqWZLWcq2HKxBPBYwe7MNBew_003D_003D[_0023_003DqCjqS7f3mH0j7aABptzXNfA_003D_003D];
		}

		internal SignalColor _0023_003DqtDul5bV6b8hQ5HT_oyqyoA_003D_003D(int _0023_003DqpnkpYmvgNGkm6Icp8LGD2A_003D_003D)
		{
			if (_0023_003DqWZLWcq2HKxBPBYwe7MNBew_003D_003D[_0023_003DqpnkpYmvgNGkm6Icp8LGD2A_003D_003D] != SignalColor.None)
			{
				return SignalColor.Green;
			}
			return SignalColor.None;
		}

		internal SignalColor _0023_003Dqo0qLq4ghBA7YzeNeK1mtWw_003D_003D(int _0023_003DqFaAj6k9S3eBhgGxKkHUYYQ_003D_003D)
		{
			if (_0023_003DqWZLWcq2HKxBPBYwe7MNBew_003D_003D[_0023_003DqFaAj6k9S3eBhgGxKkHUYYQ_003D_003D] != SignalColor.None)
			{
				return SignalColor.Red;
			}
			return SignalColor.None;
		}
	}

	private sealed class _0023_003DqmB72mIDDyySP5Crp6Y_DxSjQNzRuzUO5po_0024uP3EQCa0_003D
	{
		public SignalColor[] _0023_003Dq8orPLkACGdWXKCLe3MeRbQ_003D_003D;

		public ReliableRandom _0023_003Dq21cQ0TvmuA6NO0Vsg_C_0024VA_003D_003D;

		public SignalColor[] _0023_003Dqefe95ST4hWq8DCSEW7iX8g_003D_003D;

		public SignalColor[] _0023_003Dqe7qc0_00242DFjFD6Ze6l0L9AA_003D_003D;

		public SignalColor[] _0023_003DqbBRYci64V36SFA_NI1YkIw_003D_003D;

		public SignalColor[] _0023_003DqheNbq_0024_0024nlantY5XWpfe6MA_003D_003D;

		internal void _0023_003DqZEOXbDo6t5TGlKJfAlJ8pUFq9y5tr1XWsmkLPSbWsKY_003D(int _0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D)
		{
			_0023_003Dq8orPLkACGdWXKCLe3MeRbQ_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D] = _0023_003Dq21cQ0TvmuA6NO0Vsg_C_0024VA_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
			{
				SignalColor.Yellow,
				SignalColor.Green,
				SignalColor.Red
			});
			_0023_003Dqefe95ST4hWq8DCSEW7iX8g_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D] = _0023_003Dq21cQ0TvmuA6NO0Vsg_C_0024VA_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
			{
				SignalColor.Yellow,
				SignalColor.Green,
				SignalColor.Red
			});
			_0023_003Dqe7qc0_00242DFjFD6Ze6l0L9AA_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D] = _0023_003Dq21cQ0TvmuA6NO0Vsg_C_0024VA_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
			{
				SignalColor.Yellow,
				SignalColor.Green,
				SignalColor.Red
			});
			_0023_003DqbBRYci64V36SFA_NI1YkIw_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D] = _0023_003Dq21cQ0TvmuA6NO0Vsg_C_0024VA_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
			{
				SignalColor.Yellow,
				SignalColor.Green,
				SignalColor.Red
			});
			_0023_003DqheNbq_0024_0024nlantY5XWpfe6MA_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D - 3] = _0023_003Dq8orPLkACGdWXKCLe3MeRbQ_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D];
			_0023_003DqheNbq_0024_0024nlantY5XWpfe6MA_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D - 2] = _0023_003Dqefe95ST4hWq8DCSEW7iX8g_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D];
			_0023_003DqheNbq_0024_0024nlantY5XWpfe6MA_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D - 1] = _0023_003Dqe7qc0_00242DFjFD6Ze6l0L9AA_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D];
			_0023_003DqheNbq_0024_0024nlantY5XWpfe6MA_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D] = _0023_003DqbBRYci64V36SFA_NI1YkIw_003D_003D[_0023_003DqjcwsaJ0ldZWISnC8qjQjfw_003D_003D];
		}

		internal SignalColor _0023_003DqaxxOTYp73ZF2olAL_0024S2ZQQFbYBtbBLL2vuRZRab0Aoo_003D(int _0023_003DqyfG_00244LeHFYjaA1s4EP_00249EQ_003D_003D, ReliableRandom _0023_003DqWyHhFLoxuRChkM7MaH77Nw_003D_003D)
		{
			return _0023_003DqheNbq_0024_0024nlantY5XWpfe6MA_003D_003D[_0023_003DqyfG_00244LeHFYjaA1s4EP_00249EQ_003D_003D];
		}

		internal SignalColor _0023_003Dq70vASntFuDpRXa3HtvzukVdJZjrGAyQhbt4qJAQyKDc_003D(int _0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D)
		{
			return _0023_003Dq8orPLkACGdWXKCLe3MeRbQ_003D_003D[_0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D];
		}

		internal SignalColor _0023_003DqY8VDyIXoKncqPO8dTDq7nm60bJq0aCujk_0024G6U12WTwM_003D(int _0023_003Dqtwid9TTv1HWste3gB9yG6w_003D_003D)
		{
			return _0023_003Dqefe95ST4hWq8DCSEW7iX8g_003D_003D[_0023_003Dqtwid9TTv1HWste3gB9yG6w_003D_003D];
		}

		internal SignalColor _0023_003Dq78sY0vSKqPifcomScseUFc_0024XLgMotEMvnwZ0BMPPlQY_003D(int _0023_003Dq8upB7gb726iaUnkyq8SX7A_003D_003D)
		{
			return _0023_003Dqe7qc0_00242DFjFD6Ze6l0L9AA_003D_003D[_0023_003Dq8upB7gb726iaUnkyq8SX7A_003D_003D];
		}

		internal SignalColor _0023_003DqMT_0024AwXDAdKxi64kn0fnDND_0024qsxPjFzV6eJVomObgq6c_003D(int _0023_003DqWQl2C8y_0024FDvbj55VUPu2cQ_003D_003D)
		{
			return _0023_003DqbBRYci64V36SFA_NI1YkIw_003D_003D[_0023_003DqWQl2C8y_0024FDvbj55VUPu2cQ_003D_003D];
		}
	}

	private sealed class _0023_003Dqmjia69CA_j_0024Pd1hrUKUTcIoH44ApDBoyDC9Nk3R8QYA_003D
	{
		public SignalColor[] _0023_003DqMYnq4SJ8Jv6Q_SZsjCQ_vg_003D_003D;

		internal SignalColor _0023_003DqsEsZvoUtO8uzoMWPLnnybpQ_4RSneTk_pNor9BBSWdc_003D(int _0023_003DqajggHmWXoWEt7sDkingqSQ_003D_003D)
		{
			return _0023_003DqMYnq4SJ8Jv6Q_SZsjCQ_vg_003D_003D[_0023_003DqajggHmWXoWEt7sDkingqSQ_003D_003D];
		}

		internal SignalColor _0023_003DqmXVY5INP8IhBNqLWqayD_V7WVnkF6u9lHkJC_00243gLmv8_003D(int _0023_003DqTBYZb1xmHAQuivPB0CFlpg_003D_003D)
		{
			return _0023_003DqMYnq4SJ8Jv6Q_SZsjCQ_vg_003D_003D[_0023_003DqTBYZb1xmHAQuivPB0CFlpg_003D_003D];
		}
	}

	private sealed class _0023_003DqnOLj54kIvFQ5gu6pzObc5uTRIEgigKJQwLCYEB9yhOw_003D
	{
		public List<bool> _0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D;

		public List<bool> _0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D;

		internal SignalColor _0023_003Dq7CZsj0wWp6ruFBtn66Qg5w_003D_003D(int _0023_003DqWQl2C8y_0024FDvbj55VUPu2cQ_003D_003D, ReliableRandom _0023_003DqN3gJrOcbA1L0yZGXIXB6uQ_003D_003D)
		{
			if (!_0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D[_0023_003DqWQl2C8y_0024FDvbj55VUPu2cQ_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003Dq262AcLfJQmgcZCbtoQcMBA_003D_003D(int _0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D, ReliableRandom _0023_003Dqj96u0NruoOa2HtUD4_lVNw_003D_003D)
		{
			if (!_0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003Dq7L3MYD84OytCC_00243EhUsASQ_003D_003D(int _0023_003DqaAMr2J2V4n2iDQVI5r0R4Q_003D_003D, ReliableRandom _0023_003Dq02g322wX7zW7R4IucY3Mqw_003D_003D)
		{
			if (!_0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D[_0023_003DqaAMr2J2V4n2iDQVI5r0R4Q_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqW12rLVGo76ZTcUglPshMEA_003D_003D(int _0023_003DqlMUfRO5UaUvLjHmcDf6aqQ_003D_003D)
		{
			if (!_0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D[_0023_003DqlMUfRO5UaUvLjHmcDf6aqQ_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003Dq_0024td076yGZEEaf_0024R8FGIhRg_003D_003D(int _0023_003DqVr3sv4BIgj_002461e1yfqQN7w_003D_003D)
		{
			if (!_0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D[_0023_003DqVr3sv4BIgj_002461e1yfqQN7w_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003Dqe_00240aXdhHvmJeSL1xSPnT4w_003D_003D(int _0023_003DqAFVcb4hqOYycGLNShFeQjQ_003D_003D)
		{
			if (!_0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D[_0023_003DqAFVcb4hqOYycGLNShFeQjQ_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}
	}

	private sealed class _0023_003DqO1D_HIFavNlITu1dnrMTel4L9L9Wn8cXias_00248T_0558_003D
	{
		public SignalColor[] _0023_003Dq8keU4Hm1v2_5LuPoqVU9dQ_003D_003D;

		internal SignalColor _0023_003Dqnu_0024ihUge2HwI4DU0XFCmTw_003D_003D(int _0023_003DqYiU70PIwQuLNnfzhyiqixw_003D_003D)
		{
			return _0023_003Dq8keU4Hm1v2_5LuPoqVU9dQ_003D_003D[_0023_003DqYiU70PIwQuLNnfzhyiqixw_003D_003D];
		}

		internal SignalColor _0023_003Dqf0EtDn_0024yqRmqr3GyvfRESA_003D_003D(int _0023_003DqZy9kA_nj704QOua_uHv3_0024w_003D_003D)
		{
			return _0023_003Dq8keU4Hm1v2_5LuPoqVU9dQ_003D_003D[_0023_003DqZy9kA_nj704QOua_uHv3_0024w_003D_003D];
		}

		internal SignalColor _0023_003Dqrdq_frAbu3XhCOc26VzA8A_003D_003D(int _0023_003DqnyPJpGRqPpBkGS_0024RKSFWCw_003D_003D)
		{
			return _0023_003Dq8keU4Hm1v2_5LuPoqVU9dQ_003D_003D[_0023_003DqnyPJpGRqPpBkGS_0024RKSFWCw_003D_003D];
		}
	}

	private sealed class _0023_003DqO7DBHPxlb2VaMX6jo1Zbj2E0eV0beiL_0024OBFenCD_kOY_003D
	{
		public SignalColor[] _0023_003DqhL3djUUnD9jm8hOgZ7Nx_A_003D_003D;

		public SignalColor[] _0023_003Dq5aqblyy4Yei5tlFSI6E6hw_003D_003D;

		internal SignalColor _0023_003DqFRFwYRzr3PMdj_vMp32YtA_003D_003D(int _0023_003DqBZt9vK2MwmphkNwcOcCqFw_003D_003D)
		{
			if (_0023_003DqhL3djUUnD9jm8hOgZ7Nx_A_003D_003D[_0023_003DqBZt9vK2MwmphkNwcOcCqFw_003D_003D] != SignalColor.Green)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqFgpMu2Scm2r6KUdfHB70tg_003D_003D(int _0023_003DqoxqFQ2lpUQ6inVkWiI3_bg_003D_003D)
		{
			if (_0023_003Dq5aqblyy4Yei5tlFSI6E6hw_003D_003D[_0023_003DqoxqFQ2lpUQ6inVkWiI3_bg_003D_003D] != SignalColor.Red)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}
	}

	private sealed class _0023_003DqRcRzK_Ltz_0024ZfePIrJMKfkM_JAW1YkwCsHzFkyM1E5VM_003D
	{
		public List<SignalColor> _0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D;

		internal SignalColor _0023_003DqG4bMc5FgZ3hBl9_nKzOFpA_003D_003D(int _0023_003DqU32mTW1fxvW8JgjxGzh7DA_003D_003D)
		{
			return _0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D[_0023_003DqU32mTW1fxvW8JgjxGzh7DA_003D_003D];
		}

		internal bool _0023_003DqUF8Z7MsSXKJx3KunoDRPfA_003D_003D(int _0023_003DqeyNJW6m9_imkSJVl1eT5pw_003D_003D, ReliableRandom _0023_003DqztCGKEEOD4PK_00246nnCIxH0A_003D_003D)
		{
			return _0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D[_0023_003DqeyNJW6m9_imkSJVl1eT5pw_003D_003D] == SignalColor.Green;
		}

		internal bool _0023_003DqLLZMWB4TBcPgKG0_HiPvkA_003D_003D(int _0023_003Dqivb3QrgtdQItUZ34Fkq7AQ_003D_003D, ReliableRandom _0023_003Dq_0024dX6ekmSPUVigfgdSi_BTQ_003D_003D)
		{
			return _0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D[_0023_003Dqivb3QrgtdQItUZ34Fkq7AQ_003D_003D] == SignalColor.Red;
		}

		internal bool _0023_003DqNi_73_00248zQbZbbTHqbBHAYQ_003D_003D(int _0023_003DqAMaEhV7Unll3znZlYshpUw_003D_003D, ReliableRandom _0023_003DqaUJSHfhUWWsSWsCrlztiUA_003D_003D)
		{
			return _0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D[_0023_003DqAMaEhV7Unll3znZlYshpUw_003D_003D] == SignalColor.Yellow;
		}
	}

	private sealed class _0023_003DqrFQUDmm5E1tmh4bYAPmiQCN5slZv1RYo_5bTznL3E8E_003D
	{
		public List<bool> _0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D;

		internal SignalColor _0023_003DqUZkoUrR8gLxYVoIhu2D_IqicCqM8xhW_0024bhXjazJgggA_003D(int _0023_003DqeAxKc4r3MB3Z7DBne2TW3A_003D_003D, ReliableRandom _0023_003Dqc3eJ5XW3kg8CXvyNAu1Mhg_003D_003D)
		{
			if (_0023_003DqeAxKc4r3MB3Z7DBne2TW3A_003D_003D >= 31 || !_0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D[_0023_003DqeAxKc4r3MB3Z7DBne2TW3A_003D_003D + 1])
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqBDlCzYjEAiazTqw9KpVpb1CMZuPu542n0lIlpkD5sGo_003D(int _0023_003DqeBN0zpxUaaGlBCRASAXlAA_003D_003D, ReliableRandom _0023_003DqjmB2ZzwI3By2MOF_0024CN2hJw_003D_003D)
		{
			if (_0023_003DqeBN0zpxUaaGlBCRASAXlAA_003D_003D <= 0 || !_0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D[_0023_003DqeBN0zpxUaaGlBCRASAXlAA_003D_003D - 1])
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqB_YR8aZn4c7jOGnybnWCuwLID3LAEcTHqBBxvzwnxro_003D(int _0023_003DqwPEuS1OzujZFl7YiDlQmdw_003D_003D)
		{
			if (!_0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D[_0023_003DqwPEuS1OzujZFl7YiDlQmdw_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}
	}

	private sealed class _0023_003DqtcpgeltJl5vc87FNABhhQwWBWUSmpTfcKsauZm_0024asm0_003D
	{
		public bool[] _0023_003DqNoW_0024wQ0LRB_0024D6KGP3btgYw_003D_003D;

		internal SignalColor _0023_003DqK_0024OoNK9YOh65hyD50OXudg_003D_003D(int _0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D)
		{
			if (!_0023_003DqNoW_0024wQ0LRB_0024D6KGP3btgYw_003D_003D[_0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D])
			{
				return SignalColor.Green;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003Dq1Sb9MDh6_kpAuwosOI4DCA_003D_003D(int _0023_003Dqtwid9TTv1HWste3gB9yG6w_003D_003D)
		{
			if (!_0023_003DqNoW_0024wQ0LRB_0024D6KGP3btgYw_003D_003D[_0023_003Dqtwid9TTv1HWste3gB9yG6w_003D_003D])
			{
				return SignalColor.Red;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqrDx8vZeMPANs_J1kq2wMNg_003D_003D(int _0023_003DqaGzwSRwHICO7rLbHGGPkrg_003D_003D)
		{
			if (!_0023_003DqNoW_0024wQ0LRB_0024D6KGP3btgYw_003D_003D[_0023_003DqaGzwSRwHICO7rLbHGGPkrg_003D_003D])
			{
				return SignalColor.Yellow;
			}
			return SignalColor.Red;
		}
	}

	private sealed class _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D
	{
		public List<bool> _0023_003DqSvEIokZNii5YK58i1lWCUg_003D_003D;

		public List<bool> _0023_003DqCbPRVJ2zOuxFMEb1U9xcbw_003D_003D;

		internal bool _0023_003DqKbm2iT75kVG1ZZkOJISHTw_003D_003D(int _0023_003DqHjyMxQEa8G8gbN_0024SSRLJ4g_003D_003D, ReliableRandom _0023_003DqgpVJeAx2ryVWHJ5ui7WUgQ_003D_003D)
		{
			return _0023_003DqSvEIokZNii5YK58i1lWCUg_003D_003D[_0023_003DqHjyMxQEa8G8gbN_0024SSRLJ4g_003D_003D];
		}

		internal bool _0023_003DqWDvr1iSMYZU1LUqoxEzmBg_003D_003D(int _0023_003DqmoPlCqD8qg_4mVP4DZeprg_003D_003D, ReliableRandom _0023_003DqDickjQyzQejROBJMyzsc4w_003D_003D)
		{
			return _0023_003DqCbPRVJ2zOuxFMEb1U9xcbw_003D_003D[_0023_003DqmoPlCqD8qg_4mVP4DZeprg_003D_003D];
		}

		internal SignalColor _0023_003Dqq_wW6P51BZ74cD9rnKGPsg_003D_003D(int _0023_003DqxpHV9UmuFt6w3trGzvS_0024_0024w_003D_003D)
		{
			if (!_0023_003DqSvEIokZNii5YK58i1lWCUg_003D_003D[_0023_003DqxpHV9UmuFt6w3trGzvS_0024_0024w_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqKt_hdrG8SXuMrXFJTR13Eg_003D_003D(int _0023_003Dq6RSirFNuaFVjztTrejAMXQ_003D_003D)
		{
			if (!_0023_003DqCbPRVJ2zOuxFMEb1U9xcbw_003D_003D[_0023_003Dq6RSirFNuaFVjztTrejAMXQ_003D_003D])
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}
	}

	private sealed class _0023_003DqU7Vug_zikS_Qs4WoW3dnFQYT_0024fb44JYRx2F7HuWcOPA_003D
	{
		public List<int> _0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D;

		internal SignalColor _0023_003DqyE8IeeIPN6nxXQQuNP2pPUVPIWRRkSabvOV6vJNVidU_003D(int _0023_003Dq4Y4sK5jc5sRQQ17iE7XRLw_003D_003D, ReliableRandom _0023_003DqruXYiRyRd0l4oMbMl02RQA_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dq4Y4sK5jc5sRQQ17iE7XRLw_003D_003D] != 0)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003Dq8bIsKr9i33JTv_0024UeGZni9Uo3bBajKkMyuTdjEyHMsMg_003D(int _0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D, ReliableRandom _0023_003DqWyHhFLoxuRChkM7MaH77Nw_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D] != 1)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqbnDE5sSC1Ym6X5AKX7keaZtI6UgdR0FQJm7_0024_C5X2BY_003D(int _0023_003DqHjyMxQEa8G8gbN_0024SSRLJ4g_003D_003D, ReliableRandom _0023_003Dq_gvD2HmF8yFKNDQeMOEKRQ_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqHjyMxQEa8G8gbN_0024SSRLJ4g_003D_003D] != 2)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqjWX6ZWmUM2C_0024w4UsrQW8FIxZfPdGkltNb4eB_30SYOU_003D(int _0023_003DqK7__0024VzLO9ciAtH2wJBXE5w_003D_003D, ReliableRandom _0023_003DqRg7OgiSWc4WLNZuXF7YkAg_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqK7__0024VzLO9ciAtH2wJBXE5w_003D_003D] != 3)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqACKHxX6q1FUKZ5ZLNMAITHkLBYPjhxf0c4vPmGcGJVQ_003D(int _0023_003Dq_zDAlJxNIEa5gzz5nvolKA_003D_003D, ReliableRandom _0023_003DqUIyN_0024_7OrPWSGk6SC_E0lQ_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dq_zDAlJxNIEa5gzz5nvolKA_003D_003D] != 4)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003Dq55Vd0dDj38g6TNHgT9O7HLsCdXkLTxR1HCxqxU7BLJ4_003D(int _0023_003Dqwf5nVdoGhCcFv9VrFYCM4w_003D_003D, ReliableRandom _0023_003DqBdpWGBNZAD7OlKtt3ivikw_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dqwf5nVdoGhCcFv9VrFYCM4w_003D_003D] != 5)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqWfeEGlZWZaoT89uLJmeODTmCFZCvDnNi90sZ5R9xqy4_003D(int _0023_003DqS4szVhy3B0wVQZXH7zfL_w_003D_003D, ReliableRandom _0023_003DqBu0sCTk8uCE79xzl_0024iVWpg_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqS4szVhy3B0wVQZXH7zfL_w_003D_003D] != 6)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqYRalZ0khRuIk_fSFnzrPcIPq6MZBju_0024jsTmiUZM8SkY_003D(int _0023_003DqAwc9pkGHJXWScOkTG6IGlw_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqAwc9pkGHJXWScOkTG6IGlw_003D_003D] != 0)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqWwjT0A9BoPzi3_00249YuSYt_N4BpAMoyLHarXgySWAtQT0_003D(int _0023_003DqOCmhRD27pOG2rKFpZq4gnQ_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqOCmhRD27pOG2rKFpZq4gnQ_003D_003D] != 1)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqtAyPJCF095K9CK1Pnol9RUuPWe1ql_AlzINEXce_HOg_003D(int _0023_003DqQkCx5FSH4Ss5XaYu5bcHdQ_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqQkCx5FSH4Ss5XaYu5bcHdQ_003D_003D] != 2)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqILjXAsQYcUixPSG9_8gDaPBfptkJurs414xTEaCL6KA_003D(int _0023_003Dq1TDDEPuTqiWH4hAE_0024DQ3mg_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dq1TDDEPuTqiWH4hAE_0024DQ3mg_003D_003D] != 3)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqIUOBkn_p55K0EC5ENQajBbYZnIiCxe_0024Cwx5GAqJKN1o_003D(int _0023_003Dqby58Lz1NpiT_Qbak593u0A_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dqby58Lz1NpiT_Qbak593u0A_003D_003D] != 4)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003Dq0Gl_58YenbpvgZgAJWcRQgtNcGUPs_hy0RAKB__eGU0_003D(int _0023_003Dq_kiWAdmglkqEdDzeJ431Bw_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dq_kiWAdmglkqEdDzeJ431Bw_003D_003D] != 5)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqWjVBjPxr9fMsC726cX38uDIz0R3dX0a9_UtoLeUvlxk_003D(int _0023_003DqOb_g87xEXNotiJuyxApFIQ_003D_003D)
		{
			if (_0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqOb_g87xEXNotiJuyxApFIQ_003D_003D] != 6)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}
	}

	private sealed class _0023_003DqvWA0xQR0GGTGHP_y2YOX_0024MwdyxhP8_0024qS7MMfJz0qrwA_003D
	{
		public List<int> _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D;

		internal bool _0023_003DqUwCoYIEvSvVn_5wAFmv2xQ_003D_003D(int _0023_003DqNoNkrSHtH16vURTUd1ZoWA_003D_003D, ReliableRandom _0023_003DqhzPSJoXBL4FEde7K0EEopQ_003D_003D)
		{
			return _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqNoNkrSHtH16vURTUd1ZoWA_003D_003D] == 0;
		}

		internal bool _0023_003DqNcx3Uxu943bP09VlEbEPxQ_003D_003D(int _0023_003DqEUf186ZT0SI80SD7ipOuuw_003D_003D, ReliableRandom _0023_003DqGqHrLIPpzkY7jO6P5MeM4w_003D_003D)
		{
			return _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqEUf186ZT0SI80SD7ipOuuw_003D_003D] == 1;
		}

		internal bool _0023_003DqSAh9pjTAItWCBGDnLDSSbA_003D_003D(int _0023_003Dq_zDAlJxNIEa5gzz5nvolKA_003D_003D, ReliableRandom _0023_003DqbZQIGoV5d3TjsfrT3pLQUw_003D_003D)
		{
			return _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003Dq_zDAlJxNIEa5gzz5nvolKA_003D_003D] == 2;
		}

		internal bool _0023_003DqB5ai8I1GdFuZ_002432ZNBExnw_003D_003D(int _0023_003Dq_S_0024ULoUtIcbdVKZJfjDIZQ_003D_003D, ReliableRandom _0023_003DqGY17IGh2lI_0024cGi6FpA4BTQ_003D_003D)
		{
			return _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003Dq_S_0024ULoUtIcbdVKZJfjDIZQ_003D_003D] == 3;
		}

		internal SignalColor _0023_003DqdvysxFS8k2BVY3Kub1TkWg_003D_003D(int _0023_003DqkRLbT7z_MMwIITIlj_0024I39w_003D_003D)
		{
			if (_0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqkRLbT7z_MMwIITIlj_0024I39w_003D_003D] != 0 || (_0023_003DqkRLbT7z_MMwIITIlj_0024I39w_003D_003D != 0 && _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqkRLbT7z_MMwIITIlj_0024I39w_003D_003D - 1] == 0))
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqGjxoJ1xLlhhf8AXOKMm8Qg_003D_003D(int _0023_003DqUgPFO_0024_7vuVbPFNavUB69w_003D_003D)
		{
			if (_0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqUgPFO_0024_7vuVbPFNavUB69w_003D_003D] != 1 || (_0023_003DqUgPFO_0024_7vuVbPFNavUB69w_003D_003D != 0 && _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqUgPFO_0024_7vuVbPFNavUB69w_003D_003D - 1] == 1))
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqVAAh5dpjCXWfx7eKRdhVTg_003D_003D(int _0023_003DqcSuL6hC7v47_0024s_0024ftoFjZZg_003D_003D)
		{
			if (_0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqcSuL6hC7v47_0024s_0024ftoFjZZg_003D_003D] != 2 || (_0023_003DqcSuL6hC7v47_0024s_0024ftoFjZZg_003D_003D != 0 && _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqcSuL6hC7v47_0024s_0024ftoFjZZg_003D_003D - 1] == 2))
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003Dqk37aqo3dgYfO_0024rWU5bp_uQ_003D_003D(int _0023_003DqWAtapvC4dY6x8kWcORSpAQ_003D_003D)
		{
			if (_0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqWAtapvC4dY6x8kWcORSpAQ_003D_003D] != 3 || (_0023_003DqWAtapvC4dY6x8kWcORSpAQ_003D_003D != 0 && _0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqWAtapvC4dY6x8kWcORSpAQ_003D_003D - 1] == 3))
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}
	}

	private sealed class _0023_003DqW8Ya_3slUaCuu22so_vqbbfB0aCoLABLpW9LDdf4Jfk_003D
	{
		public SignalColor[] _0023_003DqtFolNnVazIY_OCBOJk13Pw_003D_003D;

		public SignalColor[] _0023_003DqAE9tP6JSuh_0024WDkQ0sfXTAQ_003D_003D;

		public SignalColor[] _0023_003DqnS66Wbf7eYVc2tNN_0024ehwXw_003D_003D;

		internal SignalColor _0023_003DqAeespvjEM_0024dSS_NxhhPH5teLrH03JLBizYmpQ8U1PQ4_003D(int _0023_003DqF2nYr5pxx03B0NNzHBQk9A_003D_003D)
		{
			return _0023_003DqtFolNnVazIY_OCBOJk13Pw_003D_003D[_0023_003DqF2nYr5pxx03B0NNzHBQk9A_003D_003D];
		}

		internal SignalColor _0023_003DqLbXu1BnVaoEjFC6k4lcqFUWIrHE9ADIhzsesCzq86_0024k_003D(int _0023_003Dqc4JhZ06fEBAQ092lya_2Rw_003D_003D)
		{
			return _0023_003DqAE9tP6JSuh_0024WDkQ0sfXTAQ_003D_003D[_0023_003Dqc4JhZ06fEBAQ092lya_2Rw_003D_003D];
		}

		internal SignalColor _0023_003DqqyPMxbkq2laiXfqOatv0tUoWF_WI942ihxYQDAAF2UI_003D(int _0023_003Dqpha_6rrBGUS1x2JhKcxhwA_003D_003D)
		{
			return _0023_003DqnS66Wbf7eYVc2tNN_0024ehwXw_003D_003D[_0023_003Dqpha_6rrBGUS1x2JhKcxhwA_003D_003D];
		}
	}

	private sealed class _0023_003DqW8Ya_3slUaCuu22so_vqbexnejOCv5vtx_0024lxj5b4pOA_003D
	{
		public SignalColor[] _0023_003DqjPhOaUqbREZZkH7JeYj2OA_003D_003D;

		internal SignalColor _0023_003Dq24Fc6W7AEHINLBrWHt_0024RGg_003D_003D(int _0023_003DqYFZA7TXOlOOcby7M3mldcQ_003D_003D)
		{
			if (_0023_003DqjPhOaUqbREZZkH7JeYj2OA_003D_003D[_0023_003DqYFZA7TXOlOOcby7M3mldcQ_003D_003D] != SignalColor.None)
			{
				return SignalColor.Green;
			}
			return SignalColor.None;
		}
	}

	private sealed class _0023_003DqwS7d6x_ayPuI0sJ_pDysjBSV0H6ueak4fyUPQWg_00243lU_003D
	{
		public List<int> _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D;

		internal bool _0023_003Dq_0024NZE_0024q_00249dJuOnA98HTUECQ_003D_003D(int _0023_003DqH52m6nGA0NZKlZCp_0024kI_0024_g_003D_003D, ReliableRandom _0023_003Dqhg_0024vZqgprAb0XZa9vyOaMg_003D_003D)
		{
			return _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqH52m6nGA0NZKlZCp_0024kI_0024_g_003D_003D] == 0;
		}

		internal bool _0023_003DqMNs8QUFbwdy6GZhnmXn8tg_003D_003D(int _0023_003DqT0l2JSoRQuLH7fYtWQF_iQ_003D_003D, ReliableRandom _0023_003DqU4lP2ndX5qdZn6ZqPJcpRQ_003D_003D)
		{
			return _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqT0l2JSoRQuLH7fYtWQF_iQ_003D_003D] == 1;
		}

		internal bool _0023_003DqwJwKKWCMw9_q748Vd5t_0024PA_003D_003D(int _0023_003Dqby58Lz1NpiT_Qbak593u0A_003D_003D, ReliableRandom _0023_003DqYVEu2QKPg_0024xU0_Tb0QYrog_003D_003D)
		{
			return _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqby58Lz1NpiT_Qbak593u0A_003D_003D] == 2;
		}

		internal bool _0023_003DqN2vpqz7ZqH_0024BY06J8FTYig_003D_003D(int _0023_003Dqra4K7JMN5gQNdSwhGT_0024lfA_003D_003D, ReliableRandom _0023_003DqqHLAafqsYCCTHW1Z2MvKEQ_003D_003D)
		{
			return _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqra4K7JMN5gQNdSwhGT_0024lfA_003D_003D] == 3;
		}

		internal bool _0023_003Dq53VOd52IWyF9YvaP87sNHQ_003D_003D(int _0023_003DqFMcgwPpbU4ml4QJe8BWzgg_003D_003D, ReliableRandom _0023_003Dqke7shEYza4354_0024JQJkOwjg_003D_003D)
		{
			return _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqFMcgwPpbU4ml4QJe8BWzgg_003D_003D] == 4;
		}

		internal bool _0023_003DqrDGOKbGMCl6O_l3h4MADee6kI_0024m8mcLOsK1zx8Q7uS4_003D(int _0023_003DqEE04qCJvGJ_sHw3PK7pmkA_003D_003D, ReliableRandom _0023_003Dqn_0024da2bODoq6e70MOnxv4JA_003D_003D)
		{
			return _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqEE04qCJvGJ_sHw3PK7pmkA_003D_003D] == 5;
		}

		internal SignalColor _0023_003DqCyInqt5Y7yTqcaMOjQY_0024yIqVP0WiFEBXhg8wBC9WB5U_003D(int _0023_003Dqe50OjJwKupWUwqXKNGo6Xg_003D_003D)
		{
			if (_0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqe50OjJwKupWUwqXKNGo6Xg_003D_003D] != 0 && _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqe50OjJwKupWUwqXKNGo6Xg_003D_003D] != 3 && _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqe50OjJwKupWUwqXKNGo6Xg_003D_003D] != 4)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003Dq_0xc1LeSRgRzUM_DPGgYUYANoqMgirZMseBkXxU7eOg_003D(int _0023_003DqLgrLA7VxpZ5asEp_jmc46Q_003D_003D)
		{
			if (_0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqLgrLA7VxpZ5asEp_jmc46Q_003D_003D] != 1 && _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqLgrLA7VxpZ5asEp_jmc46Q_003D_003D] != 3 && _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqLgrLA7VxpZ5asEp_jmc46Q_003D_003D] != 5)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqZzMDnhMfgFaF_dQRS179BJxNa1ilSRgvKD9Ko_0024_1BWc_003D(int _0023_003DqVHTnorKOxVfSRNMPCZEHgQ_003D_003D)
		{
			if (_0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqVHTnorKOxVfSRNMPCZEHgQ_003D_003D] != 2 && _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqVHTnorKOxVfSRNMPCZEHgQ_003D_003D] != 4 && _0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqVHTnorKOxVfSRNMPCZEHgQ_003D_003D] != 5)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}
	}

	[StructLayout(LayoutKind.Auto)]
	private struct _0023_003DqwXFoYYVv6aQ3i_00242Cgm7TOQhb414JQN9F7TxwKI0zEO8_003D
	{
		public int _0023_003Dqy1I4JiRYl1QkaKP9sE80eA_003D_003D;
	}

	private sealed class _0023_003DqwXFoYYVv6aQ3i_00242Cgm7TOQsYXSuBONyWH9FTxva5Lmw_003D
	{
		public SignalColor[] _0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D;

		public int[] _0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D;

		public SignalColor[] _0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D;

		internal SignalColor _0023_003DqidqjAtgnAhlktAvBN27GVmw5gjjc6AaPtUVaP63Aotk_003D(int _0023_003Dq5SNsMfXSeS9YA3_o7F6_Kw_003D_003D, ReliableRandom _0023_003DqLLtIPdzePVdmEKE8OZEZrw_003D_003D)
		{
			return _0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D[_0023_003Dq5SNsMfXSeS9YA3_o7F6_Kw_003D_003D];
		}

		internal bool _0023_003DqSxFZnAu3seuv0qoIF4lesA8pDwznkw8H462_uzfjEhA_003D(int _0023_003DqOnTt8eq_nQSqlO4L5wvNhA_003D_003D, ReliableRandom _0023_003DqN3gJrOcbA1L0yZGXIXB6uQ_003D_003D)
		{
			return _0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D[_0023_003DqOnTt8eq_nQSqlO4L5wvNhA_003D_003D] == 1;
		}

		internal bool _0023_003DqXPHW4pwngtEV_0AyIqV1QkWjo6RmlK5uQpanuCXPpkw_003D(int _0023_003DqW2_iQ2GRJATWr2h8odURlw_003D_003D, ReliableRandom _0023_003DqW7xDqWbJompJBvnwy3widQ_003D_003D)
		{
			return _0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D[_0023_003DqW2_iQ2GRJATWr2h8odURlw_003D_003D] == 2;
		}

		internal SignalColor _0023_003DqcCiEtuluOWPGYlQIc64YiIiJU_0024xKvdVcOJXCvBabdcE_003D(int _0023_003DqVRpGaMqM2dGT33Ua_01Tsg_003D_003D)
		{
			return _0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D[_0023_003DqVRpGaMqM2dGT33Ua_01Tsg_003D_003D];
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<bool, SignalColor> _003C_003E9__21_0;

		public static Func<bool, SignalColor> _003C_003E9__22_0;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_14;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_15;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_28;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_29;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_30;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_32;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_33;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_39;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_46;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_47;

		public static Func<int, SignalColor> _003C_003E9__25_0;

		public static Func<int, SignalColor> _003C_003E9__25_1;

		public static Func<int, SignalColor> _003C_003E9__25_2;

		public static Func<int, SignalColor> _003C_003E9__25_3;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_56;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_68;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_69;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_74;

		public static Func<int, ReliableRandom, bool> _003C_003E9__25_80;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_84;

		public static Func<int, SignalColor> _003C_003E9__25_4;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_5;

		public static Func<int, ReliableRandom, bool> _003C_003E9__25_6;

		public static Func<int, SignalColor> _003C_003E9__25_7;

		public static Func<int, SignalColor> _003C_003E9__25_8;

		public static Func<int, SignalColor> _003C_003E9__25_9;

		public static Func<int, SignalColor> _003C_003E9__25_10;

		public static Func<int, SignalColor> _003C_003E9__25_11;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_86;

		public static Func<int, SignalColor> _003C_003E9__25_12;

		public static Func<int, SignalColor> _003C_003E9__25_13;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_112;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_113;

		public static Func<int, SignalColor> _003C_003E9__25_118;

		public static Func<int, SignalColor> _003C_003E9__25_119;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_120;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_123;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_124;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_125;

		public static Func<int, SignalColor> _003C_003E9__25_129;

		public static Func<int, SignalColor> _003C_003E9__25_130;

		public static Func<int, SignalColor> _003C_003E9__25_131;

		public static Func<int, SignalColor> _003C_003E9__25_132;

		public static Action<SignalInfo> _003C_003E9__25_147;

		public static Func<int, ReliableRandom, SignalColor> _003C_003E9__25_148;

		public static Func<string, string> _003C_003E9__26_2;

		public static Func<SignalInfo, bool> _003C_003E9__26_0;

		public static Func<SignalInfo, bool> _003C_003E9__26_1;

		internal SignalColor _0023_003Dq2bzJUJZd7uE2h1T6ivUbajC1nmRKrofsSlXG6Z9_ZJQ_003D(bool _0023_003Dqgn02yBU138Mk1XViDd9t1Q_003D_003D)
		{
			if (!_0023_003Dqgn02yBU138Mk1XViDd9t1Q_003D_003D)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqhBSfeufyqtcqdPQZ9AVJRIf6N9mBCQvP4awRNbtmBCw_003D(bool _0023_003DqJhlhzWvk2miiZKL1ArzXWQ_003D_003D)
		{
			if (!_0023_003DqJhlhzWvk2miiZKL1ArzXWQ_003D_003D)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqnHaDJGQy_0024SPf4xh4a5XvN65Ov7iL5NZX_0024imvEynpLM8_003D(int _0023_003DqXymW4Zi2yK7OOvw7fubGLg_003D_003D, ReliableRandom _0023_003Dqo_Sow7hX_0024RofoFvcXOgZZg_003D_003D)
		{
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqMYtCHUDuNcJ2OniFypZxh7cWkQlRs__0024xDGmVdBezROI_003D(int _0023_003DqIZn_0024d9_00240IGHAhllOJR3E3w_003D_003D, ReliableRandom _0023_003DqHDRmTnsqWXO7ZYGpG73uBQ_003D_003D)
		{
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqP5xBOw1HcEavS5iWFlMDa3zvOXuGU3DoSyhkM70lGoE_003D(int _0023_003Dq12OqNYXtTfGTf5izjwZJ9w_003D_003D, ReliableRandom _0023_003DqHazpd6KHjvFGmTJFHwvfmQ_003D_003D)
		{
			if (!_0023_003DqHazpd6KHjvFGmTJFHwvfmQ_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D((_0023_003Dq12OqNYXtTfGTf5izjwZJ9w_003D_003D < 16) ? 0.5f : 0.25f))
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqFqe8_EIvePQr0P5x0czAvLjbVs07aY5PR2rkiDUOp_8_003D(int _0023_003Dqwf5nVdoGhCcFv9VrFYCM4w_003D_003D, ReliableRandom _0023_003DqvNmF_8yUigH_Jy0sRcIkJw_003D_003D)
		{
			if (!_0023_003DqvNmF_8yUigH_Jy0sRcIkJw_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D((_0023_003Dqwf5nVdoGhCcFv9VrFYCM4w_003D_003D < 16) ? 0.35f : 0.25f))
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqGma_lPeV6fEcu4Wq2ZAfbtIYIvoZeSNA_0024mLwloyWJn0_003D(int _0023_003DqwPci61341SFCDKYmFk4pcg_003D_003D, ReliableRandom _0023_003DqOLV6sqVUUXozK9qBaRnr5A_003D_003D)
		{
			if (!_0023_003DqOLV6sqVUUXozK9qBaRnr5A_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D((_0023_003DqwPci61341SFCDKYmFk4pcg_003D_003D < 16) ? 0.35f : 0.25f))
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003Dq4ShQB2LCVsnHXJDd5a6xK7UQOm8xwdN6J_iC_GZFzLo_003D(int _0023_003Dq4cNgsEEBMt35u5ft8FokVw_003D_003D, ReliableRandom _0023_003DqkOy5sPGXu8b9hlDkYTA_mg_003D_003D)
		{
			if (!_0023_003DqkOy5sPGXu8b9hlDkYTA_mg_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.5f) && _0023_003Dq4cNgsEEBMt35u5ft8FokVw_003D_003D >= 2)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqiFJarnJwOaXPS50lueeKCH2JzpwvyBbtjAiKBbEBmfI_003D(int _0023_003Dq_2xoeDks2EP24ByfYqVh_0024g_003D_003D, ReliableRandom _0023_003DqUtxZWj9LEDhr2EjfqNldMw_003D_003D)
		{
			if (!_0023_003DqUtxZWj9LEDhr2EjfqNldMw_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.5f))
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003Dqkzl62O6XfIa3Fkcd_0024ZV_j1UIsDMSoSeezZC9mxRfIeo_003D(int _0023_003Dqf9IethI85Lmtc9Jz_0024NppaQ_003D_003D, ReliableRandom _0023_003DqtDhuJGvPwPk3CWtljBboRQ_003D_003D)
		{
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqXvUcjNYQWVfPBwp9Xumgh6kOa0nDdxoCLMTUi7fEwzs_003D(int _0023_003Dq7tJaI6tWt1kdNOTTiIc5Hg_003D_003D, ReliableRandom _0023_003DqBS4l4qpPDbif56FflNIdsw_003D_003D)
		{
			if (!_0023_003DqBS4l4qpPDbif56FflNIdsw_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.5f))
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003Dqk7nNTlXbWLs7cm6nJgGnhfKtkhhv9r78XW6OAE88dKw_003D(int _0023_003Dqqw_kkP9Bdbaido8N3iarJA_003D_003D, ReliableRandom _0023_003Dqpjm7op3CTi9sF_0024uMZCxCrQ_003D_003D)
		{
			if (!_0023_003Dqpjm7op3CTi9sF_0024uMZCxCrQ_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.5f))
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqEAY2mijr33UW2rXVJ7H_0024XvxnZ5Dd5EJYrd_0024KbOO0KOs_003D(int _0023_003DqbYs_0024SyjwlV6e8STl9u5_0024bQ_003D_003D)
		{
			if (_0023_003DqbYs_0024SyjwlV6e8STl9u5_0024bQ_003D_003D % 2 != 0)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqIKbzc_0024pXE_GNVNbLYq88h8kt8O9efcdUUo0bzAiVflE_003D(int _0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D)
		{
			if (_0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D % 2 != 1)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqgnWgKnNWM_0024EeMW6QQnVyN9awWO5Y3hnZCruzRJM1Fjw_003D(int _0023_003DqeBN0zpxUaaGlBCRASAXlAA_003D_003D)
		{
			if (_0023_003DqeBN0zpxUaaGlBCRASAXlAA_003D_003D % 2 != 1)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqAr7fu_IbPZEI9flyjIF_17KDQL0Foe3KlUfniTzt8Rg_003D(int _0023_003DqzvwaQqxeppgBzm7J3Tj_yA_003D_003D)
		{
			if (_0023_003DqzvwaQqxeppgBzm7J3Tj_yA_003D_003D % 2 != 0)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003Dqo56hoGDlAPqnVn_0024SaSfJIGOJ5mFvCzoGyb4fTmHppKU_003D(int _0023_003DqOkMw6aBn7MZvC5Y3sSEXDQ_003D_003D, ReliableRandom _0023_003DqY2XBw7NSW04_EtErO_0024V2vA_003D_003D)
		{
			if (!_0023_003DqY2XBw7NSW04_EtErO_0024V2vA_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.5f))
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqJjcaRSf3nmbpGPKHxtetE1eg3x0Spp0VBUPTT73gSDY_003D(int _0023_003DqH52m6nGA0NZKlZCp_0024kI_0024_g_003D_003D, ReliableRandom _0023_003Dq1_tVt5tyhy423OqxysaZxQ_003D_003D)
		{
			if (Utility._0023_003DqmDpSVbUIGdNI6cWqJJ_0024w3Q_003D_003D(_0023_003DqH52m6nGA0NZKlZCp_0024kI_0024_g_003D_003D, 16) >= 8)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqWuhPGs38VwaOtR3y76fbOCZb8Qe3s3psAGW5k3r7sGw_003D(int _0023_003Dqvj82ybAA6HJUX25dLBLnaw_003D_003D, ReliableRandom _0023_003Dqhctos9qNVLWbNZppKmdSRw_003D_003D)
		{
			if (Utility._0023_003DqmDpSVbUIGdNI6cWqJJ_0024w3Q_003D_003D(_0023_003Dqvj82ybAA6HJUX25dLBLnaw_003D_003D, 16) >= 8)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqUhWCplZ2TmC5kCJSnloNvidUi0ABob__HZAjilRurg0_003D(int _0023_003DqTjMA_KSnHdtAZCwgYeOL5g_003D_003D, ReliableRandom _0023_003Dqo_Sow7hX_0024RofoFvcXOgZZg_003D_003D)
		{
			return SignalColor.Red;
		}

		internal bool _0023_003DqwNajGwr_G9HY9Ugir2XF0s_Qc04ayYgBuQbYH40QbJM_003D(int _0023_003DqFygxHN_0024l0cErZKo3oorMtg_003D_003D, ReliableRandom _0023_003Dqm0o5xX5cYy9kyl5zLxHm1w_003D_003D)
		{
			return _0023_003Dqm0o5xX5cYy9kyl5zLxHm1w_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.5f);
		}

		internal SignalColor _0023_003Dq_d0_prCqsgrsBhJ9fGEpe4RvduFSbvPzmos5i1ZqHiA_003D(int _0023_003Dqqfi39ZChw2vg6kIWDjK3AA_003D_003D, ReliableRandom _0023_003Dq3l3vBHN7D9RTHlTs_00243Mi4g_003D_003D)
		{
			return _0023_003Dq3l3vBHN7D9RTHlTs_00243Mi4g_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[6]
			{
				SignalColor.None,
				SignalColor.None,
				SignalColor.None,
				SignalColor.Green,
				SignalColor.Red,
				SignalColor.Yellow
			});
		}

		internal SignalColor _0023_003DqgO4_00244hy4kkWn3L3c8IRWkmq6KQsOyr8vYp1wmJhSoqM_003D(int _0023_003Dqwx46I9CKs1TnQcEaROaIkg_003D_003D)
		{
			return (new SignalColor[4]
			{
				SignalColor.Green,
				SignalColor.Red,
				SignalColor.Yellow,
				SignalColor.None
			})[_0023_003Dqwx46I9CKs1TnQcEaROaIkg_003D_003D % 4];
		}

		internal SignalColor _0023_003Dqh4nLwd2ydJwyalXbncGFC709et95yBGEgNfw5l4ACJQ_003D(int _0023_003DqAx3zIbywoUskz_0024RN0dxHlw_003D_003D, ReliableRandom _0023_003DqLrCSCukaSkVEYAiRO5aWzg_003D_003D)
		{
			return SignalColor.Red;
		}

		internal bool _0023_003Dqzen8tpJeOB341uON0zX_l4AKIIE6CDq7oJY1oSm0kak_003D(int _0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D, ReliableRandom _0023_003DqWkY42Jx23U2wL_0024ZfrUGSuQ_003D_003D)
		{
			return _0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D % 6 < 5;
		}

		internal SignalColor _0023_003Dqoq5XRuP14c2U4ZNwQ3IcvvHHA_0024MKWpBE7JhRP1nJPxQ_003D(int _0023_003DqdFgUVAm5cyMXDtUjdH0Jtw_003D_003D)
		{
			if (_0023_003DqdFgUVAm5cyMXDtUjdH0Jtw_003D_003D % 6 != 0 && _0023_003DqdFgUVAm5cyMXDtUjdH0Jtw_003D_003D % 6 != 4)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqoGySo3CMRqTTDJ6uBBgGhKGmSNZYjjcv1DB6MBDp8SI_003D(int _0023_003Dq8v9_0024Jxmwjc7YOuQSb69_0024oA_003D_003D)
		{
			if (_0023_003Dq8v9_0024Jxmwjc7YOuQSb69_0024oA_003D_003D % 6 != 1)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqCUOSEbW2SNESJT83J4Fnuv6cA1jTcPQyMBYvrt5qNws_003D(int _0023_003Dq8upB7gb726iaUnkyq8SX7A_003D_003D)
		{
			return SignalColor.None;
		}

		internal SignalColor _0023_003DqWazQu1WM1T8A7canMVIsoC7rcI0PfyZlyeHDeWYaR_Y_003D(int _0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D)
		{
			if (_0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D % 6 != 2 && _0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D % 6 != 3)
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqCVNgvzuRsJHItkTd75RpePBRY0vf36qypJLcwO55BN4_003D(int _0023_003Dqwqs4FCktDEGmRFdv7hcdFA_003D_003D)
		{
			return SignalColor.None;
		}

		internal SignalColor _0023_003DqTkgkO7iB91QYOXzQZ7cVn8yiJUi_2x91en22761p2Ig_003D(int _0023_003DqQNGYB17dHdOXFWEL99EPFQ_003D_003D, ReliableRandom _0023_003Dqm0o5xX5cYy9kyl5zLxHm1w_003D_003D)
		{
			return _0023_003Dqm0o5xX5cYy9kyl5zLxHm1w_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
			{
				SignalColor.None,
				SignalColor.Green,
				SignalColor.Red
			});
		}

		internal SignalColor _0023_003DqyzNvHLcCutXHFeDbo4UaVh7SDfhvSDaOjgUktovrqRk_003D(int _0023_003DqJxog5jlMg84SmDD3EXPGZg_003D_003D)
		{
			if (_0023_003DqJxog5jlMg84SmDD3EXPGZg_003D_003D % 2 != 0)
			{
				return SignalColor.Red;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqglD8JDcWMwjjt11C72uoshWzNOEImHsrLs1eXGrcaxM_003D(int _0023_003Dqpha_6rrBGUS1x2JhKcxhwA_003D_003D)
		{
			if (_0023_003Dqpha_6rrBGUS1x2JhKcxhwA_003D_003D % 2 != 0)
			{
				return SignalColor.Green;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqE5JY_0024aHDm2XvH4TeVFiCfyFl3fX_0024pBBNn9fbDSmc_PE_003D(int _0023_003Dqv_0024nLbPeHlcA38ONczZLO2Q_003D_003D, ReliableRandom _0023_003Dqw04Ov6hOAnPCIevYdEM4JA_003D_003D)
		{
			return _0023_003Dqw04Ov6hOAnPCIevYdEM4JA_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
			{
				SignalColor.Yellow,
				SignalColor.Green,
				SignalColor.Red
			});
		}

		internal SignalColor _0023_003DqmxvYNC69GCTW4doEyTBUY40_0024gN6e6YlxFXOzE3FQBGQ_003D(int _0023_003DqIOAjXylH6u_0024mMe3_EdbieA_003D_003D, ReliableRandom _0023_003DqP4Bmgt1XoGjzIgmzOEbBdg_003D_003D)
		{
			return _0023_003DqP4Bmgt1XoGjzIgmzOEbBdg_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
			{
				SignalColor.Yellow,
				SignalColor.Green,
				SignalColor.Red
			});
		}

		internal SignalColor _0023_003DqpDydZdJOufUTdYbWy_0024Zp6vYgYu4YYGSnuM5uy6Ty1V4_003D(int _0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D)
		{
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqM4vNykouk6ORi4iLkJ6xjQSowA30cY7S0VIAMU_002489HY_003D(int _0023_003DqpBfcA5kLP0ohKrpvT4Dt_0024A_003D_003D)
		{
			return SignalColor.Green;
		}

		internal SignalColor _0023_003Dq22npxjoDGsfZSWfjUbTcZD5fXQ_002486Arys5ATCyKe950_003D(int _0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D, ReliableRandom _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D)
		{
			return _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
			{
				SignalColor.Red,
				SignalColor.Green,
				SignalColor.Yellow
			});
		}

		internal SignalColor _0023_003DqY5WMXJBdfeUz5iLd_0024ShfwqnuJ07wygQX7O5sf1u82DY_003D(int _0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D, ReliableRandom _0023_003DqGqHrLIPpzkY7jO6P5MeM4w_003D_003D)
		{
			if (!_0023_003DqGqHrLIPpzkY7jO6P5MeM4w_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.9f) && _0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D != 0)
			{
				return SignalColor.None;
			}
			return SignalColor.Green;
		}

		internal SignalColor _0023_003DqCAiWVsrYUlVKEgRJPzhUbpYm9GRyW0LyOcPtIYrcnqw_003D(int _0023_003DqCbaf7a_0024qMJ59WhmwCNheMw_003D_003D, ReliableRandom _0023_003Dqb8oiVpFms5eqHdLpCNRcHQ_003D_003D)
		{
			if (!_0023_003Dqb8oiVpFms5eqHdLpCNRcHQ_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.9f) || _0023_003DqCbaf7a_0024qMJ59WhmwCNheMw_003D_003D == 10)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003Dq6aU3VUJWjAz9TRxoMUDfko_0zEoMHOv3u8iLvlxcZIE_003D(int _0023_003DqQkCx5FSH4Ss5XaYu5bcHdQ_003D_003D, ReliableRandom _0023_003Dqqnz4ujC4D_1ckH7s3jVO9Q_003D_003D)
		{
			if (!_0023_003Dqqnz4ujC4D_1ckH7s3jVO9Q_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.9f))
			{
				return SignalColor.None;
			}
			return SignalColor.Red;
		}

		internal SignalColor _0023_003DqAJ_7iGlqz4RseW8h9auHHgwCCQOWSB4awgV77huyglw_003D(int _0023_003Dqr0UUJs99v06Mk_0024yQ8Ci8Zg_003D_003D)
		{
			if (_0023_003Dqr0UUJs99v06Mk_0024yQ8Ci8Zg_003D_003D < 20)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqxdBMR8koosOJzWYVew_00245Y8ieXp_zxFV3XIjSI00u_0024kA_003D(int _0023_003Dq9VKccAOlCUpCLrjgjEhMKg_003D_003D)
		{
			if (_0023_003Dq9VKccAOlCUpCLrjgjEhMKg_003D_003D < 20)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003Dq6bttfJlw2dw1EtZyzVBErmbsT604FTFh78MM1VOvsSU_003D(int _0023_003DquBkHQAqUEAHTY6xw9HLXdQ_003D_003D)
		{
			if (_0023_003DquBkHQAqUEAHTY6xw9HLXdQ_003D_003D < 20)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal SignalColor _0023_003DqmxvYNC69GCTW4doEyTBUY_0024FnieffcMqD9Cd8xVcwicI_003D(int _0023_003DqNIH3BZwrra_1WTPm2X_Gwg_003D_003D)
		{
			if (_0023_003DqNIH3BZwrra_1WTPm2X_Gwg_003D_003D < 20)
			{
				return SignalColor.None;
			}
			return SignalColor.Yellow;
		}

		internal void _0023_003Dqkpfwp2HWboYOnbC0tLUN013aoMIcpGujITBuE045xnE_003D(SignalInfo _0023_003DqyEmFyHnXkMqRN_0024NX0rGTXw_003D_003D)
		{
			_0023_003DqyEmFyHnXkMqRN_0024NX0rGTXw_003D_003D._0023_003Dq82BJ1GIYUy0wrUImGNOm7w_003D_003D = true;
		}

		internal SignalColor _0023_003DqvcxbnMzTqQbdndAeOOJGhw8BXDOA4fMAjEdUHzkG8nE_003D(int _0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D, ReliableRandom _0023_003Dq_oPkm9mMU72Odg12q5tlJA_003D_003D)
		{
			return SignalColor.Green;
		}

		internal string _0023_003DqmQFnaVBzQBdCjGxu81FzPM813HE067jce6e7XcqnS3ZQWlCYR94fi68V0tZQBpFD(string _0023_003Dqq0hdEanwgafhIzKr3Txm_w_003D_003D)
		{
			return _0023_003Dqq0hdEanwgafhIzKr3Txm_w_003D_003D.Trim();
		}

		internal bool _0023_003DqyFjlATAlNGKmUvipcd9ytSeu0Pq1kAMmbjCdLpQu5_0024_0024wIBPitDDldpagXIY4aF5_(SignalInfo _0023_003DqD09KAxlTLi2R__0024migwxU5A_003D_003D)
		{
			return _0023_003DqD09KAxlTLi2R__0024migwxU5A_003D_003D._0023_003Dqtk6F7s2ZLJZnx1voWcVmxQ_003D_003D == _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Input;
		}

		internal bool _0023_003Dq8mLGmIx4MYLWLnveOPY2590wD5rIHLioTpfDki2c56qFnCMkXPutQ0TFu29PaHQu(SignalInfo _0023_003DqhQZ6lOFywEpKLqTg44a77A_003D_003D)
		{
			return _0023_003DqhQZ6lOFywEpKLqTg44a77A_003D_003D._0023_003Dqtk6F7s2ZLJZnx1voWcVmxQ_003D_003D == _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Output;
		}
	}

	public _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805437));

	public _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805437));

	public _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805437));

	public _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[] _0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805437)) };

	public _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805437));

	public int _0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D;

	public bool _0023_003Dq7CHNKwefFGG5_0024PaOinFpGJf6XeCn5hro_00244eXPaMhfGg_003D;

	public int _0023_003DqZ2p1r5g4RodZTCmRtOK3WZbgNDA15ypeeimkWP0ZyIk_003D;

	public ToolType[] _0023_003DqeNXlPBUDRKq13nkfZUBhsg_003D_003D = new ToolType[0];

	public ToolType[] _0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[0];

	private List<SignalInfo> _0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D = new List<SignalInfo>();

	private int _0023_003DqvLCrtLN1urK_Xefd1i7x6Q_003D_003D;

	public _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[] _0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[0];

	public bool _0023_003Dq7VqQbmCfEU7p2GDEfYZ77QdravVae29rGrgHxoYZ6E8_003D;

	public bool _0023_003DqDQLvv_0024pMq_0024sbNzfiBa4WjJokFBdnwIwjGyzfnFXUHwU_003D;

	public bool _0023_003DqUMhyzZTfZj5H5jt9ZtYZb6hVYe0Kgd0MVcSSy_VuK8Y_003D;

	public static Puzzle _0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D;

	public static Puzzle _0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D;

	public static Puzzle _0023_003DqVNp8TDtVQBPG7diGK79H7g_003D_003D;

	public static Puzzle _0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D;

	public static Puzzle _0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D;

	public static Puzzle _0023_003DqagyEePWc_0024XSthkb5uqCIOA_003D_003D;

	public static Puzzle _0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D;

	public static Puzzle _0023_003Dq8s9RzYHP9tGrcOSAsARTCg_003D_003D;

	public static Puzzle _0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D;

	public static Puzzle _0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D;

	public static Puzzle _0023_003Dq1uRf1OA4nxJpCsOfrQjOVQ_003D_003D;

	public static Puzzle _0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D;

	public static Puzzle _0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D;

	public static Puzzle _0023_003Dq4UYQ3fDdEVSgOWUjh4s8QA_003D_003D;

	public static Puzzle _0023_003Dqeck_0024JmUfwMSk5TFQAb41FQE4zWdwlN6MVY94SuzdNJA_003D;

	public static Puzzle _0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D;

	public static Puzzle _0023_003DqB7aj0hd2B9titUW6RrSCaA_003D_003D;

	public static Puzzle _0023_003Dq0h5ElWKDpORGNaf3FJ5IKw_003D_003D;

	public static Puzzle _0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D;

	public static Puzzle _0023_003Dq97lANSbKi72_tsxQMhwIAA_003D_003D;

	public static Puzzle _0023_003Dq5qWnAI5IPbaTyKddh3NHHw_003D_003D;

	public static Puzzle _0023_003Dq6znUOQDiH_8UVPxIm3iCQw_003D_003D;

	public static Puzzle _0023_003Dqa0Vxc5yXAxRg6QbmQg3_Gw_003D_003D;

	public static Puzzle _0023_003DqPNkorwKJdWUwGOXnBy8csw_003D_003D;

	public static Puzzle _0023_003DqAVraF4j1wO7CnFuxIpPyDg_003D_003D;

	public static Puzzle _0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D;

	public static Puzzle _0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D;

	public static Puzzle _0023_003DqahCULQLqG8J2RhUjeYqu2A_003D_003D;

	public static Puzzle _0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D;

	public static Puzzle _0023_003Dq40tlLCkW4vqF2Fin_00244icFw_003D_003D;

	public IReadOnlyList<SignalInfo> _0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()
	{
		return _0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D;
	}

	private SignalColor[] _0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(int _0023_003Dqo7JnR28CxixtmdwtGHgbew_003D_003D, SignalColor _0023_003DqSLUMA5ahsgFY6G2bJFyw_0024w_003D_003D)
	{
		SignalColor[] array = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = _0023_003DqSLUMA5ahsgFY6G2bJFyw_0024w_003D_003D;
		}
		_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqfSRknO6J2kskywdx9RciQg_003D_003D = _0023_003DqSLUMA5ahsgFY6G2bJFyw_0024w_003D_003D switch
		{
			SignalColor.Green => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805431)), 
			SignalColor.Red => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805471)), 
			SignalColor.Yellow => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805479)), 
			_ => throw new _0023_003DqP1Lvlriw8JdzHp67vrhOBYFwzXCcBrFvFv_m_d2KdZA_003D(), 
		};
		_0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D.Add(new SignalInfo(_0023_003DqfSRknO6J2kskywdx9RciQg_003D_003D, _0023_003DqStl6T2a_0024yL8Zer_D1uC1tQ_003D_003D.Pipeline, _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Input, _0023_003Dqo7JnR28CxixtmdwtGHgbew_003D_003D, array, _0023_003DqF78x6M5ui5lShuNSA5vA8w_003D_003D: false, _0023_003DqSLUMA5ahsgFY6G2bJFyw_0024w_003D_003D, _0023_003Dq4byLPjfeNrK273HGVZ6h9g_003D_003D: false));
		return array;
	}

	private SignalColor[] _0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(int _0023_003DqimoPBUykE4iewoGwNGyj_0024g_003D_003D, _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqmxofE9zITzIMBHXyMxPdbA_003D_003D, Func<int, ReliableRandom, SignalColor> _0023_003DqJbhKmU2grgVuA8rB3_00245kPg_003D_003D)
	{
		ReliableRandom arg = _0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(_0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D.Count);
		SignalColor[] array = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = _0023_003DqJbhKmU2grgVuA8rB3_00245kPg_003D_003D(i, arg);
		}
		_0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D.Add(new SignalInfo(_0023_003DqmxofE9zITzIMBHXyMxPdbA_003D_003D, _0023_003DqStl6T2a_0024yL8Zer_D1uC1tQ_003D_003D.Pipeline, _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Input, _0023_003DqimoPBUykE4iewoGwNGyj_0024g_003D_003D, array, _0023_003DqF78x6M5ui5lShuNSA5vA8w_003D_003D: false, _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D, _0023_003Dq4byLPjfeNrK273HGVZ6h9g_003D_003D: false));
		return array;
	}

	private SignalColor[] _0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(int _0023_003DqWjW896osRrtTnBW4LJFg8g_003D_003D, _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqXAhiI4_h6jbmACzK4duVkg_003D_003D, Func<int, SignalColor> _0023_003Dq5XUBOH9yCk8MG7I6nx_7xw_003D_003D)
	{
		SignalColor[] array = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = _0023_003Dq5XUBOH9yCk8MG7I6nx_7xw_003D_003D(i);
		}
		_0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D.Add(new SignalInfo(_0023_003DqXAhiI4_h6jbmACzK4duVkg_003D_003D, _0023_003DqStl6T2a_0024yL8Zer_D1uC1tQ_003D_003D.Pipeline, _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Output, _0023_003DqWjW896osRrtTnBW4LJFg8g_003D_003D, array, _0023_003DqF78x6M5ui5lShuNSA5vA8w_003D_003D: false, _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D, _0023_003Dq4byLPjfeNrK273HGVZ6h9g_003D_003D: false));
		return array;
	}

	private bool[] _0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(int _0023_003DqGM0xruVNJgWKnZOdCju9GQ_003D_003D, _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003Dqy0M478y6pdWl0NpJgAxmoQ_003D_003D, Func<int, ReliableRandom, bool> _0023_003Dqm4iJxPbss1irNWFqa4NSJQ_003D_003D)
	{
		ReliableRandom arg = _0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(_0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D.Count);
		bool[] array = new bool[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = _0023_003Dqm4iJxPbss1irNWFqa4NSJQ_003D_003D(i, arg);
		}
		SignalColor[] _0023_003Dqsm53h6U507FKa0_0024KoNzGIA_003D_003D = array.Select(_003C_003Ec._003C_003E9._0023_003Dq2bzJUJZd7uE2h1T6ivUbajC1nmRKrofsSlXG6Z9_ZJQ_003D).ToArray();
		_0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D.Add(new SignalInfo(_0023_003Dqy0M478y6pdWl0NpJgAxmoQ_003D_003D, _0023_003DqStl6T2a_0024yL8Zer_D1uC1tQ_003D_003D.Matrix, _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Input, _0023_003DqGM0xruVNJgWKnZOdCju9GQ_003D_003D, _0023_003Dqsm53h6U507FKa0_0024KoNzGIA_003D_003D, _0023_003DqF78x6M5ui5lShuNSA5vA8w_003D_003D: false, _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D, _0023_003Dq4byLPjfeNrK273HGVZ6h9g_003D_003D: false));
		return array;
	}

	private bool[] _0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(int _0023_003DqrP_0024Te2E8AFwb6jmFaAFGGw_003D_003D, _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqQELzY9i8PV9L4b9Ulukvtg_003D_003D, Func<int, bool> _0023_003DqivIziRZXHA2Y96KBoX0plQ_003D_003D)
	{
		bool[] array = new bool[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = _0023_003DqivIziRZXHA2Y96KBoX0plQ_003D_003D(i);
		}
		SignalColor[] _0023_003Dqsm53h6U507FKa0_0024KoNzGIA_003D_003D = array.Select(_003C_003Ec._003C_003E9._0023_003DqhBSfeufyqtcqdPQZ9AVJRIf6N9mBCQvP4awRNbtmBCw_003D).ToArray();
		_0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D.Add(new SignalInfo(_0023_003DqQELzY9i8PV9L4b9Ulukvtg_003D_003D, _0023_003DqStl6T2a_0024yL8Zer_D1uC1tQ_003D_003D.Matrix, _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Output, _0023_003DqrP_0024Te2E8AFwb6jmFaAFGGw_003D_003D, _0023_003Dqsm53h6U507FKa0_0024KoNzGIA_003D_003D, _0023_003DqF78x6M5ui5lShuNSA5vA8w_003D_003D: false, _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D, _0023_003Dq4byLPjfeNrK273HGVZ6h9g_003D_003D: false));
		return array;
	}

	private ReliableRandom _0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(int _0023_003DqesNd1b8yCDHwn93vpl6fAQ_003D_003D)
	{
		return new ReliableRandom((uint)(_0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D * 100 + _0023_003DqesNd1b8yCDHwn93vpl6fAQ_003D_003D + _0023_003DqvLCrtLN1urK_Xefd1i7x6Q_003D_003D));
	}

	private void _0023_003DqIZihr1d7YHUMWpc__c7Ihg_003D_003D(int _0023_003DqeYLVEp5XaWCTF9zF6Sn_yg_003D_003D)
	{
		_0023_003DqvLCrtLN1urK_Xefd1i7x6Q_003D_003D = _0023_003DqeYLVEp5XaWCTF9zF6Sn_yg_003D_003D;
	}

	public static void _0023_003DqySDujN2CIPod37WZvPEMgw_003D_003D()
	{
		Puzzle puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 1;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805519));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805536));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805568));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[3]
		{
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805823)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806974)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065807081))
		};
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065807292));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 8;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003Dqs5AOEPBlbXAuGCOWCZD3tA_003D_003D };
		puzzle._0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[2]
		{
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806497)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806544)) },
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806631)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqZfwrQXkXttx3oyDx_NrCng_003D_003D,
				_0023_003DqcRF_0024zuZJx85lqzA3gCpj6Q_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqsQnlHrhbxAqWc60MItkfYA_003D_003D,
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[1] { 4 }
			},
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806677)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[2]
				{
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806689)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806787))
				},
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803814)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqJmn2wDLXs0ssVD5F9QFdzw_003D_003D,
				_0023_003DqRETrPfy9KwLuhl6slpC2L0c6p58iCBykAXuSe4_0024dnfE_003D = new Dictionary<Language, Texture>
				{
					{
						Language.Russian,
						_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dqyw_0024nx0u1r6vG8gDrgeC71g_003D_003D
					},
					{
						Language.ChineseSimplified,
						_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqL74fllHlhONgmF0X5QZRBA_003D_003D
					}
				}
			}
		};
		_0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqRcRzK_Ltz_0024ZfePIrJMKfkM_JAW1YkwCsHzFkyM1E5VM_003D CS_0024_003C_003E8__locals177 = new _0023_003DqRcRzK_Ltz_0024ZfePIrJMKfkM_JAW1YkwCsHzFkyM1E5VM_003D();
		ReliableRandom reliableRandom = _0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(8);
		CS_0024_003C_003E8__locals177._0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D = new List<SignalColor>();
		while (CS_0024_003C_003E8__locals177._0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			SignalColor element = (SignalColor)reliableRandom._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(1, 4);
			CS_0024_003C_003E8__locals177._0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D.AddRange(Enumerable.Repeat(element, reliableRandom._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(1, 3)));
			CS_0024_003C_003E8__locals177._0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D.Add(SignalColor.None);
		}
		CS_0024_003C_003E8__locals177._0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D.Insert(0, SignalColor.None);
		CS_0024_003C_003E8__locals177._0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D[30] = SignalColor.Yellow;
		CS_0024_003C_003E8__locals177._0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D[31] = SignalColor.None;
		_0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803885)), (int _0023_003DqXymW4Zi2yK7OOvw7fubGLg_003D_003D, ReliableRandom _0023_003Dqo_Sow7hX_0024RofoFvcXOgZZg_003D_003D) => SignalColor.Green);
		_0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803890)), (int _0023_003DqIZn_0024d9_00240IGHAhllOJR3E3w_003D_003D, ReliableRandom _0023_003DqHDRmTnsqWXO7ZYGpG73uBQ_003D_003D) => SignalColor.Red);
		_0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803929)), CS_0024_003C_003E8__locals177._0023_003DqG4bMc5FgZ3hBl9_nKzOFpA_003D_003D);
		_0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803885)), CS_0024_003C_003E8__locals177._0023_003DqUF8Z7MsSXKJx3KunoDRPfA_003D_003D);
		_0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803890)), CS_0024_003C_003E8__locals177._0023_003DqLLZMWB4TBcPgKG0_HiPvkA_003D_003D);
		_0023_003DqRMjDkTO0Zu1IgEcOCBJLbQ_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803940)), (int _0023_003DqAMaEhV7Unll3znZlYshpUw_003D_003D, ReliableRandom _0023_003DqaUJSHfhUWWsSWsCrlztiUA_003D_003D) => CS_0024_003C_003E8__locals177._0023_003DqG8ISyAEsQbuneBo410TRYQ_003D_003D[_0023_003DqAMaEhV7Unll3znZlYshpUw_003D_003D] == SignalColor.Yellow);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 2;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803974));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803992));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804023));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804278)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803519));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 25;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqdYuzkBR6b9PKqpKL44tcyQ_003D_003D };
		puzzle._0023_003DqUMhyzZTfZj5H5jt9ZtYZb6hVYe0Kgd0MVcSSy_VuK8Y_003D = true;
		puzzle._0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[1]
		{
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803555)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[3]
				{
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803599)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803634)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803757))
				},
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804846)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqUu577tj1DXqnFsehHEDqow_003D_003D,
				_0023_003DqcRF_0024zuZJx85lqzA3gCpj6Q_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqToRm_C3sfscDpwCVUOts8A_003D_003D,
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[1] { 5 }
			}
		};
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqvWA0xQR0GGTGHP_y2YOX_0024MwdyxhP8_0024qS7MMfJz0qrwA_003D CS_0024_003C_003E8__locals180 = new _0023_003DqvWA0xQR0GGTGHP_y2YOX_0024MwdyxhP8_0024qS7MMfJz0qrwA_003D();
		ReliableRandom reliableRandom2 = _0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(12);
		CS_0024_003C_003E8__locals180._0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D = new List<int>();
		int num = -1;
		while (CS_0024_003C_003E8__locals180._0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			int num2;
			for (num2 = num; num2 == num; num2 = reliableRandom2._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(0, 4))
			{
			}
			CS_0024_003C_003E8__locals180._0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D.AddRange(Enumerable.Repeat(num2, reliableRandom2._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(2, 5)));
			num = num2;
		}
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(5, SignalColor.Green);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804943)), CS_0024_003C_003E8__locals180._0023_003DqUwCoYIEvSvVn_5wAFmv2xQ_003D_003D);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804945)), CS_0024_003C_003E8__locals180._0023_003DqNcx3Uxu943bP09VlEbEPxQ_003D_003D);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804988)), CS_0024_003C_003E8__locals180._0023_003DqSAh9pjTAItWCBGDnLDSSbA_003D_003D);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805022)), (int _0023_003Dq_S_0024ULoUtIcbdVKZJfjDIZQ_003D_003D, ReliableRandom _0023_003DqGY17IGh2lI_0024cGi6FpA4BTQ_003D_003D) => CS_0024_003C_003E8__locals180._0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003Dq_S_0024ULoUtIcbdVKZJfjDIZQ_003D_003D] == 3);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(8, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804943)), CS_0024_003C_003E8__locals180._0023_003DqdvysxFS8k2BVY3Kub1TkWg_003D_003D);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804945)), CS_0024_003C_003E8__locals180._0023_003DqGjxoJ1xLlhhf8AXOKMm8Qg_003D_003D);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804988)), CS_0024_003C_003E8__locals180._0023_003DqVAAh5dpjCXWfx7eKRdhVTg_003D_003D);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805022)), (int _0023_003DqWAtapvC4dY6x8kWcORSpAQ_003D_003D) => (CS_0024_003C_003E8__locals180._0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqWAtapvC4dY6x8kWcORSpAQ_003D_003D] == 3 && (_0023_003DqWAtapvC4dY6x8kWcORSpAQ_003D_003D == 0 || CS_0024_003C_003E8__locals180._0023_003DqtqS7pl7my6hL5ZHMTyLK2Q_003D_003D[_0023_003DqWAtapvC4dY6x8kWcORSpAQ_003D_003D - 1] != 3)) ? SignalColor.Green : SignalColor.None);
		_0023_003DqTSQoI2ZmCLZWrnh9DBRTdg_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[0]._0023_003Dq82BJ1GIYUy0wrUImGNOm7w_003D_003D = true;
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 3;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805029));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805045));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805088));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804316)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065804589));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 19;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D };
		_0023_003DqVNp8TDtVQBPG7diGK79H7g_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D _0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D2 = new _0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D();
		_0023_003DqVNp8TDtVQBPG7diGK79H7g_003D_003D._0023_003DqIZihr1d7YHUMWpc__c7Ihg_003D_003D(6);
		SignalColor[] array = _0023_003DqVNp8TDtVQBPG7diGK79H7g_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801774)), _003C_003Ec._003C_003E9._0023_003DqP5xBOw1HcEavS5iWFlMDa3zvOXuGU3DoSyhkM70lGoE_003D);
		SignalColor[] array2 = _0023_003DqVNp8TDtVQBPG7diGK79H7g_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801781)), _003C_003Ec._003C_003E9._0023_003DqFqe8_EIvePQr0P5x0czAvLjbVs07aY5PR2rkiDUOp_8_003D);
		SignalColor[] array3 = _0023_003DqVNp8TDtVQBPG7diGK79H7g_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801823)), (int _0023_003DqwPci61341SFCDKYmFk4pcg_003D_003D, ReliableRandom _0023_003DqOLV6sqVUUXozK9qBaRnr5A_003D_003D) => _0023_003DqOLV6sqVUUXozK9qBaRnr5A_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D((_0023_003DqwPci61341SFCDKYmFk4pcg_003D_003D < 16) ? 0.35f : 0.25f) ? SignalColor.Yellow : SignalColor.None);
		array[1] = SignalColor.Green;
		array[23] = SignalColor.Green;
		array[25] = SignalColor.Green;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		_0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D2._0023_003DqkHFWX_0024vfpomhMidem4r7Rw_003D_003D = new List<SignalColor>();
		for (int num6 = 0; num6 < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D; num6++)
		{
			if (array[num6] != SignalColor.None)
			{
				num3++;
			}
			if (array2[num6] != SignalColor.None)
			{
				num4++;
			}
			if (array3[num6] != SignalColor.None)
			{
				num5++;
			}
			if (num3 > 0)
			{
				num3--;
				_0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D2._0023_003DqkHFWX_0024vfpomhMidem4r7Rw_003D_003D.Add(SignalColor.Green);
			}
			else if (num4 > 0)
			{
				num4--;
				_0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D2._0023_003DqkHFWX_0024vfpomhMidem4r7Rw_003D_003D.Add(SignalColor.Red);
			}
			else if (num5 > 0)
			{
				num5--;
				_0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D2._0023_003DqkHFWX_0024vfpomhMidem4r7Rw_003D_003D.Add(SignalColor.Yellow);
			}
			else
			{
				_0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D2._0023_003DqkHFWX_0024vfpomhMidem4r7Rw_003D_003D.Add(SignalColor.None);
			}
		}
		_0023_003DqVNp8TDtVQBPG7diGK79H7g_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801825)), _0023_003DqdJHhlZgj2dXfT60Y9_gB7x887kxWbwKyYU3aabFyfm0_003D2._0023_003Dq3XucFrIhqTh1qnrDsaSLJw_003D_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 4;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801861));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801873));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801929));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[3]
		{
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802181)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801296)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801399))
		};
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801566));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 28;
		_0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqEMX30hlpGUHtSAjI_00249zLCEXZa6C2rB6k6Ghz_ialKus_003D CS_0024_003C_003E8__locals185 = new _0023_003DqEMX30hlpGUHtSAjI_00249zLCEXZa6C2rB6k6Ghz_ialKus_003D();
		_0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D._0023_003DqIZihr1d7YHUMWpc__c7Ihg_003D_003D(3);
		CS_0024_003C_003E8__locals185._0023_003Dq_EiDn0GJK_0024Gwzv4SrGjk9g_003D_003D = _0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), _003C_003Ec._003C_003E9._0023_003Dq4ShQB2LCVsnHXJDd5a6xK7UQOm8xwdN6J_iC_GZFzLo_003D);
		CS_0024_003C_003E8__locals185._0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D = _0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802812)), _003C_003Ec._003C_003E9._0023_003DqiFJarnJwOaXPS50lueeKCH2JzpwvyBbtjAiKBbEBmfI_003D);
		_0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), CS_0024_003C_003E8__locals185._0023_003Dqcivs3wnEA4vd2O3VdptGWA_003D_003D);
		_0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802812)), (int _0023_003DqF2nYr5pxx03B0NNzHBQk9A_003D_003D) => CS_0024_003C_003E8__locals185._0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D[_0023_003DqF2nYr5pxx03B0NNzHBQk9A_003D_003D]);
		_0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), CS_0024_003C_003E8__locals185._0023_003DqsLos5_8VAEur45AJ50PFLg_003D_003D);
		_0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802812)), (int _0023_003Dq_BaM5wn4H2rLBTbqWQKw3A_003D_003D) => CS_0024_003C_003E8__locals185._0023_003Dq_EiDn0GJK_0024Gwzv4SrGjk9g_003D_003D[_0023_003Dq_BaM5wn4H2rLBTbqWQKw3A_003D_003D] == SignalColor.None && CS_0024_003C_003E8__locals185._0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D[_0023_003Dq_BaM5wn4H2rLBTbqWQKw3A_003D_003D] == SignalColor.Red);
		_0023_003DqKqf8m6N7LgIo3BjRCV7mHQ_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802819)), (int _0023_003Dq7tJaI6tWt1kdNOTTiIc5Hg_003D_003D) => CS_0024_003C_003E8__locals185._0023_003Dq_EiDn0GJK_0024Gwzv4SrGjk9g_003D_003D[_0023_003Dq7tJaI6tWt1kdNOTTiIc5Hg_003D_003D] == SignalColor.Green && CS_0024_003C_003E8__locals185._0023_003DqhhJIiHIS3FelGkXFxIziBg_003D_003D[_0023_003Dq7tJaI6tWt1kdNOTTiIc5Hg_003D_003D] == SignalColor.Red);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 5;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802854));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802871));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802901));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803177)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802396));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 5;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqdYuzkBR6b9PKqpKL44tcyQ_003D_003D };
		_0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqgGM_Vg_hWoUhV9J3HjC_0024iTShqRsxZfV8Tm8enACBX7A_003D CS_0024_003C_003E8__locals186 = new _0023_003DqgGM_Vg_hWoUhV9J3HjC_0024iTShqRsxZfV8Tm8enACBX7A_003D();
		CS_0024_003C_003E8__locals186._0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D = new List<int>();
		for (int num7 = 0; num7 < 5; num7++)
		{
			CS_0024_003C_003E8__locals186._0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D.Add(0);
			CS_0024_003C_003E8__locals186._0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D.AddRange(Enumerable.Range(1, num7 + 1));
			if (num7 < 4)
			{
				CS_0024_003C_003E8__locals186._0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D.Add(0);
			}
		}
		while (CS_0024_003C_003E8__locals186._0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			CS_0024_003C_003E8__locals186._0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D.Add(5);
		}
		_0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802552)), (int _0023_003Dqf9IethI85Lmtc9Jz_0024NppaQ_003D_003D, ReliableRandom _0023_003DqtDhuJGvPwPk3CWtljBboRQ_003D_003D) => SignalColor.Yellow);
		_0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065803929)), CS_0024_003C_003E8__locals186._0023_003Dqmi8iT_Ng7fVEwC0jiUH33g_003D_003D);
		_0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802586)), CS_0024_003C_003E8__locals186._0023_003Dq00Ih_ZWWaFnNie7Vf7Dcfw_003D_003D);
		_0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802593)), CS_0024_003C_003E8__locals186._0023_003Dqpge0pLP8qkZYb09jfSHnCw_003D_003D);
		_0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802636)), CS_0024_003C_003E8__locals186._0023_003DqGqewZ5IBKg1LNlrWSHXwmA_003D_003D);
		_0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802643)), (int _0023_003DqxP_gna_bb_g59qFhQkrPOQ_003D_003D) => (CS_0024_003C_003E8__locals186._0023_003DqTV5fkoZnIF_0024AfJZwG3qLEQ_003D_003D[_0023_003DqxP_gna_bb_g59qFhQkrPOQ_003D_003D] == 4) ? SignalColor.Yellow : SignalColor.None);
		_0023_003DqNshQ8lsErUWVZVStyrEqTA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802677)), CS_0024_003C_003E8__locals186._0023_003Dq2hzS84z1ft2nj8ux3IJEAw_003D_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 6;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802719));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802726));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065799695));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065799942)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065800119));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 22;
		puzzle._0023_003Dq7CHNKwefFGG5_0024PaOinFpGJf6XeCn5hro_00244eXPaMhfGg_003D = true;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqSMgKIA_0024eogmgvqG3eVqCVA_003D_003D };
		_0023_003DqagyEePWc_0024XSthkb5uqCIOA_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqO7DBHPxlb2VaMX6jo1Zbj2E0eV0beiL_0024OBFenCD_kOY_003D _0023_003DqO7DBHPxlb2VaMX6jo1Zbj2E0eV0beiL_0024OBFenCD_kOY_003D2 = new _0023_003DqO7DBHPxlb2VaMX6jo1Zbj2E0eV0beiL_0024OBFenCD_kOY_003D();
		_0023_003DqO7DBHPxlb2VaMX6jo1Zbj2E0eV0beiL_0024OBFenCD_kOY_003D2._0023_003DqhL3djUUnD9jm8hOgZ7Nx_A_003D_003D = _0023_003DqagyEePWc_0024XSthkb5uqCIOA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), _003C_003Ec._003C_003E9._0023_003DqXvUcjNYQWVfPBwp9Xumgh6kOa0nDdxoCLMTUi7fEwzs_003D);
		_0023_003DqO7DBHPxlb2VaMX6jo1Zbj2E0eV0beiL_0024OBFenCD_kOY_003D2._0023_003Dq5aqblyy4Yei5tlFSI6E6hw_003D_003D = _0023_003DqagyEePWc_0024XSthkb5uqCIOA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802812)), _003C_003Ec._003C_003E9._0023_003Dqk7nNTlXbWLs7cm6nJgGnhfKtkhhv9r78XW6OAE88dKw_003D);
		_0023_003DqagyEePWc_0024XSthkb5uqCIOA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802812)), _0023_003DqO7DBHPxlb2VaMX6jo1Zbj2E0eV0beiL_0024OBFenCD_kOY_003D2._0023_003DqFRFwYRzr3PMdj_vMp32YtA_003D_003D);
		_0023_003DqagyEePWc_0024XSthkb5uqCIOA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), _0023_003DqO7DBHPxlb2VaMX6jo1Zbj2E0eV0beiL_0024OBFenCD_kOY_003D2._0023_003DqFgpMu2Scm2r6KUdfHB70tg_003D_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 7;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065799194));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065799215));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065799245));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065799654)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065800940));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 16;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D };
		_0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqnOLj54kIvFQ5gu6pzObc5uTRIEgigKJQwLCYEB9yhOw_003D CS_0024_003C_003E8__locals189 = new _0023_003DqnOLj54kIvFQ5gu6pzObc5uTRIEgigKJQwLCYEB9yhOw_003D();
		CS_0024_003C_003E8__locals189._0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D = new List<bool>();
		CS_0024_003C_003E8__locals189._0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D.AddRange(Enumerable.Repeat(element: true, _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D / 2));
		CS_0024_003C_003E8__locals189._0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D.AddRange(Enumerable.Repeat(element: false, _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D / 2));
		ReliableRandom _0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D = _0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(717);
		Utility._0023_003Dq_0024nGY_9C6ahFCtVXoNp4K1w_003D_003D(_0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D, CS_0024_003C_003E8__locals189._0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D);
		SignalColor[] array4 = _0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801060)), CS_0024_003C_003E8__locals189._0023_003Dq7CZsj0wWp6ruFBtn66Qg5w_003D_003D);
		Utility._0023_003Dq_0024nGY_9C6ahFCtVXoNp4K1w_003D_003D(_0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D, CS_0024_003C_003E8__locals189._0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D);
		SignalColor[] array5 = _0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801093)), CS_0024_003C_003E8__locals189._0023_003Dq262AcLfJQmgcZCbtoQcMBA_003D_003D);
		Utility._0023_003Dq_0024nGY_9C6ahFCtVXoNp4K1w_003D_003D(_0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D, CS_0024_003C_003E8__locals189._0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D);
		SignalColor[] array6 = _0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801136)), (int _0023_003DqaAMr2J2V4n2iDQVI5r0R4Q_003D_003D, ReliableRandom _0023_003Dq02g322wX7zW7R4IucY3Mqw_003D_003D) => CS_0024_003C_003E8__locals189._0023_003Dq4ZfrLej_0024Uq_0024r8nQFg4GOQQ_003D_003D[_0023_003DqaAMr2J2V4n2iDQVI5r0R4Q_003D_003D] ? SignalColor.Yellow : SignalColor.None);
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		CS_0024_003C_003E8__locals189._0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D = new List<bool>();
		for (int num11 = 0; num11 < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D; num11++)
		{
			if (array4[num11] != SignalColor.None)
			{
				num8++;
			}
			if (array5[num11] != SignalColor.None)
			{
				num9++;
			}
			if (array6[num11] != SignalColor.None)
			{
				num10++;
			}
			if (num8 > 0 && num9 > 0 && num10 > 0)
			{
				num8--;
				num9--;
				num10--;
				CS_0024_003C_003E8__locals189._0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D.Add(item: true);
			}
			else
			{
				CS_0024_003C_003E8__locals189._0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D.Add(item: false);
			}
		}
		_0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801060)), CS_0024_003C_003E8__locals189._0023_003DqW12rLVGo76ZTcUglPshMEA_003D_003D);
		_0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801093)), (int _0023_003DqVr3sv4BIgj_002461e1yfqQN7w_003D_003D) => CS_0024_003C_003E8__locals189._0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D[_0023_003DqVr3sv4BIgj_002461e1yfqQN7w_003D_003D] ? SignalColor.Red : SignalColor.None);
		_0023_003DqHO8KrC6h2OfAZ_0024B7BkLTZw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801136)), (int _0023_003DqAFVcb4hqOYycGLNShFeQjQ_003D_003D) => CS_0024_003C_003E8__locals189._0023_003Dq_Sr3D5czPV8MNmVmyx7NIg_003D_003D[_0023_003DqAFVcb4hqOYycGLNShFeQjQ_003D_003D] ? SignalColor.Yellow : SignalColor.None);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 8;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801138));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801160));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065801194));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065800574)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797689));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 18;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqbBCr6AGmuKKlmwJN9Axf4Q_003D_003D };
		puzzle._0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[1]
		{
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797965)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797955)) },
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798066)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqIe_0024eOMZArUQzR6RqdryomA_003D_003D,
				_0023_003DqcRF_0024zuZJx85lqzA3gCpj6Q_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqOUB01iZkwMGA6Nyf_0024LuG6A_003D_003D,
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[1] { 5 }
			}
		};
		_0023_003Dq8s9RzYHP9tGrcOSAsARTCg_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003Dq8s9RzYHP9tGrcOSAsARTCg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(7, SignalColor.Green);
		_0023_003Dq8s9RzYHP9tGrcOSAsARTCg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(3, SignalColor.Red);
		_0023_003Dq8s9RzYHP9tGrcOSAsARTCg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(8, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797166)), (int _0023_003DqbYs_0024SyjwlV6e8STl9u5_0024bQ_003D_003D) => (_0023_003DqbYs_0024SyjwlV6e8STl9u5_0024bQ_003D_003D % 2 == 0) ? SignalColor.Green : SignalColor.None);
		_0023_003Dq8s9RzYHP9tGrcOSAsARTCg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797173)), (int _0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D) => (_0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D % 2 == 1) ? SignalColor.Green : SignalColor.None);
		_0023_003Dq8s9RzYHP9tGrcOSAsARTCg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797215)), (int _0023_003DqeBN0zpxUaaGlBCRASAXlAA_003D_003D) => (_0023_003DqeBN0zpxUaaGlBCRASAXlAA_003D_003D % 2 == 1) ? SignalColor.Red : SignalColor.None);
		_0023_003Dq8s9RzYHP9tGrcOSAsARTCg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797223)), _003C_003Ec._003C_003E9._0023_003DqAr7fu_IbPZEI9flyjIF_17KDQL0Foe3KlUfniTzt8Rg_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 9;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797258));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797274));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797305));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797555)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798752));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 24;
		puzzle._0023_003DqeNXlPBUDRKq13nkfZUBhsg_003D_003D = new ToolType[2]
		{
			ToolType._0023_003DqQTgv9Qs5rnLQcexdpSth3g_003D_003D,
			ToolType._0023_003DqhVVvKO99dgHTdrj3Tn61AQ_003D_003D
		};
		puzzle._0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[2]
		{
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798923)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[2]
				{
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798937)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798993))
				},
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065799119)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dq7JGrubx9gQG789p9hQyrGQ_003D_003D,
				_0023_003DqcRF_0024zuZJx85lqzA3gCpj6Q_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dq9r4uKvsakqU8VWznf10_CA_003D_003D,
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[1] { 1 }
			},
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798169)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[2]
				{
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798192)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798264))
				},
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798342)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dq4XZkBqMA6k3o7r3eyetTTQ_003D_003D,
				_0023_003DqcRF_0024zuZJx85lqzA3gCpj6Q_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqcfRFN_0024I_0024w_0024PjAXpW_0024kpQpA_003D_003D,
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[1] { 2 }
			}
		};
		_0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqO1D_HIFavNlITu1dnrMTel4L9L9Wn8cXias_00248T_0558_003D CS_0024_003C_003E8__locals191 = new _0023_003DqO1D_HIFavNlITu1dnrMTel4L9L9Wn8cXias_00248T_0558_003D();
		_0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(7, SignalColor.Green);
		CS_0024_003C_003E8__locals191._0023_003Dq8keU4Hm1v2_5LuPoqVU9dQ_003D_003D = _0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798401)), (int _0023_003DqOkMw6aBn7MZvC5Y3sSEXDQ_003D_003D, ReliableRandom _0023_003DqY2XBw7NSW04_EtErO_0024V2vA_003D_003D) => _0023_003DqY2XBw7NSW04_EtErO_0024V2vA_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.5f) ? SignalColor.Green : SignalColor.None);
		_0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(3, SignalColor.Green);
		_0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), (int _0023_003DqYiU70PIwQuLNnfzhyiqixw_003D_003D) => CS_0024_003C_003E8__locals191._0023_003Dq8keU4Hm1v2_5LuPoqVU9dQ_003D_003D[_0023_003DqYiU70PIwQuLNnfzhyiqixw_003D_003D]);
		_0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), (int _0023_003DqZy9kA_nj704QOua_uHv3_0024w_003D_003D) => CS_0024_003C_003E8__locals191._0023_003Dq8keU4Hm1v2_5LuPoqVU9dQ_003D_003D[_0023_003DqZy9kA_nj704QOua_uHv3_0024w_003D_003D]);
		_0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), CS_0024_003C_003E8__locals191._0023_003Dqrdq_frAbu3XhCOc26VzA8A_003D_003D);
		_0023_003Dq0wvcQYQiEyq4b5tVki74ow_003D_003D._0023_003DqDQLvv_0024pMq_0024sbNzfiBa4WjJokFBdnwIwjGyzfnFXUHwU_003D = true;
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 10;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798443));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798459));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798488));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[3]
		{
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795698)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795849)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796092))
		};
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795311));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 29;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003DqLofx9oxbuA0d3i0H0suc1A_003D_003D,
			ToolType._0023_003DqdYuzkBR6b9PKqpKL44tcyQ_003D_003D
		};
		puzzle._0023_003DqUMhyzZTfZj5H5jt9ZtYZb6hVYe0Kgd0MVcSSy_VuK8Y_003D = true;
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003Dq_0024lUoJvE9haBX4MEfCEJkjsETfA1WK6ghrDz9K1doPyw_003D CS_0024_003C_003E8__locals199 = new _0023_003Dq_0024lUoJvE9haBX4MEfCEJkjsETfA1WK6ghrDz9K1doPyw_003D();
		ReliableRandom reliableRandom3 = _0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(10);
		CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D = new List<SignalColor>();
		CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D.Add(SignalColor.Yellow);
		CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D.Add(SignalColor.None);
		while (CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			SignalColor element2 = (reliableRandom3._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.3f) ? SignalColor.Yellow : SignalColor.Red);
			int count = Math.Max(1, reliableRandom3._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(-1, 4));
			CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D.AddRange(Enumerable.Repeat(element2, count));
			CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D.Add(SignalColor.None);
		}
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795471)), (int _0023_003DqEE04qCJvGJ_sHw3PK7pmkA_003D_003D, ReliableRandom _0023_003DqkOy5sPGXu8b9hlDkYTA_mg_003D_003D) => CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqEE04qCJvGJ_sHw3PK7pmkA_003D_003D]);
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795471)), CS_0024_003C_003E8__locals199._0023_003DqDf8iZNqR7pw7jzagKYC9LA_003D_003D);
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795473)), (int _0023_003DqTM6KKNigu1Cn5KeWBAJWTw_003D_003D) => CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqTM6KKNigu1Cn5KeWBAJWTw_003D_003D] == SignalColor.Yellow);
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795515)), CS_0024_003C_003E8__locals199._0023_003DqXzZH6Xrsccq7lwrb5zCAkw_003D_003D);
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795552)), (int _0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D) => _0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D > 1 && CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D] == SignalColor.Yellow && CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D - 1] == SignalColor.Yellow && CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003DqrBLfUCw1O7hEdmy_0024qm1v3g_003D_003D - 2] == SignalColor.Yellow);
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795556)), CS_0024_003C_003E8__locals199._0023_003DqdM4p1mLoJmkRlxoYJ9soww_003D_003D);
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(1, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796619)), CS_0024_003C_003E8__locals199._0023_003DqvpbFAr1AJbCSUdW4RSHdaw_003D_003D);
		_0023_003DqmWjl7P0KbCs537EZTSuAug_003D_003D._0023_003DqW6GdPjGPcMV4Ubed5_0024xgXzSlZ9J2_GwQ2uBIPJbxovQ_003D(0, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796653)), (int _0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D) => _0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D > 1 && CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D] == SignalColor.Red && CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D - 1] == SignalColor.Red && CS_0024_003C_003E8__locals199._0023_003DqDZ6clpXKTC8aSPWshdpPFw_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D - 2] == SignalColor.Red);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 11;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796658));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796679));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796705));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[3]
		{
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796997)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065797076)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796179))
		};
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796334));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 17;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D };
		puzzle._0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[1]
		{
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796493)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[4]
				{
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796483)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065796568)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793595)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793696))
				},
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793777)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqIM6_0024sWYlwAgBPwPtkT9fkA_003D_003D,
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[1] { 5 }
			}
		};
		_0023_003Dq1uRf1OA4nxJpCsOfrQjOVQ_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2 = new _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D();
		ReliableRandom _0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D2 = new ReliableRandom(42uL);
		_0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2._0023_003DqSvEIokZNii5YK58i1lWCUg_003D_003D = new List<bool>();
		_0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2._0023_003DqCbPRVJ2zOuxFMEb1U9xcbw_003D_003D = new List<bool>();
		for (int num12 = 0; num12 < 8; num12++)
		{
			List<bool> list = new List<bool>();
			list.AddRange(Enumerable.Repeat(element: true, 4));
			list.AddRange(Enumerable.Repeat(element: false, 4));
			Utility._0023_003Dq_0024nGY_9C6ahFCtVXoNp4K1w_003D_003D(_0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D2, list);
			((num12 < 4) ? _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2._0023_003DqSvEIokZNii5YK58i1lWCUg_003D_003D : _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2._0023_003DqCbPRVJ2zOuxFMEb1U9xcbw_003D_003D).AddRange(list);
		}
		_0023_003Dq1uRf1OA4nxJpCsOfrQjOVQ_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793838)), _003C_003Ec._003C_003E9._0023_003DqJjcaRSf3nmbpGPKHxtetE1eg3x0Spp0VBUPTT73gSDY_003D);
		_0023_003Dq1uRf1OA4nxJpCsOfrQjOVQ_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793838)), _003C_003Ec._003C_003E9._0023_003DqWuhPGs38VwaOtR3y76fbOCZb8Qe3s3psAGW5k3r7sGw_003D);
		_0023_003Dq1uRf1OA4nxJpCsOfrQjOVQ_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793848)), _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2._0023_003DqKbm2iT75kVG1ZZkOJISHTw_003D_003D);
		_0023_003Dq1uRf1OA4nxJpCsOfrQjOVQ_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793882)), _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2._0023_003DqWDvr1iSMYZU1LUqoxEzmBg_003D_003D);
		_0023_003Dq1uRf1OA4nxJpCsOfrQjOVQ_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793848)), _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2._0023_003Dqq_wW6P51BZ74cD9rnKGPsg_003D_003D);
		_0023_003Dq1uRf1OA4nxJpCsOfrQjOVQ_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793882)), _0023_003DqTdr8WV0Dn8mAd0Bs4sFbk7p7N9I_4_iPQasP9Lh78C4_003D2._0023_003DqKt_hdrG8SXuMrXFJTR13Eg_003D_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 12;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793892));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793933));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793939));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793193)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065793406));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 27;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003DqbBCr6AGmuKKlmwJN9Axf4Q_003D_003D,
			ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D
		};
		_0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqjackqGwzs_0024LGcF4Jgwor5GN3ASwbD2kO6u8avlnlk7Q_003D CS_0024_003C_003E8__locals200 = new _0023_003DqjackqGwzs_0024LGcF4Jgwor5GN3ASwbD2kO6u8avlnlk7Q_003D();
		CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D = new bool[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[6] = true;
		CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[12] = true;
		CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[13] = true;
		CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[17] = true;
		CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[27] = true;
		CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[28] = true;
		CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[29] = true;
		_0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794651)), _003C_003Ec._003C_003E9._0023_003DqUhWCplZ2TmC5kCJSnloNvidUi0ABob__HZAjilRurg0_003D);
		_0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794685)), CS_0024_003C_003E8__locals200._0023_003DqxQhDUyxgE1rpIyII9ThYIQ_003D_003D);
		_0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(8, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794651)), CS_0024_003C_003E8__locals200._0023_003Dq1rvzUh4MWPxQMKiI9hCqqA_003D_003D);
		_0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794651)), CS_0024_003C_003E8__locals200._0023_003DqW18Td21UaDUAVU9OUKzRUw_003D_003D);
		_0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794651)), (int _0023_003DqW2_iQ2GRJATWr2h8odURlw_003D_003D) => CS_0024_003C_003E8__locals200._0023_003Dq2yZgAziBsYBG1bDIKLWuKw_003D_003D[_0023_003DqW2_iQ2GRJATWr2h8odURlw_003D_003D] ? SignalColor.Red : SignalColor.None);
		_0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794651)), CS_0024_003C_003E8__locals200._0023_003Dq6f180okoddYKPcRH9VbghQ_003D_003D);
		_0023_003Dq9WmhGZrsGk9kqw5VwpMKew_003D_003D._0023_003DqDQLvv_0024pMq_0024sbNzfiBa4WjJokFBdnwIwjGyzfnFXUHwU_003D = true;
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 13;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794696));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794712));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794739));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[2]
		{
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794097)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794366))
		};
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065794550));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 14;
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqtcpgeltJl5vc87FNABhhQwWBWUSmpTfcKsauZm_0024asm0_003D CS_0024_003C_003E8__locals201 = new _0023_003DqtcpgeltJl5vc87FNABhhQwWBWUSmpTfcKsauZm_0024asm0_003D();
		CS_0024_003C_003E8__locals201._0023_003DqNoW_0024wQ0LRB_0024D6KGP3btgYw_003D_003D = _0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065824425)), _003C_003Ec._003C_003E9._0023_003DqwNajGwr_G9HY9Ugir2XF0s_Qc04ayYgBuQbYH40QbJM_003D);
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(7, SignalColor.Green);
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(5, SignalColor.Red);
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(3, SignalColor.Yellow);
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805431)), (int _0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D) => (!CS_0024_003C_003E8__locals201._0023_003DqNoW_0024wQ0LRB_0024D6KGP3btgYw_003D_003D[_0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D]) ? SignalColor.Green : SignalColor.Yellow);
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805471)), CS_0024_003C_003E8__locals201._0023_003Dq1Sb9MDh6_kpAuwosOI4DCA_003D_003D);
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805479)), CS_0024_003C_003E8__locals201._0023_003DqrDx8vZeMPANs_J1kq2wMNg_003D_003D);
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[4]._0023_003DqyamJLc9CilGrrdWVefDwyQ_003D_003D = SignalColor.Green;
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[5]._0023_003DqyamJLc9CilGrrdWVefDwyQ_003D_003D = SignalColor.Red;
		_0023_003Dq4nvG0mereFkNBfuNMMwGXg_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[6]._0023_003DqyamJLc9CilGrrdWVefDwyQ_003D_003D = SignalColor.Yellow;
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 14;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065824435));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065824474));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065824503));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823903)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065824076));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 10;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003Dqz06_0024YtyTGWeqK_3Fv_0024v8zw_003D_003D,
			ToolType._0023_003Dq5fivxgaWBrOIdKdC4Nwg_0024Q_003D_003D
		};
		_0023_003Dq4UYQ3fDdEVSgOWUjh4s8QA_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqW8Ya_3slUaCuu22so_vqbexnejOCv5vtx_0024lxj5b4pOA_003D CS_0024_003C_003E8__locals202 = new _0023_003DqW8Ya_3slUaCuu22so_vqbexnejOCv5vtx_0024lxj5b4pOA_003D();
		_0023_003Dq4UYQ3fDdEVSgOWUjh4s8QA_003D_003D._0023_003DqIZihr1d7YHUMWpc__c7Ihg_003D_003D(1);
		CS_0024_003C_003E8__locals202._0023_003DqjPhOaUqbREZZkH7JeYj2OA_003D_003D = _0023_003Dq4UYQ3fDdEVSgOWUjh4s8QA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798401)), _003C_003Ec._003C_003E9._0023_003Dq_d0_prCqsgrsBhJ9fGEpe4RvduFSbvPzmos5i1ZqHiA_003D);
		_0023_003Dq4UYQ3fDdEVSgOWUjh4s8QA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065798401)), (int _0023_003DqYFZA7TXOlOOcby7M3mldcQ_003D_003D) => (CS_0024_003C_003E8__locals202._0023_003DqjPhOaUqbREZZkH7JeYj2OA_003D_003D[_0023_003DqYFZA7TXOlOOcby7M3mldcQ_003D_003D] != SignalColor.None) ? SignalColor.Green : SignalColor.None);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 15;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065825371));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065825379));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065825420));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065825694)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065824841));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 15;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqbBCr6AGmuKKlmwJN9Axf4Q_003D_003D };
		_0023_003Dqeck_0024JmUfwMSk5TFQAb41FQE4zWdwlN6MVY94SuzdNJA_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003Dqeck_0024JmUfwMSk5TFQAb41FQE4zWdwlN6MVY94SuzdNJA_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(7, SignalColor.Green);
		_0023_003Dqeck_0024JmUfwMSk5TFQAb41FQE4zWdwlN6MVY94SuzdNJA_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(5, SignalColor.Red);
		_0023_003Dqeck_0024JmUfwMSk5TFQAb41FQE4zWdwlN6MVY94SuzdNJA_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(3, SignalColor.Yellow);
		_0023_003Dqeck_0024JmUfwMSk5TFQAb41FQE4zWdwlN6MVY94SuzdNJA_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065824977)), (int _0023_003Dqwx46I9CKs1TnQcEaROaIkg_003D_003D) => (new SignalColor[4]
		{
			SignalColor.Green,
			SignalColor.Red,
			SignalColor.Yellow,
			SignalColor.None
		})[_0023_003Dqwx46I9CKs1TnQcEaROaIkg_003D_003D % 4]);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 16;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065825014));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065825030));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065825068));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822272)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822407));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 21;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqdYuzkBR6b9PKqpKL44tcyQ_003D_003D };
		_0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822576)), _003C_003Ec._003C_003E9._0023_003Dqh4nLwd2ydJwyalXbncGFC709et95yBGEgNfw5l4ACJQ_003D);
		_0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822576)), _003C_003Ec._003C_003E9._0023_003Dqzen8tpJeOB341uON0zX_l4AKIIE6CDq7oJY1oSm0kak_003D);
		_0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822576)), (int _0023_003DqdFgUVAm5cyMXDtUjdH0Jtw_003D_003D) => (_0023_003DqdFgUVAm5cyMXDtUjdH0Jtw_003D_003D % 6 == 0 || _0023_003DqdFgUVAm5cyMXDtUjdH0Jtw_003D_003D % 6 == 4) ? SignalColor.Red : SignalColor.None);
		_0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822576)), _003C_003Ec._003C_003E9._0023_003DqoGySo3CMRqTTDJ6uBBgGhKGmSNZYjjcv1DB6MBDp8SI_003D);
		_0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822576)), _003C_003Ec._003C_003E9._0023_003DqCUOSEbW2SNESJT83J4Fnuv6cA1jTcPQyMBYvrt5qNws_003D);
		_0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822576)), _003C_003Ec._003C_003E9._0023_003DqWazQu1WM1T8A7canMVIsoC7rcI0PfyZlyeHDeWYaR_Y_003D);
		_0023_003DqWUA9U3_RKS6xp2zzVUcEfA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822576)), _003C_003Ec._003C_003E9._0023_003DqCVNgvzuRsJHItkTd75RpePBRY0vf36qypJLcwO55BN4_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 17;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822581));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822594));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822626));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821883)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822058));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 13;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003DqLofx9oxbuA0d3i0H0suc1A_003D_003D,
			ToolType._0023_003DqSMgKIA_0024eogmgvqG3eVqCVA_003D_003D
		};
		_0023_003DqB7aj0hd2B9titUW6RrSCaA_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqKFW4YJeQXiVGFHuA426XgkX5dOhr2u8VBG8HK_s3it4_003D _0023_003DqKFW4YJeQXiVGFHuA426XgkX5dOhr2u8VBG8HK_s3it4_003D2 = new _0023_003DqKFW4YJeQXiVGFHuA426XgkX5dOhr2u8VBG8HK_s3it4_003D();
		_0023_003DqB7aj0hd2B9titUW6RrSCaA_003D_003D._0023_003DqIZihr1d7YHUMWpc__c7Ihg_003D_003D(6);
		_0023_003DqKFW4YJeQXiVGFHuA426XgkX5dOhr2u8VBG8HK_s3it4_003D2._0023_003DqWZLWcq2HKxBPBYwe7MNBew_003D_003D = _0023_003DqB7aj0hd2B9titUW6RrSCaA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823373)), _003C_003Ec._003C_003E9._0023_003DqTkgkO7iB91QYOXzQZ7cVn8yiJUi_2x91en22761p2Ig_003D);
		_0023_003DqB7aj0hd2B9titUW6RrSCaA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823383)), _0023_003DqKFW4YJeQXiVGFHuA426XgkX5dOhr2u8VBG8HK_s3it4_003D2._0023_003DqAfkpUSvGO2q3lZ2dTnUweg_003D_003D);
		_0023_003DqB7aj0hd2B9titUW6RrSCaA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823373)), _0023_003DqKFW4YJeQXiVGFHuA426XgkX5dOhr2u8VBG8HK_s3it4_003D2._0023_003DqtDul5bV6b8hQ5HT_oyqyoA_003D_003D);
		_0023_003DqB7aj0hd2B9titUW6RrSCaA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823383)), _0023_003DqKFW4YJeQXiVGFHuA426XgkX5dOhr2u8VBG8HK_s3it4_003D2._0023_003Dqo0qLq4ghBA7YzeNeK1mtWw_003D_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 18;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823420));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823438));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823469));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823733)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065822968));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 12;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqbBCr6AGmuKKlmwJN9Axf4Q_003D_003D };
		_0023_003Dq0h5ElWKDpORGNaf3FJ5IKw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D _0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2 = new _0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D();
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqEyAHny9GBgCclArrUAVIBA_003D_003D = new List<int>();
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqD0nxVBjf4tbnuUWEQGrfrw_003D_003D = new List<bool>();
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqF6aETNuauk1FUEnWlI3hmw_003D_003D = new List<bool>();
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqY_gpkek_0024i0M5gGM8u3XkP5QQR0pukntqnvuQHNmGZFU_003D(0, 1);
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqY_gpkek_0024i0M5gGM8u3XkP5QQR0pukntqnvuQHNmGZFU_003D(1, 10);
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqY_gpkek_0024i0M5gGM8u3XkP5QQR0pukntqnvuQHNmGZFU_003D(0, 1);
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqY_gpkek_0024i0M5gGM8u3XkP5QQR0pukntqnvuQHNmGZFU_003D(2, 12);
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqY_gpkek_0024i0M5gGM8u3XkP5QQR0pukntqnvuQHNmGZFU_003D(0, 1);
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqY_gpkek_0024i0M5gGM8u3XkP5QQR0pukntqnvuQHNmGZFU_003D(1, 6);
		_0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqY_gpkek_0024i0M5gGM8u3XkP5QQR0pukntqnvuQHNmGZFU_003D(0, 1);
		_0023_003Dq0h5ElWKDpORGNaf3FJ5IKw_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(5, SignalColor.Yellow);
		_0023_003Dq0h5ElWKDpORGNaf3FJ5IKw_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065823201)), _0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqabWFopD8nGvk83_42qcuRg_003D_003D);
		_0023_003Dq0h5ElWKDpORGNaf3FJ5IKw_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820172)), _0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqzSIyiPmczFt15DLF1SWQcQ_003D_003D);
		_0023_003Dq0h5ElWKDpORGNaf3FJ5IKw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820180)), _0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003Dqkq0MKvBxYQsPRBhkA4gYDg_003D_003D);
		_0023_003Dq0h5ElWKDpORGNaf3FJ5IKw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820214)), _0023_003DqcGeai4JErqipxvr1p52CKQvveKowx262R_0024_0024y3CySYzQ_003D2._0023_003DqAHcK4cPC8SGk9qY_wrWbrw_003D_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 19;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820255));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820272));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820302));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[2]
		{
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820548)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819759))
		};
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819946));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 4;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqwS7d6x_ayPuI0sJ_pDysjBSV0H6ueak4fyUPQWg_00243lU_003D CS_0024_003C_003E8__locals212 = new _0023_003DqwS7d6x_ayPuI0sJ_pDysjBSV0H6ueak4fyUPQWg_00243lU_003D();
		ReliableRandom reliableRandom4 = _0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(0);
		CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D = new List<int>();
		while (CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D.Add(reliableRandom4._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(0, 6));
		}
		CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[3] = 2;
		CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[4] = 5;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(6, SignalColor.Green);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(4, SignalColor.Green);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821205)), (int _0023_003DqH52m6nGA0NZKlZCp_0024kI_0024_g_003D_003D, ReliableRandom _0023_003Dqhg_0024vZqgprAb0XZa9vyOaMg_003D_003D) => CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqH52m6nGA0NZKlZCp_0024kI_0024_g_003D_003D] == 0);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821219)), CS_0024_003C_003E8__locals212._0023_003DqMNs8QUFbwdy6GZhnmXn8tg_003D_003D);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821257)), (int _0023_003Dqby58Lz1NpiT_Qbak593u0A_003D_003D, ReliableRandom _0023_003DqYVEu2QKPg_0024xU0_Tb0QYrog_003D_003D) => CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqby58Lz1NpiT_Qbak593u0A_003D_003D] == 2);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821271)), (int _0023_003Dqra4K7JMN5gQNdSwhGT_0024lfA_003D_003D, ReliableRandom _0023_003DqqHLAafqsYCCTHW1Z2MvKEQ_003D_003D) => CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqra4K7JMN5gQNdSwhGT_0024lfA_003D_003D] == 3);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(1, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821311)), CS_0024_003C_003E8__locals212._0023_003Dq53VOd52IWyF9YvaP87sNHQ_003D_003D);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(0, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821319)), (int _0023_003DqEE04qCJvGJ_sHw3PK7pmkA_003D_003D, ReliableRandom _0023_003Dqn_0024da2bODoq6e70MOnxv4JA_003D_003D) => CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqEE04qCJvGJ_sHw3PK7pmkA_003D_003D] == 5);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821205)), (int _0023_003Dqe50OjJwKupWUwqXKNGo6Xg_003D_003D) => (CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqe50OjJwKupWUwqXKNGo6Xg_003D_003D] == 0 || CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqe50OjJwKupWUwqXKNGo6Xg_003D_003D] == 3 || CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003Dqe50OjJwKupWUwqXKNGo6Xg_003D_003D] == 4) ? SignalColor.Green : SignalColor.None);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821219)), CS_0024_003C_003E8__locals212._0023_003Dq_0xc1LeSRgRzUM_DPGgYUYANoqMgirZMseBkXxU7eOg_003D);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821257)), (int _0023_003DqVHTnorKOxVfSRNMPCZEHgQ_003D_003D) => (CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqVHTnorKOxVfSRNMPCZEHgQ_003D_003D] == 2 || CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqVHTnorKOxVfSRNMPCZEHgQ_003D_003D] == 4 || CS_0024_003C_003E8__locals212._0023_003Dqb4s0fTc7dNa0g6rgGNfK9Q_003D_003D[_0023_003DqVHTnorKOxVfSRNMPCZEHgQ_003D_003D] == 5) ? SignalColor.Green : SignalColor.None);
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[0]._0023_003Dq82BJ1GIYUy0wrUImGNOm7w_003D_003D = true;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[1]._0023_003Dq82BJ1GIYUy0wrUImGNOm7w_003D_003D = true;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[2]._0023_003DqcTMtpYk1o8PUTJ99c3zrLQ_003D_003D = true;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[3]._0023_003DqcTMtpYk1o8PUTJ99c3zrLQ_003D_003D = true;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[4]._0023_003DqcTMtpYk1o8PUTJ99c3zrLQ_003D_003D = true;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[5]._0023_003DqcTMtpYk1o8PUTJ99c3zrLQ_003D_003D = true;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[6]._0023_003DqcTMtpYk1o8PUTJ99c3zrLQ_003D_003D = true;
		_0023_003DqcVIkC4pe8Cjmlwuo8uv4yw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()[7]._0023_003DqcTMtpYk1o8PUTJ99c3zrLQ_003D_003D = true;
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 20;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821359));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821375));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821405));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[3]
		{
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821662)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820759)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820920))
		};
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065821079));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 20;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003Dqz06_0024YtyTGWeqK_3Fv_0024v8zw_003D_003D,
			ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D
		};
		_0023_003Dq97lANSbKi72_tsxQMhwIAA_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqwXFoYYVv6aQ3i_00242Cgm7TOQsYXSuBONyWH9FTxva5Lmw_003D CS_0024_003C_003E8__locals213 = new _0023_003DqwXFoYYVv6aQ3i_00242Cgm7TOQsYXSuBONyWH9FTxva5Lmw_003D();
		CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		CS_0024_003C_003E8__locals213._0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D = new int[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		CS_0024_003C_003E8__locals213._0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D, 1, SignalColor.Green, 4);
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D, 6, SignalColor.Yellow, 4);
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D, 11, SignalColor.Green, 2);
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D, 14, SignalColor.Yellow, 2);
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D, 16, SignalColor.Green, 2);
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D, 20, SignalColor.Yellow, 1);
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D, 22, SignalColor.Yellow, 1);
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003Dq3mxEIOisAoP2XRgxlSX8ag_003D_003D, 24, SignalColor.Green, 4);
		CS_0024_003C_003E8__locals213._0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D[4] = 1;
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D, 4, SignalColor.Green, 4);
		CS_0024_003C_003E8__locals213._0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D[9] = 2;
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D, 9, SignalColor.Yellow, 4);
		CS_0024_003C_003E8__locals213._0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D[17] = 1;
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D, 17, SignalColor.Green, 4);
		CS_0024_003C_003E8__locals213._0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D[22] = 2;
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D, 22, SignalColor.Yellow, 4);
		CS_0024_003C_003E8__locals213._0023_003DqUhUFFXfK6rR6v1wKTSVRXQ_003D_003D[27] = 1;
		_0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D(CS_0024_003C_003E8__locals213._0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D, 27, SignalColor.Green, 4);
		_0023_003Dq97lANSbKi72_tsxQMhwIAA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818246)), CS_0024_003C_003E8__locals213._0023_003DqidqjAtgnAhlktAvBN27GVmw5gjjc6AaPtUVaP63Aotk_003D);
		_0023_003Dq97lANSbKi72_tsxQMhwIAA_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818288)), CS_0024_003C_003E8__locals213._0023_003DqSxFZnAu3seuv0qoIF4lesA8pDwznkw8H462_uzfjEhA_003D);
		_0023_003Dq97lANSbKi72_tsxQMhwIAA_003D_003D._0023_003DqEFirVNkx3JuxR0x_0024gX6vpA_003D_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818295)), CS_0024_003C_003E8__locals213._0023_003DqXPHW4pwngtEV_0AyIqV1QkWjo6RmlK5uQpanuCXPpkw_003D);
		_0023_003Dq97lANSbKi72_tsxQMhwIAA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802769)), (int _0023_003DqVRpGaMqM2dGT33Ua_01Tsg_003D_003D) => CS_0024_003C_003E8__locals213._0023_003DqInDdoEMpXWpIt3RTye_0024QmQ_003D_003D[_0023_003DqVRpGaMqM2dGT33Ua_01Tsg_003D_003D]);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 21;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818329));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818342));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818380));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065817628)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065817805));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 26;
		puzzle._0023_003DqeNXlPBUDRKq13nkfZUBhsg_003D_003D = new ToolType[1] { ToolType._0023_003DqQTgv9Qs5rnLQcexdpSth3g_003D_003D };
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqX4UjGrQzxXjeYrSfqfoJWw_003D_003D };
		puzzle._0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[2]
		{
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818050)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818067)) },
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819212)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqrKdaFDw1jchVbzXkkGGuTQ_003D_003D,
				_0023_003DqcRF_0024zuZJx85lqzA3gCpj6Q_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqSlrwiwXqSRYgxxZ88t9h_0024g_003D_003D,
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[1] { 3 }
			},
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819274)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[4]
				{
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819285)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819368)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819461)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819564))
				},
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819635)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = new _0023_003Dqg4CEAupkpBKGYlSDmv7SftM3ictqeO4lHz7HSif2vkQ_003D(_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqVjVyYKl4HVwh0xSj38FVsQ_003D_003D),
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[2] { 7, 8 }
			}
		};
		_0023_003Dq5qWnAI5IPbaTyKddh3NHHw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqaVBWQ1MdfGPGI_0024XyU_409uP4Gx9MFhmKeFfsY25jYNM_003D CS_0024_003C_003E8__locals214 = new _0023_003DqaVBWQ1MdfGPGI_0024XyU_409uP4Gx9MFhmKeFfsY25jYNM_003D();
		ReliableRandom reliableRandom5 = _0023_003Dq5qWnAI5IPbaTyKddh3NHHw_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(1);
		CS_0024_003C_003E8__locals214._0023_003DqT5hH5foLZyiO_udCQ3aeeA_003D_003D = new List<int>();
		while (CS_0024_003C_003E8__locals214._0023_003DqT5hH5foLZyiO_udCQ3aeeA_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			CS_0024_003C_003E8__locals214._0023_003DqT5hH5foLZyiO_udCQ3aeeA_003D_003D.Add(reliableRandom5._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(0, 3));
		}
		_0023_003Dq5qWnAI5IPbaTyKddh3NHHw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818705)), CS_0024_003C_003E8__locals214._0023_003DqR5ltZ59fLvi8Fpg2PeyjsNOY9n2dHitRfTh2jQasEwg_003D);
		_0023_003Dq5qWnAI5IPbaTyKddh3NHHw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065820180)), CS_0024_003C_003E8__locals214._0023_003DqVbaJV31t5_IAm8pOqT3567Sd7gr_7c4Q7LfZA6U1wp8_003D);
		_0023_003Dq5qWnAI5IPbaTyKddh3NHHw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818747)), (int _0023_003DqbwEu4mSNLtzEzSWWvchaGA_003D_003D) => (CS_0024_003C_003E8__locals214._0023_003DqT5hH5foLZyiO_udCQ3aeeA_003D_003D[_0023_003DqbwEu4mSNLtzEzSWWvchaGA_003D_003D] != 0) ? SignalColor.Yellow : SignalColor.None);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 22;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818783));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818795));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065818830));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065819101)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816164));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 11;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqbBCr6AGmuKKlmwJN9Axf4Q_003D_003D };
		_0023_003Dq6znUOQDiH_8UVPxIm3iCQw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003Dq6znUOQDiH_8UVPxIm3iCQw_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(6, SignalColor.Green);
		_0023_003Dq6znUOQDiH_8UVPxIm3iCQw_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(4, SignalColor.Red);
		_0023_003Dq6znUOQDiH_8UVPxIm3iCQw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816361)), _003C_003Ec._003C_003E9._0023_003DqyzNvHLcCutXHFeDbo4UaVh7SDfhvSDaOjgUktovrqRk_003D);
		_0023_003Dq6znUOQDiH_8UVPxIm3iCQw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816398)), _003C_003Ec._003C_003E9._0023_003DqglD8JDcWMwjjt11C72uoshWzNOEImHsrLs1eXGrcaxM_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 23;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816402));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816423));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816456));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815726)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815803));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 7;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003Dqz06_0024YtyTGWeqK_3Fv_0024v8zw_003D_003D,
			ToolType._0023_003DqLofx9oxbuA0d3i0H0suc1A_003D_003D
		};
		_0023_003Dqa0Vxc5yXAxRg6QbmQg3_Gw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqkdVKtQOcW9dFO2d1vuW4nFDRNKYtqK_1Te6_GvX_26o_003D CS_0024_003C_003E8__locals220 = new _0023_003DqkdVKtQOcW9dFO2d1vuW4nFDRNKYtqK_1Te6_GvX_26o_003D();
		_0023_003Dqa0Vxc5yXAxRg6QbmQg3_Gw_003D_003D._0023_003DqIZihr1d7YHUMWpc__c7Ihg_003D_003D(108);
		CS_0024_003C_003E8__locals220._0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D = _0023_003Dqa0Vxc5yXAxRg6QbmQg3_Gw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815899)), (int _0023_003Dqv_0024nLbPeHlcA38ONczZLO2Q_003D_003D, ReliableRandom _0023_003Dqw04Ov6hOAnPCIevYdEM4JA_003D_003D) => _0023_003Dqw04Ov6hOAnPCIevYdEM4JA_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
		{
			SignalColor.Yellow,
			SignalColor.Green,
			SignalColor.Red
		}));
		CS_0024_003C_003E8__locals220._0023_003Dqxp1_0024T7D6QD2FY7yIbAFK8A_003D_003D = _0023_003Dqa0Vxc5yXAxRg6QbmQg3_Gw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815934)), (int _0023_003DqIOAjXylH6u_0024mMe3_EdbieA_003D_003D, ReliableRandom _0023_003DqP4Bmgt1XoGjzIgmzOEbBdg_003D_003D) => _0023_003DqP4Bmgt1XoGjzIgmzOEbBdg_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
		{
			SignalColor.Yellow,
			SignalColor.Green,
			SignalColor.Red
		}));
		_0023_003Dqa0Vxc5yXAxRg6QbmQg3_Gw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815899)), (int _0023_003DqQGGGgDFznbBadFwPtH2jUQ_003D_003D) => (CS_0024_003C_003E8__locals220._0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D[_0023_003DqQGGGgDFznbBadFwPtH2jUQ_003D_003D] == CS_0024_003C_003E8__locals220._0023_003Dqxp1_0024T7D6QD2FY7yIbAFK8A_003D_003D[_0023_003DqQGGGgDFznbBadFwPtH2jUQ_003D_003D]) ? CS_0024_003C_003E8__locals220._0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D[_0023_003DqQGGGgDFznbBadFwPtH2jUQ_003D_003D] : SignalColor.None);
		_0023_003Dqa0Vxc5yXAxRg6QbmQg3_Gw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815934)), (int _0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D) => (CS_0024_003C_003E8__locals220._0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D[_0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D] == CS_0024_003C_003E8__locals220._0023_003Dqxp1_0024T7D6QD2FY7yIbAFK8A_003D_003D[_0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D]) ? CS_0024_003C_003E8__locals220._0023_003DqizLFT812JW2lA6RxF7bW4Q_003D_003D[_0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D] : SignalColor.None);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 24;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815943));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815959));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815985));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065817281)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065817498));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 23;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003DqLofx9oxbuA0d3i0H0suc1A_003D_003D,
			ToolType._0023_003DqSMgKIA_0024eogmgvqG3eVqCVA_003D_003D
		};
		_0023_003DqPNkorwKJdWUwGOXnBy8csw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqJURZj4Mud24qs96Z7b3bhblS6PuWnQslWSSts_hE2J8_003D CS_0024_003C_003E8__locals222 = new _0023_003DqJURZj4Mud24qs96Z7b3bhblS6PuWnQslWSSts_hE2J8_003D();
		ReliableRandom reliableRandom6 = _0023_003DqPNkorwKJdWUwGOXnBy8csw_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(3);
		CS_0024_003C_003E8__locals222._0023_003DqtaPernHfKBXs_0024yp7nLDCPA_003D_003D = new List<int>();
		while (CS_0024_003C_003E8__locals222._0023_003DqtaPernHfKBXs_0024yp7nLDCPA_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			CS_0024_003C_003E8__locals222._0023_003DqtaPernHfKBXs_0024yp7nLDCPA_003D_003D.Add(reliableRandom6._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(-2, 3));
		}
		_0023_003DqPNkorwKJdWUwGOXnBy8csw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816710)), (int _0023_003DqJxog5jlMg84SmDD3EXPGZg_003D_003D, ReliableRandom _0023_003DqbZQIGoV5d3TjsfrT3pLQUw_003D_003D) => (CS_0024_003C_003E8__locals222._0023_003DqtaPernHfKBXs_0024yp7nLDCPA_003D_003D[_0023_003DqJxog5jlMg84SmDD3EXPGZg_003D_003D] != 1) ? SignalColor.Green : SignalColor.Red);
		_0023_003DqPNkorwKJdWUwGOXnBy8csw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816749)), (int _0023_003Dq4euo2bUsshlSQvYv69Ae2g_003D_003D, ReliableRandom _0023_003Dq3QUuC_00247hEGWs7XcmsSYcKw_003D_003D) => (CS_0024_003C_003E8__locals222._0023_003DqtaPernHfKBXs_0024yp7nLDCPA_003D_003D[_0023_003Dq4euo2bUsshlSQvYv69Ae2g_003D_003D] != 2) ? SignalColor.Green : SignalColor.Red);
		_0023_003DqPNkorwKJdWUwGOXnBy8csw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816710)), (int _0023_003DqZHkL5NzlA7DPg_YgVhMTew_003D_003D) => SignalColor.Green);
		_0023_003DqPNkorwKJdWUwGOXnBy8csw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816749)), (int _0023_003DqpBfcA5kLP0ohKrpvT4Dt_0024A_003D_003D) => SignalColor.Green);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 25;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816754));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816769));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065816830));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814028)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814211));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 3;
		puzzle._0023_003DqeNXlPBUDRKq13nkfZUBhsg_003D_003D = new ToolType[1] { ToolType._0023_003DqQTgv9Qs5rnLQcexdpSth3g_003D_003D };
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003Dqz06_0024YtyTGWeqK_3Fv_0024v8zw_003D_003D,
			ToolType._0023_003DqLofx9oxbuA0d3i0H0suc1A_003D_003D
		};
		puzzle._0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[1]
		{
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814487)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814499)) },
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813578)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqxivVYM4L5nz7ZU1_OUfZ1w_003D_003D,
				_0023_003DqcRF_0024zuZJx85lqzA3gCpj6Q_003D_003D = _0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dq9JHsAF_Reqr5lEd8u_0024MZBg_003D_003D,
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[2] { 5, 6 }
			}
		};
		_0023_003DqAVraF4j1wO7CnFuxIpPyDg_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003Dqmjia69CA_j_0024Pd1hrUKUTcIoH44ApDBoyDC9Nk3R8QYA_003D CS_0024_003C_003E8__locals223 = new _0023_003Dqmjia69CA_j_0024Pd1hrUKUTcIoH44ApDBoyDC9Nk3R8QYA_003D();
		CS_0024_003C_003E8__locals223._0023_003DqMYnq4SJ8Jv6Q_SZsjCQ_vg_003D_003D = _0023_003DqAVraF4j1wO7CnFuxIpPyDg_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813665)), (int _0023_003Dq9BTmNEEqFqRHRA8TBQrM8g_003D_003D, ReliableRandom _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D) => _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003DqOm5sVTeTncr1YFzf7muPCw_003D_003D(new SignalColor[3]
		{
			SignalColor.Red,
			SignalColor.Green,
			SignalColor.Yellow
		}));
		_0023_003DqAVraF4j1wO7CnFuxIpPyDg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(5, SignalColor.Green);
		_0023_003DqAVraF4j1wO7CnFuxIpPyDg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(4, SignalColor.Red);
		_0023_003DqAVraF4j1wO7CnFuxIpPyDg_003D_003D._0023_003Dqiv0zNOGTq0wC282Ef05wEQCtG7SF9scaMC3WRj8pEek_003D(3, SignalColor.Yellow);
		_0023_003DqAVraF4j1wO7CnFuxIpPyDg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813665)), CS_0024_003C_003E8__locals223._0023_003DqsEsZvoUtO8uzoMWPLnnybpQ_4RSneTk_pNor9BBSWdc_003D);
		_0023_003DqAVraF4j1wO7CnFuxIpPyDg_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813722)), (int _0023_003DqTBYZb1xmHAQuivPB0CFlpg_003D_003D) => CS_0024_003C_003E8__locals223._0023_003DqMYnq4SJ8Jv6Q_SZsjCQ_vg_003D_003D[_0023_003DqTBYZb1xmHAQuivPB0CFlpg_003D_003D]);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 26;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813731));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813747));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813780));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815083)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815256));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 9;
		puzzle._0023_003DqeNXlPBUDRKq13nkfZUBhsg_003D_003D = new ToolType[4]
		{
			ToolType._0023_003DqG2DLIeApvSabdP4rh6b2kw_003D_003D,
			ToolType._0023_003DqQTgv9Qs5rnLQcexdpSth3g_003D_003D,
			ToolType._0023_003DqhVVvKO99dgHTdrj3Tn61AQ_003D_003D,
			ToolType._0023_003Dqwl1JFFS0HzZoFeHVYvqmdw_003D_003D
		};
		puzzle._0023_003DqrEihGKXTCN_0024M2vJhVUFbug_003D_003D = new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D[2]
		{
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815522)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[3]
				{
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814537)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814629)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814749))
				},
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814821)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = new _0023_003Dqg4CEAupkpBKGYlSDmv7SftM3ictqeO4lHz7HSif2vkQ_003D(_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dq1ja6DcyIiMuZZrqeIIxgCQ_003D_003D),
				_0023_003DqcRF_0024zuZJx85lqzA3gCpj6Q_003D_003D = new _0023_003Dqg4CEAupkpBKGYlSDmv7SftM3ictqeO4lHz7HSif2vkQ_003D(_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dq1XNo8EOxnVyHod8ttiZUyw_003D_003D),
				_0023_003DqRETrPfy9KwLuhl6slpC2L0c6p58iCBykAXuSe4_0024dnfE_003D = new Dictionary<Language, Texture>
				{
					{
						Language.Russian,
						_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003DqBepLBlW3tJXPB5v9SD6Waw_003D_003D
					},
					{
						Language.ChineseSimplified,
						_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dq3Q8d0CCrPYzZP42xPDA3Og_003D_003D
					}
				}
			},
			new _0023_003Dqhxw6eZIM9wRHQW46wPorEg_003D_003D
			{
				_0023_003DqnmhSN0aoHZIVemuSAWtRmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814908)),
				_0023_003DqoBTgnlnwhmJKOEmDhydAcQ_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[3]
				{
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065814928)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065815000)),
					_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812042))
				},
				_0023_003Dqu2yd76l2vXRr144sVPoXmQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812088)),
				_0023_003DqXZ55ZB6iJEdY06cE0P_XCA_003D_003D = new _0023_003Dqg4CEAupkpBKGYlSDmv7SftM3ictqeO4lHz7HSif2vkQ_003D(_0023_003DqIXrFw8GnIzdAlFiESIGM8Q_003D_003D._0023_003DqBI_00248eYM_0024T62qZ_hSEapEaQ_003D_003D()._0023_003Dq0k9FSNJGxTek3avTOnmdcw_003D_003D._0023_003Dqbb5vBtGD1MFVubLPkUK9ZA_003D_003D),
				_0023_003DqQK17mPl066ZwLeEbbfgmcFyXmQEdRiOVgQP0lg2koj4_003D = new int[1]
			}
		};
		_0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqW8Ya_3slUaCuu22so_vqbbfB0aCoLABLpW9LDdf4Jfk_003D CS_0024_003C_003E8__locals225 = new _0023_003DqW8Ya_3slUaCuu22so_vqbbfB0aCoLABLpW9LDdf4Jfk_003D();
		_0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D._0023_003DqIZihr1d7YHUMWpc__c7Ihg_003D_003D(42);
		CS_0024_003C_003E8__locals225._0023_003DqAE9tP6JSuh_0024WDkQ0sfXTAQ_003D_003D = _0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812160)), (int _0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D, ReliableRandom _0023_003DqGqHrLIPpzkY7jO6P5MeM4w_003D_003D) => (_0023_003DqGqHrLIPpzkY7jO6P5MeM4w_003D_003D._0023_003DqAP2WU1Hze0rcoK0jMxcS5Q_003D_003D(0.9f) || _0023_003DqJvMY_nhYjel6VpOJfTUNGQ_003D_003D == 0) ? SignalColor.Green : SignalColor.None);
		CS_0024_003C_003E8__locals225._0023_003DqnS66Wbf7eYVc2tNN_0024ehwXw_003D_003D = _0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812162)), _003C_003Ec._003C_003E9._0023_003DqCAiWVsrYUlVKEgRJPzhUbpYm9GRyW0LyOcPtIYrcnqw_003D);
		CS_0024_003C_003E8__locals225._0023_003DqtFolNnVazIY_OCBOJk13Pw_003D_003D = _0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812203)), _003C_003Ec._003C_003E9._0023_003Dq6aU3VUJWjAz9TRxoMUDfko_0zEoMHOv3u8iLvlxcZIE_003D);
		_0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812160)), (int _0023_003DqF2nYr5pxx03B0NNzHBQk9A_003D_003D) => CS_0024_003C_003E8__locals225._0023_003DqtFolNnVazIY_OCBOJk13Pw_003D_003D[_0023_003DqF2nYr5pxx03B0NNzHBQk9A_003D_003D]);
		_0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812162)), (int _0023_003Dqc4JhZ06fEBAQ092lya_2Rw_003D_003D) => CS_0024_003C_003E8__locals225._0023_003DqAE9tP6JSuh_0024WDkQ0sfXTAQ_003D_003D[_0023_003Dqc4JhZ06fEBAQ092lya_2Rw_003D_003D]);
		_0023_003DqvkTDRIEJiFkPNZJrq3ubOA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812203)), CS_0024_003C_003E8__locals225._0023_003DqqyPMxbkq2laiXfqOatv0tUoWF_WI942ihxYQDAAF2UI_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 27;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812237));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812227));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812258));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811603)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811736));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 6;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D };
		puzzle._0023_003DqUMhyzZTfZj5H5jt9ZtYZb6hVYe0Kgd0MVcSSy_VuK8Y_003D = true;
		_0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		ReliableRandom _0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D3 = _0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(159);
		for (int num13 = 0; num13 < 4; num13++)
		{
			_0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D _0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D2 = new _0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D();
			_0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D2._0023_003DqF3P12g5d2GMdi55TbYqrbw_003D_003D = new List<bool>();
			_0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D2._0023_003DqF3P12g5d2GMdi55TbYqrbw_003D_003D.AddRange(Enumerable.Repeat(element: true, 12));
			_0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D2._0023_003DqF3P12g5d2GMdi55TbYqrbw_003D_003D.AddRange(Enumerable.Repeat(element: false, 8));
			Utility._0023_003Dq_0024nGY_9C6ahFCtVXoNp4K1w_003D_003D(_0023_003DqDrgVqmP9rADrqoppMDhczg_003D_003D3, _0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D2._0023_003DqF3P12g5d2GMdi55TbYqrbw_003D_003D);
			_0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D2._0023_003DqF3P12g5d2GMdi55TbYqrbw_003D_003D.AddRange(Enumerable.Repeat(element: false, 12));
			_0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(8 - num13 * 2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811783)), _0023_003DqGpbmEAKCLjPt32FzrOzi73RBZVg0TjESurXKGV8Fhzk_003D2._0023_003DqpWELsCqbVSUro56Nr2yQwm0VYL5rooSmxTvM_b5B09Q_003D);
		}
		_0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(8, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811783)), _003C_003Ec._003C_003E9._0023_003DqAJ_7iGlqz4RseW8h9auHHgwCCQOWSB4awgV77huyglw_003D);
		_0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811783)), (int _0023_003Dq9VKccAOlCUpCLrjgjEhMKg_003D_003D) => (_0023_003Dq9VKccAOlCUpCLrjgjEhMKg_003D_003D >= 20) ? SignalColor.Yellow : SignalColor.None);
		_0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811783)), _003C_003Ec._003C_003E9._0023_003Dq6bttfJlw2dw1EtZyzVBErmbsT604FTFh78MM1VOvsSU_003D);
		_0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811783)), (int _0023_003DqNIH3BZwrra_1WTPm2X_Gwg_003D_003D) => (_0023_003DqNIH3BZwrra_1WTPm2X_Gwg_003D_003D >= 20) ? SignalColor.Yellow : SignalColor.None);
		_0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D._0023_003Dq7VqQbmCfEU7p2GDEfYZ77QdravVae29rGrgHxoYZ6E8_003D = true;
		_0023_003DqlHHpJgZjJuyDPus47YGtGA_003D_003D._0023_003DqDQLvv_0024pMq_0024sbNzfiBa4WjJokFBdnwIwjGyzfnFXUHwU_003D = true;
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 28;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811820));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811834));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811871));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[2]
		{
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813138)),
			_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813207))
		};
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813307));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 2;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003DqdYuzkBR6b9PKqpKL44tcyQ_003D_003D,
			ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D
		};
		_0023_003DqahCULQLqG8J2RhUjeYqu2A_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqmB72mIDDyySP5Crp6Y_DxSjQNzRuzUO5po_0024uP3EQCa0_003D CS_0024_003C_003E8__locals229 = new _0023_003DqmB72mIDDyySP5Crp6Y_DxSjQNzRuzUO5po_0024uP3EQCa0_003D();
		CS_0024_003C_003E8__locals229._0023_003Dq8orPLkACGdWXKCLe3MeRbQ_003D_003D = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		CS_0024_003C_003E8__locals229._0023_003Dqefe95ST4hWq8DCSEW7iX8g_003D_003D = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		CS_0024_003C_003E8__locals229._0023_003Dqe7qc0_00242DFjFD6Ze6l0L9AA_003D_003D = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		CS_0024_003C_003E8__locals229._0023_003DqbBRYci64V36SFA_NI1YkIw_003D_003D = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		CS_0024_003C_003E8__locals229._0023_003DqheNbq_0024_0024nlantY5XWpfe6MA_003D_003D = new SignalColor[_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D];
		CS_0024_003C_003E8__locals229._0023_003Dq21cQ0TvmuA6NO0Vsg_C_0024VA_003D_003D = _0023_003DqahCULQLqG8J2RhUjeYqu2A_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(0);
		CS_0024_003C_003E8__locals229._0023_003DqZEOXbDo6t5TGlKJfAlJ8pUFq9y5tr1XWsmkLPSbWsKY_003D(4);
		CS_0024_003C_003E8__locals229._0023_003DqZEOXbDo6t5TGlKJfAlJ8pUFq9y5tr1XWsmkLPSbWsKY_003D(9);
		CS_0024_003C_003E8__locals229._0023_003DqZEOXbDo6t5TGlKJfAlJ8pUFq9y5tr1XWsmkLPSbWsKY_003D(14);
		CS_0024_003C_003E8__locals229._0023_003DqZEOXbDo6t5TGlKJfAlJ8pUFq9y5tr1XWsmkLPSbWsKY_003D(20);
		CS_0024_003C_003E8__locals229._0023_003DqZEOXbDo6t5TGlKJfAlJ8pUFq9y5tr1XWsmkLPSbWsKY_003D(25);
		CS_0024_003C_003E8__locals229._0023_003DqZEOXbDo6t5TGlKJfAlJ8pUFq9y5tr1XWsmkLPSbWsKY_003D(30);
		_0023_003DqahCULQLqG8J2RhUjeYqu2A_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065802812)), (int _0023_003DqyfG_00244LeHFYjaA1s4EP_00249EQ_003D_003D, ReliableRandom _0023_003DqWyHhFLoxuRChkM7MaH77Nw_003D_003D) => CS_0024_003C_003E8__locals229._0023_003DqheNbq_0024_0024nlantY5XWpfe6MA_003D_003D[_0023_003DqyfG_00244LeHFYjaA1s4EP_00249EQ_003D_003D]);
		_0023_003DqahCULQLqG8J2RhUjeYqu2A_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(8, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813370)), CS_0024_003C_003E8__locals229._0023_003Dq70vASntFuDpRXa3HtvzukVdJZjrGAyQhbt4qJAQyKDc_003D);
		_0023_003DqahCULQLqG8J2RhUjeYqu2A_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813378)), (int _0023_003Dqtwid9TTv1HWste3gB9yG6w_003D_003D) => CS_0024_003C_003E8__locals229._0023_003Dqefe95ST4hWq8DCSEW7iX8g_003D_003D[_0023_003Dqtwid9TTv1HWste3gB9yG6w_003D_003D]);
		_0023_003DqahCULQLqG8J2RhUjeYqu2A_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813417)), (int _0023_003Dq8upB7gb726iaUnkyq8SX7A_003D_003D) => CS_0024_003C_003E8__locals229._0023_003Dqe7qc0_00242DFjFD6Ze6l0L9AA_003D_003D[_0023_003Dq8upB7gb726iaUnkyq8SX7A_003D_003D]);
		_0023_003DqahCULQLqG8J2RhUjeYqu2A_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813427)), (int _0023_003DqWQl2C8y_0024FDvbj55VUPu2cQ_003D_003D) => CS_0024_003C_003E8__locals229._0023_003DqbBRYci64V36SFA_NI1YkIw_003D_003D[_0023_003DqWQl2C8y_0024FDvbj55VUPu2cQ_003D_003D]);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 29;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811820));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813462));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065813501));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812766)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065812949));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 1;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[1] { ToolType._0023_003DqSMgKIA_0024eogmgvqG3eVqCVA_003D_003D };
		puzzle._0023_003DqUMhyzZTfZj5H5jt9ZtYZb6hVYe0Kgd0MVcSSy_VuK8Y_003D = true;
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqU7Vug_zikS_Qs4WoW3dnFQYT_0024fb44JYRx2F7HuWcOPA_003D CS_0024_003C_003E8__locals235 = new _0023_003DqU7Vug_zikS_Qs4WoW3dnFQYT_0024fb44JYRx2F7HuWcOPA_003D();
		ReliableRandom reliableRandom7 = _0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(0);
		CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D = new List<int>();
		while (CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D.Add(reliableRandom7._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(0, 7));
		}
		CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[1] = 0;
		CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[5] = 2;
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(8, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809936)), CS_0024_003C_003E8__locals235._0023_003DqyE8IeeIPN6nxXQQuNP2pPUVPIWRRkSabvOV6vJNVidU_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809941)), (int _0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D, ReliableRandom _0023_003DqWyHhFLoxuRChkM7MaH77Nw_003D_003D) => (CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dq_qNdIr_0024foPIDz9THYnOn_w_003D_003D] == 1) ? SignalColor.Green : SignalColor.None);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809982)), (int _0023_003DqHjyMxQEa8G8gbN_0024SSRLJ4g_003D_003D, ReliableRandom _0023_003Dq_gvD2HmF8yFKNDQeMOEKRQ_003D_003D) => (CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqHjyMxQEa8G8gbN_0024SSRLJ4g_003D_003D] == 2) ? SignalColor.Green : SignalColor.None);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809995)), (int _0023_003DqK7__0024VzLO9ciAtH2wJBXE5w_003D_003D, ReliableRandom _0023_003DqRg7OgiSWc4WLNZuXF7YkAg_003D_003D) => (CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqK7__0024VzLO9ciAtH2wJBXE5w_003D_003D] == 3) ? SignalColor.Green : SignalColor.None);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810004)), CS_0024_003C_003E8__locals235._0023_003DqACKHxX6q1FUKZ5ZLNMAITHkLBYPjhxf0c4vPmGcGJVQ_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810041)), CS_0024_003C_003E8__locals235._0023_003Dq55Vd0dDj38g6TNHgT9O7HLsCdXkLTxR1HCxqxU7BLJ4_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810050)), CS_0024_003C_003E8__locals235._0023_003DqWfeEGlZWZaoT89uLJmeODTmCFZCvDnNi90sZ5R9xqy4_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqLDVamLlhVyitdxd3O4Zdwg_003D_003D()._0023_003DqSn0PAYg7NM9hn0eKTWsUUQ_003D_003D(_003C_003Ec._003C_003E9._0023_003Dqkpfwp2HWboYOnbC0tLUN013aoMIcpGujITBuE045xnE_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(100, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810096)), _003C_003Ec._003C_003E9._0023_003DqvcxbnMzTqQbdndAeOOJGhw8BXDOA4fMAjEdUHzkG8nE_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(8, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809936)), (int _0023_003DqAwc9pkGHJXWScOkTG6IGlw_003D_003D) => (CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqAwc9pkGHJXWScOkTG6IGlw_003D_003D] == 0) ? SignalColor.Red : SignalColor.None);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(7, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809941)), (int _0023_003DqOCmhRD27pOG2rKFpZq4gnQ_003D_003D) => (CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003DqOCmhRD27pOG2rKFpZq4gnQ_003D_003D] == 1) ? SignalColor.Red : SignalColor.None);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809982)), CS_0024_003C_003E8__locals235._0023_003DqtAyPJCF095K9CK1Pnol9RUuPWe1ql_AlzINEXce_HOg_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809995)), CS_0024_003C_003E8__locals235._0023_003DqILjXAsQYcUixPSG9_8gDaPBfptkJurs414xTEaCL6KA_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810004)), (int _0023_003Dqby58Lz1NpiT_Qbak593u0A_003D_003D) => (CS_0024_003C_003E8__locals235._0023_003DqlVkAQDVXmdvmt3uInrsxtw_003D_003D[_0023_003Dqby58Lz1NpiT_Qbak593u0A_003D_003D] == 4) ? SignalColor.Red : SignalColor.None);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(3, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810041)), CS_0024_003C_003E8__locals235._0023_003Dq0Gl_58YenbpvgZgAJWcRQgtNcGUPs_hy0RAKB__eGU0_003D);
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(2, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810050)), CS_0024_003C_003E8__locals235._0023_003DqWjVBjPxr9fMsC726cX38uDIz0R3dX0a9_UtoLeUvlxk_003D);
		puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = 30;
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810100));
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810114));
		puzzle._0023_003DqKt_Jz_YP0oYw1geJCoySeQ_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810152));
		puzzle._0023_003DqtCT0e0Qdn6MbbjMphn_KAw_003D_003D = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D[1] { _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809500)) };
		puzzle._0023_003Dq93HBdVuk2JuuWbsB3VD9Cg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809505));
		puzzle._0023_003Dq582dTCx6klS9JdX_0024i3YWDA_003D_003D = 0;
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = new ToolType[2]
		{
			ToolType._0023_003DqdYuzkBR6b9PKqpKL44tcyQ_003D_003D,
			ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D
		};
		_0023_003Dq40tlLCkW4vqF2Fin_00244icFw_003D_003D = ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: false);
		_0023_003DqrFQUDmm5E1tmh4bYAPmiQCN5slZv1RYo_5bTznL3E8E_003D CS_0024_003C_003E8__locals236 = new _0023_003DqrFQUDmm5E1tmh4bYAPmiQCN5slZv1RYo_5bTznL3E8E_003D();
		_0023_003DqVVllFs_75QVl_0024cnSYfsmqw_003D_003D._0023_003DqXyh4x24t5yI8yS83TiOK31_lcR6PgTB8V7IIUJaWvXg_003D(8);
		CS_0024_003C_003E8__locals236._0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D = new List<bool>();
		int[] array7 = new int[5] { 2, 4, 2, 3, 5 };
		foreach (int count2 in array7)
		{
			CS_0024_003C_003E8__locals236._0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D.Add(item: false);
			CS_0024_003C_003E8__locals236._0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D.Add(item: false);
			CS_0024_003C_003E8__locals236._0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D.AddRange(Enumerable.Repeat(element: true, count2));
			CS_0024_003C_003E8__locals236._0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D.Add(item: false);
		}
		while (CS_0024_003C_003E8__locals236._0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D.Count < _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
		{
			CS_0024_003C_003E8__locals236._0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D.Add(item: false);
		}
		_0023_003Dq40tlLCkW4vqF2Fin_00244icFw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(6, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809526)), (int _0023_003DqeAxKc4r3MB3Z7DBne2TW3A_003D_003D, ReliableRandom _0023_003Dqc3eJ5XW3kg8CXvyNAu1Mhg_003D_003D) => (_0023_003DqeAxKc4r3MB3Z7DBne2TW3A_003D_003D < 31 && CS_0024_003C_003E8__locals236._0023_003Dqrobp2_0024zJh1YlUHk2MSOCHg_003D_003D[_0023_003DqeAxKc4r3MB3Z7DBne2TW3A_003D_003D + 1]) ? SignalColor.Green : SignalColor.None);
		_0023_003Dq40tlLCkW4vqF2Fin_00244icFw_003D_003D._0023_003Dqk8qLYV3Lyjwj1WhIbIFnBiRp7KMSE4ouMa0_7tFvgBc_003D(4, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809568)), CS_0024_003C_003E8__locals236._0023_003DqBDlCzYjEAiazTqw9KpVpb1CMZuPu542n0lIlpkD5sGo_003D);
		_0023_003Dq40tlLCkW4vqF2Fin_00244icFw_003D_003D._0023_003DqwkST4dWsVVni7poXjfzkJAJvDHnZFkyDB198MHN4gYA_003D(5, _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065795471)), CS_0024_003C_003E8__locals236._0023_003DqB_YR8aZn4c7jOGnybnWCuwLID3LAEcTHqBBxvzwnxro_003D);
		_0023_003DqHifB_0024uZppkMVXMtifIY07A_003D_003D._0023_003DqUSzwBNmgRReaW5Q1iVtNlWCwBiNWxtP44OIp0K3kqHw_003D(_0023_003DqVSuA6NUAhjJpFAmCVOsncbF6ld4XXKj5ZrCS0x4ABkI_003D: false);
		ContentType<Puzzle>._0023_003DqxfV99pOoKxQjK_0fgdrgfsZ9DQtIKwdeH_p0wADPsh0_003D();
	}

	public static Puzzle _0023_003DqDskhplBB1Dyz_0024dBfudiaDc81E3B7zC0r4CE_0024HQ9W8iw_003D(string _0023_003Dqn94EMgFQ1k17nwUoUHKKmQ_003D_003D)
	{
		List<Tuple<string[], int>> list = new List<Tuple<string[], int>>();
		string[] array = File.ReadAllLines(_0023_003Dqn94EMgFQ1k17nwUoUHKKmQ_003D_003D);
		for (int i = 0; i < array.Length; i++)
		{
			string text = array[i].ToUpper().Trim();
			if (text.Length != 0 && !text.StartsWith(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809569)))
			{
				string[] array2 = text.Split(new char[1] { ',' }).Select(_003C_003Ec._003C_003E9._0023_003DqmQFnaVBzQBdCjGxu81FzPM813HE067jce6e7XcqnS3ZQWlCYR94fi68V0tZQBpFD).ToArray();
				if (array2.Length != 0)
				{
					list.Add(Tuple.Create(array2, i + 1));
				}
			}
		}
		Maybe<int> maybe = _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		Maybe<string> maybe2 = _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		Maybe<string> maybe3 = _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		List<SignalInfo> list2 = new List<SignalInfo>();
		List<ToolType> list3 = new List<ToolType>();
		_0023_003DqwXFoYYVv6aQ3i_00242Cgm7TOQhb414JQN9F7TxwKI0zEO8_003D _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D = default(_0023_003DqwXFoYYVv6aQ3i_00242Cgm7TOQhb414JQN9F7TxwKI0zEO8_003D);
		foreach (Tuple<string[], int> item2 in list)
		{
			string[] item = item2.Item1;
			_0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D._0023_003Dqy1I4JiRYl1QkaKP9sE80eA_003D_003D = item2.Item2;
			if (item[0] == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809593))
			{
				if (item.Length >= 2 && int.TryParse(item[1], out var result) && result >= 100)
				{
					maybe = result;
				}
				else
				{
					_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809588)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
				}
				continue;
			}
			if (item[0] == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809630))
			{
				if (item.Length >= 2 && item[1].Length > 0)
				{
					maybe2 = item[1];
				}
				else
				{
					_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809618)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
				}
				continue;
			}
			if (item[0] == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809661))
			{
				if (item.Length >= 2 && item[1].Length > 0)
				{
					maybe3 = item[1];
				}
				else
				{
					_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809678)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
				}
				continue;
			}
			if (item[0] == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809686) || item[0] == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809706))
			{
				_0023_003Dq1wZlSQGY8Lre1K0jr9CGEaI_WFExitTi68NBQJdg00E_003D CS_0024_003C_003E8__locals12 = new _0023_003Dq1wZlSQGY8Lre1K0jr9CGEaI_WFExitTi68NBQJdg00E_003D();
				if (item.Length < 4)
				{
					_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809725)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
				}
				if (item[1].Length == 0)
				{
					_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809736)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
				}
				CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D = new List<SignalColor>();
				bool flag = false;
				bool flag2 = false;
				string text2 = item[3];
				foreach (char c in text2)
				{
					if (!char.IsWhiteSpace(c))
					{
						switch (c)
						{
						case '.':
							CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D.Add(SignalColor.None);
							break;
						case 'G':
							CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D.Add(SignalColor.Green);
							flag = true;
							break;
						case 'R':
							CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D.Add(SignalColor.Red);
							flag = true;
							break;
						case 'Y':
							CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D.Add(SignalColor.Yellow);
							flag = true;
							break;
						case 'X':
							CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D.Add(SignalColor.Green);
							flag2 = true;
							break;
						default:
							_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(string.Format(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809748)), c), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
							break;
						}
					}
				}
				if (flag && flag2)
				{
					_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809777)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
				}
				if (CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D.Count != _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D)
				{
					_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(string.Format(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809816)), _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqEAwNhX4ptl2gRC2qqgP3Cw_003D_003D), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
				}
				if (!int.TryParse(item[2], out var result2) || result2 < 0 || (flag2 && result2 > 5) || (!flag2 && result2 > 10))
				{
					_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809842)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
				}
				_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqfSRknO6J2kskywdx9RciQg_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(item[1]);
				Maybe<SignalColor> _0023_003Dqhk6xC0zORB04pe5NfdL_nQ_003D_003D = _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
				bool flag3 = !flag2;
				bool flag4 = item[0] == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809686);
				if (flag3 && flag4 && CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D.All((SignalColor _0023_003DqqVKLgrH7NWh_KXwZZYg8aQ_003D_003D) => _0023_003DqqVKLgrH7NWh_KXwZZYg8aQ_003D_003D == CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D[0]))
				{
					_0023_003Dqhk6xC0zORB04pe5NfdL_nQ_003D_003D = CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D[0];
					_0023_003DqfSRknO6J2kskywdx9RciQg_003D_003D = CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D[0] switch
					{
						SignalColor.Green => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805431)), 
						SignalColor.Red => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805471)), 
						SignalColor.Yellow => _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805479)), 
						_ => throw new _0023_003DqP1Lvlriw8JdzHp67vrhOBYFwzXCcBrFvFv_m_d2KdZA_003D(), 
					};
				}
				list2.Add(new SignalInfo(_0023_003DqfSRknO6J2kskywdx9RciQg_003D_003D, (!flag3) ? _0023_003DqStl6T2a_0024yL8Zer_D1uC1tQ_003D_003D.Matrix : _0023_003DqStl6T2a_0024yL8Zer_D1uC1tQ_003D_003D.Pipeline, (!flag4) ? _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Output : _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Input, result2, CS_0024_003C_003E8__locals12._0023_003DqtTAHjAeeVXvWg9BoTBPq_g_003D_003D.ToArray(), _0023_003DqF78x6M5ui5lShuNSA5vA8w_003D_003D: false, _0023_003Dqhk6xC0zORB04pe5NfdL_nQ_003D_003D, _0023_003Dq4byLPjfeNrK273HGVZ6h9g_003D_003D: false));
				continue;
			}
			Maybe<ToolType> maybe4;
			if (item[0] == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809888))
			{
				maybe4 = _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
				if (item.Length >= 2)
				{
					string text2 = item[1];
					uint num = _0023_003DqoMbxSIjEUhnkFQLFSfnB_00243C1fZaMm_0024CZtY5z5Cl4ago_003D._0023_003Dq2iiSXB_0024AHdTZBEmDkzA4qR_9AyvzuVotkUqEEyjQ294_003D(text2);
					if (num <= 2211354620u)
					{
						if (num <= 2026172346)
						{
							if (num != 1589513528)
							{
								if (num != 2026172346 || !(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810953)))
								{
									goto IL_0767;
								}
								maybe4 = ToolType._0023_003Dqs5AOEPBlbXAuGCOWCZD3tA_003D_003D;
							}
							else
							{
								if (!(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809909)))
								{
									goto IL_0767;
								}
								maybe4 = ToolType._0023_003DqdYuzkBR6b9PKqpKL44tcyQ_003D_003D;
							}
						}
						else if (num != 2082182825)
						{
							if (num != 2211354620u || !(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810984)))
							{
								goto IL_0767;
							}
							maybe4 = ToolType._0023_003DqLofx9oxbuA0d3i0H0suc1A_003D_003D;
						}
						else
						{
							if (!(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811002)))
							{
								goto IL_0767;
							}
							maybe4 = ToolType._0023_003Dq5fivxgaWBrOIdKdC4Nwg_0024Q_003D_003D;
						}
					}
					else if (num <= 3557825546u)
					{
						if (num != 2875364188u)
						{
							if (num != 3557825546u || !(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809896)))
							{
								goto IL_0767;
							}
							maybe4 = ToolType._0023_003DqSMgKIA_0024eogmgvqG3eVqCVA_003D_003D;
						}
						else
						{
							if (!(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810964)))
							{
								goto IL_0767;
							}
							maybe4 = ToolType._0023_003Dqz06_0024YtyTGWeqK_3Fv_0024v8zw_003D_003D;
						}
					}
					else if (num != 3579508421u)
					{
						if (num != 3932906479u)
						{
							if (num != 4289874747u || !(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065809873)))
							{
								goto IL_0767;
							}
							maybe4 = ToolType._0023_003DqTHQnWatVw_BtQpx1UcHofw_003D_003D;
						}
						else
						{
							if (!(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811024)))
							{
								goto IL_0767;
							}
							maybe4 = ToolType._0023_003DqX4UjGrQzxXjeYrSfqfoJWw_003D_003D;
						}
					}
					else
					{
						if (!(text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065810973)))
						{
							goto IL_0767;
						}
						maybe4 = ToolType._0023_003DqbBCr6AGmuKKlmwJN9Axf4Q_003D_003D;
					}
				}
				goto IL_078b;
			}
			_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(string.Format(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811108)), item[0]), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
			continue;
			IL_0767:
			_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(string.Format(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811039)), item[1]), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
			goto IL_078b;
			IL_078b:
			if (!maybe4._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
			{
				_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811041)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
			}
			if (list3.Count == 2)
			{
				_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811085)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
			}
			if (list3.Contains(maybe4._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D()))
			{
				_0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811099)), ref _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D);
			}
			list3.Add(maybe4._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
		}
		if (!maybe._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			throw new _0023_003DqtPiOMvNhBE0MruqYIZHY1EGv4N2NbFIHZEUe0mzImzE_003D(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811143)));
		}
		if (!maybe2._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			throw new _0023_003DqtPiOMvNhBE0MruqYIZHY1EGv4N2NbFIHZEUe0mzImzE_003D(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811153)));
		}
		if (!maybe3._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			throw new _0023_003DqtPiOMvNhBE0MruqYIZHY1EGv4N2NbFIHZEUe0mzImzE_003D(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811200)));
		}
		if (!list2.Any((SignalInfo _0023_003DqD09KAxlTLi2R__0024migwxU5A_003D_003D) => _0023_003DqD09KAxlTLi2R__0024migwxU5A_003D_003D._0023_003Dqtk6F7s2ZLJZnx1voWcVmxQ_003D_003D == _0023_003DqhKW8j0JKbjrtk1B9IM1_4NV1B1DDQaK_0024PI7BhvxqWoo_003D.Input))
		{
			throw new _0023_003DqtPiOMvNhBE0MruqYIZHY1EGv4N2NbFIHZEUe0mzImzE_003D(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811208)));
		}
		if (!list2.Any(_003C_003Ec._003C_003E9._0023_003Dq8mLGmIx4MYLWLnveOPY2590wD5rIHLioTpfDki2c56qFnCMkXPutQ0TFu29PaHQu))
		{
			throw new _0023_003DqtPiOMvNhBE0MruqYIZHY1EGv4N2NbFIHZEUe0mzImzE_003D(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811262)));
		}
		for (int num2 = 0; num2 < list2.Count; num2++)
		{
			for (int num3 = num2 + 1; num3 < list2.Count; num3++)
			{
				SignalInfo signalInfo = list2[num2];
				SignalInfo signalInfo2 = list2[num3];
				if (signalInfo._0023_003DqdpdWBZew48Xcw7vSseWw_Q_003D_003D == signalInfo2._0023_003DqdpdWBZew48Xcw7vSseWw_Q_003D_003D && signalInfo._0023_003Dqtk6F7s2ZLJZnx1voWcVmxQ_003D_003D == signalInfo2._0023_003Dqtk6F7s2ZLJZnx1voWcVmxQ_003D_003D && signalInfo._0023_003DqtU8cwQsmhnnMiLxqFWWtZw_003D_003D == signalInfo2._0023_003DqtU8cwQsmhnnMiLxqFWWtZw_003D_003D)
				{
					throw new _0023_003DqtPiOMvNhBE0MruqYIZHY1EGv4N2NbFIHZEUe0mzImzE_003D(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811291)));
				}
			}
		}
		Puzzle puzzle = new Puzzle();
		puzzle._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D = maybe._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D();
		puzzle._0023_003Dq01FISqA19rc_ByG2EREhJw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(maybe2._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
		puzzle._0023_003DqACkjcMy25VrkMXfLODVIrw_003D_003D = _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(maybe3._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
		puzzle._0023_003DqkrP8n4Zmn2O91NoSRPoAvQ_003D_003D.AddRange(list2);
		puzzle._0023_003Dq_0024_0024v4OS5GH6ieTkKlQFdQKA_003D_003D = list3.ToArray();
		return ContentType<Puzzle>._0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(puzzle, _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D: true);
	}

	internal static void _0023_003DqiSeIfsI5zMjiffxzaM4Upq_CS7JylxiBIXxingprKu4_003D<T>(T[] _0023_003DqPlNWlpPlny6Tr72Pfi9gsg_003D_003D, int _0023_003DqaapEGP_VPBBuBZnMteFPNQ_003D_003D, T _0023_003Dq9YbCAhaLdX_00242zg2Nid6XqA_003D_003D, int _0023_003DqyXe2E7YPA7qob3xs8nz_0024yg_003D_003D)
	{
		for (int i = 0; i < _0023_003DqyXe2E7YPA7qob3xs8nz_0024yg_003D_003D; i++)
		{
			_0023_003DqPlNWlpPlny6Tr72Pfi9gsg_003D_003D[_0023_003DqaapEGP_VPBBuBZnMteFPNQ_003D_003D + i] = _0023_003Dq9YbCAhaLdX_00242zg2Nid6XqA_003D_003D;
		}
	}

	internal static void _0023_003DqQ9aqYX2GvK68B59ax_00248BMgEen0SRY7a0LhoHL5pJV5g5qdKGef4HkE6OBrxl6DHU(string _0023_003DqzuQZdF8K6hcLzN5oy8hE_Q_003D_003D, ref _0023_003DqwXFoYYVv6aQ3i_00242Cgm7TOQhb414JQN9F7TxwKI0zEO8_003D _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D)
	{
		throw new _0023_003DqtPiOMvNhBE0MruqYIZHY1EGv4N2NbFIHZEUe0mzImzE_003D(string.Format(_0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D._0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811341)), _0023_003DqzuQZdF8K6hcLzN5oy8hE_Q_003D_003D, _0023_003DqRPhtkkNN5KzbnyJF5BjLJw_003D_003D._0023_003Dqy1I4JiRYl1QkaKP9sE80eA_003D_003D));
	}
}
