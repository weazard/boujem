using System;

public sealed class UndoSnapshot
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<byte, byte, bool> _003C_003E9__1_0;

		internal bool _0023_003DqyH0TKnkOVf72uJutaQnMQONqvowLiMiqR1mXO6_0024En00_003D(byte _0023_003Dqf6oNGxW7eH5_0024g6Ijkk7G_0024A_003D_003D, byte _0023_003DqzK2pjfyPsT5tsMOtqbjrog_003D_003D)
		{
			return _0023_003Dqf6oNGxW7eH5_0024g6Ijkk7G_0024A_003D_003D == _0023_003DqzK2pjfyPsT5tsMOtqbjrog_003D_003D;
		}
	}

	public byte[] _0023_003DqDAu0MBkAtp9iF5wM5TUJKg_003D_003D;

	public bool _0023_003Dq3pTITOnPfZY8_bijTGNH4w_003D_003D(UndoSnapshot _0023_003DqOI4Lc_9Q127v6meRZH6rSQ_003D_003D)
	{
		return Utility._0023_003Dq_0024sAyWKsdUpF_wY_lSPoUuQ_003D_003D(_0023_003DqDAu0MBkAtp9iF5wM5TUJKg_003D_003D, _0023_003DqOI4Lc_9Q127v6meRZH6rSQ_003D_003D._0023_003DqDAu0MBkAtp9iF5wM5TUJKg_003D_003D, (byte _0023_003Dqf6oNGxW7eH5_0024g6Ijkk7G_0024A_003D_003D, byte _0023_003DqzK2pjfyPsT5tsMOtqbjrog_003D_003D) => _0023_003Dqf6oNGxW7eH5_0024g6Ijkk7G_0024A_003D_003D == _0023_003DqzK2pjfyPsT5tsMOtqbjrog_003D_003D);
	}
}
