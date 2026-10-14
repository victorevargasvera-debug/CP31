using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x0200009F RID: 159
	public interface IChartData
	{
		// Token: 0x060005C0 RID: 1472
		void FillChart(global::NPOI.SS.UserModel.IChart chart, params global::NPOI.SS.UserModel.Charts.IChartAxis[] axis);
	}
}
