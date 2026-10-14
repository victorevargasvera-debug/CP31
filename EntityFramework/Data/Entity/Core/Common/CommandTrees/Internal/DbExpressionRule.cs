using System;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006EA RID: 1770
	internal abstract class DbExpressionRule
	{
		// Token: 0x06005221 RID: 21025
		internal abstract bool ShouldProcess(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression);

		// Token: 0x06005222 RID: 21026
		internal abstract bool TryProcess(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result);

		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06005223 RID: 21027
		internal abstract global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction OnExpressionProcessed { get; }

		// Token: 0x02000C98 RID: 3224
		internal enum ProcessedAction
		{
			// Token: 0x040031BF RID: 12735
			Continue,
			// Token: 0x040031C0 RID: 12736
			Reset,
			// Token: 0x040031C1 RID: 12737
			Stop
		}
	}
}
