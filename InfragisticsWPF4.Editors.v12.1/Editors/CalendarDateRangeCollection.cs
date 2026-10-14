using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using Infragistics.Collections;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002B RID: 43
	public sealed class CalendarDateRangeCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.Windows.Editors.CalendarDateRange>
	{
		// Token: 0x060002DD RID: 733 RVA: 0x0000B479 File Offset: 0x00009679
		internal CalendarDateRangeCollection(global::Infragistics.Windows.Editors.XamMonthCalendar owner)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("owner", owner);
			this._owner = owner;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0000B493 File Offset: 0x00009693
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._combinedRanges = null;
			base.OnCollectionChanged(e);
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0000B4A3 File Offset: 0x000096A3
		protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this._combinedRanges = null;
			base.OnPropertyChanged(e);
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0000B4B4 File Offset: 0x000096B4
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

		// Token: 0x060002E1 RID: 737 RVA: 0x0000B608 File Offset: 0x00009808
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

		// Token: 0x060002E2 RID: 738 RVA: 0x0000B800 File Offset: 0x00009A00
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

		// Token: 0x060002E3 RID: 739 RVA: 0x0000B8F7 File Offset: 0x00009AF7
		private void VerifyCombinedRanges()
		{
			if (this._combinedRanges == null)
			{
				this.InitializeCombinedRanges();
			}
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000B908 File Offset: 0x00009B08
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

		// Token: 0x060002E5 RID: 741 RVA: 0x0000BAC0 File Offset: 0x00009CC0
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

		// Token: 0x04000108 RID: 264
		private global::Infragistics.Windows.Editors.XamMonthCalendar _owner;

		// Token: 0x04000109 RID: 265
		private global::Infragistics.Windows.Editors.CalendarDateRange[] _combinedRanges;
	}
}
