using System;
using Infragistics.Collections;

namespace Infragistics
{
	// Token: 0x02000045 RID: 69
	public class SummaryResultCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.SummaryResult>
	{
		// Token: 0x170000BD RID: 189
		public global::Infragistics.SummaryResult this[global::Infragistics.SummaryOperandBase op]
		{
			get
			{
				foreach (global::Infragistics.SummaryResult summaryResult in this.Items)
				{
					if (summaryResult.SummaryDefinition.SummaryOperand == op)
					{
						return summaryResult;
					}
				}
				return null;
			}
		}
	}
}
