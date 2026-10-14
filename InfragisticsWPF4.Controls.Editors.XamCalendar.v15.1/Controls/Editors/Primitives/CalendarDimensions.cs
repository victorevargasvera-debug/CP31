using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000019 RID: 25
	[global::System.ComponentModel.TypeConverter(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDimensionsConverter))]
	public struct CalendarDimensions : global::System.IEquatable<global::Infragistics.Controls.Editors.Primitives.CalendarDimensions>
	{
		// Token: 0x060000E3 RID: 227 RVA: 0x0000539E File Offset: 0x0000359E
		public CalendarDimensions(int rows, int columns)
		{
			if (rows < 0 || columns < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Controls.Editors.CalendarBase.GetString("LE_InvalidCalendarDimensions"));
			}
			this._rows = rows;
			this._columns = columns;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000053C6 File Offset: 0x000035C6
		public override int GetHashCode()
		{
			return this._columns.GetHashCode() ^ this._rows.GetHashCode();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000053DF File Offset: 0x000035DF
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Controls.Editors.Primitives.CalendarDimensions && this == (global::Infragistics.Controls.Editors.Primitives.CalendarDimensions)obj;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000053FC File Offset: 0x000035FC
		public static bool operator ==(global::Infragistics.Controls.Editors.Primitives.CalendarDimensions item1, global::Infragistics.Controls.Editors.Primitives.CalendarDimensions item2)
		{
			return item1._rows == item2._rows && item1._columns == item2._columns;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00005420 File Offset: 0x00003620
		public static bool operator !=(global::Infragistics.Controls.Editors.Primitives.CalendarDimensions item1, global::Infragistics.Controls.Editors.Primitives.CalendarDimensions item2)
		{
			return !(item1 == item2);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000542C File Offset: 0x0000362C
		public override string ToString()
		{
			return this.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x00005439 File Offset: 0x00003639
		// (set) Token: 0x060000EA RID: 234 RVA: 0x00005441 File Offset: 0x00003641
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
						throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Controls.Editors.CalendarBase.GetString("LE_InvalidCalendarDimensions"));
					}
					this._columns = value;
				}
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000EB RID: 235 RVA: 0x00005467 File Offset: 0x00003667
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000546F File Offset: 0x0000366F
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
						throw new global::System.ArgumentOutOfRangeException(global::Infragistics.Controls.Editors.CalendarBase.GetString("LE_InvalidCalendarDimensions"));
					}
					this._rows = value;
				}
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00005498 File Offset: 0x00003698
		internal static global::Infragistics.Controls.Editors.Primitives.CalendarDimensions FromString(string value, global::System.Globalization.CultureInfo culture)
		{
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			string[] array = value.Split(new string[]
			{
				culture.TextInfo.ListSeparator
			}, global::System.StringSplitOptions.None);
			if (array.Length == 2 && array[0].Trim().Length > 0 && array[1].Trim().Length > 0)
			{
				global::System.ComponentModel.TypeConverter converter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(int));
				int rows = (int)converter.ConvertFrom(null, culture, array[0]);
				int columns = (int)converter.ConvertFrom(null, culture, array[1]);
				return new global::Infragistics.Controls.Editors.Primitives.CalendarDimensions(rows, columns);
			}
			throw new global::System.FormatException(global::Infragistics.Controls.Editors.CalendarBase.GetString("LE_InvalidDimensionsString", new object[]
			{
				value
			}));
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00005550 File Offset: 0x00003750
		internal string ToString(global::System.Globalization.CultureInfo culture)
		{
			culture = (culture ?? global::System.Globalization.CultureInfo.CurrentCulture);
			string listSeparator = culture.TextInfo.ListSeparator;
			return this._rows.ToString(culture) + listSeparator + this._columns.ToString(culture);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00005593 File Offset: 0x00003793
		public bool Equals(global::Infragistics.Controls.Editors.Primitives.CalendarDimensions other)
		{
			return this == other;
		}

		// Token: 0x04000058 RID: 88
		private int _rows;

		// Token: 0x04000059 RID: 89
		private int _columns;
	}
}
