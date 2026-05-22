using System.Linq;

public sealed class Tool
{
	public ToolType _0023_003Dq7UFl5mW__0024iFoeF2Ez_1hjg_003D_003D;

	public Index2 _0023_003DqJdg0UfZAJnReUiPhwy5sjw_003D_003D;

	public Index2[] _0023_003DqzafnVLYG13Ro_KlJ8yPYsQ_003D_003D;

	public Tool(ToolType _0023_003DqOMQf2xxyvQWmVt1oXrWj_w_003D_003D, Index2 _0023_003Dqo070gzzC4nn8Ch6D_0024tKpiQ_003D_003D)
	{
		_0023_003Dq7UFl5mW__0024iFoeF2Ez_1hjg_003D_003D = _0023_003DqOMQf2xxyvQWmVt1oXrWj_w_003D_003D;
		_0023_003DqJdg0UfZAJnReUiPhwy5sjw_003D_003D = _0023_003Dqo070gzzC4nn8Ch6D_0024tKpiQ_003D_003D;
		_0023_003DqzafnVLYG13Ro_KlJ8yPYsQ_003D_003D = new Index2[_0023_003DqOMQf2xxyvQWmVt1oXrWj_w_003D_003D._0023_003Dq9aK36D1jI7y6_LwMvdWriQ_003D_003D.Length];
	}

	public Tool _0023_003DqXZJApLu0lQxFvhq4iHb6Qg_003D_003D()
	{
		return new Tool(_0023_003Dq7UFl5mW__0024iFoeF2Ez_1hjg_003D_003D, _0023_003DqJdg0UfZAJnReUiPhwy5sjw_003D_003D)
		{
			_0023_003DqzafnVLYG13Ro_KlJ8yPYsQ_003D_003D = _0023_003DqzafnVLYG13Ro_KlJ8yPYsQ_003D_003D.ToArray()
		};
	}
}
