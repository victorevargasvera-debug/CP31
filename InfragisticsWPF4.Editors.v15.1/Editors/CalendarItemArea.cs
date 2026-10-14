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
	// Token: 0x02000035 RID: 53
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarItemArea : global::System.Windows.Controls.Control, global::Infragistics.Windows.Editors.ICalendarItemArea
	{
		// Token: 0x0600034D RID: 845 RVA: 0x0000D11C File Offset: 0x0000B31C
		static CalendarItemArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemArea)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));
			global::Infragistics.Windows.Editors.CalendarItemGroup.CurrentCalendarModePropertyKey.OverrideMetadata(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Infragistics.Windows.Editors.CalendarItemArea.OnCurrentCalendarModeChanged)));
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000D310 File Offset: 0x0000B510
		public CalendarItemArea()
		{
			this._itemsInternal = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.CalendarItem>();
			this._items = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.CalendarItem>(this._itemsInternal);
			this._weekNumbersInternal = new global::Infragistics.Collections.ObservableCollectionExtended<int>();
			this._weekNumbers = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int>(this._weekNumbersInternal);
			this.InitializeCalendarModeSettings(global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(this));
			base.SetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemAreaPropertyKey, this);
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600034F RID: 847 RVA: 0x0000D373 File Offset: 0x0000B573
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return this._itemsInternal.GetEnumerator();
			}
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000D380 File Offset: 0x0000B580
		protected override void OnInitialized(global::System.EventArgs e)
		{
			this.InitializeCalendarModeSettings(this.CurrentCalendarMode);
			this.InitializeItems();
			base.OnInitialized(e);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000D39C File Offset: 0x0000B59C
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			global::Infragistics.Windows.Editors.CalendarItemGroup calendarItemGroup = base.TemplatedParent as global::Infragistics.Windows.Editors.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				this.InitializeGroup(calendarItemGroup);
			}
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000D3C6 File Offset: 0x0000B5C6
		internal global::Infragistics.Windows.Editors.CalendarDateRange? GroupRange
		{
			get
			{
				return this._groupRange;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000D3CE File Offset: 0x0000B5CE
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0000D3E9 File Offset: 0x0000B5E9
		internal global::Infragistics.Windows.Editors.CalendarMode CurrentCalendarMode
		{
			get
			{
				return global::Infragistics.Windows.Editors.CalendarItemGroup.GetCurrentCalendarMode(this);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		private static object CoerceDayOfWeekHeaderVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = (global::Infragistics.Windows.Editors.CalendarItemArea)d;
			if (calendarItemArea.CurrentCalendarMode != global::Infragistics.Windows.Editors.CalendarMode.Days || calendarItemArea.Items.Count == 0)
			{
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			return newValue;
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000356 RID: 854 RVA: 0x0000D424 File Offset: 0x0000B624
		// (set) Token: 0x06000357 RID: 855 RVA: 0x0000D436 File Offset: 0x0000B636
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000358 RID: 856 RVA: 0x0000D449 File Offset: 0x0000B649
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

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0000D451 File Offset: 0x0000B651
		[global::System.ComponentModel.Browsable(false)]
		public int FirstItemColumnOffset
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemColumnOffsetProperty);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600035A RID: 858 RVA: 0x0000D463 File Offset: 0x0000B663
		[global::System.ComponentModel.Browsable(false)]
		public int FirstItemRowOffset
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemRowOffsetProperty);
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000D475 File Offset: 0x0000B675
		public static global::Infragistics.Windows.Editors.CalendarItemArea GetItemArea(global::System.Windows.DependencyObject d)
		{
			return (global::Infragistics.Windows.Editors.CalendarItemArea)d.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemAreaProperty);
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600035C RID: 860 RVA: 0x0000D487 File Offset: 0x0000B687
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int ItemColumns
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemColumnsProperty);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000D499 File Offset: 0x0000B699
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int ItemRows
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Windows.Editors.CalendarItemArea.ItemRowsProperty);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000D4AB File Offset: 0x0000B6AB
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int> WeekNumbers
		{
			get
			{
				return this._weekNumbers;
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x0000D4B4 File Offset: 0x0000B6B4
		private static object CoerceWeekNumberVisibility(global::System.Windows.DependencyObject d, object newValue)
		{
			global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = (global::Infragistics.Windows.Editors.CalendarItemArea)d;
			if (calendarItemArea.CurrentCalendarMode != global::Infragistics.Windows.Editors.CalendarMode.Days || calendarItemArea.Items.Count == 0)
			{
				return global::Infragistics.KnownBoxes.VisibilityCollapsedBox;
			}
			return newValue;
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000360 RID: 864 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
		// (set) Token: 0x06000361 RID: 865 RVA: 0x0000D4F6 File Offset: 0x0000B6F6
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

		// Token: 0x06000362 RID: 866 RVA: 0x0000D50C File Offset: 0x0000B70C
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

		// Token: 0x06000363 RID: 867 RVA: 0x0000D600 File Offset: 0x0000B800
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

		// Token: 0x06000364 RID: 868 RVA: 0x0000D688 File Offset: 0x0000B888
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

		// Token: 0x06000365 RID: 869 RVA: 0x0000DCC0 File Offset: 0x0000BEC0
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

		// Token: 0x06000366 RID: 870 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		private static void OnCurrentCalendarModeChanged(global::System.Windows.DependencyObject d, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			global::Infragistics.Windows.Editors.CalendarItemArea calendarItemArea = (global::Infragistics.Windows.Editors.CalendarItemArea)d;
			calendarItemArea.InitializeCalendarModeSettings((global::Infragistics.Windows.Editors.CalendarMode)e.NewValue);
			calendarItemArea.CoerceValue(global::Infragistics.Windows.Editors.CalendarItemArea.WeekNumberVisibilityProperty);
			calendarItemArea.CoerceValue(global::Infragistics.Windows.Editors.CalendarItemArea.DayOfWeekHeaderVisibilityProperty);
			calendarItemArea.InitializeItems();
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000DE1C File Offset: 0x0000C01C
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

		// Token: 0x06000368 RID: 872 RVA: 0x0000DE94 File Offset: 0x0000C094
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

		// Token: 0x06000369 RID: 873 RVA: 0x0000DF40 File Offset: 0x0000C140
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

		// Token: 0x0600036A RID: 874 RVA: 0x0000DFE8 File Offset: 0x0000C1E8
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

		// Token: 0x0600036B RID: 875 RVA: 0x0000E094 File Offset: 0x0000C294
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

		// Token: 0x0600036C RID: 876 RVA: 0x0000E0EC File Offset: 0x0000C2EC
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

		// Token: 0x0600036D RID: 877 RVA: 0x0000E13B File Offset: 0x0000C33B
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeItems()
		{
			this.InitializeItems();
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000E143 File Offset: 0x0000C343
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeWeekNumbers()
		{
			this.InitializeWeekNumbers();
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000E14B File Offset: 0x0000C34B
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeFirstItemOffset()
		{
			this.InitializeFirstItemOffset();
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000E153 File Offset: 0x0000C353
		void global::Infragistics.Windows.Editors.ICalendarItemArea.InitializeRowColCount()
		{
			this.InitializeCalendarModeSettings(this.CurrentCalendarMode);
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000371 RID: 881 RVA: 0x0000E161 File Offset: 0x0000C361
		global::System.Collections.Generic.IList<global::Infragistics.Windows.Editors.CalendarItem> global::Infragistics.Windows.Editors.ICalendarItemArea.Items
		{
			get
			{
				return this.Items;
			}
		}

		// Token: 0x06000372 RID: 882 RVA: 0x0000E16C File Offset: 0x0000C36C
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

		// Token: 0x06000373 RID: 883 RVA: 0x0000E1B5 File Offset: 0x0000C3B5
		void global::Infragistics.Windows.Editors.ICalendarItemArea.PrepareForAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action)
		{
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0000E1B7 File Offset: 0x0000C3B7
		void global::Infragistics.Windows.Editors.ICalendarItemArea.PerformAnimationAction(global::Infragistics.Windows.Editors.CalendarAnimation action)
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x0000E1B9 File Offset: 0x0000C3B9
		global::Infragistics.Windows.Editors.CalendarItem global::Infragistics.Windows.Editors.ICalendarItemArea.GetItem(global::System.DateTime date)
		{
			return this.GetItem(date);
		}

		// Token: 0x0400013A RID: 314
		private global::Infragistics.Windows.Editors.CalendarItemGroup _group;

		// Token: 0x0400013B RID: 315
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.CalendarItem> _itemsInternal;

		// Token: 0x0400013C RID: 316
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.Editors.CalendarItem> _items;

		// Token: 0x0400013D RID: 317
		private global::Infragistics.Collections.ObservableCollectionExtended<int> _weekNumbersInternal;

		// Token: 0x0400013E RID: 318
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int> _weekNumbers;

		// Token: 0x0400013F RID: 319
		private global::Infragistics.Windows.Editors.CalendarDateRange? _groupRange;

		// Token: 0x04000140 RID: 320
		public static readonly global::System.Windows.DependencyProperty DayOfWeekHeaderVisibilityProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.DayOfWeekHeaderVisibilityProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.CalendarItemArea.CoerceDayOfWeekHeaderVisibility)));

		// Token: 0x04000141 RID: 321
		private static readonly global::System.Windows.DependencyPropertyKey FirstItemColumnOffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FirstItemColumnOffset", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt));

		// Token: 0x04000142 RID: 322
		public static readonly global::System.Windows.DependencyProperty FirstItemColumnOffsetProperty = global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemColumnOffsetPropertyKey.DependencyProperty;

		// Token: 0x04000143 RID: 323
		private static readonly global::System.Windows.DependencyPropertyKey FirstItemRowOffsetPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("FirstItemRowOffset", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt));

		// Token: 0x04000144 RID: 324
		public static readonly global::System.Windows.DependencyProperty FirstItemRowOffsetProperty = global::Infragistics.Windows.Editors.CalendarItemArea.FirstItemRowOffsetPropertyKey.DependencyProperty;

		// Token: 0x04000145 RID: 325
		private static readonly global::System.Windows.DependencyPropertyKey ItemAreaPropertyKey = global::System.Windows.DependencyProperty.RegisterAttachedReadOnly("ItemArea", typeof(global::Infragistics.Windows.Editors.CalendarItemArea), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(null, global::System.Windows.FrameworkPropertyMetadataOptions.Inherits));

		// Token: 0x04000146 RID: 326
		public static readonly global::System.Windows.DependencyProperty ItemAreaProperty = global::Infragistics.Windows.Editors.CalendarItemArea.ItemAreaPropertyKey.DependencyProperty;

		// Token: 0x04000147 RID: 327
		private static readonly global::System.Windows.DependencyPropertyKey ItemColumnsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemColumns", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt));

		// Token: 0x04000148 RID: 328
		public static readonly global::System.Windows.DependencyProperty ItemColumnsProperty = global::Infragistics.Windows.Editors.CalendarItemArea.ItemColumnsPropertyKey.DependencyProperty;

		// Token: 0x04000149 RID: 329
		private static readonly global::System.Windows.DependencyPropertyKey ItemRowsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("ItemRows", typeof(int), typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.Windows.Editors.Utils.ZeroInt));

		// Token: 0x0400014A RID: 330
		public static readonly global::System.Windows.DependencyProperty ItemRowsProperty = global::Infragistics.Windows.Editors.CalendarItemArea.ItemRowsPropertyKey.DependencyProperty;

		// Token: 0x0400014B RID: 331
		public static readonly global::System.Windows.DependencyProperty WeekNumberVisibilityProperty = global::Infragistics.Windows.Editors.XamMonthCalendar.WeekNumberVisibilityProperty.AddOwner(typeof(global::Infragistics.Windows.Editors.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(null, new global::System.Windows.CoerceValueCallback(global::Infragistics.Windows.Editors.CalendarItemArea.CoerceWeekNumberVisibility)));
	}
}
