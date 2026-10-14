using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000033 RID: 51
	public class CalendarDimensionsConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000340 RID: 832 RVA: 0x0000CFA1 File Offset: 0x0000B1A1
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000CFBF File Offset: 0x0000B1BF
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor);
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000CFE8 File Offset: 0x0000B1E8
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("value", value);
			string text = value as string;
			if (text == null)
			{
				base.GetConvertFromException(value);
			}
			return global::Infragistics.Windows.Editors.CalendarDimensions.FromString(text, culture);
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000D020 File Offset: 0x0000B220
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("value", value);
			global::Infragistics.Windows.Editors.Utils.ValidateNull("destinationType", destinationType);
			if (!(value is global::Infragistics.Windows.Editors.CalendarDimensions))
			{
				base.GetConvertToException(value, destinationType);
			}
			global::Infragistics.Windows.Editors.CalendarDimensions calendarDimensions = (global::Infragistics.Windows.Editors.CalendarDimensions)value;
			if (destinationType == typeof(string))
			{
				return calendarDimensions.ToString(culture);
			}
			if (destinationType != typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.XamMonthCalendar.GetString("LE_CannotConvertType", new object[]
				{
					typeof(global::Infragistics.Windows.Editors.CalendarDimensions),
					global::Infragistics.CoreUtilities.GetUnderlyingType(destinationType).FullName
				}));
			}
			return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(typeof(global::Infragistics.Windows.Editors.CalendarDimensions).GetConstructor(new global::System.Type[]
			{
				typeof(int),
				typeof(int)
			}), new object[]
			{
				calendarDimensions.Rows,
				calendarDimensions.Columns
			});
		}
	}
}
