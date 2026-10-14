using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics
{
	// Token: 0x02000035 RID: 53
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.DateRangeConverter))]
	public struct DateRange : global::System.IEquatable<global::Infragistics.DateRange>, global::System.IComparable<global::Infragistics.DateRange>
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000245 RID: 581 RVA: 0x0000A052 File Offset: 0x00008252
		public static global::Infragistics.DateRange Infinite
		{
			get
			{
				return global::Infragistics.DateRange._Infinite;
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0000A059 File Offset: 0x00008259
		public DateRange(global::System.DateTime date)
		{
			this = new global::Infragistics.DateRange(date, date);
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0000A063 File Offset: 0x00008263
		public DateRange(global::System.DateTime start, global::System.DateTime end)
		{
			this._start = start;
			this._end = end;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0000A073 File Offset: 0x00008273
		public override int GetHashCode()
		{
			return this._start.GetHashCode() ^ this._end.GetHashCode();
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0000A098 File Offset: 0x00008298
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.DateRange && this == (global::Infragistics.DateRange)obj;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0000A0B5 File Offset: 0x000082B5
		public static bool operator ==(global::Infragistics.DateRange range1, global::Infragistics.DateRange range2)
		{
			return range1._start == range2._start && range1._end == range2._end;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0000A0E1 File Offset: 0x000082E1
		public static bool operator !=(global::Infragistics.DateRange range1, global::Infragistics.DateRange range2)
		{
			return !(range1 == range2);
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0000A0ED File Offset: 0x000082ED
		public override string ToString()
		{
			return this.ToString(null);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000A0F6 File Offset: 0x000082F6
		public string ToString(string format)
		{
			return this.ToString(global::System.Globalization.CultureInfo.CurrentCulture, format, false);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600024E RID: 590 RVA: 0x0000A105 File Offset: 0x00008305
		public bool IsEmpty
		{
			get
			{
				return this._start == this._end;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600024F RID: 591 RVA: 0x0000A118 File Offset: 0x00008318
		// (set) Token: 0x06000250 RID: 592 RVA: 0x0000A120 File Offset: 0x00008320
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

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000251 RID: 593 RVA: 0x0000A129 File Offset: 0x00008329
		// (set) Token: 0x06000252 RID: 594 RVA: 0x0000A131 File Offset: 0x00008331
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

		// Token: 0x06000253 RID: 595 RVA: 0x0000A13C File Offset: 0x0000833C
		public bool Contains(global::System.DateTime date)
		{
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			return date >= dateRange._start && date <= dateRange._end;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0000A174 File Offset: 0x00008374
		public bool Contains(global::Infragistics.DateRange range)
		{
			range.Normalize();
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			return range._start >= dateRange._start && range._end <= dateRange._end;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0000A1C0 File Offset: 0x000083C0
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

		// Token: 0x06000256 RID: 598 RVA: 0x0000A270 File Offset: 0x00008470
		public bool IntersectsWith(global::Infragistics.DateRange range)
		{
			range.Normalize();
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			return !(dateRange._end < range._start) && !(dateRange._start > range._end);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000A2BD File Offset: 0x000084BD
		public void Offset(global::System.TimeSpan offset)
		{
			this._start = this._start.Add(offset);
			this._end = this._end.Add(offset);
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000A2E4 File Offset: 0x000084E4
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

		// Token: 0x06000259 RID: 601 RVA: 0x0000A31E File Offset: 0x0000851E
		public static global::Infragistics.DateRange Normalize(global::Infragistics.DateRange range)
		{
			range.Normalize();
			return range;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0000A328 File Offset: 0x00008528
		public void RemoveTime()
		{
			this._start = this._start.Date;
			this._end = this._end.Date;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0000A34C File Offset: 0x0000854C
		internal static global::Infragistics.DateRange[] CombineRanges(params global::System.Collections.Generic.ICollection<global::Infragistics.DateRange>[] ranges)
		{
			int num = 0;
			foreach (global::System.Collections.Generic.ICollection<global::Infragistics.DateRange> collection in ranges)
			{
				num += collection.Count;
			}
			global::Infragistics.DateRange[] array = new global::Infragistics.DateRange[num];
			int num2 = 0;
			foreach (global::System.Collections.Generic.ICollection<global::Infragistics.DateRange> collection2 in ranges)
			{
				collection2.CopyTo(array, num2);
				num2 += collection2.Count;
			}
			if (array.Length < 2)
			{
				return array;
			}
			for (int k = 0; k < array.Length; k++)
			{
				array[k].Normalize();
			}
			global::System.Array.Sort<global::Infragistics.DateRange>(array);
			int num3 = -1;
			foreach (global::Infragistics.DateRange dateRange in array)
			{
				if (num3 >= 0 && dateRange.Start <= array[num3].End)
				{
					if (dateRange.End > array[num3].End)
					{
						array[num3].End = dateRange.End;
					}
				}
				else
				{
					num3++;
					array[num3] = dateRange;
				}
			}
			global::System.Array.Resize<global::Infragistics.DateRange>(ref array, num3 + 1);
			return array;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000A47F File Offset: 0x0000867F
		internal bool ContainsExclusive(global::System.DateTime date)
		{
			return date >= this._start && date < this._end;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000A4A0 File Offset: 0x000086A0
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

		// Token: 0x0600025E RID: 606 RVA: 0x0000A4E8 File Offset: 0x000086E8
		internal bool IntersectsWithExclusive(global::Infragistics.DateRange range)
		{
			range.Normalize();
			global::Infragistics.DateRange dateRange = global::Infragistics.DateRange.Normalize(this);
			return !(dateRange._end <= range._start) && !(dateRange._start >= range._end);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0000A538 File Offset: 0x00008738
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
					bool flag2 = array.Length == 2;
					global::System.DateTime end = global::System.DateTime.MinValue;
					global::System.DateTime dateTime;
					if (!global::System.DateTime.TryParseExact(array[0], "r", culture, global::System.Globalization.DateTimeStyles.AllowLeadingWhite | global::System.Globalization.DateTimeStyles.AllowTrailingWhite | global::System.Globalization.DateTimeStyles.AllowInnerWhite | global::System.Globalization.DateTimeStyles.AssumeUniversal, out dateTime))
					{
						if (!global::System.DateTime.TryParseExact(array[0], "d", culture, global::System.Globalization.DateTimeStyles.AllowWhiteSpaces, out dateTime))
						{
							dateTime = global::System.DateTime.Parse(array[0], culture);
							if (flag2)
							{
								end = global::System.DateTime.Parse(array[1], culture);
							}
						}
						else if (flag2)
						{
							end = global::System.DateTime.ParseExact(array[1], "d", culture, global::System.Globalization.DateTimeStyles.AllowWhiteSpaces);
						}
					}
					else if (flag2)
					{
						end = global::System.DateTime.ParseExact(array[1], "r", culture, global::System.Globalization.DateTimeStyles.AllowLeadingWhite | global::System.Globalization.DateTimeStyles.AllowTrailingWhite | global::System.Globalization.DateTimeStyles.AllowInnerWhite | global::System.Globalization.DateTimeStyles.AssumeUniversal);
					}
					if (!flag2)
					{
						end = dateTime;
					}
					return new global::Infragistics.DateRange(dateTime, end);
				}
			}
			throw new global::System.FormatException(global::Infragistics.DateRange.GetString("LE_InvalidDateRangeString", new object[]
			{
				value
			}));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0000A661 File Offset: 0x00008861
		internal static string GetString(string name, params object[] args)
		{
			return global::SR.GetString(name, args);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000A66C File Offset: 0x0000886C
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

		// Token: 0x06000262 RID: 610 RVA: 0x0000A71C File Offset: 0x0000891C
		public bool Equals(global::Infragistics.DateRange other)
		{
			return this == other;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000A72C File Offset: 0x0000892C
		public int CompareTo(global::Infragistics.DateRange other)
		{
			int num = this._start.CompareTo(other._start);
			if (num == 0)
			{
				num = this._end.CompareTo(other._end);
			}
			return num;
		}

		// Token: 0x040000B8 RID: 184
		private global::System.DateTime _start;

		// Token: 0x040000B9 RID: 185
		private global::System.DateTime _end;

		// Token: 0x040000BA RID: 186
		private static readonly global::Infragistics.DateRange _Infinite = new global::Infragistics.DateRange(global::System.DateTime.MinValue, global::System.DateTime.MaxValue);
	}
}
