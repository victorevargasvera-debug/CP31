using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x02000092 RID: 146
	public interface IBarChartSeries<Tx, Ty> : global::NPOI.SS.UserModel.Charts.IChartSeries
	{
		// Token: 0x06000590 RID: 1424
		global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> GetCategoryAxisData();

		// Token: 0x06000591 RID: 1425
		global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> GetValues();
	}
}
