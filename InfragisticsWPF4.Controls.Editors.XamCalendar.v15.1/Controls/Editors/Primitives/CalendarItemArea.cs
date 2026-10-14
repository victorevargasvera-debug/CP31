using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Collections;
using Infragistics.Controls.Primitives;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200001C RID: 28
	[global::System.Windows.TemplatePart(Name = "WeekNumberPanel", Type = typeof(global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumberPanel))]
	[global::System.Windows.TemplatePart(Name = "DayOfWeekPanel", Type = typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeekPanel))]
	[global::System.Windows.TemplatePart(Name = "ItemPanel", Type = typeof(global::Infragistics.Controls.Primitives.UniformGrid))]
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CalendarItemArea : global::System.Windows.Controls.Control, global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea, global::Infragistics.Controls.Editors.Primitives.ICalendarElement
	{
		// Token: 0x06000100 RID: 256 RVA: 0x00005728 File Offset: 0x00003928
		static CalendarItemArea()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea)));
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000058F0 File Offset: 0x00003AF0
		public CalendarItemArea()
		{
			this._itemsInternal = new global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Controls.Editors.Primitives.CalendarItem>();
			this._items = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Controls.Editors.Primitives.CalendarItem>(this._itemsInternal);
			this._weekNumbersInternal = new global::Infragistics.Collections.ObservableCollectionExtended<int>();
			this._weekNumbers = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int>(this._weekNumbersInternal);
			this.InitializeCalendarModeSettings(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this));
			base.Loaded += this.OnLoaded;
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00005959 File Offset: 0x00003B59
		protected override global::System.Collections.IEnumerator LogicalChildren
		{
			get
			{
				return this._itemsInternal.GetEnumerator();
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00005968 File Offset: 0x00003B68
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (!this._isInitialized)
			{
				this._isInitialized = true;
				this.InitializeItems();
			}
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeekPanel calendarDayOfWeekPanel = base.GetTemplateChild("DayOfWeekPanel") as global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeekPanel;
			if (calendarDayOfWeekPanel != this._dayOfWeekPanel)
			{
				if (this._dayOfWeekPanel != null)
				{
					this._dayOfWeekPanel.ClearValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarPropertyKey);
				}
				this._dayOfWeekPanel = calendarDayOfWeekPanel;
				if (this._dayOfWeekPanel != null && calendar != null)
				{
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this._dayOfWeekPanel, calendar);
				}
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumberPanel calendarWeekNumberPanel = base.GetTemplateChild("WeekNumberPanel") as global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumberPanel;
			if (calendarWeekNumberPanel != this._weekNumberPanel)
			{
				if (this._weekNumberPanel != null)
				{
					this._weekNumberPanel.InitializeItemsArea(null);
					this._weekNumberPanel.ClearValue(global::Infragistics.Controls.Editors.CalendarBase.CalendarPropertyKey);
				}
				this._weekNumberPanel = calendarWeekNumberPanel;
				if (this._weekNumberPanel != null && calendar != null)
				{
					this._weekNumberPanel.InitializeItemsArea(this);
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this._weekNumberPanel, calendar);
				}
			}
			global::Infragistics.Controls.Primitives.UniformGrid uniformGrid = base.GetTemplateChild("ItemPanel") as global::Infragistics.Controls.Primitives.UniformGrid;
			if (uniformGrid != this._itemPanel)
			{
				if (this._itemPanel != null)
				{
					this._itemPanel.Children.Clear();
				}
				this._itemPanel = uniformGrid;
				if (this._itemPanel != null && calendar != null)
				{
					foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItem element in this.Items)
					{
						this._itemPanel.Children.Add(element);
					}
				}
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00005AE8 File Offset: 0x00003CE8
		protected override void OnInitialized(global::System.EventArgs e)
		{
			base.OnInitialized(e);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00005AF4 File Offset: 0x00003CF4
		protected override void OnVisualParentChanged(global::System.Windows.DependencyObject oldParent)
		{
			global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup calendarItemGroup = base.TemplatedParent as global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup;
			if (calendarItemGroup != null)
			{
				this.InitializeGroup(calendarItemGroup);
			}
			base.OnVisualParentChanged(oldParent);
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00005B1E File Offset: 0x00003D1E
		internal global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup Group
		{
			get
			{
				return this._group;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00005B26 File Offset: 0x00003D26
		internal global::Infragistics.DateRange? GroupRange
		{
			get
			{
				return this._groupRange;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00005B2E File Offset: 0x00003D2E
		internal global::Infragistics.Controls.Editors.CalendarManager CalendarManager
		{
			get
			{
				if (this._group == null)
				{
					return global::Infragistics.Controls.Editors.CalendarManager.CurrentCulture;
				}
				return this._group.CalendarManager;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00005B49 File Offset: 0x00003D49
		internal global::Infragistics.Controls.Editors.CalendarZoomMode CurrentMode
		{
			get
			{
				return global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this);
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00005B51 File Offset: 0x00003D51
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00005B63 File Offset: 0x00003D63
		public global::System.Windows.Thickness ComputedItemsBorderThickness
		{
			get
			{
				return (global::System.Windows.Thickness)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ComputedItemsBorderThicknessProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ComputedItemsBorderThicknessPropertyKey, value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00005B76 File Offset: 0x00003D76
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00005B88 File Offset: 0x00003D88
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Visibility DayOfWeekHeaderVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.DayOfWeekHeaderVisibilityProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.DayOfWeekHeaderVisibilityPropertyKey, value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00005B9B File Offset: 0x00003D9B
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Controls.Editors.Primitives.CalendarItem> Items
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00005BA3 File Offset: 0x00003DA3
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00005BB5 File Offset: 0x00003DB5
		[global::System.ComponentModel.Browsable(false)]
		public int FirstItemColumnOffset
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.FirstItemColumnOffsetProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.FirstItemColumnOffsetPropertyKey, value);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00005BC8 File Offset: 0x00003DC8
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00005BDA File Offset: 0x00003DDA
		[global::System.ComponentModel.Browsable(false)]
		public int FirstItemRowOffset
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.FirstItemRowOffsetProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.FirstItemRowOffsetPropertyKey, value);
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00005BED File Offset: 0x00003DED
		// (set) Token: 0x06000114 RID: 276 RVA: 0x00005BFF File Offset: 0x00003DFF
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public int ItemColumns
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemColumnsProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemColumnsPropertyKey, value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000115 RID: 277 RVA: 0x00005C12 File Offset: 0x00003E12
		// (set) Token: 0x06000116 RID: 278 RVA: 0x00005C24 File Offset: 0x00003E24
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public int ItemRows
		{
			get
			{
				return (int)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemRowsProperty);
			}
			internal set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemRowsPropertyKey, value);
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000117 RID: 279 RVA: 0x00005C37 File Offset: 0x00003E37
		// (set) Token: 0x06000118 RID: 280 RVA: 0x00005C49 File Offset: 0x00003E49
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::System.Windows.Visibility WeekNumberVisibility
		{
			get
			{
				return (global::System.Windows.Visibility)base.GetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.WeekNumberVisibilityProperty);
			}
			private set
			{
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.WeekNumberVisibilityPropertyKey, value);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000119 RID: 281 RVA: 0x00005C5C File Offset: 0x00003E5C
		internal global::System.DateTime? FirstDate
		{
			get
			{
				return this._firstDate;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00005C64 File Offset: 0x00003E64
		internal global::System.DateTime? LastDate
		{
			get
			{
				return this._lastDate;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600011B RID: 283 RVA: 0x00005C6C File Offset: 0x00003E6C
		internal global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int> WeekNumbers
		{
			get
			{
				return this._weekNumbers;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00005C74 File Offset: 0x00003E74
		private void InitializeCalendarModeSettings(global::Infragistics.Controls.Editors.CalendarZoomMode mode)
		{
			switch (mode)
			{
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Days:
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemRowsPropertyKey, 6);
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemColumnsPropertyKey, this.CalendarManager.VisibleDayCount);
				return;
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Months:
			{
				int num = 3;
				if (this._group != null && this._group.FirstDateOfGroup != null)
				{
					global::System.DateTime value = this._group.FirstDateOfGroup.Value;
					global::System.Globalization.Calendar calendar = this.CalendarManager.Calendar;
					int year = calendar.GetYear(value);
					num = (calendar.GetMonthsInYear(year) + 3) / 4;
				}
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemRowsPropertyKey, num);
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemColumnsPropertyKey, 4);
				return;
			}
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Years:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Decades:
			case global::Infragistics.Controls.Editors.CalendarZoomMode.Centuries:
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemRowsPropertyKey, 3);
				base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemColumnsPropertyKey, 4);
				return;
			default:
				return;
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00005D68 File Offset: 0x00003F68
		private void InitializeFirstItemOffset()
		{
			int num = 0;
			int num2 = 0;
			if (this._items.Count > 0)
			{
				this.CalendarManager.GetItemRowColumn(this.Items[0].StartDate, this.CurrentMode, this._group.FirstDateOfGroup.Value, this._group.ShowLeadingDates, out num, out num2);
			}
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.FirstItemColumnOffsetPropertyKey, num);
			base.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.FirstItemRowOffsetPropertyKey, num2);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00005DED File Offset: 0x00003FED
		private void InitializeItems()
		{
			this.InitializeItems(false);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00005DF8 File Offset: 0x00003FF8
		private void InitializeItems(bool force)
		{
			if (!this._isInitialized && !force)
			{
				return;
			}
			if (this._group == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar == null)
			{
				return;
			}
			global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection selectedDateCollection = calendar.SelectedDatesInternal as global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection;
			global::Infragistics.Controls.Editors.CalendarManager calendarManager = this.CalendarManager;
			global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
			global::System.DateTime? firstDateOfGroup = this._group.FirstDateOfGroup;
			global::System.DateTime? lastDateOfGroup = this._group.LastDateOfGroup;
			bool newValue = calendar != null && calendar.IsSelectionActive;
			this._firstDate = null;
			this._lastDate = null;
			global::System.DateTime[] array;
			if (firstDateOfGroup != null && lastDateOfGroup != null)
			{
				global::System.DateTime minDate = (calendar != null) ? calendar.MinDateResolved : global::System.DateTime.MinValue;
				global::System.DateTime maxDate = (calendar != null) ? calendar.MaxDateResolved : global::System.DateTime.MaxValue.Date;
				array = calendarManager.GetItemDates(firstDateOfGroup.Value, currentMode, this._group.ShowLeadingDates, this._group.ShowTrailingDates, minDate, maxDate);
				this._groupRange = new global::Infragistics.DateRange?(new global::Infragistics.DateRange(firstDateOfGroup.Value, lastDateOfGroup.Value));
				if (array.Length > 0)
				{
					this._firstDate = new global::System.DateTime?(array[0]);
					this._lastDate = new global::System.DateTime?(array[array.Length - 1]);
				}
			}
			else
			{
				array = new global::System.DateTime[0];
				this._groupRange = null;
			}
			bool flag = currentMode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days;
			global::Infragistics.Controls.Editors.Primitives.CalendarItem[] array2 = new global::Infragistics.Controls.Editors.Primitives.CalendarItem[array.Length];
			global::System.DateTime today = global::System.DateTime.Today;
			global::System.DateTime? dateTime;
			global::Infragistics.Controls.DayOfWeekFlags days;
			bool flag2;
			global::System.Windows.Style style;
			if (calendar != null)
			{
				dateTime = calendar.ActiveDate;
				days = calendar.WorkDaysInternal;
				flag2 = calendar.IsMinCalendarMode;
				style = (flag ? calendar.CalendarDayStyle : calendar.CalendarItemStyle);
				if (style == null)
				{
					global::Infragistics.Controls.Editors.CalendarResourceProvider resourceProviderResolved = calendar.ResourceProviderResolved;
					if (resourceProviderResolved != null)
					{
						style = (resourceProviderResolved[flag ? global::Infragistics.Controls.Editors.CalendarResourceId.CalendarDayStyle : global::Infragistics.Controls.Editors.CalendarResourceId.CalendarItemStyle] as global::System.Windows.Style);
					}
				}
			}
			else
			{
				dateTime = null;
				days = (global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday);
				flag2 = true;
				style = null;
			}
			global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItem> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItem>();
			global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItem> list2 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItem>();
			global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItem> list3 = new global::System.Collections.Generic.List<global::Infragistics.Controls.Editors.Primitives.CalendarItem>();
			global::System.Windows.Controls.UIElementCollection uielementCollection = (this._itemPanel != null) ? this._itemPanel.Children : null;
			if (uielementCollection != null)
			{
				foreach (object obj in uielementCollection)
				{
					global::System.Windows.UIElement uielement = (global::System.Windows.UIElement)obj;
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = uielement as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
					if (calendarItem != null)
					{
						bool flag3 = calendarItem is global::Infragistics.Controls.Editors.Primitives.CalendarDay;
						if (!flag)
						{
							flag3 = !flag3;
						}
						if (flag3)
						{
							list.Add(calendarItem);
						}
						else
						{
							list2.Add(calendarItem);
							calendarItem.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
						}
					}
				}
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarItem[] array3 = new global::Infragistics.Controls.Editors.Primitives.CalendarItem[list.Count];
			list.CopyTo(array3, 0);
			int num = 0;
			bool flag4 = array3.Length > 0 && array3[0] is global::Infragistics.Controls.Editors.Primitives.CalendarDay;
			bool flag5 = !flag4 && array3.Length > 0;
			if (this._group != null && this._group.IsGroupForSizing)
			{
				flag5 = (flag4 = false);
			}
			global::Infragistics.Controls.Editors.CalendarZoomMode currentMode2 = global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(this);
			for (int i = 0; i < array.Length; i++)
			{
				global::System.DateTime dateTime2 = array[i];
				bool flag6 = true;
				bool flag7 = false;
				bool flag8 = false;
				global::System.DateTime dateTime3;
				bool flag9;
				global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem2;
				if (flag)
				{
					dateTime3 = dateTime2;
					flag9 = (dateTime2 == today);
					if (flag4)
					{
						calendarItem2 = (array2[i] = array3[num]);
						num++;
						flag4 = (num < array3.Length);
						calendarItem2.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitializing, true);
						calendarItem2.Recycle(dateTime2, dateTime3);
						flag8 = true;
					}
					else
					{
						calendarItem2 = (array2[i] = new global::Infragistics.Controls.Editors.Primitives.CalendarDay(dateTime2, this._group));
						((global::System.ComponentModel.ISupportInitialize)calendarItem2).BeginInit();
					}
					global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(calendarItem2, global::Infragistics.Controls.Editors.Primitives.CalendarDay.IsWorkdayPropertyKey, global::Infragistics.Controls.CalendarHelper.IsSet(days, calendarManager.Calendar.GetDayOfWeek(dateTime2)), ((global::Infragistics.Controls.Editors.Primitives.CalendarDay)calendarItem2).IsWorkday, true);
					if (this._group == null || !this._group.IsGroupForSizing)
					{
						flag7 = true;
					}
				}
				else
				{
					dateTime3 = calendarManager.GetItemEndDate(dateTime2, currentMode);
					if (flag5)
					{
						calendarItem2 = (array2[i] = array3[num]);
						num++;
						flag5 = (num < array3.Length);
						calendarItem2.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitializing, true);
						calendarItem2.Recycle(dateTime2, dateTime3);
						flag8 = true;
					}
					else
					{
						calendarItem2 = (array2[i] = new global::Infragistics.Controls.Editors.Primitives.CalendarItem(dateTime2, dateTime3, this._group));
						((global::System.ComponentModel.ISupportInitialize)calendarItem2).BeginInit();
					}
					flag9 = (dateTime2 <= today && today <= dateTime3);
				}
				global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(calendarItem2, global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsTodayPropertyKey, flag9 && flag2, calendarItem2.IsToday, false);
				global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(calendarItem2, global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsTodayPropertyKey, flag9, calendarItem2.ContainsToday, false);
				if (currentMode2 != global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.GetCurrentMode(calendarItem2))
				{
					calendarItem2.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup.CurrentModePropertyKey, currentMode2);
				}
				bool flag10 = dateTime2 <= dateTime && dateTime <= dateTime3;
				bool newValue2 = false;
				bool flag11 = false;
				if (calendar != null)
				{
					flag6 = calendar.CanActivate(dateTime2, dateTime3, currentMode);
					if (flag6)
					{
						flag11 = selectedDateCollection.ContainsSelection(dateTime2, dateTime3);
						if (flag2)
						{
							newValue2 = flag11;
						}
						else
						{
							newValue2 = flag10;
						}
					}
				}
				global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(calendarItem2, global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectedPropertyKey, newValue2, calendarItem2.IsSelected, false);
				global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(calendarItem2, global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsSelectedDatesPropertyKey, flag11, calendarItem2.ContainsSelectedDates, false);
				calendarItem2.SetIsEnabled(flag6, flag8);
				global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(calendarItem2, global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsLeadingOrTrailingItemPropertyKey, dateTime2 > lastDateOfGroup || dateTime3 < firstDateOfGroup, calendarItem2.IsLeadingOrTrailingItem, false);
				global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(calendarItem2, global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsActivePropertyKey, flag10, calendarItem2.IsActive, false);
				global::Infragistics.Controls.Editors.CalendarUtilities.SetBoolProperty(calendarItem2, global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectionActivePropertyKey, newValue, calendarItem2.IsSelectionActive, false);
				if (flag7)
				{
					((global::Infragistics.Controls.Editors.Primitives.CalendarDay)calendarItem2).InitializeIsHighlighted();
				}
				if (flag8)
				{
					list3.Add(calendarItem2);
					if (calendarItem2.Visibility == global::System.Windows.Visibility.Collapsed)
					{
						calendarItem2.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityVisibleBox);
					}
					calendarItem2.InternalSetPropValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.PropFlags.IsInitializing, false);
				}
				else
				{
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(calendarItem2, calendar);
				}
			}
			list3.Reverse();
			foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItem item in list3)
			{
				list.Remove(item);
			}
			foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem3 in list)
			{
				calendarItem3.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
			}
			foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem4 in list2)
			{
				calendarItem4.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
			}
			if (array2.Length != this._itemsInternal.Count || array2.Length == 0 || array2[0] != this._itemsInternal[0])
			{
				this._itemsInternal.BeginUpdate();
				this._itemsInternal.Clear();
				if (array2.Length > 0)
				{
					this._itemsInternal.AddRange(array2);
				}
				this._itemsInternal.EndUpdate();
			}
			for (int j = num; j < array2.Length; j++)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem5 = array2[j];
				((global::System.ComponentModel.ISupportInitialize)calendarItem5).EndInit();
			}
			foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItem item2 in array2)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.SetItemStyleHelper(style, item2);
			}
			if (this._group != null && this._group.IsGroupForSizing && array2.Length > 1)
			{
				double num2 = -1.0;
				global::System.Windows.Size availableSize = new global::System.Windows.Size(double.PositiveInfinity, double.PositiveInfinity);
				global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem6 = null;
				foreach (global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem7 in array2)
				{
					calendarItem7.Measure(availableSize);
					global::System.Windows.Size desiredSize = calendarItem7.DesiredSize;
					double num3 = desiredSize.Width * desiredSize.Height;
					if (num3 > num2)
					{
						calendarItem6 = calendarItem7;
						num2 = num3;
					}
				}
				this._itemsInternal.ReInitialize(new global::Infragistics.Controls.Editors.Primitives.CalendarItem[]
				{
					calendarItem6
				});
			}
			if (uielementCollection != null)
			{
				bool flag12 = false;
				if (uielementCollection.Count == this._items.Count)
				{
					flag12 = true;
					int m = 0;
					int count = uielementCollection.Count;
					while (m < count)
					{
						if (uielementCollection[m] != this._items[m])
						{
							flag12 = false;
							break;
						}
						m++;
					}
				}
				if (!flag12)
				{
					if (uielementCollection.Count == 0)
					{
						using (global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Editors.Primitives.CalendarItem> enumerator3 = this._items.GetEnumerator())
						{
							while (enumerator3.MoveNext())
							{
								global::Infragistics.Controls.Editors.Primitives.CalendarItem element = enumerator3.Current;
								uielementCollection.Add(element);
							}
							goto IL_991;
						}
					}
					global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Editors.Primitives.CalendarItem> hashSet = new global::System.Collections.Generic.HashSet<global::Infragistics.Controls.Editors.Primitives.CalendarItem>(list3);
					int num4 = 0;
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem8 = null;
					for (int n = 0; n < this._items.Count; n++)
					{
						global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem9 = this._items[n];
						if (calendarItem9 != null && !hashSet.Contains(calendarItem9))
						{
							if (calendarItem8 != null && uielementCollection[num4 - 1] != calendarItem8)
							{
								num4 = global::System.Math.Max(num4, uielementCollection.IndexOf(calendarItem8) + 1);
							}
							uielementCollection.Insert(num4, calendarItem9);
						}
						calendarItem8 = calendarItem9;
						num4++;
					}
				}
			}
			IL_991:
			if (calendar != null && (base.IsKeyboardFocusWithin || calendar.IsKeyboardFocused))
			{
				calendar.FocusActiveItemWithDelay();
			}
			this.InitializeFirstItemOffset();
			this.InitializeWeekNumbers();
			this.SetHeaderVisibility();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00006804 File Offset: 0x00004A04
		private void InitializeWeekNumbers()
		{
			global::Infragistics.Controls.Editors.CalendarManager calendarManager = this.CalendarManager;
			global::System.DateTime? dateTime = (this._group != null) ? this._group.FirstDateOfGroup : null;
			bool flag = this.CurrentMode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days && dateTime != null && this.Items.Count > 0;
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
				calendarManager.GetItemRowColumn(dateTime2, global::Infragistics.Controls.Editors.CalendarZoomMode.Days, dateTime.Value, this._group.ShowLeadingDates, out num, out num2);
				int offset = 7 - num;
				bool flag2 = false;
				try
				{
					for (int i = 0; i < 6; i++)
					{
						int weekNumberForDate = calendarManager.GetWeekNumberForDate(dateTime2);
						if (i > 0 && this._weekNumbersInternal[i - 1] == weekNumberForDate)
						{
							break;
						}
						if (!flag2)
						{
							flag2 = true;
							this._weekNumbersInternal.BeginUpdate();
						}
						this._weekNumbersInternal.Add(weekNumberForDate);
						dateTime2 = calendarManager.AddItemOffset(dateTime2, offset, global::Infragistics.Controls.Editors.CalendarZoomMode.Days);
						offset = 7;
						if (dateTime2 > this._group.LastDate)
						{
							break;
						}
					}
				}
				finally
				{
					if (flag2)
					{
						this._weekNumbersInternal.EndUpdate();
					}
				}
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00006950 File Offset: 0x00004B50
		internal void OnCurrentModeChanged(global::Infragistics.Controls.Editors.CalendarZoomMode newMode, global::Infragistics.Controls.Editors.CalendarZoomMode oldMode)
		{
			this.InitializeCalendarModeSettings(newMode);
			this.SetHeaderVisibility();
			this.InitializeItems();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00006965 File Offset: 0x00004B65
		private void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.InitializeCalendarModeSettings(this.CurrentMode);
			this.InitializeItems();
			base.Loaded -= this.OnLoaded;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000698C File Offset: 0x00004B8C
		private void ReinitializeEnabledState()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar != null)
			{
				global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = this._itemsInternal[i];
					object value = calendar.CanActivate(calendarItem.StartDate, calendarItem.EndDate, currentMode) ? global::System.Windows.DependencyProperty.UnsetValue : global::Infragistics.KnownBoxes.FalseBox;
					calendarItem.SetValue(global::System.Windows.UIElement.IsEnabledProperty, value);
					i++;
				}
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006A04 File Offset: 0x00004C04
		private void ReinitializeIsSelectionActive()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar != null)
			{
				bool isSelectionActive = calendar.IsSelectionActive;
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = this._itemsInternal[i];
					if (isSelectionActive)
					{
						calendarItem.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectionActivePropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else
					{
						calendarItem.ClearValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectionActivePropertyKey);
					}
					i++;
				}
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00006A6C File Offset: 0x00004C6C
		private void ReinitializeSelectedState()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar != null)
			{
				bool isNavigationMode = calendar.IsNavigationMode;
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = this._itemsInternal[i];
					bool flag = ((global::Infragistics.Controls.Editors.Primitives.SelectedDateCollection)calendar.SelectedDatesInternal).ContainsSelection(calendarItem.StartDate, calendarItem.EndDate);
					bool flag2 = isNavigationMode ? calendarItem.IsActive : flag;
					calendarItem.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsSelectedPropertyKey, flag2 ? global::Infragistics.KnownBoxes.TrueBox : global::Infragistics.KnownBoxes.FalseBox);
					calendarItem.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsSelectedDatesPropertyKey, flag ? global::Infragistics.KnownBoxes.TrueBox : global::Infragistics.KnownBoxes.FalseBox);
					i++;
				}
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006B1C File Offset: 0x00004D1C
		private void ReinitializeResources()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar != null)
			{
				this.SetHeaderVisibility();
				global::System.Windows.Controls.UIElementCollection uielementCollection = (this._itemPanel != null) ? this._itemPanel.Children : null;
				if (uielementCollection != null)
				{
					int i = 0;
					int count = uielementCollection.Count;
					while (i < count)
					{
						global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = uielementCollection[i] as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
						if (calendarItem != null)
						{
							calendarItem.SetProviderBrushes();
						}
						i++;
					}
				}
				uielementCollection = ((this._dayOfWeekPanel != null) ? this._dayOfWeekPanel.Children : null);
				if (uielementCollection != null)
				{
					int j = 0;
					int count2 = uielementCollection.Count;
					while (j < count2)
					{
						global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek calendarDayOfWeek = uielementCollection[j] as global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeek;
						if (calendarDayOfWeek != null)
						{
							calendarDayOfWeek.SetProviderBrushes();
						}
						j++;
					}
				}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00006BD0 File Offset: 0x00004DD0
		private void ReinitializeStyle()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar != null)
			{
				bool flag = this.CurrentMode == global::Infragistics.Controls.Editors.CalendarZoomMode.Days;
				global::Infragistics.Controls.Editors.CalendarResourceProvider resourceProviderResolved = calendar.ResourceProviderResolved;
				global::System.Windows.Style style = flag ? calendar.CalendarDayStyle : calendar.CalendarItemStyle;
				if (style == null && resourceProviderResolved != null)
				{
					style = (resourceProviderResolved[flag ? global::Infragistics.Controls.Editors.CalendarResourceId.CalendarDayStyle : global::Infragistics.Controls.Editors.CalendarResourceId.CalendarItemStyle] as global::System.Windows.Style);
				}
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = this._itemsInternal[i];
					if (style != null)
					{
						calendarItem.SetValue(global::System.Windows.FrameworkElement.StyleProperty, style);
					}
					else
					{
						calendarItem.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
					}
					i++;
				}
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00006C74 File Offset: 0x00004E74
		private void ReinitializeTodayState()
		{
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar != null)
			{
				global::System.DateTime today = global::System.DateTime.Today;
				bool isMinCalendarMode = calendar.IsMinCalendarMode;
				int i = 0;
				int count = this._itemsInternal.Count;
				while (i < count)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = this._itemsInternal[i];
					bool flag = calendarItem.StartDate <= today && today <= calendarItem.EndDate;
					if (isMinCalendarMode && flag)
					{
						calendarItem.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsTodayPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else
					{
						calendarItem.ClearValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.IsTodayPropertyKey);
					}
					if (flag)
					{
						calendarItem.SetValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsTodayPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
					}
					else
					{
						calendarItem.ClearValue(global::Infragistics.Controls.Editors.Primitives.CalendarItem.ContainsTodayPropertyKey);
					}
					i++;
				}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006D30 File Offset: 0x00004F30
		private void SetHeaderVisibility()
		{
			global::System.Windows.Visibility visibility;
			global::System.Windows.Visibility weekNumberVisibility;
			global::System.Windows.Visibility visibility2;
			if (this.CurrentMode != global::Infragistics.Controls.Editors.CalendarZoomMode.Days || this.Items.Count == 0)
			{
				visibility = global::System.Windows.Visibility.Collapsed;
				weekNumberVisibility = global::System.Windows.Visibility.Collapsed;
				visibility2 = global::System.Windows.Visibility.Collapsed;
			}
			else
			{
				global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarBase.GetCalendar(this);
				if (calendar == null)
				{
					return;
				}
				visibility = calendar.DayOfWeekHeaderVisibility;
				visibility2 = calendar.WeekNumberVisibility;
				if (calendar.SupportsWeekSelectionMode)
				{
					weekNumberVisibility = global::System.Windows.Visibility.Visible;
				}
				else
				{
					weekNumberVisibility = visibility2;
				}
			}
			this.DayOfWeekHeaderVisibility = visibility;
			this.WeekNumberVisibility = weekNumberVisibility;
			double left = (double)((visibility2 == global::System.Windows.Visibility.Visible) ? 1 : 0);
			double top = (double)((visibility == global::System.Windows.Visibility.Visible) ? 1 : 0);
			this.ComputedItemsBorderThickness = new global::System.Windows.Thickness(left, top, 0.0, 0.0);
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00006DD0 File Offset: 0x00004FD0
		private static void SetItemStyleHelper(global::System.Windows.Style itemStyle, global::Infragistics.Controls.Editors.Primitives.CalendarItem item)
		{
			object obj = itemStyle ?? global::System.Windows.DependencyProperty.UnsetValue;
			if (item.ReadLocalValue(global::System.Windows.FrameworkElement.StyleProperty) != obj)
			{
				if (obj != global::System.Windows.DependencyProperty.UnsetValue)
				{
					item.SetValue(global::System.Windows.FrameworkElement.StyleProperty, obj);
					return;
				}
				item.ClearValue(global::System.Windows.FrameworkElement.StyleProperty);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00006E18 File Offset: 0x00005018
		internal global::Infragistics.Controls.Editors.Primitives.CalendarItem GetItem(global::System.DateTime date)
		{
			global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItem> items = this.Items;
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

		// Token: 0x0600012C RID: 300 RVA: 0x00006E70 File Offset: 0x00005070
		internal global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber GetWeekNumber(int weekNumber)
		{
			if (this._weekNumberPanel == null)
			{
				return null;
			}
			return this._weekNumberPanel.GetWeekNumber(weekNumber);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00006E88 File Offset: 0x00005088
		internal void InitializeGroup(global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup group)
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
			if (this._group != null && group == global::Infragistics.Controls.PresentationUtilities.GetTemplatedParent(this))
			{
				this._group.RegisterItemArea(this);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00006ED8 File Offset: 0x000050D8
		internal bool LoadItemsLazily(bool loadDays)
		{
			if (this._itemPanel == null)
			{
				return true;
			}
			global::System.Windows.Controls.UIElementCollection children = this._itemPanel.Children;
			int i = 0;
			int count = children.Count;
			while (i < count)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = children[i] as global::Infragistics.Controls.Editors.Primitives.CalendarItem;
				if (calendarItem != null)
				{
					if (calendarItem is global::Infragistics.Controls.Editors.Primitives.CalendarDay)
					{
						if (loadDays)
						{
							if (calendarItem.Visibility == global::System.Windows.Visibility.Visible)
							{
								for (i = 0; i < count; i++)
								{
									global::Infragistics.Controls.Editors.Primitives.CalendarDay calendarDay = children[i] as global::Infragistics.Controls.Editors.Primitives.CalendarDay;
									if (calendarDay != null)
									{
										calendarDay.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
									}
								}
								return true;
							}
							return false;
						}
					}
					else if (!loadDays)
					{
						return false;
					}
				}
				i++;
			}
			global::Infragistics.Controls.Editors.CalendarBase calendar = global::Infragistics.Controls.Editors.CalendarUtilities.GetCalendar(this);
			if (calendar == null)
			{
				return false;
			}
			global::Infragistics.Controls.Editors.CalendarManager calendarManager = this.CalendarManager;
			global::Infragistics.Controls.Editors.CalendarZoomMode currentMode = this.CurrentMode;
			global::System.DateTime? firstDateOfGroup = this._group.FirstDateOfGroup;
			global::System.DateTime? lastDateOfGroup = this._group.LastDateOfGroup;
			if (calendar != null)
			{
				bool isSelectionActive = calendar.IsSelectionActive;
			}
			this._firstDate = null;
			this._lastDate = null;
			global::System.DateTime[] array;
			if (firstDateOfGroup != null && lastDateOfGroup != null)
			{
				global::System.DateTime minDate = (calendar != null) ? calendar.MinDateResolved : global::System.DateTime.MinValue;
				global::System.DateTime maxDate = (calendar != null) ? calendar.MaxDateResolved : global::System.DateTime.MaxValue.Date;
				array = calendarManager.GetItemDates(firstDateOfGroup.Value, currentMode, this._group.ShowLeadingDates, this._group.ShowTrailingDates, minDate, maxDate);
				this._groupRange = new global::Infragistics.DateRange?(new global::Infragistics.DateRange(firstDateOfGroup.Value, lastDateOfGroup.Value));
				if (array.Length > 0)
				{
					this._firstDate = new global::System.DateTime?(array[0]);
					this._lastDate = new global::System.DateTime?(array[array.Length - 1]);
				}
			}
			else
			{
				array = new global::System.DateTime[0];
				this._groupRange = null;
			}
			if (array.Length == 0)
			{
				return false;
			}
			global::System.Windows.Style style = null;
			if (calendar != null)
			{
				style = (loadDays ? calendar.CalendarDayStyle : calendar.CalendarItemStyle);
				if (style == null)
				{
					global::Infragistics.Controls.Editors.CalendarResourceProvider resourceProviderResolved = calendar.ResourceProviderResolved;
					if (resourceProviderResolved != null)
					{
						style = (resourceProviderResolved[loadDays ? global::Infragistics.Controls.Editors.CalendarResourceId.CalendarDayStyle : global::Infragistics.Controls.Editors.CalendarResourceId.CalendarItemStyle] as global::System.Windows.Style);
					}
				}
			}
			if (loadDays)
			{
				int j = 0;
				int num = array.Length;
				while (j < num)
				{
					global::System.DateTime date = array[j];
					global::Infragistics.Controls.Editors.Primitives.CalendarDay calendarDay2 = new global::Infragistics.Controls.Editors.Primitives.CalendarDay(date, this._group);
					children.Add(calendarDay2);
					global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.SetItemStyleHelper(style, calendarDay2);
					calendarDay2.ApplyTemplate();
					calendarDay2.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(calendarDay2, calendar);
					j++;
				}
			}
			else
			{
				global::System.DateTime dateTime = calendarManager.GetGroupStartDate(array[0], global::Infragistics.Controls.Editors.CalendarZoomMode.Months);
				global::System.DateTime dateTime2 = calendarManager.GetGroupEndDate(array[0], global::Infragistics.Controls.Editors.CalendarZoomMode.Months);
				dateTime2 = calendarManager.AddMonths(dateTime2, -11);
				for (int k = 0; k < 12; k++)
				{
					global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem2 = new global::Infragistics.Controls.Editors.Primitives.CalendarItem(dateTime, dateTime2, this._group);
					children.Add(calendarItem2);
					dateTime = calendarManager.AddMonths(dateTime, 1);
					dateTime2 = calendarManager.AddItemOffset(dateTime, 1, global::Infragistics.Controls.Editors.CalendarZoomMode.Months);
					dateTime2 = calendarManager.AddDays(dateTime2, -1);
					global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.SetItemStyleHelper(style, calendarItem2);
					calendarItem2.ApplyTemplate();
					calendarItem2.SetValue(global::System.Windows.UIElement.VisibilityProperty, global::Infragistics.KnownBoxes.VisibilityCollapsedBox);
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(calendarItem2, calendar);
				}
			}
			return true;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000721D File Offset: 0x0000541D
		internal void VerifyItemsInitialized()
		{
			if (this._group != null && this._items.Count == 0)
			{
				this.InitializeItems(true);
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000723B File Offset: 0x0000543B
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeItems()
		{
			this.InitializeItems();
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00007243 File Offset: 0x00005443
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeDaysOfWeek()
		{
			if (this._dayOfWeekPanel != null)
			{
				this._dayOfWeekPanel.InitializeDaysOfWeek();
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00007258 File Offset: 0x00005458
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeWeekNumbers()
		{
			this.InitializeWeekNumbers();
			this.SetHeaderVisibility();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00007266 File Offset: 0x00005466
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeFirstItemOffset()
		{
			this.InitializeFirstItemOffset();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000726E File Offset: 0x0000546E
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.InitializeRowColCount()
		{
			this.InitializeCalendarModeSettings(this.CurrentMode);
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000727C File Offset: 0x0000547C
		global::System.Collections.Generic.IList<global::Infragistics.Controls.Editors.Primitives.CalendarItem> global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.Items
		{
			get
			{
				return this.Items;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00007284 File Offset: 0x00005484
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.ReinitializeItems(global::Infragistics.Controls.Editors.CalendarItemChange change)
		{
			switch (change)
			{
			case global::Infragistics.Controls.Editors.CalendarItemChange.Style:
				this.ReinitializeStyle();
				return;
			case global::Infragistics.Controls.Editors.CalendarItemChange.Enabled:
				this.ReinitializeEnabledState();
				return;
			case global::Infragistics.Controls.Editors.CalendarItemChange.Selection:
				this.ReinitializeSelectedState();
				return;
			case global::Infragistics.Controls.Editors.CalendarItemChange.Today:
				this.ReinitializeTodayState();
				return;
			case global::Infragistics.Controls.Editors.CalendarItemChange.IsSelectionActive:
				this.ReinitializeIsSelectionActive();
				return;
			case global::Infragistics.Controls.Editors.CalendarItemChange.Resources:
				this.InitializeItems();
				this.ReinitializeResources();
				return;
			default:
				((global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea)this).InitializeItems();
				return;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000072E9 File Offset: 0x000054E9
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.PrepareForAnimationAction(global::Infragistics.Controls.Editors.CalendarAnimation action)
		{
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000072EB File Offset: 0x000054EB
		void global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.PerformAnimationAction(global::Infragistics.Controls.Editors.CalendarAnimation action)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000072ED File Offset: 0x000054ED
		global::Infragistics.Controls.Editors.Primitives.CalendarItem global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.GetItem(global::System.DateTime date)
		{
			return this.GetItem(date);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000072F6 File Offset: 0x000054F6
		global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumber global::Infragistics.Controls.Editors.Primitives.ICalendarItemArea.GetWeekNumber(int weekNumber)
		{
			return this.GetWeekNumber(weekNumber);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00007300 File Offset: 0x00005500
		void global::Infragistics.Controls.Editors.Primitives.ICalendarElement.OnCalendarChanged(global::Infragistics.Controls.Editors.CalendarBase newValue, global::Infragistics.Controls.Editors.CalendarBase oldValue)
		{
			int count = this._itemsInternal.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Controls.Editors.Primitives.CalendarItem calendarItem = this._itemsInternal[i];
				if (calendarItem != null)
				{
					global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(calendarItem, newValue);
					calendarItem.InvalidateMeasure();
				}
			}
			if (this._dayOfWeekPanel != null)
			{
				global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this._dayOfWeekPanel, newValue);
			}
			if (this._weekNumberPanel != null)
			{
				global::Infragistics.Controls.Editors.CalendarBase.SetCalendar(this._weekNumberPanel, newValue);
			}
		}

		// Token: 0x0400005A RID: 90
		private const string PartDayOfWeekPanel = "DayOfWeekPanel";

		// Token: 0x0400005B RID: 91
		private const string PartWeekNumberPanel = "WeekNumberPanel";

		// Token: 0x0400005C RID: 92
		private const string PartItemPanel = "ItemPanel";

		// Token: 0x0400005D RID: 93
		private global::Infragistics.Controls.Editors.Primitives.CalendarDayOfWeekPanel _dayOfWeekPanel;

		// Token: 0x0400005E RID: 94
		private global::Infragistics.Controls.Editors.Primitives.CalendarWeekNumberPanel _weekNumberPanel;

		// Token: 0x0400005F RID: 95
		private global::Infragistics.Controls.Primitives.UniformGrid _itemPanel;

		// Token: 0x04000060 RID: 96
		private global::Infragistics.Controls.Editors.Primitives.CalendarItemGroup _group;

		// Token: 0x04000061 RID: 97
		private global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Controls.Editors.Primitives.CalendarItem> _itemsInternal;

		// Token: 0x04000062 RID: 98
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Controls.Editors.Primitives.CalendarItem> _items;

		// Token: 0x04000063 RID: 99
		private global::Infragistics.Collections.ObservableCollectionExtended<int> _weekNumbersInternal;

		// Token: 0x04000064 RID: 100
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<int> _weekNumbers;

		// Token: 0x04000065 RID: 101
		private global::Infragistics.DateRange? _groupRange;

		// Token: 0x04000066 RID: 102
		private bool _isInitialized;

		// Token: 0x04000067 RID: 103
		private global::System.DateTime? _firstDate;

		// Token: 0x04000068 RID: 104
		private global::System.DateTime? _lastDate;

		// Token: 0x04000069 RID: 105
		private static readonly global::System.Windows.DependencyPropertyKey ComputedItemsBorderThicknessPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ComputedItemsBorderThickness", typeof(global::System.Windows.Thickness), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea), new global::System.Windows.Thickness(0.0), null);

		// Token: 0x0400006A RID: 106
		public static readonly global::System.Windows.DependencyProperty ComputedItemsBorderThicknessProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ComputedItemsBorderThicknessPropertyKey.DependencyProperty;

		// Token: 0x0400006B RID: 107
		private static readonly global::System.Windows.DependencyPropertyKey DayOfWeekHeaderVisibilityPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("DayOfWeekHeaderVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea), global::Infragistics.KnownBoxes.VisibilityVisibleBox, null);

		// Token: 0x0400006C RID: 108
		public static readonly global::System.Windows.DependencyProperty DayOfWeekHeaderVisibilityProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.DayOfWeekHeaderVisibilityPropertyKey.DependencyProperty;

		// Token: 0x0400006D RID: 109
		private static readonly global::System.Windows.DependencyPropertyKey FirstItemColumnOffsetPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("FirstItemColumnOffset", typeof(int), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea), global::Infragistics.Controls.Editors.CalendarUtilities.ZeroInt, null);

		// Token: 0x0400006E RID: 110
		public static readonly global::System.Windows.DependencyProperty FirstItemColumnOffsetProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.FirstItemColumnOffsetPropertyKey.DependencyProperty;

		// Token: 0x0400006F RID: 111
		private static readonly global::System.Windows.DependencyPropertyKey FirstItemRowOffsetPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("FirstItemRowOffset", typeof(int), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea), global::Infragistics.Controls.Editors.CalendarUtilities.ZeroInt, null);

		// Token: 0x04000070 RID: 112
		public static readonly global::System.Windows.DependencyProperty FirstItemRowOffsetProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.FirstItemRowOffsetPropertyKey.DependencyProperty;

		// Token: 0x04000071 RID: 113
		private static readonly global::System.Windows.DependencyPropertyKey ItemColumnsPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ItemColumns", typeof(int), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea), global::Infragistics.Controls.Editors.CalendarUtilities.ZeroInt, null);

		// Token: 0x04000072 RID: 114
		public static readonly global::System.Windows.DependencyProperty ItemColumnsProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemColumnsPropertyKey.DependencyProperty;

		// Token: 0x04000073 RID: 115
		private static readonly global::System.Windows.DependencyPropertyKey ItemRowsPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("ItemRows", typeof(int), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea), global::Infragistics.Controls.Editors.CalendarUtilities.ZeroInt, null);

		// Token: 0x04000074 RID: 116
		public static readonly global::System.Windows.DependencyProperty ItemRowsProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.ItemRowsPropertyKey.DependencyProperty;

		// Token: 0x04000075 RID: 117
		private static readonly global::System.Windows.DependencyPropertyKey WeekNumberVisibilityPropertyKey = global::Infragistics.DependencyPropertyUtilities.RegisterReadOnly("WeekNumberVisibility", typeof(global::System.Windows.Visibility), typeof(global::Infragistics.Controls.Editors.Primitives.CalendarItemArea), global::Infragistics.KnownBoxes.VisibilityVisibleBox, null);

		// Token: 0x04000076 RID: 118
		public static readonly global::System.Windows.DependencyProperty WeekNumberVisibilityProperty = global::Infragistics.Controls.Editors.Primitives.CalendarItemArea.WeekNumberVisibilityPropertyKey.DependencyProperty;
	}
}
