using System;
using System.IO;
using System.Runtime.CompilerServices;

public sealed class _0023_003DqDXauXoByfoeu8YB4_0024Cv1Jw_003D_003D : _0023_003DqHLijordWwR3lZzytiiPSOg_003D_003D
{
	public readonly Texture _0023_003DqjaMjPQCGtyB2_6JJ7KFqhw_003D_003D;

	public readonly Texture _0023_003DqTvIvmonCdxqmIKnThG2Ibg_003D_003D;

	public readonly string _0023_003DqJYKCRZFBRk5MWUbbBtTaKg_003D_003D;

	[NonSerialized]
	public int _0023_003Dqd083jHbyNuIIby86neKgPA_003D_003D;

	[NonSerialized]
	public AnimationFrame[] _0023_003DqplsSFeA_0024y_bvua9HQvQcAg_003D_003D;

	public static readonly int _0023_003Dq9Shrgu9eU3j4UEY1XMvikQ_003D_003D = 2;

	public _0023_003DqDXauXoByfoeu8YB4_0024Cv1Jw_003D_003D(Texture _0023_003DqndQ7sC3eXRIq2eFBK9Ioig_003D_003D, Texture _0023_003Dqc05GiZ6_uaiW0g_IyX__CQ_003D_003D, string _0023_003DqP9TT4SrzK3f68aWsjPcQyQ_003D_003D)
	{
		_0023_003DqjaMjPQCGtyB2_6JJ7KFqhw_003D_003D = _0023_003DqndQ7sC3eXRIq2eFBK9Ioig_003D_003D;
		_0023_003DqTvIvmonCdxqmIKnThG2Ibg_003D_003D = _0023_003Dqc05GiZ6_uaiW0g_IyX__CQ_003D_003D;
		_0023_003DqJYKCRZFBRk5MWUbbBtTaKg_003D_003D = _0023_003DqP9TT4SrzK3f68aWsjPcQyQ_003D_003D;
		_0023_003DqwngJULso2neYiIl4tjpOrw_003D_003D();
	}

	[SpecialName]
	public int _0023_003DqrpdjDuZels0mBPLCCakWsw_003D_003D()
	{
		return _0023_003DqplsSFeA_0024y_bvua9HQvQcAg_003D_003D.Length;
	}

	public static _0023_003DqDXauXoByfoeu8YB4_0024Cv1Jw_003D_003D _0023_003DqMnQdYWx7wFc4bgqO_0024cFzmg_003D_003D(Texture _0023_003Dqjnw7q7CJAyWynDLHLsgWuw_003D_003D, Texture _0023_003DqMZ2NkyXz_0024Wz2kdWm49vb_g_003D_003D, string _0023_003DqxjRNktPraPjvg9__0024XP0GQg_003D_003D)
	{
		return new _0023_003DqDXauXoByfoeu8YB4_0024Cv1Jw_003D_003D(_0023_003Dqjnw7q7CJAyWynDLHLsgWuw_003D_003D, _0023_003DqMZ2NkyXz_0024Wz2kdWm49vb_g_003D_003D, _0023_003DqxjRNktPraPjvg9__0024XP0GQg_003D_003D);
	}

	public void _0023_003DqwngJULso2neYiIl4tjpOrw_003D_003D()
	{
		_0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2 = new _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D(File.ReadAllBytes(Path.Combine(_0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003Dq3OoYNllhnAYBu3onh_zX1g_003D_003D, _0023_003DqJYKCRZFBRk5MWUbbBtTaKg_003D_003D)));
		ushort num = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003DqjR1F78eaT36hNyYwNMO0tg_003D_003D();
		if (num > _0023_003Dq9Shrgu9eU3j4UEY1XMvikQ_003D_003D)
		{
			throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065775114));
		}
		_0023_003Dqd083jHbyNuIIby86neKgPA_003D_003D = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003DqjR1F78eaT36hNyYwNMO0tg_003D_003D();
		ushort num2 = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003DqjR1F78eaT36hNyYwNMO0tg_003D_003D();
		_0023_003DqplsSFeA_0024y_bvua9HQvQcAg_003D_003D = new AnimationFrame[num2];
		for (int i = 0; i < num2; i++)
		{
			ushort num3 = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003DqjR1F78eaT36hNyYwNMO0tg_003D_003D();
			_0023_003DqplsSFeA_0024y_bvua9HQvQcAg_003D_003D[i] = default(AnimationFrame);
			_0023_003DqplsSFeA_0024y_bvua9HQvQcAg_003D_003D[i].Patches = new AnimationPatch[num3];
			for (int j = 0; j < num3; j++)
			{
				AnimationPatch animationPatch = new AnimationPatch
				{
					SrcX = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003DqjR1F78eaT36hNyYwNMO0tg_003D_003D(),
					SrcY = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003DqjR1F78eaT36hNyYwNMO0tg_003D_003D()
				};
				if (num == 1)
				{
					animationPatch.DestX = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003DqjR1F78eaT36hNyYwNMO0tg_003D_003D();
					animationPatch.DestY = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003DqjR1F78eaT36hNyYwNMO0tg_003D_003D();
				}
				else
				{
					animationPatch.DestX = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003Dqiy5HqEKyG_oB_JRG5dQzVQ_003D_003D();
					animationPatch.DestY = _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D2._0023_003Dqiy5HqEKyG_oB_JRG5dQzVQ_003D_003D();
				}
				_0023_003DqplsSFeA_0024y_bvua9HQvQcAg_003D_003D[i].Patches[j] = animationPatch;
			}
		}
	}

	public void _0023_003DqKGsZTwyQC_MWdFYXbWh_MA_003D_003D(int _0023_003Dqoos23rpztrVMwawX9nsAXQ_003D_003D, Vector2 _0023_003Dq1P7SU2XvrC0NMz5ULaUjoA_003D_003D, float _0023_003Dqcg7j0O8AisBG7lywJNGu8g_003D_003D)
	{
		_0023_003DqLrNZ8EtVXKzZH_5THvByIA_003D_003D(_0023_003Dqoos23rpztrVMwawX9nsAXQ_003D_003D, _0023_003Dq1P7SU2XvrC0NMz5ULaUjoA_003D_003D, Color.White, _0023_003Dqcg7j0O8AisBG7lywJNGu8g_003D_003D);
	}

	public void _0023_003DqLrNZ8EtVXKzZH_5THvByIA_003D_003D(int _0023_003Dqh1LSLZ9vZ_YD797XaIvhqg_003D_003D, Vector2 _0023_003Dq6VZ57WBDLILvfUzyXZkN3g_003D_003D, Color _0023_003Dqvt7s_0024Mln9HWbEliioA0C6A_003D_003D, float _0023_003Dqb4bmdwrYrFVaNqfOjgF1qQ_003D_003D)
	{
		_0023_003Dqh1LSLZ9vZ_YD797XaIvhqg_003D_003D = Utility._0023_003DqPketCwwzMXFnMETn36UPyQ_003D_003D(_0023_003Dqh1LSLZ9vZ_YD797XaIvhqg_003D_003D, 0, _0023_003DqplsSFeA_0024y_bvua9HQvQcAg_003D_003D.Length - 1);
		G._0023_003DqUA3CdsXmphnGerSOSUhPpQ_003D_003D(_0023_003DqjaMjPQCGtyB2_6JJ7KFqhw_003D_003D, _0023_003Dqvt7s_0024Mln9HWbEliioA0C6A_003D_003D, _0023_003Dq6VZ57WBDLILvfUzyXZkN3g_003D_003D, _0023_003DqjaMjPQCGtyB2_6JJ7KFqhw_003D_003D._0023_003DqZn_0024hX3SaBiPQbhA3g_LsQQ_003D_003D * _0023_003Dqb4bmdwrYrFVaNqfOjgF1qQ_003D_003D);
		PackedColor color = _0023_003Dqvt7s_0024Mln9HWbEliioA0C6A_003D_003D.WithPremultipliedAlpha().Packed();
		AnimationPatch[] patches = _0023_003DqplsSFeA_0024y_bvua9HQvQcAg_003D_003D[_0023_003Dqh1LSLZ9vZ_YD797XaIvhqg_003D_003D].Patches;
		for (int i = 0; i < patches.Length; i++)
		{
			AnimationPatch animationPatch = patches[i];
			Vector2 vector = new Vector2((int)animationPatch.SrcX, (int)animationPatch.SrcY);
			Vector2 vector2 = _0023_003Dq6VZ57WBDLILvfUzyXZkN3g_003D_003D + new Vector2(animationPatch.DestX, animationPatch.DestY) * _0023_003Dqb4bmdwrYrFVaNqfOjgF1qQ_003D_003D;
			Vector2 vector3 = new Vector2(_0023_003Dqd083jHbyNuIIby86neKgPA_003D_003D, _0023_003Dqd083jHbyNuIIby86neKgPA_003D_003D);
			Vector2 vector4 = vector3 * _0023_003Dqb4bmdwrYrFVaNqfOjgF1qQ_003D_003D;
			float x = vector2.X;
			float x2 = vector2.X + vector4.X;
			float y = vector2.Y;
			float y2 = vector2.Y + vector4.Y;
			Vector3 normal = new Vector3(0f, 0f, -1f);
			Vector2 _0023_003DqZn_0024hX3SaBiPQbhA3g_LsQQ_003D_003D = _0023_003DqTvIvmonCdxqmIKnThG2Ibg_003D_003D._0023_003DqZn_0024hX3SaBiPQbhA3g_LsQQ_003D_003D;
			Bounds2 bounds = Bounds2.WithSize(vector.X / _0023_003DqZn_0024hX3SaBiPQbhA3g_LsQQ_003D_003D.X, vector.Y / _0023_003DqZn_0024hX3SaBiPQbhA3g_LsQQ_003D_003D.Y, vector3.X / _0023_003DqZn_0024hX3SaBiPQbhA3g_LsQQ_003D_003D.X, vector3.Y / _0023_003DqZn_0024hX3SaBiPQbhA3g_LsQQ_003D_003D.Y);
			G._0023_003DqZyyMnL4dFeDp5h46emC5tw_003D_003D(_0023_003DqTvIvmonCdxqmIKnThG2Ibg_003D_003D, new MeshVertex(new Vector3(x, y2, 0f), normal, new Vector2(bounds.Min.X, bounds.Max.Y), Vector2.Zero, color), new MeshVertex(new Vector3(x2, y2, 0f), normal, new Vector2(bounds.Max.X, bounds.Max.Y), Vector2.Zero, color), new MeshVertex(new Vector3(x2, y, 0f), normal, new Vector2(bounds.Max.X, bounds.Min.Y), Vector2.Zero, color), new MeshVertex(new Vector3(x, y, 0f), normal, new Vector2(bounds.Min.X, bounds.Min.Y), Vector2.Zero, color));
		}
	}

	private void _0023_003DqJpwvNb_y9ZL6vijaC_A_00246IKAExxpKhDeagO1h6s_S_g_003D(int _0023_003DqfpMLYJVTitxjv9AoYVVwUw_003D_003D, Color _0023_003Dq2pk1uO2guxdKZIiDlqQ1ug_003D_003D, Vector2 _0023_003Dq7fwNcTLbNgnu3_J2_5RuaA_003D_003D, float _0023_003DqAyPjpu8qldRcpoIu28bO5Q_003D_003D, Bounds2 _0023_003DqDWQoSH5UH3FyJkTOUBuHJA_003D_003D)
	{
		_0023_003DqLrNZ8EtVXKzZH_5THvByIA_003D_003D(_0023_003DqfpMLYJVTitxjv9AoYVVwUw_003D_003D, _0023_003Dq7fwNcTLbNgnu3_J2_5RuaA_003D_003D, _0023_003Dq2pk1uO2guxdKZIiDlqQ1ug_003D_003D, _0023_003DqAyPjpu8qldRcpoIu28bO5Q_003D_003D);
	}

	void _0023_003DqHLijordWwR3lZzytiiPSOg_003D_003D._0023_003DqbqQiwy8aUFDzD_002466JhH6ZQ_003D_003D(int _0023_003DqfpMLYJVTitxjv9AoYVVwUw_003D_003D, Color _0023_003Dq2pk1uO2guxdKZIiDlqQ1ug_003D_003D, Vector2 _0023_003Dq7fwNcTLbNgnu3_J2_5RuaA_003D_003D, float _0023_003DqAyPjpu8qldRcpoIu28bO5Q_003D_003D, Bounds2 _0023_003DqDWQoSH5UH3FyJkTOUBuHJA_003D_003D)
	{
		//ILSpy generated this explicit interface implementation from .override directive in #=qJpwvNb_y9ZL6vijaC_A$6IKAExxpKhDeagO1h6s_S_g=
		this._0023_003DqJpwvNb_y9ZL6vijaC_A_00246IKAExxpKhDeagO1h6s_S_g_003D(_0023_003DqfpMLYJVTitxjv9AoYVVwUw_003D_003D, _0023_003Dq2pk1uO2guxdKZIiDlqQ1ug_003D_003D, _0023_003Dq7fwNcTLbNgnu3_J2_5RuaA_003D_003D, _0023_003DqAyPjpu8qldRcpoIu28bO5Q_003D_003D, _0023_003DqDWQoSH5UH3FyJkTOUBuHJA_003D_003D);
	}
}
