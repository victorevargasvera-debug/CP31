using System;
using SourceGrid.Cells.Virtual;

namespace SourceGrid.Cells.DataGrid
{
	// Token: 0x02000409 RID: 1033
	internal class Link : global::SourceGrid.Cells.Virtual.Link
	{
		// Token: 0x06002D61 RID: 11617 RVA: 0x00098C2C File Offset: 0x00096E2C
		public Link()
		{
			base.Model.AddModel(new global::SourceGrid.DataGridValueModel());
		}
	}
}
