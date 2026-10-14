using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infragistics.Collections;

namespace Infragistics
{
	// Token: 0x02000004 RID: 4
	public class FormattingRuleCollection<T> : global::Infragistics.Collections.CollectionBase<T> where T : global::Infragistics.IRule
	{
		// Token: 0x06000011 RID: 17 RVA: 0x0000243C File Offset: 0x0000063C
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.IRule> GetRulesForStage(global::Infragistics.EvaluationStage stage)
		{
			global::System.Collections.Generic.List<global::Infragistics.IRule> list = new global::System.Collections.Generic.List<global::Infragistics.IRule>();
			foreach (T t in this.Items)
			{
				global::Infragistics.IRule rule = t;
				if (rule.RuleExecution == stage)
				{
					list.Add(rule);
				}
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.IRule>(list);
		}
	}
}
