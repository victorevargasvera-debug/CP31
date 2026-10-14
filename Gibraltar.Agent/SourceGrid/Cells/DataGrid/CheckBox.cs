using System;
using SourceGrid.Cells.Virtual;

namespace SourceGrid.Cells.DataGrid
{
	// Token: 0x02000407 RID: 1031
	internal class CheckBox : global::SourceGrid.Cells.Virtual.CheckBox
	{
		// Token: 0x06002D5F RID: 11615 RVA: 0x00098BFC File Offset: 0x00096DFC
		public CheckBox()
		{
			base.Model.AddModel(new global::SourceGrid.DataGridValueModel());
		}
	}
}
