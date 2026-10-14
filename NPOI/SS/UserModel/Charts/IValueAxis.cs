using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x020000A9 RID: 169
	public interface IValueAxis : global::NPOI.SS.UserModel.Charts.IChartAxis
	{
		// Token: 0x060005DF RID: 1503
		global::NPOI.SS.UserModel.Charts.AxisCrossBetween GetCrossBetween();

		// Token: 0x060005E0 RID: 1504
		void SetCrossBetween(global::NPOI.SS.UserModel.Charts.AxisCrossBetween crossBetween);
	}
}
