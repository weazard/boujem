using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public sealed class IniFile
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__18_0;

		public static Func<FileInfo, DateTime> _003C_003E9__18_1;

		internal string _0023_003DqAkJ46vRPVhO1bmRkvyghJFzp3j6JXqhbjqN76ET0iTg_003D(KeyValuePair<string, string> _0023_003DqbkdanHSa4s_hQKr3lG3AEw_003D_003D)
		{
			return _0023_003DqbkdanHSa4s_hQKr3lG3AEw_003D_003D.Key;
		}

		internal DateTime _0023_003Dqe8USqdZkZntCIIablbaEPkV6WmzWIPp9qZLNJYq5SXo_003D(FileInfo _0023_003DqIJ2I4uEDcT7WNx1QzVovhQ_003D_003D)
		{
			return _0023_003DqIJ2I4uEDcT7WNx1QzVovhQ_003D_003D.CreationTime;
		}
	}

	private readonly string _0023_003DqR7LQXIqgpFFcXE_0024yKg_0024huQ_003D_003D;

	private readonly bool _0023_003DqCy2rbShd003w8dPlGq1wSQ_003D_003D;

	private Dictionary<string, string> _0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D = new Dictionary<string, string>();

	private bool _0023_003DqjZGjHHMk_GF2sWQdzBmeaA_003D_003D;

	private Time _0023_003DqkiC38dywZhi2Irrnh2O5iQ_003D_003D = Time.MinValue;

	private static readonly _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D _0023_003DqECurHYnelsF21_00248ARszzFw_003D_003D = _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D._0023_003DqolE06AQhawesFg8JQVkw0g_003D_003D(60.0);

	private static readonly int _0023_003DqgJLXtK_5ktelu0kD_0024lMcXg_003D_003D = 10;

	private static readonly string _0023_003DqdGBO9Xx6ipbmyEhJF4y2RA_003D_003D = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777034);

	public IniFile(string _0023_003DqPyVZrZinffZwtRGGG_00240iuw_003D_003D, bool _0023_003DqkhNzujBZ6Lvu2CrDs1tCRQ_003D_003D)
	{
		_0023_003DqR7LQXIqgpFFcXE_0024yKg_0024huQ_003D_003D = _0023_003DqPyVZrZinffZwtRGGG_00240iuw_003D_003D;
		_0023_003DqCy2rbShd003w8dPlGq1wSQ_003D_003D = _0023_003DqkhNzujBZ6Lvu2CrDs1tCRQ_003D_003D;
		_0023_003Dquj3iVp45emKVtRffEbDDGA_003D_003D();
	}

	public IEnumerable<string> _0023_003DqAlJNyU57fEsEPWK_ozqiSQ_003D_003D()
	{
		return _0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D.Keys;
	}

	public void _0023_003Dqf14b_0024YjWGFhM6oJyQ6mbvg_003D_003D(string _0023_003Dq2oKygXynjHwc_MHZw_00241T_0024g_003D_003D, string _0023_003DqTh6TI9OwRlISe8i6p4GCyg_003D_003D)
	{
		_0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D[_0023_003Dq2oKygXynjHwc_MHZw_00241T_0024g_003D_003D] = _0023_003DqTh6TI9OwRlISe8i6p4GCyg_003D_003D;
		_0023_003DqjZGjHHMk_GF2sWQdzBmeaA_003D_003D = true;
	}

	public void _0023_003Dq8tzeyatwMbkI5DgxHT0dJw_003D_003D(string _0023_003DqdfzMPG05hiW4_0024B6gLxbUgQ_003D_003D)
	{
		_0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D.Remove(_0023_003DqdfzMPG05hiW4_0024B6gLxbUgQ_003D_003D);
		_0023_003DqjZGjHHMk_GF2sWQdzBmeaA_003D_003D = true;
	}

	public void _0023_003DqOCLYtCbWk4iZ4Br5IhzsTQ_003D_003D(string _0023_003Dq_0024g0bSFMBCG_K9NpATnIAPg_003D_003D, Maybe<string> _0023_003DqL0c5vWn06UF36tyAckzfkg_003D_003D)
	{
		if (_0023_003DqL0c5vWn06UF36tyAckzfkg_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			_0023_003Dqf14b_0024YjWGFhM6oJyQ6mbvg_003D_003D(_0023_003Dq_0024g0bSFMBCG_K9NpATnIAPg_003D_003D, _0023_003DqL0c5vWn06UF36tyAckzfkg_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
		}
		else
		{
			_0023_003Dq8tzeyatwMbkI5DgxHT0dJw_003D_003D(_0023_003Dq_0024g0bSFMBCG_K9NpATnIAPg_003D_003D);
		}
	}

	public Maybe<string> _0023_003Dq5oeYo3OKmd2wsBW3bFCaOw_003D_003D(string _0023_003DqowOic43OexEKJn8Tj8kHSQ_003D_003D)
	{
		return _0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D._0023_003Dqfjn_0024ooPv9m98_0024N4BBnAapQ_003D_003D(_0023_003DqowOic43OexEKJn8Tj8kHSQ_003D_003D);
	}

	public Maybe<T> _0023_003Dqtvb2BZsOUugWizUdNSK_Wg_003D_003D<T>(global::_0023_003DqXrTCwKFbt95txEClrIyA2PFS7x9pqZBRjkgAQScJSFQ_003D<T> _0023_003DqBjT2Ofb_BKTzS_0024oj_0024IhGLw_003D_003D, string _0023_003Dqr6SG7wDA40jGDPzAAks5MA_003D_003D)
	{
		if (_0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D.TryGetValue(_0023_003Dqr6SG7wDA40jGDPzAAks5MA_003D_003D, out var value) && _0023_003DqBjT2Ofb_BKTzS_0024oj_0024IhGLw_003D_003D(value, out var _0023_003DqBJc5EMVCoKZvh5Dpm8mt6A_003D_003D))
		{
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqviLfXxoe0_lhumqA0McvDA_003D_003D(_0023_003DqBJc5EMVCoKZvh5Dpm8mt6A_003D_003D);
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public void _0023_003DqsuEgT_0024S6pjK3pAaWnstwocydnsMf5LcgSzkpUCva4ac_003D()
	{
		if (_0023_003DqjZGjHHMk_GF2sWQdzBmeaA_003D_003D)
		{
			_0023_003DqY_N9LbM7YpoRSA38bdNoWQ_003D_003D();
			_0023_003DqjZGjHHMk_GF2sWQdzBmeaA_003D_003D = false;
		}
	}

	private void _0023_003Dquj3iVp45emKVtRffEbDDGA_003D_003D()
	{
		_0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D.Clear();
		if (!File.Exists(_0023_003DqR7LQXIqgpFFcXE_0024yKg_0024huQ_003D_003D))
		{
			return;
		}
		string text = File.ReadAllText(_0023_003DqR7LQXIqgpFFcXE_0024yKg_0024huQ_003D_003D);
		if (_0023_003DqCy2rbShd003w8dPlGq1wSQ_003D_003D && !text.TrimEnd(Array.Empty<char>()).EndsWith(_0023_003DqdGBO9Xx6ipbmyEhJF4y2RA_003D_003D))
		{
			throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777046) + Path.GetFileName(_0023_003DqR7LQXIqgpFFcXE_0024yKg_0024huQ_003D_003D));
		}
		string[] array = text.Split(new char[1] { '\n' });
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(new char[1] { '=' }, 2);
			if (array2.Length == 2)
			{
				string key = array2[0].Trim();
				string value = array2[1].Trim();
				_0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D[key] = value;
			}
		}
	}

	private void _0023_003DqY_N9LbM7YpoRSA38bdNoWQ_003D_003D()
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, string> item in _0023_003Dq7TIFOY2n0YivVUSW4ffoAA_003D_003D.OrderBy(_003C_003Ec._003C_003E9._0023_003DqAkJ46vRPVhO1bmRkvyghJFzp3j6JXqhbjqN76ET0iTg_003D))
		{
			list.Add(string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065774930), item.Key, item.Value));
		}
		if (_0023_003DqCy2rbShd003w8dPlGq1wSQ_003D_003D)
		{
			list.Add(string.Empty);
			list.Add(string.Empty);
			list.Add(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777086));
			list.Add(_0023_003DqdGBO9Xx6ipbmyEhJF4y2RA_003D_003D);
			list.Add(string.Empty);
		}
		string _0023_003DqSFy7zfTyA2Oxllipeaw9yA_003D_003D = string.Join(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065774946), list);
		Time time = Time.Now();
		_0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D2 = time - _0023_003DqkiC38dywZhi2Irrnh2O5iQ_003D_003D;
		if (_0023_003DqCy2rbShd003w8dPlGq1wSQ_003D_003D && _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D2 > _0023_003DqECurHYnelsF21_00248ARszzFw_003D_003D)
		{
			_0023_003DqkiC38dywZhi2Irrnh2O5iQ_003D_003D = time;
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(_0023_003DqR7LQXIqgpFFcXE_0024yKg_0024huQ_003D_003D);
			string extension = Path.GetExtension(_0023_003DqR7LQXIqgpFFcXE_0024yKg_0024huQ_003D_003D);
			string path = string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777134), fileNameWithoutExtension, DateTime.UtcNow.Ticks, extension);
			string _0023_003DqMOQ_0024SmoXLGSiSvKWaU8mmw_003D_003D = Path.Combine(GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqH9EjToNaNelXQT1fmjJ1Lw_003D_003D(), path);
			GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqrrHXsQwbCwgNpH1n2uSa5g_003D_003D._0023_003Dq3uRGRcZ2bz0G8NEcMFlRlQ_003D_003D(_0023_003DqMOQ_0024SmoXLGSiSvKWaU8mmw_003D_003D, _0023_003DqSFy7zfTyA2Oxllipeaw9yA_003D_003D);
			FileInfo[] array = new DirectoryInfo(GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqH9EjToNaNelXQT1fmjJ1Lw_003D_003D()).GetFiles().OrderByDescending(_003C_003Ec._003C_003E9._0023_003Dqe8USqdZkZntCIIablbaEPkV6WmzWIPp9qZLNJYq5SXo_003D).ToArray();
			for (int i = _0023_003DqgJLXtK_5ktelu0kD_0024lMcXg_003D_003D; i < array.Length; i++)
			{
				array[i].Delete();
			}
		}
		GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqrrHXsQwbCwgNpH1n2uSa5g_003D_003D._0023_003Dq3uRGRcZ2bz0G8NEcMFlRlQ_003D_003D(_0023_003DqR7LQXIqgpFFcXE_0024yKg_0024huQ_003D_003D, _0023_003DqSFy7zfTyA2Oxllipeaw9yA_003D_003D);
	}
}
