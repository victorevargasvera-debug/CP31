using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Reflection;
using System.Windows;

namespace Infragistics.Windows
{
	// Token: 0x0200011C RID: 284
	public class DeviceUnitSizeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000A7B RID: 2683 RVA: 0x00022C34 File Offset: 0x00020E34
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || global::Infragistics.Windows.Utilities.IsNumericType(sourceType);
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00022C58 File Offset: 0x00020E58
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(value, "value");
			if (value is string)
			{
				string text = value as string;
				global::Infragistics.Windows.DeviceUnitType type;
				global::Infragistics.Windows.DeviceUnitLengthConverter.ParseUnit(ref text, out type);
				global::System.Windows.Size size = (global::System.Windows.Size)new global::System.Windows.SizeConverter().ConvertFromString(context, culture, text);
				if (size.IsEmpty)
				{
					throw base.GetConvertFromException(value);
				}
				return new global::Infragistics.Windows.DeviceUnitSize(size.Width, size.Height, type);
			}
			else
			{
				if (!global::Infragistics.Windows.Utilities.IsNumericType(value.GetType()))
				{
					throw base.GetConvertFromException(value);
				}
				object value2 = global::Infragistics.CoreUtilities.ConvertDataValue(value, typeof(double), culture, null);
				return new global::Infragistics.Windows.DeviceUnitLength(global::System.Convert.ToDouble(value2));
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x00022CFE File Offset: 0x00020EFE
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor) || destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x00022D30 File Offset: 0x00020F30
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(value, "value");
			global::Infragistics.CoreUtilities.ValidateNotNull(destinationType, "destinationType");
			if (!(value is global::Infragistics.Windows.DeviceUnitSize))
			{
				throw base.GetConvertToException(value, destinationType);
			}
			global::Infragistics.Windows.DeviceUnitSize deviceUnitSize = (global::Infragistics.Windows.DeviceUnitSize)value;
			if (destinationType == typeof(string))
			{
				global::System.Windows.Size size = new global::System.Windows.Size(deviceUnitSize.Width, deviceUnitSize.Height);
				string str = new global::System.Windows.SizeConverter().ConvertToString(context, culture, size);
				return str + global::Infragistics.Windows.DeviceUnitLengthConverter.GetSuffix(deviceUnitSize.UnitType);
			}
			if (destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor))
			{
				global::System.Reflection.ConstructorInfo constructor = typeof(global::Infragistics.Windows.DeviceUnitLength).GetConstructor(new global::System.Type[]
				{
					typeof(double),
					typeof(double),
					typeof(double),
					typeof(double),
					typeof(global::Infragistics.Windows.DeviceUnitType)
				});
				return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(constructor, new object[]
				{
					deviceUnitSize.Width,
					deviceUnitSize.Height,
					deviceUnitSize.UnitType
				}, true);
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}
	}
}
