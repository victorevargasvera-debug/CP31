using System;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x020000A1 RID: 161
	public interface IChartLegend : global::NPOI.SS.UserModel.Charts.ManuallyPositionable
	{
		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x060005C4 RID: 1476
		// (set) Token: 0x060005C5 RID: 1477
		global::NPOI.SS.UserModel.Charts.LegendPosition Position { get; set; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x060005C6 RID: 1478
		// (set) Token: 0x060005C7 RID: 1479
		bool IsOverlay { get; set; }
	}
}
