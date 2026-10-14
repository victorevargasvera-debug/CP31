using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003ED RID: 1005
	internal abstract class SortBaseOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002F2C RID: 12076 RVA: 0x00094831 File Offset: 0x00092A31
		internal SortBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x06002F2D RID: 12077 RVA: 0x0009483A File Offset: 0x00092A3A
		internal SortBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> sortKeys) : this(opType)
		{
			this.m_keys = sortKeys;
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x0009484A File Offset: 0x00092A4A
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x04000FE5 RID: 4069
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> m_keys;
	}
}
