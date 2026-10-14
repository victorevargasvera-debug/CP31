using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Threading;
using Infragistics.Collections;
using Infragistics.Controls;
using Infragistics.Themes;
using Infragistics.Windows.Automation.Peers.Editors;
using Infragistics.Windows.Commands;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Controls.Events;
using Infragistics.Windows.Editors.Events;
using Infragistics.Windows.Helpers;
using Infragistics.Windows.Licensing;
using Infragistics.Windows.Selection;
using Infragistics.Windows.Themes;
using Infragistics.Windows.Themes.Internal;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000045 RID: 69
	[global::System.ComponentModel.LicenseProvider(typeof(global::Infragistics.Windows.Licensing.UltraLicenseProvider))]
	[global::System.Windows.StyleTypedProperty(Property = "CalendarDayStyle", StyleTargetType = typeof(global::Infragistics.Windows.Editors.CalendarDay))]
	[global::System.Windows.StyleTypedProperty(Property = "CalendarItemStyle", StyleTargetType = typeof(global::Infragistics.Windows.Editors.CalendarItem))]
	[global::Infragistics.Windows.Licensing.UltraLicense("XamMonthCalendar")]
	public class XamMonthCalendar : global::Infragistics.Windows.Controls.IGControlBase, global::Infragistics.Windows.Commands.ICommandHost, global::Infragistics.Windows.Selection.ISelectionHost
	{
		// Token: 0x0600046B RID: 1131 RVA: 0x00013588 File Offset: 0x00011788
		static XamMonthCalendar()
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar.ThemeChangedEvent = global::Infragistics.Windows.Themes.ThemeManager.ThemeChangedEvent.AddOwner(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar));
			global::Infragistics.Windows.Editors.XamMonthCalendar.TodayPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Today", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.Today));
			global::Infragistics.Windows.Editors.XamMonthCalendar.TodayProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.TodayPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.XamMonthCalendar.WeekRuleProperty = global::System.Windows.DependencyProperty.Register("WeekRule", typeof(global::System.Globalization.CalendarWeekRule?), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnWeekRuleChanged)));
			global::Infragistics.Windows.Editors.XamMonthCalendar.WorkdaysProperty = global::System.Windows.DependencyProperty.Register("Workdays", typeof(global::Infragistics.Controls.DayOfWeekFlags), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnWorkdaysChanged)));
			global::Infragistics.Windows.Editors.XamMonthCalendar.MeasureDateProperty = global::System.Windows.DependencyProperty.Register("MeasureDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(new global::System.DateTime(2008, 9, 1), null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.CoerceMeasureDate)));
			global::Infragistics.Windows.Editors.XamMonthCalendar.MonthCalendarPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("MonthCalendar", typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));
			global::Infragistics.Windows.Editors.XamMonthCalendar.MonthCalendarProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.MonthCalendarPropertyKey.DependencyProperty;
			global::Infragistics.Windows.Editors.XamMonthCalendar.ExecutingCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutingCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs>), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar));
			global::Infragistics.Windows.Editors.XamMonthCalendar.ExecutedCommandEvent = global::System.Windows.EventManager.RegisterRoutedEvent("ExecutedCommand", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs>), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar));
			global::Infragistics.Windows.Editors.XamMonthCalendar.SelectedDatesChangedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectedDatesChanged", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.Editors.Events.SelectedDatesChangedEventArgs>), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar));
			global::Infragistics.Windows.Editors.XamMonthCalendar.SelectionCommittedEvent = global::System.Windows.EventManager.RegisterRoutedEvent("SelectionCommitted", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.Windows.RoutedEventHandler), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar));
			global::Infragistics.Windows.Themes.ThemeManager.RegisterGroupings(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new string[]
			{
				global::Infragistics.Windows.Themes.PrimitivesResourceSet<global::Infragistics.Windows.Themes.PrimitivesGeneric.Locator>.Location.Grouping,
				global::Infragistics.Windows.Themes.EditorsResourceSet<global::Infragistics.Windows.Themes.EditorsGeneric.Locator>.Location.Grouping
			});
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar)));
			global::System.Windows.FrameworkElement.LanguageProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnLanguageChanged)));
			global::System.Windows.Controls.Control.HorizontalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.HorizontalAlignmentCenterBox));
			global::System.Windows.Controls.Control.VerticalContentAlignmentProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VerticalAlignmentCenterBox));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.CoerceIsTabStop)));
			global::Infragistics.Themes.ThemeManager.RegisterControl(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar));
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00013EB0 File Offset: 0x000120B0
		public XamMonthCalendar()
		{
			try
			{
				this._license = (global::System.ComponentModel.LicenseManager.Validate(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), this) as global::Infragistics.Windows.Licensing.UltraLicense);
			}
			catch (global::System.IO.FileNotFoundException)
			{
			}
			this._calendarManager = new global::Infragistics.Windows.Editors.CalendarManager();
			this._groups = new global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.CalendarItemGroup>();
			this._calendarManager.FirstDayOfWeek = this.FirstDayOfWeek;
			this._calendarManager.WeekRule = this.WeekRule;
			this._daysOfWeekInternal = new global::Infragistics.Collections.ObservableCollectionExtended<global::System.DayOfWeek>();
			this._daysOfWeekInternal.CollectionChanged += this.OnDaysOfWeekChanged;
			this._daysOfWeekInternal.ReInitialize(this._calendarManager.GetDaysOfWeek());
			this._daysOfWeek = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.DayOfWeek>(this._daysOfWeekInternal);
			this._disabledDates = new global::Infragistics.Windows.Editors.CalendarDateRangeCollection(this);
			this._disabledDates.CollectionChanged += this.OnDisabledDatesChanged;
			this._selectedDates = new global::Infragistics.Windows.Editors.SelectedDateCollection(this);
			this._selectedDatesSnapshot = new global::Infragistics.Collections.ObservableCollectionExtended<global::System.DateTime>();
			base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MonthCalendarPropertyKey, this);
			this._currentDateWatcher = new global::Infragistics.Windows.Editors.CurrentDate();
			global::Infragistics.Windows.Editors.CurrentDate currentDateWatcher = this._currentDateWatcher;
			currentDateWatcher.ValueChanged = (global::System.EventHandler)global::System.Delegate.Combine(currentDateWatcher.ValueChanged, new global::System.EventHandler(this.OnCurrentDateChanged));
			base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.TodayPropertyKey, this._currentDateWatcher.GetValue(global::Infragistics.Windows.Editors.CurrentDate.ValueProperty));
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0001401C File Offset: 0x0001221C
		private static object CoerceActiveDate(global::System.Windows.DependencyObject d, object value)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			if (value == null)
			{
				value = (xamMonthCalendar.SelectedDate ?? global::System.DateTime.Today);
			}
			if (value != null)
			{
				global::System.DateTime dateTime = (global::System.DateTime)value;
				global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = xamMonthCalendar.CurrentCalendarMode;
				dateTime = xamMonthCalendar._calendarManager.GetItemStartDate(dateTime, currentCalendarMode);
				dateTime = xamMonthCalendar.CoerceMinMaxDate(dateTime);
				global::System.DateTime dateTime2 = xamMonthCalendar._calendarManager.GetItemEndDate(dateTime, currentCalendarMode);
				dateTime2 = xamMonthCalendar.CoerceMinMaxDate(dateTime2);
				value = xamMonthCalendar.GetActivatableDate(dateTime, dateTime2, true, currentCalendarMode);
				if (value == null)
				{
					value = xamMonthCalendar.GetClosestActivatableDate(dateTime, dateTime2);
				}
			}
			return value;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x000140BC File Offset: 0x000122BC
		private static void OnActiveDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			if (xamMonthCalendar != null)
			{
				xamMonthCalendar.ClearPreferredNavInfo();
				if (e.NewValue is global::System.DateTime)
				{
					global::System.DateTime date = (global::System.DateTime)e.NewValue;
					if (!xamMonthCalendar._suppressBringActiveDateInView && !xamMonthCalendar.IsDateInView(date, true))
					{
						if (xamMonthCalendar._shouldBringActiveDateIntoView != null && xamMonthCalendar.IsDateInView(date, false, false))
						{
							xamMonthCalendar._shouldBringActiveDateIntoView = new bool?(true);
						}
						else
						{
							if (xamMonthCalendar._shouldBringActiveDateIntoView == true)
							{
								xamMonthCalendar._shouldBringActiveDateIntoView = new bool?(false);
							}
							xamMonthCalendar.BringDateIntoView(date);
						}
						if (xamMonthCalendar.IsKeyboardFocusWithin)
						{
							xamMonthCalendar.UpdateLayout();
						}
					}
					bool isNavigationMode = xamMonthCalendar.IsNavigationMode;
					if (e.OldValue is global::System.DateTime)
					{
						global::Infragistics.Windows.Editors.CalendarItem item = xamMonthCalendar.GetItem((global::System.DateTime)e.OldValue);
						if (item != null)
						{
							item.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsActivePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
							if (isNavigationMode)
							{
								item.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectedPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
							}
						}
					}
					global::Infragistics.Windows.Editors.CalendarItem item2 = xamMonthCalendar.GetItem(date);
					if (item2 != null)
					{
						item2.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						if (isNavigationMode)
						{
							item2.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						}
						if (xamMonthCalendar.IsKeyboardFocusWithin)
						{
							item2.Focus();
							return;
						}
					}
				}
				else if (e.OldValue is global::System.DateTime)
				{
					global::Infragistics.Windows.Editors.CalendarItem item3 = xamMonthCalendar.GetItem((global::System.DateTime)e.OldValue);
					if (item3 != null)
					{
						item3.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsActivePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
					}
				}
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x00014238 File Offset: 0x00012438
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x0001424A File Offset: 0x0001244A
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.DateTime>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime? ActiveDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ActiveDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ActiveDateProperty, value);
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0001425D File Offset: 0x0001245D
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0001426F File Offset: 0x0001246F
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowLeadingAndTrailingGroupActivation
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.AllowLeadingAndTrailingGroupActivationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.AllowLeadingAndTrailingGroupActivationProperty, value);
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00014282 File Offset: 0x00012482
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x00014294 File Offset: 0x00012494
		[global::System.ComponentModel.Bindable(true)]
		public bool AutoAdjustCalendarDimensions
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.AutoAdjustCalendarDimensionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.AutoAdjustCalendarDimensionsProperty, value);
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x000142A7 File Offset: 0x000124A7
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x000142B9 File Offset: 0x000124B9
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.CalendarDimensions CalendarDimensions
		{
			get
			{
				return (global::Infragistics.Windows.Editors.CalendarDimensions)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDimensionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDimensionsProperty, value);
			}
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x000142CC File Offset: 0x000124CC
		private static void OnItemStyleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Windows.Editors.XamMonthCalendar)d).NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.ItemStyleChange);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000142DA File Offset: 0x000124DA
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x000142EC File Offset: 0x000124EC
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style CalendarDayStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDayStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDayStyleProperty, value);
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000142FA File Offset: 0x000124FA
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x0001430C File Offset: 0x0001250C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.StyleSelector CalendarDayStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDayStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDayStyleSelectorProperty, value);
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0001431A File Offset: 0x0001251A
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x0001432C File Offset: 0x0001252C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style CalendarItemStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarItemStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarItemStyleProperty, value);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001433A File Offset: 0x0001253A
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0001434C File Offset: 0x0001254C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.StyleSelector CalendarItemStyleSelector
		{
			get
			{
				return (global::System.Windows.Controls.StyleSelector)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarItemStyleSelectorProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarItemStyleSelectorProperty, value);
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001435C File Offset: 0x0001255C
		private static object CoerceCurrentCalendarMode(global::System.Windows.DependencyObject d, object value)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			global::Infragistics.Windows.Editors.CalendarMode calendarMode = (global::Infragistics.Windows.Editors.CalendarMode)value;
			if (calendarMode < xamMonthCalendar.MinCalendarMode)
			{
				return xamMonthCalendar.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MinCalendarModeProperty);
			}
			if (calendarMode > xamMonthCalendar.MaxCalendarMode)
			{
				return xamMonthCalendar.MaxCalendarMode;
			}
			return value;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x000143A4 File Offset: 0x000125A4
		private static void OnCurrentCalendarModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			xamMonthCalendar.ClearPreferredNavInfo();
			xamMonthCalendar.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.CurrentModeChanged);
			bool suppressBringActiveDateInView = xamMonthCalendar._suppressBringActiveDateInView;
			xamMonthCalendar._suppressBringActiveDateInView = true;
			try
			{
				xamMonthCalendar.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ActiveDateProperty);
			}
			finally
			{
				xamMonthCalendar._suppressBringActiveDateInView = suppressBringActiveDateInView;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x000143FC File Offset: 0x000125FC
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x0001440E File Offset: 0x0001260E
		[global::System.Windows.Markup.DependsOn("MinCalendarMode")]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.CalendarMode CurrentCalendarMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.CalendarMode)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CurrentCalendarModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CurrentCalendarModeProperty, value);
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00014421 File Offset: 0x00012621
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00014433 File Offset: 0x00012633
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat DayOfWeekHeaderFormat
		{
			get
			{
				return (global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.DayOfWeekHeaderFormatProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.DayOfWeekHeaderFormatProperty, value);
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00014446 File Offset: 0x00012646
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00014458 File Offset: 0x00012658
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility DayOfWeekHeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.DayOfWeekHeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.DayOfWeekHeaderVisibilityProperty, value);
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0001446B File Offset: 0x0001266B
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.DayOfWeek> DaysOfWeek
		{
			get
			{
				return this._daysOfWeek;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00014473 File Offset: 0x00012673
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.CalendarDateRangeCollection DisabledDates
		{
			get
			{
				return this._disabledDates;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001447C File Offset: 0x0001267C
		private static void OnDisabledDaysOfWeekChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			using (new global::Infragistics.Windows.Editors.CalendarItemGroup.GroupInitializationHelper(xamMonthCalendar._groups))
			{
				if (!xamMonthCalendar.ShowDisabledDaysOfWeek)
				{
					xamMonthCalendar._calendarManager.HiddenDays = xamMonthCalendar.DisabledDaysOfWeek;
					xamMonthCalendar.InitializeDaysOfWeek();
				}
				xamMonthCalendar.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.DisabledDatesChanged);
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x000144E0 File Offset: 0x000126E0
		// (set) Token: 0x0600048C RID: 1164 RVA: 0x000144F2 File Offset: 0x000126F2
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.DayOfWeekFlags DisabledDaysOfWeek
		{
			get
			{
				return (global::Infragistics.Controls.DayOfWeekFlags)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.DisabledDaysOfWeekProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.DisabledDaysOfWeekProperty, value);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00014508 File Offset: 0x00012708
		private static void OnFirstDayOfWeekChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = d as global::Infragistics.Windows.Editors.XamMonthCalendar;
			if (xamMonthCalendar != null)
			{
				xamMonthCalendar._calendarManager.FirstDayOfWeek = (global::System.DayOfWeek?)e.NewValue;
				if (xamMonthCalendar.IsInitialized)
				{
					using (new global::Infragistics.Windows.Editors.CalendarItemGroup.GroupInitializationHelper(xamMonthCalendar._groups))
					{
						xamMonthCalendar.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.FirstDayOfWeekChanged);
						xamMonthCalendar.InitializeDaysOfWeek();
					}
				}
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00014574 File Offset: 0x00012774
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00014586 File Offset: 0x00012786
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.DayOfWeek>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DayOfWeek? FirstDayOfWeek
		{
			get
			{
				return (global::System.DayOfWeek?)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.FirstDayOfWeekProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.FirstDayOfWeekProperty, value);
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00014599 File Offset: 0x00012799
		public static bool GetIsSelectionActive(global::System.Windows.DependencyObject d)
		{
			return (bool)d.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.IsSelectionActiveProperty);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000145AC File Offset: 0x000127AC
		private static object CoerceMaxDate(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = d as global::Infragistics.Windows.Editors.XamMonthCalendar;
			global::System.DateTime dateTime = (global::System.DateTime)newValue;
			if (dateTime < xamMonthCalendar.MinDate)
			{
				dateTime = xamMonthCalendar.MinDate;
			}
			dateTime = xamMonthCalendar._calendarManager.CoerceMinMaxDate(dateTime);
			return dateTime;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000145F0 File Offset: 0x000127F0
		private static void OnMaxDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = d as global::Infragistics.Windows.Editors.XamMonthCalendar;
			if (xamMonthCalendar != null)
			{
				using (new global::Infragistics.Windows.Editors.CalendarItemGroup.GroupInitializationHelper(xamMonthCalendar._groups))
				{
					xamMonthCalendar.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
					xamMonthCalendar.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MeasureDateProperty);
					xamMonthCalendar.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.MaxDateChanged);
					if (xamMonthCalendar.IsInitialized)
					{
						xamMonthCalendar.SelectedDates.EnsureWithinMinMax();
					}
				}
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00014660 File Offset: 0x00012860
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00014672 File Offset: 0x00012872
		[global::System.Windows.Markup.DependsOn("MinDate")]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime MaxDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MaxDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MaxDateProperty, value);
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00014688 File Offset: 0x00012888
		private static void OnMaxSelectedDatesChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			int num = (int)e.NewValue;
			if (xamMonthCalendar.IsInitialized && num > 0 && num < xamMonthCalendar.SelectedDates.Count)
			{
				global::System.DateTime[] array = new global::System.DateTime[xamMonthCalendar.SelectedDates.Count];
				xamMonthCalendar.SelectedDates.CopyTo(array, 0);
				global::System.Array.Resize<global::System.DateTime>(ref array, num);
				xamMonthCalendar.SelectedDates.Reinitialize(array);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x000146F5 File Offset: 0x000128F5
		private static bool ValidateMaxSelected(object value)
		{
			return value is int && (int)value >= 0;
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x0001470D File Offset: 0x0001290D
		// (set) Token: 0x06000498 RID: 1176 RVA: 0x0001471F File Offset: 0x0001291F
		[global::System.ComponentModel.Bindable(true)]
		public int MaxSelectedDates
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MaxSelectedDatesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MaxSelectedDatesProperty, value);
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00014734 File Offset: 0x00012934
		internal int MaxSelectedDatesResolved
		{
			get
			{
				global::Infragistics.Windows.Controls.SelectionType selectionTypeResolved = this.SelectionTypeResolved;
				if (global::Infragistics.Windows.Selection.SelectionStrategyBase.IsMultiSelectStrategy(selectionTypeResolved))
				{
					int num = this.MaxSelectedDates;
					if (num == 0)
					{
						num = int.MaxValue;
					}
					return num;
				}
				if (global::Infragistics.Windows.Selection.SelectionStrategyBase.IsSingleSelectStrategy(selectionTypeResolved))
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00014770 File Offset: 0x00012970
		private static void OnMinDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = d as global::Infragistics.Windows.Editors.XamMonthCalendar;
			if (xamMonthCalendar != null)
			{
				using (new global::Infragistics.Windows.Editors.CalendarItemGroup.GroupInitializationHelper(xamMonthCalendar._groups))
				{
					xamMonthCalendar.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MaxDateProperty);
					xamMonthCalendar.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
					xamMonthCalendar.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MeasureDateProperty);
					xamMonthCalendar.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.MinDateChanged);
					if (xamMonthCalendar.IsInitialized)
					{
						xamMonthCalendar.SelectedDates.EnsureWithinMinMax();
					}
				}
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000147EC File Offset: 0x000129EC
		private static object CoerceMinDate(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = d as global::Infragistics.Windows.Editors.XamMonthCalendar;
			global::System.DateTime dateTime = (global::System.DateTime)newValue;
			dateTime = xamMonthCalendar._calendarManager.CoerceMinMaxDate(dateTime);
			return dateTime;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001481A File Offset: 0x00012A1A
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x0001482C File Offset: 0x00012A2C
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime MinDate
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MinDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MinDateProperty, value);
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00014840 File Offset: 0x00012A40
		private static void OnMinCalendarModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			xamMonthCalendar.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.CurrentCalendarModeProperty);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x0001485F File Offset: 0x00012A5F
		// (set) Token: 0x060004A0 RID: 1184 RVA: 0x00014871 File Offset: 0x00012A71
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Editors.CalendarMode MinCalendarMode
		{
			get
			{
				return (global::Infragistics.Windows.Editors.CalendarMode)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MinCalendarModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MinCalendarModeProperty, value);
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00014884 File Offset: 0x00012A84
		private static object CoerceReferenceDate(global::System.Windows.DependencyObject d, object value)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			global::System.DateTime defaultReferenceDate;
			if (value != null)
			{
				defaultReferenceDate = xamMonthCalendar.GetDefaultReferenceDate((global::System.DateTime)value);
			}
			else
			{
				defaultReferenceDate = xamMonthCalendar.GetDefaultReferenceDate();
			}
			return defaultReferenceDate;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x000148B7 File Offset: 0x00012AB7
		private static void OnReferenceDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (e.NewValue == null)
			{
				d.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty, global::System.DateTime.Today);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000148D7 File Offset: 0x00012AD7
		// (set) Token: 0x060004A4 RID: 1188 RVA: 0x000148E9 File Offset: 0x00012AE9
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.DateTime>))]
		public global::System.DateTime? ReferenceDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty, value);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x000148FC File Offset: 0x00012AFC
		// (set) Token: 0x060004A6 RID: 1190 RVA: 0x0001490E File Offset: 0x00012B0E
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ScrollButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ScrollButtonVisibilityProperty, value);
			}
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00014924 File Offset: 0x00012B24
		private static void OnSelectedDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			if (xamMonthCalendar != null)
			{
				if (e.NewValue == null)
				{
					xamMonthCalendar.SelectedDates.Clear();
				}
				else
				{
					if (xamMonthCalendar.SelectionType == global::Infragistics.Windows.Controls.SelectionType.None)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_MaxSelectedDatesExceeded", new object[]
						{
							1,
							0
						}));
					}
					global::System.DateTime date = ((global::System.DateTime)e.NewValue).Date;
					if (xamMonthCalendar.SelectedDates.Count == 0 || xamMonthCalendar.SelectedDates[0] != date)
					{
						xamMonthCalendar.SelectedDates.Reinitialize(new global::System.DateTime[]
						{
							date
						});
					}
				}
				if (e.NewValue != null && global::Infragistics.Windows.Selection.SelectionStrategyBase.IsSingleSelectStrategy(xamMonthCalendar.SelectionTypeResolved))
				{
					xamMonthCalendar.SetCurrentValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ActiveDateProperty, e.NewValue);
					return;
				}
				xamMonthCalendar.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ActiveDateProperty);
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x00014A14 File Offset: 0x00012C14
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x00014A26 File Offset: 0x00012C26
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.DateTime>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime? SelectedDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.SelectedDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.SelectedDateProperty, value);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00014A39 File Offset: 0x00012C39
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Windows.Editors.SelectedDateCollection SelectedDates
		{
			get
			{
				return this._selectedDates;
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00014A44 File Offset: 0x00012C44
		private static void OnSelectionTypeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			global::Infragistics.Windows.Controls.SelectionType selectionTypeResolved = xamMonthCalendar.SelectionTypeResolved;
			if (global::Infragistics.Windows.Selection.SelectionStrategyBase.IsSingleSelectStrategy(selectionTypeResolved))
			{
				xamMonthCalendar._pivotDate = xamMonthCalendar.SelectedDate;
				if (xamMonthCalendar.SelectedDates.Count > 1)
				{
					xamMonthCalendar.SelectedDates.Reinitialize(new global::System.DateTime[]
					{
						xamMonthCalendar.SelectedDates[0]
					});
					return;
				}
			}
			else if (!global::Infragistics.Windows.Selection.SelectionStrategyBase.IsMultiSelectStrategy(selectionTypeResolved))
			{
				xamMonthCalendar._pivotDate = null;
				xamMonthCalendar.SelectedDates.Clear();
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00014ACC File Offset: 0x00012CCC
		private static bool IsSelectionTypeValid(object value)
		{
			return global::System.Enum.IsDefined(typeof(global::Infragistics.Windows.Controls.SelectionType), value);
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00014ADE File Offset: 0x00012CDE
		// (set) Token: 0x060004AE RID: 1198 RVA: 0x00014AF0 File Offset: 0x00012CF0
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.Controls.SelectionType SelectionType
		{
			get
			{
				return (global::Infragistics.Windows.Controls.SelectionType)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.SelectionTypeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.SelectionTypeProperty, value);
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x00014B04 File Offset: 0x00012D04
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::Infragistics.Windows.Controls.SelectionType SelectionTypeResolved
		{
			get
			{
				global::Infragistics.Windows.Controls.SelectionType selectionType = this.SelectionType;
				if (selectionType == global::Infragistics.Windows.Controls.SelectionType.Default)
				{
					selectionType = global::Infragistics.Windows.Controls.SelectionType.Extended;
				}
				return selectionType;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x00014B1E File Offset: 0x00012D1E
		internal global::Infragistics.Windows.Controls.SelectionType CurrentSelectionTypeResolved
		{
			get
			{
				if (this.IsMinCalendarMode)
				{
					return this.SelectionTypeResolved;
				}
				return global::Infragistics.Windows.Controls.SelectionType.Single;
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00014B30 File Offset: 0x00012D30
		private static void OnShowDisabledDaysOfWeek(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			if (xamMonthCalendar.DisabledDaysOfWeek != global::Infragistics.Controls.DayOfWeekFlags.None)
			{
				global::Infragistics.Controls.DayOfWeekFlags hiddenDays = false.Equals(e.NewValue) ? xamMonthCalendar.DisabledDaysOfWeek : global::Infragistics.Controls.DayOfWeekFlags.None;
				xamMonthCalendar._calendarManager.HiddenDays = hiddenDays;
				if (!xamMonthCalendar.InitializeDaysOfWeek())
				{
					xamMonthCalendar.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.DisabledDatesChanged);
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00014B83 File Offset: 0x00012D83
		// (set) Token: 0x060004B3 RID: 1203 RVA: 0x00014B95 File Offset: 0x00012D95
		[global::System.ComponentModel.Bindable(true)]
		public bool ShowDisabledDaysOfWeek
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ShowDisabledDaysOfWeekProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ShowDisabledDaysOfWeekProperty, value);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00014BA8 File Offset: 0x00012DA8
		// (set) Token: 0x060004B5 RID: 1205 RVA: 0x00014BBA File Offset: 0x00012DBA
		[global::System.ComponentModel.Bindable(true)]
		public bool ShowLeadingAndTrailingDates
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ShowLeadingAndTrailingDatesProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ShowLeadingAndTrailingDatesProperty, value);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x00014BCD File Offset: 0x00012DCD
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00014BDF File Offset: 0x00012DDF
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility TodayButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.TodayButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.TodayButtonVisibilityProperty, value);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00014BF2 File Offset: 0x00012DF2
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00014C04 File Offset: 0x00012E04
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility WeekNumberVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.WeekNumberVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.WeekNumberVisibilityProperty, value);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00014C18 File Offset: 0x00012E18
		private static void OnThemeChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = target as global::Infragistics.Windows.Editors.XamMonthCalendar;
			xamMonthCalendar.OnThemeChanged((string)e.OldValue, (string)e.NewValue);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x00014C4A File Offset: 0x00012E4A
		// (set) Token: 0x060004BC RID: 1212 RVA: 0x00014C5C File Offset: 0x00012E5C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Themes.Internal.EditorsThemeTypeConverter))]
		public string Theme
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ThemeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ThemeProperty, value);
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00014C6C File Offset: 0x00012E6C
		protected virtual void OnThemeChanged(string previousValue, string currentValue)
		{
			base.RaiseEvent(new global::System.Windows.RoutedPropertyChangedEventArgs<string>(previousValue, currentValue)
			{
				RoutedEvent = global::Infragistics.Windows.Editors.XamMonthCalendar.ThemeChangedEvent,
				Source = this
			});
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060004BE RID: 1214 RVA: 0x00014C9A File Offset: 0x00012E9A
		// (remove) Token: 0x060004BF RID: 1215 RVA: 0x00014CA8 File Offset: 0x00012EA8
		public event global::System.Windows.RoutedPropertyChangedEventHandler<string> ThemeChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.ThemeChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.ThemeChangedEvent, value);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00014CB6 File Offset: 0x00012EB6
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime Today
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.TodayProperty);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00014CC8 File Offset: 0x00012EC8
		private static void OnWeekRuleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = d as global::Infragistics.Windows.Editors.XamMonthCalendar;
			if (xamMonthCalendar != null)
			{
				xamMonthCalendar._calendarManager.WeekRule = (global::System.Globalization.CalendarWeekRule?)e.NewValue;
				xamMonthCalendar.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.WeekRuleChanged);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00014CFD File Offset: 0x00012EFD
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00014D0F File Offset: 0x00012F0F
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Helpers.NullableConverter<global::System.Globalization.CalendarWeekRule>))]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Globalization.CalendarWeekRule? WeekRule
		{
			get
			{
				return (global::System.Globalization.CalendarWeekRule?)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.WeekRuleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.WeekRuleProperty, value);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00014D24 File Offset: 0x00012F24
		private static void OnWorkdaysChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			xamMonthCalendar.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.WorkdaysChanged);
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00014D40 File Offset: 0x00012F40
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00014D52 File Offset: 0x00012F52
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.DayOfWeekFlags Workdays
		{
			get
			{
				return (global::Infragistics.Controls.DayOfWeekFlags)base.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.WorkdaysProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.WorkdaysProperty, value);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00014D65 File Offset: 0x00012F65
		internal global::Infragistics.Windows.Editors.CalendarManager CalendarManager
		{
			get
			{
				return this._calendarManager;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00014D6D File Offset: 0x00012F6D
		internal bool IsNavigationMode
		{
			get
			{
				return !this.IsMinCalendarMode;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00014D78 File Offset: 0x00012F78
		internal bool IsMinCalendarMode
		{
			get
			{
				return this.CurrentCalendarMode == this.MinCalendarMode;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x00014D88 File Offset: 0x00012F88
		internal global::Infragistics.Windows.Editors.CalendarMode MaxCalendarMode
		{
			get
			{
				return global::Infragistics.Windows.Editors.CalendarMode.Centuries;
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00014D8C File Offset: 0x00012F8C
		private static object CoerceMeasureDate(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = d as global::Infragistics.Windows.Editors.XamMonthCalendar;
			global::System.DateTime dateTime = (global::System.DateTime)newValue;
			dateTime = xamMonthCalendar._calendarManager.CoerceMinMaxDate(dateTime);
			return dateTime;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00014DBA File Offset: 0x00012FBA
		public static global::Infragistics.Windows.Editors.XamMonthCalendar GetMonthCalendar(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Editors.XamMonthCalendar)d.GetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MonthCalendarProperty);
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00014DCC File Offset: 0x00012FCC
		internal global::Infragistics.Windows.Selection.ISelectionHost SelectionHost
		{
			get
			{
				return this;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00014DCF File Offset: 0x00012FCF
		// (set) Token: 0x060004CF RID: 1231 RVA: 0x00014DD7 File Offset: 0x00012FD7
		internal global::Infragistics.Windows.Selection.ISelectionStrategyFilter SelectionStrategyFilter
		{
			get
			{
				return this._selectionStrategyFilter;
			}
			set
			{
				this._selectionStrategyFilter = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00014DE0 File Offset: 0x00012FE0
		private global::Infragistics.Windows.Editors.MonthCalendarStates CurrentState
		{
			get
			{
				global::Infragistics.Windows.Editors.MonthCalendarStates monthCalendarStates = (global::Infragistics.Windows.Editors.MonthCalendarStates)0L;
				if (this._groups.Count > 0)
				{
					global::Infragistics.Windows.Editors.CalendarItemGroup firstGroup = this.GetFirstGroup(true, true);
					global::Infragistics.Windows.Editors.CalendarItemGroup lastGroup = this.GetLastGroup(true, true);
					if (firstGroup != null && firstGroup.FirstDateOfGroup <= this.MinDate)
					{
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.MinDateInView;
					}
					if (lastGroup != null && lastGroup.LastDateOfGroup >= this.MaxDate)
					{
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.MaxDateInView;
					}
					if (this.CanActivate(global::System.DateTime.Today))
					{
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.TodayIsEnabled;
					}
					if (this.ActiveDate != null)
					{
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.ActiveDate;
					}
					if (this.CurrentCalendarMode > this.MinCalendarMode)
					{
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.CanZoomInCalendarMode;
					}
					if (this.CurrentCalendarMode < this.MaxCalendarMode && (!this.IsDateInView(this.MinDate, true, false) || !this.IsDateInView(this.MaxDate, true, false)))
					{
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.CanZoomOutCalendarMode;
					}
					switch (this.CurrentCalendarMode)
					{
					case global::Infragistics.Windows.Editors.CalendarMode.Days:
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.CalendarModeDays;
						break;
					case global::Infragistics.Windows.Editors.CalendarMode.Months:
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.CalendarModeMonths;
						break;
					case global::Infragistics.Windows.Editors.CalendarMode.Years:
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.CalendarModeYears;
						break;
					case global::Infragistics.Windows.Editors.CalendarMode.Decades:
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.CalendarModeDecades;
						break;
					case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.CalendarModeCenturies;
						break;
					}
					if (this.IsMinCalendarMode)
					{
						monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.MinCalendarMode;
					}
				}
				if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					monthCalendarStates |= global::Infragistics.Windows.Editors.MonthCalendarStates.RightToLeft;
				}
				return monthCalendarStates;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00014F65 File Offset: 0x00013165
		private global::Infragistics.Windows.Editors.CalendarItemGroup FirstGroup
		{
			get
			{
				return this.GetFirstGroup(true, false);
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00014F6F File Offset: 0x0001316F
		private global::Infragistics.Windows.Editors.CalendarItemGroup LastGroup
		{
			get
			{
				return this.GetLastGroup(true, false);
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00014F79 File Offset: 0x00013179
		public void BringDateIntoView(global::System.DateTime date)
		{
			this.BringDateIntoView(date, null);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00014F84 File Offset: 0x00013184
		internal void BringDateIntoView(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			int groupIndex = (group == null) ? -1 : this._groups.IndexOf(group);
			this.BringDateIntoView(date, groupIndex, true);
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00014FB0 File Offset: 0x000131B0
		internal void BringDateIntoView(global::System.DateTime date, int groupIndex, bool ignoreLeadingAndTrailingDates)
		{
			if (this._shouldBringActiveDateIntoView != null)
			{
				this._shouldBringActiveDateIntoView = new bool?(false);
			}
			date = this.CoerceMinMaxDate(date);
			if (this._groups.Count == 0)
			{
				this.ReferenceDate = new global::System.DateTime?(date);
				return;
			}
			if (groupIndex >= 0)
			{
				groupIndex = global::System.Math.Min(this._groups.IndexOf(this.GetFirstGroup(false)), global::System.Math.Max(this._groups.IndexOf(this.GetLastGroup(false)), groupIndex));
				global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = this._groups[groupIndex];
				global::System.DateTime? dateTime = null;
				global::System.DateTime? dateTime2 = null;
				if (calendarItemGroup.FirstDateOfGroup != null)
				{
					dateTime = new global::System.DateTime?(ignoreLeadingAndTrailingDates ? calendarItemGroup.FirstDateOfGroup.Value : calendarItemGroup.FirstDate);
				}
				if (calendarItemGroup.LastDateOfGroup != null)
				{
					dateTime2 = new global::System.DateTime?(ignoreLeadingAndTrailingDates ? calendarItemGroup.LastDateOfGroup.Value : calendarItemGroup.LastDate);
				}
				if (date < dateTime || dateTime2 < date || dateTime == null || dateTime2 == null)
				{
					global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
					global::System.DateTime value = this._calendarManager.GetGroupStartDate(date, currentCalendarMode);
					value = this._calendarManager.AddGroupOffset(date, -groupIndex, currentCalendarMode, true);
					this.ReferenceDate = new global::System.DateTime?(value);
				}
				return;
			}
			if (this.IsDateInView(date, ignoreLeadingAndTrailingDates))
			{
				return;
			}
			if (this._groups.Count == 1)
			{
				this.ReferenceDate = new global::System.DateTime?(date);
				return;
			}
			global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode2 = this.CurrentCalendarMode;
			global::System.DateTime dateTime3 = this._calendarManager.GetGroupStartDate(date, currentCalendarMode2);
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup2 = (dateTime3 < this.ReferenceDate) ? this.GetFirstGroup(false) : this.GetLastGroup(false);
			int referenceGroupOffset = calendarItemGroup2.ReferenceGroupOffset;
			dateTime3 = this._calendarManager.AddGroupOffset(dateTime3, -referenceGroupOffset, currentCalendarMode2, true);
			this.ReferenceDate = new global::System.DateTime?(dateTime3);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x000151E1 File Offset: 0x000133E1
		public bool ExecuteCommand(global::System.Windows.Input.RoutedCommand command)
		{
			return this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command));
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x000151EF File Offset: 0x000133EF
		public bool ExecuteCommand(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x000151F8 File Offset: 0x000133F8
		private bool ExecuteCommandImpl(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("commandInfo", commandInfo);
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			object parameter = commandInfo.Parameter;
			object originalSource = commandInfo.OriginalSource;
			global::Infragistics.Windows.Editors.Utils.ValidateNull("command", routedCommand);
			if (!global::Infragistics.Windows.Commands.Commands<global::Infragistics.Windows.Editors.XamMonthCalendar>.IsMinimumStatePresentForCommand(this, routedCommand))
			{
				return false;
			}
			global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs executingCommandEventArgs = new global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs(routedCommand);
			if (!this.RaiseExecutingCommand(executingCommandEventArgs))
			{
				return !executingCommandEventArgs.ContinueKeyRouting;
			}
			bool shiftKeyDown = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
			bool ctlKeyDown = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
			bool flag = false;
			if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollNextGroup || routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollPreviousGroup)
			{
				int numberOfGroups = (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollNextGroup) ? 1 : -1;
				flag = this.ScrollGroups(numberOfGroups);
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ToggleActiveDateSelection)
			{
				flag = this.ToggleActiveDateSelection(shiftKeyDown, ctlKeyDown);
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollNextGroups || routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollPreviousGroups)
			{
				int num = (parameter is int) ? ((int)parameter) : (this.GetLastGroup(false).ReferenceGroupOffset - this.GetFirstGroup(false).ReferenceGroupOffset + 1);
				if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollPreviousGroups)
				{
					num *= -1;
				}
				flag = this.ScrollGroups(num);
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollToDate)
			{
				if (parameter is global::System.DateTime)
				{
					global::System.DateTime date = (global::System.DateTime)parameter;
					global::Infragistics.Windows.Editors.CalendarItemGroup group = null;
					if (originalSource is global::System.Windows.DependencyObject)
					{
						if (originalSource is global::Infragistics.Windows.Editors.CalendarItemGroup)
						{
							group = (global::Infragistics.Windows.Editors.CalendarItemGroup)originalSource;
						}
						else
						{
							group = (global::Infragistics.Windows.Editors.CalendarItemGroup)global::Infragistics.Windows.Utilities.GetAncestorFromType((global::System.Windows.DependencyObject)originalSource, typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), true);
						}
					}
					this.BringDateIntoView(date, group);
					flag = true;
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ActivateDate)
			{
				global::System.DateTime? dateValue = null;
				if (parameter is global::System.DateTime)
				{
					dateValue = new global::System.DateTime?((global::System.DateTime)parameter);
				}
				else
				{
					global::Infragistics.Windows.Editors.CalendarItem calendarItem = parameter as global::Infragistics.Windows.Editors.CalendarItem;
					if (calendarItem == null && originalSource is global::System.Windows.DependencyObject)
					{
						if (originalSource is global::Infragistics.Windows.Editors.CalendarItem)
						{
							calendarItem = (global::Infragistics.Windows.Editors.CalendarItem)originalSource;
						}
						else
						{
							calendarItem = (global::Infragistics.Windows.Editors.CalendarItem)global::Infragistics.Windows.Utilities.GetAncestorFromType((global::System.Windows.DependencyObject)originalSource, typeof(global::Infragistics.Windows.Editors.CalendarItem), true);
						}
					}
					if (calendarItem != null)
					{
						dateValue = new global::System.DateTime?(calendarItem.StartDate);
					}
				}
				flag = this.ActivateDate(dateValue, false);
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ActivateSelectedDate)
			{
				this.SetActiveDate(this.SelectedDate);
				flag = true;
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.Today)
			{
				flag = this.ActivateDate(new global::System.DateTime?(global::System.DateTime.Today));
				this.RaiseSelectionCommitted(new global::System.Windows.RoutedEventArgs());
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.PreviousItem || routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.NextItem)
			{
				flag = this.ActivateDate(this.GetActivatableDate(this.ActiveDate, routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.PreviousItem, false));
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.PreviousItemRow || routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.NextItemRow)
			{
				if (this.ActiveDate != null)
				{
					flag = this.NavigateRow(this.ActiveDate.Value, routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.NextItemRow);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.PreviousGroup || routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.NextGroup)
			{
				if (this.ActiveDate != null)
				{
					flag = this.NavigateGroup(this.ActiveDate.Value, routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.NextGroup);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.FirstItemOfGroup)
			{
				if (this.ActiveDate != null)
				{
					global::System.DateTime? activatableDate = this.GetActivatableDate(new global::System.DateTime?(this._calendarManager.GetGroupStartDate(this.ActiveDate.Value, this.CurrentCalendarMode)), false, true);
					flag = this.ActivateDate(activatableDate);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.LastItemOfGroup)
			{
				if (this.ActiveDate != null)
				{
					global::System.DateTime? activatableDate2 = this.GetActivatableDate(new global::System.DateTime?(this._calendarManager.GetGroupEndDate(this.ActiveDate.Value, this.CurrentCalendarMode)), true, true);
					flag = this.ActivateDate(activatableDate2);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.FirstItemOfFirstGroup)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup firstGroup = this.GetFirstGroup(false);
				if (firstGroup != null)
				{
					global::System.DateTime? activatableDate3 = this.GetActivatableDate(firstGroup.FirstDateOfGroup, false, true);
					flag = this.ActivateDate(activatableDate3);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.LastItemOfLastGroup)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup lastGroup = this.GetLastGroup(false);
				if (lastGroup != null)
				{
					global::System.DateTime? activatableDate4 = this.GetActivatableDate(lastGroup.LastDateOfGroup, true, true);
					flag = this.ActivateDate(activatableDate4);
				}
			}
			else if (routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ZoomOutCalendarMode || routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ZoomInCalendarMode)
			{
				this.ChangeCalendarMode(routedCommand == global::Infragistics.Windows.Editors.MonthCalendarCommands.ZoomOutCalendarMode, parameter, originalSource);
				flag = true;
			}
			if (flag)
			{
				this.RaiseExecutedCommand(new global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs(routedCommand));
			}
			if (parameter == global::Infragistics.Windows.Editors.MonthCalendarCommands.NavigationKeyParameter)
			{
				flag = true;
			}
			return flag;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001566C File Offset: 0x0001386C
		internal bool CanActivate(global::System.DateTime date)
		{
			return this.GetActivatableItemDate(date, this.CurrentCalendarMode) != null;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00015690 File Offset: 0x00013890
		internal bool CanActivate(global::System.DateTime start, global::System.DateTime end, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return this.GetActivatableDate(start, end, true, mode) != null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x000156AF File Offset: 0x000138AF
		internal global::System.DateTime CoerceMinMaxDate(global::System.DateTime date)
		{
			date = date.Date;
			if (date > this.MaxDate)
			{
				date = this.MaxDate;
			}
			else if (date < this.MinDate)
			{
				date = this.MinDate;
			}
			return date;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x000156EC File Offset: 0x000138EC
		internal void FocusActiveItemWithDelay()
		{
			if (!base.IsKeyboardFocusWithin)
			{
				return;
			}
			bool preventFocusActiveItem = this._preventFocusActiveItem;
			this._preventFocusActiveItem = true;
			try
			{
				base.Focus();
				base.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Render, new global::Infragistics.Windows.Editors.Utils.MethodInvoker(this.FocusActiveItem));
			}
			finally
			{
				this._preventFocusActiveItem = preventFocusActiveItem;
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0001574C File Offset: 0x0001394C
		internal global::System.DateTime? GetActivatableDate(global::Infragistics.Windows.Editors.CalendarItem item)
		{
			global::System.DateTime? result;
			if (item == null)
			{
				result = null;
			}
			else
			{
				result = this.GetActivatableDate(item.StartDate, item.EndDate, true, this.CurrentCalendarMode);
			}
			return result;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00015781 File Offset: 0x00013981
		internal global::System.DateTime? GetActivatableDate(global::System.DateTime start, global::System.DateTime end, bool next)
		{
			return this.GetActivatableDate(start, end, next, this.CurrentCalendarMode);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00015794 File Offset: 0x00013994
		internal global::System.DateTime? GetActivatableDate(global::System.DateTime start, global::System.DateTime end, bool next, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			if (end < this.MinDate || start > this.MaxDate)
			{
				return null;
			}
			if (mode != this.MinCalendarMode)
			{
				if (!next)
				{
					return new global::System.DateTime?(end);
				}
				return new global::System.DateTime?(start);
			}
			else
			{
				global::System.DateTime start2 = this.CoerceMinMaxDate(start);
				global::System.DateTime end2 = this.CoerceMinMaxDate(end);
				int disabledDaysOfWeek = (int)this.DisabledDaysOfWeek;
				int daysOfWeek = this.GetDaysOfWeek(start2, end2);
				if ((disabledDaysOfWeek & daysOfWeek) == daysOfWeek)
				{
					return null;
				}
				return this._disabledDates.GetAvailableDate(start2, end2, next);
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00015824 File Offset: 0x00013A24
		private global::System.DateTime? GetActivatableItemDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			global::System.DateTime itemStartDate = this.CalendarManager.GetItemStartDate(date, mode);
			global::System.DateTime itemEndDate = this.CalendarManager.GetItemEndDate(date, mode);
			return this.GetActivatableDate(itemStartDate, itemEndDate, true, mode);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00015858 File Offset: 0x00013A58
		internal global::Infragistics.Windows.Editors.CalendarItemGroup GetGroup(global::System.DateTime date)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup result = null;
			if (this._groups.Count > 0)
			{
				for (int i = 0; i < this._groups.Count; i++)
				{
					global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = this._groups[i];
					if (calendarItemGroup.Items.Count != 0)
					{
						if (calendarItemGroup.FirstDateOfGroup == null || calendarItemGroup.FirstDate > date)
						{
							break;
						}
						if (!(calendarItemGroup.LastDate < date))
						{
							result = calendarItemGroup;
							if (calendarItemGroup.FirstDateOfGroup <= date && date <= calendarItemGroup.LastDateOfGroup)
							{
								break;
							}
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00015A40 File Offset: 0x00013C40
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.Editors.CalendarItemGroup> GetGroups()
		{
			for (int i = 0; i < this._groups.Count; i++)
			{
				yield return this._groups[i];
			}
			yield break;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00015A60 File Offset: 0x00013C60
		internal global::System.DateTime[] GetSelectableDates(global::Infragistics.Windows.Editors.CalendarDateRange range)
		{
			range.Normalize();
			range.RemoveTime();
			if (range.End > this.MaxDate || range.Start < this.MinDate)
			{
				return new global::System.DateTime[0];
			}
			if (range.Start < this.MinDate)
			{
				range.Start = this.MinDate;
			}
			else if (range.End > this.MaxDate)
			{
				range.End = this.MaxDate;
			}
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			this._disabledDates.AddAvailableDates(range, list);
			return list.ToArray();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00015B07 File Offset: 0x00013D07
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.XamMonthCalendar.GetString(name, null);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00015B10 File Offset: 0x00013D10
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00015B1C File Offset: 0x00013D1C
		internal bool InternalSelectItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			global::Infragistics.Windows.Editors.CalendarItem item2 = this.GetItem(item);
			global::System.DateTime? activatableDate = this.GetActivatableDate(item2);
			return this.InternalSelectItem(activatableDate, clearExistingSelection, select);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00015B44 File Offset: 0x00013D44
		internal bool InternalSelectItem(global::System.DateTime? date, bool clearExistingSelection, bool select)
		{
			if (date == null && (!clearExistingSelection || this._selectedDates.Count == 0))
			{
				return false;
			}
			if (date != null && select && !this.CanActivate(date.Value))
			{
				select = false;
			}
			if (date != null && this.SelectedDates.IsSelected(date.Value) == select && (!clearExistingSelection || this._selectedDates.Count == 0))
			{
				return true;
			}
			global::System.Collections.Generic.IList<global::System.DateTime> newSelection = this.CalculateNewSelection(date, clearExistingSelection, select);
			this.SelectedDates.Reinitialize(newSelection);
			return true;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00015BD4 File Offset: 0x00013DD4
		internal bool InternalSelectRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			global::Infragistics.Windows.Editors.CalendarItem item2 = this.GetItem(item);
			if (item2 == null)
			{
				return false;
			}
			if (this._pivotDate == null)
			{
				this.SelectionHost.SetPivotItem(item2, false);
			}
			global::System.DateTime? activatableDate = this.GetActivatableDate(item2);
			global::System.Collections.Generic.IList<global::System.DateTime> newSelection = this.CalculateNewSelectionRange(activatableDate, clearExistingSelection, select);
			this.SelectedDates.Reinitialize(newSelection);
			return true;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00015C27 File Offset: 0x00013E27
		internal bool IsDateInView(global::System.DateTime date, bool ignoreLeadingTrailingDates)
		{
			return this.IsDateInView(date, ignoreLeadingTrailingDates, this.IsMinCalendarMode && !this.AllowLeadingAndTrailingGroupActivation);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00015C48 File Offset: 0x00013E48
		internal bool IsDateInView(global::System.DateTime date, bool ignoreLeadingTrailingDates, bool ignoreLeadingTrailingGroups)
		{
			if (this._groups.Count > 0)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup firstGroup = this.GetFirstGroup(true, ignoreLeadingTrailingGroups);
				global::Infragistics.Windows.Editors.CalendarItemGroup lastGroup = this.GetLastGroup(true, ignoreLeadingTrailingGroups);
				if (firstGroup != null && lastGroup != null)
				{
					global::System.DateTime t = ignoreLeadingTrailingDates ? firstGroup.FirstDateOfGroup.Value : firstGroup.FirstDate;
					global::System.DateTime t2 = ignoreLeadingTrailingDates ? lastGroup.LastDateOfGroup.Value : lastGroup.LastDate;
					if (date >= t && date <= t2)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00015CC6 File Offset: 0x00013EC6
		internal bool IsZoomFocusGroup(global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			return group == this._zoomFocusGroup;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00015CD4 File Offset: 0x00013ED4
		internal void OnAutoGeneratedGroupsChanged()
		{
			using (new global::Infragistics.Windows.Editors.CalendarItemGroup.GroupInitializationHelper(this._groups))
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
			}
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00015D14 File Offset: 0x00013F14
		internal void OnGroupOffsetChanged(global::Infragistics.Windows.Editors.CalendarItemGroup group, int oldOffset, int newOffset)
		{
			this.SortGroups();
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00015D1C File Offset: 0x00013F1C
		internal void RegisterGroup(global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			if (group.IsGroupForSizing)
			{
				this._groupForSizing = group;
				return;
			}
			this._groups.Add(group);
			this.SortGroups();
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00015D40 File Offset: 0x00013F40
		internal void SetActiveDate(global::System.DateTime? value)
		{
			base.SetCurrentValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ActiveDateProperty, value);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00015D53 File Offset: 0x00013F53
		internal void UnregisterGroup(global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			if (group.IsGroupForSizing)
			{
				if (group == this._groupForSizing)
				{
					this._groupForSizing = null;
					return;
				}
			}
			else
			{
				this._groups.Remove(group);
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00015D7B File Offset: 0x00013F7B
		internal void OnSelectedStateChanged(global::System.Collections.Generic.IList<global::System.DateTime> datesSelected, global::System.Collections.Generic.IList<global::System.DateTime> datesUnselected)
		{
			if (this.IsMinCalendarMode && !this.HasOverlappingGroups())
			{
				this.UpdateSelectedState(datesSelected, true);
				this.UpdateSelectedState(datesUnselected, false);
				return;
			}
			this.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.SelectionChanged);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00015DA5 File Offset: 0x00013FA5
		private bool ActivateDate(global::System.DateTime? dateValue)
		{
			return this.ActivateDate(dateValue, true);
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00015DB0 File Offset: 0x00013FB0
		private bool ActivateDate(global::System.DateTime? dateValue, bool useSelectionStrategy)
		{
			bool result = false;
			if (dateValue != null)
			{
				global::System.DateTime? activatableItemDate = this.GetActivatableItemDate(dateValue.Value, this.CurrentCalendarMode);
				if (activatableItemDate == null)
				{
					return false;
				}
				global::System.DateTime value = dateValue.Value;
				bool flag = true;
				if (useSelectionStrategy)
				{
					if (this._pivotDate == null)
					{
						global::System.DateTime? selectedDate = this.SelectedDate;
						this._pivotDate = ((selectedDate != null) ? new global::System.DateTime?(selectedDate.GetValueOrDefault()) : this.ActiveDate);
					}
					this.BringDateIntoView(value);
					global::Infragistics.Windows.Editors.CalendarItem item = this.GetItem(value);
					if (item != null)
					{
						global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = this.SelectionHost.GetSelectionStrategyForItem(item);
						if (selectionStrategyForItem != null)
						{
							bool shiftKeyDown = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
							bool controlKeyDown = (global::System.Windows.Input.Keyboard.Modifiers & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
							result = selectionStrategyForItem.SelectItemViaKeyboard(item, shiftKeyDown, controlKeyDown, false);
							flag = false;
						}
					}
				}
				if (flag)
				{
					this.SetActiveDate(new global::System.DateTime?(value));
					result = (this.ActiveDate == activatableItemDate);
				}
			}
			return result;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00015ED8 File Offset: 0x000140D8
		internal global::System.Collections.Generic.IList<global::System.DateTime> CalculateNewSelection(global::System.DateTime? date, bool clearExistingSelection, bool select)
		{
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			if (!clearExistingSelection)
			{
				list.AddRange(this._selectedDates);
			}
			if (date != null)
			{
				if (select)
				{
					if (this.CanActivate(date.Value))
					{
						list.Add(date.Value);
					}
				}
				else
				{
					list.Remove(date.Value);
				}
			}
			if (select)
			{
				this.EnsureItemsWithinMaxSelectedItemsBounds(list);
			}
			return list;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00015F40 File Offset: 0x00014140
		internal global::System.Collections.Generic.IList<global::System.DateTime> CalculateNewSelectionRange(global::System.DateTime? date, bool clearExistingSelection, bool select)
		{
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			if (this._pivotDate == null)
			{
				return list;
			}
			if (date != null)
			{
				bool flag = false;
				global::System.DateTime value;
				global::System.DateTime value2;
				if (this._pivotDate.Value <= date)
				{
					value = this._pivotDate.Value;
					value2 = date.Value;
				}
				else
				{
					flag = true;
					value = date.Value;
					value2 = this._pivotDate.Value;
				}
				if (!clearExistingSelection)
				{
					foreach (global::System.DateTime dateTime in this._selectedDatesSnapshot)
					{
						if (dateTime < value || dateTime > value2)
						{
							list.Add(dateTime);
						}
					}
				}
				if (select)
				{
					int offset = 1;
					if (flag)
					{
						value = this._pivotDate.Value;
						value2 = date.Value;
						offset = -1;
					}
					global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
					global::System.DateTime? dateTime2 = new global::System.DateTime?(value);
					while (dateTime2 != null && (flag || !(dateTime2 > value2)) && (!flag || !(dateTime2 < value2)))
					{
						global::System.DateTime? activatableItemDate = this.GetActivatableItemDate(dateTime2.Value, currentCalendarMode);
						if (activatableItemDate != null)
						{
							list.Add(activatableItemDate.Value);
						}
						dateTime2 = this._calendarManager.TryAddItemOffset(dateTime2.Value, offset, currentCalendarMode);
					}
				}
				if (select)
				{
					this.EnsureItemsWithinMaxSelectedItemsBounds(list);
				}
			}
			return list;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00016100 File Offset: 0x00014300
		private void ChangeCalendarMode(bool zoomOut, object commandParameter, object originalSource)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = null;
			global::System.DateTime? dateTime = null;
			if (commandParameter is global::System.DateTime)
			{
				dateTime = new global::System.DateTime?((global::System.DateTime)commandParameter);
			}
			if (zoomOut)
			{
				calendarItemGroup = (commandParameter as global::Infragistics.Windows.Editors.CalendarItemGroup);
				if (calendarItemGroup == null && originalSource is global::System.Windows.DependencyObject)
				{
					if (originalSource is global::Infragistics.Windows.Editors.CalendarItemGroup)
					{
						calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)originalSource;
					}
					else
					{
						calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)global::Infragistics.Windows.Utilities.GetAncestorFromType((global::System.Windows.DependencyObject)originalSource, typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), true);
					}
				}
				if (dateTime == null && calendarItemGroup != null)
				{
					dateTime = calendarItemGroup.FirstDateOfGroup;
				}
			}
			else
			{
				global::Infragistics.Windows.Editors.CalendarItem calendarItem = commandParameter as global::Infragistics.Windows.Editors.CalendarItem;
				if (calendarItem == null && originalSource is global::System.Windows.DependencyObject)
				{
					if (originalSource is global::Infragistics.Windows.Editors.CalendarItem)
					{
						calendarItem = (global::Infragistics.Windows.Editors.CalendarItem)originalSource;
					}
					else
					{
						calendarItem = (global::Infragistics.Windows.Editors.CalendarItem)global::Infragistics.Windows.Utilities.GetAncestorFromType((global::System.Windows.DependencyObject)originalSource, typeof(global::Infragistics.Windows.Editors.CalendarItem), true);
					}
				}
				if (calendarItem != null)
				{
					calendarItemGroup = calendarItem.Group;
					if (dateTime == null)
					{
						dateTime = new global::System.DateTime?(calendarItem.StartDate);
					}
				}
			}
			global::System.DateTime? dateTime2 = dateTime;
			if (calendarItemGroup == null && global::Infragistics.Windows.Helpers.FocusWithinManager.CheckFocusWithinHelper(this))
			{
				if (this.ActiveDate != null)
				{
					calendarItemGroup = this.GetGroup(this.ActiveDate.Value);
				}
				if (calendarItemGroup != null && dateTime == null)
				{
					dateTime = (dateTime2 = this.ActiveDate);
				}
			}
			int num = (calendarItemGroup != null) ? calendarItemGroup.ReferenceGroupOffset : 0;
			int num2 = zoomOut ? 1 : -1;
			global::Infragistics.Windows.Editors.CalendarMode calendarMode = (short)num2 + this.CurrentCalendarMode;
			using (new global::Infragistics.Windows.Editors.CalendarItemGroup.GroupInitializationHelper(this._groups, false))
			{
				try
				{
					this._zoomFocusGroup = calendarItemGroup;
					this.CurrentCalendarMode = calendarMode;
				}
				finally
				{
					this._zoomFocusGroup = null;
				}
				if (this.CurrentCalendarMode == calendarMode && dateTime2 != null)
				{
					global::System.DateTime dateTime3 = this._calendarManager.GetGroupStartDate(dateTime2.Value, calendarMode);
					if (num != 0)
					{
						dateTime3 = this._calendarManager.AddGroupOffset(dateTime3, -num, calendarMode, true);
					}
					this.ReferenceDate = new global::System.DateTime?(dateTime3);
				}
				base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
			}
			global::System.DateTime? dateTime4 = dateTime;
			global::System.DateTime? dateTime5 = (dateTime4 != null) ? new global::System.DateTime?(dateTime4.GetValueOrDefault()) : this.ActiveDate;
			if (dateTime5 != null)
			{
				global::Infragistics.Windows.Editors.CalendarItem item = this.GetItem(dateTime5.Value);
				if (item != null)
				{
					if (base.IsKeyboardFocusWithin)
					{
						item.Focus();
						return;
					}
					this.SetActiveDate(new global::System.DateTime?(item.StartDate));
				}
			}
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001635C File Offset: 0x0001455C
		private void ClearPreferredNavInfo()
		{
			this._preferredNavColumn = -1;
			this._preferredGroupNavStart = null;
			this._preferredGroupOffset = 0;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00016378 File Offset: 0x00014578
		private void CoerceAllDates()
		{
			using (new global::Infragistics.Windows.Editors.CalendarItemGroup.GroupInitializationHelper(this._groups))
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MinDateProperty);
				base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MaxDateProperty);
				base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ActiveDateProperty);
				base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
				base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.MeasureDateProperty);
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000163E4 File Offset: 0x000145E4
		private static object CoerceIsTabStop(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			if (!xamMonthCalendar.IsKeyboardFocused && xamMonthCalendar.IsKeyboardFocusWithin)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return newValue;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00016410 File Offset: 0x00014610
		private void EnsureItemsWithinMaxSelectedItemsBounds(global::System.Collections.Generic.List<global::System.DateTime> newSelection)
		{
			int maxSelectedDatesResolved = this.MaxSelectedDatesResolved;
			int num = newSelection.Count - maxSelectedDatesResolved;
			if (num > 0)
			{
				newSelection.RemoveRange(newSelection.Count - num, num);
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00016440 File Offset: 0x00014640
		private void FocusActiveItem()
		{
			if (this._preventFocusActiveItem)
			{
				return;
			}
			if (!base.IsKeyboardFocusWithin)
			{
				return;
			}
			if (this.ActiveDate != null)
			{
				global::Infragistics.Windows.Editors.CalendarItem item = this.GetItem(this.ActiveDate.Value);
				if (item != null)
				{
					item.Focus();
				}
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x0001648E File Offset: 0x0001468E
		private global::System.DateTime? GetActivatableDate(global::System.DateTime? date, bool previousItem, bool includeInitialDate)
		{
			return this.GetActivatableDate(date, previousItem, includeInitialDate, true);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001649C File Offset: 0x0001469C
		private global::System.DateTime? GetActivatableDate(global::System.DateTime? date, bool previousItem, bool includeInitialDate, bool coerceMinMax)
		{
			global::System.DateTime? dateTime = date;
			if (dateTime != null)
			{
				if (coerceMinMax)
				{
					dateTime = new global::System.DateTime?(this.CoerceMinMaxDate(dateTime.Value));
				}
				global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
				global::System.DateTime dateTime2 = this._calendarManager.GetItemStartDate(dateTime.Value, currentCalendarMode);
				global::System.DateTime itemEndDate = this._calendarManager.GetItemEndDate(dateTime2, currentCalendarMode);
				int offset = previousItem ? -1 : 1;
				if (includeInitialDate)
				{
					dateTime = this.GetActivatableDate(dateTime2, itemEndDate, true);
				}
				else
				{
					dateTime = null;
				}
				if (dateTime == null)
				{
					do
					{
						dateTime = this._calendarManager.TryAddItemOffset(dateTime2, offset, currentCalendarMode);
						if (dateTime < this.MinDate || dateTime > this.MaxDate)
						{
							dateTime = null;
						}
						if (dateTime == null)
						{
							break;
						}
						dateTime2 = dateTime.Value;
						itemEndDate = this._calendarManager.GetItemEndDate(dateTime2, currentCalendarMode);
						dateTime = this.GetActivatableDate(dateTime.Value, itemEndDate, true);
					}
					while (dateTime == null);
				}
			}
			return dateTime;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000165C8 File Offset: 0x000147C8
		private global::System.DateTime? GetClosestActivatableDate(global::System.DateTime itemStart, global::System.DateTime itemEnd)
		{
			global::System.DateTime? activatableDate = this.GetActivatableDate(itemStart, this.MaxDate, true);
			global::System.DateTime? activatableDate2 = this.GetActivatableDate(this.MinDate, itemStart, false);
			bool flag = true;
			if (activatableDate != null && activatableDate2 != null)
			{
				global::System.TimeSpan t = activatableDate.Value.Subtract(itemStart);
				global::System.TimeSpan t2 = itemEnd.Subtract(activatableDate2.Value);
				flag = (t2 > t);
			}
			else if (activatableDate2 != null)
			{
				flag = false;
			}
			if (!flag)
			{
				return activatableDate2;
			}
			return activatableDate;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00016648 File Offset: 0x00014848
		private int GetDaysOfWeek(global::System.DateTime start, global::System.DateTime end)
		{
			if (start == end)
			{
				return 1 << (int)this._calendarManager.Calendar.GetDayOfWeek(start);
			}
			if (end.Subtract(start).Days > 6)
			{
				return 127;
			}
			int num = 0;
			global::System.Globalization.Calendar calendar = this._calendarManager.Calendar;
			int i = 0;
			int days = end.Subtract(start).Days;
			while (i < days)
			{
				num |= 1 << (int)calendar.GetDayOfWeek(start);
				start = this._calendarManager.AddDays(start, 1).Date;
				i++;
			}
			return num;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000166E0 File Offset: 0x000148E0
		private global::System.DateTime GetDefaultReferenceDate()
		{
			global::System.DateTime date = this.ActiveDate ?? global::System.DateTime.Today;
			return this.GetDefaultReferenceDate(date);
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00016714 File Offset: 0x00014914
		private global::System.DateTime GetDefaultReferenceDate(global::System.DateTime date)
		{
			global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
			date = this.CoerceMinMaxDate(date);
			date = this._calendarManager.GetGroupStartDate(date, currentCalendarMode);
			date = this.CoerceMinMaxDate(date);
			if (this._groups.Count > 0)
			{
				int referenceGroupOffset = this.GetLastGroup(false, true).ReferenceGroupOffset;
				global::System.DateTime? dateTime = this._calendarManager.TryAddGroupOffset(date, referenceGroupOffset, currentCalendarMode, true);
				if (dateTime == null || dateTime.Value > this.MaxDate)
				{
					dateTime = new global::System.DateTime?(this._calendarManager.GetGroupStartDate(this.MaxDate, currentCalendarMode));
					global::System.DateTime? dateTime2 = this._calendarManager.TryAddGroupOffset(dateTime.Value, -referenceGroupOffset, currentCalendarMode, true);
					if (dateTime2 == null || dateTime2.Value < this.MinDate)
					{
						date = this._calendarManager.GetGroupStartDate(this.MinDate, currentCalendarMode);
					}
					else
					{
						date = dateTime2.Value;
					}
				}
				int referenceGroupOffset2 = this.GetFirstGroup(false, true).ReferenceGroupOffset;
				if (referenceGroupOffset2 < 0)
				{
					global::System.DateTime? dateTime3 = this._calendarManager.TryAddGroupOffset(date, referenceGroupOffset2, currentCalendarMode, true);
					if (dateTime3 == null || dateTime3 < this.MinDate)
					{
						dateTime3 = new global::System.DateTime?(this._calendarManager.GetGroupStartDate(this.MinDate, currentCalendarMode));
						global::System.DateTime? dateTime4 = this._calendarManager.TryAddGroupOffset(dateTime3.Value, -referenceGroupOffset2, currentCalendarMode, true);
						if (dateTime4 == null)
						{
							date = this._calendarManager.GetGroupStartDate(this.MaxDate, currentCalendarMode);
						}
						else
						{
							date = dateTime4.Value;
						}
					}
				}
				date = this.CoerceMinMaxDate(date);
			}
			return date;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x000168BF File Offset: 0x00014ABF
		private global::Infragistics.Windows.Editors.CalendarItemGroup GetFirstGroup(bool ignoreEmptyGroups)
		{
			return this.GetFirstGroup(ignoreEmptyGroups, !this.AllowLeadingAndTrailingGroupActivation);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x000168D4 File Offset: 0x00014AD4
		private global::Infragistics.Windows.Editors.CalendarItemGroup GetFirstGroup(bool ignoreEmptyGroups, bool ignoreLeadingTrailingGroups)
		{
			int i = 0;
			int count = this._groups.Count;
			while (i < count)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = this._groups[i];
				if ((!ignoreLeadingTrailingGroups || !calendarItemGroup.IsLeadingOrTrailingGroup) && (!ignoreEmptyGroups || calendarItemGroup.Items.Count > 0))
				{
					return calendarItemGroup;
				}
				i++;
			}
			if (ignoreLeadingTrailingGroups)
			{
				return this.GetFirstGroup(ignoreEmptyGroups, false);
			}
			return null;
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00016934 File Offset: 0x00014B34
		private global::Infragistics.Windows.Selection.ISelectableItem GetFirstLastItem(global::Infragistics.Windows.Editors.CalendarItem sourceItem, global::System.Windows.Point pt, global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			global::Infragistics.Windows.Editors.CalendarItem[] array = new global::Infragistics.Windows.Editors.CalendarItem[]
			{
				group.Items[0],
				group.Items[group.Items.Count - 1]
			};
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Windows.Media.GeneralTransform generalTransform = array[i].TransformToAncestor(this);
				global::System.Windows.Rect rect = new global::System.Windows.Rect(array[i].RenderSize);
				rect = generalTransform.TransformBounds(rect);
				if (pt.Y >= rect.Y && pt.Y < rect.Bottom && ((i == 0 && pt.X < rect.X) || (i == 1 && pt.X >= rect.Right)))
				{
					int num = this._groups.IndexOf(group);
					if (i == 0 && sourceItem.StartDate < array[i].StartDate)
					{
						if (num > 0)
						{
							global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = this._groups[num - 1];
							if (calendarItemGroup.Items.Count > 0)
							{
								return calendarItemGroup.Items[calendarItemGroup.Items.Count - 1];
							}
						}
					}
					else
					{
						if (i != 1 || !(sourceItem.StartDate > array[i].StartDate))
						{
							return array[i];
						}
						if (num < this._groups.Count - 1)
						{
							global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup2 = this._groups[num + 1];
							if (calendarItemGroup2.Items.Count > 0)
							{
								return calendarItemGroup2.Items[0];
							}
						}
					}
				}
			}
			return null;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00016AC8 File Offset: 0x00014CC8
		private global::Infragistics.Windows.Editors.CalendarItem GetItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			item = this.SelectionHost.TranslateItem(item);
			global::Infragistics.Windows.Editors.CalendarItem calendarItem = item as global::Infragistics.Windows.Editors.CalendarItem;
			if (calendarItem != null)
			{
				calendarItem = this.GetItem(calendarItem.StartDate);
			}
			return calendarItem;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00016AFC File Offset: 0x00014CFC
		internal global::Infragistics.Windows.Editors.CalendarItem GetItem(global::System.DateTime date)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup group = this.GetGroup(date);
			if (group == null)
			{
				return null;
			}
			return group.GetItem(date);
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00016B1D File Offset: 0x00014D1D
		private global::Infragistics.Windows.Editors.CalendarItemGroup GetLastGroup(bool ignoreEmptyGroups)
		{
			return this.GetLastGroup(ignoreEmptyGroups, !this.AllowLeadingAndTrailingGroupActivation);
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00016B30 File Offset: 0x00014D30
		private global::Infragistics.Windows.Editors.CalendarItemGroup GetLastGroup(bool ignoreEmptyGroups, bool ignoreLeadingTrailingGroups)
		{
			for (int i = this._groups.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = this._groups[i];
				if ((!ignoreLeadingTrailingGroups || !calendarItemGroup.IsLeadingOrTrailingGroup) && (!ignoreEmptyGroups || calendarItemGroup.Items.Count > 0))
				{
					return calendarItemGroup;
				}
			}
			if (ignoreLeadingTrailingGroups)
			{
				return this.GetLastGroup(ignoreEmptyGroups, false);
			}
			return null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00016B90 File Offset: 0x00014D90
		private bool HasOverlappingGroups()
		{
			if (this._groups != null)
			{
				global::System.DateTime? dateTime = null;
				for (int i = 0; i < this._groups.Count; i++)
				{
					global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = this._groups[i];
					if (calendarItemGroup.LastDateOfGroup != null)
					{
						if (dateTime != null && calendarItemGroup.FirstDate <= dateTime)
						{
							return true;
						}
						dateTime = new global::System.DateTime?(calendarItemGroup.LastDate);
					}
				}
			}
			return false;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00016C20 File Offset: 0x00014E20
		private bool InitializeDaysOfWeek()
		{
			if (!base.IsInitialized)
			{
				return false;
			}
			global::System.DayOfWeek[] daysOfWeek = this._calendarManager.GetDaysOfWeek();
			bool flag = daysOfWeek.Length != this._daysOfWeekInternal.Count;
			if (!flag)
			{
				for (int i = 0; i < daysOfWeek.Length; i++)
				{
					if (daysOfWeek[i] != this._daysOfWeekInternal[i])
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				this._daysOfWeekInternal.ReInitialize(daysOfWeek);
			}
			return flag;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00016C90 File Offset: 0x00014E90
		private bool NavigateGroup(global::System.DateTime date, bool next)
		{
			global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
			int num = next ? 1 : -1;
			if (this._preferredGroupNavStart != null)
			{
				date = this._preferredGroupNavStart.Value;
				num += this._preferredGroupOffset;
			}
			global::System.DateTime? dateValue;
			for (;;)
			{
				global::System.DateTime dateTime = this.CalendarManager.AddGroupOffset(date, num, currentCalendarMode, false);
				global::System.DateTime groupStartDate = this.CalendarManager.GetGroupStartDate(dateTime, currentCalendarMode);
				global::System.DateTime groupEndDate = this.CalendarManager.GetGroupEndDate(dateTime, currentCalendarMode);
				global::System.DateTime itemEndDate = this.CalendarManager.GetItemEndDate(dateTime, currentCalendarMode);
				dateValue = (next ? this.GetActivatableDate(dateTime, groupEndDate, true) : this.GetActivatableDate(groupStartDate, itemEndDate, false));
				if (dateValue != null)
				{
					goto IL_EA;
				}
				dateValue = ((!next) ? this.GetActivatableDate(dateTime, groupEndDate, true) : this.GetActivatableDate(groupStartDate, itemEndDate, false));
				if (dateValue != null)
				{
					goto IL_EA;
				}
				if ((next && groupEndDate >= this.MaxDate) || (!next && groupStartDate <= this.MinDate))
				{
					break;
				}
				num += (next ? 1 : -1);
			}
			return false;
			IL_EA:
			dateValue = this.GetActivatableDate(this.CalendarManager.GetItemStartDate(dateValue.Value, currentCalendarMode), this.CalendarManager.GetItemEndDate(dateValue.Value, currentCalendarMode), true);
			bool flag = this.ActivateDate(dateValue);
			if (flag)
			{
				this._preferredGroupOffset = num;
				this._preferredGroupNavStart = new global::System.DateTime?(date);
			}
			return flag;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00016DDC File Offset: 0x00014FDC
		private bool NavigateRow(global::System.DateTime date, bool next)
		{
			global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
			int itemColumnCount = global::Infragistics.Windows.Editors.CalendarManager.GetItemColumnCount(currentCalendarMode);
			int offset = (!next) ? (-itemColumnCount) : itemColumnCount;
			global::System.DateTime groupStartDate = this.CalendarManager.GetGroupStartDate(date, currentCalendarMode);
			int preferredNavColumn;
			int num;
			this.CalendarManager.GetItemRowColumn(date, currentCalendarMode, groupStartDate, false, out preferredNavColumn, out num);
			if (this._preferredNavColumn >= 0 && preferredNavColumn != this._preferredNavColumn)
			{
				date = this.CalendarManager.AddItemOffset(date, this._preferredNavColumn - preferredNavColumn, currentCalendarMode);
				preferredNavColumn = this._preferredNavColumn;
			}
			global::System.DateTime? dateValue;
			for (;;)
			{
				global::System.DateTime dateTime = this.CalendarManager.AddItemOffset(date, offset, currentCalendarMode);
				global::System.DateTime dateTime2 = this.CalendarManager.AddItemOffset(dateTime, -preferredNavColumn, currentCalendarMode);
				global::System.DateTime dateTime3 = this.CalendarManager.AddItemOffset(dateTime, itemColumnCount - preferredNavColumn - 1, currentCalendarMode);
				dateTime3 = this.CalendarManager.GetItemEndDate(dateTime3, currentCalendarMode);
				global::System.DateTime itemEndDate = this.CalendarManager.GetItemEndDate(dateTime, currentCalendarMode);
				dateValue = ((!next) ? this.GetActivatableDate(dateTime, dateTime3, true) : this.GetActivatableDate(dateTime2, itemEndDate, false));
				if (dateValue != null)
				{
					goto IL_141;
				}
				dateValue = ((!next) ? this.GetActivatableDate(dateTime2, itemEndDate, false) : this.GetActivatableDate(dateTime, dateTime3, true));
				if (dateValue != null)
				{
					goto IL_141;
				}
				if ((next && dateTime3 >= this.MaxDate) || (!next && dateTime2 <= this.MinDate))
				{
					break;
				}
				date = dateTime;
			}
			return false;
			IL_141:
			dateValue = this.GetActivatableDate(this.CalendarManager.GetItemStartDate(dateValue.Value, currentCalendarMode), this.CalendarManager.GetItemEndDate(dateValue.Value, currentCalendarMode), true);
			bool flag = this.ActivateDate(dateValue);
			if (flag && global::Infragistics.Windows.Editors.XamMonthCalendar.ShouldCachePreferredNavInfo(currentCalendarMode))
			{
				this._preferredNavColumn = preferredNavColumn;
			}
			return flag;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00016F7C File Offset: 0x0001517C
		private void NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange change)
		{
			if (this._groupForSizing != null)
			{
				this._groupForSizing.OnCalendarChange(change);
			}
			int i = 0;
			int count = this._groups.Count;
			while (i < count)
			{
				this._groups[i].OnCalendarChange(change);
				i++;
			}
			if (change == global::Infragistics.Windows.Editors.MonthCalendarChange.DisabledDatesChanged)
			{
				base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ActiveDateProperty);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00016FD6 File Offset: 0x000151D6
		private void OnCurrentDateChanged(object sender, global::System.EventArgs e)
		{
			this.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.TodayChanged);
			base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.TodayPropertyKey, this._currentDateWatcher.GetValue(global::Infragistics.Windows.Editors.CurrentDate.ValueProperty));
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00016FFB File Offset: 0x000151FB
		private void OnDaysOfWeekChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.CurrentCalendarMode == global::Infragistics.Windows.Editors.CalendarMode.Days)
			{
				this.ClearPreferredNavInfo();
			}
			this.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.DaysOfWeekChanged);
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00017012 File Offset: 0x00015212
		private void OnDisabledDatesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.NotifyGroupChange(global::Infragistics.Windows.Editors.MonthCalendarChange.DisabledDatesChanged);
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001701C File Offset: 0x0001521C
		private static void OnLanguageChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = (global::Infragistics.Windows.Editors.XamMonthCalendar)d;
			global::System.Windows.Markup.XmlLanguage xmlLanguage = (global::System.Windows.Markup.XmlLanguage)e.NewValue;
			global::System.Globalization.CultureInfo cultureInfo = null;
			try
			{
				cultureInfo = ((xmlLanguage == null) ? global::System.Globalization.CultureInfo.CurrentCulture : xmlLanguage.GetEquivalentCulture());
			}
			catch (global::System.InvalidOperationException)
			{
				cultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
			}
			using (new global::Infragistics.Windows.Editors.CalendarItemGroup.GroupInitializationHelper(xamMonthCalendar._groups))
			{
				xamMonthCalendar.ClearPreferredNavInfo();
				xamMonthCalendar._calendarManager.InitializeCulture(cultureInfo);
				xamMonthCalendar.CoerceAllDates();
				xamMonthCalendar.InitializeDaysOfWeek();
			}
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x000170B0 File Offset: 0x000152B0
		private void ProcessActiveSelectionStrategyChanged()
		{
			if (this._shouldProcessActiveSelectionChanged == false)
			{
				this._shouldProcessActiveSelectionChanged = new bool?(true);
				return;
			}
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyBase = (this._activeStrategy == null) ? null : (global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._activeStrategy) as global::Infragistics.Windows.Selection.SelectionStrategyBase);
			bool? shouldBringActiveDateIntoView = this._shouldBringActiveDateIntoView;
			if (selectionStrategyBase == null)
			{
				this._shouldBringActiveDateIntoView = null;
			}
			else if (this._shouldBringActiveDateIntoView == null)
			{
				this._shouldBringActiveDateIntoView = new bool?(false);
			}
			if (shouldBringActiveDateIntoView == true && this._shouldBringActiveDateIntoView == null && this.ActiveDate != null)
			{
				this.BringDateIntoView(this.ActiveDate.Value);
			}
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00017180 File Offset: 0x00015380
		private bool ScrollGroups(int numberOfGroups)
		{
			if (this._groups.Count == 0)
			{
				return false;
			}
			global::System.DateTime dateTime = this.ReferenceDate ?? this.GetDefaultReferenceDate();
			global::System.DateTime minDate = this.MinDate;
			global::System.DateTime maxDate = this.MaxDate;
			global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
			dateTime = this._calendarManager.AddGroupOffset(dateTime, numberOfGroups, currentCalendarMode, true);
			if (dateTime > maxDate)
			{
				global::System.DateTime dateTime2 = this._calendarManager.AddGroupOffset(this._calendarManager.GetGroupStartDate(maxDate, currentCalendarMode), -this.LastGroup.ReferenceGroupOffset, currentCalendarMode, true);
				if (dateTime > dateTime2)
				{
					dateTime = dateTime2;
				}
			}
			if (dateTime < minDate)
			{
				dateTime = minDate;
			}
			global::System.DateTime? referenceDate = this.ReferenceDate;
			this.ReferenceDate = new global::System.DateTime?(dateTime);
			return !object.Equals(referenceDate, this.ReferenceDate);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001725C File Offset: 0x0001545C
		private static bool ShouldCachePreferredNavInfo(global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
				return true;
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				return false;
			default:
				return false;
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x000172B0 File Offset: 0x000154B0
		private void SortGroups()
		{
			global::System.Comparison<global::Infragistics.Windows.Editors.CalendarItemGroup> comparison = (global::Infragistics.Windows.Editors.CalendarItemGroup g1, global::Infragistics.Windows.Editors.CalendarItemGroup g2) => g1.ReferenceGroupOffset.CompareTo(g2.ReferenceGroupOffset);
			global::System.Collections.Generic.IComparer<global::Infragistics.Windows.Editors.CalendarItemGroup> comparer = global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Windows.Editors.CalendarItemGroup>(comparison);
			global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Windows.Editors.CalendarItemGroup>(this._groups, comparer);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x000172F0 File Offset: 0x000154F0
		private bool ToggleActiveDateSelection(bool shiftKeyDown, bool ctlKeyDown)
		{
			global::System.DateTime value = this.ActiveDate.Value;
			global::Infragistics.Windows.Editors.CalendarItem item = this.GetItem(value);
			if (item != null)
			{
				global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = this.SelectionHost.GetSelectionStrategyForItem(item);
				if (selectionStrategyForItem != null && (selectionStrategyForItem.IsMultiSelect || selectionStrategyForItem.IsSingleSelect))
				{
					return selectionStrategyForItem.SelectItemViaKeyboard(item, shiftKeyDown, ctlKeyDown, true);
				}
			}
			return false;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00017344 File Offset: 0x00015544
		private void UpdateSelectedState(global::System.Collections.Generic.IList<global::System.DateTime> dates, bool select)
		{
			if (dates != null)
			{
				object value = global::Infragistics.KnownBoxes.FromValue(select);
				int i = 0;
				int count = dates.Count;
				while (i < count)
				{
					global::System.DateTime date = dates[i];
					global::Infragistics.Windows.Editors.CalendarItem item = this.GetItem(date);
					if (item != null)
					{
						item.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectedPropertyKey, value);
						item.SetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsSelectedDatesPropertyKey, value);
					}
					i++;
				}
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001739D File Offset: 0x0001559D
		private static bool ValidatePositiveInt(object value)
		{
			return value is int && (int)value > 0;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x000173B2 File Offset: 0x000155B2
		protected virtual void OnExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x000173BB File Offset: 0x000155BB
		internal bool RaiseExecutingCommand(global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamMonthCalendar.ExecutingCommandEvent;
			args.Source = this;
			this.OnExecutingCommand(args);
			return !args.Cancel;
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600051B RID: 1307 RVA: 0x000173DF File Offset: 0x000155DF
		// (remove) Token: 0x0600051C RID: 1308 RVA: 0x000173ED File Offset: 0x000155ED
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutingCommandEventArgs> ExecutingCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.ExecutingCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.ExecutingCommandEvent, value);
			}
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x000173FB File Offset: 0x000155FB
		protected virtual void OnExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00017404 File Offset: 0x00015604
		internal void RaiseExecutedCommand(global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamMonthCalendar.ExecutedCommandEvent;
			args.Source = this;
			this.OnExecutedCommand(args);
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x0600051F RID: 1311 RVA: 0x0001741F File Offset: 0x0001561F
		// (remove) Token: 0x06000520 RID: 1312 RVA: 0x0001742D File Offset: 0x0001562D
		public event global::System.EventHandler<global::Infragistics.Windows.Controls.Events.ExecutedCommandEventArgs> ExecutedCommand
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.ExecutedCommandEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.ExecutedCommandEvent, value);
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x0001743B File Offset: 0x0001563B
		protected virtual void OnSelectedDatesChanged(global::Infragistics.Windows.Editors.Events.SelectedDatesChangedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00017444 File Offset: 0x00015644
		internal void RaiseSelectedDatesChanged(global::Infragistics.Windows.Editors.Events.SelectedDatesChangedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamMonthCalendar.SelectedDatesChangedEvent;
			args.Source = this;
			this.OnSelectedDatesChanged(args);
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000523 RID: 1315 RVA: 0x0001745F File Offset: 0x0001565F
		// (remove) Token: 0x06000524 RID: 1316 RVA: 0x0001746D File Offset: 0x0001566D
		public event global::System.EventHandler<global::Infragistics.Windows.Editors.Events.SelectedDatesChangedEventArgs> SelectedDatesChanged
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.SelectedDatesChangedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.SelectedDatesChangedEvent, value);
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x0001747B File Offset: 0x0001567B
		private void OnSelectionCommitted(global::System.Windows.RoutedEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00017484 File Offset: 0x00015684
		internal void RaiseSelectionCommitted(global::System.Windows.RoutedEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.Editors.XamMonthCalendar.SelectionCommittedEvent;
			args.Source = this;
			this.OnSelectionCommitted(args);
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000527 RID: 1319 RVA: 0x0001749F File Offset: 0x0001569F
		// (remove) Token: 0x06000528 RID: 1320 RVA: 0x000174AD File Offset: 0x000156AD
		internal event global::System.Windows.RoutedEventHandler SelectionCommitted
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.SelectionCommittedEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.Editors.XamMonthCalendar.SelectionCommittedEvent, value);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x000174BB File Offset: 0x000156BB
		protected internal override global::Infragistics.Windows.Commands.CommandsBase Commands
		{
			get
			{
				return global::Infragistics.Windows.Editors.MonthCalendarCommands.Instance;
			}
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x000174C2 File Offset: 0x000156C2
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			base.CoerceValue(global::Infragistics.Windows.Editors.XamMonthCalendar.ReferenceDateProperty);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x000174D5 File Offset: 0x000156D5
		protected override void OnActiveSelectionStrategyChanged(global::Infragistics.Windows.Selection.SelectionStrategyBase strategy)
		{
			this._activeStrategy = ((strategy == null) ? null : new global::System.WeakReference(strategy));
			this.ProcessActiveSelectionStrategyChanged();
			base.OnActiveSelectionStrategyChanged(strategy);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000174F6 File Offset: 0x000156F6
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.Editors.XamMonthCalendarAutomationPeer(this);
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000174FE File Offset: 0x000156FE
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			base.OnGotKeyboardFocus(e);
			if (e.NewFocus == this)
			{
				this.FocusActiveItem();
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00017516 File Offset: 0x00015716
		protected override void OnInitialized(global::System.EventArgs e)
		{
			this.CoerceAllDates();
			this.InitializeDaysOfWeek();
			base.OnInitialized(e);
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x0001752C File Offset: 0x0001572C
		protected override void OnIsKeyboardFocusedChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusedChanged(e);
			base.CoerceValue(global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty);
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00017540 File Offset: 0x00015740
		protected override void OnIsKeyboardFocusWithinChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusWithinChanged(e);
			base.CoerceValue(global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty);
			bool flag = (bool)e.NewValue;
			if (!flag)
			{
				global::System.Windows.DependencyObject dependencyObject = global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.DependencyObject;
				if (dependencyObject != null && global::System.Windows.Input.FocusManager.GetFocusScope(dependencyObject) != global::System.Windows.Input.FocusManager.GetFocusScope(this) && global::System.Windows.Window.GetWindow(dependencyObject) == global::System.Windows.Window.GetWindow(this))
				{
					flag = true;
				}
			}
			base.SetValue(global::Infragistics.Windows.Editors.XamMonthCalendar.IsSelectionActivePropertyKey, global::Infragistics.KnownBoxes.FromValue(flag));
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000175AC File Offset: 0x000157AC
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			base.OnMouseWheel(e);
			if (!e.Handled)
			{
				global::System.Windows.Input.RoutedCommand command = (e.Delta < 0) ? global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollNextGroups : global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollPreviousGroups;
				e.Handled = this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(command, global::System.Math.Abs(e.Delta / 120), this));
			}
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00017604 File Offset: 0x00015804
		long global::Infragistics.Windows.Commands.ICommandHost.GetCurrentState(long statesToQuery)
		{
			return (long)(this.CurrentState & (global::Infragistics.Windows.Editors.MonthCalendarStates)statesToQuery);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00017610 File Offset: 0x00015810
		bool global::Infragistics.Windows.Commands.ICommandHost.CanExecute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			global::System.Windows.Input.RoutedCommand routedCommand = commandInfo.RoutedCommand;
			return routedCommand != null && routedCommand.OwnerType == typeof(global::Infragistics.Windows.Editors.MonthCalendarCommands);
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x0001763E File Offset: 0x0001583E
		bool global::Infragistics.Windows.Commands.ICommandHost.Execute(global::Infragistics.Windows.Commands.ExecuteCommandInfo commandInfo)
		{
			return this.ExecuteCommandImpl(commandInfo);
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00017648 File Offset: 0x00015848
		bool global::Infragistics.Windows.Selection.ISelectionHost.ActivateItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool preventScrollItemIntoView)
		{
			global::Infragistics.Windows.Editors.CalendarItem item2 = this.GetItem(item);
			if (item2 == null || !item2.IsEnabled)
			{
				return false;
			}
			global::System.DateTime? activatableDate = this.GetActivatableDate(item2);
			if (activatableDate == null)
			{
				return false;
			}
			global::System.DateTime value = activatableDate.Value;
			this.SetActiveDate(new global::System.DateTime?(value));
			item2 = this.GetItem(value);
			return item2 != null && item2.IsActive;
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x000176A4 File Offset: 0x000158A4
		void global::Infragistics.Windows.Selection.ISelectionHost.ClearSnapshot()
		{
			this._selectedDatesSnapshot.Clear();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000176B1 File Offset: 0x000158B1
		bool global::Infragistics.Windows.Selection.ISelectionHost.DeselectItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return !this.IsNavigationMode && this.InternalSelectItem(item, false, false);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x000176C6 File Offset: 0x000158C6
		bool global::Infragistics.Windows.Selection.ISelectionHost.DeselectRange(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return !this.IsNavigationMode && this.InternalSelectRange(item, false, false);
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x000176DB File Offset: 0x000158DB
		void global::Infragistics.Windows.Selection.ISelectionHost.DoAutoScrollHorizontal(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.Selection.ScrollDirection direction, global::Infragistics.Windows.Selection.ScrollSpeed speed)
		{
			if (direction == global::Infragistics.Windows.Selection.ScrollDirection.Decrement)
			{
				this.ExecuteCommand(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollPreviousGroup);
				return;
			}
			this.ExecuteCommand(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollNextGroup);
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x000176FA File Offset: 0x000158FA
		void global::Infragistics.Windows.Selection.ISelectionHost.DoAutoScrollVertical(global::Infragistics.Windows.Selection.ISelectableItem item, global::Infragistics.Windows.Selection.ScrollDirection direction, global::Infragistics.Windows.Selection.ScrollSpeed speed)
		{
			if (direction == global::Infragistics.Windows.Selection.ScrollDirection.Decrement)
			{
				this.ExecuteCommand(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollPreviousGroup);
				return;
			}
			this.ExecuteCommand(global::Infragistics.Windows.Editors.MonthCalendarCommands.ScrollNextGroup);
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00017719 File Offset: 0x00015919
		void global::Infragistics.Windows.Selection.ISelectionHost.EnterSnakingMode(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x0001771C File Offset: 0x0001591C
		global::Infragistics.Windows.Selection.AutoScrollInfo global::Infragistics.Windows.Selection.ISelectionHost.GetAutoScrollInfo(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::Infragistics.Windows.Editors.MonthCalendarStates currentState = this.CurrentState;
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyForItem = this.SelectionHost.GetSelectionStrategyForItem(item);
			bool flag = selectionStrategyForItem != null && selectionStrategyForItem.IsSingleSelect && !selectionStrategyForItem.IsMultiSelect;
			bool flag2 = flag && (currentState & global::Infragistics.Windows.Editors.MonthCalendarStates.MinDateInView) == (global::Infragistics.Windows.Editors.MonthCalendarStates)0L;
			bool flag3 = flag && (currentState & global::Infragistics.Windows.Editors.MonthCalendarStates.MaxDateInView) == (global::Infragistics.Windows.Editors.MonthCalendarStates)0L;
			return new global::Infragistics.Windows.Selection.AutoScrollInfo(this, flag2, flag2, flag3, flag3)
			{
				ScrollOrientation = global::Infragistics.Windows.Selection.ScrollOrientation.Horizontal
			};
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x00017804 File Offset: 0x00015A04
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.GetNearestCompatibleItem(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			if (item == null)
			{
				return null;
			}
			global::Infragistics.Windows.Editors.CalendarItem calendarItem = item as global::Infragistics.Windows.Editors.CalendarItem;
			global::System.Windows.Point position = e.GetPosition(this);
			global::System.Windows.Media.HitTestResult hitResult = null;
			global::System.Windows.Media.HitTestResultCallback resultCallback = delegate(global::System.Windows.Media.HitTestResult result)
			{
				hitResult = result;
				return global::System.Windows.Media.HitTestResultBehavior.Stop;
			};
			global::System.Windows.Media.HitTestFilterCallback filterCallback = delegate(global::System.Windows.DependencyObject hit)
			{
				if (global::Infragistics.Windows.Editors.Utils.IsUIElementOrUIElement3D(hit) && (false.Equals(hit.GetValue(global::System.Windows.UIElement.IsHitTestVisibleProperty)) || false.Equals(hit.GetValue(global::System.Windows.UIElement.IsVisibleProperty))))
				{
					return global::System.Windows.Media.HitTestFilterBehavior.ContinueSkipSelfAndChildren;
				}
				if (!(hit is global::Infragistics.Windows.Editors.CalendarItem) && false.Equals(hit.GetValue(global::System.Windows.UIElement.IsEnabledProperty)))
				{
					return global::System.Windows.Media.HitTestFilterBehavior.ContinueSkipSelfAndChildren;
				}
				return global::System.Windows.Media.HitTestFilterBehavior.Continue;
			};
			global::System.Windows.Media.VisualTreeHelper.HitTest(this, filterCallback, resultCallback, new global::System.Windows.Media.PointHitTestParameters(position));
			global::System.Windows.DependencyObject dependencyObject = (hitResult != null) ? hitResult.VisualHit : null;
			global::Infragistics.Windows.Editors.CalendarItem calendarItem2 = dependencyObject as global::Infragistics.Windows.Editors.CalendarItem;
			if (calendarItem2 == null && dependencyObject != null)
			{
				calendarItem2 = (global::Infragistics.Windows.Editors.CalendarItem)global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.Editors.CalendarItem), true);
			}
			if (calendarItem2 != null)
			{
				global::Infragistics.Windows.Selection.ISelectableItem selectableItem = ((global::Infragistics.Windows.Selection.ISelectableElement)calendarItem2).SelectableItem;
				if (!this.SelectionHost.IsItemSelectableWithCurrentSelection(selectableItem))
				{
					return null;
				}
				if (!calendarItem2.IsEnabled && this._pivotDate != null)
				{
					global::System.DateTime? activatableDate;
					if (this._pivotDate.Value > calendarItem2.StartDate)
					{
						activatableDate = this.GetActivatableDate(calendarItem2.EndDate, this._pivotDate.Value, true);
					}
					else
					{
						activatableDate = this.GetActivatableDate(this._pivotDate.Value, calendarItem2.StartDate, false);
					}
					if (activatableDate != null)
					{
						calendarItem2 = this.GetItem(activatableDate.Value);
					}
				}
				return calendarItem2;
			}
			else
			{
				global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = dependencyObject as global::Infragistics.Windows.Editors.CalendarItemGroup;
				if (calendarItemGroup == null)
				{
					calendarItemGroup = (global::Infragistics.Windows.Editors.CalendarItemGroup)global::Infragistics.Windows.Utilities.GetAncestorFromType(dependencyObject, typeof(global::Infragistics.Windows.Editors.CalendarItemGroup), true);
				}
				if (calendarItem != null && calendarItemGroup != null && calendarItemGroup.Items.Count > 0)
				{
					return this.GetFirstLastItem(calendarItem, position, calendarItemGroup);
				}
				return null;
			}
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x000179A0 File Offset: 0x00015BA0
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.GetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (this._pivotDate != null)
			{
				return this.GetItem(this._pivotDate.Value);
			}
			return null;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x000179D0 File Offset: 0x00015BD0
		global::Infragistics.Windows.Selection.SelectionStrategyBase global::Infragistics.Windows.Selection.ISelectionHost.GetSelectionStrategyForItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			global::Infragistics.Windows.Selection.SelectionStrategyBase selectionStrategyBase = null;
			if (this.IsMinCalendarMode && this._selectionStrategyFilter != null)
			{
				selectionStrategyBase = this._selectionStrategyFilter.GetSelectionStrategyForItem(item);
			}
			if (selectionStrategyBase == null)
			{
				global::Infragistics.Windows.Controls.SelectionType currentSelectionTypeResolved = this.CurrentSelectionTypeResolved;
				if (currentSelectionTypeResolved == global::Infragistics.Windows.Controls.SelectionType.Single && !(this._selectionStrategy is global::Infragistics.Windows.Selection.SelectionStrategySingle))
				{
					selectionStrategyBase = (this._selectionStrategy = new global::Infragistics.Windows.Editors.XamMonthCalendar.CustomSingleSelectionStrategy(this));
				}
				else
				{
					selectionStrategyBase = (this._selectionStrategy = global::Infragistics.Windows.Selection.SelectionStrategyBase.GetSelectionStrategy(currentSelectionTypeResolved, this.SelectionHost, this._selectionStrategy));
				}
			}
			return selectionStrategyBase;
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00017A46 File Offset: 0x00015C46
		bool global::Infragistics.Windows.Selection.ISelectionHost.IsItemSelectableWithCurrentSelection(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			return item is global::Infragistics.Windows.Editors.CalendarItem;
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00017A54 File Offset: 0x00015C54
		bool global::Infragistics.Windows.Selection.ISelectionHost.IsMaxSelectedItemsReached(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (this.CurrentCalendarMode != this.MinCalendarMode)
			{
				return false;
			}
			int maxSelectedDatesResolved = this.MaxSelectedDatesResolved;
			return this._selectedDates.Count >= maxSelectedDatesResolved;
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00017A89 File Offset: 0x00015C89
		void global::Infragistics.Windows.Selection.ISelectionHost.OnDragEnd(bool canceled)
		{
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00017A8B File Offset: 0x00015C8B
		void global::Infragistics.Windows.Selection.ISelectionHost.OnDragMove(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00017A8D File Offset: 0x00015C8D
		bool global::Infragistics.Windows.Selection.ISelectionHost.OnDragStart(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return false;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00017A90 File Offset: 0x00015C90
		void global::Infragistics.Windows.Selection.ISelectionHost.OnMouseUp(global::System.Windows.Input.MouseEventArgs e, bool preventScrollItemIntoView)
		{
			global::System.Windows.Input.MouseButtonEventArgs mouseButtonEventArgs = e as global::System.Windows.Input.MouseButtonEventArgs;
			if (mouseButtonEventArgs != null && mouseButtonEventArgs.ChangedButton == global::System.Windows.Input.MouseButton.Left)
			{
				global::System.Windows.IInputElement inputElement = base.InputHitTest(e.GetPosition(this));
				global::Infragistics.Windows.Editors.CalendarItem calendarItem = inputElement as global::Infragistics.Windows.Editors.CalendarItem;
				if (calendarItem == null && inputElement is global::System.Windows.DependencyObject)
				{
					calendarItem = (global::Infragistics.Windows.Editors.CalendarItem)global::Infragistics.Windows.Utilities.GetAncestorFromType((global::System.Windows.DependencyObject)inputElement, typeof(global::Infragistics.Windows.Editors.CalendarItem), true);
				}
				if (calendarItem != null)
				{
					if (this.CurrentCalendarMode > this.MinCalendarMode)
					{
						this.ExecuteCommandImpl(new global::Infragistics.Windows.Commands.ExecuteCommandInfo(global::Infragistics.Windows.Editors.MonthCalendarCommands.ZoomInCalendarMode, calendarItem, calendarItem));
						return;
					}
					this.RaiseSelectionCommitted(new global::System.Windows.RoutedEventArgs());
				}
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000546 RID: 1350 RVA: 0x00017B1B File Offset: 0x00015D1B
		global::System.Windows.FrameworkElement global::Infragistics.Windows.Selection.ISelectionHost.RootElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00017B1E File Offset: 0x00015D1E
		void global::Infragistics.Windows.Selection.ISelectionHost.ScrollPendingItemIntoView()
		{
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00017B20 File Offset: 0x00015D20
		bool global::Infragistics.Windows.Selection.ISelectionHost.SelectItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection)
		{
			if (this.IsNavigationMode)
			{
				return this.SelectionHost.ActivateItem(item, false);
			}
			return this.InternalSelectItem(item, clearExistingSelection, true);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00017B41 File Offset: 0x00015D41
		bool global::Infragistics.Windows.Selection.ISelectionHost.SelectRange(global::Infragistics.Windows.Selection.ISelectableItem item, bool clearExistingSelection)
		{
			return !this.IsNavigationMode && this.InternalSelectRange(item, clearExistingSelection, true);
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00017B58 File Offset: 0x00015D58
		void global::Infragistics.Windows.Selection.ISelectionHost.SetPivotItem(global::Infragistics.Windows.Selection.ISelectableItem item, bool isRangeSelect)
		{
			global::System.DateTime? pivotDate = this._pivotDate;
			if (isRangeSelect && pivotDate != null)
			{
				return;
			}
			global::Infragistics.Windows.Editors.CalendarItem item2 = this.GetItem(item);
			if (item2 != null)
			{
				this._pivotDate = new global::System.DateTime?(item2.StartDate);
				return;
			}
			this._pivotDate = null;
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00017BA2 File Offset: 0x00015DA2
		void global::Infragistics.Windows.Selection.ISelectionHost.SnapshotSelection(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (this.IsNavigationMode)
			{
				return;
			}
			this._selectedDatesSnapshot.ReInitialize(this._selectedDates);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00017BBE File Offset: 0x00015DBE
		global::Infragistics.Windows.Selection.ISelectableItem global::Infragistics.Windows.Selection.ISelectionHost.TranslateItem(global::Infragistics.Windows.Selection.ISelectableItem item)
		{
			if (!(item is global::Infragistics.Windows.Editors.CalendarItem))
			{
				return null;
			}
			return item;
		}

		// Token: 0x040001B1 RID: 433
		internal const int AllDays = 127;

		// Token: 0x040001B2 RID: 434
		internal const global::Infragistics.Controls.DayOfWeekFlags DefaultWorkdays = global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday;

		// Token: 0x040001B3 RID: 435
		private global::Infragistics.Windows.Licensing.UltraLicense _license;

		// Token: 0x040001B4 RID: 436
		private global::Infragistics.Windows.Editors.CalendarManager _calendarManager;

		// Token: 0x040001B5 RID: 437
		private global::Infragistics.Windows.Editors.SelectedDateCollection _selectedDates;

		// Token: 0x040001B6 RID: 438
		private global::Infragistics.Windows.Selection.ISelectionStrategyFilter _selectionStrategyFilter;

		// Token: 0x040001B7 RID: 439
		private global::Infragistics.Windows.Selection.SelectionStrategyBase _selectionStrategy;

		// Token: 0x040001B8 RID: 440
		private global::Infragistics.Collections.ObservableCollectionExtended<global::System.DateTime> _selectedDatesSnapshot;

		// Token: 0x040001B9 RID: 441
		private global::System.DateTime? _pivotDate;

		// Token: 0x040001BA RID: 442
		private global::Infragistics.Collections.ObservableCollectionExtended<global::System.DayOfWeek> _daysOfWeekInternal;

		// Token: 0x040001BB RID: 443
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.DayOfWeek> _daysOfWeek;

		// Token: 0x040001BC RID: 444
		private global::System.Collections.Generic.List<global::Infragistics.Windows.Editors.CalendarItemGroup> _groups;

		// Token: 0x040001BD RID: 445
		private global::Infragistics.Windows.Editors.CalendarItemGroup _groupForSizing;

		// Token: 0x040001BE RID: 446
		private global::Infragistics.Windows.Editors.CalendarDateRangeCollection _disabledDates;

		// Token: 0x040001BF RID: 447
		private bool? _shouldBringActiveDateIntoView;

		// Token: 0x040001C0 RID: 448
		private int _preferredNavColumn = -1;

		// Token: 0x040001C1 RID: 449
		private int _preferredGroupOffset;

		// Token: 0x040001C2 RID: 450
		private global::System.DateTime? _preferredGroupNavStart;

		// Token: 0x040001C3 RID: 451
		private global::Infragistics.Windows.Editors.CalendarItemGroup _zoomFocusGroup;

		// Token: 0x040001C4 RID: 452
		private bool _suppressBringActiveDateInView;

		// Token: 0x040001C5 RID: 453
		private bool? _shouldProcessActiveSelectionChanged = null;

		// Token: 0x040001C6 RID: 454
		private global::System.WeakReference _activeStrategy;

		// Token: 0x040001C7 RID: 455
		private bool _preventFocusActiveItem;

		// Token: 0x040001C8 RID: 456
		private global::Infragistics.Windows.Editors.CurrentDate _currentDateWatcher;

		// Token: 0x040001C9 RID: 457
		public static readonly global::System.Windows.ResourceKey ScrollNextRepeatButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), "ScrollNextRepeatButtonStyleKey");

		// Token: 0x040001CA RID: 458
		public static readonly global::System.Windows.ResourceKey ScrollPreviousRepeatButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), "ScrollPreviousRepeatButtonStyleKey");

		// Token: 0x040001CB RID: 459
		public static readonly global::System.Windows.ResourceKey TodayButtonStyleKey = new global::Infragistics.Windows.Themes.StaticPropertyResourceKey(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), "TodayButtonStyleKey");

		// Token: 0x040001CC RID: 460
		public static readonly global::System.Windows.DependencyProperty ActiveDateProperty = global::System.Windows.DependencyProperty.Register("ActiveDate", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnActiveDateChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.CoerceActiveDate)));

		// Token: 0x040001CD RID: 461
		public static readonly global::System.Windows.DependencyProperty AllowLeadingAndTrailingGroupActivationProperty = global::System.Windows.DependencyProperty.Register("AllowLeadingAndTrailingGroupActivation", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040001CE RID: 462
		public static readonly global::System.Windows.DependencyProperty AutoAdjustCalendarDimensionsProperty = global::System.Windows.DependencyProperty.Register("AutoAdjustCalendarDimensions", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040001CF RID: 463
		public static readonly global::System.Windows.DependencyProperty CalendarDimensionsProperty = global::System.Windows.DependencyProperty.Register("CalendarDimensions", typeof(global::Infragistics.Windows.Editors.CalendarDimensions), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(new global::Infragistics.Windows.Editors.CalendarDimensions(1, 1)));

		// Token: 0x040001D0 RID: 464
		public static readonly global::System.Windows.DependencyProperty CalendarDayStyleProperty = global::System.Windows.DependencyProperty.Register("CalendarDayStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnItemStyleChanged)));

		// Token: 0x040001D1 RID: 465
		public static readonly global::System.Windows.DependencyProperty CalendarDayStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("CalendarDayStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnItemStyleChanged)));

		// Token: 0x040001D2 RID: 466
		public static readonly global::System.Windows.DependencyProperty CalendarItemStyleProperty = global::System.Windows.DependencyProperty.Register("CalendarItemStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnItemStyleChanged)));

		// Token: 0x040001D3 RID: 467
		public static readonly global::System.Windows.DependencyProperty CalendarItemStyleSelectorProperty = global::System.Windows.DependencyProperty.Register("CalendarItemStyleSelector", typeof(global::System.Windows.Controls.StyleSelector), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnItemStyleChanged)));

		// Token: 0x040001D4 RID: 468
		public static readonly global::System.Windows.DependencyProperty CurrentCalendarModeProperty = global::System.Windows.DependencyProperty.Register("CurrentCalendarMode", typeof(global::Infragistics.Windows.Editors.CalendarMode), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.CalendarMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnCurrentCalendarModeChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.CoerceCurrentCalendarMode)));

		// Token: 0x040001D5 RID: 469
		public static readonly global::System.Windows.DependencyProperty DayOfWeekHeaderFormatProperty = global::System.Windows.DependencyProperty.Register("DayOfWeekHeaderFormat", typeof(global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.PropertyMetadata(global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.TwoCharacters));

		// Token: 0x040001D6 RID: 470
		public static readonly global::System.Windows.DependencyProperty DayOfWeekHeaderVisibilityProperty = global::System.Windows.DependencyProperty.Register("DayOfWeekHeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.PropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x040001D7 RID: 471
		public static readonly global::System.Windows.DependencyProperty DisabledDaysOfWeekProperty = global::System.Windows.DependencyProperty.Register("DisabledDaysOfWeek", typeof(global::Infragistics.Controls.DayOfWeekFlags), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Controls.DayOfWeekFlags.None, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnDisabledDaysOfWeekChanged)));

		// Token: 0x040001D8 RID: 472
		public static readonly global::System.Windows.DependencyProperty FirstDayOfWeekProperty = global::System.Windows.DependencyProperty.Register("FirstDayOfWeek", typeof(global::System.DayOfWeek?), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnFirstDayOfWeekChanged)));

		// Token: 0x040001D9 RID: 473
		internal static readonly global::System.Windows.DependencyPropertyKey IsSelectionActivePropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("IsSelectionActive", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x040001DA RID: 474
		public static readonly global::System.Windows.DependencyProperty IsSelectionActiveProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.IsSelectionActivePropertyKey.DependencyProperty;

		// Token: 0x040001DB RID: 475
		public static readonly global::System.Windows.DependencyProperty MaxDateProperty = global::System.Windows.DependencyProperty.Register("MaxDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MaxValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnMaxDateChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.CoerceMaxDate)));

		// Token: 0x040001DC RID: 476
		public static readonly global::System.Windows.DependencyProperty MaxSelectedDatesProperty = global::System.Windows.DependencyProperty.Register("MaxSelectedDates", typeof(int), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnMaxSelectedDatesChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.ValidateMaxSelected));

		// Token: 0x040001DD RID: 477
		public static readonly global::System.Windows.DependencyProperty MinDateProperty = global::System.Windows.DependencyProperty.Register("MinDate", typeof(global::System.DateTime), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::System.DateTime.MinValue, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnMinDateChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.CoerceMinDate)));

		// Token: 0x040001DE RID: 478
		public static readonly global::System.Windows.DependencyProperty MinCalendarModeProperty = global::System.Windows.DependencyProperty.Register("MinCalendarMode", typeof(global::Infragistics.Windows.Editors.CalendarMode), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.CalendarMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnMinCalendarModeChanged)));

		// Token: 0x040001DF RID: 479
		public static readonly global::System.Windows.DependencyProperty ReferenceDateProperty = global::System.Windows.DependencyProperty.Register("ReferenceDate", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnReferenceDateChanged), new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.CoerceReferenceDate)));

		// Token: 0x040001E0 RID: 480
		public static readonly global::System.Windows.DependencyProperty ScrollButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("ScrollButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x040001E1 RID: 481
		public static readonly global::System.Windows.DependencyProperty SelectedDateProperty = global::System.Windows.DependencyProperty.Register("SelectedDate", typeof(global::System.DateTime?), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.BindsTwoWayByDefault | global::System.Windows.FrameworkPropertyMetadataOptions.Journal, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnSelectedDateChanged)));

		// Token: 0x040001E2 RID: 482
		public static readonly global::System.Windows.DependencyProperty SelectionTypeProperty = global::System.Windows.DependencyProperty.Register("SelectionType", typeof(global::Infragistics.Windows.Controls.SelectionType), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Controls.SelectionType.Default, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnSelectionTypeChanged)), new global::System.Windows.ValidateValueCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.IsSelectionTypeValid));

		// Token: 0x040001E3 RID: 483
		public static readonly global::System.Windows.DependencyProperty ShowDisabledDaysOfWeekProperty = global::System.Windows.DependencyProperty.Register("ShowDisabledDaysOfWeek", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnShowDisabledDaysOfWeek)));

		// Token: 0x040001E4 RID: 484
		public static readonly global::System.Windows.DependencyProperty ShowLeadingAndTrailingDatesProperty = global::System.Windows.DependencyProperty.Register("ShowLeadingAndTrailingDates", typeof(bool), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040001E5 RID: 485
		public static readonly global::System.Windows.DependencyProperty TodayButtonVisibilityProperty = global::System.Windows.DependencyProperty.Register("TodayButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.PropertyMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox));

		// Token: 0x040001E6 RID: 486
		public static readonly global::System.Windows.DependencyProperty WeekNumberVisibilityProperty = global::System.Windows.DependencyProperty.Register("WeekNumberVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.PropertyMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox));

		// Token: 0x040001E7 RID: 487
		public static readonly global::System.Windows.DependencyProperty ThemeProperty = global::Infragistics.Windows.Themes.ThemeManager.ThemeProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.XamMonthCalendar), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.XamMonthCalendar.OnThemeChanged)));

		// Token: 0x040001E9 RID: 489
		private static readonly global::System.Windows.DependencyPropertyKey TodayPropertyKey;

		// Token: 0x040001EA RID: 490
		public static readonly global::System.Windows.DependencyProperty TodayProperty;

		// Token: 0x040001EB RID: 491
		public static readonly global::System.Windows.DependencyProperty WeekRuleProperty;

		// Token: 0x040001EC RID: 492
		public static readonly global::System.Windows.DependencyProperty WorkdaysProperty;

		// Token: 0x040001ED RID: 493
		internal static readonly global::System.Windows.DependencyProperty MeasureDateProperty;

		// Token: 0x040001EE RID: 494
		internal static readonly global::System.Windows.DependencyPropertyKey MonthCalendarPropertyKey;

		// Token: 0x040001EF RID: 495
		public static readonly global::System.Windows.DependencyProperty MonthCalendarProperty;

		// Token: 0x02000046 RID: 70
		private class CustomSingleSelectionStrategy : global::Infragistics.Windows.Selection.SelectionStrategySingle
		{
			// Token: 0x0600054F RID: 1359 RVA: 0x00017BCB File Offset: 0x00015DCB
			internal CustomSingleSelectionStrategy(global::Infragistics.Windows.Selection.ISelectionHost host) : base(host)
			{
				base.AllowToggle = false;
			}

			// Token: 0x17000117 RID: 279
			// (get) Token: 0x06000550 RID: 1360 RVA: 0x00017BDB File Offset: 0x00015DDB
			protected override int AutoScrollHorizontalIntervalMax
			{
				get
				{
					return 250;
				}
			}

			// Token: 0x17000118 RID: 280
			// (get) Token: 0x06000551 RID: 1361 RVA: 0x00017BE2 File Offset: 0x00015DE2
			protected override int AutoScrollHorizontalIntervalMin
			{
				get
				{
					return 250;
				}
			}

			// Token: 0x17000119 RID: 281
			// (get) Token: 0x06000552 RID: 1362 RVA: 0x00017BE9 File Offset: 0x00015DE9
			protected override int AutoScrollVerticalIntervalMax
			{
				get
				{
					return 250;
				}
			}

			// Token: 0x1700011A RID: 282
			// (get) Token: 0x06000553 RID: 1363 RVA: 0x00017BF0 File Offset: 0x00015DF0
			protected override int AutoScrollVerticalIntervalMin
			{
				get
				{
					return 250;
				}
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x00017BF8 File Offset: 0x00015DF8
			public override void OnMouseLeftButtonUp(global::Infragistics.Windows.Selection.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
			{
				global::Infragistics.Windows.Editors.XamMonthCalendar xamMonthCalendar = base.SelectionHost as global::Infragistics.Windows.Editors.XamMonthCalendar;
				if (xamMonthCalendar != null)
				{
					xamMonthCalendar._shouldProcessActiveSelectionChanged = new bool?(false);
				}
				try
				{
					base.OnMouseLeftButtonUp(item, e);
				}
				finally
				{
					if (xamMonthCalendar != null)
					{
						bool flag = xamMonthCalendar._shouldProcessActiveSelectionChanged == true;
						xamMonthCalendar._shouldProcessActiveSelectionChanged = null;
						if (flag)
						{
							xamMonthCalendar.ProcessActiveSelectionStrategyChanged();
						}
					}
				}
			}

			// Token: 0x1700011B RID: 283
			// (get) Token: 0x06000555 RID: 1365 RVA: 0x00017C70 File Offset: 0x00015E70
			protected override int PixelThresholdForHorizontalAutoScroll
			{
				get
				{
					return 5;
				}
			}

			// Token: 0x1700011C RID: 284
			// (get) Token: 0x06000556 RID: 1366 RVA: 0x00017C73 File Offset: 0x00015E73
			protected override int PixelThresholdForVerticalAutoScroll
			{
				get
				{
					return 5;
				}
			}

			// Token: 0x040001F6 RID: 502
			private const int ScrollInterval = 250;
		}
	}
}
