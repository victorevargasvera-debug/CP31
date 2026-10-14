using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Markup;
using Infragistics.Collections;
using Infragistics.Controls.Editors.Primitives;
using Infragistics.Controls.Primitives;
using Infragistics.Themes;
using Infragistics.Windows.Licensing;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000055 RID: 85
	[global::System.Windows.StyleTypedProperty(Property = "CalendarDayStyle", StyleTargetType = typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDay))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamCalendar")]
	[global::System.Windows.StyleTypedProperty(Property = "CalendarItemStyle", StyleTargetType = typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem))]
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	public class XamCalendar : global::Infragistics.Controls.Editors.CalendarBase
	{
		// Token: 0x06000459 RID: 1113 RVA: 0x00014A78 File Offset: 0x00012C78
		static XamCalendar()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.XamCalendar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.XamCalendar)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Controls.Editors.XamCalendar));
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00014D3C File Offset: 0x00012F3C
		public XamCalendar()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Controls.Editors.XamCalendar), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00014D80 File Offset: 0x00012F80
		internal override global::Infragistics.Controls.Primitives.SelectionType CurrentSelectionType
		{
			get
			{
				switch (this.SelectionMode)
				{
				default:
					return global::Infragistics.Controls.Primitives.SelectionType.Extended;
				case global::Infragistics.Controls.Editors.CalendarDateSelectionMode.None:
					return global::Infragistics.Controls.Primitives.SelectionType.None;
				case global::Infragistics.Controls.Editors.CalendarDateSelectionMode.SingleDate:
					return global::Infragistics.Controls.Primitives.SelectionType.Single;
				case global::Infragistics.Controls.Editors.CalendarDateSelectionMode.Range:
					return global::Infragistics.Controls.Primitives.SelectionType.Range;
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00014DB1 File Offset: 0x00012FB1
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		public global::Infragistics.Controls.Editors.Primitives.CalendarDateRangeCollection DisabledDates
		{
			get
			{
				return base.DisabledDatesInternal;
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00014DBC File Offset: 0x00012FBC
		private static void OnDisabledDaysOfWeekChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = (global::Infragistics.Controls.Editors.XamCalendar)d;
			xamCalendar.DisabledDaysOfWeekInternal = (global::Infragistics.Controls.DayOfWeekFlags)e.NewValue;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00014DE2 File Offset: 0x00012FE2
		// (set) Token: 0x0600045F RID: 1119 RVA: 0x00014DF4 File Offset: 0x00012FF4
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.DayOfWeekFlags DisabledDaysOfWeek
		{
			get
			{
				return (global::Infragistics.Controls.DayOfWeekFlags)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.DisabledDaysOfWeekProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.DisabledDaysOfWeekProperty, value);
			}
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00014E08 File Offset: 0x00013008
		private static void OnDisabledDaysOfWeekVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = (global::Infragistics.Controls.Editors.XamCalendar)d;
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNonHiddenVisibility(e);
			xamCalendar.DisabledDaysOfWeekVisibilityInternal = (global::System.Windows.Visibility)e.NewValue;
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00014E35 File Offset: 0x00013035
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x00014E47 File Offset: 0x00013047
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Editors.NonHiddenVisibilityConverter))]
		public global::System.Windows.Visibility DisabledDaysOfWeekVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.DisabledDaysOfWeekVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.DisabledDaysOfWeekVisibilityProperty, value);
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00014E5C File Offset: 0x0001305C
		private static void OnMinMaxDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = d as global::Infragistics.Controls.Editors.XamCalendar;
			if (xamCalendar != null)
			{
				xamCalendar.AllowableDateRange = new global::Infragistics.DateRange(xamCalendar.MinDate, xamCalendar.MaxDate);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00014E8A File Offset: 0x0001308A
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00014E9C File Offset: 0x0001309C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.Windows.Markup.DependsOn("MinDate")]
		public global::System.DateTime MaxDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.MaxDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.MaxDateProperty, value);
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00014EB0 File Offset: 0x000130B0
		private static void OnMaxSelectedDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			int num = (int)e.NewValue;
			global::Infragistics.CoreUtilities.ValidateIsNotNegative((double)num, global::Infragistics.DependencyPropertyUtilities.GetName(e.Property));
			calendarBase.MaxSelectedDatesInternal = num;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00014EEB File Offset: 0x000130EB
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x00014EFD File Offset: 0x000130FD
		[global::System.ComponentModel.Bindable(true)]
		public int MaxSelectedDates
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.MaxSelectedDatesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.MaxSelectedDatesProperty, value);
			}
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00014F10 File Offset: 0x00013110
		private static void OnMinCalendarModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = (global::Infragistics.Controls.Editors.XamCalendar)d;
			xamCalendar.MinCalendarModeResolved = (global::Infragistics.Controls.Editors.CalendarZoomMode)e.NewValue;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x00014F36 File Offset: 0x00013136
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00014F48 File Offset: 0x00013148
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.CalendarZoomMode MinCalendarMode
		{
			get
			{
				return (global::Infragistics.Controls.Editors.CalendarZoomMode)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.MinCalendarModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.MinCalendarModeProperty, value);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00014F5B File Offset: 0x0001315B
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00014F6D File Offset: 0x0001316D
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime MinDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.MinDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.MinDateProperty, value);
			}
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00014F80 File Offset: 0x00013180
		private static void OnFirstDayOfWeekChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = d as global::Infragistics.Controls.Editors.XamCalendar;
			xamCalendar.FirstDayOfWeekInternal = (global::System.DayOfWeek?)e.NewValue;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00014FA6 File Offset: 0x000131A6
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x00014FB8 File Offset: 0x000131B8
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DayOfWeek? FirstDayOfWeek
		{
			get
			{
				return (global::System.DayOfWeek?)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.FirstDayOfWeekProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.FirstDayOfWeekProperty, value);
			}
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00014FCC File Offset: 0x000131CC
		private static void OnSelectionModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = (global::Infragistics.Controls.Editors.XamCalendar)d;
			global::Infragistics.Controls.Primitives.SelectionType currentSelectionTypeResolved = xamCalendar.CurrentSelectionTypeResolved;
			if (global::Infragistics.Controls.Primitives.SelectionStrategyBase.IsSingleSelectStrategy(currentSelectionTypeResolved))
			{
				global::Infragistics.Collections.DateCollection selectedDatesInternal = xamCalendar.SelectedDatesInternal;
				if (xamCalendar.SelectedDate != null)
				{
					xamCalendar._pivotRange = new global::Infragistics.DateRange?(new global::Infragistics.DateRange(xamCalendar.SelectedDate.Value));
				}
				else
				{
					xamCalendar._pivotRange = null;
				}
				if (selectedDatesInternal.Count > 1)
				{
					selectedDatesInternal.Reinitialize(new global::System.DateTime[]
					{
						xamCalendar.SelectedDates[0]
					});
					return;
				}
			}
			else if (!global::Infragistics.Controls.Primitives.SelectionStrategyBase.IsMultiSelectStrategy(currentSelectionTypeResolved))
			{
				xamCalendar._pivotRange = null;
				xamCalendar.SelectedDatesInternal.Clear();
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00015085 File Offset: 0x00013285
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00015097 File Offset: 0x00013297
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.CalendarDateSelectionMode SelectionMode
		{
			get
			{
				return (global::Infragistics.Controls.Editors.CalendarDateSelectionMode)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.SelectionModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.SelectionModeProperty, value);
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x000150AA File Offset: 0x000132AA
		private static void OnTodayButtonVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = (global::Infragistics.Controls.Editors.XamCalendar)d;
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000150B3 File Offset: 0x000132B3
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000150C5 File Offset: 0x000132C5
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility TodayButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.TodayButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.TodayButtonVisibilityProperty, value);
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000150D8 File Offset: 0x000132D8
		private static void OnWeekRuleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = d as global::Infragistics.Controls.Editors.XamCalendar;
			xamCalendar.WeekRuleInternal = (global::System.Globalization.CalendarWeekRule?)e.NewValue;
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000150FE File Offset: 0x000132FE
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00015110 File Offset: 0x00013310
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Globalization.CalendarWeekRule? WeekRule
		{
			get
			{
				return (global::System.Globalization.CalendarWeekRule?)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.WeekRuleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.WeekRuleProperty, value);
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00015124 File Offset: 0x00013324
		private static void OnWorkdaysChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.XamCalendar xamCalendar = (global::Infragistics.Controls.Editors.XamCalendar)d;
			xamCalendar.WorkDaysInternal = (global::Infragistics.Controls.DayOfWeekFlags)e.NewValue;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x0001514A File Offset: 0x0001334A
		// (set) Token: 0x0600047C RID: 1148 RVA: 0x0001515C File Offset: 0x0001335C
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.DayOfWeekFlags Workdays
		{
			get
			{
				return (global::Infragistics.Controls.DayOfWeekFlags)base.GetValue(global::Infragistics.Controls.Editors.XamCalendar.WorkdaysProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.XamCalendar.WorkdaysProperty, value);
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001516F File Offset: 0x0001336F
		public static void RegisterResources(string name, global::System.Reflection.Assembly assembly)
		{
			global::SR.AddResource(name, assembly);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00015178 File Offset: 0x00013378
		public static void UnregisterResources(string name)
		{
			global::SR.RemoveResource(name);
		}

		// Token: 0x04000229 RID: 553
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x0400022A RID: 554
		public static readonly global::System.Windows.DependencyProperty DisabledDaysOfWeekProperty = global::Infragistics.DependencyPropertyUtilities.Register("DisabledDaysOfWeek", typeof(global::Infragistics.Controls.DayOfWeekFlags), typeof(global::Infragistics.Controls.Editors.XamCalendar), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.DayOfWeekFlags.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnDisabledDaysOfWeekChanged)));

		// Token: 0x0400022B RID: 555
		public static readonly global::System.Windows.DependencyProperty DisabledDaysOfWeekVisibilityProperty = global::Infragistics.DependencyPropertyUtilities.Register("DisabledDaysOfWeekVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.XamCalendar), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnDisabledDaysOfWeekVisibilityChanged)));

		// Token: 0x0400022C RID: 556
		public static readonly global::System.Windows.DependencyProperty MaxDateProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxDate", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.XamCalendar), new global::System.Windows.PropertyMetadata(global::System.DateTime.MaxValue.Date, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::System.DateTime>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnMinMaxDateChanged))));

		// Token: 0x0400022D RID: 557
		public static readonly global::System.Windows.DependencyProperty MaxSelectedDatesProperty = global::Infragistics.DependencyPropertyUtilities.Register("MaxSelectedDates", typeof(int), typeof(global::Infragistics.Controls.Editors.XamCalendar), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Editors.CalendarUtilities.ZeroInt, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnMaxSelectedDatesChanged)));

		// Token: 0x0400022E RID: 558
		public static readonly global::System.Windows.DependencyProperty MinCalendarModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("MinCalendarMode", typeof(global::Infragistics.Controls.Editors.CalendarZoomMode), typeof(global::Infragistics.Controls.Editors.XamCalendar), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Editors.CalendarZoomMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnMinCalendarModeChanged)));

		// Token: 0x0400022F RID: 559
		public static readonly global::System.Windows.DependencyProperty MinDateProperty = global::Infragistics.DependencyPropertyUtilities.Register("MinDate", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.XamCalendar), new global::System.Windows.PropertyMetadata(global::System.DateTime.MinValue, global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::System.DateTime>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnMinMaxDateChanged))));

		// Token: 0x04000230 RID: 560
		public static readonly global::System.Windows.DependencyProperty FirstDayOfWeekProperty = global::Infragistics.DependencyPropertyUtilities.Register("FirstDayOfWeek", typeof(global::System.DayOfWeek?), typeof(global::Infragistics.Controls.Editors.XamCalendar), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnFirstDayOfWeekChanged));

		// Token: 0x04000231 RID: 561
		public static readonly global::System.Windows.DependencyProperty SelectionModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("SelectionMode", typeof(global::Infragistics.Controls.Editors.CalendarDateSelectionMode), typeof(global::Infragistics.Controls.Editors.XamCalendar), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Editors.CalendarDateSelectionMode.Extended, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnSelectionModeChanged)));

		// Token: 0x04000232 RID: 562
		public static readonly global::System.Windows.DependencyProperty TodayButtonVisibilityProperty = global::Infragistics.DependencyPropertyUtilities.Register("TodayButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.XamCalendar), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnTodayButtonVisibilityChanged)));

		// Token: 0x04000233 RID: 563
		public static readonly global::System.Windows.DependencyProperty WeekRuleProperty = global::Infragistics.DependencyPropertyUtilities.Register("WeekRule", typeof(global::System.Globalization.CalendarWeekRule?), typeof(global::Infragistics.Controls.Editors.XamCalendar), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnWeekRuleChanged));

		// Token: 0x04000234 RID: 564
		public static readonly global::System.Windows.DependencyProperty WorkdaysProperty = global::Infragistics.DependencyPropertyUtilities.Register("Workdays", typeof(global::Infragistics.Controls.DayOfWeekFlags), typeof(global::Infragistics.Controls.Editors.XamCalendar), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.XamCalendar.OnWorkdaysChanged)));
	}
}
