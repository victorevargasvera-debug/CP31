using System;
using System.Collections;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020002F2 RID: 754
	public interface IGroupByEvaluator
	{
		// Token: 0x06002300 RID: 8960
		object GetGroupByValue(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record);

		// Token: 0x06002301 RID: 8961
		bool DoesGroupContainRecord(global::Infragistics.Windows.DataPresenter.GroupByRecord groupByRecord, global::Infragistics.Windows.DataPresenter.DataRecord record);

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06002302 RID: 8962
		global::System.Collections.IComparer SortComparer { get; }
	}
}
