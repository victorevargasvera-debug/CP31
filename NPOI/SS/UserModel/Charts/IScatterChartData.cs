using System;
using System.Collections.Generic;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x020000A7 RID: 167
	public interface IScatterChartData<Tx, Ty> : global::NPOI.SS.UserModel.Charts.IChartData
	{
		// Token: 0x060005DB RID: 1499
		global::NPOI.SS.UserModel.Charts.IScatterChartSeries<Tx, Ty> AddSeries(global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> xs, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> ys);

		// Token: 0x060005DC RID: 1500
		global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IScatterChartSeries<Tx, Ty>> GetSeries();
	}
}
