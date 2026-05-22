using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct PackedColor(byte _0023_003Dqhctos9qNVLWbNZppKmdSRw_003D_003D, byte _0023_003Dqivk8yZhHwy_0024IvQG4mglfGA_003D_003D, byte _0023_003Dqan4RMAvGIfG16BRw8Ncbqg_003D_003D, byte _0023_003Dq7BY7mK3EwYfhzlNVffBUpQ_003D_003D)
{
	public byte _0023_003DqaqnnSVIelsm7bnO1TP6PEg_003D_003D = _0023_003Dqhctos9qNVLWbNZppKmdSRw_003D_003D;

	public byte _0023_003DqODfqoRaRhxsbNXetW8Bcsg_003D_003D = _0023_003Dqivk8yZhHwy_0024IvQG4mglfGA_003D_003D;

	public byte _0023_003DqXiOPaE8cTuzuWGDfkxKq9A_003D_003D = _0023_003Dqan4RMAvGIfG16BRw8Ncbqg_003D_003D;

	public byte _0023_003DqQrnUaZT5gT_002432Vk_xaxSMg_003D_003D = _0023_003Dq7BY7mK3EwYfhzlNVffBUpQ_003D_003D;

	public static readonly PackedColor _0023_003Dqv2LxBJ_0024oaWFLOxj3vBh1sg_003D_003D = new PackedColor(byte.MaxValue, byte.MaxValue, byte.MaxValue, byte.MaxValue);

	public static readonly PackedColor _0023_003DqG7MIZmjv7_5KlGk_0024XdAo9g_003D_003D = new PackedColor(0, 0, 0, byte.MaxValue);

	public static PackedColor _0023_003DqnpFn3XtFZqzBZtWn_4Q1Vg_003D_003D(int _0023_003DqNPGEKxCLes5pL2UHejIHBQ_003D_003D)
	{
		return new PackedColor((byte)(_0023_003DqNPGEKxCLes5pL2UHejIHBQ_003D_003D >> 16), (byte)(_0023_003DqNPGEKxCLes5pL2UHejIHBQ_003D_003D >> 8), (byte)_0023_003DqNPGEKxCLes5pL2UHejIHBQ_003D_003D, byte.MaxValue);
	}
}
