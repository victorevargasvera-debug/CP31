using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003DF RID: 991
	internal abstract class ScanTableBaseOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002EF1 RID: 12017 RVA: 0x0009444D File Offset: 0x0009264D
		protected ScanTableBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Query.InternalTrees.Table table) : base(opType)
		{
			this.m_table = table;
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x0009445D File Offset: 0x0009265D
		protected ScanTableBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06002EF3 RID: 12019 RVA: 0x00094466 File Offset: 0x00092666
		internal global::System.Data.Entity.Core.Query.InternalTrees.Table Table
		{
			get
			{
				return this.m_table;
			}
		}

		// Token: 0x04000FD5 RID: 4053
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Table m_table;
	}
}
