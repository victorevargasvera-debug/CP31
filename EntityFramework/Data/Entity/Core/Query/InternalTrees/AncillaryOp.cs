using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200037C RID: 892
	internal abstract class AncillaryOp : global::System.Data.Entity.Core.Query.InternalTrees.Op
	{
		// Token: 0x06002B11 RID: 11025 RVA: 0x0008C77B File Offset: 0x0008A97B
		internal AncillaryOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x0008C784 File Offset: 0x0008A984
		internal override bool IsAncillaryOp
		{
			get
			{
				return true;
			}
		}
	}
}
