using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000122 RID: 290
	public class FieldLengthConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06001134 RID: 4404 RVA: 0x0004C240 File Offset: 0x0004A440
		static FieldLengthConverter()
		{
			global::System.Collections.Generic.Dictionary<string, double> dictionary = new global::System.Collections.Generic.Dictionary<string, double>();
			dictionary["px"] = 1.0;
			dictionary["in"] = 96.0;
			dictionary["cm"] = 37.79527559055118;
			dictionary["pt"] = 1.3333333333333333;
			global::Infragistics.Windows.DataPresenter.FieldLengthConverter._pixelFactors = dictionary;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x0004C2B1 File Offset: 0x0004A4B1
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return global::Infragistics.Windows.Utilities.IsNumericType(sourceType) || sourceType == typeof(string);
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x0004C2D4 File Offset: 0x0004A4D4
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

		// Token: 0x06001138 RID: 4408 RVA: 0x0004C33B File Offset: 0x0004A53B
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor) || destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0004C370 File Offset: 0x0004A570
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

		// Token: 0x0600113A RID: 4410 RVA: 0x0004C448 File Offset: 0x0004A648
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

		// Token: 0x0600113B RID: 4411 RVA: 0x0004C554 File Offset: 0x0004A754
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

		// Token: 0x0600113C RID: 4412 RVA: 0x0004C5D0 File Offset: 0x0004A7D0
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

		// Token: 0x040006FB RID: 1787
		private static global::System.Collections.Generic.Dictionary<string, double> _pixelFactors;
	}
}
