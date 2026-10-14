using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Threading;
using Microsoft.Windows.Automation.Peers;
using Microsoft.Windows.Controls.Primitives;
using MS.Internal;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000084 RID: 132
	public class DataGridRow : global::System.Windows.Controls.Control
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x00028F98 File Offset: 0x00027198
		static DataGridRow()
		{
			global::Microsoft.Windows.Controls.DataGridRow.SelectedEvent = global::System.Windows.Controls.Primitives.Selector.SelectedEvent.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridRow));
			global::Microsoft.Windows.Controls.DataGridRow.UnselectedEvent = global::System.Windows.Controls.Primitives.Selector.UnselectedEvent.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridRow));
			global::Microsoft.Windows.Controls.DataGridRow.IsEditingPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsEditing", typeof(bool), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::Microsoft.Windows.Controls.DataGridRow.IsEditingProperty = global::Microsoft.Windows.Controls.DataGridRow.IsEditingPropertyKey.DependencyProperty;
			global::System.Windows.UIElement.VisibilityProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceVisibility)));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.DataGridRow)));
			global::Microsoft.Windows.Controls.DataGridRow.ItemsPanelProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.Controls.ItemsPanelTemplate(new global::System.Windows.FrameworkElementFactory(typeof(global::Microsoft.Windows.Controls.DataGridCellsPanel)))));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.Controls.Control.BackgroundProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyRowPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceBackground)));
			global::System.Windows.FrameworkElement.BindingGroupProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyRowPropertyChanged)));
			global::System.Windows.UIElement.SnapsToDevicePixelsProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(true, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsArrange));
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000293BD File Offset: 0x000275BD
		public DataGridRow()
		{
			this._tracker = new global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow>(this);
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x000293D1 File Offset: 0x000275D1
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x000293DE File Offset: 0x000275DE
		public object Item
		{
			get
			{
				return base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.ItemProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.ItemProperty, value);
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000293EC File Offset: 0x000275EC
		protected virtual void OnItemChanged(object oldItem, object newItem)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				cellsPresenter.Item = newItem;
			}
			global::Microsoft.Windows.Automation.Peers.DataGridRowAutomationPeer dataGridRowAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Microsoft.Windows.Automation.Peers.DataGridRowAutomationPeer;
			if (dataGridRowAutomationPeer != null)
			{
				dataGridRowAutomationPeer.UpdateEventSource();
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x0002941F File Offset: 0x0002761F
		// (set) Token: 0x06000935 RID: 2357 RVA: 0x00029431 File Offset: 0x00027631
		public global::System.Windows.Controls.ItemsPanelTemplate ItemsPanel
		{
			get
			{
				return (global::System.Windows.Controls.ItemsPanelTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.ItemsPanelProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.ItemsPanelProperty, value);
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0002943F File Offset: 0x0002763F
		protected override void OnTemplateChanged(global::System.Windows.Controls.ControlTemplate oldTemplate, global::System.Windows.Controls.ControlTemplate newTemplate)
		{
			base.OnTemplateChanged(oldTemplate, newTemplate);
			this.CellsPresenter = null;
			this.DetailsPresenter = null;
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00029457 File Offset: 0x00027657
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x00029464 File Offset: 0x00027664
		public object Header
		{
			get
			{
				return base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.HeaderProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.HeaderProperty, value);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00029472 File Offset: 0x00027672
		protected virtual void OnHeaderChanged(object oldHeader, object newHeader)
		{
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x00029474 File Offset: 0x00027674
		// (set) Token: 0x0600093B RID: 2363 RVA: 0x00029486 File Offset: 0x00027686
		public global::System.Windows.Style HeaderStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.HeaderStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.HeaderStyleProperty, value);
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x0600093C RID: 2364 RVA: 0x00029494 File Offset: 0x00027694
		// (set) Token: 0x0600093D RID: 2365 RVA: 0x000294A6 File Offset: 0x000276A6
		public global::System.Windows.DataTemplate HeaderTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateProperty, value);
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x0600093E RID: 2366 RVA: 0x000294B4 File Offset: 0x000276B4
		// (set) Token: 0x0600093F RID: 2367 RVA: 0x000294C6 File Offset: 0x000276C6
		public global::System.Windows.Controls.DataTemplateSelector HeaderTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty, value);
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000940 RID: 2368 RVA: 0x000294D4 File Offset: 0x000276D4
		// (set) Token: 0x06000941 RID: 2369 RVA: 0x000294E6 File Offset: 0x000276E6
		public global::System.Windows.Controls.ControlTemplate ValidationErrorTemplate
		{
			get
			{
				return (global::System.Windows.Controls.ControlTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty, value);
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x000294F4 File Offset: 0x000276F4
		// (set) Token: 0x06000943 RID: 2371 RVA: 0x00029506 File Offset: 0x00027706
		public global::System.Windows.DataTemplate DetailsTemplate
		{
			get
			{
				return (global::System.Windows.DataTemplate)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateProperty, value);
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x00029514 File Offset: 0x00027714
		// (set) Token: 0x06000945 RID: 2373 RVA: 0x00029526 File Offset: 0x00027726
		public global::System.Windows.Controls.DataTemplateSelector DetailsTemplateSelector
		{
			get
			{
				return (global::System.Windows.Controls.DataTemplateSelector)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty, value);
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x00029534 File Offset: 0x00027734
		// (set) Token: 0x06000947 RID: 2375 RVA: 0x00029546 File Offset: 0x00027746
		public global::System.Windows.Visibility DetailsVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty, value);
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00029559 File Offset: 0x00027759
		// (set) Token: 0x06000949 RID: 2377 RVA: 0x00029561 File Offset: 0x00027761
		internal bool DetailsLoaded
		{
			get
			{
				return this._detailsLoaded;
			}
			set
			{
				this._detailsLoaded = value;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0002956A File Offset: 0x0002776A
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::Microsoft.Windows.Controls.DataGridRow.AlternationIndexProperty)
			{
				this.NotifyPropertyChanged(this, e, global::Microsoft.Windows.Controls.NotificationTarget.Rows);
			}
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00029590 File Offset: 0x00027790
		internal void PrepareRow(object item, global::Microsoft.Windows.Controls.DataGrid owningDataGrid)
		{
			bool flag = this._owner != owningDataGrid;
			bool forcePrepareCells = false;
			this._owner = owningDataGrid;
			if (this != item)
			{
				if (this.Item != item)
				{
					this.Item = item;
				}
				else
				{
					forcePrepareCells = true;
				}
			}
			if (this.IsEditing)
			{
				this.IsEditing = false;
			}
			if (flag)
			{
				this.SyncProperties(forcePrepareCells);
			}
			base.Dispatcher.BeginInvoke(new global::System.Windows.Threading.DispatcherOperationCallback(this.DelayedValidateWithoutUpdate), global::System.Windows.Threading.DispatcherPriority.DataBind, new object[]
			{
				base.BindingGroup
			});
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00029610 File Offset: 0x00027810
		internal void ClearRow(global::Microsoft.Windows.Controls.DataGrid owningDataGrid)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				this.PersistAttachedItemValue(cellsPresenter, global::System.Windows.FrameworkElement.HeightProperty);
			}
			this.PersistAttachedItemValue(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
			this._owner = null;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00029648 File Offset: 0x00027848
		private void PersistAttachedItemValue(global::System.Windows.DependencyObject objectWithProperty, global::System.Windows.DependencyProperty property)
		{
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(objectWithProperty, property).BaseValueSource == global::System.Windows.BaseValueSource.Local)
			{
				this._owner.ItemAttachedStorage.SetValue(this.Item, property, objectWithProperty.GetValue(property));
				objectWithProperty.ClearValue(property);
			}
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00029690 File Offset: 0x00027890
		private void RestoreAttachedItemValue(global::System.Windows.DependencyObject objectWithProperty, global::System.Windows.DependencyProperty property)
		{
			object value;
			if (this._owner.ItemAttachedStorage.TryGetValue(this.Item, property, out value))
			{
				objectWithProperty.SetValue(property, value);
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x0600094F RID: 2383 RVA: 0x000296C0 File Offset: 0x000278C0
		internal global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow> Tracker
		{
			get
			{
				return this._tracker;
			}
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000296C8 File Offset: 0x000278C8
		internal void OnRowResizeStarted()
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				this._cellsPresenterResizeHeight = cellsPresenter.Height;
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000296EC File Offset: 0x000278EC
		internal void OnRowResize(double changeAmount)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				double num = cellsPresenter.ActualHeight + changeAmount;
				double num2 = global::System.Math.Max(this.RowHeader.DesiredSize.Height, base.MinHeight);
				if (global::MS.Internal.DoubleUtil.LessThan(num, num2))
				{
					num = num2;
				}
				double maxHeight = base.MaxHeight;
				if (global::MS.Internal.DoubleUtil.GreaterThan(num, maxHeight))
				{
					num = maxHeight;
				}
				cellsPresenter.Height = num;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00029750 File Offset: 0x00027950
		internal void OnRowResizeCompleted(bool canceled)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null && canceled)
			{
				cellsPresenter.Height = this._cellsPresenterResizeHeight;
			}
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00029778 File Offset: 0x00027978
		internal void OnRowResizeReset()
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				cellsPresenter.ClearValue(global::System.Windows.FrameworkElement.HeightProperty);
				if (this._owner != null)
				{
					this._owner.ItemAttachedStorage.ClearValue(this.Item, global::System.Windows.FrameworkElement.HeightProperty);
				}
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000297C0 File Offset: 0x000279C0
		protected internal virtual void OnColumnsChanged(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn> columns, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				cellsPresenter.OnColumnsChanged(columns, e);
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000297E0 File Offset: 0x000279E0
		private static object OnCoerceHeaderStyle(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::Microsoft.Windows.Controls.DataGridRow.HeaderStyleProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowHeaderStyleProperty);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0002980C File Offset: 0x00027A0C
		private static object OnCoerceHeaderTemplate(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateProperty);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00029838 File Offset: 0x00027A38
		private static object OnCoerceHeaderTemplateSelector(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00029864 File Offset: 0x00027A64
		private static object OnCoerceBackground(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			object result = baseValue;
			switch (dataGridRow.AlternationIndex)
			{
			case 0:
				result = global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::System.Windows.Controls.Control.BackgroundProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowBackgroundProperty);
				break;
			case 1:
				result = global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::System.Windows.Controls.Control.BackgroundProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty);
				break;
			}
			return result;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000298C4 File Offset: 0x00027AC4
		private static object OnCoerceValidationErrorTemplate(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::Microsoft.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowValidationErrorTemplateProperty);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x000298F0 File Offset: 0x00027AF0
		private static object OnCoerceDetailsTemplate(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateProperty);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x0002991C File Offset: 0x00027B1C
		private static object OnCoerceDetailsTemplateSelector(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			return global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00029948 File Offset: 0x00027B48
		private static object OnCoerceDetailsVisibility(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			object obj = global::Microsoft.Windows.Controls.DataGridHelper.GetCoercedTransferPropertyValue(dataGridRow, baseValue, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty, dataGridRow.DataGridOwner, global::Microsoft.Windows.Controls.DataGrid.RowDetailsVisibilityModeProperty);
			if (obj is global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode)
			{
				global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode dataGridRowDetailsVisibilityMode = (global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode)obj;
				bool flag = dataGridRow.DetailsTemplate != null || dataGridRow.DetailsTemplateSelector != null;
				bool flag2 = dataGridRow.Item != global::System.Windows.Data.CollectionView.NewItemPlaceholder;
				switch (dataGridRowDetailsVisibilityMode)
				{
				case global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode.Collapsed:
					obj = global::System.Windows.Visibility.Collapsed;
					break;
				case global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode.Visible:
					obj = ((flag && flag2) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
					break;
				case global::Microsoft.Windows.Controls.DataGridRowDetailsVisibilityMode.VisibleWhenSelected:
					obj = ((dataGridRow.IsSelected && flag && flag2) ? global::System.Windows.Visibility.Visible : global::System.Windows.Visibility.Collapsed);
					break;
				default:
					obj = global::System.Windows.Visibility.Collapsed;
					break;
				}
			}
			return obj;
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00029A08 File Offset: 0x00027C08
		private static object OnCoerceVisibility(global::System.Windows.DependencyObject d, object baseValue)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridRow.DataGridOwner;
			if (dataGridRow.Item == global::System.Windows.Data.CollectionView.NewItemPlaceholder && dataGridOwner != null)
			{
				return dataGridOwner.PlaceholderVisibility;
			}
			return baseValue;
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00029A40 File Offset: 0x00027C40
		private static void OnNotifyRowPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(d as global::Microsoft.Windows.Controls.DataGridRow).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Rows);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00029A54 File Offset: 0x00027C54
		private static void OnNotifyRowAndRowHeaderPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(d as global::Microsoft.Windows.Controls.DataGridRow).NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.RowHeaders | global::Microsoft.Windows.Controls.NotificationTarget.Rows);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00029A68 File Offset: 0x00027C68
		private static void OnNotifyDetailsTemplatePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			dataGridRow.NotifyPropertyChanged(dataGridRow, e, global::Microsoft.Windows.Controls.NotificationTarget.DetailsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.Rows);
			if (dataGridRow.DetailsLoaded && d.GetValue(e.Property) == e.NewValue)
			{
				if (dataGridRow.DataGridOwner != null)
				{
					dataGridRow.DataGridOwner.OnUnloadingRowDetailsWrapper(dataGridRow);
				}
				if (e.NewValue != null)
				{
					global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Windows.Threading.DispatcherOperationCallback(global::Microsoft.Windows.Controls.DataGrid.DelayedOnLoadingRowDetails), global::System.Windows.Threading.DispatcherPriority.Loaded, new object[]
					{
						dataGridRow
					});
				}
			}
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00029AE8 File Offset: 0x00027CE8
		private static void OnNotifyDetailsVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)d;
			global::System.Windows.Threading.Dispatcher.CurrentDispatcher.BeginInvoke(new global::System.Windows.Threading.DispatcherOperationCallback(global::Microsoft.Windows.Controls.DataGridRow.DelayedRowDetailsVisibilityChanged), global::System.Windows.Threading.DispatcherPriority.Loaded, new object[]
			{
				dataGridRow
			});
			dataGridRow.NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.DetailsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.Rows);
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00029B30 File Offset: 0x00027D30
		private static object DelayedRowDetailsVisibilityChanged(object arg)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)arg;
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridRow.DataGridOwner;
			global::System.Windows.FrameworkElement detailsElement = (dataGridRow.DetailsPresenter != null) ? dataGridRow.DetailsPresenter.DetailsElement : null;
			if (dataGridOwner != null)
			{
				global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs e = new global::Microsoft.Windows.Controls.DataGridRowDetailsEventArgs(dataGridRow, detailsElement);
				dataGridOwner.OnRowDetailsVisibilityChanged(e);
			}
			return null;
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00029B75 File Offset: 0x00027D75
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x00029B7D File Offset: 0x00027D7D
		internal global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter CellsPresenter
		{
			get
			{
				return this._cellsPresenter;
			}
			set
			{
				this._cellsPresenter = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00029B86 File Offset: 0x00027D86
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00029B8E File Offset: 0x00027D8E
		internal global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter DetailsPresenter
		{
			get
			{
				return this._detailsPresenter;
			}
			set
			{
				this._detailsPresenter = value;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00029B97 File Offset: 0x00027D97
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00029B9F File Offset: 0x00027D9F
		internal global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader RowHeader
		{
			get
			{
				return this._rowHeader;
			}
			set
			{
				this._rowHeader = value;
			}
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00029BA8 File Offset: 0x00027DA8
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			this.NotifyPropertyChanged(d, string.Empty, e, target);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00029BB8 File Offset: 0x00027DB8
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, string propertyName, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyRows(target))
			{
				if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowBackgroundProperty || e.Property == global::Microsoft.Windows.Controls.DataGrid.AlternatingRowBackgroundProperty || e.Property == global::System.Windows.Controls.Control.BackgroundProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.AlternationIndexProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.Control.BackgroundProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowHeaderStyleProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.HeaderStyleProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.HeaderStyleProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowHeaderTemplateSelectorProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowValidationErrorTemplateProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateProperty);
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowDetailsTemplateSelectorProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty);
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.RowDetailsVisibilityModeProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty || e.Property == global::Microsoft.Windows.Controls.DataGridRow.IsSelectedProperty)
				{
					global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGridRow.ItemProperty)
				{
					this.OnItemChanged(e.OldValue, e.NewValue);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGridRow.HeaderProperty)
				{
					this.OnHeaderChanged(e.OldValue, e.NewValue);
				}
				else if (e.Property == global::System.Windows.FrameworkElement.BindingGroupProperty)
				{
					base.Dispatcher.BeginInvoke(new global::System.Windows.Threading.DispatcherOperationCallback(this.DelayedValidateWithoutUpdate), global::System.Windows.Threading.DispatcherPriority.DataBind, new object[]
					{
						e.NewValue
					});
				}
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyDetailsPresenter(target) && this.DetailsPresenter != null)
			{
				this.DetailsPresenter.NotifyPropertyChanged(d, e);
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyCellsPresenter(target) || global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyCells(target) || global::Microsoft.Windows.Controls.DataGridHelper.ShouldRefreshCellContent(target))
			{
				global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
				if (cellsPresenter != null)
				{
					cellsPresenter.NotifyPropertyChanged(d, propertyName, e, target);
				}
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyRowHeaders(target) && this.RowHeader != null)
			{
				this.RowHeader.NotifyPropertyChanged(d, e);
			}
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00029E60 File Offset: 0x00028060
		private object DelayedValidateWithoutUpdate(object arg)
		{
			global::System.Windows.Data.BindingGroup bindingGroup = (global::System.Windows.Data.BindingGroup)arg;
			if (bindingGroup != null && bindingGroup.Items.Count > 0)
			{
				bindingGroup.ValidateWithoutUpdate();
			}
			return null;
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x00029E90 File Offset: 0x00028090
		private void SyncProperties(bool forcePrepareCells)
		{
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::System.Windows.Controls.Control.BackgroundProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.HeaderStyleProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.HeaderTemplateSelectorProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.ValidationErrorTemplateProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsTemplateSelectorProperty);
			global::Microsoft.Windows.Controls.DataGridHelper.TransferProperty(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
			base.CoerceValue(global::System.Windows.UIElement.VisibilityProperty);
			this.RestoreAttachedItemValue(this, global::Microsoft.Windows.Controls.DataGridRow.DetailsVisibilityProperty);
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				cellsPresenter.SyncProperties(forcePrepareCells);
				this.RestoreAttachedItemValue(cellsPresenter, global::System.Windows.FrameworkElement.HeightProperty);
			}
			if (this.DetailsPresenter != null)
			{
				this.DetailsPresenter.SyncProperties();
			}
			if (this.RowHeader != null)
			{
				this.RowHeader.SyncProperties();
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00029F4F File Offset: 0x0002814F
		public int AlternationIndex
		{
			get
			{
				return (int)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.AlternationIndexProperty);
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00029F61 File Offset: 0x00028161
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x00029F73 File Offset: 0x00028173
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Category("Appearance")]
		public bool IsSelected
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.IsSelectedProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.IsSelectedProperty, value);
			}
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00029F88 File Offset: 0x00028188
		private static void OnIsSelectedChanged(object sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.DataGridRow dataGridRow = (global::Microsoft.Windows.Controls.DataGridRow)sender;
			bool flag = (bool)e.NewValue;
			if (flag && !dataGridRow.IsSelectable)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGridRow_CannotSelectRowWhenCells));
			}
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = dataGridRow.DataGridOwner;
			if (dataGridOwner != null && dataGridRow.DataContext != null)
			{
				global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer dataGridAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(dataGridOwner) as global::Microsoft.Windows.Automation.Peers.DataGridAutomationPeer;
				if (dataGridAutomationPeer != null)
				{
					global::Microsoft.Windows.Automation.Peers.DataGridItemAutomationPeer orCreateItemPeer = dataGridAutomationPeer.GetOrCreateItemPeer(dataGridRow.DataContext);
					if (orCreateItemPeer != null)
					{
						orCreateItemPeer.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionItemPatternIdentifiers.IsSelectedProperty, (bool)e.OldValue, flag);
					}
				}
			}
			dataGridRow.NotifyPropertyChanged(dataGridRow, e, global::Microsoft.Windows.Controls.NotificationTarget.RowHeaders | global::Microsoft.Windows.Controls.NotificationTarget.Rows);
			dataGridRow.RaiseSelectionChangedEvent(flag);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0002A02E File Offset: 0x0002822E
		private void RaiseSelectionChangedEvent(bool isSelected)
		{
			if (isSelected)
			{
				this.OnSelected(new global::System.Windows.RoutedEventArgs(global::Microsoft.Windows.Controls.DataGridRow.SelectedEvent, this));
				return;
			}
			this.OnUnselected(new global::System.Windows.RoutedEventArgs(global::Microsoft.Windows.Controls.DataGridRow.UnselectedEvent, this));
		}

		// Token: 0x1400002B RID: 43
		// (add) Token: 0x06000972 RID: 2418 RVA: 0x0002A056 File Offset: 0x00028256
		// (remove) Token: 0x06000973 RID: 2419 RVA: 0x0002A064 File Offset: 0x00028264
		public event global::System.Windows.RoutedEventHandler Selected
		{
			add
			{
				base.AddHandler(global::Microsoft.Windows.Controls.DataGridRow.SelectedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Microsoft.Windows.Controls.DataGridRow.SelectedEvent, value);
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x0002A072 File Offset: 0x00028272
		protected virtual void OnSelected(global::System.Windows.RoutedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x1400002C RID: 44
		// (add) Token: 0x06000975 RID: 2421 RVA: 0x0002A07B File Offset: 0x0002827B
		// (remove) Token: 0x06000976 RID: 2422 RVA: 0x0002A089 File Offset: 0x00028289
		public event global::System.Windows.RoutedEventHandler Unselected
		{
			add
			{
				base.AddHandler(global::Microsoft.Windows.Controls.DataGridRow.UnselectedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Microsoft.Windows.Controls.DataGridRow.UnselectedEvent, value);
			}
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x0002A097 File Offset: 0x00028297
		protected virtual void OnUnselected(global::System.Windows.RoutedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0002A0A0 File Offset: 0x000282A0
		private bool IsSelectable
		{
			get
			{
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
				if (dataGridOwner != null)
				{
					global::Microsoft.Windows.Controls.DataGridSelectionUnit selectionUnit = dataGridOwner.SelectionUnit;
					return selectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.FullRow || selectionUnit == global::Microsoft.Windows.Controls.DataGridSelectionUnit.CellOrRowHeader;
				}
				return true;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000979 RID: 2425 RVA: 0x0002A0CA File Offset: 0x000282CA
		// (set) Token: 0x0600097A RID: 2426 RVA: 0x0002A0DC File Offset: 0x000282DC
		public bool IsEditing
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.DataGridRow.IsEditingProperty);
			}
			internal set
			{
				base.SetValue(global::Microsoft.Windows.Controls.DataGridRow.IsEditingPropertyKey, value);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0002A0EF File Offset: 0x000282EF
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.DataGridRowAutomationPeer(this);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0002A0F8 File Offset: 0x000282F8
		internal void ScrollCellIntoView(int index)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				cellsPresenter.ScrollCellIntoView(index);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0002A118 File Offset: 0x00028318
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size arrangeBounds)
		{
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
			if (dataGridOwner != null)
			{
				dataGridOwner.QueueInvalidateCellsPanelHorizontalOffset();
			}
			return base.ArrangeOverride(arrangeBounds);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0002A13C File Offset: 0x0002833C
		public int GetIndex()
		{
			global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
			if (dataGridOwner != null)
			{
				return dataGridOwner.ItemContainerGenerator.IndexFromContainer(this);
			}
			return -1;
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0002A161 File Offset: 0x00028361
		public static global::Microsoft.Windows.Controls.DataGridRow GetRowContainingElement(global::System.Windows.FrameworkElement element)
		{
			return global::Microsoft.Windows.Controls.DataGridHelper.FindVisualParent<global::Microsoft.Windows.Controls.DataGridRow>(element);
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x0002A169 File Offset: 0x00028369
		internal global::Microsoft.Windows.Controls.DataGrid DataGridOwner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0002A171 File Offset: 0x00028371
		internal bool DetailsPresenterDrawsGridLines
		{
			get
			{
				return this._detailsPresenter != null && this._detailsPresenter.Visibility == global::System.Windows.Visibility.Visible;
			}
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0002A18C File Offset: 0x0002838C
		internal global::Microsoft.Windows.Controls.DataGridCell TryGetCell(int index)
		{
			global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter cellsPresenter = this.CellsPresenter;
			if (cellsPresenter != null)
			{
				return cellsPresenter.ItemContainerGenerator.ContainerFromIndex(index) as global::Microsoft.Windows.Controls.DataGridCell;
			}
			return null;
		}

		// Token: 0x040002CD RID: 717
		public static readonly global::System.Windows.DependencyProperty ItemProperty = global::System.Windows.DependencyProperty.Register("Item", typeof(object), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyRowPropertyChanged)));

		// Token: 0x040002CE RID: 718
		public static readonly global::System.Windows.DependencyProperty ItemsPanelProperty = global::System.Windows.Controls.ItemsControl.ItemsPanelProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridRow));

		// Token: 0x040002CF RID: 719
		public static readonly global::System.Windows.DependencyProperty HeaderProperty = global::System.Windows.DependencyProperty.Register("Header", typeof(object), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyRowPropertyChanged)));

		// Token: 0x040002D0 RID: 720
		public static readonly global::System.Windows.DependencyProperty HeaderStyleProperty = global::System.Windows.DependencyProperty.Register("HeaderStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyRowAndRowHeaderPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceHeaderStyle)));

		// Token: 0x040002D1 RID: 721
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyRowAndRowHeaderPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceHeaderTemplate)));

		// Token: 0x040002D2 RID: 722
		public static readonly global::System.Windows.DependencyProperty HeaderTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("HeaderTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyRowAndRowHeaderPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceHeaderTemplateSelector)));

		// Token: 0x040002D3 RID: 723
		public static readonly global::System.Windows.DependencyProperty ValidationErrorTemplateProperty = global::System.Windows.DependencyProperty.Register("ValidationErrorTemplate", typeof(global::System.Windows.Controls.ControlTemplate), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyRowPropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceValidationErrorTemplate)));

		// Token: 0x040002D4 RID: 724
		public static readonly global::System.Windows.DependencyProperty DetailsTemplateProperty = global::System.Windows.DependencyProperty.Register("DetailsTemplate", typeof(global::System.Windows.DataTemplate), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyDetailsTemplatePropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceDetailsTemplate)));

		// Token: 0x040002D5 RID: 725
		public static readonly global::System.Windows.DependencyProperty DetailsTemplateSelectorProperty = global::System.Windows.DependencyProperty.Register("DetailsTemplateSelector", typeof(global::System.Windows.Controls.DataTemplateSelector), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyDetailsTemplatePropertyChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceDetailsTemplateSelector)));

		// Token: 0x040002D6 RID: 726
		public static readonly global::System.Windows.DependencyProperty DetailsVisibilityProperty = global::System.Windows.DependencyProperty.Register("DetailsVisibility", typeof(global::System.Windows.Visibility), typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Visibility.Collapsed, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnNotifyDetailsVisibilityChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.DataGridRow.OnCoerceDetailsVisibility)));

		// Token: 0x040002D7 RID: 727
		public static readonly global::System.Windows.DependencyProperty AlternationIndexProperty = global::System.Windows.Controls.ItemsControl.AlternationIndexProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridRow));

		// Token: 0x040002D8 RID: 728
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.Controls.Primitives.Selector.IsSelectedProperty.AddOwner(typeof(global::Microsoft.Windows.Controls.DataGridRow), new global::System.Windows.FrameworkPropertyMetadata(false, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.DataGridRow.OnIsSelectedChanged)));

		// Token: 0x040002DB RID: 731
		private static readonly global::System.Windows.DependencyPropertyKey IsEditingPropertyKey;

		// Token: 0x040002DC RID: 732
		public static readonly global::System.Windows.DependencyProperty IsEditingProperty;

		// Token: 0x040002DD RID: 733
		internal bool _detailsLoaded;

		// Token: 0x040002DE RID: 734
		private global::Microsoft.Windows.Controls.DataGrid _owner;

		// Token: 0x040002DF RID: 735
		private global::Microsoft.Windows.Controls.Primitives.DataGridCellsPresenter _cellsPresenter;

		// Token: 0x040002E0 RID: 736
		private global::Microsoft.Windows.Controls.Primitives.DataGridDetailsPresenter _detailsPresenter;

		// Token: 0x040002E1 RID: 737
		private global::Microsoft.Windows.Controls.Primitives.DataGridRowHeader _rowHeader;

		// Token: 0x040002E2 RID: 738
		private global::Microsoft.Windows.Controls.ContainerTracking<global::Microsoft.Windows.Controls.DataGridRow> _tracker;

		// Token: 0x040002E3 RID: 739
		private double _cellsPresenterResizeHeight;
	}
}
