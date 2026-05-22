using System;
using System.Collections.Generic;

public sealed class _0023_003Dq77vASlEWZlku8lIZHr1DD5pDWBdwhyMxlhQSvcsZqts_003D<_0023_003Dqset7AeMGd_oEkTizTCgjRA_003D_003D>
{
	public readonly List<_0023_003Dqset7AeMGd_oEkTizTCgjRA_003D_003D> _0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D = new List<_0023_003Dqset7AeMGd_oEkTizTCgjRA_003D_003D>();

	public int _0023_003DqKINyCIApI08Sqxav12JsVg_003D_003D()
	{
		return _0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D.Count;
	}

	public void _0023_003DqlN6jFNPqrDxJpOHC9UjWkw_003D_003D(_0023_003Dqset7AeMGd_oEkTizTCgjRA_003D_003D _0023_003DqWJOjzWtOLtH7V8YpIMWsEg_003D_003D)
	{
		_0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D.Add(_0023_003DqWJOjzWtOLtH7V8YpIMWsEg_003D_003D);
	}

	public _0023_003Dqset7AeMGd_oEkTizTCgjRA_003D_003D _0023_003DqMToNKEf40OFoqoVv1Zag6w_003D_003D()
	{
		if (_0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D.Count == 0)
		{
			throw new InvalidOperationException(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811421));
		}
		int index = _0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D.Count - 1;
		_0023_003Dqset7AeMGd_oEkTizTCgjRA_003D_003D result = _0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D[index];
		_0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D.RemoveAt(index);
		return result;
	}

	public _0023_003Dqset7AeMGd_oEkTizTCgjRA_003D_003D _0023_003DqivmN7tooCRVeNlmMD_b36A_003D_003D()
	{
		if (_0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D.Count == 0)
		{
			throw new InvalidOperationException(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065811421));
		}
		return _0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D[_0023_003DqdvK99_0024oFUhqmdd_tM_0024NpRQ_003D_003D.Count - 1];
	}
}
