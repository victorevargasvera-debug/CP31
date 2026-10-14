using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003D4 RID: 980
	internal abstract class RelOp : global::System.Data.Entity.Core.Query.InternalTrees.Op
	{
		// Token: 0x06002EBD RID: 11965 RVA: 0x00093ECA File Offset: 0x000920CA
		internal RelOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002EBE RID: 11966 RVA: 0x00093ED3 File Offset: 0x000920D3
		internal override bool IsRelOp
		{
			get
			{
				return true;
			}
		}
	}
}
