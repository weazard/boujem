using System.Linq;

public struct DrawConfig
{
	public Vector2 TexCoord1;

	public bool EnableDrawing;

	public bool EnableEvenCoordinateRounding;

	public _0023_003DqzCcvhCBfOUUdBqhSoZ7tZA_003D_003D Target;

	public Range2 ScissorRect;

	public _0023_003DqIbrUToI5cSTaDCNj5eVWrZ_0024QRhPoZEGWmBZyTWyzg4U_003D DepthStencilMode;

	public _0023_003DqnPB4hTuJE892ygKxfLR8fw_003D_003D Shader;

	public Matrix4 ProjectionMatrix;

	public Matrix4 ViewMatrix;

	public Matrix4 ModelMatrix;

	public Color ModelColor;

	public Bounds2 PerFrameBounds;

	public Texture[] Textures;

	public _0023_003DqQEGUea7pvsCvLoJkRoAtVQ_003D_003D[] Samplers;

	public DrawConfig Copy()
	{
		DrawConfig result = this;
		result.Textures = Textures.ToArray();
		result.Samplers = Samplers.ToArray();
		return result;
	}
}
