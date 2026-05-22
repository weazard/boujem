using System;
using System.Runtime.InteropServices;

public sealed class _0023_003Dq9DqbTS9i9OdEEIYlQOwkumRnYVc4dj1nJnLq6haHh_x3WJZnlMMN_2X05fVRDk1a : _0023_003Dqtn9ZYTXp7UwL8vU2ZU4eVHgOtwy0Ju_0024RndOUZtnAiNw_003D
{
	public IntPtr _0023_003Dq5lVacHP7XW8yKIvqa_qEFA_003D_003D;

	public int _0023_003Dqu58AO6bjJyYmWpj5fhkuxQ_003D_003D;

	private bool _0023_003DqVCN0en_0024Kd8LHEVmHKY6Piw_003D_003D;

	public bool _0023_003DqXHbUfsjK_AAH7RzFlPbblQ_003D_003D;

	public float _0023_003DqPgu7_4EOxdM8mzgJDyRXNA_003D_003D;

	public unsafe override void _0023_003DqSZS12n_liaXtj430nsVUsg_003D_003D(short* _0023_003Dq3yPHmztl27TXqO4vgMmQ7A_003D_003D, int _0023_003DqZwPCwsa1HSsTWtAe5_0024NquA_003D_003D, float _0023_003Dqm5dN9_0024slTWUJiXmBai5Uug_003D_003D, bool _0023_003Dq__0024xVSnaEJ_0024tPPIAd5fvHKA_003D_003D, bool _0023_003Dq6_0024MJnFg85hEdSgj1R7LaCA_003D_003D)
	{
		if (_0023_003Dqu58AO6bjJyYmWpj5fhkuxQ_003D_003D == 1)
		{
			_0023_003DqZwPCwsa1HSsTWtAe5_0024NquA_003D_003D /= 2;
		}
		short[] array = new short[_0023_003DqZwPCwsa1HSsTWtAe5_0024NquA_003D_003D];
		int num2;
		for (int i = 0; i < _0023_003DqZwPCwsa1HSsTWtAe5_0024NquA_003D_003D; i += num2)
		{
			int num = _0023_003DqZwPCwsa1HSsTWtAe5_0024NquA_003D_003D - i;
			fixed (short* ptr = array)
			{
				num2 = _0023_003DqTOglFiYSzm8UOhclH9_PRKkvf_x6z1g3FfFvdKt2cD6haJMcsl2xt6NoCia00AX8._0023_003DqDtEwVMn2ElYynS8dKUJ1MQ_003D_003D(_0023_003Dq5lVacHP7XW8yKIvqa_qEFA_003D_003D, (byte*)ptr + (nint)i * (nint)2, num * 2, 0, 2, 1, out var _);
			}
			if (num2 == 0)
			{
				if (!_0023_003Dq__0024xVSnaEJ_0024tPPIAd5fvHKA_003D_003D)
				{
					_0023_003DqVCN0en_0024Kd8LHEVmHKY6Piw_003D_003D = true;
					for (; i < _0023_003DqZwPCwsa1HSsTWtAe5_0024NquA_003D_003D; i++)
					{
						array[i] = 0;
					}
					break;
				}
				_0023_003DqTOglFiYSzm8UOhclH9_PRKkvf_x6z1g3FfFvdKt2cD6haJMcsl2xt6NoCia00AX8._0023_003DqnzmReTG4O_s3eXUXgfPOxQ_003D_003D(_0023_003Dq5lVacHP7XW8yKIvqa_qEFA_003D_003D, 0.0);
			}
			else if (num2 < 0)
			{
				throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065775373));
			}
			num2 /= 2;
		}
		if (_0023_003Dqu58AO6bjJyYmWpj5fhkuxQ_003D_003D == 1)
		{
			_0023_003DqZwPCwsa1HSsTWtAe5_0024NquA_003D_003D *= 2;
		}
		for (int j = 0; j < _0023_003DqZwPCwsa1HSsTWtAe5_0024NquA_003D_003D; j++)
		{
			int num3 = _0023_003Dq3yPHmztl27TXqO4vgMmQ7A_003D_003D[j];
			int num4 = ((_0023_003Dqu58AO6bjJyYmWpj5fhkuxQ_003D_003D != 1) ? ((!_0023_003Dq6_0024MJnFg85hEdSgj1R7LaCA_003D_003D) ? array[j] : array[j + 1 - 2 * (j % 2)]) : array[j / 2]);
			num4 = (int)((float)num4 * _0023_003Dqm5dN9_0024slTWUJiXmBai5Uug_003D_003D);
			_0023_003Dq3yPHmztl27TXqO4vgMmQ7A_003D_003D[j] = (short)Utility._0023_003DqPketCwwzMXFnMETn36UPyQ_003D_003D(num3 + num4, -32768, 32767);
		}
		if (_0023_003DqXHbUfsjK_AAH7RzFlPbblQ_003D_003D)
		{
			int num5 = 0;
			for (int k = 0; k < array.Length; k++)
			{
				num5 = Math.Max(num5, Math.Abs((int)array[k]));
			}
			_0023_003DqPgu7_4EOxdM8mzgJDyRXNA_003D_003D = (float)num5 / 32768f;
		}
	}

	public override bool _0023_003DqC9oNkbVkCpOCcCHd4AZhwQ_003D_003D()
	{
		return _0023_003DqVCN0en_0024Kd8LHEVmHKY6Piw_003D_003D;
	}

	public override void _0023_003DqV1F0AVDD6il2nfHp74mY1w_003D_003D(double _0023_003DqA0_sNyNWtUXOp16kyvQCIg_003D_003D)
	{
		_0023_003DqTOglFiYSzm8UOhclH9_PRKkvf_x6z1g3FfFvdKt2cD6haJMcsl2xt6NoCia00AX8._0023_003DqnzmReTG4O_s3eXUXgfPOxQ_003D_003D(_0023_003Dq5lVacHP7XW8yKIvqa_qEFA_003D_003D, _0023_003DqA0_sNyNWtUXOp16kyvQCIg_003D_003D);
		_0023_003DqVCN0en_0024Kd8LHEVmHKY6Piw_003D_003D = false;
	}

	public override double _0023_003Dq_0024Z7VwcaDYnx9939ijxV6HA_003D_003D()
	{
		return _0023_003DqTOglFiYSzm8UOhclH9_PRKkvf_x6z1g3FfFvdKt2cD6haJMcsl2xt6NoCia00AX8._0023_003DquybOdo7XvoanZ_CQXrlw7Q_003D_003D(_0023_003Dq5lVacHP7XW8yKIvqa_qEFA_003D_003D);
	}

	public override void _0023_003DqbrzhSNYChTcuhPfW2_Vetw_003D_003D()
	{
		_0023_003DqTOglFiYSzm8UOhclH9_PRKkvf_x6z1g3FfFvdKt2cD6haJMcsl2xt6NoCia00AX8._0023_003Dq4mqtR0Soi7QPcThf_0024Hf54g_003D_003D(_0023_003Dq5lVacHP7XW8yKIvqa_qEFA_003D_003D);
		Marshal.FreeHGlobal(_0023_003Dq5lVacHP7XW8yKIvqa_qEFA_003D_003D);
	}
}
