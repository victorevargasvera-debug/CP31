using System;
using SourceGrid.Cells.Virtual;

namespace SourceGrid.Cells.DataGrid
{
	// Token: 0x0200040B RID: 1035
	internal class RowHeader : global::SourceGrid.Cells.Virtual.RowHeader
	{
		// Token: 0x06002D63 RID: 11619 RVA: 0x00098C60 File Offset: 0x00096E60
		public RowHeader()
		{
			base.Model.AddModel(new global::SourceGrid.DataGridRowHeaderModel());
			base.ResizeEnabled = false;
		}
	}
}
