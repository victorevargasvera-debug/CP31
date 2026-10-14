using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003EE RID: 1006
	internal class SortKey
	{
		// Token: 0x06002F2F RID: 12079 RVA: 0x00094852 File Offset: 0x00092A52
		internal SortKey(global::System.Data.Entity.Core.Query.InternalTrees.Var v, bool asc, string collation)
		{
			this.Var = v;
			this.m_asc = asc;
			this.m_collation = collation;
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x0009486F File Offset: 0x00092A6F
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x00094877 File Offset: 0x00092A77
		internal global::System.Data.Entity.Core.Query.InternalTrees.Var Var { get; set; }

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x00094880 File Offset: 0x00092A80
		internal bool AscendingSort
		{
			get
			{
				return this.m_asc;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x06002F33 RID: 12083 RVA: 0x00094888 File Offset: 0x00092A88
		internal string Collation
		{
			get
			{
				return this.m_collation;
			}
		}

		// Token: 0x04000FE6 RID: 4070
		private readonly bool m_asc;

		// Token: 0x04000FE7 RID: 4071
		private readonly string m_collation;
	}
}
