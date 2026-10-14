using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using Infragistics.Controls;
using Infragistics.Windows.Automation.Peers.Editors;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000034 RID: 52
	[global::System.Windows.TemplateVisualState(Name = "Year", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Focused", GroupName = "FocusStates")]
	[global::System.Windows.TemplateVisualState(Name = "Decade", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Month", GroupName = "CalendarStates")]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Day", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "MouseOver", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	[global::System.Windows.TemplateVisualState(Name = "Century", GroupName = "CalendarStates")]
	[global::System.Windows.TemplateVisualState(Name = "Unfocused", GroupName = "FocusStates")]
	public class CalendarItemGroup : global::System.Windows.Controls.Control
	{
		// Token: 0x06000376 RID: 886 RVA: 0x0000E814 File Offset: 0x0000CA14
		static CalendarItemGroup()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.Editors.XamMonthCalendar.MonthCalendarPropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnMonthCalendarChanged)));
			global::System.Windows.UIElement.IsEnabledProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnVisualStatePropertyChanged)));
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000EB43 File Offset: 0x0000CD43
		public CalendarItemGroup() : this(new global::System.DateTime?(global::Infragistics.Windows.Editors.CalendarManager.GetGroupStartDate(global::System.DateTime.Today, global::Infragistics.Windows.Editors.CalendarMode.Days, global::System.Globalization.CultureInfo.CurrentCulture.Calendar, global::Infragistics.Controls.DayOfWeekFlags.None)), false)
		{
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000EB67 File Offset: 0x0000CD67
		internal CalendarItemGroup(global::System.DateTime? firstDate, bool isSizingGroup)
		{
			this._isSizingGroup = isSizingGroup;
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.FirstDateOfGroupPropertyKey, firstDate);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0000EB8E File Offset: 0x0000CD8E
		internal bool AllowAnimation
		{
			get
			{
				return !this.IsGroupForSizing && global::System.Windows.SystemParameters.ClientAreaAnimation;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000EB9F File Offset: 0x0000CD9F
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

		// Token: 0x0600037B RID: 891 RVA: 0x0000EBBC File Offset: 0x0000CDBC
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600037C RID: 892 RVA: 0x0000EC2B File Offset: 0x0000CE2B
		// (set) Token: 0x0600037D RID: 893 RVA: 0x0000EC3D File Offset: 0x0000CE3D
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600037E RID: 894 RVA: 0x0000EC50 File Offset: 0x0000CE50
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000EC92 File Offset: 0x0000CE92
		internal bool IsGroupForSizing
		{
			get
			{
				return this._isSizingGroup;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0000EC9A File Offset: 0x0000CE9A
		internal bool IsLeadingOrTrailingGroup
		{
			get
			{
				return this.IsLeadingGroup || this.IsTrailingGroup;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000381 RID: 897 RVA: 0x0000ECAC File Offset: 0x0000CEAC
		internal global::Infragistics.Windows.Editors.ICalendarItemArea ItemArea
		{
			get
			{
				return this._itemArea;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000382 RID: 898 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.ReadOnly(true)]
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

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000383 RID: 899 RVA: 0x0000ECD0 File Offset: 0x0000CED0
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0000ED19 File Offset: 0x0000CF19
		private global::System.DateTime? ReferenceDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.ReferenceDateProperty);
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x0000ED2C File Offset: 0x0000CF2C
		private static void OnReferenceDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)d;
			global::Infragistics.Windows.Editors.CalendarAnimation? action = (e.NewValue != null && e.OldValue != null) ? new global::Infragistics.Windows.Editors.CalendarAnimation?(global::Infragistics.Windows.Editors.CalendarAnimation.Scroll) : null;
			calendarItemGroup.PrepareForAnimation(action);
			calendarItemGroup.InitializeFirstDateOfGroup();
			calendarItemGroup.PerformPendingAnimation(action);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x0000ED78 File Offset: 0x0000CF78
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.Editors.CalendarItem))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup))]
		[global::System.Windows.AttachedPropertyBrowsableForType(typeof(global::Infragistics.Windows.Editors.CalendarItemArea))]
		public static global::Infragistics.Windows.Editors.CalendarMode GetCurrentCalendarMode(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Editors.CalendarMode)d.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModeProperty);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x0000ED8A File Offset: 0x0000CF8A
		internal static void SetCurrentCalendarMode(global::System.Windows.DependencyObject d, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			d.SetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey, mode);
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000388 RID: 904 RVA: 0x0000ED9D File Offset: 0x0000CF9D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.Editors.CalendarMode CurrentCalendarMode
		{
			get
			{
				return global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(this);
			}
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0000EDA8 File Offset: 0x0000CFA8
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
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0000EDE8 File Offset: 0x0000CFE8
		public global::System.DateTime? FirstDateOfGroup
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.FirstDateOfGroupProperty);
			}
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0000EDFC File Offset: 0x0000CFFC
		private static void OnIsLeadingOrTrailingGroupChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)d;
			if (calendarItemGroup._control != null)
			{
				calendarItemGroup._control.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
				calendarItemGroup.UpdateVisualStates();
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600038C RID: 908 RVA: 0x0000EE2E File Offset: 0x0000D02E
		// (set) Token: 0x0600038D RID: 909 RVA: 0x0000EE40 File Offset: 0x0000D040
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

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000EE53 File Offset: 0x0000D053
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000EE65 File Offset: 0x0000D065
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

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000EE78 File Offset: 0x0000D078
		public global::System.DateTime? LastDateOfGroup
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemGroup.LastDateOfGroupProperty);
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000EE8C File Offset: 0x0000D08C
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

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000EED7 File Offset: 0x0000D0D7
		// (set) Token: 0x06000393 RID: 915 RVA: 0x0000EEE9 File Offset: 0x0000D0E9
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

		// Token: 0x06000394 RID: 916 RVA: 0x0000EEFC File Offset: 0x0000D0FC
		private static void OnShowLeadingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Editors.CalendarItemGroup)d).InitializeItems();
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000395 RID: 917 RVA: 0x0000EF09 File Offset: 0x0000D109
		// (set) Token: 0x06000396 RID: 918 RVA: 0x0000EF1B File Offset: 0x0000D11B
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

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0000EF2E File Offset: 0x0000D12E
		// (set) Token: 0x06000398 RID: 920 RVA: 0x0000EF40 File Offset: 0x0000D140
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

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000EF53 File Offset: 0x0000D153
		// (set) Token: 0x0600039A RID: 922 RVA: 0x0000EF65 File Offset: 0x0000D165
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

		// Token: 0x0600039B RID: 923 RVA: 0x0000EF78 File Offset: 0x0000D178
		private static void OnShowTrailingDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Editors.CalendarItemGroup)d).InitializeItems();
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600039C RID: 924 RVA: 0x0000EF85 File Offset: 0x0000D185
		// (set) Token: 0x0600039D RID: 925 RVA: 0x0000EF97 File Offset: 0x0000D197
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600039E RID: 926 RVA: 0x0000EFAA File Offset: 0x0000D1AA
		private bool IsInitializeSuspended
		{
			get
			{
				return this._suspendInitializeCount > 0;
			}
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000EFB8 File Offset: 0x0000D1B8
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

		// Token: 0x060003A0 RID: 928 RVA: 0x0000F01B File Offset: 0x0000D21B
		internal global::Infragistics.Windows.Editors.CalendarItem GetItem(global::System.DateTime date)
		{
			if (this._itemArea == null)
			{
				return null;
			}
			return this._itemArea.GetItem(date);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000F034 File Offset: 0x0000D234
		private static bool IsZoomFocus(global::Infragistics.Windows.Editors.CalendarItemGroup c)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(c);
			return monthCalendar != null && monthCalendar.IsZoomFocusGroup(c);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000F054 File Offset: 0x0000D254
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

		// Token: 0x060003A3 RID: 931 RVA: 0x0000F1CC File Offset: 0x0000D3CC
		internal void RegisterItemArea(global::Infragistics.Windows.Editors.ICalendarItemArea itemArea)
		{
			this._itemArea = itemArea;
			if (this._itemArea != null)
			{
				this.InitializeItems();
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000F1E3 File Offset: 0x0000D3E3
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

		// Token: 0x060003A5 RID: 933 RVA: 0x0000F218 File Offset: 0x0000D418
		internal void ResumeInitialize()
		{
			this.ResumeInitializeImpl();
			this.ResumeAnimations(true);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000F227 File Offset: 0x0000D427
		private void ResumeInitializeImpl()
		{
			this._suspendInitializeCount--;
			if (this._suspendInitializeCount == 0 && this._initializeNeeded)
			{
				this.InitializeItems();
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000F24D File Offset: 0x0000D44D
		private void SuspendAnimations(bool preventAnimations)
		{
			this._suspendAnimationCount++;
			if (preventAnimations)
			{
				this._preventAnimationCount++;
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000F26E File Offset: 0x0000D46E
		internal void SuspendInitialize()
		{
			this.SuspendInitializeImpl();
			this.SuspendAnimations(true);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000F27D File Offset: 0x0000D47D
		private void SuspendInitializeImpl()
		{
			this._suspendInitializeCount++;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x0000F28D File Offset: 0x0000D48D
		internal void UnregisterItemArea(global::Infragistics.Windows.Editors.ICalendarItemArea itemArea)
		{
			if (itemArea == this._itemArea)
			{
				this._itemArea = null;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
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

		// Token: 0x060003AC RID: 940 RVA: 0x0000F33C File Offset: 0x0000D53C
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

		// Token: 0x060003AD RID: 941 RVA: 0x0000F39C File Offset: 0x0000D59C
		internal static void OnVisualStatePropertyChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = target as global::Infragistics.Windows.Editors.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				calendarItemGroup.UpdateVisualStates();
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x0000F3B9 File Offset: 0x0000D5B9
		protected void UpdateVisualStates()
		{
			this.UpdateVisualStates(true);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x0000F3C2 File Offset: 0x0000D5C2
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

		// Token: 0x060003B0 RID: 944 RVA: 0x0000F3DF File Offset: 0x0000D5DF
		private global::System.DateTime? CoerceMinMaxDate(global::System.DateTime? date)
		{
			if (date != null && this._control != null)
			{
				date = new global::System.DateTime?(this._control.CoerceMinMaxDate(date.Value));
			}
			return date;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000F40C File Offset: 0x0000D60C
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

		// Token: 0x060003B2 RID: 946 RVA: 0x0000F4DC File Offset: 0x0000D6DC
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

		// Token: 0x060003B3 RID: 947 RVA: 0x0000F514 File Offset: 0x0000D714
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

		// Token: 0x060003B4 RID: 948 RVA: 0x0000F600 File Offset: 0x0000D800
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

		// Token: 0x060003B5 RID: 949 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
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

		// Token: 0x060003B6 RID: 950 RVA: 0x0000F6FC File Offset: 0x0000D8FC
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

		// Token: 0x060003B7 RID: 951 RVA: 0x0000F758 File Offset: 0x0000D958
		private void PerformPendingAnimation(global::Infragistics.Windows.Editors.CalendarAnimation? action)
		{
			if (action != null && this._itemArea != null && action == this._pendingAnimation && this._suspendAnimationCount == 0)
			{
				this._pendingAnimation = null;
				this._itemArea.PerformAnimationAction(action.Value);
			}
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000F7CC File Offset: 0x0000D9CC
		private void PrepareForAnimation(global::Infragistics.Windows.Editors.CalendarAnimation? action)
		{
			if (this._itemArea != null && this._preventAnimationCount == 0 && this.AllowAnimation && this._pendingAnimation == null && action != null)
			{
				this._pendingAnimation = action;
				this._itemArea.PrepareForAnimationAction(action.Value);
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x0000F820 File Offset: 0x0000DA20
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this._hasVisualStateGroups = global::Infragistics.VisualStateUtilities.GetHasVisualStateGroups(this);
			this.UpdateVisualStates(false);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0000F83B File Offset: 0x0000DA3B
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.CalendarItemGroupAutomationPeer(this);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0000F843 File Offset: 0x0000DA43
		protected override void OnInitialized(global::System.EventArgs e)
		{
			this.InitializeItems();
			base.OnInitialized(e);
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0000F852 File Offset: 0x0000DA52
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0000F861 File Offset: 0x0000DA61
		protected override void OnMouseEnter(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0000F870 File Offset: 0x0000DA70
		protected override void OnMouseLeave(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.UpdateVisualStates();
		}

		// Token: 0x060003BF RID: 959 RVA: 0x0000F880 File Offset: 0x0000DA80
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

		// Token: 0x0400013A RID: 314
		private global::Infragistics.Windows.Editors.XamMonthCalendar _control;

		// Token: 0x0400013B RID: 315
		private int _suspendInitializeCount;

		// Token: 0x0400013C RID: 316
		private int _suspendAnimationCount;

		// Token: 0x0400013D RID: 317
		private int _preventAnimationCount;

		// Token: 0x0400013E RID: 318
		private bool _isSizingGroup;

		// Token: 0x0400013F RID: 319
		private bool _initializeNeeded = true;

		// Token: 0x04000140 RID: 320
		private global::Infragistics.Windows.Editors.ICalendarItemArea _itemArea;

		// Token: 0x04000141 RID: 321
		private global::Infragistics.Windows.Editors.CalendarAnimation? _pendingAnimation;

		// Token: 0x04000142 RID: 322
		private bool _hasVisualStateGroups;

		// Token: 0x04000143 RID: 323
		private static readonly global::System.Windows.DependencyProperty CalendarModeInternalProperty = global::System.Windows.DependencyProperty.Register("CalendarModeInternal", typeof(global::Infragistics.Windows.Editors.CalendarMode), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.CalendarMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnCalendarModeInternalChanged)));

		// Token: 0x04000144 RID: 324
		private static readonly global::System.Windows.DependencyProperty ReferenceDateProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnReferenceDateChanged)));

		// Token: 0x04000145 RID: 325
		internal static readonly global::System.Windows.DependencyPropertyKey CurrentCalendarModePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("CurrentCalendarMode", typeof(global::Infragistics.Windows.Editors.CalendarMode), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.CalendarMode.Days, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x04000146 RID: 326
		public static readonly global::System.Windows.DependencyProperty CurrentCalendarModeProperty = global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey.DependencyProperty;

		// Token: 0x04000147 RID: 327
		internal static readonly global::System.Windows.DependencyPropertyKey FirstDateOfGroupPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FirstDateOfGroup", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnFirstDateOfGroupChanged)));

		// Token: 0x04000148 RID: 328
		public static readonly global::System.Windows.DependencyProperty FirstDateOfGroupProperty = global::Infragistics.Windows.Editors.CalendarItemGroup.FirstDateOfGroupPropertyKey.DependencyProperty;

		// Token: 0x04000149 RID: 329
		public static readonly global::System.Windows.DependencyProperty IsLeadingGroupProperty = global::System.Windows.DependencyProperty.Register("IsLeadingGroup", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnIsLeadingOrTrailingGroupChanged)));

		// Token: 0x0400014A RID: 330
		public static readonly global::System.Windows.DependencyProperty IsTrailingGroupProperty = global::System.Windows.DependencyProperty.Register("IsTrailingGroup", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnIsLeadingOrTrailingGroupChanged)));

		// Token: 0x0400014B RID: 331
		private static readonly global::System.Windows.DependencyPropertyKey LastDateOfGroupPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("LastDateOfGroup", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x0400014C RID: 332
		public static readonly global::System.Windows.DependencyProperty LastDateOfGroupProperty = global::Infragistics.Windows.Editors.CalendarItemGroup.LastDateOfGroupPropertyKey.DependencyProperty;

		// Token: 0x0400014D RID: 333
		public static readonly global::System.Windows.DependencyProperty ReferenceGroupOffsetProperty = global::System.Windows.DependencyProperty.Register("ReferenceGroupOffset", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(0, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnReferenceGroupOffsetChanged)));

		// Token: 0x0400014E RID: 334
		public static readonly global::System.Windows.DependencyProperty ShowLeadingDatesProperty = global::System.Windows.DependencyProperty.Register("ShowLeadingDates", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnShowLeadingDatesChanged)));

		// Token: 0x0400014F RID: 335
		public static readonly global::System.Windows.DependencyProperty ScrollNextButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("ScrollNextButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000150 RID: 336
		public static readonly global::System.Windows.DependencyProperty ScrollPreviousButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("ScrollPreviousButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x04000151 RID: 337
		public static readonly global::System.Windows.DependencyProperty ShowTrailingDatesProperty = global::System.Windows.DependencyProperty.Register("ShowTrailingDates", typeof(bool), typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemGroup.OnShowTrailingDatesChanged)));

		// Token: 0x02000035 RID: 53
		internal class GroupInitializationHelper : global::System.IDisposable
		{
			// Token: 0x060003C0 RID: 960 RVA: 0x0000F8ED File Offset: 0x0000DAED
			internal GroupInitializationHelper(global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItemGroup> groups) : this(groups, true)
			{
			}

			// Token: 0x060003C1 RID: 961 RVA: 0x0000F8F8 File Offset: 0x0000DAF8
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

			// Token: 0x060003C2 RID: 962 RVA: 0x0000F95C File Offset: 0x0000DB5C
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

			// Token: 0x04000152 RID: 338
			private global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItemGroup> _groups;

			// Token: 0x04000153 RID: 339
			private bool _preventedAnimations;
		}
	}
}
