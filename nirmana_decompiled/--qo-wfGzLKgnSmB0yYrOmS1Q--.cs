using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;

public sealed class _0023_003Dqo_0024wfGzLKgnSmB0yYrOmS1Q_003D_003D
{
	private static readonly string _0023_003Dqgy4EDie1v2zdJMq_0024sZJqmw_003D_003D = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065776133);

	public static void _0023_003DqsyeHuN_0024sQ740dRsDWW1iPg_003D_003D()
	{
		AppDomain.CurrentDomain.UnhandledException += _0023_003DqT6M0CN4vO_Ph6klMas7dFw_003D_003D;
	}

	private static void _0023_003DqT6M0CN4vO_Ph6klMas7dFw_003D_003D(object _0023_003DqCASbL_6J9bxuB0nYAnxI6g_003D_003D, UnhandledExceptionEventArgs _0023_003DqrP0QJs1Msmea3la2HDwXVg_003D_003D)
	{
		Exception ex = (Exception)_0023_003DqrP0QJs1Msmea3la2HDwXVg_003D_003D.ExceptionObject;
		string arg = _0023_003DqDIvcxIKqabL8WqQo3Ea05Q_003D_003D._0023_003DqG2dtugKEqTCyJ3P0za6YCvTAIcY_0024aWnrnBkXNLdUDjU_003D().ToString();
		Process.Start(string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065762104), _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003Dq9F544pPbkLIt_PKF7XYPbBchx1xq40aJ1vdcRJ_vskc_003D(_0023_003DqxfHWivu4AcveXMF67xyhGA_003D_003D: true), arg, Uri.EscapeDataString(ex.Message)));
		string text = GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003Dq_0024PEI_0024xPvHGa6a30JkuY_ojo28qgqBS3hYMFgx5Z9bps_003D.Trim() + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065762157) + GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003Dqr_R_kaNL5KYETxBrxMTZ3bcvMwGywHabvkJ7f3GdEwU_003D.Trim();
		string text2 = string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065762146), DateTime.Now);
		string path = Path.Combine(GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqBtBzdF9aBIy2anWoRXn4Mg_003D_003D, _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065762179), text2 + _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065762199));
		Directory.CreateDirectory(Path.GetDirectoryName(path));
		string text3 = string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065762220), new object[4]
		{
			_0023_003Dqjtd0RhaH_eDUMwKnGl0SnA_003D_003D._0023_003DqROBmFThNv_0024YXNgPeSS3BNA_003D_003D,
			ex.Message,
			ex.StackTrace,
			text
		});
		File.WriteAllText(path, text3);
		string text4 = Path.ChangeExtension(Path.GetTempFileName(), _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065762279));
		ZipFile.CreateFromDirectory(GameLogic._0023_003DqG7TFSM3ZjeboSgKnWHLPxw_003D_003D._0023_003DqBtBzdF9aBIy2anWoRXn4Mg_003D_003D, text4);
		string value = Convert.ToBase64String(File.ReadAllBytes(text4));
		File.Delete(text4);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(value);
		stringBuilder.Append('|');
		stringBuilder.Append(text3);
		byte[] bytes = Encoding.ASCII.GetBytes(stringBuilder.ToString());
		WebRequest webRequest = WebRequest.Create(string.Format(_0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065762297), _0023_003DqaMyRIiIVSoY8bVD5lt24uw_003D_003D._0023_003Dq9F544pPbkLIt_PKF7XYPbBchx1xq40aJ1vdcRJ_vskc_003D(_0023_003DqxfHWivu4AcveXMF67xyhGA_003D_003D: false), arg, _0023_003Dqjtd0RhaH_eDUMwKnGl0SnA_003D_003D._0023_003DqrcFyDgnrvb0dNoJ1UZ6njw_003D_003D));
		webRequest.Method = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065761298);
		webRequest.ContentType = _0023_003DqOkrtFb7xSDb86gponsEwJKLmlLeT4qfj2cAFGxN_0024WeA_003D._0023_003DqjAGAP8XErb771WPPaGoLlA_003D_003D(-2065761323);
		webRequest.ContentLength = bytes.Length;
		using (Stream stream = webRequest.GetRequestStream())
		{
			stream.Write(bytes, 0, bytes.Length);
		}
		webRequest.GetResponse();
		Environment.Exit(1);
	}
}
