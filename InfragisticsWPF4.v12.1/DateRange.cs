using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x02000028 RID: 40
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.DateRangeConverter))]
	public struct DateRange : global::System.IEquatable<global::Infragistics.DateRange>, global::System.IComparable<global::Infragistics.DateRange>
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00008D6A File Offset: 0x00006F6A
		public static global::Infragistics.DateRange Infinite
		{
			get
			{
				return global::Infragistics.DateRange._Infinite;
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00008D71 File Offset: 0x00006F71
		public DateRange(global::System.DateTime date)
		{
			this = new global::Infragistics.DateRange(date, date);
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00008D7B File Offset: 0x00006F7B
		public DateRange(global::System.DateTime start, global::System.DateTime end)
		{
			this._start = start;
			this._end = end;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00008D8B File Offset: 0x00006F8B
		public override int GetHashCode()
		{
			return this._start.GetHashCode() ^ this._end.GetHashCode();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00008DB0 File Offset: 0x00006FB0
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.DateRange && this == (global::Infragistics.DateRange)obj;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00008DCD File Offset: 0x00006FCD
		public static bool operator ==(global::Infragistics.DateRange range1, global::Infragistics.DateRange range2)
		{
			return range1._start == range2._start && range1._end == range2._end;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00008DF9 File Offset: 0x00006FF9
		public static bool operator !=(global::Infragistics.DateRange range1, global::Infragistics.DateRange range2)
		{
			return !(range1 == range2);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00008E05 File Offset: 0x00007005
		public override string ToString()
		{
			return this.ToString(null);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00008E0E File Offset: 0x0000700E
		public string ToString(string format)
		{
			return this.ToString(global::System.Globalization.CultureInfo.CurrentCulture, format, false);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00008E1D File Offset: 0x0000701D
		public bool IsEmpty
		{
			get
			{
				return this._start == this._end;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00008E30 File Offset: 0x00007030
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x00008E38 File Offset: 0x00007038
		public global::System.DateTime Start
		{
			get
			{
				return this._start;
			}
			set
			{
				this._start = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00008E41 File Offset: 0x00007041
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00008E49 File Offset: 0x00007049
		public global::System.DateTime End
		{
			get
			{
				return this._end;
			}
			set
			{
				this._end = value;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00008E54 File Offset: 0x00007054
		public bool Contains(global::System.DateTime date)
		{
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			return date >= dateRange._start && date <= dateRange._end;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00008E8C File Offset: 0x0000708C
		public bool Contains(global::Infragistics.DateRange range)
		{
			range.Normalize();
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			return range._start >= dateRange._start && range._end <= dateRange._end;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00008ED8 File Offset: 0x000070D8
		public bool Intersect(global::Infragistics.DateRange range)
		{
			range.Normalize();
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			if (dateRange._end < range._start || dateRange._start > range._end)
			{
				return false;
			}
			if (range._start > dateRange._start)
			{
				this._start = range._start;
			}
			else
			{
				this._start = dateRange._start;
			}
			if (range._end < dateRange._end)
			{
				this._end = range._end;
			}
			else
			{
				this._end = dateRange._end;
			}
			return true;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00008F88 File Offset: 0x00007188
		public bool IntersectsWith(global::Infragistics.DateRange range)
		{
			range.Normalize();
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			return !(dateRange._end < range._start) && !(dateRange._start > range._end);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00008FD5 File Offset: 0x000071D5
		public void Offset(global::System.TimeSpan offset)
		{
			this._start = this._start.Add(offset);
			this._end = this._end.Add(offset);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00008FFC File Offset: 0x000071FC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		public void Normalize()
		{
			if (this._end < this._start)
			{
				global::System.DateTime start = this._start;
				this._start = this._end;
				this._end = start;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00009036 File Offset: 0x00007236
		public static global::Infragistics.DateRange Normalize(global::Infragistics.DateRange range)
		{
			range.Normalize();
			return range;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00009040 File Offset: 0x00007240
		public void RemoveTime()
		{
			this._start = this._start.Date;
			this._end = this._end.Date;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00009064 File Offset: 0x00007264
		internal static global::Infragistics.DateRange[] CombineRanges(global::System.Collections.Generic.ICollection<global::Infragistics.DateRange> ranges)
		{
			global::Infragistics.DateRange[] array = new global::Infragistics.DateRange[ranges.Count];
			ranges.CopyTo(array, 0);
			if (array.Length < 2)
			{
				return array;
			}
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Normalize();
			}
			global::System.Array.Sort<global::Infragistics.DateRange>(array);
			int num = -1;
			foreach (global::Infragistics.DateRange dateRange in array)
			{
				if (num >= 0 && dateRange.Start <= array[num].End)
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
			return array;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00009135 File Offset: 0x00007335
		internal bool ContainsExclusive(global::System.DateTime date)
		{
			return date >= this._start && date < this._end;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00009154 File Offset: 0x00007354
		internal bool Intersect(global::Infragistics.DateRange range, bool normalizeIntersection)
		{
			bool flag = !normalizeIntersection && this._start > this._end;
			if (!this.Intersect(range))
			{
				return false;
			}
			if (flag)
			{
				global::Infragistics.CoreUtilities.Swap<global::System.DateTime>(ref this._start, ref this._end);
			}
			return true;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x0000919C File Offset: 0x0000739C
		internal bool IntersectsWithExclusive(global::Infragistics.DateRange range)
		{
			range.Normalize();
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			return !(dateRange._end <= range._start) && !(dateRange._start >= range._end);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000091EC File Offset: 0x000073EC
		internal static global::Infragistics.DateRange FromString(string value, global::System.Globalization.CultureInfo culture)
		{
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			string[] array = value.Split(new char[]
			{
				'-'
			});
			if (array.Length >= 1 && array.Length <= 2)
			{
				bool flag = false;
				foreach (string text in array)
				{
					if (string.IsNullOrEmpty(text) || text.Trim().Length == 0)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.DateTime));
					global::System.DateTime dateTime = (global::System.DateTime)converter.ConvertFrom(null, culture, array[0]);
					global::System.DateTime end = (array.Length == 2) ? ((global::System.DateTime)converter.ConvertFrom(null, culture, array[1])) : dateTime;
					return new global::Infragistics.DateRange(dateTime, end);
				}
			}
			throw new global::System.FormatException(global::Infragistics.DateRange.GetString("LE_InvalidDateRangeString", new object[]
			{
				value
			}));
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x000092CE File Offset: 0x000074CE
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x000092D8 File Offset: 0x000074D8
		internal string ToString(global::System.Globalization.CultureInfo culture, string format, bool allowConvertToUniversal)
		{
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			bool flag = this._start.TimeOfDay != global::System.TimeSpan.Zero || this._end.TimeOfDay != global::System.TimeSpan.Zero;
			if (format == null)
			{
				format = (flag ? "r" : "d");
			}
			global::System.DateTime d = this._start;
			global::System.DateTime d2 = this._end;
			if (flag && allowConvertToUniversal)
			{
				d = d.ToUniversalTime();
				d2 = d2.ToUniversalTime();
			}
			if (d == d2)
			{
				return d.ToString(format, culture);
			}
			return d.ToString(format, culture) + "-" + d2.ToString(format, culture);
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00009388 File Offset: 0x00007588
		public bool Equals(global::Infragistics.DateRange other)
		{
			return this == other;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00009398 File Offset: 0x00007598
		public int CompareTo(global::Infragistics.DateRange other)
		{
			int num = this._start.CompareTo(other._start);
			if (num == 0)
			{
				num = this._end.CompareTo(other._end);
			}
			return num;
		}

		// Token: 0x04000071 RID: 113
		private global::System.DateTime _start;

		// Token: 0x04000072 RID: 114
		private global::System.DateTime _end;

		// Token: 0x04000073 RID: 115
		private static readonly global::Infragistics.DateRange _Infinite = new global::Infragistics.DateRange(global::System.DateTime.MinValue, global::System.DateTime.MaxValue);
	}
}
