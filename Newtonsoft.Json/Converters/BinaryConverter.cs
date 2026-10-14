using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000DE RID: 222
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class BinaryConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C23 RID: 3107 RVA: 0x000309E0 File Offset: 0x0002EBE0
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			byte[] byteArray = this.GetByteArray(value);
			writer.WriteValue(byteArray);
		}

		// Token: 0x06000C24 RID: 3108 RVA: 0x00030A08 File Offset: 0x0002EC08
		private byte[] GetByteArray(object value)
		{
			if (value.GetType().FullName == "System.Data.Linq.Binary")
			{
				global::Newtonsoft.Json.Converters.BinaryConverter.EnsureReflectionObject(value.GetType());
				return (byte[])global::Newtonsoft.Json.Converters.BinaryConverter._reflectionObject.GetValue(value, "ToArray");
			}
			if (value is global::System.Data.SqlTypes.SqlBinary)
			{
				return ((global::System.Data.SqlTypes.SqlBinary)value).Value;
			}
			throw new global::Newtonsoft.Json.JsonSerializationException("Unexpected value type when writing binary: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType()));
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x00030A7E File Offset: 0x0002EC7E
		private static void EnsureReflectionObject(global::System.Type t)
		{
			if (global::Newtonsoft.Json.Converters.BinaryConverter._reflectionObject == null)
			{
				global::Newtonsoft.Json.Converters.BinaryConverter._reflectionObject = global::Newtonsoft.Json.Utilities.ReflectionObject.Create(t, t.GetConstructor(new global::System.Type[]
				{
					typeof(byte[])
				}), new string[]
				{
					"ToArray"
				});
			}
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x00030ABC File Offset: 0x0002ECBC
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null)
			{
				if (!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(objectType))
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot convert null value to {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
				}
				return null;
			}
			else
			{
				byte[] array;
				if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartArray)
				{
					array = this.ReadByteArray(reader);
				}
				else
				{
					if (reader.TokenType != global::Newtonsoft.Json.JsonToken.String)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token parsing binary. Expected String or StartArray, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
					}
					array = global::System.Convert.FromBase64String(reader.Value.ToString());
				}
				global::System.Type type = global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType) ? global::System.Nullable.GetUnderlyingType(objectType) : objectType;
				if (type.FullName == "System.Data.Linq.Binary")
				{
					global::Newtonsoft.Json.Converters.BinaryConverter.EnsureReflectionObject(type);
					return global::Newtonsoft.Json.Converters.BinaryConverter._reflectionObject.Creator(new object[]
					{
						array
					});
				}
				if (type == typeof(global::System.Data.SqlTypes.SqlBinary))
				{
					return new global::System.Data.SqlTypes.SqlBinary(array);
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected object type when writing binary: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
			}
		}

		// Token: 0x06000C27 RID: 3111 RVA: 0x00030BC0 File Offset: 0x0002EDC0
		private byte[] ReadByteArray(global::Newtonsoft.Json.JsonReader reader)
		{
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			while (reader.Read())
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
				{
					if (tokenType != global::Newtonsoft.Json.JsonToken.Integer)
					{
						if (tokenType != global::Newtonsoft.Json.JsonToken.EndArray)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when reading bytes: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
						}
						return list.ToArray();
					}
					else
					{
						list.Add(global::System.Convert.ToByte(reader.Value, global::System.Globalization.CultureInfo.InvariantCulture));
					}
				}
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when reading bytes.");
		}

		// Token: 0x06000C28 RID: 3112 RVA: 0x00030C3E File Offset: 0x0002EE3E
		public override bool CanConvert(global::System.Type objectType)
		{
			return objectType.FullName == "System.Data.Linq.Binary" || (objectType == typeof(global::System.Data.SqlTypes.SqlBinary) || objectType == typeof(global::System.Data.SqlTypes.SqlBinary?));
		}

		// Token: 0x040003D0 RID: 976
		private const string BinaryTypeName = "System.Data.Linq.Binary";

		// Token: 0x040003D1 RID: 977
		private const string BinaryToArrayName = "ToArray";

		// Token: 0x040003D2 RID: 978
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private static global::Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;
	}
}
