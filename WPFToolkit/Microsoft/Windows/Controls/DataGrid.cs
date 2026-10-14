using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Microsoft.Windows.Automation.Peers;
using Microsoft.Windows.Controls.Primitives;
using MS.Internal;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000038 RID: 56
	public class DataGrid : global::System.Windows.Controls.Primitives.MultiSelector
	{
		// Token: 0x06000312 RID: 786 RVA: 0x0000B880 File Offset: 0x00009A80
		static DataGrid()
		{
			global::System.Type typeFromHandle = typeof(global::Microsoft.Windows.Controls.DataGrid);
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.DataGrid)));
			global::System.Windows.FrameworkElementFactory frameworkElementFactory = new global::System.Windows.FrameworkElementFactory(typeof(global::Microsoft.Windows.Controls.Primitives.DataGridRowsPresenter));
			frameworkElementFactory.SetValue(global::System.Windows.FrameworkElement.NameProperty, "PART_RowsPresenter");
			global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Controls.ItemsPanelTemplate(frameworkElementFactory)));
			global::System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(true, null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceIsVirtualizingProperty)));
			global::System.Windows.Controls.VirtualizingStackPanel.VirtualizationModeProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.VirtualizationMode.Recycling));
			global::System.Windows.Controls.ItemsControl.ItemContainerStyleProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceItemContainerStyle)));
			global::System.Windows.Controls.ItemsControl.ItemContainerStyleSelectorProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceItemContainerStyleSelector)));
			global::System.Windows.Controls.ItemsControl.ItemsSourceProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceItemsSourceProperty)));
			global::System.Windows.Controls.ItemsControl.AlternationCountProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(0, null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceAlternationCount)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnIsEnabledChanged)));
			global::System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItemProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceIsSynchronizedWithCurrentItem)));
			global::System.Windows.Controls.Control.IsTabStopProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Contained));
			global::System.Windows.Input.KeyboardNavigation.ControlTabNavigationProperty.OverrideMetadata(typeFromHandle, new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Once));
			global::System.Windows.Input.CommandManager.RegisterClassInputBinding(typeFromHandle, new global::System.Windows.Input.InputBinding(global::Microsoft.Windows.Controls.DataGrid.BeginEditCommand, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.F2)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeFromHandle, new global::System.Windows.Input.CommandBinding(global::Microsoft.Windows.Controls.DataGrid.BeginEditCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnExecutedBeginEdit), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnCanExecuteBeginEdit)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeFromHandle, new global::System.Windows.Input.CommandBinding(global::Microsoft.Windows.Controls.DataGrid.CommitEditCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnExecutedCommitEdit), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnCanExecuteCommitEdit)));
			global::System.Windows.Input.CommandManager.RegisterClassInputBinding(typeFromHandle, new global::System.Windows.Input.InputBinding(global::Microsoft.Windows.Controls.DataGrid.CancelEditCommand, new global::System.Windows.Input.KeyGesture(global::System.Windows.Input.Key.Escape)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeFromHandle, new global::System.Windows.Input.CommandBinding(global::Microsoft.Windows.Controls.DataGrid.CancelEditCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnExecutedCancelEdit), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnCanExecuteCancelEdit)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeFromHandle, new global::System.Windows.Input.CommandBinding(global::Microsoft.Windows.Controls.DataGrid.SelectAllCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnExecutedSelectAll), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnCanExecuteSelectAll)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeFromHandle, new global::System.Windows.Input.CommandBinding(global::Microsoft.Windows.Controls.DataGrid.DeleteCommand, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnExecutedDelete), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnCanExecuteDelete)));
			global::System.Windows.Input.CommandManager.RegisterClassCommandBinding(typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.Input.CommandBinding(global::System.Windows.Input.ApplicationCommands.Copy, new global::System.Windows.Input.ExecutedRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnExecutedCopy), new global::System.Windows.Input.CanExecuteRoutedEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnCanExecuteCopy)));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Microsoft.Windows.Controls.DataGrid), global::System.Windows.UIElement.MouseUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(global::Microsoft.Windows.Controls.DataGrid.OnAnyMouseUpThunk), true);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000C768 File Offset: 0x0000A968
		public DataGrid()
		{
			this._columns = new global::Microsoft.Windows.Controls.DataGridColumnCollection(this);
			this._columns.CollectionChanged += this.OnColumnsChanged;
			this._rowValidationRules = new global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.Controls.ValidationRule>();
			this._rowValidationRules.CollectionChanged += this.OnRowValidationRulesChanged;
			this._selectedCells = new global::Microsoft.Windows.Controls.SelectedCellsCollection(this);
			((global::System.Collections.Specialized.INotifyCollectionChanged)base.Items).CollectionChanged += this.OnItemsCollectionChanged;
			((global::System.Collections.Specialized.INotifyCollectionChanged)base.Items.SortDescriptions).CollectionChanged += this.OnItemsSortDescriptionsChanged;
			base.Items.GroupDescriptions.CollectionChanged += this.OnItemsGroupDescriptionsChanged;
			this.InternalColumns.InvalidateColumnWidthsComputation();
			this.CellsPanelHorizontalOffsetComputationPending = false;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000C84D File Offset: 0x0000AA4D
		public global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn> Columns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000315 RID: 789 RVA: 0x0000C855 File Offset: 0x0000AA55
		internal global::Microsoft.Windows.Controls.DataGridColumnCollection InternalColumns
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000C85D File Offset: 0x0000AA5D
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0000C86F File Offset: 0x0000AA6F
		public bool CanUserResizeColumns
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserResizeColumnsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserResizeColumnsProperty, value);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000C882 File Offset: 0x0000AA82
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0000C894 File Offset: 0x0000AA94
		public global::Microsoft.Windows.Controls.DataGridLength ColumnWidth
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridLength)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.ColumnWidthProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.ColumnWidthProperty, value);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000C8A7 File Offset: 0x0000AAA7
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0000C8B9 File Offset: 0x0000AAB9
		public double MinColumnWidth
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.MinColumnWidthProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.MinColumnWidthProperty, value);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000C8CC File Offset: 0x0000AACC
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0000C8DE File Offset: 0x0000AADE
		public double MaxColumnWidth
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.MaxColumnWidthProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.MaxColumnWidthProperty, value);
			}
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000C8F1 File Offset: 0x0000AAF1
		private static void OnColumnSizeConstraintChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Columns);
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000C904 File Offset: 0x0000AB04
		private static bool ValidateMinColumnWidth(object v)
		{
			double num = (double)v;
			return num >= 0.0 && !global::MS.Internal.DoubleUtil.IsNaN(num) && !double.IsPositiveInfinity(num);
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000C938 File Offset: 0x0000AB38
		private static bool ValidateMaxColumnWidth(object v)
		{
			double num = (double)v;
			return num >= 0.0 && !global::MS.Internal.DoubleUtil.IsNaN(num);
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000C964 File Offset: 0x0000AB64
		private void OnColumnsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				this.UpdateDataGridReference(e.NewItems, false);
				global::Microsoft.Windows.Controls.DataGrid.UpdateColumnSizeConstraints(e.NewItems);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				this.UpdateDataGridReference(e.OldItems, true);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				this.UpdateDataGridReference(e.OldItems, true);
				this.UpdateDataGridReference(e.NewItems, false);
				global::Microsoft.Windows.Controls.DataGrid.UpdateColumnSizeConstraints(e.NewItems);
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				this._selectedCells.Clear();
				break;
			}
			if (this.InternalColumns.DisplayIndexMapInitialized)
			{
				base.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.FrozenColumnCountProperty);
			}
			bool flag = global::Microsoft.Windows.Controls.DataGrid.HasVisibleColumns(e.OldItems);
			flag |= global::Microsoft.Windows.Controls.DataGrid.HasVisibleColumns(e.NewItems);
			flag |= (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset);
			if (flag)
			{
				this.InternalColumns.InvalidateColumnRealization(true);
			}
			this.UpdateColumnsOnRows(e);
			if (flag && e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Move)
			{
				this.InternalColumns.InvalidateColumnWidthsComputation();
			}
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000CA5C File Offset: 0x0000AC5C
		internal void UpdateDataGridReference(global::System.Collections.IList list, bool clear)
		{
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)list[i];
				if (clear)
				{
					if (dataGridColumn.DataGridOwner == this)
					{
						dataGridColumn.DataGridOwner = null;
					}
				}
				else
				{
					if (dataGridColumn.DataGridOwner != null && dataGridColumn.DataGridOwner != this)
					{
						dataGridColumn.DataGridOwner.Columns.Remove(dataGridColumn);
					}
					dataGridColumn.DataGridOwner = this;
				}
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		private static void UpdateColumnSizeConstraints(global::System.Collections.IList list)
		{
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)list[i];
				dataGridColumn.SyncProperties();
			}
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000CAFC File Offset: 0x0000ACFC
		private static bool HasVisibleColumns(global::System.Collections.IList columns)
		{
			if (columns != null && columns.Count > 0)
			{
				foreach (object obj in columns)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)obj;
					if (dataGridColumn.IsVisible)
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000CB64 File Offset: 0x0000AD64
		public global::Microsoft.Windows.Controls.DataGridColumn ColumnFromDisplayIndex(int displayIndex)
		{
			if (displayIndex < 0 || displayIndex >= this.Columns.Count)
			{
				throw new global::System.ArgumentOutOfRangeException("displayIndex", displayIndex, global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_DisplayIndexOutOfRange));
			}
			return this.InternalColumns.ColumnFromDisplayIndex(displayIndex);
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000326 RID: 806 RVA: 0x0000CB9F File Offset: 0x0000AD9F
		// (remove) Token: 0x06000327 RID: 807 RVA: 0x0000CBB8 File Offset: 0x0000ADB8
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridColumnEventArgs> ColumnDisplayIndexChanged;

		// Token: 0x06000328 RID: 808 RVA: 0x0000CBD1 File Offset: 0x0000ADD1
		protected internal virtual void OnColumnDisplayIndexChanged(global::Microsoft.Windows.Controls.DataGridColumnEventArgs e)
		{
			if (this.ColumnDisplayIndexChanged != null)
			{
				this.ColumnDisplayIndexChanged(this, e);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		internal global::System.Collections.Generic.List<int> DisplayIndexMap
		{
			get
			{
				return this.InternalColumns.DisplayIndexMap;
			}
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000CBF5 File Offset: 0x0000ADF5
		internal void ValidateDisplayIndex(global::Microsoft.Windows.Controls.DataGridColumn column, int displayIndex)
		{
			this.InternalColumns.ValidateDisplayIndex(column, displayIndex);
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000CC04 File Offset: 0x0000AE04
		internal int ColumnIndexFromDisplayIndex(int displayIndex)
		{
			if (displayIndex >= 0 && displayIndex < this.DisplayIndexMap.Count)
			{
				return this.DisplayIndexMap[displayIndex];
			}
			return -1;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000CC28 File Offset: 0x0000AE28
		internal global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader ColumnHeaderFromDisplayIndex(int displayIndex)
		{
			int num = this.ColumnIndexFromDisplayIndex(displayIndex);
			if (num != -1 && this.ColumnHeadersPresenter != null && this.ColumnHeadersPresenter.ItemContainerGenerator != null)
			{
				return (global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader)this.ColumnHeadersPresenter.ItemContainerGenerator.ContainerFromIndex(num);
			}
			return null;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000CC6E File Offset: 0x0000AE6E
		private static void OnNotifyCellsPresenterPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter);
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000CC7E File Offset: 0x0000AE7E
		private static void OnNotifyColumnAndCellPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Cells | global::Microsoft.Windows.Controls.NotificationTarget.Columns);
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000CC8E File Offset: 0x0000AE8E
		private static void OnNotifyColumnPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Columns);
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000CC9E File Offset: 0x0000AE9E
		private static void OnNotifyColumnAndColumnHeaderPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Columns | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000CCAF File Offset: 0x0000AEAF
		private static void OnNotifyColumnHeaderPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000CCC0 File Offset: 0x0000AEC0
		private static void OnNotifyHeaderPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeaders | global::Microsoft.Windows.Controls.NotificationTarget.RowHeaders);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		private static void OnNotifyDataGridAndRowPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.DataGrid | global::Microsoft.Windows.Controls.NotificationTarget.Rows);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		private static void OnNotifyGridLinePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.OldValue != e.NewValue)
			{
				((global::Microsoft.Windows.Controls.DataGrid)d).OnItemTemplateChanged(null, null);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000CD07 File Offset: 0x0000AF07
		private static void OnNotifyRowPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Rows);
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000CD1B File Offset: 0x0000AF1B
		private static void OnNotifyRowHeaderPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.RowHeaders);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000CD2F File Offset: 0x0000AF2F
		private static void OnNotifyRowAndRowHeaderPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.RowHeaders | global::Microsoft.Windows.Controls.NotificationTarget.Rows);
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000CD43 File Offset: 0x0000AF43
		private static void OnNotifyRowAndDetailsPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.DetailsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.Rows);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000CD57 File Offset: 0x0000AF57
		private static void OnNotifyHorizontalOffsetPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.ColumnCollection | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000CD68 File Offset: 0x0000AF68
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			this.NotifyPropertyChanged(d, string.Empty, e, target);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000CD78 File Offset: 0x0000AF78
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, string propertyName, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyDataGrid(target) && e.Property == global::Microsoft.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty)
			{
				base.CoerceValue(global::System.Windows.Controls.ItemsControl.AlternationCountProperty);
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyRowSubtree(target))
			{
				for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow> containerTracking = this._rowTrackingRoot; containerTracking != null; containerTracking = containerTracking.Next)
				{
					containerTracking.Container.NotifyPropertyChanged(d, propertyName, e, target);
				}
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumnCollection(target) || global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumns(target))
			{
				this.InternalColumns.NotifyPropertyChanged(d, propertyName, e, target);
			}
			if ((global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumnHeadersPresenter(target) || global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumnHeaders(target)) && this.ColumnHeadersPresenter != null)
			{
				this.ColumnHeadersPresenter.NotifyPropertyChanged(d, propertyName, e, target);
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000CE20 File Offset: 0x0000B020
		internal void UpdateColumnsOnVirtualizedCellInfoCollections(global::System.Collections.Specialized.NotifyCollectionChangedAction action, int oldDisplayIndex, global::Microsoft.Windows.Controls.DataGridColumn oldColumn, int newDisplayIndex)
		{
			using (this.UpdateSelectedCells())
			{
				this._selectedCells.OnColumnsChanged(action, oldDisplayIndex, oldColumn, newDisplayIndex, base.SelectedItems);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000CE68 File Offset: 0x0000B068
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0000CE70 File Offset: 0x0000B070
		internal global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter ColumnHeadersPresenter
		{
			get
			{
				return this._columnHeadersPresenter;
			}
			set
			{
				this._columnHeadersPresenter = value;
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000CE79 File Offset: 0x0000B079
		protected override void OnTemplateChanged(global::System.Windows.Controls.ControlTemplate oldTemplate, global::System.Windows.Controls.ControlTemplate newTemplate)
		{
			base.OnTemplateChanged(oldTemplate, newTemplate);
			this.ColumnHeadersPresenter = null;
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000CE8A File Offset: 0x0000B08A
		// (set) Token: 0x06000341 RID: 833 RVA: 0x0000CE9C File Offset: 0x0000B09C
		public global::Microsoft.Windows.Controls.DataGridGridLinesVisibility GridLinesVisibility
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridGridLinesVisibility)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.GridLinesVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.GridLinesVisibilityProperty, value);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000342 RID: 834 RVA: 0x0000CEAF File Offset: 0x0000B0AF
		// (set) Token: 0x06000343 RID: 835 RVA: 0x0000CEC1 File Offset: 0x0000B0C1
		public global::System.Windows.Media.Brush HorizontalGridLinesBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.HorizontalGridLinesBrushProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.HorizontalGridLinesBrushProperty, value);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x06000344 RID: 836 RVA: 0x0000CECF File Offset: 0x0000B0CF
		// (set) Token: 0x06000345 RID: 837 RVA: 0x0000CEE1 File Offset: 0x0000B0E1
		public global::System.Windows.Media.Brush VerticalGridLinesBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.VerticalGridLinesBrushProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.VerticalGridLinesBrushProperty, value);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000CEEF File Offset: 0x0000B0EF
		internal double HorizontalGridLineThickness
		{
			get
			{
				return 1.0;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000347 RID: 839 RVA: 0x0000CEFA File Offset: 0x0000B0FA
		internal double VerticalGridLineThickness
		{
			get
			{
				return 1.0;
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000CF05 File Offset: 0x0000B105
		protected override bool IsItemItsOwnContainerOverride(object item)
		{
			return item is global::Microsoft.Windows.Controls.DataGridRow;
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000CF10 File Offset: 0x0000B110
		protected override global::System.Windows.DependencyObject GetContainerForItemOverride()
		{
			return new global::Microsoft.Windows.Controls.DataGridRow();
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000CF18 File Offset: 0x0000B118
		protected override void PrepareContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.PrepareContainerForItemOverride(element, item);
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)element;
			if (dataGridRow.DataGridOwner != this)
			{
				dataGridRow.Tracker.StartTracking(ref this._rowTrackingRoot);
				this.EnsureInternalScrollControls();
			}
			dataGridRow.PrepareRow(item, this);
			this.OnLoadingRow(new global::Microsoft.Windows.Controls.DataGridRowEventArgs(dataGridRow));
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000CF68 File Offset: 0x0000B168
		protected override void ClearContainerForItemOverride(global::System.Windows.DependencyObject element, object item)
		{
			base.ClearContainerForItemOverride(element, item);
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)element;
			if (dataGridRow.DataGridOwner == this)
			{
				dataGridRow.Tracker.StopTracking(ref this._rowTrackingRoot);
			}
			this.OnUnloadingRow(new global::Microsoft.Windows.Controls.DataGridRowEventArgs(dataGridRow));
			dataGridRow.ClearRow(this);
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000CFB4 File Offset: 0x0000B1B4
		private void UpdateColumnsOnRows(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow> containerTracking = this._rowTrackingRoot; containerTracking != null; containerTracking = containerTracking.Next)
			{
				containerTracking.Container.OnColumnsChanged(this._columns, e);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600034D RID: 845 RVA: 0x0000CFE6 File Offset: 0x0000B1E6
		// (set) Token: 0x0600034E RID: 846 RVA: 0x0000CFF8 File Offset: 0x0000B1F8
		public global::System.Windows.Style RowStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowStyleProperty, value);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000D006 File Offset: 0x0000B206
		private static void OnRowStyleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.Controls.ItemsControl.ItemContainerStyleProperty);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D013 File Offset: 0x0000B213
		private static object OnCoerceItemContainerStyle(global::System.Windows.DependencyObject d, object baseValue)
		{
			if (!global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(d, global::Microsoft.Windows.Controls.DataGrid.RowStyleProperty))
			{
				return d.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowStyleProperty);
			}
			return baseValue;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000D02F File Offset: 0x0000B22F
		// (set) Token: 0x06000352 RID: 850 RVA: 0x0000D041 File Offset: 0x0000B241
		public global::System.Windows.Controls.ControlTemplate RowValidationErrorTemplate
		{
			get
			{
				return (global::System.Windows.Controls.ControlTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowValidationErrorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowValidationErrorTemplateProperty, value);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000D04F File Offset: 0x0000B24F
		public global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.Controls.ValidationRule> RowValidationRules
		{
			get
			{
				return this._rowValidationRules;
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000D058 File Offset: 0x0000B258
		private void OnRowValidationRulesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.Windows.Data.BindingGroup bindingGroup = base.ItemBindingGroup;
			if (bindingGroup == null)
			{
				bindingGroup = (base.ItemBindingGroup = new global::System.Windows.Data.BindingGroup());
				this._rowValidationBindingGroup = bindingGroup;
			}
			if (this._rowValidationBindingGroup != null)
			{
				if (object.ReferenceEquals(bindingGroup, this._rowValidationBindingGroup))
				{
					switch (e.Action)
					{
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
						using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								object obj = enumerator.Current;
								global::System.Windows.Controls.ValidationRule item = (global::System.Windows.Controls.ValidationRule)obj;
								this._rowValidationBindingGroup.ValidationRules.Add(item);
							}
							return;
						}
						break;
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
						break;
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
						goto IL_FF;
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
						return;
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
						goto IL_19C;
					default:
						return;
					}
					using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							object obj2 = enumerator2.Current;
							global::System.Windows.Controls.ValidationRule item2 = (global::System.Windows.Controls.ValidationRule)obj2;
							this._rowValidationBindingGroup.ValidationRules.Remove(item2);
						}
						return;
					}
					IL_FF:
					foreach (object obj3 in e.OldItems)
					{
						global::System.Windows.Controls.ValidationRule item3 = (global::System.Windows.Controls.ValidationRule)obj3;
						this._rowValidationBindingGroup.ValidationRules.Remove(item3);
					}
					using (global::System.Collections.IEnumerator enumerator4 = e.NewItems.GetEnumerator())
					{
						while (enumerator4.MoveNext())
						{
							object obj4 = enumerator4.Current;
							global::System.Windows.Controls.ValidationRule item4 = (global::System.Windows.Controls.ValidationRule)obj4;
							this._rowValidationBindingGroup.ValidationRules.Add(item4);
						}
						return;
					}
					IL_19C:
					this._rowValidationBindingGroup.ValidationRules.Clear();
					return;
				}
				this._rowValidationBindingGroup = null;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000D250 File Offset: 0x0000B450
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0000D262 File Offset: 0x0000B462
		public global::System.Windows.Controls.StyleSelector RowStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowStyleSelectorProperty, value);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000D270 File Offset: 0x0000B470
		private static void OnRowStyleSelectorChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::System.Windows.Controls.ItemsControl.ItemContainerStyleSelectorProperty);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x0000D27D File Offset: 0x0000B47D
		private static object OnCoerceItemContainerStyleSelector(global::System.Windows.DependencyObject d, object baseValue)
		{
			if (!global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(d, global::Microsoft.Windows.Controls.DataGrid.RowStyleSelectorProperty))
			{
				return d.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowStyleSelectorProperty);
			}
			return baseValue;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000D29C File Offset: 0x0000B49C
		private static object OnCoerceIsSynchronizedWithCurrentItem(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			if (dataGrid.SelectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.Cell)
			{
				return false;
			}
			return baseValue;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000D2D2 File Offset: 0x0000B4D2
		public global::System.Windows.Media.Brush RowBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowBackgroundProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowBackgroundProperty, value);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000D2E0 File Offset: 0x0000B4E0
		// (set) Token: 0x0600035D RID: 861 RVA: 0x0000D2F2 File Offset: 0x0000B4F2
		public global::System.Windows.Media.Brush AlternatingRowBackground
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty, value);
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000D300 File Offset: 0x0000B500
		private static object OnCoerceAlternationCount(global::System.Windows.DependencyObject d, object baseValue)
		{
			if ((int)baseValue < 2)
			{
				global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
				if (dataGrid.AlternatingRowBackground != null)
				{
					return 2;
				}
			}
			return baseValue;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0000D32D File Offset: 0x0000B52D
		// (set) Token: 0x06000360 RID: 864 RVA: 0x0000D33F File Offset: 0x0000B53F
		public double RowHeight
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeightProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeightProperty, value);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000361 RID: 865 RVA: 0x0000D352 File Offset: 0x0000B552
		// (set) Token: 0x06000362 RID: 866 RVA: 0x0000D364 File Offset: 0x0000B564
		public double MinRowHeight
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.MinRowHeightProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.MinRowHeightProperty, value);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000363 RID: 867 RVA: 0x0000D377 File Offset: 0x0000B577
		internal global::System.Windows.Visibility PlaceholderVisibility
		{
			get
			{
				return this._placeholderVisibility;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000364 RID: 868 RVA: 0x0000D37F File Offset: 0x0000B57F
		// (remove) Token: 0x06000365 RID: 869 RVA: 0x0000D398 File Offset: 0x0000B598
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridRowEventArgs> LoadingRow;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000366 RID: 870 RVA: 0x0000D3B1 File Offset: 0x0000B5B1
		// (remove) Token: 0x06000367 RID: 871 RVA: 0x0000D3CA File Offset: 0x0000B5CA
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridRowEventArgs> UnloadingRow;

		// Token: 0x06000368 RID: 872 RVA: 0x0000D3E4 File Offset: 0x0000B5E4
		protected virtual void OnLoadingRow(global::Microsoft.Windows.Controls.DataGridRowEventArgs e)
		{
			if (this.LoadingRow != null)
			{
				this.LoadingRow(this, e);
			}
			global::Microsoft.Windows.Controls.DataGridRow row = e.Row;
			if (row.DetailsVisibility == global::System.Windows.Visibility.Visible && row.DetailsPresenter != null)
			{
				global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Windows.Threading.DispatcherOperationCallback(global::Microsoft.Windows.Controls.DataGrid.DelayedOnLoadingRowDetails), global::System.Windows.Threading.DispatcherPriority.Loaded, new object[]
				{
					row
				});
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000D444 File Offset: 0x0000B644
		internal static object DelayedOnLoadingRowDetails(object arg)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)arg;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridRow.DataGridOwner;
			if (dataGridOwner != null)
			{
				dataGridOwner.OnLoadingRowDetailsWrapper(dataGridRow);
			}
			return null;
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000D46C File Offset: 0x0000B66C
		protected virtual void OnUnloadingRow(global::Microsoft.Windows.Controls.DataGridRowEventArgs e)
		{
			if (this.UnloadingRow != null)
			{
				this.UnloadingRow(this, e);
			}
			global::Microsoft.Windows.Controls.DataGridRow row = e.Row;
			this.OnUnloadingRowDetailsWrapper(row);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0000D49C File Offset: 0x0000B69C
		// (set) Token: 0x0600036C RID: 876 RVA: 0x0000D4AE File Offset: 0x0000B6AE
		public double RowHeaderWidth
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderWidthProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderWidthProperty, value);
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600036D RID: 877 RVA: 0x0000D4C1 File Offset: 0x0000B6C1
		// (set) Token: 0x0600036E RID: 878 RVA: 0x0000D4D3 File Offset: 0x0000B6D3
		public double RowHeaderActualWidth
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderActualWidthProperty);
			}
			internal set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderActualWidthPropertyKey, value);
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600036F RID: 879 RVA: 0x0000D4E6 File Offset: 0x0000B6E6
		// (set) Token: 0x06000370 RID: 880 RVA: 0x0000D4F8 File Offset: 0x0000B6F8
		public double ColumnHeaderHeight
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderHeightProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderHeightProperty, value);
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000D50B File Offset: 0x0000B70B
		// (set) Token: 0x06000372 RID: 882 RVA: 0x0000D51D File Offset: 0x0000B71D
		public global::Microsoft.Windows.Controls.DataGridHeadersVisibility HeadersVisibility
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridHeadersVisibility)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.HeadersVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.HeadersVisibilityProperty, value);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0000D530 File Offset: 0x0000B730
		private static void OnNotifyRowHeaderWidthPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			double num = (double)e.NewValue;
			if (!global::MS.Internal.DoubleUtil.IsNaN(num))
			{
				dataGrid.RowHeaderActualWidth = num;
			}
			else
			{
				dataGrid.RowHeaderActualWidth = 0.0;
			}
			global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowHeaderPropertyChanged(d, e);
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000D578 File Offset: 0x0000B778
		private void ResetRowHeaderActualWidth()
		{
			if (global::MS.Internal.DoubleUtil.IsNaN(this.RowHeaderWidth))
			{
				this.RowHeaderActualWidth = 0.0;
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000D598 File Offset: 0x0000B798
		public void SetDetailsVisibilityForItem(object item, global::System.Windows.Visibility detailsVisibility)
		{
			this._itemAttachedStorage.SetValue(item, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty, detailsVisibility);
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)base.ItemContainerGenerator.ContainerFromItem(item);
			if (dataGridRow != null)
			{
				dataGridRow.DetailsVisibility = detailsVisibility;
			}
		}

		// Token: 0x06000376 RID: 886 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
		public global::System.Windows.Visibility GetDetailsVisibilityForItem(object item)
		{
			object obj;
			if (this._itemAttachedStorage.TryGetValue(item, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty, out obj))
			{
				return (global::System.Windows.Visibility)obj;
			}
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)base.ItemContainerGenerator.ContainerFromItem(item);
			if (dataGridRow != null)
			{
				return dataGridRow.DetailsVisibility;
			}
			switch (this.RowDetailsVisibilityMode)
			{
			case global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode.Visible:
				return global::System.Windows.Visibility.Visible;
			case global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode.VisibleWhenSelected:
				if (!base.SelectedItems.Contains(item))
				{
					return global::System.Windows.Visibility.Collapsed;
				}
				return global::System.Windows.Visibility.Visible;
			default:
				return global::System.Windows.Visibility.Collapsed;
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000D64C File Offset: 0x0000B84C
		public void ClearDetailsVisibilityForItem(object item)
		{
			this._itemAttachedStorage.ClearValue(item, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)base.ItemContainerGenerator.ContainerFromItem(item);
			if (dataGridRow != null)
			{
				dataGridRow.ClearValue(global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000378 RID: 888 RVA: 0x0000D68A File Offset: 0x0000B88A
		internal global::Microsoft.Windows.Controls.DataGridItemAttachedStorage ItemAttachedStorage
		{
			get
			{
				return this._itemAttachedStorage;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000D694 File Offset: 0x0000B894
		private bool ShouldSelectRowHeader
		{
			get
			{
				return this._selectionAnchor != null && base.SelectedItems.Contains(this._selectionAnchor.Value.Item) && this.SelectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader && (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000D6E3 File Offset: 0x0000B8E3
		// (set) Token: 0x0600037B RID: 891 RVA: 0x0000D6F5 File Offset: 0x0000B8F5
		public global::System.Windows.Style CellStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CellStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CellStyleProperty, value);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0000D703 File Offset: 0x0000B903
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0000D715 File Offset: 0x0000B915
		public global::System.Windows.Style ColumnHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.ColumnHeaderStyleProperty, value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000D723 File Offset: 0x0000B923
		// (set) Token: 0x0600037F RID: 895 RVA: 0x0000D735 File Offset: 0x0000B935
		public global::System.Windows.Style RowHeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderStyleProperty, value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000D743 File Offset: 0x0000B943
		// (set) Token: 0x06000381 RID: 897 RVA: 0x0000D755 File Offset: 0x0000B955
		public global::System.Windows.DataTemplate RowHeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateProperty, value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000D763 File Offset: 0x0000B963
		// (set) Token: 0x06000383 RID: 899 RVA: 0x0000D775 File Offset: 0x0000B975
		public global::System.Windows.Controls.DataTemplateSelector RowHeaderTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000D783 File Offset: 0x0000B983
		public static global::System.Windows.ComponentResourceKey FocusBorderBrushKey
		{
			get
			{
				if (global::Microsoft.Windows.Controls.DataGrid._focusBorderBrushKey == null)
				{
					global::Microsoft.Windows.Controls.DataGrid._focusBorderBrushKey = new global::System.Windows.ComponentResourceKey(typeof(global::Microsoft.Windows.Controls.DataGrid), "FocusBorderBrushKey");
				}
				return global::Microsoft.Windows.Controls.DataGrid._focusBorderBrushKey;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000D7AA File Offset: 0x0000B9AA
		public static global::System.Windows.Data.IValueConverter HeadersVisibilityConverter
		{
			get
			{
				if (global::Microsoft.Windows.Controls.DataGrid._headersVisibilityConverter == null)
				{
					global::Microsoft.Windows.Controls.DataGrid._headersVisibilityConverter = new global::Microsoft.Windows.Controls.DataGridHeadersVisibilityToVisibilityConverter();
				}
				return global::Microsoft.Windows.Controls.DataGrid._headersVisibilityConverter;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000D7C2 File Offset: 0x0000B9C2
		public static global::System.Windows.Data.IValueConverter RowDetailsScrollingConverter
		{
			get
			{
				if (global::Microsoft.Windows.Controls.DataGrid._rowDetailsScrollingConverter == null)
				{
					global::Microsoft.Windows.Controls.DataGrid._rowDetailsScrollingConverter = new global::Microsoft.Windows.Controls.BooleanToSelectiveScrollingOrientationConverter();
				}
				return global::Microsoft.Windows.Controls.DataGrid._rowDetailsScrollingConverter;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000D7DA File Offset: 0x0000B9DA
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0000D7EC File Offset: 0x0000B9EC
		public global::System.Windows.Controls.ScrollBarVisibility HorizontalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.HorizontalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.HorizontalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0000D7FF File Offset: 0x0000B9FF
		// (set) Token: 0x0600038A RID: 906 RVA: 0x0000D811 File Offset: 0x0000BA11
		public global::System.Windows.Controls.ScrollBarVisibility VerticalScrollBarVisibility
		{
			get
			{
				return (global::System.Windows.Controls.ScrollBarVisibility)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.VerticalScrollBarVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.VerticalScrollBarVisibilityProperty, value);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000D824 File Offset: 0x0000BA24
		public void ScrollIntoView(object item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (base.ItemContainerGenerator.Status == global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
			{
				this.ScrollRowIntoView(item);
				return;
			}
			base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Loaded, new global::System.Windows.Threading.DispatcherOperationCallback(this.OnScrollIntoView), item);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x0000D864 File Offset: 0x0000BA64
		public void ScrollIntoView(object item, global::Microsoft.Windows.Controls.DataGridColumn column)
		{
			if (column == null)
			{
				this.ScrollIntoView(item);
				return;
			}
			if (!column.IsVisible)
			{
				return;
			}
			if (base.ItemContainerGenerator.Status != global::System.Windows.Controls.Primitives.GeneratorStatus.ContainersGenerated)
			{
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Loaded, new global::System.Windows.Threading.DispatcherOperationCallback(this.OnScrollIntoView), new object[]
				{
					item,
					column
				});
				return;
			}
			if (item == null)
			{
				this.ScrollColumnIntoView(column);
				return;
			}
			this.ScrollCellIntoView(item, column);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000D8D0 File Offset: 0x0000BAD0
		private object OnScrollIntoView(object arg)
		{
			object[] array = arg as object[];
			if (array != null)
			{
				if (array[0] != null)
				{
					this.ScrollCellIntoView(array[0], (global::Microsoft.Windows.Controls.DataGridColumn)array[1]);
				}
				else
				{
					this.ScrollColumnIntoView((global::Microsoft.Windows.Controls.DataGridColumn)array[1]);
				}
			}
			else
			{
				this.ScrollRowIntoView(arg);
			}
			return null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000D918 File Offset: 0x0000BB18
		private void ScrollColumnIntoView(global::Microsoft.Windows.Controls.DataGridColumn column)
		{
			if (this._rowTrackingRoot != null)
			{
				global::Microsoft.Windows.Controls.DataGridRow container = this._rowTrackingRoot.Container;
				if (container != null)
				{
					int index = this._columns.IndexOf(column);
					container.ScrollCellIntoView(index);
				}
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x0000D950 File Offset: 0x0000BB50
		private void ScrollRowIntoView(object item)
		{
			global::System.Windows.FrameworkElement frameworkElement = base.ItemContainerGenerator.ContainerFromItem(item) as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				frameworkElement.BringIntoView();
				return;
			}
			if (!base.IsGrouping)
			{
				int num = base.Items.IndexOf(item);
				if (num >= 0)
				{
					global::Microsoft.Windows.Controls.Primitives.DataGridRowsPresenter dataGridRowsPresenter = this.InternalItemsHost as global::Microsoft.Windows.Controls.Primitives.DataGridRowsPresenter;
					if (dataGridRowsPresenter != null)
					{
						dataGridRowsPresenter.InternalBringIndexIntoView(num);
					}
				}
			}
		}

		// Token: 0x06000390 RID: 912 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		private void ScrollCellIntoView(object item, global::Microsoft.Windows.Controls.DataGridColumn column)
		{
			if (!column.IsVisible)
			{
				return;
			}
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = base.ItemContainerGenerator.ContainerFromItem(item) as global::Microsoft.Windows.Controls.DataGridRow;
			if (dataGridRow == null)
			{
				this.ScrollRowIntoView(item);
				base.UpdateLayout();
				dataGridRow = (base.ItemContainerGenerator.ContainerFromItem(item) as global::Microsoft.Windows.Controls.DataGridRow);
			}
			else
			{
				dataGridRow.BringIntoView();
			}
			if (dataGridRow != null)
			{
				int index = this._columns.IndexOf(column);
				dataGridRow.ScrollCellIntoView(index);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000DA11 File Offset: 0x0000BC11
		protected override void OnIsMouseCapturedChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (!base.IsMouseCaptured)
			{
				this.StopAutoScroll();
			}
			base.OnIsMouseCapturedChanged(e);
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000DA28 File Offset: 0x0000BC28
		private static global::System.TimeSpan AutoScrollTimeout
		{
			get
			{
				return global::System.TimeSpan.FromMilliseconds((double)global::Microsoft.Windows.Controls.NativeMethods.GetDoubleClickTime() * 0.8);
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000DA40 File Offset: 0x0000BC40
		private void StartAutoScroll()
		{
			if (this._autoScrollTimer == null)
			{
				this._hasAutoScrolled = false;
				this._autoScrollTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.SystemIdle);
				this._autoScrollTimer.Interval = global::Microsoft.Windows.Controls.DataGrid.AutoScrollTimeout;
				this._autoScrollTimer.Tick += this.OnAutoScrollTimeout;
				this._autoScrollTimer.Start();
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000DA9A File Offset: 0x0000BC9A
		private void StopAutoScroll()
		{
			if (this._autoScrollTimer != null)
			{
				this._autoScrollTimer.Stop();
				this._autoScrollTimer = null;
				this._hasAutoScrolled = false;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000DABD File Offset: 0x0000BCBD
		private void OnAutoScrollTimeout(object sender, global::System.EventArgs e)
		{
			if (global::System.Windows.Input.Mouse.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
			{
				this.DoAutoScroll();
				return;
			}
			this.StopAutoScroll();
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000DAD8 File Offset: 0x0000BCD8
		private bool DoAutoScroll()
		{
			global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions relativeMousePosition = this.RelativeMousePosition;
			if (relativeMousePosition != global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Over)
			{
				global::Microsoft.Windows.Controls.DataGridCell dataGridCell = this.GetCellNearMouse();
				if (dataGridCell != null)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = dataGridCell.Column;
					object obj = dataGridCell.RowDataItem;
					if (global::Microsoft.Windows.Controls.DataGrid.IsMouseToLeft(relativeMousePosition))
					{
						int displayIndex = dataGridColumn.DisplayIndex;
						if (displayIndex > 0)
						{
							dataGridColumn = this.ColumnFromDisplayIndex(displayIndex - 1);
						}
					}
					else if (global::Microsoft.Windows.Controls.DataGrid.IsMouseToRight(relativeMousePosition))
					{
						int displayIndex2 = dataGridColumn.DisplayIndex;
						if (displayIndex2 < this._columns.Count - 1)
						{
							dataGridColumn = this.ColumnFromDisplayIndex(displayIndex2 + 1);
						}
					}
					if (global::Microsoft.Windows.Controls.DataGrid.IsMouseAbove(relativeMousePosition))
					{
						int num = base.Items.IndexOf(obj);
						if (num > 0)
						{
							obj = base.Items[num - 1];
						}
					}
					else if (global::Microsoft.Windows.Controls.DataGrid.IsMouseBelow(relativeMousePosition))
					{
						int num2 = base.Items.IndexOf(obj);
						if (num2 < base.Items.Count - 1)
						{
							obj = base.Items[num2 + 1];
						}
					}
					if (this._isRowDragging)
					{
						this.ScrollRowIntoView(obj);
						global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)base.ItemContainerGenerator.ContainerFromItem(obj);
						if (dataGridRow != null)
						{
							this._hasAutoScrolled = true;
							this.HandleSelectionForRowHeaderAndDetailsInput(dataGridRow, false);
							this.CurrentItem = obj;
							return true;
						}
					}
					else
					{
						this.ScrollCellIntoView(obj, dataGridColumn);
						dataGridCell = this.TryFindCell(obj, dataGridColumn);
						if (dataGridCell != null)
						{
							this._hasAutoScrolled = true;
							this.HandleSelectionForCellInput(dataGridCell, false, true, true);
							dataGridCell.Focus();
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000DC2D File Offset: 0x0000BE2D
		protected override bool HandlesScrolling
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000DC30 File Offset: 0x0000BE30
		// (set) Token: 0x06000399 RID: 921 RVA: 0x0000DC38 File Offset: 0x0000BE38
		internal global::System.Windows.Controls.Panel InternalItemsHost
		{
			get
			{
				return this._internalItemsHost;
			}
			set
			{
				if (this._internalItemsHost != value)
				{
					this._internalItemsHost = value;
					if (this._internalItemsHost != null)
					{
						this.EnsureInternalScrollControls();
					}
				}
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000DC58 File Offset: 0x0000BE58
		internal global::System.Windows.Controls.ScrollViewer InternalScrollHost
		{
			get
			{
				this.EnsureInternalScrollControls();
				return this._internalScrollHost;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600039B RID: 923 RVA: 0x0000DC66 File Offset: 0x0000BE66
		internal global::System.Windows.Controls.ScrollContentPresenter InternalScrollContentPresenter
		{
			get
			{
				this.EnsureInternalScrollControls();
				return this._internalScrollContentPresenter;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000DC74 File Offset: 0x0000BE74
		private void EnsureInternalScrollControls()
		{
			if (this._internalScrollContentPresenter == null)
			{
				if (this._internalItemsHost != null)
				{
					this._internalScrollContentPresenter = global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::System.Windows.Controls.ScrollContentPresenter>(this._internalItemsHost);
				}
				else if (this._rowTrackingRoot != null)
				{
					global::Microsoft.Windows.Controls.DataGridRow container = this._rowTrackingRoot.Container;
					this._internalScrollContentPresenter = global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::System.Windows.Controls.ScrollContentPresenter>(container);
				}
				if (this._internalScrollContentPresenter != null)
				{
					this._internalScrollContentPresenter.SizeChanged += this.OnInternalScrollContentPresenterSizeChanged;
				}
			}
			if (this._internalScrollHost == null)
			{
				if (this._internalItemsHost != null)
				{
					this._internalScrollHost = global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::System.Windows.Controls.ScrollViewer>(this._internalItemsHost);
				}
				else if (this._rowTrackingRoot != null)
				{
					global::Microsoft.Windows.Controls.DataGridRow container2 = this._rowTrackingRoot.Container;
					this._internalScrollHost = global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::System.Windows.Controls.ScrollViewer>(container2);
				}
				if (this._internalScrollHost != null)
				{
					global::System.Windows.Data.Binding binding = new global::System.Windows.Data.Binding("ContentHorizontalOffset");
					binding.Source = this._internalScrollHost;
					base.SetBinding(global::Microsoft.Windows.Controls.DataGrid.HorizontalScrollOffsetProperty, binding);
				}
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000DD52 File Offset: 0x0000BF52
		private void CleanUpInternalScrollControls()
		{
			global::System.Windows.Data.BindingOperations.ClearBinding(this, global::Microsoft.Windows.Controls.DataGrid.HorizontalScrollOffsetProperty);
			this._internalScrollHost = null;
			if (this._internalScrollContentPresenter != null)
			{
				this._internalScrollContentPresenter.SizeChanged -= this.OnInternalScrollContentPresenterSizeChanged;
				this._internalScrollContentPresenter = null;
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		private void OnInternalScrollContentPresenterSizeChanged(object sender, global::System.Windows.SizeChangedEventArgs e)
		{
			if (this._internalScrollContentPresenter != null && !this._internalScrollContentPresenter.CanContentScroll)
			{
				this.OnViewportSizeChanged(e.PreviousSize, e.NewSize);
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		internal void OnViewportSizeChanged(global::System.Windows.Size oldSize, global::System.Windows.Size newSize)
		{
			if (!this.InternalColumns.ColumnWidthsComputationPending)
			{
				double value = newSize.Width - oldSize.Width;
				if (!global::MS.Internal.DoubleUtil.AreClose(value, 0.0))
				{
					this._finalViewportWidth = newSize.Width;
					if (!this._viewportWidthChangeNotificationPending)
					{
						this._originalViewportWidth = oldSize.Width;
						base.Dispatcher.BeginInvoke(new global::System.Windows.Threading.DispatcherOperationCallback(this.OnDelayedViewportWidthChanged), global::System.Windows.Threading.DispatcherPriority.Loaded, new object[]
						{
							this
						});
						this._viewportWidthChangeNotificationPending = true;
					}
				}
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000DE44 File Offset: 0x0000C044
		private object OnDelayedViewportWidthChanged(object args)
		{
			if (!this._viewportWidthChangeNotificationPending)
			{
				return null;
			}
			double num = this._finalViewportWidth - this._originalViewportWidth;
			if (!global::MS.Internal.DoubleUtil.AreClose(num, 0.0))
			{
				this.NotifyPropertyChanged(this, "ViewportWidth", default(global::System.Windows.DependencyPropertyChangedEventArgs), global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.ColumnCollection | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
				double num2 = this._finalViewportWidth;
				num2 -= this.CellsPanelHorizontalOffset;
				this.InternalColumns.RedistributeColumnWidthsOnAvailableSpaceChange(num, num2);
			}
			this._viewportWidthChangeNotificationPending = false;
			return null;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000DEB6 File Offset: 0x0000C0B6
		internal double HorizontalScrollOffset
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.HorizontalScrollOffsetProperty);
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
		public static global::System.Windows.Input.RoutedUICommand DeleteCommand
		{
			get
			{
				return global::System.Windows.Input.ApplicationCommands.Delete;
			}
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000DECF File Offset: 0x0000C0CF
		private static void OnCanExecuteBeginEdit(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnCanExecuteBeginEdit(e);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000DEDD File Offset: 0x0000C0DD
		private static void OnExecutedBeginEdit(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnExecutedBeginEdit(e);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		protected virtual void OnCanExecuteBeginEdit(global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			bool flag = !this.IsReadOnly && this.CurrentCellContainer != null && !this.IsEditingCurrentCell && !this.IsCurrentCellReadOnly && !this.HasCellValidationError;
			if (flag && this.HasRowValidationError)
			{
				global::Microsoft.Windows.Controls.DataGridCell eventCellOrCurrentCell = this.GetEventCellOrCurrentCell(e);
				if (eventCellOrCurrentCell != null)
				{
					object rowDataItem = eventCellOrCurrentCell.RowDataItem;
					flag = this.IsAddingOrEditingRowItem(rowDataItem);
				}
				else
				{
					flag = false;
				}
			}
			if (flag)
			{
				e.CanExecute = true;
				e.Handled = true;
				return;
			}
			e.ContinueRouting = true;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000DF68 File Offset: 0x0000C168
		protected virtual void OnExecutedBeginEdit(global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
			if (currentCellContainer != null && !currentCellContainer.IsReadOnly && !currentCellContainer.IsEditing)
			{
				bool flag = false;
				bool flag2 = false;
				bool flag3 = false;
				global::System.Collections.Generic.List<int> list = null;
				int num = -1;
				object obj = null;
				bool flag4 = this.EditableItems.NewItemPlaceholderPosition == global::System.ComponentModel.NewItemPlaceholderPosition.AtBeginning;
				if (this.IsNewItemPlaceholder(currentCellContainer.RowDataItem))
				{
					if (base.SelectedItems.Contains(global::System.Windows.Data.CollectionView.NewItemPlaceholder))
					{
						this.UnselectItem(global::System.Windows.Data.CollectionView.NewItemPlaceholder);
						flag2 = true;
					}
					else
					{
						num = base.Items.IndexOf(currentCellContainer.RowDataItem);
						flag3 = (num >= 0 && this._selectedCells.Intersects(num, out list));
					}
					obj = this.AddNewItem();
					this.CurrentItem = obj;
					currentCellContainer = this.CurrentCellContainer;
					if (this.CurrentCellContainer == null)
					{
						base.UpdateLayout();
						currentCellContainer = this.CurrentCellContainer;
						if (currentCellContainer != null && !currentCellContainer.IsKeyboardFocusWithin)
						{
							currentCellContainer.Focus();
						}
					}
					if (flag2)
					{
						this.SelectItem(obj);
					}
					else if (flag3)
					{
						using (this.UpdateSelectedCells())
						{
							int num2 = num;
							if (flag4)
							{
								this._selectedCells.RemoveRegion(num, 0, 1, this.Columns.Count);
								num2++;
							}
							int i = 0;
							int count = list.Count;
							while (i < count)
							{
								this._selectedCells.AddRegion(num2, list[i], 1, list[i + 1]);
								i += 2;
							}
						}
					}
					flag = true;
				}
				global::System.Windows.RoutedEventArgs routedEventArgs = e.Parameter as global::System.Windows.RoutedEventArgs;
				global::Microsoft.Windows.Controls.DataGridBeginningEditEventArgs dataGridBeginningEditEventArgs = null;
				if (currentCellContainer != null)
				{
					dataGridBeginningEditEventArgs = new global::Microsoft.Windows.Controls.DataGridBeginningEditEventArgs(currentCellContainer.Column, currentCellContainer.RowOwner, routedEventArgs);
					this.OnBeginningEdit(dataGridBeginningEditEventArgs);
				}
				if (currentCellContainer == null || dataGridBeginningEditEventArgs.Cancel)
				{
					if (flag2)
					{
						this.UnselectItem(obj);
					}
					else if (flag3 && flag4)
					{
						this._selectedCells.RemoveRegion(num + 1, 0, 1, this.Columns.Count);
					}
					if (flag)
					{
						this.CancelRowItem();
						this.UpdateNewItemPlaceholder(false);
						this.SetCurrentItemToPlaceholder();
					}
					if (flag2)
					{
						this.SelectItem(global::System.Windows.Data.CollectionView.NewItemPlaceholder);
					}
					else if (flag3)
					{
						int j = 0;
						int count2 = list.Count;
						while (j < count2)
						{
							this._selectedCells.AddRegion(num, list[j], 1, list[j + 1]);
							j += 2;
						}
					}
				}
				else
				{
					if (!flag && !this.IsEditingRowItem)
					{
						this.EditRowItem(currentCellContainer.RowDataItem);
						global::System.Windows.Data.BindingGroup bindingGroup = currentCellContainer.RowOwner.BindingGroup;
						if (bindingGroup != null)
						{
							bindingGroup.BeginEdit();
						}
						this._editingRowItem = currentCellContainer.RowDataItem;
						this._editingRowIndex = base.Items.IndexOf(this._editingRowItem);
					}
					currentCellContainer.BeginEdit(routedEventArgs);
					currentCellContainer.RowOwner.IsEditing = true;
				}
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			e.Handled = true;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000E23C File Offset: 0x0000C43C
		private static void OnCanExecuteCommitEdit(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnCanExecuteCommitEdit(e);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000E24A File Offset: 0x0000C44A
		private static void OnExecutedCommitEdit(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnExecutedCommitEdit(e);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000E258 File Offset: 0x0000C458
		private global::Microsoft.Windows.Controls.DataGridCell GetEventCellOrCurrentCell(global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.UIElement uielement = e.OriginalSource as global::System.Windows.UIElement;
			if (uielement != this && uielement != null)
			{
				return global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::Microsoft.Windows.Controls.DataGridCell>(uielement);
			}
			return this.CurrentCellContainer;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000E288 File Offset: 0x0000C488
		private bool CanEndEdit(global::System.Windows.Input.CanExecuteRoutedEventArgs e, bool commit)
		{
			global::Microsoft.Windows.Controls.DataGridCell eventCellOrCurrentCell = this.GetEventCellOrCurrentCell(e);
			if (eventCellOrCurrentCell == null)
			{
				return false;
			}
			global::Microsoft.Windows.Controls.DataGridEditingUnit editingUnit = this.GetEditingUnit(e.Parameter);
			global::System.ComponentModel.IEditableCollectionView editableItems = this.EditableItems;
			object rowDataItem = eventCellOrCurrentCell.RowDataItem;
			return eventCellOrCurrentCell.IsEditing || (editingUnit == global::Microsoft.Windows.Controls.DataGridEditingUnit.Row && !this.HasCellValidationError && ((editableItems.IsAddingNew && editableItems.CurrentAddItem == rowDataItem) || (editableItems.IsEditingItem && (commit || editableItems.CanCancelEdit || this.HasRowValidationError) && editableItems.CurrentEditItem == rowDataItem)));
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000E30E File Offset: 0x0000C50E
		protected virtual void OnCanExecuteCommitEdit(global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			if (this.CanEndEdit(e, true))
			{
				e.CanExecute = true;
				e.Handled = true;
				return;
			}
			e.ContinueRouting = true;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000E330 File Offset: 0x0000C530
		protected virtual void OnExecutedCommitEdit(global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
			bool flag = true;
			if (currentCellContainer != null)
			{
				global::Microsoft.Windows.Controls.DataGridEditingUnit editingUnit = this.GetEditingUnit(e.Parameter);
				bool flag2 = false;
				if (currentCellContainer.IsEditing)
				{
					global::Microsoft.Windows.Controls.DataGridCellEditEndingEventArgs dataGridCellEditEndingEventArgs = new global::Microsoft.Windows.Controls.DataGridCellEditEndingEventArgs(currentCellContainer.Column, currentCellContainer.RowOwner, currentCellContainer.EditingElement, global::Microsoft.Windows.Controls.DataGridEditAction.Commit);
					this.OnCellEditEnding(dataGridCellEditEndingEventArgs);
					flag2 = dataGridCellEditEndingEventArgs.Cancel;
					if (!flag2)
					{
						flag = currentCellContainer.CommitEdit();
						this.HasCellValidationError = !flag;
					}
				}
				if (flag && !flag2 && ((editingUnit == global::Microsoft.Windows.Controls.DataGridEditingUnit.Row && this.IsAddingOrEditingRowItem(currentCellContainer.RowDataItem)) || (!this.EditableItems.CanCancelEdit && this.IsEditingItem(currentCellContainer.RowDataItem))))
				{
					global::Microsoft.Windows.Controls.DataGridRowEditEndingEventArgs dataGridRowEditEndingEventArgs = new global::Microsoft.Windows.Controls.DataGridRowEditEndingEventArgs(currentCellContainer.RowOwner, global::Microsoft.Windows.Controls.DataGridEditAction.Commit);
					this.OnRowEditEnding(dataGridRowEditEndingEventArgs);
					if (!dataGridRowEditEndingEventArgs.Cancel)
					{
						global::System.Windows.Data.BindingGroup bindingGroup = currentCellContainer.RowOwner.BindingGroup;
						if (bindingGroup != null)
						{
							base.Dispatcher.Invoke(new global::System.Windows.Threading.DispatcherOperationCallback(global::Microsoft.Windows.Controls.DataGrid.DoNothing), global::System.Windows.Threading.DispatcherPriority.DataBind, new object[]
							{
								bindingGroup
							});
							flag = bindingGroup.CommitEdit();
						}
						this.HasRowValidationError = !flag;
						if (flag)
						{
							this.CommitRowItem();
						}
					}
				}
				if (flag)
				{
					this.UpdateRowEditing(currentCellContainer);
				}
				global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			}
			e.Handled = true;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0000E467 File Offset: 0x0000C667
		private static object DoNothing(object arg)
		{
			return null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000E46A File Offset: 0x0000C66A
		private global::Microsoft.Windows.Controls.DataGridEditingUnit GetEditingUnit(object parameter)
		{
			if (parameter != null && parameter is global::Microsoft.Windows.Controls.DataGridEditingUnit)
			{
				return (global::Microsoft.Windows.Controls.DataGridEditingUnit)parameter;
			}
			if (!this.IsEditingCurrentCell)
			{
				return global::Microsoft.Windows.Controls.DataGridEditingUnit.Row;
			}
			return global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell;
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060003AF RID: 943 RVA: 0x0000E489 File Offset: 0x0000C689
		// (remove) Token: 0x060003B0 RID: 944 RVA: 0x0000E4A2 File Offset: 0x0000C6A2
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridRowEditEndingEventArgs> RowEditEnding;

		// Token: 0x060003B1 RID: 945 RVA: 0x0000E4BC File Offset: 0x0000C6BC
		protected virtual void OnRowEditEnding(global::Microsoft.Windows.Controls.DataGridRowEditEndingEventArgs e)
		{
			if (this.RowEditEnding != null)
			{
				this.RowEditEnding(this, e);
			}
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked))
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				if (dataGridAutomationPeer != null)
				{
					dataGridAutomationPeer.RaiseAutomationRowInvokeEvents(e.Row);
				}
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060003B2 RID: 946 RVA: 0x0000E501 File Offset: 0x0000C701
		// (remove) Token: 0x060003B3 RID: 947 RVA: 0x0000E51A File Offset: 0x0000C71A
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridCellEditEndingEventArgs> CellEditEnding;

		// Token: 0x060003B4 RID: 948 RVA: 0x0000E534 File Offset: 0x0000C734
		protected virtual void OnCellEditEnding(global::Microsoft.Windows.Controls.DataGridCellEditEndingEventArgs e)
		{
			if (this.CellEditEnding != null)
			{
				this.CellEditEnding(this, e);
			}
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked))
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				if (dataGridAutomationPeer != null)
				{
					dataGridAutomationPeer.RaiseAutomationCellInvokeEvents(e.Column, e.Row);
				}
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000E57F File Offset: 0x0000C77F
		private static void OnCanExecuteCancelEdit(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnCanExecuteCancelEdit(e);
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000E58D File Offset: 0x0000C78D
		private static void OnExecutedCancelEdit(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnExecutedCancelEdit(e);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000E59B File Offset: 0x0000C79B
		protected virtual void OnCanExecuteCancelEdit(global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			if (this.CanEndEdit(e, false))
			{
				e.CanExecute = true;
				e.Handled = true;
				return;
			}
			e.ContinueRouting = true;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000E5C0 File Offset: 0x0000C7C0
		protected virtual void OnExecutedCancelEdit(global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
			if (currentCellContainer != null)
			{
				global::Microsoft.Windows.Controls.DataGridEditingUnit editingUnit = this.GetEditingUnit(e.Parameter);
				bool flag = false;
				if (currentCellContainer.IsEditing)
				{
					global::Microsoft.Windows.Controls.DataGridCellEditEndingEventArgs dataGridCellEditEndingEventArgs = new global::Microsoft.Windows.Controls.DataGridCellEditEndingEventArgs(currentCellContainer.Column, currentCellContainer.RowOwner, currentCellContainer.EditingElement, global::Microsoft.Windows.Controls.DataGridEditAction.Cancel);
					this.OnCellEditEnding(dataGridCellEditEndingEventArgs);
					flag = dataGridCellEditEndingEventArgs.Cancel;
					if (!flag)
					{
						currentCellContainer.CancelEdit();
						this.HasCellValidationError = false;
					}
				}
				global::System.ComponentModel.IEditableCollectionView editableItems = this.EditableItems;
				bool flag2 = this.IsEditingItem(currentCellContainer.RowDataItem) && !editableItems.CanCancelEdit;
				if (!flag && (this.CanCancelAddingOrEditingRowItem(editingUnit, currentCellContainer.RowDataItem) || flag2))
				{
					bool flag3 = true;
					if (!flag2)
					{
						global::Microsoft.Windows.Controls.DataGridRowEditEndingEventArgs dataGridRowEditEndingEventArgs = new global::Microsoft.Windows.Controls.DataGridRowEditEndingEventArgs(currentCellContainer.RowOwner, global::Microsoft.Windows.Controls.DataGridEditAction.Cancel);
						this.OnRowEditEnding(dataGridRowEditEndingEventArgs);
						flag3 = !dataGridRowEditEndingEventArgs.Cancel;
					}
					if (flag3)
					{
						if (flag2)
						{
							editableItems.CommitEdit();
						}
						else
						{
							this.CancelRowItem();
						}
						global::System.Windows.Data.BindingGroup bindingGroup = currentCellContainer.RowOwner.BindingGroup;
						if (bindingGroup != null)
						{
							bindingGroup.CancelEdit();
							bindingGroup.UpdateSources();
						}
					}
				}
				this.UpdateRowEditing(currentCellContainer);
				if (!currentCellContainer.RowOwner.IsEditing)
				{
					this.HasRowValidationError = false;
				}
				global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			}
			e.Handled = true;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000E6EA File Offset: 0x0000C8EA
		private static void OnCanExecuteDelete(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnCanExecuteDelete(e);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
		private static void OnExecutedDelete(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnExecutedDelete(e);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000E706 File Offset: 0x0000C906
		protected virtual void OnCanExecuteDelete(global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			e.CanExecute = (this.CanUserDeleteRows && this.DataItemsSelected > 0 && (this._currentCellContainer == null || !this._currentCellContainer.IsEditing));
			e.Handled = true;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000E744 File Offset: 0x0000C944
		protected virtual void OnExecutedDelete(global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			if (this.DataItemsSelected > 0)
			{
				bool flag = false;
				bool isEditingRowItem = this.IsEditingRowItem;
				if (isEditingRowItem || this.IsAddingNewItem)
				{
					if (this.CancelEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Row) && isEditingRowItem)
					{
						flag = true;
					}
				}
				else
				{
					flag = true;
				}
				if (flag)
				{
					int count = base.SelectedItems.Count;
					int num = -1;
					object currentItem = this.CurrentItem;
					if (base.SelectedItems.Contains(currentItem))
					{
						num = base.Items.IndexOf(currentItem);
						if (this._selectionAnchor != null)
						{
							int num2 = base.Items.IndexOf(this._selectionAnchor.Value.Item);
							if (num2 >= 0 && num2 < num)
							{
								num = num2;
							}
						}
						num = global::System.Math.Min(base.Items.Count - count - 1, num);
					}
					global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(base.SelectedItems);
					using (this.UpdateSelectedCells())
					{
						bool isUpdatingSelectedItems = base.IsUpdatingSelectedItems;
						if (!isUpdatingSelectedItems)
						{
							base.BeginUpdateSelectedItems();
						}
						try
						{
							this._selectedCells.ClearFullRows(base.SelectedItems);
							base.SelectedItems.Clear();
						}
						finally
						{
							if (!isUpdatingSelectedItems)
							{
								base.EndUpdateSelectedItems();
							}
						}
					}
					for (int i = 0; i < count; i++)
					{
						object obj = arrayList[i];
						if (obj != global::System.Windows.Data.CollectionView.NewItemPlaceholder)
						{
							this.EditableItems.Remove(obj);
						}
					}
					if (num >= 0)
					{
						object currentItem2 = base.Items[num];
						this.CurrentItem = currentItem2;
						global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
						if (currentCellContainer != null)
						{
							this._selectionAnchor = null;
							this.HandleSelectionForCellInput(currentCellContainer, false, false, false);
						}
					}
				}
			}
			e.Handled = true;
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000E8FC File Offset: 0x0000CAFC
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000E90E File Offset: 0x0000CB0E
		public bool IsReadOnly
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.IsReadOnlyProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.IsReadOnlyProperty, value);
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000E921 File Offset: 0x0000CB21
		private static void OnIsReadOnlyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if ((bool)e.NewValue)
			{
				((global::Microsoft.Windows.Controls.DataGrid)d).CancelAnyEdit();
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			d.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.CanUserAddRowsProperty);
			d.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.CanUserDeleteRowsProperty);
			global::Microsoft.Windows.Controls.DataGrid.OnNotifyColumnAndCellPropertyChanged(d, e);
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x0000E95E File Offset: 0x0000CB5E
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x0000E96B File Offset: 0x0000CB6B
		public object CurrentItem
		{
			get
			{
				return base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CurrentItemProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CurrentItemProperty, value);
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000E97C File Offset: 0x0000CB7C
		private static void OnCurrentItemChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			global::Microsoft.Windows.Controls.DataGridCellInfo currentCell = dataGrid.CurrentCell;
			object newValue = e.NewValue;
			if (currentCell.Item != newValue)
			{
				dataGrid.CurrentCell = global::Microsoft.Windows.Controls.DataGridCellInfo.CreatePossiblyPartialCellInfo(newValue, currentCell.Column, dataGrid);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0000E9BD File Offset: 0x0000CBBD
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x0000E9CF File Offset: 0x0000CBCF
		public global::Microsoft.Windows.Controls.DataGridColumn CurrentColumn
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridColumn)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CurrentColumnProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CurrentColumnProperty, value);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000E9E0 File Offset: 0x0000CBE0
		private static void OnCurrentColumnChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			global::Microsoft.Windows.Controls.DataGridCellInfo currentCell = dataGrid.CurrentCell;
			global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)e.NewValue;
			if (currentCell.Column != dataGridColumn)
			{
				dataGrid.CurrentCell = global::Microsoft.Windows.Controls.DataGridCellInfo.CreatePossiblyPartialCellInfo(currentCell.Item, dataGridColumn, dataGrid);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x0000EA26 File Offset: 0x0000CC26
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x0000EA38 File Offset: 0x0000CC38
		public global::Microsoft.Windows.Controls.DataGridCellInfo CurrentCell
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridCellInfo)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CurrentCellProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CurrentCellProperty, value);
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000EA4C File Offset: 0x0000CC4C
		private static void OnCurrentCellChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			global::Microsoft.Windows.Controls.DataGridCellInfo dataGridCellInfo = (global::Microsoft.Windows.Controls.DataGridCellInfo)e.OldValue;
			global::Microsoft.Windows.Controls.DataGridCellInfo dataGridCellInfo2 = (global::Microsoft.Windows.Controls.DataGridCellInfo)e.NewValue;
			if (dataGrid.CurrentItem != dataGridCellInfo2.Item)
			{
				dataGrid.CurrentItem = dataGridCellInfo2.Item;
			}
			if (dataGrid.CurrentColumn != dataGridCellInfo2.Column)
			{
				dataGrid.CurrentColumn = dataGridCellInfo2.Column;
			}
			if (dataGrid._currentCellContainer != null)
			{
				if ((dataGrid.IsAddingNewItem || dataGrid.IsEditingRowItem) && dataGridCellInfo.Item != dataGridCellInfo2.Item)
				{
					dataGrid.EndEdit(global::Microsoft.Windows.Controls.DataGrid.CommitEditCommand, dataGrid._currentCellContainer, global::Microsoft.Windows.Controls.DataGridEditingUnit.Row, true);
				}
				else if (dataGrid._currentCellContainer.IsEditing)
				{
					dataGrid.EndEdit(global::Microsoft.Windows.Controls.DataGrid.CommitEditCommand, dataGrid._currentCellContainer, global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell, true);
				}
			}
			dataGrid._currentCellContainer = null;
			if (dataGridCellInfo2.IsValid && dataGrid.IsKeyboardFocusWithin)
			{
				global::Microsoft.Windows.Controls.DataGridCell dataGridCell = dataGrid._pendingCurrentCellContainer;
				if (dataGridCell == null)
				{
					dataGridCell = dataGrid.CurrentCellContainer;
					if (dataGridCell == null)
					{
						dataGrid.ScrollCellIntoView(dataGridCellInfo2.Item, dataGridCellInfo2.Column);
						dataGridCell = dataGrid.CurrentCellContainer;
					}
				}
				if (dataGridCell != null && !dataGridCell.IsKeyboardFocusWithin)
				{
					dataGridCell.Focus();
				}
			}
			dataGrid.OnCurrentCellChanged(global::System.EventArgs.Empty);
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x060003C9 RID: 969 RVA: 0x0000EB75 File Offset: 0x0000CD75
		// (remove) Token: 0x060003CA RID: 970 RVA: 0x0000EB8E File Offset: 0x0000CD8E
		public event global::System.EventHandler<global::System.EventArgs> CurrentCellChanged;

		// Token: 0x060003CB RID: 971 RVA: 0x0000EBA7 File Offset: 0x0000CDA7
		protected virtual void OnCurrentCellChanged(global::System.EventArgs e)
		{
			if (this.CurrentCellChanged != null)
			{
				this.CurrentCellChanged(this, e);
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000EBBE File Offset: 0x0000CDBE
		private void UpdateCurrentCell(global::Microsoft.Windows.Controls.DataGridCell cell, bool isFocusWithinCell)
		{
			if (isFocusWithinCell)
			{
				this.CurrentCellContainer = cell;
				return;
			}
			if (!base.IsKeyboardFocusWithin)
			{
				this.CurrentCellContainer = null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003CD RID: 973 RVA: 0x0000EBDC File Offset: 0x0000CDDC
		// (set) Token: 0x060003CE RID: 974 RVA: 0x0000EC14 File Offset: 0x0000CE14
		private global::Microsoft.Windows.Controls.DataGridCell CurrentCellContainer
		{
			get
			{
				if (this._currentCellContainer == null)
				{
					global::Microsoft.Windows.Controls.DataGridCellInfo currentCell = this.CurrentCell;
					if (currentCell.IsValid)
					{
						this._currentCellContainer = this.TryFindCell(currentCell);
					}
				}
				return this._currentCellContainer;
			}
			set
			{
				if (this._currentCellContainer != value && (value == null || value != this._pendingCurrentCellContainer))
				{
					this._pendingCurrentCellContainer = value;
					if (value == null)
					{
						base.ClearValue(global::Microsoft.Windows.Controls.DataGrid.CurrentCellProperty);
					}
					else
					{
						this.CurrentCell = new global::Microsoft.Windows.Controls.DataGridCellInfo(value);
					}
					this._pendingCurrentCellContainer = null;
					this._currentCellContainer = value;
					global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0000EC6C File Offset: 0x0000CE6C
		private bool IsEditingCurrentCell
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
				return currentCellContainer != null && currentCellContainer.IsEditing;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000EC8C File Offset: 0x0000CE8C
		private bool IsCurrentCellReadOnly
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
				return currentCellContainer != null && currentCellContainer.IsReadOnly;
			}
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060003D1 RID: 977 RVA: 0x0000ECAB File Offset: 0x0000CEAB
		// (remove) Token: 0x060003D2 RID: 978 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridBeginningEditEventArgs> BeginningEdit;

		// Token: 0x060003D3 RID: 979 RVA: 0x0000ECE0 File Offset: 0x0000CEE0
		protected virtual void OnBeginningEdit(global::Microsoft.Windows.Controls.DataGridBeginningEditEventArgs e)
		{
			if (this.BeginningEdit != null)
			{
				this.BeginningEdit(this, e);
			}
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.InvokePatternOnInvoked))
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				if (dataGridAutomationPeer != null)
				{
					dataGridAutomationPeer.RaiseAutomationCellInvokeEvents(e.Column, e.Row);
				}
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060003D4 RID: 980 RVA: 0x0000ED2B File Offset: 0x0000CF2B
		// (remove) Token: 0x060003D5 RID: 981 RVA: 0x0000ED44 File Offset: 0x0000CF44
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridPreparingCellForEditEventArgs> PreparingCellForEdit;

		// Token: 0x060003D6 RID: 982 RVA: 0x0000ED5D File Offset: 0x0000CF5D
		protected internal virtual void OnPreparingCellForEdit(global::Microsoft.Windows.Controls.DataGridPreparingCellForEditEventArgs e)
		{
			if (this.PreparingCellForEdit != null)
			{
				this.PreparingCellForEdit(this, e);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000ED74 File Offset: 0x0000CF74
		public bool BeginEdit()
		{
			return this.BeginEdit(null);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0000ED80 File Offset: 0x0000CF80
		public bool BeginEdit(global::System.Windows.RoutedEventArgs editingEventArgs)
		{
			if (!this.IsReadOnly)
			{
				global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
				if (currentCellContainer != null)
				{
					if (!currentCellContainer.IsEditing && global::Microsoft.Windows.Controls.DataGrid.BeginEditCommand.CanExecute(editingEventArgs, currentCellContainer))
					{
						global::Microsoft.Windows.Controls.DataGrid.BeginEditCommand.Execute(editingEventArgs, currentCellContainer);
					}
					return currentCellContainer.IsEditing;
				}
			}
			return false;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0000EDC9 File Offset: 0x0000CFC9
		public bool CancelEdit()
		{
			if (this.IsEditingCurrentCell)
			{
				return this.CancelEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell);
			}
			return (!this.IsEditingRowItem && !this.IsAddingNewItem) || this.CancelEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Row);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		internal bool CancelEdit(global::Microsoft.Windows.Controls.DataGridCell cell)
		{
			global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
			return currentCellContainer == null || currentCellContainer != cell || !currentCellContainer.IsEditing || this.CancelEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0000EE20 File Offset: 0x0000D020
		public bool CancelEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit editingUnit)
		{
			return this.EndEdit(global::Microsoft.Windows.Controls.DataGrid.CancelEditCommand, this.CurrentCellContainer, editingUnit, true);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x0000EE35 File Offset: 0x0000D035
		private void CancelAnyEdit()
		{
			if (this.IsAddingNewItem || this.IsEditingRowItem)
			{
				this.CancelEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Row);
				return;
			}
			if (this.IsEditingCurrentCell)
			{
				this.CancelEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell);
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0000EE60 File Offset: 0x0000D060
		public bool CommitEdit()
		{
			if (this.IsEditingCurrentCell)
			{
				return this.CommitEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell, true);
			}
			return (!this.IsEditingRowItem && !this.IsAddingNewItem) || this.CommitEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Row, true);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0000EE8D File Offset: 0x0000D08D
		public bool CommitEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit editingUnit, bool exitEditingMode)
		{
			return this.EndEdit(global::Microsoft.Windows.Controls.DataGrid.CommitEditCommand, this.CurrentCellContainer, editingUnit, exitEditingMode);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000EEA2 File Offset: 0x0000D0A2
		private bool CommitAnyEdit()
		{
			if (this.IsAddingNewItem || this.IsEditingRowItem)
			{
				return this.CommitEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Row, true);
			}
			return !this.IsEditingCurrentCell || this.CommitEdit(global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell, true);
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000EED0 File Offset: 0x0000D0D0
		private bool EndEdit(global::System.Windows.Input.RoutedCommand command, global::Microsoft.Windows.Controls.DataGridCell cellContainer, global::Microsoft.Windows.Controls.DataGridEditingUnit editingUnit, bool exitEditMode)
		{
			bool flag = true;
			bool flag2 = true;
			if (cellContainer != null)
			{
				if (command.CanExecute(editingUnit, cellContainer))
				{
					command.Execute(editingUnit, cellContainer);
				}
				flag = !cellContainer.IsEditing;
				flag2 = (!this.IsEditingRowItem && !this.IsAddingNewItem);
			}
			if (!exitEditMode)
			{
				if (editingUnit != global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell)
				{
					if (flag2)
					{
						object rowDataItem = cellContainer.RowDataItem;
						if (rowDataItem != null)
						{
							this.EditRowItem(rowDataItem);
							return this.IsEditingRowItem;
						}
					}
					return false;
				}
				if (cellContainer == null)
				{
					return false;
				}
				if (flag)
				{
					return this.BeginEdit(null);
				}
			}
			return flag && (editingUnit == global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell || flag2);
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x0000EF5E File Offset: 0x0000D15E
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0000EF66 File Offset: 0x0000D166
		private bool HasCellValidationError
		{
			get
			{
				return this._hasCellValidationError;
			}
			set
			{
				if (this._hasCellValidationError != value)
				{
					this._hasCellValidationError = value;
					global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
				}
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000EF7D File Offset: 0x0000D17D
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0000EF85 File Offset: 0x0000D185
		private bool HasRowValidationError
		{
			get
			{
				return this._hasRowValidationError;
			}
			set
			{
				if (this._hasRowValidationError != value)
				{
					this._hasRowValidationError = value;
					global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
				}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x0000EF9C File Offset: 0x0000D19C
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x0000EFA4 File Offset: 0x0000D1A4
		internal global::Microsoft.Windows.Controls.DataGridCell FocusedCell
		{
			get
			{
				return this._focusedCell;
			}
			set
			{
				if (this._focusedCell != value)
				{
					if (this._focusedCell != null)
					{
						this.UpdateCurrentCell(this._focusedCell, false);
					}
					this._focusedCell = value;
					if (this._focusedCell != null)
					{
						this.UpdateCurrentCell(this._focusedCell, true);
					}
				}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x0000EFE0 File Offset: 0x0000D1E0
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x0000EFF2 File Offset: 0x0000D1F2
		public bool CanUserAddRows
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserAddRowsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserAddRowsProperty, value);
			}
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0000F005 File Offset: 0x0000D205
		private static void OnCanUserAddRowsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).UpdateNewItemPlaceholder(false);
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0000F013 File Offset: 0x0000D213
		private static object OnCoerceCanUserAddRows(global::System.Windows.DependencyObject d, object baseValue)
		{
			return global::Microsoft.Windows.Controls.DataGrid.OnCoerceCanUserAddOrDeleteRows((global::Microsoft.Windows.Controls.DataGrid)d, (bool)baseValue, true);
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0000F02C File Offset: 0x0000D22C
		private static bool OnCoerceCanUserAddOrDeleteRows(global::Microsoft.Windows.Controls.DataGrid dataGrid, bool baseValue, bool canUserAddRowsProperty)
		{
			if (baseValue)
			{
				if (dataGrid.IsReadOnly || !dataGrid.IsEnabled)
				{
					return false;
				}
				if ((canUserAddRowsProperty && !dataGrid.EditableItems.CanAddNew) || (!canUserAddRowsProperty && !dataGrid.EditableItems.CanRemove))
				{
					return false;
				}
			}
			return baseValue;
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003EC RID: 1004 RVA: 0x0000F066 File Offset: 0x0000D266
		// (set) Token: 0x060003ED RID: 1005 RVA: 0x0000F078 File Offset: 0x0000D278
		public bool CanUserDeleteRows
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserDeleteRowsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserDeleteRowsProperty, value);
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x0000F08B File Offset: 0x0000D28B
		private static void OnCanUserDeleteRowsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x0000F092 File Offset: 0x0000D292
		private static object OnCoerceCanUserDeleteRows(global::System.Windows.DependencyObject d, object baseValue)
		{
			return global::Microsoft.Windows.Controls.DataGrid.OnCoerceCanUserAddOrDeleteRows((global::Microsoft.Windows.Controls.DataGrid)d, (bool)baseValue, false);
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060003F0 RID: 1008 RVA: 0x0000F0AB File Offset: 0x0000D2AB
		// (remove) Token: 0x060003F1 RID: 1009 RVA: 0x0000F0C4 File Offset: 0x0000D2C4
		public event global::Microsoft.Windows.Controls.InitializingNewItemEventHandler InitializingNewItem;

		// Token: 0x060003F2 RID: 1010 RVA: 0x0000F0DD File Offset: 0x0000D2DD
		protected virtual void OnInitializingNewItem(global::Microsoft.Windows.Controls.InitializingNewItemEventArgs e)
		{
			if (this.InitializingNewItem != null)
			{
				this.InitializingNewItem(this, e);
			}
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		private object AddNewItem()
		{
			this.UpdateNewItemPlaceholder(true);
			object obj = this.EditableItems.AddNew();
			if (obj != null)
			{
				global::Microsoft.Windows.Controls.InitializingNewItemEventArgs e = new global::Microsoft.Windows.Controls.InitializingNewItemEventArgs(obj);
				this.OnInitializingNewItem(e);
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			return obj;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x0000F12B File Offset: 0x0000D32B
		private void EditRowItem(object rowItem)
		{
			this.EditableItems.EditItem(rowItem);
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x0000F13E File Offset: 0x0000D33E
		private void CommitRowItem()
		{
			if (this.IsEditingRowItem)
			{
				this.EditableItems.CommitEdit();
				return;
			}
			this.EditableItems.CommitNew();
			this.UpdateNewItemPlaceholder(false);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000F168 File Offset: 0x0000D368
		private void CancelRowItem()
		{
			if (this.IsEditingRowItem)
			{
				this.EditableItems.CancelEdit();
				return;
			}
			object currentAddItem = this.EditableItems.CurrentAddItem;
			bool flag = currentAddItem == this.CurrentItem;
			bool flag2 = base.SelectedItems.Contains(currentAddItem);
			bool flag3 = false;
			global::System.Collections.Generic.List<int> list = null;
			int num = -1;
			if (flag2)
			{
				this.UnselectItem(currentAddItem);
			}
			else
			{
				num = base.Items.IndexOf(currentAddItem);
				flag3 = (num >= 0 && this._selectedCells.Intersects(num, out list));
			}
			this.EditableItems.CancelNew();
			this.UpdateNewItemPlaceholder(false);
			if (flag)
			{
				this.CurrentItem = global::System.Windows.Data.CollectionView.NewItemPlaceholder;
			}
			if (flag2)
			{
				this.SelectItem(global::System.Windows.Data.CollectionView.NewItemPlaceholder);
				return;
			}
			if (flag3)
			{
				using (this.UpdateSelectedCells())
				{
					int num2 = num;
					bool flag4 = this.EditableItems.NewItemPlaceholderPosition == global::System.ComponentModel.NewItemPlaceholderPosition.AtBeginning;
					if (flag4)
					{
						this._selectedCells.RemoveRegion(num, 0, 1, this.Columns.Count);
						num2--;
					}
					int i = 0;
					int count = list.Count;
					while (i < count)
					{
						this._selectedCells.AddRegion(num2, list[i], 1, list[i + 1]);
						i += 2;
					}
				}
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		private void UpdateRowEditing(global::Microsoft.Windows.Controls.DataGridCell cell)
		{
			object rowDataItem = cell.RowDataItem;
			if (!this.IsAddingOrEditingRowItem(rowDataItem))
			{
				cell.RowOwner.IsEditing = false;
				this._editingRowItem = null;
				this._editingRowIndex = -1;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003F8 RID: 1016 RVA: 0x0000F2EF File Offset: 0x0000D4EF
		private global::System.ComponentModel.IEditableCollectionView EditableItems
		{
			get
			{
				return base.Items;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x0000F2F7 File Offset: 0x0000D4F7
		private bool IsAddingNewItem
		{
			get
			{
				return this.EditableItems.IsAddingNew;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000F304 File Offset: 0x0000D504
		private bool IsEditingRowItem
		{
			get
			{
				return this.EditableItems.IsEditingItem;
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0000F311 File Offset: 0x0000D511
		private bool IsAddingOrEditingRowItem(object item)
		{
			return this.IsEditingItem(item) || (this.IsAddingNewItem && this.EditableItems.CurrentAddItem == item);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0000F336 File Offset: 0x0000D536
		private bool CanCancelAddingOrEditingRowItem(global::Microsoft.Windows.Controls.DataGridEditingUnit editingUnit, object item)
		{
			return editingUnit == global::Microsoft.Windows.Controls.DataGridEditingUnit.Row && ((this.IsEditingItem(item) && this.EditableItems.CanCancelEdit) || (this.IsAddingNewItem && this.EditableItems.CurrentAddItem == item));
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0000F36E File Offset: 0x0000D56E
		private bool IsEditingItem(object item)
		{
			return this.IsEditingRowItem && this.EditableItems.CurrentEditItem == item;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x0000F388 File Offset: 0x0000D588
		private void UpdateNewItemPlaceholder(bool isAddingNewItem)
		{
			global::System.ComponentModel.IEditableCollectionView editableItems = this.EditableItems;
			bool flag = this.CanUserAddRows;
			if (global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(this, global::Microsoft.Windows.Controls.DataGrid.CanUserAddRowsProperty))
			{
				flag = global::Microsoft.Windows.Controls.DataGrid.OnCoerceCanUserAddOrDeleteRows(this, flag, true);
			}
			if (!isAddingNewItem)
			{
				if (flag)
				{
					if (editableItems.NewItemPlaceholderPosition == global::System.ComponentModel.NewItemPlaceholderPosition.None)
					{
						editableItems.NewItemPlaceholderPosition = global::System.ComponentModel.NewItemPlaceholderPosition.AtEnd;
					}
					this._placeholderVisibility = global::System.Windows.Visibility.Visible;
				}
				else
				{
					if (editableItems.NewItemPlaceholderPosition != global::System.ComponentModel.NewItemPlaceholderPosition.None)
					{
						editableItems.NewItemPlaceholderPosition = global::System.ComponentModel.NewItemPlaceholderPosition.None;
					}
					this._placeholderVisibility = global::System.Windows.Visibility.Collapsed;
				}
			}
			else
			{
				this._placeholderVisibility = global::System.Windows.Visibility.Collapsed;
			}
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)base.ItemContainerGenerator.ContainerFromItem(global::System.Windows.Data.CollectionView.NewItemPlaceholder);
			if (dataGridRow != null)
			{
				dataGridRow.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0000F41C File Offset: 0x0000D61C
		private void SetCurrentItemToPlaceholder()
		{
			global::System.ComponentModel.NewItemPlaceholderPosition newItemPlaceholderPosition = this.EditableItems.NewItemPlaceholderPosition;
			if (newItemPlaceholderPosition == global::System.ComponentModel.NewItemPlaceholderPosition.AtEnd)
			{
				int count = base.Items.Count;
				if (count > 0)
				{
					this.CurrentItem = base.Items[count - 1];
					return;
				}
			}
			else if (newItemPlaceholderPosition == global::System.ComponentModel.NewItemPlaceholderPosition.AtBeginning && base.Items.Count > 0)
			{
				this.CurrentItem = base.Items[0];
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x0000F484 File Offset: 0x0000D684
		private int DataItemsCount
		{
			get
			{
				int num = base.Items.Count;
				if (this.HasNewItemPlaceholder)
				{
					num--;
				}
				return num;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x0000F4AC File Offset: 0x0000D6AC
		private int DataItemsSelected
		{
			get
			{
				int num = base.SelectedItems.Count;
				if (this.HasNewItemPlaceholder && base.SelectedItems.Contains(global::System.Windows.Data.CollectionView.NewItemPlaceholder))
				{
					num--;
				}
				return num;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x0000F4E4 File Offset: 0x0000D6E4
		private bool HasNewItemPlaceholder
		{
			get
			{
				global::System.ComponentModel.IEditableCollectionView editableItems = this.EditableItems;
				return editableItems.NewItemPlaceholderPosition != global::System.ComponentModel.NewItemPlaceholderPosition.None;
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0000F504 File Offset: 0x0000D704
		private bool IsNewItemPlaceholder(object item)
		{
			return item == global::System.Windows.Data.CollectionView.NewItemPlaceholder || item == global::Microsoft.Windows.Controls.DataGrid.NewItemPlaceholder;
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x0000F518 File Offset: 0x0000D718
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x0000F52A File Offset: 0x0000D72A
		public global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode RowDetailsVisibilityMode
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowDetailsVisibilityModeProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowDetailsVisibilityModeProperty, value);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000406 RID: 1030 RVA: 0x0000F53D File Offset: 0x0000D73D
		// (set) Token: 0x06000407 RID: 1031 RVA: 0x0000F54F File Offset: 0x0000D74F
		public bool AreRowDetailsFrozen
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.AreRowDetailsFrozenProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.AreRowDetailsFrozenProperty, value);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x0000F562 File Offset: 0x0000D762
		// (set) Token: 0x06000409 RID: 1033 RVA: 0x0000F574 File Offset: 0x0000D774
		public global::System.Windows.DataTemplate RowDetailsTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateProperty, value);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x0000F582 File Offset: 0x0000D782
		// (set) Token: 0x0600040B RID: 1035 RVA: 0x0000F594 File Offset: 0x0000D794
		public global::System.Windows.Controls.DataTemplateSelector RowDetailsTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty, value);
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600040C RID: 1036 RVA: 0x0000F5A2 File Offset: 0x0000D7A2
		// (remove) Token: 0x0600040D RID: 1037 RVA: 0x0000F5BB File Offset: 0x0000D7BB
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs> LoadingRowDetails;

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600040E RID: 1038 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		// (remove) Token: 0x0600040F RID: 1039 RVA: 0x0000F5ED File Offset: 0x0000D7ED
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs> UnloadingRowDetails;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000410 RID: 1040 RVA: 0x0000F606 File Offset: 0x0000D806
		// (remove) Token: 0x06000411 RID: 1041 RVA: 0x0000F61F File Offset: 0x0000D81F
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs> RowDetailsVisibilityChanged;

		// Token: 0x06000412 RID: 1042 RVA: 0x0000F638 File Offset: 0x0000D838
		internal void OnLoadingRowDetailsWrapper(global::Microsoft.Windows.Controls.DataGridRow row)
		{
			if (row != null && !row.DetailsLoaded && row.DetailsVisibility == global::System.Windows.Visibility.Visible && row.DetailsPresenter != null)
			{
				global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs e = new global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs(row, row.DetailsPresenter.DetailsElement);
				this.OnLoadingRowDetails(e);
				row.DetailsLoaded = true;
			}
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0000F680 File Offset: 0x0000D880
		internal void OnUnloadingRowDetailsWrapper(global::Microsoft.Windows.Controls.DataGridRow row)
		{
			if (row != null && row.DetailsLoaded && row.DetailsPresenter != null)
			{
				global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs e = new global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs(row, row.DetailsPresenter.DetailsElement);
				this.OnUnloadingRowDetails(e);
				row.DetailsLoaded = false;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0000F6C0 File Offset: 0x0000D8C0
		protected virtual void OnLoadingRowDetails(global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs e)
		{
			if (this.LoadingRowDetails != null)
			{
				this.LoadingRowDetails(this, e);
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x0000F6D7 File Offset: 0x0000D8D7
		protected virtual void OnUnloadingRowDetails(global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs e)
		{
			if (this.UnloadingRowDetails != null)
			{
				this.UnloadingRowDetails(this, e);
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x0000F6F0 File Offset: 0x0000D8F0
		protected internal virtual void OnRowDetailsVisibilityChanged(global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs e)
		{
			if (this.RowDetailsVisibilityChanged != null)
			{
				this.RowDetailsVisibilityChanged(this, e);
			}
			global::Microsoft.Windows.Controls.DataGridRow row = e.Row;
			this.OnLoadingRowDetailsWrapper(row);
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x0000F720 File Offset: 0x0000D920
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0000F732 File Offset: 0x0000D932
		public bool CanUserResizeRows
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserResizeRowsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserResizeRowsProperty, value);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x0000F745 File Offset: 0x0000D945
		public global::System.Collections.Generic.IList<global::Microsoft.Windows.Controls.DataGridCellInfo> SelectedCells
		{
			get
			{
				return this._selectedCells;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x0000F74D File Offset: 0x0000D94D
		internal global::Microsoft.Windows.Controls.SelectedCellsCollection SelectedCellsInternal
		{
			get
			{
				return this._selectedCells;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x0600041B RID: 1051 RVA: 0x0000F755 File Offset: 0x0000D955
		// (remove) Token: 0x0600041C RID: 1052 RVA: 0x0000F76E File Offset: 0x0000D96E
		public event global::Microsoft.Windows.Controls.SelectedCellsChangedEventHandler SelectedCellsChanged;

		// Token: 0x0600041D RID: 1053 RVA: 0x0000F788 File Offset: 0x0000D988
		internal void OnSelectedCellsChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction action, global::Microsoft.Windows.Controls.VirtualizedCellInfoCollection oldItems, global::Microsoft.Windows.Controls.VirtualizedCellInfoCollection newItems)
		{
			global::Microsoft.Windows.Controls.DataGridSelectionMode selectionMode = this.SelectionMode;
			global::Microsoft.Windows.Controls.DataGridSelectionUnit selectionUnit = this.SelectionUnit;
			if (!this.IsUpdatingSelectedCells && selectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_CannotSelectCell));
			}
			if (oldItems != null)
			{
				if (this._pendingSelectedCells != null)
				{
					global::Microsoft.Windows.Controls.VirtualizedCellInfoCollection.Xor(this._pendingSelectedCells, oldItems);
				}
				if (this._pendingUnselectedCells == null)
				{
					this._pendingUnselectedCells = oldItems;
				}
				else
				{
					this._pendingUnselectedCells.Union(oldItems);
				}
			}
			if (newItems != null)
			{
				if (this._pendingUnselectedCells != null)
				{
					global::Microsoft.Windows.Controls.VirtualizedCellInfoCollection.Xor(this._pendingUnselectedCells, newItems);
				}
				if (this._pendingSelectedCells == null)
				{
					this._pendingSelectedCells = newItems;
				}
				else
				{
					this._pendingSelectedCells.Union(newItems);
				}
			}
			if (!this.IsUpdatingSelectedCells)
			{
				using (this.UpdateSelectedCells())
				{
					if (selectionMode == global::Microsoft.Windows.Controls.DataGridSelectionMode.Single && action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add && this._selectedCells.Count > 1)
					{
						this._selectedCells.RemoveAllButOne(newItems[0]);
					}
					else if (action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove && oldItems != null && selectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader)
					{
						bool isUpdatingSelectedItems = base.IsUpdatingSelectedItems;
						if (!isUpdatingSelectedItems)
						{
							base.BeginUpdateSelectedItems();
						}
						try
						{
							object obj = null;
							foreach (global::Microsoft.Windows.Controls.DataGridCellInfo dataGridCellInfo in oldItems)
							{
								object item = dataGridCellInfo.Item;
								if (item != obj)
								{
									obj = item;
									if (base.SelectedItems.Contains(item))
									{
										base.SelectedItems.Remove(item);
									}
								}
							}
						}
						finally
						{
							if (!isUpdatingSelectedItems)
							{
								base.EndUpdateSelectedItems();
							}
						}
					}
				}
			}
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0000F91C File Offset: 0x0000DB1C
		private void NotifySelectedCellsChanged()
		{
			if ((this._pendingSelectedCells != null && this._pendingSelectedCells.Count > 0) || (this._pendingUnselectedCells != null && this._pendingUnselectedCells.Count > 0))
			{
				global::Microsoft.Windows.Controls.SelectedCellsChangedEventArgs e = new global::Microsoft.Windows.Controls.SelectedCellsChangedEventArgs(this, this._pendingSelectedCells, this._pendingUnselectedCells);
				int count = this._selectedCells.Count;
				int num = (this._pendingUnselectedCells != null) ? this._pendingUnselectedCells.Count : 0;
				int num2 = (this._pendingSelectedCells != null) ? this._pendingSelectedCells.Count : 0;
				int num3 = count - num2 + num;
				this._pendingSelectedCells = null;
				this._pendingUnselectedCells = null;
				this.OnSelectedCellsChanged(e);
				if (num3 == 0 || count == 0)
				{
					global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
				}
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x0000F9D0 File Offset: 0x0000DBD0
		protected virtual void OnSelectedCellsChanged(global::Microsoft.Windows.Controls.SelectedCellsChangedEventArgs e)
		{
			if (this.SelectedCellsChanged != null)
			{
				this.SelectedCellsChanged(this, e);
			}
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				if (dataGridAutomationPeer != null)
				{
					dataGridAutomationPeer.RaiseAutomationCellSelectedEvent(e);
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0000FA20 File Offset: 0x0000DC20
		public static global::System.Windows.Input.RoutedUICommand SelectAllCommand
		{
			get
			{
				return global::System.Windows.Input.ApplicationCommands.SelectAll;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000FA28 File Offset: 0x0000DC28
		private static void OnCanExecuteSelectAll(object sender, global::System.Windows.Input.CanExecuteRoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)sender;
			e.CanExecute = (dataGrid.SelectionMode == global::Microsoft.Windows.Controls.DataGridSelectionMode.Extended && dataGrid.IsEnabled);
			e.Handled = true;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0000FA5C File Offset: 0x0000DC5C
		private static void OnExecutedSelectAll(object sender, global::System.Windows.Input.ExecutedRoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)sender;
			if (dataGrid.SelectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.Cell)
			{
				dataGrid.SelectAllCells();
			}
			else
			{
				dataGrid.SelectAllRows();
			}
			e.Handled = true;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0000FA90 File Offset: 0x0000DC90
		private void SelectAllRows()
		{
			int count = base.Items.Count;
			int count2 = this._columns.Count;
			if (count2 > 0 && count > 0)
			{
				using (this.UpdateSelectedCells())
				{
					this._selectedCells.AddRegion(0, 0, count, count2);
					base.SelectAll();
				}
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0000FAF8 File Offset: 0x0000DCF8
		internal void SelectOnlyThisCell(global::Microsoft.Windows.Controls.DataGridCellInfo currentCellInfo)
		{
			using (this.UpdateSelectedCells())
			{
				this._selectedCells.Clear();
				this._selectedCells.Add(currentCellInfo);
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x0000FB40 File Offset: 0x0000DD40
		public void SelectAllCells()
		{
			if (this.SelectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow)
			{
				this.SelectAllRows();
				return;
			}
			int count = base.Items.Count;
			int count2 = this._columns.Count;
			if (count > 0 && count2 > 0)
			{
				using (this.UpdateSelectedCells())
				{
					if (this._selectedCells.Count > 0)
					{
						this._selectedCells.Clear();
					}
					this._selectedCells.AddRegion(0, 0, count, count2);
				}
			}
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x0000FBC8 File Offset: 0x0000DDC8
		public void UnselectAllCells()
		{
			using (this.UpdateSelectedCells())
			{
				this._selectedCells.Clear();
				if (this.SelectionUnit != global::Microsoft.Windows.Controls.DataGridSelectionUnit.Cell)
				{
					base.UnselectAll();
				}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0000FC14 File Offset: 0x0000DE14
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x0000FC26 File Offset: 0x0000DE26
		public global::Microsoft.Windows.Controls.DataGridSelectionMode SelectionMode
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridSelectionMode)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.SelectionModeProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.SelectionModeProperty, value);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		private static void OnSelectionModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			global::Microsoft.Windows.Controls.DataGridSelectionMode dataGridSelectionMode = (global::Microsoft.Windows.Controls.DataGridSelectionMode)e.NewValue;
			bool flag = dataGridSelectionMode == global::Microsoft.Windows.Controls.DataGridSelectionMode.Single;
			global::Microsoft.Windows.Controls.DataGridSelectionUnit selectionUnit = dataGrid.SelectionUnit;
			if (flag && selectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.Cell)
			{
				using (dataGrid.UpdateSelectedCells())
				{
					dataGrid._selectedCells.RemoveAllButOne();
				}
			}
			dataGrid.CanSelectMultipleItems = (dataGridSelectionMode != global::Microsoft.Windows.Controls.DataGridSelectionMode.Single);
			if (flag && selectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader)
			{
				if (dataGrid.SelectedItems.Count > 0)
				{
					using (dataGrid.UpdateSelectedCells())
					{
						dataGrid._selectedCells.RemoveAllButOneRow(dataGrid.Items.IndexOf(dataGrid.SelectedItems[0]));
						return;
					}
				}
				using (dataGrid.UpdateSelectedCells())
				{
					dataGrid._selectedCells.RemoveAllButOne();
				}
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x0000FD34 File Offset: 0x0000DF34
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x0000FD46 File Offset: 0x0000DF46
		public global::Microsoft.Windows.Controls.DataGridSelectionUnit SelectionUnit
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridSelectionUnit)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.SelectionUnitProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.SelectionUnitProperty, value);
			}
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0000FD5C File Offset: 0x0000DF5C
		private static void OnSelectionUnitChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			global::Microsoft.Windows.Controls.DataGridSelectionUnit dataGridSelectionUnit = (global::Microsoft.Windows.Controls.DataGridSelectionUnit)e.OldValue;
			if (dataGridSelectionUnit != global::Microsoft.Windows.Controls.DataGridSelectionUnit.Cell)
			{
				dataGrid.UnselectAll();
			}
			if (dataGridSelectionUnit != global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow)
			{
				using (dataGrid.UpdateSelectedCells())
				{
					dataGrid._selectedCells.Clear();
				}
			}
			dataGrid.CoerceValue(global::System.Windows.Controls.Primitives.Selector.IsSynchronizedWithCurrentItemProperty);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0000FDC4 File Offset: 0x0000DFC4
		protected override void OnSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (!this.IsUpdatingSelectedCells)
			{
				using (this.UpdateSelectedCells())
				{
					int count = e.RemovedItems.Count;
					for (int i = 0; i < count; i++)
					{
						object rowItem = e.RemovedItems[i];
						this.UpdateSelectionOfCellsInRow(rowItem, false);
					}
					count = e.AddedItems.Count;
					for (int j = 0; j < count; j++)
					{
						object rowItem2 = e.AddedItems[j];
						this.UpdateSelectionOfCellsInRow(rowItem2, true);
					}
				}
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				if (dataGridAutomationPeer != null)
				{
					dataGridAutomationPeer.RaiseAutomationSelectionEvents(e);
				}
			}
			base.OnSelectionChanged(e);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0000FE98 File Offset: 0x0000E098
		private void UpdateIsSelected()
		{
			this.UpdateIsSelected(this._pendingUnselectedCells, false);
			this.UpdateIsSelected(this._pendingSelectedCells, true);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000FEB4 File Offset: 0x0000E0B4
		private void UpdateIsSelected(global::Microsoft.Windows.Controls.VirtualizedCellInfoCollection cells, bool isSelected)
		{
			if (cells != null)
			{
				int count = cells.Count;
				if (count > 0)
				{
					bool flag = false;
					if (count > 750)
					{
						int num = 0;
						int count2 = this._columns.Count;
						for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow> containerTracking = this._rowTrackingRoot; containerTracking != null; containerTracking = containerTracking.Next)
						{
							num += count2;
							if (num >= count)
							{
								break;
							}
						}
						flag = (count > num);
					}
					if (flag)
					{
						for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow> containerTracking2 = this._rowTrackingRoot; containerTracking2 != null; containerTracking2 = containerTracking2.Next)
						{
							global::Microsoft.Windows.Controls.DataGridRow container = containerTracking2.Container;
							global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = container.CellsPresenter;
							if (cellsPresenter != null)
							{
								for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridCell> containerTracking3 = cellsPresenter.CellTrackingRoot; containerTracking3 != null; containerTracking3 = containerTracking3.Next)
								{
									global::Microsoft.Windows.Controls.DataGridCell container2 = containerTracking3.Container;
									global::Microsoft.Windows.Controls.DataGridCellInfo cell = new global::Microsoft.Windows.Controls.DataGridCellInfo(container2);
									if (cells.Contains(cell))
									{
										container2.SyncIsSelected(isSelected);
									}
								}
							}
						}
						return;
					}
					foreach (global::Microsoft.Windows.Controls.DataGridCellInfo info in cells)
					{
						global::Microsoft.Windows.Controls.DataGridCell dataGridCell = this.TryFindCell(info);
						if (dataGridCell != null)
						{
							dataGridCell.SyncIsSelected(isSelected);
						}
					}
				}
			}
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		private void UpdateSelectionOfCellsInRow(object rowItem, bool isSelected)
		{
			int num = base.Items.IndexOf(rowItem);
			if (num >= 0)
			{
				int count = this._columns.Count;
				if (count > 0)
				{
					if (isSelected)
					{
						this._selectedCells.AddRegion(num, 0, 1, count);
						return;
					}
					this._selectedCells.RemoveRegion(num, 0, 1, count);
				}
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00010020 File Offset: 0x0000E220
		internal void CellIsSelectedChanged(global::Microsoft.Windows.Controls.DataGridCell cell, bool isSelected)
		{
			if (!this.IsUpdatingSelectedCells)
			{
				global::Microsoft.Windows.Controls.DataGridCellInfo cell2 = new global::Microsoft.Windows.Controls.DataGridCellInfo(cell);
				if (isSelected)
				{
					this._selectedCells.AddValidatedCell(cell2);
					return;
				}
				if (this._selectedCells.Contains(cell2))
				{
					this._selectedCells.Remove(cell2);
				}
			}
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00010068 File Offset: 0x0000E268
		internal void HandleSelectionForCellInput(global::Microsoft.Windows.Controls.DataGridCell cell, bool startDragging, bool allowsExtendSelect, bool allowsMinimalSelect)
		{
			global::Microsoft.Windows.Controls.DataGridSelectionUnit selectionUnit = this.SelectionUnit;
			if (selectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow)
			{
				this.MakeFullRowSelection(cell.RowDataItem, allowsExtendSelect, allowsMinimalSelect);
			}
			else
			{
				this.MakeCellSelection(new global::Microsoft.Windows.Controls.DataGridCellInfo(cell), allowsExtendSelect, allowsMinimalSelect);
			}
			if (startDragging)
			{
				this.BeginDragging();
			}
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x000100AC File Offset: 0x0000E2AC
		internal void HandleSelectionForRowHeaderAndDetailsInput(global::Microsoft.Windows.Controls.DataGridRow row, bool startDragging)
		{
			object item = row.Item;
			if (!this._isDraggingSelection && this._columns.Count > 0)
			{
				if (!base.IsKeyboardFocusWithin)
				{
					base.Focus();
				}
				if (this.CurrentCell.Item != item)
				{
					this.CurrentCell = new global::Microsoft.Windows.Controls.DataGridCellInfo(item, this.ColumnFromDisplayIndex(0), this);
				}
				else if (this._currentCellContainer != null && this._currentCellContainer.IsEditing)
				{
					this.EndEdit(global::Microsoft.Windows.Controls.DataGrid.CommitEditCommand, this._currentCellContainer, global::Microsoft.Windows.Controls.DataGridEditingUnit.Cell, true);
				}
			}
			if (this.CanSelectRows)
			{
				this.MakeFullRowSelection(item, true, true);
				if (startDragging)
				{
					this.BeginRowDragging();
				}
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0001014F File Offset: 0x0000E34F
		private void BeginRowDragging()
		{
			this.BeginDragging();
			this._isRowDragging = true;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001015E File Offset: 0x0000E35E
		private void BeginDragging()
		{
			if (global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree))
			{
				this._isDraggingSelection = true;
				this._dragPoint = global::System.Windows.Input.Mouse.GetPosition(this);
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0001017C File Offset: 0x0000E37C
		private void EndDragging()
		{
			this.StopAutoScroll();
			if (global::System.Windows.Input.Mouse.Captured == this)
			{
				base.ReleaseMouseCapture();
			}
			this._isDraggingSelection = false;
			this._isRowDragging = false;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x000101A0 File Offset: 0x0000E3A0
		private void MakeFullRowSelection(object dataItem, bool allowsExtendSelect, bool allowsMinimalSelect)
		{
			bool flag = allowsExtendSelect && this.ShouldExtendSelection;
			bool flag2 = allowsMinimalSelect && global::Microsoft.Windows.Controls.DataGrid.ShouldMinimallyModifySelection;
			using (this.UpdateSelectedCells())
			{
				bool isUpdatingSelectedItems = base.IsUpdatingSelectedItems;
				if (!isUpdatingSelectedItems)
				{
					base.BeginUpdateSelectedItems();
				}
				try
				{
					if (flag)
					{
						int count = this._columns.Count;
						if (count > 0)
						{
							global::System.Windows.Controls.ItemCollection items = base.Items;
							int num = items.IndexOf(this._selectionAnchor.Value.Item);
							int num2 = items.IndexOf(dataItem);
							if (num > num2)
							{
								int num3 = num;
								num = num2;
								num2 = num3;
							}
							if (num >= 0 && num2 >= 0)
							{
								global::System.Collections.IList selectedItems = base.SelectedItems;
								int count2 = selectedItems.Count;
								if (!flag2)
								{
									bool flag3 = false;
									for (int i = 0; i < count2; i++)
									{
										object item = selectedItems[i];
										int num4 = items.IndexOf(item);
										if (num4 < num || num2 < num4)
										{
											selectedItems.RemoveAt(i);
											if (!flag3)
											{
												this._selectedCells.Clear();
												flag3 = true;
											}
										}
									}
								}
								else
								{
									int num5 = items.IndexOf(this.CurrentCell.Item);
									int num6 = -1;
									int num7 = -1;
									if (num5 < num)
									{
										num6 = num5;
										num7 = num - 1;
									}
									else if (num5 > num2)
									{
										num6 = num2 + 1;
										num7 = num5;
									}
									if (num6 >= 0 && num7 >= 0)
									{
										for (int j = 0; j < count2; j++)
										{
											object item2 = selectedItems[j];
											int num8 = items.IndexOf(item2);
											if (num6 <= num8 && num8 <= num7)
											{
												selectedItems.RemoveAt(j);
											}
										}
										this._selectedCells.RemoveRegion(num6, 0, num7 - num6 + 1, this.Columns.Count);
									}
								}
								global::System.Collections.IEnumerator enumerator = ((global::System.Collections.IEnumerable)items).GetEnumerator();
								int num9 = 0;
								while (num9 <= num2 && enumerator.MoveNext())
								{
									if (num9 >= num)
									{
										selectedItems.Add(enumerator.Current);
									}
									num9++;
								}
								this._selectedCells.AddRegion(num, 0, num2 - num + 1, this._columns.Count);
							}
						}
					}
					else
					{
						if (flag2 && base.SelectedItems.Contains(dataItem))
						{
							this.UnselectItem(dataItem);
						}
						else
						{
							if (!flag2 || !base.CanSelectMultipleItems)
							{
								if (this._selectedCells.Count > 0)
								{
									this._selectedCells.Clear();
								}
								if (base.SelectedItems.Count > 0)
								{
									base.SelectedItems.Clear();
								}
							}
							if (this._editingRowIndex >= 0 && this._editingRowItem == dataItem)
							{
								int count3 = this._columns.Count;
								if (count3 > 0)
								{
									this._selectedCells.AddRegion(this._editingRowIndex, 0, 1, count3);
								}
								this.SelectItem(dataItem, false);
							}
							else
							{
								this.SelectItem(dataItem);
							}
						}
						this._selectionAnchor = new global::Microsoft.Windows.Controls.DataGridCellInfo?(new global::Microsoft.Windows.Controls.DataGridCellInfo(dataItem, this.ColumnFromDisplayIndex(0), this));
					}
				}
				finally
				{
					if (!isUpdatingSelectedItems)
					{
						base.EndUpdateSelectedItems();
					}
				}
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000104C0 File Offset: 0x0000E6C0
		private void MakeCellSelection(global::Microsoft.Windows.Controls.DataGridCellInfo cellInfo, bool allowsExtendSelect, bool allowsMinimalSelect)
		{
			bool flag = allowsExtendSelect && this.ShouldExtendSelection;
			bool flag2 = allowsMinimalSelect && global::Microsoft.Windows.Controls.DataGrid.ShouldMinimallyModifySelection;
			using (this.UpdateSelectedCells())
			{
				int displayIndex = cellInfo.Column.DisplayIndex;
				if (flag)
				{
					global::System.Windows.Controls.ItemCollection items = base.Items;
					int num = items.IndexOf(this._selectionAnchor.Value.Item);
					int num2 = items.IndexOf(cellInfo.Item);
					if (this._editingRowIndex >= 0)
					{
						if (this._selectionAnchor.Value.Item == this._editingRowItem)
						{
							num = this._editingRowIndex;
						}
						if (cellInfo.Item == this._editingRowItem)
						{
							num2 = this._editingRowIndex;
						}
					}
					global::Microsoft.Windows.Controls.DataGridColumn column = this._selectionAnchor.Value.Column;
					int displayIndex2 = column.DisplayIndex;
					int num3 = displayIndex;
					if (num >= 0 && num2 >= 0 && displayIndex2 >= 0 && num3 >= 0)
					{
						int num4 = global::System.Math.Abs(num2 - num) + 1;
						int num5 = global::System.Math.Abs(num3 - displayIndex2) + 1;
						if (!flag2)
						{
							if (base.SelectedItems.Count > 0)
							{
								base.UnselectAll();
							}
							this._selectedCells.Clear();
						}
						else
						{
							int num6 = items.IndexOf(this.CurrentCell.Item);
							if (this._editingRowIndex >= 0 && this._editingRowItem == this.CurrentCell.Item)
							{
								num6 = this._editingRowIndex;
							}
							int displayIndex3 = this.CurrentCell.Column.DisplayIndex;
							int num7 = global::System.Math.Min(num, num6);
							int num8 = global::System.Math.Abs(num6 - num) + 1;
							int columnIndex = global::System.Math.Min(displayIndex2, displayIndex3);
							int num9 = global::System.Math.Abs(displayIndex3 - displayIndex2) + 1;
							this._selectedCells.RemoveRegion(num7, columnIndex, num8, num9);
							if (this.SelectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader)
							{
								int num10 = num7;
								int num11 = num7 + num8 - 1;
								if (num9 <= num5)
								{
									if (num8 > num4)
									{
										int num12 = num8 - num4;
										num10 = ((num7 == num6) ? num6 : (num6 - num12 + 1));
										num11 = num10 + num12 - 1;
									}
									else
									{
										num11 = num10 - 1;
									}
								}
								for (int i = num10; i <= num11; i++)
								{
									object value = base.Items[i];
									if (base.SelectedItems.Contains(value))
									{
										base.SelectedItems.Remove(value);
									}
								}
							}
						}
						this._selectedCells.AddRegion(global::System.Math.Min(num, num2), global::System.Math.Min(displayIndex2, num3), num4, num5);
					}
				}
				else
				{
					bool flag3 = this._selectedCells.Contains(cellInfo);
					bool flag4 = this._editingRowIndex >= 0 && this._editingRowItem == cellInfo.Item;
					if (!flag3 && flag4)
					{
						flag3 = this._selectedCells.Contains(this._editingRowIndex, displayIndex);
					}
					if (flag2 && flag3)
					{
						if (flag4)
						{
							this._selectedCells.RemoveRegion(this._editingRowIndex, displayIndex, 1, 1);
						}
						else
						{
							this._selectedCells.Remove(cellInfo);
						}
						if (this.SelectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader && base.SelectedItems.Contains(cellInfo.Item))
						{
							base.SelectedItems.Remove(cellInfo.Item);
						}
					}
					else
					{
						if (!flag2 || !base.CanSelectMultipleItems)
						{
							if (base.SelectedItems.Count > 0)
							{
								base.UnselectAll();
							}
							this._selectedCells.Clear();
						}
						if (flag4)
						{
							this._selectedCells.AddRegion(this._editingRowIndex, displayIndex, 1, 1);
						}
						else
						{
							this._selectedCells.AddValidatedCell(cellInfo);
						}
					}
					this._selectionAnchor = new global::Microsoft.Windows.Controls.DataGridCellInfo?(cellInfo);
				}
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00010878 File Offset: 0x0000EA78
		private void SelectItem(object item)
		{
			this.SelectItem(item, true);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00010884 File Offset: 0x0000EA84
		private void SelectItem(object item, bool selectCells)
		{
			if (selectCells)
			{
				using (this.UpdateSelectedCells())
				{
					int num = base.Items.IndexOf(item);
					int count = this._columns.Count;
					if (num >= 0 && count > 0)
					{
						this._selectedCells.AddRegion(num, 0, 1, count);
					}
				}
			}
			this.UpdateSelectedItems(item, true);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000108F0 File Offset: 0x0000EAF0
		private void UnselectItem(object item)
		{
			using (this.UpdateSelectedCells())
			{
				int num = base.Items.IndexOf(item);
				int count = this._columns.Count;
				if (num >= 0 && count > 0)
				{
					this._selectedCells.RemoveRegion(num, 0, 1, count);
				}
			}
			this.UpdateSelectedItems(item, false);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00010958 File Offset: 0x0000EB58
		private void UpdateSelectedItems(object item, bool add)
		{
			bool isUpdatingSelectedItems = base.IsUpdatingSelectedItems;
			if (!isUpdatingSelectedItems)
			{
				base.BeginUpdateSelectedItems();
			}
			try
			{
				if (add)
				{
					base.SelectedItems.Add(item);
				}
				else
				{
					base.SelectedItems.Remove(item);
				}
			}
			finally
			{
				if (!isUpdatingSelectedItems)
				{
					base.EndUpdateSelectedItems();
				}
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000109B0 File Offset: 0x0000EBB0
		private global::System.IDisposable UpdateSelectedCells()
		{
			return new global::Microsoft.Windows.Controls.DataGrid.ChangingSelectedCellsHelper(this);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000109B8 File Offset: 0x0000EBB8
		private void BeginUpdateSelectedCells()
		{
			this._updatingSelectedCells = true;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000109C1 File Offset: 0x0000EBC1
		private void EndUpdateSelectedCells()
		{
			this.UpdateIsSelected();
			this._updatingSelectedCells = false;
			this.NotifySelectedCellsChanged();
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x000109D6 File Offset: 0x0000EBD6
		private bool IsUpdatingSelectedCells
		{
			get
			{
				return this._updatingSelectedCells;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000109DE File Offset: 0x0000EBDE
		private bool ShouldExtendSelection
		{
			get
			{
				return base.CanSelectMultipleItems && this._selectionAnchor != null && (this._isDraggingSelection || (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift);
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00010A0B File Offset: 0x0000EC0B
		private static bool ShouldMinimallyModifySelection
		{
			get
			{
				return (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x00010A18 File Offset: 0x0000EC18
		private bool CanSelectRows
		{
			get
			{
				switch (this.SelectionUnit)
				{
				case global::Microsoft.Windows.Controls.DataGridSelectionUnit.Cell:
					return false;
				case global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow:
				case global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader:
					return true;
				default:
					return false;
				}
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00010A48 File Offset: 0x0000EC48
		private void OnItemsCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._currentCellContainer = null;
			using (this.UpdateSelectedCells())
			{
				this._selectedCells.OnItemsCollectionChanged(e, base.SelectedItems);
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
			{
				using (global::System.Collections.IEnumerator enumerator = e.OldItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object item = enumerator.Current;
						this._itemAttachedStorage.ClearItem(item);
					}
					return;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
			{
				this._itemAttachedStorage.Clear();
			}
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00010B00 File Offset: 0x0000ED00
		private static void OnIsEnabledChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			d.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.CanUserAddRowsProperty);
			d.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.CanUserDeleteRowsProperty);
			if (!(bool)e.NewValue)
			{
				((global::Microsoft.Windows.Controls.DataGrid)d).UnselectAllCells();
			}
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00010B38 File Offset: 0x0000ED38
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Input.Key key = e.Key;
			if (key != global::System.Windows.Input.Key.Tab)
			{
				if (key != global::System.Windows.Input.Key.Return)
				{
					switch (key)
					{
					case global::System.Windows.Input.Key.Prior:
					case global::System.Windows.Input.Key.Next:
						this.OnPageUpOrDownKeyDown(e);
						break;
					case global::System.Windows.Input.Key.End:
					case global::System.Windows.Input.Key.Home:
						this.OnHomeOrEndKeyDown(e);
						break;
					case global::System.Windows.Input.Key.Left:
					case global::System.Windows.Input.Key.Up:
					case global::System.Windows.Input.Key.Right:
					case global::System.Windows.Input.Key.Down:
						this.OnArrowKeyDown(e);
						break;
					}
				}
				else
				{
					this.OnEnterKeyDown(e);
				}
			}
			else
			{
				this.OnTabKeyDown(e);
			}
			if (!e.Handled)
			{
				base.OnKeyDown(e);
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00010BBC File Offset: 0x0000EDBC
		private static global::System.Windows.Input.FocusNavigationDirection KeyToTraversalDirection(global::System.Windows.Input.Key key)
		{
			switch (key)
			{
			case global::System.Windows.Input.Key.Left:
				return global::System.Windows.Input.FocusNavigationDirection.Left;
			case global::System.Windows.Input.Key.Up:
				return global::System.Windows.Input.FocusNavigationDirection.Up;
			case global::System.Windows.Input.Key.Right:
				return global::System.Windows.Input.FocusNavigationDirection.Right;
			}
			return global::System.Windows.Input.FocusNavigationDirection.Down;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		private void OnArrowKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
			if (currentCellContainer != null)
			{
				e.Handled = true;
				bool isEditing = currentCellContainer.IsEditing;
				global::System.Windows.UIElement uielement = global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.UIElement;
				global::System.Windows.ContentElement contentElement = (uielement == null) ? (global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.ContentElement) : null;
				if (uielement != null || contentElement != null)
				{
					bool flag = e.OriginalSource == currentCellContainer;
					if (flag)
					{
						global::System.Windows.Input.KeyboardNavigationMode directionalNavigation = global::System.Windows.Input.KeyboardNavigation.GetDirectionalNavigation(this);
						if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Once)
						{
							global::System.Windows.DependencyObject dependencyObject = this.PredictFocus(global::Microsoft.Windows.Controls.DataGrid.KeyToTraversalDirection(e.Key));
							if (dependencyObject != null && !base.IsAncestorOf(dependencyObject))
							{
								global::System.Windows.Input.Keyboard.Focus(dependencyObject as global::System.Windows.IInputElement);
							}
							return;
						}
						int displayIndex = this.CurrentColumn.DisplayIndex;
						object currentItem = this.CurrentItem;
						int num = base.Items.IndexOf(currentItem);
						if (this._editingRowIndex >= 0 && currentItem == this._editingRowItem)
						{
							num = this._editingRowIndex;
						}
						int i = displayIndex;
						int num2 = num;
						bool flag2 = (e.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control;
						global::System.Windows.Input.Key key = e.Key;
						if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
						{
							if (key == global::System.Windows.Input.Key.Left)
							{
								key = global::System.Windows.Input.Key.Right;
							}
							else if (key == global::System.Windows.Input.Key.Right)
							{
								key = global::System.Windows.Input.Key.Left;
							}
						}
						switch (key)
						{
						case global::System.Windows.Input.Key.Left:
							if (flag2)
							{
								i = this.InternalColumns.FirstVisibleDisplayIndex;
								goto IL_2D6;
							}
							for (i--; i >= 0; i--)
							{
								global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
								if (dataGridColumn.IsVisible)
								{
									break;
								}
							}
							if (i >= 0)
							{
								goto IL_2D6;
							}
							if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Cycle)
							{
								i = this.InternalColumns.LastVisibleDisplayIndex;
								goto IL_2D6;
							}
							if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Contained)
							{
								return;
							}
							this.MoveFocus(new global::System.Windows.Input.TraversalRequest((e.Key == global::System.Windows.Input.Key.Left) ? global::System.Windows.Input.FocusNavigationDirection.Left : global::System.Windows.Input.FocusNavigationDirection.Right));
							return;
						case global::System.Windows.Input.Key.Up:
							if (flag2)
							{
								num2 = 0;
								goto IL_2D6;
							}
							num2--;
							if (num2 >= 0)
							{
								goto IL_2D6;
							}
							if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Cycle)
							{
								num2 = base.Items.Count - 1;
								goto IL_2D6;
							}
							if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Contained)
							{
								return;
							}
							this.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Up));
							return;
						case global::System.Windows.Input.Key.Right:
						{
							if (flag2)
							{
								i = global::System.Math.Max(0, this.InternalColumns.LastVisibleDisplayIndex);
								goto IL_2D6;
							}
							i++;
							int count = this.Columns.Count;
							while (i < count)
							{
								global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn2 = this.ColumnFromDisplayIndex(i);
								if (dataGridColumn2.IsVisible)
								{
									break;
								}
								i++;
							}
							if (i < this.Columns.Count)
							{
								goto IL_2D6;
							}
							if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Cycle)
							{
								i = this.InternalColumns.FirstVisibleDisplayIndex;
								goto IL_2D6;
							}
							if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Contained)
							{
								return;
							}
							this.MoveFocus(new global::System.Windows.Input.TraversalRequest((e.Key == global::System.Windows.Input.Key.Left) ? global::System.Windows.Input.FocusNavigationDirection.Left : global::System.Windows.Input.FocusNavigationDirection.Right));
							return;
						}
						}
						if (flag2)
						{
							num2 = global::System.Math.Max(0, base.Items.Count - 1);
						}
						else
						{
							num2++;
							if (num2 >= base.Items.Count)
							{
								if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Cycle)
								{
									num2 = 0;
								}
								else
								{
									if (directionalNavigation == global::System.Windows.Input.KeyboardNavigationMode.Contained)
									{
										return;
									}
									this.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.Down));
									return;
								}
							}
						}
						IL_2D6:
						global::Microsoft.Windows.Controls.DataGridColumn column = this.ColumnFromDisplayIndex(i);
						object item = base.Items[num2];
						this.ScrollCellIntoView(item, column);
						global::Microsoft.Windows.Controls.DataGridCell dataGridCell = this.TryFindCell(item, column);
						if (dataGridCell == null || dataGridCell == currentCellContainer || !dataGridCell.Focus())
						{
							return;
						}
					}
					global::System.Windows.Input.TraversalRequest request = new global::System.Windows.Input.TraversalRequest(global::Microsoft.Windows.Controls.DataGrid.KeyToTraversalDirection(e.Key));
					if (flag || (uielement != null && uielement.MoveFocus(request)) || (contentElement != null && contentElement.MoveFocus(request)))
					{
						this.SelectAndEditOnFocusMove(e, currentCellContainer, isEditing, true, true);
					}
				}
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00010F50 File Offset: 0x0000F150
		private void OnTabKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
			if (currentCellContainer != null)
			{
				bool isEditing = currentCellContainer.IsEditing;
				bool flag = (e.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift;
				global::System.Windows.UIElement uielement = global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.UIElement;
				global::System.Windows.ContentElement contentElement = (uielement == null) ? (global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.ContentElement) : null;
				if (uielement != null || contentElement != null)
				{
					e.Handled = true;
					global::System.Windows.Input.FocusNavigationDirection focusNavigationDirection = flag ? global::System.Windows.Input.FocusNavigationDirection.Previous : global::System.Windows.Input.FocusNavigationDirection.Next;
					global::System.Windows.Input.TraversalRequest traversalRequest = new global::System.Windows.Input.TraversalRequest(focusNavigationDirection);
					traversalRequest.Wrapped = true;
					if ((uielement != null && uielement.MoveFocus(traversalRequest)) || (contentElement != null && contentElement.MoveFocus(traversalRequest)))
					{
						if (isEditing && flag && global::System.Windows.Input.Keyboard.FocusedElement == currentCellContainer)
						{
							currentCellContainer.MoveFocus(traversalRequest);
						}
						if (base.IsGrouping && isEditing)
						{
							global::Microsoft.Windows.Controls.DataGridCell cellForSelectAndEditOnFocusMove = this.GetCellForSelectAndEditOnFocusMove();
							if (cellForSelectAndEditOnFocusMove != null && cellForSelectAndEditOnFocusMove.RowDataItem == currentCellContainer.RowDataItem)
							{
								global::Microsoft.Windows.Controls.DataGridCell dataGridCell = this.TryFindCell(cellForSelectAndEditOnFocusMove.RowDataItem, cellForSelectAndEditOnFocusMove.Column);
								if (dataGridCell == null)
								{
									base.UpdateLayout();
									dataGridCell = this.TryFindCell(cellForSelectAndEditOnFocusMove.RowDataItem, cellForSelectAndEditOnFocusMove.Column);
								}
								if (dataGridCell != null && dataGridCell != cellForSelectAndEditOnFocusMove)
								{
									dataGridCell.Focus();
								}
							}
						}
						this.SelectAndEditOnFocusMove(e, currentCellContainer, isEditing, false, true);
					}
				}
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001107C File Offset: 0x0000F27C
		private void OnEnterKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell currentCellContainer = this.CurrentCellContainer;
			if (currentCellContainer != null && this._columns.Count > 0)
			{
				e.Handled = true;
				global::Microsoft.Windows.Controls.DataGridColumn column = currentCellContainer.Column;
				if (this.CommitAnyEdit() && (e.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.None)
				{
					bool flag = (e.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift;
					int count = base.Items.Count;
					int num = global::System.Math.Max(0, global::System.Math.Min(count - 1, base.Items.IndexOf(currentCellContainer.RowDataItem) + (flag ? -1 : 1)));
					if (num < count)
					{
						object obj = base.Items[num];
						this.ScrollIntoView(obj, column);
						if (this.CurrentCell.Item != obj)
						{
							this.CurrentCell = new global::Microsoft.Windows.Controls.DataGridCellInfo(obj, column, this);
							this.SelectAndEditOnFocusMove(e, currentCellContainer, false, false, true);
							return;
						}
						currentCellContainer = this.CurrentCellContainer;
						if (currentCellContainer != null)
						{
							currentCellContainer.Focus();
						}
					}
				}
			}
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00011174 File Offset: 0x0000F374
		private global::Microsoft.Windows.Controls.DataGridCell GetCellForSelectAndEditOnFocusMove()
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = global::System.Windows.Input.Keyboard.FocusedElement as global::Microsoft.Windows.Controls.DataGridCell;
			if (dataGridCell == null && this.CurrentCellContainer != null && this.CurrentCellContainer.IsKeyboardFocusWithin)
			{
				dataGridCell = this.CurrentCellContainer;
			}
			return dataGridCell;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000111AC File Offset: 0x0000F3AC
		private void SelectAndEditOnFocusMove(global::System.Windows.Input.KeyEventArgs e, global::Microsoft.Windows.Controls.DataGridCell oldCell, bool wasEditing, bool allowsExtendSelect, bool ignoreControlKey)
		{
			global::Microsoft.Windows.Controls.DataGridCell cellForSelectAndEditOnFocusMove = this.GetCellForSelectAndEditOnFocusMove();
			if (cellForSelectAndEditOnFocusMove != null && cellForSelectAndEditOnFocusMove.DataGridOwner == this)
			{
				if (ignoreControlKey || (e.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.None)
				{
					if (this.ShouldSelectRowHeader && allowsExtendSelect)
					{
						this.HandleSelectionForRowHeaderAndDetailsInput(cellForSelectAndEditOnFocusMove.RowOwner, false);
					}
					else
					{
						this.HandleSelectionForCellInput(cellForSelectAndEditOnFocusMove, false, allowsExtendSelect, false);
					}
				}
				if (wasEditing && !cellForSelectAndEditOnFocusMove.IsEditing && oldCell.RowDataItem == cellForSelectAndEditOnFocusMove.RowDataItem)
				{
					this.BeginEdit(e);
				}
			}
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00011228 File Offset: 0x0000F428
		private void OnHomeOrEndKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (this._columns.Count > 0 && base.Items.Count > 0)
			{
				e.Handled = true;
				bool flag = e.Key == global::System.Windows.Input.Key.Home;
				object item = ((e.KeyboardDevice.Modifiers & global::System.Windows.Input.ModifierKeys.Control) == global::System.Windows.Input.ModifierKeys.Control) ? base.Items[flag ? 0 : (base.Items.Count - 1)] : this.CurrentItem;
				global::Microsoft.Windows.Controls.DataGridColumn column = this.ColumnFromDisplayIndex(flag ? this.InternalColumns.FirstVisibleDisplayIndex : this.InternalColumns.LastVisibleDisplayIndex);
				this.ScrollCellIntoView(item, column);
				global::Microsoft.Windows.Controls.DataGridCell dataGridCell = this.TryFindCell(item, column);
				if (dataGridCell != null)
				{
					dataGridCell.Focus();
					if (this.ShouldSelectRowHeader)
					{
						this.HandleSelectionForRowHeaderAndDetailsInput(dataGridCell.RowOwner, false);
						return;
					}
					this.HandleSelectionForCellInput(dataGridCell, false, true, false);
				}
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00011308 File Offset: 0x0000F508
		private void OnPageUpOrDownKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::System.Windows.Controls.ScrollViewer internalScrollHost = this.InternalScrollHost;
			if (internalScrollHost != null)
			{
				object currentItem = this.CurrentItem;
				global::Microsoft.Windows.Controls.DataGridColumn currentColumn = this.CurrentColumn;
				int num = base.Items.IndexOf(currentItem);
				if (num >= 0)
				{
					int num2 = global::System.Math.Max(1, (int)internalScrollHost.ViewportHeight - 1);
					int num3 = (e.Key == global::System.Windows.Input.Key.Prior) ? (num - num2) : (num + num2);
					num3 = global::System.Math.Max(0, global::System.Math.Min(num3, base.Items.Count - 1));
					object obj = base.Items[num3];
					if (currentColumn == null)
					{
						this.ScrollRowIntoView(obj);
						this.CurrentItem = obj;
						return;
					}
					this.ScrollCellIntoView(obj, currentColumn);
					global::Microsoft.Windows.Controls.DataGridCell dataGridCell = this.TryFindCell(obj, currentColumn);
					if (dataGridCell != null)
					{
						dataGridCell.Focus();
						if (this.ShouldSelectRowHeader)
						{
							this.HandleSelectionForRowHeaderAndDetailsInput(dataGridCell.RowOwner, false);
							return;
						}
						this.HandleSelectionForCellInput(dataGridCell, false, true, false);
					}
				}
			}
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000113EC File Offset: 0x0000F5EC
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._isDraggingSelection)
			{
				if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed)
				{
					global::System.Windows.Point position = global::System.Windows.Input.Mouse.GetPosition(this);
					if (!global::MS.Internal.DoubleUtil.AreClose(position, this._dragPoint))
					{
						this._dragPoint = position;
						global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions relativeMousePosition = this.RelativeMousePosition;
						if (relativeMousePosition == global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Over)
						{
							if (this._isRowDragging)
							{
								global::Microsoft.Windows.Controls.DataGridRow mouseOverRow = global::Microsoft.Windows.Controls.DataGrid.MouseOverRow;
								if (mouseOverRow != null && mouseOverRow.Item != this.CurrentItem)
								{
									this.HandleSelectionForRowHeaderAndDetailsInput(mouseOverRow, false);
									this.CurrentItem = mouseOverRow.Item;
									e.Handled = true;
									return;
								}
							}
							else
							{
								global::Microsoft.Windows.Controls.DataGridCell dataGridCell = global::Microsoft.Windows.Controls.DataGrid.MouseOverCell;
								if (dataGridCell == null)
								{
									global::Microsoft.Windows.Controls.DataGridRow mouseOverRow2 = global::Microsoft.Windows.Controls.DataGrid.MouseOverRow;
									if (mouseOverRow2 != null)
									{
										dataGridCell = this.GetCellNearMouse();
									}
								}
								if (dataGridCell != null && dataGridCell != this.CurrentCellContainer)
								{
									this.HandleSelectionForCellInput(dataGridCell, false, true, true);
									dataGridCell.Focus();
									e.Handled = true;
									return;
								}
							}
						}
						else if (this._isRowDragging && global::Microsoft.Windows.Controls.DataGrid.IsMouseToLeftOrRightOnly(relativeMousePosition))
						{
							global::Microsoft.Windows.Controls.DataGridRow rowNearMouse = this.GetRowNearMouse();
							if (rowNearMouse != null && rowNearMouse.Item != this.CurrentItem)
							{
								this.HandleSelectionForRowHeaderAndDetailsInput(rowNearMouse, false);
								this.CurrentItem = rowNearMouse.Item;
								e.Handled = true;
								return;
							}
						}
						else
						{
							if (!this._hasAutoScrolled)
							{
								this.StartAutoScroll();
								return;
							}
							if (this.DoAutoScroll())
							{
								e.Handled = true;
								return;
							}
						}
					}
				}
				else
				{
					this.EndDragging();
				}
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00011531 File Offset: 0x0000F731
		private static void OnAnyMouseUpThunk(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)sender).OnAnyMouseUp(e);
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0001153F File Offset: 0x0000F73F
		private void OnAnyMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.EndDragging();
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00011548 File Offset: 0x0000F748
		protected override void OnContextMenuOpening(global::System.Windows.Controls.ContextMenuEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridCell dataGridCell = null;
			global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader dataGridRowHeader = null;
			for (global::System.Windows.UIElement uielement = e.OriginalSource as global::System.Windows.UIElement; uielement != null; uielement = (global::System.Windows.Media.VisualTreeHelper.GetParent(uielement) as global::System.Windows.UIElement))
			{
				dataGridCell = (uielement as global::Microsoft.Windows.Controls.DataGridCell);
				if (dataGridCell != null)
				{
					break;
				}
				dataGridRowHeader = (uielement as global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader);
				if (dataGridRowHeader != null)
				{
					break;
				}
			}
			if (dataGridCell != null && !dataGridCell.IsSelected && !dataGridCell.IsKeyboardFocusWithin)
			{
				dataGridCell.Focus();
				this.HandleSelectionForCellInput(dataGridCell, false, true, true);
			}
			if (dataGridRowHeader != null)
			{
				global::Microsoft.Windows.Controls.DataGridRow parentRow = dataGridRowHeader.ParentRow;
				if (parentRow != null)
				{
					this.HandleSelectionForRowHeaderAndDetailsInput(parentRow, false);
				}
			}
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x000115C4 File Offset: 0x0000F7C4
		private global::Microsoft.Windows.Controls.DataGridRow GetRowNearMouse()
		{
			global::System.Windows.Controls.Panel internalItemsHost = this.InternalItemsHost;
			if (internalItemsHost != null)
			{
				int count = internalItemsHost.Children.Count;
				for (int i = count - 1; i >= 0; i--)
				{
					global::Microsoft.Windows.Controls.DataGridRow dataGridRow = internalItemsHost.Children[i] as global::Microsoft.Windows.Controls.DataGridRow;
					if (dataGridRow != null)
					{
						global::System.Windows.Point position = global::System.Windows.Input.Mouse.GetPosition(dataGridRow);
						global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), dataGridRow.RenderSize);
						if (position.Y >= rect.Top && position.Y <= rect.Bottom)
						{
							return dataGridRow;
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001164C File Offset: 0x0000F84C
		private global::Microsoft.Windows.Controls.DataGridCell GetCellNearMouse()
		{
			global::System.Windows.Controls.Panel internalItemsHost = this.InternalItemsHost;
			if (internalItemsHost != null)
			{
				global::System.Windows.Rect itemsHostBounds = new global::System.Windows.Rect(default(global::System.Windows.Point), internalItemsHost.RenderSize);
				double num = double.PositiveInfinity;
				global::Microsoft.Windows.Controls.DataGridCell dataGridCell = null;
				bool isMouseInCorner = global::Microsoft.Windows.Controls.DataGrid.IsMouseInCorner(this.RelativeMousePosition);
				int count = internalItemsHost.Children.Count;
				for (int i = count - 1; i >= 0; i--)
				{
					global::Microsoft.Windows.Controls.DataGridRow dataGridRow = internalItemsHost.Children[i] as global::Microsoft.Windows.Controls.DataGridRow;
					if (dataGridRow != null)
					{
						global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = dataGridRow.CellsPresenter;
						if (cellsPresenter != null)
						{
							for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridCell> containerTracking = cellsPresenter.CellTrackingRoot; containerTracking != null; containerTracking = containerTracking.Next)
							{
								global::Microsoft.Windows.Controls.DataGridCell container = containerTracking.Container;
								double num2;
								if (global::Microsoft.Windows.Controls.DataGrid.CalculateCellDistance(container, dataGridRow, internalItemsHost, itemsHostBounds, isMouseInCorner, out num2) && (dataGridCell == null || num2 < num))
								{
									num = num2;
									dataGridCell = container;
								}
							}
							global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader rowHeader = dataGridRow.RowHeader;
							double num3;
							if (rowHeader != null && global::Microsoft.Windows.Controls.DataGrid.CalculateCellDistance(rowHeader, dataGridRow, internalItemsHost, itemsHostBounds, isMouseInCorner, out num3) && (dataGridCell == null || num3 < num))
							{
								global::Microsoft.Windows.Controls.DataGridCell dataGridCell2 = dataGridRow.TryGetCell(this.DisplayIndexMap[0]);
								if (dataGridCell2 != null)
								{
									num = num3;
									dataGridCell = dataGridCell2;
								}
							}
						}
					}
				}
				return dataGridCell;
			}
			return null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00011770 File Offset: 0x0000F970
		private static bool CalculateCellDistance(global::System.Windows.FrameworkElement cell, global::Microsoft.Windows.Controls.DataGridRow rowOwner, global::System.Windows.Controls.Panel itemsHost, global::System.Windows.Rect itemsHostBounds, bool isMouseInCorner, out double distance)
		{
			global::System.Windows.Media.GeneralTransform generalTransform = cell.TransformToAncestor(itemsHost);
			global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), cell.RenderSize);
			if (itemsHostBounds.Contains(generalTransform.TransformBounds(rect)))
			{
				global::System.Windows.Point position = global::System.Windows.Input.Mouse.GetPosition(cell);
				if (isMouseInCorner)
				{
					global::System.Windows.Vector vector = new global::System.Windows.Vector(position.X - rect.Width * 0.5, position.Y - rect.Height * 0.5);
					distance = vector.Length;
					return true;
				}
				global::System.Windows.Point position2 = global::System.Windows.Input.Mouse.GetPosition(rowOwner);
				global::System.Windows.Rect rect2 = new global::System.Windows.Rect(default(global::System.Windows.Point), rowOwner.RenderSize);
				if (position.X >= rect.Left && position.X <= rect.Right)
				{
					if (position2.Y >= rect2.Top && position2.Y <= rect2.Bottom)
					{
						distance = 0.0;
					}
					else
					{
						distance = global::System.Math.Abs(position.Y - rect.Top);
					}
					return true;
				}
				if (position2.Y >= rect2.Top && position2.Y <= rect2.Bottom)
				{
					distance = global::System.Math.Abs(position.X - rect.Left);
					return true;
				}
			}
			distance = double.PositiveInfinity;
			return false;
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x000118CB File Offset: 0x0000FACB
		private static global::Microsoft.Windows.Controls.DataGridRow MouseOverRow
		{
			get
			{
				return global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::Microsoft.Windows.Controls.DataGridRow>(global::System.Windows.Input.Mouse.DirectlyOver as global::System.Windows.UIElement);
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x000118DC File Offset: 0x0000FADC
		private static global::Microsoft.Windows.Controls.DataGridCell MouseOverCell
		{
			get
			{
				return global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::Microsoft.Windows.Controls.DataGridCell>(global::System.Windows.Input.Mouse.DirectlyOver as global::System.Windows.UIElement);
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x000118F0 File Offset: 0x0000FAF0
		private global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions RelativeMousePosition
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions relativeMousePositions = global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Over;
				global::System.Windows.Controls.Panel internalItemsHost = this.InternalItemsHost;
				if (internalItemsHost != null)
				{
					global::System.Windows.Point position = global::System.Windows.Input.Mouse.GetPosition(internalItemsHost);
					global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), internalItemsHost.RenderSize);
					if (position.X < rect.Left)
					{
						relativeMousePositions |= global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Left;
					}
					else if (position.X > rect.Right)
					{
						relativeMousePositions |= global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Right;
					}
					if (position.Y < rect.Top)
					{
						relativeMousePositions |= global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Above;
					}
					else if (position.Y > rect.Bottom)
					{
						relativeMousePositions |= global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Below;
					}
				}
				return relativeMousePositions;
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001197C File Offset: 0x0000FB7C
		private static bool IsMouseToLeft(global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions position)
		{
			return (position & global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Left) == global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Left;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00011984 File Offset: 0x0000FB84
		private static bool IsMouseToRight(global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions position)
		{
			return (position & global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Right) == global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Right;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001198C File Offset: 0x0000FB8C
		private static bool IsMouseAbove(global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions position)
		{
			return (position & global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Above) == global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Above;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00011994 File Offset: 0x0000FB94
		private static bool IsMouseBelow(global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions position)
		{
			return (position & global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Below) == global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Below;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001199C File Offset: 0x0000FB9C
		private static bool IsMouseToLeftOrRightOnly(global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions position)
		{
			return position == global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Left || position == global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Right;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x000119A8 File Offset: 0x0000FBA8
		private static bool IsMouseInCorner(global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions position)
		{
			return position != global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Over && position != global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Above && position != global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Below && position != global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Left && position != global::Microsoft.Windows.Controls.DataGrid.RelativeMousePositions.Right;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x000119C2 File Offset: 0x0000FBC2
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer(this);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x000119CA File Offset: 0x0000FBCA
		private global::Microsoft.Windows.Controls.DataGridCell TryFindCell(global::Microsoft.Windows.Controls.DataGridCellInfo info)
		{
			return this.TryFindCell(info.Item, info.Column);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x000119E0 File Offset: 0x0000FBE0
		internal global::Microsoft.Windows.Controls.DataGridCell TryFindCell(object item, global::Microsoft.Windows.Controls.DataGridColumn column)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)base.ItemContainerGenerator.ContainerFromItem(item);
			int num = this._columns.IndexOf(column);
			if (dataGridRow != null && num >= 0)
			{
				return dataGridRow.TryGetCell(num);
			}
			return null;
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00011A1C File Offset: 0x0000FC1C
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00011A2E File Offset: 0x0000FC2E
		public bool CanUserSortColumns
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty, value);
			}
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00011A44 File Offset: 0x0000FC44
		private static object OnCoerceCanUserSortColumns(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			if (global::Microsoft.Windows.Controls.DataGridHelper.IsPropertyTransferEnabled(dataGrid, global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty) && global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(dataGrid, global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty) && !dataGrid.Items.CanSort)
			{
				return false;
			}
			return baseValue;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00011A88 File Offset: 0x0000FC88
		private static void OnCanUserSortColumnsPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid d2 = (global::Microsoft.Windows.Controls.DataGrid)d;
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(d2, global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty);
			global::Microsoft.Windows.Controls.DataGrid.OnNotifyColumnPropertyChanged(d, e);
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000466 RID: 1126 RVA: 0x00011AAE File Offset: 0x0000FCAE
		// (remove) Token: 0x06000467 RID: 1127 RVA: 0x00011AC7 File Offset: 0x0000FCC7
		public event global::Microsoft.Windows.Controls.DataGridSortingEventHandler Sorting;

		// Token: 0x06000468 RID: 1128 RVA: 0x00011AE0 File Offset: 0x0000FCE0
		protected virtual void OnSorting(global::Microsoft.Windows.Controls.DataGridSortingEventArgs eventArgs)
		{
			eventArgs.Handled = false;
			if (this.Sorting != null)
			{
				this.Sorting(this, eventArgs);
			}
			if (!eventArgs.Handled)
			{
				this.DefaultSort(eventArgs.Column, (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.Shift);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00011B20 File Offset: 0x0000FD20
		internal void PerformSort(global::Microsoft.Windows.Controls.DataGridColumn sortColumn)
		{
			if (!this.CanUserSortColumns || !sortColumn.CanUserSort)
			{
				return;
			}
			if (this.CommitAnyEdit())
			{
				this.PrepareForSort(sortColumn);
				global::Microsoft.Windows.Controls.DataGridSortingEventArgs eventArgs = new global::Microsoft.Windows.Controls.DataGridSortingEventArgs(sortColumn);
				this.OnSorting(eventArgs);
				if (base.Items.NeedsRefresh)
				{
					try
					{
						base.Items.Refresh();
					}
					catch (global::System.InvalidOperationException innerException)
					{
						base.Items.SortDescriptions.Clear();
						throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_ProbableInvalidSortDescription), innerException);
					}
				}
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00011BA8 File Offset: 0x0000FDA8
		private void PrepareForSort(global::Microsoft.Windows.Controls.DataGridColumn sortColumn)
		{
			if ((global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) == global::System.Windows.Input.ModifierKeys.Shift)
			{
				return;
			}
			if (this.Columns != null)
			{
				foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this.Columns)
				{
					if (dataGridColumn != sortColumn)
					{
						dataGridColumn.SortDirection = null;
					}
				}
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00011C14 File Offset: 0x0000FE14
		private void DefaultSort(global::Microsoft.Windows.Controls.DataGridColumn column, bool clearExistingSortDescriptions)
		{
			global::System.ComponentModel.ListSortDirection listSortDirection = global::System.ComponentModel.ListSortDirection.Ascending;
			global::System.ComponentModel.ListSortDirection? sortDirection = column.SortDirection;
			if (sortDirection != null && sortDirection.Value == global::System.ComponentModel.ListSortDirection.Ascending)
			{
				listSortDirection = global::System.ComponentModel.ListSortDirection.Descending;
			}
			string sortMemberPath = column.SortMemberPath;
			if (!string.IsNullOrEmpty(sortMemberPath))
			{
				int num = -1;
				if (clearExistingSortDescriptions)
				{
					base.Items.SortDescriptions.Clear();
				}
				else
				{
					for (int i = 0; i < base.Items.SortDescriptions.Count; i++)
					{
						if (string.Compare(base.Items.SortDescriptions[i].PropertyName, sortMemberPath, global::System.StringComparison.Ordinal) == 0 && (this.GroupingSortDescriptionIndices == null || !this.GroupingSortDescriptionIndices.Contains(i)))
						{
							num = i;
							break;
						}
					}
				}
				global::System.ComponentModel.SortDescription sortDescription = new global::System.ComponentModel.SortDescription(sortMemberPath, listSortDirection);
				try
				{
					if (num >= 0)
					{
						base.Items.SortDescriptions[num] = sortDescription;
					}
					else
					{
						base.Items.SortDescriptions.Add(sortDescription);
					}
					if (clearExistingSortDescriptions || !this._sortingStarted)
					{
						this.RegenerateGroupingSortDescriptions();
						this._sortingStarted = true;
					}
				}
				catch (global::System.InvalidOperationException innerException)
				{
					base.Items.SortDescriptions.Clear();
					throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_InvalidSortDescription), innerException);
				}
				column.SortDirection = new global::System.ComponentModel.ListSortDirection?(listSortDirection);
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00011D54 File Offset: 0x0000FF54
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00011D5C File Offset: 0x0000FF5C
		private global::System.Collections.Generic.List<int> GroupingSortDescriptionIndices
		{
			get
			{
				return this._groupingSortDescriptionIndices;
			}
			set
			{
				this._groupingSortDescriptionIndices = value;
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00011D68 File Offset: 0x0000FF68
		private void OnItemsSortDescriptionsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._ignoreSortDescriptionsChange || this.GroupingSortDescriptionIndices == null)
			{
				return;
			}
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			{
				int i = 0;
				int count = this.GroupingSortDescriptionIndices.Count;
				while (i < count)
				{
					if (this.GroupingSortDescriptionIndices[i] >= e.NewStartingIndex)
					{
						global::System.Collections.Generic.List<int> groupingSortDescriptionIndices;
						int index;
						(groupingSortDescriptionIndices = this.GroupingSortDescriptionIndices)[index = i] = groupingSortDescriptionIndices[index] + 1;
					}
					i++;
				}
				return;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			{
				int j = 0;
				int num = this.GroupingSortDescriptionIndices.Count;
				while (j < num)
				{
					if (this.GroupingSortDescriptionIndices[j] > e.OldStartingIndex)
					{
						global::System.Collections.Generic.List<int> groupingSortDescriptionIndices2;
						int index2;
						(groupingSortDescriptionIndices2 = this.GroupingSortDescriptionIndices)[index2 = j] = groupingSortDescriptionIndices2[index2] - 1;
					}
					else if (this.GroupingSortDescriptionIndices[j] == e.OldStartingIndex)
					{
						this.GroupingSortDescriptionIndices.RemoveAt(j);
						j--;
						num--;
					}
					j++;
				}
				return;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				this.GroupingSortDescriptionIndices.Remove(e.OldStartingIndex);
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				this.GroupingSortDescriptionIndices.Clear();
				break;
			default:
				return;
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00011E88 File Offset: 0x00010088
		private void RemoveGroupingSortDescriptions()
		{
			if (this.GroupingSortDescriptionIndices == null)
			{
				return;
			}
			bool ignoreSortDescriptionsChange = this._ignoreSortDescriptionsChange;
			this._ignoreSortDescriptionsChange = true;
			try
			{
				int i = 0;
				int count = this.GroupingSortDescriptionIndices.Count;
				while (i < count)
				{
					base.Items.SortDescriptions.RemoveAt(this.GroupingSortDescriptionIndices[i] - i);
					i++;
				}
				this.GroupingSortDescriptionIndices.Clear();
			}
			finally
			{
				this._ignoreSortDescriptionsChange = ignoreSortDescriptionsChange;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00011F08 File Offset: 0x00010108
		private static bool CanConvertToSortDescription(global::System.Windows.Data.PropertyGroupDescription propertyGroupDescription)
		{
			return propertyGroupDescription != null && propertyGroupDescription.Converter == null && propertyGroupDescription.StringComparison == global::System.StringComparison.Ordinal;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00011F24 File Offset: 0x00010124
		private void AddGroupingSortDescriptions()
		{
			bool ignoreSortDescriptionsChange = this._ignoreSortDescriptionsChange;
			this._ignoreSortDescriptionsChange = true;
			try
			{
				int index = 0;
				foreach (global::System.ComponentModel.GroupDescription groupDescription in base.Items.GroupDescriptions)
				{
					global::System.Windows.Data.PropertyGroupDescription propertyGroupDescription = groupDescription as global::System.Windows.Data.PropertyGroupDescription;
					if (global::Microsoft.Windows.Controls.DataGrid.CanConvertToSortDescription(propertyGroupDescription))
					{
						global::System.ComponentModel.SortDescription item = new global::System.ComponentModel.SortDescription(propertyGroupDescription.PropertyName, global::System.ComponentModel.ListSortDirection.Ascending);
						base.Items.SortDescriptions.Insert(index, item);
						if (this.GroupingSortDescriptionIndices == null)
						{
							this.GroupingSortDescriptionIndices = new global::System.Collections.Generic.List<int>();
						}
						this.GroupingSortDescriptionIndices.Add(index++);
					}
				}
			}
			finally
			{
				this._ignoreSortDescriptionsChange = ignoreSortDescriptionsChange;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00011FF0 File Offset: 0x000101F0
		private void RegenerateGroupingSortDescriptions()
		{
			this.RemoveGroupingSortDescriptions();
			this.AddGroupingSortDescriptions();
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00012000 File Offset: 0x00010200
		private void OnItemsGroupDescriptionsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (!this._sortingStarted)
			{
				return;
			}
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				if (global::Microsoft.Windows.Controls.DataGrid.CanConvertToSortDescription(e.NewItems[0] as global::System.Windows.Data.PropertyGroupDescription))
				{
					this.RegenerateGroupingSortDescriptions();
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				if (global::Microsoft.Windows.Controls.DataGrid.CanConvertToSortDescription(e.OldItems[0] as global::System.Windows.Data.PropertyGroupDescription))
				{
					this.RegenerateGroupingSortDescriptions();
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				if (global::Microsoft.Windows.Controls.DataGrid.CanConvertToSortDescription(e.OldItems[0] as global::System.Windows.Data.PropertyGroupDescription) || global::Microsoft.Windows.Controls.DataGrid.CanConvertToSortDescription(e.NewItems[0] as global::System.Windows.Data.PropertyGroupDescription))
				{
					this.RegenerateGroupingSortDescriptions();
					return;
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				this.RemoveGroupingSortDescriptions();
				break;
			default:
				return;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000474 RID: 1140 RVA: 0x000120B3 File Offset: 0x000102B3
		// (remove) Token: 0x06000475 RID: 1141 RVA: 0x000120CC File Offset: 0x000102CC
		public event global::System.EventHandler AutoGeneratedColumns;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000476 RID: 1142 RVA: 0x000120E5 File Offset: 0x000102E5
		// (remove) Token: 0x06000477 RID: 1143 RVA: 0x000120FE File Offset: 0x000102FE
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridAutoGeneratingColumnEventArgs> AutoGeneratingColumn;

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00012117 File Offset: 0x00010317
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00012129 File Offset: 0x00010329
		public bool AutoGenerateColumns
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.AutoGenerateColumnsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.AutoGenerateColumnsProperty, value);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001213C File Offset: 0x0001033C
		protected virtual void OnAutoGeneratedColumns(global::System.EventArgs e)
		{
			if (this.AutoGeneratedColumns != null)
			{
				this.AutoGeneratedColumns(this, e);
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00012153 File Offset: 0x00010353
		protected virtual void OnAutoGeneratingColumn(global::Microsoft.Windows.Controls.DataGridAutoGeneratingColumnEventArgs e)
		{
			if (this.AutoGeneratingColumn != null)
			{
				this.AutoGeneratingColumn(this, e);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001216C File Offset: 0x0001036C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			if (this._measureNeverInvoked)
			{
				this._measureNeverInvoked = false;
				if (this.AutoGenerateColumns)
				{
					this.AddAutoColumns();
				}
				this.InternalColumns.InitializeDisplayIndexMap();
				base.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.FrozenColumnCountProperty);
				base.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.CanUserAddRowsProperty);
				base.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.CanUserDeleteRowsProperty);
				this.UpdateNewItemPlaceholder(false);
			}
			else if (this.DeferAutoGeneration && this.AutoGenerateColumns)
			{
				this.AddAutoColumns();
			}
			return base.MeasureOverride(availableSize);
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x000121E8 File Offset: 0x000103E8
		private void ClearSortDescriptionsOnItemsSourceChange()
		{
			base.Items.SortDescriptions.Clear();
			this._sortingStarted = false;
			global::System.Collections.Generic.List<int> groupingSortDescriptionIndices = this.GroupingSortDescriptionIndices;
			if (groupingSortDescriptionIndices != null)
			{
				groupingSortDescriptionIndices.Clear();
			}
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this.Columns)
			{
				dataGridColumn.SortDirection = null;
			}
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00012264 File Offset: 0x00010464
		private static object OnCoerceItemsSourceProperty(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			if (baseValue != dataGrid._cachedItemsSource && dataGrid._cachedItemsSource != null)
			{
				dataGrid.ClearSortDescriptionsOnItemsSourceChange();
			}
			return baseValue;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00012290 File Offset: 0x00010490
		protected override void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
			base.OnItemsSourceChanged(oldValue, newValue);
			if (newValue == null)
			{
				this.ClearSortDescriptionsOnItemsSourceChange();
			}
			this._cachedItemsSource = newValue;
			using (this.UpdateSelectedCells())
			{
				this._selectedCells.RestoreOnlyFullRows(base.SelectedItems);
			}
			if (this.AutoGenerateColumns)
			{
				this.RegenerateAutoColumns();
			}
			this.InternalColumns.RefreshAutoWidthColumns = true;
			this.InternalColumns.InvalidateColumnWidthsComputation();
			base.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.CanUserAddRowsProperty);
			base.CoerceValue(global::Microsoft.Windows.Controls.DataGrid.CanUserDeleteRowsProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGrid.CanUserSortColumnsProperty);
			this.ResetRowHeaderActualWidth();
			this.UpdateNewItemPlaceholder(false);
			this.HasCellValidationError = false;
			this.HasRowValidationError = false;
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0001234C File Offset: 0x0001054C
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00012354 File Offset: 0x00010554
		private bool DeferAutoGeneration { get; set; }

		// Token: 0x06000482 RID: 1154 RVA: 0x00012360 File Offset: 0x00010560
		protected override void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			base.OnItemsChanged(e);
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				if (this.DeferAutoGeneration)
				{
					this.AddAutoColumns();
					return;
				}
			}
			else
			{
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
				{
					if (!this.HasRowValidationError && !this.HasCellValidationError)
					{
						return;
					}
					using (global::System.Collections.IEnumerator enumerator = e.OldItems.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							object item = enumerator.Current;
							if (this.IsAddingOrEditingRowItem(item))
							{
								this.HasRowValidationError = false;
								this.HasCellValidationError = false;
								break;
							}
						}
						return;
					}
				}
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
				{
					this.ResetRowHeaderActualWidth();
					this.HasRowValidationError = false;
					this.HasCellValidationError = false;
				}
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00012428 File Offset: 0x00010628
		private void AddAutoColumns()
		{
			if (this.DataItemsCount == 0)
			{
				this.DeferAutoGeneration = true;
				return;
			}
			if (!this._measureNeverInvoked)
			{
				global::Microsoft.Windows.Controls.DataGrid.GenerateColumns(base.Items, this, null);
				this.DeferAutoGeneration = false;
				this.OnAutoGeneratedColumns(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00012464 File Offset: 0x00010664
		private void DeleteAutoColumns()
		{
			if (!this.DeferAutoGeneration && !this._measureNeverInvoked)
			{
				for (int i = this.Columns.Count - 1; i >= 0; i--)
				{
					if (this.Columns[i].IsAutoGenerated)
					{
						this.Columns.RemoveAt(i);
					}
				}
				return;
			}
			this.DeferAutoGeneration = false;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x000124C0 File Offset: 0x000106C0
		private void RegenerateAutoColumns()
		{
			this.DeleteAutoColumns();
			this.AddAutoColumns();
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x000124D0 File Offset: 0x000106D0
		public static global::System.Collections.ObjectModel.Collection<global::Microsoft.Windows.Controls.DataGridColumn> GenerateColumns(global::System.ComponentModel.IItemProperties itemProperties)
		{
			if (itemProperties == null)
			{
				throw new global::System.ArgumentNullException("itemProperties");
			}
			global::System.Collections.ObjectModel.Collection<global::Microsoft.Windows.Controls.DataGridColumn> collection = new global::System.Collections.ObjectModel.Collection<global::Microsoft.Windows.Controls.DataGridColumn>();
			global::Microsoft.Windows.Controls.DataGrid.GenerateColumns(itemProperties, null, collection);
			return collection;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000124FC File Offset: 0x000106FC
		private static void GenerateColumns(global::System.ComponentModel.IItemProperties iItemProperties, global::Microsoft.Windows.Controls.DataGrid dataGrid, global::System.Collections.ObjectModel.Collection<global::Microsoft.Windows.Controls.DataGridColumn> columnCollection)
		{
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.ComponentModel.ItemPropertyInfo> itemProperties = iItemProperties.ItemProperties;
			if (itemProperties != null && itemProperties.Count > 0)
			{
				foreach (global::System.ComponentModel.ItemPropertyInfo itemPropertyInfo in itemProperties)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = global::Microsoft.Windows.Controls.DataGridColumn.CreateDefaultColumn(itemPropertyInfo);
					if (dataGrid != null)
					{
						global::Microsoft.Windows.Controls.DataGridAutoGeneratingColumnEventArgs dataGridAutoGeneratingColumnEventArgs = new global::Microsoft.Windows.Controls.DataGridAutoGeneratingColumnEventArgs(dataGridColumn, itemPropertyInfo);
						dataGrid.OnAutoGeneratingColumn(dataGridAutoGeneratingColumnEventArgs);
						if (!dataGridAutoGeneratingColumnEventArgs.Cancel && dataGridAutoGeneratingColumnEventArgs.Column != null)
						{
							dataGridAutoGeneratingColumnEventArgs.Column.IsAutoGenerated = true;
							dataGrid.Columns.Add(dataGridAutoGeneratingColumnEventArgs.Column);
						}
					}
					else
					{
						columnCollection.Add(dataGridColumn);
					}
				}
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000125A8 File Offset: 0x000107A8
		private static void OnAutoGenerateColumnsPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			bool flag = (bool)e.NewValue;
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			if (flag)
			{
				dataGrid.AddAutoColumns();
				return;
			}
			dataGrid.DeleteAutoColumns();
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x000125D9 File Offset: 0x000107D9
		// (set) Token: 0x0600048A RID: 1162 RVA: 0x000125EB File Offset: 0x000107EB
		public int FrozenColumnCount
		{
			get
			{
				return (int)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.FrozenColumnCountProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.FrozenColumnCountProperty, value);
			}
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00012600 File Offset: 0x00010800
		private static object OnCoerceFrozenColumnCount(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			int num = (int)baseValue;
			if (num > dataGrid.Columns.Count)
			{
				return dataGrid.Columns.Count;
			}
			return baseValue;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001263B File Offset: 0x0001083B
		private static void OnFrozenColumnCountPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.ColumnCollection | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001264C File Offset: 0x0001084C
		private static bool ValidateFrozenColumnCount(object value)
		{
			int num = (int)value;
			return num >= 0;
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00012667 File Offset: 0x00010867
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00012679 File Offset: 0x00010879
		public double NonFrozenColumnsViewportHorizontalOffset
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.NonFrozenColumnsViewportHorizontalOffsetProperty);
			}
			internal set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.NonFrozenColumnsViewportHorizontalOffsetPropertyKey, value);
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001268C File Offset: 0x0001088C
		public override void OnApplyTemplate()
		{
			this.CleanUpInternalScrollControls();
			base.OnApplyTemplate();
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x0001269A File Offset: 0x0001089A
		// (set) Token: 0x06000492 RID: 1170 RVA: 0x000126AC File Offset: 0x000108AC
		public bool EnableRowVirtualization
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.EnableRowVirtualizationProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.EnableRowVirtualizationProperty, value);
			}
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x000126C0 File Offset: 0x000108C0
		private static void OnEnableRowVirtualizationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGrid = (global::Microsoft.Windows.Controls.DataGrid)d;
			dataGrid.CoerceValue(global::System.Windows.Controls.VirtualizingStackPanel.IsVirtualizingProperty);
			global::System.Windows.Controls.Panel internalItemsHost = dataGrid.InternalItemsHost;
			if (internalItemsHost != null)
			{
				internalItemsHost.InvalidateMeasure();
				internalItemsHost.InvalidateArrange();
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000126F5 File Offset: 0x000108F5
		private static object OnCoerceIsVirtualizingProperty(global::System.Windows.DependencyObject d, object baseValue)
		{
			if (!global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(d, global::Microsoft.Windows.Controls.DataGrid.EnableRowVirtualizationProperty))
			{
				return d.GetValue(global::Microsoft.Windows.Controls.DataGrid.EnableRowVirtualizationProperty);
			}
			return baseValue;
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00012711 File Offset: 0x00010911
		// (set) Token: 0x06000496 RID: 1174 RVA: 0x00012723 File Offset: 0x00010923
		public bool EnableColumnVirtualization
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty, value);
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00012736 File Offset: 0x00010936
		private static void OnEnableColumnVirtualizationChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.ColumnCollection | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00012747 File Offset: 0x00010947
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x00012759 File Offset: 0x00010959
		public bool CanUserReorderColumns
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserReorderColumnsProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CanUserReorderColumnsProperty, value);
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0001276C File Offset: 0x0001096C
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x0001277E File Offset: 0x0001097E
		public global::System.Windows.Style DragIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.DragIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.DragIndicatorStyleProperty, value);
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001278C File Offset: 0x0001098C
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x0001279E File Offset: 0x0001099E
		public global::System.Windows.Style DropLocationIndicatorStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.DropLocationIndicatorStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.DropLocationIndicatorStyleProperty, value);
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x0600049E RID: 1182 RVA: 0x000127AC File Offset: 0x000109AC
		// (remove) Token: 0x0600049F RID: 1183 RVA: 0x000127C5 File Offset: 0x000109C5
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridColumnReorderingEventArgs> ColumnReordering;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x060004A0 RID: 1184 RVA: 0x000127DE File Offset: 0x000109DE
		// (remove) Token: 0x060004A1 RID: 1185 RVA: 0x000127F7 File Offset: 0x000109F7
		public event global::System.EventHandler<global::System.Windows.Controls.Primitives.DragStartedEventArgs> ColumnHeaderDragStarted;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x060004A2 RID: 1186 RVA: 0x00012810 File Offset: 0x00010A10
		// (remove) Token: 0x060004A3 RID: 1187 RVA: 0x00012829 File Offset: 0x00010A29
		public event global::System.EventHandler<global::System.Windows.Controls.Primitives.DragDeltaEventArgs> ColumnHeaderDragDelta;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x060004A4 RID: 1188 RVA: 0x00012842 File Offset: 0x00010A42
		// (remove) Token: 0x060004A5 RID: 1189 RVA: 0x0001285B File Offset: 0x00010A5B
		public event global::System.EventHandler<global::System.Windows.Controls.Primitives.DragCompletedEventArgs> ColumnHeaderDragCompleted;

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x060004A6 RID: 1190 RVA: 0x00012874 File Offset: 0x00010A74
		// (remove) Token: 0x060004A7 RID: 1191 RVA: 0x0001288D File Offset: 0x00010A8D
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridColumnEventArgs> ColumnReordered;

		// Token: 0x060004A8 RID: 1192 RVA: 0x000128A6 File Offset: 0x00010AA6
		protected internal virtual void OnColumnHeaderDragStarted(global::System.Windows.Controls.Primitives.DragStartedEventArgs e)
		{
			if (this.ColumnHeaderDragStarted != null)
			{
				this.ColumnHeaderDragStarted(this, e);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000128BD File Offset: 0x00010ABD
		protected internal virtual void OnColumnReordering(global::Microsoft.Windows.Controls.DataGridColumnReorderingEventArgs e)
		{
			if (this.ColumnReordering != null)
			{
				this.ColumnReordering(this, e);
			}
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x000128D4 File Offset: 0x00010AD4
		protected internal virtual void OnColumnHeaderDragDelta(global::System.Windows.Controls.Primitives.DragDeltaEventArgs e)
		{
			if (this.ColumnHeaderDragDelta != null)
			{
				this.ColumnHeaderDragDelta(this, e);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x000128EB File Offset: 0x00010AEB
		protected internal virtual void OnColumnHeaderDragCompleted(global::System.Windows.Controls.Primitives.DragCompletedEventArgs e)
		{
			if (this.ColumnHeaderDragCompleted != null)
			{
				this.ColumnHeaderDragCompleted(this, e);
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00012902 File Offset: 0x00010B02
		protected internal virtual void OnColumnReordered(global::Microsoft.Windows.Controls.DataGridColumnEventArgs e)
		{
			if (this.ColumnReordered != null)
			{
				this.ColumnReordered(this, e);
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00012919 File Offset: 0x00010B19
		private static void OnClipboardCopyModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::System.Windows.Input.CommandManager.InvalidateRequerySuggested();
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00012920 File Offset: 0x00010B20
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00012932 File Offset: 0x00010B32
		public global::Microsoft.Windows.Controls.DataGridClipboardCopyMode ClipboardCopyMode
		{
			get
			{
				return (global::Microsoft.Windows.Controls.DataGridClipboardCopyMode)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.ClipboardCopyModeProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.ClipboardCopyModeProperty, value);
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00012945 File Offset: 0x00010B45
		private static void OnCanExecuteCopy(object target, global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			((global::Microsoft.Windows.Controls.DataGrid)target).OnCanExecuteCopy(args);
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00012953 File Offset: 0x00010B53
		protected virtual void OnCanExecuteCopy(global::System.Windows.Input.CanExecuteRoutedEventArgs args)
		{
			args.CanExecute = (this.ClipboardCopyMode != global::Microsoft.Windows.Controls.DataGridClipboardCopyMode.None && this._selectedCells.Count > 0);
			args.Handled = true;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0001297B File Offset: 0x00010B7B
		private static void OnExecutedCopy(object target, global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			((global::Microsoft.Windows.Controls.DataGrid)target).OnExecutedCopy(args);
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0001298C File Offset: 0x00010B8C
		protected virtual void OnExecutedCopy(global::System.Windows.Input.ExecutedRoutedEventArgs args)
		{
			if (this.ClipboardCopyMode == global::Microsoft.Windows.Controls.DataGridClipboardCopyMode.None)
			{
				throw new global::System.NotSupportedException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.ClipboardCopyMode_Disabled));
			}
			args.Handled = true;
			global::System.Collections.ObjectModel.Collection<string> collection = new global::System.Collections.ObjectModel.Collection<string>(new string[]
			{
				global::System.Windows.DataFormats.Html,
				global::System.Windows.DataFormats.Text,
				global::System.Windows.DataFormats.UnicodeText,
				global::System.Windows.DataFormats.CommaSeparatedValue
			});
			global::System.Collections.Generic.Dictionary<string, global::System.Text.StringBuilder> dictionary = new global::System.Collections.Generic.Dictionary<string, global::System.Text.StringBuilder>(collection.Count);
			foreach (string key in collection)
			{
				dictionary[key] = new global::System.Text.StringBuilder();
			}
			int startColumnDisplayIndex;
			int endColumnDisplayIndex;
			int num;
			int num2;
			if (this._selectedCells.GetSelectionRange(out startColumnDisplayIndex, out endColumnDisplayIndex, out num, out num2))
			{
				if (this.ClipboardCopyMode == global::Microsoft.Windows.Controls.DataGridClipboardCopyMode.IncludeHeader)
				{
					global::Microsoft.Windows.Controls.DataGridRowClipboardEventArgs dataGridRowClipboardEventArgs = new global::Microsoft.Windows.Controls.DataGridRowClipboardEventArgs(null, startColumnDisplayIndex, endColumnDisplayIndex, true);
					this.OnCopyingRowClipboardContent(dataGridRowClipboardEventArgs);
					foreach (string text in collection)
					{
						dictionary[text].Append(dataGridRowClipboardEventArgs.FormatClipboardCellValues(text));
					}
				}
				for (int i = num; i <= num2; i++)
				{
					object item = base.Items[i];
					if (this._selectedCells.Intersects(i))
					{
						global::Microsoft.Windows.Controls.DataGridRowClipboardEventArgs dataGridRowClipboardEventArgs2 = new global::Microsoft.Windows.Controls.DataGridRowClipboardEventArgs(item, startColumnDisplayIndex, endColumnDisplayIndex, false, i);
						this.OnCopyingRowClipboardContent(dataGridRowClipboardEventArgs2);
						foreach (string text2 in collection)
						{
							dictionary[text2].Append(dataGridRowClipboardEventArgs2.FormatClipboardCellValues(text2));
						}
					}
				}
			}
			global::Microsoft.Windows.Controls.ClipboardHelper.GetClipboardContentForHtml(dictionary[global::System.Windows.DataFormats.Html]);
			try
			{
				global::System.Windows.DataObject dataObject = new global::System.Windows.DataObject();
				foreach (string text3 in collection)
				{
					dataObject.SetData(text3, dictionary[text3].ToString(), false);
				}
				global::System.Windows.Clipboard.SetDataObject(dataObject);
			}
			catch (global::System.Security.SecurityException)
			{
				global::System.Windows.Controls.TextBox textBox = new global::System.Windows.Controls.TextBox();
				textBox.Text = dictionary[global::System.Windows.DataFormats.Text].ToString();
				textBox.SelectAll();
				textBox.Copy();
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00012C00 File Offset: 0x00010E00
		protected virtual void OnCopyingRowClipboardContent(global::Microsoft.Windows.Controls.DataGridRowClipboardEventArgs args)
		{
			if (args.IsColumnHeadersRow)
			{
				for (int i = args.StartColumnDisplayIndex; i <= args.EndColumnDisplayIndex; i++)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
					if (dataGridColumn.IsVisible)
					{
						args.ClipboardRowContent.Add(new global::Microsoft.Windows.Controls.DataGridClipboardCellContent(args.Item, dataGridColumn, dataGridColumn.Header));
					}
				}
			}
			else
			{
				int num = args.RowIndexHint;
				if (num < 0)
				{
					num = base.Items.IndexOf(args.Item);
				}
				if (this._selectedCells.Intersects(num))
				{
					for (int j = args.StartColumnDisplayIndex; j <= args.EndColumnDisplayIndex; j++)
					{
						global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn2 = this.ColumnFromDisplayIndex(j);
						if (dataGridColumn2.IsVisible)
						{
							object content = null;
							if (this._selectedCells.Contains(num, j))
							{
								content = dataGridColumn2.OnCopyingCellClipboardContent(args.Item);
							}
							args.ClipboardRowContent.Add(new global::Microsoft.Windows.Controls.DataGridClipboardCellContent(args.Item, dataGridColumn2, content));
						}
					}
				}
			}
			if (this.CopyingRowClipboardContent != null)
			{
				this.CopyingRowClipboardContent(this, args);
			}
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x060004B5 RID: 1205 RVA: 0x00012D00 File Offset: 0x00010F00
		// (remove) Token: 0x060004B6 RID: 1206 RVA: 0x00012D19 File Offset: 0x00010F19
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.DataGridRowClipboardEventArgs> CopyingRowClipboardContent;

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00012D32 File Offset: 0x00010F32
		// (set) Token: 0x060004B8 RID: 1208 RVA: 0x00012D44 File Offset: 0x00010F44
		internal double CellsPanelActualWidth
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CellsPanelActualWidthProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CellsPanelActualWidthProperty, value);
			}
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00012D58 File Offset: 0x00010F58
		private static void CellsPanelActualWidthChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			double value = (double)e.OldValue;
			double value2 = (double)e.NewValue;
			if (!global::MS.Internal.DoubleUtil.AreClose(value, value2))
			{
				((global::Microsoft.Windows.Controls.DataGrid)d).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00012D97 File Offset: 0x00010F97
		// (set) Token: 0x060004BB RID: 1211 RVA: 0x00012DA9 File Offset: 0x00010FA9
		public double CellsPanelHorizontalOffset
		{
			get
			{
				return (double)base.GetValue(global::Microsoft.Windows.Controls.DataGrid.CellsPanelHorizontalOffsetProperty);
			}
			private set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGrid.CellsPanelHorizontalOffsetPropertyKey, value);
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x00012DBC File Offset: 0x00010FBC
		// (set) Token: 0x060004BD RID: 1213 RVA: 0x00012DC4 File Offset: 0x00010FC4
		private bool CellsPanelHorizontalOffsetComputationPending { get; set; }

		// Token: 0x060004BE RID: 1214 RVA: 0x00012DD0 File Offset: 0x00010FD0
		internal void QueueInvalidateCellsPanelHorizontalOffset()
		{
			if (!this.CellsPanelHorizontalOffsetComputationPending)
			{
				base.Dispatcher.BeginInvoke(new global::System.Windows.Threading.DispatcherOperationCallback(this.InvalidateCellsPanelHorizontalOffset), global::System.Windows.Threading.DispatcherPriority.Loaded, new object[]
				{
					this
				});
				this.CellsPanelHorizontalOffsetComputationPending = true;
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00012E14 File Offset: 0x00011014
		private object InvalidateCellsPanelHorizontalOffset(object args)
		{
			if (!this.CellsPanelHorizontalOffsetComputationPending)
			{
				return null;
			}
			global::Microsoft.Windows.Controls.IProvideDataGridColumn anyCellOrColumnHeader = this.GetAnyCellOrColumnHeader();
			if (anyCellOrColumnHeader != null)
			{
				this.CellsPanelHorizontalOffset = global::Microsoft.Windows.Controls.DataGridHelper.GetParentCellsPanelHorizontalOffset(anyCellOrColumnHeader);
			}
			else if (!double.IsNaN(this.RowHeaderWidth))
			{
				this.CellsPanelHorizontalOffset = this.RowHeaderWidth;
			}
			else
			{
				this.CellsPanelHorizontalOffset = 0.0;
			}
			this.CellsPanelHorizontalOffsetComputationPending = false;
			return null;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00012E78 File Offset: 0x00011078
		internal global::Microsoft.Windows.Controls.IProvideDataGridColumn GetAnyCellOrColumnHeader()
		{
			if (this._rowTrackingRoot != null)
			{
				for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow> containerTracking = this._rowTrackingRoot; containerTracking != null; containerTracking = containerTracking.Next)
				{
					if (containerTracking.Container.IsVisible)
					{
						global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = containerTracking.Container.CellsPresenter;
						if (cellsPresenter != null)
						{
							for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridCell> containerTracking2 = cellsPresenter.CellTrackingRoot; containerTracking2 != null; containerTracking2 = containerTracking2.Next)
							{
								if (containerTracking2.Container.IsVisible)
								{
									return containerTracking2.Container;
								}
							}
						}
					}
				}
			}
			if (this.ColumnHeadersPresenter != null)
			{
				for (global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeader> containerTracking3 = this.ColumnHeadersPresenter.HeaderTrackingRoot; containerTracking3 != null; containerTracking3 = containerTracking3.Next)
				{
					if (containerTracking3.Container.IsVisible)
					{
						return containerTracking3.Container;
					}
				}
			}
			return null;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00012F18 File Offset: 0x00011118
		internal double GetViewportWidthForColumns()
		{
			if (this.InternalScrollHost == null)
			{
				return 0.0;
			}
			double viewportWidth = this.InternalScrollHost.ViewportWidth;
			return viewportWidth - this.CellsPanelHorizontalOffset;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00012F4D File Offset: 0x0001114D
		internal static object NewItemPlaceholder
		{
			get
			{
				return global::Microsoft.Windows.Controls.DataGrid._newItemPlaceholder;
			}
		}

		// Token: 0x040000D5 RID: 213
		private const string ItemsPanelPartName = "PART_RowsPresenter";

		// Token: 0x040000D6 RID: 214
		public static readonly global::System.Windows.DependencyProperty CanUserResizeColumnsProperty = global::System.Windows.DependencyProperty.Register("CanUserResizeColumns", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyColumnAndColumnHeaderPropertyChanged)));

		// Token: 0x040000D7 RID: 215
		public static readonly global::System.Windows.DependencyProperty ColumnWidthProperty = global::System.Windows.DependencyProperty.Register("ColumnWidth", typeof(global::Microsoft.Windows.Controls.DataGridLength), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridLength.SizeToHeader));

		// Token: 0x040000D8 RID: 216
		public static readonly global::System.Windows.DependencyProperty MinColumnWidthProperty = global::System.Windows.DependencyProperty.Register("MinColumnWidth", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(20.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnColumnSizeConstraintChanged)), new global::System.Windows.ValidateValueCallback(global::Microsoft.Windows.Controls.DataGrid.ValidateMinColumnWidth));

		// Token: 0x040000D9 RID: 217
		public static readonly global::System.Windows.DependencyProperty MaxColumnWidthProperty = global::System.Windows.DependencyProperty.Register("MaxColumnWidth", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(double.PositiveInfinity, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnColumnSizeConstraintChanged)), new global::System.Windows.ValidateValueCallback(global::Microsoft.Windows.Controls.DataGrid.ValidateMaxColumnWidth));

		// Token: 0x040000DB RID: 219
		public static readonly global::System.Windows.DependencyProperty GridLinesVisibilityProperty = global::System.Windows.DependencyProperty.Register("GridLinesVisibility", typeof(global::Microsoft.Windows.Controls.DataGridGridLinesVisibility), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridGridLinesVisibility.All, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyGridLinePropertyChanged)));

		// Token: 0x040000DC RID: 220
		public static readonly global::System.Windows.DependencyProperty HorizontalGridLinesBrushProperty = global::System.Windows.DependencyProperty.Register("HorizontalGridLinesBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Black, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyGridLinePropertyChanged)));

		// Token: 0x040000DD RID: 221
		public static readonly global::System.Windows.DependencyProperty VerticalGridLinesBrushProperty = global::System.Windows.DependencyProperty.Register("VerticalGridLinesBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Media.Brushes.Black, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyGridLinePropertyChanged)));

		// Token: 0x040000DE RID: 222
		public static readonly global::System.Windows.DependencyProperty RowStyleProperty = global::System.Windows.DependencyProperty.Register("RowStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnRowStyleChanged)));

		// Token: 0x040000DF RID: 223
		public static readonly global::System.Windows.DependencyProperty RowValidationErrorTemplateProperty = global::System.Windows.DependencyProperty.Register("RowValidationErrorTemplate", typeof(global::System.Windows.Controls.ControlTemplate), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowPropertyChanged)));

		// Token: 0x040000E0 RID: 224
		public static readonly global::System.Windows.DependencyProperty RowStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("RowStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnRowStyleSelectorChanged)));

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty RowBackgroundProperty = global::System.Windows.DependencyProperty.Register("RowBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowPropertyChanged)));

		// Token: 0x040000E2 RID: 226
		public static readonly global::System.Windows.DependencyProperty AlternatingRowBackgroundProperty = global::System.Windows.DependencyProperty.Register("AlternatingRowBackground", typeof(global::System.Windows.Media.Brush), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyDataGridAndRowPropertyChanged)));

		// Token: 0x040000E3 RID: 227
		public static readonly global::System.Windows.DependencyProperty RowHeightProperty = global::System.Windows.DependencyProperty.Register("RowHeight", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyCellsPresenterPropertyChanged)));

		// Token: 0x040000E4 RID: 228
		public static readonly global::System.Windows.DependencyProperty MinRowHeightProperty = global::System.Windows.DependencyProperty.Register("MinRowHeight", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyCellsPresenterPropertyChanged)));

		// Token: 0x040000E7 RID: 231
		public static readonly global::System.Windows.DependencyProperty RowHeaderWidthProperty = global::System.Windows.DependencyProperty.Register("RowHeaderWidth", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowHeaderWidthPropertyChanged)));

		// Token: 0x040000E8 RID: 232
		private static readonly global::System.Windows.DependencyPropertyKey RowHeaderActualWidthPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("RowHeaderActualWidth", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowHeaderPropertyChanged)));

		// Token: 0x040000E9 RID: 233
		public static readonly global::System.Windows.DependencyProperty RowHeaderActualWidthProperty = global::Microsoft.Windows.Controls.DataGrid.RowHeaderActualWidthPropertyKey.DependencyProperty;

		// Token: 0x040000EA RID: 234
		public static readonly global::System.Windows.DependencyProperty ColumnHeaderHeightProperty = global::System.Windows.DependencyProperty.Register("ColumnHeaderHeight", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(double.NaN, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyColumnHeaderPropertyChanged)));

		// Token: 0x040000EB RID: 235
		public static readonly global::System.Windows.DependencyProperty HeadersVisibilityProperty = global::System.Windows.DependencyProperty.Register("HeadersVisibility", typeof(global::Microsoft.Windows.Controls.DataGridHeadersVisibility), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridHeadersVisibility.All));

		// Token: 0x040000EC RID: 236
		public static readonly global::System.Windows.DependencyProperty CellStyleProperty = global::System.Windows.DependencyProperty.Register("CellStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyColumnAndCellPropertyChanged)));

		// Token: 0x040000ED RID: 237
		public static readonly global::System.Windows.DependencyProperty ColumnHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("ColumnHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyColumnAndColumnHeaderPropertyChanged)));

		// Token: 0x040000EE RID: 238
		public static readonly global::System.Windows.DependencyProperty RowHeaderStyleProperty = global::System.Windows.DependencyProperty.Register("RowHeaderStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowAndRowHeaderPropertyChanged)));

		// Token: 0x040000EF RID: 239
		public static readonly global::System.Windows.DependencyProperty RowHeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("RowHeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowAndRowHeaderPropertyChanged)));

		// Token: 0x040000F0 RID: 240
		public static readonly global::System.Windows.DependencyProperty RowHeaderTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("RowHeaderTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowAndRowHeaderPropertyChanged)));

		// Token: 0x040000F1 RID: 241
		public static readonly global::System.Windows.DependencyProperty HorizontalScrollBarVisibilityProperty = global::System.Windows.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.ScrollBarVisibility.Auto));

		// Token: 0x040000F2 RID: 242
		public static readonly global::System.Windows.DependencyProperty VerticalScrollBarVisibilityProperty = global::System.Windows.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.ScrollBarVisibility.Auto));

		// Token: 0x040000F3 RID: 243
		internal static readonly global::System.Windows.DependencyProperty HorizontalScrollOffsetProperty = global::System.Windows.DependencyProperty.Register("HorizontalScrollOffset", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyHorizontalOffsetPropertyChanged)));

		// Token: 0x040000F4 RID: 244
		public static readonly global::System.Windows.Input.RoutedCommand BeginEditCommand = new global::System.Windows.Input.RoutedCommand("BeginEdit", typeof(global::Microsoft.Windows.Controls.DataGrid));

		// Token: 0x040000F5 RID: 245
		public static readonly global::System.Windows.Input.RoutedCommand CommitEditCommand = new global::System.Windows.Input.RoutedCommand("CommitEdit", typeof(global::Microsoft.Windows.Controls.DataGrid));

		// Token: 0x040000F6 RID: 246
		public static readonly global::System.Windows.Input.RoutedCommand CancelEditCommand = new global::System.Windows.Input.RoutedCommand("CancelEdit", typeof(global::Microsoft.Windows.Controls.DataGrid));

		// Token: 0x040000F9 RID: 249
		public static readonly global::System.Windows.DependencyProperty IsReadOnlyProperty = global::System.Windows.DependencyProperty.Register("IsReadOnly", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnIsReadOnlyChanged)));

		// Token: 0x040000FA RID: 250
		public static readonly global::System.Windows.DependencyProperty CurrentItemProperty = global::System.Windows.DependencyProperty.Register("CurrentItem", typeof(object), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnCurrentItemChanged)));

		// Token: 0x040000FB RID: 251
		public static readonly global::System.Windows.DependencyProperty CurrentColumnProperty = global::System.Windows.DependencyProperty.Register("CurrentColumn", typeof(global::Microsoft.Windows.Controls.DataGridColumn), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnCurrentColumnChanged)));

		// Token: 0x040000FC RID: 252
		public static readonly global::System.Windows.DependencyProperty CurrentCellProperty = global::System.Windows.DependencyProperty.Register("CurrentCell", typeof(global::Microsoft.Windows.Controls.DataGridCellInfo), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridCellInfo.Unset, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnCurrentCellChanged)));

		// Token: 0x04000100 RID: 256
		public static readonly global::System.Windows.DependencyProperty CanUserAddRowsProperty = global::System.Windows.DependencyProperty.Register("CanUserAddRows", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnCanUserAddRowsChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceCanUserAddRows)));

		// Token: 0x04000101 RID: 257
		public static readonly global::System.Windows.DependencyProperty CanUserDeleteRowsProperty = global::System.Windows.DependencyProperty.Register("CanUserDeleteRows", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnCanUserDeleteRowsChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceCanUserDeleteRows)));

		// Token: 0x04000103 RID: 259
		public static readonly global::System.Windows.DependencyProperty RowDetailsVisibilityModeProperty = global::System.Windows.DependencyProperty.Register("RowDetailsVisibilityMode", typeof(global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode.VisibleWhenSelected, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowAndDetailsPropertyChanged)));

		// Token: 0x04000104 RID: 260
		public static readonly global::System.Windows.DependencyProperty AreRowDetailsFrozenProperty = global::System.Windows.DependencyProperty.Register("AreRowDetailsFrozen", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(false));

		// Token: 0x04000105 RID: 261
		public static readonly global::System.Windows.DependencyProperty RowDetailsTemplateProperty = global::System.Windows.DependencyProperty.Register("RowDetailsTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowAndDetailsPropertyChanged)));

		// Token: 0x04000106 RID: 262
		public static readonly global::System.Windows.DependencyProperty RowDetailsTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("RowDetailsTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowAndDetailsPropertyChanged)));

		// Token: 0x0400010A RID: 266
		public static readonly global::System.Windows.DependencyProperty CanUserResizeRowsProperty = global::System.Windows.DependencyProperty.Register("CanUserResizeRows", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyRowHeaderPropertyChanged)));

		// Token: 0x0400010C RID: 268
		public static readonly global::System.Windows.DependencyProperty SelectionModeProperty = global::System.Windows.DependencyProperty.Register("SelectionMode", typeof(global::Microsoft.Windows.Controls.DataGridSelectionMode), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridSelectionMode.Extended, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnSelectionModeChanged)));

		// Token: 0x0400010D RID: 269
		public static readonly global::System.Windows.DependencyProperty SelectionUnitProperty = global::System.Windows.DependencyProperty.Register("SelectionUnit", typeof(global::Microsoft.Windows.Controls.DataGridSelectionUnit), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnSelectionUnitChanged)));

		// Token: 0x0400010E RID: 270
		public static readonly global::System.Windows.DependencyProperty CanUserSortColumnsProperty = global::System.Windows.DependencyProperty.Register("CanUserSortColumns", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnCanUserSortColumnsPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceCanUserSortColumns)));

		// Token: 0x04000112 RID: 274
		public static readonly global::System.Windows.DependencyProperty AutoGenerateColumnsProperty = global::System.Windows.DependencyProperty.Register("AutoGenerateColumns", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnAutoGenerateColumnsPropertyChanged)));

		// Token: 0x04000113 RID: 275
		public static readonly global::System.Windows.DependencyProperty FrozenColumnCountProperty = global::System.Windows.DependencyProperty.Register("FrozenColumnCount", typeof(int), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnFrozenColumnCountPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGrid.OnCoerceFrozenColumnCount)), new global::System.Windows.ValidateValueCallback(global::Microsoft.Windows.Controls.DataGrid.ValidateFrozenColumnCount));

		// Token: 0x04000114 RID: 276
		private static readonly global::System.Windows.DependencyPropertyKey NonFrozenColumnsViewportHorizontalOffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("NonFrozenColumnsViewportHorizontalOffset", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(0.0));

		// Token: 0x04000115 RID: 277
		public static readonly global::System.Windows.DependencyProperty NonFrozenColumnsViewportHorizontalOffsetProperty = global::Microsoft.Windows.Controls.DataGrid.NonFrozenColumnsViewportHorizontalOffsetPropertyKey.DependencyProperty;

		// Token: 0x04000116 RID: 278
		public static readonly global::System.Windows.DependencyProperty EnableRowVirtualizationProperty = global::System.Windows.DependencyProperty.Register("EnableRowVirtualization", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnEnableRowVirtualizationChanged)));

		// Token: 0x04000117 RID: 279
		public static readonly global::System.Windows.DependencyProperty EnableColumnVirtualizationProperty = global::System.Windows.DependencyProperty.Register("EnableColumnVirtualization", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnEnableColumnVirtualizationChanged)));

		// Token: 0x04000118 RID: 280
		public static readonly global::System.Windows.DependencyProperty CanUserReorderColumnsProperty = global::System.Windows.DependencyProperty.Register("CanUserReorderColumns", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyColumnPropertyChanged)));

		// Token: 0x04000119 RID: 281
		public static readonly global::System.Windows.DependencyProperty DragIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("DragIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyColumnPropertyChanged)));

		// Token: 0x0400011A RID: 282
		public static readonly global::System.Windows.DependencyProperty DropLocationIndicatorStyleProperty = global::System.Windows.DependencyProperty.Register("DropLocationIndicatorStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x04000120 RID: 288
		public static readonly global::System.Windows.DependencyProperty ClipboardCopyModeProperty = global::System.Windows.DependencyProperty.Register("ClipboardCopyMode", typeof(global::Microsoft.Windows.Controls.DataGridClipboardCopyMode), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DataGridClipboardCopyMode.ExcludeHeader, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnClipboardCopyModeChanged)));

		// Token: 0x04000122 RID: 290
		internal static readonly global::System.Windows.DependencyProperty CellsPanelActualWidthProperty = global::System.Windows.DependencyProperty.Register("CellsPanelActualWidth", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.CellsPanelActualWidthChanged)));

		// Token: 0x04000123 RID: 291
		private static readonly global::System.Windows.DependencyPropertyKey CellsPanelHorizontalOffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("CellsPanelHorizontalOffset", typeof(double), typeof(global::Microsoft.Windows.Controls.DataGrid), new global::System.Windows.FrameworkPropertyMetadata(0.0, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGrid.OnNotifyHorizontalOffsetPropertyChanged)));

		// Token: 0x04000124 RID: 292
		public static readonly global::System.Windows.DependencyProperty CellsPanelHorizontalOffsetProperty = global::Microsoft.Windows.Controls.DataGrid.CellsPanelHorizontalOffsetPropertyKey.DependencyProperty;

		// Token: 0x04000125 RID: 293
		private static global::System.Windows.ComponentResourceKey _focusBorderBrushKey;

		// Token: 0x04000126 RID: 294
		private static global::System.Windows.Data.IValueConverter _headersVisibilityConverter;

		// Token: 0x04000127 RID: 295
		private static global::System.Windows.Data.IValueConverter _rowDetailsScrollingConverter;

		// Token: 0x04000128 RID: 296
		private static object _newItemPlaceholder = new object();

		// Token: 0x04000129 RID: 297
		private global::Microsoft.Windows.Controls.DataGridColumnCollection _columns;

		// Token: 0x0400012A RID: 298
		private global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow> _rowTrackingRoot;

		// Token: 0x0400012B RID: 299
		private global::Microsoft.Windows.Controls.Primitives.DataGridColumnHeadersPresenter _columnHeadersPresenter;

		// Token: 0x0400012C RID: 300
		private global::Microsoft.Windows.Controls.DataGridCell _currentCellContainer;

		// Token: 0x0400012D RID: 301
		private global::Microsoft.Windows.Controls.DataGridCell _pendingCurrentCellContainer;

		// Token: 0x0400012E RID: 302
		private global::Microsoft.Windows.Controls.SelectedCellsCollection _selectedCells;

		// Token: 0x0400012F RID: 303
		private global::Microsoft.Windows.Controls.DataGridCellInfo? _selectionAnchor;

		// Token: 0x04000130 RID: 304
		private bool _isDraggingSelection;

		// Token: 0x04000131 RID: 305
		private bool _isRowDragging;

		// Token: 0x04000132 RID: 306
		private global::System.Windows.Controls.Panel _internalItemsHost;

		// Token: 0x04000133 RID: 307
		private global::System.Windows.Controls.ScrollViewer _internalScrollHost;

		// Token: 0x04000134 RID: 308
		private global::System.Windows.Controls.ScrollContentPresenter _internalScrollContentPresenter;

		// Token: 0x04000135 RID: 309
		private global::System.Windows.Threading.DispatcherTimer _autoScrollTimer;

		// Token: 0x04000136 RID: 310
		private bool _hasAutoScrolled;

		// Token: 0x04000137 RID: 311
		private global::Microsoft.Windows.Controls.VirtualizedCellInfoCollection _pendingSelectedCells;

		// Token: 0x04000138 RID: 312
		private global::Microsoft.Windows.Controls.VirtualizedCellInfoCollection _pendingUnselectedCells;

		// Token: 0x04000139 RID: 313
		private bool _measureNeverInvoked = true;

		// Token: 0x0400013A RID: 314
		private bool _updatingSelectedCells;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Visibility _placeholderVisibility = global::System.Windows.Visibility.Collapsed;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Point _dragPoint;

		// Token: 0x0400013D RID: 317
		private global::System.Collections.Generic.List<int> _groupingSortDescriptionIndices;

		// Token: 0x0400013E RID: 318
		private bool _ignoreSortDescriptionsChange;

		// Token: 0x0400013F RID: 319
		private bool _sortingStarted;

		// Token: 0x04000140 RID: 320
		private global::System.Collections.ObjectModel.ObservableCollection<global::System.Windows.Controls.ValidationRule> _rowValidationRules;

		// Token: 0x04000141 RID: 321
		private global::System.Windows.Data.BindingGroup _rowValidationBindingGroup;

		// Token: 0x04000142 RID: 322
		private object _editingRowItem;

		// Token: 0x04000143 RID: 323
		private int _editingRowIndex = -1;

		// Token: 0x04000144 RID: 324
		private bool _hasCellValidationError;

		// Token: 0x04000145 RID: 325
		private bool _hasRowValidationError;

		// Token: 0x04000146 RID: 326
		private global::System.Collections.IEnumerable _cachedItemsSource;

		// Token: 0x04000147 RID: 327
		private global::Microsoft.Windows.Controls.DataGridItemAttachedStorage _itemAttachedStorage = new global::Microsoft.Windows.Controls.DataGridItemAttachedStorage();

		// Token: 0x04000148 RID: 328
		private bool _viewportWidthChangeNotificationPending;

		// Token: 0x04000149 RID: 329
		private double _originalViewportWidth;

		// Token: 0x0400014A RID: 330
		private double _finalViewportWidth;

		// Token: 0x0400014B RID: 331
		private global::Microsoft.Windows.Controls.DataGridCell _focusedCell;

		// Token: 0x02000039 RID: 57
		private class ChangingSelectedCellsHelper : global::System.IDisposable
		{
			// Token: 0x060004C3 RID: 1219 RVA: 0x00012F54 File Offset: 0x00011154
			internal ChangingSelectedCellsHelper(global::Microsoft.Windows.Controls.DataGrid dataGrid)
			{
				this._dataGrid = dataGrid;
				this._wasUpdatingSelectedCells = this._dataGrid.IsUpdatingSelectedCells;
				if (!this._wasUpdatingSelectedCells)
				{
					this._dataGrid.BeginUpdateSelectedCells();
				}
			}

			// Token: 0x060004C4 RID: 1220 RVA: 0x00012F87 File Offset: 0x00011187
			public void Dispose()
			{
				global::System.GC.SuppressFinalize(this);
				if (!this._wasUpdatingSelectedCells)
				{
					this._dataGrid.EndUpdateSelectedCells();
				}
			}

			// Token: 0x0400014E RID: 334
			private global::Microsoft.Windows.Controls.DataGrid _dataGrid;

			// Token: 0x0400014F RID: 335
			private bool _wasUpdatingSelectedCells;
		}

		// Token: 0x0200003A RID: 58
		[global::System.Flags]
		private enum RelativeMousePositions
		{
			// Token: 0x04000151 RID: 337
			Over = 0,
			// Token: 0x04000152 RID: 338
			Above = 1,
			// Token: 0x04000153 RID: 339
			Below = 2,
			// Token: 0x04000154 RID: 340
			Left = 4,
			// Token: 0x04000155 RID: 341
			Right = 8
		}
	}
}
