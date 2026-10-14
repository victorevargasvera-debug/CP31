using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000EA RID: 234
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class RegexConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C67 RID: 3175 RVA: 0x0003231C File Offset: 0x0003051C
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::System.Text.RegularExpressions.Regex regex = (global::System.Text.RegularExpressions.Regex)value;
			global::Newtonsoft.Json.Bson.BsonWriter bsonWriter = writer as global::Newtonsoft.Json.Bson.BsonWriter;
			if (bsonWriter != null)
			{
				this.WriteBson(bsonWriter, regex);
				return;
			}
			this.WriteJson(writer, regex, serializer);
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00032356 File Offset: 0x00030556
		private bool HasFlag(global::System.Text.RegularExpressions.RegexOptions options, global::System.Text.RegularExpressions.RegexOptions flag)
		{
			return (options & flag) == flag;
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x00032360 File Offset: 0x00030560
		private void WriteBson(global::Newtonsoft.Json.Bson.BsonWriter writer, global::System.Text.RegularExpressions.Regex regex)
		{
			string text = null;
			if (this.HasFlag(regex.Options, global::System.Text.RegularExpressions.RegexOptions.IgnoreCase))
			{
				text += "i";
			}
			if (this.HasFlag(regex.Options, global::System.Text.RegularExpressions.RegexOptions.Multiline))
			{
				text += "m";
			}
			if (this.HasFlag(regex.Options, global::System.Text.RegularExpressions.RegexOptions.Singleline))
			{
				text += "s";
			}
			text += "u";
			if (this.HasFlag(regex.Options, global::System.Text.RegularExpressions.RegexOptions.ExplicitCapture))
			{
				text += "x";
			}
			writer.WriteRegex(regex.ToString(), text);
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000323F8 File Offset: 0x000305F8
		private void WriteJson(global::Newtonsoft.Json.JsonWriter writer, global::System.Text.RegularExpressions.Regex regex, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			global::Newtonsoft.Json.Serialization.DefaultContractResolver defaultContractResolver = serializer.ContractResolver as global::Newtonsoft.Json.Serialization.DefaultContractResolver;
			writer.WriteStartObject();
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Pattern") : "Pattern");
			writer.WriteValue(regex.ToString());
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Options") : "Options");
			serializer.Serialize(writer, regex.Options);
			writer.WriteEndObject();
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x00032474 File Offset: 0x00030674
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
			if (tokenType == global::Newtonsoft.Json.JsonToken.StartObject)
			{
				return this.ReadRegexObject(reader, serializer);
			}
			if (tokenType == global::Newtonsoft.Json.JsonToken.String)
			{
				return this.ReadRegexString(reader);
			}
			if (tokenType != global::Newtonsoft.Json.JsonToken.Null)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when reading Regex.");
			}
			return null;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x000324B8 File Offset: 0x000306B8
		private object ReadRegexString(global::Newtonsoft.Json.JsonReader reader)
		{
			string text = (string)reader.Value;
			if (text.Length > 0 && text[0] == '/')
			{
				int num = text.LastIndexOf('/');
				if (num > 0)
				{
					string pattern = text.Substring(1, num - 1);
					global::System.Text.RegularExpressions.RegexOptions regexOptions = global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetRegexOptions(text.Substring(num + 1));
					return new global::System.Text.RegularExpressions.Regex(pattern, regexOptions);
				}
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Regex pattern must be enclosed by slashes.");
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x00032520 File Offset: 0x00030720
		private global::System.Text.RegularExpressions.Regex ReadRegexObject(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			string text = null;
			global::System.Text.RegularExpressions.RegexOptions? regexOptions = null;
			while (reader.Read())
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
					{
						if (tokenType == global::Newtonsoft.Json.JsonToken.EndObject)
						{
							if (text == null)
							{
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Error deserializing Regex. No pattern found.");
							}
							return new global::System.Text.RegularExpressions.Regex(text, regexOptions.GetValueOrDefault());
						}
					}
				}
				else
				{
					string a = reader.Value.ToString();
					if (!reader.Read())
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when reading Regex.");
					}
					if (string.Equals(a, "Pattern", global::System.StringComparison.OrdinalIgnoreCase))
					{
						text = (string)reader.Value;
					}
					else if (string.Equals(a, "Options", global::System.StringComparison.OrdinalIgnoreCase))
					{
						regexOptions = new global::System.Text.RegularExpressions.RegexOptions?(serializer.Deserialize<global::System.Text.RegularExpressions.RegexOptions>(reader));
					}
					else
					{
						reader.Skip();
					}
				}
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when reading Regex.");
		}

		// Token: 0x06000C6E RID: 3182 RVA: 0x000325EA File Offset: 0x000307EA
		public override bool CanConvert(global::System.Type objectType)
		{
			return objectType.Name == "Regex" && this.IsRegex(objectType);
		}

		// Token: 0x06000C6F RID: 3183 RVA: 0x00032607 File Offset: 0x00030807
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		private bool IsRegex(global::System.Type objectType)
		{
			return objectType == typeof(global::System.Text.RegularExpressions.Regex);
		}

		// Token: 0x040003E3 RID: 995
		private const string PatternName = "Pattern";

		// Token: 0x040003E4 RID: 996
		private const string OptionsName = "Options";
	}
}
