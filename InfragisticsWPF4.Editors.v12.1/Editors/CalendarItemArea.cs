using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;
using Infragistics.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000032 RID: 50
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarItemArea : global::System.Windows.Controls.Control, global::Infragistics.Windows.Editors.ICalendarItemArea
	{
		// Token: 0x0600032D RID: 813 RVA: 0x0000C864 File Offset: 0x0000AA64
		static CalendarItemArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemArea)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemArea.OnCurrentCalendarModeChanged)));
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000CA58 File Offset: 0x0000AC58
		public CalendarItemArea()
		{
			this._itemsInternal = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.CalendarItem>();
			this._items = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.CalendarItem>(this._itemsInternal);
			this._weekNumbersInternal = new global::Infragistics.Collections.ObservableCollectionExtended<int>();
			this._weekNumbers = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int>(this._weekNumbersInternal);
			this.InitializeCalendarModeSettings(global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(this));
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemAreaPropertyKey, this);
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000CABB File Offset: 0x0000ACBB
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return this._itemsInternal.GetEnumerator();
			}
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		protected override void OnInitialized(global::System.EventArgs e)
		{
			this.InitializeCalendarModeSettings(this.CurrentCalendarMode);
			this.InitializeItems();
			base.OnInitialized(e);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = base.TemplatedParent as global::Infragistics.Windows.Editors.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				this.InitializeGroup(calendarItemGroup);
			}
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000CB0E File Offset: 0x0000AD0E
		internal global::Infragistics.Windows.Editors.CalendarDateRange? GroupRange
		{
			get
			{
				return this._groupRange;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000CB16 File Offset: 0x0000AD16
		internal global::Infragistics.Windows.Editors.CalendarManager CalendarManager
		{
			get
			{
				if (this._group == null)
				{
					return global::Infragistics.Windows.Editors.CalendarManager.CurrentCulture;
				}
				return this._group.CalendarManager;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000CB31 File Offset: 0x0000AD31
		internal global::Infragistics.Windows.Editors.CalendarMode CurrentCalendarMode
		{
			get
			{
				return global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(this);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000CB3C File Offset: 0x0000AD3C
		private static object CoerceDayOfWeekHeaderVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = (global::Infragistics.Windows.Editors.CalendarItemArea)d;
			if (calendarItemArea.CurrentCalendarMode != global::Infragistics.Windows.Editors.CalendarMode.Days || calendarItemArea.Items.Count == 0)
			{
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			return newValue;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000CB7E File Offset: 0x0000AD7E
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility DayOfWeekHeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.DayOfWeekHeaderVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.DayOfWeekHeaderVisibilityProperty, value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000CB91 File Offset: 0x0000AD91
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.CalendarItem> Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000339 RID: 825 RVA: 0x0000CB99 File Offset: 0x0000AD99
		[global::System.ComponentModel.Browsable(false)]
		public int FirstItemColumnOffset
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemColumnOffsetProperty);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000CBAB File Offset: 0x0000ADAB
		[global::System.ComponentModel.Browsable(false)]
		public int FirstItemRowOffset
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemRowOffsetProperty);
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000CBBD File Offset: 0x0000ADBD
		public static global::Infragistics.Windows.Editors.CalendarItemArea GetItemArea(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Editors.CalendarItemArea)d.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemAreaProperty);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000CBCF File Offset: 0x0000ADCF
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int ItemColumns
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemColumnsProperty);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000CBE1 File Offset: 0x0000ADE1
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int ItemRows
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemRowsProperty);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0000CBF3 File Offset: 0x0000ADF3
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Browsable(false)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int> WeekNumbers
		{
			get
			{
				return this._weekNumbers;
			}
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		private static object CoerceWeekNumberVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = (global::Infragistics.Windows.Editors.CalendarItemArea)d;
			if (calendarItemArea.CurrentCalendarMode != global::Infragistics.Windows.Editors.CalendarMode.Days || calendarItemArea.Items.Count == 0)
			{
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			return newValue;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0000CC2C File Offset: 0x0000AE2C
		// (set) Token: 0x06000341 RID: 833 RVA: 0x0000CC3E File Offset: 0x0000AE3E
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility WeekNumberVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.WeekNumberVisibilityProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.WeekNumberVisibilityProperty, value);
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000CC54 File Offset: 0x0000AE54
		private void InitializeCalendarModeSettings(global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemRowsPropertyKey, 6);
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemColumnsPropertyKey, this.CalendarManager.VisibleDayCount);
				return;
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
			{
				int num = 3;
				if (this._group != null && this._group.FirstDateOfGroup != null)
				{
					global::System.DateTime value = this._group.FirstDateOfGroup.Value;
					global::System.Globalization.Calendar calendar = this.CalendarManager.Calendar;
					int year = calendar.GetYear(value);
					num = (calendar.GetMonthsInYear(year) + 3) / 4;
				}
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemRowsPropertyKey, num);
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemColumnsPropertyKey, 4);
				return;
			}
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemRowsPropertyKey, 3);
				base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemColumnsPropertyKey, 4);
				return;
			default:
				return;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000CD48 File Offset: 0x0000AF48
		private void InitializeFirstItemOffset()
		{
			int num = 0;
			int num2 = 0;
			if (this._items.Count > 0)
			{
				this.CalendarManager.GetItemRowColumn(this.Items[0].StartDate, this.CurrentCalendarMode, this._group.FirstDateOfGroup.Value, this._group.ShowLeadingDates, out num, out num2);
			}
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemColumnOffsetPropertyKey, num);
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemRowOffsetPropertyKey, num2);
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000CDD0 File Offset: 0x0000AFD0
		private void InitializeItems()
		{
			if (!base.IsInitialized)
			{
				return;
			}
			if (this._group == null)
			{
				return;
			}
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
			global::Infragistics.Windows.Editors.CalendarManager calendarManager = this.CalendarManager;
			global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
			global::System.DateTime? firstDateOfGroup = this._group.FirstDateOfGroup;
			global::System.DateTime? lastDateOfGroup = this._group.LastDateOfGroup;
			global::System.DateTime[] array;
			if (firstDateOfGroup != null && lastDateOfGroup != null)
			{
				global::System.DateTime minDate = (monthCalendar != null) ? monthCalendar.MinDate : global::System.DateTime.MinValue;
				global::System.DateTime maxDate = (monthCalendar != null) ? monthCalendar.MaxDate : global::System.DateTime.MaxValue;
				array = calendarManager.GetItemDates(firstDateOfGroup.Value, currentCalendarMode, this._group.ShowLeadingDates, this._group.ShowTrailingDates, minDate, maxDate);
				this._groupRange = new global::Infragistics.Windows.Editors.CalendarDateRange?(new global::Infragistics.Windows.Editors.CalendarDateRange(firstDateOfGroup.Value, lastDateOfGroup.Value));
			}
			else
			{
				array = new global::System.DateTime[0];
				this._groupRange = null;
			}
			bool flag = currentCalendarMode == global::Infragistics.Windows.Editors.CalendarMode.Days;
			global::Infragistics.Windows.Editors.CalendarItem[] array2 = new global::Infragistics.Windows.Editors.CalendarItem[array.Length];
			global::System.DateTime today = global::System.DateTime.Today;
			global::System.DateTime? dateTime;
			global::Infragistics.Controls.DayOfWeekFlags days;
			bool flag2;
			global::System.Windows.Style style;
			global::System.Windows.Controls.StyleSelector styleSelector;
			if (monthCalendar != null)
			{
				dateTime = monthCalendar.ActiveDate;
				days = monthCalendar.Workdays;
				flag2 = monthCalendar.IsMinCalendarMode;
				style = (global::System.Windows.Style)monthCalendar.GetValue(flag ? global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDayStyleProperty : global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarItemStyleProperty);
				styleSelector = (global::System.Windows.Controls.StyleSelector)monthCalendar.GetValue(flag ? global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarDayStyleSelectorProperty : global::Infragistics.Windows.Editors.XamMonthCalendar.CalendarItemStyleSelectorProperty);
			}
			else
			{
				dateTime = null;
				days = (global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday);
				flag2 = true;
				style = null;
				styleSelector = null;
			}
			global::Infragistics.Windows.Editors.CalendarItem[] array3 = new global::Infragistics.Windows.Editors.CalendarItem[this._itemsInternal.Count];
			this._itemsInternal.CopyTo(array3, 0);
			int num = 0;
			bool flag3 = array3.Length > 0 && array3[0] is global::Infragistics.Windows.Editors.CalendarDay;
			bool flag4 = !flag3 && array3.Length > 0;
			if (this._group != null && this._group.IsGroupForSizing)
			{
				flag4 = (flag3 = false);
			}
			for (int i = 0; i < array.Length; i++)
			{
				global::System.DateTime dateTime2 = array[i];
				bool flag5 = true;
				global::System.DateTime dateTime3;
				bool flag6;
				global::Infragistics.Windows.Editors.CalendarItem calendarItem;
				if (flag)
				{
					dateTime3 = dateTime2;
					flag6 = (dateTime2 == today);
					if (flag3)
					{
						calendarItem = (array2[i] = array3[num]);
						num++;
						flag3 = (num < array3.Length);
						calendarItem.Recycle(dateTime2, dateTime3);
					}
					else
					{
						calendarItem = (array2[i] = new global::Infragistics.Windows.Editors.CalendarDay(dateTime2, this._group));
						((global::System.ComponentModel.ISupportInitialize)calendarItem).BeginInit();
					}
					if (!global::Infragistics.Controls.CalendarHelper.IsSet(days, calendarManager.Calendar.GetDayOfWeek(dateTime2)))
					{
						calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarDay.IsWorkdayPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
					}
				}
				else
				{
					dateTime3 = calendarManager.GetItemEndDate(dateTime2, currentCalendarMode);
					if (flag4)
					{
						calendarItem = (array2[i] = array3[num]);
						num++;
						flag4 = (num < array3.Length);
						calendarItem.Recycle(dateTime2, dateTime3);
					}
					else
					{
						calendarItem = (array2[i] = new global::Infragistics.Windows.Editors.CalendarItem(dateTime2, dateTime3, this._group));
						((global::System.ComponentModel.ISupportInitialize)calendarItem).BeginInit();
					}
					flag6 = (dateTime2 <= today && today <= dateTime3);
				}
				if (flag6)
				{
					if (flag2)
					{
						calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsTodayPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsTodayPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				bool flag7 = dateTime2 <= dateTime && dateTime <= dateTime3;
				if (monthCalendar != null)
				{
					flag5 = monthCalendar.CanActivate(dateTime2, dateTime3, currentCalendarMode);
					if (flag5)
					{
						bool flag8 = monthCalendar.SelectedDates.ContainsSelection(dateTime2, dateTime3);
						bool flag9;
						if (flag2)
						{
							flag9 = flag8;
						}
						else
						{
							flag9 = flag7;
						}
						if (flag9)
						{
							calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectedPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						}
						if (flag8)
						{
							calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsSelectedDatesPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
						}
					}
				}
				if (!flag5)
				{
					calendarItem.SetValue(global::System.Windows.UIElement.IsEnabledProperty, global::Infragistics.KnownBoxes.FalseBox);
				}
				if (dateTime2 > lastDateOfGroup || dateTime3 < firstDateOfGroup)
				{
					calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsLeadingOrTrailingItemPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
				if (flag7)
				{
					calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
				}
			}
			this._itemsInternal.Clear();
			this._itemsInternal.AddRange(array2);
			for (int j = num; j < array3.Length; j++)
			{
				global::Infragistics.Windows.Editors.CalendarItem child = array3[j];
				base.RemoveLogicalChild(child);
			}
			for (int k = num; k < array2.Length; k++)
			{
				global::Infragistics.Windows.Editors.CalendarItem calendarItem2 = array2[k];
				base.AddLogicalChild(calendarItem2);
				((global::System.ComponentModel.ISupportInitialize)calendarItem2).EndInit();
			}
			foreach (global::Infragistics.Windows.Editors.CalendarItem calendarItem3 in array2)
			{
				global::System.Windows.Style style2;
				if (styleSelector != null)
				{
					style2 = styleSelector.SelectStyle(calendarItem3, calendarItem3);
				}
				else
				{
					style2 = null;
				}
				global::System.Windows.Style style3;
				if ((style3 = style2) == null)
				{
					style3 = (style ?? global::System.Windows.DependencyProperty.UnsetValue);
				}
				object obj = style3;
				if (calendarItem3.ReadLocalValue(global::System.Windows.FrameworkElement.StyleProperty) != obj)
				{
					calendarItem3.SetValue(global::System.Windows.FrameworkElement.StyleProperty, obj);
				}
			}
			if (this._group != null && this._group.IsGroupForSizing && array2.Length > 1)
			{
				double num2 = -1.0;
				global::System.Windows.Size availableSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
				global::Infragistics.Windows.Editors.CalendarItem calendarItem4 = null;
				foreach (global::Infragistics.Windows.Editors.CalendarItem calendarItem5 in array2)
				{
					calendarItem5.Measure(availableSize);
					global::System.Windows.Size desiredSize = calendarItem5.DesiredSize;
					double num3 = desiredSize.Width * desiredSize.Height;
					if (num3 > num2)
					{
						calendarItem4 = calendarItem5;
						num2 = num3;
					}
				}
				this._itemsInternal.ReInitialize(new global::Infragistics.Windows.Editors.CalendarItem[]
				{
					calendarItem4
				});
				foreach (global::Infragistics.Windows.Editors.CalendarItem calendarItem6 in array2)
				{
					if (calendarItem6 != calendarItem4)
					{
						base.RemoveLogicalChild(calendarItem6);
					}
				}
			}
			if (monthCalendar != null && (base.IsKeyboardFocusWithin || monthCalendar.IsKeyboardFocused))
			{
				monthCalendar.FocusActiveItemWithDelay();
			}
			this.InitializeFirstItemOffset();
			this.InitializeWeekNumbers();
			base.CoerceValue(global::Infragistics.Windows.Editors.CalendarItemArea.WeekNumberVisibilityProperty);
			base.CoerceValue(global::Infragistics.Windows.Editors.CalendarItemArea.DayOfWeekHeaderVisibilityProperty);
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000D408 File Offset: 0x0000B608
		private void InitializeWeekNumbers()
		{
			global::Infragistics.Windows.Editors.CalendarManager calendarManager = this.CalendarManager;
			global::System.DateTime? dateTime = (this._group != null) ? this._group.FirstDateOfGroup : null;
			bool flag = this.CurrentCalendarMode == global::Infragistics.Windows.Editors.CalendarMode.Days && dateTime != null && this.Items.Count > 0;
			if (!flag && this._weekNumbersInternal.Count == 0)
			{
				return;
			}
			this._weekNumbersInternal.Clear();
			if (flag)
			{
				global::System.DateTime dateTime2 = this._group.FirstDate;
				global::System.DateTime lastDate = this._group.LastDate;
				int num;
				int num2;
				calendarManager.GetItemRowColumn(dateTime2, global::Infragistics.Windows.Editors.CalendarMode.Days, dateTime.Value, this._group.ShowLeadingDates, out num, out num2);
				int offset = 7 - num;
				for (int i = 0; i < 6; i++)
				{
					int weekNumberForDate = calendarManager.GetWeekNumberForDate(dateTime2);
					if (i > 0 && this._weekNumbersInternal[i - 1] == weekNumberForDate)
					{
						return;
					}
					this._weekNumbersInternal.Add(weekNumberForDate);
					dateTime2 = calendarManager.AddItemOffset(dateTime2, offset, global::Infragistics.Windows.Editors.CalendarMode.Days);
					offset = 7;
					if (dateTime2 > this._group.LastDate)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000D520 File Offset: 0x0000B720
		private static void OnCurrentCalendarModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = (global::Infragistics.Windows.Editors.CalendarItemArea)d;
			calendarItemArea.InitializeCalendarModeSettings((global::Infragistics.Windows.Editors.CalendarMode)e.NewValue);
			calendarItemArea.CoerceValue(global::Infragistics.Windows.Editors.CalendarItemArea.WeekNumberVisibilityProperty);
			calendarItemArea.CoerceValue(global::Infragistics.Windows.Editors.CalendarItemArea.DayOfWeekHeaderVisibilityProperty);
			calendarItemArea.InitializeItems();
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000D564 File Offset: 0x0000B764
		private void ReinitializeEnabledState()
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
			if (monthCalendar != null)
			{
				global::Infragistics.Windows.Editors.CalendarMode currentCalendarMode = this.CurrentCalendarMode;
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Windows.Editors.CalendarItem calendarItem = this._itemsInternal[i];
					object value = monthCalendar.CanActivate(calendarItem.StartDate, calendarItem.EndDate, currentCalendarMode) ? global::System.Windows.DependencyProperty.UnsetValue : global::Infragistics.KnownBoxes.FalseBox;
					calendarItem.SetValue(global::System.Windows.UIElement.IsEnabledProperty, value);
					i++;
				}
			}
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000D5DC File Offset: 0x0000B7DC
		private void ReinitializeSelectedState()
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
			if (monthCalendar != null)
			{
				bool isNavigationMode = monthCalendar.IsNavigationMode;
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Windows.Editors.CalendarItem calendarItem = this._itemsInternal[i];
					bool flag = monthCalendar.SelectedDates.ContainsSelection(calendarItem.StartDate, calendarItem.EndDate);
					bool flag2 = isNavigationMode ? calendarItem.IsActive : flag;
					calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsSelectedPropertyKey, flag2 ? global::Infragistics.KnownBoxes.TrueBox : global::Infragistics.KnownBoxes.FalseBox);
					calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsSelectedDatesPropertyKey, flag ? global::Infragistics.KnownBoxes.TrueBox : global::Infragistics.KnownBoxes.FalseBox);
					i++;
				}
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000D688 File Offset: 0x0000B888
		private void ReinitializeStyle()
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
			if (monthCalendar != null)
			{
				bool flag = this.CurrentCalendarMode == global::Infragistics.Windows.Editors.CalendarMode.Days;
				global::System.Windows.Style style = flag ? monthCalendar.CalendarDayStyle : monthCalendar.CalendarItemStyle;
				global::System.Windows.Controls.StyleSelector styleSelector = flag ? monthCalendar.CalendarDayStyleSelector : monthCalendar.CalendarItemStyleSelector;
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Windows.Editors.CalendarItem calendarItem = this._itemsInternal[i];
					global::System.Windows.Style style2;
					if (styleSelector != null)
					{
						style2 = styleSelector.SelectStyle(calendarItem, calendarItem);
					}
					else
					{
						style2 = null;
					}
					global::System.Windows.DependencyObject dependencyObject = calendarItem;
					global::System.Windows.DependencyProperty styleProperty = global::System.Windows.FrameworkElement.StyleProperty;
					global::System.Windows.Style value;
					if ((value = style2) == null)
					{
						value = (style ?? global::System.Windows.DependencyProperty.UnsetValue);
					}
					dependencyObject.SetValue(styleProperty, value);
					i++;
				}
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000D730 File Offset: 0x0000B930
		private void ReinitializeTodayState()
		{
			global::Infragistics.Windows.Editors.XamMonthCalendar monthCalendar = global::Infragistics.Windows.Editors.XamMonthCalendar.GetMonthCalendar(this);
			if (monthCalendar != null)
			{
				global::System.DateTime today = global::System.DateTime.Today;
				bool isMinCalendarMode = monthCalendar.IsMinCalendarMode;
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Windows.Editors.CalendarItem calendarItem = this._itemsInternal[i];
					bool flag = calendarItem.StartDate <= today && today <= calendarItem.EndDate;
					calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.IsTodayPropertyKey, (isMinCalendarMode && flag) ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
					calendarItem.SetValue(global::Infragistics.Windows.Editors.CalendarItem.ContainsTodayPropertyKey, flag ? global::Infragistics.KnownBoxes.TrueBox : global::System.Windows.DependencyProperty.UnsetValue);
					i++;
				}
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000D7DC File Offset: 0x0000B9DC
		internal global::Infragistics.Windows.Editors.CalendarItem GetItem(global::System.DateTime date)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> items = this.Items;
			int i = 0;
			int num = items.Count - 1;
			while (i <= num)
			{
				int num2 = i + (num - i) / 2;
				int num3 = items[num2].CompareTo(date);
				if (num3 == 0)
				{
					return items[num2];
				}
				if (num3 > 0)
				{
					num = num2 - 1;
				}
				else
				{
					i = num2 + 1;
				}
			}
			return null;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000D834 File Offset: 0x0000BA34
		internal void InitializeGroup(global::Infragistics.Windows.Editors.CalendarItemGroup group)
		{
			if (this._group == group)
			{
				return;
			}
			if (this._group != null)
			{
				this._group.UnregisterItemArea(this);
			}
			this._group = group;
			if (this._group != null && group == base.TemplatedParent)
			{
				this._group.RegisterItemArea(this);
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000D883 File Offset: 0x0000BA83
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeItems()
		{
			this.InitializeItems();
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000D88B File Offset: 0x0000BA8B
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeWeekNumbers()
		{
			this.InitializeWeekNumbers();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000D893 File Offset: 0x0000BA93
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeFirstItemOffset()
		{
			this.InitializeFirstItemOffset();
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D89B File Offset: 0x0000BA9B
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeRowColCount()
		{
			this.InitializeCalendarModeSettings(this.CurrentCalendarMode);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000D8A9 File Offset: 0x0000BAA9
		global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> global::Infragistics.Windows.Editors.ICalendarItemArea.Items
		{
			get
			{
				return this.Items;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		void global::Infragistics.Windows.Editors.ICalendarItemArea.ReinitializeItems(global::Infragistics.Windows.Editors.CalendarItemChange change)
		{
			switch (change)
			{
			case global::Infragistics.Windows.Editors.CalendarItemChange.Style:
				this.ReinitializeStyle();
				return;
			case global::Infragistics.Windows.Editors.CalendarItemChange.Enabled:
				this.ReinitializeEnabledState();
				return;
			case global::Infragistics.Windows.Editors.CalendarItemChange.Selection:
				this.ReinitializeSelectedState();
				return;
			case global::Infragistics.Windows.Editors.CalendarItemChange.Today:
				this.ReinitializeTodayState();
				return;
			default:
				((global::Infragistics.Windows.Editors.ICalendarItemArea)this).InitializeItems();
				return;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000D8FD File Offset: 0x0000BAFD
		void global::Infragistics.Windows.Editors.ICalendarItemArea.PrepareForAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action)
		{
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000D8FF File Offset: 0x0000BAFF
		void global::Infragistics.Windows.Editors.ICalendarItemArea.PerformAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action)
		{
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000D901 File Offset: 0x0000BB01
		global::Infragistics.Windows.Editors.CalendarItem global::Infragistics.Windows.Editors.ICalendarItemArea.GetItem(global::System.DateTime date)
		{
			return this.GetItem(date);
		}

		// Token: 0x04000122 RID: 290
		private global::Infragistics.Windows.Editors.CalendarItemGroup _group;

		// Token: 0x04000123 RID: 291
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.CalendarItem> _itemsInternal;

		// Token: 0x04000124 RID: 292
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.CalendarItem> _items;

		// Token: 0x04000125 RID: 293
		private global::Infragistics.Collections.ObservableCollectionExtended<int> _weekNumbersInternal;

		// Token: 0x04000126 RID: 294
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int> _weekNumbers;

		// Token: 0x04000127 RID: 295
		private global::Infragistics.Windows.Editors.CalendarDateRange? _groupRange;

		// Token: 0x04000128 RID: 296
		public static readonly global::System.Windows.DependencyProperty DayOfWeekHeaderVisibilityProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.DayOfWeekHeaderVisibilityProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.CalendarItemArea.CoerceDayOfWeekHeaderVisibility)));

		// Token: 0x04000129 RID: 297
		private static readonly global::System.Windows.DependencyPropertyKey FirstItemColumnOffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FirstItemColumnOffset", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt));

		// Token: 0x0400012A RID: 298
		public static readonly global::System.Windows.DependencyProperty FirstItemColumnOffsetProperty = global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemColumnOffsetPropertyKey.DependencyProperty;

		// Token: 0x0400012B RID: 299
		private static readonly global::System.Windows.DependencyPropertyKey FirstItemRowOffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FirstItemRowOffset", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt));

		// Token: 0x0400012C RID: 300
		public static readonly global::System.Windows.DependencyProperty FirstItemRowOffsetProperty = global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemRowOffsetPropertyKey.DependencyProperty;

		// Token: 0x0400012D RID: 301
		private static readonly global::System.Windows.DependencyPropertyKey ItemAreaPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ItemArea", typeof(global::Infragistics.Windows.Editors.CalendarItemArea), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x0400012E RID: 302
		public static readonly global::System.Windows.DependencyProperty ItemAreaProperty = global::Infragistics.Windows.Editors.CalendarItemArea.ItemAreaPropertyKey.DependencyProperty;

		// Token: 0x0400012F RID: 303
		private static readonly global::System.Windows.DependencyPropertyKey ItemColumnsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemColumns", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt));

		// Token: 0x04000130 RID: 304
		public static readonly global::System.Windows.DependencyProperty ItemColumnsProperty = global::Infragistics.Windows.Editors.CalendarItemArea.ItemColumnsPropertyKey.DependencyProperty;

		// Token: 0x04000131 RID: 305
		private static readonly global::System.Windows.DependencyPropertyKey ItemRowsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemRows", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt));

		// Token: 0x04000132 RID: 306
		public static readonly global::System.Windows.DependencyProperty ItemRowsProperty = global::Infragistics.Windows.Editors.CalendarItemArea.ItemRowsPropertyKey.DependencyProperty;

		// Token: 0x04000133 RID: 307
		public static readonly global::System.Windows.DependencyProperty WeekNumberVisibilityProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.WeekNumberVisibilityProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.CalendarItemArea.CoerceWeekNumberVisibility)));
	}
}
