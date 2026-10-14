using System;
using System.Collections.Generic;
using NPOI.SS.UserModel.Charts;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000050 RID: 80
	public interface IChart : global::NPOI.SS.UserModel.Charts.ManuallyPositionable
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000313 RID: 787
		global::NPOI.SS.UserModel.Charts.IChartDataFactory ChartDataFactory { get; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000314 RID: 788
		global::NPOI.SS.UserModel.Charts.IChartAxisFactory ChartAxisFactory { get; }

		// Token: 0x06000315 RID: 789
		global::NPOI.SS.UserModel.Charts.IChartLegend GetOrCreateLegend();

		// Token: 0x06000316 RID: 790
		void DeleteLegend();

		// Token: 0x06000317 RID: 791
		global::System.Collections.Generic.List<global::NPOI.SS.UserModel.Charts.IChartAxis> GetAxis();

		// Token: 0x06000318 RID: 792
		void Plot(global::NPOI.SS.UserModel.Charts.IChartData data, params global::NPOI.SS.UserModel.Charts.IChartAxis[] axis);

		// Token: 0x06000319 RID: 793
		void SetTitle(string newTitle);
	}
}
