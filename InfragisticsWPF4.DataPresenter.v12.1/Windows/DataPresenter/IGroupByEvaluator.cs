using System;
using System.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002B5 RID: 693
	public interface IGroupByEvaluator
	{
		// Token: 0x06001FCA RID: 8138
		object GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record);

		// Token: 0x06001FCB RID: 8139
		bool DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record);

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001FCC RID: 8140
		global::System.Collections.IComparer SortComparer { get; }
	}
}
