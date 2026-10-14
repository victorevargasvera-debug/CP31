using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x0200031E RID: 798
	internal class StructuredProperty : global::System.Data.Entity.Core.SchemaObjectModel.Property
	{
		// Token: 0x060025EB RID: 9707 RVA: 0x0006B6F1 File Offset: 0x000698F1
		internal StructuredProperty(global::System.Data.Entity.Core.SchemaObjectModel.StructuredType parentElement) : base(parentElement)
		{
			this._typeUsageBuilder = new global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder(this);
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x060025EC RID: 9708 RVA: 0x0006B706 File Offset: 0x00069906
		public override global::System.Data.Entity.Core.SchemaObjectModel.SchemaType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x060025ED RID: 9709 RVA: 0x0006B70E File Offset: 0x0006990E
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				return this._typeUsageBuilder.TypeUsage;
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x060025EE RID: 9710 RVA: 0x0006B71B File Offset: 0x0006991B
		public bool Nullable
		{
			get
			{
				return this._typeUsageBuilder.Nullable;
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x060025EF RID: 9711 RVA: 0x0006B728 File Offset: 0x00069928
		public string Default
		{
			get
			{
				return this._typeUsageBuilder.Default;
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x060025F0 RID: 9712 RVA: 0x0006B735 File Offset: 0x00069935
		public object DefaultAsObject
		{
			get
			{
				return this._typeUsageBuilder.DefaultAsObject;
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x060025F1 RID: 9713 RVA: 0x0006B742 File Offset: 0x00069942
		public global::System.Data.Entity.Core.Metadata.Edm.CollectionKind CollectionKind
		{
			get
			{
				return this._collectionKind;
			}
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x0006B74C File Offset: 0x0006994C
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (this._type != null)
			{
				return;
			}
			this._type = this.ResolveType(this.UnresolvedType);
			this._typeUsageBuilder.ValidateDefaultValue(this._type);
			global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalarType = this._type as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType;
			if (scalarType != null)
			{
				this._typeUsageBuilder.ValidateAndSetTypeUsage(scalarType, true);
			}
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x0006B7A8 File Offset: 0x000699A8
		internal void EnsureEnumTypeFacets(global::System.Data.Entity.Core.Metadata.Edm.Converter.ConversionCache convertedItemCache, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement, global::System.Data.Entity.Core.Metadata.Edm.GlobalItem> newGlobalItems)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = (global::System.Data.Entity.Core.Metadata.Edm.EdmType)global::System.Data.Entity.Core.Metadata.Edm.Converter.LoadSchemaElement(this.Type, this.Type.Schema.ProviderManifest, convertedItemCache, newGlobalItems);
			this._typeUsageBuilder.ValidateAndSetTypeUsage(edmType, false);
		}

		// Token: 0x060025F4 RID: 9716 RVA: 0x0006B7E8 File Offset: 0x000699E8
		protected virtual global::System.Data.Entity.Core.SchemaObjectModel.SchemaType ResolveType(string typeName)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType;
			if (!base.Schema.ResolveTypeName(this, typeName, out schemaType))
			{
				return null;
			}
			if (!(schemaType is global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType) && !(schemaType is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType) && !(schemaType is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidPropertyType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidPropertyType(this.UnresolvedType));
				return null;
			}
			return schemaType;
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x060025F5 RID: 9717 RVA: 0x0006B837 File Offset: 0x00069A37
		// (set) Token: 0x060025F6 RID: 9718 RVA: 0x0006B83F File Offset: 0x00069A3F
		internal string UnresolvedType { get; set; }

		// Token: 0x060025F7 RID: 9719 RVA: 0x0006B848 File Offset: 0x00069A48
		internal override void Validate()
		{
			base.Validate();
			if (this._collectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag)
			{
				global::System.Data.Entity.Core.Metadata.Edm.CollectionKind collectionKind = this._collectionKind;
			}
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType schemaEnumType = this._type as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType;
			if (schemaEnumType != null)
			{
				this._typeUsageBuilder.ValidateEnumFacets(schemaEnumType);
				return;
			}
			if (this.Nullable && base.Schema.SchemaVersion != 1.1 && this._type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.NullableComplexType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.ComplexObject_NullableComplexTypesNotSupported(this.FQName));
			}
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x0006B8CC File Offset: 0x00069ACC
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
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "CollectionKind"))
			{
				this.HandleCollectionKindAttribute(reader);
				return true;
			}
			return this._typeUsageBuilder.HandleAttribute(reader);
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x0006B924 File Offset: 0x00069B24
		private void HandleTypeAttribute(global::System.Xml.XmlReader reader)
		{
			if (this.UnresolvedType != null)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, reader, global::System.Data.Entity.Resources.Strings.PropertyTypeAlreadyDefined(reader.Name));
				return;
			}
			string unresolvedType;
			if (!global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetDottedName(base.Schema, reader, out unresolvedType))
			{
				return;
			}
			this.UnresolvedType = unresolvedType;
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x0006B968 File Offset: 0x00069B68
		private void HandleCollectionKindAttribute(global::System.Xml.XmlReader reader)
		{
			string value = reader.Value;
			if (value == "None")
			{
				this._collectionKind = global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None;
				return;
			}
			if (value == "List")
			{
				this._collectionKind = global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.List;
				return;
			}
			if (value == "Bag")
			{
				this._collectionKind = global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag;
				return;
			}
		}

		// Token: 0x04000D53 RID: 3411
		private global::System.Data.Entity.Core.SchemaObjectModel.SchemaType _type;

		// Token: 0x04000D54 RID: 3412
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder _typeUsageBuilder;

		// Token: 0x04000D55 RID: 3413
		private global::System.Data.Entity.Core.Metadata.Edm.CollectionKind _collectionKind;
	}
}
