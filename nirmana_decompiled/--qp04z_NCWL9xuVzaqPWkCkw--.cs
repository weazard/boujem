using System;
using System.Collections.Generic;
using System.Linq;

public sealed class _0023_003Dqp04z_NCWL9xuVzaqPWkCkw_003D_003D
{
	public readonly Vector2[] _0023_003Dqs9TR1v_0024BPoIc9c2m1b3vKg_003D_003D;

	public readonly Bounds2 _0023_003Dq1vC02bh5j6qsH47l_ha_Hw_003D_003D;

	public _0023_003Dqp04z_NCWL9xuVzaqPWkCkw_003D_003D(IEnumerable<Vector2> _0023_003DqfYVNs1Egx5_0024FE0Wu7kmTvg_003D_003D)
	{
		_0023_003Dqs9TR1v_0024BPoIc9c2m1b3vKg_003D_003D = _0023_003DqfYVNs1Egx5_0024FE0Wu7kmTvg_003D_003D.Concat(new Vector2[1] { _0023_003DqfYVNs1Egx5_0024FE0Wu7kmTvg_003D_003D.First() }).ToArray();
		_0023_003Dq1vC02bh5j6qsH47l_ha_Hw_003D_003D = Bounds2.WithSize(_0023_003DqfYVNs1Egx5_0024FE0Wu7kmTvg_003D_003D.First(), new Vector2(0f, 0f));
		foreach (Vector2 item in _0023_003DqfYVNs1Egx5_0024FE0Wu7kmTvg_003D_003D)
		{
			_0023_003Dq1vC02bh5j6qsH47l_ha_Hw_003D_003D = _0023_003Dq1vC02bh5j6qsH47l_ha_Hw_003D_003D.UnionedWith(item);
		}
	}

	public bool _0023_003DqRl5kd_qvO6QkQWtP4B4r5g_003D_003D(Vector2 _0023_003Dq9e2gyP673v1CsVorszw88Q_003D_003D)
	{
		if (!_0023_003Dq1vC02bh5j6qsH47l_ha_Hw_003D_003D.Contains(_0023_003Dq9e2gyP673v1CsVorszw88Q_003D_003D))
		{
			return false;
		}
		return _0023_003Dq53E3jwNFuJHHwTyfu4y9UA_003D_003D(_0023_003Dq9e2gyP673v1CsVorszw88Q_003D_003D, _0023_003Dqs9TR1v_0024BPoIc9c2m1b3vKg_003D_003D);
	}

	private static int _0023_003DquTdErAy5V4jvJxWz3Kj7tA_003D_003D(Vector2 _0023_003DqU1cGuL_0024Qi6LYS1u9NIbfdw_003D_003D, Vector2 _0023_003DqzfTg5dguYpu94ITn4MUM4A_003D_003D, Vector2 _0023_003DqHJraEW6M75ZAzFxAFO9DTg_003D_003D)
	{
		return Math.Sign((_0023_003DqzfTg5dguYpu94ITn4MUM4A_003D_003D.X - _0023_003DqU1cGuL_0024Qi6LYS1u9NIbfdw_003D_003D.X) * (_0023_003DqHJraEW6M75ZAzFxAFO9DTg_003D_003D.Y - _0023_003DqU1cGuL_0024Qi6LYS1u9NIbfdw_003D_003D.Y) - (_0023_003DqHJraEW6M75ZAzFxAFO9DTg_003D_003D.X - _0023_003DqU1cGuL_0024Qi6LYS1u9NIbfdw_003D_003D.X) * (_0023_003DqzfTg5dguYpu94ITn4MUM4A_003D_003D.Y - _0023_003DqU1cGuL_0024Qi6LYS1u9NIbfdw_003D_003D.Y));
	}

	public static bool _0023_003Dq53E3jwNFuJHHwTyfu4y9UA_003D_003D(Vector2 _0023_003DqlAp8sM6TYBuXq7mXUnk7Mw_003D_003D, Vector2[] _0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D)
	{
		int num = 0;
		for (int i = 0; i < _0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D.Length - 1; i++)
		{
			if (_0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D[i].Y <= _0023_003DqlAp8sM6TYBuXq7mXUnk7Mw_003D_003D.Y)
			{
				if (_0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D[i + 1].Y > _0023_003DqlAp8sM6TYBuXq7mXUnk7Mw_003D_003D.Y && _0023_003DquTdErAy5V4jvJxWz3Kj7tA_003D_003D(_0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D[i], _0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D[i + 1], _0023_003DqlAp8sM6TYBuXq7mXUnk7Mw_003D_003D) > 0)
				{
					num++;
				}
			}
			else if (_0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D[i + 1].Y <= _0023_003DqlAp8sM6TYBuXq7mXUnk7Mw_003D_003D.Y && _0023_003DquTdErAy5V4jvJxWz3Kj7tA_003D_003D(_0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D[i], _0023_003DqPgNkD0gb6p2TOnd3ygcbaw_003D_003D[i + 1], _0023_003DqlAp8sM6TYBuXq7mXUnk7Mw_003D_003D) < 0)
			{
				num--;
			}
		}
		return num != 0;
	}
}
