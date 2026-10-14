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
	// Token: 0x02000346 RID: 838
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Selected", GroupName = "SelectionStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilteredIn", GroupName = "FilterStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilteredOut", GroupName = "FilterStates")]
	[global::System.Windows.TemplateVisualState(Name = "Fixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord_AlternateRow", GroupName = "RecordStates")]
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
		// Token: 0x06002810 RID: 10256 RVA: 0x000B1F8C File Offset: 0x000B018C
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

		// Token: 0x06002811 RID: 10257 RVA: 0x000B25E3 File Offset: 0x000B07E3
		public DataRecordCellArea()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.DataRecordCellArea.StyleSelectorHelper(this);
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000B25F8 File Offset: 0x000B07F8
		protected override global::System.Windows.Size MeasureOverride(global::System.Windows.Size availableSize)
		{
			global::System.Windows.Size result = base.MeasureOverride(availableSize);
			this.PostSyncActiveSelectedState();
			return result;
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x000B2614 File Offset: 0x000B0814
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this.CanRaiseHoverEvent(true))
			{
				this.RaiseHoverBegin(new global::System.Windows.RoutedEventArgs());
			}
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x000B2637 File Offset: 0x000B0837
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			this.VerifyPendingHoverEndRaised();
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000B264C File Offset: 0x000B084C
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

		// Token: 0x06002816 RID: 10262 RVA: 0x000B267C File Offset: 0x000B087C
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

		// Token: 0x06002817 RID: 10263 RVA: 0x000B27DC File Offset: 0x000B09DC
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

		// Token: 0x17000BDD RID: 3037
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x000B281B File Offset: 0x000B0A1B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public object DataError
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.DataErrorProperty);
			}
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x000B2828 File Offset: 0x000B0A28
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

		// Token: 0x17000BDE RID: 3038
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x000B2870 File Offset: 0x000B0A70
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

		// Token: 0x0600281B RID: 10267 RVA: 0x000B2890 File Offset: 0x000B0A90
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = target as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea != null)
			{
				dataRecordCellArea._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				dataRecordCellArea.InitializeVersionInfo();
			}
		}

		// Token: 0x17000BDF RID: 3039
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x000B28BF File Offset: 0x000B0ABF
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x000B28C7 File Offset: 0x000B0AC7
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

		// Token: 0x17000BE0 RID: 3040
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x000B28D5 File Offset: 0x000B0AD5
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasDataError
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HasDataErrorProperty);
			}
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000B28E8 File Offset: 0x000B0AE8
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

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x000B29A8 File Offset: 0x000B0BA8
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x000B29B0 File Offset: 0x000B0BB0
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

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x000B29C3 File Offset: 0x000B0BC3
		public bool IsAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAddRecordProperty);
			}
		}

		// Token: 0x17000BE3 RID: 3043
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x000B29D5 File Offset: 0x000B0BD5
		public bool IsFilterRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsFilterRecordProperty);
			}
		}

		// Token: 0x17000BE4 RID: 3044
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x000B29E7 File Offset: 0x000B0BE7
		public bool? IsFilteredOut
		{
			get
			{
				return (bool?)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsFilteredOutProperty);
			}
		}

		// Token: 0x17000BE5 RID: 3045
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000B29F9 File Offset: 0x000B0BF9
		public bool IsAlternate
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAlternateProperty);
			}
		}

		// Token: 0x06002826 RID: 10278 RVA: 0x000B2A0C File Offset: 0x000B0C0C
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
				else
				{
					dataRecordCellArea.HookUnhook_Loaded(true);
				}
				dataRecordCellArea.UpdateVisualStates();
			}
		}

		// Token: 0x06002827 RID: 10279 RVA: 0x000B2A8C File Offset: 0x000B0C8C
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

		// Token: 0x17000BE6 RID: 3046
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x000B2ADC File Offset: 0x000B0CDC
		// (set) Token: 0x06002829 RID: 10281 RVA: 0x000B2AFB File Offset: 0x000B0CFB
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

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x0600282A RID: 10282 RVA: 0x000B2B0E File Offset: 0x000B0D0E
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OrientationProperty);
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x000B2B20 File Offset: 0x000B0D20
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x000B2B28 File Offset: 0x000B0D28
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x000B2B3A File Offset: 0x000B0D3A
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

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x0600282E RID: 10286 RVA: 0x000B2B4D File Offset: 0x000B0D4D
		// (set) Token: 0x0600282F RID: 10287 RVA: 0x000B2B5F File Offset: 0x000B0D5F
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

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x000B2B6D File Offset: 0x000B0D6D
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x000B2B7F File Offset: 0x000B0D7F
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

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x000B2B8D File Offset: 0x000B0D8D
		// (set) Token: 0x06002833 RID: 10291 RVA: 0x000B2B9F File Offset: 0x000B0D9F
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

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x000B2BAD File Offset: 0x000B0DAD
		// (set) Token: 0x06002835 RID: 10293 RVA: 0x000B2BBF File Offset: 0x000B0DBF
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

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06002836 RID: 10294 RVA: 0x000B2BCD File Offset: 0x000B0DCD
		// (set) Token: 0x06002837 RID: 10295 RVA: 0x000B2BDF File Offset: 0x000B0DDF
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

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06002838 RID: 10296 RVA: 0x000B2BED File Offset: 0x000B0DED
		// (set) Token: 0x06002839 RID: 10297 RVA: 0x000B2BFF File Offset: 0x000B0DFF
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

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x000B2C0D File Offset: 0x000B0E0D
		// (set) Token: 0x0600283B RID: 10299 RVA: 0x000B2C1F File Offset: 0x000B0E1F
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

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x0600283C RID: 10300 RVA: 0x000B2C2D File Offset: 0x000B0E2D
		// (set) Token: 0x0600283D RID: 10301 RVA: 0x000B2C3F File Offset: 0x000B0E3F
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

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x0600283E RID: 10302 RVA: 0x000B2C4D File Offset: 0x000B0E4D
		// (set) Token: 0x0600283F RID: 10303 RVA: 0x000B2C5F File Offset: 0x000B0E5F
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

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x06002840 RID: 10304 RVA: 0x000B2C6D File Offset: 0x000B0E6D
		// (set) Token: 0x06002841 RID: 10305 RVA: 0x000B2C7F File Offset: 0x000B0E7F
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

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002842 RID: 10306 RVA: 0x000B2C8D File Offset: 0x000B0E8D
		// (set) Token: 0x06002843 RID: 10307 RVA: 0x000B2C9F File Offset: 0x000B0E9F
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

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002844 RID: 10308 RVA: 0x000B2CAD File Offset: 0x000B0EAD
		// (set) Token: 0x06002845 RID: 10309 RVA: 0x000B2CBF File Offset: 0x000B0EBF
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

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002846 RID: 10310 RVA: 0x000B2CCD File Offset: 0x000B0ECD
		// (set) Token: 0x06002847 RID: 10311 RVA: 0x000B2CDF File Offset: 0x000B0EDF
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

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002848 RID: 10312 RVA: 0x000B2CED File Offset: 0x000B0EED
		// (set) Token: 0x06002849 RID: 10313 RVA: 0x000B2CFF File Offset: 0x000B0EFF
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

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000B2D12 File Offset: 0x000B0F12
		// (set) Token: 0x0600284B RID: 10315 RVA: 0x000B2D24 File Offset: 0x000B0F24
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

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x000B2D37 File Offset: 0x000B0F37
		// (set) Token: 0x0600284D RID: 10317 RVA: 0x000B2D49 File Offset: 0x000B0F49
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

		// Token: 0x0600284E RID: 10318 RVA: 0x000B2D5C File Offset: 0x000B0F5C
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

		// Token: 0x0600284F RID: 10319 RVA: 0x000B2EF4 File Offset: 0x000B10F4
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecordCellArea dataRecordCellArea = target as global::Infragistics.Windows.DataPresenter.DataRecordCellArea;
			if (dataRecordCellArea != null)
			{
				dataRecordCellArea.UpdateVisualStates();
			}
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x000B2F11 File Offset: 0x000B1111
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x000B2F1A File Offset: 0x000B111A
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

		// Token: 0x06002852 RID: 10322 RVA: 0x000B2F37 File Offset: 0x000B1137
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

		// Token: 0x06002853 RID: 10323 RVA: 0x000B2F5F File Offset: 0x000B115F
		private bool CanRaiseHoverEvent(bool queryForBegin)
		{
			return base.IsLoaded && base.IsInitialized && this.Record != null && this.Record.AssociatedRecordPresenter != null && base.GetTemplateChild("Hover") != null && global::System.Windows.Media.VisualTreeHelper.GetParent(this) != null;
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x000B2FA0 File Offset: 0x000B11A0
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

		// Token: 0x06002855 RID: 10325 RVA: 0x000B2FF4 File Offset: 0x000B11F4
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

		// Token: 0x06002856 RID: 10326 RVA: 0x000B3048 File Offset: 0x000B1248
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

		// Token: 0x06002857 RID: 10327 RVA: 0x000B309C File Offset: 0x000B129C
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

		// Token: 0x06002858 RID: 10328 RVA: 0x000B3124 File Offset: 0x000B1324
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
					if (!base.IsLoaded)
					{
						if (!this._hookedIntoLoaded)
						{
							this.HookUnhook_Loaded(true);
							this._wasSelected = (bool)obj;
						}
					}
					else if (((global::Infragistics.Windows.DataPresenter.DataRecord)sender).IsSelected)
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

		// Token: 0x06002859 RID: 10329 RVA: 0x000B32C4 File Offset: 0x000B14C4
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

		// Token: 0x0600285A RID: 10330 RVA: 0x000B3324 File Offset: 0x000B1524
		private void SyncActiveSelectedState()
		{
			this._syncPosted = null;
			if (this._record != null)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsActiveProperty, global::Infragistics.KnownBoxes.FromValue(this._record.IsActive));
				base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsSelectedProperty, global::Infragistics.KnownBoxes.FromValue(this._record.IsSelected));
			}
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x000B3378 File Offset: 0x000B1578
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

		// Token: 0x0600285C RID: 10332 RVA: 0x000B33E0 File Offset: 0x000B15E0
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.HookUnhook_Loaded(false);
			if (this._record != null)
			{
				if (this._record.IsSelected != this.IsSelected)
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

		// Token: 0x0600285D RID: 10333 RVA: 0x000B342D File Offset: 0x000B162D
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

		// Token: 0x0600285E RID: 10334 RVA: 0x000B345C File Offset: 0x000B165C
		private void VerifySelectedState()
		{
			bool isSelected = this.IsSelected;
			if (this._wasSelected != isSelected)
			{
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

		// Token: 0x0600285F RID: 10335 RVA: 0x000B34AA File Offset: 0x000B16AA
		protected virtual void OnHoverBegin(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000B34B3 File Offset: 0x000B16B3
		internal void RaiseHoverBegin(global::System.Windows.RoutedEventArgs args)
		{
			this._hasPendingHoverEnd = true;
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverBeginEvent;
			args.Source = this;
			this.OnHoverBegin(args);
		}

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x06002861 RID: 10337 RVA: 0x000B34D5 File Offset: 0x000B16D5
		// (remove) Token: 0x06002862 RID: 10338 RVA: 0x000B34E3 File Offset: 0x000B16E3
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

		// Token: 0x06002863 RID: 10339 RVA: 0x000B34F1 File Offset: 0x000B16F1
		protected virtual void OnHoverEnd(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x000B34FA File Offset: 0x000B16FA
		internal void RaiseHoverEnd(global::System.Windows.RoutedEventArgs args)
		{
			this._hasPendingHoverEnd = false;
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.HoverEndEvent;
			args.Source = this;
			this.OnHoverEnd(args);
		}

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x06002865 RID: 10341 RVA: 0x000B351C File Offset: 0x000B171C
		// (remove) Token: 0x06002866 RID: 10342 RVA: 0x000B352A File Offset: 0x000B172A
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

		// Token: 0x06002867 RID: 10343 RVA: 0x000B3538 File Offset: 0x000B1738
		protected virtual void OnSelected(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x000B3541 File Offset: 0x000B1741
		internal void RaiseSelected(global::System.Windows.RoutedEventArgs args)
		{
			if (!base.IsInitialized || !base.IsLoaded)
			{
				return;
			}
			this._wasSelected = true;
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.SelectedEvent;
			args.Source = this;
			this.OnSelected(args);
		}

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x06002869 RID: 10345 RVA: 0x000B3574 File Offset: 0x000B1774
		// (remove) Token: 0x0600286A RID: 10346 RVA: 0x000B3582 File Offset: 0x000B1782
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

		// Token: 0x0600286B RID: 10347 RVA: 0x000B3590 File Offset: 0x000B1790
		protected virtual void OnDeselected(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x000B3599 File Offset: 0x000B1799
		internal void RaiseDeselected(global::System.Windows.RoutedEventArgs args)
		{
			if (!base.IsInitialized || !base.IsLoaded)
			{
				return;
			}
			this._wasSelected = false;
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.DeselectedEvent;
			args.Source = this;
			this.OnDeselected(args);
		}

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x0600286D RID: 10349 RVA: 0x000B35CC File Offset: 0x000B17CC
		// (remove) Token: 0x0600286E RID: 10350 RVA: 0x000B35DA File Offset: 0x000B17DA
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

		// Token: 0x0600286F RID: 10351 RVA: 0x000B35E8 File Offset: 0x000B17E8
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

		// Token: 0x040013A9 RID: 5033
		private int _cachedVersion;

		// Token: 0x040013AA RID: 5034
		private bool _versionInitialized;

		// Token: 0x040013AB RID: 5035
		private bool _isAlternateInitialized;

		// Token: 0x040013AC RID: 5036
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x040013AD RID: 5037
		private global::Infragistics.Windows.DataPresenter.DataRecordCellArea.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x040013AE RID: 5038
		private global::System.Windows.Threading.DispatcherOperation _syncPosted;

		// Token: 0x040013AF RID: 5039
		private bool _wasSelected;

		// Token: 0x040013B0 RID: 5040
		private bool _ignoreIsSelectedClear;

		// Token: 0x040013B1 RID: 5041
		private bool _hasVisualStateGroups;

		// Token: 0x040013B2 RID: 5042
		private bool _hasPendingHoverEnd;

		// Token: 0x040013B3 RID: 5043
		private bool _hookedIntoLoaded;

		// Token: 0x040013B4 RID: 5044
		private bool _hookedIntoUnLoaded;

		// Token: 0x040013B5 RID: 5045
		public static readonly global::System.Windows.DependencyProperty DataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));

		// Token: 0x040013B6 RID: 5046
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnFieldLayoutChanged)));

		// Token: 0x040013B7 RID: 5047
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x040013B8 RID: 5048
		public static readonly global::System.Windows.DependencyProperty HasDataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));

		// Token: 0x040013B9 RID: 5049
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty = global::System.Windows.DependencyProperty.Register("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnIsActiveChanged)));

		// Token: 0x040013BA RID: 5050
		private bool _cachedIsActive;

		// Token: 0x040013BB RID: 5051
		internal static readonly global::System.Windows.DependencyPropertyKey IsAddRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAddRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));

		// Token: 0x040013BC RID: 5052
		public static readonly global::System.Windows.DependencyProperty IsAddRecordProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAddRecordPropertyKey.DependencyProperty;

		// Token: 0x040013BD RID: 5053
		internal static readonly global::System.Windows.DependencyPropertyKey IsFilterRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFilterRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));

		// Token: 0x040013BE RID: 5054
		public static readonly global::System.Windows.DependencyProperty IsFilterRecordProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsFilterRecordPropertyKey.DependencyProperty;

		// Token: 0x040013BF RID: 5055
		public static readonly global::System.Windows.DependencyProperty IsFilteredOutProperty = global::Infragistics.Windows.DataPresenter.RecordPresenter.IsFilteredOutProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));

		// Token: 0x040013C0 RID: 5056
		internal static readonly global::System.Windows.DependencyPropertyKey IsAlternatePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAlternate", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));

		// Token: 0x040013C1 RID: 5057
		public static readonly global::System.Windows.DependencyProperty IsAlternateProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.IsAlternatePropertyKey.DependencyProperty;

		// Token: 0x040013C2 RID: 5058
		public static readonly global::System.Windows.DependencyProperty IsSelectedProperty = global::System.Windows.DependencyProperty.Register("IsSelected", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.AffectsRender, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnIsSelectedChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.CoerceIsSelected)));

		// Token: 0x040013C3 RID: 5059
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));

		// Token: 0x040013C4 RID: 5060
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OrientationPropertyKey.DependencyProperty;

		// Token: 0x040013C5 RID: 5061
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.DataRecord), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.DataRecordCellArea.OnVisualStatePropertyChanged)));

		// Token: 0x040013C6 RID: 5062
		public static readonly global::System.Windows.DependencyProperty RecordProperty = global::Infragistics.Windows.DataPresenter.DataRecordCellArea.RecordPropertyKey.DependencyProperty;

		// Token: 0x040013C7 RID: 5063
		public static readonly global::System.Windows.DependencyProperty CornerRadiusProperty = global::System.Windows.DependencyProperty.Register("CornerRadius", typeof(global::System.Windows.CornerRadius), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.CornerRadius(4.0)));

		// Token: 0x040013C8 RID: 5064
		public static readonly global::System.Windows.DependencyProperty BackgroundHoverProperty = global::System.Windows.DependencyProperty.Register("BackgroundHover", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013C9 RID: 5065
		public static readonly global::System.Windows.DependencyProperty BorderHoverBrushProperty = global::System.Windows.DependencyProperty.Register("BorderHoverBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013CA RID: 5066
		public static readonly global::System.Windows.DependencyProperty BackgroundActiveProperty = global::System.Windows.DependencyProperty.Register("BackgroundActive", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013CB RID: 5067
		public static readonly global::System.Windows.DependencyProperty BorderActiveBrushProperty = global::System.Windows.DependencyProperty.Register("BorderActiveBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013CC RID: 5068
		public static readonly global::System.Windows.DependencyProperty BackgroundAlternateProperty = global::System.Windows.DependencyProperty.Register("BackgroundAlternate", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013CD RID: 5069
		public static readonly global::System.Windows.DependencyProperty BorderAlternateBrushProperty = global::System.Windows.DependencyProperty.Register("BorderAlternateBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013CE RID: 5070
		public static readonly global::System.Windows.DependencyProperty BackgroundSelectedProperty = global::System.Windows.DependencyProperty.Register("BackgroundSelected", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013CF RID: 5071
		public static readonly global::System.Windows.DependencyProperty BorderSelectedBrushProperty = global::System.Windows.DependencyProperty.Register("BorderSelectedBrush", typeof(global::System.Windows.Media.Brush), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013D0 RID: 5072
		public static readonly global::System.Windows.DependencyProperty ForegroundStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013D1 RID: 5073
		public static readonly global::System.Windows.DependencyProperty ForegroundActiveStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundActiveStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013D2 RID: 5074
		public static readonly global::System.Windows.DependencyProperty ForegroundAlternateStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundAlternateStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013D3 RID: 5075
		public static readonly global::System.Windows.DependencyProperty ForegroundSelectedStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundSelectedStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013D4 RID: 5076
		public static readonly global::System.Windows.DependencyProperty ForegroundHoverStyleProperty = global::System.Windows.DependencyProperty.Register("ForegroundHoverStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040013D5 RID: 5077
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x040013D6 RID: 5078
		internal static readonly global::System.Windows.DependencyProperty ScrollableRecordCountVersionProperty = global::Infragistics.Windows.DataPresenter.DataPresenterBase.ScrollableRecordCountVersionProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea));

		// Token: 0x040013D7 RID: 5079
		internal static readonly global::System.Windows.DependencyProperty SortOperationVersionProperty = global::System.Windows.DependencyProperty.Register("SortOperationVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.DataRecordCellArea), new global::System.Windows.FrameworkPropertyMetadata(0));

		// Token: 0x02000347 RID: 839
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06002870 RID: 10352 RVA: 0x000B361C File Offset: 0x000B181C
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.DataRecordCellArea rs) : base(rs)
			{
				this._rs = rs;
			}

			// Token: 0x17000BFA RID: 3066
			// (get) Token: 0x06002871 RID: 10353 RVA: 0x000B362C File Offset: 0x000B182C
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

			// Token: 0x040013DC RID: 5084
			private global::Infragistics.Windows.DataPresenter.DataRecordCellArea _rs;
		}
	}
}
