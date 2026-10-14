using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D4 RID: 724
	public class RecordAddingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002289 RID: 8841 RVA: 0x00097CE8 File Offset: 0x00095EE8
		internal RecordAddingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x0600228A RID: 8842 RVA: 0x00097CF7 File Offset: 0x00095EF7
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x0400112D RID: 4397
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
