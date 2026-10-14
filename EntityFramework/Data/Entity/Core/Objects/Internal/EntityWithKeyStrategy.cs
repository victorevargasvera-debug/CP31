using System;
using System.Data.Entity.Core.Objects.DataClasses;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000440 RID: 1088
	internal sealed class EntityWithKeyStrategy : global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy
	{
		// Token: 0x06003532 RID: 13618 RVA: 0x000AA556 File Offset: 0x000A8756
		public EntityWithKeyStrategy(global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey entity)
		{
			this._entity = entity;
		}

		// Token: 0x06003533 RID: 13619 RVA: 0x000AA565 File Offset: 0x000A8765
		public global::System.Data.Entity.Core.EntityKey GetEntityKey()
		{
			return this._entity.EntityKey;
		}

		// Token: 0x06003534 RID: 13620 RVA: 0x000AA572 File Offset: 0x000A8772
		public void SetEntityKey(global::System.Data.Entity.Core.EntityKey key)
		{
			this._entity.EntityKey = key;
		}

		// Token: 0x06003535 RID: 13621 RVA: 0x000AA580 File Offset: 0x000A8780
		public global::System.Data.Entity.Core.EntityKey GetEntityKeyFromEntity()
		{
			return this._entity.EntityKey;
		}

		// Token: 0x0400113A RID: 4410
		private readonly global::System.Data.Entity.Core.Objects.DataClasses.IEntityWithKey _entity;
	}
}
