using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002DA RID: 730
	public class RecordFilterChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002295 RID: 8853 RVA: 0x00097D72 File Offset: 0x00095F72
		internal RecordFilterChangedEventArgs(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter)
		{
			this._recordFilter = recordFilter;
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x00097D81 File Offset: 0x00095F81
		public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
		{
			get
			{
				return this._recordFilter;
			}
		}

		// Token: 0x04001133 RID: 4403
		private global::Infragistics.Windows.DataPresenter.RecordFilter _recordFilter;
	}
}
