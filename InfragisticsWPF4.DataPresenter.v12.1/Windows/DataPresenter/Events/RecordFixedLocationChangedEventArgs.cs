using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200029C RID: 668
	public class RecordFixedLocationChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E2F RID: 7727 RVA: 0x000817AE File Offset: 0x0007F9AE
		internal RecordFixedLocationChangedEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x06001E30 RID: 7728 RVA: 0x000817BD File Offset: 0x0007F9BD
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EE1 RID: 3809
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
