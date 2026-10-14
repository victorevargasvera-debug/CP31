using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000EC RID: 236
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class UnixDateTimeConverter : global::Newtonsoft.Json.Converters.DateTimeConverterBase
	{
		// Token: 0x06000C80 RID: 3200 RVA: 0x00032910 File Offset: 0x00030B10
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			long num;
			if (value is global::System.DateTime)
			{
				num = (long)(((global::System.DateTime)value).ToUniversalTime() - global::Newtonsoft.Json.Converters.UnixDateTimeConverter.UnixEpoch).TotalSeconds;
			}
			else
			{
				if (!(value is global::System.DateTimeOffset))
				{
					throw new global::Newtonsoft.Json.JsonSerializationException("Expected date object value.");
				}
				num = (long)(((global::System.DateTimeOffset)value).ToUniversalTime() - global::Newtonsoft.Json.Converters.UnixDateTimeConverter.UnixEpoch).TotalSeconds;
			}
			if (num < 0L)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Cannot convert date value that is before Unix epoch of 00:00:00 UTC on 1 January 1970.");
			}
			writer.WriteValue(num);
		}

		// Token: 0x06000C81 RID: 3201 RVA: 0x0003299C File Offset: 0x00030B9C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			bool flag = global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(objectType);
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
			{
				if (!flag)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot convert null value to {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
				}
				return null;
			}
			else
			{
				long num;
				if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Integer)
				{
					num = (long)reader.Value;
				}
				else
				{
					if (reader.TokenType != global::Newtonsoft.Json.JsonToken.String)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token parsing date. Expected Integer or String, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
					}
					if (!long.TryParse((string)reader.Value, out num))
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot convert invalid value to {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
					}
				}
				if (num < 0L)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot convert value that is before Unix epoch of 00:00:00 UTC on 1 January 1970 to {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
				}
				global::System.DateTime dateTime = global::Newtonsoft.Json.Converters.UnixDateTimeConverter.UnixEpoch.AddSeconds((double)num);
				if ((flag ? global::System.Nullable.GetUnderlyingType(objectType) : objectType) == typeof(global::System.DateTimeOffset))
				{
					return new global::System.DateTimeOffset(dateTime, global::System.TimeSpan.Zero);
				}
				return dateTime;
			}
		}

		// Token: 0x040003E7 RID: 999
		internal static readonly global::System.DateTime UnixEpoch = new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc);
	}
}
