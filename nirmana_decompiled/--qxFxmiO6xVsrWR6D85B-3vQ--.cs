using System.IO;
using System.Text;

public static class _0023_003DqxFxmiO6xVsrWR6D85B_00243vQ_003D_003D
{
	private static bool _0023_003DqGhy0XXIjlzKHET95gzLmFA_003D_003D;

	private static byte[] _0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D;

	private static string _0023_003Dqd_ewPF7ImUIvUO_0024AQnyl6w_003D_003D;

	private static void _0023_003DqSN8mMLg7nF9WVKpsuypLlw_003D_003D()
	{
		if (!_0023_003DqGhy0XXIjlzKHET95gzLmFA_003D_003D)
		{
			_0023_003DqGhy0XXIjlzKHET95gzLmFA_003D_003D = true;
			_0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D = File.ReadAllBytes(Path.Combine(_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003Dq3OoYNllhnAYBu3onh_zX1g_003D_003D, _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065792622)));
			_0023_003Dqd_ewPF7ImUIvUO_0024AQnyl6w_003D_003D = File.ReadAllText(Path.Combine(_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003Dq3OoYNllhnAYBu3onh_zX1g_003D_003D, _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065792634)));
		}
	}

	public static string _0023_003Dq_0024ciClXEtToqRdTh7YIZK8Q_003D_003D(this string _0023_003Dq9QvWqi28zzdfgLgggue0XQ_003D_003D, _0023_003DqlLeUbetm_iM4DChW85P1zA_003D_003D _0023_003DqfaAE54Pl1GAc5O5RdLwHhg_003D_003D)
	{
		_0023_003DqSN8mMLg7nF9WVKpsuypLlw_003D_003D();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < _0023_003Dq9QvWqi28zzdfgLgggue0XQ_003D_003D.Length; i++)
		{
			char c = _0023_003Dq9QvWqi28zzdfgLgggue0XQ_003D_003D[i];
			if (_0023_003DqfaAE54Pl1GAc5O5RdLwHhg_003D_003D._0023_003DqwofQj2C_0024aS3Ns6Ed5mfH_0024A_003D_003D[(_0023_003DqOgHe_0024MI4JdH5PbTM56sSvw_003D_003D)0]._0023_003DqJCHXHb6yz2FsJYn5Q0LpdYTKzLfDWzvG_8Pgc1JBK_c_003D(c, out var _))
			{
				stringBuilder.Append(c);
				continue;
			}
			int num = c * 3;
			if (char.IsHighSurrogate(c))
			{
				num = char.ConvertToUtf32(c, _0023_003Dq9QvWqi28zzdfgLgggue0XQ_003D_003D[i + 1]) * 3;
				i++;
			}
			if (num + 2 < _0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D.Length)
			{
				int num2 = _0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D[num + 2];
				switch (num2)
				{
				case 1:
					stringBuilder.Append((char)_0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D[num]);
					break;
				case 2:
					stringBuilder.Append((char)_0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D[num]);
					stringBuilder.Append((char)_0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D[num + 1]);
					break;
				default:
				{
					int startIndex = _0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D[num] | (_0023_003DqMc54guAKGi8NsPcQPKya_0024Q_003D_003D[num + 1] << 8);
					stringBuilder.Append(_0023_003Dqd_ewPF7ImUIvUO_0024AQnyl6w_003D_003D.Substring(startIndex, num2));
					break;
				}
				}
			}
		}
		return stringBuilder.ToString();
	}
}
