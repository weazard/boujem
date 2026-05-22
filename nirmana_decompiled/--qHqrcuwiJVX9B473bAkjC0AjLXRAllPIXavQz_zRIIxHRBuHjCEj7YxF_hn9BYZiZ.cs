using System;

public sealed class _0023_003DqHqrcuwiJVX9B473bAkjC0AjLXRAllPIXavQz_zRIIxHRBuHjCEj7YxF_hn9BYZiZ : _0023_003Dqtn9ZYTXp7UwL8vU2ZU4eVHgOtwy0Ju_0024RndOUZtnAiNw_003D
{
	public _0023_003DqzeMbKyXE0x_gQXVUyPbIVdZru_wFrZoO8HY8AbzsgTKjpmERPrkPWSEx0zRnOa28 _0023_003Dqih_xzls2jtkJRSuquETxpQ_003D_003D;

	public int _0023_003Dqg0ryr1TiowYBjRVQqxxbiQ_003D_003D;

	public unsafe override void _0023_003DqSZS12n_liaXtj430nsVUsg_003D_003D(short* _0023_003Dq1Mqbs8OmcfDyZ7TJKNLnog_003D_003D, int _0023_003DqRXlgC9VDITtxCx5WksbfzQ_003D_003D, float _0023_003Dq4zKOFDT6D1eMQVti0qU_0024iQ_003D_003D, bool _0023_003DqTZOcmrrX1X_Ntr4DzdaFQw_003D_003D, bool _0023_003DqEPZTdRlj4hiALNepoaE7xw_003D_003D)
	{
		for (int i = 0; i < _0023_003DqRXlgC9VDITtxCx5WksbfzQ_003D_003D; i++)
		{
			int num = _0023_003Dq1Mqbs8OmcfDyZ7TJKNLnog_003D_003D[i];
			int num2 = _0023_003Dqih_xzls2jtkJRSuquETxpQ_003D_003D._0023_003Dq_00241YXvzUdZrTsPqnJ_00242RhQQ_003D_003D[_0023_003Dqg0ryr1TiowYBjRVQqxxbiQ_003D_003D];
			_0023_003Dqg0ryr1TiowYBjRVQqxxbiQ_003D_003D++;
			if (_0023_003Dqg0ryr1TiowYBjRVQqxxbiQ_003D_003D >= _0023_003Dqih_xzls2jtkJRSuquETxpQ_003D_003D._0023_003Dq_00241YXvzUdZrTsPqnJ_00242RhQQ_003D_003D.Length)
			{
				if (!_0023_003DqTZOcmrrX1X_Ntr4DzdaFQw_003D_003D)
				{
					break;
				}
				_0023_003Dqg0ryr1TiowYBjRVQqxxbiQ_003D_003D = 0;
			}
			num2 = (int)((float)num2 * _0023_003Dq4zKOFDT6D1eMQVti0qU_0024iQ_003D_003D);
			_0023_003Dq1Mqbs8OmcfDyZ7TJKNLnog_003D_003D[i] = (short)Utility._0023_003DqPketCwwzMXFnMETn36UPyQ_003D_003D(num + num2, -32768, 32767);
		}
	}

	public override bool _0023_003DqC9oNkbVkCpOCcCHd4AZhwQ_003D_003D()
	{
		return _0023_003Dqg0ryr1TiowYBjRVQqxxbiQ_003D_003D >= _0023_003Dqih_xzls2jtkJRSuquETxpQ_003D_003D._0023_003Dq_00241YXvzUdZrTsPqnJ_00242RhQQ_003D_003D.Length;
	}

	public override void _0023_003DqV1F0AVDD6il2nfHp74mY1w_003D_003D(double _0023_003Dqc6WFvTdftCfFVca0RsFBFA_003D_003D)
	{
		_0023_003Dqg0ryr1TiowYBjRVQqxxbiQ_003D_003D = (int)Math.Round(_0023_003Dqc6WFvTdftCfFVca0RsFBFA_003D_003D * (double)_0023_003DqOtemJOzkZrHIxt9bJqyh9g_003D_003D._0023_003Dq8Ovft03UTbFmxEgIGSYv1g_003D_003D);
	}

	public override double _0023_003Dq_0024Z7VwcaDYnx9939ijxV6HA_003D_003D()
	{
		return (float)_0023_003Dqg0ryr1TiowYBjRVQqxxbiQ_003D_003D / (float)_0023_003DqOtemJOzkZrHIxt9bJqyh9g_003D_003D._0023_003Dq8Ovft03UTbFmxEgIGSYv1g_003D_003D;
	}

	public override void _0023_003DqbrzhSNYChTcuhPfW2_Vetw_003D_003D()
	{
		_0023_003Dqih_xzls2jtkJRSuquETxpQ_003D_003D = null;
	}
}
