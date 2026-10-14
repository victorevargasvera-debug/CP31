using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x0200009E RID: 158
	public interface IChartAxisFactory
	{
		// Token: 0x060005BD RID: 1469
		global::NPOI.SS.UserModel.Charts.IValueAxis CreateValueAxis(global::NPOI.SS.UserModel.Charts.AxisPosition pos);

		// Token: 0x060005BE RID: 1470
		global::NPOI.SS.UserModel.Charts.IChartAxis CreateCategoryAxis(global::NPOI.SS.UserModel.Charts.AxisPosition pos);

		// Token: 0x060005BF RID: 1471
		global::NPOI.SS.UserModel.Charts.IChartAxis CreateDateAxis(global::NPOI.SS.UserModel.Charts.AxisPosition pos);
	}
}
