using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E5 RID: 229
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class EntityKeyMemberConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C47 RID: 3143 RVA: 0x000318C8 File Offset: 0x0002FAC8
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::Newtonsoft.Json.Converters.EntityKeyMemberConverter.EnsureReflectionObject(value.GetType());
			global::Newtonsoft.Json.Serialization.DefaultContractResolver defaultContractResolver = serializer.ContractResolver as global::Newtonsoft.Json.Serialization.DefaultContractResolver;
			string value2 = (string)global::Newtonsoft.Json.Converters.EntityKeyMemberConverter._reflectionObject.GetValue(value, "Key");
			object value3 = global::Newtonsoft.Json.Converters.EntityKeyMemberConverter._reflectionObject.GetValue(value, "Value");
			global::System.Type type = (value3 != null) ? value3.GetType() : null;
			writer.WriteStartObject();
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Key") : "Key");
			writer.WriteValue(value2);
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Type") : "Type");
			writer.WriteValue((type != null) ? type.FullName : null);
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Value") : "Value");
			if (type != null)
			{
				string value4;
				if (global::Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.TryConvertToString(value3, type, out value4))
				{
					writer.WriteValue(value4);
				}
				else
				{
					writer.WriteValue(value3);
				}
			}
			else
			{
				writer.WriteNull();
			}
			writer.WriteEndObject();
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x000319D0 File Offset: 0x0002FBD0
		private static void ReadAndAssertProperty(global::Newtonsoft.Json.JsonReader reader, string propertyName)
		{
			reader.ReadAndAssert();
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
			{
				object value = reader.Value;
				if (string.Equals((value != null) ? value.ToString() : null, propertyName, global::System.StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
			}
			throw new global::Newtonsoft.Json.JsonSerializationException("Expected JSON property '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, propertyName));
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00031A20 File Offset: 0x0002FC20
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			global::Newtonsoft.Json.Converters.EntityKeyMemberConverter.EnsureReflectionObject(objectType);
			object obj = global::Newtonsoft.Json.Converters.EntityKeyMemberConverter._reflectionObject.Creator(new object[0]);
			global::Newtonsoft.Json.Converters.EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Key");
			reader.ReadAndAssert();
			global::Newtonsoft.Json.Utilities.ReflectionObject reflectionObject = global::Newtonsoft.Json.Converters.EntityKeyMemberConverter._reflectionObject;
			object target = obj;
			string member = "Key";
			object value = reader.Value;
			reflectionObject.SetValue(target, member, (value != null) ? value.ToString() : null);
			global::Newtonsoft.Json.Converters.EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Type");
			reader.ReadAndAssert();
			object value2 = reader.Value;
			global::System.Type type = global::System.Type.GetType((value2 != null) ? value2.ToString() : null);
			global::Newtonsoft.Json.Converters.EntityKeyMemberConverter.ReadAndAssertProperty(reader, "Value");
			reader.ReadAndAssert();
			global::Newtonsoft.Json.Converters.EntityKeyMemberConverter._reflectionObject.SetValue(obj, "Value", serializer.Deserialize(reader, type));
			reader.ReadAndAssert();
			return obj;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x00031AD6 File Offset: 0x0002FCD6
		private static void EnsureReflectionObject(global::System.Type objectType)
		{
			if (global::Newtonsoft.Json.Converters.EntityKeyMemberConverter._reflectionObject == null)
			{
				global::Newtonsoft.Json.Converters.EntityKeyMemberConverter._reflectionObject = global::Newtonsoft.Json.Utilities.ReflectionObject.Create(objectType, new string[]
				{
					"Key",
					"Value"
				});
			}
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x00031B00 File Offset: 0x0002FD00
		public override bool CanConvert(global::System.Type objectType)
		{
			return objectType.AssignableToTypeName("System.Data.EntityKeyMember", false);
		}

		// Token: 0x040003D7 RID: 983
		private const string EntityKeyMemberFullTypeName = "System.Data.EntityKeyMember";

		// Token: 0x040003D8 RID: 984
		private const string KeyPropertyName = "Key";

		// Token: 0x040003D9 RID: 985
		private const string TypePropertyName = "Type";

		// Token: 0x040003DA RID: 986
		private const string ValuePropertyName = "Value";

		// Token: 0x040003DB RID: 987
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private static global::Newtonsoft.Json.Utilities.ReflectionObject _reflectionObject;
	}
}
