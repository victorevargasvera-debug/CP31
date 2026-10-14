using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002E0 RID: 736
	public class RecordFixedLocationChangingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x060022B9 RID: 8889 RVA: 0x00097F59 File Offset: 0x00096159
		internal RecordFixedLocationChangingEventArgs(global::Infragistics.Windows.DataPresenter.Record record, global::Infragistics.Windows.DataPresenter.FixedRecordLocation newLocation)
		{
			this._record = record;
			this._newLocation = newLocation;
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060022BA RID: 8890 RVA: 0x00097F6F File Offset: 0x0009616F
		public global::Infragistics.Windows.DataPresenter.FixedRecordLocation NewLocation
		{
			get
			{
				return this._newLocation;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060022BB RID: 8891 RVA: 0x00097F77 File Offset: 0x00096177
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x0400114C RID: 4428
		private global::Infragistics.Windows.DataPresenter.Record _record;

		// Token: 0x0400114D RID: 4429
		private global::Infragistics.Windows.DataPresenter.FixedRecordLocation _newLocation;
	}
}
