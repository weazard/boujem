using System.Runtime.InteropServices;

public static class _0023_003Dq66UBlR8bl9zKXr53wnzucg4wZSHH5Dg3QqKAx_0024dFgWs_003D
{
	private struct _0023_003DqQNKCTrnZPkurdQeRjj4ugxv3F4eUEb6xB6mwaPH61UI_003D
	{
		public uint _0023_003DqmvH7bxRevSfrW7ygGr9k7w_003D_003D;

		public uint _0023_003DqAWxKDBKA03qNDGE7DehVLg_003D_003D;
	}

	private static _0023_003DqQNKCTrnZPkurdQeRjj4ugxv3F4eUEb6xB6mwaPH61UI_003D _0023_003Dq9XlCti4tH2N0HRO_0024azahCw_003D_003D;

	static _0023_003Dq66UBlR8bl9zKXr53wnzucg4wZSHH5Dg3QqKAx_0024dFgWs_003D()
	{
		_0023_003DqGpudxhVUHDkhM8HW4qfvMBsG5amaCWrV_bfK_0024vifq40_003D(ref _0023_003Dq9XlCti4tH2N0HRO_0024azahCw_003D_003D);
	}

	[DllImport("/usr/lib/libSystem.dylib", EntryPoint = "mach_absolute_time")]
	private static extern ulong _0023_003DqFla7gNTRMC_0024GE2aQC87fAS0jqthKJkxxToSPlW8vmkc_003D();

	[DllImport("/usr/lib/libSystem.dylib", EntryPoint = "mach_timebase_info")]
	private static extern int _0023_003DqGpudxhVUHDkhM8HW4qfvMBsG5amaCWrV_bfK_0024vifq40_003D(ref _0023_003DqQNKCTrnZPkurdQeRjj4ugxv3F4eUEb6xB6mwaPH61UI_003D _0023_003DqANEcZFeNewCdrUAAEUGCQw_003D_003D);

	[DllImport("/usr/lib/libSystem.dylib", EntryPoint = "mach_wait_until")]
	private static extern int _0023_003DqHQb1vYVgtMgHwFaY_0024HlEwaxBE7cYmbBABbM_eDA0Rp0_003D(ulong _0023_003DqHpkn_YBrOtqNF3sEsvUEKQ_003D_003D);

	public static void _0023_003DqggWEBezvre9i6auU_uWQ9bmIF17t2KUuees6xNODpiA_003D(ulong _0023_003DqEKghKw93UbUHinGfsSSAVA_003D_003D)
	{
		ulong num = _0023_003DqFla7gNTRMC_0024GE2aQC87fAS0jqthKJkxxToSPlW8vmkc_003D();
		ulong num2 = _0023_003DqEKghKw93UbUHinGfsSSAVA_003D_003D * _0023_003Dq9XlCti4tH2N0HRO_0024azahCw_003D_003D._0023_003DqAWxKDBKA03qNDGE7DehVLg_003D_003D / _0023_003Dq9XlCti4tH2N0HRO_0024azahCw_003D_003D._0023_003DqmvH7bxRevSfrW7ygGr9k7w_003D_003D;
		_0023_003DqHQb1vYVgtMgHwFaY_0024HlEwaxBE7cYmbBABbM_eDA0Rp0_003D(num + num2);
	}
}
