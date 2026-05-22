using System;
using System.Diagnostics;

public struct Maybe<T> : IEquatable<Maybe<T>>
{
	private bool _0023_003DqYPZ_0024JdGg4mIWuAExGN9ryiKI9aMKZknd6NCehOYNudA_003D;

	private T _0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D;

	public Maybe(bool _0023_003DqBceiF_0024TMI1QqFoiVx46Agw_003D_003D, T _0023_003DqL0c5vWn06UF36tyAckzfkg_003D_003D)
	{
		_0023_003Dq9T1XJw9hkMvthHL8GEAUxw_003D_003D(_0023_003DqBceiF_0024TMI1QqFoiVx46Agw_003D_003D);
		_0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D = _0023_003DqL0c5vWn06UF36tyAckzfkg_003D_003D;
	}

	public bool _0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D()
	{
		return _0023_003DqYPZ_0024JdGg4mIWuAExGN9ryiKI9aMKZknd6NCehOYNudA_003D;
	}

	private void _0023_003Dq9T1XJw9hkMvthHL8GEAUxw_003D_003D(bool _0023_003Dqy7xnT_04mxobaU4DpjsMFA_003D_003D)
	{
		_0023_003DqYPZ_0024JdGg4mIWuAExGN9ryiKI9aMKZknd6NCehOYNudA_003D = _0023_003Dqy7xnT_04mxobaU4DpjsMFA_003D_003D;
	}

	[DebuggerStepThrough]
	public T _0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D()
	{
		if (!_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			throw new InvalidOperationException(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808352));
		}
		return _0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D;
	}

	public static Maybe<T> _0023_003DqIU24wASiZAO72K8OYedx0g_003D_003D()
	{
		return new Maybe<T>(_0023_003DqBceiF_0024TMI1QqFoiVx46Agw_003D_003D: false, default(T));
	}

	public static Maybe<T> _0023_003DqxF5pJB7Wu1JzhP6_0024GmzR7w_003D_003D(T _0023_003DqA_vPY3454udYJWTTUJN6XA_003D_003D)
	{
		if (_0023_003DqA_vPY3454udYJWTTUJN6XA_003D_003D == null)
		{
			throw new ArgumentNullException(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808294));
		}
		return new Maybe<T>(_0023_003DqBceiF_0024TMI1QqFoiVx46Agw_003D_003D: true, _0023_003DqA_vPY3454udYJWTTUJN6XA_003D_003D);
	}

	public static implicit operator Maybe<T>(T _0023_003DqaU6xSUoyPjkIG2PpzTXhRg_003D_003D)
	{
		return _0023_003DqxF5pJB7Wu1JzhP6_0024GmzR7w_003D_003D(_0023_003DqaU6xSUoyPjkIG2PpzTXhRg_003D_003D);
	}

	public static implicit operator Maybe<T>(_0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D _0023_003Dq90m532Qt1LA_y8hsXUp_0024Bw_003D_003D)
	{
		return _0023_003DqIU24wASiZAO72K8OYedx0g_003D_003D();
	}

	public bool _0023_003DqY3i1VPb6dvRhYnN7vG1PAA_003D_003D(out T _0023_003DqiERL2gKH0e_0024eSPIKV5MMjA_003D_003D)
	{
		if (_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			_0023_003DqiERL2gKH0e_0024eSPIKV5MMjA_003D_003D = _0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D;
			return true;
		}
		_0023_003DqiERL2gKH0e_0024eSPIKV5MMjA_003D_003D = default(T);
		return false;
	}

	public T _0023_003DqcH4ZRa_0024zHPEYvYMVjHc4bg_003D_003D(T _0023_003DqH0VgAKo9gGihEAZ8ME54Qw_003D_003D)
	{
		if (!_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			return _0023_003DqH0VgAKo9gGihEAZ8ME54Qw_003D_003D;
		}
		return _0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D;
	}

	public Maybe<T> _0023_003Dq9f1pB0c7EELbqIz3reFf4g_003D_003D(Maybe<T> _0023_003DqT8MlNUh2n0NMQdPHYEen7g_003D_003D)
	{
		if (!_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			return _0023_003DqT8MlNUh2n0NMQdPHYEen7g_003D_003D;
		}
		return this;
	}

	public Maybe<TResult> _0023_003DqNLK1vk9_00242e7TtB5lccHXyA_003D_003D<TResult>(Func<T, TResult> _0023_003Dq2EFI67_0024bOZTyEj1_0024PMsB2A_003D_003D)
	{
		if (_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqviLfXxoe0_lhumqA0McvDA_003D_003D(_0023_003Dq2EFI67_0024bOZTyEj1_0024PMsB2A_003D_003D(_0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D));
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public Maybe<TResult> _0023_003Dqr1G_RaGbCA4HRtoyOs8_fg_003D_003D<TResult>(Func<T, Maybe<TResult>> _0023_003Dqz9gvc3eGsGqk4IBHwiRANA_003D_003D)
	{
		if (_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			return _0023_003Dqz9gvc3eGsGqk4IBHwiRANA_003D_003D(_0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D);
		}
		return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
	}

	public Maybe<T> _0023_003Dq0IAIFcjm025IYxb5RNgR8A_003D_003D(Func<T, bool> _0023_003DqwdYmCNr_0024wPUDRDw7uq8ylQ_003D_003D)
	{
		if (!_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D() || !_0023_003DqwdYmCNr_0024wPUDRDw7uq8ylQ_003D_003D(_0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D))
		{
			return _0023_003Dqpr8f6FatmdM_0024dzy_8tomNg_003D_003D._0023_003DqAZSMMsi6BcX2bhwctPD4jw_003D_003D;
		}
		return this;
	}

	public void _0023_003DqrauG0EMfCPa1HDKhJE_VWg_003D_003D(Action<T> _0023_003DqscE3fV_Dxw8eUgJJbZH_9g_003D_003D)
	{
		if (_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			_0023_003DqscE3fV_Dxw8eUgJJbZH_9g_003D_003D(_0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D());
		}
	}

	public override string ToString()
	{
		if (!_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			return _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065807402);
		}
		return _0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D.ToString();
	}

	public override int GetHashCode()
	{
		if (!_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			return 0;
		}
		return _0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D.GetHashCode();
	}

	public override bool Equals(object _0023_003DqNOPM2yyzDqTa_xL3D1s1eg_003D_003D)
	{
		if (_0023_003DqNOPM2yyzDqTa_xL3D1s1eg_003D_003D is Maybe<T>)
		{
			return Equals((Maybe<T>)_0023_003DqNOPM2yyzDqTa_xL3D1s1eg_003D_003D);
		}
		return false;
	}

	public bool Equals(Maybe<T> _0023_003Dq_00244GbBa0asR4AbRFjxIMmXg_003D_003D)
	{
		if (!_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D() && !_0023_003Dq_00244GbBa0asR4AbRFjxIMmXg_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			return true;
		}
		if (_0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D() && _0023_003Dq_00244GbBa0asR4AbRFjxIMmXg_003D_003D._0023_003DqfZi4fAK2G7Vfq_I_jXv7wg_003D_003D())
		{
			ref T reference = ref _0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D;
			object obj = _0023_003Dq_00244GbBa0asR4AbRFjxIMmXg_003D_003D._0023_003DqerJakP2mb1_VicgnDaSFew_003D_003D;
			return reference.Equals(obj);
		}
		return false;
	}

	public static bool operator ==(Maybe<T> _0023_003DqVOsYyCQx5soJwZwtxfB4dQ_003D_003D, Maybe<T> _0023_003Dq6Z_7DuyGmDS5fTO_76f2Ow_003D_003D)
	{
		return _0023_003DqVOsYyCQx5soJwZwtxfB4dQ_003D_003D.Equals(_0023_003Dq6Z_7DuyGmDS5fTO_76f2Ow_003D_003D);
	}

	public static bool operator !=(Maybe<T> _0023_003DqrVrUupyfH9BDNTNHCGfdaQ_003D_003D, Maybe<T> _0023_003Dq7A7WavlMfVEFeY3F_9Bc9g_003D_003D)
	{
		return !_0023_003DqrVrUupyfH9BDNTNHCGfdaQ_003D_003D.Equals(_0023_003Dq7A7WavlMfVEFeY3F_9Bc9g_003D_003D);
	}
}
