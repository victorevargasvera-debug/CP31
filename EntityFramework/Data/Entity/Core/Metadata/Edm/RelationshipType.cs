using System;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F6 RID: 1270
	public abstract class RelationshipType : global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase
	{
		// Token: 0x06003F08 RID: 16136 RVA: 0x000D0AB0 File Offset: 0x000CECB0
		internal RelationshipType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(name, namespaceName, dataSpace)
		{
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06003F09 RID: 16137 RVA: 0x000D0ABC File Offset: 0x000CECBC
		public global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember> RelationshipEndMembers
		{
			get
			{
				if (this._relationshipEndMembers == null)
				{
					global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember> value = new global::System.Data.Entity.Core.Metadata.Edm.FilteredReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember, global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(base.Members, new global::System.Predicate<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsRelationshipEndMember));
					global::System.Threading.Interlocked.CompareExchange<global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember>>(ref this._relationshipEndMembers, value, null);
				}
				return this._relationshipEndMembers;
			}
		}

		// Token: 0x04001582 RID: 5506
		private global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<global::System.Data.Entity.Core.Metadata.Edm.RelationshipEndMember> _relationshipEndMembers;
	}
}
