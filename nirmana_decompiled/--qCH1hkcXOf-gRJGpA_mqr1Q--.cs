using System;
using System.IO;
using System.Text;

public sealed class _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D
{
	public uint _0023_003DqNvxni_00242HM5VcKWusOhEZNw_003D_003D;

	public uint _0023_003DqNM3LWf4BgAqnW9nvjF4BkA_003D_003D;

	public uint _0023_003Dqx2Nm_0024nEWFvHiuIVCDz9Cfg_003D_003D;

	public byte[] _0023_003Dq_fwI_0024o_0024LJ7bByVTfDbuOXw_003D_003D;

	public int _0023_003DqOXeM3zPMPcalTAC2jOrzJA_003D_003D()
	{
		int num = (int)(_0023_003DqNvxni_00242HM5VcKWusOhEZNw_003D_003D * (_0023_003Dqx2Nm_0024nEWFvHiuIVCDz9Cfg_003D_003D / 8));
		return _0023_003Dq_fwI_0024o_0024LJ7bByVTfDbuOXw_003D_003D.Length / num;
	}

	public float _0023_003DqYk_Yf7_BkI2tph1quZKJ4g_003D_003D()
	{
		return (float)_0023_003DqOXeM3zPMPcalTAC2jOrzJA_003D_003D() / (float)_0023_003DqNM3LWf4BgAqnW9nvjF4BkA_003D_003D;
	}

	public void _0023_003DqGJBH9Ei904_X9DWSfUedNw_003D_003D(string _0023_003DqG1i8E4ptDn55P4mvpFzquA_003D_003D)
	{
		Console.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065757134), new object[6]
		{
			_0023_003DqG1i8E4ptDn55P4mvpFzquA_003D_003D,
			(_0023_003DqNvxni_00242HM5VcKWusOhEZNw_003D_003D == 1) ? _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756188) : _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756165),
			_0023_003Dqx2Nm_0024nEWFvHiuIVCDz9Cfg_003D_003D,
			_0023_003DqNM3LWf4BgAqnW9nvjF4BkA_003D_003D,
			_0023_003DqOXeM3zPMPcalTAC2jOrzJA_003D_003D(),
			_0023_003DqYk_Yf7_BkI2tph1quZKJ4g_003D_003D()
		});
	}

	public static _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D _0023_003DqRi7sFoO9y7a9ix4wHPpJ_0024Q_003D_003D(string _0023_003DqaLkbFp3wKlbMOxfU0JT4bw_003D_003D)
	{
		_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2 = new _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D();
		FileStream fileStream = new FileStream(_0023_003DqaLkbFp3wKlbMOxfU0JT4bw_003D_003D, FileMode.Open, FileAccess.Read);
		try
		{
			BinaryReader binaryReader = new BinaryReader(fileStream);
			try
			{
				_0023_003Dq_2igOX3AIPAcfrdUjRd7Ig_003D_003D(Encoding.ASCII.GetString(binaryReader.ReadBytes(4)) == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756205), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756194));
				binaryReader.ReadUInt32();
				_0023_003Dq_2igOX3AIPAcfrdUjRd7Ig_003D_003D(Encoding.ASCII.GetString(binaryReader.ReadBytes(4)) == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756256), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756241));
				while (!(Encoding.ASCII.GetString(binaryReader.ReadBytes(4)) == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756302)))
				{
					uint count = binaryReader.ReadUInt32();
					binaryReader.ReadBytes((int)count);
				}
				_0023_003Dq_2igOX3AIPAcfrdUjRd7Ig_003D_003D(binaryReader.ReadUInt32() == 16, _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756295));
				_0023_003Dq_2igOX3AIPAcfrdUjRd7Ig_003D_003D(binaryReader.ReadUInt16() == 1, _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756346));
				_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNvxni_00242HM5VcKWusOhEZNw_003D_003D = binaryReader.ReadUInt16();
				_0023_003Dq_2igOX3AIPAcfrdUjRd7Ig_003D_003D(_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNvxni_00242HM5VcKWusOhEZNw_003D_003D >= 1 && _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNvxni_00242HM5VcKWusOhEZNw_003D_003D <= 2, _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756412));
				_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNM3LWf4BgAqnW9nvjF4BkA_003D_003D = binaryReader.ReadUInt32();
				uint num = binaryReader.ReadUInt32();
				ushort num2 = binaryReader.ReadUInt16();
				_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003Dqx2Nm_0024nEWFvHiuIVCDz9Cfg_003D_003D = binaryReader.ReadUInt16();
				_0023_003Dq_2igOX3AIPAcfrdUjRd7Ig_003D_003D(num == _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNM3LWf4BgAqnW9nvjF4BkA_003D_003D * _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNvxni_00242HM5VcKWusOhEZNw_003D_003D * (_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003Dqx2Nm_0024nEWFvHiuIVCDz9Cfg_003D_003D / 8), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756475));
				_0023_003Dq_2igOX3AIPAcfrdUjRd7Ig_003D_003D(num2 == _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNvxni_00242HM5VcKWusOhEZNw_003D_003D * (_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003Dqx2Nm_0024nEWFvHiuIVCDz9Cfg_003D_003D / 8), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756503));
				if (_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNM3LWf4BgAqnW9nvjF4BkA_003D_003D != _0023_003DqOtemJOzkZrHIxt9bJqyh9g_003D_003D._0023_003Dq8Ovft03UTbFmxEgIGSYv1g_003D_003D)
				{
					throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756553) + _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003DqNM3LWf4BgAqnW9nvjF4BkA_003D_003D);
				}
				if (_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003Dqx2Nm_0024nEWFvHiuIVCDz9Cfg_003D_003D != 16)
				{
					throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756583) + _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003Dqx2Nm_0024nEWFvHiuIVCDz9Cfg_003D_003D);
				}
				while (!(Encoding.ASCII.GetString(binaryReader.ReadBytes(4)) == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756610)))
				{
					uint count2 = binaryReader.ReadUInt32();
					binaryReader.ReadBytes((int)count2);
				}
				uint count3 = binaryReader.ReadUInt32();
				_0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2._0023_003Dq_fwI_0024o_0024LJ7bByVTfDbuOXw_003D_003D = binaryReader.ReadBytes((int)count3);
				return _0023_003DqCH1hkcXOf_0024gRJGpA_mqr1Q_003D_003D2;
			}
			finally
			{
				((IDisposable)binaryReader).Dispose();
			}
		}
		finally
		{
			((IDisposable)fileStream).Dispose();
		}
	}

	public static void _0023_003DqAZu3FqQShGNgSU0kNQNJmw_003D_003D(string _0023_003DqkMNJtj9qx9Iyan_NiIEpew_003D_003D, int _0023_003Dqe29_0024BNKrBGD1THsf16RCHQ_003D_003D, short[] _0023_003DqqSemuUcYtEptw4BnbFBlEg_003D_003D)
	{
		if (_0023_003DqqSemuUcYtEptw4BnbFBlEg_003D_003D.Length % 2 != 0)
		{
			throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756635));
		}
		BinaryWriter binaryWriter = new BinaryWriter(new FileStream(_0023_003DqkMNJtj9qx9Iyan_NiIEpew_003D_003D, FileMode.Create, FileAccess.Write), Encoding.ASCII);
		try
		{
			int num = _0023_003DqqSemuUcYtEptw4BnbFBlEg_003D_003D.Length * 2;
			int value = 36 + num;
			binaryWriter.Write(_0023_003DqMD8m0_0024PB94Azhm6_0024cDzHLg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756205)));
			binaryWriter.Write(value);
			binaryWriter.Write(_0023_003DqMD8m0_0024PB94Azhm6_0024cDzHLg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756256)));
			short value2 = 1;
			short num2 = 2;
			short num3 = 16;
			int value3 = _0023_003Dqe29_0024BNKrBGD1THsf16RCHQ_003D_003D * num2 * num3;
			short value4 = (short)(num2 * num3 / 8);
			binaryWriter.Write(_0023_003DqMD8m0_0024PB94Azhm6_0024cDzHLg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756302)));
			binaryWriter.Write(16);
			binaryWriter.Write(value2);
			binaryWriter.Write(num2);
			binaryWriter.Write(_0023_003Dqe29_0024BNKrBGD1THsf16RCHQ_003D_003D);
			binaryWriter.Write(value3);
			binaryWriter.Write(value4);
			binaryWriter.Write(num3);
			binaryWriter.Write(_0023_003DqMD8m0_0024PB94Azhm6_0024cDzHLg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065756610)));
			binaryWriter.Write(num);
			foreach (short value5 in _0023_003DqqSemuUcYtEptw4BnbFBlEg_003D_003D)
			{
				binaryWriter.Write(value5);
			}
		}
		finally
		{
			((IDisposable)binaryWriter).Dispose();
		}
	}

	private static byte[] _0023_003DqMD8m0_0024PB94Azhm6_0024cDzHLg_003D_003D(string _0023_003DqWuU7hpaHxvVMccCX3IyVXw_003D_003D)
	{
		return Encoding.ASCII.GetBytes(_0023_003DqWuU7hpaHxvVMccCX3IyVXw_003D_003D);
	}

	private static void _0023_003Dq_2igOX3AIPAcfrdUjRd7Ig_003D_003D(bool _0023_003DqgIPxAZb56fhhr7ZOh_nClQ_003D_003D, string _0023_003DqUFkYfiUtT_0024tebmHCddU92Q_003D_003D)
	{
		if (!_0023_003DqgIPxAZb56fhhr7ZOh_nClQ_003D_003D)
		{
			throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqUFkYfiUtT_0024tebmHCddU92Q_003D_003D);
		}
	}
}
