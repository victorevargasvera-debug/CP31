using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000300 RID: 768
	internal class Parameter : global::System.Data.Entity.Core.SchemaObjectModel.FacetEnabledSchemaElement
	{
		// Token: 0x0600246E RID: 9326 RVA: 0x00066151 File Offset: 0x00064351
		internal Parameter(global::System.Data.Entity.Core.SchemaObjectModel.Function parentElement) : base(parentElement)
		{
			this._typeUsageBuilder = new global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder(this);
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x0600246F RID: 9327 RVA: 0x0006616D File Offset: 0x0006436D
		internal global::System.Data.ParameterDirection ParameterDirection
		{
			get
			{
				return this._parameterDirection;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x00066175 File Offset: 0x00064375
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x0006617D File Offset: 0x0006437D
		internal global::System.Data.Entity.Core.Metadata.Edm.CollectionKind CollectionKind
		{
			get
			{
				return this._collectionKind;
			}
			set
			{
				this._collectionKind = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x00066186 File Offset: 0x00064386
		internal bool IsRefType
		{
			get
			{
				return this._isRefType;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x06002473 RID: 9331 RVA: 0x0006618E File Offset: 0x0006438E
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				if (this._typeSubElement != null)
				{
					return this._typeSubElement.GetTypeUsage();
				}
				if (base.TypeUsage == null)
				{
					return null;
				}
				if (this.CollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(base.TypeUsage));
				}
				return base.TypeUsage;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000661CD File Offset: 0x000643CD
		internal new global::System.Data.Entity.Core.SchemaObjectModel.SchemaType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06002475 RID: 9333 RVA: 0x000661D8 File Offset: 0x000643D8
		internal void WriteIdentity(global::System.Text.StringBuilder builder)
		{
			builder.Append("Parameter(");
			if (!string.IsNullOrWhiteSpace(base.UnresolvedType))
			{
				if (this._collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					builder.Append("Collection(" + base.UnresolvedType + ")");
				}
				else if (this._isRefType)
				{
					builder.Append("Ref(" + base.UnresolvedType + ")");
				}
				else
				{
					builder.Append(base.UnresolvedType);
				}
			}
			else if (this._typeSubElement != null)
			{
				this._typeSubElement.WriteIdentity(builder);
			}
			builder.Append(")");
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0006627C File Offset: 0x0006447C
		internal override global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement Clone(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement)
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.Parameter((global::System.Data.Entity.Core.SchemaObjectModel.Function)parentElement)
			{
				_collectionKind = this._collectionKind,
				_parameterDirection = this._parameterDirection,
				_type = this._type,
				Name = this.Name,
				_typeUsageBuilder = this._typeUsageBuilder
			};
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x000662D0 File Offset: 0x000644D0
		internal bool ResolveNestedTypeNames(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			return this._typeSubElement != null && this._typeSubElement.ResolveNameAndSetTypeUsage(convertedItemCache, newGlobalItems);
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x000662EC File Offset: 0x000644EC
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Type"))
			{
				this.HandleTypeAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Mode"))
			{
				this.HandleModeAttribute(reader);
				return true;
			}
			return this._typeUsageBuilder.HandleAttribute(reader);
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00066344 File Offset: 0x00064544
		private void HandleTypeAttribute(global::System.Xml.XmlReader reader)
		{
			string text;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out text))
			{
				return;
			}
			global::System.Data.Entity.Core.SchemaObjectModel.TypeModifier typeModifier;
			global::System.Data.Entity.Core.SchemaObjectModel.Function.RemoveTypeModifier(ref text, out typeModifier, out this._isRefType);
			if (typeModifier == global::System.Data.Entity.Core.SchemaObjectModel.TypeModifier.Array)
			{
				this.CollectionKind = global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag;
			}
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.ValidateDottedName(base.Schema, reader, text))
			{
				return;
			}
			base.UnresolvedType = text;
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00066394 File Offset: 0x00064594
		private void HandleModeAttribute(global::System.Xml.XmlReader reader)
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
					if (text == "In")
					{
						this._parameterDirection = global::System.Data.ParameterDirection.Input;
						return;
					}
					if (!(text == "Out"))
					{
						if (text == "InOut")
						{
							this._parameterDirection = global::System.Data.ParameterDirection.InputOutput;
							if (base.ParentElement.IsComposable && base.ParentElement.IsFunctionImport)
							{
								this.AddErrorBadParameterDirection(text, reader, new global::System.Func<object, object, object, object, string>(global::System.Data.Entity.Resources.Strings.BadParameterDirectionForComposableFunctions));
								return;
							}
							return;
						}
					}
					else
					{
						this._parameterDirection = global::System.Data.ParameterDirection.Output;
						if (base.ParentElement.IsComposable && base.ParentElement.IsFunctionImport)
						{
							this.AddErrorBadParameterDirection(text, reader, new global::System.Func<object, object, object, object, string>(global::System.Data.Entity.Resources.Strings.BadParameterDirectionForComposableFunctions));
							return;
						}
						return;
					}
				}
				this.AddErrorBadParameterDirection(text, reader, new global::System.Func<object, object, object, object, string>(global::System.Data.Entity.Resources.Strings.BadParameterDirection));
			}
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0006647C File Offset: 0x0006467C
		private void AddErrorBadParameterDirection(string value, global::System.Xml.XmlReader reader, global::System.Func<object, object, object, object, string> errorFunc)
		{
			base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadParameterDirection, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, errorFunc(base.ParentElement.Parameters.Count, base.ParentElement.Name, base.ParentElement.ParentElement.FQName, value));
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x000664CC File Offset: 0x000646CC
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "CollectionType"))
			{
				this.HandleCollectionTypeElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "ReferenceType"))
			{
				this.HandleReferenceTypeElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "TypeRef"))
			{
				this.HandleTypeRefElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "RowType"))
			{
				this.HandleRowTypeElement(reader);
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

		// Token: 0x0600247D RID: 9341 RVA: 0x0006657C File Offset: 0x0006477C
		protected void HandleCollectionTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement collectionTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement(this);
			collectionTypeElement.Parse(reader);
			this._typeSubElement = collectionTypeElement;
		}

		// Token: 0x0600247E RID: 9342 RVA: 0x000665A0 File Offset: 0x000647A0
		protected void HandleReferenceTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReferenceTypeElement referenceTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.ReferenceTypeElement(this);
			referenceTypeElement.Parse(reader);
			this._typeSubElement = referenceTypeElement;
		}

		// Token: 0x0600247F RID: 9343 RVA: 0x000665C4 File Offset: 0x000647C4
		protected void HandleTypeRefElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.TypeRefElement typeRefElement = new global::System.Data.Entity.Core.SchemaObjectModel.TypeRefElement(this);
			typeRefElement.Parse(reader);
			this._typeSubElement = typeRefElement;
		}

		// Token: 0x06002480 RID: 9344 RVA: 0x000665E8 File Offset: 0x000647E8
		protected void HandleRowTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement rowTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement(this);
			rowTypeElement.Parse(reader);
			this._typeSubElement = rowTypeElement;
		}

		// Token: 0x06002481 RID: 9345 RVA: 0x0006660A File Offset: 0x0006480A
		internal override void ResolveTopLevelNames()
		{
			if (this._unresolvedType != null)
			{
				base.ResolveTopLevelNames();
			}
			if (this._typeSubElement != null)
			{
				this._typeSubElement.ResolveTopLevelNames();
			}
		}

		// Token: 0x06002482 RID: 9346 RVA: 0x00066630 File Offset: 0x00064830
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateTypeDeclaration(this, this._type, this._typeSubElement);
			if (base.Schema.DataModel != global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				bool isAggregate = base.ParentElement.IsAggregate;
				if (this._type != null && (!(this._type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType) || (!isAggregate && this._collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)))
				{
					string p = "";
					if (this._type != null)
					{
						p = global::System.Data.Entity.Core.SchemaObjectModel.Function.GetTypeNameForErrorMessage(this._type, this._collectionKind, this._isRefType);
					}
					else if (this._typeSubElement != null)
					{
						p = this._typeSubElement.FQName;
					}
					if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderManifestModel)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionWithNonEdmTypeNotSupported, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.FunctionWithNonEdmPrimitiveTypeNotSupported(p, base.ParentElement.FQName));
						return;
					}
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionWithNonPrimitiveTypeNotSupported, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.FunctionWithNonPrimitiveTypeNotSupported(p, base.ParentElement.FQName));
					return;
				}
			}
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateFacets(this, this._type, this._typeUsageBuilder);
			if (this._isRefType)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateRefType(this, this._type);
			}
			if (this._typeSubElement != null)
			{
				this._typeSubElement.Validate();
			}
		}

		// Token: 0x04000CF7 RID: 3319
		private global::System.Data.ParameterDirection _parameterDirection = global::System.Data.ParameterDirection.Input;

		// Token: 0x04000CF8 RID: 3320
		private global::System.Data.Entity.Core.Metadata.Edm.CollectionKind _collectionKind;

		// Token: 0x04000CF9 RID: 3321
		private global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement _typeSubElement;

		// Token: 0x04000CFA RID: 3322
		private bool _isRefType;
	}
}
