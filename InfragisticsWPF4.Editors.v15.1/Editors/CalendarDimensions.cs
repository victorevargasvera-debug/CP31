using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000032 RID: 50
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Windows.Editors.CalendarDimensionsConverter))]
	public struct CalendarDimensions : global::System.IEquatable<global::Infragistics.Windows.Editors.CalendarDimensions>
	{
		// Token: 0x06000332 RID: 818 RVA: 0x0000CD96 File Offset: 0x0000AF96
		public CalendarDimensions(int rows, int columns)
		{
			if (rows < 0 || columns < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_InvalidCalendarDimensions"));
			}
			this._rows = rows;
			this._columns = columns;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000CDBE File Offset: 0x0000AFBE
		public override int GetHashCode()
		{
			return this._columns.GetHashCode() ^ this._rows.GetHashCode();
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000CDD7 File Offset: 0x0000AFD7
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.Editors.CalendarDimensions && this == (global::Infragistics.Windows.Editors.CalendarDimensions)obj;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		public static bool operator ==(global::Infragistics.Windows.Editors.CalendarDimensions item1, global::Infragistics.Windows.Editors.CalendarDimensions item2)
		{
			return item1._rows == item2._rows && item1._columns == item2._columns;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000CE18 File Offset: 0x0000B018
		public static bool operator !=(global::Infragistics.Windows.Editors.CalendarDimensions item1, global::Infragistics.Windows.Editors.CalendarDimensions item2)
		{
			return !(item1 == item2);
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000CE24 File Offset: 0x0000B024
		public override string ToString()
		{
			return this.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000CE31 File Offset: 0x0000B031
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000CE39 File Offset: 0x0000B039
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

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000CE5F File Offset: 0x0000B05F
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000CE67 File Offset: 0x0000B067
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

		// Token: 0x0600033C RID: 828 RVA: 0x0000CE90 File Offset: 0x0000B090
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

		// Token: 0x0600033D RID: 829 RVA: 0x0000CF48 File Offset: 0x0000B148
		internal string ToString(global::System.Globalization.CultureInfo culture)
		{
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			string listSeparator = culture.TextInfo.ListSeparator;
			return this._rows.ToString(culture) + listSeparator + this._columns.ToString(culture);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000CF8B File Offset: 0x0000B18B
		public bool Equals(global::Infragistics.Windows.Editors.CalendarDimensions other)
		{
			return this == other;
		}

		// Token: 0x04000138 RID: 312
		private int _rows;

		// Token: 0x04000139 RID: 313
		private int _columns;
	}
}
