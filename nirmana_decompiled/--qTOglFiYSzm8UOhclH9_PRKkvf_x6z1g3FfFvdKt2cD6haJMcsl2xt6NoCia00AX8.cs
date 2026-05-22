using System;
using System.Runtime.InteropServices;

public static class _0023_003DqTOglFiYSzm8UOhclH9_PRKkvf_x6z1g3FfFvdKt2cD6haJMcsl2xt6NoCia00AX8
{
	public struct _0023_003Dq3eqX8sBeyUL1ZKe4s3njTg_003D_003D
	{
		public int _0023_003Dqoon_0024nEg5XLLW_0024sWTVZkd5A_003D_003D;

		public int _0023_003DqSe_ssqUaLfZM5_0024jvhCYH1Q_003D_003D;

		public int _0023_003DqqlDoYkj_0024wDH33iO0mJk66Q_003D_003D;

		public int _0023_003DqLEE4CTO34jEBD34O133sUg_003D_003D;

		public int _0023_003Dq5zAskRpAyvPBQc6xHrQzGFU3pWphonUi72cxlpHqIXs_003D;

		public int _0023_003DqRbJ8bSaaUfSPfoNzDxRqtA_003D_003D;

		public int _0023_003DqolPL1S4Df_00243Munqpcieddg_003D_003D;

		public IntPtr _0023_003DqnCq8k_BIcWZWAwaayx2t8A_003D_003D;
	}

	public static IntPtr _0023_003Dq8ze9nV9VYCHJn8BHIY7JOjvdYLVUn7DksVZRlFdyCa4_003D()
	{
		return Marshal.AllocHGlobal(4096);
	}

	[DllImport("libvorbisfile.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ov_clear")]
	public static extern int _0023_003Dq4mqtR0Soi7QPcThf_0024Hf54g_003D_003D(IntPtr _0023_003DqPEcWGmwdluVGY8zVdrv38Q_003D_003D);

	[DllImport("libvorbisfile.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ov_fopen")]
	public static extern int _0023_003Dqz60k671dmjBweDT_vmgQRg_003D_003D(string _0023_003DqnsuUsGfDUFIRLMElPrIQbA_003D_003D, IntPtr _0023_003DqKOsjY_I46O1d1qoqWdeeLg_003D_003D);

	[DllImport("libvorbisfile.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ov_streams")]
	public static extern int _0023_003DqWZGOLhqgB1XBgAYkI493yw_003D_003D(IntPtr _0023_003DqJAVc5DORHW9GTp7JBPYR6Q_003D_003D);

	[DllImport("libvorbisfile.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ov_info")]
	public static extern IntPtr _0023_003DqMewWKIDZiGlETuZHlg6r_g_003D_003D(IntPtr _0023_003DqD51ArTvNUY_0024jUeA1NehHLQ_003D_003D, int _0023_003DqyVkDUYW3rQcdUx6PqYVo_0024A_003D_003D);

	[DllImport("libvorbisfile.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ov_read")]
	public unsafe static extern int _0023_003DqDtEwVMn2ElYynS8dKUJ1MQ_003D_003D(IntPtr _0023_003DqD0Duw1eZbx1LrF2OUTfhQg_003D_003D, byte* _0023_003DqJqhHZTIdo3kO_00246SezHosHQ_003D_003D, int _0023_003DqeIAVeyq3L_Z5XGnLC7IV2g_003D_003D, int _0023_003DqIZpv6_0024x1OjDr1rjWqMYxgQ_003D_003D, int _0023_003DqiVMUK2tiFq4Zn5LVANXPcg_003D_003D, int _0023_003Dq63srNVTK37ad5lUrGg5UYg_003D_003D, out int _0023_003Dqm_sejEXooMhtStzHXuuAlg_003D_003D);

	[DllImport("libvorbisfile.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ov_time_seek")]
	public static extern int _0023_003DqnzmReTG4O_s3eXUXgfPOxQ_003D_003D(IntPtr _0023_003DqPEcWGmwdluVGY8zVdrv38Q_003D_003D, double _0023_003DqnqQ_0024U5eO5MF2N6YmRiQaaw_003D_003D);

	[DllImport("libvorbisfile.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "ov_time_tell")]
	public static extern double _0023_003DquybOdo7XvoanZ_CQXrlw7Q_003D_003D(IntPtr _0023_003Dqqlqh0xqX5N1E8aCFuUTC0A_003D_003D);
}
