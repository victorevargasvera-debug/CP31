using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000106 RID: 262
	public class FieldLengthConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000DD3 RID: 3539 RVA: 0x0003B780 File Offset: 0x00039980
		static FieldLengthConverter()
		{
			global::System.Collections.Generic.Dictionary<string, double> dictionary = new global::System.Collections.Generic.Dictionary<string, double>();
			dictionary["px"] = 1.0;
			dictionary["in"] = 96.0;
			dictionary["cm"] = 37.79527559055118;
			dictionary["pt"] = 1.3333333333333333;
			global::Infragistics.Windows.DataPresenter.FieldLengthConverter._pixelFactors = dictionary;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0003B7F1 File Offset: 0x000399F1
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return global::Infragistics.Windows.Utilities.IsNumericType(sourceType) || sourceType == typeof(string);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0003B814 File Offset: 0x00039A14
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(value, "value");
			string text = value as string;
			if (text != null)
			{
				return global::Infragistics.Windows.DataPresenter.FieldLengthConverter.FromString(text, culture);
			}
			object value2 = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(double), culture, null);
			double num = global::System.Convert.ToDouble(value2);
			if (double.IsNaN(num))
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength.Auto;
			}
			return new global::Infragistics.Windows.DataPresenter.FieldLength(num);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0003B87B File Offset: 0x00039A7B
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor) || destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0003B8B0 File Offset: 0x00039AB0
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(value, "value");
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(destinationType, "destinationType");
			if (!(value is global::Infragistics.Windows.DataPresenter.FieldLength))
			{
				throw base.GetConvertToException(value, destinationType);
			}
			global::Infragistics.Windows.DataPresenter.FieldLength fieldLength = (global::Infragistics.Windows.DataPresenter.FieldLength)value;
			if (destinationType == typeof(string))
			{
				return global::Infragistics.Windows.DataPresenter.FieldLengthConverter.ToString(fieldLength, culture);
			}
			if (destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor))
			{
				global::System.Reflection.ConstructorInfo constructor = typeof(global::Infragistics.Windows.DataPresenter.FieldLength).GetConstructor(new global::System.Type[]
				{
					typeof(double),
					typeof(global::Infragistics.Windows.DataPresenter.FieldLengthUnitType)
				});
				return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(constructor, new object[]
				{
					fieldLength.Value,
					fieldLength.UnitType
				}, true);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0003B988 File Offset: 0x00039B88
		private static global::Infragistics.Windows.DataPresenter.FieldLength FromString(string strValue, global::System.Globalization.CultureInfo culture)
		{
			strValue = strValue.Trim().ToLower(culture ?? global::System.Globalization.CultureInfo.InvariantCulture);
			if (strValue == "auto")
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength.Auto;
			}
			if (strValue == "initialauto")
			{
				return global::Infragistics.Windows.DataPresenter.FieldLength.InitialAuto;
			}
			if (strValue == "*")
			{
				return new global::Infragistics.Windows.DataPresenter.FieldLength(1.0, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Star);
			}
			if (strValue == "px")
			{
				return new global::Infragistics.Windows.DataPresenter.FieldLength(1.0);
			}
			double num;
			if (global::Infragistics.Windows.DataPresenter.FieldLengthConverter.TryParseUnit(strValue, culture, "*", out num))
			{
				return new global::Infragistics.Windows.DataPresenter.FieldLength(num, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Star);
			}
			foreach (global::System.Collections.Generic.KeyValuePair<string, double> keyValuePair in global::Infragistics.Windows.DataPresenter.FieldLengthConverter._pixelFactors)
			{
				if (global::Infragistics.Windows.DataPresenter.FieldLengthConverter.TryParseUnit(strValue, culture, keyValuePair.Key, out num))
				{
					return new global::Infragistics.Windows.DataPresenter.FieldLength(num * keyValuePair.Value, global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Pixel);
				}
			}
			return new global::Infragistics.Windows.DataPresenter.FieldLength(global::System.Convert.ToDouble(strValue, culture));
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0003BA94 File Offset: 0x00039C94
		internal static string ToString(global::Infragistics.Windows.DataPresenter.FieldLength fieldLength, global::System.Globalization.CultureInfo cultureInfo)
		{
			switch (fieldLength.UnitType)
			{
			case global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Auto:
				return "Auto";
			case global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.Star:
				if (global::Infragistics.Windows.DataPresenter.GridUtilities.AreClose(1.0, fieldLength.Value))
				{
					return "*";
				}
				return global::System.Convert.ToString(fieldLength.Value, cultureInfo) + "*";
			case global::Infragistics.Windows.DataPresenter.FieldLengthUnitType.InitialAuto:
				return "InitialAuto";
			}
			return global::System.Convert.ToString(fieldLength.Value, cultureInfo);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0003BB10 File Offset: 0x00039D10
		private static bool TryParseUnit(string strValue, global::System.Globalization.CultureInfo culture, string unitString, out double value)
		{
			value = double.NaN;
			if (strValue.EndsWith(unitString))
			{
				string value2 = strValue.Substring(0, strValue.Length - unitString.Length);
				value = global::System.Convert.ToDouble(value2, culture);
				return true;
			}
			return false;
		}

		// Token: 0x0400055C RID: 1372
		private static global::System.Collections.Generic.Dictionary<string, double> _pixelFactors;
	}
}
