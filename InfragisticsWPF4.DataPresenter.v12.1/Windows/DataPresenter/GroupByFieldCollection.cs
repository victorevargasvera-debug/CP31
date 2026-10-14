using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000165 RID: 357
	public class GroupByFieldCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.Field>
	{
		// Token: 0x06001508 RID: 5384 RVA: 0x00060A21 File Offset: 0x0005EC21
		internal GroupByFieldCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.Field> list) : base(list)
		{
			this._list = list;
		}

		// Token: 0x04000860 RID: 2144
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.Field> _list;
	}
}
