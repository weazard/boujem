using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

public static class _0023_003Dqylp6qUNKsVhvfdDlLuvMcw_003D_003D
{
	[StructLayout(LayoutKind.Auto)]
	private struct _0023_003DqeRlpor_0024dS_0024wn92ic0Pu6lVjyhKAnN94cN1s9lkYNZWQ_003D
	{
		public StringBuilder _0023_003DqgdgZC5bNjL7UyozSBQoeig_003D_003D;
	}

	public static readonly Language[] _0023_003DqjgzWHVAZ17gACAqwMK6O_0024A_003D_003D = new Language[11]
	{
		Language.English,
		Language.French,
		Language.German,
		Language.Spanish,
		Language.Portuguese,
		Language.Polish,
		Language.Russian,
		Language.ChineseSimplified,
		Language.ChineseTraditional,
		Language.Japanese,
		Language.Korean
	};

	private static readonly Dictionary<Language, CultureInfo> _0023_003Dq9xMhIk_0024ZQ_4q6EIUfZmIYZhmuGBnVdGfBo2ppDt6ivA_003D = new Dictionary<Language, CultureInfo>
	{
		{
			Language.English,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777754))
		},
		{
			Language.French,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777774))
		},
		{
			Language.German,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777762))
		},
		{
			Language.Spanish,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777782))
		},
		{
			Language.Portuguese,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777802))
		},
		{
			Language.Polish,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777822))
		},
		{
			Language.Russian,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777810))
		},
		{
			Language.ChineseSimplified,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777830))
		},
		{
			Language.ChineseTraditional,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777850))
		},
		{
			Language.Japanese,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777870))
		},
		{
			Language.Korean,
			new CultureInfo(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777858))
		}
	};

	public static readonly string _0023_003DqZA8JgVvOBLfRjP0QsBwDcw_003D_003D = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777878);

	private static readonly Dictionary<char, char> _0023_003Dqo7JehWt_udYjiTqpMQ3jKc9FmwjWF1JQHrCqXNGbHqU_003D = new Dictionary<char, char>
	{
		{ 'A', 'À' },
		{ 'B', 'ẞ' },
		{ 'C', 'Ç' },
		{ 'D', 'D' },
		{ 'E', 'E' },
		{ 'F', 'F' },
		{ 'G', 'G' },
		{ 'H', 'Н' },
		{ 'I', 'Î' },
		{ 'J', 'J' },
		{ 'K', 'К' },
		{ 'L', 'L' },
		{ 'M', 'М' },
		{ 'N', 'Ñ' },
		{ 'O', 'Ó' },
		{ 'P', 'Р' },
		{ 'Q', 'Q' },
		{ 'R', 'R' },
		{ 'S', 'S' },
		{ 'T', 'Т' },
		{ 'U', 'Ü' },
		{ 'V', 'V' },
		{ 'W', 'W' },
		{ 'X', 'X' },
		{ 'Y', 'Ÿ' },
		{ 'Z', 'Z' },
		{ 'a', 'à' },
		{ 'b', 'Ь' },
		{ 'c', 'ç' },
		{ 'd', 'd' },
		{ 'e', 'ê' },
		{ 'f', 'f' },
		{ 'g', 'g' },
		{ 'h', 'h' },
		{ 'i', 'î' },
		{ 'j', 'j' },
		{ 'k', 'k' },
		{ 'l', 'l' },
		{ 'm', 'm' },
		{ 'n', 'ñ' },
		{ 'o', 'ó' },
		{ 'p', 'p' },
		{ 'q', 'q' },
		{ 'r', 'r' },
		{ 's', 's' },
		{ 't', 't' },
		{ 'u', 'ü' },
		{ 'v', 'v' },
		{ 'w', 'w' },
		{ 'x', 'x' },
		{ 'y', 'ÿ' },
		{ 'z', 'z' }
	};

	private static readonly Dictionary<char, char> _0023_003DqW_CaeqnEyUHWhpBc9Q96K1UZrHUtEaOA2rdSmPON3m8_003D = new Dictionary<char, char>
	{
		{ 'A', 'Д' },
		{ 'B', 'Б' },
		{ 'C', 'С' },
		{ 'D', 'D' },
		{ 'E', 'Ё' },
		{ 'F', 'F' },
		{ 'G', 'G' },
		{ 'H', 'Н' },
		{ 'I', 'I' },
		{ 'J', 'J' },
		{ 'K', 'К' },
		{ 'L', 'L' },
		{ 'M', 'М' },
		{ 'N', 'Й' },
		{ 'O', 'Ф' },
		{ 'P', 'Р' },
		{ 'Q', 'Q' },
		{ 'R', 'Я' },
		{ 'S', 'S' },
		{ 'T', 'Т' },
		{ 'U', 'Ц' },
		{ 'V', 'V' },
		{ 'W', 'Щ' },
		{ 'X', 'Ж' },
		{ 'Y', 'У' },
		{ 'Z', 'Z' },
		{ 'a', 'д' },
		{ 'b', 'Ь' },
		{ 'c', 'с' },
		{ 'd', 'd' },
		{ 'e', 'ё' },
		{ 'f', 'f' },
		{ 'g', 'g' },
		{ 'h', 'н' },
		{ 'i', 'i' },
		{ 'j', 'j' },
		{ 'k', 'к' },
		{ 'l', 'l' },
		{ 'm', 'м' },
		{ 'n', 'й' },
		{ 'o', 'о' },
		{ 'p', 'p' },
		{ 'q', 'q' },
		{ 'r', 'я' },
		{ 's', 's' },
		{ 't', 'т' },
		{ 'u', 'ц' },
		{ 'v', 'v' },
		{ 'w', 'щ' },
		{ 'x', 'ж' },
		{ 'y', 'у' },
		{ 'z', 'z' }
	};

	private static readonly string _0023_003DqaRUcypJ2cYsNX_MKT87vRaVuR8_0024ABPq_0024h6RAqxtOSIo_003D = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777918);

	private static readonly char[] _0023_003Dqh_00246WzCmS2lCFi64q4D1hmg_003D_003D = new char[5] { '。', '，', '、', '？', '！' };

	public static Language _0023_003DqM7vymeVaO_00244VKiQRCRJSHESpyw6KV9DhEGp0Jsnx2Qo_003D = Language.English;

	private static Dictionary<string, _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D> _0023_003DqWSTdsK7o9q_00244M4qAWWRPiSuCTv3zZF8JC_1mLU41DgM_003D;

	public static bool _0023_003Dq0_00245smPRh3LHl2guQpjQ9_0024d6cjOs141hyrvgvHeIp1TA_003D()
	{
		if (_0023_003DqM7vymeVaO_00244VKiQRCRJSHESpyw6KV9DhEGp0Jsnx2Qo_003D != Language.ChineseSimplified && _0023_003DqM7vymeVaO_00244VKiQRCRJSHESpyw6KV9DhEGp0Jsnx2Qo_003D != Language.ChineseTraditional && _0023_003DqM7vymeVaO_00244VKiQRCRJSHESpyw6KV9DhEGp0Jsnx2Qo_003D != Language.Japanese)
		{
			return _0023_003DqM7vymeVaO_00244VKiQRCRJSHESpyw6KV9DhEGp0Jsnx2Qo_003D == Language.Korean;
		}
		return true;
	}

	public static void _0023_003DqTPA2zGb4rtsAK0yUueMybg_003D_003D()
	{
		_0023_003DqWSTdsK7o9q_00244M4qAWWRPiSuCTv3zZF8JC_1mLU41DgM_003D = new Dictionary<string, _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D>();
		_0023_003DqeRlpor_0024dS_0024wn92ic0Pu6lVjyhKAnN94cN1s9lkYNZWQ_003D _0023_003DqrfkVZeczaGy2WWeykxO1rA_003D_003D = default(_0023_003DqeRlpor_0024dS_0024wn92ic0Pu6lVjyhKAnN94cN1s9lkYNZWQ_003D);
		foreach (string item in File.ReadAllText(Path.Combine(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065775396), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778099), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778113))).Split(new char[1] { '\n' }).Skip(1))
		{
			List<string> list = Utility._0023_003DqxnuVY_00246fOx141y9w0ivelw_003D_003D(item);
			while (list.Count < _0023_003DqjgzWHVAZ17gACAqwMK6O_0024A_003D_003D.Length + 1)
			{
				list.Add(string.Empty);
			}
			string text = list[0].Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778131), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778150));
			int num = text.IndexOf(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778174));
			string text2 = ((num >= 0) ? text.Substring(0, num) : text);
			for (int i = 2; i < list.Count; i++)
			{
				if (string.IsNullOrWhiteSpace(list[i]))
				{
					list[i] = (_0023_003Dqjtd0RhaH_eDUMwKnGl0SnA_003D_003D._0023_003DqV91imo4zKxyJS7UV9Nik4A_003D_003D ? _0023_003DqZA8JgVvOBLfRjP0QsBwDcw_003D_003D : text2);
				}
			}
			_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2 = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D();
			_0023_003DqWSTdsK7o9q_00244M4qAWWRPiSuCTv3zZF8JC_1mLU41DgM_003D[text] = _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2;
			_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[Language.English] = _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(text2, Language.English);
			for (int j = 1; j < _0023_003DqjgzWHVAZ17gACAqwMK6O_0024A_003D_003D.Length; j++)
			{
				Language language = _0023_003DqjgzWHVAZ17gACAqwMK6O_0024A_003D_003D[j];
				_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[language] = _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(list[j + 1].Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778131), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778150)), language);
			}
			string text3;
			if (_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003Dq_00248rsd7xRXcH7Y61b_fZD7hbBLUlMR_0024w_ATs_0024VurGiCI_003D)
			{
				StringBuilder stringBuilder = new StringBuilder();
				text3 = text2;
				foreach (char c in text3)
				{
					stringBuilder.Append(_0023_003Dqo7JehWt_udYjiTqpMQ3jKc9FmwjWF1JQHrCqXNGbHqU_003D._0023_003Dqfjn_0024ooPv9m98_0024N4BBnAapQ_003D_003D(c)._0023_003DqcH4ZRa_0024zHPEYvYMVjHc4bg_003D_003D(c));
				}
				_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[Language.French] = _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(stringBuilder.ToString(), Language.French);
				_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[Language.German] = _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(stringBuilder.ToString(), Language.French);
				_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[Language.Spanish] = _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(stringBuilder.ToString(), Language.French);
				_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[Language.Portuguese] = _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(stringBuilder.ToString(), Language.French);
			}
			if (_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DqDDiSbtkuiS6zg8VLG_ZOcmWcSP43CHkwWXoKydSKKWs_003D)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				text3 = text2;
				foreach (char c2 in text3)
				{
					stringBuilder2.Append(_0023_003DqW_CaeqnEyUHWhpBc9Q96K1UZrHUtEaOA2rdSmPON3m8_003D._0023_003Dqfjn_0024ooPv9m98_0024N4BBnAapQ_003D_003D(c2)._0023_003DqcH4ZRa_0024zHPEYvYMVjHc4bg_003D_003D(c2));
				}
				_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[Language.Russian] = _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(stringBuilder2.ToString(), Language.Russian);
			}
			if (!_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003DquZRXgQnEVi7DdqE_1DKS5SoXg4nu_0024b8WptAkFPtJWUk_003D)
			{
				continue;
			}
			_0023_003DqrfkVZeczaGy2WWeykxO1rA_003D_003D._0023_003DqgdgZC5bNjL7UyozSBQoeig_003D_003D = new StringBuilder();
			int num2 = 0;
			text3 = text2;
			foreach (char c3 in text3)
			{
				if (char.IsLetter(c3))
				{
					num2++;
					continue;
				}
				_0023_003Dq6h5IeVmEzASBUYma_0024F4DrVv549R2wZzpUmOxLavr6vc_003D(num2, ref _0023_003DqrfkVZeczaGy2WWeykxO1rA_003D_003D);
				num2 = 0;
				if (c3 != ' ')
				{
					_0023_003DqrfkVZeczaGy2WWeykxO1rA_003D_003D._0023_003DqgdgZC5bNjL7UyozSBQoeig_003D_003D.Append(c3);
				}
			}
			_0023_003Dq6h5IeVmEzASBUYma_0024F4DrVv549R2wZzpUmOxLavr6vc_003D(num2, ref _0023_003DqrfkVZeczaGy2WWeykxO1rA_003D_003D);
			_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[Language.ChineseSimplified] = _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(_0023_003DqrfkVZeczaGy2WWeykxO1rA_003D_003D._0023_003DqgdgZC5bNjL7UyozSBQoeig_003D_003D.ToString(), Language.ChineseSimplified);
		}
	}

	public static string _0023_003DqlFDEo3Rcs2VN78qA7CJb2g_003D_003D(string _0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D, Language _0023_003DqwVX1MpQEgzBKsOYBkOtT_g_003D_003D)
	{
		_0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D = _0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D.Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065774946), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778150));
		_0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D = _0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D._0023_003DqaT_00248Pb5ixk3Jgz4yjh0VOw_003D_003D();
		if (_0023_003DqwVX1MpQEgzBKsOYBkOtT_g_003D_003D == Language.ChineseSimplified || _0023_003DqwVX1MpQEgzBKsOYBkOtT_g_003D_003D == Language.ChineseTraditional)
		{
			StringBuilder stringBuilder = new StringBuilder();
			string text = _0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D;
			foreach (char c in text)
			{
				if (_0023_003DqeolOBhRv30fxE8IbAx7hHuNkyxIi9n1nN6T6qZZGVp0_003D(c) && stringBuilder.Length > 0 && _0023_003DqeolOBhRv30fxE8IbAx7hHuNkyxIi9n1nN6T6qZZGVp0_003D(stringBuilder[stringBuilder.Length - 1]))
				{
					stringBuilder = stringBuilder.Append('●');
				}
				stringBuilder.Append(c);
			}
			_0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D = stringBuilder.ToString();
		}
		if (_0023_003DqwVX1MpQEgzBKsOYBkOtT_g_003D_003D == Language.ChineseSimplified || _0023_003DqwVX1MpQEgzBKsOYBkOtT_g_003D_003D == Language.ChineseTraditional || _0023_003DqwVX1MpQEgzBKsOYBkOtT_g_003D_003D == Language.Japanese)
		{
			char[] array = _0023_003Dqh_00246WzCmS2lCFi64q4D1hmg_003D_003D;
			for (int i = 0; i < array.Length; i++)
			{
				char c2 = array[i];
				_0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D = _0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D.Replace(c2.ToString() ?? string.Empty, c2 + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778168));
			}
		}
		while (_0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D.Contains(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065807887)))
		{
			_0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D = _0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D.Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065807887), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778168));
		}
		_0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D = _0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D.Replace(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065807876), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065778150));
		return _0023_003DqpDTUh_0024WaSHahT24yS4gb0Q_003D_003D;
	}

	private static bool _0023_003DqeolOBhRv30fxE8IbAx7hHuNkyxIi9n1nN6T6qZZGVp0_003D(char _0023_003Dqo57m9xAV6USgDad9n82wLw_003D_003D)
	{
		if (_0023_003Dqo57m9xAV6USgDad9n82wLw_003D_003D >= '一')
		{
			return _0023_003Dqo57m9xAV6USgDad9n82wLw_003D_003D <= '鿿';
		}
		return false;
	}

	public static _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqOL206uktbqbSGKVobHixYw_003D_003D(string _0023_003Dqm_0024NSS9p91j6SlMa3T5Q1pw_003D_003D)
	{
		if (_0023_003DqWSTdsK7o9q_00244M4qAWWRPiSuCTv3zZF8JC_1mLU41DgM_003D.TryGetValue(_0023_003Dqm_0024NSS9p91j6SlMa3T5Q1pw_003D_003D, out var value))
		{
			return value;
		}
		return _0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(_0023_003Dqjtd0RhaH_eDUMwKnGl0SnA_003D_003D._0023_003DqV91imo4zKxyJS7UV9Nik4A_003D_003D ? _0023_003DqZA8JgVvOBLfRjP0QsBwDcw_003D_003D : _0023_003Dqm_0024NSS9p91j6SlMa3T5Q1pw_003D_003D);
	}

	public static _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003DqVcyZvbCOXye91QJcUlZHyw_003D_003D(string _0023_003Dq_0024_j5w2_0024bZG_OSgc_dIeNVA_003D_003D)
	{
		_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2 = new _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D();
		Language[] array = _0023_003DqjgzWHVAZ17gACAqwMK6O_0024A_003D_003D;
		foreach (Language key in array)
		{
			_0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2._0023_003DqtiZEnw61ZK5uza_0024DNU6aZg_003D_003D[key] = _0023_003Dq_0024_j5w2_0024bZG_OSgc_dIeNVA_003D_003D;
		}
		return _0023_003Dq2wckbtn2WQlrITJFjb67Wg_003D_003D2;
	}

	public static CultureInfo _0023_003DqdduoJQTUcH2e4L8jFmDLBQ_003D_003D(Language _0023_003Dq6gohzBDdqgIeTIFMEWXHjg_003D_003D)
	{
		return _0023_003Dq9xMhIk_0024ZQ_4q6EIUfZmIYZhmuGBnVdGfBo2ppDt6ivA_003D[_0023_003Dq6gohzBDdqgIeTIFMEWXHjg_003D_003D];
	}

	public static string _0023_003DqCkf1M53d4dTRyWRFwZQMxNOqwahEiUIKSqUNYRci4_k_003D(Language _0023_003Dq8pINKKQXRvGJZ_0024sbrfw_FA_003D_003D)
	{
		return _0023_003Dq8pINKKQXRvGJZ_0024sbrfw_FA_003D_003D switch
		{
			Language.ChineseSimplified => _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065807893), 
			Language.ChineseTraditional => _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065807910), 
			_ => _0023_003DqdduoJQTUcH2e4L8jFmDLBQ_003D_003D(_0023_003Dq8pINKKQXRvGJZ_0024sbrfw_FA_003D_003D).Parent.NativeName, 
		};
	}

	public static string _0023_003DqI4XafJjncVVN_0024vjVL2j3tqr63Zcb68PVzRoPskGUn1I_003D(Language _0023_003Dq8MrApf_q_ZT49Hb7oLHoZw_003D_003D)
	{
		return _0023_003DqdduoJQTUcH2e4L8jFmDLBQ_003D_003D(_0023_003Dq8MrApf_q_ZT49Hb7oLHoZw_003D_003D).Name;
	}

	internal static void _0023_003Dq6h5IeVmEzASBUYma_0024F4DrVv549R2wZzpUmOxLavr6vc_003D(int _0023_003Dqp_G_8RJAsqGverLepypF8w_003D_003D, ref _0023_003DqeRlpor_0024dS_0024wn92ic0Pu6lVjyhKAnN94cN1s9lkYNZWQ_003D _0023_003DqrfkVZeczaGy2WWeykxO1rA_003D_003D)
	{
		if (_0023_003Dqp_G_8RJAsqGverLepypF8w_003D_003D > 0)
		{
			_0023_003Dqp_G_8RJAsqGverLepypF8w_003D_003D = (int)Math.Max(2.0, Math.Ceiling((float)_0023_003Dqp_G_8RJAsqGverLepypF8w_003D_003D / 4f));
			for (int i = 0; i < _0023_003Dqp_G_8RJAsqGverLepypF8w_003D_003D; i++)
			{
				_0023_003DqrfkVZeczaGy2WWeykxO1rA_003D_003D._0023_003DqgdgZC5bNjL7UyozSBQoeig_003D_003D.Append(_0023_003DqaRUcypJ2cYsNX_MKT87vRaVuR8_0024ABPq_0024h6RAqxtOSIo_003D[GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqHtYmxlm3gp_0024A4K1Vg3T8gQ_003D_003D._0023_003DqKCogRp02J_00247oki_mnEW6YA_003D_003D(0, _0023_003DqaRUcypJ2cYsNX_MKT87vRaVuR8_0024ABPq_0024h6RAqxtOSIo_003D.Length)]);
			}
		}
	}
}
