using System;
using System.Collections.Generic;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003BA RID: 954
	internal abstract class NestBaseOp : global::System.Data.Entity.Core.Query.InternalTrees.PhysicalOp
	{
		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002DCA RID: 11722 RVA: 0x000914F7 File Offset: 0x0008F6F7
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> PrefixSortKeys
		{
			get
			{
				return this.m_prefixSortKeys;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002DCB RID: 11723 RVA: 0x000914FF File Offset: 0x0008F6FF
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Outputs
		{
			get
			{
				return this.m_outputs;
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002DCC RID: 11724 RVA: 0x00091507 File Offset: 0x0008F707
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> CollectionInfo
		{
			get
			{
				return this.m_collectionInfoList;
			}
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x0009150F File Offset: 0x0008F70F
		internal NestBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> prefixSortKeys, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputVars, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> collectionInfoList) : base(opType)
		{
			this.m_outputs = outputVars;
			this.m_collectionInfoList = collectionInfoList;
			this.m_prefixSortKeys = prefixSortKeys;
		}

		// Token: 0x04000F4F RID: 3919
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.SortKey> m_prefixSortKeys;

		// Token: 0x04000F50 RID: 3920
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_outputs;

		// Token: 0x04000F51 RID: 3921
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.CollectionInfo> m_collectionInfoList;
	}
}
