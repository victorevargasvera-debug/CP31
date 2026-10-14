using System;

namespace SourceGrid
{
	// Token: 0x020003D2 RID: 978
	[global::System.Flags]
	internal enum ContextMenuStyle
	{
		// Token: 0x04000EC4 RID: 3780
		None = 0,
		// Token: 0x04000EC5 RID: 3781
		ColumnResize = 1,
		// Token: 0x04000EC6 RID: 3782
		RowResize = 2,
		// Token: 0x04000EC7 RID: 3783
		AutoSize = 4,
		// Token: 0x04000EC8 RID: 3784
		ClearSelection = 8,
		// Token: 0x04000EC9 RID: 3785
		CopyPasteSelection = 16,
		// Token: 0x04000ECA RID: 3786
		CellContextMenu = 32
	}
}
