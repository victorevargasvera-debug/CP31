using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace DevAge.ComponentModel.Converter
{
	// Token: 0x020002B1 RID: 689
	internal class DateTimeTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06002225 RID: 8741 RVA: 0x00078D14 File Offset: 0x00076F14
		public DateTimeTypeConverter()
		{
		}

		// Token: 0x06002226 RID: 8742 RVA: 0x00078D44 File Offset: 0x00076F44
		public DateTimeTypeConverter(string p_ToStringFormat)
		{
			this.m_Format = p_ToStringFormat;
		}

		// Token: 0x06002227 RID: 8743 RVA: 0x00078D7C File Offset: 0x00076F7C
		public DateTimeTypeConverter(string p_ToStringFormat, string[] p_ParseFormats)
		{
			this.m_ParseFormats = p_ParseFormats;
			this.m_Format = p_ToStringFormat;
		}

		// Token: 0x06002228 RID: 8744 RVA: 0x00078DBC File Offset: 0x00076FBC
		public DateTimeTypeConverter(string p_ToStringFormat, string[] p_ParseFormats, global::System.Globalization.DateTimeStyles p_DateTimeStyles)
		{
			this.m_ParseFormats = p_ParseFormats;
			this.m_Format = p_ToStringFormat;
			this.m_DateTimeStyles = p_DateTimeStyles;
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x00078E10 File Offset: 0x00077010
		// (set) Token: 0x0600222A RID: 8746 RVA: 0x00078E18 File Offset: 0x00077018
		public global::System.ComponentModel.TypeConverter BaseTypeConverter
		{
			get
			{
				return this.m_BaseTypeConverter;
			}
			set
			{
				this.m_BaseTypeConverter = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x0600222B RID: 8747 RVA: 0x00078E24 File Offset: 0x00077024
		// (set) Token: 0x0600222C RID: 8748 RVA: 0x00078E2C File Offset: 0x0007702C
		public global::System.Globalization.DateTimeStyles DateTimeStyles
		{
			get
			{
				return this.m_DateTimeStyles;
			}
			set
			{
				this.m_DateTimeStyles = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x0600222D RID: 8749 RVA: 0x00078E38 File Offset: 0x00077038
		// (set) Token: 0x0600222E RID: 8750 RVA: 0x00078E40 File Offset: 0x00077040
		public string Format
		{
			get
			{
				return this.m_Format;
			}
			set
			{
				this.m_Format = value;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x0600222F RID: 8751 RVA: 0x00078E4C File Offset: 0x0007704C
		// (set) Token: 0x06002230 RID: 8752 RVA: 0x00078E54 File Offset: 0x00077054
		public string[] ParseFormats
		{
			get
			{
				return this.m_ParseFormats;
			}
			set
			{
				this.m_ParseFormats = value;
			}
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x00078E60 File Offset: 0x00077060
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || this.m_BaseTypeConverter.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06002232 RID: 8754 RVA: 0x00078E84 File Offset: 0x00077084
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || this.m_BaseTypeConverter.CanConvertTo(context, destinationType);
		}

		// Token: 0x06002233 RID: 8755 RVA: 0x00078EA8 File Offset: 0x000770A8
		public override object CreateInstance(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Collections.IDictionary propertyValues)
		{
			return this.m_BaseTypeConverter.CreateInstance(context, propertyValues);
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x00078EB8 File Offset: 0x000770B8
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value == null || value.GetType() != typeof(string))
			{
				return this.m_BaseTypeConverter.ConvertFrom(context, culture, value);
			}
			if (this.m_ParseFormats != null)
			{
				return global::System.DateTime.ParseExact((string)value, this.m_ParseFormats, this.GetCulture(culture).DateTimeFormat, this.m_DateTimeStyles);
			}
			return global::System.DateTime.Parse((string)value, this.GetCulture(culture).DateTimeFormat, this.m_DateTimeStyles);
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x00078F4C File Offset: 0x0007714C
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (destinationType == typeof(string) && value != null)
			{
				return ((global::System.DateTime)value).ToString(this.m_Format, this.GetCulture(culture).DateTimeFormat);
			}
			return this.m_BaseTypeConverter.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x00078FA8 File Offset: 0x000771A8
		public override bool GetCreateInstanceSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetCreateInstanceSupported(context);
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x00078FB8 File Offset: 0x000771B8
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.ComponentModel.ITypeDescriptorContext context, object value, global::System.Attribute[] attributes)
		{
			return this.m_BaseTypeConverter.GetProperties(context, value, attributes);
		}

		// Token: 0x06002238 RID: 8760 RVA: 0x00078FC8 File Offset: 0x000771C8
		public override bool GetPropertiesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetPropertiesSupported(context);
		}

		// Token: 0x06002239 RID: 8761 RVA: 0x00078FD8 File Offset: 0x000771D8
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValues(context);
		}

		// Token: 0x0600223A RID: 8762 RVA: 0x00078FE8 File Offset: 0x000771E8
		public override bool GetStandardValuesExclusive(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValuesExclusive(context);
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x00078FF8 File Offset: 0x000771F8
		public override bool GetStandardValuesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValuesSupported(context);
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x00079008 File Offset: 0x00077208
		public override bool IsValid(global::System.ComponentModel.ITypeDescriptorContext context, object value)
		{
			if (value != null && value.GetType() == typeof(string))
			{
				try
				{
					this.ConvertFrom(context, global::System.Globalization.CultureInfo.CurrentCulture, value);
					return true;
				}
				catch (global::System.Exception)
				{
					return false;
				}
			}
			return this.m_BaseTypeConverter.IsValid(context, value);
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0007906C File Offset: 0x0007726C
		private global::System.Globalization.CultureInfo GetCulture(global::System.Globalization.CultureInfo p_RequestedCulture)
		{
			if (p_RequestedCulture == null)
			{
				return global::System.Globalization.CultureInfo.CurrentCulture;
			}
			return p_RequestedCulture;
		}

		// Token: 0x04000C61 RID: 3169
		private global::System.ComponentModel.TypeConverter m_BaseTypeConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(typeof(global::System.DateTime));

		// Token: 0x04000C62 RID: 3170
		private global::System.Globalization.DateTimeStyles m_DateTimeStyles = global::System.Globalization.DateTimeStyles.AllowWhiteSpaces;

		// Token: 0x04000C63 RID: 3171
		private string m_Format = "G";

		// Token: 0x04000C64 RID: 3172
		private string[] m_ParseFormats;
	}
}
