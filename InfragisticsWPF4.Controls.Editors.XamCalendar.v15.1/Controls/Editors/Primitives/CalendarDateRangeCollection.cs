using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using Infragistics.Collections;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200000E RID: 14
	public sealed class CalendarDateRangeCollection : global::Infragistics.Collections.ObservableCollectionExtended<global::Infragistics.DateRange>
	{
		// Token: 0x06000061 RID: 97 RVA: 0x000035DF File Offset: 0x000017DF
		internal CalendarDateRangeCollection(global::Infragistics.Controls.Editors.CalendarBase owner)
		{
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNull("owner", owner);
			this._owner = owner;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000035F9 File Offset: 0x000017F9
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._combinedRanges = null;
			base.OnCollectionChanged(e);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003609 File Offset: 0x00001809
		protected override void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this._combinedRanges = null;
			base.OnPropertyChanged(e);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000361C File Offset: 0x0000181C
		private global::System.DateTime? GetNextAvailableDate(ref global::System.DateTime start, ref global::System.DateTime end, int index)
		{
			int disabledDaysOfWeekInternal = (int)this._owner.DisabledDaysOfWeekInternal;
			global::System.DateTime dateTime = start;
			global::System.Globalization.Calendar calendar = this._owner.CalendarManager.Calendar;
			for (int i = global::System.Math.Max(0, index - 1); i < this._combinedRanges.Length; i++)
			{
				global::Infragistics.DateRange dateRange = this._combinedRanges[i];
				if (!(dateRange.End < dateTime))
				{
					while (dateTime < dateRange.Start)
					{
						if ((disabledDaysOfWeekInternal & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
						{
							return new global::System.DateTime?(dateTime);
						}
						if (dateTime == end)
						{
							return null;
						}
						dateTime = dateTime.AddTicks(864000000000L);
					}
					if (end <= dateRange.End)
					{
						return null;
					}
					dateTime = dateRange.End.AddTicks(864000000000L);
				}
			}
			for (int j = 0; j < 7; j++)
			{
				if ((disabledDaysOfWeekInternal & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
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

		// Token: 0x06000065 RID: 101 RVA: 0x00003770 File Offset: 0x00001970
		private global::System.DateTime? GetPreviousAvailableDate(ref global::System.DateTime start, ref global::System.DateTime end, int index)
		{
			int disabledDaysOfWeekInternal = (int)this._owner.DisabledDaysOfWeekInternal;
			global::System.DateTime dateTime = end;
			global::System.Globalization.Calendar calendar = this._owner.CalendarManager.Calendar;
			int num = global::System.Array.BinarySearch<global::Infragistics.DateRange>(this._combinedRanges, new global::Infragistics.DateRange(end, end));
			if (num < 0)
			{
				num = ~num;
			}
			int i = this._combinedRanges.Length - 1;
			int num2 = global::System.Math.Max(0, index - 1);
			while (i >= num2)
			{
				global::Infragistics.DateRange dateRange = this._combinedRanges[i];
				if (!(dateRange.End < start) && !(dateRange.Start > end))
				{
					if (dateRange.Start <= start)
					{
						return null;
					}
					if (dateRange.Start <= dateTime && dateRange.End >= dateTime)
					{
						dateTime = dateRange.Start.AddTicks(-864000000000L);
					}
					else
					{
						while (dateTime > dateRange.End)
						{
							if ((disabledDaysOfWeekInternal & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
							{
								return new global::System.DateTime?(dateTime);
							}
							if (dateTime == start)
							{
								return null;
							}
							dateTime = dateTime.AddTicks(-864000000000L);
						}
						if (end <= dateRange.End)
						{
							return null;
						}
						dateTime = dateRange.End.AddTicks(864000000000L);
					}
				}
				i--;
			}
			for (int j = 0; j < 7; j++)
			{
				if ((disabledDaysOfWeekInternal & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
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

		// Token: 0x06000066 RID: 102 RVA: 0x00003968 File Offset: 0x00001B68
		private void InitializeCombinedRanges()
		{
			global::Infragistics.DateRange[] array = new global::Infragistics.DateRange[base.Count];
			base.CopyTo(array, 0);
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Normalize();
				array[i].RemoveTime();
			}
			global::System.Array.Sort<global::Infragistics.DateRange>(array);
			int num = -1;
			foreach (global::Infragistics.DateRange dateRange in array)
			{
				if (num >= 0 && dateRange.Start.Subtract(array[num].End).Ticks <= 864000000000L)
				{
					if (dateRange.End > array[num].End)
					{
						array[num].End = dateRange.End;
					}
				}
				else
				{
					num++;
					array[num] = dateRange;
				}
			}
			global::System.Array.Resize<global::Infragistics.DateRange>(ref array, num + 1);
			this._combinedRanges = array;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00003A5F File Offset: 0x00001C5F
		private void VerifyCombinedRanges()
		{
			if (this._combinedRanges == null)
			{
				this.InitializeCombinedRanges();
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003A70 File Offset: 0x00001C70
		internal void AddAvailableDates(global::Infragistics.DateRange range, global::System.Collections.Generic.List<global::System.DateTime> dates)
		{
			int disabledDaysOfWeekInternal = (int)this._owner.DisabledDaysOfWeekInternal;
			global::Infragistics.Controls.Editors.CalendarManager calendarManager = this._owner.CalendarManager;
			global::System.Globalization.Calendar calendar = calendarManager.Calendar;
			global::Infragistics.Controls.Editors.CalendarZoomMode minCalendarModeResolved = this._owner.MinCalendarModeResolved;
			bool flag = minCalendarModeResolved != global::Infragistics.Controls.Editors.CalendarZoomMode.Days;
			this.VerifyCombinedRanges();
			int num = global::System.Array.BinarySearch<global::Infragistics.DateRange>(this._combinedRanges, new global::Infragistics.DateRange(range.Start, range.End));
			if (num < 0)
			{
				num = ~num;
			}
			global::System.DateTime dateTime = range.Start;
			global::System.DateTime end = range.End;
			for (int i = global::System.Math.Max(0, num - 1); i < this._combinedRanges.Length; i++)
			{
				global::Infragistics.DateRange dateRange = this._combinedRanges[i];
				if (!(dateRange.End < dateTime))
				{
					while (dateTime < dateRange.Start)
					{
						if ((disabledDaysOfWeekInternal & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
						{
							dates.Add(dateTime);
						}
						if (flag)
						{
							dateTime = calendarManager.AddItemOffset(calendarManager.GetItemStartDate(dateTime, minCalendarModeResolved), 1, minCalendarModeResolved);
						}
						if (dateTime >= end)
						{
							return;
						}
						dateTime = dateTime.AddTicks(864000000000L);
					}
					if (end <= dateRange.End)
					{
						return;
					}
					dateTime = dateRange.End.AddTicks(864000000000L);
				}
			}
			while (dateTime <= end)
			{
				if ((disabledDaysOfWeekInternal & 1 << (int)calendar.GetDayOfWeek(dateTime)) == 0)
				{
					dates.Add(dateTime);
				}
				if (flag)
				{
					dateTime = calendarManager.AddItemOffset(calendarManager.GetItemStartDate(dateTime, minCalendarModeResolved), 1, minCalendarModeResolved);
				}
				if (dateTime >= end)
				{
					return;
				}
				dateTime = dateTime.AddTicks(864000000000L);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003C28 File Offset: 0x00001E28
		internal global::System.DateTime? GetAvailableDate(global::System.DateTime start, global::System.DateTime end, bool next)
		{
			this.VerifyCombinedRanges();
			global::Infragistics.DateRange dateRange = new global::Infragistics.DateRange(start, end);
			int num = global::System.Array.BinarySearch<global::Infragistics.DateRange>(this._combinedRanges, dateRange);
			if (num < 0)
			{
				num = ~num;
			}
			if (num > 0 && this._combinedRanges[num - 1].Contains(dateRange))
			{
				return null;
			}
			if (num < this._combinedRanges.Length && this._combinedRanges[num].Contains(dateRange))
			{
				return null;
			}
			if (next)
			{
				return this.GetNextAvailableDate(ref start, ref end, num);
			}
			return this.GetPreviousAvailableDate(ref start, ref end, num);
		}

		// Token: 0x0400001B RID: 27
		private global::Infragistics.Controls.Editors.CalendarBase _owner;

		// Token: 0x0400001C RID: 28
		private global::Infragistics.DateRange[] _combinedRanges;
	}
}
