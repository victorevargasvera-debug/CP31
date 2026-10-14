using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x02000098 RID: 152
	public interface ILineChartSeries<Tx, Ty> : global::NPOI.SS.UserModel.Charts.IChartSeries
	{
		// Token: 0x060005A2 RID: 1442
		global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> GetCategoryAxisData();

		// Token: 0x060005A3 RID: 1443
		global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> GetValues();
	}
}
