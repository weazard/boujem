using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public sealed class RobustFileWriter
{
	private sealed class _0023_003Dqmjia69CA_j_0024Pd1hrUKUTcHddUlbz_00247V_0024Bz7fv4qkXro_003D
	{
		public string _0023_003DqOUAeIVq4V2w_dDc7GWZ3Tw_003D_003D;

		internal bool _0023_003DqCcqva5hnqe7sMM43G9JH6ViOihzzDJ0rH3N_0024cs1uFrU_003D(PendingFileWrite _0023_003Dq5pvDE2GMDZtAoGWKtMuGcg_003D_003D)
		{
			return _0023_003Dq5pvDE2GMDZtAoGWKtMuGcg_003D_003D._0023_003DqV4my3hIcQX1rUsuGO2D0UA_003D_003D == _0023_003DqOUAeIVq4V2w_dDc7GWZ3Tw_003D_003D;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Predicate<PendingFileWrite> _003C_003E9__8_0;

		internal bool _0023_003DqqocQ1zd82usVj47xOYHuDA_003D_003D(PendingFileWrite _0023_003DqBoHfuZRNsehcBdVar_xsFA_003D_003D)
		{
			return _0023_003DqBoHfuZRNsehcBdVar_xsFA_003D_003D._0023_003DqQNUYKu8mwSngopTcVxPfxw_003D_003D;
		}
	}

	private sealed class PendingFileWrite
	{
		public readonly string _0023_003DqV4my3hIcQX1rUsuGO2D0UA_003D_003D;

		public readonly byte[] _0023_003DqQtSwMTB8TQ8eW56lPf8_0024Aw_003D_003D;

		public bool _0023_003DqQNUYKu8mwSngopTcVxPfxw_003D_003D;

		public int _0023_003DqAefRdtmqOc5Ef9NSa0KIxA_003D_003D;

		public PendingFileWrite(string _0023_003DqRlgWErw_0024_0024KMnDUx_0024cALZkg_003D_003D, byte[] _0023_003DqUiysrurmjVYC3wvdF5qr9g_003D_003D)
		{
			_0023_003DqV4my3hIcQX1rUsuGO2D0UA_003D_003D = _0023_003DqRlgWErw_0024_0024KMnDUx_0024cALZkg_003D_003D;
			_0023_003DqQtSwMTB8TQ8eW56lPf8_0024Aw_003D_003D = _0023_003DqUiysrurmjVYC3wvdF5qr9g_003D_003D;
		}
	}

	private static readonly int _0023_003DqxPx6URr9nLc34X8VCpyOxA_003D_003D = 20;

	private static readonly TimeSpan _0023_003DqOGcphxk0sGpX0_00246gppYb_9Q_0024_0024jDX_0024o4qHSxYj05_HiY_003D = TimeSpan.FromSeconds(1.0);

	private DateTime _0023_003DqE_0024jStyBi_8_gC4yt83enaw_003D_003D = DateTime.MinValue;

	private List<PendingFileWrite> _0023_003Dq5IPOUAhVKShjIHpFD0muDg_003D_003D = new List<PendingFileWrite>();

	public void _0023_003Dq6lZmlE6NL1nP4btyBZuYXA_003D_003D(string _0023_003DqDR_f9eB9t3vusfBgpEnoZg_003D_003D, byte[] _0023_003Dqg9qikBDI_Xzrs4TZAanGFQ_003D_003D)
	{
		_0023_003Dqmjia69CA_j_0024Pd1hrUKUTcHddUlbz_00247V_0024Bz7fv4qkXro_003D CS_0024_003C_003E8__locals3 = new _0023_003Dqmjia69CA_j_0024Pd1hrUKUTcHddUlbz_00247V_0024Bz7fv4qkXro_003D();
		CS_0024_003C_003E8__locals3._0023_003DqOUAeIVq4V2w_dDc7GWZ3Tw_003D_003D = _0023_003DqDR_f9eB9t3vusfBgpEnoZg_003D_003D;
		_0023_003Dq5IPOUAhVKShjIHpFD0muDg_003D_003D.RemoveAll((PendingFileWrite _0023_003Dq5pvDE2GMDZtAoGWKtMuGcg_003D_003D) => _0023_003Dq5pvDE2GMDZtAoGWKtMuGcg_003D_003D._0023_003DqV4my3hIcQX1rUsuGO2D0UA_003D_003D == CS_0024_003C_003E8__locals3._0023_003DqOUAeIVq4V2w_dDc7GWZ3Tw_003D_003D);
		_0023_003Dq5IPOUAhVKShjIHpFD0muDg_003D_003D.Add(new PendingFileWrite(CS_0024_003C_003E8__locals3._0023_003DqOUAeIVq4V2w_dDc7GWZ3Tw_003D_003D, _0023_003Dqg9qikBDI_Xzrs4TZAanGFQ_003D_003D));
		_0023_003DqQn5jG8zi0dVVSgZwjKRCVE56fRz_0024RYy2mx9DrvCo_0024Yw_003D();
	}

	public void _0023_003Dq3uRGRcZ2bz0G8NEcMFlRlQ_003D_003D(string _0023_003DqMOQ_0024SmoXLGSiSvKWaU8mmw_003D_003D, string _0023_003DqSFy7zfTyA2Oxllipeaw9yA_003D_003D)
	{
		_0023_003Dq6lZmlE6NL1nP4btyBZuYXA_003D_003D(_0023_003DqMOQ_0024SmoXLGSiSvKWaU8mmw_003D_003D, Encoding.ASCII.GetBytes(_0023_003DqSFy7zfTyA2Oxllipeaw9yA_003D_003D));
	}

	public void _0023_003DqQn5jG8zi0dVVSgZwjKRCVE56fRz_0024RYy2mx9DrvCo_0024Yw_003D()
	{
		TimeSpan timeSpan = DateTime.Now - _0023_003DqE_0024jStyBi_8_gC4yt83enaw_003D_003D;
		if (_0023_003Dq5IPOUAhVKShjIHpFD0muDg_003D_003D.Count > 0 && timeSpan >= _0023_003DqOGcphxk0sGpX0_00246gppYb_9Q_0024_0024jDX_0024o4qHSxYj05_HiY_003D)
		{
			_0023_003DqQFgwT0ZZ8XHlEPqSdoh6gQ_003D_003D();
			_0023_003DqE_0024jStyBi_8_gC4yt83enaw_003D_003D = DateTime.Now;
		}
	}

	public void _0023_003DqbG_00247ya1pkd_0024lp2U9r5PZ7bfHc1NcY_iX7AD6AlvuYy0_003D()
	{
		while (_0023_003Dq5IPOUAhVKShjIHpFD0muDg_003D_003D.Count > 0)
		{
			_0023_003DqQFgwT0ZZ8XHlEPqSdoh6gQ_003D_003D();
		}
	}

	private void _0023_003DqQFgwT0ZZ8XHlEPqSdoh6gQ_003D_003D()
	{
		foreach (PendingFileWrite item in _0023_003Dq5IPOUAhVKShjIHpFD0muDg_003D_003D)
		{
			try
			{
				File.WriteAllBytes(item._0023_003DqV4my3hIcQX1rUsuGO2D0UA_003D_003D, item._0023_003DqQtSwMTB8TQ8eW56lPf8_0024Aw_003D_003D);
				item._0023_003DqQNUYKu8mwSngopTcVxPfxw_003D_003D = true;
			}
			catch (Exception _0023_003DqGPiOAGbkgpy7v3uOkZ3gSg_003D_003D)
			{
				item._0023_003DqAefRdtmqOc5Ef9NSa0KIxA_003D_003D++;
				if (!_0023_003DqiKvo7oDElGgmjCtY5yaOHQJ4ZbEbAJN0_0024rKS9wOzqls_003D(_0023_003DqGPiOAGbkgpy7v3uOkZ3gSg_003D_003D) || item._0023_003DqAefRdtmqOc5Ef9NSa0KIxA_003D_003D >= _0023_003DqxPx6URr9nLc34X8VCpyOxA_003D_003D)
				{
					throw;
				}
			}
		}
		_0023_003Dq5IPOUAhVKShjIHpFD0muDg_003D_003D.RemoveAll(_003C_003Ec._003C_003E9._0023_003DqqocQ1zd82usVj47xOYHuDA_003D_003D);
	}

	private bool _0023_003DqiKvo7oDElGgmjCtY5yaOHQJ4ZbEbAJN0_0024rKS9wOzqls_003D(Exception _0023_003DqGPiOAGbkgpy7v3uOkZ3gSg_003D_003D)
	{
		if (!(_0023_003DqGPiOAGbkgpy7v3uOkZ3gSg_003D_003D is IOException) || _0023_003DqGPiOAGbkgpy7v3uOkZ3gSg_003D_003D is DirectoryNotFoundException)
		{
			return _0023_003DqGPiOAGbkgpy7v3uOkZ3gSg_003D_003D is UnauthorizedAccessException;
		}
		return true;
	}
}
