using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000214 RID: 532
	public class HeaderCell : global::Infragistics.Controls.Grids.CellBase
	{
		// Token: 0x06000F1B RID: 3867 RVA: 0x0003967D File Offset: 0x0003787D
		protected internal HeaderCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000F1C RID: 3868 RVA: 0x00039687 File Offset: 0x00037887
		protected override global::System.Windows.Style ResolveStyle
		{
			get
			{
				if (this.Style == null)
				{
					return base.Column.HeaderStyleResolved;
				}
				return this.Style;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000F1D RID: 3869 RVA: 0x000396A3 File Offset: 0x000378A3
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x000396A8 File Offset: 0x000378A8
		protected override string RecyclingIdentifier
		{
			get
			{
				global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Column.ColumnLayout;
				if (columnLayout.Grid != null && columnLayout.Grid.Panel != null && ((columnLayout.Grid.CellControlGenerationModeInternal == global::Infragistics.Controls.Grids.CellControlGenerationMode.Recycle && !columnLayout.Grid.IsCellControlGenerationModeJustChanged) || (columnLayout.Grid.CellControlGenerationMode == global::Infragistics.Controls.Grids.CellControlGenerationMode.Virtualize && columnLayout.Grid.IsCellControlGenerationModeJustChanged)))
				{
					return string.Concat(new string[]
					{
						base.Row.RowType.ToString(),
						"_",
						base.Column.TypeName,
						"_",
						base.Column.ColumnLayout.Key
					});
				}
				return string.Concat(new string[]
				{
					base.Row.RowType.ToString(),
					"_",
					base.Column.Key,
					"_",
					base.Column.ColumnLayout.Key
				});
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000397BE File Offset: 0x000379BE
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.HeaderCellControl();
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x000397C8 File Offset: 0x000379C8
		protected internal override void EnsureCurrentState()
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = base.Row.ColumnLayout;
			if (columnLayout == null)
			{
				return;
			}
			base.EnsureCurrentState();
			if (base.Control != null)
			{
				global::Infragistics.Controls.Grids.CellBase activeCell = columnLayout.Grid.ActiveCell;
				if (activeCell != null && base.Column == activeCell.Column)
				{
					base.Control.GoToState("Active", false);
				}
				else
				{
					base.Control.GoToState("InActive", false);
				}
				global::Infragistics.Controls.Grids.Column column = base.Column;
				if (column != null)
				{
					bool flag = columnLayout.Columns.Contains(column);
					if (!flag)
					{
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> allColumns = columnLayout.Columns.AllColumns;
						flag = allColumns.Contains(column);
					}
					if (column.IsSelected)
					{
						base.Control.GoToState("Selected", false);
					}
					else
					{
						base.Control.GoToState("NotSelected", false);
					}
					global::Infragistics.Controls.Grids.FixedColumnType allowFixedColumnsResolved = columnLayout.FixedColumnSettings.AllowFixedColumnsResolved;
					bool flag2 = column.IsFixed != global::Infragistics.Controls.Grids.FixedState.NotFixed;
					bool flag3 = columnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells && column.IsGroupBy;
					if (allowFixedColumnsResolved != global::Infragistics.Controls.Grids.FixedColumnType.Disabled && !flag3)
					{
						bool flag4 = allowFixedColumnsResolved == global::Infragistics.Controls.Grids.FixedColumnType.Both || allowFixedColumnsResolved == global::Infragistics.Controls.Grids.FixedColumnType.Indicator;
						if (flag)
						{
							if (column.IsFixable && flag4)
							{
								if (flag2)
								{
									base.Control.GoToState("Pinned", false);
								}
								else
								{
									base.Control.GoToState("Unpinned", false);
								}
							}
							else
							{
								base.Control.GoToState("NotFixable", false);
							}
						}
					}
					else
					{
						base.Control.GoToState("NotFixable", false);
					}
					if (flag2)
					{
						base.Control.GoToState("Fixed", false);
					}
					else
					{
						base.Control.GoToState("Unfixed", false);
					}
					global::Infragistics.Controls.Grids.SortingSettingsOverride sortingSettings = columnLayout.SortingSettings;
					if (flag)
					{
						if (sortingSettings.ShowSortIndicatorResolved)
						{
							if (column.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Ascending)
							{
								base.Control.GoToState("Ascending", false);
							}
							else if (column.IsSorted == global::Infragistics.Controls.Grids.SortDirection.Descending)
							{
								base.Control.GoToState("Descending", false);
							}
							else
							{
								base.Control.GoToState("NotSorted", false);
							}
						}
						else
						{
							base.Control.GoToState("NotSorted", false);
						}
					}
					global::Infragistics.Controls.Grids.SummaryRowSettingsOverride summaryRowSettings = columnLayout.SummaryRowSettings;
					if (flag)
					{
						bool isSummable = column.IsSummable;
						if (summaryRowSettings.AllowSummaryRowResolved != global::Infragistics.Controls.Grids.SummaryRowLocation.None && isSummable)
						{
							base.Control.GoToState("Summable", false);
						}
						else
						{
							base.Control.GoToState("Unsummable", false);
						}
					}
					else
					{
						base.Control.GoToState("Unsummable", false);
					}
					if (flag)
					{
						if (columnLayout.FilteringSettings.AllowFilteringResolved == global::Infragistics.Controls.Grids.FilterUIType.FilterMenu && column.IsFilterable)
						{
							base.Control.GoToState("FilterIcon", false);
						}
						else
						{
							base.Control.GoToState("NoIcon", false);
						}
					}
					else
					{
						base.Control.GoToState("NoIcon", false);
					}
					if (flag)
					{
						global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)base.Row.Manager;
						global::Infragistics.Controls.Grids.RowsFilter rowsFilter = rowsManager.RowFiltersCollectionResolved[base.Column.Key];
						if (rowsFilter == null || rowsFilter.Conditions.Count == 0)
						{
							base.Control.GoToState("NotFiltered", false);
						}
						else
						{
							base.Control.GoToState("Filtered", false);
						}
					}
					else
					{
						base.Control.GoToState("NotFiltered", false);
					}
					if (column.IsHideable && columnLayout.ColumnChooserSettings.AllowHideColumnIconResolved)
					{
						base.Control.GoToState("VisibilityIconVisible", false);
					}
					else
					{
						base.Control.GoToState("VisibilityIconHidden", false);
					}
					if (columnLayout.ColumnChooserSettings.AllowHiddenColumnIndicatorResolved)
					{
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(columnLayout.Columns.DataColumns);
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(columnLayout.Columns.VisibleColumns);
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list3 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
						int num = 2;
						if (column.ParentColumn != null)
						{
							list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(column.ParentColumn.ResolveChildColumns());
							global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list4 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
							foreach (global::Infragistics.Controls.Grids.Column column2 in list)
							{
								if (column2.Visibility == global::System.Windows.Visibility.Visible)
								{
									list4.Add(column2);
								}
							}
							list2 = list4;
							num = 1;
						}
						else if (columnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
						{
							global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = columnLayout.Grid.GroupBySettings.GroupByColumns[columnLayout];
							int count = readOnlyCollection.Count;
							for (int i = count - 1; i >= 0; i--)
							{
								global::Infragistics.Controls.Grids.Column column3 = readOnlyCollection[i];
								if (list.Contains(column3))
								{
									list.Remove(column3);
									list.Insert(0, column3);
								}
								if (list2.Contains(column3))
								{
									list2.Remove(column3);
									list2.Insert(0, column3);
								}
								if (column3.Visibility == global::System.Windows.Visibility.Visible)
								{
									list3.Add(column3);
								}
							}
						}
						this.ColumnsHiddenToLeft.Reset();
						this.ColumnsHiddenToRight.Reset();
						int num2 = list.IndexOf(column);
						if (column is global::Infragistics.Controls.Grids.Primitives.FillerColumn && list2.Count == 1)
						{
							bool flag5 = true;
							foreach (global::Infragistics.Controls.Grids.Column column4 in list)
							{
								if (column4.Visibility == global::System.Windows.Visibility.Visible)
								{
									flag5 = false;
									break;
								}
							}
							if (flag5)
							{
								num2 = list.Count;
							}
						}
						for (int j = num2 - 1; j >= 0; j--)
						{
							global::Infragistics.Controls.Grids.Column column5 = list[j];
							if (column5.Visibility != global::System.Windows.Visibility.Collapsed)
							{
								break;
							}
							this.ColumnsHiddenToLeft.Add(column5);
						}
						int num3 = list2.IndexOf(column);
						int num4 = list2.Count - num;
						if (num3 == num4)
						{
							bool flag6 = true;
							if (num3 == -1)
							{
								global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsLeft = columnLayout.FixedColumnSettings.FixedColumnsLeft;
								global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsRight = columnLayout.FixedColumnSettings.FixedColumnsRight;
								global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list5 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(fixedColumnsLeft);
								global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list6 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(fixedColumnsRight);
								list5.InsertRange(0, list3);
								for (int k = 0; k < fixedColumnsLeft.Count; k++)
								{
									global::Infragistics.Controls.Grids.Column column6 = fixedColumnsLeft[k];
									if (column6.Visibility == global::System.Windows.Visibility.Collapsed)
									{
										list5.Remove(column6);
									}
								}
								for (int l = 0; l < fixedColumnsRight.Count; l++)
								{
									global::Infragistics.Controls.Grids.Column column7 = fixedColumnsRight[l];
									if (column7.Visibility == global::System.Windows.Visibility.Collapsed)
									{
										list6.Remove(column7);
									}
								}
								int num5 = list6.IndexOf(column);
								int num6 = list5.IndexOf(column);
								flag6 = ((num5 != -1 && num5 == list6.Count - 1) || (num6 != -1 && list6.Count == 0 && num6 == list5.Count - 1));
							}
							if (flag6)
							{
								global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list7 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
								for (int m = num2 + 1; m < list.Count; m++)
								{
									global::Infragistics.Controls.Grids.Column column8 = list[m];
									if (column8.Visibility == global::System.Windows.Visibility.Collapsed)
									{
										list7.Add(column8);
									}
									else
									{
										list7.Clear();
									}
								}
								foreach (global::Infragistics.Controls.Grids.Column item in list7)
								{
									this.ColumnsHiddenToRight.Add(item);
								}
							}
						}
						if (this.ColumnsHiddenToLeft.Count > 0)
						{
							base.Control.GoToState("HiddenLeftAdjacentColumns", false);
						}
						else
						{
							base.Control.GoToState("NoHiddenLeftAdjacentColumns", false);
							this.ColumnsHiddenToLeft.Clear();
						}
						if (this.ColumnsHiddenToRight.Count > 0)
						{
							base.Control.GoToState("LastVisibleColumnWithHiddenRightAdjacentColumns", false);
							return;
						}
						base.Control.GoToState("NoHiddenRightAdjacentColumns", false);
						this.ColumnsHiddenToRight.Clear();
						return;
					}
					else
					{
						base.Control.GoToState("NoHiddenLeftAdjacentColumns", false);
						base.Control.GoToState("NoHiddenRightAdjacentColumns", false);
					}
				}
			}
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00039FB4 File Offset: 0x000381B4
		protected internal override void OnCellDoubleClick()
		{
			if (base.Control != null && base.Column.ColumnLayout != null)
			{
				global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettings = base.Column.ColumnLayout.ColumnResizingSettings;
				if (base.Control.AllowUserResizing && columnResizingSettings.AllowDoubleClickToSizeResolved)
				{
					global::Infragistics.Controls.Grids.Column resizeColumnResolved = base.Column.ResizeColumnResolved;
					resizeColumnResolved.IsInitialAutoSet = false;
					resizeColumnResolved.Width = new global::Infragistics.Controls.Grids.ColumnWidth?(global::Infragistics.Controls.Grids.ColumnWidth.Auto);
					resizeColumnResolved.Width = new global::Infragistics.Controls.Grids.ColumnWidth?(global::Infragistics.Controls.Grids.ColumnWidth.InitialAuto);
					for (global::Infragistics.Controls.Grids.Column parentColumn = resizeColumnResolved.ParentColumn; parentColumn != null; parentColumn = parentColumn.ParentColumn)
					{
						parentColumn.Width = new global::Infragistics.Controls.Grids.ColumnWidth?(global::Infragistics.Controls.Grids.ColumnWidth.InitialAuto);
					}
					if (columnResizingSettings.AllowMultipleColumnResizeResolved)
					{
						global::Infragistics.Controls.Grids.SelectedColumnsCollection selectedColumns = base.Column.ColumnLayout.Grid.SelectionSettings.SelectedColumns;
						if (selectedColumns.Contains(base.Column))
						{
							foreach (global::Infragistics.Controls.Grids.Column column in selectedColumns)
							{
								global::Infragistics.Controls.Grids.Column resizeColumnResolved2 = column.ResizeColumnResolved;
								resizeColumnResolved2.Width = new global::Infragistics.Controls.Grids.ColumnWidth?(global::Infragistics.Controls.Grids.ColumnWidth.Auto);
								resizeColumnResolved2.Width = new global::Infragistics.Controls.Grids.ColumnWidth?(global::Infragistics.Controls.Grids.ColumnWidth.InitialAuto);
								for (global::Infragistics.Controls.Grids.Column parentColumn = column.ParentColumn; parentColumn != null; parentColumn = parentColumn.ParentColumn)
								{
									parentColumn.Width = new global::Infragistics.Controls.Grids.ColumnWidth?(global::Infragistics.Controls.Grids.ColumnWidth.InitialAuto);
								}
							}
						}
					}
					base.Control.IsResizing = false;
					base.Control.EndDragResize(true);
					return;
				}
				base.OnCellDoubleClick();
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x0003A13C File Offset: 0x0003833C
		public global::Infragistics.Controls.Grids.Primitives.HiddenColumnsCollection ColumnsHiddenToLeft
		{
			get
			{
				if (this._columnsHiddenToLeft == null)
				{
					this._columnsHiddenToLeft = new global::Infragistics.Controls.Grids.Primitives.HiddenColumnsCollection();
				}
				return this._columnsHiddenToLeft;
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x0003A157 File Offset: 0x00038357
		public global::Infragistics.Controls.Grids.Primitives.HiddenColumnsCollection ColumnsHiddenToRight
		{
			get
			{
				if (this._columnsHiddenToRight == null)
				{
					this._columnsHiddenToRight = new global::Infragistics.Controls.Grids.Primitives.HiddenColumnsCollection();
				}
				return this._columnsHiddenToRight;
			}
		}

		// Token: 0x040004D9 RID: 1241
		private global::Infragistics.Controls.Grids.Primitives.HiddenColumnsCollection _columnsHiddenToLeft;

		// Token: 0x040004DA RID: 1242
		private global::Infragistics.Controls.Grids.Primitives.HiddenColumnsCollection _columnsHiddenToRight;
	}
}
