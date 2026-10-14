using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Security;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using System.Windows.Media;
using Infragistics.Windows.Helpers;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001DE RID: 478
	public class RowsPanel : global::System.Windows.Controls.Panel, global::Infragistics.IRecyclableElementHost
	{
		// Token: 0x06000CA9 RID: 3241 RVA: 0x0002CAC8 File Offset: 0x0002ACC8
		public RowsPanel()
		{
			this._clip = new global::System.Windows.Media.RectangleGeometry();
			base.Clip = this._clip;
			this._topRows = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase>();
			this._bottomRows = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase>();
			this._visibleRows = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.RowBase>();
			this._overrideVerticalMax = -1.0;
			this._visibleManagers = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowsManagerBase>();
			this._reMeasuredCells = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>();
			this._previouslyRemeasuredCells = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase>();
			this._fixedRowsOrderComparer = new global::Infragistics.FixedRowsOrderComparer();
			this._topFixRowSeperators = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator>();
			this._bottomFixRowSeperators = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator>();
			this._nonReleasedRows = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.RowBase>();
			this._notVisibleAndNotArrangedRows = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
			base.Unloaded += this.RowsPanel_Unloaded;
			try
			{
				this.HookSourceChangedHandler();
			}
			catch (global::System.Security.SecurityException)
			{
			}
			base.SetCurrentValue(global::System.Windows.UIElement.IsManipulationEnabledProperty, true);
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x0002CBF8 File Offset: 0x0002ADF8
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x0002CC00 File Offset: 0x0002AE00
		public global::Infragistics.Controls.Grids.XamGrid Grid
		{
			get
			{
				return this._grid;
			}
			internal set
			{
				this._grid = value;
				this.ScrollInfo = this._grid;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x0002CC15 File Offset: 0x0002AE15
		public global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.RowBase> VisibleRows
		{
			get
			{
				return this._visibleRows;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06000CAD RID: 3245 RVA: 0x0002CC1D File Offset: 0x0002AE1D
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowsManagerBase> VisibleManagers
		{
			get
			{
				return this._visibleManagers;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0002CC25 File Offset: 0x0002AE25
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> FixedRowsBottom
		{
			get
			{
				return this._bottomRows;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000CAF RID: 3247 RVA: 0x0002CC2D File Offset: 0x0002AE2D
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> FixedRowsTop
		{
			get
			{
				return this._topRows;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x0002CC35 File Offset: 0x0002AE35
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x0002CC3D File Offset: 0x0002AE3D
		public global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl CustomFilterDialogControl { get; set; }

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x0002CC46 File Offset: 0x0002AE46
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x0002CC4E File Offset: 0x0002AE4E
		public global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl CompoundFilterDialogControl { get; set; }

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x0002CC57 File Offset: 0x0002AE57
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x0002CC5F File Offset: 0x0002AE5F
		private protected global::Infragistics.IProvideScrollInfo ScrollInfo { protected get; private set; }

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x0002CC68 File Offset: 0x0002AE68
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x0002CC70 File Offset: 0x0002AE70
		internal bool InLayoutPhase { get; set; }

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x0002CC79 File Offset: 0x0002AE79
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x0002CC81 File Offset: 0x0002AE81
		internal bool ScrollCellIntoViewInProgress { get; private set; }

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0002CC8A File Offset: 0x0002AE8A
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x0002CC92 File Offset: 0x0002AE92
		internal int ReverCellStartIndex { get; set; }

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x0002CC9B File Offset: 0x0002AE9B
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x0002CCA3 File Offset: 0x0002AEA3
		internal global::Infragistics.Controls.Grids.Column ReverseChildColumn { get; set; }

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0002CCAC File Offset: 0x0002AEAC
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x0002CCB4 File Offset: 0x0002AEB4
		internal bool ReverseCellMeasure { get; set; }

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x0002CCBD File Offset: 0x0002AEBD
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x0002CCC5 File Offset: 0x0002AEC5
		internal global::Infragistics.Controls.Grids.ColumnLayout ReverseColumnLayout { get; set; }

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0002CCCE File Offset: 0x0002AECE
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> RemeasuredCells
		{
			get
			{
				return this._reMeasuredCells;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x0002CCD6 File Offset: 0x0002AED6
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> PreviouslyRemeasuredCells
		{
			get
			{
				return this._previouslyRemeasuredCells;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x0002CCDE File Offset: 0x0002AEDE
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x0002CCE6 File Offset: 0x0002AEE6
		internal global::Infragistics.Controls.Grids.RowsManagerBase HorizontalRowsManager { get; set; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x0002CCEF File Offset: 0x0002AEEF
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x0002CCF7 File Offset: 0x0002AEF7
		internal bool MeasureCalled
		{
			get
			{
				return this._measureCalled;
			}
			set
			{
				this._measureCalled = value;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x0002CD00 File Offset: 0x0002AF00
		internal bool IsWndResizing
		{
			get
			{
				return this._isWndResizing;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0002CD08 File Offset: 0x0002AF08
		internal bool ShouldInvalidateCellMeasure
		{
			get
			{
				return this._shouldInvalidateCellMeasure;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x0002CD10 File Offset: 0x0002AF10
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x0002CD18 File Offset: 0x0002AF18
		internal bool ShouldInvalidateGroupCellMeasure
		{
			get
			{
				return this._shouldInvalidateGroupCellMeasure;
			}
			set
			{
				this._shouldInvalidateGroupCellMeasure = value;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x0002CD21 File Offset: 0x0002AF21
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x0002CD29 File Offset: 0x0002AF29
		internal bool IsResetingRows { get; set; }

		// Token: 0x06000CCE RID: 3278 RVA: 0x0002CD34 File Offset: 0x0002AF34
		public void RegisterFixedRow(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.FixedRowAlignment alignment)
		{
			if (row != null)
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> list = (alignment == global::Infragistics.Controls.Grids.FixedRowAlignment.Top) ? this._topRows : this._bottomRows;
				if (!list.Contains(row))
				{
					list.Add(row);
					list.Sort(this._fixedRowsOrderComparer);
				}
			}
		}

		// Token: 0x06000CCF RID: 3279 RVA: 0x0002CD74 File Offset: 0x0002AF74
		public void UnregisterFixedRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (this._topRows.Contains(row))
			{
				this._topRows.Remove(row);
			}
			else if (this._bottomRows.Contains(row))
			{
				this._bottomRows.Remove(row);
			}
			if (!this._visibleRows.Contains(row))
			{
				this.ReleaseRow(row);
			}
		}

		// Token: 0x06000CD0 RID: 3280 RVA: 0x0002CDCE File Offset: 0x0002AFCE
		public void ResetCachedScrollInfo(bool resetVisibleRows)
		{
			this.ResetCachedScrollInfo(resetVisibleRows, true);
		}

		// Token: 0x06000CD1 RID: 3281 RVA: 0x0002CDD8 File Offset: 0x0002AFD8
		internal void ResetCachedScrollInfo(bool resetVisibleRows, bool invalidateHorizontalMax)
		{
			if (!this.MeasureCalled)
			{
				this._overflowAdjustment = 0.0;
				this._overrideVerticalMax = -1.0;
				this._recalcHorizSBVis = true;
				if (invalidateHorizontalMax)
				{
					foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in this._visibleManagers)
					{
						rowsManagerBase.OverrideHorizontalMax = -1.0;
					}
				}
				if (resetVisibleRows)
				{
					this._onNextMeasureReleaseVisibleRows = true;
				}
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x0002CE70 File Offset: 0x0002B070
		public void ResetRows()
		{
			this.ResetRows(false);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x0002CE94 File Offset: 0x0002B094
		public void ResetRows(bool releaseAll)
		{
			bool flag = this._grid != null && this._grid.IsVisible;
			if (flag && this.InLayoutPhase)
			{
				base.Dispatcher.BeginInvoke(new global::System.Action(delegate()
				{
					this.ResetRows(releaseAll);
				}), new object[0]);
				return;
			}
			this.ResetRowsInternal(releaseAll);
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x0002CF0C File Offset: 0x0002B10C
		internal void ResetRowsInternal(bool releaseAll)
		{
			this.IsResetingRows = true;
			this._measureCalled = false;
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase in this._topRows)
			{
				if (rowBase.Control != null)
				{
					this.ReleaseRow(rowBase);
				}
			}
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in this._bottomRows)
			{
				if (rowBase2.Control != null)
				{
					this.ReleaseRow(rowBase2);
				}
			}
			foreach (global::Infragistics.Controls.Grids.RowBase row in this._visibleRows)
			{
				this.ReleaseRow(row);
			}
			if (releaseAll)
			{
				global::Infragistics.RecyclingManager.Manager.ReleaseAll(this);
			}
			this.Grid.ResetAdorners();
			this._overrideVerticalMax = -1.0;
			this._visibleRows.Clear();
			this.IsResetingRows = false;
			base.InvalidateMeasure();
		}

		// Token: 0x06000CD5 RID: 3285 RVA: 0x0002D044 File Offset: 0x0002B244
		internal void ScrollCellIntoView(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.CellAlignment alignment, global::Infragistics.Controls.Grids.EmptyDelegate callback)
		{
			bool flag = true;
			global::Infragistics.Controls.Grids.Column column = cell.Column;
			global::Infragistics.Controls.Grids.Column column2 = column;
			while (column != null)
			{
				bool flag2 = column.IsGroupBy && this.Grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells;
				if (column.IsFixed != global::Infragistics.Controls.Grids.FixedState.NotFixed || flag2)
				{
					flag = false;
				}
				column2 = column;
				column = column.ParentColumn;
			}
			column = column2;
			this._scrollCellIntoViewCallback = callback;
			if (cell.Row.Manager.ParentRow != null)
			{
				for (global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase expandableRowBase = cell.Row.Manager.ParentRow as global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase; expandableRowBase != null; expandableRowBase = (expandableRowBase.Manager.ParentRow as global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase))
				{
					if (!expandableRowBase.IsExpanded)
					{
						global::Infragistics.Controls.Grids.Primitives.ChildBand childBand = expandableRowBase as global::Infragistics.Controls.Grids.Primitives.ChildBand;
						if (childBand == null || childBand.ResolveIsVisible)
						{
							expandableRowBase.IsExpanded = true;
						}
					}
				}
			}
			int num = this.Grid.InternalRows.IndexOf(cell.Row);
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = cell.Row.Columns.AllVisibleChildColumns;
			int num2 = allVisibleChildColumns.IndexOf(cell.Column);
			if (num2 == -1)
			{
				num2 = 0;
			}
			bool flag3 = true;
			if (cell.Row.Control != null)
			{
				global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this);
				global::System.Windows.Rect layoutSlot2 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(cell.Row.Control);
				if (alignment == global::Infragistics.Controls.Grids.CellAlignment.Top)
				{
					this.ScrollInfo.VerticalScrollBar.Value = (double)num;
				}
				else if (alignment == global::Infragistics.Controls.Grids.CellAlignment.Bottom)
				{
					this._reverseRowStartIndex = num;
					this._reverseMeasure = true;
				}
				else if (cell.Row.Manager.Level != 0 || (this.FixedRowsBottom.IndexOf(cell.Row) == -1 && this.FixedRowsTop.IndexOf(cell.Row) == -1))
				{
					double num3 = 0.0;
					foreach (global::Infragistics.Controls.Grids.RowBase rowBase in this._bottomRows)
					{
						if (rowBase.Control != null)
						{
							num3 += global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(rowBase.Control).Height;
						}
					}
					double num4 = 0.0;
					foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in this._topRows)
					{
						if (rowBase2.Control != null)
						{
							num4 += global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(rowBase2.Control).Height;
						}
					}
					if (layoutSlot2.Height + layoutSlot2.Top + num3 > layoutSlot.Height)
					{
						this._reverseRowStartIndex = num;
						this._reverseMeasure = true;
					}
					else if (layoutSlot2.Top - num4 <= 0.0)
					{
						this.ScrollInfo.VerticalScrollBar.Value = (double)num;
					}
				}
				if (flag)
				{
					global::Infragistics.Controls.Grids.Primitives.CellsPanel control = cell.Row.Control;
					global::Infragistics.Controls.Grids.CellBase cellBase = cell.Row.Cells[column];
					global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> allVisibleColumns = cell.Row.Columns.AllVisibleColumns;
					int num5 = allVisibleColumns.IndexOf(column);
					if (num5 == -1)
					{
						num5 = 0;
					}
					if (cellBase.Control != null)
					{
						if (cell.Column.ParentColumn == null)
						{
							double leftOffsetForRow = global::Infragistics.Controls.Grids.Primitives.RowsPanel.GetLeftOffsetForRow(cell.Row);
							global::System.Windows.Rect layoutSlot3 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(cellBase.Control);
							if (layoutSlot3.Width + layoutSlot3.Left > layoutSlot.Width)
							{
								this.ReverCellStartIndex = num5;
								this.ReverseCellMeasure = true;
								this.ReverseColumnLayout = cell.Row.ColumnLayout;
								cell.Row.IsHorizontallyAlignedBy = true;
								cell.Row.ShouldInvalidateHorizontalScroll = false;
							}
							else if (layoutSlot3.Left - leftOffsetForRow < 0.0)
							{
								control.SetScrollLeft((double)num2);
							}
						}
						else
						{
							this.SetScrollForCellInGroupColumn(cell, cell.Row, num5, num2);
						}
					}
					else
					{
						global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells = control.VisibleCells;
						if (visibleCells.Count > 0)
						{
							int num6 = allVisibleColumns.IndexOf(visibleCells[visibleCells.Count - 1].Column);
							if (num6 == -1 && visibleCells.Count > 1)
							{
								num6 = allVisibleColumns.IndexOf(visibleCells[visibleCells.Count - 2].Column);
							}
							if (num6 != -1)
							{
								if (num5 > num6)
								{
									this.ReverCellStartIndex = num5;
									this.ReverseCellMeasure = true;
									this.ReverseChildColumn = cell.Column;
									this.ReverseColumnLayout = cell.Row.ColumnLayout;
								}
								else
								{
									control.SetScrollLeft((double)num2);
								}
							}
						}
					}
				}
				this.RenderRow(cell.Row, this._previousWidth);
				cell.Row.Manager.OverrideHorizontalMax = -1.0;
			}
			else if (this.VisibleRows.Count > 0)
			{
				if (alignment == global::Infragistics.Controls.Grids.CellAlignment.Top)
				{
					this.ScrollInfo.VerticalScrollBar.Value = (double)num;
				}
				else if (alignment == global::Infragistics.Controls.Grids.CellAlignment.Bottom)
				{
					this._reverseRowStartIndex = num;
					this._reverseMeasure = true;
				}
				else
				{
					int num7 = this.Grid.InternalRows.IndexOf(this.VisibleRows[this.VisibleRows.Count - 1]);
					if (num > num7)
					{
						this._reverseRowStartIndex = num;
						this._reverseMeasure = true;
					}
					else
					{
						if ((double)num > this.ScrollInfo.VerticalScrollBar.Maximum)
						{
							this.ScrollInfo.VerticalScrollBar.Maximum = (double)num;
						}
						this.ScrollInfo.VerticalScrollBar.Value = (double)num;
					}
				}
				if (flag)
				{
					int level = cell.Row.Manager.Level;
					global::Infragistics.Controls.Grids.RowBase rowBase3 = null;
					foreach (global::Infragistics.Controls.Grids.RowBase rowBase4 in this.VisibleRows)
					{
						if (level == rowBase4.Manager.Level && rowBase4.GetType() == cell.Row.GetType() && rowBase4.ColumnLayout == cell.Row.ColumnLayout)
						{
							rowBase3 = rowBase4;
							break;
						}
					}
					if (rowBase3 == null)
					{
						this.RenderRow(cell.Row, this._previousWidth);
						rowBase3 = cell.Row;
					}
					global::Infragistics.Controls.Grids.Primitives.CellsPanel control2 = rowBase3.Control;
					global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells2 = control2.VisibleCells;
					if (visibleCells2.Count > 0)
					{
						global::Infragistics.Controls.Grids.Column column3 = cell.Column;
						while (column3.ParentColumn != null)
						{
							column3 = column3.ParentColumn;
						}
						global::Infragistics.Controls.Grids.CellBase cellBase2 = cell.Row.Cells[column3];
						global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> allVisibleColumns2 = cell.Row.Columns.AllVisibleColumns;
						int num8 = allVisibleColumns2.IndexOf(column3);
						if (num8 == -1)
						{
							num8 = 0;
						}
						int num7 = allVisibleColumns2.IndexOf(visibleCells2[visibleCells2.Count - 1].Column);
						if (num7 == -1 && visibleCells2.Count > 1)
						{
							num7 = allVisibleColumns2.IndexOf(visibleCells2[visibleCells2.Count - 2].Column);
						}
						if (num7 != -1 && rowBase3.CanScrollHorizontally)
						{
							int num9 = allVisibleColumns2.IndexOf(visibleCells2[0].Column);
							bool isHorizontallyAlignedBy = cell.Row.IsHorizontallyAlignedBy;
							int visibleCellsLastIndex = this.GetVisibleCellsLastIndex(visibleCells2, num8, this._previousWidth);
							if (num8 > num7 || (visibleCellsLastIndex != -1 && visibleCellsLastIndex <= num8))
							{
								this.ReverCellStartIndex = num8;
								this.ReverseCellMeasure = true;
								if (cell.Column.ParentColumn != null)
								{
									this.ReverseChildColumn = cell.Column;
								}
								this.ReverseColumnLayout = rowBase3.ColumnLayout;
								cell.Row.IsHorizontallyAlignedBy = true;
								cell.Row.ShouldInvalidateHorizontalScroll = (visibleCellsLastIndex < num8);
							}
							else if (num8 < num9)
							{
								control2.SetScrollLeft((double)num2);
							}
							else if (cell.Column.ParentColumn != null)
							{
								this.SetScrollForCellInGroupColumn(cell, rowBase3, num8, num2);
							}
							flag3 = (isHorizontallyAlignedBy == cell.Row.IsHorizontallyAlignedBy || !cell.Row.IsHorizontallyAlignedBy);
						}
					}
					this.RenderRow(cell.Row, this._previousWidth);
					cell.Row.Manager.OverrideHorizontalMax = -1.0;
				}
			}
			this._scrollIntoViewCell = cell;
			this.ScrollCellIntoViewInProgress = true;
			this._scrollIntoViewCellAlignment = alignment;
			if (flag3)
			{
				base.InvalidateMeasure();
			}
		}

		// Token: 0x06000CD6 RID: 3286 RVA: 0x0002D87C File Offset: 0x0002BA7C
		protected virtual global::System.Windows.Size RenderRow(global::Infragistics.Controls.Grids.RowBase row, double availableWidth)
		{
			if (row.Control == null)
			{
				global::Infragistics.RecyclingManager.Manager.AttachElement(row, this);
				row.Control.Owner = this;
			}
			double num = this._invalidateRowHeight;
			if (row.Control.PreviousInvalidateHeight == num)
			{
				num = (double)((num == 10000.0) ? 10001 : 10000);
			}
			if (!this._visibleManagers.Contains(row.Manager))
			{
				this._visibleManagers.Add(row.Manager);
				row.Manager.OverflowAdjustment = 0.0;
				row.Manager.IsFirstRowRenderingInThisLayoutCycle = true;
				row.Manager.CachedIndentation = 0.0;
				row.Manager.RowWidth = 0.0;
				row.Manager.IndexOfFirstColumnRendered = 0;
				row.Manager.RenderedMergedCells.Clear();
			}
			row.Control.Measure(new global::System.Windows.Size(availableWidth, num));
			double num2 = row.Control.DesiredSize.Height;
			foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner in this.Grid.RenderAdorners)
			{
				num2 += xamGridRenderAdorner.MeasureAfterRow(row);
			}
			return new global::System.Windows.Size(row.Control.DesiredSize.Width, num2);
		}

		// Token: 0x06000CD7 RID: 3287 RVA: 0x0002D9F0 File Offset: 0x0002BBF0
		protected virtual void UpdateVerticalScrollInfo(int totalRowCount)
		{
			if (!this.DoScrollBarValidationPass())
			{
				return;
			}
			global::Infragistics.IProvideScrollInfo scrollInfo = this.ScrollInfo;
			global::System.Windows.Controls.Primitives.ScrollBar verticalScrollBar = scrollInfo.VerticalScrollBar;
			if (verticalScrollBar != null)
			{
				double value = verticalScrollBar.Value;
				verticalScrollBar.Maximum = this._overrideVerticalMax;
				if (verticalScrollBar.Value != value && value < verticalScrollBar.Maximum && !this._ensuerVertSBValueUpdated)
				{
					verticalScrollBar.Value = value;
				}
				this._ensuerVertSBValueUpdated = false;
				if (this._resetVertSBViewportSize)
				{
					verticalScrollBar.ViewportSize = (double)this._visibleRows.Count;
					this._resetVertSBViewportSize = false;
				}
				double num = (double)(this._visibleRows.Count - 1);
				if (num < 0.0)
				{
					num = 0.0;
				}
				verticalScrollBar.LargeChange = num;
				verticalScrollBar.SmallChange = 1.0;
				global::System.Windows.Visibility visibility = verticalScrollBar.Visibility;
				if (this._updateValueOnly)
				{
					this._updateValueOnly = false;
				}
				else
				{
					verticalScrollBar.Visibility = ((this._overrideVerticalMax <= 0.0 || totalRowCount == 0) ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
				}
				if (verticalScrollBar.Visibility != visibility && verticalScrollBar.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					verticalScrollBar.Value = 0.0;
				}
				if (verticalScrollBar.Visibility != visibility && verticalScrollBar.Visibility == global::System.Windows.Visibility.Visible)
				{
					this._updateValueOnly = true;
				}
			}
		}

		// Token: 0x06000CD8 RID: 3288 RVA: 0x0002DB24 File Offset: 0x0002BD24
		protected virtual void UpdateHorizontalScrollInfo()
		{
			if (!this.DoScrollBarValidationPass())
			{
				return;
			}
			global::Infragistics.IProvideScrollInfo scrollInfo = this.ScrollInfo;
			global::System.Windows.Controls.Primitives.ScrollBar horizontalScrollBar = scrollInfo.HorizontalScrollBar;
			if (horizontalScrollBar != null)
			{
				int num = 0;
				int num2 = 0;
				double num3 = -1.0;
				foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in this._visibleManagers)
				{
					if (rowsManagerBase.OverrideHorizontalMax >= num3 && rowsManagerBase.OverrideHorizontalMax > 0.0)
					{
						this.HorizontalRowsManager = rowsManagerBase;
						num3 = rowsManagerBase.OverrideHorizontalMax;
						num = rowsManagerBase.ScrollableCellCount;
						num2 = rowsManagerBase.VisibleCellCount;
					}
				}
				if (num3 != -1.0 && !double.IsPositiveInfinity(num3))
				{
					if (horizontalScrollBar.Value > num3)
					{
						horizontalScrollBar.Value = num3;
					}
					horizontalScrollBar.Maximum = num3;
					if (this._resetHorizSBViewportSize)
					{
						horizontalScrollBar.ViewportSize = (double)num2;
						this._resetHorizSBViewportSize = false;
					}
				}
				else
				{
					horizontalScrollBar.Maximum = 0.0;
				}
				horizontalScrollBar.LargeChange = (double)num2;
				horizontalScrollBar.SmallChange = 1.0;
				bool flag = num3 <= 0.0 && (num2 == num || num == 0);
				if (horizontalScrollBar.Visibility == global::System.Windows.Visibility.Collapsed || this._recalcHorizSBVis)
				{
					horizontalScrollBar.Visibility = (flag ? global::System.Windows.Visibility.Collapsed : global::System.Windows.Visibility.Visible);
					this._recalcHorizSBVis = false;
					horizontalScrollBar.IsEnabled = true;
				}
				else if (flag)
				{
					if (horizontalScrollBar.IsEnabled)
					{
						horizontalScrollBar.Value = 0.0;
						horizontalScrollBar.Maximum = 0.0;
						horizontalScrollBar.IsEnabled = false;
						if (horizontalScrollBar.Visibility != global::System.Windows.Visibility.Collapsed)
						{
							this._ignoreNextScrollUpdate = true;
						}
					}
					horizontalScrollBar.Visibility = global::System.Windows.Visibility.Collapsed;
				}
				else if (!horizontalScrollBar.IsEnabled)
				{
					horizontalScrollBar.IsEnabled = true;
					horizontalScrollBar.Visibility = global::System.Windows.Visibility.Visible;
				}
				if (horizontalScrollBar.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					horizontalScrollBar.Value = 0.0;
				}
			}
		}

		// Token: 0x06000CD9 RID: 3289 RVA: 0x0002DD10 File Offset: 0x0002BF10
		public static bool ArrangeRow(global::Infragistics.Controls.Grids.RowBase row, double left, double top, double width, double height)
		{
			row.Control.ArrangeRaised = false;
			row.Control.Arrange(new global::System.Windows.Rect(left, top, width, height));
			return row.Control.ArrangeRaised;
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x0002DD3E File Offset: 0x0002BF3E
		protected internal void ResetDataRows()
		{
			this.RemoveDataRows(this._topRows);
			this.RemoveDataRows(this._bottomRows);
			this.RemoveDataRows(this._visibleRows);
			this.MeasureCalled = false;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x0002DD6B File Offset: 0x0002BF6B
		private void ReleaseRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (!global::Infragistics.RecyclingManager.Manager.ReleaseElement(row, this))
			{
				this._nonReleasedRows.Add(row);
			}
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x0002DD88 File Offset: 0x0002BF88
		private void ThrowoutUnusedRows(global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> previousVisibleRows, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator> previousFixedRowSeparators)
		{
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase in previousVisibleRows)
			{
				if (!this._visibleRows.Contains(rowBase) && rowBase.Control != null)
				{
					this.ReleaseRow(rowBase);
				}
			}
			foreach (global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator fixedRowSeparator in previousFixedRowSeparators)
			{
				if (!this._topFixRowSeperators.Contains(fixedRowSeparator) && !this._bottomFixRowSeperators.Contains(fixedRowSeparator))
				{
					base.Children.Remove(fixedRowSeparator);
				}
			}
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x0002DE4C File Offset: 0x0002C04C
		private global::System.Windows.Size ResolveBaseSize(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			if (result.Height == 0.0 && !double.IsInfinity(availableSize.Height) && !double.IsNaN(availableSize.Height))
			{
				result.Height = availableSize.Height;
			}
			if (result.Width == 0.0 && !double.IsInfinity(availableSize.Width) && !double.IsNaN(availableSize.Width))
			{
				result.Width = availableSize.Width;
			}
			return result;
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x0002DEDC File Offset: 0x0002C0DC
		private void RemoveDataRows(global::System.Collections.Generic.IList<global::Infragistics.Controls.Grids.RowBase> rows)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase>();
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase in rows)
			{
				if (rowBase.RowType == global::Infragistics.Controls.Grids.RowType.DataRow)
				{
					this.ReleaseRow(rowBase);
					list.Add(rowBase);
				}
			}
			foreach (global::Infragistics.Controls.Grids.RowBase item in list)
			{
				rows.Remove(item);
			}
		}

		// Token: 0x06000CDF RID: 3295 RVA: 0x0002DF78 File Offset: 0x0002C178
		private static double GetLeftOffsetForRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			double num = 0.0;
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase in row.Control.VisibleFixedLeftCells)
			{
				num += global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(cellBase.Control).Width;
			}
			num += row.Manager.ResolveIndentation(row);
			return num;
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
		private void SetScrollForCellInGroupColumn(global::Infragistics.Controls.Grids.CellBase cell, global::Infragistics.Controls.Grids.RowBase referenceRow, int cellIndex, int childColumnIndex)
		{
			double leftOffsetForRow = global::Infragistics.Controls.Grids.Primitives.RowsPanel.GetLeftOffsetForRow(referenceRow);
			global::Infragistics.Controls.Grids.Column column = cell.Column.ResolveRootColumn();
			global::Infragistics.Controls.Grids.Primitives.CellsPanel control = referenceRow.Control;
			global::Infragistics.Controls.Grids.CellBase cellBase = referenceRow.Cells[cell.Column];
			if (cellBase.Control == null)
			{
				control.RenderCell(cellBase);
			}
			global::Infragistics.Controls.Grids.Primitives.CellControlBase control2 = cellBase.Control;
			global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(control2);
			global::System.Windows.Point point = control2.TransformToVisual(this).Transform(new global::System.Windows.Point(0.0, 0.0));
			global::System.Windows.Rect layoutSlot2 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(control);
			global::System.Windows.Rect layoutSlot3 = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(referenceRow.Cells[column].Control);
			if (layoutSlot.Width + point.X > layoutSlot2.Width)
			{
				if (layoutSlot.Width <= layoutSlot2.Width)
				{
					this.ReverCellStartIndex = cellIndex;
					this.ReverseCellMeasure = true;
					this.ReverseChildColumn = cell.Column;
					this.ReverseColumnLayout = cell.Row.ColumnLayout;
					return;
				}
			}
			else if (point.X - leftOffsetForRow < 0.0 && layoutSlot3.Width > 0.0)
			{
				control.SetScrollLeft((double)childColumnIndex);
			}
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x0002E116 File Offset: 0x0002C316
		[global::System.Security.SecuritySafeCritical]
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private void HookSourceChangedHandler()
		{
			global::System.Windows.PresentationSource.AddSourceChangedHandler(this, new global::System.Windows.SourceChangedEventHandler(this.OnElementSourceChanged));
		}

		// Token: 0x06000CE2 RID: 3298 RVA: 0x0002E12C File Offset: 0x0002C32C
		private void HookWndProc(global::System.Windows.Interop.HwndSource oldSource, global::System.Windows.Interop.HwndSource newSource)
		{
			if (oldSource != null)
			{
				oldSource.RemoveHook(this._hook);
			}
			if (newSource != null)
			{
				this._hook = new global::System.Windows.Interop.HwndSourceHook(this.WndProc);
				try
				{
					newSource.AddHook(this._hook);
				}
				catch (global::System.Security.SecurityException)
				{
				}
			}
		}

		// Token: 0x06000CE3 RID: 3299 RVA: 0x0002E180 File Offset: 0x0002C380
		private int GetVisibleCellsLastIndex(global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> visibleCells, int cellIndex, double availableWidth)
		{
			double num = 0.0;
			int num2 = 0;
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase in visibleCells)
			{
				num += cellBase.Column.ActualWidth;
				if (num > availableWidth)
				{
					return num2;
				}
				num2++;
			}
			return -1;
		}

		// Token: 0x06000CE4 RID: 3300 RVA: 0x0002E1F0 File Offset: 0x0002C3F0
		private bool UpdateDiffRowsSizes(bool hasDiffRowsSizes, double currentRowHeight, double previousRowHeight)
		{
			if (!hasDiffRowsSizes)
			{
				hasDiffRowsSizes = (currentRowHeight != previousRowHeight);
			}
			return hasDiffRowsSizes;
		}

		// Token: 0x06000CE5 RID: 3301 RVA: 0x0002E200 File Offset: 0x0002C400
		private void CalculateActualVerticalSBMax(double currentHeight, double availableHeight)
		{
			if (currentHeight <= 0.0 || availableHeight <= 0.0 || !this.IsLastRowInView())
			{
				return;
			}
			int num = 0;
			while (this._visibleRows.Count > num && this._visibleRows[num].RowType != global::Infragistics.Controls.Grids.RowType.DataRow)
			{
				num++;
			}
			if (this._visibleRows.Count <= num)
			{
				return;
			}
			double actualHeight = this._visibleRows[num].ActualHeight;
			double num2 = currentHeight - actualHeight;
			while (num2 > availableHeight && num < this._visibleRows.Count)
			{
				num++;
				actualHeight = this._visibleRows[num].ActualHeight;
				num2 -= actualHeight;
			}
			double num3 = actualHeight - global::System.Math.Max(availableHeight - num2, 0.0);
			double num4 = (double)this._visibleRows[num].Index + num3 / actualHeight;
			global::System.Windows.Controls.Primitives.ScrollBar verticalScrollBar = this.ScrollInfo.VerticalScrollBar;
			if (num4 > 0.0)
			{
				if (!double.IsInfinity(num4))
				{
					this._measureMax = num4;
				}
				if (num4 < this._measureScrollBarValue)
				{
					this._measureScrollBarValue = num4;
					if (verticalScrollBar != null)
					{
						verticalScrollBar.Value = num4;
					}
				}
			}
		}

		// Token: 0x06000CE6 RID: 3302 RVA: 0x0002E320 File Offset: 0x0002C520
		private bool IsLastRowInView()
		{
			return this._visibleRows.Count > 1 && this.Grid.InternalRows.Count > 1 && this._visibleRows[this._visibleRows.Count - 1].Equals(this.Grid.InternalRows[this.Grid.InternalRows.Count - 1]);
		}

		// Token: 0x06000CE7 RID: 3303 RVA: 0x0002E38F File Offset: 0x0002C58F
		private bool DoScrollBarValidationPass()
		{
			if (this._ignoreNextScrollUpdate)
			{
				this._ignoreNextScrollUpdate = false;
				return false;
			}
			return this.Grid.IsLoaded;
		}

		// Token: 0x06000CE8 RID: 3304 RVA: 0x0002E3B2 File Offset: 0x0002C5B2
		internal void RenderRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			this.RenderRow(row, this._previousWidth);
		}

		// Token: 0x06000CE9 RID: 3305 RVA: 0x0002E3C2 File Offset: 0x0002C5C2
		internal void InvalidateMeasureInternal()
		{
			base.InvalidateMeasure();
		}

		// Token: 0x06000CEA RID: 3306 RVA: 0x0002E3CA File Offset: 0x0002C5CA
		internal void InvalidateMeasureInternal(global::Infragistics.Controls.Grids.EmptyDelegate callback)
		{
			this._invalidateMeasureCallback = callback;
			base.InvalidateMeasure();
		}

		// Token: 0x06000CEB RID: 3307 RVA: 0x0002E3DC File Offset: 0x0002C5DC
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this.Grid == null || !this.Grid.IsLoaded)
			{
				return base.MeasureOverride(availableSize);
			}
			if ((this._measureCalled && this._previousWidth == availableSize.Width && this._previousHeight == availableSize.Height) || this.IsResetingRows)
			{
				return base.DesiredSize;
			}
			this._measureCalled = true;
			if (this.Grid.IsDeferredScrollingCurrently)
			{
				return this.ResolveBaseSize(availableSize);
			}
			this._hasInfiniteHeight = double.IsInfinity(availableSize.Height);
			if (this._previousWidth != availableSize.Width)
			{
				this._resetHorizSBViewportSize = true;
			}
			if (this._previousHeight != availableSize.Height)
			{
				this._resetVertSBViewportSize = true;
			}
			foreach (global::Infragistics.Controls.Grids.RowsManagerBase rowsManagerBase in this._visibleManagers)
			{
				rowsManagerBase.OverflowAdjustment = 0.0;
				rowsManagerBase.IsFirstRowRenderingInThisLayoutCycle = true;
				rowsManagerBase.CachedIndentation = 0.0;
				rowsManagerBase.RowWidth = 0.0;
				rowsManagerBase.IndexOfFirstColumnRendered = 0;
				rowsManagerBase.RenderedMergedCells.Clear();
			}
			foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner in this.Grid.RenderAdorners)
			{
				xamGridRenderAdorner.Initialize();
			}
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase>();
			if (this._previousHeight != availableSize.Height)
			{
				this._overrideVerticalMax = -1.0;
			}
			if (this.VisibleRows.Count == 0)
			{
				this._recalcHorizSBVis = true;
			}
			if (this._onNextMeasureReleaseVisibleRows)
			{
				foreach (global::Infragistics.Controls.Grids.RowBase row in this.VisibleRows)
				{
					this.ReleaseRow(row);
				}
				this.VisibleRows.Clear();
				this._onNextMeasureReleaseVisibleRows = false;
			}
			this._previousHeight = availableSize.Height;
			this._previousWidth = availableSize.Width;
			this.InLayoutPhase = true;
			this._invalidateRowHeight = (double)((this._invalidateRowHeight == 10000.0) ? 10001 : 10000);
			this._visibleManagers.Clear();
			double num = 0.0;
			double num2 = 0.0;
			double num3 = availableSize.Height;
			double num4 = 0.0;
			global::System.Windows.Controls.Primitives.ScrollBar verticalScrollBar = this.ScrollInfo.VerticalScrollBar;
			double num5 = (verticalScrollBar != null) ? verticalScrollBar.Value : 0.0;
			int count = this.Grid.InternalRows.Count;
			global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator>(this._topFixRowSeperators);
			list2.AddRange(this._bottomFixRowSeperators);
			this._topFixRowSeperators.Clear();
			this._bottomFixRowSeperators.Clear();
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase in this._topRows)
			{
				global::System.Windows.Size size = this.RenderRow(rowBase, availableSize.Width);
				num2 += size.Height;
				num4 = global::System.Math.Max(num4, size.Width);
				if (rowBase.RequiresFixedRowSeparator)
				{
					global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator fixedRowSeparator = rowBase.ResolveSeparator();
					if (!base.Children.Contains(fixedRowSeparator))
					{
						base.Children.Add(fixedRowSeparator);
					}
					fixedRowSeparator.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					num2 += fixedRowSeparator.DesiredSize.Height;
					this._topFixRowSeperators.Add(fixedRowSeparator);
				}
			}
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in this._bottomRows)
			{
				global::System.Windows.Size size2 = this.RenderRow(rowBase2, availableSize.Width);
				num2 += size2.Height;
				num4 = global::System.Math.Max(num4, size2.Width);
				if (rowBase2.RequiresFixedRowSeparator)
				{
					global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator fixedRowSeparator2 = rowBase2.ResolveSeparator();
					if (!base.Children.Contains(fixedRowSeparator2))
					{
						base.Children.Add(fixedRowSeparator2);
					}
					fixedRowSeparator2.Measure(new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity));
					num2 += fixedRowSeparator2.DesiredSize.Height;
					this._bottomFixRowSeperators.Add(fixedRowSeparator2);
				}
			}
			num3 -= num2;
			if (count == 0)
			{
				list.AddRange(this.VisibleRows);
				this.VisibleRows.Clear();
				this.ThrowoutUnusedRows(list, list2);
				if (double.IsPositiveInfinity(num3))
				{
					availableSize.Height = num2;
				}
				foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner2 in this.Grid.RenderAdorners)
				{
					xamGridRenderAdorner2.Measure(availableSize);
				}
				return this.ResolveBaseSize(availableSize);
			}
			int num6 = 0;
			double num7 = 0.0;
			bool flag = false;
			if (!this._reverseMeasure)
			{
				num6 = (int)num5;
				if (num6 >= count)
				{
					num6 = count - 1;
				}
				global::Infragistics.Controls.Grids.RowBase rowBase3 = this.Grid.InternalRows[num6];
				if (this.VisibleRows.Count > 0)
				{
					int num8 = this.VisibleRows.IndexOf(rowBase3);
					if (num8 != 0)
					{
						if (num8 != -1)
						{
							for (int i = num8; i > 0; i--)
							{
								global::Infragistics.Controls.Grids.RowBase row2 = this.VisibleRows[0];
								this.ReleaseRow(row2);
								this.VisibleRows.RemoveAt(0);
							}
							list.AddRange(this.VisibleRows);
						}
						else
						{
							int num9 = this.VisibleRows.Count;
							int num10 = this.Grid.InternalRows.IndexOf(this.VisibleRows[0]);
							int num11 = num10 + num9 - 1;
							if (num11 < num6)
							{
								foreach (global::Infragistics.Controls.Grids.RowBase row3 in this.VisibleRows)
								{
									this.ReleaseRow(row3);
								}
								this.VisibleRows.Clear();
							}
							else
							{
								num9--;
								int num12 = num10 - num6;
								int num13 = 0;
								while (num13 < num12 && num13 < num9)
								{
									int index = num9 - num13;
									global::Infragistics.Controls.Grids.RowBase row4 = this.VisibleRows[index];
									this.ReleaseRow(row4);
									this.VisibleRows.RemoveAt(index);
									num13++;
								}
							}
							list.AddRange(this.VisibleRows);
						}
					}
					else
					{
						list.AddRange(this.VisibleRows);
					}
					this.VisibleRows.Clear();
				}
				if (num6 > 0)
				{
					global::Infragistics.Controls.Grids.RowBase rowBase4 = this.Grid.InternalRows[num6 - 1];
				}
				global::System.Windows.Size size3 = this.RenderRow(rowBase3, availableSize.Width);
				double height = size3.Height;
				num4 = global::System.Math.Max(num4, size3.Width);
				num += height;
				this._visibleRows.Add(rowBase3);
				if (verticalScrollBar != null)
				{
					double num14 = verticalScrollBar.Value - (double)((int)verticalScrollBar.Value);
					num7 = height * num14;
					num -= num7;
					this._measureScrollBarValue = verticalScrollBar.Value;
				}
				int j = num6 + 1;
				while (j < count && num < num3)
				{
					global::Infragistics.Controls.Grids.RowBase rowBase5 = this.Grid.InternalRows[j];
					global::System.Windows.Size size4 = this.RenderRow(rowBase5, availableSize.Width);
					num += size4.Height;
					num4 = global::System.Math.Max(num4, size4.Width);
					this._visibleRows.Add(rowBase5);
					flag = this.UpdateDiffRowsSizes(flag, size4.Height, this._visibleRows[this._visibleRows.Count - 2].ActualHeight);
					j++;
				}
				num += num7;
				num6--;
			}
			else
			{
				list.AddRange(this.VisibleRows);
				this.VisibleRows.Clear();
				num6 = this._reverseRowStartIndex;
				if (num6 >= count)
				{
					num6 = 0;
				}
			}
			this._measureMax = double.NaN;
			if (num < num3 && this._visibleRows.Count < count)
			{
				for (int j = num6; j >= 0; j--)
				{
					global::Infragistics.Controls.Grids.RowBase rowBase6 = this.Grid.InternalRows[j];
					global::System.Windows.Size size5 = this.RenderRow(rowBase6, availableSize.Width);
					double height = size5.Height;
					num4 = global::System.Math.Max(num4, size5.Width);
					num += height;
					this._visibleRows.Insert(0, rowBase6);
					if (this._visibleRows.Count > j + 1)
					{
						flag = this.UpdateDiffRowsSizes(flag, height, this._visibleRows[j + 1].ActualHeight);
					}
					if (num >= num3)
					{
						if (this._reverseMeasure)
						{
							num7 = (num - num3) / height;
							double num15 = (double)j + num7;
							this.ScrollInfo.VerticalScrollBar.Value = num15;
							if (this.ScrollInfo.VerticalScrollBar.Value != num15)
							{
								this._ensuerVertSBValueUpdated = true;
							}
						}
						num5 = (double)j + (num - num3) / height;
						break;
					}
				}
			}
			if (flag)
			{
				this.CalculateActualVerticalSBMax(num, num3);
			}
			foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner3 in this.Grid.RenderAdorners)
			{
				xamGridRenderAdorner3.Measure(availableSize);
			}
			bool flag2 = false;
			if (this.Grid.InternalRows.Count != count)
			{
				this._overrideVerticalMax = -1.0;
				this._measureCalled = false;
				base.Measure(availableSize);
				flag2 = true;
			}
			this.ThrowoutUnusedRows(list, list2);
			if (flag2)
			{
				return base.DesiredSize;
			}
			this._overflowAdjustment = num - num3;
			double num16 = availableSize.Width;
			if (double.IsPositiveInfinity(num16))
			{
				num16 = num4;
				if (!this._measureCalledInfinite)
				{
					this._measureCalled = false;
					this._measureCalledInfinite = true;
					base.Measure(availableSize);
				}
			}
			if (double.IsPositiveInfinity(availableSize.Height))
			{
				num += num2;
			}
			else
			{
				num = availableSize.Height;
			}
			if (num < 0.0)
			{
				num = 0.0;
			}
			this._shouldInvalidateGroupCellMeasure = false;
			this._shouldInvalidateCellMeasure = false;
			return new global::System.Windows.Size(num16, num);
		}

		// Token: 0x06000CEC RID: 3308 RVA: 0x0002EE94 File Offset: 0x0002D094
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			this._measureCalled = false;
			this._measureCalledInfinite = false;
			this.InLayoutPhase = false;
			bool flag = false;
			if (this.Grid.IsDeferredScrollingCurrently || this.IsResetingRows)
			{
				return base.ArrangeOverride(finalSize);
			}
			this._clip.Rect = new global::System.Windows.Rect(0.0, 0.0, finalSize.Width, finalSize.Height);
			if (this._notVisibleAndNotArrangedRows.Count > 0)
			{
				global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list = new global::System.Collections.Generic.List<global::System.Windows.FrameworkElement>();
				foreach (global::System.Windows.FrameworkElement frameworkElement in this._notVisibleAndNotArrangedRows)
				{
					global::Infragistics.Controls.Grids.Primitives.CellsPanel cellsPanel = (global::Infragistics.Controls.Grids.Primitives.CellsPanel)frameworkElement;
					if (global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(cellsPanel) != this._hiddenRowRect)
					{
						cellsPanel.ArrangeRaised = false;
						cellsPanel.Arrange(this._hiddenRowRect);
						if (!cellsPanel.ArrangeRaised)
						{
							list.Add(cellsPanel);
							break;
						}
					}
				}
				this._notVisibleAndNotArrangedRows.Clear();
				this._notVisibleAndNotArrangedRows.AddRange(list);
			}
			global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> list2;
			if (this._unloadedSoResetAll)
			{
				list2 = global::Infragistics.RecyclingManager.Manager.GetAvailableElements(this);
				this._unloadedSoResetAll = false;
			}
			else
			{
				list2 = global::Infragistics.RecyclingManager.Manager.GetRecentlyAvailableElements(this, true);
			}
			foreach (global::System.Windows.FrameworkElement frameworkElement2 in list2)
			{
				global::Infragistics.Controls.Grids.Primitives.CellsPanel cellsPanel2 = (global::Infragistics.Controls.Grids.Primitives.CellsPanel)frameworkElement2;
				cellsPanel2.ArrangeRaised = false;
				cellsPanel2.Arrange(this._hiddenRowRect);
				if (!cellsPanel2.ArrangeRaised)
				{
					this._notVisibleAndNotArrangedRows.Add(cellsPanel2);
				}
			}
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase in this._nonReleasedRows)
			{
				if (rowBase.Control != null)
				{
					rowBase.Control.Arrange(this._hiddenRowRect);
				}
			}
			this._nonReleasedRows.Clear();
			int count = this.Grid.InternalRows.Count;
			if (this.Grid.IsColumnResizing)
			{
				this.UpdateHorizontalScrollInfo();
			}
			double num = 0.0;
			double num2 = 0.0;
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase2 in this._topRows)
			{
				if (rowBase2.Control != null)
				{
					double height = rowBase2.Control.DesiredSize.Height;
					global::Infragistics.Controls.Grids.Primitives.RowsPanel.ArrangeRow(rowBase2, 0.0, num, global::System.Math.Max(finalSize.Width, rowBase2.Control.DesiredSize.Width), height);
					global::System.Windows.Controls.Panel.SetZIndex(rowBase2.Control, 10003);
					num += height;
					num2 += height;
					if (rowBase2.RequiresFixedRowSeparator)
					{
						global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator fixedRowSeparator = rowBase2.ResolveSeparator();
						fixedRowSeparator.Style = this._grid.FixedRowSeparatorStyle;
						fixedRowSeparator.Arrange(new global::System.Windows.Rect(0.0, num, finalSize.Width, fixedRowSeparator.DesiredSize.Height));
						num += fixedRowSeparator.DesiredSize.Height;
						global::System.Windows.Controls.Panel.SetZIndex(fixedRowSeparator, 10002);
					}
				}
			}
			double num3 = finalSize.Height;
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase3 in this._bottomRows)
			{
				if (rowBase3.Control != null)
				{
					double height2 = rowBase3.Control.DesiredSize.Height;
					num3 -= height2;
					num2 += height2;
					global::System.Windows.Controls.Panel.SetZIndex(rowBase3.Control, 10003);
					global::Infragistics.Controls.Grids.Primitives.RowsPanel.ArrangeRow(rowBase3, 0.0, num3, global::System.Math.Max(finalSize.Width, rowBase3.Control.DesiredSize.Width), height2);
					if (rowBase3.RequiresFixedRowSeparator)
					{
						global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator fixedRowSeparator2 = rowBase3.ResolveSeparator();
						fixedRowSeparator2.Style = this._grid.FixedRowSeparatorStyle;
						num3 -= fixedRowSeparator2.DesiredSize.Height;
						fixedRowSeparator2.Arrange(new global::System.Windows.Rect(0.0, num3, finalSize.Width, fixedRowSeparator2.DesiredSize.Height));
						global::System.Windows.Controls.Panel.SetZIndex(fixedRowSeparator2, 10002);
					}
				}
			}
			double dataRowTop = num;
			if (count != 0)
			{
				global::System.Windows.Controls.Primitives.ScrollBar verticalScrollBar = this.ScrollInfo.VerticalScrollBar;
				if (verticalScrollBar != null && verticalScrollBar.Visibility == global::System.Windows.Visibility.Visible && this._visibleRows.Count > 0)
				{
					if (this._measureScrollBarValue != verticalScrollBar.Maximum)
					{
						double num4 = this._measureScrollBarValue - (double)((int)this._measureScrollBarValue);
						global::Infragistics.Controls.Grids.RowBase rowBase4 = this._visibleRows[0];
						double num5 = rowBase4.Control.DesiredSize.Height;
						foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner in this.Grid.RenderAdorners)
						{
							num5 += xamGridRenderAdorner.ArrangeAfterRow(rowBase4, num, finalSize);
						}
						double num6 = num5 * num4;
						double measureScrollBarValue = this._measureScrollBarValue;
						double overrideVerticalMax = this._overrideVerticalMax;
						if (measureScrollBarValue >= overrideVerticalMax && overrideVerticalMax > 0.0)
						{
							num -= this._overflowAdjustment;
						}
						else
						{
							num += -num6;
						}
					}
					else
					{
						num -= this._overflowAdjustment;
					}
					verticalScrollBar.SmallChange = 1.0;
				}
				foreach (global::Infragistics.Controls.Grids.RowBase rowBase5 in this._visibleRows)
				{
					double height3 = rowBase5.Control.DesiredSize.Height;
					if (!global::Infragistics.Controls.Grids.Primitives.RowsPanel.ArrangeRow(rowBase5, 0.0, num, global::System.Math.Max(finalSize.Width, rowBase5.Control.DesiredSize.Width), height3))
					{
						flag = true;
					}
					global::System.Windows.Controls.Panel.SetZIndex(rowBase5.Control, 0);
					num += height3;
					num2 += height3;
					foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner2 in this.Grid.RenderAdorners)
					{
						double num7 = xamGridRenderAdorner2.ArrangeAfterRow(rowBase5, num, finalSize);
						num += num7;
						num2 += num7;
					}
				}
			}
			foreach (global::Infragistics.Controls.Grids.Primitives.XamGridRenderAdorner xamGridRenderAdorner3 in this.Grid.RenderAdorners)
			{
				xamGridRenderAdorner3.ArrangeAdornments(finalSize, dataRowTop);
			}
			if (!this._hasInfiniteHeight)
			{
				int num8 = count - this.VisibleRows.Count;
				double num9 = num2 / (double)global::System.Math.Max(this.VisibleRows.Count, 1);
				double num10 = (num2 - finalSize.Height) / num9;
				if (num9 == 0.0)
				{
					num10 = 0.0;
				}
				this._overrideVerticalMax = (double)num8 + num10;
				if (!double.IsInfinity(this._measureMax) && this._measureMax >= 0.0)
				{
					this._overrideVerticalMax = this._measureMax;
				}
				if (this._overrideVerticalMax < 0.0)
				{
					this._overrideVerticalMax = -1.0;
				}
			}
			this._resetVertSBViewportSize = (count != this._previousRowCount);
			this._previousRowCount = count;
			if (!this.Grid.IsColumnResizing)
			{
				this.UpdateHorizontalScrollInfo();
			}
			global::System.Windows.Visibility visibility = this.ScrollInfo.VerticalScrollBar.Visibility;
			this.UpdateVerticalScrollInfo(count);
			this._keepReversedSettings = (this.ScrollInfo.VerticalScrollBar.Visibility != visibility && this.ScrollInfo.VerticalScrollBar.Visibility == global::System.Windows.Visibility.Visible && this.ScrollCellIntoViewInProgress && this._scrollIntoViewCell != null && this._scrollIntoViewCell.Control != null && this._scrollIntoViewCell.Control.Cell != null && this._scrollIntoViewCell.Control.Cell.Row != null && this._scrollIntoViewCell.Control.Cell.Row.Control != null);
			this.InLayoutPhase = false;
			this._reverseMeasure = false;
			if (!this._keepReversedSettings)
			{
				this.ReverseCellMeasure = false;
				this.ReverCellStartIndex = -1;
				this.ReverseColumnLayout = null;
				this.ReverseChildColumn = null;
			}
			this.Grid.DropAreaIndicatorPanel.Arrange(new global::System.Windows.Rect(0.0, 0.0, 0.0, 0.0));
			global::System.Windows.Controls.Panel.SetZIndex(this.Grid.DropAreaIndicatorPanel, 10003);
			if (this.ScrollCellIntoViewInProgress)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase control = this._scrollIntoViewCell.Control;
				if (control == null)
				{
					this.ScrollCellIntoView(this._scrollIntoViewCell, global::Infragistics.Controls.Grids.CellAlignment.NotSet, null);
				}
				if (!this._keepReversedSettings)
				{
					this.ScrollCellIntoViewInProgress = false;
					this._scrollIntoViewCell = null;
					bool flag2 = false;
					if (control != null)
					{
						global::System.Windows.Rect layoutSlot = global::System.Windows.Controls.Primitives.LayoutInformation.GetLayoutSlot(this);
						global::System.Windows.Media.GeneralTransform generalTransform = null;
						try
						{
							generalTransform = control.TransformToVisual(this);
						}
						catch
						{
							flag2 = true;
						}
						if (generalTransform != null)
						{
							global::System.Windows.Rect rect = generalTransform.TransformBounds(new global::System.Windows.Rect(0.0, 0.0, control.ActualWidth, control.ActualHeight));
							global::System.Windows.Rect rect2 = rect;
							rect2.Intersect(layoutSlot);
							flag2 = (rect2 != rect);
						}
					}
					if (flag2 || this._scrollIntoViewCellAlignment != global::Infragistics.Controls.Grids.CellAlignment.NotSet)
					{
						this.InvalidateMeasureInternal();
					}
				}
			}
			if (this._scrollCellIntoViewCallback != null)
			{
				this._scrollCellIntoViewCallback();
			}
			if (this._invalidateMeasureCallback != null)
			{
				this._invalidateMeasureCallback();
			}
			if (this.RemeasuredCells.Count > 0)
			{
				int count2 = this.RemeasuredCells.Count;
				for (int i = count2 - 1; i >= 0; i--)
				{
					global::Infragistics.Controls.Grids.CellBase item = this.RemeasuredCells[i];
					if (this.PreviouslyRemeasuredCells.Contains(item))
					{
						this.RemeasuredCells.Remove(item);
					}
				}
			}
			foreach (global::Infragistics.Controls.Grids.CellBase cellBase in this.RemeasuredCells)
			{
				if (cellBase.Control != null)
				{
					cellBase.Control.Measure(cellBase.MeasuringSize);
				}
			}
			if (!flag)
			{
				if (this.RemeasuredCells.Count == 0)
				{
					foreach (global::Infragistics.Controls.Grids.CellBase cellBase2 in this.PreviouslyRemeasuredCells)
					{
						cellBase2.MeasuringSize = global::System.Windows.Size.Empty;
					}
					this.PreviouslyRemeasuredCells.Clear();
				}
				this.PreviouslyRemeasuredCells.AddRange(this.RemeasuredCells);
			}
			this.RemeasuredCells.Clear();
			this._scrollCellIntoViewCallback = null;
			this._invalidateMeasureCallback = null;
			return finalSize;
		}

		// Token: 0x06000CED RID: 3309 RVA: 0x0002FAB8 File Offset: 0x0002DCB8
		private void RowsPanel_Unloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this._shouldInvalidateGroupCellMeasure = true;
			this.InLayoutPhase = false;
			this._measureCalled = false;
			this._unloadedSoResetAll = true;
		}

		// Token: 0x06000CEE RID: 3310 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
		private global::System.IntPtr WndProc(global::System.IntPtr hwnd, int msg, global::System.IntPtr wparam, global::System.IntPtr lparam, ref bool handled)
		{
			if (msg != 5)
			{
				switch (msg)
				{
				case 561:
					this._isWndResizing = true;
					break;
				case 562:
					this._isWndResizing = false;
					break;
				}
			}
			else
			{
				switch (global::Infragistics.Windows.Helpers.NativeWindowMethods.IntPtrToInt32(wparam))
				{
				case 0:
					this._shouldInvalidateCellMeasure = true;
					break;
				case 2:
					this._shouldInvalidateCellMeasure = true;
					break;
				}
			}
			return global::System.IntPtr.Zero;
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x0002FB48 File Offset: 0x0002DD48
		private void OnElementSourceChanged(object sender, global::System.Windows.SourceChangedEventArgs e)
		{
			global::System.Windows.Interop.HwndSource oldSource = e.OldSource as global::System.Windows.Interop.HwndSource;
			global::System.Windows.Interop.HwndSource newSource = e.NewSource as global::System.Windows.Interop.HwndSource;
			this.HookWndProc(oldSource, newSource);
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x0002FB75 File Offset: 0x0002DD75
		void global::Infragistics.IRecyclableElementHost.OnElementAttached(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element, bool isNewlyRealized)
		{
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x0002FB78 File Offset: 0x0002DD78
		void global::Infragistics.IRecyclableElementHost.OnElementReleased(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element, bool isRemoved)
		{
			if (isRemoved)
			{
				global::Infragistics.Controls.Grids.Primitives.CellsPanel cellsPanel = element as global::Infragistics.Controls.Grids.Primitives.CellsPanel;
				if (cellsPanel != null)
				{
					cellsPanel.Owner = null;
					global::Infragistics.RecyclingManager.Manager.ReleaseAll(cellsPanel);
				}
			}
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x0002FBA4 File Offset: 0x0002DDA4
		bool global::Infragistics.IRecyclableElementHost.ShouldRemove(global::Infragistics.ISupportRecycling item, global::System.Windows.FrameworkElement element)
		{
			return false;
		}

		// Token: 0x04000423 RID: 1059
		private readonly global::System.Windows.Rect _hiddenRowRect = new global::System.Windows.Rect(-1000.0, -1000.0, 0.0, 0.0);

		// Token: 0x04000424 RID: 1060
		private bool _unloadedSoResetAll;

		// Token: 0x04000425 RID: 1061
		private bool _resetHorizSBViewportSize;

		// Token: 0x04000426 RID: 1062
		private bool _resetVertSBViewportSize;

		// Token: 0x04000427 RID: 1063
		private bool _keepReversedSettings;

		// Token: 0x04000428 RID: 1064
		private bool _ignoreNextScrollUpdate;

		// Token: 0x04000429 RID: 1065
		private bool _updateValueOnly;

		// Token: 0x0400042A RID: 1066
		private bool _shouldInvalidateGroupCellMeasure;

		// Token: 0x0400042B RID: 1067
		private bool _hasInfiniteHeight;

		// Token: 0x0400042C RID: 1068
		private bool _reverseMeasure;

		// Token: 0x0400042D RID: 1069
		private bool _measureCalled;

		// Token: 0x0400042E RID: 1070
		private bool _measureCalledInfinite;

		// Token: 0x0400042F RID: 1071
		private bool _recalcHorizSBVis;

		// Token: 0x04000430 RID: 1072
		private bool _onNextMeasureReleaseVisibleRows;

		// Token: 0x04000431 RID: 1073
		private bool _ensuerVertSBValueUpdated;

		// Token: 0x04000432 RID: 1074
		private int _reverseRowStartIndex;

		// Token: 0x04000433 RID: 1075
		private double _overrideVerticalMax;

		// Token: 0x04000434 RID: 1076
		private double _overflowAdjustment;

		// Token: 0x04000435 RID: 1077
		private double _invalidateRowHeight;

		// Token: 0x04000436 RID: 1078
		private double _measureScrollBarValue;

		// Token: 0x04000437 RID: 1079
		private double _previousHeight;

		// Token: 0x04000438 RID: 1080
		private double _previousWidth;

		// Token: 0x04000439 RID: 1081
		private global::Infragistics.Controls.Grids.CellAlignment _scrollIntoViewCellAlignment;

		// Token: 0x0400043A RID: 1082
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> _topRows;

		// Token: 0x0400043B RID: 1083
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowBase> _bottomRows;

		// Token: 0x0400043C RID: 1084
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowsManagerBase> _visibleManagers;

		// Token: 0x0400043D RID: 1085
		private readonly global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.RowBase> _visibleRows;

		// Token: 0x0400043E RID: 1086
		private readonly global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.RowBase> _nonReleasedRows;

		// Token: 0x0400043F RID: 1087
		private readonly global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator> _topFixRowSeperators;

		// Token: 0x04000440 RID: 1088
		private readonly global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Primitives.FixedRowSeparator> _bottomFixRowSeperators;

		// Token: 0x04000441 RID: 1089
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> _reMeasuredCells;

		// Token: 0x04000442 RID: 1090
		private readonly global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.CellBase> _previouslyRemeasuredCells;

		// Token: 0x04000443 RID: 1091
		private readonly global::System.Collections.Generic.List<global::System.Windows.FrameworkElement> _notVisibleAndNotArrangedRows;

		// Token: 0x04000444 RID: 1092
		private readonly global::Infragistics.FixedRowsOrderComparer _fixedRowsOrderComparer;

		// Token: 0x04000445 RID: 1093
		private readonly global::System.Windows.Media.RectangleGeometry _clip;

		// Token: 0x04000446 RID: 1094
		private global::Infragistics.Controls.Grids.XamGrid _grid;

		// Token: 0x04000447 RID: 1095
		private global::Infragistics.Controls.Grids.CellBase _scrollIntoViewCell;

		// Token: 0x04000448 RID: 1096
		private global::Infragistics.Controls.Grids.EmptyDelegate _scrollCellIntoViewCallback;

		// Token: 0x04000449 RID: 1097
		private global::Infragistics.Controls.Grids.EmptyDelegate _invalidateMeasureCallback;

		// Token: 0x0400044A RID: 1098
		private int _previousRowCount;

		// Token: 0x0400044B RID: 1099
		private double _measureMax = double.NaN;

		// Token: 0x0400044C RID: 1100
		private bool _isWndResizing;

		// Token: 0x0400044D RID: 1101
		private bool _shouldInvalidateCellMeasure;

		// Token: 0x0400044E RID: 1102
		private global::System.Windows.Interop.HwndSourceHook _hook;
	}
}
