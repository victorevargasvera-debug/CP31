using System;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x0200042B RID: 1067
	public abstract class OriginalValueRecord : global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord
	{
		// Token: 0x06003401 RID: 13313 RVA: 0x000A71B8 File Offset: 0x000A53B8
		internal OriginalValueRecord(global::System.Data.Entity.Core.Objects.ObjectStateEntry cacheEntry, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject) : base(cacheEntry, metadata, userObject)
		{
		}
	}
}
