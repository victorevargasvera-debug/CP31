using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000181 RID: 385
	public class GroupByFieldCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.Field>
	{
		// Token: 0x06001880 RID: 6272 RVA: 0x000729C9 File Offset: 0x00070BC9
		internal GroupByFieldCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.Field> list) : base(list)
		{
			this._list = list;
		}

		// Token: 0x04000A15 RID: 2581
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.Field> _list;
	}
}
