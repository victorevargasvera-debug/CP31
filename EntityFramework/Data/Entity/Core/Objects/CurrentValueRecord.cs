using System;

namespace System.Data.Entity.Core.Objects
{
	// Token: 0x02000403 RID: 1027
	public abstract class CurrentValueRecord : global::System.Data.Entity.Core.Objects.DbUpdatableDataRecord
	{
		// Token: 0x06002FED RID: 12269 RVA: 0x0009688B File Offset: 0x00094A8B
		internal CurrentValueRecord(global::System.Data.Entity.Core.Objects.ObjectStateEntry cacheEntry, global::System.Data.Entity.Core.Objects.StateManagerTypeMetadata metadata, object userObject) : base(cacheEntry, metadata, userObject)
		{
		}

		// Token: 0x06002FEE RID: 12270 RVA: 0x00096896 File Offset: 0x00094A96
		internal CurrentValueRecord(global::System.Data.Entity.Core.Objects.ObjectStateEntry cacheEntry) : base(cacheEntry)
		{
		}
	}
}
