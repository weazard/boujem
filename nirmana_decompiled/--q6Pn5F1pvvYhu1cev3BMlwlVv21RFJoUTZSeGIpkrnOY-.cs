using System.Collections.Generic;
using System.Linq;

public sealed class _0023_003Dq6Pn5F1pvvYhu1cev3BMlwlVv21RFJoUTZSeGIpkrnOY_003D<_0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D>
{
	private SortedDictionary<int, Queue<_0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D>> _0023_003Dqbc2AUGg6ehhz1ncyQIYmrQ_003D_003D = new SortedDictionary<int, Queue<_0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D>>();

	public bool _0023_003Dq1B2tEa_0024VTf6PvSfuwwbhpw_003D_003D()
	{
		return _0023_003Dqbc2AUGg6ehhz1ncyQIYmrQ_003D_003D.Count == 0;
	}

	public void _0023_003DqHgmu4WNOsUx3DZ_00242SMYZxg_003D_003D(int _0023_003DqhSMdDhJuw9evaxjcmp014w_003D_003D, _0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D _0023_003DqwdDouSJt_nNOE96QZeFkOg_003D_003D)
	{
		if (!_0023_003Dqbc2AUGg6ehhz1ncyQIYmrQ_003D_003D.TryGetValue(_0023_003DqhSMdDhJuw9evaxjcmp014w_003D_003D, out var value))
		{
			value = new Queue<_0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D>();
			_0023_003Dqbc2AUGg6ehhz1ncyQIYmrQ_003D_003D.Add(_0023_003DqhSMdDhJuw9evaxjcmp014w_003D_003D, value);
		}
		value.Enqueue(_0023_003DqwdDouSJt_nNOE96QZeFkOg_003D_003D);
	}

	public _0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D _0023_003DqNtmYN7cVnH_laC8qHQtveQ_003D_003D()
	{
		return _0023_003Dqbc2AUGg6ehhz1ncyQIYmrQ_003D_003D.First().Value.Peek();
	}

	public _0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D _0023_003DqqA5fXraT_0024Y_0024ZRoDNbXaWMQ_003D_003D()
	{
		KeyValuePair<int, Queue<_0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D>> keyValuePair = _0023_003Dqbc2AUGg6ehhz1ncyQIYmrQ_003D_003D.First();
		Queue<_0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D> value = keyValuePair.Value;
		_0023_003DqrNOpsSkrHbXkGq0KTi2G6g_003D_003D result = value.Dequeue();
		if (value.Count == 0)
		{
			int key = keyValuePair.Key;
			_0023_003Dqbc2AUGg6ehhz1ncyQIYmrQ_003D_003D.Remove(key);
		}
		return result;
	}
}
