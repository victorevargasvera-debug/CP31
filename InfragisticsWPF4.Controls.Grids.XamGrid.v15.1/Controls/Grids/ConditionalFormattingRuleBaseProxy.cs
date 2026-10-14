using System;
using System.Linq;
using System.Windows;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000037 RID: 55
	public abstract class ConditionalFormattingRuleBaseProxy : global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy, global::Infragistics.IRule
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000287 RID: 647 RVA: 0x0000C558 File Offset: 0x0000A758
		public global::Infragistics.EvaluationStage RuleExecution
		{
			get
			{
				global::Infragistics.EvaluationStage result = global::Infragistics.EvaluationStage.None;
				if (this.Parent != null)
				{
					result = this.Parent.RuleExecution;
				}
				return result;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000288 RID: 648 RVA: 0x0000C57C File Offset: 0x0000A77C
		// (set) Token: 0x06000289 RID: 649 RVA: 0x0000C584 File Offset: 0x0000A784
		protected internal global::Infragistics.Controls.Grids.IConditionalFormattingRule Parent { get; set; }

		// Token: 0x0600028A RID: 650
		protected abstract global::System.Windows.Style EvaluateCondition(object sourceDataObject, object sourceDataValue);

		// Token: 0x0600028B RID: 651 RVA: 0x0000C58D File Offset: 0x0000A78D
		protected virtual void GatherData(global::System.Linq.IQueryable query)
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000C58F File Offset: 0x0000A78F
		global::Infragistics.EvaluationStage global::Infragistics.IRule.RuleExecution
		{
			get
			{
				return this.RuleExecution;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x0000C597 File Offset: 0x0000A797
		void global::Infragistics.IRule.GatherData(global::System.Linq.IQueryable query)
		{
			this.GatherData(query);
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0000C5A8 File Offset: 0x0000A7A8
		global::Infragistics.Controls.Grids.IConditionalFormattingRule global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy.Parent
		{
			get
			{
				return this.Parent;
			}
			set
			{
				this.Parent = value;
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0000C5B1 File Offset: 0x0000A7B1
		global::System.Windows.Style global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy.EvaluateCondition(object sourceDataObject, object sourceDataValue)
		{
			return this.EvaluateCondition(sourceDataObject, sourceDataValue);
		}
	}
}
