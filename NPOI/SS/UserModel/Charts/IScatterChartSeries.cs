using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x020000A8 RID: 168
	public interface IScatterChartSeries<Tx, Ty> : global::NPOI.SS.UserModel.Charts.IChartSeries
	{
		// Token: 0x060005DD RID: 1501
		global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> GetXValues();

		// Token: 0x060005DE RID: 1502
		global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> GetYValues();
	}
}
