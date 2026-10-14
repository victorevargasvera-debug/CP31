using System;
using SourceGrid.Cells.Editors;
using SourceGrid.Cells.Virtual;

namespace SourceGrid.Cells.DataGrid
{
	// Token: 0x02000406 RID: 1030
	internal class Cell : global::SourceGrid.Cells.Virtual.CellVirtual
	{
		// Token: 0x06002D5D RID: 11613 RVA: 0x00098B80 File Offset: 0x00096D80
		public Cell()
		{
			base.Model.AddModel(new global::SourceGrid.DataGridValueModel());
		}

		// Token: 0x06002D5E RID: 11614 RVA: 0x00098B98 File Offset: 0x00096D98
		public static global::SourceGrid.Cells.ICellVirtual Create(global::System.Type type, bool editable)
		{
			global::SourceGrid.Cells.ICellVirtual cellVirtual;
			if (type == typeof(bool))
			{
				cellVirtual = new global::SourceGrid.Cells.DataGrid.CheckBox();
			}
			else
			{
				cellVirtual = new global::SourceGrid.Cells.DataGrid.Cell();
				cellVirtual.Editor = global::SourceGrid.Cells.Editors.Factory.Create(type);
			}
			if (cellVirtual.Editor != null)
			{
				cellVirtual.Editor.AllowNull = true;
				cellVirtual.Editor.EnableEdit = editable;
			}
			return cellVirtual;
		}
	}
}
