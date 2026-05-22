public abstract class Screen
{
	public virtual bool IsFullscreen => true;

	public virtual void Update()
	{
	}

	public virtual void OnActivate(bool beingPushed)
	{
	}

	public virtual void OnReload()
	{
	}

	public virtual _0023_003DqdYpwVVsJZa4PgEtTtxWojg_003D_003D GetMusicState()
	{
		return new _0023_003DqdYpwVVsJZa4PgEtTtxWojg_003D_003D._0023_003Dq4pZY_0024YkhVAlk5hHR1Q5FMQ_003D_003D();
	}
}
