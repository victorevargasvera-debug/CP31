using System;
using System.Globalization;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000DF RID: 223
	[global::System.Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
	public class BsonObjectIdConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C2A RID: 3114 RVA: 0x00030C84 File Offset: 0x0002EE84
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			global::Newtonsoft.Json.Bson.BsonObjectId bsonObjectId = (global::Newtonsoft.Json.Bson.BsonObjectId)value;
			global::Newtonsoft.Json.Bson.BsonWriter bsonWriter = writer as global::Newtonsoft.Json.Bson.BsonWriter;
			if (bsonWriter != null)
			{
				bsonWriter.WriteObjectId(bsonObjectId.Value);
				return;
			}
			writer.WriteValue(bsonObjectId.Value);
		}

		// Token: 0x06000C2B RID: 3115 RVA: 0x00030CBB File Offset: 0x0002EEBB
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.Bytes)
			{
				throw new global::Newtonsoft.Json.JsonSerializationException("Expected Bytes but got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
			}
			return new global::Newtonsoft.Json.Bson.BsonObjectId((byte[])reader.Value);
		}

		// Token: 0x06000C2C RID: 3116 RVA: 0x00030CF7 File Offset: 0x0002EEF7
		public override bool CanConvert(global::System.Type objectType)
		{
			return objectType == typeof(global::Newtonsoft.Json.Bson.BsonObjectId);
		}
	}
}
