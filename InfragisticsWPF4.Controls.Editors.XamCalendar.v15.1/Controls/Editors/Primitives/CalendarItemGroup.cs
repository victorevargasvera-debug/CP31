using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using Infragistics.AutomationPeers;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200001E RID: 30
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Century", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Decade", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Day", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Month", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Year", GroupName = "CalendarStates")]
	public class CalendarItemGroup : global::System.Windows.Controls.Control, global::Infragistics.Controls.Editors.Primitives.ICalendarElement, global::Infragistics.ICommandTarget
	{
		// Token: 0x0600015D RID: 349 RVA: 0x0000868C File Offset: 0x0000688C
		static CalendarItemGroup()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnVisualStatePropertyChanged)));
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000089AD File Offset: 0x00006BAD
		public CalendarItemGroup() : this(new global::System.DateTime?(global::Infragistics.Controls.Editors.CalendarManager.GetGroupStartDate(global::System.DateTime.Today, global::Infragistics.Controls.Editors.CalendarZoomMode.Days, global::System.Globalization.CultureInfo.CurrentCulture.Calendar, global::Infragistics.Controls.DayOfWeekFlags.None)), false)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000089D1 File Offset: 0x00006BD1
		internal CalendarItemGroup(global::System.DateTime? firstDate, bool isSizingGroup)
		{
			this._isSizingGroup = isSizingGroup;
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.FirstDateOfGroupPropertyKey, firstDate);
			base.Loaded += this.OnLoaded;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000160 RID: 352 RVA: 0x00008A0A File Offset: 0x00006C0A
		internal bool AllowAnimation
		{
			get
			{
				return !this.IsGroupForSizing && global::System.Windows.SystemParameters.ClientAreaAnimation;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000161 RID: 353 RVA: 0x00008A1B File Offset: 0x00006C1B
		internal global::Infragistics.Controls.Editors.CalendarManager CalendarManager
		{
			get
			{
				if (this._control == null)
				{
					return global::Infragistics.Controls.Editors.CalendarManager.CurrentCulture;
				}
				return this._control.CalendarManager;
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00008A38 File Offset: 0x00006C38
		private static void OnModeInternalChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)d;
			global::Infragistics.Controls.Editors.CalendarAnimation value;
			if (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.IsZoomFocus(calendarItemGroup))
			{
				value = (((global::Infragistics.Controls.Editors.CalendarZoomMode)e.NewValue > (global::Infragistics.Controls.Editors.CalendarZoomMode)e.OldValue) ? global::Infragistics.Controls.Editors.CalendarAnimation.ZoomOut : global::Infragistics.Controls.Editors.CalendarAnimation.ZoomIn);
			}
			else
			{
				value = global::Infragistics.Controls.Editors.CalendarAnimation.Fade;
			}
			calendarItemGroup.PrepareForAnimation(new global::Infragistics.Controls.Editors.CalendarAnimation?(value));
			calendarItemGroup.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.CurrentModePropertyKey, e.NewValue);
			calendarItemGroup.OnCalendarModeChanged();
			calendarItemGroup.PerformPendingAnimation(new global::Infragistics.Controls.Editors.CalendarAnimation?(value));
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00008AA7 File Offset: 0x00006CA7
		// (set) Token: 0x06000164 RID: 356 RVA: 0x00008AB9 File Offset: 0x00006CB9
		internal global::Infragistics.Controls.Editors.CalendarZoomMode ModeInternal
		{
			get
			{
				return (global::Infragistics.Controls.Editors.CalendarZoomMode)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ModeInternalProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ModeInternalProperty, value);
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00008ACC File Offset: 0x00006CCC
		internal global::System.DateTime FirstDate
		{
			get
			{
				global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItem> items = this.Items;
				if (items.Count > 0)
				{
					return items[0].StartDate;
				}
				return this.CalendarManager.Calendar.MinSupportedDateTime.Date;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000166 RID: 358 RVA: 0x00008B0E File Offset: 0x00006D0E
		internal bool IsGroupForSizing
		{
			get
			{
				return this._isSizingGroup;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00008B16 File Offset: 0x00006D16
		internal bool IsLeadingOrTrailingGroup
		{
			get
			{
				return this.IsLeadingGroup || this.IsTrailingGroup;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00008B28 File Offset: 0x00006D28
		internal global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea ItemArea
		{
			get
			{
				return this._itemArea;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00008B30 File Offset: 0x00006D30
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		internal global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItem> Items
		{
			get
			{
				if (this._itemArea == null)
				{
					return new global::Infragistics.Controls.Editors.Primitives.CalendarItem[0];
				}
				return this._itemArea.Items;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00008B4C File Offset: 0x00006D4C
		internal global::System.DateTime LastDate
		{
			get
			{
				global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItem> items = this.Items;
				if (items.Count > 0)
				{
					return items[items.Count - 1].EndDate;
				}
				return this.CalendarManager.Calendar.MaxSupportedDateTime.Date;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00008B95 File Offset: 0x00006D95
		private global::System.DateTime? ReferenceDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ReferenceDateProperty);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00008BA8 File Offset: 0x00006DA8
		private static void OnReferenceDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)d;
			global::Infragistics.Controls.Editors.CalendarAnimation? action = (e.NewValue != null && e.OldValue != null) ? new global::Infragistics.Controls.Editors.CalendarAnimation?(global::Infragistics.Controls.Editors.CalendarAnimation.Scroll) : null;
			calendarItemGroup.PrepareForAnimation(action);
			calendarItemGroup.InitializeFirstDateOfGroup();
			calendarItemGroup.PerformPendingAnimation(action);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00008BF4 File Offset: 0x00006DF4
		private static void OnCurrentModeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarZoomMode newMode = (global::Infragistics.Controls.Editors.CalendarZoomMode)e.NewValue;
			global::Infragistics.Controls.Editors.CalendarZoomMode oldMode = (global::Infragistics.Controls.Editors.CalendarZoomMode)e.OldValue;
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = target as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				calendarItemGroup.OnCurrentModeChanged(newMode, oldMode);
				return;
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel calendarItemAreaPanel = target as global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel;
			if (calendarItemAreaPanel != null)
			{
				calendarItemAreaPanel.OnCurrentModeChanged(newMode, oldMode);
				return;
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItemArea calendarItemArea = target as global::Infragistics.Controls.Editors.Primitives.CalendarItemArea;
			if (calendarItemArea != null)
			{
				calendarItemArea.OnCurrentModeChanged(newMode, oldMode);
				return;
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = target as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			if (calendarItem != null)
			{
				calendarItem.OnCurrentModeChanged(newMode, oldMode);
			}
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00008C6C File Offset: 0x00006E6C
		private void OnCurrentModeChanged(global::Infragistics.Controls.Editors.CalendarZoomMode newMode, global::Infragistics.Controls.Editors.CalendarZoomMode oldMode)
		{
			global::System.Windows.DependencyObject dependencyObject = this._itemArea as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.SetCurrentMode(dependencyObject, newMode);
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00008C8F File Offset: 0x00006E8F
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup))]
		public static global::Infragistics.Controls.Editors.CalendarZoomMode GetCurrentMode(global::System.Windows.DependencyObject target)
		{
			return (global::Infragistics.Controls.Editors.CalendarZoomMode)target.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.CurrentModeProperty);
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00008CA1 File Offset: 0x00006EA1
		internal static void SetCurrentMode(global::System.Windows.DependencyObject target, global::Infragistics.Controls.Editors.CalendarZoomMode value)
		{
			target.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.CurrentModePropertyKey, value);
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000171 RID: 369 RVA: 0x00008CB4 File Offset: 0x00006EB4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Controls.Editors.CalendarZoomMode CurrentMode
		{
			get
			{
				return global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this);
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00008CBC File Offset: 0x00006EBC
		private static void OnFirstDateOfGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)d;
			calendarItemGroup.SuspendInitialize();
			try
			{
				calendarItemGroup.InitializeLastDateOfGroup();
				calendarItemGroup.InitializeItems();
			}
			finally
			{
				calendarItemGroup.ResumeInitialize();
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000173 RID: 371 RVA: 0x00008CFC File Offset: 0x00006EFC
		// (set) Token: 0x06000174 RID: 372 RVA: 0x00008D0E File Offset: 0x00006F0E
		public global::System.DateTime? FirstDateOfGroup
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.FirstDateOfGroupProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.FirstDateOfGroupPropertyKey, value);
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00008D21 File Offset: 0x00006F21
		private static void OnIsLeadingGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)d;
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00008D2C File Offset: 0x00006F2C
		private static void OnIsLeadingOrTrailingGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)d;
			if (calendarItemGroup._control != null)
			{
				calendarItemGroup._control.ResolveReferenceDate();
				calendarItemGroup.UpdateVisualStates();
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000177 RID: 375 RVA: 0x00008D59 File Offset: 0x00006F59
		// (set) Token: 0x06000178 RID: 376 RVA: 0x00008D6B File Offset: 0x00006F6B
		[global::System.ComponentModel.Bindable(true)]
		public bool IsLeadingGroup
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.IsLeadingGroupProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.IsLeadingGroupProperty, value);
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000179 RID: 377 RVA: 0x00008D7E File Offset: 0x00006F7E
		// (set) Token: 0x0600017A RID: 378 RVA: 0x00008D90 File Offset: 0x00006F90
		[global::System.ComponentModel.Bindable(true)]
		public bool IsTrailingGroup
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.IsTrailingGroupProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.IsTrailingGroupProperty, value);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00008DA3 File Offset: 0x00006FA3
		// (set) Token: 0x0600017C RID: 380 RVA: 0x00008DB5 File Offset: 0x00006FB5
		public global::System.DateTime? LastDateOfGroup
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.LastDateOfGroupProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.LastDateOfGroupPropertyKey, value);
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00008DC8 File Offset: 0x00006FC8
		private static void OnReferenceGroupOffsetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)d;
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(calendarItemGroup);
			if (calendar != null && !calendarItemGroup.IsGroupForSizing)
			{
				calendar.OnGroupOffsetChanged(calendarItemGroup, (int)e.OldValue, (int)e.NewValue);
			}
			calendarItemGroup.InitializeFirstDateOfGroup();
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017E RID: 382 RVA: 0x00008E13 File Offset: 0x00007013
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00008E25 File Offset: 0x00007025
		[global::System.ComponentModel.Bindable(true)]
		public int ReferenceGroupOffset
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ReferenceGroupOffsetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ReferenceGroupOffsetProperty, value);
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00008E38 File Offset: 0x00007038
		private static void OnShowLeadingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)d).InitializeItems();
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000181 RID: 385 RVA: 0x00008E45 File Offset: 0x00007045
		// (set) Token: 0x06000182 RID: 386 RVA: 0x00008E57 File Offset: 0x00007057
		[global::System.ComponentModel.Bindable(true)]
		public bool ShowLeadingDates
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ShowLeadingDatesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ShowLeadingDatesProperty, value);
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00008E6A File Offset: 0x0000706A
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00008E7C File Offset: 0x0000707C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollNextButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ScrollNextButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ScrollNextButtonVisibilityProperty, value);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00008E8F File Offset: 0x0000708F
		// (set) Token: 0x06000186 RID: 390 RVA: 0x00008EA1 File Offset: 0x000070A1
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollPreviousButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ScrollPreviousButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ScrollPreviousButtonVisibilityProperty, value);
			}
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00008EB4 File Offset: 0x000070B4
		private static void OnShowTrailingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)d).InitializeItems();
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00008EC1 File Offset: 0x000070C1
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00008ED3 File Offset: 0x000070D3
		[global::System.ComponentModel.Bindable(true)]
		public bool ShowTrailingDates
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ShowTrailingDatesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ShowTrailingDatesProperty, value);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600018A RID: 394 RVA: 0x00008EE6 File Offset: 0x000070E6
		// (set) Token: 0x0600018B RID: 395 RVA: 0x00008EF8 File Offset: 0x000070F8
		public string Title
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.TitleProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.TitlePropertyKey, value);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600018C RID: 396 RVA: 0x00008F06 File Offset: 0x00007106
		private bool IsInitializeSuspended
		{
			get
			{
				return this._suspendInitializeCount > 0;
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00008F11 File Offset: 0x00007111
		internal void ClearQueuedAnimations()
		{
			if (this._queuedAnimations != null)
			{
				this._queuedAnimations.Clear();
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00008F28 File Offset: 0x00007128
		internal int CompareDate(global::System.DateTime date)
		{
			date = date.Date;
			if (date < this.FirstDateOfGroup)
			{
				return -1;
			}
			if (date > this.LastDateOfGroup)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00008F8B File Offset: 0x0000718B
		internal void EnqueueAnimation(global::System.Windows.Media.Animation.Storyboard sb, global::Infragistics.Controls.Editors.Primitives.CalendarItemArea area, bool isOldArea)
		{
			if (sb != null && area != null)
			{
				if (!this._isProcessingAnimations)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.BeginStoryboard(sb, area, isOldArea);
					return;
				}
				if (this._queuedAnimations == null)
				{
					this._queuedAnimations = new global::System.Collections.Generic.Queue<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ItemAreaAnimation>();
				}
				this._queuedAnimations.Enqueue(new global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ItemAreaAnimation(sb, area, isOldArea));
			}
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00008FCA File Offset: 0x000071CA
		internal global::Infragistics.Controls.Editors.Primitives.CalendarItem GetItem(global::System.DateTime date)
		{
			if (this._itemArea == null)
			{
				return null;
			}
			return this._itemArea.GetItem(date);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00008FE2 File Offset: 0x000071E2
		internal global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber GetWeekNumber(int weekNumber)
		{
			if (this._itemArea == null)
			{
				return null;
			}
			return this._itemArea.GetWeekNumber(weekNumber);
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00008FFC File Offset: 0x000071FC
		private static bool IsZoomFocus(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup c)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(c);
			return calendar != null && calendar.IsZoomFocusGroup(c);
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000901C File Offset: 0x0000721C
		internal bool LoadItemsLazily(bool loadDays)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel calendarItemAreaPanel = this._itemArea as global::Infragistics.Controls.Editors.Primitives.CalendarItemAreaPanel;
			return calendarItemAreaPanel != null && calendarItemAreaPanel.LoadItemsLazily(loadDays);
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00009044 File Offset: 0x00007244
		internal void OnCalendarChange(global::Infragistics.Controls.Editors.CalendarChange change)
		{
			bool flag;
			switch (change)
			{
			case global::Infragistics.Controls.Editors.CalendarChange.SelectionChanged:
			case global::Infragistics.Controls.Editors.CalendarChange.CurrentModeChanged:
			case global::Infragistics.Controls.Editors.CalendarChange.IsSelectionActiveChanged:
			case global::Infragistics.Controls.Editors.CalendarChange.ReferenceDateChanged:
				flag = false;
				goto IL_2A;
			}
			flag = true;
			try
			{
				IL_2A:
				if (flag)
				{
					this.SuspendInitialize();
				}
				switch (change)
				{
				case global::Infragistics.Controls.Editors.CalendarChange.WeekRuleChanged:
				case global::Infragistics.Controls.Editors.CalendarChange.WeekNumberVisibility:
					if (this._itemArea != null)
					{
						this._itemArea.InitializeWeekNumbers();
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.FirstDayOfWeekChanged:
					if (this.ShowLeadingDates || this.ShowTrailingDates)
					{
						this.InitializeItems();
					}
					else if (this._itemArea != null)
					{
						this._itemArea.InitializeFirstItemOffset();
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.DaysOfWeekChanged:
					this.InitializeItems();
					if (this._itemArea != null)
					{
						this._itemArea.InitializeRowColCount();
						this._itemArea.InitializeDaysOfWeek();
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.AllowableDatesChanged:
					this.InitializeFirstDateOfGroup();
					this.InitializeLastDateOfGroup();
					this.InitializeItems();
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.DisabledDatesChanged:
					this.InitializeFirstDateOfGroup();
					this.InitializeLastDateOfGroup();
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange.Enabled);
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.CalendarInfoChanged:
					this.InitializeFirstDateOfGroup();
					this.InitializeLastDateOfGroup();
					this.InitializeItems();
					this.FormatTitle();
					if (this._itemArea != null)
					{
						this._itemArea.InitializeRowColCount();
						this._itemArea.InitializeDaysOfWeek();
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.ItemStyleChange:
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange.Style);
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.SelectionChanged:
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange.Selection);
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.WorkdaysChanged:
					this.InitializeItems();
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.CurrentModeChanged:
				case global::Infragistics.Controls.Editors.CalendarChange.ReferenceDateChanged:
				{
					global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
					if (calendar != null)
					{
						this.SynchronizeModeAndRefDate();
					}
					break;
				}
				case global::Infragistics.Controls.Editors.CalendarChange.TodayChanged:
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange.Today);
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.IsSelectionActiveChanged:
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange.IsSelectionActive);
					}
					break;
				case global::Infragistics.Controls.Editors.CalendarChange.Resources:
					if (this._title != null)
					{
						this._title.SetProviderBrushes();
					}
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange.Resources);
					}
					break;
				}
			}
			finally
			{
				if (flag)
				{
					this.ResumeInitialize();
				}
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00009290 File Offset: 0x00007490
		internal void OnMouseEnter()
		{
			this._isMouseOver = true;
			this.UpdateVisualStates();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000929F File Offset: 0x0000749F
		internal void OnMouseLeave()
		{
			this._isMouseOver = false;
			this.UpdateVisualStates();
		}

		// Token: 0x06000197 RID: 407 RVA: 0x000092AE File Offset: 0x000074AE
		internal void RegisterItemArea(global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea itemArea)
		{
			this._itemArea = itemArea;
			if (this._itemArea != null)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.SetCurrentMode(this._itemArea as global::System.Windows.DependencyObject, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this));
				this.InitializeItems();
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x000092DB File Offset: 0x000074DB
		internal void RegisterTitle(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle title)
		{
			this._title = title;
			if (this._title != null && this._control != null)
			{
				global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(title, this._control);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00009300 File Offset: 0x00007500
		private void ResumeAnimations(bool preventedAnimations)
		{
			if (preventedAnimations)
			{
				this._preventAnimationCount--;
			}
			this._suspendAnimationCount--;
			if (this._suspendAnimationCount == 0)
			{
				this.PerformPendingAnimation(this._pendingAnimation);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00009335 File Offset: 0x00007535
		internal void ResumeInitialize()
		{
			this.ResumeInitializeImpl();
			this.ResumeAnimations(true);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00009344 File Offset: 0x00007544
		private void ResumeInitializeImpl()
		{
			this._suspendInitializeCount--;
			if (this._suspendInitializeCount == 0 && this._initializeNeeded)
			{
				this.InitializeItems();
			}
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000936A File Offset: 0x0000756A
		private void SuspendAnimations(bool preventAnimations)
		{
			this._suspendAnimationCount++;
			if (preventAnimations)
			{
				this._preventAnimationCount++;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000938B File Offset: 0x0000758B
		internal void SuspendInitialize()
		{
			this.SuspendInitializeImpl();
			this.SuspendAnimations(true);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000939A File Offset: 0x0000759A
		private void SuspendInitializeImpl()
		{
			this._suspendInitializeCount++;
		}

		// Token: 0x0600019F RID: 415 RVA: 0x000093AA File Offset: 0x000075AA
		internal void UnregisterItemArea(global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea itemArea)
		{
			if (itemArea == this._itemArea)
			{
				this._itemArea = null;
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x000093BC File Offset: 0x000075BC
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Disabled", useTransitions);
			}
			else if (this._isMouseOver)
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
			bool isKeyboardFocusWithin = base.IsKeyboardFocusWithin;
			if (isKeyboardFocusWithin)
			{
				global::Infragistics.VisualStateUtilities.GoToState(this, useTransitions, new string[]
				{
					"Focused",
					"Unfocused"
				});
			}
			else
			{
				global::System.Windows.VisualStateManager.GoToState(this, "Unfocused", useTransitions);
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GoToCalendarState(this, useTransitions);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00009458 File Offset: 0x00007658
		internal static void GoToCalendarState(global::System.Windows.Controls.Control control, bool useTransitions)
		{
			string stateName;
			switch (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(control))
			{
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
				stateName = "Month";
				goto IL_49;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
				stateName = "Year";
				goto IL_49;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
				stateName = "Decade";
				goto IL_49;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				stateName = "Century";
				goto IL_49;
			}
			stateName = "Day";
			IL_49:
			global::System.Windows.VisualStateManager.GoToState(control, stateName, useTransitions);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x000094B8 File Offset: 0x000076B8
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = target as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				calendarItemGroup.UpdateVisualStates();
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x000094D5 File Offset: 0x000076D5
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x000094DE File Offset: 0x000076DE
		protected void UpdateVisualStates(bool useTransitions)
		{
			if (!this._hasVisualStateGroups)
			{
				return;
			}
			if (!this._isInitialized)
			{
				useTransitions = false;
			}
			this.SetVisualState(useTransitions);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x000094FB File Offset: 0x000076FB
		internal static void BeginStoryboard(global::System.Windows.Media.Animation.Storyboard sb, global::Infragistics.Controls.Editors.Primitives.CalendarItemArea area, bool isOldArea)
		{
			if (sb != null)
			{
				sb.Begin(area, global::System.Windows.Media.Animation.HandoffBehavior.Compose, true);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009509 File Offset: 0x00007709
		private global::System.DateTime? CoerceMinMaxDate(global::System.DateTime? date)
		{
			if (date != null && this._control != null)
			{
				date = new global::System.DateTime?(this._control.ConstrainBetweenMinMaxDate(date.Value));
			}
			return date;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00009538 File Offset: 0x00007738
		private void FormatTitle()
		{
			global::System.DateTime? firstDateOfGroup = this.FirstDateOfGroup;
			if (firstDateOfGroup == null)
			{
				this.Title = null;
				return;
			}
			bool flag = false;
			string format;
			switch (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this))
			{
			default:
				format = "{0:y}";
				break;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
				format = "{0:yyyy}";
				break;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				format = "{0:yyyy}-{1:yyyy}";
				flag = true;
				break;
			}
			global::System.Globalization.DateTimeFormatInfo dateTimeFormatInfo = null;
			if (this._control != null)
			{
				dateTimeFormatInfo = this._control.CalendarManager.DateTimeFormat;
			}
			if (dateTimeFormatInfo == null)
			{
				dateTimeFormatInfo = global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
			}
			if (flag)
			{
				this.Title = string.Format(dateTimeFormatInfo, format, new object[]
				{
					firstDateOfGroup.Value,
					this.LastDateOfGroup
				});
				return;
			}
			this.Title = string.Format(dateTimeFormatInfo, format, new object[]
			{
				firstDateOfGroup.Value
			});
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00009624 File Offset: 0x00007824
		private void InitializeControl(global::Infragistics.Controls.Editors.CalendarBase control)
		{
			if (control == this._control)
			{
				return;
			}
			this._control = control;
			if (control != null)
			{
				this.SuspendInitialize();
				try
				{
					global::Infragistics.Controls.Editors.CalendarZoomMode modeInternal = this.ModeInternal;
					this.SynchronizeModeAndRefDate();
					if (modeInternal == this.ModeInternal)
					{
						this.OnCalendarModeChanged();
					}
					if (this._title != null)
					{
						global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this._title, this._control);
					}
					return;
				}
				finally
				{
					this.ResumeInitialize();
				}
			}
			if (this._title != null)
			{
				global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this._title, null);
				this._title.ClearGroup();
			}
			if (this._itemArea != null)
			{
				global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this._itemArea as global::System.Windows.UIElement, null);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x000096D4 File Offset: 0x000078D4
		private void InitializeItems()
		{
			if (!this._isInitialized)
			{
				return;
			}
			if (this.IsInitializeSuspended)
			{
				this._initializeNeeded = true;
				return;
			}
			this._initializeNeeded = false;
			if (this._itemArea != null)
			{
				this._itemArea.InitializeItems();
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000970C File Offset: 0x0000790C
		private void InitializeFirstDateOfGroup()
		{
			global::System.DateTime date = this.ReferenceDate ?? this.CalendarManager.CoerceMinMaxDate(global::System.DateTime.Today);
			global::Infragistics.Controls.Editors.CalendarZoomMode modeInternal = this.ModeInternal;
			date = this.CalendarManager.GetGroupStartDate(date, modeInternal);
			global::System.DateTime? dateTime = this.CalendarManager.TryAddGroupOffset(date, this.ReferenceGroupOffset, modeInternal, true);
			if (dateTime != null && this._control != null)
			{
				if (!this.IsGroupForSizing && (dateTime > this._control.MaxDateResolved || this.CalendarManager.GetGroupEndDate(dateTime.Value, modeInternal) < this._control.MinDateResolved))
				{
					dateTime = null;
				}
				dateTime = this.CoerceMinMaxDate(dateTime);
			}
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.FirstDateOfGroupPropertyKey, dateTime);
			this.InvalidateItemGroupPanelArrange();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00009800 File Offset: 0x00007A00
		private void InitializeLastDateOfGroup()
		{
			global::System.DateTime? firstDateOfGroup = this.FirstDateOfGroup;
			global::System.DateTime? dateTime = (firstDateOfGroup != null) ? new global::System.DateTime?(this.CalendarManager.GetGroupEndDate(firstDateOfGroup.Value, this.ModeInternal)) : null;
			dateTime = this.CoerceMinMaxDate(dateTime);
			global::System.DateTime? lastDateOfGroup = this.LastDateOfGroup;
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.LastDateOfGroupPropertyKey, dateTime);
			if (lastDateOfGroup != dateTime)
			{
				this.InitializeItems();
			}
			this.FormatTitle();
			this.InvalidateItemGroupPanelArrange();
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000098B4 File Offset: 0x00007AB4
		private void InvalidateItemGroupPanelArrange()
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupPanel calendarItemGroupPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupPanel;
			if (calendarItemGroupPanel != null)
			{
				calendarItemGroupPanel.InvalidateArrange();
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000098D8 File Offset: 0x00007AD8
		private void OnCalendarModeChanged()
		{
			this.SuspendInitialize();
			try
			{
				this.InitializeFirstDateOfGroup();
				this.InitializeLastDateOfGroup();
				if (this._itemArea != null)
				{
					this._itemArea.InitializeRowColCount();
				}
				this.InitializeItems();
				this.FormatTitle();
			}
			finally
			{
				this.ResumeInitialize();
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00009930 File Offset: 0x00007B30
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			base.Loaded -= this.OnLoaded;
			this.InitializeItems();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000994C File Offset: 0x00007B4C
		private void PerformPendingAnimation(global::Infragistics.Controls.Editors.CalendarAnimation? action)
		{
			if (action != null && this._itemArea != null && action == this._pendingAnimation && this._suspendAnimationCount == 0)
			{
				this._pendingAnimation = null;
				this._isProcessingAnimations = true;
				try
				{
					this._itemArea.PerformAnimationAction(action.Value);
				}
				finally
				{
					this._isProcessingAnimations = false;
					if (this._queuedAnimations != null)
					{
						this.UpdateLayoutHelper();
						base.Dispatcher.BeginInvoke(new global::System.Action(this.ProcessQueueddAnimations), new object[0]);
					}
				}
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00009A14 File Offset: 0x00007C14
		private void PrepareForAnimation(global::Infragistics.Controls.Editors.CalendarAnimation? action)
		{
			if (this._itemArea != null && this._preventAnimationCount == 0 && this.AllowAnimation && this._pendingAnimation == null && action != null)
			{
				this._pendingAnimation = action;
				this._itemArea.PrepareForAnimationAction(action.Value);
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00009A68 File Offset: 0x00007C68
		private void ProcessQueueddAnimations()
		{
			if (this._queuedAnimations == null)
			{
				return;
			}
			while (this._queuedAnimations.Count > 0)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ItemAreaAnimation itemAreaAnimation = this._queuedAnimations.Dequeue();
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.BeginStoryboard(itemAreaAnimation.Storyboard, itemAreaAnimation.ItemArea, itemAreaAnimation.IsOldArea);
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00009AB4 File Offset: 0x00007CB4
		private void SynchronizeModeAndRefDate()
		{
			if (this._control == null)
			{
				return;
			}
			if (this.IsGroupForSizing)
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ModeInternalProperty, this._control.MinCalendarModeResolved);
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ReferenceDateProperty, this._control.GetValue(global::Infragistics.Controls.Editors.CalendarBase.MeasureDateProperty));
				return;
			}
			this.SuspendAnimations(false);
			try
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ModeInternalProperty, this._control.CurrentMode);
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ReferenceDateProperty, this._control.ReferenceDate);
			}
			finally
			{
				this.ResumeAnimations(false);
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00009B60 File Offset: 0x00007D60
		private void UpdateLayoutHelper()
		{
			global::Infragistics.Controls.Editors.CalendarBase control = this._control;
			if (control != null)
			{
				control.UpdateLayoutHelper();
				return;
			}
			base.UpdateLayout();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00009B84 File Offset: 0x00007D84
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (!this._isInitialized)
			{
				this._isInitialized = true;
				this.InitializeItems();
			}
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = global::Infragistics.Controls.PresentationUtilities.GetTemplatedParent(this) as global::Infragistics.Controls.Editors.CalendarBase;
			if (calendarBase != null)
			{
				global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this, calendarBase);
			}
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00009BD5 File Offset: 0x00007DD5
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.CalendarItemGroupAutomationPeer(this);
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00009BDD File Offset: 0x00007DDD
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00009BE6 File Offset: 0x00007DE6
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00009BF5 File Offset: 0x00007DF5
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.OnMouseEnter();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00009C04 File Offset: 0x00007E04
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.OnMouseLeave();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00009C14 File Offset: 0x00007E14
		public override string ToString()
		{
			if (this.FirstDateOfGroup != null && this.LastDateOfGroup != null)
			{
				return string.Format(this.CalendarManager.DateTimeFormat, "CalendarItemGroup {0:d}-{1:d}", new object[]
				{
					this.FirstDateOfGroup,
					this.LastDateOfGroup
				});
			}
			return base.ToString();
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00009C81 File Offset: 0x00007E81
		void global::Infragistics.Controls.Editors.Primitives.ICalendarElement.OnCalendarChanged(global::Infragistics.Controls.Editors.CalendarBase newValue, global::Infragistics.Controls.Editors.CalendarBase oldValue)
		{
			this.InitializeControl(newValue);
			if (oldValue != null)
			{
				oldValue.UnregisterGroup(this);
			}
			if (newValue != null)
			{
				newValue.RegisterGroup(this);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00009C9E File Offset: 0x00007E9E
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			if (!(source is global::Infragistics.Controls.Editors.Primitives.CalendarCommandSource))
			{
				return null;
			}
			return this;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00009CAB File Offset: 0x00007EAB
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Editors.Primitives.CalendarCommand;
		}

		// Token: 0x0400007E RID: 126
		private global::Infragistics.Controls.Editors.CalendarBase _control;

		// Token: 0x0400007F RID: 127
		private int _suspendInitializeCount;

		// Token: 0x04000080 RID: 128
		private int _suspendAnimationCount;

		// Token: 0x04000081 RID: 129
		private int _preventAnimationCount;

		// Token: 0x04000082 RID: 130
		private bool _isSizingGroup;

		// Token: 0x04000083 RID: 131
		private bool _initializeNeeded = true;

		// Token: 0x04000084 RID: 132
		private global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea _itemArea;

		// Token: 0x04000085 RID: 133
		private global::Infragistics.Controls.Editors.CalendarAnimation? _pendingAnimation;

		// Token: 0x04000086 RID: 134
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupTitle _title;

		// Token: 0x04000087 RID: 135
		private bool _isMouseOver;

		// Token: 0x04000088 RID: 136
		private bool _isInitialized;

		// Token: 0x04000089 RID: 137
		private bool _isProcessingAnimations;

		// Token: 0x0400008A RID: 138
		private global::System.Collections.Generic.Queue<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.ItemAreaAnimation> _queuedAnimations;

		// Token: 0x0400008B RID: 139
		private bool _hasVisualStateGroups;

		// Token: 0x0400008C RID: 140
		internal static readonly global::System.Windows.DependencyProperty ModeInternalProperty = global::Infragistics.DependencyPropertyUtilities.Register("ModeInternal", typeof(global::Infragistics.Controls.Editors.CalendarZoomMode), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Editors.CalendarZoomMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnModeInternalChanged)));

		// Token: 0x0400008D RID: 141
		private static readonly global::System.Windows.DependencyProperty ReferenceDateProperty = global::Infragistics.DependencyPropertyUtilities.Register("ReferenceDate", typeof(global::System.DateTime?), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnReferenceDateChanged));

		// Token: 0x0400008E RID: 142
		internal static readonly global::System.Windows.DependencyPropertyKey CurrentModePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterAttachedReadOnly("CurrentMode", typeof(global::Infragistics.Controls.Editors.CalendarZoomMode), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.Controls.Editors.CalendarZoomMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnCurrentModeChanged));

		// Token: 0x0400008F RID: 143
		public static readonly global::System.Windows.DependencyProperty CurrentModeProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.CurrentModePropertyKey.DependencyProperty;

		// Token: 0x04000090 RID: 144
		private static readonly global::System.Windows.DependencyPropertyKey FirstDateOfGroupPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("FirstDateOfGroup", typeof(global::System.DateTime?), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnFirstDateOfGroupChanged));

		// Token: 0x04000091 RID: 145
		public static readonly global::System.Windows.DependencyProperty FirstDateOfGroupProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.FirstDateOfGroupPropertyKey.DependencyProperty;

		// Token: 0x04000092 RID: 146
		public static readonly global::System.Windows.DependencyProperty IsLeadingGroupProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsLeadingGroup", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnIsLeadingOrTrailingGroupChanged)));

		// Token: 0x04000093 RID: 147
		public static readonly global::System.Windows.DependencyProperty IsTrailingGroupProperty = global::Infragistics.DependencyPropertyUtilities.Register("IsTrailingGroup", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnIsLeadingOrTrailingGroupChanged)));

		// Token: 0x04000094 RID: 148
		private static readonly global::System.Windows.DependencyPropertyKey LastDateOfGroupPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("LastDateOfGroup", typeof(global::System.DateTime?), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), null, null);

		// Token: 0x04000095 RID: 149
		public static readonly global::System.Windows.DependencyProperty LastDateOfGroupProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.LastDateOfGroupPropertyKey.DependencyProperty;

		// Token: 0x04000096 RID: 150
		public static readonly global::System.Windows.DependencyProperty ReferenceGroupOffsetProperty = global::Infragistics.DependencyPropertyUtilities.Register("ReferenceGroupOffset", typeof(int), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Editors.CalendarUtilities.ZeroInt, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnReferenceGroupOffsetChanged)));

		// Token: 0x04000097 RID: 151
		public static readonly global::System.Windows.DependencyProperty ShowLeadingDatesProperty = global::Infragistics.DependencyPropertyUtilities.Register("ShowLeadingDates", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnShowLeadingDatesChanged)));

		// Token: 0x04000098 RID: 152
		public static readonly global::System.Windows.DependencyProperty ScrollNextButtonVisibilityProperty = global::Infragistics.DependencyPropertyUtilities.Register("ScrollNextButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000099 RID: 153
		public static readonly global::System.Windows.DependencyProperty ScrollPreviousButtonVisibilityProperty = global::Infragistics.DependencyPropertyUtilities.Register("ScrollPreviousButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x0400009A RID: 154
		public static readonly global::System.Windows.DependencyProperty ShowTrailingDatesProperty = global::Infragistics.DependencyPropertyUtilities.Register("ShowTrailingDates", typeof(bool), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.OnShowTrailingDatesChanged)));

		// Token: 0x0400009B RID: 155
		private static readonly global::System.Windows.DependencyPropertyKey TitlePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("Title", typeof(string), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup), null, null);

		// Token: 0x0400009C RID: 156
		public static readonly global::System.Windows.DependencyProperty TitleProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.TitlePropertyKey.DependencyProperty;

		// Token: 0x0200001F RID: 31
		internal class GroupInitializationHelper : global::System.IDisposable
		{
			// Token: 0x060001BE RID: 446 RVA: 0x00009CB6 File Offset: 0x00007EB6
			internal GroupInitializationHelper(global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup> groups) : this(groups, true)
			{
			}

			// Token: 0x060001BF RID: 447 RVA: 0x00009CC0 File Offset: 0x00007EC0
			internal GroupInitializationHelper(global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup> groups, bool preventAnimations)
			{
				this._groups = groups;
				this._preventedAnimations = preventAnimations;
				foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup in groups)
				{
					calendarItemGroup.SuspendAnimations(preventAnimations);
					calendarItemGroup.SuspendInitializeImpl();
				}
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x00009D24 File Offset: 0x00007F24
			public void Dispose()
			{
				global::Infragistics.Controls.Editors.CalendarBase calendarBase = (this._groups.Count > 0) ? global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(this._groups[0]) : null;
				if (calendarBase != null)
				{
					calendarBase.SuspendUpdateLayout();
				}
				try
				{
					this.DisposeImpl();
				}
				finally
				{
					if (calendarBase != null)
					{
						calendarBase.ResumeUpdateLayout();
					}
				}
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00009D80 File Offset: 0x00007F80
			private void DisposeImpl()
			{
				foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup in this._groups)
				{
					calendarItemGroup.ResumeInitializeImpl();
				}
				foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup2 in this._groups)
				{
					calendarItemGroup2.ResumeAnimations(this._preventedAnimations);
				}
			}

			// Token: 0x0400009D RID: 157
			private global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup> _groups;

			// Token: 0x0400009E RID: 158
			private bool _preventedAnimations;
		}

		// Token: 0x02000020 RID: 32
		private struct ItemAreaAnimation
		{
			// Token: 0x060001C2 RID: 450 RVA: 0x00009E10 File Offset: 0x00008010
			internal ItemAreaAnimation(global::System.Windows.Media.Animation.Storyboard sb, global::Infragistics.Controls.Editors.Primitives.CalendarItemArea area, bool isOldArea)
			{
				this._sb = sb;
				this._area = area;
				this.IsOldArea = isOldArea;
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060001C3 RID: 451 RVA: 0x00009E27 File Offset: 0x00008027
			internal global::System.Windows.Media.Animation.Storyboard Storyboard
			{
				get
				{
					return this._sb;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060001C4 RID: 452 RVA: 0x00009E2F File Offset: 0x0000802F
			internal global::Infragistics.Controls.Editors.Primitives.CalendarItemArea ItemArea
			{
				get
				{
					return this._area;
				}
			}

			// Token: 0x0400009F RID: 159
			private global::System.Windows.Media.Animation.Storyboard _sb;

			// Token: 0x040000A0 RID: 160
			private global::Infragistics.Controls.Editors.Primitives.CalendarItemArea _area;

			// Token: 0x040000A1 RID: 161
			internal readonly bool IsOldArea;
		}
	}
}
