using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200013A RID: 314
	internal class RecordVisibleIndexComparer : global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record>
	{
		// Token: 0x06001110 RID: 4368 RVA: 0x0004A782 File Offset: 0x00048982
		int global::System.Collections.Generic.IComparer<global::Infragistics.Windows.DataPresenter.Record>.Compare(global::Infragistics.Windows.DataPresenter.Record x, global::Infragistics.Windows.DataPresenter.Record y)
		{
			return x.VisibleIndex - y.VisibleIndex;
		}
	}
}
