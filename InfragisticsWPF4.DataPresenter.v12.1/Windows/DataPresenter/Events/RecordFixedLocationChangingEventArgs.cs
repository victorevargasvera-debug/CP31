using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200029D RID: 669
	public class RecordFixedLocationChangingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E31 RID: 7729 RVA: 0x000817C5 File Offset: 0x0007F9C5
		internal RecordFixedLocationChangingEventArgs(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.FixedRecordLocation newLocation)
		{
			this._record = record;
			this._newLocation = newLocation;
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x06001E32 RID: 7730 RVA: 0x000817DB File Offset: 0x0007F9DB
		public global::Infragistics.Windows.DataPresenter.FixedRecordLocation NewLocation
		{
			get
			{
				return this._newLocation;
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x000817E3 File Offset: 0x0007F9E3
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EE2 RID: 3810
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x04000EE3 RID: 3811
		private global::Infragistics.Windows.DataPresenter.FixedRecordLocation _newLocation;
	}
}
