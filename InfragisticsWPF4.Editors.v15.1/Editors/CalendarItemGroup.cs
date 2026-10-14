using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using Infragistics.Controls;
using Infragistics.Windows.Automation.Peers.Editors;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000037 RID: 55
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Day", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Month", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Year", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Century", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Decade", GroupName = "CalendarStates")]
	public class CalendarItemGroup : global::System.Windows.Controls.Control
	{
		// Token: 0x06000396 RID: 918 RVA: 0x0000F0CC File Offset: 0x0000D2CC
		static CalendarItemGroup()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.Editors.XamMonthCalendar.MonthCalendarPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnMonthCalendarChanged)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnVisualStatePropertyChanged)));
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000F407 File Offset: 0x0000D607
		public CalendarItemGroup() : this(new global::System.DateTime?(global::Infragistics.Windows.Editors.CalendarManager.GetGroupStartDate(global::System.DateTime.Today, global::Infragistics.Windows.Editors.CalendarMode.Days, global::System.Globalization.CultureInfo.CurrentCulture.Calendar, global::Infragistics.Controls.DayOfWeekFlags.None)), false)
		{
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000F42B File Offset: 0x0000D62B
		internal CalendarItemGroup(global::System.DateTime? firstDate, bool isSizingGroup)
		{
			this._isSizingGroup = isSizingGroup;
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.FirstDateOfGroupPropertyKey, firstDate);
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000F452 File Offset: 0x0000D652
		internal bool AllowAnimation
		{
			get
			{
				return !this.IsGroupForSizing && global::System.Windows.SystemParameters.ClientAreaAnimation;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600039A RID: 922 RVA: 0x0000F463 File Offset: 0x0000D663
		internal global::Infragistics.Windows.Editors.CalendarManager CalendarManager
		{
			get
			{
				if (this._control == null)
				{
					return global::Infragistics.Windows.Editors.CalendarManager.CurrentCulture;
				}
				return this._control.CalendarManager;
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000F480 File Offset: 0x0000D680
		private static void OnCalendarModeInternalChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)d;
			global::Infragistics.Windows.Editors.CalendarAnimation value;
			if (global::Infragistics.Windows.Editors.CalendarItemGroup.IsZoomFocus(calendarItemGroup))
			{
				value = (((global::Infragistics.Windows.Editors.CalendarMode)e.NewValue > (global::Infragistics.Windows.Editors.CalendarMode)e.OldValue) ? global::Infragistics.Windows.Editors.CalendarAnimation.ZoomOut : global::Infragistics.Windows.Editors.CalendarAnimation.ZoomIn);
			}
			else
			{
				value = global::Infragistics.Windows.Editors.CalendarAnimation.Fade;
			}
			calendarItemGroup.PrepareForAnimation(new global::Infragistics.Windows.Editors.CalendarAnimation?(value));
			calendarItemGroup.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey, e.NewValue);
			calendarItemGroup.OnCalendarModeChanged();
			calendarItemGroup.PerformPendingAnimation(new global::Infragistics.Windows.Editors.CalendarAnimation?(value));
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000F4EF File Offset: 0x0000D6EF
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000F501 File Offset: 0x0000D701
		private global::Infragistics.Windows.Editors.CalendarMode CalendarModeInternal
		{
			get
			{
				return (global::Infragistics.Windows.Editors.CalendarMode)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CalendarModeInternalProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CalendarModeInternalProperty, value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000F514 File Offset: 0x0000D714
		internal global::System.DateTime FirstDate
		{
			get
			{
				global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> items = this.Items;
				if (items.Count > 0)
				{
					return items[0].StartDate;
				}
				return this.CalendarManager.Calendar.MinSupportedDateTime.Date;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600039F RID: 927 RVA: 0x0000F556 File Offset: 0x0000D756
		internal bool IsGroupForSizing
		{
			get
			{
				return this._isSizingGroup;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x0000F55E File Offset: 0x0000D75E
		internal bool IsLeadingOrTrailingGroup
		{
			get
			{
				return this.IsLeadingGroup || this.IsTrailingGroup;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000F570 File Offset: 0x0000D770
		internal global::Infragistics.Windows.Editors.ICalendarItemArea ItemArea
		{
			get
			{
				return this._itemArea;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000F578 File Offset: 0x0000D778
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		internal global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> Items
		{
			get
			{
				if (this._itemArea == null)
				{
					return new global::Infragistics.Windows.Editors.CalendarItem[0];
				}
				return this._itemArea.Items;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x0000F594 File Offset: 0x0000D794
		internal global::System.DateTime LastDate
		{
			get
			{
				global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> items = this.Items;
				if (items.Count > 0)
				{
					return items[items.Count - 1].EndDate;
				}
				return this.CalendarManager.Calendar.MaxSupportedDateTime.Date;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0000F5DD File Offset: 0x0000D7DD
		private global::System.DateTime? ReferenceDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ReferenceDateProperty);
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
		private static void OnReferenceDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)d;
			global::Infragistics.Windows.Editors.CalendarAnimation? action = (e.NewValue != null && e.OldValue != null) ? new global::Infragistics.Windows.Editors.CalendarAnimation?(global::Infragistics.Windows.Editors.CalendarAnimation.Scroll) : null;
			calendarItemGroup.PrepareForAnimation(action);
			calendarItemGroup.InitializeFirstDateOfGroup();
			calendarItemGroup.PerformPendingAnimation(action);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000F63C File Offset: 0x0000D83C
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.Editors.CalendarItem))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.Editors.CalendarItemArea))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup))]
		public static global::Infragistics.Windows.Editors.CalendarMode GetCurrentCalendarMode(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Editors.CalendarMode)d.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModeProperty);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000F64E File Offset: 0x0000D84E
		internal static void SetCurrentCalendarMode(global::System.Windows.DependencyObject d, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			d.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey, mode);
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x0000F661 File Offset: 0x0000D861
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.CalendarMode CurrentCalendarMode
		{
			get
			{
				return global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(this);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000F66C File Offset: 0x0000D86C
		private static void OnFirstDateOfGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)d;
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
			calendarItemGroup.InvalidateItemGroupPanelArrange();
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003AA RID: 938 RVA: 0x0000F6B4 File Offset: 0x0000D8B4
		public global::System.DateTime? FirstDateOfGroup
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.FirstDateOfGroupProperty);
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000F6C8 File Offset: 0x0000D8C8
		private static void OnIsLeadingOrTrailingGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)d;
			if (calendarItemGroup._control != null)
			{
				calendarItemGroup._control.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
				calendarItemGroup.UpdateVisualStates();
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060003AC RID: 940 RVA: 0x0000F6FA File Offset: 0x0000D8FA
		// (set) Token: 0x060003AD RID: 941 RVA: 0x0000F70C File Offset: 0x0000D90C
		[global::System.ComponentModel.Bindable(true)]
		public bool IsLeadingGroup
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.IsLeadingGroupProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.IsLeadingGroupProperty, value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060003AE RID: 942 RVA: 0x0000F71F File Offset: 0x0000D91F
		// (set) Token: 0x060003AF RID: 943 RVA: 0x0000F731 File Offset: 0x0000D931
		[global::System.ComponentModel.Bindable(true)]
		public bool IsTrailingGroup
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.IsTrailingGroupProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.IsTrailingGroupProperty, value);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x0000F744 File Offset: 0x0000D944
		private static void OnLastDateOfGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = d as global::Infragistics.Windows.Editors.CalendarItemGroup;
			calendarItemGroup.InvalidateItemGroupPanelArrange();
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060003B1 RID: 945 RVA: 0x0000F75E File Offset: 0x0000D95E
		public global::System.DateTime? LastDateOfGroup
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.LastDateOfGroupProperty);
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000F770 File Offset: 0x0000D970
		private static void OnReferenceGroupOffsetChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)d;
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(calendarItemGroup);
			if (monthCalendar != null && !calendarItemGroup.IsGroupForSizing)
			{
				monthCalendar.OnGroupOffsetChanged(calendarItemGroup, (int)e.OldValue, (int)e.NewValue);
			}
			calendarItemGroup.InitializeFirstDateOfGroup();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060003B3 RID: 947 RVA: 0x0000F7BB File Offset: 0x0000D9BB
		// (set) Token: 0x060003B4 RID: 948 RVA: 0x0000F7CD File Offset: 0x0000D9CD
		[global::System.ComponentModel.Bindable(true)]
		public int ReferenceGroupOffset
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ReferenceGroupOffsetProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ReferenceGroupOffsetProperty, value);
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		private static void OnShowLeadingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Editors.CalendarItemGroup)d).InitializeItems();
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0000F7ED File Offset: 0x0000D9ED
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x0000F7FF File Offset: 0x0000D9FF
		[global::System.ComponentModel.Bindable(true)]
		public bool ShowLeadingDates
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ShowLeadingDatesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ShowLeadingDatesProperty, value);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x0000F812 File Offset: 0x0000DA12
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x0000F824 File Offset: 0x0000DA24
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollNextButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ScrollNextButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ScrollNextButtonVisibilityProperty, value);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060003BA RID: 954 RVA: 0x0000F837 File Offset: 0x0000DA37
		// (set) Token: 0x060003BB RID: 955 RVA: 0x0000F849 File Offset: 0x0000DA49
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollPreviousButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ScrollPreviousButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ScrollPreviousButtonVisibilityProperty, value);
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000F85C File Offset: 0x0000DA5C
		private static void OnShowTrailingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Editors.CalendarItemGroup)d).InitializeItems();
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000F869 File Offset: 0x0000DA69
		// (set) Token: 0x060003BE RID: 958 RVA: 0x0000F87B File Offset: 0x0000DA7B
		[global::System.ComponentModel.Bindable(true)]
		public bool ShowTrailingDates
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ShowTrailingDatesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ShowTrailingDatesProperty, value);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000F88E File Offset: 0x0000DA8E
		private bool IsInitializeSuspended
		{
			get
			{
				return this._suspendInitializeCount > 0;
			}
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0000F89C File Offset: 0x0000DA9C
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

		// Token: 0x060003C1 RID: 961 RVA: 0x0000F8FF File Offset: 0x0000DAFF
		internal global::Infragistics.Windows.Editors.CalendarItem GetItem(global::System.DateTime date)
		{
			if (this._itemArea == null)
			{
				return null;
			}
			return this._itemArea.GetItem(date);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0000F918 File Offset: 0x0000DB18
		private static bool IsZoomFocus(global::Infragistics.Windows.Editors.CalendarItemGroup c)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(c);
			return monthCalendar != null && monthCalendar.IsZoomFocusGroup(c);
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x0000F938 File Offset: 0x0000DB38
		internal void OnCalendarChange(global::Infragistics.Windows.Editors.MonthCalendarChange change)
		{
			bool flag = change != global::Infragistics.Windows.Editors.MonthCalendarChange.CurrentModeChanged;
			try
			{
				if (flag)
				{
					this.SuspendInitialize();
				}
				switch (change)
				{
				case global::Infragistics.Windows.Editors.MonthCalendarChange.WeekRuleChanged:
					if (this._itemArea != null)
					{
						this._itemArea.InitializeWeekNumbers();
					}
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.FirstDayOfWeekChanged:
					this.InitializeItems();
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.DaysOfWeekChanged:
					this.InitializeItems();
					if (this._itemArea != null)
					{
						this._itemArea.InitializeRowColCount();
					}
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.MinDateChanged:
				case global::Infragistics.Windows.Editors.MonthCalendarChange.MaxDateChanged:
					this.InitializeFirstDateOfGroup();
					this.InitializeLastDateOfGroup();
					this.InitializeItems();
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.DisabledDatesChanged:
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Windows.Editors.CalendarItemChange.Enabled);
					}
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.LanguageChanged:
					this.InitializeFirstDateOfGroup();
					this.InitializeLastDateOfGroup();
					this.InitializeItems();
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.ItemStyleChange:
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Windows.Editors.CalendarItemChange.Style);
					}
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.SelectionChanged:
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Windows.Editors.CalendarItemChange.Selection);
					}
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.WorkdaysChanged:
					this.InitializeItems();
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.CurrentModeChanged:
					if (!this.IsGroupForSizing)
					{
						global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
						if (monthCalendar != null)
						{
							this.CalendarModeInternal = monthCalendar.CurrentCalendarMode;
						}
					}
					break;
				case global::Infragistics.Windows.Editors.MonthCalendarChange.TodayChanged:
					if (this._itemArea != null)
					{
						this._itemArea.ReinitializeItems(global::Infragistics.Windows.Editors.CalendarItemChange.Today);
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

		// Token: 0x060003C4 RID: 964 RVA: 0x0000FAB0 File Offset: 0x0000DCB0
		internal void RegisterItemArea(global::Infragistics.Windows.Editors.ICalendarItemArea itemArea)
		{
			this._itemArea = itemArea;
			if (this._itemArea != null)
			{
				this.InitializeItems();
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000FAC7 File Offset: 0x0000DCC7
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

		// Token: 0x060003C6 RID: 966 RVA: 0x0000FAFC File Offset: 0x0000DCFC
		internal void ResumeInitialize()
		{
			this.ResumeInitializeImpl();
			this.ResumeAnimations(true);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x0000FB0B File Offset: 0x0000DD0B
		private void ResumeInitializeImpl()
		{
			this._suspendInitializeCount--;
			if (this._suspendInitializeCount == 0 && this._initializeNeeded)
			{
				this.InitializeItems();
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x0000FB31 File Offset: 0x0000DD31
		private void SuspendAnimations(bool preventAnimations)
		{
			this._suspendAnimationCount++;
			if (preventAnimations)
			{
				this._preventAnimationCount++;
			}
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x0000FB52 File Offset: 0x0000DD52
		internal void SuspendInitialize()
		{
			this.SuspendInitializeImpl();
			this.SuspendAnimations(true);
		}

		// Token: 0x060003CA RID: 970 RVA: 0x0000FB61 File Offset: 0x0000DD61
		private void SuspendInitializeImpl()
		{
			this._suspendInitializeCount++;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x0000FB71 File Offset: 0x0000DD71
		internal void UnregisterItemArea(global::Infragistics.Windows.Editors.ICalendarItemArea itemArea)
		{
			if (itemArea == this._itemArea)
			{
				this._itemArea = null;
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x0000FB84 File Offset: 0x0000DD84
		protected virtual void SetVisualState(bool useTransitions)
		{
			if (!base.IsEnabled)
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
			global::Infragistics.Windows.Editors.CalendarItemGroup.GoToCalendarState(this, useTransitions);
		}

		// Token: 0x060003CD RID: 973 RVA: 0x0000FC20 File Offset: 0x0000DE20
		internal static void GoToCalendarState(global::System.Windows.Controls.Control control, bool useTransitions)
		{
			string stateName;
			switch (global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(control))
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
				stateName = "Month";
				goto IL_49;
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
				stateName = "Year";
				goto IL_49;
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				stateName = "Decade";
				goto IL_49;
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				stateName = "Century";
				goto IL_49;
			}
			stateName = "Day";
			IL_49:
			global::System.Windows.VisualStateManager.GoToState(control, stateName, useTransitions);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x0000FC80 File Offset: 0x0000DE80
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = target as global::Infragistics.Windows.Editors.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				calendarItemGroup.UpdateVisualStates();
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x0000FC9D File Offset: 0x0000DE9D
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0000FCA6 File Offset: 0x0000DEA6
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

		// Token: 0x060003D1 RID: 977 RVA: 0x0000FCC3 File Offset: 0x0000DEC3
		private global::System.DateTime? CoerceMinMaxDate(global::System.DateTime? date)
		{
			if (date != null && this._control != null)
			{
				date = new global::System.DateTime?(this._control.CoerceMinMaxDate(date.Value));
			}
			return date;
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
		private void InitializeControl(global::Infragistics.Windows.Editors.XamMonthCalendar control)
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
					global::Infragistics.Windows.Editors.CalendarMode calendarModeInternal = this.CalendarModeInternal;
					if (this.IsGroupForSizing)
					{
						base.SetBinding(global::Infragistics.Windows.Editors.CalendarItemGroup.CalendarModeInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Editors.XamMonthCalendar.MinCalendarModeProperty, global::System.Windows.Data.BindingMode.OneWay, control));
					}
					else
					{
						base.SetBinding(global::Infragistics.Windows.Editors.CalendarItemGroup.CalendarModeInternalProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Editors.XamMonthCalendar.CurrentCalendarModeProperty, global::System.Windows.Data.BindingMode.OneWay, control));
					}
					if (this.IsGroupForSizing)
					{
						base.SetBinding(global::Infragistics.Windows.Editors.CalendarItemGroup.ReferenceDateProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Editors.XamMonthCalendar.MeasureDateProperty, global::System.Windows.Data.BindingMode.OneWay, control));
					}
					else
					{
						base.SetBinding(global::Infragistics.Windows.Editors.CalendarItemGroup.ReferenceDateProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty, global::System.Windows.Data.BindingMode.OneWay, control));
					}
					if (calendarModeInternal == this.CalendarModeInternal)
					{
						this.OnCalendarModeChanged();
					}
				}
				finally
				{
					this.ResumeInitialize();
				}
			}
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		private void InitializeItems()
		{
			if (!base.IsInitialized)
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

		// Token: 0x060003D4 RID: 980 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		private void InitializeFirstDateOfGroup()
		{
			global::System.DateTime date = this.ReferenceDate ?? this.CalendarManager.CoerceMinMaxDate(global::System.DateTime.Today);
			global::Infragistics.Windows.Editors.CalendarMode calendarModeInternal = this.CalendarModeInternal;
			date = this.CalendarManager.GetGroupStartDate(date, calendarModeInternal);
			global::System.DateTime? dateTime = this.CalendarManager.TryAddGroupOffset(date, this.ReferenceGroupOffset, calendarModeInternal, true);
			if (dateTime != null && this._control != null)
			{
				if (!this.IsGroupForSizing && (dateTime > this._control.MaxDate || this.CalendarManager.GetGroupEndDate(dateTime.Value, calendarModeInternal) < this._control.MinDate))
				{
					dateTime = null;
				}
				dateTime = this.CoerceMinMaxDate(dateTime);
			}
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.FirstDateOfGroupPropertyKey, dateTime);
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0000FEE4 File Offset: 0x0000E0E4
		private void InitializeLastDateOfGroup()
		{
			global::System.DateTime? firstDateOfGroup = this.FirstDateOfGroup;
			global::System.DateTime? dateTime = (firstDateOfGroup != null) ? new global::System.DateTime?(this.CalendarManager.GetGroupEndDate(firstDateOfGroup.Value, this.CalendarModeInternal)) : null;
			dateTime = this.CoerceMinMaxDate(dateTime);
			global::System.DateTime? lastDateOfGroup = this.LastDateOfGroup;
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.LastDateOfGroupPropertyKey, dateTime);
			if (lastDateOfGroup != dateTime)
			{
				this.InitializeItems();
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0000FF8C File Offset: 0x0000E18C
		private void InvalidateItemGroupPanelArrange()
		{
			global::Infragistics.Windows.Editors.CalendarItemGroupPanel calendarItemGroupPanel = global::System.Windows.Media.VisualTreeHelper.GetParent(this) as global::Infragistics.Windows.Editors.CalendarItemGroupPanel;
			if (calendarItemGroupPanel != null)
			{
				calendarItemGroupPanel.InvalidateArrange();
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0000FFB0 File Offset: 0x0000E1B0
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
			}
			finally
			{
				this.ResumeInitialize();
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00010004 File Offset: 0x0000E204
		private static void OnMonthCalendarChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)d;
			calendarItemGroup.InitializeControl(e.NewValue as global::Infragistics.Windows.Editors.XamMonthCalendar);
			if (e.OldValue != null)
			{
				((global::Infragistics.Windows.Editors.XamMonthCalendar)e.OldValue).UnregisterGroup(calendarItemGroup);
			}
			if (e.NewValue != null)
			{
				((global::Infragistics.Windows.Editors.XamMonthCalendar)e.NewValue).RegisterGroup(calendarItemGroup);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00010060 File Offset: 0x0000E260
		private void PerformPendingAnimation(global::Infragistics.Windows.Editors.CalendarAnimation? action)
		{
			if (action != null && this._itemArea != null && action == this._pendingAnimation && this._suspendAnimationCount == 0)
			{
				this._pendingAnimation = null;
				this._itemArea.PerformAnimationAction(action.Value);
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000100D4 File Offset: 0x0000E2D4
		private void PrepareForAnimation(global::Infragistics.Windows.Editors.CalendarAnimation? action)
		{
			if (this._itemArea != null && this._preventAnimationCount == 0 && this.AllowAnimation && this._pendingAnimation == null && action != null)
			{
				this._pendingAnimation = action;
				this._itemArea.PrepareForAnimationAction(action.Value);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00010128 File Offset: 0x0000E328
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00010143 File Offset: 0x0000E343
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.CalendarItemGroupAutomationPeer(this);
		}

		// Token: 0x060003DD RID: 989 RVA: 0x0001014B File Offset: 0x0000E34B
		protected override void OnInitialized(global::System.EventArgs e)
		{
			this.InitializeItems();
			base.OnInitialized(e);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x0001015A File Offset: 0x0000E35A
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00010169 File Offset: 0x0000E369
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00010178 File Offset: 0x0000E378
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00010188 File Offset: 0x0000E388
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

		// Token: 0x04000152 RID: 338
		private global::Infragistics.Windows.Editors.XamMonthCalendar _control;

		// Token: 0x04000153 RID: 339
		private int _suspendInitializeCount;

		// Token: 0x04000154 RID: 340
		private int _suspendAnimationCount;

		// Token: 0x04000155 RID: 341
		private int _preventAnimationCount;

		// Token: 0x04000156 RID: 342
		private bool _isSizingGroup;

		// Token: 0x04000157 RID: 343
		private bool _initializeNeeded = true;

		// Token: 0x04000158 RID: 344
		private global::Infragistics.Windows.Editors.ICalendarItemArea _itemArea;

		// Token: 0x04000159 RID: 345
		private global::Infragistics.Windows.Editors.CalendarAnimation? _pendingAnimation;

		// Token: 0x0400015A RID: 346
		private bool _hasVisualStateGroups;

		// Token: 0x0400015B RID: 347
		private static readonly global::System.Windows.DependencyProperty CalendarModeInternalProperty = global::System.Windows.DependencyProperty.Register("CalendarModeInternal", typeof(global::Infragistics.Windows.Editors.CalendarMode), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.CalendarMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnCalendarModeInternalChanged)));

		// Token: 0x0400015C RID: 348
		private static readonly global::System.Windows.DependencyProperty ReferenceDateProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnReferenceDateChanged)));

		// Token: 0x0400015D RID: 349
		internal static readonly global::System.Windows.DependencyPropertyKey CurrentCalendarModePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("CurrentCalendarMode", typeof(global::Infragistics.Windows.Editors.CalendarMode), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.CalendarMode.Days, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x0400015E RID: 350
		public static readonly global::System.Windows.DependencyProperty CurrentCalendarModeProperty = global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey.DependencyProperty;

		// Token: 0x0400015F RID: 351
		internal static readonly global::System.Windows.DependencyPropertyKey FirstDateOfGroupPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FirstDateOfGroup", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnFirstDateOfGroupChanged)));

		// Token: 0x04000160 RID: 352
		public static readonly global::System.Windows.DependencyProperty FirstDateOfGroupProperty = global::Infragistics.Windows.Editors.CalendarItemGroup.FirstDateOfGroupPropertyKey.DependencyProperty;

		// Token: 0x04000161 RID: 353
		public static readonly global::System.Windows.DependencyProperty IsLeadingGroupProperty = global::System.Windows.DependencyProperty.Register("IsLeadingGroup", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnIsLeadingOrTrailingGroupChanged)));

		// Token: 0x04000162 RID: 354
		public static readonly global::System.Windows.DependencyProperty IsTrailingGroupProperty = global::System.Windows.DependencyProperty.Register("IsTrailingGroup", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnIsLeadingOrTrailingGroupChanged)));

		// Token: 0x04000163 RID: 355
		private static readonly global::System.Windows.DependencyPropertyKey LastDateOfGroupPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("LastDateOfGroup", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnLastDateOfGroupChanged)));

		// Token: 0x04000164 RID: 356
		public static readonly global::System.Windows.DependencyProperty LastDateOfGroupProperty = global::Infragistics.Windows.Editors.CalendarItemGroup.LastDateOfGroupPropertyKey.DependencyProperty;

		// Token: 0x04000165 RID: 357
		public static readonly global::System.Windows.DependencyProperty ReferenceGroupOffsetProperty = global::System.Windows.DependencyProperty.Register("ReferenceGroupOffset", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnReferenceGroupOffsetChanged)));

		// Token: 0x04000166 RID: 358
		public static readonly global::System.Windows.DependencyProperty ShowLeadingDatesProperty = global::System.Windows.DependencyProperty.Register("ShowLeadingDates", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnShowLeadingDatesChanged)));

		// Token: 0x04000167 RID: 359
		public static readonly global::System.Windows.DependencyProperty ScrollNextButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("ScrollNextButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000168 RID: 360
		public static readonly global::System.Windows.DependencyProperty ScrollPreviousButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("ScrollPreviousButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000169 RID: 361
		public static readonly global::System.Windows.DependencyProperty ShowTrailingDatesProperty = global::System.Windows.DependencyProperty.Register("ShowTrailingDates", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnShowTrailingDatesChanged)));

		// Token: 0x02000038 RID: 56
		internal class GroupInitializationHelper : global::System.IDisposable
		{
			// Token: 0x060003E2 RID: 994 RVA: 0x000101F5 File Offset: 0x0000E3F5
			internal GroupInitializationHelper(global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItemGroup> groups) : this(groups, true)
			{
			}

			// Token: 0x060003E3 RID: 995 RVA: 0x00010200 File Offset: 0x0000E400
			internal GroupInitializationHelper(global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItemGroup> groups, bool preventAnimations)
			{
				this._groups = groups;
				this._preventedAnimations = preventAnimations;
				foreach (global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup in groups)
				{
					calendarItemGroup.SuspendAnimations(preventAnimations);
					calendarItemGroup.SuspendInitializeImpl();
				}
			}

			// Token: 0x060003E4 RID: 996 RVA: 0x00010264 File Offset: 0x0000E464
			public void Dispose()
			{
				foreach (global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup in this._groups)
				{
					calendarItemGroup.ResumeInitializeImpl();
				}
				foreach (global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup2 in this._groups)
				{
					calendarItemGroup2.ResumeAnimations(this._preventedAnimations);
				}
			}

			// Token: 0x0400016A RID: 362
			private global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItemGroup> _groups;

			// Token: 0x0400016B RID: 363
			private bool _preventedAnimations;
		}
	}
}
