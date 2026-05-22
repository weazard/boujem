using System;

public static class _0023_003DqdmtTy0R4ePem1dgy6BP5Pw_003D_003D
{
	public static int _0023_003DqZMN_UTOd3_MMCiFiUZBAdQ_003D_003D(byte[] _0023_003DqsEAUPja_lVjYXhTihpwXKQ_003D_003D, byte[] _0023_003Dq_IMTCiu1T_ZTAKk3F_0024EgOg_003D_003D)
	{
		int _0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D = 0;
		int num = 0;
		while (true)
		{
			byte b = _0023_003DqsEAUPja_lVjYXhTihpwXKQ_003D_003D[_0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D++];
			int num2 = (b >> 4) & 0xF;
			if (num2 == 15)
			{
				num2 += _0023_003DqJ9YDpH7ZN1QgoUAC2feVqg_003D_003D(_0023_003DqsEAUPja_lVjYXhTihpwXKQ_003D_003D, ref _0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D);
			}
			Array.Copy(_0023_003DqsEAUPja_lVjYXhTihpwXKQ_003D_003D, _0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D, _0023_003Dq_IMTCiu1T_ZTAKk3F_0024EgOg_003D_003D, num, num2);
			_0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D += num2;
			num += num2;
			if (_0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D == _0023_003DqsEAUPja_lVjYXhTihpwXKQ_003D_003D.Length)
			{
				break;
			}
			int num3 = _0023_003DqDwS5CpVawzysIBTr412HAw_003D_003D(_0023_003DqsEAUPja_lVjYXhTihpwXKQ_003D_003D, ref _0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D);
			int num4 = num - num3;
			int num5 = b & 0xF;
			if (num5 == 15)
			{
				num5 += _0023_003DqJ9YDpH7ZN1QgoUAC2feVqg_003D_003D(_0023_003DqsEAUPja_lVjYXhTihpwXKQ_003D_003D, ref _0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D);
			}
			num5 += 4;
			if (num3 >= num5)
			{
				Array.Copy(_0023_003Dq_IMTCiu1T_ZTAKk3F_0024EgOg_003D_003D, num4, _0023_003Dq_IMTCiu1T_ZTAKk3F_0024EgOg_003D_003D, num, num5);
			}
			else
			{
				_0023_003Dq_0024G84O_WbOPwrqpeGtMA6Kw_003D_003D(_0023_003Dq_IMTCiu1T_ZTAKk3F_0024EgOg_003D_003D, num4, num, num5);
			}
			num += num5;
		}
		return num;
	}

	private static int _0023_003DqJ9YDpH7ZN1QgoUAC2feVqg_003D_003D(byte[] _0023_003Dq2jSwkUhZ3IN1SBsLF_Z0DQ_003D_003D, ref int _0023_003DqrdTeMzvSJl4Gc61TkhHaBg_003D_003D)
	{
		int num = 0;
		byte b;
		do
		{
			b = _0023_003Dq2jSwkUhZ3IN1SBsLF_Z0DQ_003D_003D[_0023_003DqrdTeMzvSJl4Gc61TkhHaBg_003D_003D++];
			num += b;
		}
		while (b >= byte.MaxValue);
		return num;
	}

	private static int _0023_003DqDwS5CpVawzysIBTr412HAw_003D_003D(byte[] _0023_003Dq_SRXYi_0024hjiJv9d4Y_0024VnZKA_003D_003D, ref int _0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D)
	{
		byte b = _0023_003Dq_SRXYi_0024hjiJv9d4Y_0024VnZKA_003D_003D[_0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D++];
		return (_0023_003Dq_SRXYi_0024hjiJv9d4Y_0024VnZKA_003D_003D[_0023_003DqymuXA2SikBA4ZQKeCf_0024t_w_003D_003D++] << 8) | b;
	}

	private static void _0023_003Dq_0024G84O_WbOPwrqpeGtMA6Kw_003D_003D(byte[] _0023_003Dq7_0024KlxItj8UDRAkc5DaN1Ng_003D_003D, int _0023_003DqJc2TNDdEdFKlTz0x6mBmbw_003D_003D, int _0023_003Dqy5g50pFnZ3Gy8Orj3zgu_0024g_003D_003D, int _0023_003DqkdjUMBVKRmwdVc35SC090w_003D_003D)
	{
		for (int i = 0; i < _0023_003DqkdjUMBVKRmwdVc35SC090w_003D_003D; i++)
		{
			_0023_003Dq7_0024KlxItj8UDRAkc5DaN1Ng_003D_003D[_0023_003Dqy5g50pFnZ3Gy8Orj3zgu_0024g_003D_003D + i] = _0023_003Dq7_0024KlxItj8UDRAkc5DaN1Ng_003D_003D[_0023_003DqJc2TNDdEdFKlTz0x6mBmbw_003D_003D + i];
		}
	}
}
