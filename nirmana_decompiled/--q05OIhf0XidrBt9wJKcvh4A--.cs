using System.Collections.Generic;
using System.Text;

public sealed class _0023_003Dq05OIhf0XidrBt9wJKcvh4A_003D_003D
{
	public float _0023_003DqduomtqPKGmoBy7U_0024MaCr8Q_003D_003D;

	public float _0023_003DqstgmuSFRp0jC1G7t5CBRnw_003D_003D;

	public float _0023_003DqEteTzzF4V4LpM10eap_00244CA_003D_003D;

	public float _0023_003Dq0uuj0NR0a1EmWVAKBZY_Hw_003D_003D;

	public Dictionary<int, FontGlyphInfo> _0023_003DqIkhwRKybcs4sfHAPLR_0024e_Q_003D_003D;

	public Vector2 _0023_003Dqb7MnXUGGFAu2Fk5LqIyjTw_003D_003D;

	public Texture[] _0023_003DqEp9MrdzdGaFBPEKWOXCUXQ_003D_003D;

	private static FontGlyphInfo _0023_003DqdLEEpR7p12ZCsXk7TzboqG8WIfUhyu76RIgu4NYWoiw_003D = new FontGlyphInfo
	{
		AdvanceX = 0f,
		Height = 0f,
		OffsetX = 0f,
		OffsetY = 0f,
		TextureIndex = 0,
		Width = 0f,
		X = 0f,
		Y = 0f
	};

	public string _0023_003DqRVee7U1_0024O_Bzo_PgRbvq4dsJiJFaQOdRjaI81sR80wk_003D(string _0023_003Dqbrav0S6f_Pt2iKetk9Wdyw_003D_003D)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in _0023_003Dqbrav0S6f_Pt2iKetk9Wdyw_003D_003D)
		{
			if (c == '\n' || _0023_003DqIkhwRKybcs4sfHAPLR_0024e_Q_003D_003D.ContainsKey(c))
			{
				stringBuilder.Append(c);
			}
			else
			{
				stringBuilder.Append('?');
			}
		}
		return stringBuilder.ToString();
	}

	public bool _0023_003DqJCHXHb6yz2FsJYn5Q0LpdYTKzLfDWzvG_8Pgc1JBK_c_003D(int _0023_003Dq1im8w_ej9JCsBipxhzyXjA_003D_003D, out FontGlyphInfo _0023_003Dq7WOw_ZF0NT6PVVBD4HIh9A_003D_003D)
	{
		if (_0023_003Dq1im8w_ej9JCsBipxhzyXjA_003D_003D == 9679)
		{
			_0023_003Dq7WOw_ZF0NT6PVVBD4HIh9A_003D_003D = _0023_003DqdLEEpR7p12ZCsXk7TzboqG8WIfUhyu76RIgu4NYWoiw_003D;
			return true;
		}
		return _0023_003DqIkhwRKybcs4sfHAPLR_0024e_Q_003D_003D.TryGetValue(_0023_003Dq1im8w_ej9JCsBipxhzyXjA_003D_003D, out _0023_003Dq7WOw_ZF0NT6PVVBD4HIh9A_003D_003D);
	}

	public FontGlyphInfo _0023_003DqbqpjiIBRae2LT0PWQ_0024_0024CtWP_0024E3ineR_GpLh2eCmlS24_003D(int _0023_003DqPvbKbO4VX3stqEzjPrEb7g_003D_003D)
	{
		_0023_003DqJCHXHb6yz2FsJYn5Q0LpdYTKzLfDWzvG_8Pgc1JBK_c_003D(_0023_003DqPvbKbO4VX3stqEzjPrEb7g_003D_003D, out var _0023_003Dq7WOw_ZF0NT6PVVBD4HIh9A_003D_003D);
		return _0023_003Dq7WOw_ZF0NT6PVVBD4HIh9A_003D_003D;
	}

	public static List<CodepointRange> _0023_003DqrXvHk_0024dEqlMaWW95QAJFb6qVPP7tN8N_G4Mo9VrVUT8_003D()
	{
		return new List<CodepointRange>
		{
			new CodepointRange(32, 255),
			new CodepointRange(256, 591),
			new CodepointRange(880, 1023),
			new CodepointRange(1024, 1279),
			new CodepointRange(8192, 8303),
			new CodepointRange(8448, 8527),
			new CodepointRange(8704, 8959),
			new CodepointRange(12288, 12336),
			new CodepointRange(12352, 12543),
			new CodepointRange(19968, 40959),
			new CodepointRange(44032, 55215),
			new CodepointRange(65280, 65520)
		};
	}
}
