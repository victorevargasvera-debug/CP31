using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E6 RID: 230
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class ExpandoObjectConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C4D RID: 3149 RVA: 0x00031B16 File Offset: 0x0002FD16
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
		}

		// Token: 0x06000C4E RID: 3150 RVA: 0x00031B18 File Offset: 0x0002FD18
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			return this.ReadValue(reader);
		}

		// Token: 0x06000C4F RID: 3151 RVA: 0x00031B24 File Offset: 0x0002FD24
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private object ReadValue(global::Newtonsoft.Json.JsonReader reader)
		{
			if (!reader.MoveToContent())
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when reading ExpandoObject.");
			}
			global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
			if (tokenType == global::Newtonsoft.Json.JsonToken.StartObject)
			{
				return this.ReadObject(reader);
			}
			if (tokenType == global::Newtonsoft.Json.JsonToken.StartArray)
			{
				return this.ReadList(reader);
			}
			if (global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsPrimitiveToken(reader.TokenType))
			{
				return reader.Value;
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when converting ExpandoObject: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
		}

		// Token: 0x06000C50 RID: 3152 RVA: 0x00031B9C File Offset: 0x0002FD9C
		private object ReadList(global::Newtonsoft.Json.JsonReader reader)
		{
			global::System.Collections.Generic.IList<object> list = new global::System.Collections.Generic.List<object>();
			while (reader.Read())
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
				{
					if (tokenType == global::Newtonsoft.Json.JsonToken.EndArray)
					{
						return list;
					}
					object item = this.ReadValue(reader);
					list.Add(item);
				}
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when reading ExpandoObject.");
		}

		// Token: 0x06000C51 RID: 3153 RVA: 0x00031BE8 File Offset: 0x0002FDE8
		private object ReadObject(global::Newtonsoft.Json.JsonReader reader)
		{
			global::System.Collections.Generic.IDictionary<string, object> dictionary = new global::System.Dynamic.ExpandoObject();
			while (reader.Read())
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
					{
						if (tokenType == global::Newtonsoft.Json.JsonToken.EndObject)
						{
							return dictionary;
						}
					}
				}
				else
				{
					string key = reader.Value.ToString();
					if (!reader.Read())
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when reading ExpandoObject.");
					}
					object value = this.ReadValue(reader);
					dictionary[key] = value;
				}
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when reading ExpandoObject.");
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x00031C5A File Offset: 0x0002FE5A
		public override bool CanConvert(global::System.Type objectType)
		{
			return objectType == typeof(global::System.Dynamic.ExpandoObject);
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000C53 RID: 3155 RVA: 0x00031C6C File Offset: 0x0002FE6C
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}
	}
}
