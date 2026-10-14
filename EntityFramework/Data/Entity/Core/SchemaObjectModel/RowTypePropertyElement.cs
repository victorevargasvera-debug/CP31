using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200030E RID: 782
	internal class RowTypePropertyElement : global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement
	{
		// Token: 0x0600250A RID: 9482 RVA: 0x000683EC File Offset: 0x000665EC
		internal RowTypePropertyElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement)
		{
			this._typeUsageBuilder = new global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder(this);
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x00068401 File Offset: 0x00066601
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

		// Token: 0x0600250C RID: 9484 RVA: 0x00068424 File Offset: 0x00066624
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
			return false;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x00068448 File Offset: 0x00066648
		protected void HandleTypeAttribute(global::System.Xml.XmlReader reader)
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
			this._unresolvedType = text;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x00068498 File Offset: 0x00066698
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
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

		// Token: 0x0600250F RID: 9487 RVA: 0x00068504 File Offset: 0x00066704
		protected void HandleCollectionTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement collectionTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement(this);
			collectionTypeElement.Parse(reader);
			this._typeSubElement = collectionTypeElement;
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x00068528 File Offset: 0x00066728
		protected void HandleReferenceTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReferenceTypeElement referenceTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.ReferenceTypeElement(this);
			referenceTypeElement.Parse(reader);
			this._typeSubElement = referenceTypeElement;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x0006854C File Offset: 0x0006674C
		protected void HandleTypeRefElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.TypeRefElement typeRefElement = new global::System.Data.Entity.Core.SchemaObjectModel.TypeRefElement(this);
			typeRefElement.Parse(reader);
			this._typeSubElement = typeRefElement;
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x00068570 File Offset: 0x00066770
		protected void HandleRowTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement rowTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement(this);
			rowTypeElement.Parse(reader);
			this._typeSubElement = rowTypeElement;
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x00068594 File Offset: 0x00066794
		internal override void WriteIdentity(global::System.Text.StringBuilder builder)
		{
			builder.Append("Property(");
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
			else
			{
				this._typeSubElement.WriteIdentity(builder);
			}
			builder.Append(")");
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x0006862D File Offset: 0x0006682D
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage()
		{
			if (this._typeUsage != null)
			{
				return this._typeUsage;
			}
			if (this._typeSubElement != null)
			{
				this._typeUsage = this._typeSubElement.GetTypeUsage();
			}
			return this._typeUsage;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x00068660 File Offset: 0x00066860
		internal override bool ResolveNameAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			if (this._typeUsage != null)
			{
				return true;
			}
			if (this._typeSubElement != null)
			{
				return this._typeSubElement.ResolveNameAndSetTypeUsage(convertedItemCache, newGlobalItems);
			}
			if (this._type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType)
			{
				this._typeUsageBuilder.ValidateAndSetTypeUsage(this._type as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType, false);
				this._typeUsage = this._typeUsageBuilder.TypeUsage;
			}
			else
			{
				global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = (global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(this._type, this._type.Schema.ProviderManifest, convertedItemCache, newGlobalItems);
				if (edmType != null)
				{
					if (this._isRefType)
					{
						global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType = edmType as global::System.Data.Entity.Core.Metadata.Edm.EntityType;
						this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.RefType(entityType));
					}
					else
					{
						this._typeUsageBuilder.ValidateAndSetTypeUsage(edmType, false);
						this._typeUsage = this._typeUsageBuilder.TypeUsage;
					}
				}
			}
			if (this._collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
			{
				this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this._typeUsage));
			}
			return this._typeUsage != null;
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x00068754 File Offset: 0x00066954
		internal bool ValidateIsScalar()
		{
			if (this._type != null)
			{
				if (!(this._type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType) || this._isRefType || this._collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					return false;
				}
			}
			else if (this._typeSubElement != null && !(this._typeSubElement.Type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType))
			{
				return false;
			}
			return true;
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000687A8 File Offset: 0x000669A8
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateFacets(this, this._type, this._typeUsageBuilder);
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateTypeDeclaration(this, this._type, this._typeSubElement);
			if (this._isRefType)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateRefType(this, this._type);
			}
			if (this._typeSubElement != null)
			{
				this._typeSubElement.Validate();
			}
		}

		// Token: 0x04000D16 RID: 3350
		private global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement _typeSubElement;

		// Token: 0x04000D17 RID: 3351
		private bool _isRefType;

		// Token: 0x04000D18 RID: 3352
		private global::System.Data.Entity.Core.Metadata.Edm.CollectionKind _collectionKind;
	}
}
