using System;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Security;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x0200001A RID: 26
	public class CalendarDimensionsConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060000F1 RID: 241 RVA: 0x000055A9 File Offset: 0x000037A9
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000055C7 File Offset: 0x000037C7
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000055F4 File Offset: 0x000037F4
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNull("value", value);
			string text = value as string;
			if (text == null)
			{
				base.GetConvertFromException(value);
			}
			return global::Infragistics.Controls.Editors.Primitives.CalendarDimensions.FromString(text, culture);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000562C File Offset: 0x0000382C
		[global::System.Security.SecuritySafeCritical]
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNull("value", value);
			global::Infragistics.Controls.Editors.CalendarUtilities.ValidateNull("destinationType", destinationType);
			if (!(value is global::Infragistics.Controls.Editors.Primitives.CalendarDimensions))
			{
				base.GetConvertToException(value, destinationType);
			}
			global::Infragistics.Controls.Editors.Primitives.CalendarDimensions calendarDimensions = (global::Infragistics.Controls.Editors.Primitives.CalendarDimensions)value;
			if (destinationType == typeof(string))
			{
				return calendarDimensions.ToString(culture);
			}
			if (destinationType == typeof(global::System.ComponentModel.Design.Serialization.InstanceDescriptor))
			{
				return new global::System.ComponentModel.Design.Serialization.InstanceDescriptor(typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDimensions).GetConstructor(new global::System.Type[]
				{
					typeof(int),
					typeof(int)
				}), new object[]
				{
					calendarDimensions.Rows,
					calendarDimensions.Columns
				});
			}
			throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.CalendarBase.GetString("LE_CannotConvertType", new object[]
			{
				typeof(global::Infragistics.Controls.Editors.Primitives.CalendarDimensions),
				global::Infragistics.CoreUtilities.GetUnderlyingType(destinationType).FullName
			}));
		}
	}
}
