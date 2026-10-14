using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200002A RID: 42
	public class CalendarDateRangeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x0000B2A7 File Offset: 0x000094A7
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000B2C5 File Offset: 0x000094C5
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000B2EC File Offset: 0x000094EC
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

		// Token: 0x060002DC RID: 732 RVA: 0x0000B324 File Offset: 0x00009524
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
					destinationType.FullName
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
