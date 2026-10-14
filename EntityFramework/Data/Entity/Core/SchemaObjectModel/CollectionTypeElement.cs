using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002E5 RID: 741
	internal class CollectionTypeElement : global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement
	{
		// Token: 0x06002352 RID: 9042 RVA: 0x00062906 File Offset: 0x00060B06
		internal CollectionTypeElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement)
		{
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x0006290F File Offset: 0x00060B0F
		internal global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement SubElement
		{
			get
			{
				return this._typeSubElement;
			}
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00062917 File Offset: 0x00060B17
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "ElementType"))
			{
				this.HandleElementTypeAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x0006293C File Offset: 0x00060B3C
		protected void HandleElementTypeAttribute(global::System.Xml.XmlReader reader)
		{
			string text;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out text))
			{
				return;
			}
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.ValidateDottedName(base.Schema, reader, text))
			{
				return;
			}
			this._unresolvedType = text;
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x00062974 File Offset: 0x00060B74
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

		// Token: 0x06002357 RID: 9047 RVA: 0x000629E0 File Offset: 0x00060BE0
		protected void HandleCollectionTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement collectionTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.CollectionTypeElement(this);
			collectionTypeElement.Parse(reader);
			this._typeSubElement = collectionTypeElement;
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x00062A04 File Offset: 0x00060C04
		protected void HandleReferenceTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReferenceTypeElement referenceTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.ReferenceTypeElement(this);
			referenceTypeElement.Parse(reader);
			this._typeSubElement = referenceTypeElement;
		}

		// Token: 0x06002359 RID: 9049 RVA: 0x00062A28 File Offset: 0x00060C28
		protected void HandleTypeRefElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.TypeRefElement typeRefElement = new global::System.Data.Entity.Core.SchemaObjectModel.TypeRefElement(this);
			typeRefElement.Parse(reader);
			this._typeSubElement = typeRefElement;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x00062A4C File Offset: 0x00060C4C
		protected void HandleRowTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement rowTypeElement = new global::System.Data.Entity.Core.SchemaObjectModel.RowTypeElement(this);
			rowTypeElement.Parse(reader);
			this._typeSubElement = rowTypeElement;
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x00062A6E File Offset: 0x00060C6E
		internal override void ResolveTopLevelNames()
		{
			if (this._typeSubElement != null)
			{
				this._typeSubElement.ResolveTopLevelNames();
			}
			if (this._unresolvedType != null)
			{
				base.ResolveTopLevelNames();
			}
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00062A94 File Offset: 0x00060C94
		internal override void WriteIdentity(global::System.Text.StringBuilder builder)
		{
			if (!string.IsNullOrWhiteSpace(base.UnresolvedType))
			{
				builder.Append("Collection(" + base.UnresolvedType + ")");
				return;
			}
			builder.Append("Collection(");
			this._typeSubElement.WriteIdentity(builder);
			builder.Append(")");
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00062AF0 File Offset: 0x00060CF0
		internal override global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GetTypeUsage()
		{
			if (this._typeUsage != null)
			{
				return this._typeUsage;
			}
			if (this._typeSubElement != null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.CollectionType collectionType = new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this._typeSubElement.GetTypeUsage());
				collectionType.AddMetadataProperties(base.OtherContent);
				this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(collectionType);
			}
			return this._typeUsage;
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00062B44 File Offset: 0x00060D44
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
				this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this._typeUsageBuilder.TypeUsage));
				return true;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = (global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(this._type, this._type.Schema.ProviderManifest, convertedItemCache, newGlobalItems);
			if (edmType != null)
			{
				this._typeUsageBuilder.ValidateAndSetTypeUsage(edmType, false);
				this._typeUsage = global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(new global::System.Data.Entity.Core.Metadata.Edm.CollectionType(this._typeUsageBuilder.TypeUsage));
			}
			return this._typeUsage != null;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00062C0C File Offset: 0x00060E0C
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateFacets(this, this._type, this._typeUsageBuilder);
			global::System.Data.Entity.Core.SchemaObjectModel.ValidationHelper.ValidateTypeDeclaration(this, this._type, this._typeSubElement);
			if (this._typeSubElement != null)
			{
				this._typeSubElement.Validate();
			}
		}

		// Token: 0x04000C16 RID: 3094
		private global::System.Data.Entity.Core.SchemaObjectModel.ModelFunctionTypeElement _typeSubElement;
	}
}
