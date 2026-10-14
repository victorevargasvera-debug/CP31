using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006F2 RID: 1778
	internal class PatternMatchRuleProcessor : global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRuleProcessingVisitor
	{
		// Token: 0x060052C2 RID: 21186 RVA: 0x00128370 File Offset: 0x00126570
		private PatternMatchRuleProcessor(global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule> rules)
		{
			this.ruleSet = rules;
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x0012837F File Offset: 0x0012657F
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Process(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			expression = this.VisitExpression(expression);
			return expression;
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x0012838B File Offset: 0x0012658B
		protected override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule> GetRules()
		{
			return this.ruleSet;
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00128393 File Offset: 0x00126593
		internal static global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> Create(params global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule[] rules)
		{
			return new global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(new global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRuleProcessor(new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule>(rules)).Process);
		}

		// Token: 0x04001DEB RID: 7659
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.CommandTrees.Internal.PatternMatchRule> ruleSet;
	}
}
