using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

public sealed class PsdImage
{
	private enum _0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D
	{

	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<byte, string> _003C_003E9__12_0;

		public static Func<PsdImageResource, bool> _003C_003E9__15_0;

		internal string _0023_003DqdBHoH1woY0uvY8DRfGnxPlMjcOTd7jQRKGHXmsGeh1o_003D(byte _0023_003Dq8vB7UpM1aWHVHGCpoBvf6w_003D_003D)
		{
			return _0023_003Dq8vB7UpM1aWHVHGCpoBvf6w_003D_003D.ToString(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808799));
		}

		internal bool _0023_003DqhcHzwTsWDj1GJ0p_C6_bSZyxyZlbqzXTo_0024tOsk7kt_0024s_003D(PsdImageResource _0023_003DqNEd_0024yW9JyNiZXa09q_Zkdg_003D_003D)
		{
			return _0023_003DqNEd_0024yW9JyNiZXa09q_Zkdg_003D_003D._0023_003DqvBNZFNBS0Y4V_5QP7f_0024h2w_003D_003D == _0023_003Dq8UUwFWWxFg0lkzbZyZSdjXCv8vUhEna2FFIliqtbOL0_003D.Guides;
		}
	}

	public int _0023_003DqeoounbbE_0024Xk_0024nZ88__MrLQ_003D_003D;

	public int _0023_003DqY9hxxiENdzkz1IuvSUvzPA_003D_003D;

	public int _0023_003DqfoQ349boa9QhofK9btYv5g_003D_003D;

	public _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D[] _0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D;

	public _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D _0023_003DqCdkitZd6LOoFXafiebxvPg_003D_003D;

	public List<PsdImageResource> _0023_003DqfD8Ja26U5yOeaZu99TmhJg_003D_003D = new List<PsdImageResource>();

	public static _0023_003DqF5mz4F6GHAU8AOjGYF08cA_003D_003D _0023_003Dq9MhhJuoi35AA3m3XNCQ1Nnnffvj2VzbWwt5lXzsXDnQ_003D(string _0023_003DqPVcR7Wd6CIrCslpBJG38cA_003D_003D)
	{
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		FileStream fileStream = new FileStream(_0023_003DqPVcR7Wd6CIrCslpBJG38cA_003D_003D, FileMode.Open, FileAccess.Read);
		int num3;
		int num4;
		_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2;
		try
		{
			BinaryReader binaryReader = new BinaryReader(fileStream);
			try
			{
				string text = aSCIIEncoding.GetString(binaryReader.ReadBytes(4));
				ushort num = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
				fileStream.Position += 6L;
				ushort num2 = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
				num3 = (int)binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				num4 = (int)binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				ushort num5 = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
				ushort num6 = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(text == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808786));
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(num == 1);
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(num2 == 3 || num2 == 4);
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(num5 == 8);
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(num6 == 3);
				uint num7 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				fileStream.Position += num7;
				num7 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				fileStream.Position += num7;
				num7 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				fileStream.Position += num7;
				_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2 = _0023_003DqQorWiHEaEfJBRhpHig8DiefCV7a4ze0KzqP2jI3dw4o_003D(binaryReader, num4, num3, num2);
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
		byte[] array = new byte[num4 * num3 * 4];
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num4; j++)
			{
				int num8 = (num3 - i - 1) * num4 + j;
				int num9 = i * num4 + j;
				byte b = _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003Dq_0024RrNKyPPBVaIgdyHbIkctg_003D_003D[num8];
				byte b2 = _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqtLPcfzWhZNeUp7QnjUhisw_003D_003D[num8];
				byte b3 = _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqXByOnnnj6__0024VIeeot0Eoow_003D_003D[num8];
				byte b4 = _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqJ_0024YNhe2CgNJWn8l5eNblgw_003D_003D[num8];
				b = (byte)(b + b4 - 255);
				b2 = (byte)(b2 + b4 - 255);
				b3 = (byte)(b3 + b4 - 255);
				array[4 * num9] = b;
				array[4 * num9 + 1] = b2;
				array[4 * num9 + 2] = b3;
				array[4 * num9 + 3] = b4;
			}
		}
		return new _0023_003DqF5mz4F6GHAU8AOjGYF08cA_003D_003D(_0023_003Dq1gL_0024CIEzk66xXEU451_0024efw_003D_003D.RGBA, num4, num3, array);
	}

	public static PsdImage _0023_003DqJ1B5op8AFKnaSKJql9Ve7Q_003D_003D(string _0023_003Dqt_0024nLiKO84Za4CB9RX1Xbvw_003D_003D)
	{
		PsdImage psdImage = new PsdImage();
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		UnicodeEncoding unicodeEncoding = new UnicodeEncoding(bigEndian: true, byteOrderMark: false);
		FileStream fileStream = new FileStream(_0023_003Dqt_0024nLiKO84Za4CB9RX1Xbvw_003D_003D, FileMode.Open, FileAccess.Read);
		_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D[] array;
		try
		{
			BinaryReader binaryReader = new BinaryReader(fileStream);
			try
			{
				string text = aSCIIEncoding.GetString(binaryReader.ReadBytes(4));
				ushort num = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
				fileStream.Position += 6L;
				ushort num2 = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
				psdImage._0023_003DqY9hxxiENdzkz1IuvSUvzPA_003D_003D = (int)binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				psdImage._0023_003DqeoounbbE_0024Xk_0024nZ88__MrLQ_003D_003D = (int)binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				ushort num3 = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
				ushort num4 = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(text == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808786));
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(num == 1);
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(num2 == 3 || num2 == 4);
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(num3 == 8);
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(num4 == 3);
				psdImage._0023_003DqfoQ349boa9QhofK9btYv5g_003D_003D = num2;
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D() == 0);
				psdImage._0023_003DqfD8Ja26U5yOeaZu99TmhJg_003D_003D = _0023_003Dq5PpXCN3xw9ZO96qqzbihjxsuHyf0brKEwzswy0cvU10_003D(binaryReader);
				uint num5 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				long position = fileStream.Position + num5;
				uint num6 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
				long num7 = fileStream.Position + (int)num6;
				short num8 = binaryReader._0023_003DqVSMmQwtG72SM04dOsld6_0024DjwCyrQx3wH8pJJ6H7BMwk_003D();
				if (num8 < 0)
				{
					num8 = Math.Abs(num8);
				}
				psdImage._0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D = new _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D[num8];
				for (int i = 0; i < num8; i++)
				{
					_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2 = new _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D();
					_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D = _0023_003DqLb0SNeSDsBr4z4X_7Gsh2g_003D_003D(binaryReader);
					ushort num9 = binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
					for (int j = 0; j < num9; j++)
					{
						_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2 = new _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D();
						_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003Dq9ZGxANf6gWCLb51ETNTyBw_003D_003D = (_0023_003DqR3_0024jZbeU8fQ9neSCkb7_00247w_003D_003D)binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
						_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003DqzLSTs7g3Fe5myXjfDB3oERw2XHS7K1BlybA2BuO8NPE_003D = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
						if (_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003Dq9ZGxANf6gWCLb51ETNTyBw_003D_003D == _0023_003DqR3_0024jZbeU8fQ9neSCkb7_00247w_003D_003D.Red)
						{
							_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqoTX9G4dhRabhNQl8Ho2JOw_003D_003D = _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2;
						}
						else if (_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003Dq9ZGxANf6gWCLb51ETNTyBw_003D_003D == _0023_003DqR3_0024jZbeU8fQ9neSCkb7_00247w_003D_003D.Green)
						{
							_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003Dqh8_WtU3AnvcvvqJ3pcYJ4A_003D_003D = _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2;
						}
						else if (_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003Dq9ZGxANf6gWCLb51ETNTyBw_003D_003D == _0023_003DqR3_0024jZbeU8fQ9neSCkb7_00247w_003D_003D.Blue)
						{
							_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003Dqbe8zY3fV8KSStf_00246Rk1gnw_003D_003D = _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2;
						}
						else if (_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003Dq9ZGxANf6gWCLb51ETNTyBw_003D_003D == _0023_003DqR3_0024jZbeU8fQ9neSCkb7_00247w_003D_003D.Transparent)
						{
							_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003Dqto4SboaPXY_6uoa9RIz7_Q_003D_003D = _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2;
						}
					}
					_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(aSCIIEncoding.GetString(binaryReader.ReadBytes(4)) == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808811));
					_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqeWa4a1DLQyiER2iCE2oyYw_003D_003D = aSCIIEncoding.GetString(binaryReader.ReadBytes(4));
					_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqipOPnMDhUHyHLEhhrgY5Uw_003D_003D = binaryReader.ReadByte();
					binaryReader.ReadByte();
					byte b = binaryReader.ReadByte();
					_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqrtRp8CsK_0024wrwBFLRJBMWIQ_003D_003D = (b & 2) == 0;
					fileStream.Position++;
					uint num10 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
					long num11 = fileStream.Position + (int)num10;
					uint num12 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
					fileStream.Position += num12;
					uint num13 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
					fileStream.Position += num13;
					byte b2 = binaryReader.ReadByte();
					_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqDQX1B7yqriNXinXjYa9AyA_003D_003D = aSCIIEncoding.GetString(binaryReader.ReadBytes(b2));
					_0023_003DqPntN3WGYu2_0024iAEW6N_dVgN0xgARilcxaQ4vo5toMd7Y_003D(fileStream, 1 + b2, 4);
					while (fileStream.Position < num11)
					{
						_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(aSCIIEncoding.GetString(binaryReader.ReadBytes(4)) == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808811));
						string text2 = aSCIIEncoding.GetString(binaryReader.ReadBytes(4));
						uint num14 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
						if (text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808832))
						{
							uint num15 = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
							_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqDQX1B7yqriNXinXjYa9AyA_003D_003D = unicodeEncoding.GetString(binaryReader.ReadBytes((int)(num15 * 2)));
							_0023_003DqPntN3WGYu2_0024iAEW6N_dVgN0xgARilcxaQ4vo5toMd7Y_003D(fileStream, (int)(4 + 2 * num15), 4);
						}
						else if (text2 == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808817))
						{
							_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003Dqlxnaq_0024Sihke6Dd5WwqDd9g_003D_003D = (_0023_003DqmhjFxYeuK5x99TEkB2QBug_003D_003D)binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
							if (num14 >= 12)
							{
								_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(aSCIIEncoding.GetString(binaryReader.ReadBytes(4)) == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808811));
								_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqeWa4a1DLQyiER2iCE2oyYw_003D_003D = aSCIIEncoding.GetString(binaryReader.ReadBytes(4));
								switch (num14)
								{
								case 16u:
									fileStream.Position += 4L;
									break;
								default:
									_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(_0023_003DqjSU76_0024qlcA0Ue9EBhxJj5A_003D_003D: false);
									break;
								case 0u:
								case 1u:
								case 2u:
								case 3u:
								case 4u:
								case 5u:
								case 6u:
								case 7u:
								case 8u:
								case 9u:
								case 10u:
								case 11u:
								case 12u:
								case 13u:
								case 14u:
								case 15u:
									break;
								}
							}
						}
						else
						{
							fileStream.Position += num14;
						}
					}
					_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(fileStream.Position == num11);
					if (num9 > 4)
					{
						throw new _0023_003DqbiTWWsZ_HEC4yfzDk8seQg_003D_003D(string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808838), _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqDQX1B7yqriNXinXjYa9AyA_003D_003D));
					}
					if (num9 < 4)
					{
						throw new _0023_003DqbiTWWsZ_HEC4yfzDk8seQg_003D_003D(string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805835), _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqDQX1B7yqriNXinXjYa9AyA_003D_003D));
					}
					psdImage._0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D[i] = _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2;
				}
				array = psdImage._0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D;
				foreach (_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D3 in array)
				{
					_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D[] array2 = new _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D[4] { _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D3._0023_003Dqto4SboaPXY_6uoa9RIz7_Q_003D_003D, _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D3._0023_003DqoTX9G4dhRabhNQl8Ho2JOw_003D_003D, _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D3._0023_003Dqh8_WtU3AnvcvvqJ3pcYJ4A_003D_003D, _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D3._0023_003Dqbe8zY3fV8KSStf_00246Rk1gnw_003D_003D };
					foreach (_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D3 in array2)
					{
						_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D3._0023_003DqgKRvvRghci8ukfP8s2tbaw_003D_003D = (_0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D)binaryReader._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
						if (_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D3._0023_003DqgKRvvRghci8ukfP8s2tbaw_003D_003D == _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D.RLE)
						{
							_0023_003DqeGPXvqhCJZRbRFF8Kd_kBA_003D_003D(binaryReader, _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D3._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D._0023_003DqBu3Xj93RRIzIl0grIGX4JQ_003D_003D(), 1);
						}
						_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D3._0023_003Dq6TRUfzIWqqmDEGWTlniAPA_003D_003D = _0023_003DqW8TaJ93UHJTvcJFBkYm9iC_7A_brbESS_NreLlGVEFM_003D(binaryReader, _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D3._0023_003DqgKRvvRghci8ukfP8s2tbaw_003D_003D, _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D3._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D);
					}
				}
				if (fileStream.Position % 2 == 1)
				{
					fileStream.Position++;
				}
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(fileStream.Position <= num7);
				fileStream.Position = position;
				psdImage._0023_003DqCdkitZd6LOoFXafiebxvPg_003D_003D = _0023_003DqQorWiHEaEfJBRhpHig8DiefCV7a4ze0KzqP2jI3dw4o_003D(binaryReader, psdImage._0023_003DqeoounbbE_0024Xk_0024nZ88__MrLQ_003D_003D, psdImage._0023_003DqY9hxxiENdzkz1IuvSUvzPA_003D_003D, psdImage._0023_003DqfoQ349boa9QhofK9btYv5g_003D_003D);
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
		Array.Reverse((Array)psdImage._0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D);
		Stack<_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D> stack = new Stack<_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D>();
		List<_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D> list = new List<_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D>();
		array = psdImage._0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D;
		foreach (_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D4 in array)
		{
			if (_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D4._0023_003Dqlxnaq_0024Sihke6Dd5WwqDd9g_003D_003D != (_0023_003DqmhjFxYeuK5x99TEkB2QBug_003D_003D)3u)
			{
				if (stack.Count > 0)
				{
					stack.Peek()._0023_003Dqcqzp6mIUg8fMqiYPase2Yg_003D_003D.Add(_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D4);
				}
				else
				{
					list.Add(_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D4);
				}
			}
			if (_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D4._0023_003DqoNSwjhCGZOp8XCPBB0DiUg_003D_003D())
			{
				stack.Push(_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D4);
			}
			else if (_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D4._0023_003Dqlxnaq_0024Sihke6Dd5WwqDd9g_003D_003D == (_0023_003DqmhjFxYeuK5x99TEkB2QBug_003D_003D)3u)
			{
				stack.Pop();
			}
		}
		psdImage._0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D = list.ToArray();
		return psdImage;
	}

	private static void _0023_003DqPntN3WGYu2_0024iAEW6N_dVgN0xgARilcxaQ4vo5toMd7Y_003D(Stream _0023_003DqyigJ3W9PLXJDoy8spmifpA_003D_003D, int _0023_003DqfBEV0EZvRdQceodgg369Wg_003D_003D, int _0023_003DquO_0024ovQsH4N3AseLdndWvSg_003D_003D)
	{
		for (int i = _0023_003DqfBEV0EZvRdQceodgg369Wg_003D_003D; i % _0023_003DquO_0024ovQsH4N3AseLdndWvSg_003D_003D != 0; i++)
		{
			_0023_003DqyigJ3W9PLXJDoy8spmifpA_003D_003D.Position++;
		}
	}

	private static _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D _0023_003DqQorWiHEaEfJBRhpHig8DiefCV7a4ze0KzqP2jI3dw4o_003D(BinaryReader _0023_003DqbTshs59a14b6IztBjcVRbA_003D_003D, int _0023_003DqxKWQdLYtWkKOaItyHxUnjQ_003D_003D, int _0023_003DqCpbRE_KjKdRVNwq0msuwMQ_003D_003D, int _0023_003DqXuwEvkIPD1aRQJK75SP6yw_003D_003D)
	{
		_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2 = new _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D();
		_0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D2 = (_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003Dq230yMvo_b9fxJobKcRA7CQ_003D_003D = (_0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D)_0023_003DqbTshs59a14b6IztBjcVRbA_003D_003D._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D());
		if (_0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D2 == _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D.RLE)
		{
			_0023_003DqeGPXvqhCJZRbRFF8Kd_kBA_003D_003D(_0023_003DqbTshs59a14b6IztBjcVRbA_003D_003D, _0023_003DqCpbRE_KjKdRVNwq0msuwMQ_003D_003D, _0023_003DqXuwEvkIPD1aRQJK75SP6yw_003D_003D);
		}
		_0023_003Dqp69_0024CKnlT_cVc6MR1Tj_RQ_003D_003D _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D = _0023_003Dqp69_0024CKnlT_cVc6MR1Tj_RQ_003D_003D._0023_003Dq84TA4p1P7BnL9hU6fbv3QQ_003D_003D(0, _0023_003DqxKWQdLYtWkKOaItyHxUnjQ_003D_003D, 0, _0023_003DqCpbRE_KjKdRVNwq0msuwMQ_003D_003D);
		_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003Dq_0024RrNKyPPBVaIgdyHbIkctg_003D_003D = _0023_003DqW8TaJ93UHJTvcJFBkYm9iC_7A_brbESS_NreLlGVEFM_003D(_0023_003DqbTshs59a14b6IztBjcVRbA_003D_003D, _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D2, _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D);
		_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqtLPcfzWhZNeUp7QnjUhisw_003D_003D = _0023_003DqW8TaJ93UHJTvcJFBkYm9iC_7A_brbESS_NreLlGVEFM_003D(_0023_003DqbTshs59a14b6IztBjcVRbA_003D_003D, _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D2, _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D);
		_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqXByOnnnj6__0024VIeeot0Eoow_003D_003D = _0023_003DqW8TaJ93UHJTvcJFBkYm9iC_7A_brbESS_NreLlGVEFM_003D(_0023_003DqbTshs59a14b6IztBjcVRbA_003D_003D, _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D2, _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D);
		if (_0023_003DqXuwEvkIPD1aRQJK75SP6yw_003D_003D > 3)
		{
			_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqJ_0024YNhe2CgNJWn8l5eNblgw_003D_003D = _0023_003DqW8TaJ93UHJTvcJFBkYm9iC_7A_brbESS_NreLlGVEFM_003D(_0023_003DqbTshs59a14b6IztBjcVRbA_003D_003D, _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D2, _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D);
		}
		else
		{
			_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqJ_0024YNhe2CgNJWn8l5eNblgw_003D_003D = new byte[_0023_003DqxKWQdLYtWkKOaItyHxUnjQ_003D_003D * _0023_003DqCpbRE_KjKdRVNwq0msuwMQ_003D_003D];
			for (int i = 0; i < _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqJ_0024YNhe2CgNJWn8l5eNblgw_003D_003D.Length; i++)
			{
				_0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2._0023_003DqJ_0024YNhe2CgNJWn8l5eNblgw_003D_003D[i] = byte.MaxValue;
			}
		}
		return _0023_003DqqHrcmQgQcuJNw9ATMChaHjTnjnT6kyjinQQvF504vYo_003D2;
	}

	private static void _0023_003DqeGPXvqhCJZRbRFF8Kd_kBA_003D_003D(BinaryReader _0023_003DqM5rpdal9vuEr773gqGHT2A_003D_003D, int _0023_003Dq_0024mpdyQBWsqa0Vu_0024ae9tLhA_003D_003D, int _0023_003DquYhS8dI28_pcL2XxuqDbng_003D_003D)
	{
		_0023_003DqM5rpdal9vuEr773gqGHT2A_003D_003D.BaseStream.Position += _0023_003Dq_0024mpdyQBWsqa0Vu_0024ae9tLhA_003D_003D * _0023_003DquYhS8dI28_pcL2XxuqDbng_003D_003D * 2;
	}

	private static byte[] _0023_003DqW8TaJ93UHJTvcJFBkYm9iC_7A_brbESS_NreLlGVEFM_003D(BinaryReader _0023_003DqkCXCpYiW_m0Sv_O9H99eJg_003D_003D, _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D _0023_003DqZD58ChRtYV1iZgZScZ0PMA_003D_003D, _0023_003Dqp69_0024CKnlT_cVc6MR1Tj_RQ_003D_003D _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D)
	{
		switch (_0023_003DqZD58ChRtYV1iZgZScZ0PMA_003D_003D)
		{
		case _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D.Raw:
			return _0023_003DqkCXCpYiW_m0Sv_O9H99eJg_003D_003D.ReadBytes(_0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D._0023_003DqUETAmMB5WIPm3eJrHbgDVg_003D_003D() * _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D._0023_003DqBu3Xj93RRIzIl0grIGX4JQ_003D_003D());
		case _0023_003Dq7rWsTS1w_0024_0024U_0024SlvGXkOpTfyYEZE_0024_pwxoEznsXj0E2I_003D.RLE:
			return _0023_003DqPAG6nKQkiZxg18xvZbGmFA_003D_003D(_0023_003DqkCXCpYiW_m0Sv_O9H99eJg_003D_003D, _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D._0023_003DqUETAmMB5WIPm3eJrHbgDVg_003D_003D() * _0023_003Dq_aEN_0024v0z0zDJO0FWYP4rHA_003D_003D._0023_003DqBu3Xj93RRIzIl0grIGX4JQ_003D_003D());
		default:
			_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(_0023_003DqjSU76_0024qlcA0Ue9EBhxJj5A_003D_003D: false);
			return new byte[0];
		}
	}

	public void _0023_003DqXaxZEdS0r6rhBNgJlOFJwA_003D_003D(TextWriter _0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D, bool _0023_003DqaexBrrH2v_ObyeJV3_2hhUrDglYjR_yzMQy4XNmX_hE_003D)
	{
		_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805902) + _0023_003DqeoounbbE_0024Xk_0024nZ88__MrLQ_003D_003D);
		_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805892) + _0023_003DqY9hxxiENdzkz1IuvSUvzPA_003D_003D);
		_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805905) + ((_0023_003DqfoQ349boa9QhofK9btYv5g_003D_003D == 3) ? _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805947) : _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805922)));
		_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805965) + _0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D.Length);
		_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D[] array = _0023_003Dqwyu1rfTb2CHt2jMVItK3OA_003D_003D;
		foreach (_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2 in array)
		{
			_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805982), _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqDQX1B7yqriNXinXjYa9AyA_003D_003D);
			_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065805994), _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D);
			_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806008), _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqeWa4a1DLQyiER2iCE2oyYw_003D_003D);
			_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806042), _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqipOPnMDhUHyHLEhhrgY5Uw_003D_003D);
			_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806055), _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqrtRp8CsK_0024wrwBFLRJBMWIQ_003D_003D);
			if (_0023_003DqaexBrrH2v_ObyeJV3_2hhUrDglYjR_yzMQy4XNmX_hE_003D)
			{
				_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D[] array2 = new _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D[4] { _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003DqoTX9G4dhRabhNQl8Ho2JOw_003D_003D, _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003Dqh8_WtU3AnvcvvqJ3pcYJ4A_003D_003D, _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003Dqbe8zY3fV8KSStf_00246Rk1gnw_003D_003D, _0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D2._0023_003Dqto4SboaPXY_6uoa9RIz7_Q_003D_003D };
				foreach (_0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2 in array2)
				{
					_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806096), _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003Dq9ZGxANf6gWCLb51ETNTyBw_003D_003D);
					_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806102), _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003DqgKRvvRghci8ukfP8s2tbaw_003D_003D);
					_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806137), _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003DqzLSTs7g3Fe5myXjfDB3oERw2XHS7K1BlybA2BuO8NPE_003D);
					_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806170), _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003Dq6TRUfzIWqqmDEGWTlniAPA_003D_003D.Length);
					_0023_003DqzE7C_00248KRb3asdOHXL7Mf2Q_003D_003D.WriteLine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806206), string.Join(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806220), _0023_003DqYfEOmMZdALgVRkIFrcZ6RQ_003D_003D2._0023_003Dq6TRUfzIWqqmDEGWTlniAPA_003D_003D.Select(_003C_003Ec._003C_003E9._0023_003DqdBHoH1woY0uvY8DRfGnxPlMjcOTd7jQRKGHXmsGeh1o_003D)));
				}
			}
		}
	}

	public _0023_003DqF5mz4F6GHAU8AOjGYF08cA_003D_003D _0023_003DqVes8W3btlk1HXw464r3SWg6LOs3xmnEURl1UFq7_0024nhs_003D(IEnumerable<_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D> _0023_003Dq7uYjPdS_eCO9SCnySAZfrQ_003D_003D)
	{
		byte[] array = new byte[_0023_003DqeoounbbE_0024Xk_0024nZ88__MrLQ_003D_003D * _0023_003DqY9hxxiENdzkz1IuvSUvzPA_003D_003D * 4];
		for (int i = 0; i < _0023_003DqY9hxxiENdzkz1IuvSUvzPA_003D_003D; i++)
		{
			for (int j = 0; j < _0023_003DqeoounbbE_0024Xk_0024nZ88__MrLQ_003D_003D; j++)
			{
				Color transparent = Color.Transparent;
				foreach (_0023_003Dqy6mE28NAaOhTioqf_35Qmg_003D_003D item in _0023_003Dq7uYjPdS_eCO9SCnySAZfrQ_003D_003D.Reverse())
				{
					if (!(item._0023_003DqeWa4a1DLQyiER2iCE2oyYw_003D_003D == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806212)))
					{
						if (item._0023_003DqeWa4a1DLQyiER2iCE2oyYw_003D_003D != _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806229))
						{
							throw new NotImplementedException(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806250));
						}
						Color transparent2 = Color.Transparent;
						if (j >= item._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D._0023_003Dq1830otylsk_Xcw_zwXodDw_003D_003D && j < item._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D._0023_003Dq5ZispjfFNDEu7dqW5ZckNA_003D_003D && i >= item._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D._0023_003Dq4IqcmRlxFFryyHG3E4zVxw_003D_003D && i < item._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D._0023_003Dq5I_0JPp_00243K2prDpmsXuX_Q_003D_003D)
						{
							int num = (i - item._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D._0023_003Dq4IqcmRlxFFryyHG3E4zVxw_003D_003D) * item._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D._0023_003DqUETAmMB5WIPm3eJrHbgDVg_003D_003D() + (j - item._0023_003DqUealnOSkk1hgoZpdYiwIOA_003D_003D._0023_003Dq1830otylsk_Xcw_zwXodDw_003D_003D);
							transparent2.R = (float)(int)item._0023_003DqoTX9G4dhRabhNQl8Ho2JOw_003D_003D._0023_003Dq6TRUfzIWqqmDEGWTlniAPA_003D_003D[num] / 255f;
							transparent2.G = (float)(int)item._0023_003Dqh8_WtU3AnvcvvqJ3pcYJ4A_003D_003D._0023_003Dq6TRUfzIWqqmDEGWTlniAPA_003D_003D[num] / 255f;
							transparent2.B = (float)(int)item._0023_003Dqbe8zY3fV8KSStf_00246Rk1gnw_003D_003D._0023_003Dq6TRUfzIWqqmDEGWTlniAPA_003D_003D[num] / 255f;
							transparent2.A = (float)(int)item._0023_003Dqto4SboaPXY_6uoa9RIz7_Q_003D_003D._0023_003Dq6TRUfzIWqqmDEGWTlniAPA_003D_003D[num] / 255f;
						}
						transparent.R = Utility._0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(transparent.R, transparent2.R, transparent2.A);
						transparent.G = Utility._0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(transparent.G, transparent2.G, transparent2.A);
						transparent.B = Utility._0023_003DqDK2NniI47TvgEIljU5pnUw_003D_003D(transparent.B, transparent2.B, transparent2.A);
						transparent.A = Math.Max(transparent.A, transparent2.A);
					}
				}
				int num2 = i * _0023_003DqeoounbbE_0024Xk_0024nZ88__MrLQ_003D_003D * 4 + j * 4;
				array[num2] = (byte)(transparent.A * 255f);
				array[num2 + 1] = (byte)(transparent.B * 255f);
				array[num2 + 2] = (byte)(transparent.G * 255f);
				array[num2 + 3] = (byte)(transparent.R * 255f);
			}
		}
		return new _0023_003DqF5mz4F6GHAU8AOjGYF08cA_003D_003D(_0023_003Dq1gL_0024CIEzk66xXEU451_0024efw_003D_003D.RGBA, _0023_003DqeoounbbE_0024Xk_0024nZ88__MrLQ_003D_003D, _0023_003DqY9hxxiENdzkz1IuvSUvzPA_003D_003D, array);
	}

	public List<PsdGuide> _0023_003DqHhBr6q6h5a5aYBQmZLHSvQ_003D_003D()
	{
		return _0023_003DqwvMAiGhwiQcL9BEfsv_0024hqw_003D_003D(_0023_003DqfD8Ja26U5yOeaZu99TmhJg_003D_003D);
	}

	private static List<PsdGuide> _0023_003DqwvMAiGhwiQcL9BEfsv_0024hqw_003D_003D(List<PsdImageResource> _0023_003DqZEi6eSWum3fgw33WQpxfcA_003D_003D)
	{
		List<PsdGuide> list = new List<PsdGuide>();
		PsdImageResource psdImageResource = _0023_003DqZEi6eSWum3fgw33WQpxfcA_003D_003D.FirstOrDefault((PsdImageResource _0023_003DqNEd_0024yW9JyNiZXa09q_Zkdg_003D_003D) => _0023_003DqNEd_0024yW9JyNiZXa09q_Zkdg_003D_003D._0023_003DqvBNZFNBS0Y4V_5QP7f_0024h2w_003D_003D == _0023_003Dq8UUwFWWxFg0lkzbZyZSdjXCv8vUhEna2FFIliqtbOL0_003D.Guides);
		if (psdImageResource != null)
		{
			MemoryStream memoryStream = new MemoryStream(psdImageResource._0023_003DqoUrco_Tt03bLdVjjoDsixA_003D_003D);
			try
			{
				BinaryReader binaryReader = new BinaryReader(memoryStream);
				try
				{
					memoryStream.Position += 12L;
					uint num = binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
					_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(psdImageResource._0023_003DqoUrco_Tt03bLdVjjoDsixA_003D_003D.Length == 16 + num * 5);
					for (int num2 = 0; num2 < num; num2++)
					{
						int _0023_003Dqw1u7xd1kh3oVwcWSkRMImw_003D_003D = binaryReader._0023_003DqF19Q3InsvIJeGdy68fNsfwMJMudzMtzODraQvF5TsdY_003D();
						_0023_003Dq1a_N0Sv5zscBSWJhNiIbPjjHy7Wx9hbR9IRTo38zs_o_003D _0023_003DqYdd4qMh7tZlOPHz6d8PmBA_003D_003D = (_0023_003Dq1a_N0Sv5zscBSWJhNiIbPjjHy7Wx9hbR9IRTo38zs_o_003D)binaryReader.ReadByte();
						list.Add(new PsdGuide
						{
							_0023_003Dqw1u7xd1kh3oVwcWSkRMImw_003D_003D = _0023_003Dqw1u7xd1kh3oVwcWSkRMImw_003D_003D,
							_0023_003DqYdd4qMh7tZlOPHz6d8PmBA_003D_003D = _0023_003DqYdd4qMh7tZlOPHz6d8PmBA_003D_003D
						});
					}
					return list;
				}
				finally
				{
					((IDisposable)binaryReader).Dispose();
				}
			}
			finally
			{
				((IDisposable)memoryStream).Dispose();
			}
		}
		return list;
	}

	[DebuggerStepThrough]
	private static void _0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(bool _0023_003DqjSU76_0024qlcA0Ue9EBhxJj5A_003D_003D)
	{
		if (!_0023_003DqjSU76_0024qlcA0Ue9EBhxJj5A_003D_003D)
		{
			throw new _0023_003DqbiTWWsZ_HEC4yfzDk8seQg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065806273));
		}
	}

	private static _0023_003Dqp69_0024CKnlT_cVc6MR1Tj_RQ_003D_003D _0023_003DqLb0SNeSDsBr4z4X_7Gsh2g_003D_003D(BinaryReader _0023_003Dqujh2utovxiqAHR9xHGOrKg_003D_003D)
	{
		_0023_003Dqp69_0024CKnlT_cVc6MR1Tj_RQ_003D_003D result = default(_0023_003Dqp69_0024CKnlT_cVc6MR1Tj_RQ_003D_003D);
		result._0023_003Dq4IqcmRlxFFryyHG3E4zVxw_003D_003D = _0023_003Dqujh2utovxiqAHR9xHGOrKg_003D_003D._0023_003DqF19Q3InsvIJeGdy68fNsfwMJMudzMtzODraQvF5TsdY_003D();
		result._0023_003Dq1830otylsk_Xcw_zwXodDw_003D_003D = _0023_003Dqujh2utovxiqAHR9xHGOrKg_003D_003D._0023_003DqF19Q3InsvIJeGdy68fNsfwMJMudzMtzODraQvF5TsdY_003D();
		result._0023_003Dq5I_0JPp_00243K2prDpmsXuX_Q_003D_003D = _0023_003Dqujh2utovxiqAHR9xHGOrKg_003D_003D._0023_003DqF19Q3InsvIJeGdy68fNsfwMJMudzMtzODraQvF5TsdY_003D();
		result._0023_003Dq5ZispjfFNDEu7dqW5ZckNA_003D_003D = _0023_003Dqujh2utovxiqAHR9xHGOrKg_003D_003D._0023_003DqF19Q3InsvIJeGdy68fNsfwMJMudzMtzODraQvF5TsdY_003D();
		return result;
	}

	private static byte[] _0023_003DqPAG6nKQkiZxg18xvZbGmFA_003D_003D(BinaryReader _0023_003DqZzQomCfpZxvSq_0024DlQc4jZQ_003D_003D, int _0023_003DqpiVAGfVGTeF0uePUiXB3mQ_003D_003D)
	{
		List<byte> list = new List<byte>();
		_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D _0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D2 = (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D)0;
		int num = 0;
		int num2 = 0;
		while (list.Count < _0023_003DqpiVAGfVGTeF0uePUiXB3mQ_003D_003D)
		{
			byte b = _0023_003DqZzQomCfpZxvSq_0024DlQc4jZQ_003D_003D.ReadByte();
			switch (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D2)
			{
			case (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D)0:
			{
				sbyte b2 = (sbyte)b;
				if (b2 != sbyte.MinValue)
				{
					if (b2 >= 0)
					{
						_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D2 = (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D)1;
						num = 1 + b2;
					}
					else
					{
						_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D2 = (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D)2;
						num2 = 1 - b2;
					}
				}
				break;
			}
			case (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D)1:
				list.Add(b);
				num--;
				if (num == 0)
				{
					_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D2 = (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D)0;
				}
				break;
			case (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D)2:
			{
				for (int i = 0; i < num2; i++)
				{
					list.Add(b);
				}
				num2 = 0;
				_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D2 = (_0023_003DqADEcllYT9vBsVfr3WznoE_qhHxSD6X70pShvJnvVS9Q_003D)0;
				break;
			}
			}
		}
		_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(list.Count == _0023_003DqpiVAGfVGTeF0uePUiXB3mQ_003D_003D);
		return list.ToArray();
	}

	private static List<PsdImageResource> _0023_003Dq5PpXCN3xw9ZO96qqzbihjxsuHyf0brKEwzswy0cvU10_003D(BinaryReader _0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D)
	{
		Stream baseStream = _0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D.BaseStream;
		List<PsdImageResource> list = new List<PsdImageResource>();
		uint num = _0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
		long num2 = baseStream.Position + num;
		while (baseStream.Position < num2)
		{
			_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(Encoding.ASCII.GetString(_0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D.ReadBytes(4)) == _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808811));
			_0023_003Dq8UUwFWWxFg0lkzbZyZSdjXCv8vUhEna2FFIliqtbOL0_003D _0023_003DqvBNZFNBS0Y4V_5QP7f_0024h2w_003D_003D = (_0023_003Dq8UUwFWWxFg0lkzbZyZSdjXCv8vUhEna2FFIliqtbOL0_003D)_0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D._0023_003DqC4KgRv5cJ_1MxVoRxWHBBErNkwGMxt7IiSqBDh0DGLQ_003D();
			byte count = _0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D.ReadByte();
			string _0023_003DqKs8VqE4bSwfni0OBKayLOA_003D_003D = Encoding.ASCII.GetString(_0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D.ReadBytes(count));
			if (baseStream.Position % 2 == 1)
			{
				baseStream.Position++;
			}
			uint count2 = _0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D();
			byte[] _0023_003DqoUrco_Tt03bLdVjjoDsixA_003D_003D = _0023_003Dq24j0Yb5tzxg9k6J13ZXsQg_003D_003D.ReadBytes((int)count2);
			if (baseStream.Position % 2 == 1)
			{
				baseStream.Position++;
			}
			list.Add(new PsdImageResource
			{
				_0023_003DqvBNZFNBS0Y4V_5QP7f_0024h2w_003D_003D = _0023_003DqvBNZFNBS0Y4V_5QP7f_0024h2w_003D_003D,
				_0023_003DqKs8VqE4bSwfni0OBKayLOA_003D_003D = _0023_003DqKs8VqE4bSwfni0OBKayLOA_003D_003D,
				_0023_003DqoUrco_Tt03bLdVjjoDsixA_003D_003D = _0023_003DqoUrco_Tt03bLdVjjoDsixA_003D_003D
			});
		}
		_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(baseStream.Position == num2);
		return list;
	}

	public static List<PsdGuide> _0023_003DqxEqFMy2YRYXqz8MFAFWnTXjPNezjrRXhc0gVVqYK9wM_003D(string _0023_003DqccVyH__Lwd8lU4fI6ahCvw_003D_003D)
	{
		FileStream fileStream = new FileStream(_0023_003DqccVyH__Lwd8lU4fI6ahCvw_003D_003D, FileMode.Open, FileAccess.Read);
		try
		{
			BinaryReader binaryReader = new BinaryReader(fileStream);
			try
			{
				fileStream.Position += 26L;
				_0023_003DqmVxRHTZPD7bnBf_0024g0vbybA_003D_003D(binaryReader._0023_003DqENQ4D_0024ExJyoD74fOrp2LGMdQUtKzHEU3uRlyCTWE4iw_003D() == 0);
				return _0023_003DqwvMAiGhwiQcL9BEfsv_0024hqw_003D_003D(_0023_003Dq5PpXCN3xw9ZO96qqzbihjxsuHyf0brKEwzswy0cvU10_003D(binaryReader));
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
}
