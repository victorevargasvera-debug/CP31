using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006EB RID: 1771
	internal abstract class DbExpressionRuleProcessingVisitor : global::System.Data.Entity.Core.Common.CommandTrees.DefaultExpressionVisitor
	{
		// Token: 0x06005225 RID: 21029
		protected abstract global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule> GetRules();

		// Token: 0x06005226 RID: 21030 RVA: 0x00125144 File Offset: 0x00123344
		private static global::System.Tuple<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction> ProcessRules(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule> rules)
		{
			for (int i = 0; i < rules.Count; i++)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule dbExpressionRule = rules[i];
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression;
				if (dbExpressionRule.ShouldProcess(expression) && dbExpressionRule.TryProcess(expression, out dbExpression))
				{
					if (dbExpressionRule.OnExpressionProcessed != global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction.Continue)
					{
						return global::System.Tuple.Create<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction>(dbExpression, dbExpressionRule.OnExpressionProcessed);
					}
					expression = dbExpression;
				}
			}
			return global::System.Tuple.Create<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction>(expression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction.Continue);
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x001251A0 File Offset: 0x001233A0
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression ApplyRules(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule> rules = this.GetRules().ToList<global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule>();
			global::System.Tuple<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction> tuple = global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRuleProcessingVisitor.ProcessRules(expression, rules);
			while (tuple.Item2 == global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction.Reset)
			{
				rules = this.GetRules().ToList<global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule>();
				tuple = global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRuleProcessingVisitor.ProcessRules(tuple.Item1, rules);
			}
			if (tuple.Item2 == global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionRule.ProcessedAction.Stop)
			{
				this._stopped = true;
			}
			return tuple.Item1;
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x001251FC File Offset: 0x001233FC
		protected override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression VisitExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression expression)
		{
			global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = this.ApplyRules(expression);
			if (this._stopped)
			{
				return dbExpression;
			}
			dbExpression = base.VisitExpression(dbExpression);
			if (this._stopped)
			{
				return dbExpression;
			}
			return this.ApplyRules(dbExpression);
		}

		// Token: 0x04001DE3 RID: 7651
		private bool _stopped;
	}
}
