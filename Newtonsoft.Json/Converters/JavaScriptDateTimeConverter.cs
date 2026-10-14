using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E8 RID: 232
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class JavaScriptDateTimeConverter : global::Newtonsoft.Json.Converters.DateTimeConverterBase
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x00031F48 File Offset: 0x00030148
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			long value2;
			if (value is global::System.DateTime)
			{
				value2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertDateTimeToJavaScriptTicks(((global::System.DateTime)value).ToUniversalTime());
			}
			else
			{
				if (!(value is global::System.DateTimeOffset))
				{
					throw new global::Newtonsoft.Json.JsonSerializationException("Expected date object value.");
				}
				value2 = global::Newtonsoft.Json.Utilities.DateTimeUtils.ConvertDateTimeToJavaScriptTicks(((global::System.DateTimeOffset)value).ToUniversalTime().UtcDateTime);
			}
			writer.WriteStartConstructor("Date");
			writer.WriteValue(value2);
			writer.WriteEndConstructor();
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00031FBC File Offset: 0x000301BC
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.Null)
			{
				if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartConstructor)
				{
					object value = reader.Value;
					if (string.Equals((value != null) ? value.ToString() : null, "Date", global::System.StringComparison.Ordinal))
					{
						global::System.DateTime dateTime;
						string message;
						if (!global::Newtonsoft.Json.Utilities.JavaScriptUtils.TryGetDateFromConstructorJson(reader, out dateTime, out message))
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, message);
						}
						if ((global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType) ? global::System.Nullable.GetUnderlyingType(objectType) : objectType) == typeof(global::System.DateTimeOffset))
						{
							return new global::System.DateTimeOffset(dateTime);
						}
						return dateTime;
					}
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token or value when parsing date. Token: {0}, Value: {1}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType, reader.Value));
			}
			if (!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(objectType))
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot convert null value to {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
			}
			return null;
		}
	}
}
