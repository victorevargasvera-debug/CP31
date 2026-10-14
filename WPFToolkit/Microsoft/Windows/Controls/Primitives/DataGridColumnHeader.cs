using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Windows.Automation.Peers;

namespace Microsoft.Windows.Controls.Primitives
{
	// Token: 0x0200004E RID: 78
	[global::System.Windows.TemplatePart(Name = "PART_LeftHeaderGripper", Type = typeof(global::System.Windows.Controls.Primitives.Thumb))]
	[global::System.Windows.TemplatePart(Name = "PART_RightHeaderGripper", Type = typeof(global::System.Windows.Controls.Primitives.Thumb))]
	public class DataGridColumnHeader : global::System.Windows.Controls.Primitives.ButtonBase, global::Microsoft.Windows.Controls.IProvideDataGridColumn
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x000181CC File Offset: 0x000163CC
		static DataGridColumnHeader()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)));
			global::System.Windows.Controls.ContentControl.ContentProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceContent)));
			global::System.Windows.Controls.ContentControl.ContentTemplateProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceContentTemplate)));
			global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceContentTemplateSelector)));
			global::System.Windows.Controls.ContentControl.ContentStringFormatProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceStringFormat)));
			global::System.Windows.FrameworkElement.StyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceStyle)));
			global::System.Windows.FrameworkElement.HeightProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceHeight)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceClip)));
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x000184F0 File Offset: 0x000166F0
		public DataGridColumnHeader()
		{
			this._tracker = new global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader>(this);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x00018504 File Offset: 0x00016704
		public global::Microsoft.Windows.Controls.DataGridColumn Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000619 RID: 1561 RVA: 0x0001850C File Offset: 0x0001670C
		// (set) Token: 0x0600061A RID: 1562 RVA: 0x0001851E File Offset: 0x0001671E
		public global::System.Windows.Media.Brush SeparatorBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorBrushProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorBrushProperty, value);
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x0600061B RID: 1563 RVA: 0x0001852C File Offset: 0x0001672C
		// (set) Token: 0x0600061C RID: 1564 RVA: 0x0001853E File Offset: 0x0001673E
		public global::System.Windows.Visibility SeparatorVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.SeparatorVisibilityProperty, value);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00018554 File Offset: 0x00016754
		internal void PrepareColumnHeader(object item, global::Microsoft.Windows.Controls.DataGridColumn column)
		{
			this._column = column;
			base.TabIndex = column.DisplayIndex;
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentTemplateProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentStringFormatProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.StyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.HeightProperty);
			base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.CanUserSortProperty);
			base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.SortDirectionProperty);
			base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.IsFrozenProperty);
			base.CoerceValue(global::System.Windows.UIElement.ClipProperty);
			base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.DisplayIndexProperty);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000185ED File Offset: 0x000167ED
		internal void ClearHeader()
		{
			this._column = null;
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600061F RID: 1567 RVA: 0x000185F6 File Offset: 0x000167F6
		internal global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader> Tracker
		{
			get
			{
				return this._tracker;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x000185FE File Offset: 0x000167FE
		public int DisplayIndex
		{
			get
			{
				return (int)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.DisplayIndexProperty);
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00018610 File Offset: 0x00016810
		private static object OnCoerceDisplayIndex(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d;
			global::Microsoft.Windows.Controls.DataGridColumn column = dataGridColumnHeader.Column;
			if (column != null)
			{
				return column.DisplayIndex;
			}
			return -1;
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x00018640 File Offset: 0x00016840
		private static void OnDisplayIndexChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d;
			global::Microsoft.Windows.Controls.DataGridColumn column = dataGridColumnHeader.Column;
			if (column != null)
			{
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = column.DataGridOwner;
				if (dataGridOwner != null)
				{
					dataGridColumnHeader.SetLeftGripperVisibility();
					global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader2 = dataGridOwner.ColumnHeaderFromDisplayIndex(dataGridColumnHeader.DisplayIndex + 1);
					if (dataGridColumnHeader2 != null)
					{
						dataGridColumnHeader2.SetLeftGripperVisibility(column.CanUserResize);
					}
				}
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0001868C File Offset: 0x0001688C
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.HookupGripperEvents();
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0001869C File Offset: 0x0001689C
		private void HookupGripperEvents()
		{
			this.UnhookGripperEvents();
			this._leftGripper = (base.GetTemplateChild("PART_LeftHeaderGripper") as global::System.Windows.Controls.Primitives.Thumb);
			this._rightGripper = (base.GetTemplateChild("PART_RightHeaderGripper") as global::System.Windows.Controls.Primitives.Thumb);
			if (this._leftGripper != null)
			{
				this._leftGripper.DragStarted += this.OnColumnHeaderGripperDragStarted;
				this._leftGripper.DragDelta += this.OnColumnHeaderResize;
				this._leftGripper.DragCompleted += this.OnColumnHeaderGripperDragCompleted;
				this._leftGripper.MouseDoubleClick += this.OnGripperDoubleClicked;
				this.SetLeftGripperVisibility();
			}
			if (this._rightGripper != null)
			{
				this._rightGripper.DragStarted += this.OnColumnHeaderGripperDragStarted;
				this._rightGripper.DragDelta += this.OnColumnHeaderResize;
				this._rightGripper.DragCompleted += this.OnColumnHeaderGripperDragCompleted;
				this._rightGripper.MouseDoubleClick += this.OnGripperDoubleClicked;
				this.SetRightGripperVisibility();
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x000187B0 File Offset: 0x000169B0
		private void UnhookGripperEvents()
		{
			if (this._leftGripper != null)
			{
				this._leftGripper.DragStarted -= this.OnColumnHeaderGripperDragStarted;
				this._leftGripper.DragDelta -= this.OnColumnHeaderResize;
				this._leftGripper.DragCompleted -= this.OnColumnHeaderGripperDragCompleted;
				this._leftGripper.MouseDoubleClick -= this.OnGripperDoubleClicked;
				this._leftGripper = null;
			}
			if (this._rightGripper != null)
			{
				this._rightGripper.DragStarted -= this.OnColumnHeaderGripperDragStarted;
				this._rightGripper.DragDelta -= this.OnColumnHeaderResize;
				this._rightGripper.DragCompleted -= this.OnColumnHeaderGripperDragCompleted;
				this._rightGripper.MouseDoubleClick -= this.OnGripperDoubleClicked;
				this._rightGripper = null;
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00018893 File Offset: 0x00016A93
		private global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader HeaderToResize(object gripper)
		{
			if (gripper != this._rightGripper)
			{
				return this.PreviousVisibleHeader;
			}
			return this;
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x000188A8 File Offset: 0x00016AA8
		private void OnColumnHeaderGripperDragStarted(object sender, global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = this.HeaderToResize(sender);
			if (dataGridColumnHeader != null)
			{
				if (dataGridColumnHeader.Column != null)
				{
					global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridColumnHeader.Column.DataGridOwner;
					if (dataGridOwner != null)
					{
						dataGridOwner.InternalColumns.OnColumnResizeStarted();
					}
				}
				e.Handled = true;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000188EC File Offset: 0x00016AEC
		private void OnColumnHeaderResize(object sender, global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = this.HeaderToResize(sender);
			if (dataGridColumnHeader != null)
			{
				global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.RecomputeColumnWidthsOnColumnResize(dataGridColumnHeader, e.HorizontalChange);
				e.Handled = true;
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x00018918 File Offset: 0x00016B18
		private static void RecomputeColumnWidthsOnColumnResize(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader header, double horizontalChange)
		{
			global::Microsoft.Windows.Controls.DataGridColumn column = header.Column;
			if (column == null)
			{
				return;
			}
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = column.DataGridOwner;
			if (dataGridOwner == null)
			{
				return;
			}
			dataGridOwner.InternalColumns.RecomputeColumnWidthsOnColumnResize(column, horizontalChange, false);
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0001894C File Offset: 0x00016B4C
		private void OnColumnHeaderGripperDragCompleted(object sender, global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = this.HeaderToResize(sender);
			if (dataGridColumnHeader != null)
			{
				if (dataGridColumnHeader.Column != null)
				{
					global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridColumnHeader.Column.DataGridOwner;
					if (dataGridOwner != null)
					{
						dataGridOwner.InternalColumns.OnColumnResizeCompleted(e.Canceled);
					}
				}
				e.Handled = true;
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00018994 File Offset: 0x00016B94
		private void OnGripperDoubleClicked(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = this.HeaderToResize(sender);
			if (dataGridColumnHeader != null && dataGridColumnHeader.Column != null)
			{
				dataGridColumnHeader.Column.Width = global::Microsoft.Windows.Controls.DataGridLength.Auto;
				e.Handled = true;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x000189CB File Offset: 0x00016BCB
		private global::Microsoft.Windows.Controls.DataGridLength ColumnWidth
		{
			get
			{
				if (this.Column == null)
				{
					return global::Microsoft.Windows.Controls.DataGridLength.Auto;
				}
				return this.Column.Width;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x0600062D RID: 1581 RVA: 0x000189E6 File Offset: 0x00016BE6
		private double ColumnActualWidth
		{
			get
			{
				if (this.Column == null)
				{
					return base.ActualWidth;
				}
				return this.Column.ActualWidth;
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00018A02 File Offset: 0x00016C02
		private static void OnNotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d).NotifyPropertyChanged(d, e);
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x00018A14 File Offset: 0x00016C14
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			if (dataGridColumn != null && dataGridColumn != this.Column)
			{
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.OnColumnWidthChanged(this, e);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.HeaderProperty || e.Property == global::System.Windows.Controls.ContentControl.ContentProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.HeaderTemplateProperty || e.Property == global::System.Windows.Controls.ContentControl.ContentTemplateProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentTemplateProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.HeaderTemplateSelectorProperty || e.Property == global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.HeaderStringFormatProperty || e.Property == global::System.Windows.Controls.ContentControl.ContentStringFormatProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.ContentControl.ContentStringFormatProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderStyleProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.HeaderStyleProperty || e.Property == global::System.Windows.FrameworkElement.StyleProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.StyleProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderHeightProperty || e.Property == global::System.Windows.FrameworkElement.HeightProperty)
			{
				global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.HeightProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty)
			{
				base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.DisplayIndexProperty);
				base.TabIndex = dataGridColumn.DisplayIndex;
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CanUserResizeColumnsProperty)
			{
				this.OnCanUserResizeColumnsChanged();
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.CanUserSortProperty)
			{
				base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.CanUserSortProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.SortDirectionProperty)
			{
				base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.SortDirectionProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.IsFrozenProperty)
			{
				base.CoerceValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.IsFrozenProperty);
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.CanUserResizeProperty)
			{
				this.OnCanUserResizeChanged();
				return;
			}
			if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.VisibilityProperty)
			{
				this.OnColumnVisibilityChanged(e);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00018BFC File Offset: 0x00016DFC
		private void OnCanUserResizeColumnsChanged()
		{
			if (this.Column.DataGridOwner != null)
			{
				this.SetLeftGripperVisibility();
				this.SetRightGripperVisibility();
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00018C18 File Offset: 0x00016E18
		private void OnCanUserResizeChanged()
		{
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.Column.DataGridOwner;
			if (dataGridOwner != null)
			{
				this.SetNextHeaderLeftGripperVisibility(this.Column.CanUserResize);
				this.SetRightGripperVisibility();
			}
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00018C4C File Offset: 0x00016E4C
		private void SetLeftGripperVisibility()
		{
			if (this._leftGripper == null || this.Column == null)
			{
				return;
			}
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.Column.DataGridOwner;
			bool leftGripperVisibility = false;
			for (int i = this.DisplayIndex - 1; i >= 0; i--)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = dataGridOwner.ColumnFromDisplayIndex(i);
				if (dataGridColumn.IsVisible)
				{
					leftGripperVisibility = dataGridColumn.CanUserResize;
					break;
				}
			}
			this.SetLeftGripperVisibility(leftGripperVisibility);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00018CAC File Offset: 0x00016EAC
		private void SetLeftGripperVisibility(bool canPreviousColumnResize)
		{
			if (this._leftGripper == null || this.Column == null)
			{
				return;
			}
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.Column.DataGridOwner;
			if (dataGridOwner != null && dataGridOwner.CanUserResizeColumns && canPreviousColumnResize)
			{
				this._leftGripper.Visibility = global::System.Windows.Visibility.Visible;
				return;
			}
			this._leftGripper.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00018D00 File Offset: 0x00016F00
		private void SetRightGripperVisibility()
		{
			if (this._rightGripper == null || this.Column == null)
			{
				return;
			}
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.Column.DataGridOwner;
			if (dataGridOwner != null && dataGridOwner.CanUserResizeColumns && this.Column.CanUserResize)
			{
				this._rightGripper.Visibility = global::System.Windows.Visibility.Visible;
				return;
			}
			this._rightGripper.Visibility = global::System.Windows.Visibility.Collapsed;
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00018D5C File Offset: 0x00016F5C
		private void SetNextHeaderLeftGripperVisibility(bool canUserResize)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.Column.DataGridOwner;
			int count = dataGridOwner.Columns.Count;
			int i = this.DisplayIndex + 1;
			while (i < count)
			{
				if (dataGridOwner.ColumnFromDisplayIndex(i).IsVisible)
				{
					global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = dataGridOwner.ColumnHeaderFromDisplayIndex(i);
					if (dataGridColumnHeader != null)
					{
						dataGridColumnHeader.SetLeftGripperVisibility(canUserResize);
						return;
					}
					break;
				}
				else
				{
					i++;
				}
			}
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00018DB8 File Offset: 0x00016FB8
		private void OnColumnVisibilityChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.Column.DataGridOwner;
			if (dataGridOwner != null)
			{
				bool flag = (global::System.Windows.Visibility)e.OldValue == global::System.Windows.Visibility.Visible;
				bool flag2 = (global::System.Windows.Visibility)e.NewValue == global::System.Windows.Visibility.Visible;
				if (flag != flag2)
				{
					if (flag2)
					{
						this.SetLeftGripperVisibility();
						this.SetRightGripperVisibility();
						this.SetNextHeaderLeftGripperVisibility(this.Column.CanUserResize);
						return;
					}
					bool nextHeaderLeftGripperVisibility = false;
					for (int i = this.DisplayIndex - 1; i >= 0; i--)
					{
						global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = dataGridOwner.ColumnFromDisplayIndex(i);
						if (dataGridColumn.IsVisible)
						{
							nextHeaderLeftGripperVisibility = dataGridColumn.CanUserResize;
							break;
						}
					}
					this.SetNextHeaderLeftGripperVisibility(nextHeaderLeftGripperVisibility);
				}
			}
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00018E5C File Offset: 0x0001705C
		private static object OnCoerceContent(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumnHeader, baseValue, global::System.Windows.Controls.ContentControl.ContentProperty, dataGridColumnHeader.Column, global::Microsoft.Windows.Controls.DataGridColumn.HeaderProperty);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00018E88 File Offset: 0x00017088
		private static object OnCoerceContentTemplate(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumnHeader, baseValue, global::System.Windows.Controls.ContentControl.ContentTemplateProperty, dataGridColumnHeader.Column, global::Microsoft.Windows.Controls.DataGridColumn.HeaderTemplateProperty);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00018EB4 File Offset: 0x000170B4
		private static object OnCoerceContentTemplateSelector(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumnHeader, baseValue, global::System.Windows.Controls.ContentControl.ContentTemplateSelectorProperty, dataGridColumnHeader.Column, global::Microsoft.Windows.Controls.DataGridColumn.HeaderTemplateSelectorProperty);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00018EE0 File Offset: 0x000170E0
		private static object OnCoerceStringFormat(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = d as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumnHeader, baseValue, global::System.Windows.Controls.ContentControl.ContentStringFormatProperty, dataGridColumnHeader.Column, global::Microsoft.Windows.Controls.DataGridColumn.HeaderStringFormatProperty);
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00018F0C File Offset: 0x0001710C
		private static object OnCoerceStyle(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d;
			global::Microsoft.Windows.Controls.DataGridColumn column = dataGridColumnHeader.Column;
			global::Microsoft.Windows.Controls.DataGrid grandParentObject = null;
			if (column == null)
			{
				global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter = dataGridColumnHeader.TemplatedParent as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter;
				if (dataGridColumnHeadersPresenter != null)
				{
					grandParentObject = dataGridColumnHeadersPresenter.ParentDataGrid;
				}
			}
			else
			{
				grandParentObject = column.DataGridOwner;
			}
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumnHeader, baseValue, global::System.Windows.FrameworkElement.StyleProperty, column, global::Microsoft.Windows.Controls.DataGridColumn.HeaderStyleProperty, grandParentObject, global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderStyleProperty);
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00018F63 File Offset: 0x00017163
		public bool CanUserSort
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.CanUserSortProperty);
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600063D RID: 1597 RVA: 0x00018F75 File Offset: 0x00017175
		public global::System.ComponentModel.ListSortDirection? SortDirection
		{
			get
			{
				return (global::System.ComponentModel.ListSortDirection?)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.SortDirectionProperty);
			}
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00018F88 File Offset: 0x00017188
		protected override void OnClick()
		{
			if (!this.SuppressClickEvent)
			{
				if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked))
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this);
					if (automationPeer != null)
					{
						automationPeer.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked);
					}
				}
				base.OnClick();
				if (this.Column != null && this.Column.DataGridOwner != null)
				{
					this.Column.DataGridOwner.PerformSort(this.Column);
				}
			}
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00018FE8 File Offset: 0x000171E8
		private static object OnCoerceHeight(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d;
			global::Microsoft.Windows.Controls.DataGridColumn column = dataGridColumnHeader.Column;
			global::Microsoft.Windows.Controls.DataGrid parentObject = null;
			if (column == null)
			{
				global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter dataGridColumnHeadersPresenter = dataGridColumnHeader.TemplatedParent as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter;
				if (dataGridColumnHeadersPresenter != null)
				{
					parentObject = dataGridColumnHeadersPresenter.ParentDataGrid;
				}
			}
			else
			{
				parentObject = column.DataGridOwner;
			}
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridColumnHeader, baseValue, global::System.Windows.FrameworkElement.HeightProperty, parentObject, global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderHeightProperty);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x0001903C File Offset: 0x0001723C
		private static object OnCoerceCanUserSort(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d;
			global::Microsoft.Windows.Controls.DataGridColumn column = dataGridColumnHeader.Column;
			if (column != null)
			{
				return column.CanUserSort;
			}
			return baseValue;
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00019068 File Offset: 0x00017268
		private static object OnCoerceSortDirection(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d;
			global::Microsoft.Windows.Controls.DataGridColumn column = dataGridColumnHeader.Column;
			if (column != null)
			{
				return column.SortDirection;
			}
			return baseValue;
		}

		// Token: 0x06000642 RID: 1602 RVA: 0x00019093 File Offset: 0x00017293
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.DataGridColumnHeaderAutomationPeer(this);
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0001909B File Offset: 0x0001729B
		internal void Invoke()
		{
			this.OnClick();
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x000190A3 File Offset: 0x000172A3
		public bool IsFrozen
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.IsFrozenProperty);
			}
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x000190B8 File Offset: 0x000172B8
		private static object OnCoerceIsFrozen(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader dataGridColumnHeader = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d;
			global::Microsoft.Windows.Controls.DataGridColumn column = dataGridColumnHeader.Column;
			if (column != null)
			{
				return column.IsFrozen;
			}
			return baseValue;
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x000190E4 File Offset: 0x000172E4
		private static object OnCoerceClip(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader cell = (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)d;
			global::System.Windows.Media.Geometry geometry = baseValue as global::System.Windows.Media.Geometry;
			global::System.Windows.Media.Geometry frozenClipForCell = global::Microsoft.Windows.Controls.DataGridHelper.GetFrozenClipForCell(cell);
			if (frozenClipForCell != null)
			{
				if (geometry == null)
				{
					return frozenClipForCell;
				}
				geometry = new global::System.Windows.Media.CombinedGeometry(global::System.Windows.Media.GeometryCombineMode.Intersect, geometry, frozenClipForCell);
			}
			return geometry;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000647 RID: 1607 RVA: 0x00019118 File Offset: 0x00017318
		internal global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter ParentPresenter
		{
			get
			{
				if (this._parentPresenter == null)
				{
					this._parentPresenter = (global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter);
				}
				return this._parentPresenter;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00019139 File Offset: 0x00017339
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00019141 File Offset: 0x00017341
		internal bool SuppressClickEvent
		{
			get
			{
				return this._suppressClickEvent;
			}
			set
			{
				this._suppressClickEvent = value;
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0001914A File Offset: 0x0001734A
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			if (base.ClickMode == global::System.Windows.Controls.ClickMode.Hover && e.ButtonState == global::System.Windows.Input.MouseButtonState.Pressed)
			{
				base.CaptureMouse();
			}
			this.ParentPresenter.OnHeaderMouseLeftButtonDown(e);
			e.Handled = true;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0001917F File Offset: 0x0001737F
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.ParentPresenter.OnHeaderMouseMove(e);
			e.Handled = true;
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0001919B File Offset: 0x0001739B
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			if (base.ClickMode == global::System.Windows.Controls.ClickMode.Hover && base.IsMouseCaptured)
			{
				base.ReleaseMouseCapture();
			}
			this.ParentPresenter.OnHeaderMouseLeftButtonUp(e);
			e.Handled = true;
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x000191CE File Offset: 0x000173CE
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnLostMouseCapture(e);
			this.ParentPresenter.OnHeaderLostMouseCapture(e);
			e.Handled = true;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600064E RID: 1614 RVA: 0x000191EA File Offset: 0x000173EA
		global::Microsoft.Windows.Controls.DataGridColumn global::Microsoft.Windows.Controls.IProvideDataGridColumn.Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x000191F2 File Offset: 0x000173F2
		private global::System.Windows.Controls.Panel ParentPanel
		{
			get
			{
				return base.VisualParent as global::System.Windows.Controls.Panel;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000650 RID: 1616 RVA: 0x00019200 File Offset: 0x00017400
		private global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader PreviousVisibleHeader
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGridColumn column = this.Column;
				if (column != null)
				{
					global::Microsoft.Windows.Controls.DataGrid dataGridOwner = column.DataGridOwner;
					if (dataGridOwner != null)
					{
						for (int i = this.DisplayIndex - 1; i >= 0; i--)
						{
							if (dataGridOwner.ColumnFromDisplayIndex(i).IsVisible)
							{
								return dataGridOwner.ColumnHeaderFromDisplayIndex(i);
							}
						}
					}
				}
				return null;
			}
		}

		// Token: 0x040001BA RID: 442
		private const string LeftHeaderGripperTemplateName = "PART_LeftHeaderGripper";

		// Token: 0x040001BB RID: 443
		private const string RightHeaderGripperTemplateName = "PART_RightHeaderGripper";

		// Token: 0x040001BC RID: 444
		public static readonly global::System.Windows.DependencyProperty SeparatorBrushProperty = global::System.Windows.DependencyProperty.Register("SeparatorBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040001BD RID: 445
		public static readonly global::System.Windows.DependencyProperty SeparatorVisibilityProperty = global::System.Windows.DependencyProperty.Register("SeparatorVisibility", typeof(global::System.Windows.Visibility), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Visible));

		// Token: 0x040001BE RID: 446
		private static readonly global::System.Windows.DependencyPropertyKey DisplayIndexPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("DisplayIndex", typeof(int), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(-1, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnDisplayIndexChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceDisplayIndex)));

		// Token: 0x040001BF RID: 447
		public static readonly global::System.Windows.DependencyProperty DisplayIndexProperty = global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.DisplayIndexPropertyKey.DependencyProperty;

		// Token: 0x040001C0 RID: 448
		private static readonly global::System.Windows.DependencyPropertyKey CanUserSortPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CanUserSort", typeof(bool), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(true, null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceCanUserSort)));

		// Token: 0x040001C1 RID: 449
		public static readonly global::System.Windows.DependencyProperty CanUserSortProperty = global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.CanUserSortPropertyKey.DependencyProperty;

		// Token: 0x040001C2 RID: 450
		private static readonly global::System.Windows.DependencyPropertyKey SortDirectionPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("SortDirection", typeof(global::System.ComponentModel.ListSortDirection?), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(null, null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceSortDirection)));

		// Token: 0x040001C3 RID: 451
		public static readonly global::System.Windows.DependencyProperty SortDirectionProperty = global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.SortDirectionPropertyKey.DependencyProperty;

		// Token: 0x040001C4 RID: 452
		private static readonly global::System.Windows.DependencyPropertyKey IsFrozenPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFrozen", typeof(bool), typeof(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader), new global::System.Windows.FrameworkPropertyMetadata(false, null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.OnCoerceIsFrozen)));

		// Token: 0x040001C5 RID: 453
		public static readonly global::System.Windows.DependencyProperty IsFrozenProperty = global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader.IsFrozenPropertyKey.DependencyProperty;

		// Token: 0x040001C6 RID: 454
		private global::Microsoft.Windows.Controls.DataGridColumn _column;

		// Token: 0x040001C7 RID: 455
		private global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader> _tracker;

		// Token: 0x040001C8 RID: 456
		private global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter _parentPresenter;

		// Token: 0x040001C9 RID: 457
		private global::System.Windows.Controls.Primitives.Thumb _leftGripper;

		// Token: 0x040001CA RID: 458
		private global::System.Windows.Controls.Primitives.Thumb _rightGripper;

		// Token: 0x040001CB RID: 459
		private bool _suppressClickEvent;
	}
}
