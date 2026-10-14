using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000AA RID: 170
	[global::System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonSchemaGenerator
	{
		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x00025F19 File Offset: 0x00024119
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x00025F21 File Offset: 0x00024121
		public global::Newtonsoft.Json.Schema.UndefinedSchemaIdHandling UndefinedSchemaIdHandling { get; set; }

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x00025F2A File Offset: 0x0002412A
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x00025F40 File Offset: 0x00024140
		public global::Newtonsoft.Json.Serialization.IContractResolver ContractResolver
		{
			get
			{
				if (this._contractResolver == null)
				{
					return global::Newtonsoft.Json.Serialization.DefaultContractResolver.Instance;
				}
				return this._contractResolver;
			}
			set
			{
				this._contractResolver = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00025F49 File Offset: 0x00024149
		private global::Newtonsoft.Json.Schema.JsonSchema CurrentSchema
		{
			get
			{
				return this._currentSchema;
			}
		}

		// Token: 0x06000903 RID: 2307 RVA: 0x00025F51 File Offset: 0x00024151
		private void Push(global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema typeSchema)
		{
			this._currentSchema = typeSchema.Schema;
			this._stack.Add(typeSchema);
			this._resolver.LoadedSchemas.Add(typeSchema.Schema);
		}

		// Token: 0x06000904 RID: 2308 RVA: 0x00025F84 File Offset: 0x00024184
		private global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema Pop()
		{
			global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema result = this._stack[this._stack.Count - 1];
			this._stack.RemoveAt(this._stack.Count - 1);
			global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema typeSchema = this._stack.LastOrDefault<global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema>();
			if (typeSchema != null)
			{
				this._currentSchema = typeSchema.Schema;
				return result;
			}
			this._currentSchema = null;
			return result;
		}

		// Token: 0x06000905 RID: 2309 RVA: 0x00025FE4 File Offset: 0x000241E4
		public global::Newtonsoft.Json.Schema.JsonSchema Generate(global::System.Type type)
		{
			return this.Generate(type, new global::Newtonsoft.Json.Schema.JsonSchemaResolver(), false);
		}

		// Token: 0x06000906 RID: 2310 RVA: 0x00025FF3 File Offset: 0x000241F3
		public global::Newtonsoft.Json.Schema.JsonSchema Generate(global::System.Type type, global::Newtonsoft.Json.Schema.JsonSchemaResolver resolver)
		{
			return this.Generate(type, resolver, false);
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00025FFE File Offset: 0x000241FE
		public global::Newtonsoft.Json.Schema.JsonSchema Generate(global::System.Type type, bool rootSchemaNullable)
		{
			return this.Generate(type, new global::Newtonsoft.Json.Schema.JsonSchemaResolver(), rootSchemaNullable);
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x0002600D File Offset: 0x0002420D
		public global::Newtonsoft.Json.Schema.JsonSchema Generate(global::System.Type type, global::Newtonsoft.Json.Schema.JsonSchemaResolver resolver, bool rootSchemaNullable)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(resolver, "resolver");
			this._resolver = resolver;
			return this.GenerateInternal(type, (!rootSchemaNullable) ? global::Newtonsoft.Json.Required.Always : global::Newtonsoft.Json.Required.Default, false);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0002603C File Offset: 0x0002423C
		private string GetTitle(global::System.Type type)
		{
			global::Newtonsoft.Json.JsonContainerAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(type);
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty((cachedAttribute != null) ? cachedAttribute.Title : null))
			{
				return cachedAttribute.Title;
			}
			return null;
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x0002606C File Offset: 0x0002426C
		private string GetDescription(global::System.Type type)
		{
			global::Newtonsoft.Json.JsonContainerAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(type);
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty((cachedAttribute != null) ? cachedAttribute.Description : null))
			{
				return cachedAttribute.Description;
			}
			global::System.ComponentModel.DescriptionAttribute attribute = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetAttribute<global::System.ComponentModel.DescriptionAttribute>(type);
			if (attribute == null)
			{
				return null;
			}
			return attribute.Description;
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x000260AC File Offset: 0x000242AC
		private string GetTypeId(global::System.Type type, bool explicitOnly)
		{
			global::Newtonsoft.Json.JsonContainerAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonContainerAttribute>(type);
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty((cachedAttribute != null) ? cachedAttribute.Id : null))
			{
				return cachedAttribute.Id;
			}
			if (explicitOnly)
			{
				return null;
			}
			global::Newtonsoft.Json.Schema.UndefinedSchemaIdHandling undefinedSchemaIdHandling = this.UndefinedSchemaIdHandling;
			if (undefinedSchemaIdHandling == global::Newtonsoft.Json.Schema.UndefinedSchemaIdHandling.UseTypeName)
			{
				return type.FullName;
			}
			if (undefinedSchemaIdHandling != global::Newtonsoft.Json.Schema.UndefinedSchemaIdHandling.UseAssemblyQualifiedName)
			{
				return null;
			}
			return type.AssemblyQualifiedName;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00026100 File Offset: 0x00024300
		private global::Newtonsoft.Json.Schema.JsonSchema GenerateInternal(global::System.Type type, global::Newtonsoft.Json.Required valueRequired, bool required)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
			string typeId = this.GetTypeId(type, false);
			string typeId2 = this.GetTypeId(type, true);
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(typeId))
			{
				global::Newtonsoft.Json.Schema.JsonSchema schema = this._resolver.GetSchema(typeId);
				if (schema != null)
				{
					if (valueRequired != global::Newtonsoft.Json.Required.Always && !global::Newtonsoft.Json.Schema.JsonSchemaGenerator.HasFlag(schema.Type, global::Newtonsoft.Json.Schema.JsonSchemaType.Null))
					{
						schema.Type |= global::Newtonsoft.Json.Schema.JsonSchemaType.Null;
					}
					if (required)
					{
						bool? required2 = schema.Required;
						bool flag = true;
						if (!(required2.GetValueOrDefault() == flag & required2 != null))
						{
							schema.Required = new bool?(true);
						}
					}
					return schema;
				}
			}
			if (this._stack.Any((global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema tc) => tc.Type == type))
			{
				throw new global::Newtonsoft.Json.JsonException("Unresolved circular reference for type '{0}'. Explicitly define an Id for the type using a JsonObject/JsonArray attribute or automatically generate a type Id using the UndefinedSchemaIdHandling property.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
			}
			global::Newtonsoft.Json.Serialization.JsonContract jsonContract = this.ContractResolver.ResolveContract(type);
			bool flag2 = (jsonContract.Converter ?? jsonContract.InternalConverter) != null;
			this.Push(new global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema(type, new global::Newtonsoft.Json.Schema.JsonSchema()));
			if (typeId2 != null)
			{
				this.CurrentSchema.Id = typeId2;
			}
			if (required)
			{
				this.CurrentSchema.Required = new bool?(true);
			}
			this.CurrentSchema.Title = this.GetTitle(type);
			this.CurrentSchema.Description = this.GetDescription(type);
			if (flag2)
			{
				this.CurrentSchema.Type = new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.Any);
			}
			else
			{
				switch (jsonContract.ContractType)
				{
				case global::Newtonsoft.Json.Serialization.JsonContractType.Object:
					this.CurrentSchema.Type = new global::Newtonsoft.Json.Schema.JsonSchemaType?(this.AddNullType(global::Newtonsoft.Json.Schema.JsonSchemaType.Object, valueRequired));
					this.CurrentSchema.Id = this.GetTypeId(type, false);
					this.GenerateObjectSchema(type, (global::Newtonsoft.Json.Serialization.JsonObjectContract)jsonContract);
					break;
				case global::Newtonsoft.Json.Serialization.JsonContractType.Array:
				{
					this.CurrentSchema.Type = new global::Newtonsoft.Json.Schema.JsonSchemaType?(this.AddNullType(global::Newtonsoft.Json.Schema.JsonSchemaType.Array, valueRequired));
					this.CurrentSchema.Id = this.GetTypeId(type, false);
					global::Newtonsoft.Json.JsonArrayAttribute cachedAttribute = global::Newtonsoft.Json.Serialization.JsonTypeReflector.GetCachedAttribute<global::Newtonsoft.Json.JsonArrayAttribute>(type);
					bool flag3 = cachedAttribute == null || cachedAttribute.AllowNullItems;
					global::System.Type collectionItemType = global::Newtonsoft.Json.Utilities.ReflectionUtils.GetCollectionItemType(type);
					if (collectionItemType != null)
					{
						this.CurrentSchema.Items = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchema>();
						this.CurrentSchema.Items.Add(this.GenerateInternal(collectionItemType, (!flag3) ? global::Newtonsoft.Json.Required.Always : global::Newtonsoft.Json.Required.Default, false));
					}
					break;
				}
				case global::Newtonsoft.Json.Serialization.JsonContractType.Primitive:
				{
					this.CurrentSchema.Type = new global::Newtonsoft.Json.Schema.JsonSchemaType?(this.GetJsonSchemaType(type, valueRequired));
					global::Newtonsoft.Json.Schema.JsonSchemaType? type2 = this.CurrentSchema.Type;
					global::Newtonsoft.Json.Schema.JsonSchemaType jsonSchemaType = global::Newtonsoft.Json.Schema.JsonSchemaType.Integer;
					if ((type2.GetValueOrDefault() == jsonSchemaType & type2 != null) && type.IsEnum() && !type.IsDefined(typeof(global::System.FlagsAttribute), true))
					{
						this.CurrentSchema.Enum = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken>();
						global::Newtonsoft.Json.Utilities.EnumInfo enumValuesAndNames = global::Newtonsoft.Json.Utilities.EnumUtils.GetEnumValuesAndNames(type);
						for (int i = 0; i < enumValuesAndNames.Names.Length; i++)
						{
							ulong value = enumValuesAndNames.Values[i];
							global::Newtonsoft.Json.Linq.JToken item = global::Newtonsoft.Json.Linq.JToken.FromObject(global::System.Enum.ToObject(type, value));
							this.CurrentSchema.Enum.Add(item);
						}
					}
					break;
				}
				case global::Newtonsoft.Json.Serialization.JsonContractType.String:
				{
					global::Newtonsoft.Json.Schema.JsonSchemaType value2 = (!global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(jsonContract.UnderlyingType)) ? global::Newtonsoft.Json.Schema.JsonSchemaType.String : this.AddNullType(global::Newtonsoft.Json.Schema.JsonSchemaType.String, valueRequired);
					this.CurrentSchema.Type = new global::Newtonsoft.Json.Schema.JsonSchemaType?(value2);
					break;
				}
				case global::Newtonsoft.Json.Serialization.JsonContractType.Dictionary:
				{
					this.CurrentSchema.Type = new global::Newtonsoft.Json.Schema.JsonSchemaType?(this.AddNullType(global::Newtonsoft.Json.Schema.JsonSchemaType.Object, valueRequired));
					global::System.Type type3;
					global::System.Type type4;
					global::Newtonsoft.Json.Utilities.ReflectionUtils.GetDictionaryKeyValueTypes(type, out type3, out type4);
					if (type3 != null && this.ContractResolver.ResolveContract(type3).ContractType == global::Newtonsoft.Json.Serialization.JsonContractType.Primitive)
					{
						this.CurrentSchema.AdditionalProperties = this.GenerateInternal(type4, global::Newtonsoft.Json.Required.Default, false);
					}
					break;
				}
				case global::Newtonsoft.Json.Serialization.JsonContractType.Dynamic:
				case global::Newtonsoft.Json.Serialization.JsonContractType.Linq:
					this.CurrentSchema.Type = new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.Any);
					break;
				case global::Newtonsoft.Json.Serialization.JsonContractType.Serializable:
					this.CurrentSchema.Type = new global::Newtonsoft.Json.Schema.JsonSchemaType?(this.AddNullType(global::Newtonsoft.Json.Schema.JsonSchemaType.Object, valueRequired));
					this.CurrentSchema.Id = this.GetTypeId(type, false);
					this.GenerateISerializableContract(type, (global::Newtonsoft.Json.Serialization.JsonISerializableContract)jsonContract);
					break;
				default:
					throw new global::Newtonsoft.Json.JsonException("Unexpected contract type: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jsonContract));
				}
			}
			return this.Pop().Schema;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x000265BB File Offset: 0x000247BB
		private global::Newtonsoft.Json.Schema.JsonSchemaType AddNullType(global::Newtonsoft.Json.Schema.JsonSchemaType type, global::Newtonsoft.Json.Required valueRequired)
		{
			if (valueRequired != global::Newtonsoft.Json.Required.Always)
			{
				return type | global::Newtonsoft.Json.Schema.JsonSchemaType.Null;
			}
			return type;
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x000265C7 File Offset: 0x000247C7
		private bool HasFlag(global::Newtonsoft.Json.DefaultValueHandling value, global::Newtonsoft.Json.DefaultValueHandling flag)
		{
			return (value & flag) == flag;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x000265D0 File Offset: 0x000247D0
		private void GenerateObjectSchema(global::System.Type type, global::Newtonsoft.Json.Serialization.JsonObjectContract contract)
		{
			this.CurrentSchema.Properties = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchema>();
			foreach (global::Newtonsoft.Json.Serialization.JsonProperty jsonProperty in contract.Properties)
			{
				if (!jsonProperty.Ignored)
				{
					global::Newtonsoft.Json.NullValueHandling? nullValueHandling = jsonProperty.NullValueHandling;
					global::Newtonsoft.Json.NullValueHandling nullValueHandling2 = global::Newtonsoft.Json.NullValueHandling.Ignore;
					bool flag = (nullValueHandling.GetValueOrDefault() == nullValueHandling2 & nullValueHandling != null) || this.HasFlag(jsonProperty.DefaultValueHandling.GetValueOrDefault(), global::Newtonsoft.Json.DefaultValueHandling.Ignore) || jsonProperty.ShouldSerialize != null || jsonProperty.GetIsSpecified != null;
					global::Newtonsoft.Json.Schema.JsonSchema jsonSchema = this.GenerateInternal(jsonProperty.PropertyType, jsonProperty.Required, !flag);
					if (jsonProperty.DefaultValue != null)
					{
						jsonSchema.Default = global::Newtonsoft.Json.Linq.JToken.FromObject(jsonProperty.DefaultValue);
					}
					this.CurrentSchema.Properties.Add(jsonProperty.PropertyName, jsonSchema);
				}
			}
			if (type.IsSealed())
			{
				this.CurrentSchema.AllowAdditionalProperties = false;
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x000266E0 File Offset: 0x000248E0
		private void GenerateISerializableContract(global::System.Type type, global::Newtonsoft.Json.Serialization.JsonISerializableContract contract)
		{
			this.CurrentSchema.AllowAdditionalProperties = true;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x000266F0 File Offset: 0x000248F0
		internal static bool HasFlag(global::Newtonsoft.Json.Schema.JsonSchemaType? value, global::Newtonsoft.Json.Schema.JsonSchemaType flag)
		{
			if (value == null)
			{
				return true;
			}
			global::Newtonsoft.Json.Schema.JsonSchemaType? jsonSchemaType = value & flag;
			if (jsonSchemaType.GetValueOrDefault() == flag & jsonSchemaType != null)
			{
				return true;
			}
			if (flag == global::Newtonsoft.Json.Schema.JsonSchemaType.Integer)
			{
				jsonSchemaType = (value & global::Newtonsoft.Json.Schema.JsonSchemaType.Float);
				global::Newtonsoft.Json.Schema.JsonSchemaType jsonSchemaType2 = global::Newtonsoft.Json.Schema.JsonSchemaType.Float;
				if (jsonSchemaType.GetValueOrDefault() == jsonSchemaType2 & jsonSchemaType != null)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0002678C File Offset: 0x0002498C
		private global::Newtonsoft.Json.Schema.JsonSchemaType GetJsonSchemaType(global::System.Type type, global::Newtonsoft.Json.Required valueRequired)
		{
			global::Newtonsoft.Json.Schema.JsonSchemaType jsonSchemaType = global::Newtonsoft.Json.Schema.JsonSchemaType.None;
			if (valueRequired != global::Newtonsoft.Json.Required.Always && global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullable(type))
			{
				jsonSchemaType = global::Newtonsoft.Json.Schema.JsonSchemaType.Null;
				if (global::Newtonsoft.Json.Utilities.ReflectionUtils.IsNullableType(type))
				{
					type = global::System.Nullable.GetUnderlyingType(type);
				}
			}
			global::Newtonsoft.Json.Utilities.PrimitiveTypeCode typeCode = global::Newtonsoft.Json.Utilities.ConvertUtils.GetTypeCode(type);
			switch (typeCode)
			{
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Empty:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Object:
				return jsonSchemaType | global::Newtonsoft.Json.Schema.JsonSchemaType.String;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Char:
				return jsonSchemaType | global::Newtonsoft.Json.Schema.JsonSchemaType.String;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Boolean:
				return jsonSchemaType | global::Newtonsoft.Json.Schema.JsonSchemaType.Boolean;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.SByte:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int16:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt16:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int32:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Byte:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt32:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Int64:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.UInt64:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.BigInteger:
				return jsonSchemaType | global::Newtonsoft.Json.Schema.JsonSchemaType.Integer;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Single:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Double:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Decimal:
				return jsonSchemaType | global::Newtonsoft.Json.Schema.JsonSchemaType.Float;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTime:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DateTimeOffset:
				return jsonSchemaType | global::Newtonsoft.Json.Schema.JsonSchemaType.String;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Guid:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.TimeSpan:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Uri:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.String:
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.Bytes:
				return jsonSchemaType | global::Newtonsoft.Json.Schema.JsonSchemaType.String;
			case global::Newtonsoft.Json.Utilities.PrimitiveTypeCode.DBNull:
				return jsonSchemaType | global::Newtonsoft.Json.Schema.JsonSchemaType.Null;
			}
			throw new global::Newtonsoft.Json.JsonException("Unexpected type code '{0}' for type '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, typeCode, type));
		}

		// Token: 0x04000320 RID: 800
		private global::Newtonsoft.Json.Serialization.IContractResolver _contractResolver;

		// Token: 0x04000321 RID: 801
		private global::Newtonsoft.Json.Schema.JsonSchemaResolver _resolver;

		// Token: 0x04000322 RID: 802
		private readonly global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema> _stack = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaGenerator.TypeSchema>();

		// Token: 0x04000323 RID: 803
		private global::Newtonsoft.Json.Schema.JsonSchema _currentSchema;

		// Token: 0x020001AF RID: 431
		private class TypeSchema
		{
			// Token: 0x17000295 RID: 661
			// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00042D9F File Offset: 0x00040F9F
			public global::System.Type Type { get; }

			// Token: 0x17000296 RID: 662
			// (get) Token: 0x06000F43 RID: 3907 RVA: 0x00042DA7 File Offset: 0x00040FA7
			public global::Newtonsoft.Json.Schema.JsonSchema Schema { get; }

			// Token: 0x06000F44 RID: 3908 RVA: 0x00042DAF File Offset: 0x00040FAF
			public TypeSchema(global::System.Type type, global::Newtonsoft.Json.Schema.JsonSchema schema)
			{
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(type, "type");
				global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(schema, "schema");
				this.Type = type;
				this.Schema = schema;
			}
		}
	}
}
