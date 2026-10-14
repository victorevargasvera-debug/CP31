using System;
using SourceGrid.Cells.Virtual;

namespace SourceGrid.Cells.DataGrid
{
	// Token: 0x02000408 RID: 1032
	internal class Image : global::SourceGrid.Cells.Virtual.Image
	{
		// Token: 0x06002D60 RID: 11616 RVA: 0x00098C14 File Offset: 0x00096E14
		public Image()
		{
			base.Model.AddModel(new global::SourceGrid.DataGridValueModel());
		}
	}
}
