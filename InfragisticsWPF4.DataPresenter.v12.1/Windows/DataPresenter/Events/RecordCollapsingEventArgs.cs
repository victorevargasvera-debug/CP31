using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000293 RID: 659
	public class RecordCollapsingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E05 RID: 7685 RVA: 0x00081582 File Offset: 0x0007F782
		internal RecordCollapsingEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x06001E06 RID: 7686 RVA: 0x00081591 File Offset: 0x0007F791
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC5 RID: 3781
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
