using System;
using System.Collections.Generic;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x02000097 RID: 151
	public interface ILineChartData<Tx, Ty> : global::NPOI.SS.UserModel.Charts.IChartData
	{
		// Token: 0x060005A0 RID: 1440
		global::NPOI.SS.UserModel.Charts.ILineChartSeries<Tx, Ty> AddSeries(global::NPOI.SS.UserModel.Charts.IChartDataSource<Tx> categories, global::NPOI.SS.UserModel.Charts.IChartDataSource<Ty> values);

		// Token: 0x060005A1 RID: 1441
		global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.ILineChartSeries<Tx, Ty>> GetSeries();
	}
}
