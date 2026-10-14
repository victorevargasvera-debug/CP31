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
using Infragistics.Windows.Resizing;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200036B RID: 875
	[global::System.Windows.TemplateVisualState(Name = "Bottom", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfixed", GroupName = "FixedStates")]
	[global::System.Windows.TemplateVisualState(Name = "Right", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "AddRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "DataRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "FilterRecord", GroupName = "RecordStates")]
	[global::System.Windows.TemplateVisualState(Name = "ValidEx", GroupName = "ValidationStatesEx")]
	[global::System.Windows.TemplateVisualState(Name = "InvalidEx", GroupName = "ValidationStatesEx")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Left", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Top", GroupName = "LocationStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Active", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Inactive", GroupName = "ActiveStates")]
	[global::System.Windows.TemplateVisualState(Name = "Changed", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unchanged", GroupName = "ChangeStates")]
	[global::System.Windows.TemplateVisualState(Name = "Fixed", GroupName = "FixedStates")]
	public class RecordSelector : global::System.Windows.Controls.ContentControl, global::System.Windows.IWeakEventListener, global::Infragistics.Windows.Resizing.IResizableElement
	{
		// Token: 0x06002AA6 RID: 10918 RVA: 0x000BE60C File Offset: 0x000BC80C
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

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000BEAF8 File Offset: 0x000BCCF8
		public RecordSelector()
		{
			this._styleSelectorHelper = new global::Infragistics.Windows.DataPresenter.RecordSelector.StyleSelectorHelper(this);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000BEB0C File Offset: 0x000BCD0C
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

		// Token: 0x06002AA9 RID: 10921 RVA: 0x000BEB35 File Offset: 0x000BCD35
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.RecordSelectorAutomationPeer(this);
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x000BEB3D File Offset: 0x000BCD3D
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x000BEB4C File Offset: 0x000BCD4C
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x000BEB80 File Offset: 0x000BCD80
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
					global::Infragistics.Windows.DataPresenter.Record record2 = this._record;
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
					if (record2 != null && base.IsMouseOver)
					{
						global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter = record2.DataPresenter;
						global::Infragistics.Windows.DataPresenter.RecordListControl recordList = dataPresenter.CurrentRecordListControl;
						if (recordList != null && recordList.CaptureMouse())
						{
							dataPresenter.WireLayoutUpdated(delegate
							{
								if (recordList.IsMouseCaptured)
								{
									recordList.ReleaseMouseCapture();
								}
							});
							return;
						}
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

		// Token: 0x06002AAD RID: 10925 RVA: 0x000BED94 File Offset: 0x000BCF94
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

		// Token: 0x06002AAE RID: 10926 RVA: 0x000BEDD3 File Offset: 0x000BCFD3
		protected virtual void OnActivated(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000BEDDC File Offset: 0x000BCFDC
		internal void RaiseActivated(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.RecordSelector.ActivatedEvent;
			args.Source = this;
			this.OnActivated(args);
		}

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x06002AB0 RID: 10928 RVA: 0x000BEDF7 File Offset: 0x000BCFF7
		// (remove) Token: 0x06002AB1 RID: 10929 RVA: 0x000BEE05 File Offset: 0x000BD005
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

		// Token: 0x06002AB2 RID: 10930 RVA: 0x000BEE13 File Offset: 0x000BD013
		protected virtual void OnDeactivated(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x000BEE1C File Offset: 0x000BD01C
		internal void RaiseDeactivated(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.RecordSelector.DeactivatedEvent;
			args.Source = this;
			this.OnDeactivated(args);
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06002AB4 RID: 10932 RVA: 0x000BEE37 File Offset: 0x000BD037
		// (remove) Token: 0x06002AB5 RID: 10933 RVA: 0x000BEE45 File Offset: 0x000BD045
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

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06002AB6 RID: 10934 RVA: 0x000BEE53 File Offset: 0x000BD053
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public object DataError
		{
			get
			{
				return base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.DataErrorProperty);
			}
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000BEE60 File Offset: 0x000BD060
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

		// Token: 0x06002AB8 RID: 10936 RVA: 0x000BEEB4 File Offset: 0x000BD0B4
		internal static void UpdateDataErrorDisplayModeProperties(global::Infragistics.Windows.DataPresenter.DataRecord dr, global::System.Windows.DependencyObject elem)
		{
			global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout = (dr != null) ? dr.FieldLayout : null;
			global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode dataErrorDisplayMode = (fieldLayout != null) ? fieldLayout.DataErrorDisplayModeResolved : global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.None;
			elem.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconPropertyKey, global::Infragistics.KnownBoxes.FromValue(global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.ErrorIcon == dataErrorDisplayMode || global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.ErrorIconAndHighlight == dataErrorDisplayMode));
			elem.SetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeHighlightPropertyKey, global::Infragistics.KnownBoxes.FromValue(global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.Highlight == dataErrorDisplayMode || global::Infragistics.Windows.DataPresenter.DataErrorDisplayMode.ErrorIconAndHighlight == dataErrorDisplayMode));
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x000BEF14 File Offset: 0x000BD114
		private static void OnFieldLayoutChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = target as global::Infragistics.Windows.DataPresenter.RecordSelector;
			if (recordSelector != null)
			{
				recordSelector._cachedFieldLayout = (e.NewValue as global::Infragistics.Windows.DataPresenter.FieldLayout);
				recordSelector.InitializeVersionInfo();
			}
		}

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002ABA RID: 10938 RVA: 0x000BEF43 File Offset: 0x000BD143
		// (set) Token: 0x06002ABB RID: 10939 RVA: 0x000BEF4B File Offset: 0x000BD14B
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

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x000BEF59 File Offset: 0x000BD159
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility FilterClearButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FilterClearButtonVisibilityProperty);
			}
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002ABD RID: 10941 RVA: 0x000BEF6B File Offset: 0x000BD16B
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility FixedButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.FixedButtonVisibilityProperty);
			}
		}

		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x000BEF7D File Offset: 0x000BD17D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool HasDataError
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.HasDataErrorProperty);
			}
		}

		// Token: 0x06002ABF RID: 10943 RVA: 0x000BEF90 File Offset: 0x000BD190
		private static void OnIsActiveChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = target as global::Infragistics.Windows.DataPresenter.RecordSelector;
			if (recordSelector != null)
			{
				recordSelector.VerifyActiveState();
				recordSelector.UpdateVisualStates();
			}
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x000BEFB3 File Offset: 0x000BD1B3
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsActiveProperty);
			}
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x000BEFC5 File Offset: 0x000BD1C5
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsAddRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsAddRecordProperty);
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x000BEFD7 File Offset: 0x000BD1D7
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsDataChanged
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataChangedProperty);
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002AC3 RID: 10947 RVA: 0x000BEFE9 File Offset: 0x000BD1E9
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

		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06002AC4 RID: 10948 RVA: 0x000BEFFB File Offset: 0x000BD1FB
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public bool IsDataErrorDisplayModeIcon
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsDataErrorDisplayModeIconProperty);
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06002AC5 RID: 10949 RVA: 0x000BF00D File Offset: 0x000BD20D
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFilterRecord
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFilterRecordProperty);
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06002AC6 RID: 10950 RVA: 0x000BF01F File Offset: 0x000BD21F
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsFixedOnBottomAllowed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnBottomAllowedProperty);
			}
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002AC7 RID: 10951 RVA: 0x000BF031 File Offset: 0x000BD231
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsFixedOnTopAllowed
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.IsFixedOnTopAllowedProperty);
			}
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x000BF043 File Offset: 0x000BD243
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.RecordSelectorLocation Location
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.RecordSelectorLocation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.LocationProperty);
			}
		}

		// Token: 0x17000CA7 RID: 3239
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x000BF055 File Offset: 0x000BD255
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.RecordSelector.OrientationProperty);
			}
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x000BF067 File Offset: 0x000BD267
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x000BF06F File Offset: 0x000BD26F
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x000BF081 File Offset: 0x000BD281
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

		// Token: 0x06002ACD RID: 10957 RVA: 0x000BF094 File Offset: 0x000BD294
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

		// Token: 0x06002ACE RID: 10958 RVA: 0x000BF21C File Offset: 0x000BD41C
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = target as global::Infragistics.Windows.DataPresenter.RecordSelector;
			if (recordSelector != null)
			{
				recordSelector.UpdateVisualStates();
			}
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x000BF239 File Offset: 0x000BD439
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000BF242 File Offset: 0x000BD442
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

		// Token: 0x06002AD1 RID: 10961 RVA: 0x000BF260 File Offset: 0x000BD460
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

		// Token: 0x06002AD2 RID: 10962 RVA: 0x000BF2FE File Offset: 0x000BD4FE
		private void OnRecordSelectorExtentChanged()
		{
			this.VerifyIsFixedAllowedProperties();
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x000BF308 File Offset: 0x000BD508
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

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000BF360 File Offset: 0x000BD560
		private static void OnMouseLeave(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Infragistics.Windows.DataPresenter.RecordSelector recordSelector = e.OriginalSource as global::Infragistics.Windows.DataPresenter.RecordSelector;
			if (recordSelector != null && !recordSelector.IsLoaded)
			{
				e.Handled = true;
			}
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000BF38C File Offset: 0x000BD58C
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

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000BF4B8 File Offset: 0x000BD6B8
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

		// Token: 0x06002AD7 RID: 10967 RVA: 0x000BF50C File Offset: 0x000BD70C
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this._activatedEventPending && global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(this) > 0)
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

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000BF57C File Offset: 0x000BD77C
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

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000BF62C File Offset: 0x000BD82C
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

		// Token: 0x06002ADA RID: 10970 RVA: 0x000BF7A0 File Offset: 0x000BD9A0
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

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002ADB RID: 10971 RVA: 0x000BF7D4 File Offset: 0x000BD9D4
		object global::Infragistics.Windows.Resizing.IResizableElement.ResizeContext
		{
			get
			{
				return this.Record;
			}
		}

		// Token: 0x04001499 RID: 5273
		private int _cachedVersion;

		// Token: 0x0400149A RID: 5274
		private bool _versionInitialized;

		// Token: 0x0400149B RID: 5275
		private bool _wasActive;

		// Token: 0x0400149C RID: 5276
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x0400149D RID: 5277
		private global::Infragistics.Windows.DataPresenter.RecordSelector.StyleSelectorHelper _styleSelectorHelper;

		// Token: 0x0400149E RID: 5278
		private global::Infragistics.Windows.Internal.PropertyValueTracker _tracker;

		// Token: 0x0400149F RID: 5279
		private global::Infragistics.Windows.Internal.PropertyValueTracker _trackerForFixedButton;

		// Token: 0x040014A0 RID: 5280
		private bool _hasVisualStateGroups;

		// Token: 0x040014A1 RID: 5281
		private bool _activatedEventPending;

		// Token: 0x040014A2 RID: 5282
		private bool _verifyActiveStatePending;

		// Token: 0x040014A5 RID: 5285
		public static readonly global::System.Windows.DependencyProperty DataErrorProperty;

		// Token: 0x040014A6 RID: 5286
		public static readonly global::System.Windows.DependencyProperty FieldLayoutProperty;

		// Token: 0x040014A7 RID: 5287
		private global::Infragistics.Windows.DataPresenter.FieldLayout _cachedFieldLayout;

		// Token: 0x040014A8 RID: 5288
		private static readonly global::System.Windows.DependencyPropertyKey FilterClearButtonVisibilityPropertyKey;

		// Token: 0x040014A9 RID: 5289
		public static readonly global::System.Windows.DependencyProperty FilterClearButtonVisibilityProperty;

		// Token: 0x040014AA RID: 5290
		private static readonly global::System.Windows.DependencyPropertyKey FixedButtonVisibilityPropertyKey;

		// Token: 0x040014AB RID: 5291
		public static readonly global::System.Windows.DependencyProperty FixedButtonVisibilityProperty;

		// Token: 0x040014AC RID: 5292
		public static readonly global::System.Windows.DependencyProperty HasDataErrorProperty;

		// Token: 0x040014AD RID: 5293
		private static readonly global::System.Windows.DependencyPropertyKey IsActivePropertyKey;

		// Token: 0x040014AE RID: 5294
		public static readonly global::System.Windows.DependencyProperty IsActiveProperty;

		// Token: 0x040014AF RID: 5295
		private static readonly global::System.Windows.DependencyPropertyKey IsAddRecordPropertyKey;

		// Token: 0x040014B0 RID: 5296
		public static readonly global::System.Windows.DependencyProperty IsAddRecordProperty;

		// Token: 0x040014B1 RID: 5297
		private static readonly global::System.Windows.DependencyPropertyKey IsDataChangedPropertyKey;

		// Token: 0x040014B2 RID: 5298
		public static readonly global::System.Windows.DependencyProperty IsDataChangedProperty;

		// Token: 0x040014B3 RID: 5299
		internal static readonly global::System.Windows.DependencyPropertyKey IsDataErrorDisplayModeHighlightPropertyKey;

		// Token: 0x040014B4 RID: 5300
		public static readonly global::System.Windows.DependencyProperty IsDataErrorDisplayModeHighlightProperty;

		// Token: 0x040014B5 RID: 5301
		internal static readonly global::System.Windows.DependencyPropertyKey IsDataErrorDisplayModeIconPropertyKey;

		// Token: 0x040014B6 RID: 5302
		public static readonly global::System.Windows.DependencyProperty IsDataErrorDisplayModeIconProperty;

		// Token: 0x040014B7 RID: 5303
		private static readonly global::System.Windows.DependencyPropertyKey IsFilterRecordPropertyKey;

		// Token: 0x040014B8 RID: 5304
		public static readonly global::System.Windows.DependencyProperty IsFilterRecordProperty;

		// Token: 0x040014B9 RID: 5305
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedOnBottomAllowedPropertyKey;

		// Token: 0x040014BA RID: 5306
		public static readonly global::System.Windows.DependencyProperty IsFixedOnBottomAllowedProperty;

		// Token: 0x040014BB RID: 5307
		private static readonly global::System.Windows.DependencyPropertyKey IsFixedOnTopAllowedPropertyKey;

		// Token: 0x040014BC RID: 5308
		public static readonly global::System.Windows.DependencyProperty IsFixedOnTopAllowedProperty;

		// Token: 0x040014BD RID: 5309
		private static readonly global::System.Windows.DependencyPropertyKey LocationPropertyKey;

		// Token: 0x040014BE RID: 5310
		public static readonly global::System.Windows.DependencyProperty LocationProperty;

		// Token: 0x040014BF RID: 5311
		private static readonly global::System.Windows.DependencyPropertyKey OrientationPropertyKey;

		// Token: 0x040014C0 RID: 5312
		public static readonly global::System.Windows.DependencyProperty OrientationProperty;

		// Token: 0x040014C1 RID: 5313
		private static readonly global::System.Windows.DependencyPropertyKey RecordPropertyKey;

		// Token: 0x040014C2 RID: 5314
		public static readonly global::System.Windows.DependencyProperty RecordProperty;

		// Token: 0x040014C3 RID: 5315
		internal static readonly global::System.Windows.DependencyProperty InternalVersionProperty;

		// Token: 0x0200036C RID: 876
		private class StyleSelectorHelper : global::Infragistics.Windows.Helpers.StyleSelectorHelperBase
		{
			// Token: 0x06002ADC RID: 10972 RVA: 0x000BF7DC File Offset: 0x000BD9DC
			internal StyleSelectorHelper(global::Infragistics.Windows.DataPresenter.RecordSelector rs) : base(rs)
			{
				this._rs = rs;
			}

			// Token: 0x17000CAB RID: 3243
			// (get) Token: 0x06002ADD RID: 10973 RVA: 0x000BF7EC File Offset: 0x000BD9EC
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

			// Token: 0x040014C4 RID: 5316
			private global::Infragistics.Windows.DataPresenter.RecordSelector _rs;
		}
	}
}
