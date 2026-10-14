using System;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200032A RID: 810
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Left", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Right", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Bottom", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Top", GroupName = "LocationStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Unchanged", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Fixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "ValidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Changed", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	public class RecordSelector : global::System.Windows.Controls.ContentControl, global::System.Windows.IWeakEventListener
	{
		// Token: 0x060026E5 RID: 9957 RVA: 0x000A9C70 File Offset: 0x000A7E70
		static RecordSelector()
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector.ActivatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Activated", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector));
			global::Infragistics.Windows.DataPresenter.RecordSelector.DeactivatedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("Deactivated", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.RoutedEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector));
			global::Infragistics.Windows.DataPresenter.RecordSelector.DataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector));
			global::Infragistics.Windows.DataPresenter.RecordSelector.FieldLayoutProperty = global::System.Windows.DependencyProperty.Register("FieldLayout", typeof(global::Infragistics.Windows.DataPresenter.FieldLayout), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnFieldLayoutChanged)));
			global::Infragistics.Windows.DataPresenter.RecordSelector.FilterClearButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FilterClearButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));
			global::Infragistics.Windows.DataPresenter.RecordSelector.FilterClearButtonVisibilityProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.FilterClearButtonVisibilityPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.FixedButtonVisibilityPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FixedButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));
			global::Infragistics.Windows.DataPresenter.RecordSelector.FixedButtonVisibilityProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.FixedButtonVisibilityPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.HasDataErrorProperty = global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorProperty.AddOwner(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsActivePropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsActive", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnIsActiveChanged)));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsActiveProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsActivePropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsAddRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsAddRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsAddRecordProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsAddRecordPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataChangedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDataChanged", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataChangedProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataChangedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeHighlightPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDataErrorDisplayModeHighlight", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeHighlightProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeHighlightPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsDataErrorDisplayModeIcon", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.None));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsFilterRecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFilterRecord", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsFilterRecordProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsFilterRecordPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnBottomAllowedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixedOnBottomAllowed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnBottomAllowedProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnBottomAllowedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnTopAllowedPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsFixedOnTopAllowed", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnTopAllowedProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnTopAllowedPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.LocationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Location", typeof(global::Infragistics.Windows.DataPresenter.RecordSelectorLocation), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordSelector.LocationProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.LocationPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.OrientationPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Vertical));
			global::Infragistics.Windows.DataPresenter.RecordSelector.OrientationProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.OrientationPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.RecordPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Record", typeof(global::Infragistics.Windows.DataPresenter.Record), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.RecordSelector.RecordProperty = global::Infragistics.Windows.DataPresenter.RecordSelector.RecordPropertyKey.DependencyProperty;
			global::Infragistics.Windows.DataPresenter.RecordSelector.InternalVersionProperty = global::System.Windows.DependencyProperty.Register("InternalVersion", typeof(int), typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(0));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), global::System.Windows.Input.Mouse.MouseLeaveEvent, new global::System.Windows.Input.MouseEventHandler(global::Infragistics.Windows.DataPresenter.RecordSelector.OnMouseLeave));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnVisualStatePropertyChanged)));
			global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.RecordSelector), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.DataPresenter.RecordSelector.OnVisualStatePropertyChanged)), global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorPropertyKey);
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x000AA15C File Offset: 0x000A835C
		public RecordSelector()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.RecordSelector.StyleSelectorHelper(this);
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x000AA170 File Offset: 0x000A8370
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._verifyActiveStatePending)
			{
				this.VerifyActiveState();
			}
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x000AA199 File Offset: 0x000A8399
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordSelectorAutomationPeer(this);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x000AA1A1 File Offset: 0x000A83A1
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x000AA1B0 File Offset: 0x000A83B0
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x000AA1C0 File Offset: 0x000A83C0
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnPropertyChanged(e);
			if (e.Property == global::System.Windows.FrameworkElement.DataContextProperty)
			{
				global::Infragistics.Windows.DataPresenter.Record record = e.NewValue as global::Infragistics.Windows.DataPresenter.Record;
				if (record != this._record)
				{
					if (this._record != null)
					{
						global::System.ComponentModel.PropertyChangedEventManager.RemoveListener(this._record, this, string.Empty);
					}
					this._record = record;
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.RecordPropertyKey, this._record);
					this._tracker = null;
					this._trackerForFixedButton = null;
					if (this._record != null)
					{
						this.InitializeVersionInfo();
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsActivePropertyKey, global::Infragistics.KnownBoxes.FromValue(this._record.IsActive));
						global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this._record as global::Infragistics.Windows.DataPresenter.DataRecord;
						if (dataRecord != null)
						{
							this._trackerForFixedButton = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._record.FieldLayout, "RecordSelectorExtentResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnRecordSelectorExtentChanged));
							this.OnRecordSelectorExtentChanged();
							if (dataRecord.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord)
							{
								base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFilterRecordPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
								this.OnFilterVisibilityChanged();
								this._tracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(this._record.FieldLayout, "FilterClearButtonLocationResolved", new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnFilterVisibilityChanged));
							}
							else
							{
								base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsAddRecordPropertyKey, global::Infragistics.KnownBoxes.FromValue(dataRecord.IsAddRecord));
								base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataChangedPropertyKey, global::Infragistics.KnownBoxes.FromValue(dataRecord.IsDataChanged));
								this.UpdateDataError();
							}
						}
						global::System.ComponentModel.PropertyChangedEventManager.AddListener(this._record, this, string.Empty);
						return;
					}
				}
			}
			else
			{
				if (e.Property == global::Infragistics.Windows.DataPresenter.RecordSelector.InternalVersionProperty)
				{
					this.InitializeVersionInfo();
					return;
				}
				if (e.Property == global::System.Windows.UIElement.IsVisibleProperty && (bool)e.NewValue)
				{
					this.VerifyIsFixedAllowedProperties();
				}
			}
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000AA36C File Offset: 0x000A856C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("RecordSelector: ");
			if (this.Record != null)
			{
				stringBuilder.Append(this.Record.ToString());
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x000AA3AB File Offset: 0x000A85AB
		protected virtual void OnActivated(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x000AA3B4 File Offset: 0x000A85B4
		internal void RaiseActivated(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.RecordSelector.ActivatedEvent;
			args.Source = this;
			this.OnActivated(args);
		}

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x060026EF RID: 9967 RVA: 0x000AA3CF File Offset: 0x000A85CF
		// (remove) Token: 0x060026F0 RID: 9968 RVA: 0x000AA3DD File Offset: 0x000A85DD
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> Activated
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.RecordSelector.ActivatedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.RecordSelector.ActivatedEvent, value);
			}
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x000AA3EB File Offset: 0x000A85EB
		protected virtual void OnDeactivated(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x000AA3F4 File Offset: 0x000A85F4
		internal void RaiseDeactivated(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.RecordSelector.DeactivatedEvent;
			args.Source = this;
			this.OnDeactivated(args);
		}

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x060026F3 RID: 9971 RVA: 0x000AA40F File Offset: 0x000A860F
		// (remove) Token: 0x060026F4 RID: 9972 RVA: 0x000AA41D File Offset: 0x000A861D
		public event global::System.EventHandler<global::System.Windows.RoutedEventArgs> Deactivated
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.RecordSelector.DeactivatedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.RecordSelector.DeactivatedEvent, value);
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x000AA42B File Offset: 0x000A862B
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public object DataError
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.DataErrorProperty);
			}
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x000AA438 File Offset: 0x000A8638
		internal void UpdateDataError()
		{
			bool value = false;
			object value2 = null;
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = this.Record as global::Infragistics.Windows.DataPresenter.DataRecord;
			if (dataRecord != null)
			{
				value2 = dataRecord.DataError;
				value = dataRecord.HasDataError;
			}
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.HasDataErrorPropertyKey, global::Infragistics.KnownBoxes.FromValue(value));
			base.SetValue(global::Infragistics.Windows.DataPresenter.DataRecordPresenter.DataErrorPropertyKey, value2);
			global::Infragistics.Windows.DataPresenter.RecordSelector.UpdateDataErrorDisplayModeProperties(dataRecord, this);
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x000AA48C File Offset: 0x000A868C
		internal static void UpdateDataErrorDisplayModeProperties(global::Infragistics.Windows.DataPresenter.DataRecord dr, global::System.Windows.DependencyObject elem)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (dr != null) ? dr.FieldLayout : null;
			global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode dataErrorDisplayMode = (fieldLayout != null) ? fieldLayout.DataErrorDisplayModeResolved : global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.None;
			elem.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconPropertyKey, global::Infragistics.KnownBoxes.FromValue(global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.ErrorIcon == dataErrorDisplayMode || global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.ErrorIconAndHighlight == dataErrorDisplayMode));
			elem.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeHighlightPropertyKey, global::Infragistics.KnownBoxes.FromValue(global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.Highlight == dataErrorDisplayMode || global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.ErrorIconAndHighlight == dataErrorDisplayMode));
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x000AA4EC File Offset: 0x000A86EC
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = target as global::Infragistics.Windows.DataPresenter.RecordSelector;
			if (recordSelector != null)
			{
				recordSelector._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				recordSelector.InitializeVersionInfo();
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060026F9 RID: 9977 RVA: 0x000AA51B File Offset: 0x000A871B
		// (set) Token: 0x060026FA RID: 9978 RVA: 0x000AA523 File Offset: 0x000A8723
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._cachedFieldLayout;
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FieldLayoutProperty, value);
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x060026FB RID: 9979 RVA: 0x000AA531 File Offset: 0x000A8731
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility FilterClearButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FilterClearButtonVisibilityProperty);
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x000AA543 File Offset: 0x000A8743
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility FixedButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FixedButtonVisibilityProperty);
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x060026FD RID: 9981 RVA: 0x000AA555 File Offset: 0x000A8755
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public bool HasDataError
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.HasDataErrorProperty);
			}
		}

		// Token: 0x060026FE RID: 9982 RVA: 0x000AA568 File Offset: 0x000A8768
		private static void OnIsActiveChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = target as global::Infragistics.Windows.DataPresenter.RecordSelector;
			if (recordSelector != null)
			{
				recordSelector.VerifyActiveState();
				recordSelector.UpdateVisualStates();
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x060026FF RID: 9983 RVA: 0x000AA58B File Offset: 0x000A878B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsActiveProperty);
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x000AA59D File Offset: 0x000A879D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsAddRecordProperty);
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x000AA5AF File Offset: 0x000A87AF
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDataChanged
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataChangedProperty);
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002702 RID: 9986 RVA: 0x000AA5C1 File Offset: 0x000A87C1
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDataErrorDisplayModeHighlight
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeHighlightProperty);
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x000AA5D3 File Offset: 0x000A87D3
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsDataErrorDisplayModeIcon
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconProperty);
			}
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x06002704 RID: 9988 RVA: 0x000AA5E5 File Offset: 0x000A87E5
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsFilterRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFilterRecordProperty);
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x000AA5F7 File Offset: 0x000A87F7
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsFixedOnBottomAllowed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnBottomAllowedProperty);
			}
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x000AA609 File Offset: 0x000A8809
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsFixedOnTopAllowed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnTopAllowedProperty);
			}
		}

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06002707 RID: 9991 RVA: 0x000AA61B File Offset: 0x000A881B
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSelectorLocation Location
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordSelectorLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.LocationProperty);
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x000AA62D File Offset: 0x000A882D
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.OrientationProperty);
			}
		}

		// Token: 0x17000B72 RID: 2930
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x000AA63F File Offset: 0x000A883F
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x17000B73 RID: 2931
		// (get) Token: 0x0600270A RID: 9994 RVA: 0x000AA647 File Offset: 0x000A8847
		// (set) Token: 0x0600270B RID: 9995 RVA: 0x000AA659 File Offset: 0x000A8859
		internal int InternalVersion
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.InternalVersionProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.InternalVersionProperty, value);
			}
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x000AA66C File Offset: 0x000A886C
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
			if (this.IsDataChanged)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Changed", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unchanged", useTransitions);
			}
			if (record != null && record.FixedLocation != global::Infragistics.Windows.DataPresenter.FixedRecordLocation.Scrollable)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Fixed", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unfixed", useTransitions);
			}
			string text = null;
			switch (this.Location)
			{
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.AboveCellArea:
				text = "Top";
				break;
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.BelowCellArea:
				text = "Bottom";
				break;
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.LeftOfCellArea:
				text = "Left";
				break;
			case global::Infragistics.Windows.DataPresenter.RecordSelectorLocation.RightOfCellArea:
				text = "Right";
				break;
			}
			if (text != null)
			{
				global::System.Windows.VisualStateManager.GoToState(this, text, useTransitions);
			}
			if (this.IsFilterRecord)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "FilterRecord", useTransitions);
			}
			else if (this.IsAddRecord)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "AddRecord", useTransitions);
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "DataRecord", useTransitions);
			}
			if (this.HasDataError)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "InvalidEx", useTransitions);
				return;
			}
			global::System.Windows.VisualStateManager.GoToState(this, "ValidEx", useTransitions);
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x000AA7F4 File Offset: 0x000A89F4
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = target as global::Infragistics.Windows.DataPresenter.RecordSelector;
			if (recordSelector != null)
			{
				recordSelector.UpdateVisualStates();
			}
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x000AA811 File Offset: 0x000A8A11
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000AA81A File Offset: 0x000A8A1A
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

		// Token: 0x06002710 RID: 10000 RVA: 0x000AA838 File Offset: 0x000A8A38
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
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.OrientationPropertyKey, global::Infragistics.KnownBoxes.FromValue(this._cachedFieldLayout.StyleGenerator.LogicalOrientation));
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.LocationPropertyKey, this._cachedFieldLayout.RecordSelectorLocationResolved);
				}
				this._versionInitialized = true;
			}
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x000AA8D6 File Offset: 0x000A8AD6
		private void OnRecordSelectorExtentChanged()
		{
			this.VerifyIsFixedAllowedProperties();
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x000AA8E0 File Offset: 0x000A8AE0
		private void OnFilterVisibilityChanged()
		{
			if (this._record != null)
			{
				switch (this._record.FieldLayout.FilterClearButtonLocationResolved)
				{
				case global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.RecordSelector:
				case global::Infragistics.Windows.DataPresenter.FilterClearButtonLocation.RecordSelectorAndFilterCell:
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FilterClearButtonVisibilityPropertyKey, global::Infragistics.KnownBoxes.VisibilityVisibleBox);
					return;
				}
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FilterClearButtonVisibilityPropertyKey);
			}
		}

		// Token: 0x06002713 RID: 10003 RVA: 0x000AA938 File Offset: 0x000A8B38
		private static void OnMouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = e.OriginalSource as global::Infragistics.Windows.DataPresenter.RecordSelector;
			if (recordSelector != null && !recordSelector.IsLoaded)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000AA964 File Offset: 0x000A8B64
		private void OnRecordPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.DataRecord dataRecord = sender as global::Infragistics.Windows.DataPresenter.DataRecord;
			string propertyName;
			switch (propertyName = e.PropertyName)
			{
			case "ActiveCell":
			case "IsActive":
				base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsActivePropertyKey, global::Infragistics.KnownBoxes.FromValue(((global::Infragistics.Windows.DataPresenter.Record)sender).IsActive));
				return;
			case "IsAddRecord":
				if (dataRecord != null)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsAddRecordPropertyKey, global::Infragistics.KnownBoxes.FromValue(dataRecord.IsAddRecord));
					this.VerifyIsFixedAllowedProperties();
					return;
				}
				break;
			case "IsDataChanged":
				if (dataRecord != null)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataChangedPropertyKey, global::Infragistics.KnownBoxes.FromValue(dataRecord.IsDataChanged));
					return;
				}
				break;
			case "IsEnabledResolved":
				this.UpdateVisualStates();
				return;
			case "DataError":
				this.UpdateDataError();
				return;
			case "ParentRecord":
				this.VerifyIsFixedAllowedProperties();
				break;

				return;
			}
		}

		// Token: 0x06002715 RID: 10005 RVA: 0x000AAA90 File Offset: 0x000A8C90
		private void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Unloaded -= this.OnUnloaded;
			bool wasActive = this._wasActive;
			this._wasActive = false;
			base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsActivePropertyKey);
			this._wasActive = wasActive;
			if (wasActive)
			{
				base.Loaded += this.OnLoaded;
			}
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x000AAAE4 File Offset: 0x000A8CE4
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this._activatedEventPending)
			{
				this._activatedEventPending = false;
				this.RaiseActivated(new global::System.Windows.RoutedEventArgs());
			}
			base.Loaded -= this.OnLoaded;
			if (this._record != null)
			{
				if (this._record.IsActive)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					return;
				}
				this.VerifyActiveState();
			}
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000AAB4C File Offset: 0x000A8D4C
		private void VerifyActiveState()
		{
			if (global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this) == 0)
			{
				this._verifyActiveStatePending = true;
				return;
			}
			this._verifyActiveStatePending = false;
			bool isActive = this.IsActive;
			if (this._wasActive != isActive)
			{
				this._wasActive = isActive;
				if (isActive)
				{
					if (base.IsLoaded)
					{
						this.RaiseActivated(new global::System.Windows.RoutedEventArgs());
						base.Unloaded += this.OnUnloaded;
						return;
					}
					this._activatedEventPending = true;
					base.Loaded += this.OnLoaded;
					return;
				}
				else
				{
					this.RaiseDeactivated(new global::System.Windows.RoutedEventArgs());
					base.Unloaded -= this.OnUnloaded;
					base.Loaded -= this.OnLoaded;
				}
			}
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000AABFC File Offset: 0x000A8DFC
		private void VerifyIsFixedAllowedProperties()
		{
			if (this._record != null)
			{
				bool flag = false;
				bool flag2 = false;
				global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = this._record.DataPresenter;
				if (dataPresenter != null && !dataPresenter.IsReportControl && this._record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.DataRecord && !((global::Infragistics.Windows.DataPresenter.DataRecord)this._record).IsAddRecord && this._record.FieldLayout.FixedRecordUITypeResolved == global::Infragistics.Windows.DataPresenter.FixedRecordUIType.Button)
				{
					switch (this._record.FieldLayout.AllowRecordFixingResolved)
					{
					case global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Top:
						flag = true;
						break;
					case global::Infragistics.Windows.DataPresenter.AllowRecordFixing.Bottom:
						flag2 = true;
						break;
					case global::Infragistics.Windows.DataPresenter.AllowRecordFixing.TopOrBottom:
						flag = true;
						flag2 = (this._record.ParentRecord == null);
						break;
					}
					global::Infragistics.Windows.DataPresenter.ViewBase currentViewInternal = dataPresenter.CurrentViewInternal;
					if (!currentViewInternal.IsFixedRecordsSupported || (!currentViewInternal.IsFixingSupportedForNestedRecords && this._record.ParentRecord != null))
					{
						flag = false;
						flag2 = false;
					}
				}
				if (flag || flag2)
				{
					if (!flag && this._record.ParentRecord != null)
					{
						flag2 = false;
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FixedButtonVisibilityPropertyKey, global::Infragistics.KnownBoxes.VisibilityHiddenBox);
					}
					else
					{
						global::System.Windows.Visibility visibility = (this._record.RecordType == global::Infragistics.Windows.DataPresenter.RecordType.FilterRecord) ? global::System.Windows.Visibility.Hidden : global::System.Windows.Visibility.Visible;
						base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FixedButtonVisibilityPropertyKey, visibility);
					}
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FixedButtonVisibilityPropertyKey);
				}
				if (flag2)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnBottomAllowedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				else
				{
					base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnBottomAllowedPropertyKey);
				}
				if (flag)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnTopAllowedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					return;
				}
				base.ClearValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnTopAllowedPropertyKey);
			}
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000AAD70 File Offset: 0x000A8F70
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

		// Token: 0x04001276 RID: 4726
		private int _cachedVersion;

		// Token: 0x04001277 RID: 4727
		private bool _versionInitialized;

		// Token: 0x04001278 RID: 4728
		private bool _wasActive;

		// Token: 0x04001279 RID: 4729
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x0400127A RID: 4730
		private global::Infragistics.Windows.DataPresenter.RecordSelector.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x0400127B RID: 4731
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x0400127C RID: 4732
		private global::Infragistics.Windows.Internal.PropertyValueTracker _trackerForFixedButton;

		// Token: 0x0400127D RID: 4733
		private bool _hasVisualStateGroups;

		// Token: 0x0400127E RID: 4734
		private bool _activatedEventPending;

		// Token: 0x0400127F RID: 4735
		private bool _verifyActiveStatePending;

		// Token: 0x04001282 RID: 4738
		public static readonly global::System.Windows.DependencyProperty DataErrorProperty;

		// Token: 0x04001283 RID: 4739
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty;

		// Token: 0x04001284 RID: 4740
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x04001285 RID: 4741
		private static readonly global::System.Windows.DependencyPropertyKey FilterClearButtonVisibilityPropertyKey;

		// Token: 0x04001286 RID: 4742
		public static readonly global::System.Windows.DependencyProperty FilterClearButtonVisibilityProperty;

		// Token: 0x04001287 RID: 4743
		private static readonly global::System.Windows.DependencyPropertyKey FixedButtonVisibilityPropertyKey;

		// Token: 0x04001288 RID: 4744
		public static readonly global::System.Windows.DependencyProperty FixedButtonVisibilityProperty;

		// Token: 0x04001289 RID: 4745
		public static readonly global::System.Windows.DependencyProperty HasDataErrorProperty;

		// Token: 0x0400128A RID: 4746
		private static readonly global::System.Windows.DependencyPropertyKey IsActivePropertyKey;

		// Token: 0x0400128B RID: 4747
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;

		// Token: 0x0400128C RID: 4748
		private static readonly global::System.Windows.DependencyPropertyKey IsAddRecordPropertyKey;

		// Token: 0x0400128D RID: 4749
		public static readonly global::System.Windows.DependencyProperty IsAddRecordProperty;

		// Token: 0x0400128E RID: 4750
		private static readonly global::System.Windows.DependencyPropertyKey IsDataChangedPropertyKey;

		// Token: 0x0400128F RID: 4751
		public static readonly global::System.Windows.DependencyProperty IsDataChangedProperty;

		// Token: 0x04001290 RID: 4752
		internal static readonly global::System.Windows.DependencyPropertyKey IsDataErrorDisplayModeHighlightPropertyKey;

		// Token: 0x04001291 RID: 4753
		public static readonly global::System.Windows.DependencyProperty IsDataErrorDisplayModeHighlightProperty;

		// Token: 0x04001292 RID: 4754
		internal static readonly global::System.Windows.DependencyPropertyKey IsDataErrorDisplayModeIconPropertyKey;

		// Token: 0x04001293 RID: 4755
		public static readonly global::System.Windows.DependencyProperty IsDataErrorDisplayModeIconProperty;

		// Token: 0x04001294 RID: 4756
		private static readonly global::System.Windows.DependencyPropertyKey IsFilterRecordPropertyKey;

		// Token: 0x04001295 RID: 4757
		public static readonly global::System.Windows.DependencyProperty IsFilterRecordProperty;

		// Token: 0x04001296 RID: 4758
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedOnBottomAllowedPropertyKey;

		// Token: 0x04001297 RID: 4759
		public static readonly global::System.Windows.DependencyProperty IsFixedOnBottomAllowedProperty;

		// Token: 0x04001298 RID: 4760
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedOnTopAllowedPropertyKey;

		// Token: 0x04001299 RID: 4761
		public static readonly global::System.Windows.DependencyProperty IsFixedOnTopAllowedProperty;

		// Token: 0x0400129A RID: 4762
		private static readonly global::System.Windows.DependencyPropertyKey LocationPropertyKey;

		// Token: 0x0400129B RID: 4763
		public static readonly global::System.Windows.DependencyProperty LocationProperty;

		// Token: 0x0400129C RID: 4764
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey;

		// Token: 0x0400129D RID: 4765
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;

		// Token: 0x0400129E RID: 4766
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey;

		// Token: 0x0400129F RID: 4767
		public static readonly global::System.Windows.DependencyProperty RecordProperty;

		// Token: 0x040012A0 RID: 4768
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty;

		// Token: 0x0200032B RID: 811
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x0600271A RID: 10010 RVA: 0x000AADA4 File Offset: 0x000A8FA4
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.RecordSelector rs) : base(rs)
			{
				this._rs = rs;
			}

			// Token: 0x17000B74 RID: 2932
			// (get) Token: 0x0600271B RID: 10011 RVA: 0x000AADB4 File Offset: 0x000A8FB4
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
							return dataPresenter.InternalRecordSelectorStyleSelector.SelectStyle(this._rs.DataContext, this._rs);
						}
					}
					return null;
				}
			}

			// Token: 0x040012A1 RID: 4769
			private global::Infragistics.Windows.DataPresenter.RecordSelector _rs;
		}
	}
}
