using System;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Controls;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200003A RID: 58
	internal class CalendarManager : global::Infragistics.Controls.CalendarHelper
	{
		// Token: 0x060003E6 RID: 998 RVA: 0x000107F6 File Offset: 0x0000E9F6
		internal CalendarManager() : base(global::System.Globalization.CultureInfo.CurrentCulture)
		{
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0001080A File Offset: 0x0000EA0A
		internal CalendarManager(global::System.Globalization.CultureInfo culture) : base(culture)
		{
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001081A File Offset: 0x0000EA1A
		internal static global::Infragistics.Windows.Editors.CalendarManager CurrentCulture
		{
			get
			{
				if (global::Infragistics.Windows.Editors.CalendarManager.currentCulture == null)
				{
					global::Infragistics.Windows.Editors.CalendarManager.currentCulture = new global::Infragistics.Windows.Editors.CalendarManager();
				}
				return global::Infragistics.Windows.Editors.CalendarManager.currentCulture;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00010832 File Offset: 0x0000EA32
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0001083C File Offset: 0x0000EA3C
		public global::Infragistics.Controls.DayOfWeekFlags HiddenDays
		{
			get
			{
				return this._hiddenDays;
			}
			set
			{
				this.VerifyCanChange();
				this._hiddenDays = value;
				this._visibleDayCount = 0;
				for (int i = 0; i < 7; i++)
				{
					if (!global::Infragistics.Controls.CalendarHelper.IsSet(value, (global::System.DayOfWeek)i))
					{
						this._visibleDayCount++;
					}
				}
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00010880 File Offset: 0x0000EA80
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x00010888 File Offset: 0x0000EA88
		public global::System.DayOfWeek? FirstDayOfWeek
		{
			get
			{
				return this._firstDayOfWeek;
			}
			set
			{
				this.VerifyCanChange();
				this._firstDayOfWeek = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00010897 File Offset: 0x0000EA97
		internal global::System.DayOfWeek FirstDayOfWeekResolved
		{
			get
			{
				if (this._firstDayOfWeek == null)
				{
					return base.DateTimeFormat.FirstDayOfWeek;
				}
				return this._firstDayOfWeek.Value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x000108BD File Offset: 0x0000EABD
		public int VisibleDayCount
		{
			get
			{
				return this._visibleDayCount;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x000108C5 File Offset: 0x0000EAC5
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x000108CD File Offset: 0x0000EACD
		public global::System.Globalization.CalendarWeekRule? WeekRule
		{
			get
			{
				return this._weekRule;
			}
			set
			{
				this.VerifyCanChange();
				this._weekRule = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000108DC File Offset: 0x0000EADC
		internal global::System.Globalization.CalendarWeekRule WeekRuleResolved
		{
			get
			{
				if (this._weekRule == null)
				{
					return base.DateTimeFormat.CalendarWeekRule;
				}
				return this._weekRule.Value;
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00010904 File Offset: 0x0000EB04
		internal global::System.DateTime? TryAddGroupOffset(global::System.DateTime date, int offset, global::Infragistics.Windows.Editors.CalendarMode mode, bool adjustForStart)
		{
			try
			{
				switch (mode)
				{
				default:
					date = base.Calendar.AddMonths(date, offset);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Months:
					date = base.Calendar.AddYears(date, offset);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int num = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Windows.Editors.CalendarMode.Years)));
					date = base.Calendar.AddYears(date, offset * num);
					break;
				}
				}
			}
			catch (global::System.ArgumentException)
			{
				if (offset < 0)
				{
					global::System.DateTime? dateTime = this.TryAddGroupOffset(date, offset + 1, mode, false);
					if (dateTime != null && dateTime > base.Calendar.MinSupportedDateTime && dateTime <= date)
					{
						date = base.Calendar.MinSupportedDateTime;
						if (adjustForStart)
						{
							date = this.GetGroupStartDate(date, mode);
						}
						return new global::System.DateTime?(date);
					}
				}
				return null;
			}
			if (adjustForStart)
			{
				date = this.GetGroupStartDate(date, mode);
			}
			return new global::System.DateTime?(date);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00010A40 File Offset: 0x0000EC40
		internal global::System.DateTime AddGroupOffset(global::System.DateTime date, int offset, global::Infragistics.Windows.Editors.CalendarMode mode, bool adjustForStart)
		{
			global::System.DateTime? dateTime = this.TryAddGroupOffset(date, offset, mode, adjustForStart);
			if (dateTime == null)
			{
				dateTime = new global::System.DateTime?(global::Infragistics.Controls.CalendarHelper.GetMinMax(base.Calendar, offset < 0).Date);
				if (adjustForStart)
				{
					dateTime = new global::System.DateTime?(this.GetGroupStartDate(dateTime.Value, mode));
				}
			}
			return dateTime.Value;
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		internal global::System.DateTime? TryAddItemOffset(global::System.DateTime date, int offset, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			try
			{
				switch (mode)
				{
				default:
					date = base.Calendar.AddDays(date, offset);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Months:
					date = base.Calendar.AddMonths(date, offset);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int num = (int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
					date = base.Calendar.AddYears(date, offset * num);
					break;
				}
				}
			}
			catch (global::System.ArgumentException)
			{
				return null;
			}
			return new global::System.DateTime?(date);
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00010B38 File Offset: 0x0000ED38
		internal global::System.DateTime AddItemOffset(global::System.DateTime date, int offset, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			global::System.DateTime? dateTime = this.TryAddItemOffset(date, offset, mode);
			if (dateTime == null)
			{
				if (offset < 0)
				{
					dateTime = new global::System.DateTime?(base.Calendar.MinSupportedDateTime.Date);
				}
				else
				{
					dateTime = new global::System.DateTime?(base.Calendar.MaxSupportedDateTime.Date);
				}
			}
			return dateTime.Value;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00010B9C File Offset: 0x0000ED9C
		private static global::System.DateTime FindVisibleDate(global::System.DateTime date, global::Infragistics.Controls.DayOfWeekFlags hiddenDays, global::System.Globalization.Calendar calendar, int offset)
		{
			try
			{
				while (global::Infragistics.Controls.CalendarHelper.IsSet(hiddenDays, calendar.GetDayOfWeek(date)))
				{
					date = calendar.AddDays(date, offset);
				}
			}
			catch (global::System.ArgumentException)
			{
				if (offset > 0)
				{
					date = calendar.MaxSupportedDateTime;
				}
				else
				{
					date = calendar.MinSupportedDateTime;
				}
			}
			return date;
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00010BF0 File Offset: 0x0000EDF0
		private int GetDateCount(global::Infragistics.Windows.Editors.CalendarMode mode, bool includeLeadingDates, bool includeTrailingDates, ref global::System.DateTime firstDate)
		{
			global::System.DateTime dateTime = firstDate;
			global::System.Globalization.Calendar calendar = base.Calendar;
			global::System.DateTime groupStartDate = global::Infragistics.Windows.Editors.CalendarManager.GetGroupStartDate(dateTime, mode, calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
			global::System.DateTime groupEndDate = global::Infragistics.Windows.Editors.CalendarManager.GetGroupEndDate(dateTime, mode, calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
			int num;
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
				num = base.GetDaysInMonth(dateTime);
				goto IL_B2;
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
			{
				int year = calendar.GetYear(dateTime);
				int era = calendar.GetEra(dateTime);
				num = calendar.GetMonthsInYear(year, era);
				goto IL_B2;
			}
			}
			double num2 = global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
			int num3 = (int)global::System.Math.Floor((double)calendar.GetYear(groupEndDate) / num2);
			int num4 = (int)global::System.Math.Floor((double)calendar.GetYear(groupStartDate) / num2);
			num = 1 + num3 - num4;
			IL_B2:
			if (includeLeadingDates)
			{
				switch (mode)
				{
				case global::Infragistics.Windows.Editors.CalendarMode.Days:
				{
					int num5 = this.GetDayOfWeekNumber(groupStartDate, false);
					if (num5 == 0 && global::System.Math.Ceiling((double)base.GetDaysInMonth(dateTime) / 7.0) <= 5.0)
					{
						num5 += 7;
					}
					firstDate = base.AddDays(groupStartDate, -num5).Date;
					num += groupStartDate.Subtract(firstDate).Days;
					break;
				}
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int years = -(int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
					firstDate = base.AddYears(groupStartDate, years).Date;
					if (firstDate < dateTime)
					{
						num++;
					}
					break;
				}
				}
			}
			if (includeTrailingDates)
			{
				switch (mode)
				{
				case global::Infragistics.Windows.Editors.CalendarMode.Days:
				{
					int num6 = num;
					num += 6 - this.GetDayOfWeekNumber(groupEndDate, false);
					if (num6 == 35 || this.GetDayOfWeekNumber(groupStartDate, false) != 0)
					{
						int num7 = (int)global::System.Math.Ceiling((double)num / 7.0);
						num += 7 * (6 - num7);
					}
					break;
				}
				case global::Infragistics.Windows.Editors.CalendarMode.Months:
					break;
				default:
					num++;
					break;
				}
			}
			if (!includeLeadingDates && mode == global::Infragistics.Windows.Editors.CalendarMode.Days && groupStartDate < firstDate)
			{
				num -= firstDate.Subtract(groupStartDate).Days;
			}
			return num;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00010E1A File Offset: 0x0000F01A
		public int GetDayOfWeekNumber(global::System.DateTime date)
		{
			return base.GetDayOfWeekNumber(date, global::Infragistics.Controls.DayOfWeekFlags.None, this._firstDayOfWeek);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00010E2C File Offset: 0x0000F02C
		public int GetDayOfWeekNumber(global::System.DateTime date, bool honorDisabledDays)
		{
			global::Infragistics.Controls.DayOfWeekFlags hiddenDays = honorDisabledDays ? this._hiddenDays : global::Infragistics.Controls.DayOfWeekFlags.None;
			return base.GetDayOfWeekNumber(date, hiddenDays, this._firstDayOfWeek);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00010E54 File Offset: 0x0000F054
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetString(name, null);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00010E5D File Offset: 0x0000F05D
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00010E68 File Offset: 0x0000F068
		internal static int GetItemColumnCount(global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			switch (mode)
			{
			default:
				return 7;
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
				return 4;
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				return 4;
			}
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00010E98 File Offset: 0x0000F098
		internal global::System.DateTime[] GetItemDates(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, bool includeLeadingDates, bool includeTrailingDates, global::System.DateTime minDate, global::System.DateTime maxDate)
		{
			global::System.DateTime dateTime = date;
			global::System.Globalization.Calendar calendar = base.Calendar;
			int dateCount = this.GetDateCount(mode, includeLeadingDates, includeTrailingDates, ref dateTime);
			global::System.DateTime[] array = new global::System.DateTime[dateCount];
			global::System.DateTime dateTime2 = dateTime;
			global::Infragistics.Controls.DayOfWeekFlags dayOfWeekFlags = (mode == global::Infragistics.Windows.Editors.CalendarMode.Days) ? this._hiddenDays : global::Infragistics.Controls.DayOfWeekFlags.None;
			int num = 0;
			for (int i = 0; i < dateCount; i++)
			{
				if (dayOfWeekFlags == global::Infragistics.Controls.DayOfWeekFlags.None || !global::Infragistics.Controls.CalendarHelper.IsSet(dayOfWeekFlags, calendar.GetDayOfWeek(dateTime2)))
				{
					global::System.DateTime itemEndDate = this.GetItemEndDate(dateTime2, mode);
					if (!(itemEndDate < minDate) && !(dateTime2 > maxDate))
					{
						array[num] = dateTime2;
						num++;
					}
				}
				dateTime2 = this.AddItemOffset(dateTime2, 1, mode);
				dateTime2 = this.GetItemStartDate(dateTime2, mode);
				if ((num == 0 && dateTime2 <= this.GetItemEndDate(dateTime, mode)) || (num > 0 && dateTime2 <= this.GetItemEndDate(array[num - 1], mode)))
				{
					break;
				}
			}
			if (array.Length > num)
			{
				global::System.Array.Resize<global::System.DateTime>(ref array, num);
			}
			return array;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00010F98 File Offset: 0x0000F198
		internal void GetItemRowColumn(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.DateTime groupStartDate, bool showsLeadingDates, out int colOffset, out int rowOffset)
		{
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
			{
				rowOffset = 0;
				colOffset = this.GetDayOfWeekNumber(date, true);
				global::System.DateTime groupStartDate2 = global::Infragistics.Windows.Editors.CalendarManager.GetGroupStartDate(groupStartDate, mode, base.Calendar, global::Infragistics.Controls.DayOfWeekFlags.None);
				int dayOfWeekNumber = this.GetDayOfWeekNumber(groupStartDate2, false);
				if (dayOfWeekNumber == 0 && (!showsLeadingDates || date >= groupStartDate2) && base.GetDaysInMonth(groupStartDate2) < 35)
				{
					rowOffset = 1;
				}
				if (date > groupStartDate2)
				{
					int num = base.GetDayOfMonth(date) - 1;
					num += dayOfWeekNumber;
					rowOffset += num / 7;
					return;
				}
				return;
			}
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
			{
				int num2 = base.Calendar.GetMonth(date) - 1;
				colOffset = num2 % 4;
				rowOffset = num2 / 4;
				return;
			}
			}
			double num3 = global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
			int num4 = ((int)global::System.Math.Floor((double)base.Calendar.GetYear(date) / num3) + 1) % 10;
			colOffset = num4 % 4;
			rowOffset = num4 / 4;
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x0001108C File Offset: 0x0000F28C
		internal static string GetDayOfWeekCaption(global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat format, global::System.DayOfWeek day, global::System.Globalization.DateTimeFormatInfo formatInfo)
		{
			formatInfo = (formatInfo ?? global::System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat);
			string text;
			if (format == global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.Abbreviated)
			{
				text = formatInfo.AbbreviatedDayNames[(int)day];
			}
			else
			{
				text = formatInfo.DayNames[(int)day];
				switch (format)
				{
				case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.SingleCharacter:
					text = global::Infragistics.Windows.Editors.CalendarManager.GetShortDayOfWeekCaption(text, 1, formatInfo);
					break;
				case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.TwoCharacters:
					text = global::Infragistics.Windows.Editors.CalendarManager.GetShortDayOfWeekCaption(text, 2, formatInfo);
					break;
				}
			}
			return text;
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x000110EC File Offset: 0x0000F2EC
		private static string GetDayOfWeekCaption(string dayOfWeek, int index, int length)
		{
			int[] array = global::System.Globalization.StringInfo.ParseCombiningCharacters(dayOfWeek);
			int num = array.Length;
			if (index >= array.Length)
			{
				return null;
			}
			if (num <= length)
			{
				return dayOfWeek;
			}
			if (num == index + length)
			{
				return dayOfWeek.Substring(array[index]);
			}
			return dayOfWeek.Substring(array[index], array[index + length] - array[index]);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00011134 File Offset: 0x0000F334
		internal string[] GetDayOfWeekCaptions(global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat format)
		{
			string[] array;
			switch (format)
			{
			case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.SingleCharacter:
				array = this.GetShortDaysOfWeek(1);
				break;
			case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.TwoCharacters:
				array = this.GetShortDaysOfWeek(2);
				break;
			default:
				array = base.DateTimeFormat.AbbreviatedDayNames;
				break;
			case global::Infragistics.Windows.Editors.DayOfWeekHeaderFormat.Full:
				array = base.DateTimeFormat.DayNames;
				break;
			}
			int firstDayOfWeekResolved = (int)this.FirstDayOfWeekResolved;
			if (firstDayOfWeekResolved > 0)
			{
				string[] array2 = new string[firstDayOfWeekResolved];
				global::System.Array.Copy(array, 0, array2, 0, firstDayOfWeekResolved);
				global::System.Array.Copy(array, firstDayOfWeekResolved, array, 0, 7 - firstDayOfWeekResolved);
				global::System.Array.Copy(array2, 0, array, 7 - firstDayOfWeekResolved, firstDayOfWeekResolved);
			}
			return array;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000111BC File Offset: 0x0000F3BC
		internal global::System.DayOfWeek[] GetDaysOfWeek()
		{
			int firstDayOfWeekResolved = (int)this.FirstDayOfWeekResolved;
			global::System.Collections.Generic.List<global::System.DayOfWeek> list = new global::System.Collections.Generic.List<global::System.DayOfWeek>(this.VisibleDayCount);
			for (int i = 0; i < 7; i++)
			{
				global::System.DayOfWeek dayOfWeek = (global::System.DayOfWeek)((i + firstDayOfWeekResolved) % 7);
				if (!global::Infragistics.Controls.CalendarHelper.IsSet(this.HiddenDays, dayOfWeek))
				{
					list.Add(dayOfWeek);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00011209 File Offset: 0x0000F409
		internal global::System.DateTime GetGroupEndDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetGroupEndDate(date, mode, base.Calendar, this._hiddenDays);
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00011220 File Offset: 0x0000F420
		internal static global::System.DateTime GetGroupEndDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.Globalization.Calendar calendar, global::Infragistics.Controls.DayOfWeekFlags hiddenDays)
		{
			int month = calendar.GetMonth(date);
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			int daysInMonth = calendar.GetDaysInMonth(num, month, era);
			global::System.DateTime dateTime;
			try
			{
				switch (mode)
				{
				case global::Infragistics.Windows.Editors.CalendarMode.Months:
					month = calendar.GetMonthsInYear(num, era);
					daysInMonth = calendar.GetDaysInMonth(num, month, era);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Windows.Editors.CalendarMode.Years)));
					num += num2 - 1 - num % num2;
					month = calendar.GetMonthsInYear(num, era);
					daysInMonth = calendar.GetDaysInMonth(num, month, era);
					break;
				}
				}
				dateTime = calendar.ToDateTime(num, month, daysInMonth, 0, 0, 0, 0, era);
			}
			catch (global::System.ArgumentException)
			{
				dateTime = calendar.MaxSupportedDateTime;
			}
			if (hiddenDays == (global::Infragistics.Controls.DayOfWeekFlags.Sunday | global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday | global::Infragistics.Controls.DayOfWeekFlags.Saturday))
			{
				return dateTime;
			}
			return global::Infragistics.Windows.Editors.CalendarManager.FindVisibleDate(dateTime, hiddenDays, calendar, -1);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x000112FC File Offset: 0x0000F4FC
		internal global::System.DateTime GetItemEndDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetItemEndDate(date, mode, base.Calendar);
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0001130C File Offset: 0x0000F50C
		internal static global::System.DateTime GetItemEndDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.Globalization.Calendar calendar)
		{
			int month = calendar.GetMonth(date);
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			int day = calendar.GetDaysInMonth(num, month, era);
			global::System.DateTime result;
			try
			{
				switch (mode)
				{
				case global::Infragistics.Windows.Editors.CalendarMode.Days:
					day = calendar.GetDayOfMonth(date);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Years:
					month = calendar.GetMonthsInYear(num, era);
					day = calendar.GetDaysInMonth(num, month, era);
					break;
				case global::Infragistics.Windows.Editors.CalendarMode.Decades:
				case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
				{
					int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Windows.Editors.CalendarMode.Decades)));
					num += num2 - 1 - num % num2;
					month = calendar.GetMonthsInYear(num, era);
					day = calendar.GetDaysInMonth(num, month, era);
					break;
				}
				}
				result = calendar.ToDateTime(num, month, day, 0, 0, 0, 0, era);
			}
			catch (global::System.ArgumentException)
			{
				result = calendar.MaxSupportedDateTime;
			}
			return result;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x000113E0 File Offset: 0x0000F5E0
		private string[] GetShortDaysOfWeek(int charCount)
		{
			string[] dayNames = base.DateTimeFormat.DayNames;
			string[] array = new string[7];
			for (int i = 0; i < 7; i++)
			{
				array[i] = global::Infragistics.Windows.Editors.CalendarManager.GetShortDayOfWeekCaption(dayNames[i], charCount, base.DateTimeFormat);
			}
			return array;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00011420 File Offset: 0x0000F620
		internal static string GetShortDayOfWeekCaption(string dayOfWeek, int preferredChars, global::System.Globalization.DateTimeFormatInfo dateTimeFormat)
		{
			int num = 0;
			string dayOfWeekCaption;
			do
			{
				dayOfWeekCaption = global::Infragistics.Windows.Editors.CalendarManager.GetDayOfWeekCaption(dayOfWeek, num, preferredChars);
				if (global::Infragistics.Windows.Editors.CalendarManager.InUniqueDayOfWeekCaption(num, dayOfWeek, dayOfWeekCaption, preferredChars, dateTimeFormat))
				{
					break;
				}
				num++;
			}
			while (dayOfWeekCaption != null);
			if (dayOfWeekCaption == null)
			{
				dayOfWeekCaption = global::Infragistics.Windows.Editors.CalendarManager.GetDayOfWeekCaption(dayOfWeek, num, preferredChars);
			}
			return dayOfWeekCaption;
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001145C File Offset: 0x0000F65C
		internal global::System.DateTime GetGroupStartDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetGroupStartDate(date, mode, base.Calendar, this._hiddenDays);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00011474 File Offset: 0x0000F674
		internal static global::System.DateTime GetGroupStartDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.Globalization.Calendar calendar, global::Infragistics.Controls.DayOfWeekFlags hiddenDays)
		{
			int month = 1;
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
				month = calendar.GetMonth(date);
				break;
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
			{
				int num2 = (int)global::System.Math.Pow(10.0, (double)(1 + (mode - global::Infragistics.Windows.Editors.CalendarMode.Years)));
				num -= num % num2;
				if (num < 1)
				{
					num = 1;
				}
				break;
			}
			}
			global::System.DateTime dateTime;
			try
			{
				dateTime = calendar.ToDateTime(num, month, 1, 0, 0, 0, 0, era);
			}
			catch (global::System.ArgumentException)
			{
				dateTime = calendar.MinSupportedDateTime;
			}
			if (hiddenDays == (global::Infragistics.Controls.DayOfWeekFlags.Sunday | global::Infragistics.Controls.DayOfWeekFlags.Monday | global::Infragistics.Controls.DayOfWeekFlags.Tuesday | global::Infragistics.Controls.DayOfWeekFlags.Wednesday | global::Infragistics.Controls.DayOfWeekFlags.Thursday | global::Infragistics.Controls.DayOfWeekFlags.Friday | global::Infragistics.Controls.DayOfWeekFlags.Saturday))
			{
				return dateTime;
			}
			return global::Infragistics.Windows.Editors.CalendarManager.FindVisibleDate(dateTime, hiddenDays, calendar, 1);
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00011520 File Offset: 0x0000F720
		internal global::System.DateTime GetItemStartDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode)
		{
			return global::Infragistics.Windows.Editors.CalendarManager.GetItemStartDate(date, mode, base.Calendar);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00011530 File Offset: 0x0000F730
		internal static global::System.DateTime GetItemStartDate(global::System.DateTime date, global::Infragistics.Windows.Editors.CalendarMode mode, global::System.Globalization.Calendar calendar)
		{
			int month = 1;
			int num = calendar.GetYear(date);
			int era = calendar.GetEra(date);
			switch (mode)
			{
			case global::Infragistics.Windows.Editors.CalendarMode.Days:
				return date;
			case global::Infragistics.Windows.Editors.CalendarMode.Months:
				month = calendar.GetMonth(date);
				break;
			case global::Infragistics.Windows.Editors.CalendarMode.Years:
			case global::Infragistics.Windows.Editors.CalendarMode.Decades:
			case global::Infragistics.Windows.Editors.CalendarMode.Centuries:
			{
				int num2 = (int)global::System.Math.Pow(10.0, (double)(mode - global::Infragistics.Windows.Editors.CalendarMode.Years));
				num -= num % num2;
				break;
			}
			}
			global::System.DateTime result;
			try
			{
				result = calendar.ToDateTime(num, month, 1, 0, 0, 0, 0, era);
			}
			catch (global::System.ArgumentException)
			{
				result = calendar.MinSupportedDateTime;
			}
			return result;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x000115C8 File Offset: 0x0000F7C8
		public int GetWeekNumberForDate(global::System.DateTime date)
		{
			int num;
			return base.GetWeekNumberForDate(date, this._weekRule, this._firstDayOfWeek, out num);
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x000115EA File Offset: 0x0000F7EA
		internal void InitializeCulture(global::System.Globalization.CultureInfo cultureInfo)
		{
			if (cultureInfo == null)
			{
				cultureInfo = global::System.Globalization.CultureInfo.CurrentCulture;
			}
			base.Initialize(cultureInfo.Calendar, cultureInfo.DateTimeFormat);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00011608 File Offset: 0x0000F808
		private static bool InUniqueDayOfWeekCaption(int index, string dayOfWeek, string text, int length, global::System.Globalization.DateTimeFormatInfo dateTimeFormat)
		{
			foreach (string text2 in dateTimeFormat.DayNames)
			{
				if (!(text2 == dayOfWeek) && text != global::Infragistics.Windows.Editors.CalendarManager.GetDayOfWeekCaption(text2, index, length))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0001164F File Offset: 0x0000F84F
		protected override void VerifyCanChange()
		{
			if (this == global::Infragistics.Windows.Editors.CalendarManager.currentCulture)
			{
				throw new global::System.InvalidOperationException("The shared current culture CalendarManager cannot be changed.");
			}
		}

		// Token: 0x0400016D RID: 365
		private global::System.DayOfWeek? _firstDayOfWeek;

		// Token: 0x0400016E RID: 366
		private global::System.Globalization.CalendarWeekRule? _weekRule;

		// Token: 0x0400016F RID: 367
		private global::Infragistics.Controls.DayOfWeekFlags _hiddenDays;

		// Token: 0x04000170 RID: 368
		private int _visibleDayCount = 7;

		// Token: 0x04000171 RID: 369
		private static global::Infragistics.Windows.Editors.CalendarManager currentCulture;
	}
}
