using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000115 RID: 277
	internal class EntitySetTypePair : global::System.Tuple<global::System.Data.Entity.Core.Metadata.Edm.EntitySet, global::System.Type>
	{
		// Token: 0x0600135E RID: 4958 RVA: 0x0003199C File Offset: 0x0002FB9C
		public EntitySetTypePair(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Type type) : base(entitySet, type)
		{
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600135F RID: 4959 RVA: 0x000319A6 File Offset: 0x0002FBA6
		public global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				return base.Item1;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x000319AE File Offset: 0x0002FBAE
		public global::System.Type BaseType
		{
			get
			{
				return base.Item2;
			}
		}
	}
}
