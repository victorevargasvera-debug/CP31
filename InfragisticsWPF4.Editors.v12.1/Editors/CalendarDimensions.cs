using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002F RID: 47
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Editors.CalendarDimensionsConverter))]
	public struct CalendarDimensions : global::System.IEquatable<global::Infragistics.Windows.Editors.CalendarDimensions>
	{
		// Token: 0x06000312 RID: 786 RVA: 0x0000C4E2 File Offset: 0x0000A6E2
		public CalendarDimensions(int rows, int columns)
		{
			if (rows < 0 || columns < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_InvalidCalendarDimensions"));
			}
			this._rows = rows;
			this._columns = columns;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000C50A File Offset: 0x0000A70A
		public override int GetHashCode()
		{
			return this._columns.GetHashCode() ^ this._rows.GetHashCode();
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000C523 File Offset: 0x0000A723
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.Editors.CalendarDimensions && this == (global::Infragistics.Windows.Editors.CalendarDimensions)obj;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000C540 File Offset: 0x0000A740
		public static bool operator ==(global::Infragistics.Windows.Editors.CalendarDimensions item1, global::Infragistics.Windows.Editors.CalendarDimensions item2)
		{
			return item1._rows == item2._rows && item1._columns == item2._columns;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000C564 File Offset: 0x0000A764
		public static bool operator !=(global::Infragistics.Windows.Editors.CalendarDimensions item1, global::Infragistics.Windows.Editors.CalendarDimensions item2)
		{
			return !(item1 == item2);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000C570 File Offset: 0x0000A770
		public override string ToString()
		{
			return this.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000C57D File Offset: 0x0000A77D
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0000C585 File Offset: 0x0000A785
		public int Columns
		{
			get
			{
				return this._columns;
			}
			set
			{
				if (this._columns != value)
				{
					if (value < 0)
					{
						throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_InvalidCalendarDimensions"));
					}
					this._columns = value;
				}
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000C5AB File Offset: 0x0000A7AB
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0000C5B3 File Offset: 0x0000A7B3
		public int Rows
		{
			get
			{
				return this._rows;
			}
			set
			{
				if (this._rows != value)
				{
					if (value < 0)
					{
						throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_InvalidCalendarDimensions"));
					}
					this._rows = value;
				}
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000C5DC File Offset: 0x0000A7DC
		internal static global::Infragistics.Windows.Editors.CalendarDimensions FromString(string value, global::System.Globalization.CultureInfo culture)
		{
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			string[] array = value.Split(new string[]
			{
				culture.TextInfo.ListSeparator
			}, global::System.StringSplitOptions.None);
			if (array.Length == 2 && array[0].Trim().Length > 0 && array[1].Trim().Length > 0)
			{
				global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(int));
				int rows = (int)converter.ConvertFromString(null, culture, array[0]);
				int columns = (int)converter.ConvertFromString(null, culture, array[1]);
				return new global::Infragistics.Windows.Editors.CalendarDimensions(rows, columns);
			}
			throw new global::System.FormatException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_InvalidDimensionsString", new object[]
			{
				value
			}));
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000C694 File Offset: 0x0000A894
		internal string ToString(global::System.Globalization.CultureInfo culture)
		{
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			string listSeparator = culture.TextInfo.ListSeparator;
			return this._rows.ToString(culture) + listSeparator + this._columns.ToString(culture);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000C6D7 File Offset: 0x0000A8D7
		public bool Equals(global::Infragistics.Windows.Editors.CalendarDimensions other)
		{
			return this == other;
		}

		// Token: 0x04000120 RID: 288
		private int _rows;

		// Token: 0x04000121 RID: 289
		private int _columns;
	}
}
