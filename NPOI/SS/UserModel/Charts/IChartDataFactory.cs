using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x020000A0 RID: 160
	public interface IChartDataFactory
	{
		// Token: 0x060005C1 RID: 1473
		global::NPOI.SS.UserModel.Charts.IScatterChartData<Tx, Ty> CreateScatterChartData<Tx, Ty>();

		// Token: 0x060005C2 RID: 1474
		global::NPOI.SS.UserModel.Charts.ILineChartData<Tx, Ty> CreateLineChartData<Tx, Ty>();

		// Token: 0x060005C3 RID: 1475
		global::NPOI.SS.UserModel.Charts.IBarChartData<Tx, Ty> CreateBarChartData<Tx, Ty>();
	}
}
