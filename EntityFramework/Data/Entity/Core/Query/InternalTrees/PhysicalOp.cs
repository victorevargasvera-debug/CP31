using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003CD RID: 973
	internal abstract class PhysicalOp : global::System.Data.Entity.Core.Query.InternalTrees.Op
	{
		// Token: 0x06002E96 RID: 11926 RVA: 0x00093D0A File Offset: 0x00091F0A
		internal PhysicalOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06002E97 RID: 11927 RVA: 0x00093D13 File Offset: 0x00091F13
		internal override bool IsPhysicalOp
		{
			get
			{
				return true;
			}
		}
	}
}
