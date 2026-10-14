using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200028E RID: 654
	public class RecordActivatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DFB RID: 7675 RVA: 0x0008150F File Offset: 0x0007F70F
		internal RecordActivatedEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x0008151E File Offset: 0x0007F71E
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC0 RID: 3776
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
