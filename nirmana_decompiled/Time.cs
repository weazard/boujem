using SDL2;

public struct Time(ulong ticks)
{
	public readonly ulong Ticks = ticks;

	public static readonly Time MinValue = new Time(0uL);

	public static Time Now()
	{
		return new Time(SDL.SDL_GetPerformanceCounter());
	}

	public static float GetLoopingCounter(_0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D period)
	{
		return GetLoopingCounterSince(MinValue, period);
	}

	public static float GetLoopingCounterSince(Time start, _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D period)
	{
		return (float)((Now() - start)._0023_003DqYoqYkqTcMsKdDfvSpTgCHg_003D_003D % period._0023_003DqYoqYkqTcMsKdDfvSpTgCHg_003D_003D) / (float)period._0023_003DqYoqYkqTcMsKdDfvSpTgCHg_003D_003D;
	}

	public static Time operator +(Time time, _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D delta)
	{
		return new Time(time.Ticks + delta._0023_003DqYoqYkqTcMsKdDfvSpTgCHg_003D_003D);
	}

	public static Time operator -(Time time, _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D delta)
	{
		return new Time(time.Ticks - delta._0023_003DqYoqYkqTcMsKdDfvSpTgCHg_003D_003D);
	}

	public static _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D operator -(Time a, Time b)
	{
		return new _0023_003Dq9HVm_3_0024HzM8_0024nfFnjwOGCw_003D_003D(a.Ticks - b.Ticks);
	}

	public static bool operator <(Time a, Time b)
	{
		return a.Ticks < b.Ticks;
	}

	public static bool operator >(Time a, Time b)
	{
		return a.Ticks > b.Ticks;
	}
}
