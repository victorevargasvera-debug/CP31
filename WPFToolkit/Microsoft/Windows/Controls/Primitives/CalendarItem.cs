using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace Microsoft.Windows.Controls.Primitives
{
	// Token: 0x02000058 RID: 88
	[global::System.Windows.TemplateVisualState(Name = "Disabled", GroupName = "CommonStates")]
	[global::System.Windows.TemplatePart(Name = "PART_Root", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplatePart(Name = "PART_HeaderButton", Type = typeof(global::System.Windows.Controls.Button))]
	[global::System.Windows.TemplatePart(Name = "PART_PreviousButton", Type = typeof(global::System.Windows.Controls.Button))]
	[global::System.Windows.TemplatePart(Name = "PART_NextButton", Type = typeof(global::System.Windows.Controls.Button))]
	[global::System.Windows.TemplatePart(Name = "DayTitleTemplate", Type = typeof(global::System.Windows.DataTemplate))]
	[global::System.Windows.TemplatePart(Name = "PART_MonthView", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.Windows.TemplatePart(Name = "PART_YearView", Type = typeof(global::System.Windows.Controls.Grid))]
	[global::System.Windows.TemplatePart(Name = "PART_DisabledVisual", Type = typeof(global::System.Windows.FrameworkElement))]
	[global::System.Windows.TemplateVisualState(Name = "Normal", GroupName = "CommonStates")]
	public sealed class CalendarItem : global::System.Windows.Controls.Control
	{
		// Token: 0x060006DB RID: 1755 RVA: 0x0001BEE8 File Offset: 0x0001A0E8
		static CalendarItem()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.CalendarItem)));
			global::System.Windows.UIElement.FocusableProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(false));
			global::System.Windows.Input.KeyboardNavigation.TabNavigationProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Once));
			global::System.Windows.Input.KeyboardNavigation.DirectionalNavigationProperty.OverrideMetadata(typeof(global::Microsoft.Windows.Controls.Primitives.CalendarItem), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Input.KeyboardNavigationMode.Contained));
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0001BF88 File Offset: 0x0001A188
		internal global::System.Windows.Controls.Grid MonthView
		{
			get
			{
				return this._monthView;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x060006DE RID: 1758 RVA: 0x0001BF90 File Offset: 0x0001A190
		// (set) Token: 0x060006DF RID: 1759 RVA: 0x0001BF98 File Offset: 0x0001A198
		internal global::Microsoft.Windows.Controls.Calendar Owner { get; set; }

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x060006E0 RID: 1760 RVA: 0x0001BFA1 File Offset: 0x0001A1A1
		internal global::System.Windows.Controls.Grid YearView
		{
			get
			{
				return this._yearView;
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0001BFA9 File Offset: 0x0001A1A9
		private global::Microsoft.Windows.Controls.CalendarMode DisplayMode
		{
			get
			{
				if (this.Owner == null)
				{
					return global::Microsoft.Windows.Controls.CalendarMode.Month;
				}
				return this.Owner.DisplayMode;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0001BFC0 File Offset: 0x0001A1C0
		private global::System.Windows.Controls.Button HeaderButton
		{
			get
			{
				return this._headerButton;
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0001BFC8 File Offset: 0x0001A1C8
		private global::System.Windows.Controls.Button NextButton
		{
			get
			{
				return this._nextButton;
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0001BFD0 File Offset: 0x0001A1D0
		private global::System.Windows.Controls.Button PreviousButton
		{
			get
			{
				return this._previousButton;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x060006E5 RID: 1765 RVA: 0x0001BFD8 File Offset: 0x0001A1D8
		private global::System.DateTime DisplayDate
		{
			get
			{
				if (this.Owner == null)
				{
					return global::System.DateTime.Today;
				}
				return this.Owner.DisplayDate;
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001BFF4 File Offset: 0x0001A1F4
		public override void OnApplyTemplate()
		{
			base.OnApplyTemplate();
			if (this._previousButton != null)
			{
				this._previousButton.Click -= this.PreviousButton_Click;
			}
			if (this._nextButton != null)
			{
				this._nextButton.Click -= this.NextButton_Click;
			}
			if (this._headerButton != null)
			{
				this._headerButton.Click -= this.HeaderButton_Click;
			}
			this._monthView = (base.GetTemplateChild("PART_MonthView") as global::System.Windows.Controls.Grid);
			this._yearView = (base.GetTemplateChild("PART_YearView") as global::System.Windows.Controls.Grid);
			this._previousButton = (base.GetTemplateChild("PART_PreviousButton") as global::System.Windows.Controls.Button);
			this._nextButton = (base.GetTemplateChild("PART_NextButton") as global::System.Windows.Controls.Button);
			this._headerButton = (base.GetTemplateChild("PART_HeaderButton") as global::System.Windows.Controls.Button);
			this._disabledVisual = (base.GetTemplateChild("PART_DisabledVisual") as global::System.Windows.FrameworkElement);
			this._dayTitleTemplate = null;
			if (base.Template != null && base.Template.Resources.Contains("DayTitleTemplate"))
			{
				this._dayTitleTemplate = (base.Template.Resources["DayTitleTemplate"] as global::System.Windows.DataTemplate);
			}
			if (this._previousButton != null)
			{
				if (this._previousButton.Content == null)
				{
					this._previousButton.Content = global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.Calendar_PreviousButtonName);
				}
				this._previousButton.Click += this.PreviousButton_Click;
			}
			if (this._nextButton != null)
			{
				if (this._nextButton.Content == null)
				{
					this._nextButton.Content = global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.Calendar_NextButtonName);
				}
				this._nextButton.Click += this.NextButton_Click;
			}
			if (this._headerButton != null)
			{
				this._headerButton.Click += this.HeaderButton_Click;
			}
			this.PopulateGrids();
			if (this.Owner == null)
			{
				this.UpdateMonthMode();
				return;
			}
			switch (this.Owner.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
				this.UpdateMonthMode();
				return;
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
				this.UpdateYearMode();
				return;
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
				this.UpdateDecadeMode();
				return;
			default:
				return;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001C218 File Offset: 0x0001A418
		protected override void OnMouseUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseUp(e);
			if (base.IsMouseCaptured)
			{
				base.ReleaseMouseCapture();
			}
			this._isMonthPressed = false;
			this._isDayPressed = false;
			if (!e.Handled && this.Owner.DisplayMode == global::Microsoft.Windows.Controls.CalendarMode.Month && this.Owner.HoverEnd != null)
			{
				this.FinishSelection(this.Owner.HoverEnd.Value);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001C28B File Offset: 0x0001A48B
		protected override void OnLostMouseCapture(global::System.Windows.Input.MouseEventArgs e)
		{
			base.OnLostMouseCapture(e);
			if (!base.IsMouseCaptured)
			{
				this._isDayPressed = false;
				this._isMonthPressed = false;
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0001C2AC File Offset: 0x0001A4AC
		internal void UpdateDecadeMode()
		{
			global::System.DateTime selectedYear;
			if (this.Owner != null)
			{
				selectedYear = this.Owner.DisplayYear;
			}
			else
			{
				selectedYear = global::System.DateTime.Today;
			}
			int decadeForDecadeMode = this.GetDecadeForDecadeMode(selectedYear);
			int num = decadeForDecadeMode + 9;
			this.SetDecadeModeHeaderButton(decadeForDecadeMode);
			this.SetDecadeModePreviousButton(decadeForDecadeMode);
			this.SetDecadeModeNextButton(num);
			if (this._yearView != null)
			{
				this.SetYearButtons(decadeForDecadeMode, num);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0001C307 File Offset: 0x0001A507
		internal void UpdateMonthMode()
		{
			this.SetMonthModeHeaderButton();
			this.SetMonthModePreviousButton();
			this.SetMonthModeNextButton();
			if (this._monthView != null)
			{
				this.SetMonthModeDayTitles();
				this.SetMonthModeCalendarDayButtons();
				this.AddMonthModeHighlight();
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0001C335 File Offset: 0x0001A535
		internal void UpdateYearMode()
		{
			this.SetYearModeHeaderButton();
			this.SetYearModePreviousButton();
			this.SetYearModeNextButton();
			if (this._yearView != null)
			{
				this.SetYearModeMonthButtons();
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0001C4A0 File Offset: 0x0001A6A0
		internal global::System.Collections.Generic.IEnumerable<global::Microsoft.Windows.Controls.Primitives.CalendarDayButton> GetCalendarDayButtons()
		{
			int count = 49;
			if (this.MonthView != null)
			{
				global::System.Windows.Controls.UIElementCollection dayButtonsHost = this.MonthView.Children;
				for (int childIndex = 7; childIndex < count; childIndex++)
				{
					global::Microsoft.Windows.Controls.Primitives.CalendarDayButton b = dayButtonsHost[childIndex] as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
					if (b != null)
					{
						yield return b;
					}
				}
			}
			yield break;
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		internal global::Microsoft.Windows.Controls.Primitives.CalendarDayButton GetFocusedCalendarDayButton()
		{
			foreach (global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton in this.GetCalendarDayButtons())
			{
				if (calendarDayButton != null && calendarDayButton.IsFocused)
				{
					return calendarDayButton;
				}
			}
			return null;
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0001C518 File Offset: 0x0001A718
		internal global::Microsoft.Windows.Controls.Primitives.CalendarDayButton GetCalendarDayButton(global::System.DateTime date)
		{
			foreach (global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton in this.GetCalendarDayButtons())
			{
				if (calendarDayButton != null && calendarDayButton.DataContext is global::System.DateTime && global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(date, (global::System.DateTime)calendarDayButton.DataContext) == 0)
				{
					return calendarDayButton;
				}
			}
			return null;
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0001C588 File Offset: 0x0001A788
		internal global::Microsoft.Windows.Controls.Primitives.CalendarButton GetCalendarButton(global::System.DateTime date, global::Microsoft.Windows.Controls.CalendarMode mode)
		{
			foreach (global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton in this.GetCalendarButtons())
			{
				if (calendarButton != null && calendarButton.DataContext is global::System.DateTime)
				{
					if (mode == global::Microsoft.Windows.Controls.CalendarMode.Year)
					{
						if (global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(date, (global::System.DateTime)calendarButton.DataContext) == 0)
						{
							return calendarButton;
						}
					}
					else if (date.Year == ((global::System.DateTime)calendarButton.DataContext).Year)
					{
						return calendarButton;
					}
				}
			}
			return null;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0001C61C File Offset: 0x0001A81C
		internal global::Microsoft.Windows.Controls.Primitives.CalendarButton GetFocusedCalendarButton()
		{
			foreach (global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton in this.GetCalendarButtons())
			{
				if (calendarButton != null && calendarButton.IsFocused)
				{
					return calendarButton;
				}
			}
			return null;
		}

		// Token: 0x060006F1 RID: 1777 RVA: 0x0001C83C File Offset: 0x0001AA3C
		private global::System.Collections.Generic.IEnumerable<global::Microsoft.Windows.Controls.Primitives.CalendarButton> GetCalendarButtons()
		{
			foreach (object obj in this.YearView.Children)
			{
				global::System.Windows.UIElement element = (global::System.Windows.UIElement)obj;
				global::Microsoft.Windows.Controls.Primitives.CalendarButton b = element as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
				if (b != null)
				{
					yield return b;
				}
			}
			yield break;
		}

		// Token: 0x060006F2 RID: 1778 RVA: 0x0001C85C File Offset: 0x0001AA5C
		internal void FocusDate(global::System.DateTime date)
		{
			global::System.Windows.FrameworkElement frameworkElement = null;
			switch (this.DisplayMode)
			{
			case global::Microsoft.Windows.Controls.CalendarMode.Month:
				frameworkElement = this.GetCalendarDayButton(date);
				break;
			case global::Microsoft.Windows.Controls.CalendarMode.Year:
			case global::Microsoft.Windows.Controls.CalendarMode.Decade:
				frameworkElement = this.GetCalendarButton(date, this.DisplayMode);
				break;
			}
			if (frameworkElement != null && !frameworkElement.IsFocused)
			{
				frameworkElement.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
			}
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0001C8B8 File Offset: 0x0001AAB8
		private int GetDecadeForDecadeMode(global::System.DateTime selectedYear)
		{
			int num = global::Microsoft.Windows.Controls.DateTimeHelper.DecadeOfDate(selectedYear);
			if (this._isMonthPressed && this._yearView != null)
			{
				global::System.Windows.Controls.UIElementCollection children = this._yearView.Children;
				int count = children.Count;
				if (count > 0)
				{
					global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = children[0] as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
					if (calendarButton != null && calendarButton.DataContext is global::System.DateTime && ((global::System.DateTime)calendarButton.DataContext).Year == selectedYear.Year)
					{
						return num + 10;
					}
				}
				if (count > 1)
				{
					global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton2 = children[count - 1] as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
					if (calendarButton2 != null && calendarButton2.DataContext is global::System.DateTime && ((global::System.DateTime)calendarButton2.DataContext).Year == selectedYear.Year)
					{
						return num - 10;
					}
				}
			}
			return num;
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0001C984 File Offset: 0x0001AB84
		private void EndDrag(bool ctrl, global::System.DateTime selectedDate)
		{
			if (this.Owner != null)
			{
				this.Owner.CurrentDate = selectedDate;
				if (this.Owner.HoverStart != null)
				{
					if (ctrl && global::System.DateTime.Compare(this.Owner.HoverStart.Value, selectedDate) == 0 && (this.Owner.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate || this.Owner.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.MultipleRange))
					{
						this.Owner.SelectedDates.Toggle(selectedDate);
					}
					else
					{
						this.Owner.SelectedDates.AddRangeInternal(this.Owner.HoverStart.Value, selectedDate);
					}
					this.Owner.OnDayClick(selectedDate);
				}
			}
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0001CA39 File Offset: 0x0001AC39
		private void CellOrMonth_PreviewKeyDown(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.Owner == null)
			{
				return;
			}
			this.Owner.OnDayOrMonthPreviewKeyDown(e);
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0001CA50 File Offset: 0x0001AC50
		private void Cell_Clicked(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.Owner == null)
			{
				return;
			}
			global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = sender as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
			if (!(calendarDayButton.DataContext is global::System.DateTime))
			{
				return;
			}
			if (!calendarDayButton.IsBlackedOut)
			{
				global::System.DateTime dateTime = (global::System.DateTime)calendarDayButton.DataContext;
				bool flag;
				bool flag2;
				global::Microsoft.Windows.Controls.KeyboardHelper.GetMetaKeyState(out flag, out flag2);
				switch (this.Owner.SelectionMode)
				{
				case global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate:
					if (!flag)
					{
						this.Owner.SelectedDate = new global::System.DateTime?(dateTime);
					}
					else
					{
						this.Owner.SelectedDates.Toggle(dateTime);
					}
					break;
				case global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleRange:
				{
					global::System.DateTime? dateTime2 = new global::System.DateTime?(this.Owner.CurrentDate);
					this.Owner.SelectedDates.ClearInternal(true);
					if (flag2 && dateTime2 != null)
					{
						this.Owner.SelectedDates.AddRangeInternal(dateTime2.Value, dateTime);
					}
					else
					{
						this.Owner.SelectedDate = new global::System.DateTime?(dateTime);
						this.Owner.HoverStart = null;
						this.Owner.HoverEnd = null;
					}
					break;
				}
				case global::Microsoft.Windows.Controls.CalendarSelectionMode.MultipleRange:
					if (!flag)
					{
						this.Owner.SelectedDates.ClearInternal(true);
					}
					if (flag2)
					{
						this.Owner.SelectedDates.AddRangeInternal(this.Owner.CurrentDate, dateTime);
					}
					else if (!flag)
					{
						this.Owner.SelectedDate = new global::System.DateTime?(dateTime);
					}
					else
					{
						this.Owner.SelectedDates.Toggle(dateTime);
						this.Owner.HoverStart = null;
						this.Owner.HoverEnd = null;
					}
					break;
				}
				this.Owner.OnDayClick(dateTime);
			}
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x0001CC14 File Offset: 0x0001AE14
		private void Cell_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = sender as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
			if (calendarDayButton == null)
			{
				return;
			}
			if (this.Owner == null || !(calendarDayButton.DataContext is global::System.DateTime))
			{
				return;
			}
			if (calendarDayButton.IsBlackedOut)
			{
				this.Owner.HoverStart = null;
				return;
			}
			this._isDayPressed = true;
			global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree);
			calendarDayButton.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
			bool flag;
			bool flag2;
			global::Microsoft.Windows.Controls.KeyboardHelper.GetMetaKeyState(out flag, out flag2);
			global::System.DateTime dateTime = (global::System.DateTime)calendarDayButton.DataContext;
			switch (this.Owner.SelectionMode)
			{
			case global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate:
				this.Owner.DatePickerDisplayDateFlag = true;
				if (!flag)
				{
					this.Owner.SelectedDate = new global::System.DateTime?(dateTime);
				}
				else
				{
					this.Owner.SelectedDates.Toggle(dateTime);
				}
				break;
			case global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleRange:
				this.Owner.SelectedDates.ClearInternal();
				if (flag2)
				{
					if (this.Owner.HoverStart == null)
					{
						this.Owner.HoverStart = (this.Owner.HoverEnd = new global::System.DateTime?(this.Owner.CurrentDate));
					}
				}
				else
				{
					this.Owner.HoverStart = (this.Owner.HoverEnd = new global::System.DateTime?(dateTime));
				}
				break;
			case global::Microsoft.Windows.Controls.CalendarSelectionMode.MultipleRange:
				if (!flag)
				{
					this.Owner.SelectedDates.ClearInternal();
				}
				if (flag2)
				{
					if (this.Owner.HoverStart == null)
					{
						this.Owner.HoverStart = (this.Owner.HoverEnd = new global::System.DateTime?(this.Owner.CurrentDate));
					}
				}
				else
				{
					this.Owner.HoverStart = (this.Owner.HoverEnd = new global::System.DateTime?(dateTime));
				}
				break;
			}
			this.Owner.CurrentDate = dateTime;
			this.Owner.UpdateCellItems();
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0001CE08 File Offset: 0x0001B008
		private void Cell_MouseEnter(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = sender as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
			if (calendarDayButton == null)
			{
				return;
			}
			if (calendarDayButton.IsBlackedOut)
			{
				return;
			}
			if (e.LeftButton == global::System.Windows.Input.MouseButtonState.Pressed && this._isDayPressed)
			{
				calendarDayButton.MoveFocus(new global::System.Windows.Input.TraversalRequest(global::System.Windows.Input.FocusNavigationDirection.First));
				if (this.Owner == null || !(calendarDayButton.DataContext is global::System.DateTime))
				{
					return;
				}
				global::System.DateTime dateTime = (global::System.DateTime)calendarDayButton.DataContext;
				global::Microsoft.Windows.Controls.CalendarSelectionMode selectionMode = this.Owner.SelectionMode;
				if (selectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate)
				{
					this.Owner.DatePickerDisplayDateFlag = true;
					this.Owner.HoverStart = (this.Owner.HoverEnd = null);
					if (this.Owner.SelectedDates.Count == 0)
					{
						this.Owner.SelectedDates.Add(dateTime);
						return;
					}
					this.Owner.SelectedDates[0] = dateTime;
					return;
				}
				else
				{
					this.Owner.HoverEnd = new global::System.DateTime?(dateTime);
					this.Owner.CurrentDate = dateTime;
					this.Owner.UpdateCellItems();
				}
			}
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0001CF10 File Offset: 0x0001B110
		private void Cell_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = sender as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
			if (calendarDayButton == null)
			{
				return;
			}
			if (this.Owner == null)
			{
				return;
			}
			if (!calendarDayButton.IsBlackedOut)
			{
				this.Owner.OnDayButtonMouseUp(e);
			}
			if (!(calendarDayButton.DataContext is global::System.DateTime))
			{
				return;
			}
			this.FinishSelection((global::System.DateTime)calendarDayButton.DataContext);
			e.Handled = true;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0001CF6C File Offset: 0x0001B16C
		private void FinishSelection(global::System.DateTime selectedDate)
		{
			bool ctrl;
			bool flag;
			global::Microsoft.Windows.Controls.KeyboardHelper.GetMetaKeyState(out ctrl, out flag);
			if (this.Owner.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.None || this.Owner.SelectionMode == global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleDate)
			{
				this.Owner.OnDayClick(selectedDate);
				return;
			}
			if (this.Owner.HoverStart == null)
			{
				global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = this.GetCalendarDayButton(selectedDate);
				if (calendarDayButton != null && calendarDayButton.IsInactive && calendarDayButton.IsBlackedOut)
				{
					this.Owner.OnDayClick(selectedDate);
				}
				return;
			}
			switch (this.Owner.SelectionMode)
			{
			case global::Microsoft.Windows.Controls.CalendarSelectionMode.SingleRange:
				this.Owner.SelectedDates.ClearInternal();
				this.EndDrag(ctrl, selectedDate);
				return;
			case global::Microsoft.Windows.Controls.CalendarSelectionMode.MultipleRange:
				this.EndDrag(ctrl, selectedDate);
				return;
			default:
				return;
			}
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0001D028 File Offset: 0x0001B228
		private void Month_MouseLeftButtonDown(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = sender as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
			if (calendarButton != null)
			{
				this._isMonthPressed = true;
				global::System.Windows.Input.Mouse.Capture(this, global::System.Windows.Input.CaptureMode.SubTree);
				if (this.Owner != null)
				{
					this.Owner.OnCalendarButtonPressed(calendarButton, false);
				}
			}
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0001D064 File Offset: 0x0001B264
		private void Month_MouseLeftButtonUp(object sender, global::System.Windows.Input.MouseButtonEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = sender as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
			if (calendarButton != null && this.Owner != null)
			{
				this.Owner.OnCalendarButtonPressed(calendarButton, true);
			}
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0001D090 File Offset: 0x0001B290
		private void Month_MouseEnter(object sender, global::System.Windows.Input.MouseEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = sender as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
			if (calendarButton != null && this._isMonthPressed && this.Owner != null)
			{
				this.Owner.OnCalendarButtonPressed(calendarButton, false);
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0001D0C4 File Offset: 0x0001B2C4
		private void Month_Clicked(object sender, global::System.Windows.RoutedEventArgs e)
		{
			global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = sender as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
			if (calendarButton != null)
			{
				this.Owner.OnCalendarButtonPressed(calendarButton, true);
			}
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0001D0E8 File Offset: 0x0001B2E8
		private void HeaderButton_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.Owner != null)
			{
				if (this.Owner.DisplayMode == global::Microsoft.Windows.Controls.CalendarMode.Month)
				{
					this.Owner.DisplayMode = global::Microsoft.Windows.Controls.CalendarMode.Year;
				}
				else
				{
					this.Owner.DisplayMode = global::Microsoft.Windows.Controls.CalendarMode.Decade;
				}
				this.FocusDate(this.DisplayDate);
			}
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x0001D125 File Offset: 0x0001B325
		private void PreviousButton_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.Owner != null)
			{
				this.Owner.OnPreviousClick();
			}
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x0001D13A File Offset: 0x0001B33A
		private void NextButton_Click(object sender, global::System.Windows.RoutedEventArgs e)
		{
			if (this.Owner != null)
			{
				this.Owner.OnNextClick();
			}
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0001D150 File Offset: 0x0001B350
		private void PopulateGrids()
		{
			if (this._monthView != null)
			{
				if (this._dayTitleTemplate != null)
				{
					for (int i = 0; i < 7; i++)
					{
						global::System.Windows.FrameworkElement frameworkElement = (global::System.Windows.FrameworkElement)this._dayTitleTemplate.LoadContent();
						frameworkElement.SetValue(global::System.Windows.Controls.Grid.RowProperty, 0);
						frameworkElement.SetValue(global::System.Windows.Controls.Grid.ColumnProperty, i);
						this._monthView.Children.Add(frameworkElement);
					}
				}
				for (int j = 1; j < 7; j++)
				{
					for (int k = 0; k < 7; k++)
					{
						global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = new global::Microsoft.Windows.Controls.Primitives.CalendarDayButton();
						calendarDayButton.Owner = this.Owner;
						calendarDayButton.SetValue(global::System.Windows.Controls.Grid.RowProperty, j);
						calendarDayButton.SetValue(global::System.Windows.Controls.Grid.ColumnProperty, k);
						calendarDayButton.SetBinding(global::System.Windows.FrameworkElement.StyleProperty, this.GetOwnerBinding("CalendarDayButtonStyle"));
						calendarDayButton.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseLeftButtonDown), true);
						calendarDayButton.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.Cell_MouseLeftButtonUp), true);
						calendarDayButton.AddHandler(global::System.Windows.UIElement.MouseEnterEvent, new global::System.Windows.Input.MouseEventHandler(this.Cell_MouseEnter), true);
						calendarDayButton.Click += this.Cell_Clicked;
						calendarDayButton.AddHandler(global::System.Windows.UIElement.PreviewKeyDownEvent, new global::System.Windows.RoutedEventHandler(this.CellOrMonth_PreviewKeyDown), true);
						this._monthView.Children.Add(calendarDayButton);
					}
				}
			}
			if (this._yearView != null)
			{
				int num = 0;
				for (int l = 0; l < 3; l++)
				{
					for (int m = 0; m < 4; m++)
					{
						global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = new global::Microsoft.Windows.Controls.Primitives.CalendarButton();
						calendarButton.Owner = this.Owner;
						calendarButton.SetValue(global::System.Windows.Controls.Grid.RowProperty, l);
						calendarButton.SetValue(global::System.Windows.Controls.Grid.ColumnProperty, m);
						calendarButton.SetBinding(global::System.Windows.FrameworkElement.StyleProperty, this.GetOwnerBinding("CalendarButtonStyle"));
						calendarButton.AddHandler(global::System.Windows.UIElement.MouseLeftButtonDownEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.Month_MouseLeftButtonDown), true);
						calendarButton.AddHandler(global::System.Windows.UIElement.MouseLeftButtonUpEvent, new global::System.Windows.Input.MouseButtonEventHandler(this.Month_MouseLeftButtonUp), true);
						calendarButton.AddHandler(global::System.Windows.UIElement.MouseEnterEvent, new global::System.Windows.Input.MouseEventHandler(this.Month_MouseEnter), true);
						calendarButton.AddHandler(global::System.Windows.UIElement.PreviewKeyDownEvent, new global::System.Windows.RoutedEventHandler(this.CellOrMonth_PreviewKeyDown), true);
						calendarButton.Click += this.Month_Clicked;
						this._yearView.Children.Add(calendarButton);
						num++;
					}
				}
			}
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0001D3DC File Offset: 0x0001B5DC
		private void SetMonthModeDayTitles()
		{
			if (this._monthView != null)
			{
				string[] shortestDayNames = global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this)).ShortestDayNames;
				for (int i = 0; i < 7; i++)
				{
					global::System.Windows.FrameworkElement frameworkElement = this._monthView.Children[i] as global::System.Windows.FrameworkElement;
					if (frameworkElement != null && shortestDayNames != null && shortestDayNames.Length > 0)
					{
						if (this.Owner != null)
						{
							frameworkElement.DataContext = shortestDayNames[(int)((i + this.Owner.FirstDayOfWeek) % (global::System.DayOfWeek)shortestDayNames.Length)];
						}
						else
						{
							frameworkElement.DataContext = shortestDayNames[(int)((i + global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this)).FirstDayOfWeek) % (global::System.DayOfWeek)shortestDayNames.Length)];
						}
					}
				}
			}
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0001D478 File Offset: 0x0001B678
		private void SetMonthModeCalendarDayButtons()
		{
			global::System.DateTime dateTime = global::Microsoft.Windows.Controls.DateTimeHelper.DiscardDayTime(this.DisplayDate);
			int numberOfDisplayedDaysFromPreviousMonth = this.GetNumberOfDisplayedDaysFromPreviousMonth(dateTime);
			bool flag = global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(dateTime, global::System.DateTime.MinValue) <= 0;
			bool flag2 = global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(dateTime, global::System.DateTime.MaxValue) >= 0;
			int daysInMonth = this._calendar.GetDaysInMonth(dateTime.Year, dateTime.Month);
			global::System.Globalization.CultureInfo culture = global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this);
			int num = 49;
			for (int i = 7; i < num; i++)
			{
				global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = this._monthView.Children[i] as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
				int num2 = i - numberOfDisplayedDaysFromPreviousMonth - 7;
				if ((!flag || num2 >= 0) && (!flag2 || num2 < daysInMonth))
				{
					global::System.DateTime dateTime2 = this._calendar.AddDays(dateTime, num2);
					this.SetMonthModeDayButtonState(calendarDayButton, new global::System.DateTime?(dateTime2));
					calendarDayButton.DataContext = dateTime2;
					calendarDayButton.SetContentInternal(global::Microsoft.Windows.Controls.DateTimeHelper.ToDayString(new global::System.DateTime?(dateTime2), culture));
				}
				else
				{
					this.SetMonthModeDayButtonState(calendarDayButton, null);
					calendarDayButton.DataContext = null;
					calendarDayButton.SetContentInternal(global::Microsoft.Windows.Controls.DateTimeHelper.ToDayString(null, culture));
				}
			}
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x0001D5A4 File Offset: 0x0001B7A4
		private void SetMonthModeDayButtonState(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton childButton, global::System.DateTime? dateToAdd)
		{
			if (this.Owner != null)
			{
				if (dateToAdd != null)
				{
					childButton.Visibility = global::System.Windows.Visibility.Visible;
					if (global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(dateToAdd.Value, this.Owner.DisplayDateStartInternal) < 0 || global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(dateToAdd.Value, this.Owner.DisplayDateEndInternal) > 0)
					{
						childButton.IsEnabled = false;
						childButton.Visibility = global::System.Windows.Visibility.Hidden;
						return;
					}
					childButton.IsEnabled = true;
					childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsBlackedOutPropertyKey, this.Owner.BlackoutDates.Contains(dateToAdd.Value));
					childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsInactivePropertyKey, global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(dateToAdd.Value, this.Owner.DisplayDateInternal) != 0);
					if (global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(dateToAdd.Value, global::System.DateTime.Today) == 0)
					{
						childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsTodayPropertyKey, true);
						childButton.ChangeVisualState(true);
					}
					else
					{
						childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsTodayPropertyKey, false);
					}
					bool flag = false;
					foreach (global::System.DateTime dt in this.Owner.SelectedDates)
					{
						flag |= (global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(dateToAdd.Value, dt) == 0);
					}
					childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsSelectedPropertyKey, flag);
					return;
				}
				else
				{
					childButton.Visibility = global::System.Windows.Visibility.Hidden;
					childButton.IsEnabled = false;
					childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsBlackedOutPropertyKey, false);
					childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsInactivePropertyKey, true);
					childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsTodayPropertyKey, false);
					childButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsSelectedPropertyKey, false);
				}
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0001D764 File Offset: 0x0001B964
		private void AddMonthModeHighlight()
		{
			global::Microsoft.Windows.Controls.Calendar owner = this.Owner;
			if (owner == null)
			{
				return;
			}
			if (owner.HoverStart != null && owner.HoverEnd != null)
			{
				global::System.DateTime value = owner.HoverEnd.Value;
				global::System.DateTime value2 = owner.HoverEnd.Value;
				int num = global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(owner.HoverEnd.Value, owner.HoverStart.Value);
				if (num < 0)
				{
					value2 = this.Owner.HoverStart.Value;
				}
				else
				{
					value = this.Owner.HoverStart.Value;
				}
				int num2 = 49;
				for (int i = 7; i < num2; i++)
				{
					global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton = this._monthView.Children[i] as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
					if (calendarDayButton.DataContext is global::System.DateTime)
					{
						global::System.DateTime date = (global::System.DateTime)calendarDayButton.DataContext;
						calendarDayButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsHighlightedPropertyKey, num != 0 && global::Microsoft.Windows.Controls.DateTimeHelper.InRange(date, value, value2));
					}
					else
					{
						calendarDayButton.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsHighlightedPropertyKey, false);
					}
				}
				return;
			}
			int num3 = 49;
			for (int j = 7; j < num3; j++)
			{
				global::Microsoft.Windows.Controls.Primitives.CalendarDayButton calendarDayButton2 = this._monthView.Children[j] as global::Microsoft.Windows.Controls.Primitives.CalendarDayButton;
				calendarDayButton2.SetValue(global::Microsoft.Windows.Controls.Primitives.CalendarDayButton.IsHighlightedPropertyKey, false);
			}
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001D8D7 File Offset: 0x0001BAD7
		private void SetMonthModeHeaderButton()
		{
			if (this._headerButton != null)
			{
				this._headerButton.Content = global::Microsoft.Windows.Controls.DateTimeHelper.ToYearMonthPatternString(new global::System.DateTime?(this.DisplayDate), global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this));
				if (this.Owner != null)
				{
					this._headerButton.IsEnabled = true;
				}
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001D918 File Offset: 0x0001BB18
		private void SetMonthModeNextButton()
		{
			if (this.Owner != null && this._nextButton != null)
			{
				global::System.DateTime dateTime = global::Microsoft.Windows.Controls.DateTimeHelper.DiscardDayTime(this.DisplayDate);
				if (global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(dateTime, global::System.DateTime.MaxValue) == 0)
				{
					this._nextButton.IsEnabled = false;
					return;
				}
				global::System.DateTime dt = this._calendar.AddMonths(dateTime, 1);
				this._nextButton.IsEnabled = (global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(this.Owner.DisplayDateEndInternal, dt) > -1);
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0001D988 File Offset: 0x0001BB88
		private void SetMonthModePreviousButton()
		{
			if (this.Owner != null && this._previousButton != null)
			{
				global::System.DateTime dt = global::Microsoft.Windows.Controls.DateTimeHelper.DiscardDayTime(this.DisplayDate);
				this._previousButton.IsEnabled = (global::Microsoft.Windows.Controls.DateTimeHelper.CompareDays(this.Owner.DisplayDateStartInternal, dt) < 0);
			}
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x0001D9D0 File Offset: 0x0001BBD0
		private void SetYearButtons(int decade, int decadeEnd)
		{
			int num = -1;
			foreach (object obj in this._yearView.Children)
			{
				global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = obj as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
				int num2 = decade + num;
				if (num2 <= global::System.DateTime.MaxValue.Year && num2 >= global::System.DateTime.MinValue.Year)
				{
					global::System.DateTime dateTime = new global::System.DateTime(num2, 1, 1);
					calendarButton.DataContext = dateTime;
					calendarButton.SetContentInternal(global::Microsoft.Windows.Controls.DateTimeHelper.ToYearString(new global::System.DateTime?(dateTime), global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this)));
					calendarButton.Visibility = global::System.Windows.Visibility.Visible;
					if (this.Owner != null)
					{
						calendarButton.HasSelectedDays = (this.Owner.DisplayDate.Year == num2);
						if (num2 < this.Owner.DisplayDateStartInternal.Year || num2 > this.Owner.DisplayDateEndInternal.Year)
						{
							calendarButton.IsEnabled = false;
							calendarButton.Opacity = 0.0;
						}
						else
						{
							calendarButton.IsEnabled = true;
							calendarButton.Opacity = 1.0;
						}
					}
					calendarButton.IsInactive = (num2 < decade || num2 > decadeEnd);
				}
				else
				{
					calendarButton.DataContext = null;
					calendarButton.IsEnabled = false;
					calendarButton.Opacity = 0.0;
				}
				num++;
			}
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x0001DB5C File Offset: 0x0001BD5C
		private void SetYearModeMonthButtons()
		{
			int num = 0;
			foreach (object obj in this._yearView.Children)
			{
				global::Microsoft.Windows.Controls.Primitives.CalendarButton calendarButton = obj as global::Microsoft.Windows.Controls.Primitives.CalendarButton;
				global::System.DateTime dateTime = new global::System.DateTime(this.DisplayDate.Year, num + 1, 1);
				calendarButton.DataContext = dateTime;
				calendarButton.SetContentInternal(global::Microsoft.Windows.Controls.DateTimeHelper.ToAbbreviatedMonthString(new global::System.DateTime?(dateTime), global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this)));
				calendarButton.Visibility = global::System.Windows.Visibility.Visible;
				if (this.Owner != null)
				{
					calendarButton.HasSelectedDays = (global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(dateTime, this.Owner.DisplayDateInternal) == 0);
					if (global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(dateTime, this.Owner.DisplayDateStartInternal) < 0 || global::Microsoft.Windows.Controls.DateTimeHelper.CompareYearMonth(dateTime, this.Owner.DisplayDateEndInternal) > 0)
					{
						calendarButton.IsEnabled = false;
						calendarButton.Opacity = 0.0;
					}
					else
					{
						calendarButton.IsEnabled = true;
						calendarButton.Opacity = 1.0;
					}
				}
				calendarButton.IsInactive = false;
				num++;
			}
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x0001DC8C File Offset: 0x0001BE8C
		private void SetYearModeHeaderButton()
		{
			if (this._headerButton != null)
			{
				this._headerButton.IsEnabled = true;
				this._headerButton.Content = global::Microsoft.Windows.Controls.DateTimeHelper.ToYearString(new global::System.DateTime?(this.DisplayDate), global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this));
			}
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0001DCC4 File Offset: 0x0001BEC4
		private void SetYearModeNextButton()
		{
			if (this.Owner != null && this._nextButton != null)
			{
				this._nextButton.IsEnabled = (this.Owner.DisplayDateEndInternal.Year != this.DisplayDate.Year);
			}
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0001DD14 File Offset: 0x0001BF14
		private void SetYearModePreviousButton()
		{
			if (this.Owner != null && this._previousButton != null)
			{
				this._previousButton.IsEnabled = (this.Owner.DisplayDateStartInternal.Year != this.DisplayDate.Year);
			}
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0001DD62 File Offset: 0x0001BF62
		private void SetDecadeModeHeaderButton(int decade)
		{
			if (this._headerButton != null)
			{
				this._headerButton.Content = global::Microsoft.Windows.Controls.DateTimeHelper.ToDecadeRangeString(decade, global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this));
				this._headerButton.IsEnabled = false;
			}
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0001DD90 File Offset: 0x0001BF90
		private void SetDecadeModeNextButton(int decadeEnd)
		{
			if (this.Owner != null && this._nextButton != null)
			{
				this._nextButton.IsEnabled = (this.Owner.DisplayDateEndInternal.Year > decadeEnd);
			}
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0001DDD0 File Offset: 0x0001BFD0
		private void SetDecadeModePreviousButton(int decade)
		{
			if (this.Owner != null && this._previousButton != null)
			{
				this._previousButton.IsEnabled = (decade > this.Owner.DisplayDateStartInternal.Year);
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0001DE10 File Offset: 0x0001C010
		private int GetNumberOfDisplayedDaysFromPreviousMonth(global::System.DateTime firstOfMonth)
		{
			global::System.DayOfWeek dayOfWeek = this._calendar.GetDayOfWeek(firstOfMonth);
			int num;
			if (this.Owner != null)
			{
				num = (dayOfWeek - this.Owner.FirstDayOfWeek + 7) % 7;
			}
			else
			{
				num = (dayOfWeek - global::Microsoft.Windows.Controls.DateTimeHelper.GetDateFormat(global::Microsoft.Windows.Controls.DateTimeHelper.GetCulture(this)).FirstDayOfWeek + 7) % 7;
			}
			if (num == 0)
			{
				return 7;
			}
			return num;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0001DE64 File Offset: 0x0001C064
		private global::System.Windows.Data.BindingBase GetOwnerBinding(string propertyName)
		{
			return new global::System.Windows.Data.Binding(propertyName)
			{
				Source = this.Owner
			};
		}

		// Token: 0x040001F1 RID: 497
		private const string ElementRoot = "PART_Root";

		// Token: 0x040001F2 RID: 498
		private const string ElementHeaderButton = "PART_HeaderButton";

		// Token: 0x040001F3 RID: 499
		private const string ElementPreviousButton = "PART_PreviousButton";

		// Token: 0x040001F4 RID: 500
		private const string ElementNextButton = "PART_NextButton";

		// Token: 0x040001F5 RID: 501
		private const string ElementDayTitleTemplate = "DayTitleTemplate";

		// Token: 0x040001F6 RID: 502
		private const string ElementMonthView = "PART_MonthView";

		// Token: 0x040001F7 RID: 503
		private const string ElementYearView = "PART_YearView";

		// Token: 0x040001F8 RID: 504
		private const string ElementDisabledVisual = "PART_DisabledVisual";

		// Token: 0x040001F9 RID: 505
		private const int COLS = 7;

		// Token: 0x040001FA RID: 506
		private const int ROWS = 7;

		// Token: 0x040001FB RID: 507
		private const int YEAR_COLS = 4;

		// Token: 0x040001FC RID: 508
		private const int YEAR_ROWS = 3;

		// Token: 0x040001FD RID: 509
		private const int NUMBER_OF_DAYS_IN_WEEK = 7;

		// Token: 0x040001FE RID: 510
		private global::System.Globalization.Calendar _calendar = new global::System.Globalization.GregorianCalendar();

		// Token: 0x040001FF RID: 511
		private global::System.Windows.DataTemplate _dayTitleTemplate;

		// Token: 0x04000200 RID: 512
		private global::System.Windows.FrameworkElement _disabledVisual;

		// Token: 0x04000201 RID: 513
		private global::System.Windows.Controls.Button _headerButton;

		// Token: 0x04000202 RID: 514
		private global::System.Windows.Controls.Grid _monthView;

		// Token: 0x04000203 RID: 515
		private global::System.Windows.Controls.Button _nextButton;

		// Token: 0x04000204 RID: 516
		private global::System.Windows.Controls.Button _previousButton;

		// Token: 0x04000205 RID: 517
		private global::System.Windows.Controls.Grid _yearView;

		// Token: 0x04000206 RID: 518
		private bool _isMonthPressed;

		// Token: 0x04000207 RID: 519
		private bool _isDayPressed;
	}
}
