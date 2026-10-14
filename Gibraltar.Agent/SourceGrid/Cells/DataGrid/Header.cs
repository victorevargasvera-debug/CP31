using System;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Virtual;

namespace SourceGrid.Cells.DataGrid
{
	// Token: 0x0200040C RID: 1036
	internal class Header : global::SourceGrid.Cells.Virtual.Header
	{
		// Token: 0x06002D64 RID: 11620 RVA: 0x00098C90 File Offset: 0x00096E90
		public Header()
		{
			base.Model.AddModel(new global::SourceGrid.Cells.Models.NullValueModel());
		}
	}
}
