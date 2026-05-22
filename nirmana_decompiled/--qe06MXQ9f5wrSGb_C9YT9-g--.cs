using System.Linq;
using System.Threading;

public sealed class _0023_003Dqe06MXQ9f5wrSGb_C9YT9_0024g_003D_003D
{
	private static readonly Mutex _0023_003DqCPU6cfb6vU5W3ZdLIjfaEaGwOO_V_ADyAGaSMm_0024ErSg_003D = new Mutex(initiallyOwned: true, _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808664));

	private static void _0023_003Dq2OZg_I4m1po8dBIQCYU1AQ_003D_003D(string[] _0023_003DqTqs0EP2peXlvYWPIJ0aRdA_003D_003D)
	{
		if (_0023_003DqTqs0EP2peXlvYWPIJ0aRdA_003D_003D.Contains(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808708)))
		{
			throw new _0023_003Dq_0024S5dJUVgVPAqf6W5JmXPAg_003D_003D(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065808728));
		}
		if (!_0023_003DqCPU6cfb6vU5W3ZdLIjfaEaGwOO_V_ADyAGaSMm_0024ErSg_003D.WaitOne(0, exitContext: true))
		{
			return;
		}
		GameLogic gameLogic = new GameLogic();
		gameLogic._0023_003DqZORM08SiS4WmJMNN_0024s5avQ_003D_003D();
		while (true)
		{
			gameLogic._0023_003DqUPnb2DUlNkzAB_0024HZ7dkzQw_003D_003D();
		}
	}
}
