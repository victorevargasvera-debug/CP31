using System;
using DevAge.Drawing;

namespace SourceGrid.Cells.Models
{
	// Token: 0x020003AF RID: 943
	internal interface ISortableHeader : global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002B81 RID: 11137
		global::SourceGrid.Cells.Models.SortStatus GetSortStatus(global::SourceGrid.CellContext cellContext);

		// Token: 0x06002B82 RID: 11138
		void SetSortMode(global::SourceGrid.CellContext cellContext, global::DevAge.Drawing.HeaderSortStyle pStyle);
	}
}
