using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000019 RID: 25
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public static class JsonConvert
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000024B0 File Offset: 0x000006B0
		// (set) Token: 0x0600003A RID: 58 RVA: 0x000024B7 File Offset: 0x000006B7
		[global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})]
		public static global::System.Func<global::Newtonsoft.Json.JsonSerializerSettings> DefaultSettings { [return: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] get; [param: global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x0600003B RID: 59 RVA: 0x000024BF File Offset: 0x000006BF
		public static string ToString(global::System.DateTime value)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(value, global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat, global::Newtonsoft.Json.DateTimeZoneHandling.RoundtripKind);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000024CC File Offset: 0x000006CC
		public static string ToString(global::System.DateTime value, global::Newtonsoft.Json.DateFormatHandling format, global::Newtonsoft.Json.DateTimeZoneHandling timeZoneHandling)
		{
			global::System.DateTime value2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(value, timeZoneHandling);
			string result;
			using (global::System.IO.StringWriter stringWriter = global::Newtonsoft.Json.Utilities.StringUtils.CreateStringWriter(64))
			{
				stringWriter.Write('"');
				global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeString(stringWriter, value2, format, null, global::System.Globalization.CultureInfo.InvariantCulture);
				stringWriter.Write('"');
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000252C File Offset: 0x0000072C
		public static string ToString(global::System.DateTimeOffset value)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(value, global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002538 File Offset: 0x00000738
		public static string ToString(global::System.DateTimeOffset value, global::Newtonsoft.Json.DateFormatHandling format)
		{
			string result;
			using (global::System.IO.StringWriter stringWriter = global::Newtonsoft.Json.Utilities.StringUtils.CreateStringWriter(64))
			{
				stringWriter.Write('"');
				global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeOffsetString(stringWriter, value, format, null, global::System.Globalization.CultureInfo.InvariantCulture);
				stringWriter.Write('"');
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002590 File Offset: 0x00000790
		public static string ToString(bool value)
		{
			if (!value)
			{
				return global::Newtonsoft.Json.JsonConvert.False;
			}
			return global::Newtonsoft.Json.JsonConvert.True;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000025A0 File Offset: 0x000007A0
		public static string ToString(char value)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(char.ToString(value));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000025AD File Offset: 0x000007AD
		public static string ToString(global::System.Enum value)
		{
			return value.ToString("D");
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000025BA File Offset: 0x000007BA
		public static string ToString(int value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000025C9 File Offset: 0x000007C9
		public static string ToString(short value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000025D8 File Offset: 0x000007D8
		[global::System.CLSCompliant(false)]
		public static string ToString(ushort value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000025E7 File Offset: 0x000007E7
		[global::System.CLSCompliant(false)]
		public static string ToString(uint value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000025F6 File Offset: 0x000007F6
		public static string ToString(long value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002605 File Offset: 0x00000805
		private static string ToStringInternal(global::System.Numerics.BigInteger value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002614 File Offset: 0x00000814
		[global::System.CLSCompliant(false)]
		public static string ToString(ulong value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002623 File Offset: 0x00000823
		public static string ToString(float value)
		{
			return global::Newtonsoft.Json.JsonConvert.EnsureDecimalPlace((double)value, value.ToString("R", global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000263D File Offset: 0x0000083D
		internal static string ToString(float value, global::Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return global::Newtonsoft.Json.JsonConvert.EnsureFloatFormat((double)value, global::Newtonsoft.Json.JsonConvert.EnsureDecimalPlace((double)value, value.ToString("R", global::System.Globalization.CultureInfo.InvariantCulture)), floatFormatHandling, quoteChar, nullable);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002661 File Offset: 0x00000861
		private static string EnsureFloatFormat(double value, string text, global::Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			if (floatFormatHandling == global::Newtonsoft.Json.FloatFormatHandling.Symbol || (!double.IsInfinity(value) && !double.IsNaN(value)))
			{
				return text;
			}
			if (floatFormatHandling != global::Newtonsoft.Json.FloatFormatHandling.DefaultValue)
			{
				return quoteChar.ToString() + text + quoteChar.ToString();
			}
			if (nullable)
			{
				return global::Newtonsoft.Json.JsonConvert.Null;
			}
			return "0.0";
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000026A1 File Offset: 0x000008A1
		public static string ToString(double value)
		{
			return global::Newtonsoft.Json.JsonConvert.EnsureDecimalPlace(value, value.ToString("R", global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000026BA File Offset: 0x000008BA
		internal static string ToString(double value, global::Newtonsoft.Json.FloatFormatHandling floatFormatHandling, char quoteChar, bool nullable)
		{
			return global::Newtonsoft.Json.JsonConvert.EnsureFloatFormat(value, global::Newtonsoft.Json.JsonConvert.EnsureDecimalPlace(value, value.ToString("R", global::System.Globalization.CultureInfo.InvariantCulture)), floatFormatHandling, quoteChar, nullable);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000026DC File Offset: 0x000008DC
		private static string EnsureDecimalPlace(double value, string text)
		{
			if (double.IsNaN(value) || double.IsInfinity(value) || text.IndexOf('.') != -1 || text.IndexOf('E') != -1 || text.IndexOf('e') != -1)
			{
				return text;
			}
			return text + ".0";
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000271C File Offset: 0x0000091C
		private static string EnsureDecimalPlace(string text)
		{
			if (text.IndexOf('.') != -1)
			{
				return text;
			}
			return text + ".0";
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002736 File Offset: 0x00000936
		public static string ToString(byte value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002745 File Offset: 0x00000945
		[global::System.CLSCompliant(false)]
		public static string ToString(sbyte value)
		{
			return value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002754 File Offset: 0x00000954
		public static string ToString(decimal value)
		{
			return global::Newtonsoft.Json.JsonConvert.EnsureDecimalPlace(value.ToString(null, global::System.Globalization.CultureInfo.InvariantCulture));
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002768 File Offset: 0x00000968
		public static string ToString(global::System.Guid value)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(value, '"');
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002774 File Offset: 0x00000974
		internal static string ToString(global::System.Guid value, char quoteChar)
		{
			string str = value.ToString("D", global::System.Globalization.CultureInfo.InvariantCulture);
			string text = quoteChar.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
			return text + str + text;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000027A8 File Offset: 0x000009A8
		public static string ToString(global::System.TimeSpan value)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(value, '"');
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000027B2 File Offset: 0x000009B2
		internal static string ToString(global::System.TimeSpan value, char quoteChar)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(value.ToString(), quoteChar);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000027C7 File Offset: 0x000009C7
		public static string ToString([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Uri value)
		{
			if (value == null)
			{
				return global::Newtonsoft.Json.JsonConvert.Null;
			}
			return global::Newtonsoft.Json.JsonConvert.ToString(value, '"');
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000027E0 File Offset: 0x000009E0
		internal static string ToString(global::System.Uri value, char quoteChar)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(value.OriginalString, quoteChar);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000027EE File Offset: 0x000009EE
		public static string ToString([global::System.Runtime.CompilerServices.Nullable(2)] string value)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(value, '"');
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000027F8 File Offset: 0x000009F8
		public static string ToString([global::System.Runtime.CompilerServices.Nullable(2)] string value, char delimiter)
		{
			return global::Newtonsoft.Json.JsonConvert.ToString(value, delimiter, global::Newtonsoft.Json.StringEscapeHandling.Default);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002802 File Offset: 0x00000A02
		public static string ToString([global::System.Runtime.CompilerServices.Nullable(2)] string value, char delimiter, global::Newtonsoft.Json.StringEscapeHandling stringEscapeHandling)
		{
			if (delimiter != '"' && delimiter != '\'')
			{
				throw new global::System.ArgumentException("Delimiter must be a single or double quote.", "delimiter");
			}
			return global::Newtonsoft.Json.Utilities.JavaScriptUtils.ToEscapedJavaScriptString(value, delimiter, true, stringEscapeHandling);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002828 File Offset: 0x00000A28
		public static string ToString([global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			if (value == null)
			{
				return global::Newtonsoft.Json.JsonConvert.Null;
			}
			switch (global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(value.GetType()))
			{
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char:
				return global::Newtonsoft.Json.JsonConvert.ToString((char)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean:
				return global::Newtonsoft.Json.JsonConvert.ToString((bool)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte:
				return global::Newtonsoft.Json.JsonConvert.ToString((sbyte)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16:
				return global::Newtonsoft.Json.JsonConvert.ToString((short)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16:
				return global::Newtonsoft.Json.JsonConvert.ToString((ushort)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32:
				return global::Newtonsoft.Json.JsonConvert.ToString((int)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte:
				return global::Newtonsoft.Json.JsonConvert.ToString((byte)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32:
				return global::Newtonsoft.Json.JsonConvert.ToString((uint)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64:
				return global::Newtonsoft.Json.JsonConvert.ToString((long)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64:
				return global::Newtonsoft.Json.JsonConvert.ToString((ulong)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single:
				return global::Newtonsoft.Json.JsonConvert.ToString((float)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double:
				return global::Newtonsoft.Json.JsonConvert.ToString((double)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime:
				return global::Newtonsoft.Json.JsonConvert.ToString((global::System.DateTime)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset:
				return global::Newtonsoft.Json.JsonConvert.ToString((global::System.DateTimeOffset)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Decimal:
				return global::Newtonsoft.Json.JsonConvert.ToString((decimal)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Guid:
				return global::Newtonsoft.Json.JsonConvert.ToString((global::System.Guid)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpan:
				return global::Newtonsoft.Json.JsonConvert.ToString((global::System.TimeSpan)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigInteger:
				return global::Newtonsoft.Json.JsonConvert.ToStringInternal((global::System.Numerics.BigInteger)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Uri:
				return global::Newtonsoft.Json.JsonConvert.ToString((global::System.Uri)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.String:
				return global::Newtonsoft.Json.JsonConvert.ToString((string)value);
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DBNull:
				return global::Newtonsoft.Json.JsonConvert.Null;
			}
			throw new global::System.ArgumentException("Unsupported type: {0}. Use the JsonSerializer class to get the object's JSON representation.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002A07 File Offset: 0x00000C07
		[global::System.Diagnostics.DebuggerStepThrough]
		public static string SerializeObject([global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(value, null, null);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002A11 File Offset: 0x00000C11
		[global::System.Diagnostics.DebuggerStepThrough]
		public static string SerializeObject([global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.Formatting formatting)
		{
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(value, formatting, null);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002A1C File Offset: 0x00000C1C
		[global::System.Diagnostics.DebuggerStepThrough]
		public static string SerializeObject([global::System.Runtime.CompilerServices.Nullable(2)] object value, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			object obj;
			if (converters == null || converters.Length == 0)
			{
				obj = null;
			}
			else
			{
				(obj = new global::Newtonsoft.Json.JsonSerializerSettings()).Converters = converters;
			}
			global::Newtonsoft.Json.JsonSerializerSettings settings = obj;
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(value, null, settings);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002A48 File Offset: 0x00000C48
		[global::System.Diagnostics.DebuggerStepThrough]
		public static string SerializeObject([global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.Formatting formatting, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			object obj;
			if (converters == null || converters.Length == 0)
			{
				obj = null;
			}
			else
			{
				(obj = new global::Newtonsoft.Json.JsonSerializerSettings()).Converters = converters;
			}
			global::Newtonsoft.Json.JsonSerializerSettings settings = obj;
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(value, null, formatting, settings);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002A75 File Offset: 0x00000C75
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		public static string SerializeObject(object value, global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(value, null, settings);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002A80 File Offset: 0x00000C80
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		public static string SerializeObject(object value, global::System.Type type, global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			global::Newtonsoft.Json.JsonSerializer jsonSerializer = global::Newtonsoft.Json.JsonSerializer.CreateDefault(settings);
			return global::Newtonsoft.Json.JsonConvert.SerializeObjectInternal(value, type, jsonSerializer);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002A9C File Offset: 0x00000C9C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		public static string SerializeObject(object value, global::Newtonsoft.Json.Formatting formatting, global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(value, null, formatting, settings);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(1)]
		public static string SerializeObject(object value, global::System.Type type, global::Newtonsoft.Json.Formatting formatting, global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			global::Newtonsoft.Json.JsonSerializer jsonSerializer = global::Newtonsoft.Json.JsonSerializer.CreateDefault(settings);
			jsonSerializer.Formatting = formatting;
			return global::Newtonsoft.Json.JsonConvert.SerializeObjectInternal(value, type, jsonSerializer);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002ACC File Offset: 0x00000CCC
		private static string SerializeObjectInternal([global::System.Runtime.CompilerServices.Nullable(2)] object value, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Type type, global::Newtonsoft.Json.JsonSerializer jsonSerializer)
		{
			global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(new global::System.Text.StringBuilder(256), global::System.Globalization.CultureInfo.InvariantCulture);
			using (global::Newtonsoft.Json.JsonTextWriter jsonTextWriter = new global::Newtonsoft.Json.JsonTextWriter(stringWriter))
			{
				jsonTextWriter.Formatting = jsonSerializer.Formatting;
				jsonSerializer.Serialize(jsonTextWriter, value, type);
			}
			return stringWriter.ToString();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002B2C File Offset: 0x00000D2C
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static object DeserializeObject(string value)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeObject(value, null, null);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002B36 File Offset: 0x00000D36
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static object DeserializeObject(string value, global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeObject(value, null, settings);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002B40 File Offset: 0x00000D40
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static object DeserializeObject(string value, global::System.Type type)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeObject(value, type, null);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002B4A File Offset: 0x00000D4A
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Diagnostics.DebuggerStepThrough]
		public static T DeserializeObject<T>([global::System.Runtime.CompilerServices.Nullable(1)] string value)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value, null);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002B53 File Offset: 0x00000D53
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static T DeserializeAnonymousType<[global::System.Runtime.CompilerServices.Nullable(2)] T>(string value, T anonymousTypeObject)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002B5B File Offset: 0x00000D5B
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static T DeserializeAnonymousType<[global::System.Runtime.CompilerServices.Nullable(2)] T>(string value, T anonymousTypeObject, global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeObject<T>(value, settings);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002B64 File Offset: 0x00000D64
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static T DeserializeObject<[global::System.Runtime.CompilerServices.Nullable(2)] T>(string value, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			return (T)((object)global::Newtonsoft.Json.JsonConvert.DeserializeObject(value, typeof(T), converters));
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002B7C File Offset: 0x00000D7C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Diagnostics.DebuggerStepThrough]
		public static T DeserializeObject<T>([global::System.Runtime.CompilerServices.Nullable(1)] string value, global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			return (T)((object)global::Newtonsoft.Json.JsonConvert.DeserializeObject(value, typeof(T), settings));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002B94 File Offset: 0x00000D94
		[global::System.Diagnostics.DebuggerStepThrough]
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static object DeserializeObject(string value, global::System.Type type, params global::Newtonsoft.Json.JsonConverter[] converters)
		{
			object obj;
			if (converters == null || converters.Length == 0)
			{
				obj = null;
			}
			else
			{
				(obj = new global::Newtonsoft.Json.JsonSerializerSettings()).Converters = converters;
			}
			global::Newtonsoft.Json.JsonSerializerSettings settings = obj;
			return global::Newtonsoft.Json.JsonConvert.DeserializeObject(value, type, settings);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002BC0 File Offset: 0x00000DC0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static object DeserializeObject([global::System.Runtime.CompilerServices.Nullable(1)] string value, global::System.Type type, global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(value, "value");
			global::Newtonsoft.Json.JsonSerializer jsonSerializer = global::Newtonsoft.Json.JsonSerializer.CreateDefault(settings);
			if (!jsonSerializer.IsCheckAdditionalContentSet())
			{
				jsonSerializer.CheckAdditionalContent = true;
			}
			object result;
			using (global::Newtonsoft.Json.JsonTextReader jsonTextReader = new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StringReader(value)))
			{
				result = jsonSerializer.Deserialize(jsonTextReader, type);
			}
			return result;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00002C20 File Offset: 0x00000E20
		[global::System.Diagnostics.DebuggerStepThrough]
		public static void PopulateObject(string value, object target)
		{
			global::Newtonsoft.Json.JsonConvert.PopulateObject(value, target, null);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002C2C File Offset: 0x00000E2C
		public static void PopulateObject(string value, object target, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.JsonSerializerSettings settings)
		{
			global::Newtonsoft.Json.JsonSerializer jsonSerializer = global::Newtonsoft.Json.JsonSerializer.CreateDefault(settings);
			using (global::Newtonsoft.Json.JsonReader jsonReader = new global::Newtonsoft.Json.JsonTextReader(new global::System.IO.StringReader(value)))
			{
				jsonSerializer.Populate(jsonReader, target);
				if (settings != null && settings.CheckAdditionalContent)
				{
					while (jsonReader.Read())
					{
						if (jsonReader.TokenType != global::Newtonsoft.Json.JsonToken.Comment)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(jsonReader, "Additional text found in JSON string after finishing deserializing object.");
						}
					}
				}
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00002C9C File Offset: 0x00000E9C
		public static string SerializeXmlNode([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Xml.XmlNode node)
		{
			return global::Newtonsoft.Json.JsonConvert.SerializeXmlNode(node, global::Newtonsoft.Json.Formatting.None);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public static string SerializeXmlNode([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Xml.XmlNode node, global::Newtonsoft.Json.Formatting formatting)
		{
			global::Newtonsoft.Json.Converters.XmlNodeConverter xmlNodeConverter = new global::Newtonsoft.Json.Converters.XmlNodeConverter();
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(node, formatting, new global::Newtonsoft.Json.JsonConverter[]
			{
				xmlNodeConverter
			});
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002CCC File Offset: 0x00000ECC
		public static string SerializeXmlNode([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Xml.XmlNode node, global::Newtonsoft.Json.Formatting formatting, bool omitRootObject)
		{
			global::Newtonsoft.Json.Converters.XmlNodeConverter xmlNodeConverter = new global::Newtonsoft.Json.Converters.XmlNodeConverter
			{
				OmitRootObject = omitRootObject
			};
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(node, formatting, new global::Newtonsoft.Json.JsonConverter[]
			{
				xmlNodeConverter
			});
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00002CF7 File Offset: 0x00000EF7
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static global::System.Xml.XmlDocument DeserializeXmlNode(string value)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeXmlNode(value, null);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002D00 File Offset: 0x00000F00
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static global::System.Xml.XmlDocument DeserializeXmlNode([global::System.Runtime.CompilerServices.Nullable(1)] string value, string deserializeRootElementName)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeXmlNode(value, deserializeRootElementName, false);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00002D0A File Offset: 0x00000F0A
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static global::System.Xml.XmlDocument DeserializeXmlNode([global::System.Runtime.CompilerServices.Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeXmlNode(value, deserializeRootElementName, writeArrayAttribute, false);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00002D18 File Offset: 0x00000F18
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static global::System.Xml.XmlDocument DeserializeXmlNode([global::System.Runtime.CompilerServices.Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
		{
			global::Newtonsoft.Json.Converters.XmlNodeConverter xmlNodeConverter = new global::Newtonsoft.Json.Converters.XmlNodeConverter();
			xmlNodeConverter.DeserializeRootElementName = deserializeRootElementName;
			xmlNodeConverter.WriteArrayAttribute = writeArrayAttribute;
			xmlNodeConverter.EncodeSpecialCharacters = encodeSpecialCharacters;
			return (global::System.Xml.XmlDocument)global::Newtonsoft.Json.JsonConvert.DeserializeObject(value, typeof(global::System.Xml.XmlDocument), new global::Newtonsoft.Json.JsonConverter[]
			{
				xmlNodeConverter
			});
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002D5F File Offset: 0x00000F5F
		public static string SerializeXNode([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Xml.Linq.XObject node)
		{
			return global::Newtonsoft.Json.JsonConvert.SerializeXNode(node, global::Newtonsoft.Json.Formatting.None);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00002D68 File Offset: 0x00000F68
		public static string SerializeXNode([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Xml.Linq.XObject node, global::Newtonsoft.Json.Formatting formatting)
		{
			return global::Newtonsoft.Json.JsonConvert.SerializeXNode(node, formatting, false);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002D74 File Offset: 0x00000F74
		public static string SerializeXNode([global::System.Runtime.CompilerServices.Nullable(2)] global::System.Xml.Linq.XObject node, global::Newtonsoft.Json.Formatting formatting, bool omitRootObject)
		{
			global::Newtonsoft.Json.Converters.XmlNodeConverter xmlNodeConverter = new global::Newtonsoft.Json.Converters.XmlNodeConverter
			{
				OmitRootObject = omitRootObject
			};
			return global::Newtonsoft.Json.JsonConvert.SerializeObject(node, formatting, new global::Newtonsoft.Json.JsonConverter[]
			{
				xmlNodeConverter
			});
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002D9F File Offset: 0x00000F9F
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static global::System.Xml.Linq.XDocument DeserializeXNode(string value)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeXNode(value, null);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002DA8 File Offset: 0x00000FA8
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static global::System.Xml.Linq.XDocument DeserializeXNode([global::System.Runtime.CompilerServices.Nullable(1)] string value, string deserializeRootElementName)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeXNode(value, deserializeRootElementName, false);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002DB2 File Offset: 0x00000FB2
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static global::System.Xml.Linq.XDocument DeserializeXNode([global::System.Runtime.CompilerServices.Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute)
		{
			return global::Newtonsoft.Json.JsonConvert.DeserializeXNode(value, deserializeRootElementName, writeArrayAttribute, false);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static global::System.Xml.Linq.XDocument DeserializeXNode([global::System.Runtime.CompilerServices.Nullable(1)] string value, string deserializeRootElementName, bool writeArrayAttribute, bool encodeSpecialCharacters)
		{
			global::Newtonsoft.Json.Converters.XmlNodeConverter xmlNodeConverter = new global::Newtonsoft.Json.Converters.XmlNodeConverter();
			xmlNodeConverter.DeserializeRootElementName = deserializeRootElementName;
			xmlNodeConverter.WriteArrayAttribute = writeArrayAttribute;
			xmlNodeConverter.EncodeSpecialCharacters = encodeSpecialCharacters;
			return (global::System.Xml.Linq.XDocument)global::Newtonsoft.Json.JsonConvert.DeserializeObject(value, typeof(global::System.Xml.Linq.XDocument), new global::Newtonsoft.Json.JsonConverter[]
			{
				xmlNodeConverter
			});
		}

		// Token: 0x04000035 RID: 53
		public static readonly string True = "true";

		// Token: 0x04000036 RID: 54
		public static readonly string False = "false";

		// Token: 0x04000037 RID: 55
		public static readonly string Null = "null";

		// Token: 0x04000038 RID: 56
		public static readonly string Undefined = "undefined";

		// Token: 0x04000039 RID: 57
		public static readonly string PositiveInfinity = "Infinity";

		// Token: 0x0400003A RID: 58
		public static readonly string NegativeInfinity = "-Infinity";

		// Token: 0x0400003B RID: 59
		public static readonly string NaN = "NaN";
	}
}
