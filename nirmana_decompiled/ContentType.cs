using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

public class ContentType<T> : IEquatable<T>, IComparable<T> where T : ContentType<T>, new()
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<T, int> _003C_003E9__10_0;

		internal int _0023_003DqIg8eLOGO65bkqfa8eOxL6Qhq5SS03TJKjfgEZLJmeoA_003D(T _0023_003Dqn_uOCbp5vbV0MrSukJE_fQ_003D_003D)
		{
			return _0023_003Dqn_uOCbp5vbV0MrSukJE_fQ_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D;
		}
	}

	public int _0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D;

	private static Dictionary<int, T> _0023_003Dqv7XuGB4AcxivU6t8HKw4ug_003D_003D = new Dictionary<int, T>();

	private static List<T> _0023_003DqruHcHakgsdHLd_0024edfyesl4srePTpCya2aJjL3WOybGQ_003D = new List<T>();

	public static bool operator ==(ContentType<T> _0023_003Dq3KvpKosNLPYW71ML5fOusQ_003D_003D, ContentType<T> _0023_003DqhlV6LMxeNv3NYEmNAKgm0A_003D_003D)
	{
		if ((object)_0023_003Dq3KvpKosNLPYW71ML5fOusQ_003D_003D != null && (object)_0023_003DqhlV6LMxeNv3NYEmNAKgm0A_003D_003D != null && _0023_003Dq3KvpKosNLPYW71ML5fOusQ_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D == _0023_003DqhlV6LMxeNv3NYEmNAKgm0A_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D)
		{
			return true;
		}
		if ((object)_0023_003Dq3KvpKosNLPYW71ML5fOusQ_003D_003D == null && (object)_0023_003DqhlV6LMxeNv3NYEmNAKgm0A_003D_003D == null)
		{
			return true;
		}
		return false;
	}

	public static bool operator !=(ContentType<T> _0023_003DqR0_0024hx4ufqZ2k8n8ruY1P2Q_003D_003D, ContentType<T> _0023_003DqkPaJzhJwNQP7pXpaJ67tEg_003D_003D)
	{
		return !(_0023_003DqR0_0024hx4ufqZ2k8n8ruY1P2Q_003D_003D == _0023_003DqkPaJzhJwNQP7pXpaJ67tEg_003D_003D);
	}

	public bool Equals(T _0023_003DqH1pDfEirf0N_0024EZw7GnbR_w_003D_003D)
	{
		return this == _0023_003DqH1pDfEirf0N_0024EZw7GnbR_w_003D_003D;
	}

	public override bool Equals(object _0023_003DqvzB_qlgluvjiW5t6ftUMOw_003D_003D)
	{
		if (_0023_003DqvzB_qlgluvjiW5t6ftUMOw_003D_003D is T val)
		{
			return this == val;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return _0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D.GetHashCode();
	}

	public int CompareTo(T _0023_003DqonK9iEBKDC3PehWFMB318Q_003D_003D)
	{
		return _0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D.CompareTo(_0023_003DqonK9iEBKDC3PehWFMB318Q_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D);
	}

	protected static T _0023_003Dqv_zYhOR1bVs_0024Sv2_0024wECPsw_003D_003D(T _0023_003DqM7BYkWDd5sNsfy8HVThLDg_003D_003D, bool _0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D)
	{
		if (_0023_003DqM7BYkWDd5sNsfy8HVThLDg_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D == 0)
		{
			throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065775031));
		}
		if (_0023_003Dqv7XuGB4AcxivU6t8HKw4ug_003D_003D.ContainsKey(_0023_003DqM7BYkWDd5sNsfy8HVThLDg_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D) && !_0023_003DqpmUU4yEs3wBJNx3SSNCBuYgqxJdZTye5L1dnZ_00242aidk_003D)
		{
			throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065775081));
		}
		_0023_003Dqv7XuGB4AcxivU6t8HKw4ug_003D_003D[_0023_003DqM7BYkWDd5sNsfy8HVThLDg_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D] = _0023_003DqM7BYkWDd5sNsfy8HVThLDg_003D_003D;
		return _0023_003DqM7BYkWDd5sNsfy8HVThLDg_003D_003D;
	}

	public static IEnumerable<T> _0023_003Dq_0024K0RE2SHcO4TbjmjudlM4g_003D_003D()
	{
		return _0023_003Dqv7XuGB4AcxivU6t8HKw4ug_003D_003D.Values.OrderBy(_003C_003Ec._003C_003E9._0023_003DqIg8eLOGO65bkqfa8eOxL6Qhq5SS03TJKjfgEZLJmeoA_003D);
	}

	public static Maybe<T> _0023_003DqLBAInUtMewlY2gdoYmQPOA_003D_003D(int _0023_003DqMjKvAFOOojM_0024tX_0024QOJloKQ_003D_003D)
	{
		return _0023_003Dqv7XuGB4AcxivU6t8HKw4ug_003D_003D._0023_003Dqfjn_0024ooPv9m98_0024N4BBnAapQ_003D_003D(_0023_003DqMjKvAFOOojM_0024tX_0024QOJloKQ_003D_003D);
	}

	[OnDeserialized]
	private void _0023_003DqknLm1loZgM_0024ZQOgNgyw1PA_003D_003D(StreamingContext _0023_003DqbHqFJFWJknD9uaFj6d2_0024Ng_003D_003D)
	{
		_0023_003DqruHcHakgsdHLd_0024edfyesl4srePTpCya2aJjL3WOybGQ_003D.Add((T)this);
	}

	protected static void _0023_003DqxfV99pOoKxQjK_0fgdrgfsZ9DQtIKwdeH_p0wADPsh0_003D()
	{
		foreach (T item in _0023_003DqruHcHakgsdHLd_0024edfyesl4srePTpCya2aJjL3WOybGQ_003D)
		{
			if (_0023_003Dqv7XuGB4AcxivU6t8HKw4ug_003D_003D.TryGetValue(item._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D, out var value))
			{
				item._0023_003Dqmf5Yi7U5d6I2NC9xGtp9_3l_EuGLwDtvGvvCDTVAWGI_003D(value);
			}
		}
		_0023_003DqruHcHakgsdHLd_0024edfyesl4srePTpCya2aJjL3WOybGQ_003D.Clear();
	}

	protected void _0023_003Dqmf5Yi7U5d6I2NC9xGtp9_3l_EuGLwDtvGvvCDTVAWGI_003D(T _0023_003Dqe2SW_Y80LU4MZnZY_Encpg_003D_003D)
	{
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;
		FieldInfo[] fields = typeof(T).GetFields(bindingAttr);
		foreach (FieldInfo fieldInfo in fields)
		{
			fieldInfo.SetValue(this, fieldInfo.GetValue(_0023_003Dqe2SW_Y80LU4MZnZY_Encpg_003D_003D));
		}
	}
}
