using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200028D RID: 653
	public class ColumnWidthTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x0600160C RID: 5644 RVA: 0x00054006 File Offset: 0x00052206
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00054018 File Offset: 0x00052218
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value is string)
			{
				string text = value.ToString().ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
				double value2 = -1.0;
				if (double.TryParse(text, out value2))
				{
					return new global::Infragistics.Controls.Grids.ColumnWidth(value2, false);
				}
				if (text.IndexOf('*') != -1)
				{
					text = text.Replace('*', ' ');
					if (double.TryParse(text, out value2))
					{
						return new global::Infragistics.Controls.Grids.ColumnWidth(value2, true);
					}
					return global::Infragistics.Controls.Grids.ColumnWidth.Star;
				}
				else
				{
					if (text == "AUTO")
					{
						return global::Infragistics.Controls.Grids.ColumnWidth.Auto;
					}
					if (text == "SIZETOCELLS")
					{
						return global::Infragistics.Controls.Grids.ColumnWidth.SizeToCells;
					}
					if (text == "SIZETOHEADER")
					{
						return global::Infragistics.Controls.Grids.ColumnWidth.SizeToHeader;
					}
					if (text == "INITIALAUTO")
					{
						return global::Infragistics.Controls.Grids.ColumnWidth.InitialAuto;
					}
					if (text == "STAR")
					{
						return global::Infragistics.Controls.Grids.ColumnWidth.Star;
					}
				}
			}
			return null;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x00054113 File Offset: 0x00052313
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x00054128 File Offset: 0x00052328
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			string result = "";
			if (value != null)
			{
				global::Infragistics.Controls.Grids.ColumnWidth columnWidth = (global::Infragistics.Controls.Grids.ColumnWidth)value;
				if (columnWidth.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Numeric)
				{
					result = columnWidth.Value.ToString();
				}
				else if (columnWidth.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star)
				{
					result = columnWidth.Value.ToString() + "*";
				}
				else
				{
					result = columnWidth.WidthType.ToString();
				}
			}
			return result;
		}
	}
}
