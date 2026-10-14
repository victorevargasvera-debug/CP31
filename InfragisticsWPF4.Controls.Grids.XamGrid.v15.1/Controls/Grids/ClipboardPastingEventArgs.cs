using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020001BE RID: 446
	public class ClipboardPastingEventArgs : global::System.EventArgs
	{
		// Token: 0x06000C02 RID: 3074 RVA: 0x0002AA73 File Offset: 0x00028C73
		internal ClipboardPastingEventArgs(global::Infragistics.Controls.Grids.XamGrid grid)
		{
			this._grid = grid;
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000C03 RID: 3075 RVA: 0x0002AA82 File Offset: 0x00028C82
		// (set) Token: 0x06000C04 RID: 3076 RVA: 0x0002AA8A File Offset: 0x00028C8A
		public global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> Values { get; set; }

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000C05 RID: 3077 RVA: 0x0002AA93 File Offset: 0x00028C93
		// (set) Token: 0x06000C06 RID: 3078 RVA: 0x0002AA9B File Offset: 0x00028C9B
		public string ClipboardValue { get; protected internal set; }

		// Token: 0x06000C07 RID: 3079 RVA: 0x0002AAAC File Offset: 0x00028CAC
		public void PasteAsExcel()
		{
			if (this._grid == null)
			{
				return;
			}
			if (this.Values == null)
			{
				this._grid.OnClipboardPasteError(global::Infragistics.Controls.Grids.ClipboardPasteErrorType.InvalidInputSelection, false);
				return;
			}
			if (this._grid.ActiveCell == null || this._grid.ActiveCell.Row.RowType != global::Infragistics.Controls.Grids.RowType.DataRow || this._grid.ActiveCell.Column == null)
			{
				this._grid.OnClipboardPasteError(global::Infragistics.Controls.Grids.ClipboardPasteErrorType.InvalidDestinationSelection, false);
				return;
			}
			global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Cell> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Cell>();
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = this.GetAllVisibleChildColumns();
			int num = this.Values.Max((global::System.Collections.Generic.List<string> r) => r.Count);
			int num2 = allVisibleChildColumns.IndexOf(this._grid.ActiveCell.Column);
			if (num2 + num > allVisibleChildColumns.Count && !this._grid.OnClipboardPasteError(global::Infragistics.Controls.Grids.ClipboardPasteErrorType.TruncationError, true))
			{
				return;
			}
			int index = this._grid.ActiveCell.Row.Index;
			global::Infragistics.Controls.Grids.RowCollection rowCollectionResolved = this.GetRowCollectionResolved();
			int count = this.Values.Count;
			if (count == 0)
			{
				return;
			}
			string[,] array = new string[count, this.Values.First<global::System.Collections.Generic.List<string>>().Count];
			int count2 = rowCollectionResolved.Count;
			int num3 = global::System.Math.Min(count2 - 1, index + count - 1);
			if (index + count > count2 && !this._grid.OnClipboardPasteError(global::Infragistics.Controls.Grids.ClipboardPasteErrorType.TruncationError, true))
			{
				return;
			}
			bool flag = false;
			int endingRow = -1;
			int endingCol = -1;
			int num4 = index;
			while (num4 <= num3 && !flag)
			{
				int num5 = num4 - index;
				global::Infragistics.Controls.Grids.Row row = rowCollectionResolved[num4];
				int count3 = this.Values[num5].Count;
				int num6 = global::System.Math.Min(allVisibleChildColumns.Count - 1, count3 + num2 - 1);
				for (int i = num2; i <= num6; i++)
				{
					int num7 = i - num2;
					global::Infragistics.Controls.Grids.EditableColumn editableColumn = allVisibleChildColumns[i] as global::Infragistics.Controls.Grids.EditableColumn;
					bool flag2 = false;
					if (editableColumn == null || editableColumn.IsReadOnly)
					{
						if (!this._grid.OnClipboardPasteError(global::Infragistics.Controls.Grids.ClipboardPasteErrorType.ReadOnlyColumn, true))
						{
							flag = true;
							break;
						}
						flag2 = true;
					}
					else if (editableColumn is global::Infragistics.Controls.Grids.UnboundColumn)
					{
						if (!this._grid.OnClipboardPasteError(global::Infragistics.Controls.Grids.ClipboardPasteErrorType.UnboundColumn, true))
						{
							flag = true;
							break;
						}
						flag2 = true;
					}
					if (editableColumn != null && !flag2)
					{
						string parsedCellValue = this.Values[num5][num7];
						array[num5, num7] = this.GetCellValue(row, editableColumn);
						if (!this.SetCellValue(row, editableColumn, parsedCellValue))
						{
							if (!this._grid.OnClipboardPasteError(global::Infragistics.Controls.Grids.ClipboardPasteErrorType.CastError, true))
							{
								flag = true;
								break;
							}
						}
						else
						{
							endingCol = i;
							endingRow = num4;
							global::Infragistics.Controls.Grids.Cell cell = row.Cells[editableColumn] as global::Infragistics.Controls.Grids.Cell;
							if (cell != null)
							{
								list.Add(cell);
							}
						}
					}
				}
				num4++;
			}
			if (flag)
			{
				this.RevertCellValues(array, index, num2, endingRow, endingCol);
				return;
			}
			this.SelectCells(list);
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0002AD98 File Offset: 0x00028F98
		private bool RevertCellValues(string[,] values, int startingRow, int startingCol, int endingRow, int endingCol)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = this.GetAllVisibleChildColumns();
			global::Infragistics.Controls.Grids.RowCollection rowCollectionResolved = this.GetRowCollectionResolved();
			for (int i = startingRow; i <= endingRow; i++)
			{
				int num = i - startingRow;
				global::Infragistics.Controls.Grids.Row row = rowCollectionResolved[i];
				int num2 = values.GetUpperBound(1) + 1;
				int num3 = global::System.Math.Min(allVisibleChildColumns.Count - 1, num2 + startingCol - 1);
				int num4 = startingCol;
				while (num4 <= num3 && (i != endingRow || num4 <= endingCol))
				{
					int num5 = num4 - startingCol;
					global::Infragistics.Controls.Grids.EditableColumn editableColumn = allVisibleChildColumns[num4] as global::Infragistics.Controls.Grids.EditableColumn;
					if (editableColumn != null && !(editableColumn is global::Infragistics.Controls.Grids.UnboundColumn))
					{
						string parsedCellValue = values[num, num5];
						this.SetCellValue(row, editableColumn, parsedCellValue);
						global::Infragistics.Controls.Grids.CellBase cellBase = row.Cells[editableColumn];
					}
					num4++;
				}
			}
			return true;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0002AE5C File Offset: 0x0002905C
		private bool SetCellValue(global::Infragistics.Controls.Grids.Row row, global::Infragistics.Controls.Grids.EditableColumn column, string parsedCellValue)
		{
			bool result = true;
			global::Infragistics.Controls.Grids.Cell.CellValueObject cellValueObject = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(column.Key, new object[0]),
				Mode = global::System.Windows.Data.BindingMode.TwoWay,
				Source = row.Data,
				Converter = column.EditorValueConverter,
				ConverterParameter = column.EditorValueConverterParameter,
				ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture
			};
			global::System.Windows.Data.BindingOperations.SetBinding(cellValueObject, global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
			if (column.EditorValueConverter != null && column is global::Infragistics.Controls.Grids.TextColumn)
			{
				cellValueObject.Value = parsedCellValue;
			}
			else
			{
				object obj = null;
				bool flag = false;
				try
				{
					global::System.Type type = column.DataType;
					if (type != null)
					{
						bool isGenericType = type.IsGenericType;
						if (isGenericType && type.GetGenericTypeDefinition().Equals(typeof(global::System.Nullable<>)))
						{
							type = global::System.Nullable.GetUnderlyingType(type);
							flag = true;
						}
						if (!flag || !string.IsNullOrEmpty(parsedCellValue))
						{
							obj = global::System.Convert.ChangeType(parsedCellValue, type, global::System.Globalization.CultureInfo.CurrentCulture);
						}
					}
				}
				catch (global::System.InvalidCastException)
				{
					result = false;
				}
				catch (global::System.FormatException)
				{
					result = false;
				}
				catch (global::System.OverflowException)
				{
					result = false;
				}
				catch (global::System.ArgumentException)
				{
					result = false;
				}
				if (obj != null)
				{
					cellValueObject.Value = obj;
				}
				else if (flag && string.IsNullOrEmpty(parsedCellValue))
				{
					cellValueObject.Value = null;
				}
			}
			return result;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0002AFC4 File Offset: 0x000291C4
		private void SelectCells(global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Grids.Cell> cellsToSelect)
		{
			if (cellsToSelect.Any<global::Infragistics.Controls.Grids.Cell>())
			{
				this._grid.SelectionSettings.SelectedCells.Clear();
			}
			using (global::Infragistics.Controls.Grids.SelectedCellsCollection selectedCellsCollection = new global::Infragistics.Controls.Grids.SelectedCellsCollection())
			{
				foreach (global::Infragistics.Controls.Grids.Cell item in cellsToSelect)
				{
					selectedCellsCollection.Add(item);
				}
				this._grid.SelectionSettings.SelectedCells.AddRange(selectedCellsCollection);
			}
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0002B060 File Offset: 0x00029260
		private global::Infragistics.Controls.Grids.RowCollection GetRowCollectionResolved()
		{
			global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = ((global::Infragistics.Controls.Grids.Row)this._grid.ActiveCell.Row).ParentRow as global::Infragistics.Controls.Grids.Primitives.ChildBand;
			global::Infragistics.Controls.Grids.Primitives.GroupByRow groupByRow = ((global::Infragistics.Controls.Grids.Row)this._grid.ActiveCell.Row).ParentRow as global::Infragistics.Controls.Grids.Primitives.GroupByRow;
			if (childBand != null)
			{
				return childBand.Rows;
			}
			if (groupByRow != null)
			{
				return groupByRow.Rows;
			}
			return this._grid.Rows;
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0002B0CC File Offset: 0x000292CC
		private string GetCellValue(global::Infragistics.Controls.Grids.Row row, global::Infragistics.Controls.Grids.EditableColumn column)
		{
			global::Infragistics.Controls.Grids.Cell.CellValueObject cellValueObject = new global::Infragistics.Controls.Grids.Cell.CellValueObject();
			global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding
			{
				Path = new global::System.Windows.PropertyPath(column.Key, new object[0]),
				Mode = global::System.Windows.Data.BindingMode.TwoWay,
				Source = row.Data,
				Converter = column.EditorValueConverter,
				ConverterParameter = column.EditorValueConverterParameter,
				ConverterCulture = global::System.Globalization.CultureInfo.CurrentCulture
			};
			global::System.Windows.Data.BindingOperations.SetBinding(cellValueObject, global::Infragistics.Controls.Grids.Cell.CellValueObject.ValueProperty, binding);
			object obj = global::System.Convert.ChangeType(cellValueObject.Value, typeof(string), global::System.Globalization.CultureInfo.CurrentCulture);
			return obj as string;
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0002B164 File Offset: 0x00029364
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> GetAllVisibleChildColumns()
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
			global::Infragistics.Controls.Grids.RowBase row = this._grid.ActiveCell.Row;
			if (this._grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = this._grid.GroupBySettings.GroupByColumns[row.ColumnLayout];
				foreach (global::Infragistics.Controls.Grids.Column column in readOnlyCollection)
				{
					if (column.Visibility == global::System.Windows.Visibility.Visible)
					{
						list.Add(column);
					}
				}
			}
			foreach (global::Infragistics.Controls.Grids.Column column2 in row.Columns.FixedColumnsLeft)
			{
				if (column2.Visibility == global::System.Windows.Visibility.Visible)
				{
					if (!(column2 is global::Infragistics.Controls.Grids.GroupColumn))
					{
						list.Add(column2);
					}
					foreach (global::Infragistics.Controls.Grids.Column column3 in column2.AllColumns)
					{
						if (!(column3 is global::Infragistics.Controls.Grids.GroupColumn) && column3.Visibility == global::System.Windows.Visibility.Visible)
						{
							list.Add(column3);
						}
					}
				}
			}
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> allColumns = row.Columns.AllColumns;
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in allColumns)
			{
				global::Infragistics.Controls.Grids.Column column4 = columnBase as global::Infragistics.Controls.Grids.Column;
				if (column4 != null && column4.SupportsActivationAndSelection && column4.Visibility == global::System.Windows.Visibility.Visible && column4.IsFixed == global::Infragistics.Controls.Grids.FixedState.NotFixed && !list.Contains(column4))
				{
					list.Add(column4);
				}
			}
			global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsRight = row.Columns.FixedColumnsRight;
			int count = fixedColumnsRight.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				if (fixedColumnsRight[i].Visibility == global::System.Windows.Visibility.Visible)
				{
					if (!(fixedColumnsRight[i] is global::Infragistics.Controls.Grids.GroupColumn))
					{
						list.Add(fixedColumnsRight[i]);
					}
					foreach (global::Infragistics.Controls.Grids.Column column5 in fixedColumnsRight[i].AllColumns)
					{
						if (!(column5 is global::Infragistics.Controls.Grids.GroupColumn) && column5.Visibility == global::System.Windows.Visibility.Visible)
						{
							list.Add(column5);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x040003F4 RID: 1012
		private global::Infragistics.Controls.Grids.XamGrid _grid;
	}
}
