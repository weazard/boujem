using System;
using System.Collections.Generic;
using System.Linq;

public static class DeepCopyExtensions
{
	[Serializable]
	private sealed class _003C_003Ec__0<T> where T : global::_0023_003DqsI3BNfALP7JJqKtN_0024awPFnoloKWv6dGlsziEP4Ox0H0_003D<T>
	{
		public static readonly _003C_003Ec__0<T> _003C_003E9 = new _003C_003Ec__0<T>();

		public static Func<T, T> _003C_003E9__0_0;

		internal T _0023_003DqL_0024OEl2plr863nlfmnm3zLk__7s4x9P6ineP5WBXoYts_003D(T _0023_003DqXxO1WcAhXUWZcE19F0sdyg_003D_003D)
		{
			return _0023_003DqXxO1WcAhXUWZcE19F0sdyg_003D_003D._0023_003DqKoBt9xKngVZMktVx5jV0Nw_003D_003D();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec__1<T> where T : global::_0023_003DqsI3BNfALP7JJqKtN_0024awPFnoloKWv6dGlsziEP4Ox0H0_003D<T>
	{
		public static readonly _003C_003Ec__1<T> _003C_003E9 = new _003C_003Ec__1<T>();

		public static Func<T, T> _003C_003E9__1_0;

		internal T _0023_003DqxYwoM6KWICl3hzR0xoYFw4HlBfNuSABUrI31wTHTvvs_003D(T _0023_003Dqc32pZxsW7a2mSVwcgQrIGA_003D_003D)
		{
			return _0023_003Dqc32pZxsW7a2mSVwcgQrIGA_003D_003D._0023_003DqKoBt9xKngVZMktVx5jV0Nw_003D_003D();
		}
	}

	public static T[] _0023_003Dq2PvI17WdFq_00243Jso0oMrQIQ_003D_003D<T>(this T[] _0023_003DqV_0024Tc_9ohf1rPYDlmKeASjQ_003D_003D) where T : global::_0023_003DqsI3BNfALP7JJqKtN_0024awPFnoloKWv6dGlsziEP4Ox0H0_003D<T>
	{
		return _0023_003DqV_0024Tc_9ohf1rPYDlmKeASjQ_003D_003D.Select((T _0023_003DqXxO1WcAhXUWZcE19F0sdyg_003D_003D) => _0023_003DqXxO1WcAhXUWZcE19F0sdyg_003D_003D._0023_003DqKoBt9xKngVZMktVx5jV0Nw_003D_003D()).ToArray();
	}

	public static List<T> _0023_003DqAC2ERLM6jubiJXn4gVPNnQ_003D_003D<T>(this List<T> _0023_003DqsLhhkizztK6R7QBb3ZWSOw_003D_003D) where T : global::_0023_003DqsI3BNfALP7JJqKtN_0024awPFnoloKWv6dGlsziEP4Ox0H0_003D<T>
	{
		return _0023_003DqsLhhkizztK6R7QBb3ZWSOw_003D_003D.Select(_003C_003Ec__1<T>._003C_003E9._0023_003DqxYwoM6KWICl3hzR0xoYFw4HlBfNuSABUrI31wTHTvvs_003D).ToList();
	}

	public static Dictionary<K, V> _0023_003DqJq5BA7grqn13VRe4as6oiQ_003D_003D<K, V>(this Dictionary<K, V> _0023_003Dq6JEY0fBIfErsr424yoDg4A_003D_003D) where V : global::_0023_003DqsI3BNfALP7JJqKtN_0024awPFnoloKWv6dGlsziEP4Ox0H0_003D<V>
	{
		Dictionary<K, V> dictionary = new Dictionary<K, V>();
		foreach (KeyValuePair<K, V> item in _0023_003Dq6JEY0fBIfErsr424yoDg4A_003D_003D)
		{
			dictionary.Add(item.Key, item.Value._0023_003DqKoBt9xKngVZMktVx5jV0Nw_003D_003D());
		}
		return dictionary;
	}

	public static Maybe<T> _0023_003Dq9YE7V6WVopKORxPX_0024iWaWQ_003D_003D<T>(this Maybe<T> _0023_003DqXGtYeuIMO9ftxmePVr5fJg_003D_003D) where T : global::_0023_003DqsI3BNfALP7JJqKtN_0024awPFnoloKWv6dGlsziEP4Ox0H0_003D<T>
	{
		if (_0023_003DqXGtYeuIMO9ftxmePVr5fJg_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqviLfXxoe0_lhumqA0McvDA_003D_003D(_0023_003DqXGtYeuIMO9ftxmePVr5fJg_003D_003D._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D()._0023_003DqKoBt9xKngVZMktVx5jV0Nw_003D_003D());
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}
}
