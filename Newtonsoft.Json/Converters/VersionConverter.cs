using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000ED RID: 237
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class VersionConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C84 RID: 3204 RVA: 0x00032AC2 File Offset: 0x00030CC2
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			if (value is global::System.Version)
			{
				writer.WriteValue(value.ToString());
				return;
			}
			throw new global::Newtonsoft.Json.JsonSerializationException("Expected Version object value");
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00032AF0 File Offset: 0x00030CF0
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
			{
				return null;
			}
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.String)
			{
				try
				{
					return new global::System.Version((string)reader.Value);
				}
				catch (global::System.Exception ex)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Error parsing version string: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.Value), ex);
				}
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token or value when parsing version. Token: {0}, Value: {1}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType, reader.Value));
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x00032B7C File Offset: 0x00030D7C
		public override bool CanConvert(global::System.Type objectType)
		{
			return objectType == typeof(global::System.Version);
		}
	}
}
