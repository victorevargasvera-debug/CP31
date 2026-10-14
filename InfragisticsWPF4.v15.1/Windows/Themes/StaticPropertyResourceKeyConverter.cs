using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection;
using System.Text;
using System.Windows.Markup;

namespace Infragistics.Windows.Themes
{
	// Token: 0x02000230 RID: 560
	internal class StaticPropertyResourceKeyConverter : global::System.ComponentModel.TypeConverter
	{
		// Token: 0x06001545 RID: 5445 RVA: 0x0004D6B4 File Offset: 0x0004B8B4
		internal static void CacheType(global::System.Type type)
		{
			lock (global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter.s_Lock)
			{
				global::Infragistics.Windows.Themes.StaticPropertyResourceKeyConverter.s_typesWithResourceKeys[type.Name] = type;
			}
		}

		// Token: 0x06001546 RID: 5446 RVA: 0x0004D700 File Offset: 0x0004B900
		public override bool CanConvertFrom(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type sourceType)
		{
			if (sourceType == null)
			{
				throw new global::System.ArgumentNullException("sourceType");
			}
			return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x0004D732 File Offset: 0x0004B932
		public override bool CanConvertTo(global::System.ComponentModel.ITypeDescriptorContext context, global::System.Type destinationType)
		{
			if (destinationType == null)
			{
				throw new global::System.ArgumentNullException("destinationType");
			}
			return (destinationType == typeof(global::System.Windows.Markup.MarkupExtension) && context is global::System.Windows.Markup.IValueSerializerContext) || base.CanConvertTo(context, destinationType);
		}

		// Token: 0x06001548 RID: 5448 RVA: 0x0004D76C File Offset: 0x0004B96C
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

		// Token: 0x06001549 RID: 5449 RVA: 0x0004D8B8 File Offset: 0x0004BAB8
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

		// Token: 0x04000B41 RID: 2881
		private static global::System.Collections.Generic.Dictionary<string, global::System.Type> s_typesWithResourceKeys = new global::System.Collections.Generic.Dictionary<string, global::System.Type>();

		// Token: 0x04000B42 RID: 2882
		private static object s_Lock = new object();
	}
}
