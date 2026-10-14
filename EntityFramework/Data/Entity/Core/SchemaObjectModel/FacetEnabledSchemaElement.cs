using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002F1 RID: 753
	internal abstract class FacetEnabledSchemaElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x000646F4 File Offset: 0x000628F4
		internal new global::System.Data.Entity.Core.SchemaObjectModel.Function ParentElement
		{
			get
			{
				return base.ParentElement as global::System.Data.Entity.Core.SchemaObjectModel.Function;
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x00064701 File Offset: 0x00062901
		internal global::System.Data.Entity.Core.SchemaObjectModel.SchemaType Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x060023D7 RID: 9175 RVA: 0x00064709 File Offset: 0x00062909
		internal virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage TypeUsage
		{
			get
			{
				return this._typeUsageBuilder.TypeUsage;
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x060023D8 RID: 9176 RVA: 0x00064716 File Offset: 0x00062916
		internal global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder TypeUsageBuilder
		{
			get
			{
				return this._typeUsageBuilder;
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x060023D9 RID: 9177 RVA: 0x0006471E File Offset: 0x0006291E
		internal bool HasUserDefinedFacets
		{
			get
			{
				return this._typeUsageBuilder.HasUserDefinedFacets;
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x060023DA RID: 9178 RVA: 0x0006472B File Offset: 0x0006292B
		// (set) Token: 0x060023DB RID: 9179 RVA: 0x00064733 File Offset: 0x00062933
		internal string UnresolvedType
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

		// Token: 0x060023DC RID: 9180 RVA: 0x0006473C File Offset: 0x0006293C
		internal FacetEnabledSchemaElement(global::System.Data.Entity.Core.SchemaObjectModel.Function parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x00064746 File Offset: 0x00062946
		internal FacetEnabledSchemaElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x00064750 File Offset: 0x00062950
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			if (base.Schema.ResolveTypeName(this, this.UnresolvedType, out this._type) && base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderManifestModel && this._typeUsageBuilder.HasUserDefinedFacets)
			{
				bool flag = base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderManifestModel;
				this._typeUsageBuilder.ValidateAndSetTypeUsage((global::System.Data.Entity.Core.SchemaObjectModel.ScalarType)this._type, !flag);
			}
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000647C1 File Offset: 0x000629C1
		internal void ValidateAndSetTypeUsage(global::System.Data.Entity.Core.SchemaObjectModel.ScalarType scalar)
		{
			this._typeUsageBuilder.ValidateAndSetTypeUsage(scalar, false);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x000647D0 File Offset: 0x000629D0
		internal void ValidateAndSetTypeUsage(global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			this._typeUsageBuilder.ValidateAndSetTypeUsage(edmType, false);
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x000647DF File Offset: 0x000629DF
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			return base.HandleAttribute(reader) || this._typeUsageBuilder.HandleAttribute(reader);
		}

		// Token: 0x04000CCD RID: 3277
		protected global::System.Data.Entity.Core.SchemaObjectModel.SchemaType _type;

		// Token: 0x04000CCE RID: 3278
		protected string _unresolvedType;

		// Token: 0x04000CCF RID: 3279
		protected global::System.Data.Entity.Core.SchemaObjectModel.TypeUsageBuilder _typeUsageBuilder;
	}
}
