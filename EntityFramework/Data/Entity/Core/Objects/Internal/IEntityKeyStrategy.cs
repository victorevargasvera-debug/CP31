using System;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000447 RID: 1095
	internal interface IEntityKeyStrategy
	{
		// Token: 0x0600356E RID: 13678
		global::System.Data.Entity.Core.EntityKey GetEntityKey();

		// Token: 0x0600356F RID: 13679
		void SetEntityKey(global::System.Data.Entity.Core.EntityKey key);

		// Token: 0x06003570 RID: 13680
		global::System.Data.Entity.Core.EntityKey GetEntityKeyFromEntity();
	}
}
