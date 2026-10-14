using System;
using System.ComponentModel;
using DevAge.ComponentModel;
using SourceGrid.Cells.Models;

namespace SourceGrid
{
	// Token: 0x02000401 RID: 1025
	internal class DataGridValueModel : global::SourceGrid.Cells.Models.IValueModel, global::SourceGrid.Cells.Models.IModel
	{
		// Token: 0x06002D4F RID: 11599 RVA: 0x000988C0 File Offset: 0x00096AC0
		public object GetValue(global::SourceGrid.CellContext cellContext)
		{
			global::SourceGrid.DataGrid dataGrid = (global::SourceGrid.DataGrid)cellContext.Grid;
			global::System.ComponentModel.PropertyDescriptor propertyColumn = dataGrid.Columns[cellContext.Position.Column].PropertyColumn;
			int num = dataGrid.Rows.IndexToDataSourceIndex(cellContext.Position.Row);
			if (num >= dataGrid.DataSource.Count)
			{
				return null;
			}
			object itemValue = dataGrid.DataSource.GetItemValue(num, propertyColumn);
			if (global::System.DBNull.Value == itemValue)
			{
				return null;
			}
			return itemValue;
		}

		// Token: 0x06002D50 RID: 11600 RVA: 0x00098944 File Offset: 0x00096B44
		public void SetValue(global::SourceGrid.CellContext cellContext, object p_Value)
		{
			if (p_Value == null)
			{
				p_Value = global::System.DBNull.Value;
			}
			global::DevAge.ComponentModel.ValueEventArgs valueEventArgs = new global::DevAge.ComponentModel.ValueEventArgs(p_Value);
			if (cellContext.Grid != null)
			{
				cellContext.Grid.Controller.OnValueChanging(cellContext, valueEventArgs);
			}
			global::SourceGrid.DataGrid dataGrid = (global::SourceGrid.DataGrid)cellContext.Grid;
			global::System.ComponentModel.PropertyDescriptor propertyColumn = dataGrid.Columns[cellContext.Position.Column].PropertyColumn;
			dataGrid.Rows.IndexToDataSourceIndex(cellContext.Position.Row);
			dataGrid.DataSource.SetEditValue(propertyColumn, valueEventArgs.Value);
			if (cellContext.Grid != null)
			{
				cellContext.Grid.Controller.OnValueChanged(cellContext, global::System.EventArgs.Empty);
			}
		}
	}
}
