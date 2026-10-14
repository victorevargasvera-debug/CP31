using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000120 RID: 288
	public class FieldLayoutGroupByInfoCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo>
	{
		// Token: 0x0600111F RID: 4383 RVA: 0x0004C042 File Offset: 0x0004A242
		internal FieldLayoutGroupByInfoCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo> list) : base(list)
		{
			this._list = list;
		}

		// Token: 0x040006F4 RID: 1780
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FieldLayoutGroupByInfo> _list;
	}
}
