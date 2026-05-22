using System;
using System.Runtime.InteropServices;

public static class _0023_003DqM55GVP_2Oz0KS7PSBaLfHeXI1aEoUVz1quyWukExBpo_003D
{
	[DllImport("Renderer_D3D11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CreateTimestampDisjointQuery")]
	public static extern IntPtr _0023_003Dqh9Z9EqByXLwGxTk7pQDY13gLX7SiLyD06s9pxI_0024GrHg_003D();

	[DllImport("Renderer_D3D11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "CreateTimestampQuery")]
	public static extern IntPtr _0023_003Dqbrj_cPK5UKyPinrf0PIQp2Qx91nZQL_0024Qj7_0024eOIUkGcw_003D();

	[DllImport("Renderer_D3D11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "BeginQuery")]
	public static extern void _0023_003Dqf8R6hTD8k59UQhNiamQ1jA_003D_003D(IntPtr _0023_003DqpM6_0024WsEz_Gx06kRegPkf3Q_003D_003D);

	[DllImport("Renderer_D3D11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "EndQuery")]
	public static extern void _0023_003DqjUkoplaXrWYzA3CZotRK5w_003D_003D(IntPtr _0023_003Dqlz3jm58_blo1ffD2jT9_AA_003D_003D);

	[DllImport("Renderer_D3D11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetDataFromTimestampDisjointQuery")]
	public static extern int _0023_003DqdQi8SQAWFgKiWEHCqT1V0wuP7c7K45zjsUvPM_0024jye5wZq85VWoEbEzaQkcg28_9m(IntPtr _0023_003DqWzInjNJYYZYeGKoELe2prw_003D_003D, out ulong _0023_003Dq8XZU_lvKL1higKW3W2DayA_003D_003D, out int _0023_003DqotArbmUKX48ewAxf6FMQRA_003D_003D);

	[DllImport("Renderer_D3D11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GetDataFromTimestampQuery")]
	public static extern int _0023_003DquAXRE_0024eY2pTtRgIVossXYDcZN_0024ZEwHcVF782HZ9PFw0_003D(IntPtr _0023_003Dq3B3ix0j1u3_0024K8elxJKST9g_003D_003D, out ulong _0023_003DqtJZK3pI7E52e1LqWyMbtzg_003D_003D);
}
