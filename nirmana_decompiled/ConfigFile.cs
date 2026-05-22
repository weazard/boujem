using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public sealed class ConfigFile
{
	private sealed class _0023_003DqFQ7oeTy4mzt8tLxFJo29V3dRMl1AmmL5cHOTs1xoGSU_003D : global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<Language>
	{
		public _0023_003DqFQ7oeTy4mzt8tLxFJo29V3dRMl1AmmL5cHOTs1xoGSU_003D(ConfigFile _0023_003Dq9qCRJppXf0gVsfriIxxkMw_003D_003D, string _0023_003DqVhI3Sdo_0024b0mi00xDUpLitg_003D_003D, Language _0023_003Dq5e8D_AVoBjWc03mUfgGJDA_003D_003D)
			: base(_0023_003Dq9qCRJppXf0gVsfriIxxkMw_003D_003D, _0023_003DqVhI3Sdo_0024b0mi00xDUpLitg_003D_003D, _0023_003Dq5e8D_AVoBjWc03mUfgGJDA_003D_003D)
		{
		}

		protected override Maybe<Language> _0023_003DqhMp6weeZF0icu7YgRcBfYA_003D_003D(string _0023_003Dq1fZd_8FePu1BjvCmfO53Pw_003D_003D)
		{
			if (Enum.TryParse<Language>(_0023_003Dq1fZd_8FePu1BjvCmfO53Pw_003D_003D, out var result))
			{
				return result;
			}
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		}

		protected override string _0023_003Dqu1mmdZ0EphaKrh7jYLMNHQ_003D_003D(Language _0023_003Dq4u_PGf_0024GqYRfFh3M7vzziw_003D_003D)
		{
			return _0023_003Dq4u_PGf_0024GqYRfFh3M7vzziw_003D_003D.ToString();
		}
	}

	private sealed class _0023_003Dqh6eEBU8PPTcr3t1sNmfnpw_003D_003D : global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<int>
	{
		public _0023_003Dqh6eEBU8PPTcr3t1sNmfnpw_003D_003D(ConfigFile _0023_003Dqv4ALwKKNO2_MngYyHFYGKQ_003D_003D, string _0023_003DqmlAUBt_0024mk8MluOdwXT85hg_003D_003D, int _0023_003DqhcUNEJlvv88W83ERFwZaoA_003D_003D)
			: base(_0023_003Dqv4ALwKKNO2_MngYyHFYGKQ_003D_003D, _0023_003DqmlAUBt_0024mk8MluOdwXT85hg_003D_003D, _0023_003DqhcUNEJlvv88W83ERFwZaoA_003D_003D)
		{
		}

		protected override Maybe<int> _0023_003DqhMp6weeZF0icu7YgRcBfYA_003D_003D(string _0023_003DqNZ6xmlnTGgQIXytvXaM7VQ_003D_003D)
		{
			if (int.TryParse(_0023_003DqNZ6xmlnTGgQIXytvXaM7VQ_003D_003D, out var result))
			{
				return result;
			}
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		}

		protected override string _0023_003Dqu1mmdZ0EphaKrh7jYLMNHQ_003D_003D(int _0023_003DqPI4FGoE1FgkrDjpOmGYUUQ_003D_003D)
		{
			return _0023_003DqPI4FGoE1FgkrDjpOmGYUUQ_003D_003D.ToString();
		}
	}

	public interface _0023_003Dqji6FxBdMyEK2IoTgpWZ3Cg_003D_003D
	{
		string _0023_003DqSCABzv8BlSMmyMPE_oimfw_003D_003D();

		string _0023_003Dq73fIpEFjPS665sxyd2kdXTAEnS8j64RQNZgfykMYWPs_003D();
	}

	private sealed class _0023_003DqnMAgHdPlOUpzfc_0024RGAJ_gmdtNlIVEpoEVTMrbVofnzw_003D : global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<string>
	{
		public _0023_003DqnMAgHdPlOUpzfc_0024RGAJ_gmdtNlIVEpoEVTMrbVofnzw_003D(ConfigFile _0023_003Dqa7Sji2G1T_sGFBI48VdyBA_003D_003D, string _0023_003DqlkwJTyW6Mn9T1FZtIPKVnA_003D_003D, string _0023_003DqMhgDcqIBDpdmhsan4a5n6A_003D_003D)
			: base(_0023_003Dqa7Sji2G1T_sGFBI48VdyBA_003D_003D, _0023_003DqlkwJTyW6Mn9T1FZtIPKVnA_003D_003D, _0023_003DqMhgDcqIBDpdmhsan4a5n6A_003D_003D)
		{
		}

		protected override Maybe<string> _0023_003DqhMp6weeZF0icu7YgRcBfYA_003D_003D(string _0023_003DqVExb4DvqxrxiSXGSU6noOg_003D_003D)
		{
			return _0023_003DqVExb4DvqxrxiSXGSU6noOg_003D_003D;
		}

		protected override string _0023_003Dqu1mmdZ0EphaKrh7jYLMNHQ_003D_003D(string _0023_003DqDnqwt3LRTS7bA1vvRfStmQ_003D_003D)
		{
			return _0023_003DqDnqwt3LRTS7bA1vvRfStmQ_003D_003D;
		}
	}

	private sealed class _0023_003DqNTHxARDL4T_msnB_0024517w_ML0BrXpMU1exDyv_tmuV2c_003D : global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<float>
	{
		public _0023_003DqNTHxARDL4T_msnB_0024517w_ML0BrXpMU1exDyv_tmuV2c_003D(ConfigFile _0023_003DqS3J3zoQRmprWeJQyAcPp8A_003D_003D, string _0023_003Dq8SL41V8rRcdB6humdrSvhg_003D_003D, float _0023_003DqYWvsdSq9xTd8xSnD7_uE9Q_003D_003D)
			: base(_0023_003DqS3J3zoQRmprWeJQyAcPp8A_003D_003D, _0023_003Dq8SL41V8rRcdB6humdrSvhg_003D_003D, _0023_003DqYWvsdSq9xTd8xSnD7_uE9Q_003D_003D)
		{
		}

		protected override Maybe<float> _0023_003DqhMp6weeZF0icu7YgRcBfYA_003D_003D(string _0023_003DqttZ0gQqbtv2anv6TcgWmCg_003D_003D)
		{
			if (!int.TryParse(_0023_003DqttZ0gQqbtv2anv6TcgWmCg_003D_003D, out var result))
			{
				return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
			}
			return (float)Utility._0023_003DqPketCwwzMXFnMETn36UPyQ_003D_003D(result, 0, 100) / 100f;
		}

		protected override string _0023_003Dqu1mmdZ0EphaKrh7jYLMNHQ_003D_003D(float _0023_003Dq576nEgcxdbtVUfWSZ1gCnA_003D_003D)
		{
			return ((int)Math.Round(100f * _0023_003Dq576nEgcxdbtVUfWSZ1gCnA_003D_003D)).ToString();
		}
	}

	private sealed class _0023_003DqwuqP0DwFPTH1xeB1mL7s9w_003D_003D : global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<Key>
	{
		public _0023_003DqwuqP0DwFPTH1xeB1mL7s9w_003D_003D(ConfigFile _0023_003DqSTCvnMMme_0024Lb_0024YKx6BYQqA_003D_003D, string _0023_003DqJgyrnzBp4FPE63Ouz7yXOg_003D_003D, Key _0023_003DqHHucnPSagHYxn8yVIkQxtw_003D_003D)
			: base(_0023_003DqSTCvnMMme_0024Lb_0024YKx6BYQqA_003D_003D, _0023_003DqJgyrnzBp4FPE63Ouz7yXOg_003D_003D, _0023_003DqHHucnPSagHYxn8yVIkQxtw_003D_003D)
		{
		}

		protected override Maybe<Key> _0023_003DqhMp6weeZF0icu7YgRcBfYA_003D_003D(string _0023_003Dqo1rguycNhs3sl8wXvbDkgA_003D_003D)
		{
			if (int.TryParse(_0023_003Dqo1rguycNhs3sl8wXvbDkgA_003D_003D, out var result))
			{
				return (Key)result;
			}
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		}

		protected override string _0023_003Dqu1mmdZ0EphaKrh7jYLMNHQ_003D_003D(Key _0023_003DqL0c5vWn06UF36tyAckzfkg_003D_003D)
		{
			int num = (int)_0023_003DqL0c5vWn06UF36tyAckzfkg_003D_003D;
			return num.ToString();
		}
	}

	private sealed class _0023_003DqWw_0024yEEYqp0VVyELZaG19UtPTBMhI7omyprvk_00248CmkKw_003D : global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<bool>
	{
		public _0023_003DqWw_0024yEEYqp0VVyELZaG19UtPTBMhI7omyprvk_00248CmkKw_003D(ConfigFile _0023_003Dq96NKZEVhTuk4no976y3c8g_003D_003D, string _0023_003DqKqSl7rOQDrTic7g6ibs1qg_003D_003D, bool _0023_003DqkoaOWOaI1rwPG3zjrp_0024Bdg_003D_003D)
			: base(_0023_003Dq96NKZEVhTuk4no976y3c8g_003D_003D, _0023_003DqKqSl7rOQDrTic7g6ibs1qg_003D_003D, _0023_003DqkoaOWOaI1rwPG3zjrp_0024Bdg_003D_003D)
		{
		}

		protected override Maybe<bool> _0023_003DqhMp6weeZF0icu7YgRcBfYA_003D_003D(string _0023_003DqSYs9EQM1994MrS4wY7cgFw_003D_003D)
		{
			if (bool.TryParse(_0023_003DqSYs9EQM1994MrS4wY7cgFw_003D_003D, out var result))
			{
				return result;
			}
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		}

		protected override string _0023_003Dqu1mmdZ0EphaKrh7jYLMNHQ_003D_003D(bool _0023_003DqWgXVeExjEa_00242BffEPss1VA_003D_003D)
		{
			return _0023_003DqWgXVeExjEa_00242BffEPss1VA_003D_003D.ToString();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__10_0;

		internal string _0023_003Dq_9XUvjyUOC_tR21LxPsMtrqYBAeewE5dA_0024FuGbymk94_003D(KeyValuePair<string, string> _0023_003DqjSRr9a0ekrZ79AKq_002497Oxg_003D_003D)
		{
			return _0023_003DqjSRr9a0ekrZ79AKq_002497Oxg_003D_003D.Key;
		}
	}

	private readonly string _0023_003DqrT4_0024YpbG_0024JSf_0024ohxqaNifw_003D_003D;

	private Dictionary<string, string> _0023_003DqhJ9rEgMr0HYG21hvl9CC9g_003D_003D;

	private List<_0023_003Dqji6FxBdMyEK2IoTgpWZ3Cg_003D_003D> _0023_003Dq7pDSadwDyteUFQwDGvhhzg_003D_003D = new List<_0023_003Dqji6FxBdMyEK2IoTgpWZ3Cg_003D_003D>();

	private bool _0023_003Dquw7rQrPE5EG6O08Zt4eZ2g_003D_003D;

	public ConfigFile(string _0023_003Dqr80dLSTQWlFIllhoaX3XtA_003D_003D)
	{
		_0023_003DqrT4_0024YpbG_0024JSf_0024ohxqaNifw_003D_003D = _0023_003Dqr80dLSTQWlFIllhoaX3XtA_003D_003D;
		_0023_003DqhJ9rEgMr0HYG21hvl9CC9g_003D_003D = _0023_003DqKJtZjf_0024R2h34kQ8qUNoa_g_003D_003D(_0023_003Dqr80dLSTQWlFIllhoaX3XtA_003D_003D);
	}

	public void _0023_003DqdeKoNuHqfmYotwId1icwZg_003D_003D(_0023_003Dqji6FxBdMyEK2IoTgpWZ3Cg_003D_003D _0023_003Dqg_OcaZX9dLwc8H2j2MGVtQ_003D_003D)
	{
		_0023_003Dq7pDSadwDyteUFQwDGvhhzg_003D_003D.Add(_0023_003Dqg_OcaZX9dLwc8H2j2MGVtQ_003D_003D);
	}

	public Maybe<string> _0023_003DqQxci846_tlwsINY8PHXgwg_003D_003D(string _0023_003Dqy_0024jTPK_0024kymwTVqrJVgE_0024cQ_003D_003D)
	{
		return _0023_003DqhJ9rEgMr0HYG21hvl9CC9g_003D_003D._0023_003Dqfjn_0024ooPv9m98_0024N4BBnAapQ_003D_003D(_0023_003Dqy_0024jTPK_0024kymwTVqrJVgE_0024cQ_003D_003D);
	}

	public void _0023_003Dq0pYyxI4EvHmJ1TyDLN09hw_003D_003D()
	{
		_0023_003Dquw7rQrPE5EG6O08Zt4eZ2g_003D_003D = true;
	}

	public void _0023_003DqmL_0024u55Aty0WyX7kgJ75UYwf2IztxaN4byqKvOVB3Ogc_003D()
	{
		if (!_0023_003Dquw7rQrPE5EG6O08Zt4eZ2g_003D_003D)
		{
			return;
		}
		_0023_003DqhJ9rEgMr0HYG21hvl9CC9g_003D_003D.Clear();
		foreach (_0023_003Dqji6FxBdMyEK2IoTgpWZ3Cg_003D_003D item in _0023_003Dq7pDSadwDyteUFQwDGvhhzg_003D_003D)
		{
			_0023_003DqhJ9rEgMr0HYG21hvl9CC9g_003D_003D[item._0023_003DqSCABzv8BlSMmyMPE_oimfw_003D_003D()] = item._0023_003Dq73fIpEFjPS665sxyd2kdXTAEnS8j64RQNZgfykMYWPs_003D();
		}
		_0023_003DqqASFQhdHh46e37HuX8CBqQ_003D_003D(_0023_003DqrT4_0024YpbG_0024JSf_0024ohxqaNifw_003D_003D, _0023_003DqhJ9rEgMr0HYG21hvl9CC9g_003D_003D);
		_0023_003Dquw7rQrPE5EG6O08Zt4eZ2g_003D_003D = false;
	}

	private static Dictionary<string, string> _0023_003DqKJtZjf_0024R2h34kQ8qUNoa_g_003D_003D(string _0023_003Dq39C3i3R__0024Ddg3Kmfd7xcQw_003D_003D)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		if (File.Exists(_0023_003Dq39C3i3R__0024Ddg3Kmfd7xcQw_003D_003D))
		{
			string[] array = File.ReadAllText(_0023_003Dq39C3i3R__0024Ddg3Kmfd7xcQw_003D_003D).Split(new char[1] { '\n' });
			for (int i = 0; i < array.Length; i++)
			{
				string[] array2 = array[i].Split(new char[1] { '=' }, 2);
				if (array2.Length == 2)
				{
					string key = array2[0].Trim();
					string value = array2[1].Trim();
					dictionary[key] = value;
				}
			}
		}
		return dictionary;
	}

	private static void _0023_003DqqASFQhdHh46e37HuX8CBqQ_003D_003D(string _0023_003DqYhChEXDt4oJKQc_vGbNnGw_003D_003D, Dictionary<string, string> _0023_003DqWUEinuUKVEzim52AJ8kp1w_003D_003D)
	{
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, string> item in _0023_003DqWUEinuUKVEzim52AJ8kp1w_003D_003D.OrderBy((KeyValuePair<string, string> _0023_003DqjSRr9a0ekrZ79AKq_002497Oxg_003D_003D) => _0023_003DqjSRr9a0ekrZ79AKq_002497Oxg_003D_003D.Key))
		{
			list.Add(string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065774930), item.Key, item.Value));
		}
		string _0023_003DqSFy7zfTyA2Oxllipeaw9yA_003D_003D = string.Join(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065774946), list);
		GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqrrHXsQwbCwgNpH1n2uSa5g_003D_003D._0023_003Dq3uRGRcZ2bz0G8NEcMFlRlQ_003D_003D(_0023_003DqYhChEXDt4oJKQc_vGbNnGw_003D_003D, _0023_003DqSFy7zfTyA2Oxllipeaw9yA_003D_003D);
	}

	public global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<string> _0023_003DqPX1iU9yBklRWWIE8ZVqyzA_003D_003D(string _0023_003Dqg6qzMYOYboT5hXOsQaC_0024Ww_003D_003D, string _0023_003Dqi_y3N_BjmWY7NiN8z5WPGQ_003D_003D)
	{
		return new _0023_003DqnMAgHdPlOUpzfc_0024RGAJ_gmdtNlIVEpoEVTMrbVofnzw_003D(this, _0023_003Dqg6qzMYOYboT5hXOsQaC_0024Ww_003D_003D, _0023_003Dqi_y3N_BjmWY7NiN8z5WPGQ_003D_003D);
	}

	public global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<bool> _0023_003DqoQmfKmgCEvDcceSPxQQnBw_003D_003D(string _0023_003DqbGy_0024GVDWZtdNrB5Q0H6jYA_003D_003D, bool _0023_003DqhcUNEJlvv88W83ERFwZaoA_003D_003D)
	{
		return new _0023_003DqWw_0024yEEYqp0VVyELZaG19UtPTBMhI7omyprvk_00248CmkKw_003D(this, _0023_003DqbGy_0024GVDWZtdNrB5Q0H6jYA_003D_003D, _0023_003DqhcUNEJlvv88W83ERFwZaoA_003D_003D);
	}

	public global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<int> _0023_003DqMfloTyfJWocMhw5E2rB_0024Fg_003D_003D(string _0023_003DqDwzW2rhq1HgcYUAsMSjeyA_003D_003D, int _0023_003DqzqTaUjbEWa2Dbx8kZG8Ilg_003D_003D)
	{
		return new _0023_003Dqh6eEBU8PPTcr3t1sNmfnpw_003D_003D(this, _0023_003DqDwzW2rhq1HgcYUAsMSjeyA_003D_003D, _0023_003DqzqTaUjbEWa2Dbx8kZG8Ilg_003D_003D);
	}

	public global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<float> _0023_003DqNsW_cdPRdM8N4GZ_0024aEs_0024oC6_00240Qh0zSbKjR7HvzGoG20_003D(string _0023_003DqOl9JKbNl01ZPLIZTbN4q4w_003D_003D, float _0023_003DqUCk5ROV_0024d08AjjyeVZr_0024Kw_003D_003D)
	{
		return new _0023_003DqNTHxARDL4T_msnB_0024517w_ML0BrXpMU1exDyv_tmuV2c_003D(this, _0023_003DqOl9JKbNl01ZPLIZTbN4q4w_003D_003D, _0023_003DqUCk5ROV_0024d08AjjyeVZr_0024Kw_003D_003D);
	}

	public global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<Language> _0023_003DqS2h1o_0024WV39DdTi3MlGi_Tg_003D_003D(string _0023_003DqU7NaS4yo22cfkL39t87x4Q_003D_003D, Language _0023_003DqP3fD0bR9l4I8IMC8n7TItA_003D_003D)
	{
		return new _0023_003DqFQ7oeTy4mzt8tLxFJo29V3dRMl1AmmL5cHOTs1xoGSU_003D(this, _0023_003DqU7NaS4yo22cfkL39t87x4Q_003D_003D, _0023_003DqP3fD0bR9l4I8IMC8n7TItA_003D_003D);
	}

	public global::_0023_003DqmlHnw8uCbB3A3saP75l5FQ_003D_003D<Key> _0023_003DqMMOMvySWxDQxQGsnkr_0024oaw_003D_003D(string _0023_003DqsIO_DEAlGNrUSqScO7IvVg_003D_003D, Key _0023_003DqoB2_00244gH4OsstfZY1lUzfBg_003D_003D)
	{
		return new _0023_003DqwuqP0DwFPTH1xeB1mL7s9w_003D_003D(this, _0023_003DqsIO_DEAlGNrUSqScO7IvVg_003D_003D, _0023_003DqoB2_00244gH4OsstfZY1lUzfBg_003D_003D);
	}
}
