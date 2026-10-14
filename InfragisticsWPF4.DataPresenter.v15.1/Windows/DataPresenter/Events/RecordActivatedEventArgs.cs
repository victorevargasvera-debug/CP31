using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D1 RID: 721
	public class RecordActivatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002283 RID: 8835 RVA: 0x00097CA3 File Offset: 0x00095EA3
		internal RecordActivatedEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06002284 RID: 8836 RVA: 0x00097CB2 File Offset: 0x00095EB2
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x0400112A RID: 4394
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
