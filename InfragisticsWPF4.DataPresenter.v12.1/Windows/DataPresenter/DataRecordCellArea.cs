using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000305 RID: 773
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord_AlternateRow", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilteredIn", GroupName = "FilterStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilteredOut", GroupName = "FilterStates")]
	[global::System.Windows.TemplateVisualState(Name = "Fixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unselected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "ValidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundActiveStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundAlternateStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundSelectedStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	[global::System.Windows.StyleTypedProperty(Property = "ForegroundHoverStyle", StyleTargetType = typeof(global::System.Windows.Controls.ContentPresenter))]
	public class DataRecordCellArea : global::Infragistics.Windows.DataPresenter.RecordCellAreaBase, global::System.Windows.IWeakEventListener
	{
		// Token: 0x0600245F RID: 9311 RVA: 0x0009E200 File Offset: 0x0009C400
		static DataRecordCellArea()
		{
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverBeginEvent = global::System.Windows.EventManager.RegisterRoutedEvent("HoverBegin", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverEndEvent = global::System.Windows.EventManager.RegisterRoutedEvent("HoverEnd", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SelectedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Selected", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea.DeselectedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Deselected", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)), global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorPropertyKey);
			global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)), global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutPropertyKey);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0009E857 File Offset: 0x0009CA57
		public DataRecordCellArea()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.DataRecordCellArea.StyleSelectorHelper(this);
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0009E86C File Offset: 0x0009CA6C
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			this.PostSyncActiveSelectedState();
			return result;
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0009E888 File Offset: 0x0009CA88
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.CanRaiseHoverEvent(true))
			{
				this.RaiseHoverBegin(new global::System.Windows.RoutedEventArgs());
			}
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x0009E8AB File Offset: 0x0009CAAB
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this.VerifyPendingHoverEndRaised();
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0009E8C0 File Offset: 0x0009CAC0
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this.IsSelected)
			{
				this.RaiseSelected(new global::System.Windows.RoutedEventArgs());
			}
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0009E8F0 File Offset: 0x0009CAF0
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			global::System.Windows.DependencyProperty property = e.Property;
			if (property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = e.NewValue as global::Infragistics.Windows.DataPresenter.DataRecord;
				if (dataRecord != this._record)
				{
					bool flag = this._record != null;
					if (this._record != null)
					{
						global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._record, this, string.Empty);
					}
					this._record = dataRecord;
					this._isAlternateInitialized = false;
					this.InitializeIsAlternate();
					if (this._record != null)
					{
						global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._record, this, string.Empty);
						base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAddRecordPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._record.IsAddRecord));
						base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsFilterRecordPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._record is global::Infragistics.Windows.DataPresenter.FilterRecord));
						global::Infragistics.Windows.DataPresenter.RecordPresenter.SetIsFilteredOutPropertyHelper(this, this._record);
						if (flag)
						{
							this.SyncActiveSelectedState();
						}
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.RecordPropertyKey, this._record);
					this.UpdateDataError();
					if (this._record != null && e.OldValue != null)
					{
						this._styleSelectorHelper.InvalidateStyle();
						return;
					}
				}
			}
			else
			{
				if (property == global::System.Windows.Controls.ContentControl.ContentProperty)
				{
					return;
				}
				if (property == global::Infragistics.Windows.DataPresenter.DataRecordCellArea.InternalVersionProperty)
				{
					this._isAlternateInitialized = false;
					this.InitializeVersionInfo();
					return;
				}
				if (property == global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ScrollableRecordCountVersionProperty)
				{
					this._isAlternateInitialized = false;
					this.InitializeIsAlternate();
					return;
				}
				if (property == global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SortOperationVersionProperty)
				{
					this._isAlternateInitialized = false;
					this.InitializeIsAlternate();
				}
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0009EA50 File Offset: 0x0009CC50
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("DataRecordCellArea: ");
			if (this.Record != null)
			{
				stringBuilder.Append(this.Record.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002467 RID: 9319 RVA: 0x0009EA8F File Offset: 0x0009CC8F
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public object DataError
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.DataErrorProperty);
			}
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0009EA9C File Offset: 0x0009CC9C
		internal void UpdateDataError()
		{
			bool flag = false;
			object value = null;
			global::Infragistics.Windows.DataPresenter.DataRecord record = this.Record;
			if (record != null)
			{
				value = record.DataError;
				flag = record.HasDataError;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorPropertyKey, value);
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorPropertyKey, flag);
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002469 RID: 9321 RVA: 0x0009EAE4 File Offset: 0x0009CCE4
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record record = this.Record;
				if (record != null)
				{
					return record.DataPresenter;
				}
				return null;
			}
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0009EB04 File Offset: 0x0009CD04
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = target as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea != null)
			{
				dataRecordCellArea._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				dataRecordCellArea.InitializeVersionInfo();
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x0600246B RID: 9323 RVA: 0x0009EB33 File Offset: 0x0009CD33
		// (set) Token: 0x0600246C RID: 9324 RVA: 0x0009EB3B File Offset: 0x0009CD3B
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._cachedFieldLayout;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.FieldLayoutProperty, value);
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x0600246D RID: 9325 RVA: 0x0009EB49 File Offset: 0x0009CD49
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasDataError
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HasDataErrorProperty);
			}
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0009EB5C File Offset: 0x0009CD5C
		private static void OnIsActiveChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = target as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea != null)
			{
				bool flag = (bool)e.NewValue;
				if (flag != dataRecordCellArea._cachedIsActive)
				{
					dataRecordCellArea._cachedIsActive = flag;
				}
				if (dataRecordCellArea._record != null && dataRecordCellArea._record.DataPresenter != null)
				{
					global::Infragistics.Windows.DataPresenter.Record activeRecord = dataRecordCellArea._record.DataPresenter.ActiveRecord;
					if (flag)
					{
						if (activeRecord != dataRecordCellArea._record)
						{
							dataRecordCellArea._record.DataPresenter.ActiveRecord = dataRecordCellArea._record;
						}
					}
					else if (activeRecord == dataRecordCellArea._record)
					{
						dataRecordCellArea._record.DataPresenter.ActiveRecord = null;
					}
				}
				if (dataRecordCellArea.IsSelected != flag)
				{
					dataRecordCellArea.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(dataRecordCellArea.IsActive));
				}
				dataRecordCellArea.UpdateVisualStates();
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x0009EC1C File Offset: 0x0009CE1C
		// (set) Token: 0x06002470 RID: 9328 RVA: 0x0009EC24 File Offset: 0x0009CE24
		public bool IsActive
		{
			get
			{
				return this._cachedIsActive;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsActiveProperty, value);
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002471 RID: 9329 RVA: 0x0009EC37 File Offset: 0x0009CE37
		public bool IsAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAddRecordProperty);
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x0009EC49 File Offset: 0x0009CE49
		public bool IsFilterRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsFilterRecordProperty);
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x0009EC5B File Offset: 0x0009CE5B
		public bool? IsFilteredOut
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsFilteredOutProperty);
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x0009EC6D File Offset: 0x0009CE6D
		public bool IsAlternate
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAlternateProperty);
			}
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x0009EC80 File Offset: 0x0009CE80
		private static void OnIsSelectedChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = target as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea != null)
			{
				if (dataRecordCellArea.ReadLocalValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsSelectedProperty) == global::System.Windows.DependencyProperty.UnsetValue)
				{
					bool flag = (bool)e.NewValue;
					global::Infragistics.Windows.DataPresenter.DataRecordCellArea.CoerceIsSelected(dataRecordCellArea, global::Infragistics.KnownBoxes.FromValue(flag));
					if (dataRecordCellArea.IsSelected != flag)
					{
						dataRecordCellArea.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(dataRecordCellArea.IsSelected));
					}
				}
				if (dataRecordCellArea.IsLoaded)
				{
					dataRecordCellArea.VerifySelectedState();
				}
				dataRecordCellArea.UpdateVisualStates();
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0009ECF8 File Offset: 0x0009CEF8
		private static object CoerceIsSelected(global::System.Windows.DependencyObject target, object value)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = target as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea != null)
			{
				if (dataRecordCellArea._ignoreIsSelectedClear)
				{
					return value;
				}
				global::Infragistics.Windows.DataPresenter.Record record = dataRecordCellArea.Record;
				if (record != null && dataRecordCellArea.DataPresenter != null)
				{
					record.IsSelected = (bool)value;
					return record.IsSelected;
				}
			}
			return global::Infragistics.KnownBoxes.FalseBox;
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06002477 RID: 9335 RVA: 0x0009ED48 File Offset: 0x0009CF48
		// (set) Token: 0x06002478 RID: 9336 RVA: 0x0009ED67 File Offset: 0x0009CF67
		public bool IsSelected
		{
			get
			{
				global::Infragistics.Windows.DataPresenter.Record record = this.Record;
				return record != null && record.IsSelected;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsSelectedProperty, value);
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06002479 RID: 9337 RVA: 0x0009ED7A File Offset: 0x0009CF7A
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OrientationProperty);
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x0600247A RID: 9338 RVA: 0x0009ED8C File Offset: 0x0009CF8C
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x0600247B RID: 9339 RVA: 0x0009ED94 File Offset: 0x0009CF94
		// (set) Token: 0x0600247C RID: 9340 RVA: 0x0009EDA6 File Offset: 0x0009CFA6
		public global::System.Windows.CornerRadius CornerRadius
		{
			get
			{
				return (global::System.Windows.CornerRadius)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.CornerRadiusProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.CornerRadiusProperty, value);
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x0600247D RID: 9341 RVA: 0x0009EDB9 File Offset: 0x0009CFB9
		// (set) Token: 0x0600247E RID: 9342 RVA: 0x0009EDCB File Offset: 0x0009CFCB
		public global::System.Windows.Media.Brush BackgroundHover
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BackgroundHoverProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BackgroundHoverProperty, value);
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x0600247F RID: 9343 RVA: 0x0009EDD9 File Offset: 0x0009CFD9
		// (set) Token: 0x06002480 RID: 9344 RVA: 0x0009EDEB File Offset: 0x0009CFEB
		public global::System.Windows.Media.Brush BorderHoverBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BorderHoverBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BorderHoverBrushProperty, value);
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06002481 RID: 9345 RVA: 0x0009EDF9 File Offset: 0x0009CFF9
		// (set) Token: 0x06002482 RID: 9346 RVA: 0x0009EE0B File Offset: 0x0009D00B
		public global::System.Windows.Media.Brush BackgroundActive
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BackgroundActiveProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BackgroundActiveProperty, value);
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06002483 RID: 9347 RVA: 0x0009EE19 File Offset: 0x0009D019
		// (set) Token: 0x06002484 RID: 9348 RVA: 0x0009EE2B File Offset: 0x0009D02B
		public global::System.Windows.Media.Brush BorderActiveBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BorderActiveBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BorderActiveBrushProperty, value);
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06002485 RID: 9349 RVA: 0x0009EE39 File Offset: 0x0009D039
		// (set) Token: 0x06002486 RID: 9350 RVA: 0x0009EE4B File Offset: 0x0009D04B
		public global::System.Windows.Media.Brush BackgroundAlternate
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BackgroundAlternateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BackgroundAlternateProperty, value);
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06002487 RID: 9351 RVA: 0x0009EE59 File Offset: 0x0009D059
		// (set) Token: 0x06002488 RID: 9352 RVA: 0x0009EE6B File Offset: 0x0009D06B
		public global::System.Windows.Media.Brush BorderAlternateBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BorderAlternateBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BorderAlternateBrushProperty, value);
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06002489 RID: 9353 RVA: 0x0009EE79 File Offset: 0x0009D079
		// (set) Token: 0x0600248A RID: 9354 RVA: 0x0009EE8B File Offset: 0x0009D08B
		public global::System.Windows.Media.Brush BackgroundSelected
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BackgroundSelectedProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BackgroundSelectedProperty, value);
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x0600248B RID: 9355 RVA: 0x0009EE99 File Offset: 0x0009D099
		// (set) Token: 0x0600248C RID: 9356 RVA: 0x0009EEAB File Offset: 0x0009D0AB
		public global::System.Windows.Media.Brush BorderSelectedBrush
		{
			get
			{
				return (global::System.Windows.Media.Brush)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BorderSelectedBrushProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.BorderSelectedBrushProperty, value);
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x0600248D RID: 9357 RVA: 0x0009EEB9 File Offset: 0x0009D0B9
		// (set) Token: 0x0600248E RID: 9358 RVA: 0x0009EECB File Offset: 0x0009D0CB
		public global::System.Windows.Style ForegroundStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundStyleProperty, value);
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x0009EED9 File Offset: 0x0009D0D9
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x0009EEEB File Offset: 0x0009D0EB
		public global::System.Windows.Style ForegroundActiveStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundActiveStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundActiveStyleProperty, value);
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x0009EEF9 File Offset: 0x0009D0F9
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x0009EF0B File Offset: 0x0009D10B
		public global::System.Windows.Style ForegroundAlternateStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundAlternateStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundAlternateStyleProperty, value);
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x0009EF19 File Offset: 0x0009D119
		// (set) Token: 0x06002494 RID: 9364 RVA: 0x0009EF2B File Offset: 0x0009D12B
		public global::System.Windows.Style ForegroundSelectedStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundSelectedStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundSelectedStyleProperty, value);
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06002495 RID: 9365 RVA: 0x0009EF39 File Offset: 0x0009D139
		// (set) Token: 0x06002496 RID: 9366 RVA: 0x0009EF4B File Offset: 0x0009D14B
		public global::System.Windows.Style ForegroundHoverStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundHoverStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ForegroundHoverStyleProperty, value);
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06002497 RID: 9367 RVA: 0x0009EF59 File Offset: 0x0009D159
		// (set) Token: 0x06002498 RID: 9368 RVA: 0x0009EF6B File Offset: 0x0009D16B
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.InternalVersionProperty, value);
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06002499 RID: 9369 RVA: 0x0009EF7E File Offset: 0x0009D17E
		// (set) Token: 0x0600249A RID: 9370 RVA: 0x0009EF90 File Offset: 0x0009D190
		internal int ScrollableRecordCountVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ScrollableRecordCountVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.ScrollableRecordCountVersionProperty, value);
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0009EFA3 File Offset: 0x0009D1A3
		// (set) Token: 0x0600249C RID: 9372 RVA: 0x0009EFB5 File Offset: 0x0009D1B5
		internal int SortOperationVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SortOperationVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SortOperationVersionProperty, value);
			}
		}

		// Token: 0x0600249D RID: 9373 RVA: 0x0009EFC8 File Offset: 0x0009D1C8
		protected virtual void SetVisualState(bool useTransitions)
		{
			global::Infragistics.Windows.DataPresenter.Record record = this.Record;
			if (!base.IsEnabled || (record != null && !record.IsEnabledResolved))
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else if (base.IsMouseOver)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"MouseOver",
					"Normal"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Normal", useTransitions);
			}
			if (this.IsActive)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Active", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Inactive", useTransitions);
			}
			bool? isFilteredOut = this.IsFilteredOut;
			if (isFilteredOut != null && isFilteredOut.Value)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "FilteredOut", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "FilteredIn", useTransitions);
			}
			if (record != null && record.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Fixed", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unfixed", useTransitions);
			}
			if (this.IsFilterRecord)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "FilterRecord", useTransitions);
			}
			else if (this.IsAddRecord)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "AddRecord", useTransitions);
			}
			else if (this.IsAlternate)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"DataRecord_AlternateRow",
					"DataRecord"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "DataRecord", useTransitions);
			}
			if (this.IsSelected)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Selected", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unselected", useTransitions);
			}
			if (this.HasDataError)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "InvalidEx", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "ValidEx", useTransitions);
		}

		// Token: 0x0600249E RID: 9374 RVA: 0x0009F160 File Offset: 0x0009D360
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = target as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea != null)
			{
				dataRecordCellArea.UpdateVisualStates();
			}
		}

		// Token: 0x0600249F RID: 9375 RVA: 0x0009F17D File Offset: 0x0009D37D
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060024A0 RID: 9376 RVA: 0x0009F186 File Offset: 0x0009D386
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!base.IsLoaded)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x0009F1A3 File Offset: 0x0009D3A3
		internal void SetIsAlternate(bool isAlternate)
		{
			this._isAlternateInitialized = true;
			if (isAlternate)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAlternatePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				return;
			}
			base.ClearValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAlternatePropertyKey);
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x0009F1CB File Offset: 0x0009D3CB
		private bool CanRaiseHoverEvent(bool queryForBegin)
		{
			return base.IsLoaded && base.IsInitialized && this.Record != null && this.Record.AssociatedRecordPresenter != null && base.GetTemplateChild("Hover") != null && global::System.Windows.Media.VisualTreeHelper.GetParent(this) != null;
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x0009F20C File Offset: 0x0009D40C
		private void HookUnhook_Loaded(bool hook)
		{
			if (hook)
			{
				if (!this._hookedIntoLoaded)
				{
					base.Loaded += this.OnLoaded;
					this._hookedIntoLoaded = true;
					return;
				}
			}
			else if (this._hookedIntoLoaded)
			{
				base.Loaded -= this.OnLoaded;
				this._hookedIntoLoaded = false;
			}
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x0009F260 File Offset: 0x0009D460
		private void HookUnhook_UnLoaded(bool hook)
		{
			if (hook)
			{
				if (!this._hookedIntoUnLoaded)
				{
					base.Unloaded += this.OnUnloaded;
					this._hookedIntoUnLoaded = true;
					return;
				}
			}
			else if (this._hookedIntoUnLoaded)
			{
				base.Unloaded -= this.OnUnloaded;
				this._hookedIntoUnLoaded = false;
			}
		}

		// Token: 0x060024A5 RID: 9381 RVA: 0x0009F2B4 File Offset: 0x0009D4B4
		private void InitializeIsAlternate()
		{
			if (this._isAlternateInitialized)
			{
				return;
			}
			bool isAlternate = false;
			if (this._cachedFieldLayout != null && this._cachedFieldLayout.HighlightAlternateRecordsResolved && this._record != null)
			{
				int visibleIndex = this._record.VisibleIndex;
				isAlternate = (0 != visibleIndex % 2);
			}
			this.SetIsAlternate(isAlternate);
		}

		// Token: 0x060024A6 RID: 9382 RVA: 0x0009F308 File Offset: 0x0009D508
		private void InitializeVersionInfo()
		{
			if (this._cachedFieldLayout != null && this._cachedFieldLayout.DataPresenter != null && this._cachedFieldLayout.StyleGenerator != null)
			{
				int internalVersion = this.InternalVersion;
				if (this._cachedVersion != internalVersion)
				{
					this._cachedVersion = internalVersion;
					if (this._versionInitialized)
					{
						this._styleSelectorHelper.InvalidateStyle();
					}
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OrientationPropertyKey, this.FieldLayout.StyleGenerator.LogicalOrientation);
				}
				this.InitializeIsAlternate();
				this._versionInitialized = true;
			}
		}

		// Token: 0x060024A7 RID: 9383 RVA: 0x0009F390 File Offset: 0x0009D590
		private void OnRecordPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (!(sender is global::Infragistics.Windows.DataPresenter.DataRecord))
			{
				return;
			}
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "IsAddRecord":
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAddRecordPropertyKey, global::Infragistics.KnownBoxes.FromValue(((global::Infragistics.Windows.DataPresenter.DataRecord)sender).IsAddRecord));
				return;
			case "IsSelected":
			{
				object obj = base.ReadLocalValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsSelectedProperty);
				if (obj is bool && (bool)obj != ((global::Infragistics.Windows.DataPresenter.DataRecord)sender).IsSelected)
				{
					if (((global::Infragistics.Windows.DataPresenter.DataRecord)sender).IsSelected)
					{
						this.RaiseSelected(new global::System.Windows.RoutedEventArgs());
					}
					else
					{
						this.RaiseDeselected(new global::System.Windows.RoutedEventArgs());
					}
				}
				this.IsSelected = ((global::Infragistics.Windows.DataPresenter.DataRecord)sender).IsSelected;
				return;
			}
			case "IsFilteredOut":
				global::Infragistics.Windows.DataPresenter.RecordPresenter.SetIsFilteredOutPropertyHelper(this, (global::Infragistics.Windows.DataPresenter.Record)sender);
				return;
			case "ActiveCell":
			case "IsActive":
				this.IsActive = ((global::Infragistics.Windows.DataPresenter.DataRecord)sender).IsActive;
				return;
			case "DataError":
				this.UpdateDataError();
				return;
			case "IsEnabledResolved":
			case "FixedLocation":
				this.UpdateVisualStates();
				break;

				return;
			}
		}

		// Token: 0x060024A8 RID: 9384 RVA: 0x0009F50C File Offset: 0x0009D70C
		private void PostSyncActiveSelectedState()
		{
			if (this.DataPresenter != null && (base.IsVisible || base.DataContext != null))
			{
				if (this.DataPresenter.IsSynchronousControl)
				{
					this.SyncActiveSelectedState();
					return;
				}
				if (this._syncPosted == null)
				{
					this._syncPosted = base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.DataPresenter.GridUtilities.MethodDelegate(this.SyncActiveSelectedState));
				}
			}
		}

		// Token: 0x060024A9 RID: 9385 RVA: 0x0009F56C File Offset: 0x0009D76C
		private void SyncActiveSelectedState()
		{
			this._syncPosted = null;
			if (this._record != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(this._record.IsActive));
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(this._record.IsSelected));
			}
		}

		// Token: 0x060024AA RID: 9386 RVA: 0x0009F5C0 File Offset: 0x0009D7C0
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.HookUnhook_UnLoaded(false);
			bool wasSelected = this._wasSelected;
			this._wasSelected = false;
			this._ignoreIsSelectedClear = true;
			try
			{
				base.ClearValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsSelectedProperty);
			}
			finally
			{
				this._ignoreIsSelectedClear = true;
			}
			this._wasSelected = wasSelected;
			if (wasSelected || this._hasPendingHoverEnd)
			{
				this.HookUnhook_Loaded(true);
			}
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0009F628 File Offset: 0x0009D828
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.HookUnhook_Loaded(false);
			if (this._record != null)
			{
				if (this._record.IsSelected)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsSelectedProperty, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					this.VerifySelectedState();
				}
			}
			this.VerifyPendingHoverEndRaised();
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0009F664 File Offset: 0x0009D864
		private void VerifyPendingHoverEndRaised()
		{
			if (this._hasPendingHoverEnd)
			{
				if (this.CanRaiseHoverEvent(false))
				{
					this.RaiseHoverEnd(new global::System.Windows.RoutedEventArgs());
					return;
				}
				if (!base.IsLoaded)
				{
					this.HookUnhook_Loaded(true);
				}
			}
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0009F694 File Offset: 0x0009D894
		private void VerifySelectedState()
		{
			bool isSelected = this.IsSelected;
			if (this._wasSelected != isSelected)
			{
				this._wasSelected = isSelected;
				if (isSelected)
				{
					this.RaiseSelected(new global::System.Windows.RoutedEventArgs());
					if (base.IsLoaded)
					{
						this.HookUnhook_UnLoaded(true);
						return;
					}
					this.HookUnhook_Loaded(true);
					return;
				}
				else
				{
					this.RaiseDeselected(new global::System.Windows.RoutedEventArgs());
				}
			}
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0009F6E9 File Offset: 0x0009D8E9
		protected virtual void OnHoverBegin(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0009F6F2 File Offset: 0x0009D8F2
		internal void RaiseHoverBegin(global::System.Windows.RoutedEventArgs args)
		{
			this._hasPendingHoverEnd = true;
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverBeginEvent;
			args.Source = this;
			this.OnHoverBegin(args);
		}

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x060024B0 RID: 9392 RVA: 0x0009F714 File Offset: 0x0009D914
		// (remove) Token: 0x060024B1 RID: 9393 RVA: 0x0009F722 File Offset: 0x0009D922
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> HoverBegin
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverBeginEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverBeginEvent, value);
			}
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x0009F730 File Offset: 0x0009D930
		protected virtual void OnHoverEnd(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x0009F739 File Offset: 0x0009D939
		internal void RaiseHoverEnd(global::System.Windows.RoutedEventArgs args)
		{
			this._hasPendingHoverEnd = false;
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverEndEvent;
			args.Source = this;
			this.OnHoverEnd(args);
		}

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x060024B4 RID: 9396 RVA: 0x0009F75B File Offset: 0x0009D95B
		// (remove) Token: 0x060024B5 RID: 9397 RVA: 0x0009F769 File Offset: 0x0009D969
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> HoverEnd
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverEndEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverEndEvent, value);
			}
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x0009F777 File Offset: 0x0009D977
		protected virtual void OnSelected(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0009F780 File Offset: 0x0009D980
		internal void RaiseSelected(global::System.Windows.RoutedEventArgs args)
		{
			if (!base.IsInitialized || !base.IsLoaded)
			{
				return;
			}
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SelectedEvent;
			args.Source = this;
			this.OnSelected(args);
		}

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x060024B8 RID: 9400 RVA: 0x0009F7AC File Offset: 0x0009D9AC
		// (remove) Token: 0x060024B9 RID: 9401 RVA: 0x0009F7BA File Offset: 0x0009D9BA
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> Selected
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SelectedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SelectedEvent, value);
			}
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0009F7C8 File Offset: 0x0009D9C8
		protected virtual void OnDeselected(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x0009F7D1 File Offset: 0x0009D9D1
		internal void RaiseDeselected(global::System.Windows.RoutedEventArgs args)
		{
			if (!base.IsInitialized || !base.IsLoaded)
			{
				return;
			}
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.DeselectedEvent;
			args.Source = this;
			this.OnDeselected(args);
		}

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x060024BC RID: 9404 RVA: 0x0009F7FD File Offset: 0x0009D9FD
		// (remove) Token: 0x060024BD RID: 9405 RVA: 0x0009F80B File Offset: 0x0009DA0B
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> Deselected
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.DeselectedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.DeselectedEvent, value);
			}
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x0009F81C File Offset: 0x0009DA1C
		bool global::System.Windows.IWeakEventListener.ReceiveWeakEvent(global::System.Type managerType, object sender, global::System.EventArgs e)
		{
			if (managerType == typeof(global::System.ComponentModel.PropertyChangedEventManager))
			{
				global::System.ComponentModel.PropertyChangedEventArgs propertyChangedEventArgs = e as global::System.ComponentModel.PropertyChangedEventArgs;
				if (propertyChangedEventArgs != null)
				{
					this.OnRecordPropertyChanged(sender, propertyChangedEventArgs);
					return true;
				}
			}
			return false;
		}

		// Token: 0x04001189 RID: 4489
		private int _cachedVersion;

		// Token: 0x0400118A RID: 4490
		private bool _versionInitialized;

		// Token: 0x0400118B RID: 4491
		private bool _isAlternateInitialized;

		// Token: 0x0400118C RID: 4492
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x0400118D RID: 4493
		private global::Infragistics.Windows.DataPresenter.DataRecordCellArea.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x0400118E RID: 4494
		private global::System.Windows.Threading.DispatcherOperation _syncPosted;

		// Token: 0x0400118F RID: 4495
		private bool _wasSelected;

		// Token: 0x04001190 RID: 4496
		private bool _ignoreIsSelectedClear;

		// Token: 0x04001191 RID: 4497
		private bool _hasVisualStateGroups;

		// Token: 0x04001192 RID: 4498
		private bool _hasPendingHoverEnd;

		// Token: 0x04001193 RID: 4499
		private bool _hookedIntoLoaded;

		// Token: 0x04001194 RID: 4500
		private bool _hookedIntoUnLoaded;

		// Token: 0x04001195 RID: 4501
		public static readonly global::System.Windows.DependencyProperty DataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));

		// Token: 0x04001196 RID: 4502
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnFieldLayoutChanged)));

		// Token: 0x04001197 RID: 4503
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x04001198 RID: 4504
		public static readonly global::System.Windows.DependencyProperty HasDataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));

		// Token: 0x04001199 RID: 4505
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnIsActiveChanged)));

		// Token: 0x0400119A RID: 4506
		private bool _cachedIsActive;

		// Token: 0x0400119B RID: 4507
		internal static readonly global::System.Windows.DependencyPropertyKey IsAddRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAddRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));

		// Token: 0x0400119C RID: 4508
		public static readonly global::System.Windows.DependencyProperty IsAddRecordProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAddRecordPropertyKey.DependencyProperty;

		// Token: 0x0400119D RID: 4509
		internal static readonly global::System.Windows.DependencyPropertyKey IsFilterRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFilterRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));

		// Token: 0x0400119E RID: 4510
		public static readonly global::System.Windows.DependencyProperty IsFilterRecordProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsFilterRecordPropertyKey.DependencyProperty;

		// Token: 0x0400119F RID: 4511
		public static readonly global::System.Windows.DependencyProperty IsFilteredOutProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));

		// Token: 0x040011A0 RID: 4512
		internal static readonly global::System.Windows.DependencyPropertyKey IsAlternatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAlternate", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));

		// Token: 0x040011A1 RID: 4513
		public static readonly global::System.Windows.DependencyProperty IsAlternateProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAlternatePropertyKey.DependencyProperty;

		// Token: 0x040011A2 RID: 4514
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnIsSelectedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.CoerceIsSelected)));

		// Token: 0x040011A3 RID: 4515
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));

		// Token: 0x040011A4 RID: 4516
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OrientationPropertyKey.DependencyProperty;

		// Token: 0x040011A5 RID: 4517
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.DataRecord), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));

		// Token: 0x040011A6 RID: 4518
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.RecordPropertyKey.DependencyProperty;

		// Token: 0x040011A7 RID: 4519
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty = global::System.Windows.DependencyProperty.Register("CornerRadius", typeof(global::System.Windows.CornerRadius), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.CornerRadius(4.0)));

		// Token: 0x040011A8 RID: 4520
		public static readonly global::System.Windows.DependencyProperty BackgroundHoverProperty = global::System.Windows.DependencyProperty.Register("BackgroundHover", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011A9 RID: 4521
		public static readonly global::System.Windows.DependencyProperty BorderHoverBrushProperty = global::System.Windows.DependencyProperty.Register("BorderHoverBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011AA RID: 4522
		public static readonly global::System.Windows.DependencyProperty BackgroundActiveProperty = global::System.Windows.DependencyProperty.Register("BackgroundActive", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011AB RID: 4523
		public static readonly global::System.Windows.DependencyProperty BorderActiveBrushProperty = global::System.Windows.DependencyProperty.Register("BorderActiveBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011AC RID: 4524
		public static readonly global::System.Windows.DependencyProperty BackgroundAlternateProperty = global::System.Windows.DependencyProperty.Register("BackgroundAlternate", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011AD RID: 4525
		public static readonly global::System.Windows.DependencyProperty BorderAlternateBrushProperty = global::System.Windows.DependencyProperty.Register("BorderAlternateBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011AE RID: 4526
		public static readonly global::System.Windows.DependencyProperty BackgroundSelectedProperty = global::System.Windows.DependencyProperty.Register("BackgroundSelected", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011AF RID: 4527
		public static readonly global::System.Windows.DependencyProperty BorderSelectedBrushProperty = global::System.Windows.DependencyProperty.Register("BorderSelectedBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011B0 RID: 4528
		public static readonly global::System.Windows.DependencyProperty ForegroundStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011B1 RID: 4529
		public static readonly global::System.Windows.DependencyProperty ForegroundActiveStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundActiveStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011B2 RID: 4530
		public static readonly global::System.Windows.DependencyProperty ForegroundAlternateStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundAlternateStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011B3 RID: 4531
		public static readonly global::System.Windows.DependencyProperty ForegroundSelectedStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundSelectedStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011B4 RID: 4532
		public static readonly global::System.Windows.DependencyProperty ForegroundHoverStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundHoverStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040011B5 RID: 4533
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x040011B6 RID: 4534
		internal static readonly global::System.Windows.DependencyProperty ScrollableRecordCountVersionProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollableRecordCountVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));

		// Token: 0x040011B7 RID: 4535
		internal static readonly global::System.Windows.DependencyProperty SortOperationVersionProperty = global::System.Windows.DependencyProperty.Register("SortOperationVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x02000306 RID: 774
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x060024BF RID: 9407 RVA: 0x0009F850 File Offset: 0x0009DA50
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.DataRecordCellArea rs) : base(rs)
			{
				this._rs = rs;
			}

			// Token: 0x17000AC9 RID: 2761
			// (get) Token: 0x060024C0 RID: 9408 RVA: 0x0009F860 File Offset: 0x0009DA60
			public override global::System.Windows.Style Style
			{
				get
				{
					if (this._rs == null)
					{
						return null;
					}
					global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = this._rs.FieldLayout;
					if (fieldLayout != null)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = fieldLayout.DataPresenter;
						if (dataPresenter != null)
						{
							return dataPresenter.InternalRecordCellAreaStyleSelector.SelectStyle(this._rs.DataContext, this._rs);
						}
					}
					return null;
				}
			}

			// Token: 0x040011BC RID: 4540
			private global::Infragistics.Windows.DataPresenter.DataRecordCellArea _rs;
		}
	}
}
