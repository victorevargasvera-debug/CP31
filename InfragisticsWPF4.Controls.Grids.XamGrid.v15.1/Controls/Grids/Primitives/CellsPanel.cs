using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.AutomationPeers;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000008 RID: 8
	public class CellsPanel : global::System.Windows.Controls.Panel, global::Infragistics.ICommandTarget
	{
		// Token: 0x06000072 RID: 114 RVA: 0x000036D8 File Offset: 0x000018D8
		public CellsPanel()
		{
			this._visibleCells = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			this._visibleFixedLeftCells = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			this._visibleFixedRightCells = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			this._additionalCells = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			this._clipRG = new global::System.Windows.Media.RectangleGeometry();
			base.Clip = this._clipRG;
			this._lastCellsDetached = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			this._nonReleasedCells = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			this._isInDesigner = global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(this);
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003799 File Offset: 0x00001999
		public global::Infragistics.Controls.Grids.RowBase Row
		{
			get
			{
				return this._row;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000037A1 File Offset: 0x000019A1
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000037A9 File Offset: 0x000019A9
		public global::Infragistics.Controls.Grids.Primitives.RowsPanel Owner
		{
			get
			{
				return this._owner;
			}
			set
			{
				this._owner = value;
				if (value != null)
				{
					this._scrollInfo = this._owner.Grid;
					return;
				}
				this._scrollInfo = null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000037CE File Offset: 0x000019CE
		protected internal global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> VisibleCells
		{
			get
			{
				return this._visibleCells;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000077 RID: 119 RVA: 0x000037D6 File Offset: 0x000019D6
		protected internal global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> VisibleFixedLeftCells
		{
			get
			{
				return this._visibleFixedLeftCells;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000037DE File Offset: 0x000019DE
		protected internal global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> VisibleFixedRightCells
		{
			get
			{
				return this._visibleFixedRightCells;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000079 RID: 121 RVA: 0x000037E6 File Offset: 0x000019E6
		// (set) Token: 0x0600007A RID: 122 RVA: 0x000037EE File Offset: 0x000019EE
		internal double PreviousInvalidateHeight { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600007B RID: 123 RVA: 0x000037F7 File Offset: 0x000019F7
		// (set) Token: 0x0600007C RID: 124 RVA: 0x000037FF File Offset: 0x000019FF
		internal bool ArrangeRaised { get; set; }

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003808 File Offset: 0x00001A08
		internal global::System.Windows.Media.RectangleGeometry ClipRect
		{
			get
			{
				return this._clipRG;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00003810 File Offset: 0x00001A10
		protected internal virtual void OnAttached(global::Infragistics.Controls.Grids.RowBase row)
		{
			row.SkipApplyStyle = true;
			this._row = row;
			base.DataContext = this._row.Data;
			row.SkipApplyStyle = false;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00003838 File Offset: 0x00001A38
		protected internal virtual void OnReleased()
		{
			global::Infragistics.Controls.Grids.RowBase row = this._row;
			row.IsReleasingCells = true;
			this._row = null;
			base.DataContext = null;
			foreach (global::Infragistics.Controls.Grids.CellBase cell in this._visibleFixedLeftCells)
			{
				this.ReleaseCell(cell);
			}
			foreach (global::Infragistics.Controls.Grids.CellBase cell2 in this._visibleCells)
			{
				this.ReleaseCell(cell2);
			}
			foreach (global::Infragistics.Controls.Grids.CellBase cell3 in this._visibleFixedRightCells)
			{
				this.ReleaseCell(cell3);
			}
			foreach (global::Infragistics.Controls.Grids.CellBase cell4 in this._additionalCells)
			{
				this.ReleaseCell(cell4);
			}
			this._additionalCells.Clear();
			this._visibleCells.Clear();
			this._visibleFixedLeftCells.Clear();
			this._visibleFixedRightCells.Clear();
			this._lastCellsDetached.Clear();
			row.IsReleasingCells = false;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000039B8 File Offset: 0x00001BB8
		private global::System.Windows.Size RenderCellsComplex(double availableWidth)
		{
			bool flag = double.IsPositiveInfinity(availableWidth);
			double height = 0.0;
			global::Infragistics.Controls.Grids.RowsManagerBase manager = this.Row.Manager;
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = this.Row.Columns.VisibleColumns;
			bool flag2 = readOnlyCollection.Any((global::Infragistics.Controls.Grids.Column i) => i is global::Infragistics.Controls.Grids.Primitives.FillerColumn);
			if (flag && !flag2)
			{
				readOnlyCollection = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column>(new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(readOnlyCollection)
				{
					this.Row.Columns.FillerColumn
				});
				flag2 = true;
			}
			int num = readOnlyCollection.Count;
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			double num2 = manager.IsFirstRowRenderingInThisLayoutCycle ? manager.ResolveIndentation(this.Row) : manager.CachedIndentation;
			manager.CachedIndentation = num2;
			double num3 = num2;
			double num4 = 0.0;
			if (!flag2)
			{
				this.Row.Columns.FillerColumn.ActualWidth = 0.0;
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> fixedAdornerColumns = this.Row.Columns.FixedAdornerColumns;
			foreach (global::Infragistics.Controls.Grids.Column column in fixedAdornerColumns)
			{
				if (num3 >= availableWidth)
				{
					break;
				}
				num3 += this.RenderCell(column, starColumns, ref height, false, this.VisibleFixedLeftCells, flag);
			}
			bool flag3 = false;
			if (this.Row.ColumnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection2 = this.Row.Columns.GroupByColumns[this.Row.ColumnLayout];
				foreach (global::Infragistics.Controls.Grids.Column column2 in readOnlyCollection2)
				{
					if (column2.Visibility == global::System.Windows.Visibility.Visible)
					{
						flag3 = true;
						if (num3 >= availableWidth)
						{
							break;
						}
						num3 += this.RenderCell(column2, starColumns, ref height, false, this.VisibleFixedLeftCells, flag);
					}
				}
			}
			global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsCollection = this.Row.Columns.FixedColumnsLeft;
			if (fixedColumnsCollection.Count > 0)
			{
				foreach (global::Infragistics.Controls.Grids.Column column3 in fixedColumnsCollection)
				{
					if (column3.Visibility == global::System.Windows.Visibility.Visible)
					{
						flag3 = true;
						if (num3 >= availableWidth)
						{
							break;
						}
						num3 += this.RenderCell(column3, starColumns, ref height, false, this.VisibleFixedLeftCells, flag);
					}
				}
			}
			if (flag3)
			{
				this.Row.Columns.FixedBorderColumnLeft.ActualWidth = 0.0;
				num3 += this.RenderCell(this.Row.Columns.FixedBorderColumnLeft, starColumns, ref height, false, this._additionalCells, flag);
				flag3 = false;
			}
			fixedColumnsCollection = this.Row.Columns.FixedColumnsRight;
			if (fixedColumnsCollection.Count > 0)
			{
				foreach (global::Infragistics.Controls.Grids.Column column4 in fixedColumnsCollection)
				{
					if (column4.Visibility == global::System.Windows.Visibility.Visible)
					{
						flag3 = true;
						if (num3 >= availableWidth)
						{
							break;
						}
						num3 += this.RenderCell(column4, starColumns, ref height, false, this.VisibleFixedRightCells, flag);
					}
				}
				if (flag3)
				{
					this.Row.Columns.FixedBorderColumnRight.ActualWidth = 0.0;
					num3 += this.RenderCell(this.Row.Columns.FixedBorderColumnRight, starColumns, ref height, false, this._additionalCells, flag);
				}
			}
			num4 = num3 - num2;
			int num5 = 0;
			double num6 = 0.0;
			double num7 = this.ResolveScrollLeft();
			if (num7 == -1.0)
			{
				if (this.Row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
				{
					this.InvalidateHorizontalMax(availableWidth - (num4 + num2), ref height, flag, false);
					num7 = this.ResolveScrollLeft();
					this.Owner.MeasureCalled = false;
					this.Owner.InvalidateMeasureInternal();
				}
				else
				{
					this.InvalidateHorizontalMax(availableWidth - (num4 + num2), ref height, flag, false);
					num7 = this.ResolveScrollLeft();
					if (num7 != 0.0)
					{
						manager.InvalidateOverrideHorizontalMax = true;
					}
				}
			}
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = this.Row.Columns.AllVisibleChildColumns;
			if (!this.Owner.ReverseCellMeasure)
			{
				int num8 = global::System.Math.Max(0, (int)num7);
				global::Infragistics.Controls.Grids.Column column5 = null;
				if (num8 < allVisibleChildColumns.Count)
				{
					column5 = allVisibleChildColumns[num8];
					global::Infragistics.Controls.Grids.Column column6 = column5.ResolveRootColumn();
					if (column6 != null && readOnlyCollection.Contains(column6))
					{
						int num9 = readOnlyCollection.IndexOf(column6);
						num5 = num9;
					}
					else
					{
						num5 = readOnlyCollection.IndexOf(column5);
					}
				}
				num5 = ((num5 < 0) ? 0 : num5);
				if (num5 < readOnlyCollection.Count)
				{
					global::Infragistics.Controls.Grids.Column column7 = readOnlyCollection[num5];
					double num10 = this.RenderCell(column7, starColumns, ref height, false, this.VisibleCells, flag);
					num3 += num10;
					double num11 = num7 - (double)((int)num7);
					global::Infragistics.Controls.Grids.GroupColumn groupColumn = column7 as global::Infragistics.Controls.Grids.GroupColumn;
					if (groupColumn != null)
					{
						num6 = 0.0;
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns2 = groupColumn.AllVisibleChildColumns;
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.Column> enumerator = allVisibleChildColumns2.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::Infragistics.Controls.Grids.Column column8 = enumerator.Current;
								if (column8 == column5)
								{
									num6 += column5.ActualWidth * num11;
									break;
								}
								num6 += column8.ActualWidth;
							}
							goto IL_532;
						}
					}
					num6 = num10 * num11;
					IL_532:
					num3 -= num6;
					int m = num5 + 1;
					while (m < num && num3 < availableWidth)
					{
						global::Infragistics.Controls.Grids.Column column9 = readOnlyCollection[m];
						double num12 = this.RenderCell(column9, starColumns, ref height, false, this.VisibleCells, flag);
						num3 += num12;
						m++;
					}
					num3 += num6;
				}
				num5--;
				num3 = this.SetupStarCells(availableWidth, num3, ref height, starColumns);
			}
			else
			{
				num5 = this.Owner.ReverCellStartIndex;
				int count = this.Row.VisibleCells.Count;
				int count2 = readOnlyCollection.Count;
				if (num5 >= count)
				{
					num5 = count - 1;
				}
				if (num5 >= count2)
				{
					num5 = count2 - 1;
				}
			}
			if (num3 < availableWidth && this._visibleCells.Count < num)
			{
				int m = num5;
				while (m >= 0)
				{
					global::Infragistics.Controls.Grids.Column column10 = readOnlyCollection[m];
					if (column10 is global::Infragistics.Controls.Grids.Primitives.FillerColumn)
					{
						num5--;
					}
					double num10 = this.RenderCell(column10, starColumns, ref height, true, this.VisibleCells, flag);
					num3 += num10;
					if (num3 >= availableWidth)
					{
						if (!this.Owner.ReverseCellMeasure)
						{
							break;
						}
						if (manager.OverflowAdjustment == 0.0)
						{
							manager.OverflowAdjustment = num3 - availableWidth;
						}
						else
						{
							manager.OverflowAdjustment = global::System.Math.Min(manager.OverflowAdjustment, num3 - availableWidth);
						}
						num6 = manager.OverflowAdjustment / num10;
						if (m == num5)
						{
							num6 = 0.0;
						}
						if (this.Row.ColumnLayout != this.Owner.ReverseColumnLayout)
						{
							break;
						}
						this.InvalidateHorizontalMax(availableWidth - (num4 + num2), ref height, flag, false);
						if (this.Owner.ReverseChildColumn != null && this.Owner.ReverseChildColumn.ParentColumn != null && num5 == this.Owner.ReverCellStartIndex)
						{
							if (double.IsPositiveInfinity(availableWidth))
							{
								break;
							}
							int num13 = allVisibleChildColumns.IndexOf(this.Owner.ReverseChildColumn);
							global::Infragistics.Controls.Grids.CellBase cellBase = this.Row.Cells[this.Owner.ReverseChildColumn];
							global::Infragistics.Controls.Grids.Column column11 = null;
							int num14 = -1;
							double actualWidth = cellBase.Column.ActualWidth;
							double num15 = availableWidth - actualWidth - num4;
							double num16 = 0.0;
							for (int j = num13 - 1; j >= 0; j--)
							{
								column11 = allVisibleChildColumns[j];
								num14 = j;
								if (column11.ActualWidth >= num15)
								{
									num16 = (column11.ActualWidth - num15) / column11.ActualWidth;
									break;
								}
								num15 -= column11.ActualWidth;
							}
							if (column11 != null)
							{
								this.SetScrollLeft((double)num14 + num16);
								break;
							}
							break;
						}
						else
						{
							global::Infragistics.Controls.Grids.GroupColumn groupColumn2 = column10 as global::Infragistics.Controls.Grids.GroupColumn;
							if (groupColumn2 != null)
							{
								global::Infragistics.Controls.Grids.Primitives.CellsPanel.ChildColumnInfo childColumnInfo = this.ResolveChildColumnInfo(groupColumn2, num6);
								this.SetScrollLeft((double)allVisibleChildColumns.IndexOf(childColumnInfo.ChildColumn) + childColumnInfo.ChildColumnScrollPercentage);
								break;
							}
							this.SetScrollLeft((double)allVisibleChildColumns.IndexOf(column10) + num6);
							break;
						}
					}
					else
					{
						m--;
					}
				}
			}
			if (this.Owner.ReverseCellMeasure)
			{
				num3 = this.SetupStarCells(availableWidth, num3, ref height, starColumns);
				if (this.Row.IsHorizontallyAlignedBy && num3 >= availableWidth)
				{
					if (!this.ArrangeRaised && this.Row.ShouldInvalidateHorizontalScroll)
					{
						this.Row.Manager.OverrideHorizontalMax = -1.0;
						this.InvalidateHorizontalMax(availableWidth - (num4 + num2), ref height, flag, true);
					}
					if (this.Owner.ReverseChildColumn != null && this.Owner.ReverseChildColumn.ParentColumn != null && num5 == this.Owner.ReverCellStartIndex)
					{
						if (!double.IsPositiveInfinity(availableWidth))
						{
							int num17 = allVisibleChildColumns.IndexOf(this.Owner.ReverseChildColumn);
							global::Infragistics.Controls.Grids.CellBase cellBase2 = this.Row.Cells[this.Owner.ReverseChildColumn];
							global::Infragistics.Controls.Grids.Column column12 = null;
							int num18 = -1;
							double actualWidth2 = cellBase2.Column.ActualWidth;
							double num19 = availableWidth - actualWidth2 - num4;
							double num20 = 0.0;
							for (int k = num17 - 1; k >= 0; k--)
							{
								column12 = allVisibleChildColumns[k];
								num18 = k;
								if (column12.ActualWidth >= num19)
								{
									num20 = 1.0 - (column12.ActualWidth - num19) / column12.ActualWidth;
									break;
								}
								num19 -= column12.ActualWidth;
							}
							if (column12 != null)
							{
								this.SetScrollLeft((double)num18 + num20);
							}
						}
					}
					else
					{
						global::Infragistics.Controls.Grids.CellBase cellBase3 = this.Row.VisibleCells[num5];
						global::Infragistics.Controls.Grids.Column column13 = null;
						int num21 = -1;
						double actualWidth3 = cellBase3.Column.ActualWidth;
						double num22 = availableWidth - actualWidth3 - num4 - num2;
						double num23 = 0.0;
						for (int l = num5 - 1; l >= 0; l--)
						{
							column13 = allVisibleChildColumns[l];
							num21 = l;
							if (column13.ActualWidth >= num22)
							{
								num23 = (column13.ActualWidth - num22) / column13.ActualWidth;
								break;
							}
							num22 -= column13.ActualWidth;
						}
						if (column13 != null)
						{
							global::Infragistics.Controls.Grids.GroupColumn groupColumn3 = cellBase3.Column as global::Infragistics.Controls.Grids.GroupColumn;
							if (groupColumn3 != null)
							{
								global::Infragistics.Controls.Grids.Primitives.CellsPanel.ChildColumnInfo childColumnInfo2 = this.ResolveChildColumnInfo(groupColumn3, num23);
								this.SetScrollLeft((double)num21 + childColumnInfo2.ChildColumnScrollPercentage);
							}
							else
							{
								this.SetScrollLeft((double)num21 + num23);
							}
						}
					}
				}
				if (num3 < availableWidth && readOnlyCollection.Contains(this.Row.Columns.FillerColumn))
				{
					this.RenderCell(this.Row.Columns.FillerColumn, starColumns, ref height, false, this.VisibleCells, flag);
				}
			}
			double num24 = availableWidth - (num4 + num2);
			if (this._prevAvailableWidth != num24 || this.Row.Manager.OverrideHorizontalMax == -1.0)
			{
				this.InvalidateHorizontalMax(num24, ref height, flag, true);
			}
			manager.OverflowAdjustment = global::System.Math.Max(manager.OverflowAdjustment, num3 - availableWidth);
			if (flag)
			{
				num--;
			}
			manager.ScrollableCellCount = num;
			manager.VisibleCellCount = this._visibleCells.Count;
			manager.CurrentVisibleWidth = num3 - num2 - num4;
			manager.IndexOfFirstColumnRendered = num5 + 1;
			manager.TotalColumnsRendered = this.VisibleCells.Count;
			manager.RowWidth = num3;
			return new global::System.Windows.Size(num3, height);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00004570 File Offset: 0x00002770
		protected virtual global::System.Windows.Size RenderCells(double availableWidth)
		{
			global::Infragistics.Controls.Grids.RowsManagerBase manager = this.Row.Manager;
			global::System.Windows.Size result;
			if (!manager.IsFirstRowRenderingInThisLayoutCycle && !this.Owner.ReverseCellMeasure)
			{
				if (this.Row.ColumnLayout.Grid.CellControlGenerationModeInternal == global::Infragistics.Controls.Grids.CellControlGenerationMode.Recycle)
				{
					for (int k = this._previousCells.Count - 1; k >= 0; k--)
					{
						global::Infragistics.Controls.Grids.CellBase cellBase = this._previousCells[k];
						int visibleColumnIndex = cellBase.Column.VisibleColumnIndex;
						if (visibleColumnIndex >= 0 && (visibleColumnIndex < manager.IndexOfFirstColumnRendered || visibleColumnIndex >= manager.IndexOfFirstColumnRendered + manager.TotalColumnsRendered))
						{
							this.ReleaseCell(cellBase);
						}
					}
				}
				if (manager.InvalidateOverrideHorizontalMax)
				{
					manager.InvalidateOverrideHorizontalMax = false;
					manager.OverrideHorizontalMax = -1.0;
				}
				bool flag = double.IsPositiveInfinity(availableWidth);
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = this.Row.Columns.VisibleColumns;
				double height = 0.0;
				global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
				if (flag)
				{
					if (!readOnlyCollection.Any((global::Infragistics.Controls.Grids.Column i) => i is global::Infragistics.Controls.Grids.Primitives.FillerColumn))
					{
						readOnlyCollection = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column>(new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>(readOnlyCollection)
						{
							this.Row.Columns.FillerColumn
						});
					}
				}
				double num = manager.CachedIndentation;
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> fixedAdornerColumns = this.Row.Columns.FixedAdornerColumns;
				foreach (global::Infragistics.Controls.Grids.Column column in fixedAdornerColumns)
				{
					double actualWidth = column.ActualWidth;
					this.RenderCell(column, starColumns, ref height, false, this.VisibleFixedLeftCells, flag);
					if (actualWidth != column.ActualWidth)
					{
						this.VisibleFixedLeftCells.Clear();
						return this.RenderCellsComplex(availableWidth);
					}
					if (column.WidthResolved.WidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star || flag)
					{
						num += actualWidth;
					}
				}
				bool flag2 = false;
				if (this.Row.ColumnLayout.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
				{
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection2 = this.Row.Columns.GroupByColumns[this.Row.ColumnLayout];
					foreach (global::Infragistics.Controls.Grids.Column column2 in readOnlyCollection2)
					{
						if (column2.Visibility == global::System.Windows.Visibility.Visible)
						{
							flag2 = true;
							double actualWidth2 = column2.ActualWidth;
							this.RenderCell(column2, starColumns, ref height, false, this.VisibleFixedLeftCells, flag);
							if (actualWidth2 != column2.ActualWidth)
							{
								this.VisibleFixedLeftCells.Clear();
								return this.RenderCellsComplex(availableWidth);
							}
							if (column2.WidthResolved.WidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star || flag)
							{
								num += actualWidth2;
							}
						}
					}
				}
				global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsCollection = this.Row.Columns.FixedColumnsLeft;
				if (fixedColumnsCollection.Count > 0)
				{
					foreach (global::Infragistics.Controls.Grids.Column column3 in fixedColumnsCollection)
					{
						if (column3.Visibility == global::System.Windows.Visibility.Visible)
						{
							double actualWidth3 = column3.ActualWidth;
							flag2 = true;
							this.RenderCell(column3, starColumns, ref height, false, this.VisibleFixedLeftCells, flag);
							if (actualWidth3 != column3.ActualWidth)
							{
								this.ReleaseCells(this.VisibleFixedLeftCells);
								return this.RenderCellsComplex(availableWidth);
							}
							if (column3.WidthResolved.WidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star || flag)
							{
								num += actualWidth3;
							}
						}
					}
				}
				if (flag2)
				{
					this.Row.Columns.FixedBorderColumnLeft.ActualWidth = 0.0;
					num += this.RenderCell(this.Row.Columns.FixedBorderColumnLeft, starColumns, ref height, false, this._additionalCells, flag);
				}
				fixedColumnsCollection = this.Row.Columns.FixedColumnsRight;
				if (fixedColumnsCollection.Count > 0)
				{
					flag2 = false;
					foreach (global::Infragistics.Controls.Grids.Column column4 in fixedColumnsCollection)
					{
						if (column4.Visibility == global::System.Windows.Visibility.Visible)
						{
							double actualWidth4 = column4.ActualWidth;
							flag2 = true;
							this.RenderCell(column4, starColumns, ref height, false, this.VisibleFixedRightCells, flag);
							if (actualWidth4 != column4.ActualWidth)
							{
								this.ReleaseCells(this.VisibleFixedLeftCells);
								this.ReleaseCells(this.VisibleFixedRightCells);
								return this.RenderCellsComplex(availableWidth);
							}
							if (column4.WidthResolved.WidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star || flag)
							{
								num += actualWidth4;
							}
						}
					}
					if (flag2)
					{
						this.Row.Columns.FixedBorderColumnRight.ActualWidth = 0.0;
						num += this.RenderCell(this.Row.Columns.FixedBorderColumnRight, starColumns, ref height, false, this._additionalCells, flag);
					}
				}
				double num2 = this.ResolveScrollLeft();
				if (num2 == -1.0 && this.Row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
				{
					this.InvalidateHorizontalMax(availableWidth - num, ref height, flag, false);
					num2 = this.ResolveScrollLeft();
					this.Owner.MeasureCalled = false;
					this.Owner.InvalidateMeasureInternal();
				}
				int num3 = manager.TotalColumnsRendered + manager.IndexOfFirstColumnRendered;
				if (num3 > readOnlyCollection.Count)
				{
					num3 = readOnlyCollection.Count;
				}
				bool flag3 = manager.ColumnLayout != null && manager.ColumnLayout.Grid != null && manager.ColumnLayout.Grid.ConditionalFormattingSettings.AllowConditionalFormatting;
				for (int j = manager.IndexOfFirstColumnRendered; j < num3; j++)
				{
					global::Infragistics.Controls.Grids.Column column5 = readOnlyCollection[j];
					double actualWidth5 = column5.ActualWidth;
					this.RenderCell(column5, starColumns, ref height, false, this.VisibleCells, flag);
					bool flag4 = true;
					if (actualWidth5 != column5.ActualWidth && flag4)
					{
						this.ReleaseCells(this.VisibleFixedLeftCells);
						this.ReleaseCells(this.VisibleFixedRightCells);
						this.ReleaseCells(this.VisibleCells);
						if (flag3)
						{
							base.DataContext = null;
							base.DataContext = this.Row.Data;
						}
						return this.RenderCellsComplex(availableWidth);
					}
					if (column5.WidthResolved.WidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star)
					{
						num += actualWidth5;
					}
				}
				manager.RowWidth = num;
				this.SetupStarCells(availableWidth, manager.RowWidth, ref height, starColumns);
				result = new global::System.Windows.Size(manager.RowWidth, height);
				return result;
			}
			result = this.RenderCellsComplex(availableWidth);
			manager.IsFirstRowRenderingInThisLayoutCycle = false;
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00004C1C File Offset: 0x00002E1C
		protected virtual double RenderCell(global::Infragistics.Controls.Grids.Column column, global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns, ref double maxHeight, bool insert, global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells, bool isInfinite)
		{
			return this.RenderCell(column, starColumns, ref maxHeight, insert, visibleCells, isInfinite, false);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004C30 File Offset: 0x00002E30
		protected virtual double RenderCell(global::Infragistics.Controls.Grids.Column column, global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns, ref double maxHeight, bool insert, global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells, bool isInfinite, bool suppressCellControlAttached)
		{
			double actualWidth = column.ActualWidth;
			global::Infragistics.Controls.Grids.ColumnWidth widthResolved = column.WidthResolved;
			global::Infragistics.Controls.Grids.ColumnWidthType columnWidthType = widthResolved.WidthType;
			double num = double.PositiveInfinity;
			if (columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Numeric)
			{
				num = widthResolved.Value;
			}
			else if (isInfinite && columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star)
			{
				columnWidthType = global::Infragistics.Controls.Grids.ColumnWidthType.Auto;
			}
			else if (columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.InitialAuto && column.IsInitialAutoSet && column.ActualWidth != 0.0)
			{
				num = column.ActualWidth;
			}
			if (!double.IsInfinity(num))
			{
				num = global::System.Math.Max(column.MinimumWidth, global::System.Math.Min(column.MaximumWidth, num));
			}
			double num2 = double.PositiveInfinity;
			global::Infragistics.Controls.Grids.RowHeight heightResolved = this.Row.HeightResolved;
			if (heightResolved.HeightType == global::Infragistics.Controls.Grids.RowHeightType.Numeric)
			{
				num2 = heightResolved.Value;
			}
			if (column.Visibility == global::System.Windows.Visibility.Collapsed)
			{
				return 0.0;
			}
			global::Infragistics.Controls.Grids.CellBase cellBase = this.Row.ResolveCell(column);
			if (cellBase != null)
			{
				if (!insert)
				{
					visibleCells.Add(cellBase);
				}
				else
				{
					visibleCells.Insert(0, cellBase);
				}
				global::System.Windows.Size size = global::System.Windows.Size.Empty;
				bool flag = false;
				bool flag2 = cellBase is global::Infragistics.Controls.Grids.Primitives.GroupCell && this.Owner.ShouldInvalidateGroupCellMeasure;
				if (cellBase.Control == null)
				{
					cellBase.SuppressCellControlAttached = suppressCellControlAttached;
					bool flag3 = global::Infragistics.RecyclingManager.Manager.AttachElement(cellBase, this);
					cellBase.Control.EnsureContent();
					cellBase.EnsureCurrentState();
					flag2 |= (!flag3 && cellBase is global::Infragistics.Controls.Grids.Primitives.GroupCell);
					flag2 |= (!flag3 && (this.Owner.IsWndResizing || this.Owner.ShouldInvalidateCellMeasure));
					flag2 |= (!flag3 && base.IsLoaded);
					cellBase.MeasuringSize = global::System.Windows.Size.Empty;
					size = new global::System.Windows.Size(num, num2);
				}
				else
				{
					cellBase.ApplyStyle();
					cellBase.Control.EnsureContent();
					cellBase.EnsureCurrentState();
					if (cellBase.MeasuringSize.IsEmpty)
					{
						size = new global::System.Windows.Size(num, num2);
					}
					else
					{
						size = cellBase.MeasuringSize;
					}
					flag = true;
				}
				if (flag2)
				{
					cellBase.Control.Measure(new global::System.Windows.Size(1.0, 1.0));
				}
				if (columnWidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star)
				{
					cellBase.Control.MeasureRaised = false;
					cellBase.Control.Measure(size);
					if (!cellBase.Control.MeasureRaised)
					{
						global::System.Windows.FrameworkElement frameworkElement = cellBase.Control.Content as global::System.Windows.FrameworkElement;
						if (frameworkElement != null && (frameworkElement.DesiredSize.Width > cellBase.Control.DesiredSize.Width || frameworkElement.DesiredSize.Width < 10.0))
						{
							cellBase.Control.Measure(new global::System.Windows.Size(1.0, 1.0));
							cellBase.Control.Measure(size);
						}
						if (flag)
						{
							cellBase.Control.ManuallyInvokeMeasure(size);
						}
					}
				}
				global::Infragistics.Controls.Grids.Primitives.CellControlBase control = cellBase.Control;
				double num3 = control.DesiredSize.Width;
				if (columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.InitialAuto && !column.IsInitialAutoSet)
				{
					num3 = global::System.Math.Ceiling(num3 + 1.0);
				}
				if (column.AllowToolTips == global::Infragistics.Controls.Grids.AllowToolTips.Overflow)
				{
					global::Infragistics.Controls.Grids.CellControl cellControl = control as global::Infragistics.Controls.Grids.CellControl;
					if (cellControl != null && (num != double.PositiveInfinity || num2 != double.PositiveInfinity) && cellBase.MeasuringSize.IsEmpty)
					{
						control.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
						double width = control.DesiredSize.Width;
						control.Measure(new global::System.Windows.Size(num, num2));
						if (width > num3 && (double.IsPositiveInfinity(num) || num < width))
						{
							cellControl.ShowToolTip();
						}
						else
						{
							cellControl.HideToolTip();
						}
					}
				}
				if (isInfinite && columnWidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star)
				{
					columnWidthType = global::Infragistics.Controls.Grids.ColumnWidthType.Auto;
					if (num3 < control.ActualWidth)
					{
						num3 = control.ActualWidth;
					}
				}
				if (isInfinite && column is global::Infragistics.Controls.Grids.Primitives.FillerColumn)
				{
					num3 = 0.0;
					column.ActualWidth = num3;
				}
				switch (columnWidthType)
				{
				case global::Infragistics.Controls.Grids.ColumnWidthType.Auto:
					if (column.ActualWidth < num3)
					{
						column.ActualWidth = num3;
					}
					break;
				case global::Infragistics.Controls.Grids.ColumnWidthType.InitialAuto:
					if (column.ActualWidth == 0.0)
					{
						column.IsInitialAutoSet = false;
					}
					if (!column.IsInitialAutoSet && column.ActualWidth < num3)
					{
						column.ActualWidth = num3;
					}
					break;
				case global::Infragistics.Controls.Grids.ColumnWidthType.SizeToHeader:
					if (this.Row.RowType == global::Infragistics.Controls.Grids.RowType.HeaderRow && column.ActualWidth < num3)
					{
						column.ActualWidth = num3;
					}
					break;
				case global::Infragistics.Controls.Grids.ColumnWidthType.SizeToCells:
					if (this.Row.RowType != global::Infragistics.Controls.Grids.RowType.HeaderRow && this.Row.RowType != global::Infragistics.Controls.Grids.RowType.FooterRow && column.ActualWidth < num3)
					{
						column.ActualWidth = num3;
					}
					break;
				case global::Infragistics.Controls.Grids.ColumnWidthType.Star:
					if (starColumns != null)
					{
						starColumns.Add(cellBase);
					}
					return 0.0;
				case global::Infragistics.Controls.Grids.ColumnWidthType.Numeric:
					column.ActualWidth = cellBase.Column.WidthResolved.Value;
					break;
				}
				if (column.ActualWidth < column.MinimumWidth)
				{
					column.ActualWidth = column.MinimumWidth;
				}
				if (column.ActualWidth > column.MaximumWidth)
				{
					column.ActualWidth = column.MaximumWidth;
				}
				if (actualWidth != column.ActualWidth && actualWidth != 0.0 && !(column is global::Infragistics.Controls.Grids.Primitives.FixedBorderColumn))
				{
					this.Row.Manager.OverrideHorizontalMax = -1.0;
				}
				maxHeight = global::System.Math.Max(maxHeight, cellBase.Control.DesiredSize.Height);
				return column.ActualWidth;
			}
			return 0.0;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000051E4 File Offset: 0x000033E4
		protected virtual void OnCellMouseOver(global::Infragistics.Controls.Grids.CellBase cell)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = cell.Row.ColumnLayout;
			bool flag = columnLayout.EditingSettings.AllowEditingResolved == global::Infragistics.Controls.Grids.EditingType.Hover;
			if (this.Row.ResolveRowHover == global::Infragistics.Controls.Grids.RowHoverType.Row)
			{
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase in this._visibleFixedLeftCells)
				{
					cellBase.EnsureCurrentState();
				}
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase2 in this._visibleCells)
				{
					cellBase2.EnsureCurrentState();
				}
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase3 in this._visibleFixedRightCells)
				{
					cellBase3.EnsureCurrentState();
				}
				if (flag && !this._isEnteringEditMode)
				{
					global::Infragistics.Controls.Grids.Row row = this.Row as global::Infragistics.Controls.Grids.Row;
					if (row != null)
					{
						global::Infragistics.Controls.Grids.CellBase cellBase4 = cell;
						if (!cell.IsEditable)
						{
							cellBase4 = (from c in row.VisibleCells
							where c.IsEditable
							select c).FirstOrDefault<global::Infragistics.Controls.Grids.CellBase>();
						}
						if (cellBase4 != null)
						{
							this._isEnteringEditMode = true;
							columnLayout.Grid.EnterEditMode(row, cellBase4);
							this._isEnteringEditMode = false;
							cellBase4.Control.ContentProvider.FocusEditor();
							return;
						}
					}
				}
			}
			else if (this.Row.ResolveRowHover == global::Infragistics.Controls.Grids.RowHoverType.Cell)
			{
				cell.EnsureCurrentState();
				if (flag)
				{
					columnLayout.Grid.EnterEditMode(cell);
				}
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000539C File Offset: 0x0000359C
		protected virtual void OnCellMouseLeave(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.CellBase newCell)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = cell.Row.ColumnLayout;
			bool flag = columnLayout != null && columnLayout.Grid.EditingSettings.AllowEditing == global::Infragistics.Controls.Grids.EditingType.Hover;
			if (this.Row.ResolveRowHover == global::Infragistics.Controls.Grids.RowHoverType.Row)
			{
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase in this._visibleFixedLeftCells)
				{
					cellBase.EnsureCurrentState();
				}
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase2 in this._visibleCells)
				{
					cellBase2.EnsureCurrentState();
				}
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.CellBase> enumerator3 = this._visibleFixedRightCells.GetEnumerator())
				{
					while (enumerator3.MoveNext())
					{
						global::Infragistics.Controls.Grids.CellBase cellBase3 = enumerator3.Current;
						cellBase3.EnsureCurrentState();
					}
					goto IL_DB;
				}
			}
			cell.EnsureCurrentState();
			IL_DB:
			if (flag && columnLayout.Grid.RowHover == global::Infragistics.Controls.Grids.RowHoverType.Cell && newCell != null)
			{
				columnLayout.Grid.ExitEditModeInternal(false);
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000054CC File Offset: 0x000036CC
		protected double SetupStarCells(double availableWidth, double currentWidth, ref double maxHeight, global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns)
		{
			double num = availableWidth - currentWidth;
			double num2 = num;
			double num3 = 0.0;
			if (num > 0.0)
			{
				if (starColumns.Count <= 0)
				{
					goto IL_830;
				}
				double num4 = 0.0;
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase in starColumns)
				{
					num4 += cellBase.Column.WidthResolved.Value;
				}
				if (num4 == 0.0)
				{
					goto IL_830;
				}
				double num5 = num / num4;
				bool flag = false;
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>(starColumns);
				do
				{
					flag = false;
					global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>();
					foreach (global::Infragistics.Controls.Grids.CellBase cellBase2 in list)
					{
						double num6 = (double)((int)num5) * cellBase2.Column.WidthResolved.Value;
						if (num6 < cellBase2.Column.MinimumWidth)
						{
							num -= cellBase2.Column.MinimumWidth;
							num4 -= cellBase2.Column.WidthResolved.Value;
							cellBase2.Column.ActualWidth = cellBase2.Column.MinimumWidth;
							if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase2.Column))
							{
								this.Row.Manager.StarColumnWidths.Add(cellBase2.Column, cellBase2.Column.MinimumWidth);
							}
							else
							{
								this.Row.Manager.StarColumnWidths[cellBase2.Column] = cellBase2.Column.MinimumWidth;
							}
							flag = true;
						}
						else
						{
							list2.Add(cellBase2);
						}
					}
					list = list2;
					num5 = num / num4;
				}
				while (flag);
				if (num > 0.0)
				{
					if (list.Count > 0)
					{
						foreach (global::Infragistics.Controls.Grids.CellBase cellBase3 in list)
						{
							cellBase3.Column.ActualWidth = (double)((int)num5) * cellBase3.Column.WidthResolved.Value;
							if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase3.Column))
							{
								this.Row.Manager.StarColumnWidths.Add(cellBase3.Column, cellBase3.Column.ActualWidth);
							}
							else
							{
								this.Row.Manager.StarColumnWidths[cellBase3.Column] = cellBase3.Column.ActualWidth;
							}
							num3 += num5 * cellBase3.Column.WidthResolved.Value - cellBase3.Column.ActualWidth;
						}
						if (num3 > 0.0)
						{
							double num7 = global::System.Math.Floor(num3 / (double)list.Count);
							num3 -= (double)list.Count * num7;
							foreach (global::Infragistics.Controls.Grids.CellBase cellBase4 in list)
							{
								cellBase4.Column.ActualWidth += num7;
								if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase4.Column))
								{
									this.Row.Manager.StarColumnWidths.Add(cellBase4.Column, cellBase4.Column.ActualWidth);
								}
								else
								{
									this.Row.Manager.StarColumnWidths[cellBase4.Column] = cellBase4.Column.ActualWidth;
								}
							}
						}
						list[list.Count - 1].Column.ActualWidth += num3;
					}
				}
				else
				{
					num2 = 0.0;
					foreach (global::Infragistics.Controls.Grids.CellBase cellBase5 in list)
					{
						cellBase5.Column.ActualWidth = cellBase5.Column.MinimumWidth;
						if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase5.Column))
						{
							this.Row.Manager.StarColumnWidths.Add(cellBase5.Column, cellBase5.Column.ActualWidth);
						}
						else
						{
							this.Row.Manager.StarColumnWidths[cellBase5.Column] = cellBase5.Column.ActualWidth;
						}
					}
				}
				using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.CellBase> enumerator6 = starColumns.GetEnumerator())
				{
					while (enumerator6.MoveNext())
					{
						global::Infragistics.Controls.Grids.CellBase cellBase6 = enumerator6.Current;
						double num8 = 0.0;
						if (this.Row.Manager.StarColumnWidths.ContainsKey(cellBase6.Column))
						{
							num8 = this.Row.Manager.StarColumnWidths[cellBase6.Column];
						}
						if (cellBase6.Column.AllowToolTips == global::Infragistics.Controls.Grids.AllowToolTips.Overflow)
						{
							global::Infragistics.Controls.Grids.CellControl cellControl = cellBase6.Control as global::Infragistics.Controls.Grids.CellControl;
							if (cellControl != null)
							{
								cellControl.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
								double width = cellControl.DesiredSize.Width;
								if (width > num8)
								{
									cellControl.ShowToolTip();
								}
								else
								{
									cellControl.HideToolTip();
								}
							}
						}
						cellBase6.Control.MeasureRaised = false;
						cellBase6.Control.Measure(new global::System.Windows.Size(num8, double.PositiveInfinity));
						if (!cellBase6.Control.MeasureRaised)
						{
							global::System.Windows.FrameworkElement frameworkElement = cellBase6.Control.Content as global::System.Windows.FrameworkElement;
							if (frameworkElement != null && (frameworkElement.DesiredSize.Width > cellBase6.Control.DesiredSize.Width || frameworkElement.DesiredSize.Width < 10.0))
							{
								cellBase6.Control.Measure(new global::System.Windows.Size(1.0, 1.0));
								cellBase6.Control.Measure(new global::System.Windows.Size(num8, double.PositiveInfinity));
							}
						}
						num2 -= num8;
						maxHeight = global::System.Math.Max(maxHeight, cellBase6.Control.DesiredSize.Height);
					}
					goto IL_830;
				}
			}
			num2 = 0.0;
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase7 in starColumns)
			{
				cellBase7.Column.ActualWidth = cellBase7.Column.MinimumWidth;
				if (cellBase7.Column.AllowToolTips == global::Infragistics.Controls.Grids.AllowToolTips.Overflow)
				{
					global::Infragistics.Controls.Grids.CellControl cellControl2 = cellBase7.Control as global::Infragistics.Controls.Grids.CellControl;
					if (cellControl2 != null)
					{
						cellControl2.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
						double width2 = cellControl2.DesiredSize.Width;
						if (width2 > cellBase7.Column.ActualWidth)
						{
							cellControl2.ShowToolTip();
						}
						else
						{
							cellControl2.HideToolTip();
						}
					}
				}
				if (!this.Row.Manager.StarColumnWidths.ContainsKey(cellBase7.Column))
				{
					this.Row.Manager.StarColumnWidths.Add(cellBase7.Column, cellBase7.Column.ActualWidth);
				}
				else
				{
					this.Row.Manager.StarColumnWidths[cellBase7.Column] = cellBase7.Column.ActualWidth;
				}
				cellBase7.Control.Measure(new global::System.Windows.Size(cellBase7.Column.ActualWidth, double.PositiveInfinity));
				maxHeight = global::System.Math.Max(maxHeight, cellBase7.Control.DesiredSize.Height);
				num2 -= cellBase7.Column.ActualWidth;
			}
			this.Row.Columns.FillerColumn.ActualWidth = 0.0;
			IL_830:
			if (double.IsInfinity(num2))
			{
				num2 = 0.0;
			}
			return currentWidth + global::System.Math.Abs(num2);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005DD0 File Offset: 0x00003FD0
		protected virtual bool SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Grids.RowCommandBase;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005DDB File Offset: 0x00003FDB
		protected virtual object GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.Row;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005DE3 File Offset: 0x00003FE3
		internal void ReleaseCell(global::Infragistics.Controls.Grids.CellBase cell)
		{
			if (cell.Control != null && cell.Control.Parent == this && !global::Infragistics.RecyclingManager.Manager.ReleaseElement(cell, this))
			{
				this._nonReleasedCells.Add(cell);
			}
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005E18 File Offset: 0x00004018
		private void ReleaseCells(global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> cells)
		{
			foreach (global::Infragistics.Controls.Grids.CellBase cell in cells)
			{
				this.ReleaseCell(cell);
			}
			cells.Clear();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00005E68 File Offset: 0x00004068
		private double ResolveScrollLeft()
		{
			global::System.Windows.Controls.Primitives.ScrollBar horizontalScrollBar = this._scrollInfo.HorizontalScrollBar;
			if (horizontalScrollBar == null)
			{
				return 0.0;
			}
			global::Infragistics.Controls.Grids.RowsManagerBase horizontalRowsManager = this.Owner.HorizontalRowsManager;
			if (horizontalRowsManager == null || horizontalRowsManager == this.Row.Manager)
			{
				return horizontalScrollBar.Value;
			}
			if (horizontalScrollBar.Value == 0.0 || horizontalScrollBar.Maximum == 0.0)
			{
				return 0.0;
			}
			double num = horizontalScrollBar.Value / horizontalScrollBar.Maximum;
			if (this.Row.Manager.OverrideHorizontalMax == -1.0)
			{
				return -1.0;
			}
			double num2 = this.Row.Manager.OverrideHorizontalMax * num;
			if (num2 < 0.0 || double.IsPositiveInfinity(num2) || double.IsNaN(num2))
			{
				num2 = 0.0;
			}
			return num2;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00005F50 File Offset: 0x00004150
		internal void SetScrollLeft(double scrollLeft)
		{
			global::System.Windows.Controls.Primitives.ScrollBar horizontalScrollBar = this._scrollInfo.HorizontalScrollBar;
			if (horizontalScrollBar != null && this.Row.Manager.ScrollableCellCount - 1 > 0)
			{
				global::Infragistics.Controls.Grids.RowsManagerBase horizontalRowsManager = this.Owner.HorizontalRowsManager;
				double num;
				if (horizontalRowsManager == null || horizontalRowsManager == this.Row.Manager)
				{
					num = scrollLeft;
				}
				else
				{
					if (this.Row.Manager.OverrideHorizontalMax != -1.0)
					{
						horizontalScrollBar.Maximum = this.Row.Manager.OverrideHorizontalMax;
					}
					num = scrollLeft / this.Row.Manager.OverrideHorizontalMax * horizontalScrollBar.Maximum;
				}
				if (double.IsNaN(num) || double.IsInfinity(num))
				{
					num = 0.0;
				}
				horizontalScrollBar.Value = num;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006020 File Offset: 0x00004220
		private global::Infragistics.Controls.Grids.Primitives.CellsPanel.ChildColumnInfo ResolveChildColumnInfo(global::Infragistics.Controls.Grids.GroupColumn groupColumn, double percent)
		{
			if (percent < 0.0 || percent > 1.0)
			{
				throw new global::System.ArgumentException("percent");
			}
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = groupColumn.AllVisibleChildColumns;
			double actualWidth = groupColumn.ActualWidth;
			double num = 0.0;
			global::Infragistics.Controls.Grids.Primitives.CellsPanel.ChildColumnInfo result = null;
			this.VerifyColumnsActualWidths(groupColumn);
			for (int i = 0; i < allVisibleChildColumns.Count; i++)
			{
				global::Infragistics.Controls.Grids.Column column = allVisibleChildColumns[i];
				double num2 = num + column.ActualWidth;
				if (num / actualWidth <= percent && percent <= num2 / actualWidth)
				{
					double scrollPercentage = (percent * actualWidth - num) / column.ActualWidth;
					result = new global::Infragistics.Controls.Grids.Primitives.CellsPanel.ChildColumnInfo(column, scrollPercentage, i);
					break;
				}
				num = num2;
			}
			return result;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000060CC File Offset: 0x000042CC
		private void VerifyColumnsActualWidths(global::Infragistics.Controls.Grids.GroupColumn groupColumn)
		{
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = groupColumn.AllVisibleChildColumns;
			for (int i = 0; i < allVisibleChildColumns.Count; i++)
			{
				global::Infragistics.Controls.Grids.Column column = allVisibleChildColumns[i];
				if (column.ActualWidth == 0.0 && groupColumn.ActualWidth > 0.0)
				{
					global::Infragistics.Controls.Grids.GroupColumnsCollection groupColumnsCollection = new global::Infragistics.Controls.Grids.GroupColumnsCollection();
					foreach (global::Infragistics.Controls.Grids.Column item in groupColumn.AllColumns)
					{
						groupColumnsCollection.Add(item);
					}
					global::Infragistics.Controls.Grids.Primitives.GroupColumnPanel.InitializeColumnActualWidths(groupColumnsCollection, this.Row, -1.0);
					return;
				}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006184 File Offset: 0x00004384
		private void InvalidateHorizontalMax(double availWidth, ref double maxHeight, bool isInfinite, bool includeStarCols)
		{
			if (this._prevAvailableWidth != availWidth)
			{
				this.Row.Manager.OverrideHorizontalMax = -1.0;
			}
			this._prevAvailableWidth = availWidth;
			if (this.Row.Manager.OverrideHorizontalMax == -1.0 && !isInfinite)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>(this._lastCellsDetached);
				this._lastCellsDetached.Clear();
				foreach (global::Infragistics.Controls.Grids.Column column in this.Row.Columns.VisibleColumns)
				{
					if (!(column is global::Infragistics.Controls.Grids.Primitives.FillerColumn) && column.WidthResolved.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star && column.ActualWidth > column.MinimumWidth)
					{
						global::Infragistics.Controls.Grids.CellBase cellBase = this.Row.Cells[column];
						if (cellBase.Control != null)
						{
							this.Row.Manager.OverrideHorizontalMax = -1.0;
							return;
						}
					}
				}
				global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
				double num = 0.0;
				double num2 = 0.0;
				int num3 = this.Row.Columns.VisibleColumns.Count - 1;
				int num4 = this.Row.Columns.AllVisibleChildColumns.Count - 1;
				bool flag = false;
				while (num2 < availWidth && num3 >= 0)
				{
					global::Infragistics.Controls.Grids.Column column2 = this.Row.Columns.VisibleColumns[num3];
					if (column2.WidthResolved.WidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star)
					{
						num = this.RenderCell(column2, starColumns, ref maxHeight, false, this._lastCellsDetached, isInfinite, true);
					}
					else if (includeStarCols && !(column2 is global::Infragistics.Controls.Grids.Primitives.FillerColumn))
					{
						if (column2.ActualWidth < column2.MinimumWidth)
						{
							num = column2.MinimumWidth;
						}
						else
						{
							num = column2.ActualWidth;
						}
					}
					num2 += num;
					num3--;
					int count = column2.AllVisibleChildColumns.Count;
					num4 -= ((count > 0) ? count : 1);
					flag = true;
				}
				if (flag)
				{
					num3++;
					num4++;
				}
				double num5 = (num2 - availWidth) / num;
				if (num3 != -1 && num5 >= 0.0 && num5 <= 1.0)
				{
					global::Infragistics.Controls.Grids.GroupColumn groupColumn = this.Row.Columns.VisibleColumns[num3] as global::Infragistics.Controls.Grids.GroupColumn;
					if (groupColumn != null)
					{
						global::Infragistics.Controls.Grids.Primitives.CellsPanel.ChildColumnInfo childColumnInfo = this.ResolveChildColumnInfo(groupColumn, num5);
						if (childColumnInfo != null)
						{
							num5 = childColumnInfo.ChildColumnScrollPercentage;
							num3 = num4 + childColumnInfo.ChildColumnIndexOffset;
						}
					}
					else
					{
						num3 = num4;
					}
				}
				int num6 = this._lastCellsDetached.Count - 1;
				for (int i = num6; i >= 0; i--)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase2 = this._lastCellsDetached[i];
					cellBase2.SuppressCellControlAttached = false;
					if (this.VisibleCells.Contains(cellBase2))
					{
						this._lastCellsDetached.Remove(cellBase2);
						global::Infragistics.Controls.Grids.Cell cell = cellBase2 as global::Infragistics.Controls.Grids.Cell;
						global::Infragistics.Controls.Grids.ColumnLayout columnLayout = this.Row.Manager.ColumnLayout;
						if (cell != null && columnLayout != null && columnLayout.Grid != null)
						{
							this.Row.Manager.ColumnLayout.Grid.OnCellControlAttached(cell);
						}
					}
					else
					{
						this.ReleaseCell(cellBase2);
					}
				}
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase3 in list)
				{
					if (!this.VisibleCells.Contains(cellBase3) && !this.VisibleFixedLeftCells.Contains(cellBase3) && !this.VisibleFixedRightCells.Contains(cellBase3) && cellBase3.Control != null)
					{
						this.ReleaseCell(cellBase3);
					}
				}
				this.Row.Manager.OverrideHorizontalMax = (double)num3 + num5;
				if (this.Row.Manager.OverrideHorizontalMax < 0.0)
				{
					this.Row.Manager.OverrideHorizontalMax = 0.0;
				}
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00006594 File Offset: 0x00004794
		internal void InternalCellMouseEnter(global::Infragistics.Controls.Grids.CellBase cell)
		{
			this.OnCellMouseOver(cell);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000659D File Offset: 0x0000479D
		internal void InternalCellMouseLeave(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.CellBase newCell)
		{
			this.OnCellMouseLeave(cell, newCell);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000065A8 File Offset: 0x000047A8
		internal void RenderCell(global::Infragistics.Controls.Grids.CellBase cell)
		{
			double num = 0.0;
			global::Infragistics.Controls.Grids.Column column = cell.Column;
			while (column.ParentColumn != null)
			{
				column = column.ParentColumn;
			}
			bool flag = true;
			global::Infragistics.Controls.Grids.Primitives.RowsPanel owner = this.Owner;
			if (owner != null)
			{
				flag = !owner.ShouldInvalidateGroupCellMeasure;
				owner.ShouldInvalidateGroupCellMeasure = true;
			}
			this.RenderCell(column, new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>(), ref num, false, this._visibleCells, false);
			if (owner != null && flag)
			{
				owner.ShouldInvalidateGroupCellMeasure = false;
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00006618 File Offset: 0x00004818
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			bool flag = this._hasInfiniteWidth = double.IsInfinity(availableSize.Width);
			if (this.Row == null || this.Row.ColumnLayout == null)
			{
				return base.MeasureOverride(availableSize);
			}
			this.PreviousInvalidateHeight = availableSize.Height;
			if (this.Owner != null && !this.Owner.InLayoutPhase)
			{
				this.Owner.InvalidateMeasureInternal();
			}
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>(this._visibleCells);
			list.AddRange(this._visibleFixedLeftCells);
			list.AddRange(this._additionalCells);
			list.AddRange(this._visibleFixedRightCells);
			this._additionalCells.Clear();
			this._visibleCells.Clear();
			this._visibleFixedLeftCells.Clear();
			this._visibleFixedRightCells.Clear();
			this._previousCells.AddRange(list);
			global::System.Windows.Size size = this.RenderCells(availableSize.Width);
			this._previousCells.Clear();
			switch (this.Row.HeightResolved.HeightType)
			{
			case global::Infragistics.Controls.Grids.RowHeightType.SizeToLargestCell:
				this.Row.ActualHeight = (size.Height = global::System.Math.Max(global::System.Math.Max(this.Row.ActualHeight, size.Height), this.Row.MinimumRowHeightResolved));
				break;
			case global::Infragistics.Controls.Grids.RowHeightType.Dynamic:
				size.Height = global::System.Math.Max(size.Height, this.Row.MinimumRowHeightResolved);
				this.Row.ActualHeight = size.Height;
				break;
			case global::Infragistics.Controls.Grids.RowHeightType.Numeric:
				this.Row.ActualHeight = (size.Height = this.Row.HeightResolved.Value);
				break;
			}
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase in list)
			{
				if (!this._visibleCells.Contains(cellBase) && !this._visibleFixedLeftCells.Contains(cellBase) && !this._visibleFixedRightCells.Contains(cellBase) && !this._additionalCells.Contains(cellBase))
				{
					this.ReleaseCell(cellBase);
				}
			}
			double width = availableSize.Width;
			if (flag)
			{
				width = size.Width;
			}
			return new global::System.Windows.Size(width, size.Height);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000068D4 File Offset: 0x00004AD4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this.ArrangeRaised = true;
			if (this.Row == null || this.Row.ColumnLayout == null)
			{
				return finalSize;
			}
			global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> availableElements = global::Infragistics.RecyclingManager.Manager.GetAvailableElements(this);
			foreach (global::System.Windows.FrameworkElement frameworkElement in availableElements)
			{
				frameworkElement.Arrange(this._hideCellRect);
			}
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase in this._nonReleasedCells)
			{
				if (cellBase.Control != null)
				{
					cellBase.Control.Arrange(this._hideCellRect);
				}
			}
			this._nonReleasedCells.Clear();
			double num = this.Row.Manager.CachedIndentation;
			double num2 = finalSize.Width - num;
			if (num2 < 0.0)
			{
				num2 = 0.0;
			}
			this._clipRG.Rect = new global::System.Windows.Rect(num, 0.0, num2, finalSize.Height);
			bool flag = false;
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase2 in this._visibleFixedLeftCells)
			{
				global::Infragistics.Controls.Grids.Column column = cellBase2.Column;
				global::System.Windows.FrameworkElement control = cellBase2.Control;
				double actualWidth = column.ActualWidth;
				if (column.IsGroupBy || column.IsFixed == global::Infragistics.Controls.Grids.FixedState.Left)
				{
					flag = true;
				}
				if (column != null && column.IsMoving)
				{
					control.Arrange(new global::System.Windows.Rect(num, 0.0, 0.0, 0.0));
				}
				else
				{
					double height = global::System.Math.Max(finalSize.Height, control.DesiredSize.Height);
					double x = num;
					if (column != null && column.PercentMoved > 0.0)
					{
						if (!column.ReverseMove)
						{
							x = num - column.MovingColumnsWidth + column.MovingColumnsWidth * column.PercentMoved;
						}
						else
						{
							x = num + column.MovingColumnsWidth - column.MovingColumnsWidth * column.PercentMoved;
						}
					}
					control.Arrange(new global::System.Windows.Rect(x, 0.0, actualWidth, height));
				}
				num += actualWidth;
				global::System.Windows.Controls.Panel.SetZIndex(control, 1);
			}
			if (flag)
			{
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase3 in this._additionalCells)
				{
					if (cellBase3.Column == this.Row.Columns.FixedBorderColumnLeft)
					{
						global::System.Windows.FrameworkElement control2 = cellBase3.Control;
						double actualWidth2 = cellBase3.Column.ActualWidth;
						control2.Arrange(new global::System.Windows.Rect(num, 0.0, actualWidth2, finalSize.Height));
						num += actualWidth2;
						global::System.Windows.Controls.Panel.SetZIndex(control2, 1);
						break;
					}
				}
			}
			double num3 = finalSize.Width;
			double actualWidth3 = this.Row.Columns.FillerColumn.ActualWidth;
			if (actualWidth3 > 0.0 && !this._hasInfiniteWidth)
			{
				num3 -= actualWidth3;
			}
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase4 in this._visibleFixedRightCells)
			{
				global::Infragistics.Controls.Grids.Column column2 = cellBase4.Column;
				global::System.Windows.FrameworkElement control3 = cellBase4.Control;
				double actualWidth4 = cellBase4.Column.ActualWidth;
				double num4 = num3;
				num3 -= actualWidth4;
				if (column2 != null && column2.IsMoving)
				{
					control3.Arrange(new global::System.Windows.Rect(num3, 0.0, 0.0, 0.0));
				}
				else
				{
					if (column2 != null && column2.PercentMoved > 0.0)
					{
						if (!column2.ReverseMove)
						{
							num4 = num4 + column2.MovingColumnsWidth - column2.MovingColumnsWidth * column2.PercentMoved;
						}
						else
						{
							num4 = num4 - column2.MovingColumnsWidth + column2.MovingColumnsWidth * column2.PercentMoved;
						}
					}
					num4 -= actualWidth4;
					control3.Arrange(new global::System.Windows.Rect(num4, 0.0, actualWidth4, global::System.Math.Max(finalSize.Height, control3.DesiredSize.Height)));
				}
				global::System.Windows.Controls.Panel.SetZIndex(control3, 2);
			}
			if (this.Row.Columns.FixedColumnsRight.Count > 0)
			{
				foreach (global::Infragistics.Controls.Grids.CellBase cellBase5 in this._additionalCells)
				{
					if (cellBase5.Column == this.Row.Columns.FixedBorderColumnRight)
					{
						global::System.Windows.FrameworkElement control4 = cellBase5.Control;
						double actualWidth5 = cellBase5.Column.ActualWidth;
						num3 -= actualWidth5;
						control4.Arrange(new global::System.Windows.Rect(num3, 0.0, actualWidth5, finalSize.Height));
						global::System.Windows.Controls.Panel.SetZIndex(control4, 2);
						break;
					}
				}
			}
			if (this.Row.CanScrollHorizontally)
			{
				global::System.Windows.Controls.Primitives.ScrollBar horizontalScrollBar = this._scrollInfo.HorizontalScrollBar;
				if (horizontalScrollBar != null && horizontalScrollBar.Visibility == global::System.Windows.Visibility.Visible)
				{
					if (this.Row.Manager.OverrideHorizontalMax > 0.0)
					{
						this.Row.Columns.FillerColumn.ActualWidth = 0.0;
					}
					if (horizontalScrollBar.Value != horizontalScrollBar.Maximum)
					{
						if (this._visibleCells.Count > 0)
						{
							double num5 = this.ResolveScrollLeft();
							double num6 = num5 - (double)((int)num5);
							double num7 = this._visibleCells[0].Column.ActualWidth * num6;
							global::Infragistics.Controls.Grids.GroupColumn groupColumn = this._visibleCells[0].Column as global::Infragistics.Controls.Grids.GroupColumn;
							if (groupColumn != null)
							{
								num7 = 0.0;
								global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = this.Row.Columns.AllVisibleChildColumns;
								global::Infragistics.Controls.Grids.Column column3 = allVisibleChildColumns[(int)num5];
								global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns2 = groupColumn.AllVisibleChildColumns;
								foreach (global::Infragistics.Controls.Grids.Column column4 in allVisibleChildColumns2)
								{
									if (column3 == column4)
									{
										num7 += column3.ActualWidth * num6;
										break;
									}
									num7 += column4.ActualWidth;
								}
							}
							if (this.Row.Manager.CurrentVisibleWidth + num > num3)
							{
								num += -num7;
							}
						}
					}
					else if (this.Row.Manager.CurrentVisibleWidth + num > num3)
					{
						num -= this.Row.Manager.OverflowAdjustment;
					}
				}
			}
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase6 in this._visibleCells)
			{
				global::Infragistics.Controls.Grids.Column col = cellBase6.Column;
				if (!col.IsInitialAutoSet)
				{
					bool ignoreAutoSet = false;
					global::Infragistics.Controls.Grids.RowsManager rowsManager = this.Row.Manager as global::Infragistics.Controls.Grids.RowsManager;
					if (rowsManager != null)
					{
						ignoreAutoSet = rowsManager.RegisteredTopRows.Contains(this.Row);
						if (!ignoreAutoSet)
						{
							ignoreAutoSet = rowsManager.RegisteredBottomRows.Contains(this.Row);
						}
					}
					global::Infragistics.Controls.Grids.CellBase cellRef = cellBase6;
					global::Infragistics.Controls.Grids.Primitives.RowsPanel owner = this.Owner;
					global::System.Action action = delegate()
					{
						global::Infragistics.Controls.Grids.Primitives.CellControlBase control7 = cellRef.Control;
						if (owner != null && !owner.ReverseCellMeasure && !ignoreAutoSet && control7 != null && control7.IsCellLoaded)
						{
							col.IsInitialAutoSet = true;
						}
					};
					if (this._isInDesigner)
					{
						action();
					}
					else
					{
						base.Dispatcher.BeginInvoke(action, new object[0]);
					}
				}
				global::Infragistics.Controls.Grids.Primitives.CellControlBase control5 = cellBase6.Control;
				double num8 = cellBase6.Column.ActualWidth;
				if (cellBase6.Column.WidthResolved.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star && this.Row.Manager.StarColumnWidths.ContainsKey(cellBase6.Column))
				{
					num8 = this.Row.Manager.StarColumnWidths[cellBase6.Column];
				}
				if (col != null && col.IsMoving)
				{
					control5.Arrange(new global::System.Windows.Rect(num, 0.0, 0.0, 0.0));
				}
				else
				{
					double x2 = num;
					if (col != null && col.PercentMoved > 0.0)
					{
						if (!col.ReverseMove)
						{
							x2 = num - col.MovingColumnsWidth + col.MovingColumnsWidth * col.PercentMoved;
						}
						else
						{
							x2 = num + col.MovingColumnsWidth - col.MovingColumnsWidth * col.PercentMoved;
						}
					}
					if (col is global::Infragistics.Controls.Grids.Primitives.FillerColumn)
					{
						if (this._hasInfiniteWidth)
						{
							continue;
						}
						x2 = finalSize.Width - num8;
					}
					control5.Arrange(new global::System.Windows.Rect(x2, 0.0, num8, global::System.Math.Max(finalSize.Height, control5.DesiredSize.Height)));
				}
				num += num8;
				global::System.Windows.Controls.Panel.SetZIndex(control5, 0);
			}
			if (this._hasInfiniteWidth && (num < finalSize.Width || this._fillerCellNeedsToBeReArranged))
			{
				if (num < finalSize.Width)
				{
					this._fillerCellNeedsToBeReArranged = true;
				}
				global::Infragistics.Controls.Grids.Primitives.FillerColumn fillerColumn = this.Row.Columns.FillerColumn;
				global::Infragistics.Controls.Grids.CellBase cellBase7 = this.Row.Cells[fillerColumn];
				global::Infragistics.Controls.Grids.Primitives.CellControlBase control6 = cellBase7.Control;
				if (control6 != null)
				{
					double num9 = finalSize.Width - num;
					num9 = ((num9 < 0.0) ? 0.0 : num9);
					fillerColumn.SetActualWidthSilently(num9);
					control6.Arrange(new global::System.Windows.Rect(num, 0.0, num9, global::System.Math.Max(finalSize.Height, control6.DesiredSize.Height)));
					global::System.Windows.Controls.Panel.SetZIndex(control6, 0);
				}
			}
			else
			{
				this._fillerCellNeedsToBeReArranged = false;
			}
			return finalSize;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000073C8 File Offset: 0x000055C8
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.CellsPanelAutomationPeer(this);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000073D0 File Offset: 0x000055D0
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return this.SupportsCommand(command);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000073D9 File Offset: 0x000055D9
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			return this.GetParameter(source);
		}

		// Token: 0x0400000F RID: 15
		private bool _isInDesigner;

		// Token: 0x04000010 RID: 16
		private bool _isEnteringEditMode;

		// Token: 0x04000011 RID: 17
		private bool _hasInfiniteWidth;

		// Token: 0x04000012 RID: 18
		private bool _fillerCellNeedsToBeReArranged;

		// Token: 0x04000013 RID: 19
		private double _prevAvailableWidth = -1.0;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Rect _hideCellRect = new global::System.Windows.Rect(-1000.0, -1000.0, 0.0, 0.0);

		// Token: 0x04000015 RID: 21
		private global::Infragistics.Controls.Grids.RowBase _row;

		// Token: 0x04000016 RID: 22
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> _visibleCells;

		// Token: 0x04000017 RID: 23
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> _visibleFixedLeftCells;

		// Token: 0x04000018 RID: 24
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> _visibleFixedRightCells;

		// Token: 0x04000019 RID: 25
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> _additionalCells;

		// Token: 0x0400001A RID: 26
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> _lastCellsDetached;

		// Token: 0x0400001B RID: 27
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> _nonReleasedCells;

		// Token: 0x0400001C RID: 28
		private global::Infragistics.Controls.Grids.Primitives.RowsPanel _owner;

		// Token: 0x0400001D RID: 29
		private global::Infragistics.IProvideScrollInfo _scrollInfo;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Media.RectangleGeometry _clipRG;

		// Token: 0x0400001F RID: 31
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> _previousCells = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>();

		// Token: 0x02000009 RID: 9
		private class ChildColumnInfo
		{
			// Token: 0x0600009B RID: 155 RVA: 0x000073E2 File Offset: 0x000055E2
			internal ChildColumnInfo(global::Infragistics.Controls.Grids.Column column, double scrollPercentage, int offset)
			{
				this.ChildColumn = column;
				this.ChildColumnScrollPercentage = scrollPercentage;
				this.ChildColumnIndexOffset = offset;
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x0600009C RID: 156 RVA: 0x000073FF File Offset: 0x000055FF
			// (set) Token: 0x0600009D RID: 157 RVA: 0x00007407 File Offset: 0x00005607
			internal int ChildColumnIndexOffset { get; private set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600009E RID: 158 RVA: 0x00007410 File Offset: 0x00005610
			// (set) Token: 0x0600009F RID: 159 RVA: 0x00007418 File Offset: 0x00005618
			internal double ChildColumnScrollPercentage { get; private set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x00007421 File Offset: 0x00005621
			// (set) Token: 0x060000A1 RID: 161 RVA: 0x00007429 File Offset: 0x00005629
			internal global::Infragistics.Controls.Grids.Column ChildColumn { get; private set; }
		}
	}
}
