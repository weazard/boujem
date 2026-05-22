public struct TextDrawingOptions
{
	public string Text;

	public Vector2 Position;

	public _0023_003DqlLeUbetm_iM4DChW85P1zA_003D_003D Font;

	public Color Color;

	public _0023_003DqD5jDAPwcz7atocNECzXPWQ_003D_003D Alignment;

	public float LineSpacing;

	public float DoubleNewlineSpacing;

	public float WrapWidth;

	public float TruncateWidth;

	public Vector2 ShadowOffset;

	public Color ShadowColor;

	public int RenderCharCount;

	public Matrix4? Transform;

	public float AdditionalCharacterSpacingNormal;

	public float AdditionalCharacterSpacingWhitespace;

	public Color[] AlternateColors;

	public float HangingIndent;

	public bool EnableMeasuring;

	public bool EnableDrawing;

	public bool EnableSpeech;

	public bool IgnoreNewlinesForSpeech;

	public bool EnableEvenCoordinateRounding;

	public static TextDrawingOptions Default()
	{
		return new TextDrawingOptions
		{
			Alignment = (_0023_003DqD5jDAPwcz7atocNECzXPWQ_003D_003D)0,
			LineSpacing = 1f,
			DoubleNewlineSpacing = 0.6f,
			WrapWidth = float.MaxValue,
			TruncateWidth = float.MaxValue,
			ShadowOffset = Vector2.Zero,
			ShadowColor = default(Color),
			RenderCharCount = int.MaxValue,
			Transform = null,
			AlternateColors = null,
			EnableMeasuring = false,
			EnableDrawing = true,
			EnableSpeech = true,
			IgnoreNewlinesForSpeech = false,
			EnableEvenCoordinateRounding = false
		};
	}

	public TextDrawingOptions WithText(string text)
	{
		TextDrawingOptions result = this;
		result.Text = text;
		return result;
	}

	public TextDrawingOptions WithPosition(Vector2 position)
	{
		TextDrawingOptions result = this;
		result.Position = position;
		return result;
	}

	public TextDrawingOptions WithOffset(Vector2 offset)
	{
		TextDrawingOptions result = this;
		result.Position += offset;
		return result;
	}

	public TextDrawingOptions WithOffset(float x, float y)
	{
		TextDrawingOptions result = this;
		result.Position.X += x;
		result.Position.Y += y;
		return result;
	}

	public TextDrawingOptions WithFont(_0023_003DqlLeUbetm_iM4DChW85P1zA_003D_003D font)
	{
		TextDrawingOptions result = this;
		result.Font = font;
		return result;
	}

	public TextDrawingOptions WithColor(Color color)
	{
		TextDrawingOptions result = this;
		result.Color = color;
		return result;
	}

	public TextDrawingOptions WithAlignment(_0023_003DqD5jDAPwcz7atocNECzXPWQ_003D_003D alignment)
	{
		TextDrawingOptions result = this;
		result.Alignment = alignment;
		return result;
	}

	public TextDrawingOptions AlignedLeft()
	{
		TextDrawingOptions result = this;
		result.Alignment = (_0023_003DqD5jDAPwcz7atocNECzXPWQ_003D_003D)0;
		return result;
	}

	public TextDrawingOptions AlignedCenter()
	{
		TextDrawingOptions result = this;
		result.Alignment = (_0023_003DqD5jDAPwcz7atocNECzXPWQ_003D_003D)1;
		return result;
	}

	public TextDrawingOptions AlignedRight()
	{
		TextDrawingOptions result = this;
		result.Alignment = (_0023_003DqD5jDAPwcz7atocNECzXPWQ_003D_003D)2;
		return result;
	}

	public TextDrawingOptions WithLineSpacing(float spacing)
	{
		TextDrawingOptions result = this;
		result.LineSpacing = spacing;
		return result;
	}

	public TextDrawingOptions WithDoubleNewlineSpacing(float spacing)
	{
		TextDrawingOptions result = this;
		result.DoubleNewlineSpacing = spacing;
		return result;
	}

	public TextDrawingOptions WithWrapWidth(float width)
	{
		TextDrawingOptions result = this;
		result.WrapWidth = width;
		return result;
	}

	public TextDrawingOptions WithTruncateWidth(float width)
	{
		TextDrawingOptions result = this;
		result.TruncateWidth = width;
		return result;
	}

	public TextDrawingOptions WithShadow(Vector2 offset, Color color)
	{
		TextDrawingOptions result = this;
		result.ShadowOffset = offset;
		result.ShadowColor = color;
		return result;
	}

	public TextDrawingOptions WithRenderCharCount(int count)
	{
		TextDrawingOptions result = this;
		result.RenderCharCount = count;
		return result;
	}

	public TextDrawingOptions WithTransform(Matrix4? transform)
	{
		TextDrawingOptions result = this;
		result.Transform = transform;
		return result;
	}

	public TextDrawingOptions WithAdditionalCharacterSpacing(float spacing)
	{
		TextDrawingOptions result = this;
		result.AdditionalCharacterSpacingNormal = spacing;
		result.AdditionalCharacterSpacingWhitespace = spacing;
		return result;
	}

	public TextDrawingOptions WithAdditionalCharacterSpacing(float normalSpacing, float whitespaceSpacing)
	{
		TextDrawingOptions result = this;
		result.AdditionalCharacterSpacingNormal = normalSpacing;
		result.AdditionalCharacterSpacingWhitespace = whitespaceSpacing;
		return result;
	}

	public TextDrawingOptions WithAlternateColors(Color[] colors)
	{
		TextDrawingOptions result = this;
		result.AlternateColors = colors;
		return result;
	}

	public TextDrawingOptions WithSpeechDisabled()
	{
		TextDrawingOptions result = this;
		result.EnableSpeech = false;
		return result;
	}

	public TextDrawingOptions WithNewlinesIgnoredForSpeech()
	{
		TextDrawingOptions result = this;
		result.IgnoreNewlinesForSpeech = true;
		return result;
	}

	public TextDrawingOptions WithEvenCoordinateRounding()
	{
		TextDrawingOptions result = this;
		result.EnableEvenCoordinateRounding = true;
		return result;
	}

	public TextDrawingOptions AlignedCenterVertically()
	{
		TextDrawingOptions result = this;
		Bounds2 bounds = Measure();
		float num = Position.Y - bounds.Center.Y;
		result.Position.Y += num;
		return result;
	}

	public TextDrawingOptions WithHangingIndent(float indent)
	{
		TextDrawingOptions result = this;
		result.HangingIndent = indent;
		return result;
	}

	public Bounds2 Measure()
	{
		EnableMeasuring = true;
		EnableDrawing = false;
		return G._0023_003DqzUSXuzpmleZkReClomdYgkDdwMBziMcbZaliC2ZXPKM_003D(this);
	}

	public void Draw()
	{
		EnableMeasuring = false;
		EnableDrawing = true;
		G._0023_003DqzUSXuzpmleZkReClomdYgkDdwMBziMcbZaliC2ZXPKM_003D(this);
	}

	public Bounds2 DrawAndMeasure()
	{
		EnableMeasuring = true;
		EnableDrawing = true;
		return G._0023_003DqzUSXuzpmleZkReClomdYgkDdwMBziMcbZaliC2ZXPKM_003D(this);
	}
}
