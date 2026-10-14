using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Infragistics.AutomationPeers;
using Infragistics.Collections;
using Infragistics.Controls.Editors.Primitives;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200004F RID: 79
	[global::System.Windows.StyleTypedProperty(Property = "ScrollNextRepeatButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.RepeatButton))]
	[global::System.Windows.StyleTypedProperty(Property = "TodayButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Button))]
	[global::System.Windows.StyleTypedProperty(Property = "CalendarDayStyle", StyleTargetType = typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDay))]
	[global::System.Windows.StyleTypedProperty(Property = "ScrollPreviousRepeatButtonStyle", StyleTargetType = typeof(global::System.Windows.Controls.Primitives.RepeatButton))]
	[global::System.Windows.TemplatePart(Name = "RootPanel", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.Windows.StyleTypedProperty(Property = "CalendarItemStyle", StyleTargetType = typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItem))]
	public abstract class CalendarBase : global::System.Windows.Controls.Control, global::Infragistics.Controls.Primitives.ISelectionHost, global::Infragistics.ICommandTarget
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0000F194 File Offset: 0x0000D394
		static CalendarBase()
		{
			global::System.Windows.FrameworkElement.LanguageProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.CalendarBase), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnLanguageChanged)));
			global::System.Windows.Style style = new global::System.Windows.Style();
			style.Seal();
			global::System.Windows.FrameworkElement.FocusVisualStyleProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.CalendarBase), new global::System.Windows.FrameworkPropertyMetadata(style));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.CalendarBase), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Local));
			global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.CalendarBase), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Controls.Editors.CalendarBase.CoerceIsTabStop)));
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000F8E0 File Offset: 0x0000DAE0
		internal CalendarBase()
		{
			this._calendarManager = new global::Infragistics.Controls.Editors.CalendarManager();
			this._selectionController = new global::Infragistics.Controls.Primitives.SelectionController(this);
			this._selectionController.ActiveStrategyChanged += this.OnActiveSelectionStrategyChanged;
			this._groups = new global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup>();
			this._calendarManager.FirstDayOfWeek = this.FirstDayOfWeekInternal;
			this._calendarManager.WeekRule = this.WeekRuleInternal;
			this._daysOfWeekInternal = new global::Infragistics.Collections.ObservableCollectionExtended<global::System.DayOfWeek>();
			this._daysOfWeekInternal.CollectionChanged += this.OnDaysOfWeekChanged;
			this._daysOfWeekInternal.ReInitialize(this._calendarManager.GetDaysOfWeek());
			this._daysOfWeek = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.DayOfWeek>(this._daysOfWeekInternal);
			this._disabledDates = new global::Infragistics.Controls.Editors.Primitives.CalendarDateRangeCollection(this);
			this._disabledDates.CollectionChanged += this.OnDisabledDatesChanged;
			this._selectedDates = new global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection(this);
			this._selectedDatesSnapshot = new global::Infragistics.Collections.ObservableCollectionExtended<global::System.DateTime>();
			base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarPropertyKey, this);
			this.InitializeToday();
			global::Infragistics.CommandSourceManager.RegisterCommandTarget(this);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000FA24 File Offset: 0x0000DC24
		private void ResolveActiveDate()
		{
			if (!this._isInitialized)
			{
				return;
			}
			global::System.DateTime? activeDate = this.ActiveDate;
			if (activeDate == null)
			{
				activeDate = new global::System.DateTime?(this.SelectedDate ?? global::System.DateTime.Today);
			}
			if (activeDate != null)
			{
				global::System.DateTime dateTime = activeDate.Value;
				global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
				dateTime = this._calendarManager.GetItemStartDate(dateTime, currentMode);
				dateTime = this.ConstrainBetweenMinMaxDate(dateTime);
				global::System.DateTime dateTime2 = this._calendarManager.GetItemEndDate(dateTime, currentMode);
				dateTime2 = this.ConstrainBetweenMinMaxDate(dateTime2);
				activeDate = this.GetActivatableDate(dateTime, dateTime2, true, currentMode);
				if (activeDate == null)
				{
					activeDate = this.GetClosestActivatableDate(dateTime, dateTime2);
				}
			}
			this.ActiveDate = activeDate;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000FAD8 File Offset: 0x0000DCD8
		private static void OnActiveDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			if (calendarBase != null)
			{
				calendarBase.ClearPreferredNavInfo();
				if (e.NewValue is global::System.DateTime)
				{
					global::System.DateTime date = (global::System.DateTime)e.NewValue;
					if (!calendarBase._suppressBringActiveDateInView && !calendarBase.IsDateInView(date, true))
					{
						if (calendarBase._shouldBringActiveDateIntoView != null && calendarBase.IsDateInView(date, false, false))
						{
							calendarBase._shouldBringActiveDateIntoView = new bool?(true);
						}
						else
						{
							if (calendarBase._shouldBringActiveDateIntoView == true)
							{
								calendarBase._shouldBringActiveDateIntoView = new bool?(false);
							}
							calendarBase.BringDateIntoView(date);
						}
						if (calendarBase.IsKeyboardFocusWithin)
						{
							calendarBase.UpdateLayout();
						}
					}
					bool isNavigationMode = calendarBase.IsNavigationMode;
					if (e.OldValue is global::System.DateTime)
					{
						global::Infragistics.Controls.Editors.Primitives.CalendarItem item = calendarBase.GetItem((global::System.DateTime)e.OldValue);
						if (item != null)
						{
							item.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsActivePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
							if (isNavigationMode)
							{
								item.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectedPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
							}
						}
					}
					global::Infragistics.Controls.Editors.Primitives.CalendarItem item2 = calendarBase.GetItem(date);
					if (item2 != null)
					{
						item2.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						if (isNavigationMode)
						{
							item2.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
							return;
						}
					}
				}
				else if (e.OldValue is global::System.DateTime)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItem item3 = calendarBase.GetItem((global::System.DateTime)e.OldValue);
					if (item3 != null)
					{
						item3.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsActivePropertyKey, global::Infragistics.KnownBoxes.FalseBox);
					}
				}
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000FC44 File Offset: 0x0000DE44
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000FC56 File Offset: 0x0000DE56
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime? ActiveDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ActiveDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ActiveDateProperty, value);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000FC69 File Offset: 0x0000DE69
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000FC7B File Offset: 0x0000DE7B
		[global::System.ComponentModel.Bindable(true)]
		public bool AllowLeadingAndTrailingGroupActivation
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.AllowLeadingAndTrailingGroupActivationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.AllowLeadingAndTrailingGroupActivationProperty, value);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000FC8E File Offset: 0x0000DE8E
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		[global::System.ComponentModel.Bindable(true)]
		public bool AutoAdjustDimensions
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.AutoAdjustDimensionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.AutoAdjustDimensionsProperty, value);
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000FCB3 File Offset: 0x0000DEB3
		private static void OnItemStyleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			((global::Infragistics.Controls.Editors.CalendarBase)d).NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.ItemStyleChange);
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000FCC1 File Offset: 0x0000DEC1
		// (set) Token: 0x0600033E RID: 830 RVA: 0x0000FCD3 File Offset: 0x0000DED3
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style CalendarDayStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarDayStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarDayStyleProperty, value);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600033F RID: 831 RVA: 0x0000FCE1 File Offset: 0x0000DEE1
		// (set) Token: 0x06000340 RID: 832 RVA: 0x0000FCF3 File Offset: 0x0000DEF3
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style CalendarItemStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarItemStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarItemStyleProperty, value);
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000FD04 File Offset: 0x0000DF04
		private void ResolveCurrentMode()
		{
			global::Infragistics.Controls.Editors.CalendarZoomMode calendarZoomMode = this.CurrentMode;
			global::Infragistics.Controls.Editors.CalendarZoomMode minCalendarModeResolved = this.MinCalendarModeResolved;
			if (calendarZoomMode < minCalendarModeResolved)
			{
				calendarZoomMode = minCalendarModeResolved;
			}
			else
			{
				global::Infragistics.Controls.Editors.CalendarZoomMode maxCalendarMode = this.MaxCalendarMode;
				if (calendarZoomMode > maxCalendarMode)
				{
					calendarZoomMode = maxCalendarMode;
				}
			}
			this.CurrentMode = calendarZoomMode;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000FD3C File Offset: 0x0000DF3C
		private static void OnCurrentModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			calendarBase.ClearPreferredNavInfo();
			calendarBase.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.CurrentModeChanged);
			bool suppressBringActiveDateInView = calendarBase._suppressBringActiveDateInView;
			calendarBase._suppressBringActiveDateInView = true;
			try
			{
				calendarBase.ResolveActiveDate();
			}
			finally
			{
				calendarBase._suppressBringActiveDateInView = suppressBringActiveDateInView;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000343 RID: 835 RVA: 0x0000FD8C File Offset: 0x0000DF8C
		// (set) Token: 0x06000344 RID: 836 RVA: 0x0000FD9E File Offset: 0x0000DF9E
		[global::System.ComponentModel.Bindable(true)]
		[global::System.Windows.Markup.DependsOn("MinCalendarMode")]
		public global::Infragistics.Controls.Editors.CalendarZoomMode CurrentMode
		{
			get
			{
				return (global::Infragistics.Controls.Editors.CalendarZoomMode)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.CurrentModeProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.CurrentModeProperty, value);
			}
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000FDB4 File Offset: 0x0000DFB4
		private static void OnDayOfWeekHeaderFormatChanged(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = target as global::Infragistics.Controls.Editors.CalendarBase;
			calendarBase.InvalidateDisplay();
			calendarBase.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.CalendarInfoChanged);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000FDD5 File Offset: 0x0000DFD5
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000FDE7 File Offset: 0x0000DFE7
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat DayOfWeekHeaderFormat
		{
			get
			{
				return (global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.DayOfWeekHeaderFormatProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.DayOfWeekHeaderFormatProperty, value);
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000FDFC File Offset: 0x0000DFFC
		private static void OnDayOfWeekHeaderVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			calendarBase.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.WeekNumberVisibility);
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000349 RID: 841 RVA: 0x0000FE17 File Offset: 0x0000E017
		// (set) Token: 0x0600034A RID: 842 RVA: 0x0000FE29 File Offset: 0x0000E029
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility DayOfWeekHeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.DayOfWeekHeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.DayOfWeekHeaderVisibilityProperty, value);
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000FE3C File Offset: 0x0000E03C
		private static void OnDimensionsChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000FE45 File Offset: 0x0000E045
		// (set) Token: 0x0600034D RID: 845 RVA: 0x0000FE57 File Offset: 0x0000E057
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Controls.Editors.Primitives.CalendarDimensions Dimensions
		{
			get
			{
				return (global::Infragistics.Controls.Editors.Primitives.CalendarDimensions)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.DimensionsProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.DimensionsProperty, value);
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000FE6C File Offset: 0x0000E06C
		private static void OnIsSelectionActiveChange(global::System.Windows.DependencyObject target, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = target as global::Infragistics.Controls.Editors.CalendarBase;
			if (!calendarBase._notifySelectionActiveChangePending)
			{
				calendarBase._notifySelectionActiveChangePending = true;
				calendarBase.Dispatcher.BeginInvoke(new global::System.Action(calendarBase.ProcessSelectionActiveChange), new object[0]);
			}
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000FEAD File Offset: 0x0000E0AD
		private void ProcessSelectionActiveChange()
		{
			if (this._notifySelectionActiveChangePending)
			{
				this._notifySelectionActiveChangePending = false;
				this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.IsSelectionActiveChanged);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000350 RID: 848 RVA: 0x0000FEC6 File Offset: 0x0000E0C6
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0000FED8 File Offset: 0x0000E0D8
		public bool IsSelectionActive
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.IsSelectionActiveProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.IsSelectionActivePropertyKey, value);
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000FEEB File Offset: 0x0000E0EB
		private static void OnLeadingAndTrailingDatesVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNonHiddenVisibility(e);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000FEFB File Offset: 0x0000E0FB
		// (set) Token: 0x06000354 RID: 852 RVA: 0x0000FF0D File Offset: 0x0000E10D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Editors.NonHiddenVisibilityConverter))]
		public global::System.Windows.Visibility LeadingAndTrailingDatesVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.LeadingAndTrailingDatesVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.LeadingAndTrailingDatesVisibilityProperty, value);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000355 RID: 853 RVA: 0x0000FF20 File Offset: 0x0000E120
		// (set) Token: 0x06000356 RID: 854 RVA: 0x0000FF32 File Offset: 0x0000E132
		public global::System.DateTime MaxDateResolved
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.MaxDateResolvedProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.MaxDateResolvedPropertyKey, value);
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000FF48 File Offset: 0x0000E148
		private static void OnMinCalendarModeResolvedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			calendarBase._minCalendarModeResolved = (global::Infragistics.Controls.Editors.CalendarZoomMode)e.NewValue;
			calendarBase.ResolveCurrentMode();
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000FF74 File Offset: 0x0000E174
		// (set) Token: 0x06000359 RID: 857 RVA: 0x0000FF86 File Offset: 0x0000E186
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public global::Infragistics.Controls.Editors.CalendarZoomMode MinCalendarModeResolved
		{
			get
			{
				return (global::Infragistics.Controls.Editors.CalendarZoomMode)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.MinCalendarModeResolvedProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.MinCalendarModeResolvedPropertyKey, value);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000FF99 File Offset: 0x0000E199
		// (set) Token: 0x0600035B RID: 859 RVA: 0x0000FFAB File Offset: 0x0000E1AB
		public global::System.DateTime MinDateResolved
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.MinDateResolvedProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.MinDateResolvedPropertyKey, value);
			}
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000FFBE File Offset: 0x0000E1BE
		internal void ResolveReferenceDate()
		{
			if (!this._isInitialized)
			{
				return;
			}
			this.ResolveReferenceDate(this.ReferenceDate);
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000FFD8 File Offset: 0x0000E1D8
		internal void ResolveReferenceDate(global::System.DateTime? date)
		{
			if (!this._isInitialized)
			{
				return;
			}
			global::System.DateTime defaultReferenceDate;
			if (date != null)
			{
				defaultReferenceDate = this.GetDefaultReferenceDate(date.Value);
			}
			else
			{
				defaultReferenceDate = this.GetDefaultReferenceDate();
			}
			this.ReferenceDate = new global::System.DateTime?(defaultReferenceDate);
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0001001C File Offset: 0x0000E21C
		private static void OnReferenceDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = d as global::Infragistics.Controls.Editors.CalendarBase;
			if (e.NewValue == null)
			{
				d.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ReferenceDateProperty, global::System.DateTime.Today);
			}
			calendarBase._notifySelectionActiveChangePending = false;
			calendarBase.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.ReferenceDateChanged);
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600035F RID: 863 RVA: 0x0001005D File Offset: 0x0000E25D
		// (set) Token: 0x06000360 RID: 864 RVA: 0x0001006F File Offset: 0x0000E26F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime? ReferenceDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ReferenceDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ReferenceDateProperty, value);
			}
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00010084 File Offset: 0x0000E284
		private static void OnResourceProviderChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			calendarBase.ResolveResourceProvider();
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0001009E File Offset: 0x0000E29E
		// (set) Token: 0x06000363 RID: 867 RVA: 0x000100B0 File Offset: 0x0000E2B0
		public global::Infragistics.Controls.Editors.CalendarResourceProvider ResourceProvider
		{
			get
			{
				return (global::Infragistics.Controls.Editors.CalendarResourceProvider)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ResourceProviderProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ResourceProviderProperty, value);
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000100C0 File Offset: 0x0000E2C0
		private static void OnResourceProviderResolvedChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			calendarBase.ResolveButtonStyles();
			global::Infragistics.Controls.Editors.CalendarResourceProvider calendarResourceProvider = e.OldValue as global::Infragistics.Controls.Editors.CalendarResourceProvider;
			global::Infragistics.Controls.Editors.CalendarResourceProvider calendarResourceProvider2 = e.NewValue as global::Infragistics.Controls.Editors.CalendarResourceProvider;
			if (calendarResourceProvider != null)
			{
				calendarResourceProvider.PropertyChanged -= calendarBase.OnResourceProviderPropertyChanged;
				calendarBase.NotifyResourcesChanged();
			}
			if (calendarResourceProvider2 != null)
			{
				calendarResourceProvider2.PropertyChanged += calendarBase.OnResourceProviderPropertyChanged;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00010124 File Offset: 0x0000E324
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00010136 File Offset: 0x0000E336
		public global::Infragistics.Controls.Editors.CalendarResourceProvider ResourceProviderResolved
		{
			get
			{
				return (global::Infragistics.Controls.Editors.CalendarResourceProvider)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ResourceProviderResolvedProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ResourceProviderResolvedPropertyKey, value);
			}
		}

		// Token: 0x06000367 RID: 871 RVA: 0x00010144 File Offset: 0x0000E344
		private static void OnScrollButtonVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0001014D File Offset: 0x0000E34D
		// (set) Token: 0x06000369 RID: 873 RVA: 0x0001015F File Offset: 0x0000E35F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility ScrollButtonVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollButtonVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollButtonVisibilityProperty, value);
			}
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00010174 File Offset: 0x0000E374
		private static void OnButtonStyleChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			calendarBase.ResolveButtonStyles();
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600036B RID: 875 RVA: 0x0001018E File Offset: 0x0000E38E
		// (set) Token: 0x0600036C RID: 876 RVA: 0x000101A0 File Offset: 0x0000E3A0
		public global::System.Windows.Style ScrollNextRepeatButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollNextRepeatButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollNextRepeatButtonStyleProperty, value);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x0600036D RID: 877 RVA: 0x000101AE File Offset: 0x0000E3AE
		// (set) Token: 0x0600036E RID: 878 RVA: 0x000101C0 File Offset: 0x0000E3C0
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Style ScrollNextRepeatButtonStyleResolved
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollNextRepeatButtonStyleResolvedProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollNextRepeatButtonStyleResolvedPropertyKey, value);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000101CE File Offset: 0x0000E3CE
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000101E0 File Offset: 0x0000E3E0
		public global::System.Windows.Style ScrollPreviousRepeatButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollPreviousRepeatButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollPreviousRepeatButtonStyleProperty, value);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000101EE File Offset: 0x0000E3EE
		// (set) Token: 0x06000372 RID: 882 RVA: 0x00010200 File Offset: 0x0000E400
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Style ScrollPreviousRepeatButtonStyleResolved
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollPreviousRepeatButtonStyleResolvedProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.ScrollPreviousRepeatButtonStyleResolvedPropertyKey, value);
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00010210 File Offset: 0x0000E410
		private static void OnSelectedDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			if (calendarBase != null)
			{
				if (e.NewValue == null)
				{
					calendarBase.SelectedDatesInternal.Clear();
				}
				else
				{
					if (calendarBase.CurrentSelectionTypeResolved == global::Infragistics.Controls.Primitives.SelectionType.None)
					{
						throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.CalendarBase.GetString("LE_MaxSelectedDatesExceeded", new object[]
						{
							1,
							0
						}));
					}
					global::System.DateTime date = ((global::System.DateTime)e.NewValue).Date;
					global::Infragistics.Collections.DateCollection selectedDatesInternal = calendarBase.SelectedDatesInternal;
					if (selectedDatesInternal.Count == 0 || selectedDatesInternal[0] != date)
					{
						selectedDatesInternal.Reinitialize(new global::System.DateTime[]
						{
							date
						});
					}
				}
				calendarBase.ResolveActiveDate();
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000102CD File Offset: 0x0000E4CD
		// (set) Token: 0x06000375 RID: 885 RVA: 0x000102DF File Offset: 0x0000E4DF
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime? SelectedDate
		{
			get
			{
				return (global::System.DateTime?)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.SelectedDateProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.SelectedDateProperty, value);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000376 RID: 886 RVA: 0x000102F2 File Offset: 0x0000E4F2
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Content)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Collections.DateCollection SelectedDates
		{
			get
			{
				return this._selectedDates;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000377 RID: 887 RVA: 0x000102FA File Offset: 0x0000E4FA
		// (set) Token: 0x06000378 RID: 888 RVA: 0x0001030C File Offset: 0x0000E50C
		public string TodayButtonCaption
		{
			get
			{
				return (string)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayButtonCaptionProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayButtonCaptionPropertyKey, value);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0001031A File Offset: 0x0000E51A
		// (set) Token: 0x0600037A RID: 890 RVA: 0x0001032C File Offset: 0x0000E52C
		public global::System.Windows.Style TodayButtonStyle
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayButtonStyleProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayButtonStyleProperty, value);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0001033A File Offset: 0x0000E53A
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0001034C File Offset: 0x0000E54C
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Style TodayButtonStyleResolved
		{
			get
			{
				return (global::System.Windows.Style)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayButtonStyleResolvedProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayButtonStyleResolvedPropertyKey, value);
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0001035C File Offset: 0x0000E55C
		private static void OnWeekNumberVisibilityChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			calendarBase.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.WeekNumberVisibility);
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00010377 File Offset: 0x0000E577
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00010389 File Offset: 0x0000E589
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility WeekNumberVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.WeekNumberVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.WeekNumberVisibilityProperty, value);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000380 RID: 896 RVA: 0x0001039C File Offset: 0x0000E59C
		// (set) Token: 0x06000381 RID: 897 RVA: 0x000103AE File Offset: 0x0000E5AE
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.DateTime Today
		{
			get
			{
				return (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayPropertyKey, value);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000382 RID: 898 RVA: 0x000103C1 File Offset: 0x0000E5C1
		// (set) Token: 0x06000383 RID: 899 RVA: 0x000103CC File Offset: 0x0000E5CC
		protected global::Infragistics.DateRange AllowableDateRange
		{
			get
			{
				return this._allowableDateRange;
			}
			set
			{
				if (value != this._allowableDateRange)
				{
					this._allowableDateRange = value;
					global::System.DateTime dateTime;
					global::System.DateTime dateTime2;
					if (this._allowableDateRange.Start <= this._allowableDateRange.End)
					{
						dateTime = this._allowableDateRange.Start;
						dateTime2 = this._allowableDateRange.End;
					}
					else
					{
						dateTime = this._allowableDateRange.End;
						dateTime2 = this._allowableDateRange.Start;
					}
					base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.MinDateResolvedPropertyKey, dateTime.Date);
					base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.MaxDateResolvedPropertyKey, dateTime2.Date);
					this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.AllowableDatesChanged);
					if (this._isInitialized)
					{
						base.Dispatcher.BeginInvoke(new global::System.Action(this.ResolveReferenceDate), new object[0]);
					}
				}
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0001049B File Offset: 0x0000E69B
		// (set) Token: 0x06000385 RID: 901 RVA: 0x000104A4 File Offset: 0x0000E6A4
		protected internal global::System.DayOfWeek? FirstDayOfWeekInternal
		{
			get
			{
				return this._firstDayOfWeekResolved;
			}
			set
			{
				if (value != this._firstDayOfWeekResolved)
				{
					this._firstDayOfWeekResolved = value;
					this._calendarManager.FirstDayOfWeek = value;
					if (this._isInitialized)
					{
						using (new global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GroupInitializationHelper(this._groups))
						{
							this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.FirstDayOfWeekChanged);
							this.InitializeDaysOfWeek();
						}
					}
				}
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00010534 File Offset: 0x0000E734
		// (set) Token: 0x06000387 RID: 903 RVA: 0x0001053C File Offset: 0x0000E73C
		protected internal global::System.Globalization.CalendarWeekRule? WeekRuleInternal
		{
			get
			{
				return this._weekRuleResolved;
			}
			set
			{
				if (value != this._weekRuleResolved)
				{
					this._weekRuleResolved = value;
					this._calendarManager.WeekRule = value;
					this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.WeekRuleChanged);
				}
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00010594 File Offset: 0x0000E794
		internal global::Infragistics.Controls.Editors.CalendarManager CalendarManager
		{
			get
			{
				return this._calendarManager;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000389 RID: 905 RVA: 0x0001059C File Offset: 0x0000E79C
		internal virtual global::Infragistics.Controls.Primitives.SelectionType CurrentSelectionType
		{
			get
			{
				return global::Infragistics.Controls.Primitives.SelectionType.Extended;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600038A RID: 906 RVA: 0x0001059F File Offset: 0x0000E79F
		internal global::Infragistics.Controls.Primitives.SelectionType CurrentSelectionTypeResolved
		{
			get
			{
				if (this.IsMinCalendarMode)
				{
					return this.CurrentSelectionType;
				}
				return global::Infragistics.Controls.Primitives.SelectionType.Single;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600038B RID: 907 RVA: 0x000105B1 File Offset: 0x0000E7B1
		internal global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.DayOfWeek> DaysOfWeek
		{
			get
			{
				return this._daysOfWeek;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600038C RID: 908 RVA: 0x000105B9 File Offset: 0x0000E7B9
		// (set) Token: 0x0600038D RID: 909 RVA: 0x000105C1 File Offset: 0x0000E7C1
		internal bool DisableAnimations { get; set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600038E RID: 910 RVA: 0x000105CA File Offset: 0x0000E7CA
		internal global::Infragistics.Controls.Editors.Primitives.CalendarDateRangeCollection DisabledDatesInternal
		{
			get
			{
				return this._disabledDates;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600038F RID: 911 RVA: 0x000105D2 File Offset: 0x0000E7D2
		// (set) Token: 0x06000390 RID: 912 RVA: 0x000105DC File Offset: 0x0000E7DC
		internal global::Infragistics.Controls.DayOfWeekFlags DisabledDaysOfWeekInternal
		{
			get
			{
				return this._disabledDaysOfWeekInternal;
			}
			set
			{
				if (value != this._disabledDaysOfWeekInternal)
				{
					this._disabledDaysOfWeekInternal = value;
					using (new global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GroupInitializationHelper(this._groups))
					{
						if (this.DisabledDaysOfWeekVisibilityInternal != global::System.Windows.Visibility.Visible)
						{
							this.CalendarManager.HiddenDays = this.DisabledDaysOfWeekInternal;
							this.InitializeDaysOfWeek();
						}
						this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.DisabledDatesChanged);
					}
				}
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00010648 File Offset: 0x0000E848
		// (set) Token: 0x06000392 RID: 914 RVA: 0x00010650 File Offset: 0x0000E850
		internal global::System.Windows.Visibility DisabledDaysOfWeekVisibilityInternal
		{
			get
			{
				return this._disabledDaysOfWeekVisibilityInternal;
			}
			set
			{
				if (value != this._disabledDaysOfWeekVisibilityInternal)
				{
					this._disabledDaysOfWeekVisibilityInternal = value;
					if (this._disabledDaysOfWeekInternal != global::Infragistics.Controls.DayOfWeekFlags.None)
					{
						global::Infragistics.Controls.DayOfWeekFlags hiddenDays = (value != global::System.Windows.Visibility.Visible) ? this._disabledDaysOfWeekInternal : global::Infragistics.Controls.DayOfWeekFlags.None;
						this._calendarManager.HiddenDays = hiddenDays;
						if (!this.InitializeDaysOfWeek())
						{
							this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.DisabledDatesChanged);
						}
					}
				}
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000393 RID: 915 RVA: 0x0001069D File Offset: 0x0000E89D
		// (set) Token: 0x06000394 RID: 916 RVA: 0x000106A5 File Offset: 0x0000E8A5
		internal global::Infragistics.Controls.Editors.CalendarResourceProvider DefaultResourceProvider
		{
			get
			{
				return this._defaultResourceProvider;
			}
			set
			{
				if (value != this._defaultResourceProvider)
				{
					this._defaultResourceProvider = value;
					this.ResolveResourceProvider();
				}
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000395 RID: 917 RVA: 0x000106BD File Offset: 0x0000E8BD
		// (set) Token: 0x06000396 RID: 918 RVA: 0x000106C8 File Offset: 0x0000E8C8
		internal int MaxSelectedDatesInternal
		{
			get
			{
				return this._maxSelectedDatesInternal;
			}
			set
			{
				if (value != this._maxSelectedDatesInternal)
				{
					this._maxSelectedDatesInternal = value;
					global::Infragistics.Collections.DateCollection selectedDatesInternal = this.SelectedDatesInternal;
					if (this._isInitialized && this._maxSelectedDatesInternal > 0 && this._maxSelectedDatesInternal < selectedDatesInternal.Count)
					{
						global::System.DateTime[] array = new global::System.DateTime[selectedDatesInternal.Count];
						selectedDatesInternal.CopyTo(array, 0);
						global::System.Array.Resize<global::System.DateTime>(ref array, this._maxSelectedDatesInternal);
						selectedDatesInternal.Reinitialize(array);
					}
				}
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00010734 File Offset: 0x0000E934
		internal int MaxSelectedDatesResolved
		{
			get
			{
				global::Infragistics.Controls.Primitives.SelectionType currentSelectionTypeResolved = this.CurrentSelectionTypeResolved;
				if (global::Infragistics.Controls.Primitives.SelectionStrategyBase.IsMultiSelectStrategy(currentSelectionTypeResolved))
				{
					int num = this.MaxSelectedDatesInternal;
					if (num == 0)
					{
						num = int.MaxValue;
					}
					return num;
				}
				if (global::Infragistics.Controls.Primitives.SelectionStrategyBase.IsSingleSelectStrategy(currentSelectionTypeResolved))
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0001076D File Offset: 0x0000E96D
		internal bool IsNavigationMode
		{
			get
			{
				return !this.IsMinCalendarMode;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00010778 File Offset: 0x0000E978
		internal bool IsMinCalendarMode
		{
			get
			{
				return this.CurrentMode == this.MinCalendarModeResolved;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00010788 File Offset: 0x0000E988
		internal global::Infragistics.Controls.Editors.CalendarZoomMode MaxCalendarMode
		{
			get
			{
				return global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries;
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0001078B File Offset: 0x0000E98B
		private static void OnMeasureDateChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00010794 File Offset: 0x0000E994
		private void ResolveMeasureDate()
		{
			if (!this._isInitialized)
			{
				return;
			}
			global::System.DateTime dateTime = (global::System.DateTime)base.GetValue(global::Infragistics.Controls.Editors.CalendarBase.MeasureDateProperty);
			dateTime = this._calendarManager.CoerceMinMaxDate(dateTime);
			base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.MeasureDateProperty, dateTime);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x000107DC File Offset: 0x0000E9DC
		private static void OnCalendarChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.Primitives.ICalendarElement calendarElement = d as global::Infragistics.Controls.Editors.Primitives.ICalendarElement;
			if (calendarElement != null)
			{
				calendarElement.OnCalendarChanged(e.NewValue as global::Infragistics.Controls.Editors.CalendarBase, e.OldValue as global::Infragistics.Controls.Editors.CalendarBase);
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00010811 File Offset: 0x0000EA11
		public static global::Infragistics.Controls.Editors.CalendarBase GetCalendar(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Controls.Editors.CalendarBase)d.GetValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarProperty);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00010823 File Offset: 0x0000EA23
		internal static void SetCalendar(global::System.Windows.DependencyObject d, global::Infragistics.Controls.Editors.CalendarBase value)
		{
			d.SetValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarPropertyKey, value);
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00010831 File Offset: 0x0000EA31
		internal global::System.Windows.Controls.Panel RootPanel
		{
			get
			{
				return this._rootPanel;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00010839 File Offset: 0x0000EA39
		internal global::Infragistics.Collections.DateCollection SelectedDatesInternal
		{
			get
			{
				if (this._mouseDownSnapshot == null)
				{
					return this._selectedDates;
				}
				return this._mouseDownSnapshot.SelectedDates;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00010855 File Offset: 0x0000EA55
		internal global::Infragistics.Controls.Primitives.ISelectionHost SelectionHost
		{
			get
			{
				return this;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00010858 File Offset: 0x0000EA58
		internal virtual bool SupportsWeekSelectionMode
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x0001085B File Offset: 0x0000EA5B
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00010863 File Offset: 0x0000EA63
		internal global::Infragistics.Controls.DayOfWeekFlags WorkDaysInternal
		{
			get
			{
				return this._workDaysInternal;
			}
			set
			{
				if (this._workDaysInternal != value)
				{
					this._workDaysInternal = value;
					this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.WorkdaysChanged);
				}
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00010880 File Offset: 0x0000EA80
		private global::Infragistics.Controls.Editors.CalendarStates CurrentState
		{
			get
			{
				global::Infragistics.Controls.Editors.CalendarStates calendarStates = (global::Infragistics.Controls.Editors.CalendarStates)0L;
				if (this._groups.Count > 0)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup firstGroup = this.GetFirstGroup(true, true);
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup lastGroup = this.GetLastGroup(true, true);
					if (firstGroup != null && firstGroup.FirstDateOfGroup <= this.MinDateResolved)
					{
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.MinDateInView;
					}
					if (lastGroup != null && lastGroup.LastDateOfGroup >= this.MaxDateResolved)
					{
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.MaxDateInView;
					}
					if (this.CanActivate(global::System.DateTime.Today))
					{
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.TodayIsEnabled;
					}
					if (this.ActiveDate != null)
					{
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.ActiveDate;
					}
					if (this.CurrentMode > this.MinCalendarModeResolved)
					{
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.CanZoomInCalendarMode;
					}
					if (this.CurrentMode < this.MaxCalendarMode && (!this.IsDateInView(this.MinDateResolved, true, false) || !this.IsDateInView(this.MaxDateResolved, true, false)))
					{
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.CanZoomOutCalendarMode;
					}
					switch (this.CurrentMode)
					{
					case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.CalendarModeDays;
						break;
					case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.CalendarModeMonths;
						break;
					case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.CalendarModeYears;
						break;
					case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.CalendarModeDecades;
						break;
					case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.CalendarModeCenturies;
						break;
					}
					if (this.IsMinCalendarMode)
					{
						calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.MinCalendarMode;
					}
				}
				if (base.FlowDirection == global::System.Windows.FlowDirection.RightToLeft)
				{
					calendarStates |= global::Infragistics.Controls.Editors.CalendarStates.RightToLeft;
				}
				return calendarStates;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x00010A05 File Offset: 0x0000EC05
		internal global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup FirstGroup
		{
			get
			{
				return this.GetFirstGroup(true, false);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00010A0F File Offset: 0x0000EC0F
		internal global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup LastGroup
		{
			get
			{
				return this.GetLastGroup(true, false);
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00010A19 File Offset: 0x0000EC19
		public void BringDateIntoView(global::System.DateTime date)
		{
			this.BringDateIntoView(date, null);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00010A24 File Offset: 0x0000EC24
		internal void BringDateIntoView(global::System.DateTime date, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group)
		{
			int groupIndex = (group == null) ? -1 : this._groups.IndexOf(group);
			this.BringDateIntoView(date, groupIndex, true);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00010A50 File Offset: 0x0000EC50
		internal void BringDateIntoView(global::System.DateTime date, int groupIndex, bool ignoreLeadingAndTrailingDates)
		{
			if (this._shouldBringActiveDateIntoView != null)
			{
				this._shouldBringActiveDateIntoView = new bool?(false);
			}
			date = this.ConstrainBetweenMinMaxDate(date);
			if (this._groups.Count == 0)
			{
				this.ResolveReferenceDate(new global::System.DateTime?(date));
				return;
			}
			if (groupIndex >= 0)
			{
				groupIndex = global::System.Math.Min(this._groups.IndexOf(this.GetFirstGroup(false)), global::System.Math.Max(this._groups.IndexOf(this.GetLastGroup(false)), groupIndex));
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = this._groups[groupIndex];
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
					global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
					global::System.DateTime value = this._calendarManager.GetGroupStartDate(date, currentMode);
					value = this._calendarManager.AddGroupOffset(date, -groupIndex, currentMode, true);
					this.ResolveReferenceDate(new global::System.DateTime?(value));
				}
				return;
			}
			if (this.IsDateInView(date, ignoreLeadingAndTrailingDates))
			{
				return;
			}
			if (this._groups.Count == 1)
			{
				this.ResolveReferenceDate(new global::System.DateTime?(date));
				return;
			}
			global::Infragistics.Controls.Editors.CalendarZoomMode currentMode2 = this.CurrentMode;
			global::System.DateTime dateTime3 = this._calendarManager.GetGroupStartDate(date, currentMode2);
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup2 = (dateTime3 < this.ReferenceDate) ? this.GetFirstGroup(false) : this.GetLastGroup(false);
			int referenceGroupOffset = calendarItemGroup2.ReferenceGroupOffset;
			dateTime3 = this._calendarManager.AddGroupOffset(dateTime3, -referenceGroupOffset, currentMode2, true);
			this.ResolveReferenceDate(new global::System.DateTime?(dateTime3));
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00010C81 File Offset: 0x0000EE81
		public bool ExecuteCommand(global::Infragistics.Controls.Editors.CalendarCommandType command, object parameter, global::System.Windows.FrameworkElement sourceElement)
		{
			return this.ExecuteCommandImpl(command, parameter, sourceElement);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00010C8C File Offset: 0x0000EE8C
		private bool ExecuteCommandImpl(global::Infragistics.Controls.Editors.CalendarCommandType commandType, object parameter, global::System.Windows.FrameworkElement sourceElement)
		{
			if (!this.CanExecuteCommand(commandType, sourceElement))
			{
				return false;
			}
			global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
			bool shiftKeyDown = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
			bool ctlKeyDown = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
			bool result = false;
			switch (commandType)
			{
			case global::Infragistics.Controls.Editors.CalendarCommandType.ActivateDate:
			{
				global::System.DateTime? dateValue = null;
				if (parameter is global::System.DateTime)
				{
					dateValue = new global::System.DateTime?((global::System.DateTime)parameter);
				}
				else
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = parameter as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
					if (calendarItem == null && sourceElement != null)
					{
						if (sourceElement is global::Infragistics.Controls.Editors.Primitives.CalendarItem)
						{
							calendarItem = (global::Infragistics.Controls.Editors.Primitives.CalendarItem)sourceElement;
						}
						else
						{
							calendarItem = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::Infragistics.Controls.Editors.Primitives.CalendarItem>(sourceElement, null, null);
						}
					}
					if (calendarItem != null)
					{
						dateValue = new global::System.DateTime?(calendarItem.StartDate);
					}
				}
				result = this.ActivateDate(dateValue, false);
				break;
			}
			case global::Infragistics.Controls.Editors.CalendarCommandType.ActivateSelectedDate:
				this.ActiveDate = this.SelectedDate;
				result = true;
				break;
			case global::Infragistics.Controls.Editors.CalendarCommandType.FirstItemOfFirstGroup:
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup firstGroup = this.GetFirstGroup(false);
				if (firstGroup != null)
				{
					global::System.DateTime? activatableDate = this.GetActivatableDate(firstGroup.FirstDateOfGroup, false, true);
					result = this.ActivateDate(activatableDate);
				}
				break;
			}
			case global::Infragistics.Controls.Editors.CalendarCommandType.FirstItemOfGroup:
				if (this.ActiveDate != null)
				{
					global::System.DateTime? activatableDate2 = this.GetActivatableDate(new global::System.DateTime?(this._calendarManager.GetGroupStartDate(this.ActiveDate.Value, this.CurrentMode)), false, true);
					result = this.ActivateDate(activatableDate2);
				}
				break;
			case global::Infragistics.Controls.Editors.CalendarCommandType.LastItemOfGroup:
				if (this.ActiveDate != null)
				{
					global::System.DateTime? activatableDate3 = this.GetActivatableDate(new global::System.DateTime?(this._calendarManager.GetGroupEndDate(this.ActiveDate.Value, this.CurrentMode)), true, true);
					result = this.ActivateDate(activatableDate3);
				}
				break;
			case global::Infragistics.Controls.Editors.CalendarCommandType.LastItemOfLastGroup:
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup lastGroup = this.GetLastGroup(false);
				if (lastGroup != null)
				{
					global::System.DateTime? activatableDate4 = this.GetActivatableDate(lastGroup.LastDateOfGroup, true, true);
					result = this.ActivateDate(activatableDate4);
				}
				break;
			}
			case global::Infragistics.Controls.Editors.CalendarCommandType.NextGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.PreviousGroup:
				if (this.ActiveDate != null)
				{
					result = this.NavigateGroup(this.ActiveDate.Value, commandType == global::Infragistics.Controls.Editors.CalendarCommandType.NextGroup);
				}
				break;
			case global::Infragistics.Controls.Editors.CalendarCommandType.NextItem:
			case global::Infragistics.Controls.Editors.CalendarCommandType.PreviousItem:
			{
				global::System.DateTime? activatableDate5 = this.GetActivatableDate(this.ActiveDate, commandType == global::Infragistics.Controls.Editors.CalendarCommandType.PreviousItem, false);
				if (activatableDate5 != null && this.SupportsWeekSelectionMode)
				{
					global::Infragistics.Collections.DateCollection selectedDates = this.SelectedDates;
					while (activatableDate5 != null && selectedDates.ContainsDate(activatableDate5.Value))
					{
						activatableDate5 = this.GetActivatableDate(activatableDate5, commandType == global::Infragistics.Controls.Editors.CalendarCommandType.PreviousItem, false);
					}
				}
				result = this.ActivateDate(activatableDate5);
				break;
			}
			case global::Infragistics.Controls.Editors.CalendarCommandType.NextItemRow:
			case global::Infragistics.Controls.Editors.CalendarCommandType.PreviousItemRow:
				if (this.ActiveDate != null)
				{
					result = this.NavigateRow(this.ActiveDate.Value, commandType == global::Infragistics.Controls.Editors.CalendarCommandType.NextItemRow);
				}
				break;
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollNextGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollPreviousGroup:
			{
				int numberOfGroups = (commandType == global::Infragistics.Controls.Editors.CalendarCommandType.ScrollNextGroup) ? 1 : -1;
				result = this.ScrollGroups(numberOfGroups);
				break;
			}
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollNextGroups:
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollPreviousGroups:
			{
				int num = (parameter is int) ? ((int)parameter) : (this.GetLastGroup(false).ReferenceGroupOffset - this.GetFirstGroup(false).ReferenceGroupOffset + 1);
				if (commandType == global::Infragistics.Controls.Editors.CalendarCommandType.ScrollPreviousGroups)
				{
					num *= -1;
				}
				result = this.ScrollGroups(num);
				break;
			}
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollToDate:
				if (parameter is global::System.DateTime)
				{
					global::System.DateTime date = (global::System.DateTime)parameter;
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group = null;
					if (sourceElement != null)
					{
						if (sourceElement is global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)
						{
							group = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)sourceElement;
						}
						else
						{
							group = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup>(sourceElement, null, null);
						}
					}
					this.BringDateIntoView(date, group);
					result = true;
				}
				break;
			case global::Infragistics.Controls.Editors.CalendarCommandType.Today:
				result = this.ActivateDate(new global::System.DateTime?(global::System.DateTime.Today));
				this.RaiseSelectionCommitted(new global::System.EventArgs());
				break;
			case global::Infragistics.Controls.Editors.CalendarCommandType.ToggleActiveDateSelection:
				result = this.ToggleActiveDateSelection(shiftKeyDown, ctlKeyDown);
				break;
			case global::Infragistics.Controls.Editors.CalendarCommandType.ZoomOutCalendarMode:
			case global::Infragistics.Controls.Editors.CalendarCommandType.ZoomInCalendarMode:
				this.ChangeCalendarMode(commandType == global::Infragistics.Controls.Editors.CalendarCommandType.ZoomOutCalendarMode, parameter, sourceElement);
				result = true;
				break;
			}
			return result;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00011044 File Offset: 0x0000F244
		protected internal virtual string GetDayOfWeekHeader(global::System.DayOfWeek dayofWeek)
		{
			global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat dayOfWeekHeaderFormat = this.DayOfWeekHeaderFormat;
			return this._calendarManager.GetDayOfWeekCaption(dayOfWeekHeaderFormat, dayofWeek);
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00011065 File Offset: 0x0000F265
		protected internal virtual void InvalidateDisplay()
		{
			if (this.CurrentMode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days)
			{
				this.ClearPreferredNavInfo();
			}
			this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.DaysOfWeekChanged);
			this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.Resources);
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00011084 File Offset: 0x0000F284
		protected void InvalidateIsHighlighted(global::System.DateTime dayinMonth)
		{
			if (this.CurrentMode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group = this.GetGroup(dayinMonth);
				if (group != null)
				{
					global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea itemArea = group.ItemArea;
					if (itemArea != null)
					{
						foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem in itemArea.Items)
						{
							global::Infragistics.Controls.Editors.Primitives.CalendarDay calendarDay = calendarItem as global::Infragistics.Controls.Editors.Primitives.CalendarDay;
							if (calendarDay != null)
							{
								calendarDay.InitializeIsHighlighted();
							}
						}
					}
				}
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000110FC File Offset: 0x0000F2FC
		protected void SetCalendarInfo(global::System.Globalization.Calendar calendar, global::System.Globalization.DateTimeFormatInfo dateTimeFormat)
		{
			if (this._suppliedCalendar != calendar || this._suppliedDateTimeFormat != dateTimeFormat)
			{
				this._suppliedCalendar = calendar;
				this._suppliedDateTimeFormat = dateTimeFormat;
				this.OnCalendarInfoChanged(base.Language);
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0001112A File Offset: 0x0000F32A
		protected internal virtual bool ShouldHighlightDay(global::Infragistics.Controls.Editors.Primitives.CalendarDay dayElement)
		{
			return dayElement.IsWorkday && !dayElement.IsLeadingOrTrailingItem && dayElement.IsEnabled;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00011144 File Offset: 0x0000F344
		internal virtual global::System.DateTime AddLogicalDayDuration(global::System.DateTime start)
		{
			global::Infragistics.Controls.Editors.CalendarManager calendarManager = this.CalendarManager;
			if (calendarManager != null)
			{
				return calendarManager.AddDays(start, 1).AddMilliseconds(-1.0);
			}
			return (start + global::System.TimeSpan.FromTicks(864000000000L)).AddMilliseconds(-1.0);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0001119A File Offset: 0x0000F39A
		internal virtual global::System.DateTime ApplyLogicalDayOffset(global::System.DateTime date)
		{
			return date;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000111A0 File Offset: 0x0000F3A0
		internal void BindCalendarItemGroupPanel(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupPanel panel)
		{
			panel.SetBinding(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupPanel.AutoAdjustDimensionsProperty, this.CreateBindingHelper(global::Infragistics.Controls.Editors.CalendarBase.AutoAdjustDimensionsProperty, "AutoAdjustDimensionsProperty"));
			panel.SetBinding(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupPanel.DimensionsProperty, this.CreateBindingHelper(global::Infragistics.Controls.Editors.CalendarBase.DimensionsProperty, "DimensionsProperty"));
			panel.SetBinding(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupPanel.LeadingAndTrailingDatesVisibilityProperty, this.CreateBindingHelper(global::Infragistics.Controls.Editors.CalendarBase.LeadingAndTrailingDatesVisibilityProperty, "LeadingAndTrailingDatesVisibilityProperty"));
			panel.SetBinding(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroupPanel.ScrollButtonVisibilityProperty, this.CreateBindingHelper(global::Infragistics.Controls.Editors.CalendarBase.ScrollButtonVisibilityProperty, "ScrollButtonVisibilityProperty"));
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00011220 File Offset: 0x0000F420
		internal bool CanActivate(global::System.DateTime date)
		{
			return this.GetActivatableItemDate(date, this.CurrentMode) != null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00011244 File Offset: 0x0000F444
		internal bool CanActivate(global::System.DateTime start, global::System.DateTime end, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			return this.GetActivatableDate(start, end, true, mode) != null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00011264 File Offset: 0x0000F464
		internal bool CanExecuteCommand(global::Infragistics.Controls.Editors.CalendarCommandType command, global::System.Windows.FrameworkElement sourceElement)
		{
			switch (command)
			{
			case global::Infragistics.Controls.Editors.CalendarCommandType.FirstItemOfFirstGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.FirstItemOfGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.LastItemOfGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.LastItemOfLastGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.NextGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.NextItem:
			case global::Infragistics.Controls.Editors.CalendarCommandType.NextItemRow:
			case global::Infragistics.Controls.Editors.CalendarCommandType.PreviousGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.PreviousItem:
			case global::Infragistics.Controls.Editors.CalendarCommandType.PreviousItemRow:
				return (this.CurrentState & global::Infragistics.Controls.Editors.CalendarStates.ActiveDate) == global::Infragistics.Controls.Editors.CalendarStates.ActiveDate;
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollNextGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollNextGroups:
				return (this.CurrentState & global::Infragistics.Controls.Editors.CalendarStates.MaxDateInView) != global::Infragistics.Controls.Editors.CalendarStates.MaxDateInView;
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollPreviousGroup:
			case global::Infragistics.Controls.Editors.CalendarCommandType.ScrollPreviousGroups:
				return (this.CurrentState & global::Infragistics.Controls.Editors.CalendarStates.MinDateInView) != global::Infragistics.Controls.Editors.CalendarStates.MinDateInView;
			case global::Infragistics.Controls.Editors.CalendarCommandType.Today:
				return (this.CurrentState & global::Infragistics.Controls.Editors.CalendarStates.TodayIsEnabled) == global::Infragistics.Controls.Editors.CalendarStates.TodayIsEnabled;
			case global::Infragistics.Controls.Editors.CalendarCommandType.ToggleActiveDateSelection:
				return (this.CurrentState & (global::Infragistics.Controls.Editors.CalendarStates.ActiveDate | global::Infragistics.Controls.Editors.CalendarStates.MinCalendarMode)) == (global::Infragistics.Controls.Editors.CalendarStates.ActiveDate | global::Infragistics.Controls.Editors.CalendarStates.MinCalendarMode);
			case global::Infragistics.Controls.Editors.CalendarCommandType.ZoomOutCalendarMode:
				return (this.CurrentState & global::Infragistics.Controls.Editors.CalendarStates.CanZoomOutCalendarMode) == global::Infragistics.Controls.Editors.CalendarStates.CanZoomOutCalendarMode;
			case global::Infragistics.Controls.Editors.CalendarCommandType.ZoomInCalendarMode:
				return (this.CurrentState & global::Infragistics.Controls.Editors.CalendarStates.CanZoomInCalendarMode) == global::Infragistics.Controls.Editors.CalendarStates.CanZoomInCalendarMode;
			}
			return true;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00011340 File Offset: 0x0000F540
		internal global::System.DateTime ConstrainBetweenMinMaxDate(global::System.DateTime date)
		{
			date = date.Date;
			global::System.DateTime maxDateResolved = this.MaxDateResolved;
			if (date > maxDateResolved)
			{
				date = maxDateResolved;
			}
			else
			{
				global::System.DateTime minDateResolved = this.MinDateResolved;
				if (date < minDateResolved)
				{
					date = minDateResolved;
				}
			}
			return date;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00011380 File Offset: 0x0000F580
		internal void FocusActiveItemWithDelay()
		{
			if (!base.IsKeyboardFocusWithin)
			{
				return;
			}
			bool? flag = new bool?(global::Infragistics.Controls.Primitives.XamlHelper.GetFocusable(this));
			if (flag != null && !flag.Value)
			{
				return;
			}
			bool preventFocusActiveItem = this._preventFocusActiveItem;
			this._preventFocusActiveItem = true;
			try
			{
				base.Focus();
			}
			finally
			{
				this._preventFocusActiveItem = preventFocusActiveItem;
			}
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000113E8 File Offset: 0x0000F5E8
		internal global::System.DateTime? GetActivatableDate(global::Infragistics.Controls.Editors.Primitives.CalendarItem item)
		{
			global::System.DateTime? result;
			if (item == null)
			{
				result = null;
			}
			else
			{
				result = this.GetActivatableDate(item.StartDate, item.EndDate, true, this.CurrentMode);
			}
			return result;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0001141D File Offset: 0x0000F61D
		internal global::System.DateTime? GetActivatableDate(global::System.DateTime start, global::System.DateTime end, bool next)
		{
			return this.GetActivatableDate(start, end, next, this.CurrentMode);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00011430 File Offset: 0x0000F630
		internal global::System.DateTime? GetActivatableDate(global::System.DateTime start, global::System.DateTime end, bool next, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			if (end < this.MinDateResolved || start > this.MaxDateResolved)
			{
				return null;
			}
			if (mode != this.MinCalendarModeResolved)
			{
				if (!next)
				{
					return new global::System.DateTime?(end);
				}
				return new global::System.DateTime?(start);
			}
			else
			{
				global::System.DateTime start2 = this.ConstrainBetweenMinMaxDate(start);
				global::System.DateTime end2 = this.ConstrainBetweenMinMaxDate(end);
				int disabledDaysOfWeekInternal = (int)this.DisabledDaysOfWeekInternal;
				int daysOfWeek = this.GetDaysOfWeek(start2, end2);
				if ((disabledDaysOfWeekInternal & daysOfWeek) == daysOfWeek)
				{
					return null;
				}
				return this._disabledDates.GetAvailableDate(start2, end2, next);
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000114C0 File Offset: 0x0000F6C0
		private global::System.DateTime? GetActivatableItemDate(global::System.DateTime date, global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			global::System.DateTime itemStartDate = this.CalendarManager.GetItemStartDate(date, mode);
			global::System.DateTime itemEndDate = this.CalendarManager.GetItemEndDate(date, mode);
			return this.GetActivatableDate(itemStartDate, itemEndDate, true, mode);
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000114F4 File Offset: 0x0000F6F4
		internal virtual global::Infragistics.DateRange GetTodayRange()
		{
			global::System.DateTime start = global::System.DateTime.Today.ToUniversalTime();
			return new global::Infragistics.DateRange(start, start.AddDays(1.0));
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00011528 File Offset: 0x0000F728
		internal global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup GetGroup(global::System.DateTime date)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup result = null;
			if (this._groups.Count > 0)
			{
				for (int i = 0; i < this._groups.Count; i++)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = this._groups[i];
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

		// Token: 0x060003C1 RID: 961 RVA: 0x00011710 File Offset: 0x0000F910
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup> GetGroups()
		{
			for (int i = 0; i < this._groups.Count; i++)
			{
				yield return this._groups[i];
			}
			yield break;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00011730 File Offset: 0x0000F930
		internal global::System.DateTime[] GetSelectableDates(global::Infragistics.DateRange range)
		{
			range.Normalize();
			range.RemoveTime();
			if (range.End > this.MaxDateResolved || range.Start < this.MinDateResolved)
			{
				return new global::System.DateTime[0];
			}
			if (range.Start < this.MinDateResolved)
			{
				range.Start = this.MinDateResolved;
			}
			else if (range.End > this.MaxDateResolved)
			{
				range.End = this.MaxDateResolved;
			}
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			this._disabledDates.AddAvailableDates(range, list);
			return list.ToArray();
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000117D7 File Offset: 0x0000F9D7
		internal static string GetString(string name)
		{
			return global::Infragistics.Controls.Editors.CalendarBase.GetString(name, null);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000117E0 File Offset: 0x0000F9E0
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000117EC File Offset: 0x0000F9EC
		internal bool InternalSelectItem(global::Infragistics.Controls.Primitives.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem item2 = this.GetItem(item);
			global::Infragistics.DateRange? dateRange = null;
			if (item2 != null)
			{
				global::System.DateTime? activatableDate = this.GetActivatableDate(item2);
				if (activatableDate != null)
				{
					dateRange = new global::Infragistics.DateRange?(new global::Infragistics.DateRange(activatableDate.Value));
				}
			}
			else
			{
				dateRange = this.GetRangeFromItem(item);
			}
			return this.InternalSelectItem(dateRange, clearExistingSelection, select);
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00011844 File Offset: 0x0000FA44
		internal bool InternalSelectItem(global::Infragistics.DateRange? dateRange, bool clearExistingSelection, bool select)
		{
			if (dateRange == null && (!clearExistingSelection || this.SelectedDatesInternal.Count == 0))
			{
				return false;
			}
			if (dateRange != null && select && (!this.CanActivate(dateRange.Value.Start) || !this.CanActivate(dateRange.Value.End)))
			{
				select = false;
			}
			global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection selectedDateCollection = this.SelectedDatesInternal as global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection;
			if (dateRange != null && selectedDateCollection.IsSelected(dateRange.Value) == select && (!clearExistingSelection || this.SelectedDatesInternal.Count == 0))
			{
				return true;
			}
			global::System.Collections.Generic.IList<global::System.DateTime> newSelection = this.CalculateNewSelection(dateRange, clearExistingSelection, select);
			this.SelectedDatesInternal.Reinitialize(newSelection);
			return true;
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000118F8 File Offset: 0x0000FAF8
		internal bool InternalSelectRange(global::Infragistics.Controls.Primitives.ISelectableItem item, bool clearExistingSelection, bool select)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem item2 = this.GetItem(item);
			global::Infragistics.DateRange? dateRange = null;
			if (item2 != null)
			{
				global::System.DateTime? activatableDate = this.GetActivatableDate(item2);
				if (activatableDate != null)
				{
					dateRange = new global::Infragistics.DateRange?(new global::Infragistics.DateRange(activatableDate.Value));
				}
			}
			else
			{
				dateRange = this.GetRangeFromItem(item);
			}
			if (dateRange == null)
			{
				return false;
			}
			dateRange.Value.Normalize();
			dateRange.Value.RemoveTime();
			if (this._pivotRange == null)
			{
				this.SelectionHost.SetPivotItem(item, false);
			}
			global::System.Collections.Generic.IList<global::System.DateTime> newSelection = this.CalculateNewSelectionRange(dateRange, clearExistingSelection, select);
			this.SelectedDatesInternal.Reinitialize(newSelection);
			return true;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x000119A2 File Offset: 0x0000FBA2
		internal bool IsDateInView(global::System.DateTime date, bool ignoreLeadingTrailingDates)
		{
			return this.IsDateInView(date, ignoreLeadingTrailingDates, this.IsMinCalendarMode && !this.AllowLeadingAndTrailingGroupActivation);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000119C0 File Offset: 0x0000FBC0
		internal bool IsDateInView(global::System.DateTime date, bool ignoreLeadingTrailingDates, bool ignoreLeadingTrailingGroups)
		{
			if (this._groups.Count > 0)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup firstGroup = this.GetFirstGroup(true, ignoreLeadingTrailingGroups);
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup lastGroup = this.GetLastGroup(true, ignoreLeadingTrailingGroups);
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

		// Token: 0x060003CA RID: 970 RVA: 0x00011A3E File Offset: 0x0000FC3E
		internal bool IsZoomFocusGroup(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group)
		{
			return group == this._zoomFocusGroup;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00011A4C File Offset: 0x0000FC4C
		internal void OnAutoGeneratedGroupsChanged()
		{
			using (new global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GroupInitializationHelper(this._groups))
			{
				this.ResolveReferenceDate();
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00011A88 File Offset: 0x0000FC88
		internal void OnGroupOffsetChanged(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group, int oldOffset, int newOffset)
		{
			this.SortGroups();
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00011A90 File Offset: 0x0000FC90
		internal bool OnMouseWheel(int delta)
		{
			global::Infragistics.Controls.Editors.CalendarCommandType commandType = (delta < 0) ? global::Infragistics.Controls.Editors.CalendarCommandType.ScrollNextGroups : global::Infragistics.Controls.Editors.CalendarCommandType.ScrollPreviousGroups;
			return this.ExecuteCommandImpl(commandType, global::System.Math.Abs(delta / 120), this);
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00011ABE File Offset: 0x0000FCBE
		internal void RaisePendingSelectionChanged()
		{
			if (this._mouseDownSnapshot == null)
			{
				return;
			}
			this._mouseDownSnapshot.ProcessEndSelection();
			this._mouseDownSnapshot = null;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x00011ADB File Offset: 0x0000FCDB
		internal void RegisterGroup(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group)
		{
			global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(group, this);
			if (group.IsGroupForSizing)
			{
				this._groupForSizing = group;
				global::Infragistics.Controls.PresentationUtilities.ReparentElement(this._templatePanel, this._groupForSizing, true);
				return;
			}
			this._groups.Add(group);
			this.SortGroups();
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00011B18 File Offset: 0x0000FD18
		internal void ResumeUpdateLayout()
		{
			this._updateLayoutSuspendCount--;
			if (this._updateLayoutSuspendCount == 0 && this._hasPendingUpdateLayout)
			{
				this._hasPendingUpdateLayout = false;
				base.UpdateLayout();
			}
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00011B45 File Offset: 0x0000FD45
		internal void SnapshotSelection()
		{
			if (this._mouseDownSnapshot != null)
			{
				return;
			}
			this._mouseDownSnapshot = new global::Infragistics.Controls.Editors.CalendarBase.SelectionSnapshot(this);
			this._mouseDownSnapshot.Initialize(this._selectedDates);
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x00011B6D File Offset: 0x0000FD6D
		internal void SuspendUpdateLayout()
		{
			this._updateLayoutSuspendCount++;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x00011B7D File Offset: 0x0000FD7D
		internal void UnregisterGroup(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group)
		{
			if (group.IsGroupForSizing)
			{
				if (group == this._groupForSizing)
				{
					this._groupForSizing = null;
					global::Infragistics.Controls.PresentationUtilities.ReparentElement(this._templatePanel, this._groupForSizing, false);
					return;
				}
			}
			else
			{
				this._groups.Remove(group);
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00011BB7 File Offset: 0x0000FDB7
		internal void UpdateLayoutHelper()
		{
			if (this._updateLayoutSuspendCount > 0)
			{
				this._hasPendingUpdateLayout = true;
				return;
			}
			base.UpdateLayout();
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x00011BD0 File Offset: 0x0000FDD0
		internal void OnSelectedStateChanged(global::System.Collections.Generic.IList<global::System.DateTime> datesSelected, global::System.Collections.Generic.IList<global::System.DateTime> datesUnselected)
		{
			if (this.IsMinCalendarMode && !this.HasOverlappingGroups())
			{
				this.UpdateSelectedState(datesSelected, true);
				this.UpdateSelectedState(datesUnselected, false);
				return;
			}
			this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.SelectionChanged);
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00011BFA File Offset: 0x0000FDFA
		internal void VerifySelectedDayStatesAsync()
		{
			if (!this._selectedStateVerifyPending && this.CurrentMode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days)
			{
				this._selectedStateVerifyPending = true;
				base.Dispatcher.BeginInvoke(new global::System.Action(this.VerifySelectedDayStates), new object[0]);
			}
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00011C34 File Offset: 0x0000FE34
		internal void VerifySelectedDayStates()
		{
			this._selectedStateVerifyPending = false;
			if (this.CurrentMode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days)
			{
				global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection selectedDateCollection = this.SelectedDatesInternal as global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection;
				this.UpdateSelectedState(selectedDateCollection, true);
				selectedDateCollection.VerifyWeekSelection();
			}
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00011C6A File Offset: 0x0000FE6A
		private bool ActivateDate(global::System.DateTime? dateValue)
		{
			return this.ActivateDate(dateValue, true);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00011C74 File Offset: 0x0000FE74
		private bool ActivateDate(global::System.DateTime? dateValue, bool useSelectionStrategy)
		{
			bool result = false;
			if (dateValue != null)
			{
				global::System.DateTime? activatableItemDate = this.GetActivatableItemDate(dateValue.Value, this.CurrentMode);
				if (activatableItemDate == null)
				{
					return false;
				}
				global::System.DateTime value = dateValue.Value;
				bool flag = true;
				if (useSelectionStrategy)
				{
					if (this._pivotRange == null)
					{
						global::System.DateTime? selectedDate = this.SelectedDate;
						global::System.DateTime? dateTime = (selectedDate != null) ? new global::System.DateTime?(selectedDate.GetValueOrDefault()) : this.ActiveDate;
						if (dateTime != null)
						{
							this._pivotRange = new global::Infragistics.DateRange?(new global::Infragistics.DateRange(dateTime.Value));
						}
						else
						{
							this._pivotRange = null;
						}
					}
					this.BringDateIntoView(value);
					global::Infragistics.Controls.Editors.Primitives.CalendarItem item = this.GetItem(value);
					if (item != null)
					{
						global::Infragistics.Controls.Primitives.SelectionStrategyBase selectionStrategyForItem = this.SelectionHost.GetSelectionStrategyForItem(item);
						if (selectionStrategyForItem != null)
						{
							global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
							bool shiftKeyDown = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
							bool controlKeyDown = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
							result = selectionStrategyForItem.SelectItemViaKeyboard(item, shiftKeyDown, controlKeyDown, false);
							flag = false;
						}
					}
				}
				if (flag)
				{
					this.ActiveDate = new global::System.DateTime?(value);
					result = (this.ActiveDate == activatableItemDate);
				}
			}
			return result;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00011DC8 File Offset: 0x0000FFC8
		internal global::System.Collections.Generic.IList<global::System.DateTime> CalculateNewSelection(global::Infragistics.DateRange? dateRange, bool clearExistingSelection, bool select)
		{
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection selectedDateCollection = this.SelectedDatesInternal as global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection;
			if (!clearExistingSelection)
			{
				list.AddRange(selectedDateCollection);
			}
			if (dateRange != null)
			{
				global::Infragistics.DateRange value = dateRange.Value;
				value.Normalize();
				value.RemoveTime();
				global::System.DateTime dateTime = value.Start;
				global::System.DateTime end = value.End;
				global::Infragistics.Controls.Editors.CalendarManager calendarManager = this.CalendarManager;
				while (dateTime <= end)
				{
					if (select)
					{
						if ((clearExistingSelection || !selectedDateCollection.IsSelected(dateTime)) && this.CanActivate(dateTime))
						{
							list.Add(dateTime);
						}
					}
					else if (!clearExistingSelection && selectedDateCollection.IsSelected(dateTime))
					{
						list.Remove(dateTime);
					}
					dateTime = calendarManager.AddDays(dateTime, 1);
				}
			}
			if (select)
			{
				this.EnsureItemsWithinMaxSelectedItemsBounds(list);
			}
			return list;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00011E80 File Offset: 0x00010080
		internal global::System.Collections.Generic.IList<global::System.DateTime> CalculateNewSelectionRange(global::Infragistics.DateRange? dateRange, bool clearExistingSelection, bool select)
		{
			global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>();
			if (this._pivotRange == null)
			{
				return list;
			}
			if (dateRange != null)
			{
				bool flag = false;
				global::System.DateTime dateTime;
				if (this._pivotRange.Value.Start <= dateRange.Value.Start)
				{
					dateTime = this._pivotRange.Value.Start;
				}
				else
				{
					flag = true;
					dateTime = dateRange.Value.Start;
				}
				global::System.DateTime t = (this._pivotRange.Value.End > dateRange.Value.End) ? this._pivotRange.Value.End : dateRange.Value.End;
				if (!clearExistingSelection)
				{
					foreach (global::System.DateTime dateTime2 in this._selectedDatesSnapshot)
					{
						if (dateTime2 < dateTime || dateTime2 > t)
						{
							list.Add(dateTime2);
						}
					}
				}
				if (select)
				{
					int offset = 1;
					if (flag)
					{
						dateTime = this._pivotRange.Value.End;
						t = dateRange.Value.Start;
						offset = -1;
					}
					global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
					global::System.DateTime? dateTime3 = new global::System.DateTime?(dateTime);
					while (dateTime3 != null && (flag || !(dateTime3 > t)) && (!flag || !(dateTime3 < t)))
					{
						global::System.DateTime? activatableItemDate = this.GetActivatableItemDate(dateTime3.Value, currentMode);
						if (activatableItemDate != null)
						{
							list.Add(activatableItemDate.Value);
						}
						dateTime3 = this._calendarManager.TryAddItemOffset(dateTime3.Value, offset, currentMode);
					}
				}
				if (select)
				{
					this.EnsureItemsWithinMaxSelectedItemsBounds(list);
				}
			}
			return list;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000120A4 File Offset: 0x000102A4
		private bool CancelPendingMouseOperations()
		{
			bool result = false;
			if (this._selectionController != null)
			{
				result = this._selectionController.CancelPendingOperations();
			}
			return result;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000120C8 File Offset: 0x000102C8
		private void ChangeCalendarMode(bool zoomOut, object parameter, object originalSource)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = null;
			global::System.DateTime? dateTime = null;
			if (parameter is global::System.DateTime)
			{
				dateTime = new global::System.DateTime?((global::System.DateTime)parameter);
			}
			if (zoomOut)
			{
				calendarItemGroup = (parameter as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup);
				if (calendarItemGroup == null && originalSource is global::System.Windows.FrameworkElement)
				{
					if (originalSource is global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)
					{
						calendarItemGroup = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup)originalSource;
					}
					else
					{
						calendarItemGroup = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup>((global::System.Windows.FrameworkElement)originalSource, null, null);
					}
				}
				if (dateTime == null && calendarItemGroup != null)
				{
					dateTime = calendarItemGroup.FirstDateOfGroup;
				}
			}
			else
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = parameter as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
				if (calendarItem == null && originalSource is global::System.Windows.FrameworkElement)
				{
					if (originalSource is global::Infragistics.Controls.Editors.Primitives.CalendarItem)
					{
						calendarItem = (global::Infragistics.Controls.Editors.Primitives.CalendarItem)originalSource;
					}
					else
					{
						calendarItem = global::Infragistics.Controls.PresentationUtilities.GetVisualAncestor<global::Infragistics.Controls.Editors.Primitives.CalendarItem>((global::System.Windows.FrameworkElement)originalSource, null, null);
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
			int num = (calendarItemGroup != null) ? calendarItemGroup.ReferenceGroupOffset : 0;
			int num2 = zoomOut ? 1 : -1;
			global::Infragistics.Controls.Editors.CalendarZoomMode calendarZoomMode = (short)num2 + this.CurrentMode;
			using (new global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GroupInitializationHelper(this._groups, false))
			{
				try
				{
					this._zoomFocusGroup = calendarItemGroup;
					this.CurrentMode = calendarZoomMode;
				}
				finally
				{
					this._zoomFocusGroup = null;
				}
				if (this.CurrentMode == calendarZoomMode && dateTime2 != null)
				{
					global::System.DateTime dateTime3 = this._calendarManager.GetGroupStartDate(dateTime2.Value, calendarZoomMode);
					if (num != 0)
					{
						dateTime3 = this._calendarManager.AddGroupOffset(dateTime3, -num, calendarZoomMode, true);
					}
					this.ResolveReferenceDate(new global::System.DateTime?(dateTime3));
				}
				this.ResolveReferenceDate();
			}
			global::System.DateTime? dateTime4 = dateTime;
			global::System.DateTime? dateTime5 = (dateTime4 != null) ? new global::System.DateTime?(dateTime4.GetValueOrDefault()) : this.ActiveDate;
			if (dateTime5 != null)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItem item = this.GetItem(dateTime5.Value);
				if (item != null)
				{
					this.ActiveDate = new global::System.DateTime?(item.StartDate);
				}
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x000122AC File Offset: 0x000104AC
		private void ClearPreferredNavInfo()
		{
			this._preferredNavColumn = -1;
			this._preferredGroupNavStart = null;
			this._preferredGroupOffset = 0;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x000122C8 File Offset: 0x000104C8
		private static object CoerceIsTabStop(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			bool? flag = new bool?(global::Infragistics.Controls.Primitives.XamlHelper.GetFocusable(calendarBase));
			if (flag != null && !flag.Value)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			if (!calendarBase.IsKeyboardFocused && calendarBase.IsKeyboardFocusWithin)
			{
				return global::Infragistics.KnownBoxes.FalseBox;
			}
			return newValue;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00012318 File Offset: 0x00010518
		private global::System.Windows.Data.Binding CreateBindingHelper(global::System.Windows.DependencyProperty dp, string propertyPropertyName)
		{
			global::System.Windows.Data.Binding binding = global::Infragistics.Controls.PresentationUtilities.CreateBinding(new global::Infragistics.Controls.BindingPart[]
			{
				new global::Infragistics.Controls.BindingPart
				{
					PathParameter = dp
				}
			});
			binding.Source = this;
			return binding;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0001234C File Offset: 0x0001054C
		private void EnsureItemsWithinMaxSelectedItemsBounds(global::System.Collections.Generic.List<global::System.DateTime> newSelection)
		{
			int maxSelectedDatesResolved = this.MaxSelectedDatesResolved;
			int num = newSelection.Count - maxSelectedDatesResolved;
			if (num > 0)
			{
				newSelection.RemoveRange(newSelection.Count - num, num);
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0001237C File Offset: 0x0001057C
		private global::System.DateTime? GetActivatableDate(global::System.DateTime? date, bool previousItem, bool includeInitialDate)
		{
			return this.GetActivatableDate(date, previousItem, includeInitialDate, true);
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00012388 File Offset: 0x00010588
		private global::System.DateTime? GetActivatableDate(global::System.DateTime? date, bool previousItem, bool includeInitialDate, bool coerceMinMax)
		{
			global::System.DateTime? dateTime = date;
			if (dateTime != null)
			{
				if (coerceMinMax)
				{
					dateTime = new global::System.DateTime?(this.ConstrainBetweenMinMaxDate(dateTime.Value));
				}
				global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
				global::System.DateTime dateTime2 = this._calendarManager.GetItemStartDate(dateTime.Value, currentMode);
				global::System.DateTime itemEndDate = this._calendarManager.GetItemEndDate(dateTime2, currentMode);
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
						dateTime = this._calendarManager.TryAddItemOffset(dateTime2, offset, currentMode);
						if (dateTime < this.MinDateResolved || dateTime > this.MaxDateResolved)
						{
							dateTime = null;
						}
						if (dateTime == null)
						{
							break;
						}
						dateTime2 = dateTime.Value;
						itemEndDate = this._calendarManager.GetItemEndDate(dateTime2, currentMode);
						dateTime = this.GetActivatableDate(dateTime.Value, itemEndDate, true);
					}
					while (dateTime == null);
				}
			}
			return dateTime;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x000124B4 File Offset: 0x000106B4
		private global::System.DateTime? GetClosestActivatableDate(global::System.DateTime itemStart, global::System.DateTime itemEnd)
		{
			global::System.DateTime? activatableDate = this.GetActivatableDate(itemStart, this.MaxDateResolved, true);
			global::System.DateTime? activatableDate2 = this.GetActivatableDate(this.MinDateResolved, itemStart, false);
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

		// Token: 0x060003E5 RID: 997 RVA: 0x00012534 File Offset: 0x00010734
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

		// Token: 0x060003E6 RID: 998 RVA: 0x000125CC File Offset: 0x000107CC
		private global::System.DateTime GetDefaultReferenceDate()
		{
			global::System.DateTime date = this.ActiveDate ?? global::System.DateTime.Today;
			return this.GetDefaultReferenceDate(date);
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00012600 File Offset: 0x00010800
		private global::System.DateTime GetDefaultReferenceDate(global::System.DateTime date)
		{
			global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
			date = this.ConstrainBetweenMinMaxDate(date);
			date = this._calendarManager.GetGroupStartDate(date, currentMode);
			date = this.ConstrainBetweenMinMaxDate(date);
			if (this._groups.Count > 0)
			{
				int referenceGroupOffset = this.GetLastGroup(false, true).ReferenceGroupOffset;
				global::System.DateTime? dateTime = this._calendarManager.TryAddGroupOffset(date, referenceGroupOffset, currentMode, true);
				if (dateTime == null || dateTime.Value > this.MaxDateResolved)
				{
					dateTime = new global::System.DateTime?(this._calendarManager.GetGroupStartDate(this.MaxDateResolved, currentMode));
					global::System.DateTime? dateTime2 = this._calendarManager.TryAddGroupOffset(dateTime.Value, -referenceGroupOffset, currentMode, true);
					if (dateTime2 == null || dateTime2.Value < this.MinDateResolved)
					{
						date = this._calendarManager.GetGroupStartDate(this.MinDateResolved, currentMode);
					}
					else
					{
						date = dateTime2.Value;
					}
				}
				int referenceGroupOffset2 = this.GetFirstGroup(false, true).ReferenceGroupOffset;
				if (referenceGroupOffset2 < 0)
				{
					global::System.DateTime? dateTime3 = this._calendarManager.TryAddGroupOffset(date, referenceGroupOffset2, currentMode, true);
					if (dateTime3 == null || dateTime3 < this.MinDateResolved)
					{
						dateTime3 = new global::System.DateTime?(this._calendarManager.GetGroupStartDate(this.MinDateResolved, currentMode));
						global::System.DateTime? dateTime4 = this._calendarManager.TryAddGroupOffset(dateTime3.Value, -referenceGroupOffset2, currentMode, true);
						if (dateTime4 == null)
						{
							date = this._calendarManager.GetGroupStartDate(this.MaxDateResolved, currentMode);
						}
						else
						{
							date = dateTime4.Value;
						}
					}
				}
				date = this.ConstrainBetweenMinMaxDate(date);
			}
			return date;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000127AB File Offset: 0x000109AB
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup GetFirstGroup(bool ignoreEmptyGroups)
		{
			return this.GetFirstGroup(ignoreEmptyGroups, !this.AllowLeadingAndTrailingGroupActivation);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000127C0 File Offset: 0x000109C0
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup GetFirstGroup(bool ignoreEmptyGroups, bool ignoreLeadingTrailingGroups)
		{
			int i = 0;
			int count = this._groups.Count;
			while (i < count)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = this._groups[i];
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

		// Token: 0x060003EA RID: 1002 RVA: 0x00012820 File Offset: 0x00010A20
		private global::Infragistics.Controls.Primitives.ISelectableItem GetFirstLastItem(global::Infragistics.Controls.Editors.Primitives.CalendarItem sourceItem, global::System.Windows.Point pt, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem[] array = new global::Infragistics.Controls.Editors.Primitives.CalendarItem[]
			{
				group.Items[0],
				group.Items[group.Items.Count - 1]
			};
			for (int i = 0; i < array.Length; i++)
			{
				global::System.Windows.Media.GeneralTransform generalTransform = array[i].TransformToVisual(this);
				global::System.Windows.Rect rect = new global::System.Windows.Rect(default(global::System.Windows.Point), new global::System.Windows.Size(array[i].ActualWidth, array[i].ActualHeight));
				rect = generalTransform.TransformBounds(rect);
				if (pt.Y >= rect.Y && pt.Y < rect.Bottom && ((i == 0 && pt.X < rect.X) || (i == 1 && pt.X >= rect.Right)))
				{
					int num = this._groups.IndexOf(group);
					if (i == 0 && sourceItem.StartDate < array[i].StartDate)
					{
						if (num > 0)
						{
							global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = this._groups[num - 1];
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
							global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup2 = this._groups[num + 1];
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

		// Token: 0x060003EB RID: 1003 RVA: 0x000129CC File Offset: 0x00010BCC
		private global::Infragistics.Controls.Editors.Primitives.CalendarItem GetItem(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			item = this.SelectionHost.TranslateItem(item);
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = item as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			if (calendarItem != null)
			{
				calendarItem = this.GetItem(calendarItem.StartDate);
			}
			return calendarItem;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00012A00 File Offset: 0x00010C00
		internal global::Infragistics.Controls.Editors.Primitives.CalendarItem GetItem(global::System.DateTime date)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group = this.GetGroup(date);
			if (group == null)
			{
				return null;
			}
			return group.GetItem(date);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00012A24 File Offset: 0x00010C24
		private global::Infragistics.DateRange? GetRangeFromItem(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItem item2 = this.GetItem(item);
			if (item2 != null)
			{
				return new global::Infragistics.DateRange?(new global::Infragistics.DateRange(item2.StartDate));
			}
			if (this.SupportsWeekSelectionMode)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber calendarWeekNumber = item as global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber;
				if (calendarWeekNumber != null)
				{
					return new global::Infragistics.DateRange?(calendarWeekNumber.Range);
				}
			}
			return null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00012A74 File Offset: 0x00010C74
		internal global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber GetWeekNumber(global::System.DateTime date)
		{
			int num;
			int weekNumberForDate = this.CalendarManager.GetWeekNumberForDate(date, this.WeekRuleInternal, this.FirstDayOfWeekInternal, out num);
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group = this.GetGroup(date);
			if (group == null)
			{
				return null;
			}
			return group.GetWeekNumber(weekNumberForDate);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00012AB0 File Offset: 0x00010CB0
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup GetLastGroup(bool ignoreEmptyGroups)
		{
			return this.GetLastGroup(ignoreEmptyGroups, !this.AllowLeadingAndTrailingGroupActivation);
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00012AC4 File Offset: 0x00010CC4
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup GetLastGroup(bool ignoreEmptyGroups, bool ignoreLeadingTrailingGroups)
		{
			for (int i = this._groups.Count - 1; i >= 0; i--)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = this._groups[i];
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

		// Token: 0x060003F1 RID: 1009 RVA: 0x00012B24 File Offset: 0x00010D24
		private bool HasOverlappingGroups()
		{
			if (this._groups != null)
			{
				global::System.DateTime? dateTime = null;
				for (int i = 0; i < this._groups.Count; i++)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = this._groups[i];
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

		// Token: 0x060003F2 RID: 1010 RVA: 0x00012BB4 File Offset: 0x00010DB4
		private bool InitializeDaysOfWeek()
		{
			if (!this._isInitialized)
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

		// Token: 0x060003F3 RID: 1011 RVA: 0x00012C24 File Offset: 0x00010E24
		private void InitializeToday()
		{
			global::Infragistics.DateRange todayRange = this.GetTodayRange();
			this._todayToken = global::Infragistics.Controls.Primitives.TimeManager.Instance.AddTimeRange(todayRange, false, new global::System.Action(this.OnCurrentDateChanged));
			base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.TodayPropertyKey, global::System.DateTime.Today);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00012C6C File Offset: 0x00010E6C
		private bool NavigateGroup(global::System.DateTime date, bool next)
		{
			global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
			int num = next ? 1 : -1;
			if (this._preferredGroupNavStart != null)
			{
				date = this._preferredGroupNavStart.Value;
				num += this._preferredGroupOffset;
			}
			global::System.DateTime? dateValue;
			for (;;)
			{
				global::System.DateTime dateTime = this.CalendarManager.AddGroupOffset(date, num, currentMode, false);
				global::System.DateTime groupStartDate = this.CalendarManager.GetGroupStartDate(dateTime, currentMode);
				global::System.DateTime groupEndDate = this.CalendarManager.GetGroupEndDate(dateTime, currentMode);
				global::System.DateTime itemEndDate = this.CalendarManager.GetItemEndDate(dateTime, currentMode);
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
				if ((next && groupEndDate >= this.MaxDateResolved) || (!next && groupStartDate <= this.MinDateResolved))
				{
					break;
				}
				num += (next ? 1 : -1);
			}
			return false;
			IL_EA:
			dateValue = this.GetActivatableDate(this.CalendarManager.GetItemStartDate(dateValue.Value, currentMode), this.CalendarManager.GetItemEndDate(dateValue.Value, currentMode), true);
			bool flag = this.ActivateDate(dateValue);
			if (flag)
			{
				this._preferredGroupOffset = num;
				this._preferredGroupNavStart = new global::System.DateTime?(date);
			}
			return flag;
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00012DB8 File Offset: 0x00010FB8
		private bool NavigateRow(global::System.DateTime date, bool next)
		{
			global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
			int itemColumnCount = global::Infragistics.Controls.Editors.CalendarManager.GetItemColumnCount(currentMode);
			int offset = (!next) ? (-itemColumnCount) : itemColumnCount;
			global::System.DateTime groupStartDate = this.CalendarManager.GetGroupStartDate(date, currentMode);
			int preferredNavColumn;
			int num;
			this.CalendarManager.GetItemRowColumn(date, currentMode, groupStartDate, false, out preferredNavColumn, out num);
			if (this._preferredNavColumn >= 0 && preferredNavColumn != this._preferredNavColumn)
			{
				date = this.CalendarManager.AddItemOffset(date, this._preferredNavColumn - preferredNavColumn, currentMode);
				preferredNavColumn = this._preferredNavColumn;
			}
			global::System.DateTime? dateValue;
			for (;;)
			{
				global::System.DateTime dateTime = this.CalendarManager.AddItemOffset(date, offset, currentMode);
				global::System.DateTime dateTime2 = this.CalendarManager.AddItemOffset(dateTime, -preferredNavColumn, currentMode);
				global::System.DateTime dateTime3 = this.CalendarManager.AddItemOffset(dateTime, itemColumnCount - preferredNavColumn - 1, currentMode);
				dateTime3 = this.CalendarManager.GetItemEndDate(dateTime3, currentMode);
				global::System.DateTime itemEndDate = this.CalendarManager.GetItemEndDate(dateTime, currentMode);
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
				if ((next && dateTime3 >= this.MaxDateResolved) || (!next && dateTime2 <= this.MinDateResolved))
				{
					break;
				}
				date = dateTime;
			}
			return false;
			IL_141:
			dateValue = this.GetActivatableDate(this.CalendarManager.GetItemStartDate(dateValue.Value, currentMode), this.CalendarManager.GetItemEndDate(dateValue.Value, currentMode), true);
			bool flag = this.ActivateDate(dateValue);
			if (flag && global::Infragistics.Controls.Editors.CalendarBase.ShouldCachePreferredNavInfo(currentMode))
			{
				this._preferredNavColumn = preferredNavColumn;
			}
			return flag;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00012F58 File Offset: 0x00011158
		internal void NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange change)
		{
			if (this._groupForSizing != null)
			{
				this._groupForSizing.OnCalendarChange(change);
			}
			try
			{
				this.SuspendUpdateLayout();
				for (int i = 0; i < this._groups.Count; i++)
				{
					this._groups[i].OnCalendarChange(change);
				}
			}
			finally
			{
				this.ResumeUpdateLayout();
			}
			if (change == global::Infragistics.Controls.Editors.CalendarChange.DisabledDatesChanged)
			{
				this.ResolveActiveDate();
				return;
			}
			if (change != global::Infragistics.Controls.Editors.CalendarChange.Resources)
			{
				return;
			}
			this.ResolveButtonStyles();
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00012FDC File Offset: 0x000111DC
		private void NotifyResourcesChanged()
		{
			if (this._notifyResourcesChangedPending || !this._isInitialized)
			{
				return;
			}
			this._notifyResourcesChangedPending = true;
			base.Dispatcher.BeginInvoke(new global::System.Action(this.ProcessNotifyResourcesChanged), new object[0]);
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00013014 File Offset: 0x00011214
		private void OnCalendarInfoChanged(global::System.Windows.Markup.XmlLanguage lang)
		{
			global::System.Globalization.CultureInfo cultureInfo = null;
			if (this._suppliedCalendar != null)
			{
				if (this._suppliedDateTimeFormat != null)
				{
					goto IL_2E;
				}
			}
			try
			{
				cultureInfo = ((lang == null) ? global::System.Globalization.CultureInfo.CurrentCulture : lang.GetEquivalentCulture());
			}
			catch (global::System.InvalidOperationException)
			{
				cultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
			}
			IL_2E:
			using (new global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GroupInitializationHelper(this._groups))
			{
				this.ClearPreferredNavInfo();
				this._calendarManager.InitializeCalendarInfo((this._suppliedCalendar != null) ? this._suppliedCalendar : cultureInfo.Calendar, (this._suppliedDateTimeFormat != null) ? this._suppliedDateTimeFormat : cultureInfo.DateTimeFormat);
				this.ResolveAllDates();
				this.InitializeDaysOfWeek();
				this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.CalendarInfoChanged);
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000130D4 File Offset: 0x000112D4
		private void OnCurrentDateChanged()
		{
			this.InitializeToday();
			this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.TodayChanged);
			this.ResolveButtonStyles();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x000130EA File Offset: 0x000112EA
		private void OnDaysOfWeekChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.CurrentMode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days)
			{
				this.ClearPreferredNavInfo();
			}
			this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.DaysOfWeekChanged);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00013101 File Offset: 0x00011301
		private void OnDisabledDatesChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.DisabledDatesChanged);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0001310C File Offset: 0x0001130C
		private static void OnLanguageChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendarBase = (global::Infragistics.Controls.Editors.CalendarBase)d;
			global::System.Windows.Markup.XmlLanguage lang = (global::System.Windows.Markup.XmlLanguage)e.NewValue;
			calendarBase.OnCalendarInfoChanged(lang);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00013134 File Offset: 0x00011334
		private void OnResourceProviderPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			string propertyName = e.PropertyName;
			if (propertyName == "ResourceVersion" || string.IsNullOrEmpty(propertyName))
			{
				this.NotifyResourcesChanged();
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00013163 File Offset: 0x00011363
		private void ProcessNotifyResourcesChanged()
		{
			this._notifyResourcesChangedPending = false;
			this.NotifyGroupChange(global::Infragistics.Controls.Editors.CalendarChange.Resources);
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00013174 File Offset: 0x00011374
		private void ProcessActiveSelectionStrategyChanged()
		{
			if (this._shouldProcessActiveSelectionChanged == false)
			{
				this._shouldProcessActiveSelectionChanged = new bool?(true);
				return;
			}
			global::Infragistics.Controls.Primitives.SelectionStrategyBase selectionStrategyBase = (this._activeStrategy == null) ? null : (global::Infragistics.CoreUtilities.GetWeakReferenceTargetSafe(this._activeStrategy) as global::Infragistics.Controls.Primitives.SelectionStrategyBase);
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

		// Token: 0x06000400 RID: 1024 RVA: 0x00013244 File Offset: 0x00011444
		private void ResolveAllDates()
		{
			using (new global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GroupInitializationHelper(this._groups))
			{
				this.ResolveActiveDate();
				this.ResolveReferenceDate();
				this.ResolveMeasureDate();
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x0001328C File Offset: 0x0001148C
		private void ResolveButtonStyles()
		{
			global::Infragistics.Controls.Editors.CalendarResourceProvider resourceProviderResolved = this.ResourceProviderResolved;
			if (resourceProviderResolved == null)
			{
				this.ResolveResourceProvider();
				return;
			}
			global::System.Windows.Style style = this.ScrollNextRepeatButtonStyle;
			if (style == null)
			{
				style = (resourceProviderResolved[global::Infragistics.Controls.Editors.CalendarResourceId.ScrollNextRepeatButtonStyle] as global::System.Windows.Style);
			}
			this.ScrollNextRepeatButtonStyleResolved = style;
			style = this.ScrollPreviousRepeatButtonStyle;
			if (style == null)
			{
				style = (resourceProviderResolved[global::Infragistics.Controls.Editors.CalendarResourceId.ScrollPreviousRepeatButtonStyle] as global::System.Windows.Style);
			}
			this.ScrollPreviousRepeatButtonStyleResolved = style;
			style = this.TodayButtonStyle;
			if (style == null)
			{
				style = (resourceProviderResolved[global::Infragistics.Controls.Editors.CalendarResourceId.TodayButtonStyle] as global::System.Windows.Style);
			}
			this.TodayButtonStyleResolved = style;
			string format = global::Infragistics.Controls.Editors.CalendarUtilities.GetString("TodayButtonCaption") ?? "{0:d}";
			this.TodayButtonCaption = string.Format(global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat, format, new object[]
			{
				global::System.DateTime.Today
			});
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00013348 File Offset: 0x00011548
		private void ResolveResourceProvider()
		{
			global::Infragistics.Controls.Editors.CalendarResourceProvider calendarResourceProvider = this.ResourceProvider;
			if (calendarResourceProvider == null)
			{
				calendarResourceProvider = this.DefaultResourceProvider;
				if (calendarResourceProvider == null)
				{
					calendarResourceProvider = new global::Infragistics.Controls.Editors.CalendarResourceProvider();
					this._defaultResourceProvider = calendarResourceProvider;
				}
			}
			this.ResourceProviderResolved = calendarResourceProvider;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00013380 File Offset: 0x00011580
		private bool ScrollGroups(int numberOfGroups)
		{
			if (this._groups.Count == 0)
			{
				return false;
			}
			global::System.DateTime dateTime = this.ReferenceDate ?? this.GetDefaultReferenceDate();
			global::System.DateTime minDateResolved = this.MinDateResolved;
			global::System.DateTime maxDateResolved = this.MaxDateResolved;
			global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
			dateTime = this._calendarManager.AddGroupOffset(dateTime, numberOfGroups, currentMode, true);
			if (dateTime > maxDateResolved)
			{
				global::System.DateTime dateTime2 = this._calendarManager.GetGroupStartDate(maxDateResolved, currentMode);
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup lastGroup = this.LastGroup;
				if (this.LastGroup != null)
				{
					dateTime2 = this._calendarManager.AddGroupOffset(dateTime2, -lastGroup.ReferenceGroupOffset, currentMode, true);
				}
				if (dateTime > dateTime2)
				{
					dateTime = dateTime2;
				}
			}
			if (dateTime < minDateResolved)
			{
				dateTime = minDateResolved;
			}
			global::System.DateTime? referenceDate = this.ReferenceDate;
			this.ResolveReferenceDate(new global::System.DateTime?(dateTime));
			return !object.Equals(referenceDate, this.ReferenceDate);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001346C File Offset: 0x0001166C
		private static bool ShouldCachePreferredNavInfo(global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			switch (mode)
			{
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
				return true;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				return false;
			default:
				return false;
			}
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000134C0 File Offset: 0x000116C0
		private void SortGroups()
		{
			global::System.Comparison<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup> comparison = (global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup g1, global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup g2) => g1.ReferenceGroupOffset.CompareTo(g2.ReferenceGroupOffset);
			global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup> comparer = global::Infragistics.CoreUtilities.CreateComparer<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup>(comparison);
			global::Infragistics.CoreUtilities.SortMergeGeneric<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup>(this._groups, comparer);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00013500 File Offset: 0x00011700
		private bool ToggleActiveDateSelection(bool shiftKeyDown, bool ctlKeyDown)
		{
			global::System.DateTime value = this.ActiveDate.Value;
			global::Infragistics.Controls.Editors.Primitives.CalendarItem item = this.GetItem(value);
			if (item != null)
			{
				global::Infragistics.Controls.Primitives.SelectionStrategyBase selectionStrategyForItem = this.SelectionHost.GetSelectionStrategyForItem(item);
				if (selectionStrategyForItem != null && (selectionStrategyForItem.IsMultiSelect || selectionStrategyForItem.IsSingleSelect))
				{
					return selectionStrategyForItem.SelectItemViaKeyboard(item, shiftKeyDown, ctlKeyDown, true);
				}
			}
			return false;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00013554 File Offset: 0x00011754
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
					global::Infragistics.Controls.Editors.Primitives.CalendarItem item = this.GetItem(date);
					if (item != null)
					{
						item.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectedPropertyKey, value);
						item.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsSelectedDatesPropertyKey, value);
					}
					i++;
				}
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x000135AD File Offset: 0x000117AD
		private static bool ValidatePositiveInt(object value)
		{
			return value is int && (int)value > 0;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x000135C4 File Offset: 0x000117C4
		internal void VerifyWeekSelectionMode()
		{
			if (global::Infragistics.CoreUtilities.Antirecursion.InProgress(this, "VerifyWeekSelectionMode"))
			{
				return;
			}
			global::Infragistics.CoreUtilities.Antirecursion.Enter(this, "VerifyWeekSelectionMode", true);
			try
			{
				bool flag = false;
				global::Infragistics.Collections.DateCollection selectedDatesInternal = this.SelectedDatesInternal;
				int count = selectedDatesInternal.Count;
				if (this.SupportsWeekSelectionMode && this.IsMinCalendarMode)
				{
					if (count > 8)
					{
						flag = true;
					}
					else if (count > 6)
					{
						flag = (this._pivotRange != null && this._pivotRange.Value.End > this._pivotRange.Value.Start);
					}
				}
				if (flag)
				{
					selectedDatesInternal.Sort();
					global::System.DayOfWeek? firstDayOfWeekInternal = this.FirstDayOfWeekInternal;
					global::System.DateTime dateTime = selectedDatesInternal[0];
					int num;
					global::System.DateTime firstDayOfWeekForDate = this.CalendarManager.GetFirstDayOfWeekForDate(dateTime, firstDayOfWeekInternal, out num);
					global::System.DateTime dateTime2 = selectedDatesInternal[count - 1];
					global::System.DateTime dateTime3 = this.CalendarManager.GetFirstDayOfWeekForDate(dateTime2, firstDayOfWeekInternal, out num);
					dateTime3 = this._calendarManager.AddDays(dateTime3, 6 + num);
					if (dateTime > firstDayOfWeekForDate)
					{
						global::System.DateTime dateTime4 = this._calendarManager.AddDays(dateTime, -1);
						if (dateTime4 >= firstDayOfWeekForDate)
						{
							selectedDatesInternal.AddRange(new global::Infragistics.DateRange(firstDayOfWeekForDate, dateTime4), true);
						}
					}
					if (dateTime2 < dateTime3)
					{
						global::System.DateTime dateTime5 = this._calendarManager.AddDays(dateTime2, 1);
						if (dateTime5 <= dateTime3)
						{
							selectedDatesInternal.AddRange(new global::Infragistics.DateRange(dateTime5, dateTime3), true);
						}
					}
				}
			}
			finally
			{
				global::Infragistics.CoreUtilities.Antirecursion.Exit(this, "VerifyWeekSelectionMode");
			}
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00013760 File Offset: 0x00011960
		protected virtual void OnSelectedDatesChanged(global::Infragistics.Controls.Editors.SelectedDatesChangedEventArgs args)
		{
			if (this.SelectedDatesChanged != null)
			{
				this.SelectedDatesChanged(this, args);
			}
			if (this.SelectedDatesInternalChanged != null)
			{
				this.SelectedDatesInternalChanged(this, args);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0001378C File Offset: 0x0001198C
		internal void RaiseSelectedDatesChanged(global::System.Collections.Generic.IList<global::System.DateTime> unselected, global::System.Collections.Generic.IList<global::System.DateTime> selected, bool force)
		{
			if (this._mouseDownSnapshot == null || force)
			{
				this.OnSelectedDatesChanged(new global::Infragistics.Controls.Editors.SelectedDatesChangedEventArgs(unselected, selected));
				return;
			}
			if (this.SelectedDatesInternalChanged != null)
			{
				this.SelectedDatesInternalChanged(this, new global::Infragistics.Controls.Editors.SelectedDatesChangedEventArgs(unselected, selected));
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600040C RID: 1036 RVA: 0x000137C4 File Offset: 0x000119C4
		// (remove) Token: 0x0600040D RID: 1037 RVA: 0x000137FC File Offset: 0x000119FC
		public event global::System.EventHandler<global::Infragistics.Controls.Editors.SelectedDatesChangedEventArgs> SelectedDatesChanged;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600040E RID: 1038 RVA: 0x00013834 File Offset: 0x00011A34
		// (remove) Token: 0x0600040F RID: 1039 RVA: 0x0001386C File Offset: 0x00011A6C
		internal event global::System.EventHandler<global::Infragistics.Controls.Editors.SelectedDatesChangedEventArgs> SelectedDatesInternalChanged;

		// Token: 0x06000410 RID: 1040 RVA: 0x000138A1 File Offset: 0x00011AA1
		private void OnSelectionCommitted(global::System.EventArgs args)
		{
			if (this.SelectionCommitted != null)
			{
				this.SelectionCommitted(this, args);
			}
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x000138B8 File Offset: 0x00011AB8
		internal void RaiseSelectionCommitted(global::System.EventArgs args)
		{
			this.OnSelectionCommitted(args);
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000412 RID: 1042 RVA: 0x000138C4 File Offset: 0x00011AC4
		// (remove) Token: 0x06000413 RID: 1043 RVA: 0x000138FC File Offset: 0x00011AFC
		internal event global::System.EventHandler SelectionCommitted;

		// Token: 0x06000414 RID: 1044 RVA: 0x00013934 File Offset: 0x00011B34
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			this.ResolveCurrentMode();
			this.ResolveAllDates();
			global::Infragistics.Controls.PresentationUtilities.ReparentElement(this._templatePanel, this._groupForSizing, false);
			global::Infragistics.Controls.PresentationUtilities.ReparentElement(this._rootPanel, this._templatePanel, false);
			if (this._rootPanel != null)
			{
				foreach (object obj in this._rootPanel.Children)
				{
					global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
					global::Infragistics.Controls.Editors.Primitives.ICalendarElement calendarElement = uielement as global::Infragistics.Controls.Editors.Primitives.ICalendarElement;
					if (calendarElement != null)
					{
						global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(uielement, null);
					}
				}
			}
			this._rootPanel = (base.GetTemplateChild("RootPanel") as global::System.Windows.Controls.Panel);
			if (this._templatePanel == null)
			{
				this._templatePanel = new global::Infragistics.Controls.Editors.CalendarBase.MeasurePanel();
				this._templatePanel.Tag = global::Infragistics.Controls.Editors.CalendarBase.MeasurePanelId;
				this._templatePanel.Width = 0.0;
				this._templatePanel.Height = 0.0;
				this._templatePanel.IsHitTestVisible = false;
				this._templatePanel.RenderTransform = new global::System.Windows.Media.TranslateTransform
				{
					X = -1000.0,
					Y = -1000.0
				};
				this._templatePanel.Clip = new global::System.Windows.Media.RectangleGeometry();
			}
			global::Infragistics.Controls.PresentationUtilities.ReparentElement(this._rootPanel, this._templatePanel, true);
			this._groupForSizing = null;
			if (this._groups != null)
			{
				for (int i = this._groups.Count - 1; i >= 0; i--)
				{
					if (!global::Infragistics.Controls.PresentationUtilities.IsAncestorOf(this, this._groups[i]))
					{
						this._groups.RemoveAt(i);
					}
				}
			}
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00013AEC File Offset: 0x00011CEC
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.AutomationPeers.CalendarBaseAutomationPeer(this);
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00013AF4 File Offset: 0x00011CF4
		protected override void OnGotKeyboardFocus(global::System.Windows.Input.KeyboardFocusChangedEventArgs e)
		{
			base.OnGotKeyboardFocus(e);
			global::System.Windows.IInputElement newFocus = e.NewFocus;
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00013B06 File Offset: 0x00011D06
		protected override void OnIsKeyboardFocusedChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			base.OnIsKeyboardFocusedChanged(e);
			base.CoerceValue(global::System.Windows.Input.KeyboardNavigation.IsTabStopProperty);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00013B1C File Offset: 0x00011D1C
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
			base.SetValue(global::Infragistics.Controls.Editors.CalendarBase.IsSelectionActivePropertyKey, global::Infragistics.KnownBoxes.FromValue(flag));
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00013B88 File Offset: 0x00011D88
		protected override void OnKeyDown(global::System.Windows.Input.KeyEventArgs e)
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(this);
			if (calendar == null)
			{
				return;
			}
			global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
			bool flag = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Alt) != global::System.Windows.Input.ModifierKeys.None;
			if (flag)
			{
				return;
			}
			bool flag2 = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
			bool flag3 = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
			global::Infragistics.Controls.Editors.CalendarCommandType? calendarCommandType = null;
			global::System.Windows.Input.Key key = e.Key;
			if (key != global::System.Windows.Input.Key.Return)
			{
				switch (key)
				{
				case global::System.Windows.Input.Key.Space:
					if (!flag3 && !flag2 && !flag && this.ActiveDate != null && this.CurrentMode != this.MinCalendarModeResolved)
					{
						calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.ZoomInCalendarMode);
					}
					else if (!flag2 && !flag)
					{
						calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.ToggleActiveDateSelection);
					}
					break;
				case global::System.Windows.Input.Key.Prior:
					calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.PreviousGroup);
					break;
				case global::System.Windows.Input.Key.Next:
					calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.NextGroup);
					break;
				case global::System.Windows.Input.Key.End:
					if (flag3)
					{
						calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.LastItemOfLastGroup);
					}
					else
					{
						calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.LastItemOfGroup);
					}
					break;
				case global::System.Windows.Input.Key.Home:
					if (flag3)
					{
						calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.FirstItemOfFirstGroup);
					}
					else
					{
						calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.FirstItemOfGroup);
					}
					break;
				case global::System.Windows.Input.Key.Left:
					calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.PreviousItem);
					break;
				case global::System.Windows.Input.Key.Up:
					calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.PreviousItemRow);
					break;
				case global::System.Windows.Input.Key.Right:
					calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.NextItem);
					break;
				case global::System.Windows.Input.Key.Down:
					calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.NextItemRow);
					break;
				default:
					switch (key)
					{
					case global::System.Windows.Input.Key.Add:
						if (flag3)
						{
							calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.ZoomOutCalendarMode);
						}
						break;
					case global::System.Windows.Input.Key.Subtract:
						if (flag3)
						{
							calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.ZoomInCalendarMode);
						}
						break;
					}
					break;
				}
			}
			else if (flag3)
			{
				calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.ZoomOutCalendarMode);
			}
			else
			{
				calendarCommandType = new global::Infragistics.Controls.Editors.CalendarCommandType?(global::Infragistics.Controls.Editors.CalendarCommandType.ZoomInCalendarMode);
			}
			if (calendarCommandType != null)
			{
				e.Handled = calendar.ExecuteCommand(calendarCommandType.Value, null, this);
			}
			base.OnKeyDown(e);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00013D57 File Offset: 0x00011F57
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
			if (this._isInitialized)
			{
				return;
			}
			this._isInitialized = true;
			this.ResolveResourceProvider();
			this.ResolveAllDates();
			this.InitializeDaysOfWeek();
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00013D83 File Offset: 0x00011F83
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			this.OnLostMouseCaptureImpl(e);
			base.OnLostMouseCapture(e);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00013D93 File Offset: 0x00011F93
		private void OnLostMouseCaptureImpl(global::System.Windows.Input.MouseEventArgs e)
		{
			this.RaisePendingSelectionChanged();
			if (e.OriginalSource == this || !base.IsMouseCaptured)
			{
				this.CancelPendingMouseOperations();
			}
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00013DB3 File Offset: 0x00011FB3
		protected override void OnMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonDown(e);
			this.OnMouseLeftButtonDownImpl(e);
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00013DC3 File Offset: 0x00011FC3
		private void OnMouseLeftButtonDownImpl(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			if (this._selectionController != null && !e.Handled)
			{
				this.SnapshotSelection();
				this._selectionController.OnMouseLeftButtonDown(e);
				if (!e.Handled)
				{
					this.RaisePendingSelectionChanged();
				}
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00013DF5 File Offset: 0x00011FF5
		protected override void OnMouseMove(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			this.OnMouseMoveImpl(e);
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00013E05 File Offset: 0x00012005
		private void OnMouseMoveImpl(global::System.Windows.Input.MouseEventArgs e)
		{
			if (this._selectionController != null && !e.Handled)
			{
				this._selectionController.OnMouseMove(e);
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x00013E23 File Offset: 0x00012023
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.OnMouseLeftButtonUpImpl(e);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00013E33 File Offset: 0x00012033
		private void OnMouseLeftButtonUpImpl(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			this.RaisePendingSelectionChanged();
			if (this._selectionController != null && !e.Handled)
			{
				this._selectionController.OnMouseLeftButtonUp(e);
				bool handled = e.Handled;
			}
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00013E5E File Offset: 0x0001205E
		protected override void OnMouseWheel(global::System.Windows.Input.MouseWheelEventArgs e)
		{
			base.OnMouseWheel(e);
			if (!e.Handled)
			{
				e.Handled = this.OnMouseWheel(e.Delta);
			}
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00013E84 File Offset: 0x00012084
		protected override void OnPreviewMouseLeftButtonDown(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnPreviewMouseLeftButtonDown(e);
			if (!e.Handled && !base.IsKeyboardFocused && !base.IsKeyboardFocusWithin && base.Focusable && base.IsEnabled && !global::Infragistics.Controls.PresentationUtilities.IsAncestorOf(this, global::System.Windows.Input.Keyboard.FocusedElement as global::System.Windows.Media.Visual))
			{
				base.Focus();
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00013EDC File Offset: 0x000120DC
		bool global::Infragistics.Controls.Primitives.ISelectionHost.ActivateItem(global::Infragistics.Controls.Primitives.ISelectableItem item, bool preventScrollItemIntoView)
		{
			if (item is global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber)
			{
				return true;
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItem item2 = this.GetItem(item);
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
			this.ActiveDate = new global::System.DateTime?(value);
			item2 = this.GetItem(value);
			return item2 != null && item2.IsActive;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00013F42 File Offset: 0x00012142
		void global::Infragistics.Controls.Primitives.ISelectionHost.ClearSnapshot()
		{
			this._selectedDatesSnapshot.Clear();
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00013F50 File Offset: 0x00012150
		bool global::Infragistics.Controls.Primitives.ISelectionHost.DeselectItem(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			return !this.IsNavigationMode && this.InternalSelectItem(item, false, false);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00013F74 File Offset: 0x00012174
		bool global::Infragistics.Controls.Primitives.ISelectionHost.DeselectRange(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			if (this.IsNavigationMode)
			{
				return false;
			}
			bool result = this.InternalSelectRange(item, false, false);
			this.VerifyWeekSelectionMode();
			return result;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00013F9C File Offset: 0x0001219C
		void global::Infragistics.Controls.Primitives.ISelectionHost.DoAutoScrollHorizontal(global::Infragistics.Controls.Primitives.ISelectableItem item, global::Infragistics.Controls.Primitives.ScrollDirection direction, global::Infragistics.Controls.Primitives.ScrollSpeed speed)
		{
			if (direction == global::Infragistics.Controls.Primitives.ScrollDirection.Decrement)
			{
				this.ExecuteCommand(global::Infragistics.Controls.Editors.CalendarCommandType.ScrollPreviousGroup, null, null);
				return;
			}
			this.ExecuteCommand(global::Infragistics.Controls.Editors.CalendarCommandType.ScrollNextGroup, null, null);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00013FB9 File Offset: 0x000121B9
		void global::Infragistics.Controls.Primitives.ISelectionHost.DoAutoScrollVertical(global::Infragistics.Controls.Primitives.ISelectableItem item, global::Infragistics.Controls.Primitives.ScrollDirection direction, global::Infragistics.Controls.Primitives.ScrollSpeed speed)
		{
			if (direction == global::Infragistics.Controls.Primitives.ScrollDirection.Decrement)
			{
				this.ExecuteCommand(global::Infragistics.Controls.Editors.CalendarCommandType.ScrollPreviousGroup, null, null);
				return;
			}
			this.ExecuteCommand(global::Infragistics.Controls.Editors.CalendarCommandType.ScrollNextGroup, null, null);
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00013FD6 File Offset: 0x000121D6
		void global::Infragistics.Controls.Primitives.ISelectionHost.EnterSnakingMode(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00013FD8 File Offset: 0x000121D8
		global::Infragistics.Controls.Primitives.AutoScrollInfo global::Infragistics.Controls.Primitives.ISelectionHost.GetAutoScrollInfo(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			global::Infragistics.Controls.Editors.CalendarStates currentState = this.CurrentState;
			global::Infragistics.Controls.Primitives.SelectionStrategyBase selectionStrategyForItem = this.SelectionHost.GetSelectionStrategyForItem(item);
			bool flag = selectionStrategyForItem != null && selectionStrategyForItem.IsSingleSelect && !selectionStrategyForItem.IsMultiSelect;
			bool flag2 = flag && (currentState & global::Infragistics.Controls.Editors.CalendarStates.MinDateInView) == (global::Infragistics.Controls.Editors.CalendarStates)0L;
			bool flag3 = flag && (currentState & global::Infragistics.Controls.Editors.CalendarStates.MaxDateInView) == (global::Infragistics.Controls.Editors.CalendarStates)0L;
			return new global::Infragistics.Controls.Primitives.AutoScrollInfo(this, flag2, flag2, flag3, flag3)
			{
				ScrollOrientation = global::Infragistics.Controls.Primitives.ScrollOrientation.Horizontal
			};
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00014048 File Offset: 0x00012248
		global::Infragistics.Controls.Primitives.ISelectableItem global::Infragistics.Controls.Primitives.ISelectionHost.GetNearestCompatibleItem(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			if (item == null)
			{
				return null;
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = item as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			global::System.Windows.Point position = e.GetPosition(this);
			global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem2 = global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPoint<global::Infragistics.Controls.Editors.Primitives.CalendarItem>(this, position, null);
			if (calendarItem2 != null)
			{
				global::Infragistics.Controls.Primitives.ISelectableItem selectableItem = ((global::Infragistics.Controls.Primitives.ISelectableElement)calendarItem2).SelectableItem;
				if (!this.SelectionHost.IsItemSelectableWithCurrentSelection(selectableItem))
				{
					return null;
				}
				if (!calendarItem2.IsEnabled && this._pivotRange != null)
				{
					global::System.DateTime? activatableDate;
					if (this._pivotRange.Value.End > calendarItem2.StartDate)
					{
						activatableDate = this.GetActivatableDate(calendarItem2.EndDate, this._pivotRange.Value.End, true);
					}
					else
					{
						activatableDate = this.GetActivatableDate(this._pivotRange.Value.Start, calendarItem2.StartDate, false);
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
				if (this.SupportsWeekSelectionMode)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber visualDescendantFromPoint = global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPoint<global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber>(this, position, null);
					if (visualDescendantFromPoint != null)
					{
						return visualDescendantFromPoint;
					}
				}
				global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup visualDescendantFromPoint2 = global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPoint<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup>(this, position, null);
				if (calendarItem != null && visualDescendantFromPoint2 != null && visualDescendantFromPoint2.Items.Count > 0)
				{
					return this.GetFirstLastItem(calendarItem, position, visualDescendantFromPoint2);
				}
				return null;
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00014174 File Offset: 0x00012374
		global::Infragistics.Controls.Primitives.ISelectableItem global::Infragistics.Controls.Primitives.ISelectionHost.GetPivotItem(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			if (this._pivotRange == null)
			{
				return null;
			}
			if (this._pivotRange.Value.Start == this._pivotRange.Value.End)
			{
				return this.GetItem(this._pivotRange.Value.Start);
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber weekNumber = this.GetWeekNumber(this._pivotRange.Value.Start);
			if (weekNumber == null)
			{
				weekNumber = this.GetWeekNumber(this._pivotRange.Value.End);
			}
			return weekNumber;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00014218 File Offset: 0x00012418
		global::Infragistics.Controls.Primitives.SelectionStrategyBase global::Infragistics.Controls.Primitives.ISelectionHost.GetSelectionStrategyForItem(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			global::Infragistics.Controls.Primitives.SelectionType currentSelectionTypeResolved = this.CurrentSelectionTypeResolved;
			global::Infragistics.Controls.Primitives.SelectionStrategyBase result;
			if (currentSelectionTypeResolved == global::Infragistics.Controls.Primitives.SelectionType.Single && !(this._selectionStrategy is global::Infragistics.Controls.Primitives.SelectionStrategySingle))
			{
				result = (this._selectionStrategy = new global::Infragistics.Controls.Editors.CalendarBase.CustomSingleSelectionStrategy(this));
			}
			else
			{
				result = (this._selectionStrategy = global::Infragistics.Controls.Primitives.SelectionStrategyBase.GetSelectionStrategy(currentSelectionTypeResolved, this.SelectionHost, this._selectionStrategy));
			}
			return result;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00014270 File Offset: 0x00012470
		bool global::Infragistics.Controls.Primitives.ISelectionHost.IsItemSelectableWithCurrentSelection(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			if (this._pivotRange != null && item != null && this._pivotRange.Value.Start == this._pivotRange.Value.End)
			{
				return item is global::Infragistics.Controls.Editors.Primitives.CalendarItem;
			}
			return item is global::Infragistics.Controls.Editors.Primitives.CalendarItem || (this.SupportsWeekSelectionMode && item is global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000142E4 File Offset: 0x000124E4
		bool global::Infragistics.Controls.Primitives.ISelectionHost.IsMaxSelectedItemsReached(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			if (this.CurrentMode != this.MinCalendarModeResolved)
			{
				return false;
			}
			int maxSelectedDatesResolved = this.MaxSelectedDatesResolved;
			return this.SelectedDatesInternal.Count >= maxSelectedDatesResolved;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00014319 File Offset: 0x00012519
		private void OnActiveSelectionStrategyChanged(object sender, global::System.EventArgs e)
		{
			this.OnActiveSelectionStrategyChanged(this._selectionController.ActiveStrategy);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0001432C File Offset: 0x0001252C
		private void OnActiveSelectionStrategyChanged(global::Infragistics.Controls.Primitives.SelectionStrategyBase strategy)
		{
			this._activeStrategy = ((strategy == null) ? null : new global::System.WeakReference(strategy));
			this.ProcessActiveSelectionStrategyChanged();
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00014346 File Offset: 0x00012546
		void global::Infragistics.Controls.Primitives.ISelectionHost.OnDragEnd(bool canceled)
		{
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00014348 File Offset: 0x00012548
		void global::Infragistics.Controls.Primitives.ISelectionHost.OnDragMove(global::System.Windows.Input.MouseEventArgs e)
		{
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0001434A File Offset: 0x0001254A
		bool global::Infragistics.Controls.Primitives.ISelectionHost.OnDragStart(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
		{
			return false;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00014350 File Offset: 0x00012550
		void global::Infragistics.Controls.Primitives.ISelectionHost.OnMouseUp(global::System.Windows.Input.MouseEventArgs e)
		{
			global::System.Windows.Input.MouseButtonEventArgs mouseButtonEventArgs = e as global::System.Windows.Input.MouseButtonEventArgs;
			if (mouseButtonEventArgs != null && mouseButtonEventArgs.ChangedButton == global::System.Windows.Input.MouseButton.Left)
			{
				global::System.Windows.Point position = e.GetPosition(this);
				global::Infragistics.Controls.Editors.Primitives.CalendarItem visualDescendantFromPoint = global::Infragistics.Controls.PresentationUtilities.GetVisualDescendantFromPoint<global::Infragistics.Controls.Editors.Primitives.CalendarItem>(this, position, null);
				if (visualDescendantFromPoint != null)
				{
					if (this.CurrentMode > this.MinCalendarModeResolved)
					{
						this.ExecuteCommandImpl(global::Infragistics.Controls.Editors.CalendarCommandType.ZoomInCalendarMode, visualDescendantFromPoint, visualDescendantFromPoint);
						return;
					}
					this.RaiseSelectionCommitted(new global::System.Windows.RoutedEventArgs());
				}
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000143A8 File Offset: 0x000125A8
		global::System.Windows.FrameworkElement global::Infragistics.Controls.Primitives.ISelectionHost.RootElement
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000143AC File Offset: 0x000125AC
		bool global::Infragistics.Controls.Primitives.ISelectionHost.SelectItem(global::Infragistics.Controls.Primitives.ISelectableItem item, bool clearExistingSelection)
		{
			if (this.IsNavigationMode)
			{
				return this.SelectionHost.ActivateItem(item, false);
			}
			return this.InternalSelectItem(item, clearExistingSelection, true);
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000143DC File Offset: 0x000125DC
		bool global::Infragistics.Controls.Primitives.ISelectionHost.SelectRange(global::Infragistics.Controls.Primitives.ISelectableItem item, bool clearExistingSelection)
		{
			if (this.IsNavigationMode)
			{
				return false;
			}
			bool result = this.InternalSelectRange(item, clearExistingSelection, true);
			this.VerifyWeekSelectionMode();
			return result;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00014404 File Offset: 0x00012604
		void global::Infragistics.Controls.Primitives.ISelectionHost.SetPivotItem(global::Infragistics.Controls.Primitives.ISelectableItem item, bool isRangeSelect)
		{
			global::Infragistics.DateRange? dateRange = this._pivotRange;
			if (item == null)
			{
				dateRange = null;
			}
			else if (dateRange != null)
			{
				if (dateRange.Value.Start == dateRange.Value.End)
				{
					if (!(item is global::Infragistics.Controls.Editors.Primitives.CalendarItem))
					{
						dateRange = null;
					}
				}
				else if (!(item is global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber))
				{
					dateRange = null;
				}
			}
			if (isRangeSelect && dateRange != null)
			{
				return;
			}
			this._pivotRange = this.GetRangeFromItem(item);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0001448F File Offset: 0x0001268F
		void global::Infragistics.Controls.Primitives.ISelectionHost.SnapshotSelection(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			if (this.IsNavigationMode)
			{
				return;
			}
			this._selectedDatesSnapshot.ReInitialize(this.SelectedDatesInternal);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000144AB File Offset: 0x000126AB
		global::Infragistics.Controls.Primitives.ISelectableItem global::Infragistics.Controls.Primitives.ISelectionHost.TranslateItem(global::Infragistics.Controls.Primitives.ISelectableItem item)
		{
			if (!(item is global::Infragistics.Controls.Editors.Primitives.CalendarItem) && !(item is global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber))
			{
				return null;
			}
			return item;
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x000144C0 File Offset: 0x000126C0
		object global::Infragistics.ICommandTarget.GetParameter(global::Infragistics.Controls.CommandSource source)
		{
			if (!(source is global::Infragistics.Controls.Editors.Primitives.CalendarCommandSource))
			{
				return null;
			}
			return this;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x000144CD File Offset: 0x000126CD
		bool global::Infragistics.ICommandTarget.SupportsCommand(global::System.Windows.Input.ICommand command)
		{
			return command is global::Infragistics.Controls.Editors.Primitives.CalendarCommand;
		}

		// Token: 0x040001C8 RID: 456
		private const string PartRootPanel = "RootPanel";

		// Token: 0x040001C9 RID: 457
		internal const global::Infragistics.Controls.DayOfWeekFlags DefaultWorkdays = global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday;

		// Token: 0x040001CA RID: 458
		internal const int AllDays = 127;

		// Token: 0x040001CB RID: 459
		private global::System.Windows.Controls.Panel _rootPanel;

		// Token: 0x040001CC RID: 460
		private global::System.Windows.Controls.Canvas _templatePanel;

		// Token: 0x040001CD RID: 461
		private global::Infragistics.Controls.Editors.CalendarZoomMode _minCalendarModeResolved;

		// Token: 0x040001CE RID: 462
		private global::Infragistics.Controls.DayOfWeekFlags _disabledDaysOfWeekInternal;

		// Token: 0x040001CF RID: 463
		private global::System.Windows.Visibility _disabledDaysOfWeekVisibilityInternal;

		// Token: 0x040001D0 RID: 464
		private global::System.DayOfWeek? _firstDayOfWeekResolved;

		// Token: 0x040001D1 RID: 465
		private global::System.Globalization.CalendarWeekRule? _weekRuleResolved;

		// Token: 0x040001D2 RID: 466
		private int _maxSelectedDatesInternal;

		// Token: 0x040001D3 RID: 467
		private global::Infragistics.Controls.DayOfWeekFlags _workDaysInternal = global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday;

		// Token: 0x040001D4 RID: 468
		private bool _selectedStateVerifyPending;

		// Token: 0x040001D5 RID: 469
		internal static readonly object MeasurePanelId = new object();

		// Token: 0x040001D6 RID: 470
		private global::Infragistics.Controls.Editors.CalendarManager _calendarManager;

		// Token: 0x040001D7 RID: 471
		private global::System.Globalization.Calendar _suppliedCalendar;

		// Token: 0x040001D8 RID: 472
		private global::System.Globalization.DateTimeFormatInfo _suppliedDateTimeFormat;

		// Token: 0x040001D9 RID: 473
		private global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection _selectedDates;

		// Token: 0x040001DA RID: 474
		private global::Infragistics.Controls.Primitives.SelectionStrategyBase _selectionStrategy;

		// Token: 0x040001DB RID: 475
		private global::Infragistics.Collections.ObservableCollectionExtended<global::System.DateTime> _selectedDatesSnapshot;

		// Token: 0x040001DC RID: 476
		internal global::Infragistics.DateRange? _pivotRange;

		// Token: 0x040001DD RID: 477
		private global::Infragistics.Collections.ObservableCollectionExtended<global::System.DayOfWeek> _daysOfWeekInternal;

		// Token: 0x040001DE RID: 478
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::System.DayOfWeek> _daysOfWeek;

		// Token: 0x040001DF RID: 479
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup> _groups;

		// Token: 0x040001E0 RID: 480
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup _groupForSizing;

		// Token: 0x040001E1 RID: 481
		private global::Infragistics.Controls.Editors.Primitives.CalendarDateRangeCollection _disabledDates;

		// Token: 0x040001E2 RID: 482
		private global::Infragistics.Controls.Editors.CalendarResourceProvider _defaultResourceProvider;

		// Token: 0x040001E3 RID: 483
		private bool? _shouldBringActiveDateIntoView;

		// Token: 0x040001E4 RID: 484
		private int _preferredNavColumn = -1;

		// Token: 0x040001E5 RID: 485
		private int _preferredGroupOffset;

		// Token: 0x040001E6 RID: 486
		private global::System.DateTime? _preferredGroupNavStart;

		// Token: 0x040001E7 RID: 487
		private global::Infragistics.Controls.Editors.CalendarBase.SelectionSnapshot _mouseDownSnapshot;

		// Token: 0x040001E8 RID: 488
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup _zoomFocusGroup;

		// Token: 0x040001E9 RID: 489
		private bool _suppressBringActiveDateInView;

		// Token: 0x040001EA RID: 490
		private bool? _shouldProcessActiveSelectionChanged = null;

		// Token: 0x040001EB RID: 491
		private global::System.WeakReference _activeStrategy;

		// Token: 0x040001EC RID: 492
		private bool _preventFocusActiveItem;

		// Token: 0x040001ED RID: 493
		private global::Infragistics.DateRange _allowableDateRange = new global::Infragistics.DateRange(global::System.DateTime.MinValue, global::System.DateTime.MaxValue.Date);

		// Token: 0x040001EE RID: 494
		private global::Infragistics.Controls.Primitives.SelectionController _selectionController;

		// Token: 0x040001EF RID: 495
		private bool _notifyResourcesChangedPending;

		// Token: 0x040001F0 RID: 496
		private bool _notifySelectionActiveChangePending;

		// Token: 0x040001F1 RID: 497
		private bool _isInitialized;

		// Token: 0x040001F2 RID: 498
		private object _todayToken;

		// Token: 0x040001F3 RID: 499
		private int _updateLayoutSuspendCount;

		// Token: 0x040001F4 RID: 500
		private bool _hasPendingUpdateLayout;

		// Token: 0x040001F5 RID: 501
		public static readonly global::System.Windows.DependencyProperty ActiveDateProperty = global::Infragistics.DependencyPropertyUtilities.Register("ActiveDate", typeof(global::System.DateTime?), typeof(global::Infragistics.Controls.Editors.CalendarBase), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnActiveDateChanged));

		// Token: 0x040001F6 RID: 502
		public static readonly global::System.Windows.DependencyProperty AllowLeadingAndTrailingGroupActivationProperty = global::Infragistics.DependencyPropertyUtilities.Register("AllowLeadingAndTrailingGroupActivation", typeof(bool), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040001F7 RID: 503
		public static readonly global::System.Windows.DependencyProperty AutoAdjustDimensionsProperty = global::Infragistics.DependencyPropertyUtilities.Register("AutoAdjustDimensions", typeof(bool), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040001F8 RID: 504
		public static readonly global::System.Windows.DependencyProperty CalendarDayStyleProperty = global::Infragistics.DependencyPropertyUtilities.Register("CalendarDayStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnItemStyleChanged)));

		// Token: 0x040001F9 RID: 505
		public static readonly global::System.Windows.DependencyProperty CalendarItemStyleProperty = global::Infragistics.DependencyPropertyUtilities.Register("CalendarItemStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnItemStyleChanged)));

		// Token: 0x040001FA RID: 506
		public static readonly global::System.Windows.DependencyProperty CurrentModeProperty = global::Infragistics.DependencyPropertyUtilities.Register("CurrentMode", typeof(global::Infragistics.Controls.Editors.CalendarZoomMode), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Editors.CalendarZoomMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnCurrentModeChanged)));

		// Token: 0x040001FB RID: 507
		public static readonly global::System.Windows.DependencyProperty DayOfWeekHeaderFormatProperty = global::Infragistics.DependencyPropertyUtilities.Register("DayOfWeekHeaderFormat", typeof(global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.Controls.Editors.DayOfWeekHeaderFormat.TwoCharacters, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnDayOfWeekHeaderFormatChanged)));

		// Token: 0x040001FC RID: 508
		public static readonly global::System.Windows.DependencyProperty DayOfWeekHeaderVisibilityProperty = global::Infragistics.DependencyPropertyUtilities.Register("DayOfWeekHeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnDayOfWeekHeaderVisibilityChanged)));

		// Token: 0x040001FD RID: 509
		public static readonly global::System.Windows.DependencyProperty DimensionsProperty = global::Infragistics.DependencyPropertyUtilities.Register("Dimensions", typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDimensions), typeof(global::Infragistics.Controls.Editors.CalendarBase), new global::System.Windows.PropertyMetadata(new global::Infragistics.Controls.Editors.Primitives.CalendarDimensions(1, 1), global::Infragistics.DependencyPropertyUtilities.CreateTypeConverterCallbackWrapper<global::Infragistics.Controls.Editors.Primitives.CalendarDimensions>(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnDimensionsChanged))));

		// Token: 0x040001FE RID: 510
		private static readonly global::System.Windows.DependencyPropertyKey IsSelectionActivePropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("IsSelectionActive", typeof(bool), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.KnownBoxes.FalseBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnIsSelectionActiveChange));

		// Token: 0x040001FF RID: 511
		public static readonly global::System.Windows.DependencyProperty IsSelectionActiveProperty = global::Infragistics.Controls.Editors.CalendarBase.IsSelectionActivePropertyKey.DependencyProperty;

		// Token: 0x04000200 RID: 512
		public static readonly global::System.Windows.DependencyProperty LeadingAndTrailingDatesVisibilityProperty = global::Infragistics.DependencyPropertyUtilities.Register("LeadingAndTrailingDatesVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnLeadingAndTrailingDatesVisibilityChanged)));

		// Token: 0x04000201 RID: 513
		private static readonly global::System.Windows.DependencyPropertyKey MaxDateResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("MaxDateResolved", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::System.DateTime.MaxValue.Date, null);

		// Token: 0x04000202 RID: 514
		public static readonly global::System.Windows.DependencyProperty MaxDateResolvedProperty = global::Infragistics.Controls.Editors.CalendarBase.MaxDateResolvedPropertyKey.DependencyProperty;

		// Token: 0x04000203 RID: 515
		private static readonly global::System.Windows.DependencyPropertyKey MinCalendarModeResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("MinCalendarModeResolved", typeof(global::Infragistics.Controls.Editors.CalendarZoomMode), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.Controls.Editors.CalendarZoomMode.Days, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnMinCalendarModeResolvedChanged));

		// Token: 0x04000204 RID: 516
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public static readonly global::System.Windows.DependencyProperty MinCalendarModeResolvedProperty = global::Infragistics.Controls.Editors.CalendarBase.MinCalendarModeResolvedPropertyKey.DependencyProperty;

		// Token: 0x04000205 RID: 517
		private static readonly global::System.Windows.DependencyPropertyKey MinDateResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("MinDateResolved", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::System.DateTime.MinValue, null);

		// Token: 0x04000206 RID: 518
		public static readonly global::System.Windows.DependencyProperty MinDateResolvedProperty = global::Infragistics.Controls.Editors.CalendarBase.MinDateResolvedPropertyKey.DependencyProperty;

		// Token: 0x04000207 RID: 519
		public static readonly global::System.Windows.DependencyProperty ReferenceDateProperty = global::Infragistics.DependencyPropertyUtilities.Register("ReferenceDate", typeof(global::System.DateTime?), typeof(global::Infragistics.Controls.Editors.CalendarBase), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnReferenceDateChanged));

		// Token: 0x04000208 RID: 520
		public static readonly global::System.Windows.DependencyProperty ResourceProviderProperty = global::Infragistics.DependencyPropertyUtilities.Register("ResourceProvider", typeof(global::Infragistics.Controls.Editors.CalendarResourceProvider), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnResourceProviderChanged)));

		// Token: 0x04000209 RID: 521
		private static readonly global::System.Windows.DependencyPropertyKey ResourceProviderResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ResourceProviderResolved", typeof(global::Infragistics.Controls.Editors.CalendarResourceProvider), typeof(global::Infragistics.Controls.Editors.CalendarBase), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnResourceProviderResolvedChanged));

		// Token: 0x0400020A RID: 522
		public static readonly global::System.Windows.DependencyProperty ResourceProviderResolvedProperty = global::Infragistics.Controls.Editors.CalendarBase.ResourceProviderResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400020B RID: 523
		public static readonly global::System.Windows.DependencyProperty ScrollButtonVisibilityProperty = global::Infragistics.DependencyPropertyUtilities.Register("ScrollButtonVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.VisibilityVisibleBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnScrollButtonVisibilityChanged)));

		// Token: 0x0400020C RID: 524
		public static readonly global::System.Windows.DependencyProperty ScrollNextRepeatButtonStyleProperty = global::Infragistics.DependencyPropertyUtilities.Register("ScrollNextRepeatButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnButtonStyleChanged)));

		// Token: 0x0400020D RID: 525
		private static readonly global::System.Windows.DependencyPropertyKey ScrollNextRepeatButtonStyleResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ScrollNextRepeatButtonStyleResolved", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.CalendarBase), null, null);

		// Token: 0x0400020E RID: 526
		public static readonly global::System.Windows.DependencyProperty ScrollNextRepeatButtonStyleResolvedProperty = global::Infragistics.Controls.Editors.CalendarBase.ScrollNextRepeatButtonStyleResolvedPropertyKey.DependencyProperty;

		// Token: 0x0400020F RID: 527
		public static readonly global::System.Windows.DependencyProperty ScrollPreviousRepeatButtonStyleProperty = global::Infragistics.DependencyPropertyUtilities.Register("ScrollPreviousRepeatButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnButtonStyleChanged)));

		// Token: 0x04000210 RID: 528
		private static readonly global::System.Windows.DependencyPropertyKey ScrollPreviousRepeatButtonStyleResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ScrollPreviousRepeatButtonStyleResolved", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.CalendarBase), null, null);

		// Token: 0x04000211 RID: 529
		public static readonly global::System.Windows.DependencyProperty ScrollPreviousRepeatButtonStyleResolvedProperty = global::Infragistics.Controls.Editors.CalendarBase.ScrollPreviousRepeatButtonStyleResolvedPropertyKey.DependencyProperty;

		// Token: 0x04000212 RID: 530
		public static readonly global::System.Windows.DependencyProperty SelectedDateProperty = global::Infragistics.DependencyPropertyUtilities.Register("SelectedDate", typeof(global::System.DateTime?), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnSelectedDateChanged), global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.BindsTwoWayByDefault | global::Infragistics.DependencyPropertyUtilities.MetadataOptionFlags.Journal));

		// Token: 0x04000213 RID: 531
		private static readonly global::System.Windows.DependencyPropertyKey TodayButtonCaptionPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("TodayButtonCaption", typeof(string), typeof(global::Infragistics.Controls.Editors.CalendarBase), null, null);

		// Token: 0x04000214 RID: 532
		public static readonly global::System.Windows.DependencyProperty TodayButtonCaptionProperty = global::Infragistics.Controls.Editors.CalendarBase.TodayButtonCaptionPropertyKey.DependencyProperty;

		// Token: 0x04000215 RID: 533
		public static readonly global::System.Windows.DependencyProperty TodayButtonStyleProperty = global::Infragistics.DependencyPropertyUtilities.Register("TodayButtonStyle", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnButtonStyleChanged)));

		// Token: 0x04000216 RID: 534
		private static readonly global::System.Windows.DependencyPropertyKey TodayButtonStyleResolvedPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("TodayButtonStyleResolved", typeof(global::System.Windows.Style), typeof(global::Infragistics.Controls.Editors.CalendarBase), null, null);

		// Token: 0x04000217 RID: 535
		public static readonly global::System.Windows.DependencyProperty TodayButtonStyleResolvedProperty = global::Infragistics.Controls.Editors.CalendarBase.TodayButtonStyleResolvedPropertyKey.DependencyProperty;

		// Token: 0x04000218 RID: 536
		public static readonly global::System.Windows.DependencyProperty WeekNumberVisibilityProperty = global::Infragistics.DependencyPropertyUtilities.Register("WeekNumberVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(global::Infragistics.KnownBoxes.VisibilityCollapsedBox, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnWeekNumberVisibilityChanged)));

		// Token: 0x04000219 RID: 537
		private static readonly global::System.Windows.DependencyPropertyKey TodayPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("Today", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::System.DateTime.Today, null);

		// Token: 0x0400021A RID: 538
		public static readonly global::System.Windows.DependencyProperty TodayProperty = global::Infragistics.Controls.Editors.CalendarBase.TodayPropertyKey.DependencyProperty;

		// Token: 0x0400021B RID: 539
		internal static readonly global::System.Windows.DependencyProperty MeasureDateProperty = global::Infragistics.DependencyPropertyUtilities.Register("MeasureDate", typeof(global::System.DateTime), typeof(global::Infragistics.Controls.Editors.CalendarBase), global::Infragistics.DependencyPropertyUtilities.CreateMetadata(new global::System.DateTime(2008, 9, 1), new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnMeasureDateChanged)));

		// Token: 0x0400021C RID: 540
		internal static readonly global::System.Windows.DependencyPropertyKey CalendarPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterAttachedReadOnly("Calendar", typeof(global::Infragistics.Controls.Editors.CalendarBase), typeof(global::Infragistics.Controls.Editors.CalendarBase), null, new global::System.Windows.PropertyChangedCallback(global::Infragistics.Controls.Editors.CalendarBase.OnCalendarChanged));

		// Token: 0x0400021D RID: 541
		public static readonly global::System.Windows.DependencyProperty CalendarProperty = global::Infragistics.Controls.Editors.CalendarBase.CalendarPropertyKey.DependencyProperty;

		// Token: 0x02000050 RID: 80
		private class CustomSingleSelectionStrategy : global::Infragistics.Controls.Primitives.SelectionStrategySingle
		{
			// Token: 0x06000441 RID: 1089 RVA: 0x000144D8 File Offset: 0x000126D8
			internal CustomSingleSelectionStrategy(global::Infragistics.Controls.Primitives.ISelectionHost host) : base(host)
			{
				base.AllowToggle = false;
			}

			// Token: 0x170000E4 RID: 228
			// (get) Token: 0x06000442 RID: 1090 RVA: 0x000144E8 File Offset: 0x000126E8
			protected override int AutoScrollHorizontalIntervalMax
			{
				get
				{
					return 250;
				}
			}

			// Token: 0x170000E5 RID: 229
			// (get) Token: 0x06000443 RID: 1091 RVA: 0x000144EF File Offset: 0x000126EF
			protected override int AutoScrollHorizontalIntervalMin
			{
				get
				{
					return 250;
				}
			}

			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x06000444 RID: 1092 RVA: 0x000144F6 File Offset: 0x000126F6
			protected override int AutoScrollVerticalIntervalMax
			{
				get
				{
					return 250;
				}
			}

			// Token: 0x170000E7 RID: 231
			// (get) Token: 0x06000445 RID: 1093 RVA: 0x000144FD File Offset: 0x000126FD
			protected override int AutoScrollVerticalIntervalMin
			{
				get
				{
					return 250;
				}
			}

			// Token: 0x06000446 RID: 1094 RVA: 0x00014504 File Offset: 0x00012704
			public override void OnMouseLeftButtonUp(global::Infragistics.Controls.Primitives.ISelectableItem item, global::System.Windows.Input.MouseEventArgs e)
			{
				global::Infragistics.Controls.Editors.CalendarBase calendarBase = base.SelectionHost as global::Infragistics.Controls.Editors.CalendarBase;
				if (calendarBase != null)
				{
					calendarBase._shouldProcessActiveSelectionChanged = new bool?(false);
				}
				try
				{
					base.OnMouseLeftButtonUp(item, e);
				}
				finally
				{
					if (calendarBase != null)
					{
						bool flag = calendarBase._shouldProcessActiveSelectionChanged == true;
						calendarBase._shouldProcessActiveSelectionChanged = null;
						if (flag)
						{
							calendarBase.ProcessActiveSelectionStrategyChanged();
						}
					}
				}
			}

			// Token: 0x170000E8 RID: 232
			// (get) Token: 0x06000447 RID: 1095 RVA: 0x0001457C File Offset: 0x0001277C
			protected override int PixelThresholdForHorizontalAutoScroll
			{
				get
				{
					return 5;
				}
			}

			// Token: 0x170000E9 RID: 233
			// (get) Token: 0x06000448 RID: 1096 RVA: 0x0001457F File Offset: 0x0001277F
			protected override int PixelThresholdForVerticalAutoScroll
			{
				get
				{
					return 5;
				}
			}

			// Token: 0x04000223 RID: 547
			private const int ScrollInterval = 250;
		}

		// Token: 0x02000051 RID: 81
		private class SelectionSnapshot
		{
			// Token: 0x06000449 RID: 1097 RVA: 0x00014582 File Offset: 0x00012782
			internal SelectionSnapshot(global::Infragistics.Controls.Editors.CalendarBase owner)
			{
				this._owner = owner;
			}

			// Token: 0x0600044A RID: 1098 RVA: 0x00014591 File Offset: 0x00012791
			internal void Initialize(global::Infragistics.Collections.DateCollection currentSelection)
			{
				this._selectedDates = new global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection(this._owner);
				this._selectedDates.Reinitialize(currentSelection);
				this._selectedDates.Sort();
			}

			// Token: 0x170000EA RID: 234
			// (get) Token: 0x0600044B RID: 1099 RVA: 0x000145BB File Offset: 0x000127BB
			internal global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection SelectedDates
			{
				get
				{
					return this._selectedDates;
				}
			}

			// Token: 0x0600044C RID: 1100 RVA: 0x000145C4 File Offset: 0x000127C4
			internal void ProcessEndSelection()
			{
				if (this._selectedDates.Count == this._owner.SelectedDates.Count)
				{
					bool flag = true;
					int i = 0;
					int count = this._owner.SelectedDates.Count;
					while (i < count)
					{
						if (this._owner.SelectedDates[i] != this._selectedDates[i])
						{
							flag = false;
							break;
						}
						i++;
					}
					if (flag)
					{
						return;
					}
				}
				global::Infragistics.Collections.DateCollection dateCollection = new global::Infragistics.Collections.DateCollection();
				dateCollection.Reinitialize(new global::System.Collections.Generic.List<global::System.DateTime>(this._selectedDates));
				global::System.Collections.Generic.HashSet<global::System.DateTime> hashSet = new global::System.Collections.Generic.HashSet<global::System.DateTime>(this._owner.SelectedDates);
				global::System.Collections.Generic.List<global::System.DateTime> list = new global::System.Collections.Generic.List<global::System.DateTime>(dateCollection.Count);
				foreach (global::System.DateTime item in dateCollection)
				{
					if (hashSet.Contains(item))
					{
						hashSet.Remove(item);
					}
					else
					{
						list.Add(item);
					}
				}
				if (list.Count == 0 && hashSet.Count == 0)
				{
					return;
				}
				this._owner.SelectedDates.Reinitialize(dateCollection);
				global::System.Collections.Generic.List<global::System.DateTime> list2 = new global::System.Collections.Generic.List<global::System.DateTime>(hashSet);
				list2.Sort();
				this._owner._mouseDownSnapshot = null;
				this._owner.RaiseSelectedDatesChanged(list2, list, true);
			}

			// Token: 0x04000224 RID: 548
			private global::Infragistics.Controls.Editors.CalendarBase _owner;

			// Token: 0x04000225 RID: 549
			private global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection _selectedDates;
		}

		// Token: 0x02000052 RID: 82
		internal class MeasurePanel : global::System.Windows.Controls.Canvas
		{
			// Token: 0x0600044D RID: 1101 RVA: 0x0001471C File Offset: 0x0001291C
			protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
			{
				return new global::Infragistics.Controls.Editors.CalendarBase.MeasurePanel.MeasurePanelAutomationPeer(this);
			}

			// Token: 0x02000053 RID: 83
			private class MeasurePanelAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
			{
				// Token: 0x0600044F RID: 1103 RVA: 0x0001472C File Offset: 0x0001292C
				internal MeasurePanelAutomationPeer(global::Infragistics.Controls.Editors.CalendarBase.MeasurePanel owner) : base(owner)
				{
				}

				// Token: 0x06000450 RID: 1104 RVA: 0x00014735 File Offset: 0x00012935
				protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
				{
					return new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
				}

				// Token: 0x06000451 RID: 1105 RVA: 0x0001473C File Offset: 0x0001293C
				protected override bool IsOffscreenCore()
				{
					return true;
				}
			}
		}
	}
}
