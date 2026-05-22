using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

internal static class _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D
{
	private enum _000E_2000_2004_2004_2003_2007_2001_200A_2001_2006_2002_200B_2000_2009_2006_200B_2000_2002_2009_200B_2004_2009_2003_2005_2001_2005_2006_2001
	{

	}

	[DefaultMember("Item")]
	internal sealed class _0006_2005_2001_200B_2005_2008_2003_2001_2001_2008_200A_2003_2002_2002_200A_2003_2000_2007_2009_2001_2007_2001_2002
	{
		private struct _0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D
		{
			public int _0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D;

			public string _0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D;
		}

		private _0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D[] _0023_003DqL_BCuq6ipYe6p_7VMdMTM3IpZZO45PH2_npvM8rzJ9c_003D;

		private int _0023_003Dqetudg7dMPOU4d_eAdjcnpNjLrI6I2xNLKCT9z4EuhDI_003D;

		public _0006_2005_2001_200B_2005_2008_2003_2001_2001_2008_200A_2003_2002_2002_200A_2003_2000_2007_2009_2001_2007_2001_2002()
		{
			_0023_003DqL_BCuq6ipYe6p_7VMdMTM3IpZZO45PH2_npvM8rzJ9c_003D = new _0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D[16];
		}

		public _0006_2005_2001_200B_2005_2008_2003_2001_2001_2008_200A_2003_2002_2002_200A_2003_2000_2007_2009_2001_2007_2001_2002(int _0023_003Dqj4gsXrV2u_ohrfHGztDFT258U4QPqOX9tbinJqsFozk_003D)
		{
			int num = 16;
			_0023_003Dqj4gsXrV2u_ohrfHGztDFT258U4QPqOX9tbinJqsFozk_003D <<= 1;
			while (num < _0023_003Dqj4gsXrV2u_ohrfHGztDFT258U4QPqOX9tbinJqsFozk_003D && num > 0)
			{
				num <<= 1;
			}
			if (num < 0)
			{
				num = 16;
			}
			_0023_003DqL_BCuq6ipYe6p_7VMdMTM3IpZZO45PH2_npvM8rzJ9c_003D = new _0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D[num];
		}

		public int _0023_003DqLocSUPSkxctOD3yXV3BDeGmj8YaWv8lth2mjKiJanhU_003D()
		{
			return _0023_003Dqetudg7dMPOU4d_eAdjcnpNjLrI6I2xNLKCT9z4EuhDI_003D;
		}

		private void _0023_003DqTQl3htXVUG7PrRXQAY61HJx7qNir380z0GqirMwfz_00240_003D()
		{
			_0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D[] array = _0023_003DqL_BCuq6ipYe6p_7VMdMTM3IpZZO45PH2_npvM8rzJ9c_003D;
			int num = array.Length;
			int num2 = num * 2;
			if (num2 <= 0)
			{
				return;
			}
			_0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D[] array2 = new _0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D[num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				string _0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D = array[i]._0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D;
				if (_0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D == null)
				{
					continue;
				}
				int _0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D = array[i]._0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D;
				int num4 = _0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D & (num2 - 1);
				while (array2[num4]._0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D != null)
				{
					num4++;
					if (num4 >= num2)
					{
						num4 = 0;
					}
				}
				array2[num4]._0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D = _0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D;
				array2[num4]._0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D = _0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D;
				num3++;
			}
			_0023_003DqL_BCuq6ipYe6p_7VMdMTM3IpZZO45PH2_npvM8rzJ9c_003D = array2;
			_0023_003Dqetudg7dMPOU4d_eAdjcnpNjLrI6I2xNLKCT9z4EuhDI_003D = num3;
		}

		public string _0023_003DqezctZeOACk0w__0024nhmBSEFA_003D_003D(int _0023_003Dq9B3iOI7uKWukbxd5RJ1CnqG58oXvMKDzen1NjbFxSNA_003D)
		{
			_0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D[] array = _0023_003DqL_BCuq6ipYe6p_7VMdMTM3IpZZO45PH2_npvM8rzJ9c_003D;
			int num = array.Length;
			int num2 = _0023_003Dq9B3iOI7uKWukbxd5RJ1CnqG58oXvMKDzen1NjbFxSNA_003D & (num - 1);
			string result = null;
			while (true)
			{
				if (array[num2]._0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D == _0023_003Dq9B3iOI7uKWukbxd5RJ1CnqG58oXvMKDzen1NjbFxSNA_003D)
				{
					result = array[num2]._0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D;
					break;
				}
				if (array[num2]._0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D == null)
				{
					break;
				}
				num2++;
				if (num2 >= num)
				{
					num2 = 0;
				}
			}
			return result;
		}

		public void _0023_003DqkGjI4qBJDiP12xMxjjdHbQ_003D_003D(int _0023_003DqWf2Ewr6aBtbxg3SdyqQyLXphu7xmIaBg3V7XzbSibYU_003D, string _0023_003Dqy9bIM9S3ydnXwdEdHmUqyfB248ztq76gd1cWmvzBhx8_003D)
		{
			_0023_003Dq3qyLbmamKBClyQNO82xuEJG_x6dSbez5voURBNe5EFY_003D[] array = _0023_003DqL_BCuq6ipYe6p_7VMdMTM3IpZZO45PH2_npvM8rzJ9c_003D;
			int num = array.Length;
			int num2 = num >> 1;
			int num3 = _0023_003DqWf2Ewr6aBtbxg3SdyqQyLXphu7xmIaBg3V7XzbSibYU_003D & (num - 1);
			bool flag;
			while (true)
			{
				int _0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D = array[num3]._0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D;
				flag = array[num3]._0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D == null;
				if (_0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D == _0023_003DqWf2Ewr6aBtbxg3SdyqQyLXphu7xmIaBg3V7XzbSibYU_003D || flag)
				{
					break;
				}
				num3++;
				if (num3 >= num)
				{
					num3 = 0;
				}
			}
			array[num3]._0023_003DqYXcnPZh95D1KapQMc0KkDiXyBFkJ9lLoHYB_V25Ac78_003D = _0023_003Dqy9bIM9S3ydnXwdEdHmUqyfB248ztq76gd1cWmvzBhx8_003D;
			if (flag)
			{
				array[num3]._0023_003Dquq4t2CntKeeTGj4hiYDCAOI_0024sEf1sm774QdH1Hy5D_o_003D = _0023_003DqWf2Ewr6aBtbxg3SdyqQyLXphu7xmIaBg3V7XzbSibYU_003D;
				_0023_003Dqetudg7dMPOU4d_eAdjcnpNjLrI6I2xNLKCT9z4EuhDI_003D++;
				if (_0023_003Dqetudg7dMPOU4d_eAdjcnpNjLrI6I2xNLKCT9z4EuhDI_003D > num2)
				{
					_0023_003DqTQl3htXVUG7PrRXQAY61HJx7qNir380z0GqirMwfz_00240_003D();
				}
			}
		}
	}

	private sealed class _0002_2006_2001_2004_2002_2001_200A_200B_2003_200B_200A_2003_200A_2000_2005_2003_2008_2009_200B_200B_200B_2000_2004_2003_200B_2009_200A_2008_2009
	{
		private Stream _0023_003Dq_G0ZDtJ7Nevv8K0SOTJuZ5p2JmNCnhE7D1cIKzFNQfA_003D;

		private byte[] _0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D;

		public _0002_2006_2001_2004_2002_2001_200A_200B_2003_200B_200A_2003_200A_2000_2005_2003_2008_2009_200B_200B_200B_2000_2004_2003_200B_2009_200A_2008_2009(Stream _0023_003DqSCwfKtpWU3wmRSQdTQ7xlg_JQm3o80c0LtaET153_0024cE_003D)
		{
			_0023_003Dq_G0ZDtJ7Nevv8K0SOTJuZ5p2JmNCnhE7D1cIKzFNQfA_003D = _0023_003DqSCwfKtpWU3wmRSQdTQ7xlg_JQm3o80c0LtaET153_0024cE_003D;
			_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D = new byte[4];
		}

		public Stream _0023_003DqNw9Ic947H_0024UDRDkMFzNP4mdNk9kc16XhlesD_0024jU9g8U_003D()
		{
			return _0023_003Dq_G0ZDtJ7Nevv8K0SOTJuZ5p2JmNCnhE7D1cIKzFNQfA_003D;
		}

		public short _0023_003DqQh3e0_0024TX5zNwylmf_0024DAhCpkMvXcuBmJuXUOU9KzKURA_003D()
		{
			_0023_003Dqg8bjBJLnfe08_sl1AdXYXcmhXTDEKArygNmWJvKzeBY_003D(2);
			return (short)(_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D[0] | (_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D[1] << 8));
		}

		public int _0023_003Dqv27KByyHy_0024wmElRe6nCBpTNQKkd4vnQPefJjn71CFqc_003D()
		{
			_0023_003Dqg8bjBJLnfe08_sl1AdXYXcmhXTDEKArygNmWJvKzeBY_003D(4);
			return _0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D[0] | (_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D[1] << 8) | (_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D[2] << 16) | (_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D[3] << 24);
		}

		private void _0023_003DqrSrpnV3oygunT9gwud6aZrmdxzfiRkQ_3U1uLUN6w6s_003D()
		{
			throw new EndOfStreamException();
		}

		private void _0023_003Dqg8bjBJLnfe08_sl1AdXYXcmhXTDEKArygNmWJvKzeBY_003D(int _0023_003DqDZiXfeKdXkeYptO5EBP3mWBL5_0024AavEKhIXCrIj8rmc8_003D)
		{
			int num = 0;
			int num2 = 0;
			if (_0023_003DqDZiXfeKdXkeYptO5EBP3mWBL5_0024AavEKhIXCrIj8rmc8_003D == 1)
			{
				num2 = _0023_003Dq_G0ZDtJ7Nevv8K0SOTJuZ5p2JmNCnhE7D1cIKzFNQfA_003D.ReadByte();
				if (num2 == -1)
				{
					_0023_003DqrSrpnV3oygunT9gwud6aZrmdxzfiRkQ_3U1uLUN6w6s_003D();
				}
				_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = _0023_003Dq_G0ZDtJ7Nevv8K0SOTJuZ5p2JmNCnhE7D1cIKzFNQfA_003D.Read(_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D, num, _0023_003DqDZiXfeKdXkeYptO5EBP3mWBL5_0024AavEKhIXCrIj8rmc8_003D - num);
				if (num2 == 0)
				{
					_0023_003DqrSrpnV3oygunT9gwud6aZrmdxzfiRkQ_3U1uLUN6w6s_003D();
				}
				num += num2;
			}
			while (num < _0023_003DqDZiXfeKdXkeYptO5EBP3mWBL5_0024AavEKhIXCrIj8rmc8_003D);
		}

		public void _0023_003DqnjQgUNznNnMaCzdec0X0wB9P3YNP_0024CFcjLRV0sJKt20_003D()
		{
			Stream stream = _0023_003Dq_G0ZDtJ7Nevv8K0SOTJuZ5p2JmNCnhE7D1cIKzFNQfA_003D;
			_0023_003Dq_G0ZDtJ7Nevv8K0SOTJuZ5p2JmNCnhE7D1cIKzFNQfA_003D = null;
			stream?.Close();
			_0023_003DqpM9phcNAGdQFeO7QkkQiFgF7e_wwIn8bIvJnGHUCLF8_003D = null;
		}

		public byte[] _0023_003DqOg4HftqFPEw8VLaaw9DeWSCkVuX0KLXkk3NcTS_3PzM_003D(int _0023_003DqtClztGCiRvRjM3Wd9ptJM3zOeQm987xqGGPVo2OG7bI_003D)
		{
			if (_0023_003DqtClztGCiRvRjM3Wd9ptJM3zOeQm987xqGGPVo2OG7bI_003D < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[_0023_003DqtClztGCiRvRjM3Wd9ptJM3zOeQm987xqGGPVo2OG7bI_003D];
			int num = 0;
			do
			{
				int num2 = _0023_003Dq_G0ZDtJ7Nevv8K0SOTJuZ5p2JmNCnhE7D1cIKzFNQfA_003D.Read(array, num, _0023_003DqtClztGCiRvRjM3Wd9ptJM3zOeQm987xqGGPVo2OG7bI_003D);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				_0023_003DqtClztGCiRvRjM3Wd9ptJM3zOeQm987xqGGPVo2OG7bI_003D -= num2;
			}
			while (_0023_003DqtClztGCiRvRjM3Wd9ptJM3zOeQm987xqGGPVo2OG7bI_003D > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private static _0006_2005_2001_200B_2005_2008_2003_2001_2001_2008_200A_2003_2002_2002_200A_2003_2000_2007_2009_2001_2007_2001_2002 _0023_003DqVTw5faBUR2OiokEQKFI6pqsdwHYOENViCT4q_0024QajzXE_003D;

	private static _0002_2006_2001_2004_2002_2001_200A_200B_2003_200B_200A_2003_200A_2000_2005_2003_2008_2009_200B_200B_200B_2000_2004_2003_200B_2009_200A_2008_2009 _0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D;

	private static byte[] _0023_003Dqt_SYM3wt5rKJUWgHlOVd_vBUHOzxJb7nNK_0024HcJVFil8_003D;

	private static short _0023_003DqUHVV0DeFH4JN3sPAS2M0k0jzo1wdo2q_no4C_0024GK4Wlw_003D;

	private static int _0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D;

	private static byte[] _0023_003DqSEK1_pQy7tv4C0vq0w6OsC05_CPSOiKYW85pJqNDkh8_003D;

	private static int _0023_003DqpV0reRLMgb_00244mttRVZHsQictkBrZNFDnDkc8gTaQSSk_003D;

	private static int _0023_003DqN68aK_9LAaAh_z4vazCouMYJjKHc8QVCN9bdH1h8LGM_003D;

	private static _000E_2000_2004_2004_2003_2007_2001_200A_2001_2006_2002_200B_2000_2009_2006_200B_2000_2002_2009_200B_2004_2009_2003_2005_2001_2005_2006_2001 _0023_003DqEY7cH_UPZMIhDUdk4Q_4x7nhacgwBIFoqmVGy8hWoRQ_003D;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D()
	{
		int num = 1886404844;
		int num2 = -76056230 ^ num;
		_0023_003DqVTw5faBUR2OiokEQKFI6pqsdwHYOENViCT4q_0024QajzXE_003D = new _0006_2005_2001_200B_2005_2008_2003_2001_2001_2008_200A_2003_2002_2002_200A_2003_2000_2007_2009_2001_2007_2001_2002(-446099408 - num + num2);
		int num3 = 1;
		StackTrace stackTrace = new StackTrace(num3, fNeedFileInfo: false);
		num3--;
		StackFrame frame = stackTrace.GetFrame(num3);
		int num4 = -(~(-(~(~(-(-(~(~(-316467062 + num - num2))))))))) ^ ~(-(-(~(~(-(~(-(~(0x1632DB43 ^ num ^ num2)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= -(~(~(-(~(-(~(-(-(~(~(-390235488 - num - num2)))))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			_0023_003DqEY7cH_UPZMIhDUdk4Q_4x7nhacgwBIFoqmVGy8hWoRQ_003D = (_000E_2000_2004_2004_2003_2007_2001_200A_2001_2006_2002_200B_2000_2009_2006_200B_2000_2002_2009_200B_2004_2009_2003_2005_2001_2005_2006_2001)4 | _0023_003DqEY7cH_UPZMIhDUdk4Q_4x7nhacgwBIFoqmVGy8hWoRQ_003D;
			num4 ^= (0x488899D ^ num) + num2 + num3;
		}
		else if ((object)type == null)
		{
			num4 ^= ~(-(~(-(-(~(~(-(~((-446130211 - num) ^ num2)))))))));
			_0023_003DqEY7cH_UPZMIhDUdk4Q_4x7nhacgwBIFoqmVGy8hWoRQ_003D |= (_000E_2000_2004_2004_2003_2007_2001_200A_2001_2006_2002_200B_2000_2009_2006_200B_2000_2002_2009_200B_2004_2009_2003_2005_2001_2005_2006_2001)1;
		}
		else if ((object)type.Assembly != typeof(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D).Assembly)
		{
			_0023_003DqEY7cH_UPZMIhDUdk4Q_4x7nhacgwBIFoqmVGy8hWoRQ_003D = (_000E_2000_2004_2004_2003_2007_2001_200A_2001_2006_2002_200B_2000_2009_2006_200B_2000_2002_2009_200B_2004_2009_2003_2005_2001_2005_2006_2001)2 | _0023_003DqEY7cH_UPZMIhDUdk4Q_4x7nhacgwBIFoqmVGy8hWoRQ_003D;
			num4 ^= num + 800258119 + num2;
		}
		else
		{
			num4 ^= -(~(~(-(~(-(~(-(~((-446112613 - num) ^ num2))))))))) - num3;
			_0023_003DqEY7cH_UPZMIhDUdk4Q_4x7nhacgwBIFoqmVGy8hWoRQ_003D |= (_000E_2000_2004_2004_2003_2007_2001_200A_2001_2006_2002_200B_2000_2009_2006_200B_2000_2002_2009_200B_2004_2009_2003_2005_2001_2005_2006_2001)16;
		}
		_0023_003DqN68aK_9LAaAh_z4vazCouMYJjKHc8QVCN9bdH1h8LGM_003D = num4 + _0023_003DqN68aK_9LAaAh_z4vazCouMYJjKHc8QVCN9bdH1h8LGM_003D;
	}

	private static void _0023_003DqPjjZeoPZSjhsr2IXcscD1_002471wFr0raW_dhcKPHR0uro_003D(byte[] _0023_003Dq4AX0_vJqXL4F_0024T2Cu5jA9chmv1N2XWxX722ihQOwPuM_003D, int _0023_003Dqe20UeGhqlncDdQUGjZa3r_0024gaKSWbDuUZeiyNoxUdugU_003D, byte[] _0023_003DqpcM57JI6yI6rJe6NjZN2XtauiR7VxBBCr5_7EMwc2DE_003D)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = _0023_003DqpcM57JI6yI6rJe6NjZN2XtauiR7VxBBCr5_7EMwc2DE_003D.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = _0023_003Dq4AX0_vJqXL4F_0024T2Cu5jA9chmv1N2XWxX722ihQOwPuM_003D[_0023_003Dqe20UeGhqlncDdQUGjZa3r_0024gaKSWbDuUZeiyNoxUdugU_003D++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (_0023_003Dq4AX0_vJqXL4F_0024T2Cu5jA9chmv1N2XWxX722ihQOwPuM_003D[_0023_003Dqe20UeGhqlncDdQUGjZa3r_0024gaKSWbDuUZeiyNoxUdugU_003D] >> 2) + 3;
				int num6 = ((_0023_003Dq4AX0_vJqXL4F_0024T2Cu5jA9chmv1N2XWxX722ihQOwPuM_003D[_0023_003Dqe20UeGhqlncDdQUGjZa3r_0024gaKSWbDuUZeiyNoxUdugU_003D] << 8) | _0023_003Dq4AX0_vJqXL4F_0024T2Cu5jA9chmv1N2XWxX722ihQOwPuM_003D[_0023_003Dqe20UeGhqlncDdQUGjZa3r_0024gaKSWbDuUZeiyNoxUdugU_003D + 1]) & 0x3FF;
				_0023_003Dqe20UeGhqlncDdQUGjZa3r_0024gaKSWbDuUZeiyNoxUdugU_003D += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					_0023_003DqpcM57JI6yI6rJe6NjZN2XtauiR7VxBBCr5_7EMwc2DE_003D[num++] = _0023_003DqpcM57JI6yI6rJe6NjZN2XtauiR7VxBBCr5_7EMwc2DE_003D[num7++];
				}
			}
			else
			{
				_0023_003DqpcM57JI6yI6rJe6NjZN2XtauiR7VxBBCr5_7EMwc2DE_003D[num++] = _0023_003Dq4AX0_vJqXL4F_0024T2Cu5jA9chmv1N2XWxX722ihQOwPuM_003D[_0023_003Dqe20UeGhqlncDdQUGjZa3r_0024gaKSWbDuUZeiyNoxUdugU_003D++];
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string _0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(int _0023_003Dqvu5LhG98U9xDOOJNjliwGyVE9YOqoYP0qpHg46rN6rM_003D)
	{
		int num = 1823582618;
		int num2 = num ^ 0x578C238E;
		lock (_0023_003DqVTw5faBUR2OiokEQKFI6pqsdwHYOENViCT4q_0024QajzXE_003D)
		{
			byte[] array;
			int num11;
			string text;
			while (true)
			{
				text = _0023_003DqVTw5faBUR2OiokEQKFI6pqsdwHYOENViCT4q_0024QajzXE_003D._0023_003DqezctZeOACk0w__0024nhmBSEFA_003D_003D(_0023_003Dqvu5LhG98U9xDOOJNjliwGyVE9YOqoYP0qpHg46rN6rM_003D);
				if (text != null)
				{
					return text;
				}
				int num6;
				if (_0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D == null)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly callingAssembly = Assembly.GetCallingAssembly();
					_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D |= 1479106260 + num + num2;
					StringBuilder stringBuilder = new StringBuilder();
					int num3 = num ^ 0x77840387 ^ num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = -940420173 - num - num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = num + 2014571602 + num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = -939961416 - num - num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = (num + -1366556542) ^ num2;
					stringBuilder.Append((char)num3).Append((char)(num3 >> 16));
					num3 = 1367228300 - num + num2;
					stringBuilder.Append((char)(num3 >> 16)).Append((char)num3);
					num3 = 0x578C0388 ^ num ^ num2;
					stringBuilder.Append((char)num3);
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
					int num4 = 1;
					StackTrace stackTrace = new StackTrace(num4, fNeedFileInfo: false);
					_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D ^= (num + 1477502360 + num2) | num4;
					num4--;
					StackFrame frame = stackTrace.GetFrame(num4);
					MethodBase methodBase = frame?.GetMethod();
					_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D ^= num4 + (0x578C230E ^ num ^ num2);
					Type type = methodBase?.DeclaringType;
					if (frame == null)
					{
						_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D ^= 829913145 - num + num2;
					}
					bool flag = (object)type == typeof(RuntimeMethodHandle);
					_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D ^= (num + -829693670) ^ num2;
					if (!flag)
					{
						flag = (object)type == null;
						if (flag)
						{
							_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D ^= -1477276607 - num - num2;
						}
					}
					if (flag == (stackTrace != null))
					{
						_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D ^= 32;
					}
					_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D ^= (num ^ 0x578C3AE8 ^ num2) | (1 + num4);
					_0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D = new _0002_2006_2001_2004_2002_2001_200A_200B_2003_200B_200A_2003_200A_2000_2005_2003_2008_2009_200B_200B_200B_2000_2004_2003_200B_2009_200A_2008_2009(manifestResourceStream);
					short num5 = (short)(_0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqQh3e0_0024TX5zNwylmf_0024DAhCpkMvXcuBmJuXUOU9KzKURA_003D() ^ (short)(-(~(~(-(~(-(~(-(-(~(~(1477478891 + num + num2)))))))))))));
					if (num5 == 0)
					{
						_0023_003DqUHVV0DeFH4JN3sPAS2M0k0jzo1wdo2q_no4C_0024GK4Wlw_003D = (short)(_0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqQh3e0_0024TX5zNwylmf_0024DAhCpkMvXcuBmJuXUOU9KzKURA_003D() ^ (short)(~(-(~(-(-(~(~(-(-(~(~(num ^ 0x578C74D1 ^ num2)))))))))))));
					}
					else
					{
						_0023_003Dqt_SYM3wt5rKJUWgHlOVd_vBUHOzxJb7nNK_0024HcJVFil8_003D = _0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqOg4HftqFPEw8VLaaw9DeWSCkVuX0KLXkk3NcTS_3PzM_003D(num5);
					}
					callingAssembly = executingAssembly;
					AssemblyName assemblyName;
					try
					{
						assemblyName = callingAssembly.GetName();
					}
					catch
					{
						assemblyName = new AssemblyName(callingAssembly.FullName);
					}
					_0023_003DqSEK1_pQy7tv4C0vq0w6OsC05_CPSOiKYW85pJqNDkh8_003D = assemblyName.GetPublicKeyToken();
					if (_0023_003DqSEK1_pQy7tv4C0vq0w6OsC05_CPSOiKYW85pJqNDkh8_003D != null && _0023_003DqSEK1_pQy7tv4C0vq0w6OsC05_CPSOiKYW85pJqNDkh8_003D.Length == 0)
					{
						_0023_003DqSEK1_pQy7tv4C0vq0w6OsC05_CPSOiKYW85pJqNDkh8_003D = null;
					}
					num6 = _0023_003DqN68aK_9LAaAh_z4vazCouMYJjKHc8QVCN9bdH1h8LGM_003D;
					_0023_003DqN68aK_9LAaAh_z4vazCouMYJjKHc8QVCN9bdH1h8LGM_003D = 0;
					long num7 = _0023_003Dq7iLYzMJBQgAYtGLC7UC6Nfh_ljN4gyj2xNtybSs9fIs_003D._0023_003DqN4yjVFuPYK5j7R64LmRCaA_003D_003D();
					num6 ^= (int)num7;
					num6 ^= 1782419994 - num + num2;
					num6 ^= ((-830097012 + num) ^ num2) + -(~(-(~(-(~(~(-(~((-1468801759 ^ num) + num2)))))))));
					num6 = (_0023_003DqpV0reRLMgb_00244mttRVZHsQictkBrZNFDnDkc8gTaQSSk_003D = num6 ^ -(~(~(-(~(-(~(-(~(1482594414 - num - num2))))))))));
					_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D = (_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D & ((num ^ -1200366396) + num2)) ^ ((-1477494230 - num) ^ num2);
					if (((uint)_0023_003DqEY7cH_UPZMIhDUdk4Q_4x7nhacgwBIFoqmVGy8hWoRQ_003D & (uint)(~(-(~(-(~(-(-(~(~(-(~((num ^ -1468801982) + num2))))))))))))) == 0)
					{
						_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D = (-1477522616 - num) ^ num2;
					}
				}
				else
				{
					num6 = _0023_003DqpV0reRLMgb_00244mttRVZHsQictkBrZNFDnDkc8gTaQSSk_003D;
				}
				if (_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D == num + -829649868 - num2)
				{
					return new string(new char[3]
					{
						(char)((num ^ -1468801058) + num2),
						'0',
						(char)((-1477495834 - num) ^ num2)
					});
				}
				int num8 = _0023_003Dqvu5LhG98U9xDOOJNjliwGyVE9YOqoYP0qpHg46rN6rM_003D ^ ((num ^ 0x17376B09) + num2) ^ num6;
				num8 ^= (1938417804 - num) ^ num2;
				_0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqNw9Ic947H_0024UDRDkMFzNP4mdNk9kc16XhlesD_0024jU9g8U_003D().Position = num8;
				if (_0023_003Dqt_SYM3wt5rKJUWgHlOVd_vBUHOzxJb7nNK_0024HcJVFil8_003D != null)
				{
					array = _0023_003Dqt_SYM3wt5rKJUWgHlOVd_vBUHOzxJb7nNK_0024HcJVFil8_003D;
				}
				else
				{
					short num9 = ((_0023_003DqUHVV0DeFH4JN3sPAS2M0k0jzo1wdo2q_no4C_0024GK4Wlw_003D != -1) ? _0023_003DqUHVV0DeFH4JN3sPAS2M0k0jzo1wdo2q_no4C_0024GK4Wlw_003D : ((short)(_0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqQh3e0_0024TX5zNwylmf_0024DAhCpkMvXcuBmJuXUOU9KzKURA_003D() ^ ((num ^ 0x578C49C9) - num2) ^ num8)));
					if (num9 == 0)
					{
						array = null;
					}
					else
					{
						array = _0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqOg4HftqFPEw8VLaaw9DeWSCkVuX0KLXkk3NcTS_3PzM_003D(num9);
						for (int num10 = 0; num10 != array.Length; num10 = 1 + num10)
						{
							array[num10] ^= (byte)(_0023_003DqpV0reRLMgb_00244mttRVZHsQictkBrZNFDnDkc8gTaQSSk_003D >> ((3 & num10) << 3));
						}
					}
				}
				num11 = _0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003Dqv27KByyHy_0024wmElRe6nCBpTNQKkd4vnQPefJjn71CFqc_003D() ^ num8 ^ -(~(-(~(-(~(~(-(~(1723630976 + num + num2))))))))) ^ num6;
				if (num11 != ((829693828 - num) | num2))
				{
					break;
				}
				byte[] array2 = _0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqOg4HftqFPEw8VLaaw9DeWSCkVuX0KLXkk3NcTS_3PzM_003D(4);
				_0023_003Dqvu5LhG98U9xDOOJNjliwGyVE9YOqoYP0qpHg46rN6rM_003D = -1495767715 ^ num ^ num2 ^ num6;
				_0023_003Dqvu5LhG98U9xDOOJNjliwGyVE9YOqoYP0qpHg46rN6rM_003D = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -_0023_003Dqvu5LhG98U9xDOOJNjliwGyVE9YOqoYP0qpHg46rN6rM_003D;
			}
			bool flag2 = (num11 & (-1743729582 + num + num2)) != 0;
			bool flag3 = (num11 & (-678681714 ^ num ^ num2)) != 0;
			bool flag4 = (num11 & (1366564742 - num + num2)) != 0;
			num11 &= (num + -938423215) ^ num2;
			byte[] array3 = _0023_003DqrTebbNLL2paemLSpxzlMwfIZwJUN1D_L2f_0024m0PBTtNaRiXz2IE3lOJaIZUxlDfCv._0023_003DquZw2kqDuAM3tJrPwcHio7g_003D_003D(array, _0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqOg4HftqFPEw8VLaaw9DeWSCkVuX0KLXkk3NcTS_3PzM_003D(num11));
			if (_0023_003DqSEK1_pQy7tv4C0vq0w6OsC05_CPSOiKYW85pJqNDkh8_003D != null != (_0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D != 831301644 - num + num2))
			{
				for (int i = 0; i < num11; i++)
				{
					byte b = _0023_003DqSEK1_pQy7tv4C0vq0w6OsC05_CPSOiKYW85pJqNDkh8_003D[i & 7];
					b = (byte)((b << 3) | (b >> 5));
					array3[i] ^= b;
				}
			}
			int num12 = _0023_003Dq9U2y9dNToJpqE0SAonworeRPMWvCXb_5tnk_0024NwSiVyc_003D - 12;
			int num13;
			byte[] array4;
			if (!flag3)
			{
				num13 = num11;
				array4 = array3;
			}
			else
			{
				num13 = array3[2] | (array3[0] << 16) | (array3[3] << 8) | (array3[1] << 24);
				array4 = new byte[num13];
				_0023_003DqPjjZeoPZSjhsr2IXcscD1_002471wFr0raW_dhcKPHR0uro_003D(array3, 4, array4);
			}
			if (flag2 && num12 == num + -828086028 - num2)
			{
				char[] array5 = new char[num13];
				for (int j = 0; j < num13; j++)
				{
					array5[j] = (char)array4[j];
				}
				text = new string(array5);
			}
			else
			{
				text = Encoding.Unicode.GetString(array4, 0, array4.Length);
			}
			num12 += (0x578C23F1 ^ num ^ num2) + (3 & num12) << 5;
			if (num12 != 831305760 - num + num2)
			{
				int num14 = (_0023_003Dqvu5LhG98U9xDOOJNjliwGyVE9YOqoYP0qpHg46rN6rM_003D + num11) ^ (num + -828757262 - num2) ^ (num12 & (num ^ 0x578C2683 ^ num2));
				StringBuilder stringBuilder = new StringBuilder();
				int num3 = num + -829693742 - num2;
				stringBuilder.Append((char)(byte)num3);
				text = num14.ToString(stringBuilder.ToString());
			}
			if (!flag4)
			{
				text = string.Intern(text);
				_0023_003DqVTw5faBUR2OiokEQKFI6pqsdwHYOENViCT4q_0024QajzXE_003D._0023_003DqkGjI4qBJDiP12xMxjjdHbQ_003D_003D(_0023_003Dqvu5LhG98U9xDOOJNjliwGyVE9YOqoYP0qpHg46rN6rM_003D, text);
				if (_0023_003DqVTw5faBUR2OiokEQKFI6pqsdwHYOENViCT4q_0024QajzXE_003D._0023_003DqLocSUPSkxctOD3yXV3BDeGmj8YaWv8lth2mjKiJanhU_003D() == (-1468803204 ^ num) + num2)
				{
					_0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D._0023_003DqnjQgUNznNnMaCzdec0X0wB9P3YNP_0024CFcjLRV0sJKt20_003D();
					_0023_003DqweYc8AvLx1ctFjfF1JF2fFM_0024Z8NCbz_s4LKTirGXsww_003D = null;
					_0023_003Dqt_SYM3wt5rKJUWgHlOVd_vBUHOzxJb7nNK_0024HcJVFil8_003D = (_0023_003DqSEK1_pQy7tv4C0vq0w6OsC05_CPSOiKYW85pJqNDkh8_003D = null);
				}
			}
			return text;
		}
	}
}
