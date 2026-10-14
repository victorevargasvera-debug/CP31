using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace Infragistics.Windows
{
	// Token: 0x0200011A RID: 282
	public class DeviceUnitLengthConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000A61 RID: 2657 RVA: 0x00022798 File Offset: 0x00020998
		static DeviceUnitLengthConverter()
		{
			global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DeviceUnitType, string> dictionary = new global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DeviceUnitType, string>();
			dictionary[global::Infragistics.Windows.DeviceUnitType.Centimeter] = "cm";
			dictionary[global::Infragistics.Windows.DeviceUnitType.Inch] = "in";
			dictionary[global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit] = string.Empty;
			dictionary[global::Infragistics.Windows.DeviceUnitType.Pixel] = "px";
			dictionary[global::Infragistics.Windows.DeviceUnitType.Point] = "pt";
			dictionary[global::Infragistics.Windows.DeviceUnitType.Twip] = "twip";
			global::Infragistics.Windows.DeviceUnitLengthConverter._suffixTable = dictionary;
		}

		// Token: 0x06000A63 RID: 2659 RVA: 0x00022801 File Offset: 0x00020A01
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || global::Infragistics.Windows.Utilities.IsNumericType(sourceType);
		}

		// Token: 0x06000A64 RID: 2660 RVA: 0x00022824 File Offset: 0x00020A24
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value == null)
			{
				throw new global::System.ArgumentException("value");
			}
			if (value is string)
			{
				return global::Infragistics.Windows.DeviceUnitLengthConverter.FromString(value as string, culture);
			}
			if (!global::Infragistics.Windows.Utilities.IsNumericType(value.GetType()))
			{
				throw base.GetConvertFromException(value);
			}
			object value2 = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(double), culture, null);
			double num = global::System.Convert.ToDouble(value2);
			if (double.IsNaN(num))
			{
				return new global::Infragistics.Windows.DeviceUnitLength(0.0);
			}
			return new global::Infragistics.Windows.DeviceUnitLength(num);
		}

		// Token: 0x06000A65 RID: 2661 RVA: 0x000228AF File Offset: 0x00020AAF
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor) || destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06000A66 RID: 2662 RVA: 0x000228E4 File Offset: 0x00020AE4
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (value == null)
			{
				throw new global::System.ArgumentException("value");
			}
			if (destinationType == null)
			{
				throw new global::System.ArgumentException("destinationType");
			}
			if (!(value is global::Infragistics.Windows.DeviceUnitLength))
			{
				throw base.GetConvertToException(value, destinationType);
			}
			global::Infragistics.Windows.DeviceUnitLength length = (global::Infragistics.Windows.DeviceUnitLength)value;
			if (destinationType == typeof(string))
			{
				return global::Infragistics.Windows.DeviceUnitLengthConverter.ToString(length, culture);
			}
			if (destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor))
			{
				global::System.Reflection.ConstructorInfo constructor = typeof(global::Infragistics.Windows.DeviceUnitLength).GetConstructor(new global::System.Type[]
				{
					typeof(double),
					typeof(global::Infragistics.Windows.DeviceUnitType)
				});
				return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(constructor, new object[]
				{
					length.Value,
					length.UnitType
				}, true);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x000229C8 File Offset: 0x00020BC8
		internal static global::Infragistics.Windows.DeviceUnitLength FromString(string strValue, global::System.Globalization.CultureInfo culture)
		{
			global::Infragistics.Windows.DeviceUnitType type = global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit;
			global::Infragistics.Windows.DeviceUnitLengthConverter.ParseUnit(ref strValue, out type);
			return new global::Infragistics.Windows.DeviceUnitLength(global::System.Convert.ToDouble(strValue, culture), type);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x000229ED File Offset: 0x00020BED
		internal static string GetSuffix(global::Infragistics.Windows.DeviceUnitType unitType)
		{
			return global::Infragistics.Windows.DeviceUnitLengthConverter._suffixTable[unitType];
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x000229FC File Offset: 0x00020BFC
		internal static void ParseUnit(ref string strValue, out global::Infragistics.Windows.DeviceUnitType unit)
		{
			unit = global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit;
			foreach (global::System.Collections.Generic.KeyValuePair<global::Infragistics.Windows.DeviceUnitType, string> keyValuePair in global::Infragistics.Windows.DeviceUnitLengthConverter._suffixTable)
			{
				if (!string.IsNullOrEmpty(keyValuePair.Value) && strValue.EndsWith(keyValuePair.Value))
				{
					unit = keyValuePair.Key;
					strValue = strValue.Substring(0, strValue.Length - keyValuePair.Value.Length);
					break;
				}
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00022A94 File Offset: 0x00020C94
		internal static string ToString(global::Infragistics.Windows.DeviceUnitLength length, global::System.Globalization.CultureInfo culture)
		{
			string suffix = global::Infragistics.Windows.DeviceUnitLengthConverter.GetSuffix(length.UnitType);
			string text = global::System.Convert.ToString(length.Value, culture);
			if (!string.IsNullOrEmpty(suffix))
			{
				text += suffix;
			}
			return text;
		}

		// Token: 0x04000483 RID: 1155
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DeviceUnitType, string> _suffixTable;
	}
}
