using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace DevAge.ComponentModel.Converter
{
	// Token: 0x020002C5 RID: 709
	internal class PercentTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060022A3 RID: 8867 RVA: 0x00079DD0 File Offset: 0x00077FD0
		public PercentTypeConverter(global::System.Type p_BaseType)
		{
			this.BaseType = p_BaseType;
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x00079DFC File Offset: 0x00077FFC
		public PercentTypeConverter(global::System.Type p_BaseType, string p_Format) : this(p_BaseType)
		{
			this.Format = p_Format;
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x00079E0C File Offset: 0x0007800C
		// (set) Token: 0x060022A6 RID: 8870 RVA: 0x00079E14 File Offset: 0x00078014
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

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x060022A7 RID: 8871 RVA: 0x00079E20 File Offset: 0x00078020
		// (set) Token: 0x060022A8 RID: 8872 RVA: 0x00079E28 File Offset: 0x00078028
		public global::System.Type BaseType
		{
			get
			{
				return this.m_BaseType;
			}
			set
			{
				if (value != typeof(double) && value != typeof(float) && value != typeof(decimal))
				{
					throw new global::System.ArgumentException("Type not supported", "BaseType");
				}
				this.m_BaseTypeConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(value);
				this.m_BaseType = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00079E8C File Offset: 0x0007808C
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x00079E94 File Offset: 0x00078094
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

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x00079EA0 File Offset: 0x000780A0
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x00079EA8 File Offset: 0x000780A8
		public bool ConsiderAllStringAsPercent
		{
			get
			{
				return this.m_ConsiderAllStringAsPercent;
			}
			set
			{
				this.m_ConsiderAllStringAsPercent = value;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x00079EB4 File Offset: 0x000780B4
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x00079EBC File Offset: 0x000780BC
		public global::System.Globalization.NumberStyles NumberStyles
		{
			get
			{
				return this.m_NumberStyles;
			}
			set
			{
				this.m_NumberStyles = value;
			}
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00079EC8 File Offset: 0x000780C8
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || this.m_BaseTypeConverter.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00079EEC File Offset: 0x000780EC
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || this.m_BaseTypeConverter.CanConvertTo(context, destinationType);
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00079F10 File Offset: 0x00078110
		public override object CreateInstance(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Collections.IDictionary propertyValues)
		{
			return this.m_BaseTypeConverter.CreateInstance(context, propertyValues);
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00079F20 File Offset: 0x00078120
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value == null || value.GetType() != typeof(string))
			{
				return this.m_BaseTypeConverter.ConvertFrom(context, culture, value);
			}
			if (this.BaseType == typeof(double))
			{
				return global::DevAge.ComponentModel.Converter.PercentTypeConverter.StringToDouble((string)value, this.NumberStyles, this.GetCulture(culture).NumberFormat, this.ConsiderAllStringAsPercent);
			}
			if (this.BaseType == typeof(decimal))
			{
				return global::DevAge.ComponentModel.Converter.PercentTypeConverter.StringToDecimal((string)value, this.NumberStyles, this.GetCulture(culture).NumberFormat, this.ConsiderAllStringAsPercent);
			}
			if (this.BaseType == typeof(float))
			{
				return global::DevAge.ComponentModel.Converter.PercentTypeConverter.StringToFloat((string)value, this.NumberStyles, this.GetCulture(culture).NumberFormat, this.ConsiderAllStringAsPercent);
			}
			throw new global::System.ArgumentException("Not supported type");
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x0007A020 File Offset: 0x00078220
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (destinationType != typeof(string) || value == null)
			{
				return this.m_BaseTypeConverter.ConvertTo(context, culture, value, destinationType);
			}
			if (this.BaseType == typeof(double))
			{
				return global::DevAge.ComponentModel.Converter.PercentTypeConverter.DoubleToString((double)value, this.Format, this.GetCulture(culture).NumberFormat);
			}
			if (this.BaseType == typeof(decimal))
			{
				return global::DevAge.ComponentModel.Converter.PercentTypeConverter.DecimalToString((decimal)value, this.Format, this.GetCulture(culture).NumberFormat);
			}
			if (this.BaseType == typeof(float))
			{
				return global::DevAge.ComponentModel.Converter.PercentTypeConverter.FloatToString((float)value, this.Format, this.GetCulture(culture).NumberFormat);
			}
			return this.m_BaseTypeConverter.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x0007A104 File Offset: 0x00078304
		public override bool GetCreateInstanceSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetCreateInstanceSupported(context);
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x0007A114 File Offset: 0x00078314
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.ComponentModel.ITypeDescriptorContext context, object value, global::System.Attribute[] attributes)
		{
			return this.m_BaseTypeConverter.GetProperties(context, value, attributes);
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0007A124 File Offset: 0x00078324
		public override bool GetPropertiesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetPropertiesSupported(context);
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0007A134 File Offset: 0x00078334
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValues(context);
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0007A144 File Offset: 0x00078344
		public override bool GetStandardValuesExclusive(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValuesExclusive(context);
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0007A154 File Offset: 0x00078354
		public override bool GetStandardValuesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValuesSupported(context);
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0007A164 File Offset: 0x00078364
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

		// Token: 0x060022BB RID: 8891 RVA: 0x0007A1C8 File Offset: 0x000783C8
		private global::System.Globalization.CultureInfo GetCulture(global::System.Globalization.CultureInfo p_RequestedCulture)
		{
			if (p_RequestedCulture == null)
			{
				return global::System.Globalization.CultureInfo.CurrentCulture;
			}
			return p_RequestedCulture;
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x0007A1D8 File Offset: 0x000783D8
		public static bool IsPercentString(string p_strVal, global::System.IFormatProvider provider)
		{
			global::System.Globalization.NumberFormatInfo numberFormatInfo;
			if (provider == null)
			{
				numberFormatInfo = global::System.Globalization.CultureInfo.CurrentCulture.NumberFormat;
			}
			else
			{
				numberFormatInfo = (global::System.Globalization.NumberFormatInfo)provider.GetFormat(typeof(global::System.Globalization.NumberFormatInfo));
			}
			return p_strVal.IndexOf(numberFormatInfo.PercentSymbol) != -1;
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x0007A22C File Offset: 0x0007842C
		public static double StringToDouble(string p_strVal, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, bool p_ConsiderAllStringAsPercent)
		{
			bool flag = global::DevAge.ComponentModel.Converter.PercentTypeConverter.IsPercentString(p_strVal, provider);
			if (flag)
			{
				return double.Parse(p_strVal.Replace("%", ""), style, provider) / 100.0;
			}
			if (p_ConsiderAllStringAsPercent)
			{
				return double.Parse(p_strVal, style, provider) / 100.0;
			}
			return double.Parse(p_strVal, style, provider);
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x0007A290 File Offset: 0x00078490
		public static float StringToFloat(string p_strVal, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, bool p_ConsiderAllStringAsPercent)
		{
			bool flag = global::DevAge.ComponentModel.Converter.PercentTypeConverter.IsPercentString(p_strVal, provider);
			if (flag)
			{
				return float.Parse(p_strVal.Replace("%", ""), style, provider) / 100f;
			}
			if (p_ConsiderAllStringAsPercent)
			{
				return float.Parse(p_strVal, style, provider) / 100f;
			}
			return float.Parse(p_strVal, style, provider);
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x0007A2EC File Offset: 0x000784EC
		public static decimal StringToDecimal(string p_strVal, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider, bool p_ConsiderAllStringAsPercent)
		{
			bool flag = global::DevAge.ComponentModel.Converter.PercentTypeConverter.IsPercentString(p_strVal, provider);
			if (flag)
			{
				return decimal.Parse(p_strVal.Replace("%", ""), style, provider) / 100.0m;
			}
			if (p_ConsiderAllStringAsPercent)
			{
				return decimal.Parse(p_strVal, style, provider) / 100.0m;
			}
			return decimal.Parse(p_strVal, style, provider);
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x0007A360 File Offset: 0x00078560
		public static string DoubleToString(double p_Val, string format, global::System.IFormatProvider provider)
		{
			return p_Val.ToString(format, provider);
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x0007A36C File Offset: 0x0007856C
		public static string FloatToString(float p_Val, string format, global::System.IFormatProvider provider)
		{
			return p_Val.ToString(format, provider);
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0007A378 File Offset: 0x00078578
		public static string DecimalToString(decimal p_Val, string format, global::System.IFormatProvider provider)
		{
			return p_Val.ToString(format, provider);
		}

		// Token: 0x04000C71 RID: 3185
		private global::System.ComponentModel.TypeConverter m_BaseTypeConverter;

		// Token: 0x04000C72 RID: 3186
		private global::System.Type m_BaseType;

		// Token: 0x04000C73 RID: 3187
		private string m_Format = "P";

		// Token: 0x04000C74 RID: 3188
		private bool m_ConsiderAllStringAsPercent = true;

		// Token: 0x04000C75 RID: 3189
		private global::System.Globalization.NumberStyles m_NumberStyles = global::System.Globalization.NumberStyles.Number;
	}
}
