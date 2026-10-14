using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Markup;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000200 RID: 512
	internal class StaticPropertyResourceKeyConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x00047968 File Offset: 0x00045B68
		internal static void CacheType(global::System.Type type)
		{
			lock (global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter.s_Lock)
			{
				global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter.s_typesWithResourceKeys[type.Name] = type;
			}
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x000479B4 File Offset: 0x00045BB4
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			if (sourceType == null)
			{
				throw new global::System.ArgumentNullException("sourceType");
			}
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000479E6 File Offset: 0x00045BE6
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			if (destinationType == null)
			{
				throw new global::System.ArgumentNullException("destinationType");
			}
			return (destinationType == typeof(global::System.Windows.Markup.MarkupExtension) && context is global::System.Windows.Markup.IValueSerializerContext) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x00047A20 File Offset: 0x00045C20
		public override object ConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value)
		{
			string text = value as string;
			if (text != null)
			{
				string[] array = text.Split(new char[]
				{
					'.'
				});
				if (array.Length == 2)
				{
					lock (global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter.s_Lock)
					{
						global::System.Type type;
						if (!global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter.s_typesWithResourceKeys.TryGetValue(array[0], out type))
						{
							throw new global::System.FormatException(global::SR.GetString("LE_StringFormatException_3", new object[]
							{
								array[0]
							}));
						}
						global::System.Reflection.FieldInfo field = type.GetField(array[1]);
						if (field != null)
						{
							return field.GetValue(null);
						}
						global::System.Reflection.PropertyInfo property = type.GetProperty(array[1]);
						if (property != null)
						{
							global::System.Reflection.MethodInfo getMethod = property.GetGetMethod();
							if (getMethod != null)
							{
								return getMethod.Invoke(null, null);
							}
						}
						throw new global::System.FormatException(global::SR.GetString("LE_StringFormatException_2", new object[]
						{
							type.FullName,
							array[1]
						}));
					}
				}
				throw new global::System.FormatException(global::SR.GetString("LE_StringFormatException_1", new object[]
				{
					text
				}));
			}
			return base.ConvertFrom(context, culture, value);
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x00047B6C File Offset: 0x00045D6C
		public override object ConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Globalization.CultureInfo culture, object value, global::System.Type destinationType)
		{
			if (destinationType == null)
			{
				throw new global::System.ArgumentNullException("destinationType");
			}
			if (destinationType == typeof(global::System.Windows.Markup.MarkupExtension))
			{
				global::Infragistics.Windows.Themes.StaticPropertyResourceKey staticPropertyResourceKey = value as global::Infragistics.Windows.Themes.StaticPropertyResourceKey;
				if (staticPropertyResourceKey != null)
				{
					global::System.Windows.Markup.IValueSerializerContext valueSerializerContext = context as global::System.Windows.Markup.IValueSerializerContext;
					if (valueSerializerContext != null)
					{
						global::System.Windows.Markup.ValueSerializer valueSerializerFor = valueSerializerContext.GetValueSerializerFor(typeof(global::System.Type));
						if (valueSerializerFor != null)
						{
							global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
							stringBuilder.Append(valueSerializerFor.ConvertToString(staticPropertyResourceKey.Type, valueSerializerContext));
							stringBuilder.Append(".");
							stringBuilder.Append(staticPropertyResourceKey.PropertyName);
							return new global::System.Windows.Markup.StaticExtension(stringBuilder.ToString());
						}
					}
				}
			}
			return base.ConvertTo(context, culture, value, destinationType);
		}

		// Token: 0x040009F6 RID: 2550
		private static global::System.Collections.Generic.Dictionary<string, global::System.Type> s_typesWithResourceKeys = new global::System.Collections.Generic.Dictionary<string, global::System.Type>();

		// Token: 0x040009F7 RID: 2551
		private static object s_Lock = new object();
	}
}
