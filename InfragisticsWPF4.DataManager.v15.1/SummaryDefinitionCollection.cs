using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Infragistics.Collections;

namespace Infragistics
{
	// Token: 0x02000042 RID: 66
	public class SummaryDefinitionCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.SummaryDefinition>
	{
		// Token: 0x060002C2 RID: 706 RVA: 0x0000DE18 File Offset: 0x0000C018
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryDefinition> GetDefinitionsByKey(string key)
		{
			global::System.Collections.Generic.List<global::Infragistics.SummaryDefinition> list = new global::System.Collections.Generic.List<global::Infragistics.SummaryDefinition>();
			foreach (global::Infragistics.SummaryDefinition summaryDefinition in this.Items)
			{
				if (summaryDefinition.ColumnKey == key)
				{
					list.Add(summaryDefinition);
				}
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryDefinition>(list);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000DE80 File Offset: 0x0000C080
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryDefinition> GetDefinitionsBySummaryExecution(global::Infragistics.SummaryExecution summaryExecution)
		{
			return this.GetDefinitionsBySummaryExecution(summaryExecution, false);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000DE8C File Offset: 0x0000C08C
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryDefinition> GetDefinitionsBySummaryExecution(global::Infragistics.SummaryExecution summaryExecution, bool includeNulls)
		{
			global::System.Collections.Generic.List<global::Infragistics.SummaryDefinition> list = new global::System.Collections.Generic.List<global::Infragistics.SummaryDefinition>();
			foreach (global::Infragistics.SummaryDefinition summaryDefinition in this.Items)
			{
				if ((summaryDefinition.SummaryOperand != null && summaryDefinition.SummaryOperand.SummaryCalculator != null && summaryDefinition.SummaryOperand.SummaryCalculator.SummaryExecution == summaryExecution) || (includeNulls && summaryDefinition.SummaryOperand.SummaryCalculator.SummaryExecution == null))
				{
					list.Add(summaryDefinition);
				}
			}
			return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryDefinition>(list);
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000DF44 File Offset: 0x0000C144
		protected internal void AddItemSilently(global::Infragistics.SummaryDefinition item)
		{
			base.AddItemSilently(this.Items.Count, item);
		}
	}
}
