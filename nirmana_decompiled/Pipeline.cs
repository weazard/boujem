using System;
using System.Collections.Generic;
using System.Linq;

public sealed class Pipeline
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<Tool, int> _003C_003E9__0_0;

		public static Func<Tool, int> _003C_003E9__0_1;

		public static Func<KeyValuePair<Index2, Instruction>, int> _003C_003E9__0_2;

		public static Func<KeyValuePair<Index2, Instruction>, int> _003C_003E9__0_3;

		internal int _0023_003DqF22Wnl56SlkXucT_0024xUCx9lbDTrUehdeqGiSCs3TX3NY_003D(Tool _0023_003DqPFfnPqCIEV8jR6vQNXeNrQ_003D_003D)
		{
			return _0023_003DqPFfnPqCIEV8jR6vQNXeNrQ_003D_003D._0023_003DqJdg0UfZAJnReUiPhwy5sjw_003D_003D.X;
		}

		internal int _0023_003Dq3YLTNotYfzQ6b_TAp21wirC_rKRogB3vl2xQq4xO3mE_003D(Tool _0023_003DqTXfkc_qMbN2yjW4nwuWJJA_003D_003D)
		{
			return _0023_003DqTXfkc_qMbN2yjW4nwuWJJA_003D_003D._0023_003DqJdg0UfZAJnReUiPhwy5sjw_003D_003D.Y;
		}

		internal int _0023_003DqVylmXTXpnqQuNAEU_K2wX3eOD7u8CcQtN6TblqYnw_Q_003D(KeyValuePair<Index2, Instruction> _0023_003Dqyrb00TEk3zMVYr9mnK2SZA_003D_003D)
		{
			return _0023_003Dqyrb00TEk3zMVYr9mnK2SZA_003D_003D.Key.X;
		}

		internal int _0023_003DqQEnPrOt0keKyETCIQEDDDHe6fz4XNA3qaCiEGZiTtMw_003D(KeyValuePair<Index2, Instruction> _0023_003DqulUeWSqHgzrC65Mpc0Ey2g_003D_003D)
		{
			return _0023_003DqulUeWSqHgzrC65Mpc0Ey2g_003D_003D.Key.Y;
		}
	}

	public List<Tool> _0023_003Dqq75ZV0DsqzYmmiMFDYzCZg_003D_003D = new List<Tool>();

	public Dictionary<Index2, Instruction> _0023_003DqkxiH61qzGjel_0024fOaxem_0024hw_003D_003D = new Dictionary<Index2, Instruction>();

	public void _0023_003DqqIXd4WIOEc__0024BseXONL83w_003D_003D(_0023_003DqkLcwmaDVPwaP62_002404T2bdQ_003D_003D _0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D)
	{
		_0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D._0023_003DqHBgD8mvW_00246E4SEVsTJmbig_003D_003D(_0023_003Dqq75ZV0DsqzYmmiMFDYzCZg_003D_003D.Count());
		foreach (Tool item in _0023_003Dqq75ZV0DsqzYmmiMFDYzCZg_003D_003D.OrderBy((Tool _0023_003DqPFfnPqCIEV8jR6vQNXeNrQ_003D_003D) => _0023_003DqPFfnPqCIEV8jR6vQNXeNrQ_003D_003D._0023_003DqJdg0UfZAJnReUiPhwy5sjw_003D_003D.X).OrderBy(_003C_003Ec._003C_003E9._0023_003Dq3YLTNotYfzQ6b_TAp21wirC_rKRogB3vl2xQq4xO3mE_003D))
		{
			_0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D._0023_003DqHBgD8mvW_00246E4SEVsTJmbig_003D_003D(item._0023_003Dq7UFl5mW__0024iFoeF2Ez_1hjg_003D_003D._0023_003DqTTksYjEee69Pcr1D4U0bHQ_003D_003D);
			_0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D._0023_003DqBRjJ46OezyKk0HG9O3LPog_003D_003D(item._0023_003DqJdg0UfZAJnReUiPhwy5sjw_003D_003D);
			_0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D._0023_003DqHBgD8mvW_00246E4SEVsTJmbig_003D_003D(item._0023_003DqzafnVLYG13Ro_KlJ8yPYsQ_003D_003D.Length);
			for (int num = 0; num < item._0023_003DqzafnVLYG13Ro_KlJ8yPYsQ_003D_003D.Length; num++)
			{
				_0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D._0023_003DqBRjJ46OezyKk0HG9O3LPog_003D_003D(item._0023_003DqzafnVLYG13Ro_KlJ8yPYsQ_003D_003D[num]);
			}
		}
		_0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D._0023_003DqHBgD8mvW_00246E4SEVsTJmbig_003D_003D(_0023_003DqkxiH61qzGjel_0024fOaxem_0024hw_003D_003D.Count);
		foreach (KeyValuePair<Index2, Instruction> item2 in _0023_003DqkxiH61qzGjel_0024fOaxem_0024hw_003D_003D.OrderBy(_003C_003Ec._003C_003E9._0023_003DqVylmXTXpnqQuNAEU_K2wX3eOD7u8CcQtN6TblqYnw_Q_003D).OrderBy(_003C_003Ec._003C_003E9._0023_003DqQEnPrOt0keKyETCIQEDDDHe6fz4XNA3qaCiEGZiTtMw_003D))
		{
			Index2 key = item2.Key;
			Instruction value = item2.Value;
			_0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D._0023_003DqBRjJ46OezyKk0HG9O3LPog_003D_003D(key);
			_0023_003DqU3HpulQiW47WWWy2JQq0gw_003D_003D._0023_003DqHBgD8mvW_00246E4SEVsTJmbig_003D_003D((int)value);
		}
	}

	public static Pipeline _0023_003DqqQIIUbo_0024jkjlXWTo4hHDug_003D_003D(_0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D, int _0023_003DqZt6dr7LUgKpB8q0AKb5HDw_003D_003D)
	{
		Pipeline pipeline = new Pipeline();
		int num = _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003Dqiy5HqEKyG_oB_JRG5dQzVQ_003D_003D();
		for (int i = 0; i < num; i++)
		{
			ToolType _0023_003DqOMQf2xxyvQWmVt1oXrWj_w_003D_003D = ContentType<ToolType>._0023_003DqLBAInUtMewlY2gdoYmQPOA_003D_003D(_0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003Dqiy5HqEKyG_oB_JRG5dQzVQ_003D_003D())._0023_003DqvGiHfj9rWTdxWXVB0_SqYw_003D_003D();
			Index2 _0023_003Dqo070gzzC4nn8Ch6D_0024tKpiQ_003D_003D = _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003Dqu4wCYvM3PIpmdXgpg_Aiuw_003D_003D();
			Tool tool = new Tool(_0023_003DqOMQf2xxyvQWmVt1oXrWj_w_003D_003D, _0023_003Dqo070gzzC4nn8Ch6D_0024tKpiQ_003D_003D);
			pipeline._0023_003Dqq75ZV0DsqzYmmiMFDYzCZg_003D_003D.Add(tool);
			int num2 = _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003Dqiy5HqEKyG_oB_JRG5dQzVQ_003D_003D();
			for (int j = 0; j < num2; j++)
			{
				tool._0023_003DqzafnVLYG13Ro_KlJ8yPYsQ_003D_003D[j] = _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003Dqu4wCYvM3PIpmdXgpg_Aiuw_003D_003D();
			}
		}
		int num3 = _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003Dqiy5HqEKyG_oB_JRG5dQzVQ_003D_003D();
		for (int k = 0; k < num3; k++)
		{
			Index2 key = _0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003Dqu4wCYvM3PIpmdXgpg_Aiuw_003D_003D();
			Instruction value = (Instruction)_0023_003DqQRtxcXvfhPicQp9a3XSSNg_003D_003D._0023_003Dqiy5HqEKyG_oB_JRG5dQzVQ_003D_003D();
			pipeline._0023_003DqkxiH61qzGjel_0024fOaxem_0024hw_003D_003D[key] = value;
		}
		return pipeline;
	}

	public Pipeline _0023_003DqGDytyMJ68WKF3Ah9wRZn4w_003D_003D()
	{
		_0023_003DqkLcwmaDVPwaP62_002404T2bdQ_003D_003D _0023_003DqkLcwmaDVPwaP62_002404T2bdQ_003D_003D2 = new _0023_003DqkLcwmaDVPwaP62_002404T2bdQ_003D_003D();
		_0023_003DqqIXd4WIOEc__0024BseXONL83w_003D_003D(_0023_003DqkLcwmaDVPwaP62_002404T2bdQ_003D_003D2);
		return _0023_003DqqQIIUbo_0024jkjlXWTo4hHDug_003D_003D(new _0023_003DqV_H53aVrIv3D2hOL5xj0Ew_003D_003D(_0023_003DqkLcwmaDVPwaP62_002404T2bdQ_003D_003D2._0023_003DqRdjFcbDitE4cDiBqA6iYMg_003D_003D()), Solution._0023_003DqN1DlQMPFmWAWnjJsHEI6Q0EyyGxfpPhxiWzJKuG_0024HJ4_003D);
	}
}
