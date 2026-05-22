using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

public sealed class HttpManager
{
	private sealed class _0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D
	{
		public _0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D _0023_003DqEDk0A4GOmznscDCGfm37Iw_003D_003D;

		public Func<byte[]> _0023_003DqG4qJ8bfJwxoIn_0024EHOS78sGoCnvvQApaVpibn2j6J3fA_003D;

		internal void _0023_003DqNMnNfklw1BnqdMcb6cyaSlbo2QxhKrI0GR94zDaNaG8_003D()
		{
			try
			{
				_0023_003DqEDk0A4GOmznscDCGfm37Iw_003D_003D._0023_003DqTaSrz6Wjzfz8bkSYJd3IRQ_003D_003D = _0023_003DqG4qJ8bfJwxoIn_0024EHOS78sGoCnvvQApaVpibn2j6J3fA_003D();
			}
			catch
			{
			}
		}
	}

	private sealed class _0023_003DqA6ufQcLm6VIxVRxAfMrfdgDp8nwWAAKTYC0mlJP1dbc_003D
	{
		public Dictionary<string, string> _0023_003Dq_0024CaEdSOazuxVACF0p7JfUg_003D_003D;

		public string _0023_003DqAXpw92gozxWKXtuPiY8JQg_003D_003D;

		public HttpManager _0023_003DqOli3AR4II9X0NIpaf9sxSA_003D_003D;

		internal byte[] _0023_003DqoyzMyulNNOmzbSDTxWyvA4W4_0024EqyUYfDtWUQIMSeZm8_003D()
		{
			string text = string.Join(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065776644), _0023_003Dq_0024CaEdSOazuxVACF0p7JfUg_003D_003D.Select(_003C_003Ec._003C_003E9._0023_003Dq7RhV84og62n1dWqDY98JU3BHYKUQCss0tiz8SVPgQEk_003D).ToArray());
			WebRequest webRequest = WebRequest.Create(_0023_003DqAXpw92gozxWKXtuPiY8JQg_003D_003D);
			webRequest.Method = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065761298);
			webRequest.ContentType = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065776668);
			webRequest.ContentLength = text.Length;
			StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());
			try
			{
				streamWriter.Write(text);
			}
			finally
			{
				((IDisposable)streamWriter).Dispose();
			}
			return _0023_003DqOli3AR4II9X0NIpaf9sxSA_003D_003D._0023_003DqqAxeScg5ol9s5QVDOu0vtw_003D_003D(webRequest);
		}
	}

	private sealed class _0023_003DqEuH9ut0NoiLKdJyJo0elbrcurxPHYelbxUF1Ncj1ruc_003D
	{
		public string _0023_003Dq1qmkiLBnpL33KvAJeMBdBg_003D_003D;

		public byte[] _0023_003Dqb8fvBw3dDeY6QLZL96OCxQ_003D_003D;

		public HttpManager _0023_003DqLFfIXjHOaeJNO_i5vLH5qw_003D_003D;

		internal byte[] _0023_003DqDJznMsZBDWlBg5RYc_0024g_00249s0IM6tc442v0s4s1Jj8mHo_003D()
		{
			WebRequest webRequest = WebRequest.Create(_0023_003Dq1qmkiLBnpL33KvAJeMBdBg_003D_003D);
			webRequest.Method = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065761298);
			webRequest.ContentType = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065761323);
			webRequest.ContentLength = _0023_003Dqb8fvBw3dDeY6QLZL96OCxQ_003D_003D.Length;
			using (Stream stream = webRequest.GetRequestStream())
			{
				stream.Write(_0023_003Dqb8fvBw3dDeY6QLZL96OCxQ_003D_003D, 0, _0023_003Dqb8fvBw3dDeY6QLZL96OCxQ_003D_003D.Length);
			}
			return _0023_003DqLFfIXjHOaeJNO_i5vLH5qw_003D_003D._0023_003DqqAxeScg5ol9s5QVDOu0vtw_003D_003D(webRequest);
		}
	}

	private sealed class _0023_003Dqid1WTiRS2kg6_BIk_0024oc0iYcJDv86u3qlWW5XsLFek7M_003D
	{
		public string _0023_003DqSExJj8VpuyZOQ8uR7ueCWw_003D_003D;

		public HttpManager _0023_003DqxKhxUDKfcUABuC7pu4JiwA_003D_003D;

		internal byte[] _0023_003DqKCcpQWxd031Y6RZjygaAHw_003D_003D()
		{
			WebRequest webRequest = WebRequest.Create(_0023_003DqSExJj8VpuyZOQ8uR7ueCWw_003D_003D);
			webRequest.Method = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065776650);
			return _0023_003DqxKhxUDKfcUABuC7pu4JiwA_003D_003D._0023_003DqqAxeScg5ol9s5QVDOu0vtw_003D_003D(webRequest);
		}
	}

	private sealed class _0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D
	{
		public Task _0023_003Dq9O1KKnk_E2JHPHhj6YLHFw_003D_003D;

		public Action<byte[]> _0023_003DqqHoqaBdrMQf7pmQ9Rw_00244bg_003D_003D;

		public Action _0023_003Dq1hNZaRNQAjXF8wpEbezZJA_003D_003D;

		public Maybe<byte[]> _0023_003DqTaSrz6Wjzfz8bkSYJd3IRQ_003D_003D = _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<KeyValuePair<string, string>, string> _003C_003E9__3_1;

		internal string _0023_003Dq7RhV84og62n1dWqDY98JU3BHYKUQCss0tiz8SVPgQEk_003D(KeyValuePair<string, string> _0023_003DqiqcUwmpJ2M_ONSenLvsYlA_003D_003D)
		{
			return Uri.EscapeDataString(_0023_003DqiqcUwmpJ2M_ONSenLvsYlA_003D_003D.Key) + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065777650) + Uri.EscapeDataString(_0023_003DqiqcUwmpJ2M_ONSenLvsYlA_003D_003D.Value);
		}
	}

	private List<_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D> _0023_003DqXkFoHYwwlvsVOgeJFwAZ_quso_8H8QUJRUg2cQ_4PAo_003D = new List<_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D>();

	public void _0023_003DqB04mpJPIErZ6fUmG328gxg_003D_003D(string _0023_003Dq1qM7NUb2UHF8kzlRoBnW_0024A_003D_003D, Action<byte[]> _0023_003DqJ4bj_0024GsA_0024KPvTFlqvOaj6Q_003D_003D, Action _0023_003Dq6fDQlF_0024zh8vWjHySOt6pJA_003D_003D)
	{
		_0023_003Dqid1WTiRS2kg6_BIk_0024oc0iYcJDv86u3qlWW5XsLFek7M_003D _0023_003Dqid1WTiRS2kg6_BIk_0024oc0iYcJDv86u3qlWW5XsLFek7M_003D2 = new _0023_003Dqid1WTiRS2kg6_BIk_0024oc0iYcJDv86u3qlWW5XsLFek7M_003D();
		_0023_003Dqid1WTiRS2kg6_BIk_0024oc0iYcJDv86u3qlWW5XsLFek7M_003D2._0023_003DqSExJj8VpuyZOQ8uR7ueCWw_003D_003D = _0023_003Dq1qM7NUb2UHF8kzlRoBnW_0024A_003D_003D;
		_0023_003Dqid1WTiRS2kg6_BIk_0024oc0iYcJDv86u3qlWW5XsLFek7M_003D2._0023_003DqxKhxUDKfcUABuC7pu4JiwA_003D_003D = this;
		_0023_003Dq4NgPGtFR2rR9twDLN9Sg4mumrTvLlMKzrRwpLv6EUBw_003D(_0023_003DqJ4bj_0024GsA_0024KPvTFlqvOaj6Q_003D_003D, _0023_003Dq6fDQlF_0024zh8vWjHySOt6pJA_003D_003D, _0023_003Dqid1WTiRS2kg6_BIk_0024oc0iYcJDv86u3qlWW5XsLFek7M_003D2._0023_003DqKCcpQWxd031Y6RZjygaAHw_003D_003D);
	}

	public void _0023_003Dq7nTgijWs_0024CEoSJ8OqttIYw_003D_003D(string _0023_003DqnvCS9VZnLaVm4ZWbnH1MJA_003D_003D, byte[] _0023_003DqNOBboDSpfSGqoXukrGoNZQ_003D_003D, Action<byte[]> _0023_003Dqa5I0_0024gDZ7HqMAKTFZZ0Pzw_003D_003D, Action _0023_003Dq7aQVnnIAL4ChcwXn3SN5Ww_003D_003D)
	{
		_0023_003DqEuH9ut0NoiLKdJyJo0elbrcurxPHYelbxUF1Ncj1ruc_003D CS_0024_003C_003E8__locals8 = new _0023_003DqEuH9ut0NoiLKdJyJo0elbrcurxPHYelbxUF1Ncj1ruc_003D();
		CS_0024_003C_003E8__locals8._0023_003Dq1qmkiLBnpL33KvAJeMBdBg_003D_003D = _0023_003DqnvCS9VZnLaVm4ZWbnH1MJA_003D_003D;
		CS_0024_003C_003E8__locals8._0023_003Dqb8fvBw3dDeY6QLZL96OCxQ_003D_003D = _0023_003DqNOBboDSpfSGqoXukrGoNZQ_003D_003D;
		CS_0024_003C_003E8__locals8._0023_003DqLFfIXjHOaeJNO_i5vLH5qw_003D_003D = this;
		_0023_003Dq4NgPGtFR2rR9twDLN9Sg4mumrTvLlMKzrRwpLv6EUBw_003D(_0023_003Dqa5I0_0024gDZ7HqMAKTFZZ0Pzw_003D_003D, _0023_003Dq7aQVnnIAL4ChcwXn3SN5Ww_003D_003D, delegate
		{
			WebRequest webRequest = WebRequest.Create(CS_0024_003C_003E8__locals8._0023_003Dq1qmkiLBnpL33KvAJeMBdBg_003D_003D);
			webRequest.Method = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065761298);
			webRequest.ContentType = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065761323);
			webRequest.ContentLength = CS_0024_003C_003E8__locals8._0023_003Dqb8fvBw3dDeY6QLZL96OCxQ_003D_003D.Length;
			using (Stream stream = webRequest.GetRequestStream())
			{
				stream.Write(CS_0024_003C_003E8__locals8._0023_003Dqb8fvBw3dDeY6QLZL96OCxQ_003D_003D, 0, CS_0024_003C_003E8__locals8._0023_003Dqb8fvBw3dDeY6QLZL96OCxQ_003D_003D.Length);
			}
			return CS_0024_003C_003E8__locals8._0023_003DqLFfIXjHOaeJNO_i5vLH5qw_003D_003D._0023_003DqqAxeScg5ol9s5QVDOu0vtw_003D_003D(webRequest);
		});
	}

	public void _0023_003Dq0hUfvR7eiibjr78tiSKK3g_003D_003D(string _0023_003DqSqOZBz1UBqm1BmJa2PLrOA_003D_003D, Dictionary<string, string> _0023_003Dqz_0024wFF8jjMjEGh7F4k2hH6w_003D_003D, Action<byte[]> _0023_003DqwYFhx65qOsYBE1bSJaBpYw_003D_003D, Action _0023_003Dq1_ejTczGzQYLYHWqfVGSYw_003D_003D)
	{
		_0023_003DqA6ufQcLm6VIxVRxAfMrfdgDp8nwWAAKTYC0mlJP1dbc_003D CS_0024_003C_003E8__locals6 = new _0023_003DqA6ufQcLm6VIxVRxAfMrfdgDp8nwWAAKTYC0mlJP1dbc_003D();
		CS_0024_003C_003E8__locals6._0023_003Dq_0024CaEdSOazuxVACF0p7JfUg_003D_003D = _0023_003Dqz_0024wFF8jjMjEGh7F4k2hH6w_003D_003D;
		CS_0024_003C_003E8__locals6._0023_003DqAXpw92gozxWKXtuPiY8JQg_003D_003D = _0023_003DqSqOZBz1UBqm1BmJa2PLrOA_003D_003D;
		CS_0024_003C_003E8__locals6._0023_003DqOli3AR4II9X0NIpaf9sxSA_003D_003D = this;
		_0023_003Dq4NgPGtFR2rR9twDLN9Sg4mumrTvLlMKzrRwpLv6EUBw_003D(_0023_003DqwYFhx65qOsYBE1bSJaBpYw_003D_003D, _0023_003Dq1_ejTczGzQYLYHWqfVGSYw_003D_003D, delegate
		{
			string text = string.Join(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065776644), CS_0024_003C_003E8__locals6._0023_003Dq_0024CaEdSOazuxVACF0p7JfUg_003D_003D.Select(_003C_003Ec._003C_003E9._0023_003Dq7RhV84og62n1dWqDY98JU3BHYKUQCss0tiz8SVPgQEk_003D).ToArray());
			WebRequest webRequest = WebRequest.Create(CS_0024_003C_003E8__locals6._0023_003DqAXpw92gozxWKXtuPiY8JQg_003D_003D);
			webRequest.Method = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065761298);
			webRequest.ContentType = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065776668);
			webRequest.ContentLength = text.Length;
			StreamWriter streamWriter = new StreamWriter(webRequest.GetRequestStream());
			try
			{
				streamWriter.Write(text);
			}
			finally
			{
				((IDisposable)streamWriter).Dispose();
			}
			return CS_0024_003C_003E8__locals6._0023_003DqOli3AR4II9X0NIpaf9sxSA_003D_003D._0023_003DqqAxeScg5ol9s5QVDOu0vtw_003D_003D(webRequest);
		});
	}

	private byte[] _0023_003DqqAxeScg5ol9s5QVDOu0vtw_003D_003D(WebRequest _0023_003Dq3EZ2RZL8IdwwTLF6gXfy7w_003D_003D)
	{
		using WebResponse webResponse = _0023_003Dq3EZ2RZL8IdwwTLF6gXfy7w_003D_003D.GetResponse();
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			webResponse.GetResponseStream().CopyTo(memoryStream);
			return memoryStream.ToArray();
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}

	private void _0023_003Dq4NgPGtFR2rR9twDLN9Sg4mumrTvLlMKzrRwpLv6EUBw_003D(Action<byte[]> _0023_003DqkmEMnRASKsjTAMMztZNkZw_003D_003D, Action _0023_003DqVSzERKCPxc_GSRYoTe0a5A_003D_003D, Func<byte[]> _0023_003DqqNpMTdWqJOaA3O_e9DZJcb2q_Etcx7kAyXNDgvypUl4_003D)
	{
		_0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D _0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D2 = new _0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D();
		_0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D2._0023_003DqG4qJ8bfJwxoIn_0024EHOS78sGoCnvvQApaVpibn2j6J3fA_003D = _0023_003DqqNpMTdWqJOaA3O_e9DZJcb2q_Etcx7kAyXNDgvypUl4_003D;
		_0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D2._0023_003DqEDk0A4GOmznscDCGfm37Iw_003D_003D = new _0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D();
		_0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D2._0023_003DqEDk0A4GOmznscDCGfm37Iw_003D_003D._0023_003DqqHoqaBdrMQf7pmQ9Rw_00244bg_003D_003D = _0023_003DqkmEMnRASKsjTAMMztZNkZw_003D_003D;
		_0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D2._0023_003DqEDk0A4GOmznscDCGfm37Iw_003D_003D._0023_003Dq1hNZaRNQAjXF8wpEbezZJA_003D_003D = _0023_003DqVSzERKCPxc_GSRYoTe0a5A_003D_003D;
		_0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D2._0023_003DqEDk0A4GOmznscDCGfm37Iw_003D_003D._0023_003Dq9O1KKnk_E2JHPHhj6YLHFw_003D_003D = Task.Run((Action)_0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D2._0023_003DqNMnNfklw1BnqdMcb6cyaSlbo2QxhKrI0GR94zDaNaG8_003D);
		_0023_003DqXkFoHYwwlvsVOgeJFwAZ_quso_8H8QUJRUg2cQ_4PAo_003D.Add(_0023_003Dq9C_0024TgUtPVA5civ7fsbXqvownwaZRR36PfimxFLkJdas_003D2._0023_003DqEDk0A4GOmznscDCGfm37Iw_003D_003D);
	}

	public void _0023_003DqhhgxR8bdvxr6g_IKxNUVgw_003D_003D()
	{
		_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D[] array = _0023_003DqXkFoHYwwlvsVOgeJFwAZ_quso_8H8QUJRUg2cQ_4PAo_003D.ToArray();
		foreach (_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D _0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D2 in array)
		{
			if (_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D2._0023_003Dq9O1KKnk_E2JHPHhj6YLHFw_003D_003D.IsCompleted)
			{
				if (_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D2._0023_003DqTaSrz6Wjzfz8bkSYJd3IRQ_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
				{
					_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D2._0023_003DqqHoqaBdrMQf7pmQ9Rw_00244bg_003D_003D(_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D2._0023_003DqTaSrz6Wjzfz8bkSYJd3IRQ_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
				}
				else
				{
					_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D2._0023_003Dq1hNZaRNQAjXF8wpEbezZJA_003D_003D();
				}
				_0023_003DqXkFoHYwwlvsVOgeJFwAZ_quso_8H8QUJRUg2cQ_4PAo_003D.Remove(_0023_003DqTH1HtKpHF8tUSuemRykQLg_003D_003D2);
			}
		}
	}
}
