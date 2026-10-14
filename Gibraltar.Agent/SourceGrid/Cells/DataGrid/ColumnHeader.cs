using System;
using SourceGrid.Cells.Models;
using SourceGrid.Cells.Virtual;

namespace SourceGrid.Cells.DataGrid
{
	// Token: 0x0200040A RID: 1034
	internal class ColumnHeader : global::SourceGrid.Cells.Virtual.ColumnHeader
	{
		// Token: 0x06002D62 RID: 11618 RVA: 0x00098C44 File Offset: 0x00096E44
		public ColumnHeader(string pCaption)
		{
			base.Model.AddModel(new global::SourceGrid.Cells.Models.ValueModel(pCaption));
		}
	}
}
