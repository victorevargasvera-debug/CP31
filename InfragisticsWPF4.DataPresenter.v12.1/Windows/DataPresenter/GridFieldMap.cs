using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002D3 RID: 723
	internal class GridFieldMap
	{
		// Token: 0x06002252 RID: 8786 RVA: 0x00095B14 File Offset: 0x00093D14
		internal GridFieldMap(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator fieldLayoutTemplateGenerator)
		{
			this._fieldLayoutTemplateGenerator = fieldLayoutTemplateGenerator;
			this._fieldLayout = fieldLayoutTemplateGenerator.FieldLayout;
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06002253 RID: 8787 RVA: 0x00095B2F File Offset: 0x00093D2F
		public global::Infragistics.Windows.DataPresenter.Field[,] Map
		{
			get
			{
				this.VerifyInitialized();
				return this._map;
			}
		}

		// Token: 0x06002254 RID: 8788 RVA: 0x00095B3D File Offset: 0x00093D3D
		internal global::Infragistics.Windows.DataPresenter.Field GetFirstField()
		{
			this.VerifyInitialized();
			return this._firstField;
		}

		// Token: 0x06002255 RID: 8789 RVA: 0x00095B4B File Offset: 0x00093D4B
		internal global::Infragistics.Windows.DataPresenter.Field GetLastField()
		{
			this.VerifyInitialized();
			return this._lastField;
		}

		// Token: 0x06002256 RID: 8790 RVA: 0x00095B5C File Offset: 0x00093D5C
		internal int GetNavigationIndex(global::Infragistics.Windows.DataPresenter.Field field, int previousIndex)
		{
			this.VerifyInitialized();
			int result = previousIndex;
			if (previousIndex < 0 || previousIndex >= this._navigationFields.Length || this._navigationFields[previousIndex] != field)
			{
				result = global::System.Array.IndexOf<global::Infragistics.Windows.DataPresenter.Field>(this._navigationFields, field);
			}
			return result;
		}

		// Token: 0x06002257 RID: 8791 RVA: 0x00095B99 File Offset: 0x00093D99
		internal global::Infragistics.Windows.DataPresenter.Field[] GetNavigationOrderFields()
		{
			this.VerifyInitialized();
			return this._navigationFields;
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x00095BA8 File Offset: 0x00093DA8
		internal global::Infragistics.Windows.DataPresenter.Cell GetNavigationTargetCell(global::Infragistics.Windows.DataPresenter.Cell currentCell, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.IViewPanel panelNavigator, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle)
		{
			global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = currentCell.Field.GridPosition;
			int row = gridPosition.Row;
			int column = gridPosition.Column;
			global::Infragistics.Windows.DataPresenter.Cell cell = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetCell(currentCell.Record, row, column, navigationDirection, siblingNavigationStyle, false);
			if (cell != null)
			{
				return cell;
			}
			if (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentAndWrap || siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentNoWrap)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection2 = navigationDirection;
			global::System.Windows.Controls.Orientation logicalOrientation = this._fieldLayoutTemplateGenerator.LogicalOrientation;
			if (this._fieldLayoutTemplateGenerator.HasLogicalOrientation)
			{
				navigationDirection2 = this._fieldLayoutTemplateGenerator.GetRecordNavigationDirectionFromCellNavigationDirection(navigationDirection);
			}
			else
			{
				switch (navigationDirection)
				{
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
					navigationDirection2 = global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous;
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
					navigationDirection2 = global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next;
					break;
				}
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
			if (shiftKeyDown)
			{
				dataRecord = (panelNavigator.GetNavigationTargetRecord(currentCell.Record, navigationDirection2, selectionHost, shiftKeyDown, ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentNoWrap, typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord);
			}
			else
			{
				dataRecord = (panelNavigator.GetNavigationTargetRecord(currentCell.Record, navigationDirection2, selectionHost, shiftKeyDown, ctlKeyDown, siblingNavigationStyle, typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord);
			}
			if (dataRecord == null || dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = dataRecord.FieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = fieldLayout.StyleGenerator;
			if (styleGenerator != null)
			{
				styleGenerator.GridFieldMap.VerifyInitialized();
			}
			switch (navigationDirection)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
				if (!styleGenerator.AreRecordsArrangedInRowsAndCols)
				{
					if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						row = fieldLayout.TotalRowsGenerated - 1;
						column = fieldLayout.TotalColumnsGenerated - 1;
					}
					else
					{
						column = fieldLayout.TotalColumnsGenerated - 1;
					}
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
				if (!styleGenerator.AreRecordsArrangedInRowsAndCols)
				{
					if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						row = 0;
						column = 0;
					}
					else
					{
						column = 0;
					}
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
				if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					row = fieldLayout.TotalRowsGenerated - 1;
				}
				else
				{
					row = fieldLayout.TotalRowsGenerated - 1;
					column = fieldLayout.TotalColumnsGenerated - 1;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
				if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					row = 0;
				}
				else
				{
					row = 0;
					column = 0;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
				if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					row = 0;
					column = 0;
				}
				else
				{
					row = 0;
					column = 0;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
				if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					row = fieldLayout.TotalRowsGenerated - 1;
					column = fieldLayout.TotalColumnsGenerated - 1;
				}
				else
				{
					row = fieldLayout.TotalRowsGenerated - 1;
					column = fieldLayout.TotalColumnsGenerated - 1;
				}
				break;
			}
			return global::Infragistics.Windows.DataPresenter.GridFieldMap.GetCell(dataRecord, row, column, navigationDirection, siblingNavigationStyle, true);
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x00095DD0 File Offset: 0x00093FD0
		private void Initialize()
		{
			this._fieldLayout.VerifyStyleGeneratorTemplates();
			int totalRowsGenerated = this._fieldLayout.TotalRowsGenerated;
			int totalColumnsGenerated = this._fieldLayout.TotalColumnsGenerated;
			this._map = new global::Infragistics.Windows.DataPresenter.Field[totalRowsGenerated, totalColumnsGenerated];
			foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
			{
				if (field.CellContentAlignmentResolved != global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly && field.VisibilityResolved == global::System.Windows.Visibility.Visible && !field.IsExpandableResolved)
				{
					global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = field.GridPosition;
					int num = gridPosition.Row;
					while (num < gridPosition.Row + gridPosition.RowSpan && num < totalRowsGenerated)
					{
						int num2 = gridPosition.Column;
						while (num2 < gridPosition.Column + gridPosition.ColumnSpan && num2 < totalColumnsGenerated)
						{
							if (this._map[num, num2] == null)
							{
								this._map[num, num2] = field;
							}
							num2++;
						}
						num++;
					}
				}
			}
			this._maxSeqOffset = totalColumnsGenerated * totalRowsGenerated - 1;
			while (this._maxSeqOffset > 0)
			{
				int num3 = this._maxSeqOffset / totalColumnsGenerated;
				int num4 = this._maxSeqOffset % totalColumnsGenerated;
				if (this._map[num3, num4] != null)
				{
					break;
				}
				this._maxSeqOffset--;
			}
			this._firstField = null;
			for (int i = 0; i <= this._maxSeqOffset; i++)
			{
				int num5 = i / totalColumnsGenerated;
				int num6 = i % totalColumnsGenerated;
				this._firstField = this._map[num5, num6];
				if (this._firstField != null)
				{
					break;
				}
			}
			this._lastField = null;
			for (int j = this._maxSeqOffset; j >= 0; j--)
			{
				int num7 = j / totalColumnsGenerated;
				int num8 = j % totalColumnsGenerated;
				this._lastField = this._map[num7, num8];
				if (this._lastField != null)
				{
					break;
				}
			}
			bool flag = true;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			int k = 0;
			int num9 = flag ? totalRowsGenerated : totalColumnsGenerated;
			while (k < num9)
			{
				int l = 0;
				int num10 = flag ? totalColumnsGenerated : totalRowsGenerated;
				while (l < num10)
				{
					int num11 = flag ? k : l;
					int num12 = flag ? l : k;
					global::Infragistics.Windows.DataPresenter.Field field2 = this._map[num11, num12];
					if (field2 != null && (num11 <= 0 || this._map[num11 - 1, num12] != field2) && (num12 <= 0 || this._map[num11, num12 - 1] != field2))
					{
						list.Add(field2);
					}
					l++;
				}
				k++;
			}
			this._navigationFields = list.ToArray();
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x00096078 File Offset: 0x00094278
		internal void ResetMap()
		{
			this._map = null;
			this._lastField = (this._firstField = null);
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0009609C File Offset: 0x0009429C
		private static global::Infragistics.Windows.DataPresenter.Field[,] CompressFieldMap(global::Infragistics.Windows.DataPresenter.Field[,] fieldMap, global::Infragistics.Windows.DataPresenter.Record record)
		{
			int length = fieldMap.GetLength(0);
			int length2 = fieldMap.GetLength(1);
			global::Infragistics.Windows.DataPresenter.Field[,] array = new global::Infragistics.Windows.DataPresenter.Field[length, length2];
			int num = 0;
			for (int i = 0; i < length; i++)
			{
				bool flag = false;
				for (int j = 0; j < length2; j++)
				{
					array[num, j] = fieldMap[i, j];
					if (!record.ShouldCollapseCell(fieldMap[i, j]))
					{
						flag = true;
					}
				}
				if (flag)
				{
					num++;
				}
			}
			length = array.GetLength(0);
			length2 = array.GetLength(1);
			global::Infragistics.Windows.DataPresenter.Field[,] array2 = new global::Infragistics.Windows.DataPresenter.Field[num, length2];
			int num2 = 0;
			for (int k = 0; k < length2; k++)
			{
				bool flag2 = false;
				for (int l = 0; l < num; l++)
				{
					array2[l, num2] = array[l, k];
					if (!record.ShouldCollapseCell(array[l, k]))
					{
						flag2 = true;
					}
				}
				if (flag2)
				{
					num2++;
				}
			}
			if (array2.GetLength(1) == num)
			{
				return array2;
			}
			global::Infragistics.Windows.DataPresenter.Field[,] array3 = new global::Infragistics.Windows.DataPresenter.Field[num, num2];
			for (int m = 0; m < num; m++)
			{
				for (int n = 0; n < num2; n++)
				{
					array3[m, n] = array2[m, n];
				}
			}
			return array3;
		}

		// Token: 0x0600225C RID: 8796 RVA: 0x000961DC File Offset: 0x000943DC
		private static global::Infragistics.Windows.DataPresenter.Cell GetCellInDirection(global::Infragistics.Windows.DataPresenter.Field[,] fields, int row, int column, global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field startingField, bool includeCurrent, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection direction, bool wrap)
		{
			global::Infragistics.Windows.DataPresenter.Field[,] array;
			int length;
			int length2;
			if (record.ShouldCollapseEmptyCellsResolved)
			{
				array = global::Infragistics.Windows.DataPresenter.GridFieldMap.CompressFieldMap(fields, record);
				length = array.GetLength(0);
				length2 = array.GetLength(1);
				int num;
				int num2;
				global::Infragistics.Windows.DataPresenter.GridFieldMap.GetFieldRowColInMap(array, startingField, out num, out num2);
				if (num > -1 && num2 > -1)
				{
					row = num;
					column = num2;
				}
				else
				{
					row = global::System.Math.Min(length - 1, row);
					column = global::System.Math.Min(length2 - 1, column);
					startingField = array[row, column];
				}
			}
			else
			{
				array = fields;
				length = fields.GetLength(0);
				length2 = fields.GetLength(1);
			}
			int num3 = 0;
			int num4 = 0;
			bool flag = false;
			int num5;
			switch (direction)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
				flag = true;
				num5 = column + 1;
				num4 = -1;
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
				flag = true;
				num5 = length2 - column;
				num4 = 1;
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
				num5 = row + 1;
				num3 = -1;
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
				num5 = length - row;
				num3 = 1;
				break;
			default:
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = null;
			for (int i = 0; i < num5; i++)
			{
				int num6 = row + num3 * i;
				int num7 = column + num4 * i;
				global::Infragistics.Windows.DataPresenter.Field field = array[num6, num7];
				if (field != null && !record.ShouldCollapseCell(field) && (record.ShouldCollapseEmptyCellsResolved || ((!flag || field.GridPosition.Row == num6) && (flag || field.GridPosition.Column == num7))))
				{
					cell = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetNavigationCell(startingField, record, includeCurrent, field);
					if (cell != null)
					{
						break;
					}
				}
			}
			if (cell == null && wrap)
			{
				bool flag2 = false;
				switch (direction)
				{
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
					if (row > 0)
					{
						flag2 = true;
						column = length2 - 1;
						row--;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
					if (row < length - 1)
					{
						flag2 = true;
						column = 0;
						row++;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
					if (column > 0)
					{
						flag2 = true;
						row = length - 1;
						column--;
					}
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
					if (column < length2 - 1)
					{
						flag2 = true;
						row = 0;
						column++;
					}
					break;
				}
				if (flag2)
				{
					cell = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetCellInDirection(array, row, column, record, startingField, includeCurrent, direction, wrap);
				}
			}
			return cell;
		}

		// Token: 0x0600225D RID: 8797 RVA: 0x000963C4 File Offset: 0x000945C4
		private static global::Infragistics.Windows.DataPresenter.Cell GetCell(global::Infragistics.Windows.DataPresenter.DataRecord record, int row, int column, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, bool includeCurrent)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = fieldLayout.StyleGenerator;
			global::Infragistics.Windows.DataPresenter.GridFieldMap gridFieldMap = styleGenerator.GridFieldMap;
			gridFieldMap.VerifyInitialized();
			global::Infragistics.Windows.DataPresenter.Field[,] map = gridFieldMap.Map;
			int length = map.GetLength(0);
			int length2 = map.GetLength(1);
			if (length2 == 0 || length == 0)
			{
				return null;
			}
			column = global::System.Math.Max(0, global::System.Math.Min(length2 - 1, column));
			row = global::System.Math.Max(0, global::System.Math.Min(length - 1, row));
			global::Infragistics.Windows.DataPresenter.Field startingField = map[row, column];
			switch (navigationDirection)
			{
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
			{
				bool flag = siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentAndWrap;
				if (!flag)
				{
					bool hasLogicalOrientation = styleGenerator.HasLogicalOrientation;
					global::System.Windows.Controls.Orientation logicalOrientation = styleGenerator.LogicalOrientation;
					bool flag2 = navigationDirection == global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left || navigationDirection == global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right;
					flag = (hasLogicalOrientation && flag2 == (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical) && !styleGenerator.AreRecordsArrangedInRowsAndCols);
				}
				return global::Infragistics.Windows.DataPresenter.GridFieldMap.GetCellInDirection(gridFieldMap.Map, row, column, record, startingField, includeCurrent, navigationDirection, flag);
			}
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
			{
				bool wrap = siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentAndWrap;
				return global::Infragistics.Windows.DataPresenter.GridFieldMap.GetNextPreviousCell(gridFieldMap, row, column, record, startingField, includeCurrent, navigationDirection == global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next, wrap);
			}
			default:
				return null;
			}
		}

		// Token: 0x0600225E RID: 8798 RVA: 0x000964D8 File Offset: 0x000946D8
		private static void GetFieldRowColInMap(global::Infragistics.Windows.DataPresenter.Field[,] fieldMap, global::Infragistics.Windows.DataPresenter.Field field, out int row, out int col)
		{
			int length = fieldMap.GetLength(0);
			int length2 = fieldMap.GetLength(1);
			for (int i = 0; i < length; i++)
			{
				for (int j = 0; j < length2; j++)
				{
					if (fieldMap[i, j] == field)
					{
						row = i;
						col = j;
						return;
					}
				}
			}
			row = -1;
			col = -1;
		}

		// Token: 0x0600225F RID: 8799 RVA: 0x00096528 File Offset: 0x00094728
		private static global::Infragistics.Windows.DataPresenter.Cell GetNavigationCell(global::Infragistics.Windows.DataPresenter.Field startingField, global::Infragistics.Windows.DataPresenter.DataRecord record, bool includeCurrent, global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			if (field == startingField && !includeCurrent)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.Cell cell = record.Cells[field];
			if (cell != null && !cell.IsTabStop)
			{
				return null;
			}
			return cell;
		}

		// Token: 0x06002260 RID: 8800 RVA: 0x00096560 File Offset: 0x00094760
		private static global::Infragistics.Windows.DataPresenter.Cell GetNextPreviousCell(global::Infragistics.Windows.DataPresenter.GridFieldMap map, int row, int column, global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field startingField, bool includeCurrent, bool next, bool wrap)
		{
			global::Infragistics.Windows.DataPresenter.Field[,] map2 = map._map;
			global::Infragistics.Windows.DataPresenter.Field[] navigationFields = map._navigationFields;
			int num = navigationFields.Length;
			if (startingField == null)
			{
				if (num == 0)
				{
					return null;
				}
				if (next)
				{
					startingField = navigationFields[0];
				}
				else
				{
					startingField = navigationFields[num - 1];
				}
			}
			int navigationIndex = startingField.NavigationIndex;
			global::Infragistics.Windows.DataPresenter.Cell nextPreviousCellHelper = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetNextPreviousCellHelper(startingField, record, includeCurrent, navigationFields, next, navigationIndex, next ? (num - navigationIndex) : (navigationIndex + 1));
			if (nextPreviousCellHelper == null && wrap)
			{
				nextPreviousCellHelper = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetNextPreviousCellHelper(startingField, record, includeCurrent, navigationFields, next, next ? 0 : (num - 1), next ? (navigationIndex - 1) : (num - navigationIndex));
			}
			return nextPreviousCellHelper;
		}

		// Token: 0x06002261 RID: 8801 RVA: 0x000965EC File Offset: 0x000947EC
		private static global::Infragistics.Windows.DataPresenter.Cell GetNextPreviousCellHelper(global::Infragistics.Windows.DataPresenter.Field startingField, global::Infragistics.Windows.DataPresenter.DataRecord record, bool includeCurrent, global::Infragistics.Windows.DataPresenter.Field[] navigationFields, bool next, int start, int count)
		{
			if (start < 0 || start >= navigationFields.Length)
			{
				return null;
			}
			for (int i = 0; i < count; i++)
			{
				int num = start + (next ? i : (-i));
				global::Infragistics.Windows.DataPresenter.Field field = navigationFields[num];
				global::Infragistics.Windows.DataPresenter.Cell navigationCell = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetNavigationCell(startingField, record, includeCurrent, field);
				if (navigationCell != null && !record.ShouldCollapseCell(field))
				{
					return navigationCell;
				}
			}
			return null;
		}

		// Token: 0x06002262 RID: 8802 RVA: 0x0009663E File Offset: 0x0009483E
		private void VerifyInitialized()
		{
			if (this._map == null)
			{
				this.Initialize();
			}
		}

		// Token: 0x040010CA RID: 4298
		private global::Infragistics.Windows.DataPresenter.Field[,] _map;

		// Token: 0x040010CB RID: 4299
		private global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator _fieldLayoutTemplateGenerator;

		// Token: 0x040010CC RID: 4300
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040010CD RID: 4301
		private int _maxSeqOffset;

		// Token: 0x040010CE RID: 4302
		private global::Infragistics.Windows.DataPresenter.Field _firstField;

		// Token: 0x040010CF RID: 4303
		private global::Infragistics.Windows.DataPresenter.Field _lastField;

		// Token: 0x040010D0 RID: 4304
		private global::Infragistics.Windows.DataPresenter.Field[] _navigationFields;
	}
}
