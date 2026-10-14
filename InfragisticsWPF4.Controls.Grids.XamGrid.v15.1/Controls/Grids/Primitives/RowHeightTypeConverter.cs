using System;
using System.ComponentModel;
using System.Globalization;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000293 RID: 659
	public class RowHeightTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x0600161F RID: 5663 RVA: 0x0005438C File Offset: 0x0005258C
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x000543A0 File Offset: 0x000525A0
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value is string)
			{
				string text = value.ToString().ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
				double value2 = -1.0;
				if (double.TryParse(text, out value2))
				{
					return new global::Infragistics.Controls.Grids.RowHeight(value2);
				}
				if (text == "DYNAMIC")
				{
					return global::Infragistics.Controls.Grids.RowHeight.Dynamic;
				}
				if (text == "SIZETOLARGESTCELL")
				{
					return global::Infragistics.Controls.Grids.RowHeight.SizeToLargestCell;
				}
			}
			return null;
		}

		// Token: 0x06001621 RID: 5665 RVA: 0x00054417 File Offset: 0x00052617
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string);
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x0005442C File Offset: 0x0005262C
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			string result = "";
			if (value != null)
			{
				global::Infragistics.Controls.Grids.RowHeight rowHeight = (global::Infragistics.Controls.Grids.RowHeight)value;
				if (rowHeight.HeightType == global::Infragistics.Controls.Grids.RowHeightType.Numeric)
				{
					result = rowHeight.Value.ToString();
				}
				else
				{
					result = rowHeight.HeightType.ToString();
				}
			}
			return result;
		}
	}
}
