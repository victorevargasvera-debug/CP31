using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Schema
{
	// Token: 0x020000A7 RID: 167
	[global::System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	internal class JsonSchemaBuilder
	{
		// Token: 0x060008E3 RID: 2275 RVA: 0x00024D5D File Offset: 0x00022F5D
		public JsonSchemaBuilder(global::Newtonsoft.Json.Schema.JsonSchemaResolver resolver)
		{
			this._stack = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchema>();
			this._documentSchemas = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchema>();
			this._resolver = resolver;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00024D82 File Offset: 0x00022F82
		private void Push(global::Newtonsoft.Json.Schema.JsonSchema value)
		{
			this._currentSchema = value;
			this._stack.Add(value);
			this._resolver.LoadedSchemas.Add(value);
			this._documentSchemas.Add(value.Location, value);
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00024DBA File Offset: 0x00022FBA
		private global::Newtonsoft.Json.Schema.JsonSchema Pop()
		{
			global::Newtonsoft.Json.Schema.JsonSchema currentSchema = this._currentSchema;
			this._stack.RemoveAt(this._stack.Count - 1);
			this._currentSchema = this._stack.LastOrDefault<global::Newtonsoft.Json.Schema.JsonSchema>();
			return currentSchema;
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x00024DEB File Offset: 0x00022FEB
		private global::Newtonsoft.Json.Schema.JsonSchema CurrentSchema
		{
			get
			{
				return this._currentSchema;
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00024DF4 File Offset: 0x00022FF4
		internal global::Newtonsoft.Json.Schema.JsonSchema Read(global::Newtonsoft.Json.JsonReader reader)
		{
			global::Newtonsoft.Json.Linq.JToken jtoken = global::Newtonsoft.Json.Linq.JToken.ReadFrom(reader);
			this._rootSchema = (jtoken as global::Newtonsoft.Json.Linq.JObject);
			global::Newtonsoft.Json.Schema.JsonSchema jsonSchema = this.BuildSchema(jtoken);
			this.ResolveReferences(jsonSchema);
			return jsonSchema;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00024E25 File Offset: 0x00023025
		private string UnescapeReference(string reference)
		{
			return global::System.Uri.UnescapeDataString(reference).Replace("~1", "/").Replace("~0", "~");
		}

		// Token: 0x060008E9 RID: 2281 RVA: 0x00024E4C File Offset: 0x0002304C
		private global::Newtonsoft.Json.Schema.JsonSchema ResolveReferences(global::Newtonsoft.Json.Schema.JsonSchema schema)
		{
			if (schema.DeferredReference != null)
			{
				string text = schema.DeferredReference;
				bool flag = text.StartsWith("#", global::System.StringComparison.Ordinal);
				if (flag)
				{
					text = this.UnescapeReference(text);
				}
				global::Newtonsoft.Json.Schema.JsonSchema jsonSchema = this._resolver.GetSchema(text);
				if (jsonSchema == null)
				{
					if (flag)
					{
						string[] array = schema.DeferredReference.TrimStart(new char[]
						{
							'#'
						}).Split(new char[]
						{
							'/'
						}, global::System.StringSplitOptions.RemoveEmptyEntries);
						global::Newtonsoft.Json.Linq.JToken jtoken = this._rootSchema;
						foreach (string reference in array)
						{
							string text2 = this.UnescapeReference(reference);
							if (jtoken.Type == global::Newtonsoft.Json.Linq.JTokenType.Object)
							{
								jtoken = jtoken[text2];
							}
							else if (jtoken.Type == global::Newtonsoft.Json.Linq.JTokenType.Array || jtoken.Type == global::Newtonsoft.Json.Linq.JTokenType.Constructor)
							{
								int num;
								if (int.TryParse(text2, out num) && num >= 0 && num < jtoken.Count<global::Newtonsoft.Json.Linq.JToken>())
								{
									jtoken = jtoken[num];
								}
								else
								{
									jtoken = null;
								}
							}
							if (jtoken == null)
							{
								break;
							}
						}
						if (jtoken != null)
						{
							jsonSchema = this.BuildSchema(jtoken);
						}
					}
					if (jsonSchema == null)
					{
						throw new global::Newtonsoft.Json.JsonException("Could not resolve schema reference '{0}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, schema.DeferredReference));
					}
				}
				schema = jsonSchema;
			}
			if (schema.ReferencesResolved)
			{
				return schema;
			}
			schema.ReferencesResolved = true;
			if (schema.Extends != null)
			{
				for (int j = 0; j < schema.Extends.Count; j++)
				{
					schema.Extends[j] = this.ResolveReferences(schema.Extends[j]);
				}
			}
			if (schema.Items != null)
			{
				for (int k = 0; k < schema.Items.Count; k++)
				{
					schema.Items[k] = this.ResolveReferences(schema.Items[k]);
				}
			}
			if (schema.AdditionalItems != null)
			{
				schema.AdditionalItems = this.ResolveReferences(schema.AdditionalItems);
			}
			if (schema.PatternProperties != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchema> keyValuePair in schema.PatternProperties.ToList<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchema>>())
				{
					schema.PatternProperties[keyValuePair.Key] = this.ResolveReferences(keyValuePair.Value);
				}
			}
			if (schema.Properties != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchema> keyValuePair2 in schema.Properties.ToList<global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchema>>())
				{
					schema.Properties[keyValuePair2.Key] = this.ResolveReferences(keyValuePair2.Value);
				}
			}
			if (schema.AdditionalProperties != null)
			{
				schema.AdditionalProperties = this.ResolveReferences(schema.AdditionalProperties);
			}
			return schema;
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00025114 File Offset: 0x00023314
		private global::Newtonsoft.Json.Schema.JsonSchema BuildSchema(global::Newtonsoft.Json.Linq.JToken token)
		{
			global::Newtonsoft.Json.Linq.JObject jobject = token as global::Newtonsoft.Json.Linq.JObject;
			if (jobject == null)
			{
				throw global::Newtonsoft.Json.JsonException.Create(token, token.Path, "Expected object while parsing schema object, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.Type));
			}
			global::Newtonsoft.Json.Linq.JToken value;
			if (jobject.TryGetValue("$ref", out value))
			{
				return new global::Newtonsoft.Json.Schema.JsonSchema
				{
					DeferredReference = (string)value
				};
			}
			string text = token.Path.Replace(".", "/").Replace("[", "/").Replace("]", string.Empty);
			if (!global::Newtonsoft.Json.Utilities.StringUtils.IsNullOrEmpty(text))
			{
				text = "/" + text;
			}
			text = "#" + text;
			global::Newtonsoft.Json.Schema.JsonSchema result;
			if (this._documentSchemas.TryGetValue(text, out result))
			{
				return result;
			}
			this.Push(new global::Newtonsoft.Json.Schema.JsonSchema
			{
				Location = text
			});
			this.ProcessSchemaProperties(jobject);
			return this.Pop();
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x000251F8 File Offset: 0x000233F8
		private void ProcessSchemaProperties(global::Newtonsoft.Json.Linq.JObject schemaObject)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Linq.JToken> keyValuePair in schemaObject)
			{
				string key = keyValuePair.Key;
				uint num = global::<PrivateImplementationDetails>.ComputeStringHash(key);
				if (num <= 2223801888U)
				{
					if (num <= 981021583U)
					{
						if (num <= 353304077U)
						{
							if (num != 299789532U)
							{
								if (num != 334560121U)
								{
									if (num == 353304077U)
									{
										if (key == "divisibleBy")
										{
											this.CurrentSchema.DivisibleBy = new double?((double)keyValuePair.Value);
										}
									}
								}
								else if (key == "minItems")
								{
									this.CurrentSchema.MinimumItems = new int?((int)keyValuePair.Value);
								}
							}
							else if (key == "properties")
							{
								this.CurrentSchema.Properties = this.ProcessProperties(keyValuePair.Value);
							}
						}
						else if (num <= 879704937U)
						{
							if (num != 479998177U)
							{
								if (num == 879704937U)
								{
									if (key == "description")
									{
										this.CurrentSchema.Description = (string)keyValuePair.Value;
									}
								}
							}
							else if (key == "additionalProperties")
							{
								this.ProcessAdditionalProperties(keyValuePair.Value);
							}
						}
						else if (num != 926444256U)
						{
							if (num == 981021583U)
							{
								if (key == "items")
								{
									this.ProcessItems(keyValuePair.Value);
								}
							}
						}
						else if (key == "id")
						{
							this.CurrentSchema.Id = (string)keyValuePair.Value;
						}
					}
					else if (num <= 1693958795U)
					{
						if (num != 1361572173U)
						{
							if (num != 1542649473U)
							{
								if (num == 1693958795U)
								{
									if (key == "exclusiveMaximum")
									{
										this.CurrentSchema.ExclusiveMaximum = new bool?((bool)keyValuePair.Value);
									}
								}
							}
							else if (key == "maximum")
							{
								this.CurrentSchema.Maximum = new double?((double)keyValuePair.Value);
							}
						}
						else if (key == "type")
						{
							this.CurrentSchema.Type = this.ProcessType(keyValuePair.Value);
						}
					}
					else if (num <= 2051482624U)
					{
						if (num != 1913005517U)
						{
							if (num == 2051482624U)
							{
								if (key == "additionalItems")
								{
									this.ProcessAdditionalItems(keyValuePair.Value);
								}
							}
						}
						else if (key == "exclusiveMinimum")
						{
							this.CurrentSchema.ExclusiveMinimum = new bool?((bool)keyValuePair.Value);
						}
					}
					else if (num != 2171383808U)
					{
						if (num == 2223801888U)
						{
							if (key == "required")
							{
								this.CurrentSchema.Required = new bool?((bool)keyValuePair.Value);
							}
						}
					}
					else if (key == "enum")
					{
						this.ProcessEnum(keyValuePair.Value);
					}
				}
				else if (num <= 2692244416U)
				{
					if (num <= 2474713847U)
					{
						if (num != 2268922153U)
						{
							if (num != 2470140894U)
							{
								if (num == 2474713847U)
								{
									if (key == "minimum")
									{
										this.CurrentSchema.Minimum = new double?((double)keyValuePair.Value);
									}
								}
							}
							else if (key == "default")
							{
								this.CurrentSchema.Default = keyValuePair.Value.DeepClone();
							}
						}
						else if (key == "pattern")
						{
							this.CurrentSchema.Pattern = (string)keyValuePair.Value;
						}
					}
					else if (num <= 2609687125U)
					{
						if (num != 2556802313U)
						{
							if (num == 2609687125U)
							{
								if (key == "requires")
								{
									this.CurrentSchema.Requires = (string)keyValuePair.Value;
								}
							}
						}
						else if (key == "title")
						{
							this.CurrentSchema.Title = (string)keyValuePair.Value;
						}
					}
					else if (num != 2642794062U)
					{
						if (num == 2692244416U)
						{
							if (key == "disallow")
							{
								this.CurrentSchema.Disallow = this.ProcessType(keyValuePair.Value);
							}
						}
					}
					else if (key == "extends")
					{
						this.ProcessExtends(keyValuePair.Value);
					}
				}
				else if (num <= 3522602594U)
				{
					if (num <= 3114108242U)
					{
						if (num != 2957261815U)
						{
							if (num == 3114108242U)
							{
								if (key == "format")
								{
									this.CurrentSchema.Format = (string)keyValuePair.Value;
								}
							}
						}
						else if (key == "minLength")
						{
							this.CurrentSchema.MinimumLength = new int?((int)keyValuePair.Value);
						}
					}
					else if (num != 3456888823U)
					{
						if (num == 3522602594U)
						{
							if (key == "uniqueItems")
							{
								this.CurrentSchema.UniqueItems = (bool)keyValuePair.Value;
							}
						}
					}
					else if (key == "readonly")
					{
						this.CurrentSchema.ReadOnly = new bool?((bool)keyValuePair.Value);
					}
				}
				else if (num <= 3947606640U)
				{
					if (num != 3526559937U)
					{
						if (num == 3947606640U)
						{
							if (key == "patternProperties")
							{
								this.CurrentSchema.PatternProperties = this.ProcessProperties(keyValuePair.Value);
							}
						}
					}
					else if (key == "maxLength")
					{
						this.CurrentSchema.MaximumLength = new int?((int)keyValuePair.Value);
					}
				}
				else if (num != 4128829753U)
				{
					if (num == 4244322099U)
					{
						if (key == "maxItems")
						{
							this.CurrentSchema.MaximumItems = new int?((int)keyValuePair.Value);
						}
					}
				}
				else if (key == "hidden")
				{
					this.CurrentSchema.Hidden = new bool?((bool)keyValuePair.Value);
				}
			}
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x000259C8 File Offset: 0x00023BC8
		private void ProcessExtends(global::Newtonsoft.Json.Linq.JToken token)
		{
			global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchema> list = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchema>();
			if (token.Type == global::Newtonsoft.Json.Linq.JTokenType.Array)
			{
				using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)token).GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Newtonsoft.Json.Linq.JToken token2 = enumerator.Current;
						list.Add(this.BuildSchema(token2));
					}
					goto IL_52;
				}
			}
			global::Newtonsoft.Json.Schema.JsonSchema jsonSchema = this.BuildSchema(token);
			if (jsonSchema != null)
			{
				list.Add(jsonSchema);
			}
			IL_52:
			if (list.Count > 0)
			{
				this.CurrentSchema.Extends = list;
			}
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x00025A4C File Offset: 0x00023C4C
		private void ProcessEnum(global::Newtonsoft.Json.Linq.JToken token)
		{
			if (token.Type != global::Newtonsoft.Json.Linq.JTokenType.Array)
			{
				throw global::Newtonsoft.Json.JsonException.Create(token, token.Path, "Expected Array token while parsing enum values, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.Type));
			}
			this.CurrentSchema.Enum = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken>();
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)token))
			{
				this.CurrentSchema.Enum.Add(jtoken.DeepClone());
			}
		}

		// Token: 0x060008EE RID: 2286 RVA: 0x00025AE4 File Offset: 0x00023CE4
		private void ProcessAdditionalProperties(global::Newtonsoft.Json.Linq.JToken token)
		{
			if (token.Type == global::Newtonsoft.Json.Linq.JTokenType.Boolean)
			{
				this.CurrentSchema.AllowAdditionalProperties = (bool)token;
				return;
			}
			this.CurrentSchema.AdditionalProperties = this.BuildSchema(token);
		}

		// Token: 0x060008EF RID: 2287 RVA: 0x00025B14 File Offset: 0x00023D14
		private void ProcessAdditionalItems(global::Newtonsoft.Json.Linq.JToken token)
		{
			if (token.Type == global::Newtonsoft.Json.Linq.JTokenType.Boolean)
			{
				this.CurrentSchema.AllowAdditionalItems = (bool)token;
				return;
			}
			this.CurrentSchema.AdditionalItems = this.BuildSchema(token);
		}

		// Token: 0x060008F0 RID: 2288 RVA: 0x00025B44 File Offset: 0x00023D44
		private global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Schema.JsonSchema> ProcessProperties(global::Newtonsoft.Json.Linq.JToken token)
		{
			global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Schema.JsonSchema> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Newtonsoft.Json.Schema.JsonSchema>();
			if (token.Type != global::Newtonsoft.Json.Linq.JTokenType.Object)
			{
				throw global::Newtonsoft.Json.JsonException.Create(token, token.Path, "Expected Object token while parsing schema properties, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.Type));
			}
			foreach (global::Newtonsoft.Json.Linq.JToken jtoken in ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)token))
			{
				global::Newtonsoft.Json.Linq.JProperty jproperty = (global::Newtonsoft.Json.Linq.JProperty)jtoken;
				if (dictionary.ContainsKey(jproperty.Name))
				{
					throw new global::Newtonsoft.Json.JsonException("Property {0} has already been defined in schema.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, jproperty.Name));
				}
				dictionary.Add(jproperty.Name, this.BuildSchema(jproperty.Value));
			}
			return dictionary;
		}

		// Token: 0x060008F1 RID: 2289 RVA: 0x00025C04 File Offset: 0x00023E04
		private void ProcessItems(global::Newtonsoft.Json.Linq.JToken token)
		{
			this.CurrentSchema.Items = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchema>();
			global::Newtonsoft.Json.Linq.JTokenType type = token.Type;
			if (type != global::Newtonsoft.Json.Linq.JTokenType.Object)
			{
				if (type == global::Newtonsoft.Json.Linq.JTokenType.Array)
				{
					this.CurrentSchema.PositionalItemsValidation = true;
					using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)token).GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							global::Newtonsoft.Json.Linq.JToken token2 = enumerator.Current;
							this.CurrentSchema.Items.Add(this.BuildSchema(token2));
						}
						return;
					}
				}
				throw global::Newtonsoft.Json.JsonException.Create(token, token.Path, "Expected array or JSON schema object, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.Type));
			}
			this.CurrentSchema.Items.Add(this.BuildSchema(token));
			this.CurrentSchema.PositionalItemsValidation = false;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x00025CD4 File Offset: 0x00023ED4
		private global::Newtonsoft.Json.Schema.JsonSchemaType? ProcessType(global::Newtonsoft.Json.Linq.JToken token)
		{
			global::Newtonsoft.Json.Linq.JTokenType type = token.Type;
			if (type == global::Newtonsoft.Json.Linq.JTokenType.Array)
			{
				global::Newtonsoft.Json.Schema.JsonSchemaType? jsonSchemaType = new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.None);
				foreach (global::Newtonsoft.Json.Linq.JToken jtoken in ((global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken>)token))
				{
					if (jtoken.Type != global::Newtonsoft.Json.Linq.JTokenType.String)
					{
						throw global::Newtonsoft.Json.JsonException.Create(jtoken, jtoken.Path, "Expected JSON schema type string token, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.Type));
					}
					jsonSchemaType |= global::Newtonsoft.Json.Schema.JsonSchemaBuilder.MapType((string)jtoken);
				}
				return jsonSchemaType;
			}
			if (type != global::Newtonsoft.Json.Linq.JTokenType.String)
			{
				throw global::Newtonsoft.Json.JsonException.Create(token, token.Path, "Expected array or JSON schema type string token, got {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, token.Type));
			}
			return new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaBuilder.MapType((string)token));
		}

		// Token: 0x060008F3 RID: 2291 RVA: 0x00025DD4 File Offset: 0x00023FD4
		internal static global::Newtonsoft.Json.Schema.JsonSchemaType MapType(string type)
		{
			global::Newtonsoft.Json.Schema.JsonSchemaType result;
			if (!global::Newtonsoft.Json.Schema.JsonSchemaConstants.JsonSchemaTypeMapping.TryGetValue(type, out result))
			{
				throw new global::Newtonsoft.Json.JsonException("Invalid JSON schema type: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, type));
			}
			return result;
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x00025E08 File Offset: 0x00024008
		internal static string MapType(global::Newtonsoft.Json.Schema.JsonSchemaType type)
		{
			return global::Newtonsoft.Json.Schema.JsonSchemaConstants.JsonSchemaTypeMapping.Single((global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchemaType> kv) => kv.Value == type).Key;
		}

		// Token: 0x040002F6 RID: 758
		private readonly global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchema> _stack;

		// Token: 0x040002F7 RID: 759
		private readonly global::Newtonsoft.Json.Schema.JsonSchemaResolver _resolver;

		// Token: 0x040002F8 RID: 760
		private readonly global::System.Collections.Generic.IDictionary<string, global::Newtonsoft.Json.Schema.JsonSchema> _documentSchemas;

		// Token: 0x040002F9 RID: 761
		private global::Newtonsoft.Json.Schema.JsonSchema _currentSchema;

		// Token: 0x040002FA RID: 762
		private global::Newtonsoft.Json.Linq.JObject _rootSchema;
	}
}
