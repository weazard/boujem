using System;
using System.Runtime.InteropServices;
using SDL2;

public static class _0023_003DqZBY7JNLqygyt_1mZMUcqbQ_003D_003D
{
	public enum _0023_003DqlI7gcEt0vzcDmPnHrA8nzA_003D_003D
	{

	}

	public static void _0023_003DqpSg9SyHpoiIPMPwZGKlhD32QfIjCToYjXk0V7WHF1TE_003D(out SDL.SDL_version _0023_003DqEQblTiEecJkDUuEdJJvk0g_003D_003D)
	{
		_0023_003DqEQblTiEecJkDUuEdJJvk0g_003D_003D.major = 2;
		_0023_003DqEQblTiEecJkDUuEdJJvk0g_003D_003D.minor = 0;
		_0023_003DqEQblTiEecJkDUuEdJJvk0g_003D_003D.patch = 2;
	}

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LinkedVersion")]
	private static extern IntPtr _0023_003Dq8_h8e1UIbs8suOLRcPby9V9Z3SjXOhVyyPOXQicl1dE_003D();

	public static SDL.SDL_version _0023_003DqpycOhnaHFYDMQ_0024HV1O3dD1Ic97GClafS0fM1fnP_wf8_003D()
	{
		return (SDL.SDL_version)Marshal.PtrToStructure(_0023_003Dq8_h8e1UIbs8suOLRcPby9V9Z3SjXOhVyyPOXQicl1dE_003D(), typeof(SDL.SDL_version));
	}

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Init")]
	public static extern int _0023_003DqHXNfnAOJ3GordKQojw7DRw_003D_003D(_0023_003DqlI7gcEt0vzcDmPnHrA8nzA_003D_003D _0023_003DqEpQgobwB7JvDZwufcQL29w_003D_003D);

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Quit")]
	public static extern void _0023_003Dq4q_n1VID9yowAPlljN6QhQ_003D_003D();

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Load")]
	private static extern IntPtr _0023_003DqchT_0024fG5NyYh4hG3wXpE7F7Ba1uxSM5GYa612oYlhar4_003D(byte[] _0023_003DqcCKtVJW3AcPdoeZjwan3XQ_003D_003D);

	public static IntPtr _0023_003DqPBOrf8U7YuhnnZHE_0024_0024gWnQ_003D_003D(string _0023_003DqsGdTwWib2M9FcJKbo4saGw_003D_003D)
	{
		return _0023_003DqchT_0024fG5NyYh4hG3wXpE7F7Ba1uxSM5GYa612oYlhar4_003D(SDL.UTF8_ToNative(_0023_003DqsGdTwWib2M9FcJKbo4saGw_003D_003D));
	}

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_Load_RW")]
	public static extern IntPtr _0023_003DqaRpCA92Rn3vunk9E3VjEFQ_003D_003D(IntPtr _0023_003Dq7Q_0024bVq0_0024ZBMKAknYKhpmCA_003D_003D, int _0023_003DqROv1XLTIZrhDULHB0pI6AQ_003D_003D);

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTyped_RW")]
	private static extern IntPtr _0023_003DqidM4YOvH_0024jszSnL1fWmA7ZUIZLLBTJSah3dgw1_O_0024aI_003D(IntPtr _0023_003Dq2cDWAUda3Nzu9AG3_er0lg_003D_003D, int _0023_003Dq6D6cz6Z0k3zsBjUItH1h9A_003D_003D, byte[] _0023_003Dq9p4ciPmffbH355yAyBT7Mw_003D_003D);

	public static IntPtr _0023_003Dqh13jtUdQ2w12xw8X0OXky_0024jowaeDxq_pr7DKTDAColM_003D(IntPtr _0023_003Dq6IBYtCWFKVacCAwX7795lg_003D_003D, int _0023_003DqlQFQCJQCXNosj8MBE1Au5Q_003D_003D, string _0023_003DqH59qAC2a0y1MjI68C6_0024MdQ_003D_003D)
	{
		return _0023_003DqidM4YOvH_0024jszSnL1fWmA7ZUIZLLBTJSah3dgw1_O_0024aI_003D(_0023_003Dq6IBYtCWFKVacCAwX7795lg_003D_003D, _0023_003DqlQFQCJQCXNosj8MBE1Au5Q_003D_003D, SDL.UTF8_ToNative(_0023_003DqH59qAC2a0y1MjI68C6_0024MdQ_003D_003D));
	}

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTexture")]
	private static extern IntPtr _0023_003DqqgdGUx_0024Gn7XV6d4RE9JgiMeyF0_N9NQkfmzlu495uAY_003D(IntPtr _0023_003DqX1JIAR6O_cnzcz6CddKOQg_003D_003D, byte[] _0023_003DqgrFMhMlM0X0X7gX_0024LeWPFQ_003D_003D);

	public static IntPtr _0023_003DqtYZaSS3bwJB9SZ3Pf0iT0Po_Ij_qTjXCPcFWEZJRD64_003D(IntPtr _0023_003DqCeFoLxU14gQfFfJGDhPTXw_003D_003D, string _0023_003DqGPDyGaXd78fILd5PC0GG1w_003D_003D)
	{
		return _0023_003DqqgdGUx_0024Gn7XV6d4RE9JgiMeyF0_N9NQkfmzlu495uAY_003D(_0023_003DqCeFoLxU14gQfFfJGDhPTXw_003D_003D, SDL.UTF8_ToNative(_0023_003DqGPDyGaXd78fILd5PC0GG1w_003D_003D));
	}

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTexture_RW")]
	public static extern IntPtr _0023_003DqIpMf1GI9SMBMn9iOT_dkLS3hrtoEWJJRMCTQFgk7CxI_003D(IntPtr _0023_003DquE53kimShp6ykxnYd9g5CA_003D_003D, IntPtr _0023_003DqPFaGOeQFMVxtjAILGRpmew_003D_003D, int _0023_003DqF83nwRBBefqqnJpWlkwVlQ_003D_003D);

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_LoadTextureTyped_RW")]
	private static extern IntPtr _0023_003DqQTjK8VSIZljb7OczSc42RI__0024Fbbmkwg53xy2ha_CPZxyBeI735hfxSf2ZhsJObFv(IntPtr _0023_003Dq1j1JQxLrIYrpr1j94kB4tA_003D_003D, IntPtr _0023_003DqBY_0024ZLCnoyhCi7PeVmiE5Ig_003D_003D, int _0023_003DqqcVE9uiConkFJgiZnZ6xYw_003D_003D, byte[] _0023_003DqAtvKEm4BtePQ02kwKfFubQ_003D_003D);

	public static IntPtr _0023_003DqEAwcZWxDEOWEhnOxIOBi_w4N5UcPmKAnD4lLy1FM8kY_003D(IntPtr _0023_003DqMwePrHrWmIjjatCKPPeCFA_003D_003D, IntPtr _0023_003Dq16GPV08qTE_0024iAe4Fch5z5Q_003D_003D, int _0023_003DqJQ_t5ForlozpH3NqDIdnyg_003D_003D, string _0023_003DqMqKWSpYF4ObDwkjmPMsS8w_003D_003D)
	{
		return _0023_003DqQTjK8VSIZljb7OczSc42RI__0024Fbbmkwg53xy2ha_CPZxyBeI735hfxSf2ZhsJObFv(_0023_003DqMwePrHrWmIjjatCKPPeCFA_003D_003D, _0023_003Dq16GPV08qTE_0024iAe4Fch5z5Q_003D_003D, _0023_003DqJQ_t5ForlozpH3NqDIdnyg_003D_003D, SDL.UTF8_ToNative(_0023_003DqMqKWSpYF4ObDwkjmPMsS8w_003D_003D));
	}

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_InvertAlpha")]
	public static extern int _0023_003DqxGtXIG8zvBsskhkeeI1eNeZBxDrIAeQhOfsNaWkJBok_003D(int _0023_003DqTTfHE4T9HsKHeQW2myM2cQ_003D_003D);

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_ReadXPMFromArray")]
	public static extern IntPtr _0023_003Dq8BTQ1AhaqNZUr66I46rh67cSFWSKx1QUS5hHOIsiVlQ_003D([In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPStr, SizeConst = 0)] string[] _0023_003DqtBdktTA0iGNIR19ySZ1VRA_003D_003D);

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SavePNG")]
	private static extern int _0023_003Dqp_0024_00240Q_kbuuMRCfjYM6OGIoucnXECAjqCMt13w4RtatU_003D(IntPtr _0023_003Dq74LZAkswZ8h4dgyxKHJnww_003D_003D, byte[] _0023_003DqaEQzA4_0024EoVzq7hB2u1AQLQ_003D_003D);

	public static int _0023_003DqEOs_WKCyTxAqZS7apzhM_w_003D_003D(IntPtr _0023_003DqAe5kM_qJw9R8uAjwxphY3Q_003D_003D, string _0023_003DqgrFMhMlM0X0X7gX_0024LeWPFQ_003D_003D)
	{
		return _0023_003Dqp_0024_00240Q_kbuuMRCfjYM6OGIoucnXECAjqCMt13w4RtatU_003D(_0023_003DqAe5kM_qJw9R8uAjwxphY3Q_003D_003D, SDL.UTF8_ToNative(_0023_003DqgrFMhMlM0X0X7gX_0024LeWPFQ_003D_003D));
	}

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SavePNG_RW")]
	public static extern int _0023_003Dqp3Tp9teaYc1tlcGXgDzMOQ_003D_003D(IntPtr _0023_003DqyHyOsF8qxQMd4xLmlNuChA_003D_003D, IntPtr _0023_003Dq7hV7Pi2jb6bLg2i2CM6_QA_003D_003D, int _0023_003DqC0md2krI47aU1_00240RwnIaBg_003D_003D);

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveJPG")]
	private static extern int _0023_003DqQweAcRRZw8CuM4h6nt_00249J_002470Px8TqA9leEvEqhp9Wh8_003D(IntPtr _0023_003DqwVD_KRbqWo6G98hykV3Idw_003D_003D, byte[] _0023_003DqPH2AKu5S0t07a7Z_N64l0Q_003D_003D, int _0023_003Dqg0cyBIxm_9_o3Av0r21UGw_003D_003D);

	public static int _0023_003DqZpz1WCCXUdHjbEKh5CpQpQ_003D_003D(IntPtr _0023_003Dqbc0fQ7GHRH6rUjus1LhccQ_003D_003D, string _0023_003Dqpg0tG8AsDu_0024q_2AXB9Ip_A_003D_003D, int _0023_003Dq_002493B0LIdGccpqqmWXUXPpQ_003D_003D)
	{
		return _0023_003DqQweAcRRZw8CuM4h6nt_00249J_002470Px8TqA9leEvEqhp9Wh8_003D(_0023_003Dqbc0fQ7GHRH6rUjus1LhccQ_003D_003D, SDL.UTF8_ToNative(_0023_003Dqpg0tG8AsDu_0024q_2AXB9Ip_A_003D_003D), _0023_003Dq_002493B0LIdGccpqqmWXUXPpQ_003D_003D);
	}

	[DllImport("SDL2_image.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "IMG_SaveJPG_RW")]
	public static extern int _0023_003Dqa77bhs2FI5me_0024rh_RDotQQ_003D_003D(IntPtr _0023_003DqizQN5CzEJu7Th6qmHQQJcg_003D_003D, IntPtr _0023_003DqYjAFLr5q7Bz0t49MJWrEcQ_003D_003D, int _0023_003Dq8T0lP1hjSG71ltlSxzmpJg_003D_003D, int _0023_003DqGj4Hxgg4oo2P90cpghdOsA_003D_003D);
}
