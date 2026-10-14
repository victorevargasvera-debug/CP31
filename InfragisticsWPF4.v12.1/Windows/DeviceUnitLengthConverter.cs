using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;

namespace Infragistics.Windows
{
	// Token: 0x020000FC RID: 252
	public class DeviceUnitLengthConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000962 RID: 2402 RVA: 0x0001EBD0 File Offset: 0x0001CDD0
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

		// Token: 0x06000964 RID: 2404 RVA: 0x0001EC39 File Offset: 0x0001CE39
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || global::Infragistics.Windows.Utilities.IsNumericType(sourceType);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x0001EC5C File Offset: 0x0001CE5C
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

		// Token: 0x06000966 RID: 2406 RVA: 0x0001ECE7 File Offset: 0x0001CEE7
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor) || destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x0001ED1C File Offset: 0x0001CF1C
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

		// Token: 0x06000968 RID: 2408 RVA: 0x0001EE00 File Offset: 0x0001D000
		internal static global::Infragistics.Windows.DeviceUnitLength FromString(string strValue, global::System.Globalization.CultureInfo culture)
		{
			global::Infragistics.Windows.DeviceUnitType type = global::Infragistics.Windows.DeviceUnitType.DeviceIndependentUnit;
			global::Infragistics.Windows.DeviceUnitLengthConverter.ParseUnit(ref strValue, out type);
			return new global::Infragistics.Windows.DeviceUnitLength(global::System.Convert.ToDouble(strValue, culture), type);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x0001EE25 File Offset: 0x0001D025
		internal static string GetSuffix(global::Infragistics.Windows.DeviceUnitType unitType)
		{
			return global::Infragistics.Windows.DeviceUnitLengthConverter._suffixTable[unitType];
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x0001EE34 File Offset: 0x0001D034
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

		// Token: 0x0600096B RID: 2411 RVA: 0x0001EECC File Offset: 0x0001D0CC
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

		// Token: 0x040003D0 RID: 976
		private static global::System.Collections.Generic.Dictionary<global::Infragistics.Windows.DeviceUnitType, string> _suffixTable;
	}
}
