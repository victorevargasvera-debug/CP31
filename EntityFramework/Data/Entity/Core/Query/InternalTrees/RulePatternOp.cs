using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003DA RID: 986
	internal abstract class RulePatternOp : global::System.Data.Entity.Core.Query.InternalTrees.Op
	{
		// Token: 0x06002ED6 RID: 11990 RVA: 0x000941AF File Offset: 0x000923AF
		internal RulePatternOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002ED7 RID: 11991 RVA: 0x000941B8 File Offset: 0x000923B8
		internal override bool IsRulePatternOp
		{
			get
			{
				return true;
			}
		}
	}
}
