using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D6 RID: 726
	internal interface IEntityStateManager
	{
		// Token: 0x06002316 RID: 8982
		global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> GetEntityStateEntries(global::System.Data.Entity.EntityState state);

		// Token: 0x06002317 RID: 8983
		global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.IEntityStateEntry> FindRelationshipsByKey(global::System.Data.Entity.Core.EntityKey key);

		// Token: 0x06002318 RID: 8984
		global::System.Data.Entity.Core.IEntityStateEntry GetEntityStateEntry(global::System.Data.Entity.Core.EntityKey key);

		// Token: 0x06002319 RID: 8985
		bool TryGetEntityStateEntry(global::System.Data.Entity.Core.EntityKey key, out global::System.Data.Entity.Core.IEntityStateEntry stateEntry);

		// Token: 0x0600231A RID: 8986
		bool TryGetReferenceKey(global::System.Data.Entity.Core.EntityKey dependentKey, global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalRole, out global::System.Data.Entity.Core.EntityKey principalKey);
	}
}
