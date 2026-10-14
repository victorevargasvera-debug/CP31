using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;

namespace Infragistics
{
	// Token: 0x02000036 RID: 54
	public class DateRangeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06000266 RID: 614 RVA: 0x0000A781 File Offset: 0x00008981
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0000A79F File Offset: 0x0000899F
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor);
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0000A7CC File Offset: 0x000089CC
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(value, "value");
			string text = value as string;
			if (text == null)
			{
				base.GetConvertFromException(value);
			}
			return global::Infragistics.DateRange.FromString(text, culture);
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000A804 File Offset: 0x00008A04
		[global::System.Security.SecuritySafeCritical]
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			global::Infragistics.CoreUtilities.ValidateNotNull(value, "value");
			global::Infragistics.CoreUtilities.ValidateNotNull(destinationType, "destinationType");
			if (!(value is global::Infragistics.DateRange))
			{
				base.GetConvertToException(value, destinationType);
			}
			global::Infragistics.DateRange dateRange = (global::Infragistics.DateRange)value;
			if (destinationType == typeof(string))
			{
				return dateRange.ToString(culture, null, true);
			}
			if (!(destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor)))
			{
				throw new global::System.ArgumentException(global::Infragistics.DateRange.GetString("LE_CannotConvertType", new object[]
				{
					typeof(global::Infragistics.DateRange),
					global::Infragistics.CoreUtilities.GetUnderlyingType(destinationType).FullName
				}));
			}
			if (dateRange.IsEmpty)
			{
				return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(typeof(global::Infragistics.DateRange).GetConstructor(new global::System.Type[]
				{
					typeof(global::System.DateTime)
				}), new object[]
				{
					dateRange.Start
				});
			}
			return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(typeof(global::Infragistics.DateRange).GetConstructor(new global::System.Type[]
			{
				typeof(global::System.DateTime),
				typeof(global::System.DateTime)
			}), new object[]
			{
				dateRange.Start,
				dateRange.End
			});
		}
	}
}
