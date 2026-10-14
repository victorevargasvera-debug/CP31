using System;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x020000C6 RID: 198
	public static class TypeUtil
	{
		// Token: 0x0600084F RID: 2127 RVA: 0x0002729C File Offset: 0x0002549C
		public static global::System.ComponentModel.TypeConverter GetTypeConverter(this global::System.Type type)
		{
			object[] customAttributes = type.GetCustomAttributes(typeof(global::System.ComponentModel.TypeConverterAttribute), true);
			global::System.ComponentModel.TypeConverterAttribute typeConverterAttribute = (customAttributes != null && customAttributes.Length > 0) ? (customAttributes[0] as global::System.ComponentModel.TypeConverterAttribute) : null;
			global::System.Type type2 = (typeConverterAttribute != null) ? global::System.Type.GetType(typeConverterAttribute.ConverterTypeName) : null;
			if (!(type2 != null))
			{
				return null;
			}
			return global::System.Activator.CreateInstance(type2) as global::System.ComponentModel.TypeConverter;
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x000272F8 File Offset: 0x000254F8
		public static object ChangeType(this global::System.Type type, object value)
		{
			if (value == null)
			{
				return value;
			}
			global::System.Type type2 = value.GetType();
			object obj = type.IsAssignableFrom(type2) ? value : null;
			if (obj == null)
			{
				try
				{
					obj = global::System.Convert.ChangeType(value, type, null);
				}
				catch
				{
				}
			}
			if (obj == null)
			{
				global::System.ComponentModel.TypeConverter typeConverter = type.GetTypeConverter();
				if (typeConverter != null && typeConverter.CanConvertFrom(type2))
				{
					try
					{
						obj = typeConverter.ConvertFrom(value);
					}
					catch
					{
					}
				}
			}
			if (obj == null)
			{
				global::System.ComponentModel.TypeConverter typeConverter2 = type2.GetTypeConverter();
				if (typeConverter2 != null && typeConverter2.CanConvertTo(type))
				{
					try
					{
						obj = typeConverter2.ConvertTo(value, type);
					}
					catch
					{
					}
				}
			}
			return obj;
		}
	}
}
