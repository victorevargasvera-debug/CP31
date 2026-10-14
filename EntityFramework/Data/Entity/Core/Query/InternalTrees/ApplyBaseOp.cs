using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200037D RID: 893
	internal abstract class ApplyBaseOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002B13 RID: 11027 RVA: 0x0008C787 File Offset: 0x0008A987
		internal ApplyBaseOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x0008C790 File Offset: 0x0008A990
		internal override int Arity
		{
			get
			{
				return 2;
			}
		}
	}
}
