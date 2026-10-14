using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000029 RID: 41
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Editors.CalendarDateRangeConverter))]
	public struct CalendarDateRange : global::System.IEquatable<global::Infragistics.Windows.Editors.CalendarDateRange>, global::System.IComparable<global::Infragistics.Windows.Editors.CalendarDateRange>
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x0000AE9B File Offset: 0x0000909B
		public CalendarDateRange(global::System.DateTime date)
		{
			this = new global::Infragistics.Windows.Editors.CalendarDateRange(date, date);
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000AEA5 File Offset: 0x000090A5
		public CalendarDateRange(global::System.DateTime start, global::System.DateTime end)
		{
			this._start = start;
			this._end = end;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000AEB5 File Offset: 0x000090B5
		public override int GetHashCode()
		{
			return this._start.GetHashCode() ^ this._end.GetHashCode();
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000AEDA File Offset: 0x000090DA
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.Editors.CalendarDateRange && this == (global::Infragistics.Windows.Editors.CalendarDateRange)obj;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000AEF7 File Offset: 0x000090F7
		public static bool operator ==(global::Infragistics.Windows.Editors.CalendarDateRange range1, global::Infragistics.Windows.Editors.CalendarDateRange range2)
		{
			return range1._start == range2._start && range1._end == range2._end;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000AF23 File Offset: 0x00009123
		public static bool operator !=(global::Infragistics.Windows.Editors.CalendarDateRange range1, global::Infragistics.Windows.Editors.CalendarDateRange range2)
		{
			return !(range1 == range2);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000AF2F File Offset: 0x0000912F
		public override string ToString()
		{
			return this.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x0000AF3C File Offset: 0x0000913C
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0000AF44 File Offset: 0x00009144
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0000AF4D File Offset: 0x0000914D
		// (set) Token: 0x060002CB RID: 715 RVA: 0x0000AF55 File Offset: 0x00009155
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

		// Token: 0x060002CC RID: 716 RVA: 0x0000AF60 File Offset: 0x00009160
		public bool Contains(global::System.DateTime date)
		{
			global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = global::Infragistics.Windows.Editors.CalendarDateRange.Normalize(this);
			return date >= calendarDateRange._start && date <= calendarDateRange._end;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000AF98 File Offset: 0x00009198
		public bool Contains(global::Infragistics.Windows.Editors.CalendarDateRange range)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("range", range);
			range.Normalize();
			global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = global::Infragistics.Windows.Editors.CalendarDateRange.Normalize(this);
			return range._start >= calendarDateRange._start && range._end <= calendarDateRange._end;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000AFF4 File Offset: 0x000091F4
		public bool IntersectsWith(global::Infragistics.Windows.Editors.CalendarDateRange range)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("range", range);
			range.Normalize();
			global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = global::Infragistics.Windows.Editors.CalendarDateRange.Normalize(this);
			return !(calendarDateRange._end < range._start) && !(calendarDateRange._start > range._end);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0000B054 File Offset: 0x00009254
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

		// Token: 0x060002D0 RID: 720 RVA: 0x0000B08E File Offset: 0x0000928E
		public static global::Infragistics.Windows.Editors.CalendarDateRange Normalize(global::Infragistics.Windows.Editors.CalendarDateRange range)
		{
			range.Normalize();
			return range;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x0000B098 File Offset: 0x00009298
		public void RemoveTime()
		{
			this._start = this._start.Date;
			this._end = this._end.Date;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000B0BC File Offset: 0x000092BC
		internal static global::Infragistics.Windows.Editors.CalendarDateRange FromString(string value, global::System.Globalization.CultureInfo culture)
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
					global::System.DateTime dateTime = (global::System.DateTime)converter.ConvertFromString(null, culture, array[0]);
					global::System.DateTime end = (array.Length == 2) ? ((global::System.DateTime)converter.ConvertFromString(null, culture, array[1])) : dateTime;
					return new global::Infragistics.Windows.Editors.CalendarDateRange(dateTime, end);
				}
			}
			throw new global::System.FormatException(global::Infragistics.Windows.Editors.CalendarDateRange.GetString("LE_InvalidDateRangeString", new object[]
			{
				value
			}));
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000B19E File Offset: 0x0000939E
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.CalendarDateRange.GetString(name, null);
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000B1A7 File Offset: 0x000093A7
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x0000B1B0 File Offset: 0x000093B0
		internal string ToString(global::System.Globalization.CultureInfo culture)
		{
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			bool flag = this._start.TimeOfDay != global::System.TimeSpan.Zero || this._end.TimeOfDay != global::System.TimeSpan.Zero;
			string format = flag ? "r" : "d";
			global::System.DateTime d = this._start;
			global::System.DateTime d2 = this._end;
			if (flag)
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

		// Token: 0x060002D6 RID: 726 RVA: 0x0000B259 File Offset: 0x00009459
		public bool Equals(global::Infragistics.Windows.Editors.CalendarDateRange other)
		{
			return this == other;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000B268 File Offset: 0x00009468
		public int CompareTo(global::Infragistics.Windows.Editors.CalendarDateRange other)
		{
			int num = this._start.CompareTo(other._start);
			if (num == 0)
			{
				num = this._end.CompareTo(other._end);
			}
			return num;
		}

		// Token: 0x04000106 RID: 262
		private global::System.DateTime _start;

		// Token: 0x04000107 RID: 263
		private global::System.DateTime _end;
	}
}
