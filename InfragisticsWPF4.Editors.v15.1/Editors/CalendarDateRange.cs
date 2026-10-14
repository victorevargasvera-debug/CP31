using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002C RID: 44
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Editors.CalendarDateRangeConverter))]
	public struct CalendarDateRange : global::System.IEquatable<global::Infragistics.Windows.Editors.CalendarDateRange>, global::System.IComparable<global::Infragistics.Windows.Editors.CalendarDateRange>
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x0000B74B File Offset: 0x0000994B
		public CalendarDateRange(global::System.DateTime date)
		{
			this = new global::Infragistics.Windows.Editors.CalendarDateRange(date, date);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000B755 File Offset: 0x00009955
		public CalendarDateRange(global::System.DateTime start, global::System.DateTime end)
		{
			this._start = start;
			this._end = end;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000B765 File Offset: 0x00009965
		public override int GetHashCode()
		{
			return this._start.GetHashCode() ^ this._end.GetHashCode();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000B78A File Offset: 0x0000998A
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.Editors.CalendarDateRange && this == (global::Infragistics.Windows.Editors.CalendarDateRange)obj;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000B7A7 File Offset: 0x000099A7
		public static bool operator ==(global::Infragistics.Windows.Editors.CalendarDateRange range1, global::Infragistics.Windows.Editors.CalendarDateRange range2)
		{
			return range1._start == range2._start && range1._end == range2._end;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000B7D3 File Offset: 0x000099D3
		public static bool operator !=(global::Infragistics.Windows.Editors.CalendarDateRange range1, global::Infragistics.Windows.Editors.CalendarDateRange range2)
		{
			return !(range1 == range2);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000B7DF File Offset: 0x000099DF
		public override string ToString()
		{
			return this.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0000B7EC File Offset: 0x000099EC
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x0000B7F4 File Offset: 0x000099F4
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002EA RID: 746 RVA: 0x0000B7FD File Offset: 0x000099FD
		// (set) Token: 0x060002EB RID: 747 RVA: 0x0000B805 File Offset: 0x00009A05
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

		// Token: 0x060002EC RID: 748 RVA: 0x0000B810 File Offset: 0x00009A10
		public bool Contains(global::System.DateTime date)
		{
			global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = global::Infragistics.Windows.Editors.CalendarDateRange.Normalize(this);
			return date >= calendarDateRange._start && date <= calendarDateRange._end;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0000B848 File Offset: 0x00009A48
		public bool Contains(global::Infragistics.Windows.Editors.CalendarDateRange range)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("range", range);
			range.Normalize();
			global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = global::Infragistics.Windows.Editors.CalendarDateRange.Normalize(this);
			return range._start >= calendarDateRange._start && range._end <= calendarDateRange._end;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0000B8A4 File Offset: 0x00009AA4
		public bool IntersectsWith(global::Infragistics.Windows.Editors.CalendarDateRange range)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("range", range);
			range.Normalize();
			global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = global::Infragistics.Windows.Editors.CalendarDateRange.Normalize(this);
			return !(calendarDateRange._end < range._start) && !(calendarDateRange._start > range._end);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000B904 File Offset: 0x00009B04
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

		// Token: 0x060002F0 RID: 752 RVA: 0x0000B93E File Offset: 0x00009B3E
		public static global::Infragistics.Windows.Editors.CalendarDateRange Normalize(global::Infragistics.Windows.Editors.CalendarDateRange range)
		{
			range.Normalize();
			return range;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0000B948 File Offset: 0x00009B48
		public void RemoveTime()
		{
			this._start = this._start.Date;
			this._end = this._end.Date;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0000B96C File Offset: 0x00009B6C
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

		// Token: 0x060002F3 RID: 755 RVA: 0x0000BA4E File Offset: 0x00009C4E
		internal static string GetString(string name)
		{
			return global::Infragistics.Windows.Editors.CalendarDateRange.GetString(name, null);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000BA57 File Offset: 0x00009C57
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0000BA60 File Offset: 0x00009C60
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

		// Token: 0x060002F6 RID: 758 RVA: 0x0000BB09 File Offset: 0x00009D09
		public bool Equals(global::Infragistics.Windows.Editors.CalendarDateRange other)
		{
			return this == other;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0000BB18 File Offset: 0x00009D18
		public int CompareTo(global::Infragistics.Windows.Editors.CalendarDateRange other)
		{
			int num = this._start.CompareTo(other._start);
			if (num == 0)
			{
				num = this._end.CompareTo(other._end);
			}
			return num;
		}

		// Token: 0x0400011E RID: 286
		private global::System.DateTime _start;

		// Token: 0x0400011F RID: 287
		private global::System.DateTime _end;
	}
}
