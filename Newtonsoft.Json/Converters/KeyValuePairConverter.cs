using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Converters
{
	// Token: 0x020000E9 RID: 233
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	public class KeyValuePairConverter : global::Newtonsoft.Json.JsonConverter
	{
		// Token: 0x06000C61 RID: 3169 RVA: 0x00032094 File Offset: 0x00030294
		private static global::Newtonsoft.Json.Utilities.ReflectionObject InitializeReflectionObject(global::System.Type t)
		{
			global::System.Type[] genericArguments = t.GetGenericArguments();
			global::System.Type type = ((global::System.Collections.Generic.IList<global::System.Type>)genericArguments)[0];
			global::System.Type type2 = ((global::System.Collections.Generic.IList<global::System.Type>)genericArguments)[1];
			return global::Newtonsoft.Json.Utilities.ReflectionObject.Create(t, t.GetConstructor(new global::System.Type[]
			{
				type,
				type2
			}), new string[]
			{
				"Key",
				"Value"
			});
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000320E8 File Offset: 0x000302E8
		public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, [global::System.Runtime.CompilerServices.Nullable(2)] object value, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::Newtonsoft.Json.Utilities.ReflectionObject reflectionObject = global::Newtonsoft.Json.Converters.KeyValuePairConverter.ReflectionObjectPerType.Get(value.GetType());
			global::Newtonsoft.Json.Serialization.DefaultContractResolver defaultContractResolver = serializer.ContractResolver as global::Newtonsoft.Json.Serialization.DefaultContractResolver;
			writer.WriteStartObject();
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Key") : "Key");
			serializer.Serialize(writer, reflectionObject.GetValue(value, "Key"), reflectionObject.GetType("Key"));
			writer.WritePropertyName((defaultContractResolver != null) ? defaultContractResolver.GetResolvedPropertyName("Value") : "Value");
			serializer.Serialize(writer, reflectionObject.GetValue(value, "Value"), reflectionObject.GetType("Value"));
			writer.WriteEndObject();
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x0003219C File Offset: 0x0003039C
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
		{
			if (reader.TokenType != global::Newtonsoft.Json.JsonToken.Null)
			{
				object obj = null;
				object obj2 = null;
				reader.ReadAndAssert();
				global::System.Type key = global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType) ? global::System.Nullable.GetUnderlyingType(objectType) : objectType;
				global::Newtonsoft.Json.Utilities.ReflectionObject reflectionObject = global::Newtonsoft.Json.Converters.KeyValuePairConverter.ReflectionObjectPerType.Get(key);
				global::Newtonsoft.Json.Serialization.JsonContract jsonContract = serializer.ContractResolver.ResolveContract(reflectionObject.GetType("Key"));
				global::Newtonsoft.Json.Serialization.JsonContract jsonContract2 = serializer.ContractResolver.ResolveContract(reflectionObject.GetType("Value"));
				while (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					string a = reader.Value.ToString();
					if (string.Equals(a, "Key", global::System.StringComparison.OrdinalIgnoreCase))
					{
						reader.ReadForTypeAndAssert(jsonContract, false);
						obj = serializer.Deserialize(reader, jsonContract.UnderlyingType);
					}
					else if (string.Equals(a, "Value", global::System.StringComparison.OrdinalIgnoreCase))
					{
						reader.ReadForTypeAndAssert(jsonContract2, false);
						obj2 = serializer.Deserialize(reader, jsonContract2.UnderlyingType);
					}
					else
					{
						reader.Skip();
					}
					reader.ReadAndAssert();
				}
				return reflectionObject.Creator(new object[]
				{
					obj,
					obj2
				});
			}
			if (!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType))
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot convert null value to KeyValuePair.");
			}
			return null;
		}

		// Token: 0x06000C64 RID: 3172 RVA: 0x000322B4 File Offset: 0x000304B4
		public override bool CanConvert(global::System.Type objectType)
		{
			global::System.Type type = global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(objectType) ? global::System.Nullable.GetUnderlyingType(objectType) : objectType;
			return type.IsValueType() && type.IsGenericType() && type.GetGenericTypeDefinition() == typeof(global::System.Collections.Generic.KeyValuePair<, >);
		}

		// Token: 0x040003E0 RID: 992
		private const string KeyName = "Key";

		// Token: 0x040003E1 RID: 993
		private const string ValueName = "Value";

		// Token: 0x040003E2 RID: 994
		private static readonly global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::Newtonsoft.Json.Utilities.ReflectionObject> ReflectionObjectPerType = new global::Newtonsoft.Json.Utilities.ThreadSafeStore<global::System.Type, global::Newtonsoft.Json.Utilities.ReflectionObject>(new global::System.Func<global::System.Type, global::Newtonsoft.Json.Utilities.ReflectionObject>(global::Newtonsoft.Json.Converters.KeyValuePairConverter.InitializeReflectionObject));
	}
}
