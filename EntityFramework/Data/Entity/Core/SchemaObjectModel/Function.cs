using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002F3 RID: 755
	internal class Function : global::System.Data.Entity.Core.SchemaObjectModel.SchemaType
	{
		// Token: 0x060023E9 RID: 9193 RVA: 0x00064934 File Offset: 0x00062B34
		internal static void RemoveTypeModifier(ref string type, out global::System.Data.Entity.Core.SchemaObjectModel.TypeModifier typeModifier, out bool isRefType)
		{
			isRefType = false;
			typeModifier = global::System.Data.Entity.Core.SchemaObjectModel.TypeModifier.None;
			global::System.Text.RegularExpressions.Match match = global::System.Data.Entity.Core.SchemaObjectModel.Function._typeParser.Match(type);
			if (match.Success)
			{
				type = match.Groups["typeName"].Value;
				string value = match.Groups["modifier"].Value;
				if (value != null)
				{
					if (value == "Collection")
					{
						typeModifier = global::System.Data.Entity.Core.SchemaObjectModel.TypeModifier.Array;
						return;
					}
					if (!(value == "Ref"))
					{
						return;
					}
					isRefType = true;
					return;
				}
			}
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x000649B0 File Offset: 0x00062BB0
		internal static string GetTypeNameForErrorMessage(global::System.Data.Entity.Core.SchemaObjectModel.SchemaType type, global::System.Data.Entity.Core.Metadata.Edm.CollectionKind colKind, bool isRef)
		{
			string text = type.FQName;
			if (isRef)
			{
				text = "Ref(" + text + ")";
			}
			if (colKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag)
			{
				text = "Collection(" + text + ")";
			}
			return text;
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x000649EE File Offset: 0x00062BEE
		public Function(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement)
		{
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x000649FE File Offset: 0x00062BFE
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x00064A06 File Offset: 0x00062C06
		public bool IsAggregate
		{
			get
			{
				return this._isAggregate;
			}
			internal set
			{
				this._isAggregate = value;
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x060023EE RID: 9198 RVA: 0x00064A0F File Offset: 0x00062C0F
		// (set) Token: 0x060023EF RID: 9199 RVA: 0x00064A17 File Offset: 0x00062C17
		public bool IsBuiltIn
		{
			get
			{
				return this._isBuiltIn;
			}
			internal set
			{
				this._isBuiltIn = value;
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x00064A20 File Offset: 0x00062C20
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x00064A28 File Offset: 0x00062C28
		public bool IsNiladicFunction
		{
			get
			{
				return this._isNiladicFunction;
			}
			internal set
			{
				this._isNiladicFunction = value;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x00064A31 File Offset: 0x00062C31
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x00064A39 File Offset: 0x00062C39
		public bool IsComposable
		{
			get
			{
				return this._isComposable;
			}
			internal set
			{
				this._isComposable = value;
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x00064A42 File Offset: 0x00062C42
		public string CommandText
		{
			get
			{
				if (this._commandText != null)
				{
					return this._commandText.CommandText;
				}
				return null;
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x00064A59 File Offset: 0x00062C59
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x00064A61 File Offset: 0x00062C61
		public global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics ParameterTypeSemantics
		{
			get
			{
				return this._parameterTypeSemantics;
			}
			internal set
			{
				this._parameterTypeSemantics = value;
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x060023F7 RID: 9207 RVA: 0x00064A6A File Offset: 0x00062C6A
		// (set) Token: 0x060023F8 RID: 9208 RVA: 0x00064A72 File Offset: 0x00062C72
		public string StoreFunctionName
		{
			get
			{
				return this._storeFunctionName;
			}
			internal set
			{
				this._storeFunctionName = value;
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x00064A7B File Offset: 0x00062C7B
		public virtual global::System.Data.Entity.Core.SchemaObjectModel.SchemaType Type
		{
			get
			{
				if (this._returnTypeList != null)
				{
					return this._returnTypeList[0].Type;
				}
				return this._type;
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x060023FA RID: 9210 RVA: 0x00064A9D File Offset: 0x00062C9D
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.ReturnType> ReturnTypeList
		{
			get
			{
				if (this._returnTypeList == null)
				{
					return null;
				}
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.SchemaObjectModel.ReturnType>(this._returnTypeList);
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x060023FB RID: 9211 RVA: 0x00064AB4 File Offset: 0x00062CB4
		public global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.Parameter> Parameters
		{
			get
			{
				if (this._parameters == null)
				{
					this._parameters = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.Parameter>();
				}
				return this._parameters;
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x00064ACF File Offset: 0x00062CCF
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x00064AD7 File Offset: 0x00062CD7
		public global::System.Data.Entity.Core.Metadata.Edm.CollectionKind CollectionKind
		{
			get
			{
				return this._returnTypeCollectionKind;
			}
			internal set
			{
				this._returnTypeCollectionKind = value;
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x060023FE RID: 9214 RVA: 0x00064AE0 File Offset: 0x00062CE0
		public override string Identity
		{
			get
			{
				if (string.IsNullOrEmpty(this._functionStrongName))
				{
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(this.FQName);
					bool flag = true;
					stringBuilder.Append('(');
					foreach (global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter in this.Parameters)
					{
						if (!flag)
						{
							stringBuilder.Append(',');
						}
						else
						{
							flag = false;
						}
						stringBuilder.Append(global::System.Data.Entity.Core.Metadata.Edm.Helper.ToString(parameter.ParameterDirection));
						stringBuilder.Append(' ');
						parameter.WriteIdentity(stringBuilder);
					}
					stringBuilder.Append(')');
					this._functionStrongName = stringBuilder.ToString();
				}
				return this._functionStrongName;
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x00064B9C File Offset: 0x00062D9C
		public bool IsReturnAttributeReftype
		{
			get
			{
				return this._isRefType;
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x00064BA4 File Offset: 0x00062DA4
		public virtual bool IsFunctionImport
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x00064BA7 File Offset: 0x00062DA7
		public string DbSchema
		{
			get
			{
				return this._schema;
			}
		}

		// Token: 0x06002402 RID: 9218 RVA: 0x00064BB0 File Offset: 0x00062DB0
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "CommandText"))
			{
				this.HandleCommandTextFunctionElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "Parameter"))
			{
				this.HandleParameterElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "ReturnType"))
			{
				this.HandleReturnTypeElement(reader);
				return true;
			}
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				if (base.CanHandleElement(reader, "ValueAnnotation"))
				{
					this.SkipElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "TypeAnnotation"))
				{
					this.SkipElement(reader);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002403 RID: 9219 RVA: 0x00064C4C File Offset: 0x00062E4C
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "ReturnType"))
			{
				this.HandleReturnTypeAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Aggregate"))
			{
				this.HandleAggregateAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "BuiltIn"))
			{
				this.HandleBuiltInAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "StoreFunctionName"))
			{
				this.HandleStoreFunctionNameAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "NiladicFunction"))
			{
				this.HandleNiladicFunctionAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "IsComposable"))
			{
				this.HandleIsComposableAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "ParameterTypeSemantics"))
			{
				this.HandleParameterTypeSemanticsAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Schema"))
			{
				this.HandleDbSchemaAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x00064D18 File Offset: 0x00062F18
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (this._unresolvedType != null)
			{
				base.Schema.ResolveTypeName(this, this.UnresolvedReturnType, out this._type);
			}
			if (this._returnTypeList != null)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.ReturnType returnType in this._returnTypeList)
				{
					returnType.ResolveTopLevelNames();
				}
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter in this.Parameters)
			{
				parameter.ResolveTopLevelNames();
			}
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x00064DD0 File Offset: 0x00062FD0
		internal override void Validate()
		{
			base.Validate();
			if (this._type != null && this._returnTypeList != null)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ReturnTypeDeclaredAsAttributeAndElement, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.TypeDeclaredAsAttributeAndElement);
			}
			if (this._returnTypeList == null && this.Type == null)
			{
				if (this.IsComposable)
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ComposableFunctionOrFunctionImportWithoutReturnType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.ComposableFunctionOrFunctionImportMustDeclareReturnType);
				}
			}
			else if (!this.IsComposable && !this.IsFunctionImport)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.NonComposableFunctionWithReturnType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.NonComposableFunctionMustNotDeclareReturnType);
			}
			if (base.Schema.DataModel != global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				if (this.IsAggregate)
				{
					if (this.Parameters.Count == 0)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidNumberOfParametersForAggregateFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.InvalidNumberOfParametersForAggregateFunction(this.FQName));
					}
					else if (this.Parameters.GetElementAt(0).CollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
					{
						global::System.Data.Entity.Core.SchemaObjectModel.Parameter elementAt = this.Parameters.GetElementAt(0);
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidParameterTypeForAggregateFunction, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.InvalidParameterTypeForAggregateFunction(elementAt.Name, this.FQName));
					}
				}
				if (!this.IsComposable && (this.IsAggregate || this.IsNiladicFunction || this.IsBuiltIn))
				{
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.NonComposableFunctionAttributesNotValid, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.NonComposableFunctionHasDisallowedAttribute);
				}
				if (this.CommandText != null)
				{
					if (this.IsComposable)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ComposableFunctionWithCommandText, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.CommandTextFunctionsNotComposable);
					}
					if (this.StoreFunctionName != null)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionDeclaresCommandTextAndStoreFunctionName, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.CommandTextFunctionsCannotDeclareStoreFunctionName);
					}
				}
			}
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel && this._type != null && (!(this._type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType) || this._returnTypeCollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionWithNonPrimitiveTypeNotSupported, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.FunctionWithNonPrimitiveTypeNotSupported(global::System.Data.Entity.Core.SchemaObjectModel.Function.GetTypeNameForErrorMessage(this._type, this._returnTypeCollectionKind, this._isRefType), this.FQName));
			}
			if (this._returnTypeList != null)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.ReturnType returnType in this._returnTypeList)
				{
					returnType.Validate();
				}
			}
			if (this._parameters != null)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter in this._parameters)
				{
					parameter.Validate();
				}
			}
			if (this._commandText != null)
			{
				this._commandText.Validate();
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x00065030 File Offset: 0x00063230
		internal override void ResolveSecondLevelNames()
		{
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter in this._parameters)
			{
				parameter.ResolveSecondLevelNames();
			}
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x0006507C File Offset: 0x0006327C
		internal override global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement Clone(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement)
		{
			throw global::System.Data.Entity.Resources.Error.NotImplemented();
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x00065084 File Offset: 0x00063284
		protected void CloneSetFunctionFields(global::System.Data.Entity.Core.SchemaObjectModel.Function clone)
		{
			clone._isAggregate = this._isAggregate;
			clone._isBuiltIn = this._isBuiltIn;
			clone._isNiladicFunction = this._isNiladicFunction;
			clone._isComposable = this._isComposable;
			clone._commandText = this._commandText;
			clone._storeFunctionName = this._storeFunctionName;
			clone._type = this._type;
			clone._returnTypeList = this._returnTypeList;
			clone._returnTypeCollectionKind = this._returnTypeCollectionKind;
			clone._parameterTypeSemantics = this._parameterTypeSemantics;
			clone._schema = this._schema;
			clone.Name = this.Name;
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter in this.Parameters)
			{
				clone.Parameters.TryAdd((global::System.Data.Entity.Core.SchemaObjectModel.Parameter)parameter.Clone(clone));
			}
		}

		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06002409 RID: 9225 RVA: 0x00065174 File Offset: 0x00063374
		// (set) Token: 0x0600240A RID: 9226 RVA: 0x0006517C File Offset: 0x0006337C
		internal string UnresolvedReturnType
		{
			get
			{
				return this._unresolvedType;
			}
			set
			{
				this._unresolvedType = value;
			}
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x00065185 File Offset: 0x00063385
		private void HandleDbSchemaAttribute(global::System.Xml.XmlReader reader)
		{
			this._schema = reader.Value;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x00065194 File Offset: 0x00063394
		private void HandleAggregateAttribute(global::System.Xml.XmlReader reader)
		{
			bool isAggregate = false;
			base.HandleBoolAttribute(reader, ref isAggregate);
			this.IsAggregate = isAggregate;
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x000651B4 File Offset: 0x000633B4
		private void HandleBuiltInAttribute(global::System.Xml.XmlReader reader)
		{
			bool isBuiltIn = false;
			base.HandleBoolAttribute(reader, ref isBuiltIn);
			this.IsBuiltIn = isBuiltIn;
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x000651D4 File Offset: 0x000633D4
		private void HandleStoreFunctionNameAttribute(global::System.Xml.XmlReader reader)
		{
			string text = reader.Value;
			if (!string.IsNullOrEmpty(text))
			{
				text = text.Trim();
				this.StoreFunctionName = text;
			}
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x00065200 File Offset: 0x00063400
		private void HandleNiladicFunctionAttribute(global::System.Xml.XmlReader reader)
		{
			bool isNiladicFunction = false;
			base.HandleBoolAttribute(reader, ref isNiladicFunction);
			this.IsNiladicFunction = isNiladicFunction;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x00065220 File Offset: 0x00063420
		private void HandleIsComposableAttribute(global::System.Xml.XmlReader reader)
		{
			bool isComposable = true;
			base.HandleBoolAttribute(reader, ref isComposable);
			this.IsComposable = isComposable;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x00065240 File Offset: 0x00063440
		private void HandleCommandTextFunctionElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.FunctionCommandText functionCommandText = new global::System.Data.Entity.Core.SchemaObjectModel.FunctionCommandText(this);
			functionCommandText.Parse(reader);
			this._commandText = functionCommandText;
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x00065264 File Offset: 0x00063464
		protected virtual void HandleReturnTypeAttribute(global::System.Xml.XmlReader reader)
		{
			string text;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out text))
			{
				return;
			}
			global::System.Data.Entity.Core.SchemaObjectModel.TypeModifier typeModifier;
			global::System.Data.Entity.Core.SchemaObjectModel.Function.RemoveTypeModifier(ref text, out typeModifier, out this._isRefType);
			if (typeModifier != global::System.Data.Entity.Core.SchemaObjectModel.TypeModifier.None && typeModifier == global::System.Data.Entity.Core.SchemaObjectModel.TypeModifier.Array)
			{
				this.CollectionKind = global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag;
			}
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.ValidateDottedName(base.Schema, reader, text))
			{
				return;
			}
			this.UnresolvedReturnType = text;
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x000652B8 File Offset: 0x000634B8
		protected void HandleParameterElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter = new global::System.Data.Entity.Core.SchemaObjectModel.Parameter(this);
			parameter.Parse(reader);
			this.Parameters.Add(parameter, true, new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.ParameterNameAlreadyDefinedDuplicate));
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x000652EC File Offset: 0x000634EC
		protected void HandleReturnTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReturnType returnType = new global::System.Data.Entity.Core.SchemaObjectModel.ReturnType(this);
			returnType.Parse(reader);
			if (this._returnTypeList == null)
			{
				this._returnTypeList = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.ReturnType>();
			}
			this._returnTypeList.Add(returnType);
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x00065328 File Offset: 0x00063528
		private void HandleParameterTypeSemanticsAttribute(global::System.Xml.XmlReader reader)
		{
			string text = reader.Value;
			if (string.IsNullOrEmpty(text))
			{
				return;
			}
			text = text.Trim();
			if (!string.IsNullOrEmpty(text))
			{
				if (text != null)
				{
					if (text == "ExactMatchOnly")
					{
						this.ParameterTypeSemantics = global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics.ExactMatchOnly;
						return;
					}
					if (text == "AllowImplicitPromotion")
					{
						this.ParameterTypeSemantics = global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics.AllowImplicitPromotion;
						return;
					}
					if (text == "AllowImplicitConversion")
					{
						this.ParameterTypeSemantics = global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics.AllowImplicitConversion;
						return;
					}
				}
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidValueForParameterTypeSemantics, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.InvalidValueForParameterTypeSemanticsAttribute(text));
			}
		}

		// Token: 0x04000CD1 RID: 3281
		private bool _isAggregate;

		// Token: 0x04000CD2 RID: 3282
		private bool _isBuiltIn;

		// Token: 0x04000CD3 RID: 3283
		private bool _isNiladicFunction;

		// Token: 0x04000CD4 RID: 3284
		protected bool _isComposable = true;

		// Token: 0x04000CD5 RID: 3285
		protected global::System.Data.Entity.Core.SchemaObjectModel.FunctionCommandText _commandText;

		// Token: 0x04000CD6 RID: 3286
		private string _storeFunctionName;

		// Token: 0x04000CD7 RID: 3287
		protected global::System.Data.Entity.Core.SchemaObjectModel.SchemaType _type;

		// Token: 0x04000CD8 RID: 3288
		private string _unresolvedType;

		// Token: 0x04000CD9 RID: 3289
		protected bool _isRefType;

		// Token: 0x04000CDA RID: 3290
		protected global::System.Data.Entity.Core.SchemaObjectModel.SchemaElementLookUpTable<global::System.Data.Entity.Core.SchemaObjectModel.Parameter> _parameters;

		// Token: 0x04000CDB RID: 3291
		protected global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.ReturnType> _returnTypeList;

		// Token: 0x04000CDC RID: 3292
		private global::System.Data.Entity.Core.Metadata.Edm.CollectionKind _returnTypeCollectionKind;

		// Token: 0x04000CDD RID: 3293
		private global::System.Data.Entity.Core.Metadata.Edm.ParameterTypeSemantics _parameterTypeSemantics;

		// Token: 0x04000CDE RID: 3294
		private string _schema;

		// Token: 0x04000CDF RID: 3295
		private string _functionStrongName;

		// Token: 0x04000CE0 RID: 3296
		private static readonly global::System.Text.RegularExpressions.Regex _typeParser = new global::System.Text.RegularExpressions.Regex("^(?<modifier>((Collection)|(Ref)))\\s*\\(\\s*(?<typeName>\\S*)\\s*\\)$", global::System.Text.RegularExpressions.RegexOptions.Compiled);
	}
}
