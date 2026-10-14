using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.AutomationPeers;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020001E5 RID: 485
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Normal")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "Alternate")]
	[global::System.Windows.TemplateVisualState(GroupName = "CommonStates", Name = "MouseOver")]
	public abstract class CellControlBase : global::System.Windows.Controls.ContentControl, global::Infragistics.IRecyclableElement, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000D65 RID: 3429 RVA: 0x00031E0C File Offset: 0x0003000C
		static CellControlBase()
		{
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Grids.Primitives.CellControlBase), new global::System.Windows.FrameworkPropertyMetadata(style));
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00031E79 File Offset: 0x00030079
		protected CellControlBase()
		{
			base.Loaded += this.CellControlBase_Loaded;
			base.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.CellControlBase_MouseLeftButtonUp), true);
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000D67 RID: 3431 RVA: 0x00031EAB File Offset: 0x000300AB
		public virtual global::Infragistics.Controls.Grids.Primitives.ColumnContentProviderBase ContentProvider
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000D68 RID: 3432 RVA: 0x00031EB0 File Offset: 0x000300B0
		// (set) Token: 0x06000D69 RID: 3433 RVA: 0x00031F1C File Offset: 0x0003011C
		public global::Infragistics.Controls.Grids.CellBase Cell
		{
			get
			{
				if (this._cell != null)
				{
					this._panel = this._cell.Row.Control;
					return this._cell;
				}
				if (this.Column != null && this._panel != null && this._panel.Row != null)
				{
					return this._panel.Row.Cells[this.Column];
				}
				return null;
			}
			set
			{
				if (this._cell != value)
				{
					this._cell = value;
					this.OnPropertyChanged("Cell");
				}
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000D6A RID: 3434 RVA: 0x00031F39 File Offset: 0x00030139
		// (set) Token: 0x06000D6B RID: 3435 RVA: 0x00031F41 File Offset: 0x00030141
		public global::Infragistics.Controls.Grids.Column Column { get; private set; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06000D6C RID: 3436 RVA: 0x00031F4A File Offset: 0x0003014A
		// (set) Token: 0x06000D6D RID: 3437 RVA: 0x00031F51 File Offset: 0x00030151
		public static bool KeepContentInLogicalTree { get; set; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000D6E RID: 3438 RVA: 0x00031F59 File Offset: 0x00030159
		// (set) Token: 0x06000D6F RID: 3439 RVA: 0x00031F6B File Offset: 0x0003016B
		public int ResizingThreshold
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Grids.Primitives.CellControlBase.ResizingThresholdProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Grids.Primitives.CellControlBase.ResizingThresholdProperty, value);
			}
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00031F7E File Offset: 0x0003017E
		private static void ResizingThresholdChanged(global::System.Windows.DependencyObject obj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000D71 RID: 3441 RVA: 0x00031F80 File Offset: 0x00030180
		// (set) Token: 0x06000D72 RID: 3442 RVA: 0x00031F88 File Offset: 0x00030188
		protected internal bool AllowUserResizing { get; set; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000D73 RID: 3443 RVA: 0x00031F91 File Offset: 0x00030191
		// (set) Token: 0x06000D74 RID: 3444 RVA: 0x00031F9C File Offset: 0x0003019C
		protected internal bool IsResizing
		{
			get
			{
				return this._isResizing;
			}
			set
			{
				this._isResizing = value;
				if (this.Cell != null && this.Cell.Column != null && this.Cell.Column.ColumnLayout != null && this.Cell.Column.ColumnLayout.Grid != null)
				{
					this.Cell.Column.ColumnLayout.Grid.IsColumnResizing = value;
				}
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000D75 RID: 3445 RVA: 0x00032009 File Offset: 0x00030209
		protected virtual bool ShowResizingArrow
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000D76 RID: 3446 RVA: 0x0003200C File Offset: 0x0003020C
		// (set) Token: 0x06000D77 RID: 3447 RVA: 0x00032014 File Offset: 0x00030214
		protected virtual bool DelayRecycling { get; set; }

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000D78 RID: 3448 RVA: 0x0003201D File Offset: 0x0003021D
		// (set) Token: 0x06000D79 RID: 3449 RVA: 0x00032028 File Offset: 0x00030228
		protected virtual global::System.Windows.Controls.Panel OwnerPanel
		{
			get
			{
				return this._panel;
			}
			set
			{
				global::Infragistics.Controls.Grids.Primitives.CellsPanel cellsPanel = value as global::Infragistics.Controls.Grids.Primitives.CellsPanel;
				if (cellsPanel != null)
				{
					this._panel = cellsPanel;
				}
				if (value == null)
				{
					this.Column = null;
				}
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x00032050 File Offset: 0x00030250
		protected virtual bool ValidateWidthInArrange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x00032053 File Offset: 0x00030253
		// (set) Token: 0x06000D7C RID: 3452 RVA: 0x0003205B File Offset: 0x0003025B
		internal bool MeasureRaised { get; set; }

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00032064 File Offset: 0x00030264
		// (set) Token: 0x06000D7E RID: 3454 RVA: 0x0003206C File Offset: 0x0003026C
		internal virtual bool IsCellLoaded { get; set; }

		// Token: 0x06000D7F RID: 3455 RVA: 0x00032078 File Offset: 0x00030278
		protected internal virtual void OnAttached(global::Infragistics.Controls.Grids.CellBase cell)
		{
			this.Cell = cell;
			this.Column = this._cell.Column;
			if (cell.ShouldClearDataContext && base.ReadLocalValue(global::System.Windows.FrameworkElement.DataContextProperty) != global::System.Windows.DependencyProperty.UnsetValue)
			{
				base.ClearValue(global::System.Windows.FrameworkElement.DataContextProperty);
			}
			this.AttachContent();
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x000320C8 File Offset: 0x000302C8
		protected internal virtual bool OnReleasing(global::Infragistics.Controls.Grids.CellBase cell)
		{
			return !this.IsResizing;
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x000320D3 File Offset: 0x000302D3
		protected internal virtual void OnReleased(global::Infragistics.Controls.Grids.CellBase cell)
		{
			if (!this.IsResizing)
			{
				this.ReleaseObjectForRecycling(cell);
				if (!cell.Row.IsReleasingCells || cell is global::Infragistics.Controls.Grids.Primitives.UnboundCell)
				{
					base.DataContext = null;
					return;
				}
			}
			else
			{
				this.DelayRecycling = true;
			}
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00032108 File Offset: 0x00030308
		protected virtual void AttachContent()
		{
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x0003210A File Offset: 0x0003030A
		protected virtual void ReleaseContent()
		{
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x0003210C File Offset: 0x0003030C
		protected virtual void OnLoaded()
		{
			this.IsCellLoaded = true;
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00032115 File Offset: 0x00030315
		protected internal virtual void EnsureContent()
		{
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00032117 File Offset: 0x00030317
		protected virtual void ReleaseObjectForRecycling(global::Infragistics.Controls.Grids.CellBase cell)
		{
			this.ReleaseContent();
			this.Cell = null;
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00032126 File Offset: 0x00030326
		protected internal virtual global::System.Windows.Data.Binding ResolveBinding()
		{
			return null;
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00032129 File Offset: 0x00030329
		protected internal virtual global::System.Windows.Data.Binding ResolveEditorBinding()
		{
			return null;
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0003212C File Offset: 0x0003032C
		protected virtual bool DetermineCursorHelper(global::Infragistics.Controls.Grids.Column column, global::System.Windows.Rect bounds, double xPosition)
		{
			if (this.Cell != null && this.Cell.Row != null && this.Cell.Row.ColumnLayout != null && this.Cell.Row.ColumnLayout.Grid.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				double num = bounds.Left - bounds.Width;
				return column.IsResizable && xPosition > num - (double)this.ResizingThreshold && xPosition < num + (double)this.ResizingThreshold;
			}
			return column.IsResizable && xPosition > bounds.Right - (double)this.ResizingThreshold && xPosition < bounds.Right;
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x000321D6 File Offset: 0x000303D6
		protected internal void Refresh()
		{
			this.EnsureContent();
			this.AttachContent();
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x000321E4 File Offset: 0x000303E4
		protected internal virtual void EnsureCurrentState()
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x000321E6 File Offset: 0x000303E6
		protected internal virtual void ManuallyInvokeMeasure(global::System.Windows.Size sizeToBeMeasured)
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x000321E8 File Offset: 0x000303E8
		internal bool GoToState(string state, bool transition)
		{
			return global::System.Windows.VisualStateManager.GoToState(this, state, transition);
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x000321F2 File Offset: 0x000303F2
		public global::System.Windows.DependencyObject GetTemplateChildByName(string name)
		{
			return base.GetTemplateChild(name);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x000321FC File Offset: 0x000303FC
		private static double ValidateColumnWidth(global::Infragistics.Controls.Grids.Column column, double width)
		{
			if (width < column.MinimumWidth)
			{
				return column.MinimumWidth;
			}
			if (width > column.MaximumWidth)
			{
				return column.MaximumWidth;
			}
			global::Infragistics.Controls.Grids.GroupColumn groupColumn = column.ParentColumn as global::Infragistics.Controls.Grids.GroupColumn;
			if (groupColumn != null && groupColumn.WidthResolved.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star)
			{
				double num = 0.0;
				foreach (global::Infragistics.Controls.Grids.Column column2 in groupColumn.Columns)
				{
					if (column2 != column && column2.WidthResolved.WidthType != global::Infragistics.Controls.Grids.ColumnWidthType.Star)
					{
						num += column2.ActualWidth;
					}
				}
				if (width > groupColumn.ActualWidth - num)
				{
					return groupColumn.ActualWidth - num;
				}
			}
			return width;
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x000322C8 File Offset: 0x000304C8
		private void ResizeColumns(double width)
		{
			foreach (global::Infragistics.Controls.Grids.Column column in this._resizedColumns)
			{
				if (column.IsResizable)
				{
					global::Infragistics.Controls.Grids.Primitives.CellControlBase.ResizeColumn(width, column);
				}
			}
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00032320 File Offset: 0x00030520
		private static void ResizeColumn(double width, global::Infragistics.Controls.Grids.Column column)
		{
			if (column != null && width >= 0.0)
			{
				column.Width = new global::Infragistics.Controls.Grids.ColumnWidth?(new global::Infragistics.Controls.Grids.ColumnWidth(global::Infragistics.Controls.Grids.Primitives.CellControlBase.ValidateColumnWidth(column, width), false));
			}
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x0003234C File Offset: 0x0003054C
		internal bool DetermineCursor(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.Cell != null)
			{
				global::Infragistics.Controls.Grids.Column column = this.Cell.Column;
				if (column != null && column.IsResizable && this.ShowResizingArrow && column.ColumnLayout != null && column.ColumnLayout.ColumnResizingSettings.AllowColumnResizingResolved != global::Infragistics.Controls.Grids.ColumnResizingType.Disabled)
				{
					global::System.Windows.Rect bounds = this.AreOnlyFixedColumnsInView() ? global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(column.ColumnLayout.Grid.Panel, null) : global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(this, null);
					double num = e.GetPosition(null).X;
					try
					{
						num *= global::Infragistics.PlatformProxy.GetZoomFactor();
					}
					catch
					{
					}
					if (this.DetermineCursorHelper(column, bounds, num))
					{
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns = column.AllColumns;
						if (allColumns != null)
						{
							foreach (global::Infragistics.Controls.Grids.Column column2 in allColumns)
							{
								if (column2.IsMoving || column2.IsDragging)
								{
									return false;
								}
							}
						}
						base.Cursor = global::System.Windows.Input.Cursors.SizeWE;
						return true;
					}
				}
				if (base.Cursor != null)
				{
					base.Cursor = null;
					this.AllowUserResizing = false;
				}
			}
			return false;
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x000324AC File Offset: 0x000306AC
		private bool AreOnlyFixedColumnsInView()
		{
			if (this._panel == null || this.Column == null || this.Column.ColumnLayout == null || this.Column.ColumnLayout.Grid == null || (this._panel.VisibleFixedLeftCells.Count == 0 && this._panel.VisibleFixedRightCells.Count == 0))
			{
				return false;
			}
			double num = this._panel.VisibleFixedLeftCells.Sum((global::Infragistics.Controls.Grids.CellBase e) => e.Control.ActualWidth);
			double num2 = this._panel.VisibleFixedRightCells.Sum((global::Infragistics.Controls.Grids.CellBase e) => e.Control.ActualWidth);
			double actualWidth = this._panel.ActualWidth;
			if (num <= num2)
			{
				return num2 >= actualWidth;
			}
			return num >= actualWidth;
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000D94 RID: 3476 RVA: 0x0003258C File Offset: 0x0003078C
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				global::System.Windows.DependencyObject dependencyObject = base.Content as global::System.Windows.DependencyObject;
				if (!global::Infragistics.Controls.Grids.Primitives.CellControlBase.KeepContentInLogicalTree && (dependencyObject == null || global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject) != this))
				{
					return global::Infragistics.Collections.EmptyEnumerator.Instance;
				}
				return base.LogicalChildren;
			}
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x000325C4 File Offset: 0x000307C4
		protected override void OnContentChanged(object oldContent, object newContent)
		{
			if (!global::Infragistics.Controls.Grids.Primitives.CellControlBase.KeepContentInLogicalTree)
			{
				global::System.Windows.DependencyObject dependencyObject = oldContent as global::System.Windows.DependencyObject;
				if (dependencyObject != null && global::System.Windows.LogicalTreeHelper.GetParent(dependencyObject) == this)
				{
					base.RemoveLogicalChild(oldContent);
				}
				return;
			}
			base.OnContentChanged(oldContent, newContent);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x000325FB File Offset: 0x000307FB
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			this.MeasureRaised = true;
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x0003260C File Offset: 0x0003080C
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			if (this.ValidateWidthInArrange && this.Cell != null && this.Cell.Column != null && this.Cell.Control != null && finalSize.Width > this.Cell.Column.ActualWidth)
			{
				double num = this.Cell.Column.ActualWidth;
				if (num == 0.0 && this.Cell.Column.WidthResolved.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Numeric)
				{
					num = this.Cell.Column.WidthResolved.Value;
				}
				this.Cell.MeasuringSize = new global::System.Windows.Size(num, double.PositiveInfinity);
				this.Cell.Row.ColumnLayout.Grid.Panel.RemeasuredCells.Add(this.Cell);
			}
			return base.ArrangeOverride(finalSize);
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00032707 File Offset: 0x00030907
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.CellControlBaseAutomationPeer(this);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0003270F File Offset: 0x0003090F
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnMouseMoveColumnResizing(e);
			this.OnMouseMoveColumnMoving(e);
			base.OnMouseMove(e);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00032726 File Offset: 0x00030926
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			if (base.Cursor != null && !this.IsResizing)
			{
				base.Cursor = null;
				this.AllowUserResizing = false;
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x0003274D File Offset: 0x0003094D
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (!this.OnMouseLeftButtonDownColumnResizing(e))
			{
				this.OnMouseLeftButtonDownColumnMoving(e);
			}
			base.OnMouseLeftButtonDown(e);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00032767 File Offset: 0x00030967
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (this.IsResizing)
			{
				if (e.Key == global::System.Windows.Input.Key.Escape)
				{
					this.CancelDragResize(true);
				}
				e.Handled = true;
			}
			base.OnKeyDown(e);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00032790 File Offset: 0x00030990
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.IsResizing)
			{
				this.EndDragResize(true);
			}
			base.OnLostMouseCapture(e);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x000327A8 File Offset: 0x000309A8
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this.Cell != null)
			{
				this.Cell.EnsureCurrentState();
			}
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x000327C3 File Offset: 0x000309C3
		private void CellControlBase_Loaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.Cell != null)
			{
				this.GoToState(this.Cell.NormalState, false);
			}
			this.OnLoaded();
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x000327E6 File Offset: 0x000309E6
		private void CellControlBase_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.OnMouseLeftButtonUpColumnResizing(e);
			this.OnMouseLeftButtonUpColumnMoving(e);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x000327F6 File Offset: 0x000309F6
		protected virtual bool OnMouseLeftButtonDownColumnMoving(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			return false;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000327F9 File Offset: 0x000309F9
		protected virtual void OnMouseMoveColumnMoving(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000327FB File Offset: 0x000309FB
		protected virtual void OnMouseLeftButtonUpColumnMoving(global::System.Windows.Input.MouseButtonEventArgs e)
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000327FD File Offset: 0x000309FD
		protected virtual bool OnMouseLeftButtonDownColumnResizing(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.AllowUserResizing)
			{
				this.IsResizing = this.InitializeDragResize(e);
			}
			else
			{
				this.IsResizing = false;
			}
			e.Handled = this.IsResizing;
			return this.IsResizing;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00032830 File Offset: 0x00030A30
		protected virtual void OnMouseLeftButtonUpColumnResizing(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this.Cell == null || this.Cell.Row == null || this.Cell.Row.ColumnLayout == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettings = this.Cell.Row.ColumnLayout.ColumnResizingSettings;
			if (columnResizingSettings != null)
			{
				global::Infragistics.Controls.Grids.ColumnResizingType allowColumnResizingResolved = columnResizingSettings.AllowColumnResizingResolved;
				bool allowMultipleColumnResizeResolved = columnResizingSettings.AllowMultipleColumnResizeResolved;
				if (this.IsResizing)
				{
					bool flag = this._dragStartPoint.X != e.GetPosition(null).X;
					global::Infragistics.Controls.Grids.Column resizeColumnResolved = this.Cell.Column.ResizeColumnResolved;
					if ((allowColumnResizingResolved != global::Infragistics.Controls.Grids.ColumnResizingType.Immediate && resizeColumnResolved.ActualWidth != this._originalWidthValue) || (allowColumnResizingResolved == global::Infragistics.Controls.Grids.ColumnResizingType.Indicator && flag) || (allowColumnResizingResolved == global::Infragistics.Controls.Grids.ColumnResizingType.Immediate && this._resizedColumns != null && this._resizedColumns.Count > 1 && allowMultipleColumnResizeResolved && flag))
					{
						this.VerifyResizedColumns();
						this.ResizeColumns(this._currentWidth);
					}
					this.EndDragResize(true);
					base.ReleaseMouseCapture();
				}
				this.AllowUserResizing = this.DetermineCursor(e);
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00032934 File Offset: 0x00030B34
		protected virtual void OnMouseMoveColumnResizing(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.Cell == null || this.Cell.Row == null || this.Cell.Row.ColumnLayout == null)
			{
				return;
			}
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettings = this.Cell.Row.ColumnLayout.ColumnResizingSettings;
			if (columnResizingSettings.AllowColumnResizingResolved == global::Infragistics.Controls.Grids.ColumnResizingType.Disabled)
			{
				return;
			}
			if (!this.IsResizing)
			{
				this.AllowUserResizing = this.DetermineCursor(e);
				return;
			}
			base.Focus();
			global::Infragistics.Controls.Grids.RowBase row = this.Cell.Row;
			global::Infragistics.Controls.Grids.XamGrid grid = row.ColumnLayout.Grid;
			global::System.Windows.Controls.Panel panel = grid.Panel;
			global::System.Windows.Point position = e.GetPosition(null);
			global::System.Windows.Point position2 = e.GetPosition(panel);
			global::System.Windows.Controls.Primitives.Popup indicatorContainer = columnResizingSettings.IndicatorContainer;
			global::System.Windows.UIElement rootVisual = global::Infragistics.PlatformProxy.GetRootVisual(this);
			global::System.Windows.Media.MatrixTransform matrixTransform = null;
			if (base.Parent != null)
			{
				matrixTransform = (base.TransformToVisual(rootVisual) as global::System.Windows.Media.MatrixTransform);
			}
			double num = 1.0;
			if (matrixTransform != null)
			{
				num = global::System.Math.Abs(matrixTransform.Matrix.M11) / global::Infragistics.PlatformProxy.GetZoomFactor();
			}
			double num2 = this.AreOnlyFixedColumnsInView() ? this.CalculateFixedColumnsInViewWidth() : this._originalWidthValue;
			this._currentWidth = num2 + (position.X - this._dragStartPoint.X) / num;
			if (grid.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
			{
				this._currentWidth = num2 - (position.X - this._dragStartPoint.X) / num;
			}
			this._currentWidth = global::Infragistics.Controls.Grids.Primitives.CellControlBase.ValidateColumnWidth(this._resizedColumn, this._currentWidth);
			if (columnResizingSettings.AllowColumnResizingResolved == global::Infragistics.Controls.Grids.ColumnResizingType.Immediate)
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase.ResizeColumn(this._currentWidth, this._resizedColumn);
			}
			if (columnResizingSettings.AllowColumnResizingResolved == global::Infragistics.Controls.Grids.ColumnResizingType.Indicator)
			{
				indicatorContainer.HorizontalOffset = position2.X;
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00032AD8 File Offset: 0x00030CD8
		protected virtual bool InitializeDragResize(global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Row.ColumnLayout.Grid;
			global::Infragistics.Controls.Grids.Primitives.RowsPanel panel = grid.Panel;
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettings = this.Cell.Row.ColumnLayout.ColumnResizingSettings;
			this._resizedColumn = this.Cell.Column.ResizeColumnResolved;
			if (this._resizedColumn == null || !this.ShowResizingArrow || (this._resizedColumn != null && !this._resizedColumn.IsResizable))
			{
				return false;
			}
			this._dragStartPoint = e.GetPosition(null);
			this._originalWidthValue = this._resizedColumn.ActualWidth;
			this._originalWidth = this._resizedColumn.Width;
			this._resizedColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column>();
			if (columnResizingSettings.AllowMultipleColumnResizeResolved)
			{
				if (grid.SelectionSettings.SelectedColumns.Contains(this.Cell.Column))
				{
					global::Infragistics.Controls.Grids.ColumnLayout columnLayout = this.Cell.Column.ColumnLayout;
					using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Grids.Column> enumerator = grid.SelectionSettings.SelectedColumns.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Infragistics.Controls.Grids.Column column = enumerator.Current;
							if (column.ColumnLayout == columnLayout)
							{
								this._resizedColumns.Add(column.ResizeColumnResolved);
							}
						}
						goto IL_157;
					}
				}
				this._resizedColumns.Add(this._resizedColumn);
			}
			else
			{
				this._resizedColumns.Add(this._resizedColumn);
			}
			IL_157:
			if (grid.OnColumnResizing(this._resizedColumns, this._originalWidthValue))
			{
				this.IsResizing = false;
				return false;
			}
			this.VerifyResizedColumns();
			base.CaptureMouse();
			if (columnResizingSettings.AllowColumnResizingResolved == global::Infragistics.Controls.Grids.ColumnResizingType.Immediate && this.AreOnlyFixedColumnsInView())
			{
				this.UpdateResizedColumnWidth();
			}
			if (columnResizingSettings.AllowColumnResizingResolved == global::Infragistics.Controls.Grids.ColumnResizingType.Indicator)
			{
				global::System.Windows.Controls.Primitives.Popup indicatorContainer = columnResizingSettings.IndicatorContainer;
				global::System.Windows.Rect rect = this.AreOnlyFixedColumnsInView() ? global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(panel, null) : global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(this, panel);
				indicatorContainer.HorizontalOffset = rect.Left + rect.Width / global::Infragistics.PlatformProxy.GetZoomFactor();
				global::Infragistics.Controls.Grids.RowsManagerBase manager = this.Cell.Row.Manager;
				indicatorContainer.VerticalOffset = global::Infragistics.Controls.Grids.Primitives.CellControlBase.DetermineOffsetHeight(manager, panel);
				if (!panel.Children.Contains(indicatorContainer))
				{
					panel.Children.Add(indicatorContainer);
				}
				columnResizingSettings.Indicator.Height = global::Infragistics.Controls.Grids.Primitives.CellControlBase.DetermineIndicatorHeight(manager, panel);
				indicatorContainer.IsOpen = true;
			}
			return true;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00032D34 File Offset: 0x00030F34
		private void UpdateResizedColumnWidth()
		{
			this._originalWidthValue = this.CalculateFixedColumnsInViewWidth();
			global::Infragistics.Controls.Grids.Primitives.CellControlBase.ResizeColumn(this._originalWidthValue, this._resizedColumn);
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x00032D70 File Offset: 0x00030F70
		private double CalculateFixedColumnsInViewWidth()
		{
			if (this._panel != null && (this._panel.VisibleFixedLeftCells.Count > 0 || this._panel.VisibleFixedRightCells.Count > 0))
			{
				double num = this._panel.VisibleFixedLeftCells.Sum((global::Infragistics.Controls.Grids.CellBase a) => a.Control.ActualWidth);
				double num2 = this._panel.VisibleFixedRightCells.Sum((global::Infragistics.Controls.Grids.CellBase a) => a.Control.ActualWidth);
				double actualWidth = this._panel.ActualWidth;
				double num3 = (num > num2) ? (num - actualWidth) : (num2 - actualWidth);
				if (this._originalWidthValue > num3)
				{
					return this._originalWidthValue - num3;
				}
			}
			return this._originalWidthValue;
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00032E3E File Offset: 0x0003103E
		private void VerifyResizedColumns()
		{
			if (this._resizedColumns == null || this._resizedColumns.Count == 0 || !this._resizedColumns.Contains(this._resizedColumn))
			{
				throw new global::Infragistics.Controls.Grids.ResizingColumnCannotBeRemovedException();
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00032E70 File Offset: 0x00031070
		private static double DetermineOffsetHeight(global::Infragistics.Controls.Grids.RowsManagerBase mgr, global::Infragistics.Controls.Grids.Primitives.RowsPanel panel)
		{
			if (mgr.Level == 0)
			{
				return global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(panel, panel).Top;
			}
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase in panel.VisibleRows)
			{
				if (mgr == rowBase.Manager)
				{
					return global::Infragistics.Controls.Grids.Primitives.HeaderCellControl.GetBoundsOfElement(rowBase.Control, panel).Top;
				}
			}
			return 0.0;
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00032F00 File Offset: 0x00031100
		private static double DetermineIndicatorHeight(global::Infragistics.Controls.Grids.RowsManagerBase mgr, global::Infragistics.Controls.Grids.Primitives.RowsPanel panel)
		{
			if (mgr.Level == 0)
			{
				return panel.ActualHeight;
			}
			double num = 0.0;
			bool flag = false;
			foreach (global::Infragistics.Controls.Grids.RowBase rowBase in panel.VisibleRows)
			{
				if (mgr == rowBase.Manager)
				{
					flag = true;
					num += rowBase.Control.ActualHeight;
				}
				else if (flag)
				{
					break;
				}
			}
			return num;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00032F80 File Offset: 0x00031180
		protected virtual void CancelDragResize(bool fireEvent)
		{
			if (this._resizedColumn != null)
			{
				this._resizedColumn.Width = this._originalWidth;
			}
			this.EndDragResize(fireEvent);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00032FA4 File Offset: 0x000311A4
		protected internal virtual void EndDragResize(bool fireEvent)
		{
			global::Infragistics.Controls.Grids.XamGrid grid = this.Cell.Column.ColumnLayout.Grid;
			global::Infragistics.Controls.Grids.ColumnResizingSettingsOverride columnResizingSettings = this.Cell.Row.ColumnLayout.ColumnResizingSettings;
			if (fireEvent)
			{
				grid.OnColumnResized(this._resizedColumns);
			}
			this.IsResizing = false;
			this._resizedColumn = null;
			if (columnResizingSettings.AllowColumnResizingResolved == global::Infragistics.Controls.Grids.ColumnResizingType.Indicator)
			{
				global::Infragistics.Controls.Grids.Primitives.RowsPanel panel = grid.Panel;
				global::System.Windows.Controls.Primitives.Popup indicatorContainer = columnResizingSettings.IndicatorContainer;
				indicatorContainer.IsOpen = false;
				if (panel.Children.Contains(indicatorContainer))
				{
					panel.Children.Remove(indicatorContainer);
				}
			}
			base.ReleaseMouseCapture();
			if (this.DelayRecycling)
			{
				this.ReleaseObjectForRecycling(this.Cell);
				this.DelayRecycling = false;
			}
			base.Cursor = null;
			this._currentWidth = 0.0;
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000DAF RID: 3503 RVA: 0x00033069 File Offset: 0x00031269
		// (set) Token: 0x06000DB0 RID: 3504 RVA: 0x00033071 File Offset: 0x00031271
		bool global::Infragistics.IRecyclableElement.DelayRecycling
		{
			get
			{
				return this.DelayRecycling;
			}
			set
			{
				this.DelayRecycling = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0003307A File Offset: 0x0003127A
		// (set) Token: 0x06000DB2 RID: 3506 RVA: 0x00033082 File Offset: 0x00031282
		global::System.Windows.Controls.Panel global::Infragistics.IRecyclableElement.OwnerPanel
		{
			get
			{
				return this.OwnerPanel;
			}
			set
			{
				this.OwnerPanel = value;
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x06000DB3 RID: 3507 RVA: 0x0003308C File Offset: 0x0003128C
		// (remove) Token: 0x06000DB4 RID: 3508 RVA: 0x000330C4 File Offset: 0x000312C4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000DB5 RID: 3509 RVA: 0x000330F9 File Offset: 0x000312F9
		protected virtual void OnPropertyChanged(string propName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propName));
			}
		}

		// Token: 0x04000468 RID: 1128
		private global::Infragistics.Controls.Grids.CellBase _cell;

		// Token: 0x04000469 RID: 1129
		private bool _isResizing;

		// Token: 0x0400046A RID: 1130
		private global::Infragistics.Controls.Grids.Primitives.CellsPanel _panel;

		// Token: 0x0400046B RID: 1131
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column> _resizedColumns;

		// Token: 0x0400046C RID: 1132
		private global::Infragistics.Controls.Grids.Column _resizedColumn;

		// Token: 0x0400046D RID: 1133
		private global::System.Windows.Point _dragStartPoint;

		// Token: 0x0400046E RID: 1134
		private double _originalWidthValue;

		// Token: 0x0400046F RID: 1135
		private global::Infragistics.Controls.Grids.ColumnWidth? _originalWidth;

		// Token: 0x04000470 RID: 1136
		private double _currentWidth;

		// Token: 0x04000471 RID: 1137
		public static readonly global::System.Windows.DependencyProperty ResizingThresholdProperty = global::System.Windows.DependencyProperty.Register("ResizingThreshold", typeof(int), typeof(global::Infragistics.Controls.Grids.Primitives.CellControlBase), new global::System.Windows.PropertyMetadata(5, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Grids.Primitives.CellControlBase.ResizingThresholdChanged)));
	}
}
