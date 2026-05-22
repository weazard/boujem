public struct Range(int start, int end)
{
	public readonly int Start = start;

	public readonly int End = end;

	public static readonly Range Empty = new Range(0, 0);

	public int Size => End - Start;

	public static Range WithSize(int start, int size)
	{
		return new Range(start, start + size);
	}

	public bool Contains(int index)
	{
		if (index >= Start)
		{
			return index < End;
		}
		return false;
	}

	public override string ToString()
	{
		return string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811436), Start, End);
	}
}
