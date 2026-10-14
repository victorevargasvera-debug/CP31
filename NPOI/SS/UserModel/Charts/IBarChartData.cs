using System;
using System.Collections.Generic;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x02000091 RID: 145
	public interface IBarChartData<Tx, Ty> : global::NPOI.SS.UserModel.Charts.IChartData
	{
		// Token: 0x0600058E RID: 1422
		global::NPOI.SS.UserModel.Charts.IBarChartSeries<Tx, Ty> AddSeries(global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> categories, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> values);

		// Token: 0x0600058F RID: 1423
		global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IBarChartSeries<Tx, Ty>> GetSeries();
	}
}
