using System;

public struct KerningPair(char first, char second) : IEquatable<KerningPair>, IComparable<KerningPair>
{
	public char First = first;

	public char Second = second;

	public override int GetHashCode()
	{
		return (391 + First.GetHashCode()) * 23 + Second.GetHashCode();
	}

	public int CompareTo(KerningPair other)
	{
		if (Second < other.Second)
		{
			return -1;
		}
		if (Second > other.Second)
		{
			return 1;
		}
		if (First < other.First)
		{
			return -1;
		}
		if (First > other.First)
		{
			return 1;
		}
		return 0;
	}

	public override bool Equals(object obj)
	{
		KerningPair? kerningPair = obj as KerningPair?;
		if (!kerningPair.HasValue)
		{
			return false;
		}
		KerningPair value = this;
		KerningPair? kerningPair2 = kerningPair;
		return value == kerningPair2;
	}

	public bool Equals(KerningPair other)
	{
		return this == other;
	}

	public static bool operator ==(KerningPair a, KerningPair b)
	{
		if (a.First == b.First)
		{
			return a.Second == b.Second;
		}
		return false;
	}

	public static bool operator !=(KerningPair a, KerningPair b)
	{
		return !(a == b);
	}
}
