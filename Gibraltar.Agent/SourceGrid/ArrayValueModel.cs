using System;
using DevAge.ComponentModel;
using SourceGrid.Cells.Models;

namespace SourceGrid
{
	// Token: 0x02000410 RID: 1040
	internal class ArrayValueModel : global::SourceGrid.Cells.Models.IValueModel, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002D8C RID: 11660 RVA: 0x0009918C File Offset: 0x0009738C
		public virtual object GetValue(global::SourceGrid.CellContext cellContext)
		{
			global::System.Array dataSource = ((global::SourceGrid.ArrayGrid)cellContext.Grid).DataSource;
			return dataSource.GetValue(cellContext.Position.Row - cellContext.Grid.FixedRows, cellContext.Position.Column - cellContext.Grid.FixedColumns);
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x000991E8 File Offset: 0x000973E8
		public virtual void SetValue(global::SourceGrid.CellContext cellContext, object p_Value)
		{
			global::DevAge.ComponentModel.ValueEventArgs valueEventArgs = new global::DevAge.ComponentModel.ValueEventArgs(p_Value);
			if (cellContext.Grid != null)
			{
				cellContext.Grid.Controller.OnValueChanging(cellContext, valueEventArgs);
			}
			global::System.Array dataSource = ((global::SourceGrid.ArrayGrid)cellContext.Grid).DataSource;
			dataSource.SetValue(valueEventArgs.Value, cellContext.Position.Row - cellContext.Grid.FixedRows, cellContext.Position.Column - cellContext.Grid.FixedColumns);
			if (cellContext.Grid != null)
			{
				cellContext.Grid.Controller.OnValueChanged(cellContext, global::System.EventArgs.Empty);
			}
		}
	}
}
