using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using Infragistics.Collections;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002E RID: 46
	public sealed class CalendarDateRangeCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.CalendarDateRange>
	{
		// Token: 0x060002FD RID: 765 RVA: 0x0000BD2E File Offset: 0x00009F2E
		internal CalendarDateRangeCollection(global::Infragistics.Windows.Editors.XamMonthCalendar owner)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("owner", owner);
			this._owner = owner;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000BD48 File Offset: 0x00009F48
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._combinedRanges = null;
			base.OnCollectionChanged(e);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000BD58 File Offset: 0x00009F58
		protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this._combinedRanges = null;
			base.OnPropertyChanged(e);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000BD68 File Offset: 0x00009F68
		private global::System.DateTime? GetNextAvailableDate(ref global::System.DateTime start, ref global::System.DateTime end, int index)
		{
			int disabledDaysOfWeek = (int)this._owner.DisabledDaysOfWeek;
			global::System.DateTime dateTime = start;
			global::System.Globalization.Calendar calendar = this._owner.CalendarManager.Calendar;
			for (int i = global::System.Math.Max(0, index - 1); i < this._combinedRanges.Length; i++)
			{
				global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = this._combinedRanges[i];
				if (!(calendarDateRange.End < dateTime))
				{
					while (dateTime < calendarDateRange.Start)
					{
						if ((disabledDaysOfWeek & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
						{
							return new global::System.DateTime?(dateTime);
						}
						if (dateTime == end)
						{
							return null;
						}
						dateTime = dateTime.AddTicks(864000000000L);
					}
					if (end <= calendarDateRange.End)
					{
						return null;
					}
					dateTime = calendarDateRange.End.AddTicks(864000000000L);
				}
			}
			for (int j = 0; j < 7; j++)
			{
				if ((disabledDaysOfWeek & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
				{
					return new global::System.DateTime?(dateTime);
				}
				if (dateTime == end)
				{
					break;
				}
				dateTime = dateTime.AddTicks(864000000000L);
			}
			return null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000BEBC File Offset: 0x0000A0BC
		private global::System.DateTime? GetPreviousAvailableDate(ref global::System.DateTime start, ref global::System.DateTime end, int index)
		{
			int disabledDaysOfWeek = (int)this._owner.DisabledDaysOfWeek;
			global::System.DateTime dateTime = end;
			global::System.Globalization.Calendar calendar = this._owner.CalendarManager.Calendar;
			int num = global::System.Array.BinarySearch<global::Infragistics.Windows.Editors.CalendarDateRange>(this._combinedRanges, new global::Infragistics.Windows.Editors.CalendarDateRange(end, end));
			if (num < 0)
			{
				num = ~num;
			}
			int i = this._combinedRanges.Length - 1;
			int num2 = global::System.Math.Max(0, index - 1);
			while (i >= num2)
			{
				global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = this._combinedRanges[i];
				if (!(calendarDateRange.End < start) && !(calendarDateRange.Start > end))
				{
					if (calendarDateRange.Start <= start)
					{
						return null;
					}
					if (calendarDateRange.Start <= dateTime && calendarDateRange.End >= dateTime)
					{
						dateTime = calendarDateRange.Start.AddTicks(-864000000000L);
					}
					else
					{
						while (dateTime > calendarDateRange.End)
						{
							if ((disabledDaysOfWeek & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
							{
								return new global::System.DateTime?(dateTime);
							}
							if (dateTime == start)
							{
								return null;
							}
							dateTime = dateTime.AddTicks(-864000000000L);
						}
						if (end <= calendarDateRange.End)
						{
							return null;
						}
						dateTime = calendarDateRange.End.AddTicks(864000000000L);
					}
				}
				i--;
			}
			for (int j = 0; j < 7; j++)
			{
				if ((disabledDaysOfWeek & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
				{
					return new global::System.DateTime?(dateTime);
				}
				if (dateTime == start)
				{
					break;
				}
				dateTime = dateTime.AddTicks(-864000000000L);
			}
			return null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000C0B4 File Offset: 0x0000A2B4
		private void InitializeCombinedRanges()
		{
			global::Infragistics.Windows.Editors.CalendarDateRange[] array = new global::Infragistics.Windows.Editors.CalendarDateRange[base.Count];
			base.CopyTo(array, 0);
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Normalize();
				array[i].RemoveTime();
			}
			global::System.Array.Sort<global::Infragistics.Windows.Editors.CalendarDateRange>(array);
			int num = -1;
			foreach (global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange in array)
			{
				if (num >= 0 && calendarDateRange.Start.Subtract(array[num].End).Ticks <= 864000000000L)
				{
					if (calendarDateRange.End > array[num].End)
					{
						array[num].End = calendarDateRange.End;
					}
				}
				else
				{
					num++;
					array[num] = calendarDateRange;
				}
			}
			global::System.Array.Resize<global::Infragistics.Windows.Editors.CalendarDateRange>(ref array, num + 1);
			this._combinedRanges = array;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000C1AB File Offset: 0x0000A3AB
		private void VerifyCombinedRanges()
		{
			if (this._combinedRanges == null)
			{
				this.InitializeCombinedRanges();
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000C1BC File Offset: 0x0000A3BC
		internal void AddAvailableDates(global::Infragistics.Windows.Editors.CalendarDateRange range, global::System.Collections.Generic.List<global::System.DateTime> dates)
		{
			int disabledDaysOfWeek = (int)this._owner.DisabledDaysOfWeek;
			global::Infragistics.Windows.Editors.CalendarManager calendarManager = this._owner.CalendarManager;
			global::System.Globalization.Calendar calendar = calendarManager.Calendar;
			global::Infragistics.Windows.Editors.CalendarMode minCalendarMode = this._owner.MinCalendarMode;
			bool flag = minCalendarMode != global::Infragistics.Windows.Editors.CalendarMode.Days;
			this.VerifyCombinedRanges();
			int num = global::System.Array.BinarySearch<global::Infragistics.Windows.Editors.CalendarDateRange>(this._combinedRanges, new global::Infragistics.Windows.Editors.CalendarDateRange(range.Start, range.End));
			if (num < 0)
			{
				num = ~num;
			}
			global::System.DateTime dateTime = range.Start;
			global::System.DateTime end = range.End;
			for (int i = global::System.Math.Max(0, num - 1); i < this._combinedRanges.Length; i++)
			{
				global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = this._combinedRanges[i];
				if (!(calendarDateRange.End < dateTime))
				{
					while (dateTime < calendarDateRange.Start)
					{
						if ((disabledDaysOfWeek & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
						{
							dates.Add(dateTime);
						}
						if (flag)
						{
							dateTime = calendarManager.AddItemOffset(calendarManager.GetItemStartDate(dateTime, minCalendarMode), 1, minCalendarMode);
						}
						if (dateTime >= end)
						{
							return;
						}
						dateTime = dateTime.AddTicks(864000000000L);
					}
					if (end <= calendarDateRange.End)
					{
						return;
					}
					dateTime = calendarDateRange.End.AddTicks(864000000000L);
				}
			}
			while (dateTime <= end)
			{
				if ((disabledDaysOfWeek & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
				{
					dates.Add(dateTime);
				}
				if (flag)
				{
					dateTime = calendarManager.AddItemOffset(calendarManager.GetItemStartDate(dateTime, minCalendarMode), 1, minCalendarMode);
				}
				if (dateTime >= end)
				{
					return;
				}
				dateTime = dateTime.AddTicks(864000000000L);
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000C374 File Offset: 0x0000A574
		internal global::System.DateTime? GetAvailableDate(global::System.DateTime start, global::System.DateTime end, bool next)
		{
			this.VerifyCombinedRanges();
			global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = new global::Infragistics.Windows.Editors.CalendarDateRange(start, end);
			int num = global::System.Array.BinarySearch<global::Infragistics.Windows.Editors.CalendarDateRange>(this._combinedRanges, calendarDateRange);
			if (num < 0)
			{
				num = ~num;
			}
			if (num > 0 && this._combinedRanges[num - 1].Contains(calendarDateRange))
			{
				return null;
			}
			if (num < this._combinedRanges.Length && this._combinedRanges[num].Contains(calendarDateRange))
			{
				return null;
			}
			if (next)
			{
				return this.GetNextAvailableDate(ref start, ref end, num);
			}
			return this.GetPreviousAvailableDate(ref start, ref end, num);
		}

		// Token: 0x04000120 RID: 288
		private global::Infragistics.Windows.Editors.XamMonthCalendar _owner;

		// Token: 0x04000121 RID: 289
		private global::Infragistics.Windows.Editors.CalendarDateRange[] _combinedRanges;
	}
}
