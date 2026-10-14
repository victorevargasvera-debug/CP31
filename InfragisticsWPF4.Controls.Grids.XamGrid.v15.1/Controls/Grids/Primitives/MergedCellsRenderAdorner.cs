using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200010C RID: 268
	public class MergedCellsRenderAdorner : global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner
	{
		// Token: 0x06000906 RID: 2310 RVA: 0x000235B2 File Offset: 0x000217B2
		public MergedCellsRenderAdorner(global::Infragistics.Controls.Grids.XamGrid grid) : base(grid)
		{
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x000235DC File Offset: 0x000217DC
		public override void Reset()
		{
			base.Reset();
			this._summaryRowLookup.Clear();
			this._separtorCells.Clear();
			this._cellsToUpdate.Clear();
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x00023605 File Offset: 0x00021805
		public override void Initialize()
		{
			base.Initialize();
			this._summaryRowLookup.Clear();
			this._separtorCells.Clear();
			this._cellsToUpdate.Clear();
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x00023648 File Offset: 0x00021848
		public override double MeasureAfterRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			double num = 0.0;
			bool flag = false;
			global::Infragistics.MergedRowInfo mergeData = row.MergeData;
			if (mergeData != null && mergeData.MergedGroups.Count > 0)
			{
				global::Infragistics.Controls.Grids.RowsManagerBase manager = row.Manager;
				int num2 = 0;
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = row.Columns.GroupByColumns[row.ColumnLayout];
				global::Infragistics.Controls.Grids.Column obj = (from col in row.Columns.GroupByColumns[row.ColumnLayout]
				where col.Visibility.Equals(global::System.Windows.Visibility.Visible)
				select col).LastOrDefault<global::Infragistics.Controls.Grids.Column>();
				foreach (global::Infragistics.Controls.Grids.Column column in readOnlyCollection)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase = row.Cells[column];
					if (cellBase.Control != null)
					{
						global::Infragistics.MergedColumnInfo mergedColumnInfo = mergeData.MergedGroups[num2];
						global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo> list;
						if (!manager.RenderedMergedCells.ContainsKey(column))
						{
							list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo>();
							manager.RenderedMergedCells.Add(column, list);
						}
						else
						{
							list = manager.RenderedMergedCells[column];
						}
						global::Infragistics.Controls.Grids.CellBase cellBase2 = null;
						global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo renderMergeInfo = null;
						if (list.Count > 0)
						{
							renderMergeInfo = list[list.Count - 1];
							if (renderMergeInfo.Key == mergedColumnInfo.Key && renderMergeInfo.ParentMergedColumnInfo == mergedColumnInfo.ParentMergedColumnInfo)
							{
								cellBase2 = renderMergeInfo.Cell;
							}
						}
						if (cellBase2 != cellBase)
						{
							global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase expandableRowBase = cellBase.Row as global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase;
							bool lastCellIsExpanded = expandableRowBase != null && expandableRowBase.IsExpanded;
							if (cellBase2 != null && !renderMergeInfo.LastCellIsExpanded && !expandableRowBase.IsExpanded)
							{
								if (cellBase2.Control != null)
								{
									int index = cellBase.Row.Index;
									int index2 = cellBase2.Row.Index;
									if (index2 > index)
									{
										global::Infragistics.Controls.Grids.CellBase cellBase3 = cellBase2;
										cellBase2 = cellBase;
										cellBase = cellBase3;
										cellBase2.ActualMergedHeight = cellBase.ActualMergedHeight;
										renderMergeInfo.Cell = cellBase2;
									}
									if (!renderMergeInfo.CellsAlreadyAccountedFor.Contains(cellBase))
									{
										cellBase2.ActualMergedHeight += row.ActualHeight;
										renderMergeInfo.CellsAlreadyAccountedFor.Add(cellBase);
									}
									cellBase.ActualMergedHeight = 0.0;
									renderMergeInfo.LastVisibleCell = cellBase;
								}
							}
							else
							{
								cellBase.ActualMergedHeight = row.ActualHeight;
								renderMergeInfo = new global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo
								{
									Key = mergedColumnInfo.Key,
									Cell = cellBase
								};
								renderMergeInfo.MergedColumnInfo = mergedColumnInfo;
								renderMergeInfo.ParentMergedColumnInfo = mergedColumnInfo.ParentMergedColumnInfo;
								list.Add(renderMergeInfo);
								renderMergeInfo.LastVisibleCell = cellBase;
								renderMergeInfo.LastCellIsExpanded = lastCellIsExpanded;
							}
						}
						if (renderMergeInfo != null)
						{
							if (!this._cellsToUpdate.ContainsKey(mergedColumnInfo))
							{
								this._cellsToUpdate.Add(mergedColumnInfo, renderMergeInfo.Cell);
							}
							else
							{
								this._cellsToUpdate[mergedColumnInfo] = renderMergeInfo.Cell;
							}
							if (mergeData.IsLastRowInGroup[renderMergeInfo.LastVisibleCell.Column])
							{
								if (mergedColumnInfo.Summaries.Count > 0)
								{
									bool flag2 = false;
									foreach (global::Infragistics.SummaryDefinition summaryDefinition in mergedColumnInfo.Summaries)
									{
										global::Infragistics.Controls.Grids.Column column2 = row.ColumnLayout.Columns.AllColumns[summaryDefinition.ColumnKey] as global::Infragistics.Controls.Grids.Column;
										if (column2 != null && (!column2.IsGroupBy || readOnlyCollection.IndexOf(column2) > 0))
										{
											flag2 = true;
											break;
										}
									}
									if (flag2)
									{
										if (!this._summaryRowLookup.ContainsKey(row))
										{
											this._summaryRowLookup.Add(row, new global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo>());
										}
										this._summaryRowLookup[row].Insert(0, mergedColumnInfo);
										global::Infragistics.Controls.Grids.Primitives.CellsPanel cellsPanel = base.GetElement(mergedColumnInfo, "MergedSummaryRow") as global::Infragistics.Controls.Grids.Primitives.CellsPanel;
										if (cellsPanel == null)
										{
											global::Infragistics.Controls.Grids.Primitives.MergedSummaryRow mergedSummaryRow = new global::Infragistics.Controls.Grids.Primitives.MergedSummaryRow((global::Infragistics.Controls.Grids.RowsManager)row.Manager);
											mergedSummaryRow.MergedColumnInfo = mergedColumnInfo;
											base.RowsPanel.RenderRow(mergedSummaryRow);
											cellsPanel = (global::Infragistics.Controls.Grids.Primitives.CellsPanel)base.AddElement(mergedColumnInfo, "MergedSummaryRow", mergedSummaryRow.Control);
										}
										else
										{
											((global::Infragistics.Controls.Grids.Primitives.MergedSummaryRow)cellsPanel.Row).MergedColumnInfo = mergedColumnInfo;
											base.RowsPanel.RenderRow(cellsPanel.Row);
										}
										for (global::Infragistics.MergedColumnInfo mergedColumnInfo2 = mergedColumnInfo; mergedColumnInfo2 != null; mergedColumnInfo2 = mergedColumnInfo2.ParentMergedColumnInfo)
										{
											this._cellsToUpdate[mergedColumnInfo2].ActualMergedHeight += cellsPanel.DesiredSize.Height;
										}
										num += cellsPanel.DesiredSize.Height;
									}
								}
								global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator fixedRowSeparator = base.GetElement(row, "MergedRowSeparator") as global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator;
								if (fixedRowSeparator == null)
								{
									fixedRowSeparator = (global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator)base.AddElement(row, "MergedRowSeparator", new global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator());
								}
								fixedRowSeparator.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
								if (!this._separtorCells.ContainsKey(row))
								{
									this._separtorCells.Add(row, renderMergeInfo.LastVisibleCell);
								}
								if (readOnlyCollection[num2].Equals(obj))
								{
									bool flag3 = true;
									global::Infragistics.MergedColumnInfo parentMergedColumnInfo = mergedColumnInfo.ParentMergedColumnInfo;
									while (parentMergedColumnInfo != null)
									{
										global::Infragistics.Controls.Grids.Column column3 = parentMergedColumnInfo.MergingObject as global::Infragistics.Controls.Grids.Column;
										if (this._cellsToUpdate.ContainsKey(parentMergedColumnInfo))
										{
											global::Infragistics.Controls.Grids.CellBase cellBase4 = this._cellsToUpdate[parentMergedColumnInfo];
											if (!row.MergeData.IsLastRowInGroup[cellBase4.Column])
											{
												cellBase4.ActualMergedHeight += fixedRowSeparator.DesiredSize.Height;
												flag3 = false;
											}
											else
											{
												if (!flag3)
												{
													cellBase4.ActualMergedHeight += fixedRowSeparator.DesiredSize.Height;
												}
												flag3 = true;
											}
											parentMergedColumnInfo = parentMergedColumnInfo.ParentMergedColumnInfo;
										}
										else
										{
											if (column3 == null || column3.Visibility == global::System.Windows.Visibility.Visible)
											{
												break;
											}
											parentMergedColumnInfo = parentMergedColumnInfo.ParentMergedColumnInfo;
										}
									}
								}
								if (!flag)
								{
									num += fixedRowSeparator.DesiredSize.Height;
									flag = true;
								}
							}
						}
					}
					num2++;
				}
			}
			return num;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00023C8C File Offset: 0x00021E8C
		protected override void MeasureAdorners(global::System.Windows.Size availableSize)
		{
			foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in base.RowsPanel.VisibleManagers)
			{
				if (rowsManagerBase.RenderedMergedCells.Count > 0)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Grids.Column, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo>> keyValuePair in rowsManagerBase.RenderedMergedCells)
					{
						foreach (global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo renderMergeInfo in keyValuePair.Value)
						{
							global::Infragistics.Controls.Grids.Cell cell = (global::Infragistics.Controls.Grids.Cell)renderMergeInfo.Cell;
							global::Infragistics.Controls.Grids.Primitives.MergedContentControl mergedContentControl = base.GetElement(renderMergeInfo.Cell, "MergedContentControl") as global::Infragistics.Controls.Grids.Primitives.MergedContentControl;
							if (mergedContentControl == null)
							{
								if (cell.Column.MergedItemTemplate != null)
								{
									mergedContentControl = (global::Infragistics.Controls.Grids.Primitives.MergedContentControl)base.AddElement(renderMergeInfo.Cell, "MergedContentControl", new global::Infragistics.Controls.Grids.Primitives.MergedContentControl
									{
										DataContext = new global::Infragistics.MergeDataContext
										{
											Records = renderMergeInfo.MergedColumnInfo.Children,
											Value = renderMergeInfo.Key
										},
										Content = cell.Column.MergedItemTemplate.LoadContent()
									});
								}
								else
								{
									mergedContentControl = (global::Infragistics.Controls.Grids.Primitives.MergedContentControl)base.AddElement(renderMergeInfo.Cell, "MergedContentControl", new global::Infragistics.Controls.Grids.Primitives.MergedContentControl
									{
										DataContext = renderMergeInfo.Cell.Row.Data
									});
									global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase columnContentProviderBase = renderMergeInfo.Cell.Column.GenerateContentProvider();
									columnContentProviderBase.IsToolTip = true;
									global::System.Windows.Data.Binding cellBinding = columnContentProviderBase.ResolveBinding(cell);
									mergedContentControl.Content = columnContentProviderBase.ResolveDisplayElement(cell, cellBinding);
									global::Infragistics.Controls.Grids.TemplateColumn templateColumn = cell.Column as global::Infragistics.Controls.Grids.TemplateColumn;
									if (templateColumn != null && templateColumn.ItemTemplate == null && mergedContentControl.Content is global::System.Windows.Controls.ContentPresenter)
									{
										((global::System.Windows.Controls.ContentPresenter)mergedContentControl.Content).Content = renderMergeInfo.Cell.Value;
									}
									mergedContentControl.ContentProvider = columnContentProviderBase;
								}
							}
							if (mergedContentControl.Style != cell.Column.MergeCellStyle)
							{
								global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase.SetControlStyle(mergedContentControl, cell.Column.MergeCellStyle);
							}
							mergedContentControl.HorizontalContentAlignment = cell.Column.HorizontalContentAlignment;
							mergedContentControl.Measure(new global::System.Windows.Size(renderMergeInfo.Cell.Column.ActualWidth, renderMergeInfo.Cell.ActualMergedHeight));
							if (mergedContentControl.ContentProvider != null)
							{
								mergedContentControl.ContentProvider.AdjustDisplayElement(cell);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00023F74 File Offset: 0x00022174
		public override double ArrangeAfterRow(global::Infragistics.Controls.Grids.RowBase row, double top, global::System.Windows.Size finalSize)
		{
			double num = 0.0;
			if (row.MergeData != null)
			{
				if (row.IsMouseOverInternal && row.ColumnLayout.Grid.RowHover == global::Infragistics.Controls.Grids.RowHoverType.Row && row.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
				{
					global::System.Windows.Controls.Panel.SetZIndex(row.Control, 10001);
				}
				if (row.IsActive)
				{
					global::System.Windows.Controls.Panel.SetZIndex(row.Control, 10001);
				}
				global::Infragistics.Controls.Grids.Row row2 = row as global::Infragistics.Controls.Grids.Row;
				if (row2 != null && row2.IsSelected)
				{
					global::System.Windows.Controls.Panel.SetZIndex(row.Control, 10001);
				}
				foreach (global::Infragistics.MergedColumnInfo mergedColumnInfo in row.MergeData.MergedGroups)
				{
					if (mergedColumnInfo.MergingObject != null && row.Cells[(global::Infragistics.Controls.Grids.Column)mergedColumnInfo.MergingObject].IsSelected)
					{
						global::System.Windows.Controls.Panel.SetZIndex(row.Control, 10001);
					}
				}
				global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo> list;
				this._summaryRowLookup.TryGetValue(row, out list);
				if (list != null)
				{
					foreach (global::Infragistics.MergedColumnInfo obj in list)
					{
						global::System.Windows.UIElement element = base.GetElement(obj, "MergedSummaryRow");
						if (element != null)
						{
							element.Arrange(new global::System.Windows.Rect(0.0, top, finalSize.Width, element.DesiredSize.Height));
							num += element.DesiredSize.Height;
							top += element.DesiredSize.Height;
							global::System.Windows.Controls.Panel.SetZIndex(element, 0);
						}
					}
				}
				global::System.Windows.UIElement element2 = base.GetElement(row, "MergedRowSeparator");
				if (element2 != null)
				{
					global::Infragistics.Controls.Grids.CellBase cellBase = this._separtorCells[row];
					if (cellBase != null && cellBase.Control != null)
					{
						element2.Arrange(new global::System.Windows.Rect(cellBase.Control.TransformToVisual(base.RowsPanel).Transform(new global::System.Windows.Point(0.0, 0.0)).X, top, finalSize.Width, element2.DesiredSize.Height));
						double height = element2.DesiredSize.Height;
						num += height;
						top += height;
						global::System.Windows.Controls.Panel.SetZIndex(element2, 0);
						foreach (global::Infragistics.Controls.Grids.Column column in cellBase.Column.ColumnLayout.Columns.FixedAdornerColumns)
						{
							global::Infragistics.Controls.Grids.CellBase cellBase2 = row.Cells[column];
							if (cellBase2.Control != null)
							{
								global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(cellBase2.Control);
								cellBase2.Control.Arrange(new global::System.Windows.Rect(layoutSlot.Left, layoutSlot.Top, column.ActualWidth, layoutSlot.Height + height));
								global::System.Windows.Rect rect = cellBase2.Row.Control.ClipRect.Rect;
								if (rect.IsEmpty)
								{
									rect = new global::System.Windows.Rect(0.0, 0.0, 0.0, 0.0);
								}
								cellBase2.Row.Control.ClipRect.Rect = new global::System.Windows.Rect(rect.X, rect.Y, rect.Width, rect.Height + height);
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00024324 File Offset: 0x00022524
		public override void ArrangeAdornments(global::System.Windows.Size finalSize, double dataRowTop)
		{
			foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in base.RowsPanel.VisibleManagers)
			{
				if (rowsManagerBase.RenderedMergedCells.Count > 0)
				{
					foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Controls.Grids.Column, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo>> keyValuePair in rowsManagerBase.RenderedMergedCells)
					{
						foreach (global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo renderMergeInfo in keyValuePair.Value)
						{
							global::System.Windows.UIElement element = base.GetElement(renderMergeInfo.Cell, "MergedContentControl");
							if (element != null)
							{
								double num = renderMergeInfo.Cell.ActualMergedHeight;
								double num2 = renderMergeInfo.Cell.Column.ActualWidth - renderMergeInfo.Cell.Control.BorderThickness.Right;
								if (num2 < 0.0)
								{
									num2 = 0.0;
								}
								global::System.Windows.Point point = renderMergeInfo.Cell.Control.TransformToVisual(base.RowsPanel).Transform(new global::System.Windows.Point(0.0, 0.0));
								if (point.Y > -999.0)
								{
									if (point.Y < dataRowTop)
									{
										double num3 = dataRowTop - point.Y;
										point.Y = dataRowTop;
										num -= num3;
										if (num < 0.0)
										{
											num = 0.0;
										}
										if (num < renderMergeInfo.Cell.Row.ActualHeight)
										{
											num3 = renderMergeInfo.Cell.Row.ActualHeight - num;
											num = renderMergeInfo.Cell.Row.ActualHeight;
											point.Y -= num3;
										}
									}
									element.Arrange(new global::System.Windows.Rect(point.X, point.Y, num2, num));
									global::System.Windows.Controls.Panel.SetZIndex(element, 1000);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0400023E RID: 574
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.RowBase, global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo>> _summaryRowLookup = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.RowBase, global::System.Collections.Generic.List<global::Infragistics.MergedColumnInfo>>();

		// Token: 0x0400023F RID: 575
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.RowBase, global::Infragistics.Controls.Grids.CellBase> _separtorCells = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.RowBase, global::Infragistics.Controls.Grids.CellBase>();

		// Token: 0x04000240 RID: 576
		private global::System.Collections.Generic.Dictionary<global::Infragistics.MergedColumnInfo, global::Infragistics.Controls.Grids.CellBase> _cellsToUpdate = new global::System.Collections.Generic.Dictionary<global::Infragistics.MergedColumnInfo, global::Infragistics.Controls.Grids.CellBase>();
	}
}
