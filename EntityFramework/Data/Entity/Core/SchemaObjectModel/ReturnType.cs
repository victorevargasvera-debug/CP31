using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200030B RID: 779
	internal class ReturnType : global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement
	{
		// Token: 0x060024E6 RID: 9446 RVA: 0x00067B48 File Offset: 0x00065D48
		internal ReturnType(global::System.Data.Entity.Core.SchemaObjectModel.Function parentElement) : base(parentElement)
		{
			this._typeUsageBuilder = new global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder(this);
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060024E7 RID: 9447 RVA: 0x00067B5D File Offset: 0x00065D5D
		internal bool IsRefType
		{
			get
			{
				return this._isRefType;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060024E8 RID: 9448 RVA: 0x00067B65 File Offset: 0x00065D65
		internal global::System.Data.Entity.Core.Metadata.Edm.CollectionKind CollectionKind
		{
			get
			{
				return this._collectionKind;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060024E9 RID: 9449 RVA: 0x00067B6D File Offset: 0x00065D6D
		internal global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet EntitySet
		{
			get
			{
				return this._entitySet;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060024EA RID: 9450 RVA: 0x00067B75 File Offset: 0x00065D75
		internal bool EntitySetPathDefined
		{
			get
			{
				return this._entitySetPathDefined;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060024EB RID: 9451 RVA: 0x00067B7D File Offset: 0x00065D7D
		internal global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement SubElement
		{
			get
			{
				return this._typeSubElement;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x00067B88 File Offset: 0x00065D88
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				if (this._typeSubElement != null)
				{
					return this._typeSubElement.GetTypeUsage();
				}
				if (this._typeUsage != null)
				{
					return this._typeUsage;
				}
				if (base.TypeUsage == null)
				{
					return null;
				}
				if (this._collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(base.TypeUsage));
				}
				return base.TypeUsage;
			}
		}

		// Token: 0x060024ED RID: 9453 RVA: 0x00067BE4 File Offset: 0x00065DE4
		internal override global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement Clone(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement)
		{
			return new global::System.Data.Entity.Core.SchemaObjectModel.ReturnType((global::System.Data.Entity.Core.SchemaObjectModel.Function)parentElement)
			{
				_type = this._type,
				Name = this.Name,
				_typeUsageBuilder = this._typeUsageBuilder,
				_unresolvedType = this._unresolvedType,
				_unresolvedEntitySet = this._unresolvedEntitySet,
				_entitySetPathDefined = this._entitySetPathDefined,
				_entitySet = this._entitySet
			};
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x00067C50 File Offset: 0x00065E50
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
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "EntitySet"))
			{
				this.HandleEntitySetAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "EntitySetPath"))
			{
				this.HandleEntitySetPathAttribute(reader);
				return true;
			}
			return this._typeUsageBuilder.HandleAttribute(reader);
		}

		// Token: 0x060024EF RID: 9455 RVA: 0x00067CBB File Offset: 0x00065EBB
		internal bool ResolveNestedTypeNames(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			return this._typeSubElement.ResolveNameAndSetTypeUsage(convertedItemCache, newGlobalItems);
		}

		// Token: 0x060024F0 RID: 9456 RVA: 0x00067CCC File Offset: 0x00065ECC
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
				this._collectionKind = global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag;
			}
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.ValidateDottedName(base.Schema, reader, text))
			{
				return;
			}
			base.UnresolvedType = text;
		}

		// Token: 0x060024F1 RID: 9457 RVA: 0x00067D1C File Offset: 0x00065F1C
		private void HandleEntitySetAttribute(global::System.Xml.XmlReader reader)
		{
			string unresolvedEntitySet;
			if (global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out unresolvedEntitySet))
			{
				this._unresolvedEntitySet = unresolvedEntitySet;
			}
		}

		// Token: 0x060024F2 RID: 9458 RVA: 0x00067D40 File Offset: 0x00065F40
		private void HandleEntitySetPathAttribute(global::System.Xml.XmlReader reader)
		{
			string text;
			if (global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out text))
			{
				this._entitySetPathDefined = true;
			}
		}

		// Token: 0x060024F3 RID: 9459 RVA: 0x00067D64 File Offset: 0x00065F64
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
			return false;
		}

		// Token: 0x060024F4 RID: 9460 RVA: 0x00067DDC File Offset: 0x00065FDC
		protected void HandleCollectionTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement collectionTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement(this);
			collectionTypeElement.Parse(reader);
			this._typeSubElement = collectionTypeElement;
		}

		// Token: 0x060024F5 RID: 9461 RVA: 0x00067E00 File Offset: 0x00066000
		protected void HandleReferenceTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReferenceTypeElement referenceTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.ReferenceTypeElement(this);
			referenceTypeElement.Parse(reader);
			this._typeSubElement = referenceTypeElement;
		}

		// Token: 0x060024F6 RID: 9462 RVA: 0x00067E24 File Offset: 0x00066024
		protected void HandleTypeRefElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.TypeRefElement typeRefElement = new global::System.Data.Entity.Core.SchemaObjectModel.TypeRefElement(this);
			typeRefElement.Parse(reader);
			this._typeSubElement = typeRefElement;
		}

		// Token: 0x060024F7 RID: 9463 RVA: 0x00067E48 File Offset: 0x00066048
		protected void HandleRowTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement rowTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement(this);
			rowTypeElement.Parse(reader);
			this._typeSubElement = rowTypeElement;
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x00067E6C File Offset: 0x0006606C
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
			if (base.ParentElement.IsFunctionImport && this._unresolvedEntitySet != null)
			{
				((global::System.Data.Entity.Core.SchemaObjectModel.FunctionImportElement)base.ParentElement).ResolveEntitySet(this, this._unresolvedEntitySet, ref this._entitySet);
			}
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00067ECC File Offset: 0x000660CC
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateTypeDeclaration(this, this._type, this._typeSubElement);
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateFacets(this, this._type, this._typeUsageBuilder);
			if (this._isRefType)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateRefType(this, this._type);
			}
			if (base.Schema.DataModel != global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderManifestModel)
				{
					if ((this._type != null && (!(this._type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType) || this._collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)) || (this._typeSubElement != null && !(this._typeSubElement.Type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType)))
					{
						string p2 = "";
						if (this._type != null)
						{
							p2 = global::System.Data.Entity.Core.SchemaObjectModel.Function.GetTypeNameForErrorMessage(this._type, this._collectionKind, this._isRefType);
						}
						else if (this._typeSubElement != null)
						{
							p2 = this._typeSubElement.FQName;
						}
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionWithNonEdmTypeNotSupported, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.FunctionWithNonEdmPrimitiveTypeNotSupported(p2, base.ParentElement.FQName));
					}
				}
				else if (this._type != null)
				{
					if (!(this._type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType) || this._collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionWithNonPrimitiveTypeNotSupported, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.FunctionWithNonPrimitiveTypeNotSupported(this._isRefType ? this._unresolvedType : this._type.FQName, base.ParentElement.FQName));
					}
				}
				else if (this._typeSubElement != null && !(this._typeSubElement.Type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType))
				{
					if (base.Schema.SchemaVersion < 3.0)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionWithNonPrimitiveTypeNotSupported, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.FunctionWithNonPrimitiveTypeNotSupported(this._typeSubElement.FQName, base.ParentElement.FQName));
					}
					else
					{
						global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement collectionTypeElement = this._typeSubElement as global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement;
						if (collectionTypeElement != null)
						{
							global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement rowTypeElement = collectionTypeElement.SubElement as global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement;
							if (rowTypeElement != null)
							{
								if (rowTypeElement.Properties.Any((global::System.Data.Entity.Core.SchemaObjectModel.RowTypePropertyElement p) => !p.ValidateIsScalar()))
								{
									base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.TVFReturnTypeRowHasNonScalarProperty, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, this, global::System.Data.Entity.Resources.Strings.TVFReturnTypeRowHasNonScalarProperty);
								}
							}
						}
					}
				}
			}
			if (this._typeSubElement != null)
			{
				this._typeSubElement.Validate();
			}
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x000680FA File Offset: 0x000662FA
		internal override void WriteIdentity(global::System.Text.StringBuilder builder)
		{
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x000680FC File Offset: 0x000662FC
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage()
		{
			return this.TypeUsage;
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x00068104 File Offset: 0x00066304
		internal override bool ResolveNameAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			return false;
		}

		// Token: 0x04000D0D RID: 3341
		private global::System.Data.Entity.Core.Metadata.Edm.CollectionKind _collectionKind;

		// Token: 0x04000D0E RID: 3342
		private bool _isRefType;

		// Token: 0x04000D0F RID: 3343
		private string _unresolvedEntitySet;

		// Token: 0x04000D10 RID: 3344
		private bool _entitySetPathDefined;

		// Token: 0x04000D11 RID: 3345
		private global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement _typeSubElement;

		// Token: 0x04000D12 RID: 3346
		private global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet _entitySet;
	}
}
