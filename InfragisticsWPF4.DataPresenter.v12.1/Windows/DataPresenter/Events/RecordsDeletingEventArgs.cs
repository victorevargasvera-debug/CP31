using System;
using System.Collections.ObjectModel;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200029F RID: 671
	public class RecordsDeletingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E35 RID: 7733 RVA: 0x000817F3 File Offset: 0x0007F9F3
		internal RecordsDeletingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord[] records, bool displayPromptMessage)
		{
			this._records = records;
			this._displayPromptMessage = displayPromptMessage;
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x06001E36 RID: 7734 RVA: 0x00081809 File Offset: 0x0007FA09
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.Record> Records
		{
			get
			{
				if (this._readOnlyRecords == null)
				{
					this._readOnlyRecords = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.Record>(this._records);
				}
				return this._readOnlyRecords;
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0008182A File Offset: 0x0007FA2A
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x00081832 File Offset: 0x0007FA32
		public bool DisplayPromptMessage
		{
			get
			{
				return this._displayPromptMessage;
			}
			set
			{
				this._displayPromptMessage = value;
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x0008183B File Offset: 0x0007FA3B
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x00081843 File Offset: 0x0007FA43
		public global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy UndeleteStrategy
		{
			get
			{
				return this._undeleteStrategy;
			}
			set
			{
				this._undeleteStrategy = value;
			}
		}

		// Token: 0x04000EE4 RID: 3812
		private global::Infragistics.Windows.DataPresenter.DataRecord[] _records;

		// Token: 0x04000EE5 RID: 3813
		private bool _displayPromptMessage;

		// Token: 0x04000EE6 RID: 3814
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.Record> _readOnlyRecords;

		// Token: 0x04000EE7 RID: 3815
		private global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy _undeleteStrategy;
	}
}
