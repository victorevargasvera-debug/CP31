using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002DF RID: 735
	public class RecordFixedLocationChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x00097F42 File Offset: 0x00096142
		internal RecordFixedLocationChangedEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060022B8 RID: 8888 RVA: 0x00097F51 File Offset: 0x00096151
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x0400114B RID: 4427
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
