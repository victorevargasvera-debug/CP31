using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F2 RID: 1266
	public abstract class RelationshipEndMember : global::System.Data.Entity.Core.Metadata.Edm.EdmMember
	{
		// Token: 0x06003EFD RID: 16125 RVA: 0x000D098F File Offset: 0x000CEB8F
		internal RelationshipEndMember(string name, global::System.Data.Entity.Core.Metadata.Edm.RefType endRefType, global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity multiplicity) : base(name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(endRefType, new global::System.Data.Entity.Core.Metadata.Edm.FacetValues
		{
			Nullable = new bool?(false)
		}))
		{
			this._relationshipMultiplicity = multiplicity;
			this._deleteBehavior = global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None;
		}

		// Token: 0x17000C5E RID: 3166
		// (get) Token: 0x06003EFE RID: 16126 RVA: 0x000D09C2 File Offset: 0x000CEBC2
		// (set) Token: 0x06003EFF RID: 16127 RVA: 0x000D09CA File Offset: 0x000CEBCA
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.OperationAction, true)]
		public global::System.Data.Entity.Core.Metadata.Edm.OperationAction DeleteBehavior
		{
			get
			{
				return this._deleteBehavior;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._deleteBehavior = value;
			}
		}

		// Token: 0x17000C5F RID: 3167
		// (get) Token: 0x06003F00 RID: 16128 RVA: 0x000D09D9 File Offset: 0x000CEBD9
		// (set) Token: 0x06003F01 RID: 16129 RVA: 0x000D09E1 File Offset: 0x000CEBE1
		[global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty(global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipMultiplicity, false)]
		public global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity RelationshipMultiplicity
		{
			get
			{
				return this._relationshipMultiplicity;
			}
			set
			{
				global::System.Data.Entity.Core.Metadata.Edm.Util.ThrowIfReadOnly(this);
				this._relationshipMultiplicity = value;
			}
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x000D09F0 File Offset: 0x000CEBF0
		public global::System.Data.Entity.Core.Metadata.Edm.EntityType GetEntityType()
		{
			if (this.TypeUsage == null)
			{
				return null;
			}
			return (global::System.Data.Entity.Core.Metadata.Edm.EntityType)((global::System.Data.Entity.Core.Metadata.Edm.RefType)this.TypeUsage.EdmType).ElementType;
		}

		// Token: 0x0400157C RID: 5500
		private global::System.Data.Entity.Core.Metadata.Edm.OperationAction _deleteBehavior;

		// Token: 0x0400157D RID: 5501
		private global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity _relationshipMultiplicity;
	}
}
