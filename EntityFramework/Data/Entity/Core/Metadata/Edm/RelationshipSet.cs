using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F5 RID: 1269
	public abstract class RelationshipSet : global::System.Data.Entity.Core.Metadata.Edm.EntitySetBase
	{
		// Token: 0x06003F05 RID: 16133 RVA: 0x000D0A90 File Offset: 0x000CEC90
		internal RelationshipSet(string name, string schema, string table, string definingQuery, global::System.Data.Entity.Core.Metadata.Edm.RelationshipType relationshipType) : base(name, schema, table, definingQuery, relationshipType)
		{
		}

		// Token: 0x17000C60 RID: 3168
		// (get) Token: 0x06003F06 RID: 16134 RVA: 0x000D0A9F File Offset: 0x000CEC9F
		public new global::System.Data.Entity.Core.Metadata.Edm.RelationshipType ElementType
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.RelationshipType)base.ElementType;
			}
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06003F07 RID: 16135 RVA: 0x000D0AAC File Offset: 0x000CECAC
		public override global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.BuiltInTypeKind.RelationshipSet;
			}
		}
	}
}
