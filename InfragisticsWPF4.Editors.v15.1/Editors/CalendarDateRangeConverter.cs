using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002D RID: 45
	public class CalendarDateRangeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x0000BB57 File Offset: 0x00009D57
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000BB75 File Offset: 0x00009D75
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0000BB9C File Offset: 0x00009D9C
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("value", value);
			string text = value as string;
			if (text == null)
			{
				base.GetConvertFromException(value);
			}
			return global::Infragistics.Windows.Editors.CalendarDateRange.FromString(text, culture);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000BBD4 File Offset: 0x00009DD4
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			global::Infragistics.Windows.Editors.Utils.ValidateNull("value", value);
			global::Infragistics.Windows.Editors.Utils.ValidateNull("destinationType", destinationType);
			if (!(value is global::Infragistics.Windows.Editors.CalendarDateRange))
			{
				base.GetConvertToException(value, destinationType);
			}
			global::Infragistics.Windows.Editors.CalendarDateRange calendarDateRange = (global::Infragistics.Windows.Editors.CalendarDateRange)value;
			if (destinationType == typeof(string))
			{
				return calendarDateRange.ToString(culture);
			}
			if (destinationType != typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor))
			{
				throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.CalendarDateRange.GetString("LE_CannotConvertType", new object[]
				{
					typeof(global::Infragistics.Windows.Editors.CalendarDateRange),
					global::Infragistics.CoreUtilities.GetUnderlyingType(destinationType).FullName
				}));
			}
			if (calendarDateRange.Start == calendarDateRange.End)
			{
				return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(typeof(global::Infragistics.Windows.Editors.CalendarDateRange).GetConstructor(new global::System.Type[]
				{
					typeof(global::System.DateTime)
				}), new object[]
				{
					calendarDateRange.Start
				});
			}
			return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(typeof(global::Infragistics.Windows.Editors.CalendarDateRange).GetConstructor(new global::System.Type[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime)
			}), new object[]
			{
				calendarDateRange.Start,
				calendarDateRange.End
			});
		}
	}
}
