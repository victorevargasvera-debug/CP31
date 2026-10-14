using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Windows.Automation.Peers;
using Microsoft.Windows.Controls.Primitives;

namespace Microsoft.Windows.Controls
{
	// Token: 0x0200004B RID: 75
	[global::System.Windows.TemplatePart(Name = "PART_CalendarItem", Type = typeof(global::Microsoft.Windows.Controls.Primitives.CalendarItem))]
	[global::System.Windows.TemplatePart(Name = "PART_Root", Type = typeof(global::System.Windows.Controls.Panel))]
	public class Calendar : global::System.Windows.Controls.Control
	{
		// Token: 0x14000021 RID: 33
		// (add) Token: 0x060005A3 RID: 1443 RVA: 0x0001644E File Offset: 0x0001464E
		// (remove) Token: 0x060005A4 RID: 1444 RVA: 0x0001645C File Offset: 0x0001465C
		public event global::System.EventHandler<global::System.Windows.Controls.SelectionChangedEventArgs> SelectedDatesChanged
		{
			add
			{
				base.AddHandler(global::Microsoft.Windows.Controls.Calendar.SelectedDatesChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Microsoft.Windows.Controls.Calendar.SelectedDatesChangedEvent, value);
			}
		}

		// Token: 0x14000022 RID: 34
		// (add) Token: 0x060005A5 RID: 1445 RVA: 0x0001646A File Offset: 0x0001466A
		// (remove) Token: 0x060005A6 RID: 1446 RVA: 0x00016483 File Offset: 0x00014683
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.CalendarDateChangedEventArgs> DisplayDateChanged;

		// Token: 0x14000023 RID: 35
		// (add) Token: 0x060005A7 RID: 1447 RVA: 0x0001649C File Offset: 0x0001469C
		// (remove) Token: 0x060005A8 RID: 1448 RVA: 0x000164B5 File Offset: 0x000146B5
		public event global::System.EventHandler<global::Microsoft.Windows.Controls.CalendarModeChangedEventArgs> DisplayModeChanged;

		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060005A9 RID: 1449 RVA: 0x000164CE File Offset: 0x000146CE
		// (remove) Token: 0x060005AA RID: 1450 RVA: 0x000164E7 File Offset: 0x000146E7
		public event global::System.EventHandler<global::System.EventArgs> SelectionModeChanged;

		// Token: 0x060005AB RID: 1451 RVA: 0x00016500 File Offset: 0x00014700
		static Calendar()
		{
			global::Microsoft.Windows.Controls.Calendar.SelectedDatesChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectedDatesChanged", global::System.Windows.RoutingStrategy.Direct, typeof(global::System.EventHandler<global::System.Windows.Controls.SelectionChangedEventArgs>), typeof(global::Microsoft.Windows.Controls.Calendar));
			global::Microsoft.Windows.Controls.Calendar.CalendarButtonStyleProperty = global::System.Windows.DependencyProperty.Register("CalendarButtonStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.Calendar));
			global::Microsoft.Windows.Controls.Calendar.CalendarDayButtonStyleProperty = global::System.Windows.DependencyProperty.Register("CalendarDayButtonStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.Calendar));
			global::Microsoft.Windows.Controls.Calendar.CalendarItemStyleProperty = global::System.Windows.DependencyProperty.Register("CalendarItemStyle", typeof(global::System.Windows.Style), typeof(global::Microsoft.Windows.Controls.Calendar));
			global::Microsoft.Windows.Controls.Calendar.DisplayDateProperty = global::System.Windows.DependencyProperty.Register("DisplayDate", typeof(global::System.DateTime), typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MinValue, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnDisplayDateChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Calendar.CoerceDisplayDate)));
			global::Microsoft.Windows.Controls.Calendar.DisplayDateEndProperty = global::System.Windows.DependencyProperty.Register("DisplayDateEnd", typeof(global::System.DateTime?), typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnDisplayDateEndChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Calendar.CoerceDisplayDateEnd)));
			global::Microsoft.Windows.Controls.Calendar.DisplayDateStartProperty = global::System.Windows.DependencyProperty.Register("DisplayDateStart", typeof(global::System.DateTime?), typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnDisplayDateStartChanged), new global::System.Windows.CoerceValueCallback(global::Microsoft.Windows.Controls.Calendar.CoerceDisplayDateStart)));
			global::Microsoft.Windows.Controls.Calendar.DisplayModeProperty = global::System.Windows.DependencyProperty.Register("DisplayMode", typeof(global::Microsoft.Windows.Controls.CalendarMode), typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.CalendarMode.Month, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnDisplayModePropertyChanged)), new global::System.Windows.ValidateValueCallback(global::Microsoft.Windows.Controls.Calendar.IsValidDisplayMode));
			global::Microsoft.Windows.Controls.Calendar.FirstDayOfWeekProperty = global::System.Windows.DependencyProperty.Register("FirstDayOfWeek", typeof(global::System.DayOfWeek), typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.DateTimeHelper.GetCurrentDateFormat().FirstDayOfWeek, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnFirstDayOfWeekChanged)), new global::System.Windows.ValidateValueCallback(global::Microsoft.Windows.Controls.Calendar.IsValidFirstDayOfWeek));
			global::Microsoft.Windows.Controls.Calendar.IsTodayHighlightedProperty = global::System.Windows.DependencyProperty.Register("IsTodayHighlighted", typeof(bool), typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(true, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnIsTodayHighlightedChanged)));
			global::Microsoft.Windows.Controls.Calendar.SelectedDateProperty = global::System.Windows.DependencyProperty.Register("SelectedDate", typeof(global::System.DateTime?), typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnSelectedDateChanged)));
			global::Microsoft.Windows.Controls.Calendar.SelectionModeProperty = global::System.Windows.DependencyProperty.Register("SelectionMode", typeof(global::Microsoft.Windows.Controls.CalendarSelectionMode), typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate, new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnSelectionModeChanged)), new global::System.Windows.ValidateValueCallback(global::Microsoft.Windows.Controls.Calendar.IsValidSelectionMode));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.Calendar)));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Once));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Contained));
			global::System.Windows.EventManager.RegisterClassHandler(typeof(global::Microsoft.Windows.Controls.Calendar), global::System.Windows.UIElement.GotFocusEvent, new global::System.Windows.RoutedEventHandler(global::Microsoft.Windows.Controls.Calendar.OnGotFocus));
			global::System.Windows.FrameworkElement.LanguageProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Calendar), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Windows.Controls.Calendar.OnLanguageChanged)));
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001686F File Offset: 0x00014A6F
		public Calendar()
		{
			this._blackoutDates = new global::Microsoft.Windows.Controls.CalendarBlackoutDatesCollection(this);
			this._selectedDates = new global::Microsoft.Windows.Controls.SelectedDatesCollection(this);
			this.DisplayDate = global::System.DateTime.Today;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x0001689A File Offset: 0x00014A9A
		public global::Microsoft.Windows.Controls.CalendarBlackoutDatesCollection BlackoutDates
		{
			get
			{
				return this._blackoutDates;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x000168A2 File Offset: 0x00014AA2
		// (set) Token: 0x060005AF RID: 1455 RVA: 0x000168B4 File Offset: 0x00014AB4
		public global::System.Windows.Style CalendarButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.Calendar.CalendarButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.CalendarButtonStyleProperty, value);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x000168C2 File Offset: 0x00014AC2
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x000168D4 File Offset: 0x00014AD4
		public global::System.Windows.Style CalendarDayButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.Calendar.CalendarDayButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.CalendarDayButtonStyleProperty, value);
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060005B2 RID: 1458 RVA: 0x000168E2 File Offset: 0x00014AE2
		// (set) Token: 0x060005B3 RID: 1459 RVA: 0x000168F4 File Offset: 0x00014AF4
		public global::System.Windows.Style CalendarItemStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Microsoft.Windows.Controls.Calendar.CalendarItemStyleProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.CalendarItemStyleProperty, value);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00016902 File Offset: 0x00014B02
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00016914 File Offset: 0x00014B14
		public global::System.DateTime DisplayDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateProperty, value);
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x00016928 File Offset: 0x00014B28
		private static void OnDisplayDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			calendar.DisplayDateInternal = global::Microsoft.Windows.Controls.DateTimeHelper.DiscardDayTime((global::System.DateTime)e.NewValue);
			calendar.UpdateCellItems();
			calendar.OnDisplayDateChanged(new global::Microsoft.Windows.Controls.CalendarDateChangedEventArgs(new global::System.DateTime?((global::System.DateTime)e.OldValue), new global::System.DateTime?((global::System.DateTime)e.NewValue)));
		}

		// Token: 0x060005B7 RID: 1463 RVA: 0x00016988 File Offset: 0x00014B88
		private static object CoerceDisplayDate(global::System.Windows.DependencyObject d, object value)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			global::System.DateTime t = (global::System.DateTime)value;
			if (calendar.DisplayDateStart != null && t < calendar.DisplayDateStart.Value)
			{
				value = calendar.DisplayDateStart.Value;
			}
			else if (calendar.DisplayDateEnd != null && t > calendar.DisplayDateEnd.Value)
			{
				value = calendar.DisplayDateEnd.Value;
			}
			return value;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060005B8 RID: 1464 RVA: 0x00016A20 File Offset: 0x00014C20
		// (set) Token: 0x060005B9 RID: 1465 RVA: 0x00016A32 File Offset: 0x00014C32
		public global::System.DateTime? DisplayDateEnd
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateEndProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateEndProperty, value);
			}
		}

		// Token: 0x060005BA RID: 1466 RVA: 0x00016A48 File Offset: 0x00014C48
		private static void OnDisplayDateEndChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			calendar.CoerceValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateProperty);
			calendar.UpdateCellItems();
		}

		// Token: 0x060005BB RID: 1467 RVA: 0x00016A70 File Offset: 0x00014C70
		private static object CoerceDisplayDateEnd(global::System.Windows.DependencyObject d, object value)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			global::System.DateTime? dateTime = (global::System.DateTime?)value;
			if (dateTime != null)
			{
				if (calendar.DisplayDateStart != null && dateTime.Value < calendar.DisplayDateStart.Value)
				{
					value = calendar.DisplayDateStart;
				}
				global::System.DateTime? maximumDate = calendar.SelectedDates.MaximumDate;
				if (maximumDate != null && dateTime.Value < maximumDate.Value)
				{
					value = maximumDate;
				}
			}
			return value;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060005BC RID: 1468 RVA: 0x00016B01 File Offset: 0x00014D01
		// (set) Token: 0x060005BD RID: 1469 RVA: 0x00016B13 File Offset: 0x00014D13
		public global::System.DateTime? DisplayDateStart
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateStartProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateStartProperty, value);
			}
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00016B28 File Offset: 0x00014D28
		private static void OnDisplayDateStartChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			calendar.CoerceValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateEndProperty);
			calendar.CoerceValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateProperty);
			calendar.UpdateCellItems();
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00016B58 File Offset: 0x00014D58
		private static object CoerceDisplayDateStart(global::System.Windows.DependencyObject d, object value)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			global::System.DateTime? dateTime = (global::System.DateTime?)value;
			if (dateTime != null)
			{
				global::System.DateTime? minimumDate = calendar.SelectedDates.MinimumDate;
				if (minimumDate != null && dateTime.Value > minimumDate.Value)
				{
					value = minimumDate;
				}
			}
			return value;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060005C0 RID: 1472 RVA: 0x00016BAF File Offset: 0x00014DAF
		// (set) Token: 0x060005C1 RID: 1473 RVA: 0x00016BC1 File Offset: 0x00014DC1
		public global::Microsoft.Windows.Controls.CalendarMode DisplayMode
		{
			get
			{
				return (global::Microsoft.Windows.Controls.CalendarMode)base.GetValue(global::Microsoft.Windows.Controls.Calendar.DisplayModeProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.DisplayModeProperty, value);
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x00016BD4 File Offset: 0x00014DD4
		private static void OnDisplayModePropertyChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			global::Microsoft.Windows.Controls.CalendarMode newMode = (global::Microsoft.Windows.Controls.CalendarMode)e.NewValue;
			global::Microsoft.Windows.Controls.CalendarMode calendarMode = (global::Microsoft.Windows.Controls.CalendarMode)e.OldValue;
			global::Microsoft.Windows.Controls.Primitives.CalendarItem monthControl = calendar.MonthControl;
			switch (newMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
				if (calendarMode == global::Microsoft.Windows.Controls.CalendarMode.Year || calendarMode == global::Microsoft.Windows.Controls.CalendarMode.Decade)
				{
					calendar.HoverStart = (calendar.HoverEnd = null);
					calendar.CurrentDate = calendar.DisplayDate;
				}
				calendar.UpdateCellItems();
				break;
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
				if (calendarMode == global::Microsoft.Windows.Controls.CalendarMode.Month)
				{
					calendar.DisplayDate = calendar.CurrentDate;
				}
				calendar.UpdateCellItems();
				break;
			}
			calendar.OnDisplayModeChanged(new global::Microsoft.Windows.Controls.CalendarModeChangedEventArgs((global::Microsoft.Windows.Controls.CalendarMode)e.OldValue, newMode));
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060005C3 RID: 1475 RVA: 0x00016C83 File Offset: 0x00014E83
		// (set) Token: 0x060005C4 RID: 1476 RVA: 0x00016C95 File Offset: 0x00014E95
		public global::System.DayOfWeek FirstDayOfWeek
		{
			get
			{
				return (global::System.DayOfWeek)base.GetValue(global::Microsoft.Windows.Controls.Calendar.FirstDayOfWeekProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.FirstDayOfWeekProperty, value);
			}
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x00016CA8 File Offset: 0x00014EA8
		private static void OnFirstDayOfWeekChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			calendar.UpdateCellItems();
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060005C6 RID: 1478 RVA: 0x00016CC2 File Offset: 0x00014EC2
		// (set) Token: 0x060005C7 RID: 1479 RVA: 0x00016CD4 File Offset: 0x00014ED4
		public bool IsTodayHighlighted
		{
			get
			{
				return (bool)base.GetValue(global::Microsoft.Windows.Controls.Calendar.IsTodayHighlightedProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.IsTodayHighlightedProperty, value);
			}
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00016CE8 File Offset: 0x00014EE8
		private static void OnIsTodayHighlightedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			int num = global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(calendar.DisplayDateInternal, global::System.DateTime.Today);
			if (num > -2 && num < 2)
			{
				calendar.UpdateCellItems();
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00016D1C File Offset: 0x00014F1C
		private static void OnLanguageChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			if (global::System.Windows.DependencyPropertyHelper.GetValueSource(d, global::Microsoft.Windows.Controls.Calendar.FirstDayOfWeekProperty).BaseValueSource == global::System.Windows.BaseValueSource.Default)
			{
				calendar.CoerceValue(global::Microsoft.Windows.Controls.Calendar.FirstDayOfWeekProperty);
				calendar.UpdateCellItems();
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060005CA RID: 1482 RVA: 0x00016D57 File Offset: 0x00014F57
		// (set) Token: 0x060005CB RID: 1483 RVA: 0x00016D69 File Offset: 0x00014F69
		public global::System.DateTime? SelectedDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Microsoft.Windows.Controls.Calendar.SelectedDateProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.SelectedDateProperty, value);
			}
		}

		// Token: 0x060005CC RID: 1484 RVA: 0x00016D7C File Offset: 0x00014F7C
		private static void OnSelectedDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			if (calendar.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.None && e.NewValue != null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.Calendar_OnSelectedDateChanged_InvalidOperation));
			}
			global::System.DateTime? dateTime = (global::System.DateTime?)e.NewValue;
			if (!global::Microsoft.Windows.Controls.Calendar.IsValidDateSelection(calendar, dateTime))
			{
				throw new global::System.ArgumentOutOfRangeException("d", global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.Calendar_OnSelectedDateChanged_InvalidValue));
			}
			if (dateTime == null)
			{
				calendar.SelectedDates.ClearInternal(true);
			}
			else if (dateTime != null && (calendar.SelectedDates.Count <= 0 || !(calendar.SelectedDates[0] == dateTime.Value)))
			{
				calendar.SelectedDates.ClearInternal();
				calendar.SelectedDates.Add(dateTime.Value);
			}
			if (calendar.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate)
			{
				if (dateTime != null)
				{
					calendar.CurrentDate = dateTime.Value;
				}
				calendar.UpdateCellItems();
				return;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060005CD RID: 1485 RVA: 0x00016E72 File Offset: 0x00015072
		public global::Microsoft.Windows.Controls.SelectedDatesCollection SelectedDates
		{
			get
			{
				return this._selectedDates;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060005CE RID: 1486 RVA: 0x00016E7A File Offset: 0x0001507A
		// (set) Token: 0x060005CF RID: 1487 RVA: 0x00016E8C File Offset: 0x0001508C
		public global::Microsoft.Windows.Controls.CalendarSelectionMode SelectionMode
		{
			get
			{
				return (global::Microsoft.Windows.Controls.CalendarSelectionMode)base.GetValue(global::Microsoft.Windows.Controls.Calendar.SelectionModeProperty);
			}
			set
			{
				base.SetValue(global::Microsoft.Windows.Controls.Calendar.SelectionModeProperty, value);
			}
		}

		// Token: 0x060005D0 RID: 1488 RVA: 0x00016EA0 File Offset: 0x000150A0
		private static void OnSelectionModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = d as global::Microsoft.Windows.Controls.Calendar;
			calendar.HoverStart = (calendar.HoverEnd = null);
			calendar.SelectedDates.ClearInternal(true);
			calendar.OnSelectionModeChanged(global::System.EventArgs.Empty);
		}

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060005D1 RID: 1489 RVA: 0x00016EE3 File Offset: 0x000150E3
		// (remove) Token: 0x060005D2 RID: 1490 RVA: 0x00016EFC File Offset: 0x000150FC
		internal event global::System.Windows.Input.MouseButtonEventHandler DayButtonMouseUp;

		// Token: 0x14000026 RID: 38
		// (add) Token: 0x060005D3 RID: 1491 RVA: 0x00016F15 File Offset: 0x00015115
		// (remove) Token: 0x060005D4 RID: 1492 RVA: 0x00016F2E File Offset: 0x0001512E
		internal event global::System.Windows.RoutedEventHandler DayOrMonthPreviewKeyDown;

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060005D5 RID: 1493 RVA: 0x00016F47 File Offset: 0x00015147
		// (set) Token: 0x060005D6 RID: 1494 RVA: 0x00016F4F File Offset: 0x0001514F
		internal bool DatePickerDisplayDateFlag { get; set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060005D7 RID: 1495 RVA: 0x00016F58 File Offset: 0x00015158
		// (set) Token: 0x060005D8 RID: 1496 RVA: 0x00016F60 File Offset: 0x00015160
		internal global::System.DateTime DisplayDateInternal { get; private set; }

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060005D9 RID: 1497 RVA: 0x00016F6C File Offset: 0x0001516C
		internal global::System.DateTime DisplayDateEndInternal
		{
			get
			{
				return this.DisplayDateEnd.GetValueOrDefault(global::System.DateTime.MaxValue);
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005DA RID: 1498 RVA: 0x00016F8C File Offset: 0x0001518C
		internal global::System.DateTime DisplayDateStartInternal
		{
			get
			{
				return this.DisplayDateStart.GetValueOrDefault(global::System.DateTime.MinValue);
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00016FAC File Offset: 0x000151AC
		// (set) Token: 0x060005DC RID: 1500 RVA: 0x00016FBF File Offset: 0x000151BF
		internal global::System.DateTime CurrentDate
		{
			get
			{
				return this._currentDate.GetValueOrDefault(this.DisplayDateInternal);
			}
			set
			{
				this._currentDate = new global::System.DateTime?(value);
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x00016FD0 File Offset: 0x000151D0
		// (set) Token: 0x060005DE RID: 1502 RVA: 0x00016FF6 File Offset: 0x000151F6
		internal global::System.DateTime? HoverStart
		{
			get
			{
				if (this.SelectionMode != global::Microsoft.Windows.Controls.CalendarSelectionMode.None)
				{
					return this._hoverStart;
				}
				return null;
			}
			set
			{
				this._hoverStart = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005DF RID: 1503 RVA: 0x00017000 File Offset: 0x00015200
		// (set) Token: 0x060005E0 RID: 1504 RVA: 0x00017026 File Offset: 0x00015226
		internal global::System.DateTime? HoverEnd
		{
			get
			{
				if (this.SelectionMode != global::Microsoft.Windows.Controls.CalendarSelectionMode.None)
				{
					return this._hoverEnd;
				}
				return null;
			}
			set
			{
				this._hoverEnd = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001702F File Offset: 0x0001522F
		internal global::Microsoft.Windows.Controls.Primitives.CalendarItem MonthControl
		{
			get
			{
				return this._monthControl;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x00017037 File Offset: 0x00015237
		internal global::System.DateTime DisplayMonth
		{
			get
			{
				return global::Microsoft.Windows.Controls.DateTimeHelper.DiscardDayTime(this.DisplayDate);
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005E3 RID: 1507 RVA: 0x00017044 File Offset: 0x00015244
		internal global::System.DateTime DisplayYear
		{
			get
			{
				return new global::System.DateTime(this.DisplayDate.Year, 1, 1);
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x00017066 File Offset: 0x00015266
		private bool IsRightToLeft
		{
			get
			{
				return base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft;
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00017074 File Offset: 0x00015274
		public override void OnApplyTemplate()
		{
			if (this._monthControl != null)
			{
				this._monthControl.Owner = null;
			}
			base.OnApplyTemplate();
			this._monthControl = (base.GetTemplateChild("PART_CalendarItem") as global::Microsoft.Windows.Controls.Primitives.CalendarItem);
			if (this._monthControl != null)
			{
				this._monthControl.Owner = this;
			}
			this.CurrentDate = this.DisplayDate;
			this.UpdateCellItems();
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x000170D8 File Offset: 0x000152D8
		public override string ToString()
		{
			if (this.SelectedDate != null)
			{
				return this.SelectedDate.Value.ToString(global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this)));
			}
			return string.Empty;
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0001711C File Offset: 0x0001531C
		protected virtual void OnSelectedDatesChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			base.RaiseEvent(e);
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x00017128 File Offset: 0x00015328
		protected virtual void OnDisplayDateChanged(global::Microsoft.Windows.Controls.CalendarDateChangedEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Windows.Controls.CalendarDateChangedEventArgs> displayDateChanged = this.DisplayDateChanged;
			if (displayDateChanged != null)
			{
				displayDateChanged(this, e);
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x00017148 File Offset: 0x00015348
		protected virtual void OnDisplayModeChanged(global::Microsoft.Windows.Controls.CalendarModeChangedEventArgs e)
		{
			global::System.EventHandler<global::Microsoft.Windows.Controls.CalendarModeChangedEventArgs> displayModeChanged = this.DisplayModeChanged;
			if (displayModeChanged != null)
			{
				displayModeChanged(this, e);
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00017168 File Offset: 0x00015368
		protected virtual void OnSelectionModeChanged(global::System.EventArgs e)
		{
			global::System.EventHandler<global::System.EventArgs> selectionModeChanged = this.SelectionModeChanged;
			if (selectionModeChanged != null)
			{
				selectionModeChanged(this, e);
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00017187 File Offset: 0x00015387
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Microsoft.Windows.Automation.Peers.CalendarAutomationPeer(this);
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0001718F File Offset: 0x0001538F
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled)
			{
				e.Handled = this.ProcessCalendarKey(e);
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x000171A6 File Offset: 0x000153A6
		protected override void OnKeyUp(global::System.Windows.Input.KeyEventArgs e)
		{
			if (!e.Handled && (e.Key == global::System.Windows.Input.Key.LeftShift || e.Key == global::System.Windows.Input.Key.RightShift))
			{
				this.ProcessShiftKeyUp();
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x000171CC File Offset: 0x000153CC
		internal global::Microsoft.Windows.Controls.Primitives.CalendarDayButton FindDayButtonFromDay(global::System.DateTime day)
		{
			if (this.MonthControl != null)
			{
				foreach (global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton in this.MonthControl.GetCalendarDayButtons())
				{
					if (calendarDayButton.DataContext is global::System.DateTime && global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays((global::System.DateTime)calendarDayButton.DataContext, day) == 0)
					{
						return calendarDayButton;
					}
				}
			}
			return null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x00017248 File Offset: 0x00015448
		internal static bool IsValidDateSelection(global::Microsoft.Windows.Controls.Calendar cal, object value)
		{
			return value == null || !cal.BlackoutDates.Contains((global::System.DateTime)value);
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x00017264 File Offset: 0x00015464
		internal void OnDayButtonMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::System.Windows.Input.MouseButtonEventHandler dayButtonMouseUp = this.DayButtonMouseUp;
			if (dayButtonMouseUp != null)
			{
				dayButtonMouseUp(this, e);
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x00017284 File Offset: 0x00015484
		internal void OnDayOrMonthPreviewKeyDown(global::System.Windows.RoutedEventArgs e)
		{
			global::System.Windows.RoutedEventHandler dayOrMonthPreviewKeyDown = this.DayOrMonthPreviewKeyDown;
			if (dayOrMonthPreviewKeyDown != null)
			{
				dayOrMonthPreviewKeyDown(this, e);
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x000172A3 File Offset: 0x000154A3
		internal void OnDayClick(global::System.DateTime selectedDate)
		{
			if (this.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.None)
			{
				this.CurrentDate = selectedDate;
			}
			if (global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(selectedDate, this.DisplayDateInternal) != 0)
			{
				this.MoveDisplayTo(new global::System.DateTime?(selectedDate));
				return;
			}
			this.UpdateCellItems();
			this.FocusDate(selectedDate);
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x000172E0 File Offset: 0x000154E0
		internal void OnCalendarButtonPressed(global::Microsoft.Windows.Controls.Primitives.CalendarButton b, bool switchDisplayMode)
		{
			if (b.DataContext is global::System.DateTime)
			{
				global::System.DateTime yearMonth = (global::System.DateTime)b.DataContext;
				global::System.DateTime? dateTime = null;
				global::Microsoft.Windows.Controls.CalendarMode displayMode = global::Microsoft.Windows.Controls.CalendarMode.Month;
				switch (this.DisplayMode)
				{
				case global::Microsoft.Windows.Controls.CalendarMode.Year:
					dateTime = global::Microsoft.Windows.Controls.DateTimeHelper.SetYearMonth(this.DisplayDate, yearMonth);
					displayMode = global::Microsoft.Windows.Controls.CalendarMode.Month;
					break;
				case global::Microsoft.Windows.Controls.CalendarMode.Decade:
					dateTime = global::Microsoft.Windows.Controls.DateTimeHelper.SetYear(this.DisplayDate, yearMonth.Year);
					displayMode = global::Microsoft.Windows.Controls.CalendarMode.Year;
					break;
				}
				if (dateTime != null)
				{
					this.DisplayDate = dateTime.Value;
					if (switchDisplayMode)
					{
						this.DisplayMode = displayMode;
						this.FocusDate((this.DisplayMode == global::Microsoft.Windows.Controls.CalendarMode.Month) ? this.CurrentDate : this.DisplayDate);
					}
				}
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x00017390 File Offset: 0x00015590
		private global::System.DateTime? GetDateOffset(global::System.DateTime date, int offset, global::Microsoft.Windows.Controls.CalendarMode displayMode)
		{
			global::System.DateTime? result = null;
			switch (displayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
				result = global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(date, offset);
				break;
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
				result = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(date, offset);
				break;
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
				result = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, offset * 10);
				break;
			}
			return result;
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000173E0 File Offset: 0x000155E0
		private void MoveDisplayTo(global::System.DateTime? date)
		{
			if (date != null)
			{
				global::System.DateTime date2 = date.Value.Date;
				switch (this.DisplayMode)
				{
				case global::Microsoft.Windows.Controls.CalendarMode.Month:
					this.DisplayDate = global::Microsoft.Windows.Controls.DateTimeHelper.DiscardDayTime(date2);
					this.CurrentDate = date2;
					this.UpdateCellItems();
					break;
				case global::Microsoft.Windows.Controls.CalendarMode.Year:
				case global::Microsoft.Windows.Controls.CalendarMode.Decade:
					this.DisplayDate = date2;
					this.UpdateCellItems();
					break;
				}
				this.FocusDate(date2);
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x00017450 File Offset: 0x00015650
		internal void OnNextClick()
		{
			global::System.DateTime? dateOffset = this.GetDateOffset(this.DisplayDate, 1, this.DisplayMode);
			if (dateOffset != null)
			{
				this.MoveDisplayTo(new global::System.DateTime?(global::Microsoft.Windows.Controls.DateTimeHelper.DiscardDayTime(dateOffset.Value)));
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x00017494 File Offset: 0x00015694
		internal void OnPreviousClick()
		{
			global::System.DateTime? dateOffset = this.GetDateOffset(this.DisplayDate, -1, this.DisplayMode);
			if (dateOffset != null)
			{
				this.MoveDisplayTo(new global::System.DateTime?(global::Microsoft.Windows.Controls.DateTimeHelper.DiscardDayTime(dateOffset.Value)));
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x000174D8 File Offset: 0x000156D8
		internal void OnSelectedDatesCollectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (global::Microsoft.Windows.Controls.Calendar.IsSelectionChanged(e))
			{
				if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection))
				{
					global::Microsoft.Windows.Automation.Peers.CalendarAutomationPeer calendarAutomationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(this) as global::Microsoft.Windows.Automation.Peers.CalendarAutomationPeer;
					if (calendarAutomationPeer != null)
					{
						calendarAutomationPeer.RaiseSelectionEvents(e);
					}
				}
				this.CoerceFromSelection();
				this.OnSelectedDatesChanged(e);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x00017528 File Offset: 0x00015728
		internal void UpdateCellItems()
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarItem monthControl = this.MonthControl;
			if (monthControl != null)
			{
				switch (this.DisplayMode)
				{
				case global::Microsoft.Windows.Controls.CalendarMode.Month:
					monthControl.UpdateMonthMode();
					return;
				case global::Microsoft.Windows.Controls.CalendarMode.Year:
					monthControl.UpdateYearMode();
					return;
				case global::Microsoft.Windows.Controls.CalendarMode.Decade:
					monthControl.UpdateDecadeMode();
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0001756D File Offset: 0x0001576D
		private void CoerceFromSelection()
		{
			base.CoerceValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateStartProperty);
			base.CoerceValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateEndProperty);
			base.CoerceValue(global::Microsoft.Windows.Controls.Calendar.DisplayDateProperty);
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x00017590 File Offset: 0x00015790
		private void AddKeyboardSelection()
		{
			if (this.HoverStart != null)
			{
				this.SelectedDates.ClearInternal();
				this.SelectedDates.AddRange(this.HoverStart.Value, this.CurrentDate);
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x000175D8 File Offset: 0x000157D8
		private static bool IsSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs e)
		{
			if (e.AddedItems.Count != e.RemovedItems.Count)
			{
				return true;
			}
			foreach (object obj in e.AddedItems)
			{
				global::System.DateTime dateTime = (global::System.DateTime)obj;
				if (!e.RemovedItems.Contains(dateTime))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x00017660 File Offset: 0x00015860
		private static bool IsValidDisplayMode(object value)
		{
			global::Microsoft.Windows.Controls.CalendarMode calendarMode = (global::Microsoft.Windows.Controls.CalendarMode)value;
			return calendarMode == global::Microsoft.Windows.Controls.CalendarMode.Month || calendarMode == global::Microsoft.Windows.Controls.CalendarMode.Year || calendarMode == global::Microsoft.Windows.Controls.CalendarMode.Decade;
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x00017684 File Offset: 0x00015884
		internal static bool IsValidFirstDayOfWeek(object value)
		{
			global::System.DayOfWeek dayOfWeek = (global::System.DayOfWeek)value;
			return dayOfWeek == global::System.DayOfWeek.Sunday || dayOfWeek == global::System.DayOfWeek.Monday || dayOfWeek == global::System.DayOfWeek.Tuesday || dayOfWeek == global::System.DayOfWeek.Wednesday || dayOfWeek == global::System.DayOfWeek.Thursday || dayOfWeek == global::System.DayOfWeek.Friday || dayOfWeek == global::System.DayOfWeek.Saturday;
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x000176B8 File Offset: 0x000158B8
		private static bool IsValidKeyboardSelection(global::Microsoft.Windows.Controls.Calendar cal, object value)
		{
			return value == null || (!cal.BlackoutDates.Contains((global::System.DateTime)value) && global::System.DateTime.Compare((global::System.DateTime)value, cal.DisplayDateStartInternal) >= 0 && global::System.DateTime.Compare((global::System.DateTime)value, cal.DisplayDateEndInternal) <= 0);
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0001770C File Offset: 0x0001590C
		private static bool IsValidSelectionMode(object value)
		{
			global::Microsoft.Windows.Controls.CalendarSelectionMode calendarSelectionMode = (global::Microsoft.Windows.Controls.CalendarSelectionMode)value;
			return calendarSelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate || calendarSelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleRange || calendarSelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.MultipleRange || calendarSelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.None;
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x00017731 File Offset: 0x00015931
		private void OnSelectedMonthChanged(global::System.DateTime? selectedMonth)
		{
			if (selectedMonth != null)
			{
				this.DisplayDate = selectedMonth.Value;
				this.UpdateCellItems();
				this.FocusDate(selectedMonth.Value);
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0001775C File Offset: 0x0001595C
		private void OnSelectedYearChanged(global::System.DateTime? selectedYear)
		{
			if (selectedYear != null)
			{
				this.DisplayDate = selectedYear.Value;
				this.UpdateCellItems();
				this.FocusDate(selectedYear.Value);
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x00017787 File Offset: 0x00015987
		internal void FocusDate(global::System.DateTime date)
		{
			if (this.MonthControl != null)
			{
				this.MonthControl.FocusDate(date);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x000177A0 File Offset: 0x000159A0
		private static void OnGotFocus(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Calendar calendar = (global::Microsoft.Windows.Controls.Calendar)sender;
			if (!e.Handled && e.OriginalSource == calendar)
			{
				if (calendar.SelectedDate != null && global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(calendar.SelectedDate.Value, calendar.DisplayDateInternal) == 0)
				{
					calendar.FocusDate(calendar.SelectedDate.Value);
				}
				else
				{
					calendar.FocusDate(calendar.DisplayDate);
				}
				e.Handled = true;
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001781C File Offset: 0x00015A1C
		private bool ProcessCalendarKey(global::System.Windows.Input.KeyEventArgs e)
		{
			if (this.DisplayMode == global::Microsoft.Windows.Controls.CalendarMode.Month)
			{
				global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = (this.MonthControl != null) ? this.MonthControl.GetCalendarDayButton(this.CurrentDate) : null;
				if (global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(this.CurrentDate, this.DisplayDateInternal) != 0 && calendarDayButton != null && !calendarDayButton.IsInactive)
				{
					return false;
				}
			}
			bool ctrl;
			bool shift;
			global::Microsoft.Windows.Controls.KeyboardHelper.GetMetaKeyState(out ctrl, out shift);
			global::System.Windows.Input.Key key = e.Key;
			if (key != global::System.Windows.Input.Key.Return)
			{
				switch (key)
				{
				case global::System.Windows.Input.Key.Space:
					break;
				case global::System.Windows.Input.Key.Prior:
					this.ProcessPageUpKey(shift);
					return true;
				case global::System.Windows.Input.Key.Next:
					this.ProcessPageDownKey(shift);
					return true;
				case global::System.Windows.Input.Key.End:
					this.ProcessEndKey(shift);
					return true;
				case global::System.Windows.Input.Key.Home:
					this.ProcessHomeKey(shift);
					return true;
				case global::System.Windows.Input.Key.Left:
					this.ProcessLeftKey(shift);
					return true;
				case global::System.Windows.Input.Key.Up:
					this.ProcessUpKey(ctrl, shift);
					return true;
				case global::System.Windows.Input.Key.Right:
					this.ProcessRightKey(shift);
					return true;
				case global::System.Windows.Input.Key.Down:
					this.ProcessDownKey(ctrl, shift);
					return true;
				default:
					return false;
				}
			}
			return this.ProcessEnterKey();
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00017904 File Offset: 0x00015B04
		private void ProcessDownKey(bool ctrl, bool shift)
		{
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
				if (!ctrl || shift)
				{
					global::System.DateTime? nonBlackoutDate = this._blackoutDates.GetNonBlackoutDate(global::Microsoft.Windows.Controls.DateTimeHelper.AddDays(this.CurrentDate, 7), 1);
					this.ProcessSelection(shift, nonBlackoutDate);
					return;
				}
				break;
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			{
				if (ctrl)
				{
					this.DisplayMode = global::Microsoft.Windows.Controls.CalendarMode.Month;
					this.FocusDate(this.DisplayDate);
					return;
				}
				global::System.DateTime? selectedMonth = global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(this.DisplayDate, 4);
				this.OnSelectedMonthChanged(selectedMonth);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
			{
				if (ctrl)
				{
					this.DisplayMode = global::Microsoft.Windows.Controls.CalendarMode.Year;
					this.FocusDate(this.DisplayDate);
					return;
				}
				global::System.DateTime? selectedYear = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, 4);
				this.OnSelectedYearChanged(selectedYear);
				break;
			}
			default:
				return;
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x000179AC File Offset: 0x00015BAC
		private void ProcessEndKey(bool shift)
		{
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
			{
				global::System.DateTime displayDate = this.DisplayDate;
				global::System.DateTime? lastSelectedDate = new global::System.DateTime?(new global::System.DateTime(this.DisplayDateInternal.Year, this.DisplayDateInternal.Month, 1));
				if (global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(global::System.DateTime.MaxValue, lastSelectedDate.Value) > 0)
				{
					lastSelectedDate = new global::System.DateTime?(global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(lastSelectedDate.Value, 1).Value);
					lastSelectedDate = new global::System.DateTime?(global::Microsoft.Windows.Controls.DateTimeHelper.AddDays(lastSelectedDate.Value, -1).Value);
				}
				else
				{
					lastSelectedDate = new global::System.DateTime?(global::System.DateTime.MaxValue);
				}
				this.ProcessSelection(shift, lastSelectedDate);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			{
				global::System.DateTime value = new global::System.DateTime(this.DisplayDate.Year, 12, 1);
				this.OnSelectedMonthChanged(new global::System.DateTime?(value));
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
			{
				global::System.DateTime? selectedYear = new global::System.DateTime?(new global::System.DateTime(global::Microsoft.Windows.Controls.DateTimeHelper.EndOfDecade(this.DisplayDate), 1, 1));
				this.OnSelectedYearChanged(selectedYear);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00017AB0 File Offset: 0x00015CB0
		private bool ProcessEnterKey()
		{
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
				this.DisplayMode = global::Microsoft.Windows.Controls.CalendarMode.Month;
				this.FocusDate(this.DisplayDate);
				return true;
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
				this.DisplayMode = global::Microsoft.Windows.Controls.CalendarMode.Year;
				this.FocusDate(this.DisplayDate);
				return true;
			default:
				return false;
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00017B04 File Offset: 0x00015D04
		private void ProcessHomeKey(bool shift)
		{
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
			{
				global::System.DateTime? lastSelectedDate = new global::System.DateTime?(new global::System.DateTime(this.DisplayDateInternal.Year, this.DisplayDateInternal.Month, 1));
				this.ProcessSelection(shift, lastSelectedDate);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			{
				global::System.DateTime value = new global::System.DateTime(this.DisplayDate.Year, 1, 1);
				this.OnSelectedMonthChanged(new global::System.DateTime?(value));
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
			{
				global::System.DateTime? selectedYear = new global::System.DateTime?(new global::System.DateTime(global::Microsoft.Windows.Controls.DateTimeHelper.DecadeOfDate(this.DisplayDate), 1, 1));
				this.OnSelectedYearChanged(selectedYear);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00017BA4 File Offset: 0x00015DA4
		private void ProcessLeftKey(bool shift)
		{
			int num = (!this.IsRightToLeft) ? -1 : 1;
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
			{
				global::System.DateTime? nonBlackoutDate = this._blackoutDates.GetNonBlackoutDate(global::Microsoft.Windows.Controls.DateTimeHelper.AddDays(this.CurrentDate, num), num);
				this.ProcessSelection(shift, nonBlackoutDate);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			{
				global::System.DateTime? selectedMonth = global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(this.DisplayDate, num);
				this.OnSelectedMonthChanged(selectedMonth);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
			{
				global::System.DateTime? selectedYear = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, num);
				this.OnSelectedYearChanged(selectedYear);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00017C28 File Offset: 0x00015E28
		private void ProcessPageDownKey(bool shift)
		{
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
			{
				global::System.DateTime? nonBlackoutDate = this._blackoutDates.GetNonBlackoutDate(global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(this.CurrentDate, 1), 1);
				this.ProcessSelection(shift, nonBlackoutDate);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			{
				global::System.DateTime? selectedMonth = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, 1);
				this.OnSelectedMonthChanged(selectedMonth);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
			{
				global::System.DateTime? selectedYear = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, 10);
				this.OnSelectedYearChanged(selectedYear);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00017C9C File Offset: 0x00015E9C
		private void ProcessPageUpKey(bool shift)
		{
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
			{
				global::System.DateTime? nonBlackoutDate = this._blackoutDates.GetNonBlackoutDate(global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(this.CurrentDate, -1), -1);
				this.ProcessSelection(shift, nonBlackoutDate);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			{
				global::System.DateTime? selectedMonth = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, -1);
				this.OnSelectedMonthChanged(selectedMonth);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
			{
				global::System.DateTime? selectedYear = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, -10);
				this.OnSelectedYearChanged(selectedYear);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00017D10 File Offset: 0x00015F10
		private void ProcessRightKey(bool shift)
		{
			int num = (!this.IsRightToLeft) ? 1 : -1;
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
			{
				global::System.DateTime? nonBlackoutDate = this._blackoutDates.GetNonBlackoutDate(global::Microsoft.Windows.Controls.DateTimeHelper.AddDays(this.CurrentDate, num), num);
				this.ProcessSelection(shift, nonBlackoutDate);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			{
				global::System.DateTime? selectedMonth = global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(this.DisplayDate, num);
				this.OnSelectedMonthChanged(selectedMonth);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
			{
				global::System.DateTime? selectedYear = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, num);
				this.OnSelectedYearChanged(selectedYear);
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00017D94 File Offset: 0x00015F94
		private void ProcessSelection(bool shift, global::System.DateTime? lastSelectedDate)
		{
			if (this.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.None && lastSelectedDate != null)
			{
				this.OnDayClick(lastSelectedDate.Value);
				return;
			}
			if (lastSelectedDate != null && global::Microsoft.Windows.Controls.Calendar.IsValidKeyboardSelection(this, lastSelectedDate.Value))
			{
				if (this.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleRange || this.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.MultipleRange)
				{
					this.SelectedDates.ClearInternal();
					if (shift)
					{
						this._isShiftPressed = true;
						if (this.HoverStart == null)
						{
							this.HoverStart = (this.HoverEnd = new global::System.DateTime?(this.CurrentDate));
						}
						global::Microsoft.Windows.Controls.CalendarDateRange range;
						if (global::System.DateTime.Compare(this.HoverStart.Value, lastSelectedDate.Value) < 0)
						{
							range = new global::Microsoft.Windows.Controls.CalendarDateRange(this.HoverStart.Value, lastSelectedDate.Value);
						}
						else
						{
							range = new global::Microsoft.Windows.Controls.CalendarDateRange(lastSelectedDate.Value, this.HoverStart.Value);
						}
						if (!this.BlackoutDates.ContainsAny(range))
						{
							this._currentDate = lastSelectedDate;
							this.HoverEnd = lastSelectedDate;
						}
						this.OnDayClick(this.CurrentDate);
					}
					else
					{
						this.HoverStart = (this.HoverEnd = new global::System.DateTime?(this.CurrentDate = lastSelectedDate.Value));
						this.AddKeyboardSelection();
						this.OnDayClick(lastSelectedDate.Value);
					}
				}
				else
				{
					this.CurrentDate = lastSelectedDate.Value;
					this.HoverStart = (this.HoverEnd = null);
					if (this.SelectedDates.Count > 0)
					{
						this.SelectedDates[0] = lastSelectedDate.Value;
					}
					else
					{
						this.SelectedDates.Add(lastSelectedDate.Value);
					}
					this.OnDayClick(lastSelectedDate.Value);
				}
				this.UpdateCellItems();
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00017F6C File Offset: 0x0001616C
		private void ProcessShiftKeyUp()
		{
			if (this._isShiftPressed && (this.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleRange || this.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.MultipleRange))
			{
				this.AddKeyboardSelection();
				this._isShiftPressed = false;
				this.HoverStart = (this.HoverEnd = null);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00017FB8 File Offset: 0x000161B8
		private void ProcessUpKey(bool ctrl, bool shift)
		{
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
			{
				if (ctrl)
				{
					this.DisplayMode = global::Microsoft.Windows.Controls.CalendarMode.Year;
					this.FocusDate(this.DisplayDate);
					return;
				}
				global::System.DateTime? nonBlackoutDate = this._blackoutDates.GetNonBlackoutDate(global::Microsoft.Windows.Controls.DateTimeHelper.AddDays(this.CurrentDate, -7), -1);
				this.ProcessSelection(shift, nonBlackoutDate);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			{
				if (ctrl)
				{
					this.DisplayMode = global::Microsoft.Windows.Controls.CalendarMode.Decade;
					this.FocusDate(this.DisplayDate);
					return;
				}
				global::System.DateTime? selectedMonth = global::Microsoft.Windows.Controls.DateTimeHelper.AddMonths(this.DisplayDate, -4);
				this.OnSelectedMonthChanged(selectedMonth);
				return;
			}
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
				if (!ctrl)
				{
					global::System.DateTime? selectedYear = global::Microsoft.Windows.Controls.DateTimeHelper.AddYears(this.DisplayDate, -4);
					this.OnSelectedYearChanged(selectedYear);
				}
				return;
			default:
				return;
			}
		}

		// Token: 0x04000194 RID: 404
		private const string ElementRoot = "PART_Root";

		// Token: 0x04000195 RID: 405
		private const string ElementMonth = "PART_CalendarItem";

		// Token: 0x04000196 RID: 406
		private const int COLS = 7;

		// Token: 0x04000197 RID: 407
		private const int ROWS = 7;

		// Token: 0x04000198 RID: 408
		private const int YEAR_ROWS = 3;

		// Token: 0x04000199 RID: 409
		private const int YEAR_COLS = 4;

		// Token: 0x0400019A RID: 410
		private const int YEARS_PER_DECADE = 10;

		// Token: 0x0400019B RID: 411
		private global::System.DateTime? _hoverStart;

		// Token: 0x0400019C RID: 412
		private global::System.DateTime? _hoverEnd;

		// Token: 0x0400019D RID: 413
		private bool _isShiftPressed;

		// Token: 0x0400019E RID: 414
		private global::System.DateTime? _currentDate;

		// Token: 0x0400019F RID: 415
		private global::Microsoft.Windows.Controls.Primitives.CalendarItem _monthControl;

		// Token: 0x040001A0 RID: 416
		private global::Microsoft.Windows.Controls.CalendarBlackoutDatesCollection _blackoutDates;

		// Token: 0x040001A1 RID: 417
		private global::Microsoft.Windows.Controls.SelectedDatesCollection _selectedDates;

		// Token: 0x040001A6 RID: 422
		public static readonly global::System.Windows.DependencyProperty CalendarButtonStyleProperty;

		// Token: 0x040001A7 RID: 423
		public static readonly global::System.Windows.DependencyProperty CalendarDayButtonStyleProperty;

		// Token: 0x040001A8 RID: 424
		public static readonly global::System.Windows.DependencyProperty CalendarItemStyleProperty;

		// Token: 0x040001A9 RID: 425
		public static readonly global::System.Windows.DependencyProperty DisplayDateProperty;

		// Token: 0x040001AA RID: 426
		public static readonly global::System.Windows.DependencyProperty DisplayDateEndProperty;

		// Token: 0x040001AB RID: 427
		public static readonly global::System.Windows.DependencyProperty DisplayDateStartProperty;

		// Token: 0x040001AC RID: 428
		public static readonly global::System.Windows.DependencyProperty DisplayModeProperty;

		// Token: 0x040001AD RID: 429
		public static readonly global::System.Windows.DependencyProperty FirstDayOfWeekProperty;

		// Token: 0x040001AE RID: 430
		public static readonly global::System.Windows.DependencyProperty IsTodayHighlightedProperty;

		// Token: 0x040001AF RID: 431
		public static readonly global::System.Windows.DependencyProperty SelectedDateProperty;

		// Token: 0x040001B0 RID: 432
		public static readonly global::System.Windows.DependencyProperty SelectionModeProperty;
	}
}
