using System;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel.Charts
{
	// Token: 0x02000095 RID: 149
	public interface IChartSeries
	{
		// Token: 0x06000597 RID: 1431
		void SetTitle(string title);

		// Token: 0x06000598 RID: 1432
		void SetTitle(global::NPOI.SS.Util.CellReference titleReference);

		// Token: 0x06000599 RID: 1433
		string GetTitleString();

		// Token: 0x0600059A RID: 1434
		global::NPOI.SS.Util.CellReference GetTitleCellReference();

		// Token: 0x0600059B RID: 1435
		global::NPOI.SS.UserModel.Charts.TitleType? GetTitleType();
	}
}
