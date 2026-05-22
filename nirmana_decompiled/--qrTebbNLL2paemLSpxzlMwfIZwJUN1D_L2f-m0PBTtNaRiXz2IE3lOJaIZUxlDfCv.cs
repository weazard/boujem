internal static class _0023_003DqrTebbNLL2paemLSpxzlMwfIZwJUN1D_L2f_0024m0PBTtNaRiXz2IE3lOJaIZUxlDfCv
{
	public static byte[] _0023_003DquZw2kqDuAM3tJrPwcHio7g_003D_003D(byte[] _0023_003DqY_0024hHXiWqF8J5g2HWWG_0024sBJD2NCHowx63ffpnpxklT_0024g_003D, byte[] _0023_003DqI1ugE01ftWA_00244OwCISI7u9QLu4UZ6a_pEjamOArnUV4_003D)
	{
		byte b = _0023_003DqY_0024hHXiWqF8J5g2HWWG_0024sBJD2NCHowx63ffpnpxklT_0024g_003D[1];
		int num = _0023_003DqI1ugE01ftWA_00244OwCISI7u9QLu4UZ6a_pEjamOArnUV4_003D.Length;
		byte b2 = (byte)((num + 11) ^ (b + 7));
		uint num2 = (uint)((_0023_003DqY_0024hHXiWqF8J5g2HWWG_0024sBJD2NCHowx63ffpnpxklT_0024g_003D[0] | (_0023_003DqY_0024hHXiWqF8J5g2HWWG_0024sBJD2NCHowx63ffpnpxklT_0024g_003D[2] << 8)) + (b2 << 3));
		ushort num3 = 0;
		for (int i = 0; i < num; i++)
		{
			if ((i & 1) == 0)
			{
				num2 = num2 * 214013 + 2531011;
				num3 = (ushort)(num2 >> 16);
			}
			byte b3 = (byte)num3;
			num3 >>= 8;
			byte b4 = _0023_003DqI1ugE01ftWA_00244OwCISI7u9QLu4UZ6a_pEjamOArnUV4_003D[i];
			_0023_003DqI1ugE01ftWA_00244OwCISI7u9QLu4UZ6a_pEjamOArnUV4_003D[i] = (byte)(b4 ^ b ^ (b2 + 3) ^ b3);
			b2 = b4;
		}
		return _0023_003DqI1ugE01ftWA_00244OwCISI7u9QLu4UZ6a_pEjamOArnUV4_003D;
	}
}
