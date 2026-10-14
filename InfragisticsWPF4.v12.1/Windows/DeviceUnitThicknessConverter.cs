using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace Infragistics.Windows
{
	// Token: 0x02000100 RID: 256
	public class DeviceUnitThicknessConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000996 RID: 2454 RVA: 0x0001F593 File Offset: 0x0001D793
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || global::Infragistics.Windows.Utilities.IsNumericType(sourceType);
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0001F5B4 File Offset: 0x0001D7B4
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(value, "value");
			if (value is string)
			{
				string text = value as string;
				global::Infragistics.Windows.DeviceUnitType type;
				global::Infragistics.Windows.DeviceUnitLengthConverter.ParseUnit(ref text, out type);
				global::System.Windows.Thickness thickness = (global::System.Windows.Thickness)new global::System.Windows.ThicknessConverter().ConvertFromString(context, culture, text);
				return new global::Infragistics.Windows.DeviceUnitThickness(thickness.Left, thickness.Top, thickness.Right, thickness.Bottom, type);
			}
			if (!global::Infragistics.Windows.Utilities.IsNumericType(value.GetType()))
			{
				throw base.GetConvertFromException(value);
			}
			object value2 = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(double), culture, null);
			return new global::Infragistics.Windows.DeviceUnitLength(global::System.Convert.ToDouble(value2));
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0001F657 File Offset: 0x0001D857
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor) || destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0001F68C File Offset: 0x0001D88C
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(value, "value");
			global::Infragistics.CoreUtilities.ValidateNotNull(destinationType, "destinationType");
			if (!(value is global::Infragistics.Windows.DeviceUnitThickness))
			{
				throw base.GetConvertToException(value, destinationType);
			}
			global::Infragistics.Windows.DeviceUnitThickness deviceUnitThickness = (global::Infragistics.Windows.DeviceUnitThickness)value;
			if (destinationType == typeof(string))
			{
				if (deviceUnitThickness.IsUniform)
				{
					return global::Infragistics.Windows.DeviceUnitLengthConverter.ToString(new global::Infragistics.Windows.DeviceUnitLength(deviceUnitThickness.Left, deviceUnitThickness.UnitType), culture);
				}
				global::System.Windows.Thickness thickness = new global::System.Windows.Thickness(deviceUnitThickness.Left, deviceUnitThickness.Top, deviceUnitThickness.Right, deviceUnitThickness.Bottom);
				string str = new global::System.Windows.ThicknessConverter().ConvertToString(context, culture, thickness);
				return str + global::Infragistics.Windows.DeviceUnitLengthConverter.GetSuffix(deviceUnitThickness.UnitType);
			}
			else
			{
				if (!(destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor)))
				{
					return base.ConvertTo(context, culture, value, destinationType);
				}
				global::System.Reflection.ConstructorInfo constructor;
				if (deviceUnitThickness.IsUniform)
				{
					constructor = typeof(global::Infragistics.Windows.DeviceUnitLength).GetConstructor(new global::System.Type[]
					{
						typeof(double),
						typeof(global::Infragistics.Windows.DeviceUnitType)
					});
					return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(constructor, new object[]
					{
						deviceUnitThickness.Left,
						deviceUnitThickness.UnitType
					}, true);
				}
				constructor = typeof(global::Infragistics.Windows.DeviceUnitLength).GetConstructor(new global::System.Type[]
				{
					typeof(double),
					typeof(double),
					typeof(double),
					typeof(double),
					typeof(global::Infragistics.Windows.DeviceUnitType)
				});
				return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(constructor, new object[]
				{
					deviceUnitThickness.Left,
					deviceUnitThickness.Top,
					deviceUnitThickness.Right,
					deviceUnitThickness.Bottom,
					deviceUnitThickness.UnitType
				}, true);
			}
		}
	}
}
