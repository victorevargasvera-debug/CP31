using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	// Token: 0x02000031 RID: 49
	[global::System.Obsolete("JSON Schema validation has been moved to its own package. See https://www.newtonsoft.com/jsonschema for more details.")]
	public class JsonValidatingReader : global::Newtonsoft.Json.JsonReader, global::Newtonsoft.Json.IJsonLineInfo
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600031A RID: 794 RVA: 0x0000C024 File Offset: 0x0000A224
		// (remove) Token: 0x0600031B RID: 795 RVA: 0x0000C05C File Offset: 0x0000A25C
		public event global::Newtonsoft.Json.Schema.ValidationEventHandler ValidationEventHandler;

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000C091 File Offset: 0x0000A291
		public override object Value
		{
			get
			{
				return this._reader.Value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0000C09E File Offset: 0x0000A29E
		public override int Depth
		{
			get
			{
				return this._reader.Depth;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000C0AB File Offset: 0x0000A2AB
		public override string Path
		{
			get
			{
				return this._reader.Path;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
		// (set) Token: 0x06000320 RID: 800 RVA: 0x0000C0C5 File Offset: 0x0000A2C5
		public override char QuoteChar
		{
			get
			{
				return this._reader.QuoteChar;
			}
			protected internal set
			{
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0000C0C7 File Offset: 0x0000A2C7
		public override global::Newtonsoft.Json.JsonToken TokenType
		{
			get
			{
				return this._reader.TokenType;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		public override global::System.Type ValueType
		{
			get
			{
				return this._reader.ValueType;
			}
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000C0E1 File Offset: 0x0000A2E1
		private void Push(global::Newtonsoft.Json.JsonValidatingReader.SchemaScope scope)
		{
			this._stack.Push(scope);
			this._currentScope = scope;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000C0F6 File Offset: 0x0000A2F6
		private global::Newtonsoft.Json.JsonValidatingReader.SchemaScope Pop()
		{
			global::Newtonsoft.Json.JsonValidatingReader.SchemaScope result = this._stack.Pop();
			this._currentScope = ((this._stack.Count != 0) ? this._stack.Peek() : null);
			return result;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000C124 File Offset: 0x0000A324
		private global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> CurrentSchemas
		{
			get
			{
				return this._currentScope.Schemas;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000C134 File Offset: 0x0000A334
		private global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> CurrentMemberSchemas
		{
			get
			{
				if (this._currentScope == null)
				{
					return new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaModel>(new global::Newtonsoft.Json.Schema.JsonSchemaModel[]
					{
						this._model
					});
				}
				if (this._currentScope.Schemas == null || this._currentScope.Schemas.Count == 0)
				{
					return global::Newtonsoft.Json.JsonValidatingReader.EmptySchemaList;
				}
				switch (this._currentScope.TokenType)
				{
				case global::Newtonsoft.Json.Linq.JTokenType.None:
					return this._currentScope.Schemas;
				case global::Newtonsoft.Json.Linq.JTokenType.Object:
				{
					if (this._currentScope.CurrentPropertyName == null)
					{
						throw new global::Newtonsoft.Json.JsonReaderException("CurrentPropertyName has not been set on scope.");
					}
					global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> list = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaModel>();
					foreach (global::Newtonsoft.Json.Schema.JsonSchemaModel jsonSchemaModel in this.CurrentSchemas)
					{
						global::Newtonsoft.Json.Schema.JsonSchemaModel item;
						if (jsonSchemaModel.Properties != null && jsonSchemaModel.Properties.TryGetValue(this._currentScope.CurrentPropertyName, out item))
						{
							list.Add(item);
						}
						if (jsonSchemaModel.PatternProperties != null)
						{
							foreach (global::System.Collections.Generic.KeyValuePair<string, global::Newtonsoft.Json.Schema.JsonSchemaModel> keyValuePair in jsonSchemaModel.PatternProperties)
							{
								if (global::System.Text.RegularExpressions.Regex.IsMatch(this._currentScope.CurrentPropertyName, keyValuePair.Key))
								{
									list.Add(keyValuePair.Value);
								}
							}
						}
						if (list.Count == 0 && jsonSchemaModel.AllowAdditionalProperties && jsonSchemaModel.AdditionalProperties != null)
						{
							list.Add(jsonSchemaModel.AdditionalProperties);
						}
					}
					return list;
				}
				case global::Newtonsoft.Json.Linq.JTokenType.Array:
				{
					global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> list2 = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaModel>();
					foreach (global::Newtonsoft.Json.Schema.JsonSchemaModel jsonSchemaModel2 in this.CurrentSchemas)
					{
						if (!jsonSchemaModel2.PositionalItemsValidation)
						{
							if (jsonSchemaModel2.Items != null && jsonSchemaModel2.Items.Count > 0)
							{
								list2.Add(jsonSchemaModel2.Items[0]);
							}
						}
						else
						{
							if (jsonSchemaModel2.Items != null && jsonSchemaModel2.Items.Count > 0 && jsonSchemaModel2.Items.Count > this._currentScope.ArrayItemCount - 1)
							{
								list2.Add(jsonSchemaModel2.Items[this._currentScope.ArrayItemCount - 1]);
							}
							if (jsonSchemaModel2.AllowAdditionalItems && jsonSchemaModel2.AdditionalItems != null)
							{
								list2.Add(jsonSchemaModel2.AdditionalItems);
							}
						}
					}
					return list2;
				}
				case global::Newtonsoft.Json.Linq.JTokenType.Constructor:
					return global::Newtonsoft.Json.JsonValidatingReader.EmptySchemaList;
				default:
					throw new global::System.ArgumentOutOfRangeException("TokenType", "Unexpected token type: {0}".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._currentScope.TokenType));
				}
			}
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		private void RaiseError(string message, global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			string message2 = ((global::Newtonsoft.Json.IJsonLineInfo)this).HasLineInfo() ? (message + " Line {0}, position {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, ((global::Newtonsoft.Json.IJsonLineInfo)this).LineNumber, ((global::Newtonsoft.Json.IJsonLineInfo)this).LinePosition)) : message;
			this.OnValidationEvent(new global::Newtonsoft.Json.Schema.JsonSchemaException(message2, null, this.Path, ((global::Newtonsoft.Json.IJsonLineInfo)this).LineNumber, ((global::Newtonsoft.Json.IJsonLineInfo)this).LinePosition));
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000C45C File Offset: 0x0000A65C
		private void OnValidationEvent(global::Newtonsoft.Json.Schema.JsonSchemaException exception)
		{
			global::Newtonsoft.Json.Schema.ValidationEventHandler validationEventHandler = this.ValidationEventHandler;
			if (validationEventHandler != null)
			{
				validationEventHandler(this, new global::Newtonsoft.Json.Schema.ValidationEventArgs(exception));
				return;
			}
			throw exception;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000C482 File Offset: 0x0000A682
		public JsonValidatingReader(global::Newtonsoft.Json.JsonReader reader)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(reader, "reader");
			this._reader = reader;
			this._stack = new global::System.Collections.Generic.Stack<global::Newtonsoft.Json.JsonValidatingReader.SchemaScope>();
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000C4A7 File Offset: 0x0000A6A7
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000C4AF File Offset: 0x0000A6AF
		public global::Newtonsoft.Json.Schema.JsonSchema Schema
		{
			get
			{
				return this._schema;
			}
			set
			{
				if (this.TokenType != global::Newtonsoft.Json.JsonToken.None)
				{
					throw new global::System.InvalidOperationException("Cannot change schema while validating JSON.");
				}
				this._schema = value;
				this._model = null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000C4D2 File Offset: 0x0000A6D2
		public global::Newtonsoft.Json.JsonReader Reader
		{
			get
			{
				return this._reader;
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000C4DA File Offset: 0x0000A6DA
		public override void Close()
		{
			base.Close();
			if (base.CloseInput)
			{
				global::Newtonsoft.Json.JsonReader reader = this._reader;
				if (reader == null)
				{
					return;
				}
				reader.Close();
			}
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000C4FC File Offset: 0x0000A6FC
		private void ValidateNotDisallowed(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			global::Newtonsoft.Json.Schema.JsonSchemaType? currentNodeSchemaType = this.GetCurrentNodeSchemaType();
			if (currentNodeSchemaType != null && global::Newtonsoft.Json.Schema.JsonSchemaGenerator.HasFlag(new global::Newtonsoft.Json.Schema.JsonSchemaType?(schema.Disallow), currentNodeSchemaType.GetValueOrDefault()))
			{
				this.RaiseError("Type {0} is disallowed.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, currentNodeSchemaType), schema);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000C554 File Offset: 0x0000A754
		private global::Newtonsoft.Json.Schema.JsonSchemaType? GetCurrentNodeSchemaType()
		{
			switch (this._reader.TokenType)
			{
			case global::Newtonsoft.Json.JsonToken.StartObject:
				return new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.Object);
			case global::Newtonsoft.Json.JsonToken.StartArray:
				return new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.Array);
			case global::Newtonsoft.Json.JsonToken.Integer:
				return new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.Integer);
			case global::Newtonsoft.Json.JsonToken.Float:
				return new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.Float);
			case global::Newtonsoft.Json.JsonToken.String:
				return new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.String);
			case global::Newtonsoft.Json.JsonToken.Boolean:
				return new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.Boolean);
			case global::Newtonsoft.Json.JsonToken.Null:
				return new global::Newtonsoft.Json.Schema.JsonSchemaType?(global::Newtonsoft.Json.Schema.JsonSchemaType.Null);
			}
			return null;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000C5E0 File Offset: 0x0000A7E0
		public override int? ReadAsInt32()
		{
			int? result = this._reader.ReadAsInt32();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000C5F3 File Offset: 0x0000A7F3
		public override byte[] ReadAsBytes()
		{
			byte[] result = this._reader.ReadAsBytes();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000C606 File Offset: 0x0000A806
		public override decimal? ReadAsDecimal()
		{
			decimal? result = this._reader.ReadAsDecimal();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000C619 File Offset: 0x0000A819
		public override double? ReadAsDouble()
		{
			double? result = this._reader.ReadAsDouble();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000C62C File Offset: 0x0000A82C
		public override bool? ReadAsBoolean()
		{
			bool? result = this._reader.ReadAsBoolean();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000C63F File Offset: 0x0000A83F
		public override string ReadAsString()
		{
			string result = this._reader.ReadAsString();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000C652 File Offset: 0x0000A852
		public override global::System.DateTime? ReadAsDateTime()
		{
			global::System.DateTime? result = this._reader.ReadAsDateTime();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000C665 File Offset: 0x0000A865
		public override global::System.DateTimeOffset? ReadAsDateTimeOffset()
		{
			global::System.DateTimeOffset? result = this._reader.ReadAsDateTimeOffset();
			this.ValidateCurrentToken();
			return result;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000C678 File Offset: 0x0000A878
		public override bool Read()
		{
			if (!this._reader.Read())
			{
				return false;
			}
			if (this._reader.TokenType == global::Newtonsoft.Json.JsonToken.Comment)
			{
				return true;
			}
			this.ValidateCurrentToken();
			return true;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000C6A0 File Offset: 0x0000A8A0
		private void ValidateCurrentToken()
		{
			if (this._model == null)
			{
				global::Newtonsoft.Json.Schema.JsonSchemaModelBuilder jsonSchemaModelBuilder = new global::Newtonsoft.Json.Schema.JsonSchemaModelBuilder();
				this._model = jsonSchemaModelBuilder.Build(this._schema);
				if (!global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsStartToken(this._reader.TokenType))
				{
					this.Push(new global::Newtonsoft.Json.JsonValidatingReader.SchemaScope(global::Newtonsoft.Json.Linq.JTokenType.None, this.CurrentMemberSchemas));
				}
			}
			switch (this._reader.TokenType)
			{
			case global::Newtonsoft.Json.JsonToken.None:
				return;
			case global::Newtonsoft.Json.JsonToken.StartObject:
			{
				this.ProcessValue();
				global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> schemas = this.CurrentMemberSchemas.Where(new global::System.Func<global::Newtonsoft.Json.Schema.JsonSchemaModel, bool>(this.ValidateObject)).ToList<global::Newtonsoft.Json.Schema.JsonSchemaModel>();
				this.Push(new global::Newtonsoft.Json.JsonValidatingReader.SchemaScope(global::Newtonsoft.Json.Linq.JTokenType.Object, schemas));
				this.WriteToken(this.CurrentSchemas);
				return;
			}
			case global::Newtonsoft.Json.JsonToken.StartArray:
			{
				this.ProcessValue();
				global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> schemas2 = this.CurrentMemberSchemas.Where(new global::System.Func<global::Newtonsoft.Json.Schema.JsonSchemaModel, bool>(this.ValidateArray)).ToList<global::Newtonsoft.Json.Schema.JsonSchemaModel>();
				this.Push(new global::Newtonsoft.Json.JsonValidatingReader.SchemaScope(global::Newtonsoft.Json.Linq.JTokenType.Array, schemas2));
				this.WriteToken(this.CurrentSchemas);
				return;
			}
			case global::Newtonsoft.Json.JsonToken.StartConstructor:
				this.ProcessValue();
				this.Push(new global::Newtonsoft.Json.JsonValidatingReader.SchemaScope(global::Newtonsoft.Json.Linq.JTokenType.Constructor, null));
				this.WriteToken(this.CurrentSchemas);
				return;
			case global::Newtonsoft.Json.JsonToken.PropertyName:
				this.WriteToken(this.CurrentSchemas);
				using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Schema.JsonSchemaModel> enumerator = this.CurrentSchemas.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Newtonsoft.Json.Schema.JsonSchemaModel schema = enumerator.Current;
						this.ValidatePropertyName(schema);
					}
					return;
				}
				break;
			case global::Newtonsoft.Json.JsonToken.Comment:
				goto IL_3BD;
			case global::Newtonsoft.Json.JsonToken.Raw:
				break;
			case global::Newtonsoft.Json.JsonToken.Integer:
				this.ProcessValue();
				this.WriteToken(this.CurrentMemberSchemas);
				using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Schema.JsonSchemaModel> enumerator = this.CurrentMemberSchemas.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::Newtonsoft.Json.Schema.JsonSchemaModel schema2 = enumerator.Current;
						this.ValidateInteger(schema2);
					}
					return;
				}
				goto IL_1D6;
			case global::Newtonsoft.Json.JsonToken.Float:
				goto IL_1D6;
			case global::Newtonsoft.Json.JsonToken.String:
				goto IL_222;
			case global::Newtonsoft.Json.JsonToken.Boolean:
				goto IL_26E;
			case global::Newtonsoft.Json.JsonToken.Null:
				goto IL_2BA;
			case global::Newtonsoft.Json.JsonToken.Undefined:
			case global::Newtonsoft.Json.JsonToken.Date:
			case global::Newtonsoft.Json.JsonToken.Bytes:
				this.WriteToken(this.CurrentMemberSchemas);
				return;
			case global::Newtonsoft.Json.JsonToken.EndObject:
				goto IL_306;
			case global::Newtonsoft.Json.JsonToken.EndArray:
				this.WriteToken(this.CurrentSchemas);
				foreach (global::Newtonsoft.Json.Schema.JsonSchemaModel schema3 in this.CurrentSchemas)
				{
					this.ValidateEndArray(schema3);
				}
				this.Pop();
				return;
			case global::Newtonsoft.Json.JsonToken.EndConstructor:
				this.WriteToken(this.CurrentSchemas);
				this.Pop();
				return;
			default:
				goto IL_3BD;
			}
			this.ProcessValue();
			return;
			IL_1D6:
			this.ProcessValue();
			this.WriteToken(this.CurrentMemberSchemas);
			using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Schema.JsonSchemaModel> enumerator = this.CurrentMemberSchemas.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Newtonsoft.Json.Schema.JsonSchemaModel schema4 = enumerator.Current;
					this.ValidateFloat(schema4);
				}
				return;
			}
			IL_222:
			this.ProcessValue();
			this.WriteToken(this.CurrentMemberSchemas);
			using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Schema.JsonSchemaModel> enumerator = this.CurrentMemberSchemas.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Newtonsoft.Json.Schema.JsonSchemaModel schema5 = enumerator.Current;
					this.ValidateString(schema5);
				}
				return;
			}
			IL_26E:
			this.ProcessValue();
			this.WriteToken(this.CurrentMemberSchemas);
			using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Schema.JsonSchemaModel> enumerator = this.CurrentMemberSchemas.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Newtonsoft.Json.Schema.JsonSchemaModel schema6 = enumerator.Current;
					this.ValidateBoolean(schema6);
				}
				return;
			}
			IL_2BA:
			this.ProcessValue();
			this.WriteToken(this.CurrentMemberSchemas);
			using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Schema.JsonSchemaModel> enumerator = this.CurrentMemberSchemas.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::Newtonsoft.Json.Schema.JsonSchemaModel schema7 = enumerator.Current;
					this.ValidateNull(schema7);
				}
				return;
			}
			IL_306:
			this.WriteToken(this.CurrentSchemas);
			foreach (global::Newtonsoft.Json.Schema.JsonSchemaModel schema8 in this.CurrentSchemas)
			{
				this.ValidateEndObject(schema8);
			}
			this.Pop();
			return;
			IL_3BD:
			throw new global::System.ArgumentOutOfRangeException();
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000CAD4 File Offset: 0x0000ACD4
		private void WriteToken(global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> schemas)
		{
			foreach (global::Newtonsoft.Json.JsonValidatingReader.SchemaScope schemaScope in this._stack)
			{
				bool flag = schemaScope.TokenType == global::Newtonsoft.Json.Linq.JTokenType.Array && schemaScope.IsUniqueArray && schemaScope.ArrayItemCount > 0;
				if (!flag)
				{
					if (!schemas.Any((global::Newtonsoft.Json.Schema.JsonSchemaModel s) => s.Enum != null))
					{
						continue;
					}
				}
				if (schemaScope.CurrentItemWriter == null)
				{
					if (global::Newtonsoft.Json.Utilities.JsonTokenUtils.IsEndToken(this._reader.TokenType))
					{
						continue;
					}
					schemaScope.CurrentItemWriter = new global::Newtonsoft.Json.Linq.JTokenWriter();
				}
				schemaScope.CurrentItemWriter.WriteToken(this._reader, false);
				if (schemaScope.CurrentItemWriter.Top == 0 && this._reader.TokenType != global::Newtonsoft.Json.JsonToken.PropertyName)
				{
					global::Newtonsoft.Json.Linq.JToken token = schemaScope.CurrentItemWriter.Token;
					schemaScope.CurrentItemWriter = null;
					if (flag)
					{
						if (schemaScope.UniqueArrayItems.Contains(token, global::Newtonsoft.Json.Linq.JToken.EqualityComparer))
						{
							this.RaiseError("Non-unique array item at index {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, schemaScope.ArrayItemCount - 1), schemaScope.Schemas.First((global::Newtonsoft.Json.Schema.JsonSchemaModel s) => s.UniqueItems));
						}
						schemaScope.UniqueArrayItems.Add(token);
					}
					else if (schemas.Any((global::Newtonsoft.Json.Schema.JsonSchemaModel s) => s.Enum != null))
					{
						foreach (global::Newtonsoft.Json.Schema.JsonSchemaModel jsonSchemaModel in schemas)
						{
							if (jsonSchemaModel.Enum != null && !jsonSchemaModel.Enum.ContainsValue(token, global::Newtonsoft.Json.Linq.JToken.EqualityComparer))
							{
								global::System.IO.StringWriter stringWriter = new global::System.IO.StringWriter(global::System.Globalization.CultureInfo.InvariantCulture);
								token.WriteTo(new global::Newtonsoft.Json.JsonTextWriter(stringWriter), new global::Newtonsoft.Json.JsonConverter[0]);
								this.RaiseError("Value {0} is not defined in enum.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, stringWriter.ToString()), jsonSchemaModel);
							}
						}
					}
				}
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000CD24 File Offset: 0x0000AF24
		private void ValidateEndObject(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			global::System.Collections.Generic.Dictionary<string, bool> requiredProperties = this._currentScope.RequiredProperties;
			if (requiredProperties != null)
			{
				if (requiredProperties.Values.Any((bool v) => !v))
				{
					global::System.Collections.Generic.IEnumerable<string> values = from kv in requiredProperties
					where !kv.Value
					select kv.Key;
					this.RaiseError("Required properties are missing from object: {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, string.Join(", ", values)), schema);
				}
			}
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		private void ValidateEndArray(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			int arrayItemCount = this._currentScope.ArrayItemCount;
			if (schema.MaximumItems != null)
			{
				int num = arrayItemCount;
				int? num2 = schema.MaximumItems;
				if (num > num2.GetValueOrDefault() & num2 != null)
				{
					this.RaiseError("Array item count {0} exceeds maximum count of {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, arrayItemCount, schema.MaximumItems), schema);
				}
			}
			if (schema.MinimumItems != null)
			{
				int num3 = arrayItemCount;
				int? num2 = schema.MinimumItems;
				if (num3 < num2.GetValueOrDefault() & num2 != null)
				{
					this.RaiseError("Array item count {0} is less than minimum count of {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, arrayItemCount, schema.MinimumItems), schema);
				}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000CEA1 File Offset: 0x0000B0A1
		private void ValidateNull(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, global::Newtonsoft.Json.Schema.JsonSchemaType.Null))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000CEBA File Offset: 0x0000B0BA
		private void ValidateBoolean(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, global::Newtonsoft.Json.Schema.JsonSchemaType.Boolean))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000CED4 File Offset: 0x0000B0D4
		private void ValidateString(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, global::Newtonsoft.Json.Schema.JsonSchemaType.String))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
			string text = this._reader.Value.ToString();
			if (schema.MaximumLength != null)
			{
				int length = text.Length;
				int? num = schema.MaximumLength;
				if (length > num.GetValueOrDefault() & num != null)
				{
					this.RaiseError("String '{0}' exceeds maximum length of {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text, schema.MaximumLength), schema);
				}
			}
			if (schema.MinimumLength != null)
			{
				int length2 = text.Length;
				int? num = schema.MinimumLength;
				if (length2 < num.GetValueOrDefault() & num != null)
				{
					this.RaiseError("String '{0}' is less than minimum length of {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text, schema.MinimumLength), schema);
				}
			}
			if (schema.Patterns != null)
			{
				foreach (string text2 in schema.Patterns)
				{
					if (!global::System.Text.RegularExpressions.Regex.IsMatch(text, text2))
					{
						this.RaiseError("String '{0}' does not match regex pattern '{1}'.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text, text2), schema);
					}
				}
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000D010 File Offset: 0x0000B210
		private void ValidateInteger(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, global::Newtonsoft.Json.Schema.JsonSchemaType.Integer))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
			object value = this._reader.Value;
			if (schema.Maximum != null)
			{
				if (global::Newtonsoft.Json.Linq.JValue.Compare(global::Newtonsoft.Json.Linq.JTokenType.Integer, value, schema.Maximum) > 0)
				{
					this.RaiseError("Integer {0} exceeds maximum value of {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value, schema.Maximum), schema);
				}
				if (schema.ExclusiveMaximum && global::Newtonsoft.Json.Linq.JValue.Compare(global::Newtonsoft.Json.Linq.JTokenType.Integer, value, schema.Maximum) == 0)
				{
					this.RaiseError("Integer {0} equals maximum value of {1} and exclusive maximum is true.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value, schema.Maximum), schema);
				}
			}
			if (schema.Minimum != null)
			{
				if (global::Newtonsoft.Json.Linq.JValue.Compare(global::Newtonsoft.Json.Linq.JTokenType.Integer, value, schema.Minimum) < 0)
				{
					this.RaiseError("Integer {0} is less than minimum value of {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value, schema.Minimum), schema);
				}
				if (schema.ExclusiveMinimum && global::Newtonsoft.Json.Linq.JValue.Compare(global::Newtonsoft.Json.Linq.JTokenType.Integer, value, schema.Minimum) == 0)
				{
					this.RaiseError("Integer {0} equals minimum value of {1} and exclusive minimum is true.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, value, schema.Minimum), schema);
				}
			}
			if (schema.DivisibleBy != null)
			{
				bool flag;
				if (value is global::System.Numerics.BigInteger)
				{
					global::System.Numerics.BigInteger bigInteger = (global::System.Numerics.BigInteger)value;
					if (!global::System.Math.Abs(schema.DivisibleBy.Value - global::System.Math.Truncate(schema.DivisibleBy.Value)).Equals(0.0))
					{
						flag = (bigInteger != 0L);
					}
					else
					{
						flag = (bigInteger % new global::System.Numerics.BigInteger(schema.DivisibleBy.Value) != 0L);
					}
				}
				else
				{
					flag = !global::Newtonsoft.Json.JsonValidatingReader.IsZero((double)global::System.Convert.ToInt64(value, global::System.Globalization.CultureInfo.InvariantCulture) % schema.DivisibleBy.GetValueOrDefault());
				}
				if (flag)
				{
					this.RaiseError("Integer {0} is not evenly divisible by {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.JsonConvert.ToString(value), schema.DivisibleBy), schema);
				}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000D228 File Offset: 0x0000B428
		private void ProcessValue()
		{
			if (this._currentScope != null && this._currentScope.TokenType == global::Newtonsoft.Json.Linq.JTokenType.Array)
			{
				global::Newtonsoft.Json.JsonValidatingReader.SchemaScope currentScope = this._currentScope;
				int arrayItemCount = currentScope.ArrayItemCount;
				currentScope.ArrayItemCount = arrayItemCount + 1;
				foreach (global::Newtonsoft.Json.Schema.JsonSchemaModel jsonSchemaModel in this.CurrentSchemas)
				{
					if (jsonSchemaModel != null && jsonSchemaModel.PositionalItemsValidation && !jsonSchemaModel.AllowAdditionalItems && (jsonSchemaModel.Items == null || this._currentScope.ArrayItemCount - 1 >= jsonSchemaModel.Items.Count))
					{
						this.RaiseError("Index {0} has not been defined and the schema does not allow additional items.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, this._currentScope.ArrayItemCount), jsonSchemaModel);
					}
				}
			}
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		private void ValidateFloat(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			if (!this.TestType(schema, global::Newtonsoft.Json.Schema.JsonSchemaType.Float))
			{
				return;
			}
			this.ValidateNotDisallowed(schema);
			double num = global::System.Convert.ToDouble(this._reader.Value, global::System.Globalization.CultureInfo.InvariantCulture);
			if (schema.Maximum != null)
			{
				double num2 = num;
				double? num3 = schema.Maximum;
				if (num2 > num3.GetValueOrDefault() & num3 != null)
				{
					this.RaiseError("Float {0} exceeds maximum value of {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.JsonConvert.ToString(num), schema.Maximum), schema);
				}
				if (schema.ExclusiveMaximum)
				{
					double num4 = num;
					num3 = schema.Maximum;
					if (num4 == num3.GetValueOrDefault() & num3 != null)
					{
						this.RaiseError("Float {0} equals maximum value of {1} and exclusive maximum is true.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.JsonConvert.ToString(num), schema.Maximum), schema);
					}
				}
			}
			if (schema.Minimum != null)
			{
				double num5 = num;
				double? num3 = schema.Minimum;
				if (num5 < num3.GetValueOrDefault() & num3 != null)
				{
					this.RaiseError("Float {0} is less than minimum value of {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.JsonConvert.ToString(num), schema.Minimum), schema);
				}
				if (schema.ExclusiveMinimum)
				{
					double num6 = num;
					num3 = schema.Minimum;
					if (num6 == num3.GetValueOrDefault() & num3 != null)
					{
						this.RaiseError("Float {0} equals minimum value of {1} and exclusive minimum is true.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.JsonConvert.ToString(num), schema.Minimum), schema);
					}
				}
			}
			if (schema.DivisibleBy != null && !global::Newtonsoft.Json.JsonValidatingReader.IsZero(global::Newtonsoft.Json.JsonValidatingReader.FloatingPointRemainder(num, schema.DivisibleBy.GetValueOrDefault())))
			{
				this.RaiseError("Float {0} is not evenly divisible by {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, global::Newtonsoft.Json.JsonConvert.ToString(num), schema.DivisibleBy), schema);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000D4C5 File Offset: 0x0000B6C5
		private static double FloatingPointRemainder(double dividend, double divisor)
		{
			return dividend - global::System.Math.Floor(dividend / divisor) * divisor;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000D4D3 File Offset: 0x0000B6D3
		private static bool IsZero(double value)
		{
			return global::System.Math.Abs(value) < 4.440892098500626E-15;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		private void ValidatePropertyName(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			if (schema == null)
			{
				return;
			}
			string text = global::System.Convert.ToString(this._reader.Value, global::System.Globalization.CultureInfo.InvariantCulture);
			if (this._currentScope.RequiredProperties.ContainsKey(text))
			{
				this._currentScope.RequiredProperties[text] = true;
			}
			if (!schema.AllowAdditionalProperties && !this.IsPropertyDefinied(schema, text))
			{
				this.RaiseError("Property '{0}' has not been defined and the schema does not allow additional properties.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, text), schema);
			}
			this._currentScope.CurrentPropertyName = text;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000D56C File Offset: 0x0000B76C
		private bool IsPropertyDefinied(global::Newtonsoft.Json.Schema.JsonSchemaModel schema, string propertyName)
		{
			if (schema.Properties != null && schema.Properties.ContainsKey(propertyName))
			{
				return true;
			}
			if (schema.PatternProperties != null)
			{
				foreach (string pattern in schema.PatternProperties.Keys)
				{
					if (global::System.Text.RegularExpressions.Regex.IsMatch(propertyName, pattern))
					{
						return true;
					}
				}
				return false;
			}
			return false;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000D5E8 File Offset: 0x0000B7E8
		private bool ValidateArray(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			return schema == null || this.TestType(schema, global::Newtonsoft.Json.Schema.JsonSchemaType.Array);
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
		private bool ValidateObject(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
		{
			return schema == null || this.TestType(schema, global::Newtonsoft.Json.Schema.JsonSchemaType.Object);
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000D608 File Offset: 0x0000B808
		private bool TestType(global::Newtonsoft.Json.Schema.JsonSchemaModel currentSchema, global::Newtonsoft.Json.Schema.JsonSchemaType currentType)
		{
			if (!global::Newtonsoft.Json.Schema.JsonSchemaGenerator.HasFlag(new global::Newtonsoft.Json.Schema.JsonSchemaType?(currentSchema.Type), currentType))
			{
				this.RaiseError("Invalid type. Expected {0} but got {1}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, currentSchema.Type, currentType), currentSchema);
				return false;
			}
			return true;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000D648 File Offset: 0x0000B848
		bool global::Newtonsoft.Json.IJsonLineInfo.HasLineInfo()
		{
			global::Newtonsoft.Json.IJsonLineInfo jsonLineInfo = this._reader as global::Newtonsoft.Json.IJsonLineInfo;
			return jsonLineInfo != null && jsonLineInfo.HasLineInfo();
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000D66C File Offset: 0x0000B86C
		int global::Newtonsoft.Json.IJsonLineInfo.LineNumber
		{
			get
			{
				global::Newtonsoft.Json.IJsonLineInfo jsonLineInfo = this._reader as global::Newtonsoft.Json.IJsonLineInfo;
				if (jsonLineInfo == null)
				{
					return 0;
				}
				return jsonLineInfo.LineNumber;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000D690 File Offset: 0x0000B890
		int global::Newtonsoft.Json.IJsonLineInfo.LinePosition
		{
			get
			{
				global::Newtonsoft.Json.IJsonLineInfo jsonLineInfo = this._reader as global::Newtonsoft.Json.IJsonLineInfo;
				if (jsonLineInfo == null)
				{
					return 0;
				}
				return jsonLineInfo.LinePosition;
			}
		}

		// Token: 0x04000100 RID: 256
		private readonly global::Newtonsoft.Json.JsonReader _reader;

		// Token: 0x04000101 RID: 257
		private readonly global::System.Collections.Generic.Stack<global::Newtonsoft.Json.JsonValidatingReader.SchemaScope> _stack;

		// Token: 0x04000102 RID: 258
		private global::Newtonsoft.Json.Schema.JsonSchema _schema;

		// Token: 0x04000103 RID: 259
		private global::Newtonsoft.Json.Schema.JsonSchemaModel _model;

		// Token: 0x04000104 RID: 260
		private global::Newtonsoft.Json.JsonValidatingReader.SchemaScope _currentScope;

		// Token: 0x04000106 RID: 262
		private static readonly global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> EmptySchemaList = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Schema.JsonSchemaModel>();

		// Token: 0x02000155 RID: 341
		private class SchemaScope
		{
			// Token: 0x17000286 RID: 646
			// (get) Token: 0x06000E59 RID: 3673 RVA: 0x0003FFAE File Offset: 0x0003E1AE
			// (set) Token: 0x06000E5A RID: 3674 RVA: 0x0003FFB6 File Offset: 0x0003E1B6
			public string CurrentPropertyName { get; set; }

			// Token: 0x17000287 RID: 647
			// (get) Token: 0x06000E5B RID: 3675 RVA: 0x0003FFBF File Offset: 0x0003E1BF
			// (set) Token: 0x06000E5C RID: 3676 RVA: 0x0003FFC7 File Offset: 0x0003E1C7
			public int ArrayItemCount { get; set; }

			// Token: 0x17000288 RID: 648
			// (get) Token: 0x06000E5D RID: 3677 RVA: 0x0003FFD0 File Offset: 0x0003E1D0
			public bool IsUniqueArray { get; }

			// Token: 0x17000289 RID: 649
			// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0003FFD8 File Offset: 0x0003E1D8
			public global::System.Collections.Generic.IList<global::Newtonsoft.Json.Linq.JToken> UniqueArrayItems { get; }

			// Token: 0x1700028A RID: 650
			// (get) Token: 0x06000E5F RID: 3679 RVA: 0x0003FFE0 File Offset: 0x0003E1E0
			// (set) Token: 0x06000E60 RID: 3680 RVA: 0x0003FFE8 File Offset: 0x0003E1E8
			public global::Newtonsoft.Json.Linq.JTokenWriter CurrentItemWriter { get; set; }

			// Token: 0x1700028B RID: 651
			// (get) Token: 0x06000E61 RID: 3681 RVA: 0x0003FFF1 File Offset: 0x0003E1F1
			public global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> Schemas
			{
				get
				{
					return this._schemas;
				}
			}

			// Token: 0x1700028C RID: 652
			// (get) Token: 0x06000E62 RID: 3682 RVA: 0x0003FFF9 File Offset: 0x0003E1F9
			public global::System.Collections.Generic.Dictionary<string, bool> RequiredProperties
			{
				get
				{
					return this._requiredProperties;
				}
			}

			// Token: 0x1700028D RID: 653
			// (get) Token: 0x06000E63 RID: 3683 RVA: 0x00040001 File Offset: 0x0003E201
			public global::Newtonsoft.Json.Linq.JTokenType TokenType
			{
				get
				{
					return this._tokenType;
				}
			}

			// Token: 0x06000E64 RID: 3684 RVA: 0x0004000C File Offset: 0x0003E20C
			public SchemaScope(global::Newtonsoft.Json.Linq.JTokenType tokenType, global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> schemas)
			{
				this._tokenType = tokenType;
				this._schemas = schemas;
				this._requiredProperties = schemas.SelectMany(new global::System.Func<global::Newtonsoft.Json.Schema.JsonSchemaModel, global::System.Collections.Generic.IEnumerable<string>>(this.GetRequiredProperties)).Distinct<string>().ToDictionary((string p) => p, (string p) => false);
				if (tokenType == global::Newtonsoft.Json.Linq.JTokenType.Array)
				{
					if (schemas.Any((global::Newtonsoft.Json.Schema.JsonSchemaModel s) => s.UniqueItems))
					{
						this.IsUniqueArray = 1;
						this.UniqueArrayItems = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JToken>();
					}
				}
			}

			// Token: 0x06000E65 RID: 3685 RVA: 0x000400CC File Offset: 0x0003E2CC
			private global::System.Collections.Generic.IEnumerable<string> GetRequiredProperties(global::Newtonsoft.Json.Schema.JsonSchemaModel schema)
			{
				if (((schema != null) ? schema.Properties : null) == null)
				{
					return global::System.Linq.Enumerable.Empty<string>();
				}
				return from p in schema.Properties
				where p.Value.Required
				select p.Key;
			}

			// Token: 0x0400060A RID: 1546
			private readonly global::Newtonsoft.Json.Linq.JTokenType _tokenType;

			// Token: 0x0400060B RID: 1547
			private readonly global::System.Collections.Generic.IList<global::Newtonsoft.Json.Schema.JsonSchemaModel> _schemas;

			// Token: 0x0400060C RID: 1548
			private readonly global::System.Collections.Generic.Dictionary<string, bool> _requiredProperties;
		}
	}
}
