using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

namespace DevAge.ComponentModel.Converter
{
	// Token: 0x02000282 RID: 642
	internal class NumberTypeConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x060020B3 RID: 8371 RVA: 0x00075424 File Offset: 0x00073624
		public NumberTypeConverter(global::System.Type p_BaseType)
		{
			this.BaseType = p_BaseType;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x00075448 File Offset: 0x00073648
		public NumberTypeConverter(global::System.Type p_BaseType, string p_Format) : this(p_BaseType)
		{
			this.Format = p_Format;
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x060020B5 RID: 8373 RVA: 0x00075458 File Offset: 0x00073658
		// (set) Token: 0x060020B6 RID: 8374 RVA: 0x00075460 File Offset: 0x00073660
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

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x060020B7 RID: 8375 RVA: 0x0007546C File Offset: 0x0007366C
		// (set) Token: 0x060020B8 RID: 8376 RVA: 0x00075474 File Offset: 0x00073674
		public global::System.Type BaseType
		{
			get
			{
				return this.m_BaseType;
			}
			set
			{
				if (value != typeof(double) && value != typeof(float) && value != typeof(decimal) && value != typeof(int))
				{
					throw new global::System.ArgumentException("Type not supported", "BaseType");
				}
				this.m_BaseTypeConverter = global::System.ComponentModel.TypeDescriptor.GetConverter(value);
				this.m_BaseType = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x060020B9 RID: 8377 RVA: 0x000754E8 File Offset: 0x000736E8
		// (set) Token: 0x060020BA RID: 8378 RVA: 0x000754F0 File Offset: 0x000736F0
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

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x060020BB RID: 8379 RVA: 0x000754FC File Offset: 0x000736FC
		// (set) Token: 0x060020BC RID: 8380 RVA: 0x00075504 File Offset: 0x00073704
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

		// Token: 0x060020BD RID: 8381 RVA: 0x00075510 File Offset: 0x00073710
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			return sourceType == typeof(string) || this.m_BaseTypeConverter.CanConvertFrom(context, sourceType);
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x00075534 File Offset: 0x00073734
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			return destinationType == typeof(string) || this.m_BaseTypeConverter.CanConvertTo(context, destinationType);
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x00075558 File Offset: 0x00073758
		public override object CreateInstance(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Collections.IDictionary propertyValues)
		{
			return this.m_BaseTypeConverter.CreateInstance(context, propertyValues);
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x00075568 File Offset: 0x00073768
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			if (value == null || value.GetType() != typeof(string))
			{
				return this.m_BaseTypeConverter.ConvertFrom(context, culture, value);
			}
			if (this.BaseType == typeof(double))
			{
				return global::DevAge.ComponentModel.Converter.NumberTypeConverter.StringToDouble((string)value, this.NumberStyles, this.GetCulture(culture).NumberFormat);
			}
			if (this.BaseType == typeof(decimal))
			{
				return global::DevAge.ComponentModel.Converter.NumberTypeConverter.StringToDecimal((string)value, this.NumberStyles, this.GetCulture(culture).NumberFormat);
			}
			if (this.BaseType == typeof(float))
			{
				return global::DevAge.ComponentModel.Converter.NumberTypeConverter.StringToFloat((string)value, this.NumberStyles, this.GetCulture(culture).NumberFormat);
			}
			if (this.BaseType == typeof(int))
			{
				return global::DevAge.ComponentModel.Converter.NumberTypeConverter.StringToInt((string)value, this.NumberStyles, this.GetCulture(culture).NumberFormat);
			}
			throw new global::System.ArgumentException("Not supported type");
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x00075690 File Offset: 0x00073890
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (destinationType != typeof(string) || value == null)
			{
				return this.m_BaseTypeConverter.ConvertTo(context, culture, value, destinationType);
			}
			if (this.BaseType == typeof(double))
			{
				return global::DevAge.ComponentModel.Converter.NumberTypeConverter.DoubleToString((double)value, this.Format, this.GetCulture(culture).NumberFormat);
			}
			if (this.BaseType == typeof(decimal))
			{
				return global::DevAge.ComponentModel.Converter.NumberTypeConverter.DecimalToString((decimal)value, this.Format, this.GetCulture(culture).NumberFormat);
			}
			if (this.BaseType == typeof(float))
			{
				return global::DevAge.ComponentModel.Converter.NumberTypeConverter.FloatToString((float)value, this.Format, this.GetCulture(culture).NumberFormat);
			}
			if (this.BaseType == typeof(int))
			{
				return global::DevAge.ComponentModel.Converter.NumberTypeConverter.IntToString((int)value, this.Format, this.GetCulture(culture).NumberFormat);
			}
			return this.m_BaseTypeConverter.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x000757A8 File Offset: 0x000739A8
		public override bool GetCreateInstanceSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetCreateInstanceSupported(context);
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x000757B8 File Offset: 0x000739B8
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.ComponentModel.ITypeDescriptorContext context, object value, global::System.Attribute[] attributes)
		{
			return this.m_BaseTypeConverter.GetProperties(context, value, attributes);
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x000757C8 File Offset: 0x000739C8
		public override bool GetPropertiesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetPropertiesSupported(context);
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x000757D8 File Offset: 0x000739D8
		public override global::System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValues(context);
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x000757E8 File Offset: 0x000739E8
		public override bool GetStandardValuesExclusive(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValuesExclusive(context);
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x000757F8 File Offset: 0x000739F8
		public override bool GetStandardValuesSupported(global::System.ComponentModel.ITypeDescriptorContext context)
		{
			return this.m_BaseTypeConverter.GetStandardValuesSupported(context);
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00075808 File Offset: 0x00073A08
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

		// Token: 0x060020C9 RID: 8393 RVA: 0x0007586C File Offset: 0x00073A6C
		private global::System.Globalization.CultureInfo GetCulture(global::System.Globalization.CultureInfo p_RequestedCulture)
		{
			if (p_RequestedCulture == null)
			{
				return global::System.Globalization.CultureInfo.CurrentCulture;
			}
			return p_RequestedCulture;
		}

		// Token: 0x060020CA RID: 8394 RVA: 0x0007587C File Offset: 0x00073A7C
		public static double StringToDouble(string p_strVal, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			return double.Parse(p_strVal, style, provider);
		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00075888 File Offset: 0x00073A88
		public static float StringToFloat(string p_strVal, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			return float.Parse(p_strVal, style, provider);
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00075894 File Offset: 0x00073A94
		public static decimal StringToDecimal(string p_strVal, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			return decimal.Parse(p_strVal, style, provider);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x000758A0 File Offset: 0x00073AA0
		public static int StringToInt(string p_strVal, global::System.Globalization.NumberStyles style, global::System.IFormatProvider provider)
		{
			return int.Parse(p_strVal, style, provider);
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000758AC File Offset: 0x00073AAC
		public static string DoubleToString(double p_Val, string format, global::System.IFormatProvider provider)
		{
			return p_Val.ToString(format, provider);
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x000758B8 File Offset: 0x00073AB8
		public static string FloatToString(float p_Val, string format, global::System.IFormatProvider provider)
		{
			return p_Val.ToString(format, provider);
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000758C4 File Offset: 0x00073AC4
		public static string DecimalToString(decimal p_Val, string format, global::System.IFormatProvider provider)
		{
			return p_Val.ToString(format, provider);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x000758D0 File Offset: 0x00073AD0
		public static string IntToString(int p_Val, string format, global::System.IFormatProvider provider)
		{
			return p_Val.ToString(format, provider);
		}

		// Token: 0x04000C0F RID: 3087
		private global::System.ComponentModel.TypeConverter m_BaseTypeConverter;

		// Token: 0x04000C10 RID: 3088
		private global::System.Type m_BaseType;

		// Token: 0x04000C11 RID: 3089
		private string m_Format = "G";

		// Token: 0x04000C12 RID: 3090
		private global::System.Globalization.NumberStyles m_NumberStyles = global::System.Globalization.NumberStyles.Number;
	}
}
