using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using NLog.Common;
using NLog.Internal;

namespace NLog.Targets
{
	// Token: 0x02000035 RID: 53
	public class DefaultJsonSerializer : global::NLog.IJsonConverter, global::NLog.Targets.IJsonSerializer
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0000B3E4 File Offset: 0x000095E4
		public static global::NLog.Targets.DefaultJsonSerializer Instance
		{
			get
			{
				return global::NLog.Targets.DefaultJsonSerializer.instance;
			}
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x0000B3F8 File Offset: 0x000095F8
		private DefaultJsonSerializer()
		{
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x0000B453 File Offset: 0x00009653
		public string SerializeObject(object value)
		{
			return this.SerializeObject(value, this._serializeOptions);
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0000B464 File Offset: 0x00009664
		public string SerializeObject(object value, global::NLog.Targets.JsonSerializeOptions options)
		{
			if (value == null)
			{
				return "null";
			}
			string text;
			if ((text = (value as string)) != null)
			{
				for (int i = 0; i < text.Length; i++)
				{
					if (global::NLog.Targets.DefaultJsonSerializer.RequiresJsonEscape(text[i], options.EscapeUnicode))
					{
						global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(text.Length + 4);
						stringBuilder.Append('"');
						global::NLog.Targets.DefaultJsonSerializer.AppendStringEscape(stringBuilder, text, options.EscapeUnicode);
						stringBuilder.Append('"');
						return stringBuilder.ToString();
					}
				}
				return global::NLog.Targets.DefaultJsonSerializer.QuoteValue(text);
			}
			global::System.TypeCode typeCode = global::System.Convert.GetTypeCode(value);
			if (typeCode != global::System.TypeCode.Object && typeCode != global::System.TypeCode.Char && global::NLog.Internal.StringHelpers.IsNullOrWhiteSpace(options.Format) && options.FormatProvider == null)
			{
				global::System.Enum value2;
				if (!options.EnumAsInteger && global::NLog.Targets.DefaultJsonSerializer.IsNumericTypeCode(typeCode, false) && (value2 = (value as global::System.Enum)) != null)
				{
					return global::NLog.Targets.DefaultJsonSerializer.QuoteValue(this.EnumAsString(value2));
				}
				string text2 = global::NLog.Internal.XmlHelper.XmlConvertToString(value, typeCode);
				if (global::NLog.Targets.DefaultJsonSerializer.SkipQuotes(typeCode))
				{
					return text2;
				}
				return global::NLog.Targets.DefaultJsonSerializer.QuoteValue(text2);
			}
			else
			{
				global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
				if (!this.SerializeObject(value, stringBuilder2, options))
				{
					return null;
				}
				return stringBuilder2.ToString();
			}
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x0000B566 File Offset: 0x00009766
		public bool SerializeObject(object value, global::System.Text.StringBuilder destination)
		{
			return this.SerializeObject(value, destination, this._serializeOptions);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x0000B578 File Offset: 0x00009778
		public bool SerializeObject(object value, global::System.Text.StringBuilder destination, global::NLog.Targets.JsonSerializeOptions options)
		{
			return this.SerializeObject(value, destination, options, default(global::NLog.Internal.SingleItemOptimizedHashSet<object>), 0);
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x0000B598 File Offset: 0x00009798
		private bool SerializeObject(object value, global::System.Text.StringBuilder destination, global::NLog.Targets.JsonSerializeOptions options, global::NLog.Internal.SingleItemOptimizedHashSet<object> objectsInPath, int depth)
		{
			if (objectsInPath.Contains(value))
			{
				return false;
			}
			string text;
			if (value == null)
			{
				destination.Append("null");
			}
			else if ((text = (value as string)) != null)
			{
				destination.Append('"');
				global::NLog.Targets.DefaultJsonSerializer.AppendStringEscape(destination, text, options.EscapeUnicode);
				destination.Append('"');
			}
			else
			{
				global::System.Collections.IDictionary dictionary;
				if ((dictionary = (value as global::System.Collections.IDictionary)) != null)
				{
					using (new global::NLog.Internal.SingleItemOptimizedHashSet<object>.SingleItemScopedInsert(dictionary, ref objectsInPath, true))
					{
						this.SerializeDictionaryObject(dictionary, destination, options, objectsInPath, depth);
						return true;
					}
				}
				global::System.Collections.IEnumerable value2;
				if ((value2 = (value as global::System.Collections.IEnumerable)) != null)
				{
					using (new global::NLog.Internal.SingleItemOptimizedHashSet<object>.SingleItemScopedInsert(value, ref objectsInPath, true))
					{
						this.SerializeCollectionObject(value2, destination, options, objectsInPath, depth);
						return true;
					}
				}
				string format = options.Format;
				bool flag = !global::NLog.Internal.StringHelpers.IsNullOrWhiteSpace(format);
				global::System.IFormattable formattable;
				if ((options.FormatProvider != null || flag) && (formattable = (value as global::System.IFormattable)) != null)
				{
					if (!this.SerializeWithFormatProvider(value, destination, options, formattable, format, flag))
					{
						return false;
					}
				}
				else if (!this.SerializeTypeCodeValue(value, destination, options, objectsInPath, depth))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0000B6C8 File Offset: 0x000098C8
		private bool SerializeWithFormatProvider(object value, global::System.Text.StringBuilder destination, global::NLog.Targets.JsonSerializeOptions options, global::System.IFormattable formattable, string format, bool hasFormat)
		{
			int length = destination.Length;
			bool result;
			try
			{
				bool flag = !global::NLog.Targets.DefaultJsonSerializer.SkipQuotes(global::System.Convert.GetTypeCode(value));
				if (flag)
				{
					destination.Append('"');
				}
				if (hasFormat)
				{
					global::System.IFormatProvider provider = options.FormatProvider ?? this._defaultFormatProvider;
					destination.AppendFormat(provider, "{0:" + format + "}", new object[]
					{
						value
					});
				}
				else
				{
					string text = formattable.ToString("", options.FormatProvider);
					global::NLog.Targets.DefaultJsonSerializer.AppendStringEscape(destination, text, options.EscapeUnicode);
				}
				if (flag)
				{
					destination.Append('"');
				}
				result = true;
			}
			catch
			{
				destination.Length = length;
				result = false;
			}
			return result;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0000B784 File Offset: 0x00009984
		private void SerializeDictionaryObject(global::System.Collections.IDictionary value, global::System.Text.StringBuilder destination, global::NLog.Targets.JsonSerializeOptions options, global::NLog.Internal.SingleItemOptimizedHashSet<object> objectsInPath, int depth)
		{
			bool flag = true;
			int num = (objectsInPath.Count <= 1) ? depth : (depth + 1);
			if (num > options.MaxRecursionLimit)
			{
				destination.Append("{}");
				return;
			}
			destination.Append('{');
			foreach (object obj in value)
			{
				global::System.Collections.DictionaryEntry dictionaryEntry = (global::System.Collections.DictionaryEntry)obj;
				int length = destination.Length;
				if (length > 524288)
				{
					break;
				}
				if (!flag)
				{
					destination.Append(',');
				}
				if (!this.SerializeObject(dictionaryEntry.Key, destination, options, objectsInPath, num))
				{
					destination.Length = length;
				}
				else
				{
					if (options.SanitizeDictionaryKeys)
					{
						int num2 = options.QuoteKeys ? 1 : 0;
						int num3 = destination.Length - num2;
						int num4 = length + (flag ? 0 : 1) + num2;
						if (!global::NLog.Targets.DefaultJsonSerializer.SanitizeDictionaryKey(destination, num4, num3 - num4))
						{
							destination.Length = length;
							continue;
						}
					}
					destination.Append(':');
					if (!this.SerializeObject(dictionaryEntry.Value, destination, options, objectsInPath, num))
					{
						destination.Length = length;
					}
					else
					{
						flag = false;
					}
				}
			}
			destination.Append('}');
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0000B8C4 File Offset: 0x00009AC4
		private static bool SanitizeDictionaryKey(global::System.Text.StringBuilder destination, int keyStartIndex, int keyLength)
		{
			if (keyLength == 0)
			{
				return false;
			}
			int num = keyStartIndex + keyLength;
			for (int i = keyStartIndex; i < num; i++)
			{
				char c = destination[i];
				if (c != '_' && !char.IsLetterOrDigit(c))
				{
					destination[i] = '_';
				}
			}
			return true;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0000B908 File Offset: 0x00009B08
		private void SerializeCollectionObject(global::System.Collections.IEnumerable value, global::System.Text.StringBuilder destination, global::NLog.Targets.JsonSerializeOptions options, global::NLog.Internal.SingleItemOptimizedHashSet<object> objectsInPath, int depth)
		{
			bool flag = true;
			int num = (objectsInPath.Count <= 1) ? depth : (depth + 1);
			if (num > options.MaxRecursionLimit)
			{
				destination.Append("[]");
				return;
			}
			destination.Append('[');
			foreach (object value2 in value)
			{
				int length = destination.Length;
				if (length > 524288)
				{
					break;
				}
				if (!flag)
				{
					destination.Append(',');
				}
				if (!this.SerializeObject(value2, destination, options, objectsInPath, num))
				{
					destination.Length = length;
				}
				else
				{
					flag = false;
				}
			}
			destination.Append(']');
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0000B9C8 File Offset: 0x00009BC8
		private bool SerializeTypeCodeValue(object value, global::System.Text.StringBuilder destination, global::NLog.Targets.JsonSerializeOptions options, global::NLog.Internal.SingleItemOptimizedHashSet<object> objectsInPath, int depth)
		{
			global::System.TypeCode typeCode = global::System.Convert.GetTypeCode(value);
			if (typeCode == global::System.TypeCode.Object)
			{
				if (value is global::System.Guid || value is global::System.TimeSpan || value is global::System.Reflection.MemberInfo || value is global::System.Reflection.Assembly)
				{
					global::NLog.Targets.DefaultJsonSerializer.QuoteValue(destination, global::System.Convert.ToString(value, global::System.Globalization.CultureInfo.InvariantCulture));
					return true;
				}
				if (value is global::System.DateTimeOffset)
				{
					global::NLog.Targets.DefaultJsonSerializer.QuoteValue(destination, string.Format("{0:yyyy-MM-dd HH:mm:ss zzz}", value));
					return true;
				}
				int length = destination.Length;
				if (length > 524288)
				{
					return false;
				}
				if (depth < options.MaxRecursionLimit)
				{
					try
					{
						if (value is global::System.Exception && options == global::NLog.Targets.DefaultJsonSerializer.instance._serializeOptions)
						{
							options = global::NLog.Targets.DefaultJsonSerializer.instance._exceptionSerializeOptions;
						}
						using (new global::NLog.Internal.SingleItemOptimizedHashSet<object>.SingleItemScopedInsert(value, ref objectsInPath, false))
						{
							return this.SerializeProperties(value, destination, options, objectsInPath, depth);
						}
					}
					catch
					{
						destination.Length = length;
						return false;
					}
				}
				try
				{
					string text = global::System.Convert.ToString(value, global::System.Globalization.CultureInfo.InvariantCulture);
					destination.Append('"');
					global::NLog.Targets.DefaultJsonSerializer.AppendStringEscape(destination, text, options.EscapeUnicode);
					destination.Append('"');
					return true;
				}
				catch
				{
					return false;
				}
			}
			if (global::NLog.Targets.DefaultJsonSerializer.IsNumericTypeCode(typeCode, false))
			{
				this.SerializeNumber(value, destination, options, typeCode);
			}
			else
			{
				string text2 = global::NLog.Internal.XmlHelper.XmlConvertToString(value, typeCode);
				if (text2 == null)
				{
					return false;
				}
				if (global::NLog.Targets.DefaultJsonSerializer.SkipQuotes(typeCode))
				{
					destination.Append(text2);
				}
				else if (typeCode == global::System.TypeCode.Char)
				{
					destination.Append('"');
					global::NLog.Targets.DefaultJsonSerializer.AppendStringEscape(destination, text2, options.EscapeUnicode);
					destination.Append('"');
				}
				else
				{
					global::NLog.Targets.DefaultJsonSerializer.QuoteValue(destination, text2);
				}
			}
			return true;
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0000BB74 File Offset: 0x00009D74
		private void SerializeNumber(object value, global::System.Text.StringBuilder destination, global::NLog.Targets.JsonSerializeOptions options, global::System.TypeCode objTypeCode)
		{
			global::System.Enum value2;
			if (!options.EnumAsInteger && (value2 = (value as global::System.Enum)) != null)
			{
				global::NLog.Targets.DefaultJsonSerializer.QuoteValue(destination, this.EnumAsString(value2));
				return;
			}
			destination.AppendIntegerAsString(value, objTypeCode);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0000BBAC File Offset: 0x00009DAC
		private static global::System.Globalization.CultureInfo CreateFormatProvider()
		{
			global::System.Globalization.CultureInfo cultureInfo = new global::System.Globalization.CultureInfo("en-US", false);
			global::System.Globalization.NumberFormatInfo numberFormat = cultureInfo.NumberFormat;
			numberFormat.NumberGroupSeparator = string.Empty;
			numberFormat.NumberDecimalSeparator = ".";
			numberFormat.NumberGroupSizes = new int[1];
			return cultureInfo;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0000BBED File Offset: 0x00009DED
		private static string QuoteValue(string value)
		{
			return "\"" + value + "\"";
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0000BBFF File Offset: 0x00009DFF
		private static void QuoteValue(global::System.Text.StringBuilder destination, string value)
		{
			destination.Append('"');
			destination.Append(value);
			destination.Append('"');
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0000BC1C File Offset: 0x00009E1C
		private string EnumAsString(global::System.Enum value)
		{
			string text;
			if (!this._enumCache.TryGetValue(value, out text))
			{
				text = global::System.Convert.ToString(value, global::System.Globalization.CultureInfo.InvariantCulture);
				this._enumCache.TryAddValue(value, text);
			}
			return text;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0000BC54 File Offset: 0x00009E54
		private static bool SkipQuotes(global::System.TypeCode objTypeCode)
		{
			return objTypeCode != global::System.TypeCode.String && (objTypeCode == global::System.TypeCode.Empty || objTypeCode == global::System.TypeCode.Boolean || global::NLog.Targets.DefaultJsonSerializer.IsNumericTypeCode(objTypeCode, true));
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0000BC6D File Offset: 0x00009E6D
		private static bool IsNumericTypeCode(global::System.TypeCode objTypeCode, bool includeDecimals)
		{
			return objTypeCode - global::System.TypeCode.SByte <= 7 || (objTypeCode - global::System.TypeCode.Single <= 2 && includeDecimals);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0000BC84 File Offset: 0x00009E84
		internal static void AppendStringEscape(global::System.Text.StringBuilder destination, string text, bool escapeUnicode)
		{
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			global::System.Text.StringBuilder stringBuilder = null;
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if (!global::NLog.Targets.DefaultJsonSerializer.RequiresJsonEscape(c, escapeUnicode))
				{
					if (stringBuilder != null)
					{
						stringBuilder.Append(c);
					}
				}
				else
				{
					if (stringBuilder == null)
					{
						stringBuilder = destination;
						stringBuilder.Append(text, 0, i);
					}
					if (c <= '"')
					{
						switch (c)
						{
						case '\b':
							stringBuilder.Append("\\b");
							goto IL_129;
						case '\t':
							stringBuilder.Append("\\t");
							goto IL_129;
						case '\n':
							stringBuilder.Append("\\n");
							goto IL_129;
						case '\v':
							break;
						case '\f':
							stringBuilder.Append("\\f");
							goto IL_129;
						case '\r':
							stringBuilder.Append("\\r");
							goto IL_129;
						default:
							if (c == '"')
							{
								stringBuilder.Append("\\\"");
								goto IL_129;
							}
							break;
						}
					}
					else
					{
						if (c == '/')
						{
							stringBuilder.Append("\\/");
							goto IL_129;
						}
						if (c == '\\')
						{
							stringBuilder.Append("\\\\");
							goto IL_129;
						}
					}
					if (global::NLog.Targets.DefaultJsonSerializer.EscapeChar(c, escapeUnicode))
					{
						stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "\\u{0:x4}", new object[]
						{
							(int)c
						});
					}
					else
					{
						stringBuilder.Append(c);
					}
				}
				IL_129:;
			}
			if (stringBuilder == null)
			{
				destination.Append(text);
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x0000BDD5 File Offset: 0x00009FD5
		internal static bool RequiresJsonEscape(char ch, bool escapeUnicode)
		{
			return global::NLog.Targets.DefaultJsonSerializer.EscapeChar(ch, escapeUnicode) || (ch == '"' || ch == '/' || ch == '\\');
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0000BDF4 File Offset: 0x00009FF4
		private static bool EscapeChar(char ch, bool escapeUnicode)
		{
			return ch < ' ' || (escapeUnicode && ch > '\u007f');
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0000BE08 File Offset: 0x0000A008
		private bool SerializeProperties(object value, global::System.Text.StringBuilder destination, global::NLog.Targets.JsonSerializeOptions options, global::NLog.Internal.SingleItemOptimizedHashSet<object> objectsInPath, int depth)
		{
			global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo[], global::NLog.Internal.ReflectionHelpers.LateBoundMethod[]> props = this.GetProps(value);
			if (props.Key.Length == 0)
			{
				try
				{
					string text = global::System.Convert.ToString(value, global::System.Globalization.CultureInfo.InvariantCulture);
					destination.Append('"');
					global::NLog.Targets.DefaultJsonSerializer.AppendStringEscape(destination, text, options.EscapeUnicode);
					destination.Append('"');
					return true;
				}
				catch
				{
					return false;
				}
			}
			destination.Append('{');
			bool flag = true;
			bool flag2 = props.Key.Length == props.Value.Length;
			for (int i = 0; i < props.Key.Length; i++)
			{
				int length = destination.Length;
				try
				{
					global::System.Reflection.PropertyInfo propertyInfo = props.Key[i];
					object obj = flag2 ? props.Value[i](value, null) : propertyInfo.GetValue(value, null);
					if (obj != null)
					{
						if (!flag)
						{
							destination.Append(", ");
						}
						if (options.QuoteKeys)
						{
							global::NLog.Targets.DefaultJsonSerializer.QuoteValue(destination, propertyInfo.Name);
						}
						else
						{
							destination.Append(propertyInfo.Name);
						}
						destination.Append(':');
						if (!this.SerializeObject(obj, destination, options, objectsInPath, depth + 1))
						{
							destination.Length = length;
						}
						else
						{
							flag = false;
						}
					}
				}
				catch
				{
					destination.Length = length;
				}
			}
			destination.Append('}');
			return true;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0000BF6C File Offset: 0x0000A16C
		private global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo[], global::NLog.Internal.ReflectionHelpers.LateBoundMethod[]> GetProps(object value)
		{
			global::System.Type type = value.GetType();
			global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo[], global::NLog.Internal.ReflectionHelpers.LateBoundMethod[]> keyValuePair;
			if (this._propsCache.TryGetValue(type, out keyValuePair))
			{
				if (keyValuePair.Key.Length != 0 && keyValuePair.Value.Length == 0)
				{
					global::NLog.Internal.ReflectionHelpers.LateBoundMethod[] array = new global::NLog.Internal.ReflectionHelpers.LateBoundMethod[keyValuePair.Key.Length];
					for (int i = 0; i < keyValuePair.Key.Length; i++)
					{
						array[i] = global::NLog.Internal.ReflectionHelpers.CreateLateBoundMethod(keyValuePair.Key[i].GetGetMethod());
					}
					keyValuePair = new global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo[], global::NLog.Internal.ReflectionHelpers.LateBoundMethod[]>(keyValuePair.Key, array);
					this._propsCache.TryAddValue(type, keyValuePair);
				}
				return keyValuePair;
			}
			global::System.Reflection.PropertyInfo[] array2 = null;
			try
			{
				array2 = type.GetProperties(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Failed to get JSON properties for type: {0}", new object[]
				{
					type
				});
			}
			finally
			{
				if (array2 == null)
				{
					array2 = global::NLog.Internal.ArrayHelper.Empty<global::System.Reflection.PropertyInfo>();
				}
			}
			foreach (global::System.Reflection.PropertyInfo propertyInfo in array2)
			{
				if (!propertyInfo.CanRead || propertyInfo.GetIndexParameters().Length != 0 || propertyInfo.GetGetMethod() == null)
				{
					array2 = (from p in array2
					where p.CanRead && p.GetIndexParameters().Length == 0 && p.GetGetMethod() != null
					select p).ToArray<global::System.Reflection.PropertyInfo>();
					break;
				}
			}
			keyValuePair = new global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo[], global::NLog.Internal.ReflectionHelpers.LateBoundMethod[]>(array2, global::NLog.Internal.ArrayHelper.Empty<global::NLog.Internal.ReflectionHelpers.LateBoundMethod>());
			this._propsCache.TryAddValue(type, keyValuePair);
			return keyValuePair;
		}

		// Token: 0x040000AB RID: 171
		private readonly global::NLog.Internal.MruCache<global::System.Type, global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo[], global::NLog.Internal.ReflectionHelpers.LateBoundMethod[]>> _propsCache = new global::NLog.Internal.MruCache<global::System.Type, global::System.Collections.Generic.KeyValuePair<global::System.Reflection.PropertyInfo[], global::NLog.Internal.ReflectionHelpers.LateBoundMethod[]>>(10000);

		// Token: 0x040000AC RID: 172
		private readonly global::NLog.Internal.MruCache<global::System.Enum, string> _enumCache = new global::NLog.Internal.MruCache<global::System.Enum, string>(1500);

		// Token: 0x040000AD RID: 173
		private readonly global::NLog.Targets.JsonSerializeOptions _serializeOptions = new global::NLog.Targets.JsonSerializeOptions();

		// Token: 0x040000AE RID: 174
		private readonly global::NLog.Targets.JsonSerializeOptions _exceptionSerializeOptions = new global::NLog.Targets.JsonSerializeOptions
		{
			SanitizeDictionaryKeys = true
		};

		// Token: 0x040000AF RID: 175
		private readonly global::System.IFormatProvider _defaultFormatProvider = global::NLog.Targets.DefaultJsonSerializer.CreateFormatProvider();

		// Token: 0x040000B0 RID: 176
		private const int MaxJsonLength = 524288;

		// Token: 0x040000B1 RID: 177
		private static readonly global::NLog.Targets.DefaultJsonSerializer instance = new global::NLog.Targets.DefaultJsonSerializer();

		// Token: 0x040000B2 RID: 178
		private const global::System.Reflection.BindingFlags PublicProperties = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public;
	}
}
