using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000297 RID: 663
	public class RecordFilterChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E0D RID: 7693 RVA: 0x000815DE File Offset: 0x0007F7DE
		internal RecordFilterChangedEventArgs(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter)
		{
			this._recordFilter = recordFilter;
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x000815ED File Offset: 0x0007F7ED
		public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
		{
			get
			{
				return this._recordFilter;
			}
		}

		// Token: 0x04000EC9 RID: 3785
		private global::Infragistics.Windows.DataPresenter.RecordFilter _recordFilter;
	}
}
