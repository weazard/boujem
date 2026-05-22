using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public static class _0023_003DqpuDyZrTvgwOuSz7PLXTv7PGB7LMzVWfNMAj27V7eOOg_003D
{
	private struct _0023_003DqtSx9S01rIM23sHBrVxKzZg_003D_003D
	{
		public ulong _0023_003Dqh_00249OqlBkD_1R5QTOL974Eg_003D_003D;

		public int _0023_003Dq4izmgUPKiLINVhX8DwpHNw_003D_003D;
	}

	private static long _0023_003DqkJ_0024nLphsJDj7EJ0sb5Hj2Q_003D_003D = 0L;

	private static List<_0023_003DqtSx9S01rIM23sHBrVxKzZg_003D_003D> _0023_003DqY3SF0WBRCBOXnWI4dQx3YA_003D_003D = new List<_0023_003DqtSx9S01rIM23sHBrVxKzZg_003D_003D>(1048576);

	private static bool _0023_003DqafZ6GNQduvh0bGq0pPt80Mw_CUHd7V5uvGuKKi9lL4c_003D = false;

	private static string _0023_003DqL1JqpkeyzATaoNu_tOyoQw_003D_003D;

	public static List<string> _0023_003Dq4jkId2boWbFlbLNk6FP2eA_003D_003D = new List<string>();

	private static Dictionary<string, int> _0023_003Dq9VKfOIGC9WLpzFjEzo5efw_003D_003D = new Dictionary<string, int>();

	public static _0023_003DqRi31WlRlfPvMv_wQy0br9nxFQ_iitTcpY8yJB71RZaM_003D _0023_003DqNkdkXvr8zN99PwvDVuRpBnqfIDkoA4VuQo9jRNLzpqg_003D(string _0023_003DqcUT6ux346MIDZPJywVI4xQ_003D_003D)
	{
		if (!_0023_003Dq9VKfOIGC9WLpzFjEzo5efw_003D_003D.TryGetValue(_0023_003DqcUT6ux346MIDZPJywVI4xQ_003D_003D, out var value))
		{
			value = (_0023_003Dq4jkId2boWbFlbLNk6FP2eA_003D_003D.Count + 1) * 2;
			_0023_003Dq4jkId2boWbFlbLNk6FP2eA_003D_003D.Add(_0023_003DqcUT6ux346MIDZPJywVI4xQ_003D_003D);
			_0023_003Dq9VKfOIGC9WLpzFjEzo5efw_003D_003D.Add(_0023_003DqcUT6ux346MIDZPJywVI4xQ_003D_003D, value);
		}
		return new _0023_003DqRi31WlRlfPvMv_wQy0br9nxFQ_iitTcpY8yJB71RZaM_003D
		{
			_0023_003Dq6K3UxSHFdECLkPchutus1Q_003D_003D = value
		};
	}

	public static void _0023_003DqVY9y6DgFH7bjFHDf8yxG1w_003D_003D(_0023_003DqRi31WlRlfPvMv_wQy0br9nxFQ_iitTcpY8yJB71RZaM_003D _0023_003DqAA_E_0024wlDbsa5q5Yj6U4c0w_003D_003D)
	{
		_0023_003DqwsCZ6pxlgsfVYvG6LLFdfQ_003D_003D(_0023_003DqAA_E_0024wlDbsa5q5Yj6U4c0w_003D_003D._0023_003Dq6K3UxSHFdECLkPchutus1Q_003D_003D);
	}

	public static void _0023_003Dq1RHtzBWC0gt9zaan5Wr8TQ_003D_003D(_0023_003DqRi31WlRlfPvMv_wQy0br9nxFQ_iitTcpY8yJB71RZaM_003D _0023_003Dqm_d3_0024n9xPZ8CoqH4Kr09Aw_003D_003D)
	{
		_0023_003DqwsCZ6pxlgsfVYvG6LLFdfQ_003D_003D(_0023_003Dqm_d3_0024n9xPZ8CoqH4Kr09Aw_003D_003D._0023_003Dq6K3UxSHFdECLkPchutus1Q_003D_003D + 1);
	}

	public static void _0023_003DqwsCZ6pxlgsfVYvG6LLFdfQ_003D_003D(int _0023_003DqsKkz66puC7MXfFLJ9mX03w_003D_003D)
	{
		if (_0023_003Dqjtd0RhaH_eDUMwKnGl0SnA_003D_003D._0023_003DqnIzqlc23BInBv8GSc_0024MYPQD_0024tvzYZTjVwKK7JCt_77Y_003D)
		{
			_0023_003DqY3SF0WBRCBOXnWI4dQx3YA_003D_003D.Add(new _0023_003DqtSx9S01rIM23sHBrVxKzZg_003D_003D
			{
				_0023_003Dqh_00249OqlBkD_1R5QTOL974Eg_003D_003D = _0023_003DqF_pGiuEvCUcNZRgFq9dXSg_003D_003D(),
				_0023_003Dq4izmgUPKiLINVhX8DwpHNw_003D_003D = _0023_003DqsKkz66puC7MXfFLJ9mX03w_003D_003D
			});
		}
	}

	public static void _0023_003DqgKrDjZ0sMeobC2pON_00242Yjg_003D_003D(string _0023_003Dqkr_pIbLu7lWNXitVrtU_Yw_003D_003D)
	{
		if (_0023_003DqkJ_0024nLphsJDj7EJ0sb5Hj2Q_003D_003D > 0)
		{
			_0023_003DqafZ6GNQduvh0bGq0pPt80Mw_CUHd7V5uvGuKKi9lL4c_003D = true;
			_0023_003DqL1JqpkeyzATaoNu_tOyoQw_003D_003D = _0023_003Dqkr_pIbLu7lWNXitVrtU_Yw_003D_003D;
		}
	}

	public static void _0023_003DqvvIHuGjuoV7OZ7aDvGSIpA_003D_003D()
	{
		if (_0023_003DqafZ6GNQduvh0bGq0pPt80Mw_CUHd7V5uvGuKKi9lL4c_003D && _0023_003DqY3SF0WBRCBOXnWI4dQx3YA_003D_003D.Count > 0)
		{
			Directory.CreateDirectory(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065758280));
			FileStream fileStream = new FileStream(string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065758299), _0023_003DqkJ_0024nLphsJDj7EJ0sb5Hj2Q_003D_003D, _0023_003DqL1JqpkeyzATaoNu_tOyoQw_003D_003D), FileMode.Create);
			try
			{
				BinaryWriter binaryWriter = new BinaryWriter(fileStream, Encoding.ASCII);
				try
				{
					binaryWriter.Write(_0023_003Dq4jkId2boWbFlbLNk6FP2eA_003D_003D.Count);
					foreach (string item in _0023_003Dq4jkId2boWbFlbLNk6FP2eA_003D_003D)
					{
						binaryWriter.Write(item);
					}
					binaryWriter.Write(_0023_003DqY3SF0WBRCBOXnWI4dQx3YA_003D_003D.Count);
					foreach (_0023_003DqtSx9S01rIM23sHBrVxKzZg_003D_003D item2 in _0023_003DqY3SF0WBRCBOXnWI4dQx3YA_003D_003D)
					{
						binaryWriter.Write(item2._0023_003Dqh_00249OqlBkD_1R5QTOL974Eg_003D_003D);
						binaryWriter.Write(item2._0023_003Dq4izmgUPKiLINVhX8DwpHNw_003D_003D);
					}
				}
				finally
				{
					((IDisposable)binaryWriter).Dispose();
				}
			}
			finally
			{
				((IDisposable)fileStream).Dispose();
			}
		}
		_0023_003DqkJ_0024nLphsJDj7EJ0sb5Hj2Q_003D_003D++;
		_0023_003DqY3SF0WBRCBOXnWI4dQx3YA_003D_003D.Clear();
		_0023_003DqafZ6GNQduvh0bGq0pPt80Mw_CUHd7V5uvGuKKi9lL4c_003D = false;
	}

	[DllImport("Renderer_D3D11", CallingConvention = CallingConvention.Cdecl, EntryPoint = "RDTSCP")]
	public static extern ulong _0023_003DqF_pGiuEvCUcNZRgFq9dXSg_003D_003D();
}
