using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000096 RID: 150
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class JsonSerializerInternalWriter : global::Newtonsoft.Json.Serialization.JsonSerializerInternalBase
	{
		// Token: 0x06000794 RID: 1940 RVA: 0x0002142B File Offset: 0x0001F62B
		public JsonSerializerInternalWriter(global::Newtonsoft.Json.JsonSerializer serializer) : base(serializer)
		{
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00021440 File Offset: 0x0001F640
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public void Serialize([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonWriter jsonWriter, object value, global::System.Type objectType)
		{
			if (jsonWriter == null)
			{
				throw new global::System.ArgumentNullException("jsonWriter");
			}
			this._rootType = objectType;
			this._rootLevel = this._serializeStack.Count + 1;
			global::Newtonsoft.Json.Serialization.JsonContract contractSafe = this.GetContractSafe(value);
			try
			{
				if (this.ShouldWriteReference(value, null, contractSafe, null, null))
				{
					this.WriteReference(jsonWriter, value);
				}
				else
				{
					this.SerializeValue(jsonWriter, value, contractSafe, null, null, null);
				}
			}
			catch (global::System.Exception ex)
			{
				if (!base.IsErrorHandled(null, contractSafe, null, null, jsonWriter.Path, ex))
				{
					base.ClearErrorContext();
					throw;
				}
				this.HandleError(jsonWriter, 0);
			}
			finally
			{
				this._rootType = null;
			}
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x000214F0 File Offset: 0x0001F6F0
		private global::Newtonsoft.Json.Serialization.JsonSerializerProxy GetInternalSerializer()
		{
			if (this.InternalSerializer == null)
			{
				this.InternalSerializer = new global::Newtonsoft.Json.Serialization.JsonSerializerProxy(this);
			}
			return this.InternalSerializer;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x0002150C File Offset: 0x0001F70C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private global::Newtonsoft.Json.Serialization.JsonContract GetContractSafe(object value)
		{
			if (value == null)
			{
				return null;
			}
			return this.GetContract(value);
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002151A File Offset: 0x0001F71A
		private global::Newtonsoft.Json.Serialization.JsonContract GetContract(object value)
		{
			return this.Serializer._contractResolver.ResolveContract(value.GetType());
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00021534 File Offset: 0x0001F734
		private void SerializePrimitive(global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.Serialization.JsonPrimitiveContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			if (contract.TypeCode == global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Bytes && this.ShouldWriteType(global::Newtonsoft.Json.TypeNameHandling.Objects, contract, member, containerContract, containerProperty))
			{
				writer.WriteStartObject();
				this.WriteTypeProperty(writer, contract.CreatedType);
				writer.WritePropertyName("$value", false);
				global::Newtonsoft.Json.JsonWriter.WriteValue(writer, contract.TypeCode, value);
				writer.WriteEndObject();
				return;
			}
			global::Newtonsoft.Json.JsonWriter.WriteValue(writer, contract.TypeCode, value);
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x0002159C File Offset: 0x0001F79C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private void SerializeValue([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.Serialization.JsonContract valueContract, global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			if (value == null)
			{
				writer.WriteNull();
				return;
			}
			global::Newtonsoft.Json.JsonConverter jsonConverter;
			if ((jsonConverter = ((member != null) ? member.Converter : null)) == null && (jsonConverter = ((containerProperty != null) ? containerProperty.ItemConverter : null)) == null && (jsonConverter = ((containerContract != null) ? containerContract.ItemConverter : null)) == null && (jsonConverter = valueContract.Converter) == null)
			{
				jsonConverter = (this.Serializer.GetMatchingConverter(valueContract.UnderlyingType) ?? valueContract.InternalConverter);
			}
			global::Newtonsoft.Json.JsonConverter jsonConverter2 = jsonConverter;
			if (jsonConverter2 != null && jsonConverter2.CanWrite)
			{
				this.SerializeConvertable(writer, jsonConverter2, value, valueContract, containerContract, containerProperty);
				return;
			}
			switch (valueContract.ContractType)
			{
			case global::Newtonsoft.Json.Serialization.JsonContractType.Object:
				this.SerializeObject(writer, value, (global::Newtonsoft.Json.Serialization.JsonObjectContract)valueContract, member, containerContract, containerProperty);
				return;
			case global::Newtonsoft.Json.Serialization.JsonContractType.Array:
			{
				global::Newtonsoft.Json.Serialization.JsonArrayContract jsonArrayContract = (global::Newtonsoft.Json.Serialization.JsonArrayContract)valueContract;
				if (!jsonArrayContract.IsMultidimensionalArray)
				{
					this.SerializeList(writer, (global::System.Collections.IEnumerable)value, jsonArrayContract, member, containerContract, containerProperty);
					return;
				}
				this.SerializeMultidimensionalArray(writer, (global::System.Array)value, jsonArrayContract, member, containerContract, containerProperty);
				return;
			}
			case global::Newtonsoft.Json.Serialization.JsonContractType.Primitive:
				this.SerializePrimitive(writer, value, (global::Newtonsoft.Json.Serialization.JsonPrimitiveContract)valueContract, member, containerContract, containerProperty);
				return;
			case global::Newtonsoft.Json.Serialization.JsonContractType.String:
				this.SerializeString(writer, value, (global::Newtonsoft.Json.Serialization.JsonStringContract)valueContract);
				return;
			case global::Newtonsoft.Json.Serialization.JsonContractType.Dictionary:
			{
				global::Newtonsoft.Json.Serialization.JsonDictionaryContract jsonDictionaryContract = (global::Newtonsoft.Json.Serialization.JsonDictionaryContract)valueContract;
				global::System.Collections.IDictionary dictionary = value as global::System.Collections.IDictionary;
				global::System.Collections.IDictionary values;
				if (dictionary == null)
				{
					global::System.Collections.IDictionary dictionary2 = jsonDictionaryContract.CreateWrapper(value);
					values = dictionary2;
				}
				else
				{
					values = dictionary;
				}
				this.SerializeDictionary(writer, values, jsonDictionaryContract, member, containerContract, containerProperty);
				return;
			}
			case global::Newtonsoft.Json.Serialization.JsonContractType.Dynamic:
				this.SerializeDynamic(writer, (global::System.Dynamic.IDynamicMetaObjectProvider)value, (global::Newtonsoft.Json.Serialization.JsonDynamicContract)valueContract, member, containerContract, containerProperty);
				return;
			case global::Newtonsoft.Json.Serialization.JsonContractType.Serializable:
				this.SerializeISerializable(writer, (global::System.Runtime.Serialization.ISerializable)value, (global::Newtonsoft.Json.Serialization.JsonISerializableContract)valueContract, member, containerContract, containerProperty);
				return;
			case global::Newtonsoft.Json.Serialization.JsonContractType.Linq:
				((global::Newtonsoft.Json.Linq.JToken)value).WriteTo(writer, this.Serializer.Converters.ToArray<global::Newtonsoft.Json.JsonConverter>());
				return;
			default:
				return;
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0002174C File Offset: 0x0001F94C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool? ResolveIsReference([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonProperty property, global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			bool? result = null;
			if (property != null)
			{
				result = property.IsReference;
			}
			if (result == null && containerProperty != null)
			{
				result = containerProperty.ItemIsReference;
			}
			if (result == null && collectionContract != null)
			{
				result = collectionContract.ItemIsReference;
			}
			if (result == null)
			{
				result = contract.IsReference;
			}
			return result;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x000217A4 File Offset: 0x0001F9A4
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool ShouldWriteReference(object value, global::Newtonsoft.Json.Serialization.JsonProperty property, global::Newtonsoft.Json.Serialization.JsonContract valueContract, global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			if (value == null)
			{
				return false;
			}
			if (valueContract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Primitive || valueContract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.String)
			{
				return false;
			}
			bool? flag = this.ResolveIsReference(valueContract, property, collectionContract, containerProperty);
			if (flag == null)
			{
				if (valueContract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Array)
				{
					flag = new bool?(this.HasFlag(this.Serializer._preserveReferencesHandling, global::Newtonsoft.Json.PreserveReferencesHandling.Arrays));
				}
				else
				{
					flag = new bool?(this.HasFlag(this.Serializer._preserveReferencesHandling, global::Newtonsoft.Json.PreserveReferencesHandling.Objects));
				}
			}
			return flag.GetValueOrDefault() && this.Serializer.GetReferenceResolver().IsReferenced(this, value);
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x0002183C File Offset: 0x0001FA3C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool ShouldWriteProperty(object memberValue, global::Newtonsoft.Json.Serialization.JsonObjectContract containerContract, [global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Serialization.JsonProperty property)
		{
			return (memberValue != null || base.ResolvedNullValueHandling(containerContract, property) != global::Newtonsoft.Json.NullValueHandling.Ignore) && (!this.HasFlag(property.DefaultValueHandling.GetValueOrDefault(this.Serializer._defaultValueHandling), global::Newtonsoft.Json.DefaultValueHandling.Ignore) || !global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ValueEquals(memberValue, property.GetResolvedDefaultValue()));
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x0002188C File Offset: 0x0001FA8C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool CheckForCircularReference([global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.Serialization.JsonProperty property, global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			if (value == null)
			{
				return true;
			}
			if (contract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Primitive || contract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.String)
			{
				return true;
			}
			global::Newtonsoft.Json.ReferenceLoopHandling? referenceLoopHandling = null;
			if (property != null)
			{
				referenceLoopHandling = property.ReferenceLoopHandling;
			}
			if (referenceLoopHandling == null && containerProperty != null)
			{
				referenceLoopHandling = containerProperty.ItemReferenceLoopHandling;
			}
			if (referenceLoopHandling == null && containerContract != null)
			{
				referenceLoopHandling = containerContract.ItemReferenceLoopHandling;
			}
			if ((this.Serializer._equalityComparer != null) ? this._serializeStack.Contains(value, this.Serializer._equalityComparer) : this._serializeStack.Contains(value))
			{
				string text = "Self referencing loop detected";
				if (property != null)
				{
					text += " for property '{0}'".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName);
				}
				text += " with type '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType());
				switch (referenceLoopHandling.GetValueOrDefault(this.Serializer._referenceLoopHandling))
				{
				case global::Newtonsoft.Json.ReferenceLoopHandling.Error:
					throw global::Newtonsoft.Json.JsonSerializationException.Create(null, writer.ContainerPath, text, null);
				case global::Newtonsoft.Json.ReferenceLoopHandling.Ignore:
					if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
					{
						this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, text + ". Skipping serializing self referenced value."), null);
					}
					return false;
				case global::Newtonsoft.Json.ReferenceLoopHandling.Serialize:
					if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
					{
						this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, text + ". Serializing self referenced value."), null);
					}
					return true;
				}
			}
			return true;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00021A1C File Offset: 0x0001FC1C
		private void WriteReference(global::Newtonsoft.Json.JsonWriter writer, object value)
		{
			string reference = this.GetReference(writer, value);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "Writing object reference to Id '{0}' for {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reference, value.GetType())), null);
			}
			writer.WriteStartObject();
			writer.WritePropertyName("$ref", false);
			writer.WriteValue(reference);
			writer.WriteEndObject();
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00021A98 File Offset: 0x0001FC98
		private string GetReference(global::Newtonsoft.Json.JsonWriter writer, object value)
		{
			string reference;
			try
			{
				reference = this.Serializer.GetReferenceResolver().GetReference(this, value);
			}
			catch (global::System.Exception ex)
			{
				throw global::Newtonsoft.Json.JsonSerializationException.Create(null, writer.ContainerPath, "Error writing object reference for '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType()), ex);
			}
			return reference;
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00021AF0 File Offset: 0x0001FCF0
		internal static bool TryConvertToString(object value, global::System.Type type, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out string s)
		{
			global::System.ComponentModel.TypeConverter typeConverter;
			if (global::Newtonsoft.Json.Serialization.JsonTypeReflector.CanTypeDescriptorConvertString(type, out typeConverter))
			{
				s = typeConverter.ConvertToInvariantString(value);
				return true;
			}
			global::System.Type type2 = value as global::System.Type;
			if (type2 != null)
			{
				s = type2.AssemblyQualifiedName;
				return true;
			}
			s = null;
			return false;
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00021B2C File Offset: 0x0001FD2C
		private void SerializeString(global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.Serialization.JsonStringContract contract)
		{
			this.OnSerializing(writer, contract, value);
			string value2;
			global::Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.TryConvertToString(value, contract.UnderlyingType, out value2);
			writer.WriteValue(value2);
			this.OnSerialized(writer, contract, value);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00021B64 File Offset: 0x0001FD64
		private void OnSerializing(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Serialization.JsonContract contract, object value)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "Started serializing {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			contract.InvokeOnSerializing(value, this.Serializer._context);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00021BC8 File Offset: 0x0001FDC8
		private void OnSerialized(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Serialization.JsonContract contract, object value)
		{
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "Finished serializing {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, contract.UnderlyingType)), null);
			}
			contract.InvokeOnSerialized(value, this.Serializer._context);
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00021C2C File Offset: 0x0001FE2C
		private void SerializeObject(global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.Serialization.JsonObjectContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			this.OnSerializing(writer, contract, value);
			this._serializeStack.Add(value);
			this.WriteObjectStart(writer, value, contract, member, collectionContract, containerProperty);
			int top = writer.Top;
			for (int i = 0; i < contract.Properties.Count; i++)
			{
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = contract.Properties[i];
				try
				{
					global::Newtonsoft.Json.Serialization.JsonContract valueContract;
					object value2;
					if (this.CalculatePropertyValues(writer, value, contract, member, jsonProperty, out valueContract, out value2))
					{
						jsonProperty.WritePropertyName(writer);
						this.SerializeValue(writer, value2, valueContract, jsonProperty, contract, member);
					}
				}
				catch (global::System.Exception ex)
				{
					if (!base.IsErrorHandled(value, contract, jsonProperty.PropertyName, null, writer.ContainerPath, ex))
					{
						throw;
					}
					this.HandleError(writer, top);
				}
			}
			global::Newtonsoft.Json.Serialization.ExtensionDataGetter extensionDataGetter = contract.ExtensionDataGetter;
			global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<object, object>> enumerable = (extensionDataGetter != null) ? extensionDataGetter(value) : null;
			if (enumerable != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<object, object> keyValuePair in enumerable)
				{
					global::Newtonsoft.Json.Serialization.JsonContract contract2 = this.GetContract(keyValuePair.Key);
					global::Newtonsoft.Json.Serialization.JsonContract contractSafe = this.GetContractSafe(keyValuePair.Value);
					bool flag;
					string text = this.GetPropertyName(writer, keyValuePair.Key, contract2, out flag);
					text = ((contract.ExtensionDataNameResolver != null) ? contract.ExtensionDataNameResolver(text) : text);
					if (this.ShouldWriteReference(keyValuePair.Value, null, contractSafe, contract, member))
					{
						writer.WritePropertyName(text);
						this.WriteReference(writer, keyValuePair.Value);
					}
					else if (this.CheckForCircularReference(writer, keyValuePair.Value, null, contractSafe, contract, member))
					{
						writer.WritePropertyName(text);
						this.SerializeValue(writer, keyValuePair.Value, contractSafe, null, contract, member);
					}
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, value);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00021E18 File Offset: 0x00020018
		private bool CalculatePropertyValues(global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.Serialization.JsonContainerContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.Serialization.JsonProperty property, [global::System.Runtime.CompilerServices.Nullable(2)] [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out global::Newtonsoft.Json.Serialization.JsonContract memberContract, [global::System.Runtime.CompilerServices.Nullable(2)] out object memberValue)
		{
			if (!property.Ignored && property.Readable && this.ShouldSerialize(writer, property, value) && this.IsSpecified(writer, property, value))
			{
				if (property.PropertyContract == null)
				{
					property.PropertyContract = this.Serializer._contractResolver.ResolveContract(property.PropertyType);
				}
				memberValue = property.ValueProvider.GetValue(value);
				memberContract = (property.PropertyContract.IsSealed ? property.PropertyContract : this.GetContractSafe(memberValue));
				if (this.ShouldWriteProperty(memberValue, contract as global::Newtonsoft.Json.Serialization.JsonObjectContract, property))
				{
					if (this.ShouldWriteReference(memberValue, property, memberContract, contract, member))
					{
						property.WritePropertyName(writer);
						this.WriteReference(writer, memberValue);
						return false;
					}
					if (!this.CheckForCircularReference(writer, memberValue, property, memberContract, contract, member))
					{
						return false;
					}
					if (memberValue == null)
					{
						global::Newtonsoft.Json.Serialization.JsonObjectContract jsonObjectContract = contract as global::Newtonsoft.Json.Serialization.JsonObjectContract;
						global::Newtonsoft.Json.Required required = property._required ?? ((jsonObjectContract != null) ? jsonObjectContract.ItemRequired : null).GetValueOrDefault();
						if (required == global::Newtonsoft.Json.Required.Always)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(null, writer.ContainerPath, "Cannot write a null value for property '{0}'. Property requires a value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName), null);
						}
						if (required == global::Newtonsoft.Json.Required.DisallowNull)
						{
							throw global::Newtonsoft.Json.JsonSerializationException.Create(null, writer.ContainerPath, "Cannot write a null value for property '{0}'. Property requires a non-null value.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName), null);
						}
					}
					return true;
				}
			}
			memberContract = null;
			memberValue = null;
			return false;
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00021FA8 File Offset: 0x000201A8
		private void WriteObjectStart(global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.Serialization.JsonContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			writer.WriteStartObject();
			if ((this.ResolveIsReference(contract, member, collectionContract, containerProperty) ?? this.HasFlag(this.Serializer._preserveReferencesHandling, global::Newtonsoft.Json.PreserveReferencesHandling.Objects)) && (member == null || member.Writable || this.HasCreatorParameter(collectionContract, member)))
			{
				this.WriteReferenceIdProperty(writer, contract.UnderlyingType, value);
			}
			if (this.ShouldWriteType(global::Newtonsoft.Json.TypeNameHandling.Objects, contract, member, collectionContract, containerProperty))
			{
				this.WriteTypeProperty(writer, contract.UnderlyingType);
			}
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00022034 File Offset: 0x00020234
		private bool HasCreatorParameter([global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract contract, global::Newtonsoft.Json.Serialization.JsonProperty property)
		{
			global::Newtonsoft.Json.Serialization.JsonObjectContract jsonObjectContract = contract as global::Newtonsoft.Json.Serialization.JsonObjectContract;
			return jsonObjectContract != null && jsonObjectContract.CreatorParameters.Contains(property.PropertyName);
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00022060 File Offset: 0x00020260
		private void WriteReferenceIdProperty(global::Newtonsoft.Json.JsonWriter writer, global::System.Type type, object value)
		{
			string reference = this.GetReference(writer, value);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "Writing object reference Id '{0}' for {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, reference, type)), null);
			}
			writer.WritePropertyName("$id", false);
			writer.WriteValue(reference);
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x000220CC File Offset: 0x000202CC
		private void WriteTypeProperty(global::Newtonsoft.Json.JsonWriter writer, global::System.Type type)
		{
			string typeName = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetTypeName(type, this.Serializer._typeNameAssemblyFormatHandling, this.Serializer._serializationBinder);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "Writing type name '{0}' for {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeName, type)), null);
			}
			writer.WritePropertyName("$type", false);
			writer.WriteValue(typeName);
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00022149 File Offset: 0x00020349
		private bool HasFlag(global::Newtonsoft.Json.DefaultValueHandling value, global::Newtonsoft.Json.DefaultValueHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00022151 File Offset: 0x00020351
		private bool HasFlag(global::Newtonsoft.Json.PreserveReferencesHandling value, global::Newtonsoft.Json.PreserveReferencesHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x060007AD RID: 1965 RVA: 0x00022159 File Offset: 0x00020359
		private bool HasFlag(global::Newtonsoft.Json.TypeNameHandling value, global::Newtonsoft.Json.TypeNameHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00022164 File Offset: 0x00020364
		private void SerializeConvertable(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.JsonConverter converter, object value, global::Newtonsoft.Json.Serialization.JsonContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			if (this.ShouldWriteReference(value, null, contract, collectionContract, containerProperty))
			{
				this.WriteReference(writer, value);
				return;
			}
			if (!this.CheckForCircularReference(writer, value, null, contract, collectionContract, containerProperty))
			{
				return;
			}
			this._serializeStack.Add(value);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "Started serializing {0} with converter {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType(), converter.GetType())), null);
			}
			converter.WriteJson(writer, value, this.GetInternalSerializer());
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Info)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Info, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "Finished serializing {0} with converter {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType(), converter.GetType())), null);
			}
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00022264 File Offset: 0x00020464
		private void SerializeList(global::Newtonsoft.Json.JsonWriter writer, global::System.Collections.IEnumerable values, global::Newtonsoft.Json.Serialization.JsonArrayContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			global::Newtonsoft.Json.Utilities.IWrappedCollection wrappedCollection = values as global::Newtonsoft.Json.Utilities.IWrappedCollection;
			object obj = (wrappedCollection != null) ? wrappedCollection.UnderlyingCollection : values;
			this.OnSerializing(writer, contract, obj);
			this._serializeStack.Add(obj);
			bool flag = this.WriteStartArray(writer, obj, contract, member, collectionContract, containerProperty);
			writer.WriteStartArray();
			int top = writer.Top;
			int num = 0;
			foreach (object value in values)
			{
				try
				{
					global::Newtonsoft.Json.Serialization.JsonContract jsonContract = contract.FinalItemContract ?? this.GetContractSafe(value);
					if (this.ShouldWriteReference(value, null, jsonContract, contract, member))
					{
						this.WriteReference(writer, value);
					}
					else if (this.CheckForCircularReference(writer, value, null, jsonContract, contract, member))
					{
						this.SerializeValue(writer, value, jsonContract, null, contract, member);
					}
				}
				catch (global::System.Exception ex)
				{
					if (!base.IsErrorHandled(obj, contract, num, null, writer.ContainerPath, ex))
					{
						throw;
					}
					this.HandleError(writer, top);
				}
				finally
				{
					num++;
				}
			}
			writer.WriteEndArray();
			if (flag)
			{
				writer.WriteEndObject();
			}
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, obj);
		}

		// Token: 0x060007B0 RID: 1968 RVA: 0x000223D0 File Offset: 0x000205D0
		private void SerializeMultidimensionalArray(global::Newtonsoft.Json.JsonWriter writer, global::System.Array values, global::Newtonsoft.Json.Serialization.JsonArrayContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			this.OnSerializing(writer, contract, values);
			this._serializeStack.Add(values);
			bool flag = this.WriteStartArray(writer, values, contract, member, collectionContract, containerProperty);
			this.SerializeMultidimensionalArray(writer, values, contract, member, writer.Top, global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<int>());
			if (flag)
			{
				writer.WriteEndObject();
			}
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, values);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00022440 File Offset: 0x00020640
		private void SerializeMultidimensionalArray(global::Newtonsoft.Json.JsonWriter writer, global::System.Array values, global::Newtonsoft.Json.Serialization.JsonArrayContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, int initialDepth, int[] indices)
		{
			int num = indices.Length;
			int[] array = new int[num + 1];
			for (int i = 0; i < num; i++)
			{
				array[i] = indices[i];
			}
			writer.WriteStartArray();
			int j = values.GetLowerBound(num);
			while (j <= values.GetUpperBound(num))
			{
				array[num] = j;
				if (array.Length == values.Rank)
				{
					object value = values.GetValue(array);
					try
					{
						global::Newtonsoft.Json.Serialization.JsonContract jsonContract = contract.FinalItemContract ?? this.GetContractSafe(value);
						if (this.ShouldWriteReference(value, null, jsonContract, contract, member))
						{
							this.WriteReference(writer, value);
						}
						else if (this.CheckForCircularReference(writer, value, null, jsonContract, contract, member))
						{
							this.SerializeValue(writer, value, jsonContract, null, contract, member);
						}
						goto IL_DE;
					}
					catch (global::System.Exception ex)
					{
						if (base.IsErrorHandled(values, contract, j, null, writer.ContainerPath, ex))
						{
							this.HandleError(writer, initialDepth + 1);
							goto IL_DE;
						}
						throw;
					}
					goto IL_CE;
				}
				goto IL_CE;
				IL_DE:
				j++;
				continue;
				IL_CE:
				this.SerializeMultidimensionalArray(writer, values, contract, member, initialDepth + 1, array);
				goto IL_DE;
			}
			writer.WriteEndArray();
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00022554 File Offset: 0x00020754
		private bool WriteStartArray(global::Newtonsoft.Json.JsonWriter writer, object values, global::Newtonsoft.Json.Serialization.JsonArrayContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			bool flag = this.ResolveIsReference(contract, member, containerContract, containerProperty) ?? this.HasFlag(this.Serializer._preserveReferencesHandling, global::Newtonsoft.Json.PreserveReferencesHandling.Arrays);
			flag = (flag && (member == null || member.Writable || this.HasCreatorParameter(containerContract, member)));
			bool flag2 = this.ShouldWriteType(global::Newtonsoft.Json.TypeNameHandling.Arrays, contract, member, containerContract, containerProperty);
			bool flag3 = flag || flag2;
			if (flag3)
			{
				writer.WriteStartObject();
				if (flag)
				{
					this.WriteReferenceIdProperty(writer, contract.UnderlyingType, values);
				}
				if (flag2)
				{
					this.WriteTypeProperty(writer, values.GetType());
				}
				writer.WritePropertyName("$values", false);
			}
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.Serializer._contractResolver.ResolveContract(contract.CollectionItemType ?? typeof(object));
			}
			return flag3;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00022630 File Offset: 0x00020830
		[global::System.Security.SecuritySafeCritical]
		private void SerializeISerializable(global::Newtonsoft.Json.JsonWriter writer, global::System.Runtime.Serialization.ISerializable value, global::Newtonsoft.Json.Serialization.JsonISerializableContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			if (!global::Newtonsoft.Json.Serialization.JsonTypeReflector.FullyTrusted)
			{
				string text = "Type '{0}' implements ISerializable but cannot be serialized using the ISerializable interface because the current application is not fully trusted and ISerializable can expose secure data." + global::System.Environment.NewLine + "To fix this error either change the environment to be fully trusted, change the application to not deserialize the type, add JsonObjectAttribute to the type or change the JsonSerializer setting ContractResolver to use a new DefaultContractResolver with IgnoreSerializableInterface set to true." + global::System.Environment.NewLine;
				text = text.FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value.GetType());
				throw global::Newtonsoft.Json.JsonSerializationException.Create(null, writer.ContainerPath, text, null);
			}
			this.OnSerializing(writer, contract, value);
			this._serializeStack.Add(value);
			this.WriteObjectStart(writer, value, contract, member, collectionContract, containerProperty);
			global::System.Runtime.Serialization.SerializationInfo serializationInfo = new global::System.Runtime.Serialization.SerializationInfo(contract.UnderlyingType, new global::System.Runtime.Serialization.FormatterConverter());
			value.GetObjectData(serializationInfo, this.Serializer._context);
			foreach (global::System.Runtime.Serialization.SerializationEntry serializationEntry in serializationInfo)
			{
				global::Newtonsoft.Json.Serialization.JsonContract contractSafe = this.GetContractSafe(serializationEntry.Value);
				if (this.ShouldWriteReference(serializationEntry.Value, null, contractSafe, contract, member))
				{
					writer.WritePropertyName(serializationEntry.Name);
					this.WriteReference(writer, serializationEntry.Value);
				}
				else if (this.CheckForCircularReference(writer, serializationEntry.Value, null, contractSafe, contract, member))
				{
					writer.WritePropertyName(serializationEntry.Name);
					this.SerializeValue(writer, serializationEntry.Value, contractSafe, null, contract, member);
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, value);
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00022780 File Offset: 0x00020980
		private void SerializeDynamic(global::Newtonsoft.Json.JsonWriter writer, global::System.Dynamic.IDynamicMetaObjectProvider value, global::Newtonsoft.Json.Serialization.JsonDynamicContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			this.OnSerializing(writer, contract, value);
			this._serializeStack.Add(value);
			this.WriteObjectStart(writer, value, contract, member, collectionContract, containerProperty);
			int top = writer.Top;
			for (int i = 0; i < contract.Properties.Count; i++)
			{
				global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty = contract.Properties[i];
				if (jsonProperty.HasMemberAttribute)
				{
					try
					{
						global::Newtonsoft.Json.Serialization.JsonContract valueContract;
						object value2;
						if (this.CalculatePropertyValues(writer, value, contract, member, jsonProperty, out valueContract, out value2))
						{
							jsonProperty.WritePropertyName(writer);
							this.SerializeValue(writer, value2, valueContract, jsonProperty, contract, member);
						}
					}
					catch (global::System.Exception ex)
					{
						if (!base.IsErrorHandled(value, contract, jsonProperty.PropertyName, null, writer.ContainerPath, ex))
						{
							throw;
						}
						this.HandleError(writer, top);
					}
				}
			}
			foreach (string text in value.GetDynamicMemberNames())
			{
				object obj;
				if (contract.TryGetMember(value, text, out obj))
				{
					try
					{
						global::Newtonsoft.Json.Serialization.JsonContract contractSafe = this.GetContractSafe(obj);
						if (this.ShouldWriteDynamicProperty(obj))
						{
							if (this.CheckForCircularReference(writer, obj, null, contractSafe, contract, member))
							{
								string name = (contract.PropertyNameResolver != null) ? contract.PropertyNameResolver(text) : text;
								writer.WritePropertyName(name);
								this.SerializeValue(writer, obj, contractSafe, null, contract, member);
							}
						}
					}
					catch (global::System.Exception ex2)
					{
						if (!base.IsErrorHandled(value, contract, text, null, writer.ContainerPath, ex2))
						{
							throw;
						}
						this.HandleError(writer, top);
					}
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, value);
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x0002294C File Offset: 0x00020B4C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool ShouldWriteDynamicProperty(object memberValue)
		{
			return (this.Serializer._nullValueHandling != global::Newtonsoft.Json.NullValueHandling.Ignore || memberValue != null) && (!this.HasFlag(this.Serializer._defaultValueHandling, global::Newtonsoft.Json.DefaultValueHandling.Ignore) || (memberValue != null && !global::Newtonsoft.Json.Utilities.MiscellaneousUtils.ValueEquals(memberValue, global::Newtonsoft.Json.Utilities.ReflectionUtils.GetDefaultValue(memberValue.GetType()))));
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0002299C File Offset: 0x00020B9C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool ShouldWriteType(global::Newtonsoft.Json.TypeNameHandling typeNameHandlingFlag, [global::System.Runtime.CompilerServices.Nullable(1)] global::Newtonsoft.Json.Serialization.JsonContract contract, global::Newtonsoft.Json.Serialization.JsonProperty member, global::Newtonsoft.Json.Serialization.JsonContainerContract containerContract, global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			global::Newtonsoft.Json.TypeNameHandling value = ((member != null) ? member.TypeNameHandling : null) ?? (((containerProperty != null) ? containerProperty.ItemTypeNameHandling : null) ?? (((containerContract != null) ? containerContract.ItemTypeNameHandling : null) ?? this.Serializer._typeNameHandling));
			if (this.HasFlag(value, typeNameHandlingFlag))
			{
				return true;
			}
			if (this.HasFlag(value, global::Newtonsoft.Json.TypeNameHandling.Auto))
			{
				if (member != null)
				{
					if (contract.NonNullableUnderlyingType != member.PropertyContract.CreatedType)
					{
						return true;
					}
				}
				else if (containerContract != null)
				{
					if (containerContract.ItemContract == null || contract.NonNullableUnderlyingType != containerContract.ItemContract.CreatedType)
					{
						return true;
					}
				}
				else if (this._rootType != null && this._serializeStack.Count == this._rootLevel)
				{
					global::Newtonsoft.Json.Serialization.JsonContract jsonContract = this.Serializer._contractResolver.ResolveContract(this._rootType);
					if (contract.NonNullableUnderlyingType != jsonContract.CreatedType)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00022AE0 File Offset: 0x00020CE0
		private void SerializeDictionary(global::Newtonsoft.Json.JsonWriter writer, global::System.Collections.IDictionary values, global::Newtonsoft.Json.Serialization.JsonDictionaryContract contract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty member, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonContainerContract collectionContract, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Serialization.JsonProperty containerProperty)
		{
			global::Newtonsoft.Json.Utilities.IWrappedDictionary wrappedDictionary = values as global::Newtonsoft.Json.Utilities.IWrappedDictionary;
			object obj = (wrappedDictionary != null) ? wrappedDictionary.UnderlyingDictionary : values;
			this.OnSerializing(writer, contract, obj);
			this._serializeStack.Add(obj);
			this.WriteObjectStart(writer, obj, contract, member, collectionContract, containerProperty);
			if (contract.ItemContract == null)
			{
				contract.ItemContract = this.Serializer._contractResolver.ResolveContract(contract.DictionaryValueType ?? typeof(object));
			}
			if (contract.KeyContract == null)
			{
				contract.KeyContract = this.Serializer._contractResolver.ResolveContract(contract.DictionaryKeyType ?? typeof(object));
			}
			int top = writer.Top;
			using (global::System.Collections.IDictionaryEnumerator enumerator = values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Collections.DictionaryEntry entry = enumerator.Entry;
					bool escape;
					string text = this.GetPropertyName(writer, entry.Key, contract.KeyContract, out escape);
					text = ((contract.DictionaryKeyResolver != null) ? contract.DictionaryKeyResolver(text) : text);
					try
					{
						object value = entry.Value;
						global::Newtonsoft.Json.Serialization.JsonContract jsonContract = contract.FinalItemContract ?? this.GetContractSafe(value);
						if (this.ShouldWriteReference(value, null, jsonContract, contract, member))
						{
							writer.WritePropertyName(text, escape);
							this.WriteReference(writer, value);
						}
						else if (this.CheckForCircularReference(writer, value, null, jsonContract, contract, member))
						{
							writer.WritePropertyName(text, escape);
							this.SerializeValue(writer, value, jsonContract, null, contract, member);
						}
					}
					catch (global::System.Exception ex)
					{
						if (!base.IsErrorHandled(obj, contract, text, null, writer.ContainerPath, ex))
						{
							throw;
						}
						this.HandleError(writer, top);
					}
				}
			}
			writer.WriteEndObject();
			this._serializeStack.RemoveAt(this._serializeStack.Count - 1);
			this.OnSerialized(writer, contract, obj);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00022CD0 File Offset: 0x00020ED0
		private string GetPropertyName(global::Newtonsoft.Json.JsonWriter writer, object name, global::Newtonsoft.Json.Serialization.JsonContract contract, out bool escape)
		{
			if (contract.ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Primitive)
			{
				global::Newtonsoft.Json.Serialization.JsonPrimitiveContract jsonPrimitiveContract = (global::Newtonsoft.Json.Serialization.JsonPrimitiveContract)contract;
				switch (jsonPrimitiveContract.TypeCode)
				{
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single:
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SingleNullable:
				{
					float num = (float)name;
					escape = false;
					return num.ToString("R", global::System.Globalization.CultureInfo.InvariantCulture);
				}
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double:
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DoubleNullable:
				{
					double num2 = (double)name;
					escape = false;
					return num2.ToString("R", global::System.Globalization.CultureInfo.InvariantCulture);
				}
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime:
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeNullable:
				{
					global::System.DateTime value = global::Newtonsoft.Json.Utilities.DateTimeUtils.EnsureDateTime((global::System.DateTime)name, writer.DateTimeZoneHandling);
					escape = false;
					global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture);
					global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeString(stringWriter, value, writer.DateFormatHandling, writer.DateFormatString, writer.Culture);
					return stringWriter.ToString();
				}
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset:
				case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffsetNullable:
				{
					escape = false;
					global::System.IO.StringWriter stringWriter2 = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture);
					global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeOffsetString(stringWriter2, (global::System.DateTimeOffset)name, writer.DateFormatHandling, writer.DateFormatString, writer.Culture);
					return stringWriter2.ToString();
				}
				default:
				{
					escape = true;
					string result;
					if (jsonPrimitiveContract.IsEnum && global::Newtonsoft.Json.Utilities.EnumUtils.TryToString(jsonPrimitiveContract.NonNullableUnderlyingType, name, null, out result))
					{
						return result;
					}
					return global::System.Convert.ToString(name, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				}
			}
			else
			{
				string result2;
				if (global::Newtonsoft.Json.Serialization.JsonSerializerInternalWriter.TryConvertToString(name, name.GetType(), out result2))
				{
					escape = true;
					return result2;
				}
				escape = true;
				return name.ToString();
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00022E1E File Offset: 0x0002101E
		private void HandleError(global::Newtonsoft.Json.JsonWriter writer, int initialDepth)
		{
			base.ClearErrorContext();
			if (writer.WriteState == global::Newtonsoft.Json.WriteState.Property)
			{
				writer.WriteNull();
			}
			while (writer.Top > initialDepth)
			{
				writer.WriteEnd();
			}
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00022E48 File Offset: 0x00021048
		private bool ShouldSerialize(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Serialization.JsonProperty property, object target)
		{
			if (property.ShouldSerialize == null)
			{
				return true;
			}
			bool flag = property.ShouldSerialize(target);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "ShouldSerialize result for property '{0}' on {1}: {2}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType, flag)), null);
			}
			return flag;
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00022EC0 File Offset: 0x000210C0
		private bool IsSpecified(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Serialization.JsonProperty property, object target)
		{
			if (property.GetIsSpecified == null)
			{
				return true;
			}
			bool flag = property.GetIsSpecified(target);
			if (this.TraceWriter != null && this.TraceWriter.LevelFilter >= global::System.Diagnostics.TraceLevel.Verbose)
			{
				this.TraceWriter.Trace(global::System.Diagnostics.TraceLevel.Verbose, global::Newtonsoft.Json.JsonPosition.FormatMessage(null, writer.Path, "IsSpecified result for property '{0}' on {1}: {2}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, property.PropertyName, property.DeclaringType, flag)), null);
			}
			return flag;
		}

		// Token: 0x040002AF RID: 687
		[global::System.Runtime.CompilerServices.Nullable(2)]
		private global::System.Type _rootType;

		// Token: 0x040002B0 RID: 688
		private int _rootLevel;

		// Token: 0x040002B1 RID: 689
		private readonly global::System.Collections.Generic.List<object> _serializeStack = new global::System.Collections.Generic.List<object>();
	}
}
