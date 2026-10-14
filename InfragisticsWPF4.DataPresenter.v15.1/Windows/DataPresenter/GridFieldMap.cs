using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.DataPresenter.Internal;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000312 RID: 786
	internal class GridFieldMap
	{
		// Token: 0x060025E6 RID: 9702 RVA: 0x000A8F74 File Offset: 0x000A7174
		internal GridFieldMap(global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator fieldLayoutTemplateGenerator, bool isCompessedLabelMap = false, global::Infragistics.Windows.DataPresenter.Field[,] compressedFieldMap = null, global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation layoutInfo = null)
		{
			this._fieldLayoutTemplateGenerator = fieldLayoutTemplateGenerator;
			this._fieldLayout = fieldLayoutTemplateGenerator.FieldLayout;
			this._compressedFieldMap = compressedFieldMap;
			this._layoutInfo = layoutInfo;
			this._isCompressedLabelMap = isCompessedLabelMap;
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x000A8FA5 File Offset: 0x000A71A5
		public global::Infragistics.Windows.DataPresenter.Field[,] Map
		{
			get
			{
				this.VerifyInitialized();
				return this._map;
			}
		}

		// Token: 0x060025E8 RID: 9704 RVA: 0x000A8FB3 File Offset: 0x000A71B3
		internal global::Infragistics.Windows.DataPresenter.Field GetFirstField()
		{
			this.VerifyInitialized();
			return this._firstField;
		}

		// Token: 0x060025E9 RID: 9705 RVA: 0x000A8FC1 File Offset: 0x000A71C1
		internal global::Infragistics.Windows.DataPresenter.Field GetLastField()
		{
			this.VerifyInitialized();
			return this._lastField;
		}

		// Token: 0x060025EA RID: 9706 RVA: 0x000A8FCF File Offset: 0x000A71CF
		internal int GetNavigationIndex(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._compressedFieldMap == null)
			{
				return field.NavigationIndex;
			}
			if (this._isCompressedLabelMap)
			{
				return field.NavigationIndexCompressedLabel;
			}
			return field.NavigationIndexCompressedCell;
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x000A8FF8 File Offset: 0x000A71F8
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

		// Token: 0x060025EC RID: 9708 RVA: 0x000A9035 File Offset: 0x000A7235
		internal global::Infragistics.Windows.DataPresenter.Field[] GetNavigationOrderFields()
		{
			this.VerifyInitialized();
			return this._navigationFields;
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x000A9044 File Offset: 0x000A7244
		internal global::Infragistics.Windows.DataPresenter.Cell GetNavigationTargetCell(global::Infragistics.Windows.DataPresenter.Cell currentCell, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.IViewPanel panelNavigator, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle)
		{
			global::Infragistics.Windows.DataPresenter.Field field = currentCell.Field;
			global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition positionInMap = this.GetPositionInMap(field);
			int row = positionInMap.Row;
			int column = positionInMap.Column;
			global::Infragistics.Windows.DataPresenter.Cell cell = this.GetCell(currentCell.Record, row, column, navigationDirection, siblingNavigationStyle, false);
			if (cell != null)
			{
				return cell;
			}
			if (siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentAndWrap || siblingNavigationStyle == global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentNoWrap)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.PanelNavigationDirection recordNavigationDirection = navigationDirection;
			global::System.Windows.Controls.Orientation logicalOrientation = this._fieldLayoutTemplateGenerator.LogicalOrientation;
			if (this._fieldLayoutTemplateGenerator.HasLogicalOrientation)
			{
				recordNavigationDirection = this._fieldLayoutTemplateGenerator.GetRecordNavigationDirectionFromCellNavigationDirection(navigationDirection);
			}
			else
			{
				switch (navigationDirection)
				{
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Left:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
					recordNavigationDirection = global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous;
					break;
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
				case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
					recordNavigationDirection = global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next;
					break;
				}
			}
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = currentCell.Record;
			global::Infragistics.Windows.DataPresenter.Cell adjacentRecordTargetCell;
			for (;;)
			{
				dataRecord = this.GetAdjacentRecord(dataRecord, navigationDirection, panelNavigator, selectionHost, shiftKeyDown, ctlKeyDown, siblingNavigationStyle, recordNavigationDirection);
				if (dataRecord != null && dataRecord.IsEnabledResolved)
				{
					adjacentRecordTargetCell = this.GetAdjacentRecordTargetCell(dataRecord, row, column, navigationDirection, siblingNavigationStyle, logicalOrientation);
					if (adjacentRecordTargetCell != null)
					{
						break;
					}
				}
				if (dataRecord == null)
				{
					goto Block_8;
				}
			}
			return adjacentRecordTargetCell;
			Block_8:
			return null;
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x000A9138 File Offset: 0x000A7338
		internal global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition GetPositionInMap(global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (this._layoutInfo != null)
			{
				global::Infragistics.Windows.DataPresenter.FieldPosition? fieldPosition = this._layoutInfo.GetFieldPosition(field, this._layoutInfo._header);
				if (fieldPosition != null)
				{
					return new global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition
					{
						Column = fieldPosition.Value.Column,
						ColumnSpan = fieldPosition.Value.ColumnSpan,
						Row = fieldPosition.Value.Row,
						RowSpan = fieldPosition.Value.RowSpan
					};
				}
			}
			return field.GridPosition;
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x000A91D4 File Offset: 0x000A73D4
		private void Initialize()
		{
			this._fieldLayout.VerifyStyleGeneratorTemplates();
			int num;
			int num2;
			if (this._compressedFieldMap != null)
			{
				this._map = this._compressedFieldMap;
				num = this._map.GetLength(0);
				num2 = this._map.GetLength(1);
			}
			else
			{
				num = this._fieldLayout.TotalRowsGenerated;
				num2 = this._fieldLayout.TotalColumnsGenerated;
				this._map = new global::Infragistics.Windows.DataPresenter.Field[num, num2];
				foreach (global::Infragistics.Windows.DataPresenter.Field field in this._fieldLayout.Fields)
				{
					if (field.CellContentAlignmentResolved != global::Infragistics.Windows.DataPresenter.CellContentAlignment.LabelOnly && field.VisibilityResolved == global::System.Windows.Visibility.Visible && !field.IsExpandableResolved)
					{
						global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition gridPosition = field.GridPosition;
						int num3 = gridPosition.Row;
						while (num3 < gridPosition.Row + gridPosition.RowSpan && num3 < num)
						{
							int num4 = gridPosition.Column;
							while (num4 < gridPosition.Column + gridPosition.ColumnSpan && num4 < num2)
							{
								if (this._map[num3, num4] == null)
								{
									this._map[num3, num4] = field;
								}
								num4++;
							}
							num3++;
						}
					}
				}
			}
			this._maxSeqOffset = num2 * num - 1;
			while (this._maxSeqOffset > 0)
			{
				int num5 = this._maxSeqOffset / num2;
				int num6 = this._maxSeqOffset % num2;
				if (this._map[num5, num6] != null)
				{
					break;
				}
				this._maxSeqOffset--;
			}
			this._firstField = null;
			for (int i = 0; i <= this._maxSeqOffset; i++)
			{
				int num7 = i / num2;
				int num8 = i % num2;
				this._firstField = this._map[num7, num8];
				if (this._firstField != null)
				{
					break;
				}
			}
			this._lastField = null;
			for (int j = this._maxSeqOffset; j >= 0; j--)
			{
				int num9 = j / num2;
				int num10 = j % num2;
				this._lastField = this._map[num9, num10];
				if (this._lastField != null)
				{
					break;
				}
			}
			bool flag = true;
			global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field> list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.Field>();
			int k = 0;
			int num11 = flag ? num : num2;
			while (k < num11)
			{
				int l = 0;
				int num12 = flag ? num2 : num;
				while (l < num12)
				{
					int num13 = flag ? k : l;
					int num14 = flag ? l : k;
					global::Infragistics.Windows.DataPresenter.Field field2 = this._map[num13, num14];
					if (field2 != null && (num13 <= 0 || this._map[num13 - 1, num14] != field2) && (num14 <= 0 || this._map[num13, num14 - 1] != field2))
					{
						list.Add(field2);
					}
					l++;
				}
				k++;
			}
			this._navigationFields = list.ToArray();
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x000A94B0 File Offset: 0x000A76B0
		internal void ResetMap()
		{
			this._map = null;
			this._lastField = (this._firstField = null);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x000A94D4 File Offset: 0x000A76D4
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

		// Token: 0x060025F2 RID: 9714 RVA: 0x000A9614 File Offset: 0x000A7814
		private global::Infragistics.Windows.DataPresenter.DataRecord GetAdjacentRecord(global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.IViewPanel panelNavigator, global::Infragistics.Windows.Selection.ISelectionHost selectionHost, bool shiftKeyDown, bool ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection recordNavigationDirection)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord;
			if (shiftKeyDown && !record.DataPresenter.IsTreeView)
			{
				dataRecord = (panelNavigator.GetNavigationTargetRecord(record, recordNavigationDirection, selectionHost, shiftKeyDown, ctlKeyDown, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle.StayWithinParentNoWrap, typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord);
			}
			else
			{
				dataRecord = (panelNavigator.GetNavigationTargetRecord(record, recordNavigationDirection, selectionHost, shiftKeyDown, ctlKeyDown, siblingNavigationStyle, typeof(global::Infragistics.Windows.DataPresenter.DataRecord)) as global::Infragistics.Windows.DataPresenter.DataRecord);
			}
			if (dataRecord is global::Infragistics.Windows.DataPresenter.HeaderRecord)
			{
				return null;
			}
			return dataRecord;
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x000A9680 File Offset: 0x000A7880
		private global::Infragistics.Windows.DataPresenter.Cell GetAdjacentRecordTargetCell(global::Infragistics.Windows.DataPresenter.DataRecord adjacentRecord, int fromRow, int fromCol, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, global::System.Windows.Controls.Orientation logicalOrientation)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = adjacentRecord.FieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = fieldLayout.AlignmentFieldLayout;
			if (alignmentFieldLayout != null)
			{
				fieldLayout = alignmentFieldLayout;
			}
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
						fromRow = fieldLayout.TotalRowsGenerated - 1;
						fromCol = fieldLayout.TotalColumnsGenerated - 1;
					}
					else
					{
						fromCol = fieldLayout.TotalColumnsGenerated - 1;
					}
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Right:
				if (!styleGenerator.AreRecordsArrangedInRowsAndCols)
				{
					if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
					{
						fromRow = 0;
						fromCol = 0;
					}
					else
					{
						fromCol = 0;
					}
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Above:
				if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					fromRow = fieldLayout.TotalRowsGenerated - 1;
				}
				else
				{
					fromRow = fieldLayout.TotalRowsGenerated - 1;
					fromCol = fieldLayout.TotalColumnsGenerated - 1;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Below:
				if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					fromRow = 0;
				}
				else
				{
					fromRow = 0;
					fromCol = 0;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Next:
				if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					fromRow = 0;
					fromCol = 0;
				}
				else
				{
					fromRow = 0;
					fromCol = 0;
				}
				break;
			case global::Infragistics.Windows.DataPresenter.PanelNavigationDirection.Previous:
				if (logicalOrientation == global::System.Windows.Controls.Orientation.Vertical)
				{
					fromRow = fieldLayout.TotalRowsGenerated - 1;
					fromCol = fieldLayout.TotalColumnsGenerated - 1;
				}
				else
				{
					fromRow = fieldLayout.TotalRowsGenerated - 1;
					fromCol = fieldLayout.TotalColumnsGenerated - 1;
				}
				break;
			}
			return this.GetCell(adjacentRecord, fromRow, fromCol, navigationDirection, siblingNavigationStyle, true);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x000A97C0 File Offset: 0x000A79C0
		private global::Infragistics.Windows.DataPresenter.Cell GetCellInDirection(global::Infragistics.Windows.DataPresenter.Field[,] fields, int row, int column, global::Infragistics.Windows.DataPresenter.DataRecord record, global::Infragistics.Windows.DataPresenter.Field startingField, bool includeCurrent, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection direction, bool wrap)
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
				if (field != null)
				{
					if (field.Owner != record.FieldLayout)
					{
						field = record.FieldLayout.GetFieldFromMappedField(field);
						if (field == null)
						{
							goto IL_16A;
						}
					}
					if (!record.ShouldCollapseCell(field))
					{
						if (!record.ShouldCollapseEmptyCellsResolved)
						{
							global::Infragistics.Windows.DataPresenter.Field.FieldGridPosition positionInMap = this.GetPositionInMap(field);
							if ((flag && positionInMap.Row != num6) || (!flag && positionInMap.Column != num7))
							{
								goto IL_16A;
							}
						}
						cell = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetNavigationCell(startingField, record, includeCurrent, field);
						if (cell != null)
						{
							break;
						}
					}
				}
				IL_16A:;
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
					cell = this.GetCellInDirection(array, row, column, record, startingField, includeCurrent, direction, wrap);
				}
			}
			return cell;
		}

		// Token: 0x060025F5 RID: 9717 RVA: 0x000A99DC File Offset: 0x000A7BDC
		private global::Infragistics.Windows.DataPresenter.Cell GetCell(global::Infragistics.Windows.DataPresenter.DataRecord record, int row, int column, global::Infragistics.Windows.DataPresenter.PanelNavigationDirection navigationDirection, global::Infragistics.Windows.DataPresenter.PanelSiblingNavigationStyle siblingNavigationStyle, bool includeCurrent)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = record.FieldLayout;
			global::Infragistics.Windows.DataPresenter.FieldLayout alignmentFieldLayout = fieldLayout.AlignmentFieldLayout;
			if (alignmentFieldLayout != null)
			{
				fieldLayout = alignmentFieldLayout;
			}
			global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator styleGenerator = fieldLayout.StyleGenerator;
			global::Infragistics.Windows.DataPresenter.GridFieldMap gridFieldMap;
			if (fieldLayout.UseCellPresenters)
			{
				gridFieldMap = styleGenerator.GridFieldMap;
			}
			else
			{
				gridFieldMap = fieldLayout.TemplateDataRecordCache.CellFieldMap;
			}
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
				return this.GetCellInDirection(gridFieldMap.Map, row, column, record, startingField, includeCurrent, navigationDirection, flag);
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

		// Token: 0x060025F6 RID: 9718 RVA: 0x000A9B1C File Offset: 0x000A7D1C
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

		// Token: 0x060025F7 RID: 9719 RVA: 0x000A9B6C File Offset: 0x000A7D6C
		private static global::Infragistics.Windows.DataPresenter.Cell GetNavigationCell(global::Infragistics.Windows.DataPresenter.Field startingField, global::Infragistics.Windows.DataPresenter.DataRecord record, bool includeCurrent, global::Infragistics.Windows.DataPresenter.Field field)
		{
			if (field == null)
			{
				return null;
			}
			if (!includeCurrent)
			{
				if (field == startingField)
				{
					return null;
				}
				if (field.Owner != startingField.Owner && field.MappedTreeField == startingField)
				{
					return null;
				}
			}
			if (!record.IsCellTabStop(field, null))
			{
				return null;
			}
			return record.Cells[field];
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x000A9BB8 File Offset: 0x000A7DB8
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
			int navigationIndex = map.GetNavigationIndex(startingField);
			global::Infragistics.Windows.DataPresenter.Cell nextPreviousCellHelper = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetNextPreviousCellHelper(startingField, record, includeCurrent, navigationFields, next, navigationIndex, next ? (num - navigationIndex) : (navigationIndex + 1));
			if (nextPreviousCellHelper == null && wrap)
			{
				nextPreviousCellHelper = global::Infragistics.Windows.DataPresenter.GridFieldMap.GetNextPreviousCellHelper(startingField, record, includeCurrent, navigationFields, next, next ? 0 : (num - 1), next ? (navigationIndex - 1) : (num - navigationIndex));
			}
			return nextPreviousCellHelper;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x000A9C44 File Offset: 0x000A7E44
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

		// Token: 0x060025FA RID: 9722 RVA: 0x000A9C96 File Offset: 0x000A7E96
		private void VerifyInitialized()
		{
			if (this._map == null)
			{
				this.Initialize();
			}
		}

		// Token: 0x040012E0 RID: 4832
		private global::Infragistics.Windows.DataPresenter.Field[,] _map;

		// Token: 0x040012E1 RID: 4833
		private global::Infragistics.Windows.DataPresenter.Field[,] _compressedFieldMap;

		// Token: 0x040012E2 RID: 4834
		private global::Infragistics.Windows.DataPresenter.Internal.ExportLayoutInformation _layoutInfo;

		// Token: 0x040012E3 RID: 4835
		private global::Infragistics.Windows.DataPresenter.FieldLayoutTemplateGenerator _fieldLayoutTemplateGenerator;

		// Token: 0x040012E4 RID: 4836
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x040012E5 RID: 4837
		private int _maxSeqOffset;

		// Token: 0x040012E6 RID: 4838
		private global::Infragistics.Windows.DataPresenter.Field _firstField;

		// Token: 0x040012E7 RID: 4839
		private global::Infragistics.Windows.DataPresenter.Field _lastField;

		// Token: 0x040012E8 RID: 4840
		private global::Infragistics.Windows.DataPresenter.Field[] _navigationFields;

		// Token: 0x040012E9 RID: 4841
		private bool _isCompressedLabelMap;
	}
}
