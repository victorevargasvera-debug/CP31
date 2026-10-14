using System;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006F1 RID: 1777
	internal class PatternMatchRule : global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule
	{
		// Token: 0x060052BC RID: 21180 RVA: 0x00128314 File Offset: 0x00126514
		private PatternMatchRule(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> matchFunc, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> processor, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction onProcessed)
		{
			this.isMatch = matchFunc;
			this.process = processor;
			this.processed = onProcessed;
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x00128331 File Offset: 0x00126531
		internal override bool ShouldProcess(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			return this.isMatch(expression);
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x0012833F File Offset: 0x0012653F
		internal override bool TryProcess(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, out global::System.Data.Entity.Core.Common.CommandTrees.DbExpression result)
		{
			result = this.process(expression);
			return result != null;
		}

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x060052BF RID: 21183 RVA: 0x00128354 File Offset: 0x00126554
		internal override global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction OnExpressionProcessed
		{
			get
			{
				return this.processed;
			}
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x0012835C File Offset: 0x0012655C
		internal static global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule Create(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> matchFunc, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> processor)
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule.Create(matchFunc, processor, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction.Reset);
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00128366 File Offset: 0x00126566
		internal static global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule Create(global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> matchFunc, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> processor, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction onProcessed)
		{
			return new global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule(matchFunc, processor, onProcessed);
		}

		// Token: 0x04001DE8 RID: 7656
		private readonly global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, bool> isMatch;

		// Token: 0x04001DE9 RID: 7657
		private readonly global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> process;

		// Token: 0x04001DEA RID: 7658
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction processed;
	}
}
