using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Windows.Automation.Peers;
using Microsoft.Windows.Controls.Primitives;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000032 RID: 50
	public class DataGridCell : global::System.Windows.Controls.ContentControl, global::Microsoft.Windows.Controls.IProvideDataGridColumn
	{
		// Token: 0x06000284 RID: 644 RVA: 0x00009B88 File Offset: 0x00007D88
		static DataGridCell()
		{
			global::Microsoft.Windows.Controls.DataGridCell.SelectedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Selected", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Microsoft.Windows.Controls.DataGridCell));
			global::Microsoft.Windows.Controls.DataGridCell.UnselectedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Unselected", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Microsoft.Windows.Controls.DataGridCell));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCell)));
			global::System.Windows.FrameworkElement.StyleProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridCell.OnNotifyPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridCell.OnCoerceStyle)));
			global::System.Windows.UIElement.ClipProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridCell.OnCoerceClip)));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.UIElement.SnapsToDevicePixelsProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Microsoft.Windows.Controls.DataGridCell), global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Microsoft.Windows.Controls.DataGridCell.OnAnyMouseLeftButtonDownThunk), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Microsoft.Windows.Controls.DataGridCell), global::System.Windows.UIElement.LostFocusEvent, new global::System.Windows.RoutedEventHandler(global::Microsoft.Windows.Controls.DataGridCell.OnAnyLostFocus), true);
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Microsoft.Windows.Controls.DataGridCell), global::System.Windows.UIElement.GotFocusEvent, new global::System.Windows.RoutedEventHandler(global::Microsoft.Windows.Controls.DataGridCell.OnAnyGotFocus), true);
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00009E07 File Offset: 0x00008007
		public DataGridCell()
		{
			this._tracker = new global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridCell>(this);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00009E1B File Offset: 0x0000801B
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.DataGridCellAutomationPeer(this);
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00009E23 File Offset: 0x00008023
		internal void PrepareCell(object item, global::System.Windows.Controls.ItemsControl cellsPresenter, global::Microsoft.Windows.Controls.DataGridRow ownerRow)
		{
			this.PrepareCell(item, ownerRow, cellsPresenter.ItemContainerGenerator.IndexFromContainer(this));
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00009E3C File Offset: 0x0000803C
		internal void PrepareCell(object item, global::Microsoft.Windows.Controls.DataGridRow ownerRow, int index)
		{
			this._owner = ownerRow;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this._owner.DataGridOwner;
			if (dataGridOwner != null)
			{
				if (index >= 0 && index < dataGridOwner.Columns.Count)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = dataGridOwner.Columns[index];
					this.Column = dataGridColumn;
					base.TabIndex = dataGridColumn.DisplayIndex;
				}
				if (this.IsEditing)
				{
					this.IsEditing = false;
				}
				else if (!(base.Content is global::System.Windows.FrameworkElement))
				{
					this.BuildVisualTree();
					if (!this.NeedsVisualTree)
					{
						base.Content = item;
					}
				}
				bool isSelected = dataGridOwner.SelectedCellsInternal.Contains(this);
				this.SyncIsSelected(isSelected);
			}
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.StyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridCell.IsReadOnlyProperty);
			base.CoerceValue(global::System.Windows.UIElement.ClipProperty);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00009EF9 File Offset: 0x000080F9
		internal void ClearCell(global::Microsoft.Windows.Controls.DataGridRow ownerRow)
		{
			this._owner = null;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00009F02 File Offset: 0x00008102
		internal global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridCell> Tracker
		{
			get
			{
				return this._tracker;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600028B RID: 651 RVA: 0x00009F0A File Offset: 0x0000810A
		// (set) Token: 0x0600028C RID: 652 RVA: 0x00009F1C File Offset: 0x0000811C
		public global::Microsoft.Windows.Controls.DataGridColumn Column
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridColumn)base.GetValue(global::Microsoft.Windows.Controls.DataGridCell.ColumnProperty);
			}
			internal set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridCell.ColumnPropertyKey, value);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00009F2C File Offset: 0x0000812C
		private static void OnColumnChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = sender as global::Microsoft.Windows.Controls.DataGridCell;
			if (dataGridCell != null)
			{
				dataGridCell.OnColumnChanged((global::Microsoft.Windows.Controls.DataGridColumn)e.OldValue, (global::Microsoft.Windows.Controls.DataGridColumn)e.NewValue);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00009F61 File Offset: 0x00008161
		protected virtual void OnColumnChanged(global::Microsoft.Windows.Controls.DataGridColumn oldColumn, global::Microsoft.Windows.Controls.DataGridColumn newColumn)
		{
			base.Content = null;
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.StyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridCell.IsReadOnlyProperty);
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00009F80 File Offset: 0x00008180
		private static void OnNotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridCell)d).NotifyPropertyChanged(d, string.Empty, e, global::Microsoft.Windows.Controls.NotificationTarget.Cells);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00009F98 File Offset: 0x00008198
		private static void OnNotifyIsReadOnlyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = (global::Microsoft.Windows.Controls.DataGridCell)d;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridCell.DataGridOwner;
			if ((bool)e.NewValue && dataGridOwner != null)
			{
				dataGridOwner.CancelEdit(dataGridCell);
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			dataGridCell.NotifyPropertyChanged(d, string.Empty, e, global::Microsoft.Windows.Controls.NotificationTarget.Cells);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00009FE0 File Offset: 0x000081E0
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, string propertyName, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = d as global::Microsoft.Windows.Controls.DataGridColumn;
			if (dataGridColumn != null && dataGridColumn != this.Column)
			{
				return;
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyCells(target))
			{
				if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.OnColumnWidthChanged(this, e);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CellStyleProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.CellStyleProperty || e.Property == global::System.Windows.FrameworkElement.StyleProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.FrameworkElement.StyleProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.IsReadOnlyProperty || e.Property == global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty || e.Property == global::Microsoft.Windows.Controls.DataGridCell.IsReadOnlyProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridCell.IsReadOnlyProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty)
				{
					base.TabIndex = dataGridColumn.DisplayIndex;
				}
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldRefreshCellContent(target) && dataGridColumn != null && this.NeedsVisualTree)
			{
				if (!string.IsNullOrEmpty(propertyName))
				{
					dataGridColumn.RefreshCellContent(this, propertyName);
					return;
				}
				if (e.Property != null)
				{
					dataGridColumn.RefreshCellContent(this, e.Property.Name);
				}
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0000A0F0 File Offset: 0x000082F0
		private static object OnCoerceStyle(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = d as global::Microsoft.Windows.Controls.DataGridCell;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridCell, baseValue, global::System.Windows.FrameworkElement.StyleProperty, dataGridCell.Column, global::Microsoft.Windows.Controls.DataGridColumn.CellStyleProperty, dataGridCell.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.CellStyleProperty);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000A128 File Offset: 0x00008328
		internal void BuildVisualTree()
		{
			if (this.NeedsVisualTree)
			{
				global::Microsoft.Windows.Controls.DataGridColumn column = this.Column;
				if (column != null)
				{
					global::Microsoft.Windows.Controls.DataGridRow rowOwner = this.RowOwner;
					if (rowOwner != null)
					{
						global::System.Windows.Data.BindingGroup bindingGroup = rowOwner.BindingGroup;
						if (bindingGroup != null)
						{
							this.RemoveBindingExpressions(bindingGroup, base.Content as global::System.Windows.DependencyObject);
						}
					}
					base.Content = column.BuildVisualTree(this.IsEditing, this.RowDataItem, this);
				}
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0000A188 File Offset: 0x00008388
		private void RemoveBindingExpressions(global::System.Windows.Data.BindingGroup bindingGroup, global::System.Windows.DependencyObject element)
		{
			if (element != null)
			{
				global::System.Collections.ObjectModel.Collection<global::System.Windows.Data.BindingExpressionBase> bindingExpressions = bindingGroup.BindingExpressions;
				global::System.Windows.LocalValueEnumerator localValueEnumerator = element.GetLocalValueEnumerator();
				while (localValueEnumerator.MoveNext())
				{
					global::System.Windows.LocalValueEntry localValueEntry = localValueEnumerator.Current;
					global::System.Windows.Data.BindingExpression bindingExpression = localValueEntry.Value as global::System.Windows.Data.BindingExpression;
					if (bindingExpression != null)
					{
						for (int i = 0; i < bindingExpressions.Count; i++)
						{
							if (object.ReferenceEquals(bindingExpression, bindingExpressions[i]))
							{
								bindingExpressions.RemoveAt(i--);
							}
						}
					}
				}
				foreach (object obj in global::System.Windows.LogicalTreeHelper.GetChildren(element))
				{
					this.RemoveBindingExpressions(bindingGroup, obj as global::System.Windows.DependencyObject);
				}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000A250 File Offset: 0x00008450
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0000A262 File Offset: 0x00008462
		public bool IsEditing
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridCell.IsEditingProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridCell.IsEditingProperty, value);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000A275 File Offset: 0x00008475
		private static void OnIsEditingChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridCell)sender).OnIsEditingChanged((bool)e.NewValue);
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000A28E File Offset: 0x0000848E
		protected virtual void OnIsEditingChanged(bool isEditing)
		{
			if (base.IsKeyboardFocusWithin && !base.IsKeyboardFocused)
			{
				base.Focus();
			}
			this.BuildVisualTree();
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000299 RID: 665 RVA: 0x0000A2AD File Offset: 0x000084AD
		public bool IsReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridCell.IsReadOnlyProperty);
			}
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000A2C0 File Offset: 0x000084C0
		private static object OnCoerceIsReadOnly(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = d as global::Microsoft.Windows.Controls.DataGridCell;
			global::Microsoft.Windows.Controls.DataGridColumn column = dataGridCell.Column;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridCell.DataGridOwner;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(column, column.IsReadOnly, global::Microsoft.Windows.Controls.DataGridColumn.IsReadOnlyProperty, dataGridOwner, global::Microsoft.Windows.Controls.DataGrid.IsReadOnlyProperty);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000A300 File Offset: 0x00008500
		private static void OnAnyLostFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::Microsoft.Windows.Controls.DataGridCell>(e.OriginalSource as global::System.Windows.UIElement);
			if (dataGridCell != null && dataGridCell == sender)
			{
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridCell.DataGridOwner;
				if (dataGridOwner != null && !dataGridCell.IsKeyboardFocusWithin && dataGridOwner.FocusedCell == dataGridCell)
				{
					dataGridOwner.FocusedCell = null;
				}
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000A348 File Offset: 0x00008548
		private static void OnAnyGotFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::Microsoft.Windows.Controls.DataGridCell>(e.OriginalSource as global::System.Windows.UIElement);
			if (dataGridCell != null && dataGridCell == sender)
			{
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridCell.DataGridOwner;
				if (dataGridOwner != null)
				{
					dataGridOwner.FocusedCell = dataGridCell;
				}
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000A380 File Offset: 0x00008580
		internal void BeginEdit(global::System.Windows.RoutedEventArgs e)
		{
			this.IsEditing = true;
			global::Microsoft.Windows.Controls.DataGridColumn column = this.Column;
			if (column != null)
			{
				column.BeginEdit(base.Content as global::System.Windows.FrameworkElement, e);
			}
			this.RaisePreparingCellForEdit(e);
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000A3B8 File Offset: 0x000085B8
		internal void CancelEdit()
		{
			global::Microsoft.Windows.Controls.DataGridColumn column = this.Column;
			if (column != null)
			{
				column.CancelEdit(base.Content as global::System.Windows.FrameworkElement);
			}
			this.IsEditing = false;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000A3E8 File Offset: 0x000085E8
		internal bool CommitEdit()
		{
			bool flag = true;
			global::Microsoft.Windows.Controls.DataGridColumn column = this.Column;
			if (column != null)
			{
				flag = column.CommitEdit(base.Content as global::System.Windows.FrameworkElement);
			}
			if (flag)
			{
				this.IsEditing = false;
			}
			return flag;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000A420 File Offset: 0x00008620
		private void RaisePreparingCellForEdit(global::System.Windows.RoutedEventArgs editingEventArgs)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
			if (dataGridOwner != null)
			{
				global::System.Windows.FrameworkElement editingElement = this.EditingElement;
				global::Microsoft.Windows.Controls.DataGridPreparingCellForEditEventArgs e = new global::Microsoft.Windows.Controls.DataGridPreparingCellForEditEventArgs(this.Column, this.RowOwner, editingEventArgs, editingElement);
				dataGridOwner.OnPreparingCellForEdit(e);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x0000A459 File Offset: 0x00008659
		internal global::System.Windows.FrameworkElement EditingElement
		{
			get
			{
				return base.Content as global::System.Windows.FrameworkElement;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000A466 File Offset: 0x00008666
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x0000A478 File Offset: 0x00008678
		public bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridCell.IsSelectedProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridCell.IsSelectedProperty, value);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000A48C File Offset: 0x0000868C
		private static void OnIsSelectedChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = (global::Microsoft.Windows.Controls.DataGridCell)sender;
			bool isSelected = (bool)e.NewValue;
			if (!dataGridCell._syncingIsSelected)
			{
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridCell.DataGridOwner;
				if (dataGridOwner != null)
				{
					dataGridOwner.CellIsSelectedChanged(dataGridCell, isSelected);
				}
			}
			dataGridCell.RaiseSelectionChangedEvent(isSelected);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000A4D0 File Offset: 0x000086D0
		internal void SyncIsSelected(bool isSelected)
		{
			bool syncingIsSelected = this._syncingIsSelected;
			this._syncingIsSelected = true;
			try
			{
				this.IsSelected = isSelected;
			}
			finally
			{
				this._syncingIsSelected = syncingIsSelected;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000A50C File Offset: 0x0000870C
		private void RaiseSelectionChangedEvent(bool isSelected)
		{
			if (isSelected)
			{
				this.OnSelected(new global::System.Windows.RoutedEventArgs(global::Microsoft.Windows.Controls.DataGridCell.SelectedEvent, this));
				return;
			}
			this.OnUnselected(new global::System.Windows.RoutedEventArgs(global::Microsoft.Windows.Controls.DataGridCell.UnselectedEvent, this));
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060002A7 RID: 679 RVA: 0x0000A534 File Offset: 0x00008734
		// (remove) Token: 0x060002A8 RID: 680 RVA: 0x0000A542 File Offset: 0x00008742
		public event global::System.Windows.RoutedEventHandler Selected
		{
			add
			{
				base.AddHandler(global::Microsoft.Windows.Controls.DataGridCell.SelectedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Microsoft.Windows.Controls.DataGridCell.SelectedEvent, value);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000A550 File Offset: 0x00008750
		protected virtual void OnSelected(global::System.Windows.RoutedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060002AA RID: 682 RVA: 0x0000A559 File Offset: 0x00008759
		// (remove) Token: 0x060002AB RID: 683 RVA: 0x0000A567 File Offset: 0x00008767
		public event global::System.Windows.RoutedEventHandler Unselected
		{
			add
			{
				base.AddHandler(global::Microsoft.Windows.Controls.DataGridCell.UnselectedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Microsoft.Windows.Controls.DataGridCell.UnselectedEvent, value);
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000A575 File Offset: 0x00008775
		protected virtual void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000A580 File Offset: 0x00008780
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size constraint)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.IsGridLineVisible(this.DataGridOwner, false))
			{
				double verticalGridLineThickness = this.DataGridOwner.VerticalGridLineThickness;
				global::System.Windows.Size result = base.MeasureOverride(global::Microsoft.Windows.Controls.DataGridHelper.SubtractFromSize(constraint, verticalGridLineThickness, false));
				result.Width += verticalGridLineThickness;
				return result;
			}
			return base.MeasureOverride(constraint);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000A5D0 File Offset: 0x000087D0
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeSize)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.IsGridLineVisible(this.DataGridOwner, false))
			{
				double verticalGridLineThickness = this.DataGridOwner.VerticalGridLineThickness;
				global::System.Windows.Size result = base.ArrangeOverride(global::Microsoft.Windows.Controls.DataGridHelper.SubtractFromSize(arrangeSize, verticalGridLineThickness, false));
				result.Width += verticalGridLineThickness;
				return result;
			}
			return base.ArrangeOverride(arrangeSize);
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000A620 File Offset: 0x00008820
		protected override void OnRender(global::System.Windows.Media.DrawingContext drawingContext)
		{
			base.OnRender(drawingContext);
			if (global::Microsoft.Windows.Controls.DataGridHelper.IsGridLineVisible(this.DataGridOwner, false))
			{
				double verticalGridLineThickness = this.DataGridOwner.VerticalGridLineThickness;
				global::System.Windows.Rect rectangle = new global::System.Windows.Rect(new global::System.Windows.Size(verticalGridLineThickness, base.RenderSize.Height));
				rectangle.X = base.RenderSize.Width - verticalGridLineThickness;
				drawingContext.DrawRectangle(this.DataGridOwner.VerticalGridLinesBrush, null, rectangle);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x0000A693 File Offset: 0x00008893
		private static void OnAnyMouseLeftButtonDownThunk(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGridCell)sender).OnAnyMouseLeftButtonDown(e);
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000A6A4 File Offset: 0x000088A4
		private void OnAnyMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			bool isKeyboardFocusWithin = base.IsKeyboardFocusWithin;
			bool flag = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
			if (isKeyboardFocusWithin && !flag && !e.Handled && !this.IsEditing && !this.IsReadOnly && this.IsSelected)
			{
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
				if (dataGridOwner != null)
				{
					dataGridOwner.HandleSelectionForCellInput(this, false, true, false);
					dataGridOwner.BeginEdit(e);
					e.Handled = true;
					return;
				}
			}
			else if (!isKeyboardFocusWithin || !this.IsSelected || flag)
			{
				if (!isKeyboardFocusWithin)
				{
					base.Focus();
				}
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner2 = this.DataGridOwner;
				if (dataGridOwner2 != null)
				{
					dataGridOwner2.HandleSelectionForCellInput(this, global::System.Windows.Input.Mouse.Captured == null, true, true);
				}
				e.Handled = true;
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000A747 File Offset: 0x00008947
		protected override void OnTextInput(global::System.Windows.Input.TextCompositionEventArgs e)
		{
			this.SendInputToColumn(e);
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000A750 File Offset: 0x00008950
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			this.SendInputToColumn(e);
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x0000A75C File Offset: 0x0000895C
		private void SendInputToColumn(global::System.Windows.Input.InputEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridColumn column = this.Column;
			if (column != null)
			{
				column.OnInput(e);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x0000A77C File Offset: 0x0000897C
		private static object OnCoerceClip(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridCell cell = (global::Microsoft.Windows.Controls.DataGridCell)d;
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000A7B0 File Offset: 0x000089B0
		internal global::Microsoft.Windows.Controls.DataGrid DataGridOwner
		{
			get
			{
				if (this._owner != null)
				{
					global::Microsoft.Windows.Controls.DataGrid dataGrid = this._owner.DataGridOwner;
					if (dataGrid == null)
					{
						dataGrid = (global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this._owner) as global::Microsoft.Windows.Controls.DataGrid);
					}
					return dataGrid;
				}
				return null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x0000A7E8 File Offset: 0x000089E8
		private global::System.Windows.Controls.Panel ParentPanel
		{
			get
			{
				return base.VisualParent as global::System.Windows.Controls.Panel;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0000A7F5 File Offset: 0x000089F5
		internal global::Microsoft.Windows.Controls.DataGridRow RowOwner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002B9 RID: 697 RVA: 0x0000A800 File Offset: 0x00008A00
		internal object RowDataItem
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGridRow rowOwner = this.RowOwner;
				if (rowOwner != null)
				{
					return rowOwner.Item;
				}
				return base.DataContext;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0000A824 File Offset: 0x00008A24
		private global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter CellsPresenter
		{
			get
			{
				return global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(this) as global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002BB RID: 699 RVA: 0x0000A831 File Offset: 0x00008A31
		private bool NeedsVisualTree
		{
			get
			{
				return base.ContentTemplate == null && base.ContentTemplateSelector == null;
			}
		}

		// Token: 0x040000AE RID: 174
		private static readonly global::System.Windows.DependencyPropertyKey ColumnPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Column", typeof(global::Microsoft.Windows.Controls.DataGridColumn), typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridCell.OnColumnChanged)));

		// Token: 0x040000AF RID: 175
		public static readonly global::System.Windows.DependencyProperty ColumnProperty = global::Microsoft.Windows.Controls.DataGridCell.ColumnPropertyKey.DependencyProperty;

		// Token: 0x040000B0 RID: 176
		public static readonly global::System.Windows.DependencyProperty IsEditingProperty = global::System.Windows.DependencyProperty.Register("IsEditing", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridCell.OnIsEditingChanged)));

		// Token: 0x040000B1 RID: 177
		private static readonly global::System.Windows.DependencyPropertyKey IsReadOnlyPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsReadOnly", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridCell.OnNotifyIsReadOnlyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridCell.OnCoerceIsReadOnly)));

		// Token: 0x040000B2 RID: 178
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty = global::Microsoft.Windows.Controls.DataGridCell.IsReadOnlyPropertyKey.DependencyProperty;

		// Token: 0x040000B3 RID: 179
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridCell), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridCell.OnIsSelectedChanged)));

		// Token: 0x040000B6 RID: 182
		private global::Microsoft.Windows.Controls.DataGridRow _owner;

		// Token: 0x040000B7 RID: 183
		private global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridCell> _tracker;

		// Token: 0x040000B8 RID: 184
		private bool _syncingIsSelected;
	}
}
