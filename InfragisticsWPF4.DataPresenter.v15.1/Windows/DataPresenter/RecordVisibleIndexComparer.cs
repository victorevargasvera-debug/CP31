using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000156 RID: 342
	internal class RecordVisibleIndexComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record>
	{
		// Token: 0x06001479 RID: 5241 RVA: 0x0005BA7E File Offset: 0x00059C7E
		int global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record>.Compare(global::Infragistics.Windows.DataPresenter.Record x, global::Infragistics.Windows.DataPresenter.Record y)
		{
			return x.VisibleIndex - y.VisibleIndex;
		}
	}
}
