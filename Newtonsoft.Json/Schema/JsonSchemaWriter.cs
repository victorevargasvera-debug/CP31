using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000B1 RID: 177
	[global::System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaWriter
	{
		// Token: 0x06000961 RID: 2401 RVA: 0x00027356 File Offset: 0x00025556
		public JsonSchemaWriter(global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Schema.JsonSchemaResolver resolver)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(writer, "writer");
			this._writer = writer;
			this._resolver = resolver;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00027378 File Offset: 0x00025578
		private void ReferenceOrWriteSchema(global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			if (schema.Id != null && this._resolver.GetSchema(schema.Id) != null)
			{
				this._writer.WriteStartObject();
				this._writer.WritePropertyName("$ref");
				this._writer.WriteValue(schema.Id);
				this._writer.WriteEndObject();
				return;
			}
			this.WriteSchema(schema);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x000273E0 File Offset: 0x000255E0
		public void WriteSchema(global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(schema, "schema");
			if (!this._resolver.LoadedSchemas.Contains(schema))
			{
				this._resolver.LoadedSchemas.Add(schema);
			}
			this._writer.WriteStartObject();
			this.WritePropertyIfNotNull(this._writer, "id", schema.Id);
			this.WritePropertyIfNotNull(this._writer, "title", schema.Title);
			this.WritePropertyIfNotNull(this._writer, "description", schema.Description);
			this.WritePropertyIfNotNull(this._writer, "required", schema.Required);
			this.WritePropertyIfNotNull(this._writer, "readonly", schema.ReadOnly);
			this.WritePropertyIfNotNull(this._writer, "hidden", schema.Hidden);
			this.WritePropertyIfNotNull(this._writer, "transient", schema.Transient);
			if (schema.Type != null)
			{
				this.WriteType("type", this._writer, schema.Type.GetValueOrDefault());
			}
			if (!schema.AllowAdditionalProperties)
			{
				this._writer.WritePropertyName("additionalProperties");
				this._writer.WriteValue(schema.AllowAdditionalProperties);
			}
			else if (schema.AdditionalProperties != null)
			{
				this._writer.WritePropertyName("additionalProperties");
				this.ReferenceOrWriteSchema(schema.AdditionalProperties);
			}
			if (!schema.AllowAdditionalItems)
			{
				this._writer.WritePropertyName("additionalItems");
				this._writer.WriteValue(schema.AllowAdditionalItems);
			}
			else if (schema.AdditionalItems != null)
			{
				this._writer.WritePropertyName("additionalItems");
				this.ReferenceOrWriteSchema(schema.AdditionalItems);
			}
			this.WriteSchemaDictionaryIfNotNull(this._writer, "properties", schema.Properties);
			this.WriteSchemaDictionaryIfNotNull(this._writer, "patternProperties", schema.PatternProperties);
			this.WriteItems(schema);
			this.WritePropertyIfNotNull(this._writer, "minimum", schema.Minimum);
			this.WritePropertyIfNotNull(this._writer, "maximum", schema.Maximum);
			this.WritePropertyIfNotNull(this._writer, "exclusiveMinimum", schema.ExclusiveMinimum);
			this.WritePropertyIfNotNull(this._writer, "exclusiveMaximum", schema.ExclusiveMaximum);
			this.WritePropertyIfNotNull(this._writer, "minLength", schema.MinimumLength);
			this.WritePropertyIfNotNull(this._writer, "maxLength", schema.MaximumLength);
			this.WritePropertyIfNotNull(this._writer, "minItems", schema.MinimumItems);
			this.WritePropertyIfNotNull(this._writer, "maxItems", schema.MaximumItems);
			this.WritePropertyIfNotNull(this._writer, "divisibleBy", schema.DivisibleBy);
			this.WritePropertyIfNotNull(this._writer, "format", schema.Format);
			this.WritePropertyIfNotNull(this._writer, "pattern", schema.Pattern);
			if (schema.Enum != null)
			{
				this._writer.WritePropertyName("enum");
				this._writer.WriteStartArray();
				foreach (global::Newtonsoft.Json.Linq.JToken jtoken in schema.Enum)
				{
					jtoken.WriteTo(this._writer, new global::Newtonsoft.Json.JsonConverter[0]);
				}
				this._writer.WriteEndArray();
			}
			if (schema.Default != null)
			{
				this._writer.WritePropertyName("default");
				schema.Default.WriteTo(this._writer, new global::Newtonsoft.Json.JsonConverter[0]);
			}
			if (schema.Disallow != null)
			{
				this.WriteType("disallow", this._writer, schema.Disallow.GetValueOrDefault());
			}
			if (schema.Extends != null && schema.Extends.Count > 0)
			{
				this._writer.WritePropertyName("extends");
				if (schema.Extends.Count == 1)
				{
					this.ReferenceOrWriteSchema(schema.Extends[0]);
				}
				else
				{
					this._writer.WriteStartArray();
					foreach (global::Newtonsoft.Json.Schema.JsonSchema schema2 in schema.Extends)
					{
						this.ReferenceOrWriteSchema(schema2);
					}
					this._writer.WriteEndArray();
				}
			}
			this._writer.WriteEndObject();
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x00027888 File Offset: 0x00025A88
		private void WriteSchemaDictionaryIfNotNull(global::Newtonsoft.Json.JsonWriter writer, string propertyName, global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Schema.JsonSchema> properties)
		{
			if (properties != null)
			{
				writer.WritePropertyName(propertyName);
				writer.WriteStartObject();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchema> keyValuePair in properties)
				{
					writer.WritePropertyName(keyValuePair.Key);
					this.ReferenceOrWriteSchema(keyValuePair.Value);
				}
				writer.WriteEndObject();
			}
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000278FC File Offset: 0x00025AFC
		private void WriteItems(global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			if (schema.Items == null && !schema.PositionalItemsValidation)
			{
				return;
			}
			this._writer.WritePropertyName("items");
			if (schema.PositionalItemsValidation)
			{
				this._writer.WriteStartArray();
				if (schema.Items != null)
				{
					foreach (global::Newtonsoft.Json.Schema.JsonSchema schema2 in schema.Items)
					{
						this.ReferenceOrWriteSchema(schema2);
					}
				}
				this._writer.WriteEndArray();
				return;
			}
			if (schema.Items != null && schema.Items.Count > 0)
			{
				this.ReferenceOrWriteSchema(schema.Items[0]);
				return;
			}
			this._writer.WriteStartObject();
			this._writer.WriteEndObject();
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000279D0 File Offset: 0x00025BD0
		private void WriteType(string propertyName, global::Newtonsoft.Json.JsonWriter writer, global::Newtonsoft.Json.Schema.JsonSchemaType type)
		{
			if (global::System.Enum.IsDefined(typeof(global::Newtonsoft.Json.Schema.JsonSchemaType), type))
			{
				writer.WritePropertyName(propertyName);
				writer.WriteValue(global::Newtonsoft.Json.Schema.JsonSchemaBuilder.MapType(type));
				return;
			}
			global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Schema.JsonSchemaType> enumerator = (from v in global::Newtonsoft.Json.Utilities.EnumUtils.GetFlagsValues<global::Newtonsoft.Json.Schema.JsonSchemaType>(type)
			where v > global::Newtonsoft.Json.Schema.JsonSchemaType.None
			select v).GetEnumerator();
			if (enumerator.MoveNext())
			{
				writer.WritePropertyName(propertyName);
				global::Newtonsoft.Json.Schema.JsonSchemaType type2 = enumerator.Current;
				if (enumerator.MoveNext())
				{
					writer.WriteStartArray();
					writer.WriteValue(global::Newtonsoft.Json.Schema.JsonSchemaBuilder.MapType(type2));
					do
					{
						writer.WriteValue(global::Newtonsoft.Json.Schema.JsonSchemaBuilder.MapType(enumerator.Current));
					}
					while (enumerator.MoveNext());
					writer.WriteEndArray();
					return;
				}
				writer.WriteValue(global::Newtonsoft.Json.Schema.JsonSchemaBuilder.MapType(type2));
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00027A94 File Offset: 0x00025C94
		private void WritePropertyIfNotNull(global::Newtonsoft.Json.JsonWriter writer, string propertyName, object value)
		{
			if (value != null)
			{
				writer.WritePropertyName(propertyName);
				writer.WriteValue(value);
			}
		}

		// Token: 0x04000350 RID: 848
		private readonly global::Newtonsoft.Json.JsonWriter _writer;

		// Token: 0x04000351 RID: 849
		private readonly global::Newtonsoft.Json.Schema.JsonSchemaResolver _resolver;
	}
}
