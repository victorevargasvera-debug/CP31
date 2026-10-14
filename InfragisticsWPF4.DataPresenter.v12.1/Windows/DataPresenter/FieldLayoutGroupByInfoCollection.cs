using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000104 RID: 260
	public class FieldLayoutGroupByInfoCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo>
	{
		// Token: 0x06000DBE RID: 3518 RVA: 0x0003B582 File Offset: 0x00039782
		internal FieldLayoutGroupByInfoCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo> list) : base(list)
		{
			this._list = list;
		}

		// Token: 0x04000555 RID: 1365
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo> _list;
	}
}
