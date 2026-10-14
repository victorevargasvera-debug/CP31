using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000095 RID: 149
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class JsonSerializerInternalReader : global::Newtonsoft.Json.Serialization.JsonSerializerInternalBase
	{
		// Token: 0x06000764 RID: 1892 RVA: 0x0001D9F4 File Offset: 0x0001BBF4
		public JsonSerializerInternalReader(global::Newtonsoft.Json.JsonSerializer serializer) : base(serializer)
		{
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0001DA00 File Offset: 0x0001BC00
		public void Populate(global::Newtonsoft.Json.JsonReader reader, object target)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(target, "target");
			global::System.Type type = target.GetType();
			global::Newtonsoft.Json.Serialization.JsonContract jsonContract = this.Serializer._contractResolver.ResolveContract(type);
			if (!reader.MoveToContent())
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "No JSON content found.");
			}
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartArray)
			{
				if (jsonContract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Array)
				{
					global::Newtonsoft.Json.Serialization.JsonArrayContract jsonArrayContract = (global::Newtonsoft.Json.Serialization.JsonArrayContract)jsonContract;
					global::System.Collections.IList list;
					if (!jsonArrayContract.ShouldCreateWrapper)
					{
						list = (global::System.Collections.IList)target;
					}
					else
					{
						global::System.Collections.IList list2 = jsonArrayContract.CreateWrapper(target);
						list = list2;
					}
					this.PopulateList(list, reader, jsonArrayContract, null, null);
					return;
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot populate JSON array onto type '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
			}
			else
			{
				if (reader.TokenType != global::Newtonsoft.Json.JsonToken.StartObject)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected initial token '{0}' when populating object. Expected JSON object or array.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.TokenType));
				}
				reader.ReadAndAssert();
				string id = null;
				if (this.Serializer.MetadataPropertyHandling != global::Newtonsoft.Json.MetadataPropertyHandling.Ignore && reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName && string.Equals(reader.Value.ToString(), "$id", global::System.StringComparison.Ordinal))
				{
					reader.ReadAndAssert();
					object value = reader.Value;
					id = ((value != null) ? value.ToString() : null);
					reader.ReadAndAssert();
				}
				if (jsonContract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Dictionary)
				{
					global::Newtonsoft.Json.Serialization.JsonDictionaryContract jsonDictionaryContract = (global::Newtonsoft.Json.Serialization.JsonDictionaryContract)jsonContract;
					global::System.Collections.IDictionary dictionary;
					if (!jsonDictionaryContract.ShouldCreateWrapper)
					{
						dictionary = (global::System.Collections.IDictionary)target;
					}
					else
					{
						global::System.Collections.IDictionary dictionary2 = jsonDictionaryContract.CreateWrapper(target);
						dictionary = dictionary2;
					}
					this.PopulateDictionary(dictionary, reader, jsonDictionaryContract, null, id);
					return;
				}
				if (jsonContract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Object)
				{
					this.PopulateObject(target, reader, (global::Newtonsoft.Json.Serialization.JsonObjectContract)jsonContract, null, id);
					return;
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot populate JSON object onto type '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0001DB8D File Offset: 0x0001BD8D
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private global::Newtonsoft.Json.Serialization.JsonContract GetContractSafe(global::System.Type type)
		{
			if (type == null)
			{
				return null;
			}
			return this.GetContract(type);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0001DBA1 File Offset: 0x0001BDA1
		private global::Newtonsoft.Json.Serialization.JsonContract GetContract(global::System.Type type)
		{
			return this.Serializer._contractResolver.ResolveContract(type);
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0001DBB4 File Offset: 0x0001BDB4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public object Deserialize([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, bool checkAdditionalContent)
		{
			if (reader == null)
			{
				throw new global::System.ArgumentNullException("reader");
			}
			global::Newtonsoft.Json.Serialization.JsonContract contractSafe = this.GetContractSafe(objectType);
			object result;
			try
			{
				global::Newtonsoft.Json.JsonConverter converter = this.GetConverter(contractSafe, null, null, null);
				if (reader.TokenType == global::Newtonsoft.Json.JsonToken.None && !reader.ReadForType(contractSafe, converter != null))
				{
					if (contractSafe != null && !contractSafe.IsNullable)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "No JSON content found and type '{0}' is not nullable.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contractSafe.UnderlyingType));
					}
					result = null;
				}
				else
				{
					object obj;
					if (converter != null && converter.CanRead)
					{
						obj = this.DeserializeConvertable(converter, reader, objectType, null);
					}
					else
					{
						obj = this.CreateValueInternal(reader, objectType, contractSafe, null, null, null, null);
					}
					if (checkAdditionalContent)
					{
						while (reader.Read())
						{
							if (reader.TokenType != global::Newtonsoft.Json.JsonToken.Comment)
							{
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Additional text found in JSON string after finishing deserializing object.");
							}
						}
					}
					result = obj;
				}
			}
			catch (global::System.Exception ex)
			{
				if (!base.IsErrorHandled(null, contractSafe, null, reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, ex))
				{
					base.ClearErrorContext();
					throw;
				}
				this.HandleError(reader, false, 0);
				result = null;
			}
			return result;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0001DCB0 File Offset: 0x0001BEB0
		private global::Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer()
		{
			if (this.InternalSerializer == null)
			{
				this.InternalSerializer = new global::Newtonsoft.Json.Serialization.JsonSerializerProxy(this);
			}
			return this.InternalSerializer;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0001DCCC File Offset: 0x0001BECC
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private global::Newtonsoft.Json.Linq.JToken CreateJToken([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonContract contract)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(reader, "reader");
			if (contract != null)
			{
				if (contract.UnderlyingType == typeof(global::Newtonsoft.Json.Linq.JRaw))
				{
					return global::Newtonsoft.Json.Linq.JRaw.Create(reader);
				}
				if (reader.TokenType == global::Newtonsoft.Json.JsonToken.Null && !(contract.UnderlyingType == typeof(global::Newtonsoft.Json.Linq.JValue)) && !(contract.UnderlyingType == typeof(global::Newtonsoft.Json.Linq.JToken)))
				{
					return null;
				}
			}
			global::Newtonsoft.Json.Linq.JToken token;
			using (global::Newtonsoft.Json.Linq.JTokenWriter jtokenWriter = new global::Newtonsoft.Json.Linq.JTokenWriter())
			{
				jtokenWriter.WriteToken(reader);
				token = jtokenWriter.Token;
			}
			if (contract != null && token != null && !contract.UnderlyingType.IsAssignableFrom(token.GetType()))
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Deserialized JSON type '{0}' is not compatible with expected type '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.GetType().FullName, contract.UnderlyingType.FullName));
			}
			return token;
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0001DDB8 File Offset: 0x0001BFB8
		private global::Newtonsoft.Json.Linq.JToken CreateJObject(global::Newtonsoft.Json.JsonReader reader)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(reader, "reader");
			using (global::Newtonsoft.Json.Linq.JTokenWriter jtokenWriter = new global::Newtonsoft.Json.Linq.JTokenWriter())
			{
				jtokenWriter.WriteStartObject();
				for (;;)
				{
					if (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
					{
						string text = (string)reader.Value;
						if (!reader.ReadAndMoveToContent())
						{
							goto IL_71;
						}
						if (!this.CheckPropertyName(reader, text))
						{
							jtokenWriter.WritePropertyName(text);
							jtokenWriter.WriteToken(reader, true, true, false);
						}
					}
					else if (reader.TokenType != global::Newtonsoft.Json.JsonToken.Comment)
					{
						break;
					}
					if (!reader.Read())
					{
						goto IL_71;
					}
				}
				jtokenWriter.WriteEndObject();
				return jtokenWriter.Token;
				IL_71:
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
			}
			global::Newtonsoft.Json.Linq.JToken result;
			return result;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001DE60 File Offset: 0x0001C060
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private object CreateValueInternal([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue)
		{
			if (contract != null && contract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Linq)
			{
				return this.CreateJToken(reader, contract);
			}
			for (;;)
			{
				switch (reader.TokenType)
				{
				case global::Newtonsoft.Json.JsonToken.StartObject:
					goto IL_6D;
				case global::Newtonsoft.Json.JsonToken.StartArray:
					goto IL_7F;
				case global::Newtonsoft.Json.JsonToken.StartConstructor:
					goto IL_E4;
				case global::Newtonsoft.Json.JsonToken.Comment:
					if (!reader.Read())
					{
						goto Block_7;
					}
					continue;
				case global::Newtonsoft.Json.JsonToken.Raw:
					goto IL_12D;
				case global::Newtonsoft.Json.JsonToken.Integer:
				case global::Newtonsoft.Json.JsonToken.Float:
				case global::Newtonsoft.Json.JsonToken.Boolean:
				case global::Newtonsoft.Json.JsonToken.Date:
				case global::Newtonsoft.Json.JsonToken.Bytes:
					goto IL_8E;
				case global::Newtonsoft.Json.JsonToken.String:
					goto IL_A3;
				case global::Newtonsoft.Json.JsonToken.Null:
				case global::Newtonsoft.Json.JsonToken.Undefined:
					goto IL_100;
				}
				break;
			}
			goto IL_13E;
			IL_6D:
			return this.CreateObject(reader, objectType, contract, member, containerContract, containerMember, existingValue);
			IL_7F:
			return this.CreateList(reader, objectType, contract, member, existingValue, null);
			IL_8E:
			return this.EnsureType(reader, reader.Value, global::System.Globalization.CultureInfo.InvariantCulture, contract, objectType);
			IL_A3:
			string text = (string)reader.Value;
			if (objectType == typeof(byte[]))
			{
				return global::System.Convert.FromBase64String(text);
			}
			if (global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CoerceEmptyStringToNull(objectType, contract, text))
			{
				return null;
			}
			return this.EnsureType(reader, text, global::System.Globalization.CultureInfo.InvariantCulture, contract, objectType);
			IL_E4:
			string value = reader.Value.ToString();
			return this.EnsureType(reader, value, global::System.Globalization.CultureInfo.InvariantCulture, contract, objectType);
			IL_100:
			if (objectType == typeof(global::System.DBNull))
			{
				return global::System.DBNull.Value;
			}
			return this.EnsureType(reader, reader.Value, global::System.Globalization.CultureInfo.InvariantCulture, contract, objectType);
			IL_12D:
			return new global::Newtonsoft.Json.Linq.JRaw((string)reader.Value);
			IL_13E:
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token while deserializing object: " + reader.TokenType.ToString());
			Block_7:
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001DFE8 File Offset: 0x0001C1E8
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private static bool CoerceEmptyStringToNull(global::System.Type objectType, global::Newtonsoft.Json.Serialization.JsonContract contract, [global::System.Runtime.CompilerServices.Nullable(1)] string s)
		{
			return global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(s) && objectType != null && objectType != typeof(string) && objectType != typeof(object) && contract != null && contract.IsNullable;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001E038 File Offset: 0x0001C238
		internal string GetExpectedDescription(global::Newtonsoft.Json.Serialization.JsonContract contract)
		{
			switch (contract.ContractType)
			{
			case global::Newtonsoft.Json.Serialization.JsonContractType.Object:
			case global::Newtonsoft.Json.Serialization.JsonContractType.Dictionary:
			case global::Newtonsoft.Json.Serialization.JsonContractType.Dynamic:
			case global::Newtonsoft.Json.Serialization.JsonContractType.Serializable:
				return "JSON object (e.g. {\"name\":\"value\"})";
			case global::Newtonsoft.Json.Serialization.JsonContractType.Array:
				return "JSON array (e.g. [1,2,3])";
			case global::Newtonsoft.Json.Serialization.JsonContractType.Primitive:
				return "JSON primitive value (e.g. string, number, boolean, null)";
			case global::Newtonsoft.Json.Serialization.JsonContractType.String:
				return "JSON string value";
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001E090 File Offset: 0x0001C290
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private global::Newtonsoft.Json.JsonConverter GetConverter(global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.JsonConverter memberConverter, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			global::Newtonsoft.Json.JsonConverter result = null;
			if (memberConverter != null)
			{
				result = memberConverter;
			}
			else if (((containerProperty != null) ? containerProperty.ItemConverter : null) != null)
			{
				result = containerProperty.ItemConverter;
			}
			else if (((containerContract != null) ? containerContract.ItemConverter : null) != null)
			{
				result = containerContract.ItemConverter;
			}
			else if (contract != null)
			{
				if (contract.Converter != null)
				{
					result = contract.Converter;
				}
				else
				{
					global::Newtonsoft.Json.JsonConverter matchingConverter = this.Serializer.GetMatchingConverter(contract.UnderlyingType);
					if (matchingConverter != null)
					{
						result = matchingConverter;
					}
					else if (contract.InternalConverter != null)
					{
						result = contract.InternalConverter;
					}
				}
			}
			return result;
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0001E114 File Offset: 0x0001C314
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private object CreateObject([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue)
		{
			global::System.Type type = objectType;
			string text;
			if (this.Serializer.MetadataPropertyHandling == global::Newtonsoft.Json.MetadataPropertyHandling.Ignore)
			{
				reader.ReadAndAssert();
				text = null;
			}
			else if (this.Serializer.MetadataPropertyHandling == global::Newtonsoft.Json.MetadataPropertyHandling.ReadAhead)
			{
				global::Newtonsoft.Json.Linq.JTokenReader jtokenReader = reader as global::Newtonsoft.Json.Linq.JTokenReader;
				if (jtokenReader == null)
				{
					jtokenReader = (global::Newtonsoft.Json.Linq.JTokenReader)global::Newtonsoft.Json.Linq.JToken.ReadFrom(reader).CreateReader();
					jtokenReader.Culture = reader.Culture;
					jtokenReader.DateFormatString = reader.DateFormatString;
					jtokenReader.DateParseHandling = reader.DateParseHandling;
					jtokenReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
					jtokenReader.FloatParseHandling = reader.FloatParseHandling;
					jtokenReader.SupportMultipleContent = reader.SupportMultipleContent;
					jtokenReader.ReadAndAssert();
					reader = jtokenReader;
				}
				object result;
				if (this.ReadMetadataPropertiesToken(jtokenReader, ref type, ref contract, member, containerContract, containerMember, existingValue, out result, out text))
				{
					return result;
				}
			}
			else
			{
				reader.ReadAndAssert();
				object result2;
				if (this.ReadMetadataProperties(reader, ref type, ref contract, member, containerContract, containerMember, existingValue, out result2, out text))
				{
					return result2;
				}
			}
			if (this.HasNoDefinedType(contract))
			{
				return this.CreateJObject(reader);
			}
			switch (contract.ContractType)
			{
			case global::Newtonsoft.Json.Serialization.JsonContractType.Object:
			{
				bool flag = false;
				global::Newtonsoft.Json.Serialization.JsonObjectContract jsonObjectContract = (global::Newtonsoft.Json.Serialization.JsonObjectContract)contract;
				object obj;
				if (existingValue != null && (type == objectType || type.IsAssignableFrom(existingValue.GetType())))
				{
					obj = existingValue;
				}
				else
				{
					obj = this.CreateNewObject(reader, jsonObjectContract, member, containerMember, text, out flag);
				}
				if (flag)
				{
					return obj;
				}
				return this.PopulateObject(obj, reader, jsonObjectContract, member, text);
			}
			case global::Newtonsoft.Json.Serialization.JsonContractType.Primitive:
			{
				global::Newtonsoft.Json.Serialization.JsonPrimitiveContract contract2 = (global::Newtonsoft.Json.Serialization.JsonPrimitiveContract)contract;
				if (this.Serializer.MetadataPropertyHandling != global::Newtonsoft.Json.MetadataPropertyHandling.Ignore && reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName && string.Equals(reader.Value.ToString(), "$value", global::System.StringComparison.Ordinal))
				{
					reader.ReadAndAssert();
					if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartObject)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when deserializing primitive value: " + reader.TokenType.ToString());
					}
					object result3 = this.CreateValueInternal(reader, type, contract2, member, null, null, existingValue);
					reader.ReadAndAssert();
					return result3;
				}
				break;
			}
			case global::Newtonsoft.Json.Serialization.JsonContractType.Dictionary:
			{
				global::Newtonsoft.Json.Serialization.JsonDictionaryContract jsonDictionaryContract = (global::Newtonsoft.Json.Serialization.JsonDictionaryContract)contract;
				object result4;
				if (existingValue == null)
				{
					bool flag2;
					global::System.Collections.IDictionary dictionary = this.CreateNewDictionary(reader, jsonDictionaryContract, out flag2);
					if (flag2)
					{
						if (text != null)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot preserve reference to readonly dictionary, or dictionary created from a non-default constructor: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
						}
						if (contract.OnSerializingCallbacks.Count > 0)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot call OnSerializing on readonly dictionary, or dictionary created from a non-default constructor: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
						}
						if (contract.OnErrorCallbacks.Count > 0)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot call OnError on readonly list, or dictionary created from a non-default constructor: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
						}
						if (!jsonDictionaryContract.HasParameterizedCreatorInternal)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot deserialize readonly or fixed size dictionary: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
						}
					}
					this.PopulateDictionary(dictionary, reader, jsonDictionaryContract, member, text);
					if (flag2)
					{
						return (jsonDictionaryContract.OverrideCreator ?? jsonDictionaryContract.ParameterizedCreator)(new object[]
						{
							dictionary
						});
					}
					global::Newtonsoft.Json.Utilities.IWrappedDictionary wrappedDictionary = dictionary as global::Newtonsoft.Json.Utilities.IWrappedDictionary;
					if (wrappedDictionary != null)
					{
						return wrappedDictionary.UnderlyingDictionary;
					}
					result4 = dictionary;
				}
				else
				{
					global::System.Collections.IDictionary dictionary2;
					if (!jsonDictionaryContract.ShouldCreateWrapper && existingValue is global::System.Collections.IDictionary)
					{
						dictionary2 = (global::System.Collections.IDictionary)existingValue;
					}
					else
					{
						global::System.Collections.IDictionary dictionary3 = jsonDictionaryContract.CreateWrapper(existingValue);
						dictionary2 = dictionary3;
					}
					result4 = this.PopulateDictionary(dictionary2, reader, jsonDictionaryContract, member, text);
				}
				return result4;
			}
			case global::Newtonsoft.Json.Serialization.JsonContractType.Dynamic:
			{
				global::Newtonsoft.Json.Serialization.JsonDynamicContract contract3 = (global::Newtonsoft.Json.Serialization.JsonDynamicContract)contract;
				return this.CreateDynamic(reader, contract3, member, text);
			}
			case global::Newtonsoft.Json.Serialization.JsonContractType.Serializable:
			{
				global::Newtonsoft.Json.Serialization.JsonISerializableContract contract4 = (global::Newtonsoft.Json.Serialization.JsonISerializableContract)contract;
				return this.CreateISerializable(reader, contract4, member, text);
			}
			}
			string text2 = "Cannot deserialize the current JSON object (e.g. {{\"name\":\"value\"}}) into type '{0}' because the type requires a {1} to deserialize correctly." + global::System.Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type so that it is a normal .NET type (e.g. not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object." + global::System.Environment.NewLine;
			text2 = text2.FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type, this.GetExpectedDescription(contract));
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, text2);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0001E4C4 File Offset: 0x0001C6C4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool ReadMetadataPropertiesToken([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Linq.JTokenReader reader, ref global::System.Type objectType, ref global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			id = null;
			newValue = null;
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.StartObject)
			{
				global::Newtonsoft.Json.Linq.JObject jobject = (global::Newtonsoft.Json.Linq.JObject)reader.CurrentToken;
				global::Newtonsoft.Json.Linq.JProperty jproperty = jobject.Property("$ref", global::System.StringComparison.Ordinal);
				if (jproperty != null)
				{
					global::Newtonsoft.Json.Linq.JToken value = jproperty.Value;
					if (value.Type != global::Newtonsoft.Json.Linq.JTokenType.String && value.Type != global::Newtonsoft.Json.Linq.JTokenType.Null)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(value, value.Path, "JSON reference {0} property must have a string or null value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, "$ref"), null);
					}
					string text = (string)jproperty;
					if (text != null)
					{
						global::Newtonsoft.Json.Linq.JToken jtoken = jproperty.Next ?? jproperty.Previous;
						if (jtoken != null)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(jtoken, jtoken.Path, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, "$ref"), null);
						}
						newValue = this.Serializer.GetReferenceResolver().ResolveReference(this, text);
						if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
						{
							this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader, reader.Path, "Resolved object reference '{0}' to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text, newValue.GetType())), null);
						}
						reader.Skip();
						return true;
					}
				}
				global::Newtonsoft.Json.Linq.JToken jtoken2 = jobject["$type"];
				if (jtoken2 != null)
				{
					string qualifiedTypeName = (string)jtoken2;
					global::Newtonsoft.Json.JsonReader jsonReader = jtoken2.CreateReader();
					jsonReader.ReadAndAssert();
					this.ResolveTypeName(jsonReader, ref objectType, ref contract, member, containerContract, containerMember, qualifiedTypeName);
					if (jobject["$value"] != null)
					{
						for (;;)
						{
							reader.ReadAndAssert();
							if (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName && (string)reader.Value == "$value")
							{
								break;
							}
							reader.ReadAndAssert();
							reader.Skip();
						}
						return false;
					}
				}
				global::Newtonsoft.Json.Linq.JToken jtoken3 = jobject["$id"];
				if (jtoken3 != null)
				{
					id = (string)jtoken3;
				}
				global::Newtonsoft.Json.Linq.JToken jtoken4 = jobject["$values"];
				if (jtoken4 != null)
				{
					global::Newtonsoft.Json.JsonReader jsonReader2 = jtoken4.CreateReader();
					jsonReader2.ReadAndAssert();
					newValue = this.CreateList(jsonReader2, objectType, contract, member, existingValue, id);
					reader.Skip();
					return true;
				}
			}
			reader.ReadAndAssert();
			return false;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0001E6D0 File Offset: 0x0001C8D0
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool ReadMetadataProperties([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, ref global::System.Type objectType, ref global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerMember, object existingValue, out object newValue, out string id)
		{
			id = null;
			newValue = null;
			if (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
			{
				string text = reader.Value.ToString();
				if (text.Length > 0 && text[0] == '$')
				{
					string text2;
					for (;;)
					{
						text = reader.Value.ToString();
						bool flag;
						if (string.Equals(text, "$ref", global::System.StringComparison.Ordinal))
						{
							reader.ReadAndAssert();
							if (reader.TokenType != global::Newtonsoft.Json.JsonToken.String && reader.TokenType != global::Newtonsoft.Json.JsonToken.Null)
							{
								break;
							}
							object value = reader.Value;
							text2 = ((value != null) ? value.ToString() : null);
							reader.ReadAndAssert();
							if (text2 != null)
							{
								goto Block_7;
							}
							flag = true;
						}
						else if (string.Equals(text, "$type", global::System.StringComparison.Ordinal))
						{
							reader.ReadAndAssert();
							string qualifiedTypeName = reader.Value.ToString();
							this.ResolveTypeName(reader, ref objectType, ref contract, member, containerContract, containerMember, qualifiedTypeName);
							reader.ReadAndAssert();
							flag = true;
						}
						else if (string.Equals(text, "$id", global::System.StringComparison.Ordinal))
						{
							reader.ReadAndAssert();
							object value2 = reader.Value;
							id = ((value2 != null) ? value2.ToString() : null);
							reader.ReadAndAssert();
							flag = true;
						}
						else
						{
							if (string.Equals(text, "$values", global::System.StringComparison.Ordinal))
							{
								goto Block_14;
							}
							flag = false;
						}
						if (!flag || reader.TokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
						{
							return false;
						}
					}
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "JSON reference {0} property must have a string or null value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, "$ref"));
					Block_7:
					if (reader.TokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Additional content found in JSON reference object. A JSON reference object should only have a {0} property.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, "$ref"));
					}
					newValue = this.Serializer.GetReferenceResolver().ResolveReference(this, text2);
					if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
					{
						this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Resolved object reference '{0}' to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text2, newValue.GetType())), null);
					}
					return true;
					Block_14:
					reader.ReadAndAssert();
					object obj = this.CreateList(reader, objectType, contract, member, existingValue, id);
					reader.ReadAndAssert();
					newValue = obj;
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0001E8CC File Offset: 0x0001CACC
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private void ResolveTypeName([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, ref global::System.Type objectType, ref global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerMember, [global::System.Runtime.CompilerServices.Nullable(1)] string qualifiedTypeName)
		{
			if ((((member != null) ? member.TypeNameHandling : null) ?? (((containerContract != null) ? containerContract.ItemTypeNameHandling : null) ?? (((containerMember != null) ? containerMember.ItemTypeNameHandling : null) ?? this.Serializer._typeNameHandling))) != global::Newtonsoft.Json.TypeNameHandling.None)
			{
				global::Newtonsoft.Json.Utilities.StructMultiKey<string, string> structMultiKey = global::Newtonsoft.Json.Utilities.ReflectionUtils.SplitFullyQualifiedTypeName(qualifiedTypeName);
				global::System.Type type;
				try
				{
					type = this.Serializer._serializationBinder.BindToType(structMultiKey.Value1, structMultiKey.Value2);
				}
				catch (global::System.Exception ex)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Error resolving type specified in JSON '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, qualifiedTypeName), ex);
				}
				if (type == null)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Type specified in JSON '{0}' was not resolved.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, qualifiedTypeName));
				}
				if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
				{
					this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Resolved type '{0}' to {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, qualifiedTypeName, type)), null);
				}
				if (objectType != null && objectType != typeof(global::System.Dynamic.IDynamicMetaObjectProvider) && !objectType.IsAssignableFrom(type))
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Type specified in JSON '{0}' is not compatible with '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type.AssemblyQualifiedName, objectType.AssemblyQualifiedName));
				}
				objectType = type;
				contract = this.GetContract(type);
			}
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001EA80 File Offset: 0x0001CC80
		private global::Newtonsoft.Json.Serialization.JsonArrayContract EnsureArrayContract(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, global::Newtonsoft.Json.Serialization.JsonContract contract)
		{
			if (contract == null)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not resolve type '{0}' to a JsonContract.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType));
			}
			global::Newtonsoft.Json.Serialization.JsonArrayContract jsonArrayContract = contract as global::Newtonsoft.Json.Serialization.JsonArrayContract;
			if (jsonArrayContract == null)
			{
				string text = "Cannot deserialize the current JSON array (e.g. [1,2,3]) into type '{0}' because the type requires a {1} to deserialize correctly." + global::System.Environment.NewLine + "To fix this error either change the JSON to a {1} or change the deserialized type to an array or a type that implements a collection interface (e.g. ICollection, IList) like List<T> that can be deserialized from a JSON array. JsonArrayAttribute can also be added to the type to force it to deserialize from a JSON array." + global::System.Environment.NewLine;
				text = text.FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType, this.GetExpectedDescription(contract));
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, text);
			}
			return jsonArrayContract;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0001EAE8 File Offset: 0x0001CCE8
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private object CreateList([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonProperty member, object existingValue, string id)
		{
			if (this.HasNoDefinedType(contract))
			{
				return this.CreateJToken(reader, contract);
			}
			global::Newtonsoft.Json.Serialization.JsonArrayContract jsonArrayContract = this.EnsureArrayContract(reader, objectType, contract);
			object result;
			if (existingValue == null)
			{
				bool flag;
				global::System.Collections.IList list = this.CreateNewList(reader, jsonArrayContract, out flag);
				if (flag)
				{
					if (id != null)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot preserve reference to array or readonly list, or list created from a non-default constructor: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					if (contract.OnSerializingCallbacks.Count > 0)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot call OnSerializing on an array or readonly list, or list created from a non-default constructor: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					if (contract.OnErrorCallbacks.Count > 0)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot call OnError on an array or readonly list, or list created from a non-default constructor: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
					if (!jsonArrayContract.HasParameterizedCreatorInternal && !jsonArrayContract.IsArray)
					{
						throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot deserialize readonly or fixed size list: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
					}
				}
				if (!jsonArrayContract.IsMultidimensionalArray)
				{
					this.PopulateList(list, reader, jsonArrayContract, member, id);
				}
				else
				{
					this.PopulateMultidimensionalArray(list, reader, jsonArrayContract, member, id);
				}
				if (flag)
				{
					if (jsonArrayContract.IsMultidimensionalArray)
					{
						list = global::Newtonsoft.Json.Utilities.CollectionUtils.ToMultidimensionalArray(list, jsonArrayContract.CollectionItemType, contract.CreatedType.GetArrayRank());
					}
					else
					{
						if (!jsonArrayContract.IsArray)
						{
							return (jsonArrayContract.OverrideCreator ?? jsonArrayContract.ParameterizedCreator)(new object[]
							{
								list
							});
						}
						global::System.Array array = global::System.Array.CreateInstance(jsonArrayContract.CollectionItemType, list.Count);
						list.CopyTo(array, 0);
						list = array;
					}
				}
				else
				{
					global::Newtonsoft.Json.Utilities.IWrappedCollection wrappedCollection = list as global::Newtonsoft.Json.Utilities.IWrappedCollection;
					if (wrappedCollection != null)
					{
						return wrappedCollection.UnderlyingCollection;
					}
				}
				result = list;
			}
			else
			{
				if (!jsonArrayContract.CanDeserialize)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot populate list type {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.CreatedType));
				}
				global::System.Collections.IList list3;
				if (!jsonArrayContract.ShouldCreateWrapper)
				{
					global::System.Collections.IList list2 = existingValue as global::System.Collections.IList;
					if (list2 != null)
					{
						list3 = list2;
						goto IL_1CA;
					}
				}
				global::System.Collections.IList list4 = jsonArrayContract.CreateWrapper(existingValue);
				list3 = list4;
				IL_1CA:
				result = this.PopulateList(list3, reader, jsonArrayContract, member, id);
			}
			return result;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001ECCC File Offset: 0x0001CECC
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool HasNoDefinedType(global::Newtonsoft.Json.Serialization.JsonContract contract)
		{
			return contract == null || contract.UnderlyingType == typeof(object) || contract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Linq || contract.UnderlyingType == typeof(global::System.Dynamic.IDynamicMetaObjectProvider);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0001ED08 File Offset: 0x0001CF08
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private object EnsureType([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, object value, [global::System.Runtime.CompilerServices.Nullable(1)] global::System.Globalization.CultureInfo culture, global::Newtonsoft.Json.Serialization.JsonContract contract, global::System.Type targetType)
		{
			if (targetType == null)
			{
				return value;
			}
			if (global::Newtonsoft.Json.Utilities.ReflectionUtils.GetObjectType(value) != targetType)
			{
				if (value == null && contract.IsNullable)
				{
					return null;
				}
				try
				{
					if (!contract.IsConvertable)
					{
						return global::Newtonsoft.Json.Utilities.ConvertUtils.ConvertOrCast(value, culture, contract.NonNullableUnderlyingType);
					}
					global::Newtonsoft.Json.Serialization.JsonPrimitiveContract jsonPrimitiveContract = (global::Newtonsoft.Json.Serialization.JsonPrimitiveContract)contract;
					if (contract.IsEnum)
					{
						string text = value as string;
						if (text != null)
						{
							return global::Newtonsoft.Json.Utilities.EnumUtils.ParseEnum(contract.NonNullableUnderlyingType, null, text, false);
						}
						if (global::Newtonsoft.Json.Utilities.ConvertUtils.IsInteger(jsonPrimitiveContract.TypeCode))
						{
							return global::System.Enum.ToObject(contract.NonNullableUnderlyingType, value);
						}
					}
					else if (contract.NonNullableUnderlyingType == typeof(global::System.DateTime))
					{
						string text2 = value as string;
						global::System.DateTime value2;
						if (text2 != null && global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTime(text2, reader.DateTimeZoneHandling, reader.DateFormatString, reader.Culture, out value2))
						{
							return global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime(value2, reader.DateTimeZoneHandling);
						}
					}
					if (value is global::System.Numerics.BigInteger)
					{
						global::System.Numerics.BigInteger i = (global::System.Numerics.BigInteger)value;
						return global::Newtonsoft.Json.Utilities.ConvertUtils.FromBigInteger(i, contract.NonNullableUnderlyingType);
					}
					return global::System.Convert.ChangeType(value, contract.NonNullableUnderlyingType, culture);
				}
				catch (global::System.Exception ex)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Error converting value {0} to type '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ToString(value), targetType), ex);
				}
				return value;
			}
			return value;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0001EE70 File Offset: 0x0001D070
		private bool SetPropertyValue(global::Newtonsoft.Json.Serialization.JsonProperty property, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.JsonConverter propertyConverter, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty, global::Newtonsoft.Json.JsonReader reader, object target)
		{
			bool flag;
			object value;
			global::Newtonsoft.Json.Serialization.JsonContract contract;
			bool flag2;
			bool result;
			if (this.CalculatePropertyDetails(property, ref propertyConverter, containerContract, containerProperty, reader, target, out flag, out value, out contract, out flag2, out result))
			{
				return result;
			}
			object obj;
			if (propertyConverter != null && propertyConverter.CanRead)
			{
				if (!flag2 && property.Readable)
				{
					value = property.ValueProvider.GetValue(target);
				}
				obj = this.DeserializeConvertable(propertyConverter, reader, property.PropertyType, value);
			}
			else
			{
				obj = this.CreateValueInternal(reader, property.PropertyType, contract, property, containerContract, containerProperty, flag ? value : null);
			}
			if ((!flag || obj != value) && this.ShouldSetPropertyValue(property, containerContract as global::Newtonsoft.Json.Serialization.JsonObjectContract, obj))
			{
				property.ValueProvider.SetValue(target, obj);
				if (property.SetIsSpecified != null)
				{
					if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
					{
						this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "IsSpecified for property '{0}' on {1} set to true.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType)), null);
					}
					property.SetIsSpecified(target, true);
				}
				return true;
			}
			return flag;
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001EF90 File Offset: 0x0001D190
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool CalculatePropertyDetails([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Serialization.JsonProperty property, ref global::Newtonsoft.Json.JsonConverter propertyConverter, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerProperty, [global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonReader reader, [global::System.Runtime.CompilerServices.Nullable(1)] object target, out bool useExistingValue, out object currentValue, out global::Newtonsoft.Json.Serialization.JsonContract propertyContract, out bool gottenCurrentValue, out bool ignoredValue)
		{
			currentValue = null;
			useExistingValue = false;
			propertyContract = null;
			gottenCurrentValue = false;
			ignoredValue = false;
			if (property.Ignored)
			{
				return true;
			}
			global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
			if (property.PropertyContract == null)
			{
				property.PropertyContract = this.GetContractSafe(property.PropertyType);
			}
			if (property.ObjectCreationHandling.GetValueOrDefault(this.Serializer._objectCreationHandling) != global::Newtonsoft.Json.ObjectCreationHandling.Replace && (tokenType == global::Newtonsoft.Json.JsonToken.StartArray || tokenType == global::Newtonsoft.Json.JsonToken.StartObject || propertyConverter != null) && property.Readable)
			{
				currentValue = property.ValueProvider.GetValue(target);
				gottenCurrentValue = true;
				if (currentValue != null)
				{
					propertyContract = this.GetContract(currentValue.GetType());
					useExistingValue = (!propertyContract.IsReadOnlyOrFixedSize && !propertyContract.UnderlyingType.IsValueType());
				}
			}
			if (!property.Writable && !useExistingValue)
			{
				if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
				{
					this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Unable to deserialize value to non-writable property '{0}' on {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType)), null);
				}
				return true;
			}
			if (tokenType == global::Newtonsoft.Json.JsonToken.Null && base.ResolvedNullValueHandling(containerContract as global::Newtonsoft.Json.Serialization.JsonObjectContract, property) == global::Newtonsoft.Json.NullValueHandling.Ignore)
			{
				ignoredValue = true;
				return true;
			}
			if (this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), global::Newtonsoft.Json.DefaultValueHandling.Ignore) && !this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), global::Newtonsoft.Json.DefaultValueHandling.Populate) && global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsPrimitiveToken(tokenType) && global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ValueEquals(reader.Value, property.GetResolvedDefaultValue()))
			{
				ignoredValue = true;
				return true;
			}
			if (currentValue == null)
			{
				propertyContract = property.PropertyContract;
			}
			else
			{
				propertyContract = this.GetContract(currentValue.GetType());
				if (propertyContract != property.PropertyContract)
				{
					propertyConverter = this.GetConverter(propertyContract, property.Converter, containerContract, containerProperty);
				}
			}
			return false;
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0001F17C File Offset: 0x0001D37C
		private void AddReference(global::Newtonsoft.Json.JsonReader reader, string id, object value)
		{
			try
			{
				if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
				{
					this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Read object reference Id '{0}' for {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, id, value.GetType())), null);
				}
				this.Serializer.GetReferenceResolver().AddReference(this, id, value);
			}
			catch (global::System.Exception ex)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Error reading object reference '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, id), ex);
			}
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001F214 File Offset: 0x0001D414
		private bool HasFlag(global::Newtonsoft.Json.DefaultValueHandling value, global::Newtonsoft.Json.DefaultValueHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0001F21C File Offset: 0x0001D41C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool ShouldSetPropertyValue([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Serialization.JsonProperty property, global::Newtonsoft.Json.Serialization.JsonObjectContract contract, object value)
		{
			return (value != null || base.ResolvedNullValueHandling(contract, property) != global::Newtonsoft.Json.NullValueHandling.Ignore) && (!this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), global::Newtonsoft.Json.DefaultValueHandling.Ignore) || this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), global::Newtonsoft.Json.DefaultValueHandling.Populate) || !global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ValueEquals(value, property.GetResolvedDefaultValue())) && property.Writable;
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0001F298 File Offset: 0x0001D498
		private global::System.Collections.IList CreateNewList(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonArrayContract contract, out bool createdFromNonDefaultCreator)
		{
			if (!contract.CanDeserialize)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Cannot create and populate list type {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.CreatedType));
			}
			if (contract.OverrideCreator != null)
			{
				if (contract.HasParameterizedCreator)
				{
					createdFromNonDefaultCreator = true;
					return contract.CreateTemporaryCollection();
				}
				object obj = contract.OverrideCreator(new object[0]);
				if (contract.ShouldCreateWrapper)
				{
					obj = contract.CreateWrapper(obj);
				}
				createdFromNonDefaultCreator = false;
				return (global::System.Collections.IList)obj;
			}
			else
			{
				if (contract.IsReadOnlyOrFixedSize)
				{
					createdFromNonDefaultCreator = true;
					global::System.Collections.IList list = contract.CreateTemporaryCollection();
					if (contract.ShouldCreateWrapper)
					{
						list = contract.CreateWrapper(list);
					}
					return list;
				}
				if (contract.DefaultCreator != null && (!contract.DefaultCreatorNonPublic || this.Serializer._constructorHandling == global::Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor))
				{
					object obj2 = contract.DefaultCreator();
					if (contract.ShouldCreateWrapper)
					{
						obj2 = contract.CreateWrapper(obj2);
					}
					createdFromNonDefaultCreator = false;
					return (global::System.Collections.IList)obj2;
				}
				if (contract.HasParameterizedCreatorInternal)
				{
					createdFromNonDefaultCreator = true;
					return contract.CreateTemporaryCollection();
				}
				if (!contract.IsInstantiable)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unable to find a constructor to use for type {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0001F3C8 File Offset: 0x0001D5C8
		private global::System.Collections.IDictionary CreateNewDictionary(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonDictionaryContract contract, out bool createdFromNonDefaultCreator)
		{
			if (contract.OverrideCreator != null)
			{
				if (contract.HasParameterizedCreator)
				{
					createdFromNonDefaultCreator = true;
					return contract.CreateTemporaryDictionary();
				}
				createdFromNonDefaultCreator = false;
				return (global::System.Collections.IDictionary)contract.OverrideCreator(new object[0]);
			}
			else
			{
				if (contract.IsReadOnlyOrFixedSize)
				{
					createdFromNonDefaultCreator = true;
					return contract.CreateTemporaryDictionary();
				}
				if (contract.DefaultCreator != null && (!contract.DefaultCreatorNonPublic || this.Serializer._constructorHandling == global::Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor))
				{
					object obj = contract.DefaultCreator();
					if (contract.ShouldCreateWrapper)
					{
						obj = contract.CreateWrapper(obj);
					}
					createdFromNonDefaultCreator = false;
					return (global::System.Collections.IDictionary)obj;
				}
				if (contract.HasParameterizedCreatorInternal)
				{
					createdFromNonDefaultCreator = true;
					return contract.CreateTemporaryDictionary();
				}
				if (!contract.IsInstantiable)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unable to find a default constructor to use for type {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0001F4B0 File Offset: 0x0001D6B0
		private void OnDeserializing(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonContract contract, object value)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Started deserializing {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			contract.InvokeOnDeserializing(value, this.Serializer._context);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0001F518 File Offset: 0x0001D718
		private void OnDeserialized(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonContract contract, object value)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Finished deserializing {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			contract.InvokeOnDeserialized(value, this.Serializer._context);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0001F580 File Offset: 0x0001D780
		private object PopulateDictionary(global::System.Collections.IDictionary dictionary, global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonDictionaryContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty, [global::System.Runtime.CompilerServices.Nullable(2)] string id)
		{
			global::Newtonsoft.Json.Utilities.IWrappedDictionary wrappedDictionary = dictionary as global::Newtonsoft.Json.Utilities.IWrappedDictionary;
			object obj = (wrappedDictionary != null) ? wrappedDictionary.UnderlyingDictionary : dictionary;
			if (id != null)
			{
				this.AddReference(reader, id, obj);
			}
			this.OnDeserializing(reader, contract, obj);
			int depth = reader.Depth;
			if (contract.KeyContract == null)
			{
				contract.KeyContract = this.GetContractSafe(contract.DictionaryKeyType);
			}
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.GetContractSafe(contract.DictionaryValueType);
			}
			global::Newtonsoft.Json.JsonConverter jsonConverter = contract.ItemConverter ?? this.GetConverter(contract.ItemContract, null, contract, containerProperty);
			global::Newtonsoft.Json.Serialization.JsonPrimitiveContract jsonPrimitiveContract = contract.KeyContract as global::Newtonsoft.Json.Serialization.JsonPrimitiveContract;
			global::Newtonsoft.Json.Utilities.PrimitiveTypeCode primitiveTypeCode = (jsonPrimitiveContract != null) ? jsonPrimitiveContract.TypeCode : global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Empty;
			bool flag = false;
			for (;;)
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
					{
						if (tokenType != global::Newtonsoft.Json.JsonToken.EndObject)
						{
							break;
						}
						goto IL_2A0;
					}
				}
				else
				{
					object obj2 = reader.Value;
					if (!this.CheckPropertyName(reader, obj2.ToString()))
					{
						try
						{
							try
							{
								if (primitiveTypeCode - global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime > 1)
								{
									if (primitiveTypeCode - global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset > 1)
									{
										object obj3;
										if (contract.KeyContract == null || !contract.KeyContract.IsEnum)
										{
											obj3 = this.EnsureType(reader, obj2, global::System.Globalization.CultureInfo.InvariantCulture, contract.KeyContract, contract.DictionaryKeyType);
										}
										else
										{
											global::System.Type nonNullableUnderlyingType = contract.KeyContract.NonNullableUnderlyingType;
											global::Newtonsoft.Json.Serialization.DefaultContractResolver defaultContractResolver = this.Serializer._contractResolver as global::Newtonsoft.Json.Serialization.DefaultContractResolver;
											obj3 = global::Newtonsoft.Json.Utilities.EnumUtils.ParseEnum(nonNullableUnderlyingType, (defaultContractResolver != null) ? defaultContractResolver.NamingStrategy : null, obj2.ToString(), false);
										}
										obj2 = obj3;
									}
									else
									{
										global::System.DateTimeOffset dateTimeOffset;
										obj2 = (global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTimeOffset(obj2.ToString(), reader.DateFormatString, reader.Culture, out dateTimeOffset) ? dateTimeOffset : this.EnsureType(reader, obj2, global::System.Globalization.CultureInfo.InvariantCulture, contract.KeyContract, contract.DictionaryKeyType));
									}
								}
								else
								{
									global::System.DateTime dateTime;
									obj2 = (global::Newtonsoft.Json.Utilities.DateTimeUtils.TryParseDateTime(obj2.ToString(), reader.DateTimeZoneHandling, reader.DateFormatString, reader.Culture, out dateTime) ? dateTime : this.EnsureType(reader, obj2, global::System.Globalization.CultureInfo.InvariantCulture, contract.KeyContract, contract.DictionaryKeyType));
								}
							}
							catch (global::System.Exception ex)
							{
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not convert string '{0}' to dictionary key type '{1}'. Create a TypeConverter to convert from the string to the key type object.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reader.Value, contract.DictionaryKeyType), ex);
							}
							if (!reader.ReadForType(contract.ItemContract, jsonConverter != null))
							{
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when deserializing object.");
							}
							object value;
							if (jsonConverter != null && jsonConverter.CanRead)
							{
								value = this.DeserializeConvertable(jsonConverter, reader, contract.DictionaryValueType, null);
							}
							else
							{
								value = this.CreateValueInternal(reader, contract.DictionaryValueType, contract.ItemContract, null, contract, containerProperty, null);
							}
							dictionary[obj2] = value;
							goto IL_2CB;
						}
						catch (global::System.Exception ex2)
						{
							if (base.IsErrorHandled(obj, contract, obj2, reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, ex2))
							{
								this.HandleError(reader, true, depth);
								goto IL_2CB;
							}
							throw;
						}
						goto IL_2A0;
					}
				}
				IL_2CB:
				if (flag || !reader.Read())
				{
					goto IL_2DA;
				}
				continue;
				IL_2A0:
				flag = true;
				goto IL_2CB;
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType.ToString());
			IL_2DA:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, obj, "Unexpected end when deserializing object.");
			}
			this.OnDeserialized(reader, contract, obj);
			return obj;
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001F8B8 File Offset: 0x0001DAB8
		private object PopulateMultidimensionalArray(global::System.Collections.IList list, global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonArrayContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty, [global::System.Runtime.CompilerServices.Nullable(2)] string id)
		{
			int arrayRank = contract.UnderlyingType.GetArrayRank();
			if (id != null)
			{
				this.AddReference(reader, id, list);
			}
			this.OnDeserializing(reader, contract, list);
			global::Newtonsoft.Json.Serialization.JsonContract contractSafe = this.GetContractSafe(contract.CollectionItemType);
			global::Newtonsoft.Json.JsonConverter converter = this.GetConverter(contractSafe, null, contract, containerProperty);
			int? num = null;
			global::System.Collections.Generic.Stack<global::System.Collections.IList> stack = new global::System.Collections.Generic.Stack<global::System.Collections.IList>();
			stack.Push(list);
			global::System.Collections.IList list2 = list;
			bool flag = false;
			for (;;)
			{
				int depth = reader.Depth;
				global::Newtonsoft.Json.JsonToken tokenType;
				if (stack.Count == arrayRank)
				{
					try
					{
						if (reader.ReadForType(contractSafe, converter != null))
						{
							tokenType = reader.TokenType;
							if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
							{
								if (tokenType == global::Newtonsoft.Json.JsonToken.EndArray)
								{
									stack.Pop();
									list2 = stack.Peek();
									num = null;
								}
								else
								{
									object value;
									if (converter != null && converter.CanRead)
									{
										value = this.DeserializeConvertable(converter, reader, contract.CollectionItemType, null);
									}
									else
									{
										value = this.CreateValueInternal(reader, contract.CollectionItemType, contractSafe, null, contract, containerProperty, null);
									}
									list2.Add(value);
								}
							}
							goto IL_20A;
						}
						goto IL_211;
					}
					catch (global::System.Exception ex)
					{
						global::Newtonsoft.Json.JsonPosition position = reader.GetPosition(depth);
						if (base.IsErrorHandled(list, contract, position.Position, reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, ex))
						{
							this.HandleError(reader, true, depth + 1);
							if (num != null)
							{
								int? num2 = num;
								int position2 = position.Position;
								if (num2.GetValueOrDefault() == position2 & num2 != null)
								{
									throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Infinite loop detected from error handling.", ex);
								}
							}
							num = new int?(position.Position);
							goto IL_20A;
						}
						throw;
					}
					goto IL_17D;
				}
				goto IL_17D;
				IL_20A:
				if (flag)
				{
					goto IL_211;
				}
				continue;
				IL_17D:
				if (!reader.Read())
				{
					goto IL_211;
				}
				tokenType = reader.TokenType;
				if (tokenType == global::Newtonsoft.Json.JsonToken.StartArray)
				{
					global::System.Collections.IList list3 = new global::System.Collections.Generic.List<object>();
					list2.Add(list3);
					stack.Push(list3);
					list2 = list3;
					goto IL_20A;
				}
				if (tokenType == global::Newtonsoft.Json.JsonToken.Comment)
				{
					goto IL_20A;
				}
				if (tokenType != global::Newtonsoft.Json.JsonToken.EndArray)
				{
					break;
				}
				stack.Pop();
				if (stack.Count > 0)
				{
					list2 = stack.Peek();
					goto IL_20A;
				}
				flag = true;
				goto IL_20A;
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when deserializing multidimensional array: " + reader.TokenType.ToString());
			IL_211:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, list, "Unexpected end when deserializing array.");
			}
			this.OnDeserialized(reader, contract, list);
			return list;
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x0001FB04 File Offset: 0x0001DD04
		private void ThrowUnexpectedEndException(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] object currentObject, string message)
		{
			try
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, message);
			}
			catch (global::System.Exception ex)
			{
				if (!base.IsErrorHandled(currentObject, contract, null, reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, ex))
				{
					throw;
				}
				this.HandleError(reader, false, 0);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x0001FB54 File Offset: 0x0001DD54
		private object PopulateList(global::System.Collections.IList list, global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonArrayContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty, [global::System.Runtime.CompilerServices.Nullable(2)] string id)
		{
			global::Newtonsoft.Json.Utilities.IWrappedCollection wrappedCollection = list as global::Newtonsoft.Json.Utilities.IWrappedCollection;
			object obj = (wrappedCollection != null) ? wrappedCollection.UnderlyingCollection : list;
			if (id != null)
			{
				this.AddReference(reader, id, obj);
			}
			if (list.IsFixedSize)
			{
				reader.Skip();
				return obj;
			}
			this.OnDeserializing(reader, contract, obj);
			int depth = reader.Depth;
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.GetContractSafe(contract.CollectionItemType);
			}
			global::Newtonsoft.Json.JsonConverter converter = this.GetConverter(contract.ItemContract, null, contract, containerProperty);
			int? num = null;
			bool flag = false;
			do
			{
				try
				{
					if (!reader.ReadForType(contract.ItemContract, converter != null))
					{
						break;
					}
					global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
					if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
					{
						if (tokenType == global::Newtonsoft.Json.JsonToken.EndArray)
						{
							flag = true;
						}
						else
						{
							object value;
							if (converter != null && converter.CanRead)
							{
								value = this.DeserializeConvertable(converter, reader, contract.CollectionItemType, null);
							}
							else
							{
								value = this.CreateValueInternal(reader, contract.CollectionItemType, contract.ItemContract, null, contract, containerProperty, null);
							}
							list.Add(value);
						}
					}
				}
				catch (global::System.Exception ex)
				{
					global::Newtonsoft.Json.JsonPosition position = reader.GetPosition(depth);
					if (!base.IsErrorHandled(obj, contract, position.Position, reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, ex))
					{
						throw;
					}
					this.HandleError(reader, true, depth + 1);
					if (num != null)
					{
						int? num2 = num;
						int position2 = position.Position;
						if (num2.GetValueOrDefault() == position2 & num2 != null)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Infinite loop detected from error handling.", ex);
						}
					}
					num = new int?(position.Position);
				}
			}
			while (!flag);
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, obj, "Unexpected end when deserializing array.");
			}
			this.OnDeserialized(reader, contract, obj);
			return obj;
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x0001FD0C File Offset: 0x0001DF0C
		private object CreateISerializable(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonISerializableContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] string id)
		{
			global::System.Type underlyingType = contract.UnderlyingType;
			if (!global::Newtonsoft.Json.Serialization.JsonTypeReflector.FullyTrusted)
			{
				string text = "Type '{0}' implements ISerializable but cannot be deserialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + global::System.Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + global::System.Environment.NewLine;
				text = text.FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, underlyingType);
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, text);
			}
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Deserializing {0} using ISerializable constructor.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			global::System.Runtime.Serialization.SerializationInfo serializationInfo = new global::System.Runtime.Serialization.SerializationInfo(contract.UnderlyingType, new global::Newtonsoft.Json.Serialization.JsonFormatterConverter(this, contract, member));
			bool flag = false;
			string text2;
			for (;;)
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
					{
						if (tokenType != global::Newtonsoft.Json.JsonToken.EndObject)
						{
							break;
						}
						flag = true;
					}
				}
				else
				{
					text2 = reader.Value.ToString();
					if (!reader.Read())
					{
						goto Block_7;
					}
					serializationInfo.AddValue(text2, global::Newtonsoft.Json.Linq.JToken.ReadFrom(reader));
				}
				if (flag || !reader.Read())
				{
					goto IL_12F;
				}
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType.ToString());
			Block_7:
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text2));
			IL_12F:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, serializationInfo, "Unexpected end when deserializing object.");
			}
			if (!contract.IsInstantiable)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
			if (contract.ISerializableCreator == null)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "ISerializable type '{0}' does not have a valid constructor. To correctly implement ISerializable a constructor that takes SerializationInfo and StreamingContext parameters should be present.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, underlyingType));
			}
			object obj = contract.ISerializableCreator(new object[]
			{
				serializationInfo,
				this.Serializer._context
			});
			if (id != null)
			{
				this.AddReference(reader, id, obj);
			}
			this.OnDeserializing(reader, contract, obj);
			this.OnDeserialized(reader, contract, obj);
			return obj;
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0001FEE8 File Offset: 0x0001E0E8
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		internal object CreateISerializableItem(global::Newtonsoft.Json.Linq.JToken token, global::System.Type type, global::Newtonsoft.Json.Serialization.JsonISerializableContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member)
		{
			global::Newtonsoft.Json.Serialization.JsonContract contractSafe = this.GetContractSafe(type);
			global::Newtonsoft.Json.JsonConverter converter = this.GetConverter(contractSafe, null, contract, member);
			global::Newtonsoft.Json.JsonReader jsonReader = token.CreateReader();
			jsonReader.ReadAndAssert();
			object result;
			if (converter != null && converter.CanRead)
			{
				result = this.DeserializeConvertable(converter, jsonReader, type, null);
			}
			else
			{
				result = this.CreateValueInternal(jsonReader, type, contractSafe, null, contract, member, null);
			}
			return result;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001FF40 File Offset: 0x0001E140
		private object CreateDynamic(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonDynamicContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] string id)
		{
			if (!contract.IsInstantiable)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
			}
			if (contract.DefaultCreator != null && (!contract.DefaultCreatorNonPublic || this.Serializer._constructorHandling == global::Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor))
			{
				global::System.Dynamic.IDynamicMetaObjectProvider dynamicMetaObjectProvider = (global::System.Dynamic.IDynamicMetaObjectProvider)contract.DefaultCreator();
				if (id != null)
				{
					this.AddReference(reader, id, dynamicMetaObjectProvider);
				}
				this.OnDeserializing(reader, contract, dynamicMetaObjectProvider);
				int depth = reader.Depth;
				bool flag = false;
				for (;;)
				{
					global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
					if (tokenType == global::Newtonsoft.Json.JsonToken.PropertyName)
					{
						string text = reader.Value.ToString();
						try
						{
							if (!reader.Read())
							{
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text));
							}
							global::Newtonsoft.Json.Serialization.JsonProperty closestMatchProperty = contract.Properties.GetClosestMatchProperty(text);
							if (closestMatchProperty != null && closestMatchProperty.Writable && !closestMatchProperty.Ignored)
							{
								if (closestMatchProperty.PropertyContract == null)
								{
									closestMatchProperty.PropertyContract = this.GetContractSafe(closestMatchProperty.PropertyType);
								}
								global::Newtonsoft.Json.JsonConverter converter = this.GetConverter(closestMatchProperty.PropertyContract, closestMatchProperty.Converter, null, null);
								if (!this.SetPropertyValue(closestMatchProperty, converter, null, member, reader, dynamicMetaObjectProvider))
								{
									reader.Skip();
								}
							}
							else
							{
								global::System.Type type = global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsPrimitiveToken(reader.TokenType) ? reader.ValueType : typeof(global::System.Dynamic.IDynamicMetaObjectProvider);
								global::Newtonsoft.Json.Serialization.JsonContract contractSafe = this.GetContractSafe(type);
								global::Newtonsoft.Json.JsonConverter converter2 = this.GetConverter(contractSafe, null, null, member);
								object value;
								if (converter2 != null && converter2.CanRead)
								{
									value = this.DeserializeConvertable(converter2, reader, type, null);
								}
								else
								{
									value = this.CreateValueInternal(reader, type, contractSafe, null, null, member, null);
								}
								contract.TrySetMember(dynamicMetaObjectProvider, text, value);
							}
							goto IL_20F;
						}
						catch (global::System.Exception ex)
						{
							if (base.IsErrorHandled(dynamicMetaObjectProvider, contract, text, reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, ex))
							{
								this.HandleError(reader, true, depth);
								goto IL_20F;
							}
							throw;
						}
						goto IL_1E5;
					}
					if (tokenType != global::Newtonsoft.Json.JsonToken.EndObject)
					{
						break;
					}
					goto IL_1E5;
					IL_20F:
					if (flag || !reader.Read())
					{
						goto IL_21D;
					}
					continue;
					IL_1E5:
					flag = true;
					goto IL_20F;
				}
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType.ToString());
				IL_21D:
				if (!flag)
				{
					this.ThrowUnexpectedEndException(reader, contract, dynamicMetaObjectProvider, "Unexpected end when deserializing object.");
				}
				this.OnDeserialized(reader, contract, dynamicMetaObjectProvider);
				return dynamicMetaObjectProvider;
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unable to find a default constructor to use for type {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType));
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000201A4 File Offset: 0x0001E3A4
		private object CreateObjectUsingCreatorWithParameters(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonObjectContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty, global::Newtonsoft.Json.Serialization.ObjectConstructor<object> creator, [global::System.Runtime.CompilerServices.Nullable(2)] string id)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(creator, "creator");
			bool flag = contract.HasRequiredOrDefaultValueProperties || this.HasFlag(this.Serializer._defaultValueHandling, global::Newtonsoft.Json.DefaultValueHandling.Populate);
			global::System.Type underlyingType = contract.UnderlyingType;
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				string arg = string.Join(", ", from p in contract.CreatorParameters
				select p.PropertyName);
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Deserializing {0} using creator with parameters: {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType, arg)), null);
			}
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> list = this.ResolvePropertyAndCreatorValues(contract, containerProperty, reader, underlyingType);
			if (flag)
			{
				using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Serialization.JsonProperty> enumerator = contract.Properties.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Newtonsoft.Json.Serialization.JsonProperty property = enumerator.Current;
						if (!property.Ignored && list.All((global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext p) => p.Property != property))
						{
							list.Add(new global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext(property.PropertyName)
							{
								Property = property,
								Presence = new global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence?(global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.None)
							});
						}
					}
				}
			}
			object[] array = new object[contract.CreatorParameters.Count];
			foreach (global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext in list)
			{
				if (flag && creatorPropertyContext.Property != null && creatorPropertyContext.Presence == null)
				{
					object value = creatorPropertyContext.Value;
					global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence value2;
					if (value == null)
					{
						value2 = global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Null;
					}
					else
					{
						string text = value as string;
						if (text != null)
						{
							value2 = (global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CoerceEmptyStringToNull(creatorPropertyContext.Property.PropertyType, creatorPropertyContext.Property.PropertyContract, text) ? global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Null : global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Value);
						}
						else
						{
							value2 = global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Value;
						}
					}
					creatorPropertyContext.Presence = new global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence?(value2);
				}
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = creatorPropertyContext.ConstructorProperty;
				if (jsonProperty == null && creatorPropertyContext.Property != null)
				{
					jsonProperty = contract.CreatorParameters.ForgivingCaseSensitiveFind((global::Newtonsoft.Json.Serialization.JsonProperty p) => p.PropertyName, creatorPropertyContext.Property.UnderlyingName);
				}
				if (jsonProperty != null && !jsonProperty.Ignored)
				{
					if (flag)
					{
						global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence? presence = creatorPropertyContext.Presence;
						global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence propertyPresence = global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.None;
						if (!(presence.GetValueOrDefault() == propertyPresence & presence != null))
						{
							presence = creatorPropertyContext.Presence;
							propertyPresence = global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Null;
							if (!(presence.GetValueOrDefault() == propertyPresence & presence != null))
							{
								goto IL_2FD;
							}
						}
						if (jsonProperty.PropertyContract == null)
						{
							jsonProperty.PropertyContract = this.GetContractSafe(jsonProperty.PropertyType);
						}
						if (this.HasFlag(jsonProperty.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), global::Newtonsoft.Json.DefaultValueHandling.Populate))
						{
							creatorPropertyContext.Value = this.EnsureType(reader, jsonProperty.GetResolvedDefaultValue(), global::System.Globalization.CultureInfo.InvariantCulture, jsonProperty.PropertyContract, jsonProperty.PropertyType);
						}
					}
					IL_2FD:
					int num = contract.CreatorParameters.IndexOf(jsonProperty);
					array[num] = creatorPropertyContext.Value;
					creatorPropertyContext.Used = true;
				}
			}
			object obj = creator(array);
			if (id != null)
			{
				this.AddReference(reader, id, obj);
			}
			this.OnDeserializing(reader, contract, obj);
			foreach (global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext2 in list)
			{
				if (!creatorPropertyContext2.Used && creatorPropertyContext2.Property != null && !creatorPropertyContext2.Property.Ignored)
				{
					global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence? presence = creatorPropertyContext2.Presence;
					global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence propertyPresence = global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.None;
					if (!(presence.GetValueOrDefault() == propertyPresence & presence != null))
					{
						global::Newtonsoft.Json.Serialization.JsonProperty property2 = creatorPropertyContext2.Property;
						object value3 = creatorPropertyContext2.Value;
						if (this.ShouldSetPropertyValue(property2, contract, value3))
						{
							property2.ValueProvider.SetValue(obj, value3);
							creatorPropertyContext2.Used = true;
						}
						else if (!property2.Writable && value3 != null)
						{
							global::Newtonsoft.Json.Serialization.JsonContract jsonContract = this.Serializer._contractResolver.ResolveContract(property2.PropertyType);
							if (jsonContract.ContractType != global::Newtonsoft.Json.Serialization.JsonContractType.Array)
							{
								goto IL_50D;
							}
							global::Newtonsoft.Json.Serialization.JsonArrayContract jsonArrayContract = (global::Newtonsoft.Json.Serialization.JsonArrayContract)jsonContract;
							if (jsonArrayContract.CanDeserialize && !jsonArrayContract.IsReadOnlyOrFixedSize)
							{
								object value4 = property2.ValueProvider.GetValue(obj);
								if (value4 != null)
								{
									jsonArrayContract = (global::Newtonsoft.Json.Serialization.JsonArrayContract)this.GetContract(value4.GetType());
									global::System.Collections.IList list2;
									if (!jsonArrayContract.ShouldCreateWrapper)
									{
										list2 = (global::System.Collections.IList)value4;
									}
									else
									{
										global::System.Collections.IList list3 = jsonArrayContract.CreateWrapper(value4);
										list2 = list3;
									}
									global::System.Collections.IList list4 = list2;
									if (!list4.IsFixedSize)
									{
										global::System.Collections.IEnumerable enumerable;
										if (!jsonArrayContract.ShouldCreateWrapper)
										{
											enumerable = (global::System.Collections.IList)value3;
										}
										else
										{
											global::System.Collections.IList list3 = jsonArrayContract.CreateWrapper(value3);
											enumerable = list3;
										}
										using (global::System.Collections.IEnumerator enumerator3 = enumerable.GetEnumerator())
										{
											while (enumerator3.MoveNext())
											{
												object value5 = enumerator3.Current;
												list4.Add(value5);
											}
											goto IL_5CB;
										}
										goto IL_50D;
									}
								}
							}
							IL_5CB:
							creatorPropertyContext2.Used = true;
							continue;
							IL_50D:
							if (jsonContract.ContractType != global::Newtonsoft.Json.Serialization.JsonContractType.Dictionary)
							{
								goto IL_5CB;
							}
							global::Newtonsoft.Json.Serialization.JsonDictionaryContract jsonDictionaryContract = (global::Newtonsoft.Json.Serialization.JsonDictionaryContract)jsonContract;
							if (jsonDictionaryContract.IsReadOnlyOrFixedSize)
							{
								goto IL_5CB;
							}
							object value6 = property2.ValueProvider.GetValue(obj);
							if (value6 != null)
							{
								global::System.Collections.IDictionary dictionary;
								if (!jsonDictionaryContract.ShouldCreateWrapper)
								{
									dictionary = (global::System.Collections.IDictionary)value6;
								}
								else
								{
									global::System.Collections.IDictionary dictionary2 = jsonDictionaryContract.CreateWrapper(value6);
									dictionary = dictionary2;
								}
								global::System.Collections.IDictionary dictionary3 = dictionary;
								global::System.Collections.IDictionary dictionary4;
								if (!jsonDictionaryContract.ShouldCreateWrapper)
								{
									dictionary4 = (global::System.Collections.IDictionary)value3;
								}
								else
								{
									global::System.Collections.IDictionary dictionary2 = jsonDictionaryContract.CreateWrapper(value3);
									dictionary4 = dictionary2;
								}
								using (global::System.Collections.IDictionaryEnumerator enumerator4 = dictionary4.GetEnumerator())
								{
									while (enumerator4.MoveNext())
									{
										global::System.Collections.DictionaryEntry entry = enumerator4.Entry;
										dictionary3[entry.Key] = entry.Value;
									}
								}
								goto IL_5CB;
							}
							goto IL_5CB;
						}
					}
				}
			}
			if (contract.ExtensionDataSetter != null)
			{
				foreach (global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext3 in list)
				{
					if (!creatorPropertyContext3.Used)
					{
						global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence? presence = creatorPropertyContext3.Presence;
						global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence propertyPresence = global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.None;
						if (!(presence.GetValueOrDefault() == propertyPresence & presence != null))
						{
							contract.ExtensionDataSetter(obj, creatorPropertyContext3.Name, creatorPropertyContext3.Value);
						}
					}
				}
			}
			if (flag)
			{
				foreach (global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext4 in list)
				{
					if (creatorPropertyContext4.Property != null)
					{
						this.EndProcessProperty(obj, reader, contract, reader.Depth, creatorPropertyContext4.Property, creatorPropertyContext4.Presence.GetValueOrDefault(), !creatorPropertyContext4.Used);
					}
				}
			}
			this.OnDeserialized(reader, contract, obj);
			return obj;
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00020938 File Offset: 0x0001EB38
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private object DeserializeConvertable(global::Newtonsoft.Json.JsonConverter converter, global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, [global::System.Runtime.CompilerServices.Nullable(2)] object existingValue)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Started deserializing {0} with converter {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType, converter.GetType())), null);
			}
			object result = converter.ReadJson(reader, objectType, existingValue, this.GetInternalSerializer());
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Finished deserializing {0} with converter {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectType, converter.GetType())), null);
			}
			return result;
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x000209EC File Offset: 0x0001EBEC
		private global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> ResolvePropertyAndCreatorValues(global::Newtonsoft.Json.Serialization.JsonObjectContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty, global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType)
		{
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext> list = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext>();
			bool flag = false;
			string text;
			for (;;)
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
					{
						if (tokenType != global::Newtonsoft.Json.JsonToken.EndObject)
						{
							break;
						}
						flag = true;
					}
				}
				else
				{
					text = reader.Value.ToString();
					global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext creatorPropertyContext = new global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CreatorPropertyContext(text)
					{
						ConstructorProperty = contract.CreatorParameters.GetClosestMatchProperty(text),
						Property = contract.Properties.GetClosestMatchProperty(text)
					};
					list.Add(creatorPropertyContext);
					global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = creatorPropertyContext.ConstructorProperty ?? creatorPropertyContext.Property;
					if (jsonProperty != null)
					{
						if (!jsonProperty.Ignored)
						{
							if (jsonProperty.PropertyContract == null)
							{
								jsonProperty.PropertyContract = this.GetContractSafe(jsonProperty.PropertyType);
							}
							global::Newtonsoft.Json.JsonConverter converter = this.GetConverter(jsonProperty.PropertyContract, jsonProperty.Converter, contract, containerProperty);
							if (!reader.ReadForType(jsonProperty.PropertyContract, converter != null))
							{
								goto Block_8;
							}
							if (converter != null && converter.CanRead)
							{
								creatorPropertyContext.Value = this.DeserializeConvertable(converter, reader, jsonProperty.PropertyType, null);
								goto IL_236;
							}
							creatorPropertyContext.Value = this.CreateValueInternal(reader, jsonProperty.PropertyType, jsonProperty.PropertyContract, jsonProperty, contract, containerProperty, null);
							goto IL_236;
						}
					}
					else
					{
						if (!reader.Read())
						{
							goto Block_11;
						}
						if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
						{
							this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Could not find member '{0}' on {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text, contract.UnderlyingType)), null);
						}
						if ((contract.MissingMemberHandling ?? this.Serializer._missingMemberHandling) == global::Newtonsoft.Json.MissingMemberHandling.Error)
						{
							goto Block_15;
						}
					}
					if (contract.ExtensionDataSetter != null)
					{
						creatorPropertyContext.Value = this.ReadExtensionDataValue(contract, containerProperty, reader);
					}
					else
					{
						reader.Skip();
					}
				}
				IL_236:
				if (flag || !reader.Read())
				{
					goto IL_244;
				}
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType.ToString());
			Block_8:
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text));
			Block_11:
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text));
			Block_15:
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not find member '{0}' on object of type '{1}'".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text, objectType.Name));
			IL_244:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, null, "Unexpected end when deserializing object.");
			}
			return list;
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00020C50 File Offset: 0x0001EE50
		public object CreateNewObject(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonObjectContract objectContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerMember, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty, [global::System.Runtime.CompilerServices.Nullable(2)] string id, out bool createdFromNonDefaultCreator)
		{
			object obj = null;
			if (objectContract.OverrideCreator != null)
			{
				if (objectContract.CreatorParameters.Count > 0)
				{
					createdFromNonDefaultCreator = true;
					return this.CreateObjectUsingCreatorWithParameters(reader, objectContract, containerMember, objectContract.OverrideCreator, id);
				}
				obj = objectContract.OverrideCreator(global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<object>());
			}
			else if (objectContract.DefaultCreator != null && (!objectContract.DefaultCreatorNonPublic || this.Serializer._constructorHandling == global::Newtonsoft.Json.ConstructorHandling.AllowNonPublicDefaultConstructor || objectContract.ParameterizedCreator == null))
			{
				obj = objectContract.DefaultCreator();
			}
			else if (objectContract.ParameterizedCreator != null)
			{
				createdFromNonDefaultCreator = true;
				return this.CreateObjectUsingCreatorWithParameters(reader, objectContract, containerMember, objectContract.ParameterizedCreator, id);
			}
			if (obj != null)
			{
				createdFromNonDefaultCreator = false;
				return obj;
			}
			if (!objectContract.IsInstantiable)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not create an instance of type {0}. Type is an interface or abstract class and cannot be instantiated.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectContract.UnderlyingType));
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unable to find a constructor to use for type {0}. A class should either have a default constructor, one constructor with arguments or a constructor marked with the JsonConstructor attribute.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, objectContract.UnderlyingType));
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x00020D38 File Offset: 0x0001EF38
		private object PopulateObject(object newObject, global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonObjectContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] string id)
		{
			this.OnDeserializing(reader, contract, newObject);
			global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Serialization.JsonProperty, global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> dictionary;
			if (!contract.HasRequiredOrDefaultValueProperties && !this.HasFlag(this.Serializer._defaultValueHandling, global::Newtonsoft.Json.DefaultValueHandling.Populate))
			{
				dictionary = null;
			}
			else
			{
				dictionary = contract.Properties.ToDictionary((global::Newtonsoft.Json.Serialization.JsonProperty m) => m, (global::Newtonsoft.Json.Serialization.JsonProperty m) => global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.None);
			}
			global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Serialization.JsonProperty, global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> dictionary2 = dictionary;
			if (id != null)
			{
				this.AddReference(reader, id, newObject);
			}
			int depth = reader.Depth;
			bool flag = false;
			for (;;)
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				if (tokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					if (tokenType != global::Newtonsoft.Json.JsonToken.Comment)
					{
						if (tokenType != global::Newtonsoft.Json.JsonToken.EndObject)
						{
							break;
						}
						goto IL_284;
					}
				}
				else
				{
					string text = reader.Value.ToString();
					if (!this.CheckPropertyName(reader, text))
					{
						try
						{
							global::Newtonsoft.Json.Serialization.JsonProperty closestMatchProperty = contract.Properties.GetClosestMatchProperty(text);
							if (closestMatchProperty != null)
							{
								if (closestMatchProperty.Ignored || !this.ShouldDeserialize(reader, closestMatchProperty, newObject))
								{
									if (reader.Read())
									{
										this.SetPropertyPresence(reader, closestMatchProperty, dictionary2);
										this.SetExtensionData(contract, member, reader, text, newObject);
									}
								}
								else
								{
									if (closestMatchProperty.PropertyContract == null)
									{
										closestMatchProperty.PropertyContract = this.GetContractSafe(closestMatchProperty.PropertyType);
									}
									global::Newtonsoft.Json.JsonConverter converter = this.GetConverter(closestMatchProperty.PropertyContract, closestMatchProperty.Converter, contract, member);
									if (!reader.ReadForType(closestMatchProperty.PropertyContract, converter != null))
									{
										throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected end when setting {0}'s value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text));
									}
									this.SetPropertyPresence(reader, closestMatchProperty, dictionary2);
									if (!this.SetPropertyValue(closestMatchProperty, converter, contract, member, reader, newObject))
									{
										this.SetExtensionData(contract, member, reader, text, newObject);
									}
								}
								goto IL_2AE;
							}
							if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
							{
								this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, "Could not find member '{0}' on {1}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text, contract.UnderlyingType)), null);
							}
							if ((contract.MissingMemberHandling ?? this.Serializer._missingMemberHandling) == global::Newtonsoft.Json.MissingMemberHandling.Error)
							{
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Could not find member '{0}' on object of type '{1}'".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text, contract.UnderlyingType.Name));
							}
							if (!reader.Read())
							{
								goto IL_2AE;
							}
							this.SetExtensionData(contract, member, reader, text, newObject);
							goto IL_2AE;
						}
						catch (global::System.Exception ex)
						{
							if (base.IsErrorHandled(newObject, contract, text, reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, ex))
							{
								this.HandleError(reader, true, depth);
								goto IL_2AE;
							}
							throw;
						}
						goto IL_284;
					}
				}
				IL_2AE:
				if (flag || !reader.Read())
				{
					goto IL_2BC;
				}
				continue;
				IL_284:
				flag = true;
				goto IL_2AE;
			}
			throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Unexpected token when deserializing object: " + reader.TokenType.ToString());
			IL_2BC:
			if (!flag)
			{
				this.ThrowUnexpectedEndException(reader, contract, newObject, "Unexpected end when deserializing object.");
			}
			if (dictionary2 != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<global::Newtonsoft.Json.Serialization.JsonProperty, global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> keyValuePair in dictionary2)
				{
					global::Newtonsoft.Json.Serialization.JsonProperty key = keyValuePair.Key;
					global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence value = keyValuePair.Value;
					this.EndProcessProperty(newObject, reader, contract, depth, key, value, true);
				}
			}
			this.OnDeserialized(reader, contract, newObject);
			return newObject;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000210A0 File Offset: 0x0001F2A0
		private bool ShouldDeserialize(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonProperty property, object target)
		{
			if (property.ShouldDeserialize == null)
			{
				return true;
			}
			bool flag = property.ShouldDeserialize(target);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, reader.Path, "ShouldDeserialize result for property '{0}' on {1}: {2}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType, flag)), null);
			}
			return flag;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00021118 File Offset: 0x0001F318
		private bool CheckPropertyName(global::Newtonsoft.Json.JsonReader reader, string memberName)
		{
			if (this.Serializer.MetadataPropertyHandling == global::Newtonsoft.Json.MetadataPropertyHandling.ReadAhead && (memberName == "$id" || memberName == "$ref" || memberName == "$type" || memberName == "$values"))
			{
				reader.Skip();
				return true;
			}
			return false;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00021170 File Offset: 0x0001F370
		private void SetExtensionData(global::Newtonsoft.Json.Serialization.JsonObjectContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.JsonReader reader, string memberName, object o)
		{
			if (contract.ExtensionDataSetter != null)
			{
				try
				{
					object value = this.ReadExtensionDataValue(contract, member, reader);
					contract.ExtensionDataSetter(o, memberName, value);
					return;
				}
				catch (global::System.Exception ex)
				{
					throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Error setting value in extension data for type '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType), ex);
				}
			}
			reader.Skip();
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000211D8 File Offset: 0x0001F3D8
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		private object ReadExtensionDataValue(global::Newtonsoft.Json.Serialization.JsonObjectContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.JsonReader reader)
		{
			object result;
			if (contract.ExtensionDataIsJToken)
			{
				result = global::Newtonsoft.Json.Linq.JToken.ReadFrom(reader);
			}
			else
			{
				result = this.CreateValueInternal(reader, null, null, null, contract, member, null);
			}
			return result;
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00021208 File Offset: 0x0001F408
		private void EndProcessProperty(object newObject, global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonObjectContract contract, int initialDepth, global::Newtonsoft.Json.Serialization.JsonProperty property, global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence presence, bool setDefaultValue)
		{
			if (presence == global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.None || presence == global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Null)
			{
				try
				{
					global::Newtonsoft.Json.Required required = property.Ignored ? global::Newtonsoft.Json.Required.Default : (property._required ?? contract.ItemRequired.GetValueOrDefault());
					if (presence != global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.None)
					{
						if (presence == global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Null)
						{
							if (required == global::Newtonsoft.Json.Required.Always)
							{
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Required property '{0}' expects a value but got null.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName));
							}
							if (required == global::Newtonsoft.Json.Required.DisallowNull)
							{
								throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Required property '{0}' expects a non-null value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName));
							}
						}
					}
					else
					{
						if (required == global::Newtonsoft.Json.Required.AllowNull || required == global::Newtonsoft.Json.Required.Always)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(reader, "Required property '{0}' not found in JSON.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName));
						}
						if (setDefaultValue && !property.Ignored)
						{
							if (property.PropertyContract == null)
							{
								property.PropertyContract = this.GetContractSafe(property.PropertyType);
							}
							if (this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), global::Newtonsoft.Json.DefaultValueHandling.Populate) && property.Writable)
							{
								property.ValueProvider.SetValue(newObject, this.EnsureType(reader, property.GetResolvedDefaultValue(), global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyContract, property.PropertyType));
							}
						}
					}
				}
				catch (global::System.Exception ex)
				{
					if (!base.IsErrorHandled(newObject, contract, property.PropertyName, reader as global::Newtonsoft.Json.IJsonLineInfo, reader.Path, ex))
					{
						throw;
					}
					this.HandleError(reader, true, initialDepth);
				}
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x000213AC File Offset: 0x0001F5AC
		private void SetPropertyPresence(global::Newtonsoft.Json.JsonReader reader, global::Newtonsoft.Json.Serialization.JsonProperty property, [global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] global::System.Collections.Generic.Dictionary<global::Newtonsoft.Json.Serialization.JsonProperty, global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence> requiredProperties)
		{
			if (property != null && requiredProperties != null)
			{
				global::Newtonsoft.Json.JsonToken tokenType = reader.TokenType;
				global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence value;
				if (tokenType != global::Newtonsoft.Json.JsonToken.String)
				{
					if (tokenType - global::Newtonsoft.Json.JsonToken.Null > 1)
					{
						value = global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Value;
					}
					else
					{
						value = global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Null;
					}
				}
				else
				{
					value = (global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.CoerceEmptyStringToNull(property.PropertyType, property.PropertyContract, (string)reader.Value) ? global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Null : global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence.Value);
				}
				requiredProperties[property] = value;
			}
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00021407 File Offset: 0x0001F607
		private void HandleError(global::Newtonsoft.Json.JsonReader reader, bool readPastError, int initialDepth)
		{
			base.ClearErrorContext();
			if (readPastError)
			{
				reader.Skip();
				while (reader.Depth > initialDepth && reader.Read())
				{
				}
			}
		}

		// Token: 0x020001A6 RID: 422
		[global::System.Runtime.CompilerServices.NullableContext(0)]
		internal enum PropertyPresence
		{
			// Token: 0x0400071B RID: 1819
			None,
			// Token: 0x0400071C RID: 1820
			Null,
			// Token: 0x0400071D RID: 1821
			Value
		}

		// Token: 0x020001A7 RID: 423
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Runtime.CompilerServices.Nullable(0)]
		internal class CreatorPropertyContext
		{
			// Token: 0x06000F2E RID: 3886 RVA: 0x00042BF4 File Offset: 0x00040DF4
			[global::System.Runtime.CompilerServices.NullableContext(1)]
			public CreatorPropertyContext(string name)
			{
				this.Name = name;
			}

			// Token: 0x0400071E RID: 1822
			[global::System.Runtime.CompilerServices.Nullable(1)]
			public readonly string Name;

			// Token: 0x0400071F RID: 1823
			public global::Newtonsoft.Json.Serialization.JsonProperty Property;

			// Token: 0x04000720 RID: 1824
			public global::Newtonsoft.Json.Serialization.JsonProperty ConstructorProperty;

			// Token: 0x04000721 RID: 1825
			public global::Newtonsoft.Json.Serialization.JsonSerializerInternalReader.PropertyPresence? Presence;

			// Token: 0x04000722 RID: 1826
			public object Value;

			// Token: 0x04000723 RID: 1827
			public bool Used;
		}
	}
}
