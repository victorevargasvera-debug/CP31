using System;

namespace System.Data.Entity.Core.Objects.Internal
{
	// Token: 0x02000454 RID: 1108
	internal sealed class PocoEntityKeyStrategy : global::System.Data.Entity.Core.Objects.Internal.IEntityKeyStrategy
	{
		// Token: 0x06003628 RID: 13864 RVA: 0x000AD80A File Offset: 0x000ABA0A
		public global::System.Data.Entity.Core.EntityKey GetEntityKey()
		{
			return this._key;
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x000AD812 File Offset: 0x000ABA12
		public void SetEntityKey(global::System.Data.Entity.Core.EntityKey key)
		{
			this._key = key;
		}

		// Token: 0x0600362A RID: 13866 RVA: 0x000AD81B File Offset: 0x000ABA1B
		public global::System.Data.Entity.Core.EntityKey GetEntityKeyFromEntity()
		{
			return null;
		}

		// Token: 0x0400117E RID: 4478
		private global::System.Data.Entity.Core.EntityKey _key;
	}
}
