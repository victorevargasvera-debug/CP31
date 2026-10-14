using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003B2 RID: 946
	internal abstract class JoinBaseOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002D9D RID: 11677 RVA: 0x00091164 File Offset: 0x0008F364
		internal JoinBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002D9E RID: 11678 RVA: 0x0009116D File Offset: 0x0008F36D
		internal override int Arity
		{
			get
			{
				return 3;
			}
		}
	}
}
