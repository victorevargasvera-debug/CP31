using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D2 RID: 722
	public class RecordActivatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002285 RID: 8837 RVA: 0x00097CBA File Offset: 0x00095EBA
		internal RecordActivatingEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06002286 RID: 8838 RVA: 0x00097CC9 File Offset: 0x00095EC9
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x0400112B RID: 4395
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
