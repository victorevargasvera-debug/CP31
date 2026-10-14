using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000291 RID: 657
	public class RecordAddingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E01 RID: 7681 RVA: 0x00081554 File Offset: 0x0007F754
		internal RecordAddingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001E02 RID: 7682 RVA: 0x00081563 File Offset: 0x0007F763
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EC3 RID: 3779
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
