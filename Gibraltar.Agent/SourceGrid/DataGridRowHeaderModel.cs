using System;
using SourceGrid.Cells.Models;

namespace SourceGrid
{
	// Token: 0x02000402 RID: 1026
	internal class DataGridRowHeaderModel : global::SourceGrid.Cells.Models.IValueModel, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002D52 RID: 11602 RVA: 0x00098A08 File Offset: 0x00096C08
		public object GetValue(global::SourceGrid.CellContext cellContext)
		{
			global::SourceGrid.DataGrid dataGrid = (global::SourceGrid.DataGrid)cellContext.Grid;
			if (dataGrid.DataSource != null && dataGrid.DataSource.AllowNew && cellContext.Position.Row == dataGrid.Rows.Count - 1)
			{
				return "*";
			}
			return null;
		}

		// Token: 0x06002D53 RID: 11603 RVA: 0x00098A68 File Offset: 0x00096C68
		public void SetValue(global::SourceGrid.CellContext cellContext, object p_Value)
		{
			throw new global::System.ApplicationException("Not supported");
		}
	}
}
