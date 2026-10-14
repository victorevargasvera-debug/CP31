using System;
using System.Collections.ObjectModel;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002E2 RID: 738
	public class RecordsDeletingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x060022BD RID: 8893 RVA: 0x00097F87 File Offset: 0x00096187
		internal RecordsDeletingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord[] records, bool displayPromptMessage)
		{
			this._records = records;
			this._displayPromptMessage = displayPromptMessage;
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x060022BE RID: 8894 RVA: 0x00097F9D File Offset: 0x0009619D
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

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x00097FBE File Offset: 0x000961BE
		// (set) Token: 0x060022C0 RID: 8896 RVA: 0x00097FC6 File Offset: 0x000961C6
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

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060022C1 RID: 8897 RVA: 0x00097FCF File Offset: 0x000961CF
		// (set) Token: 0x060022C2 RID: 8898 RVA: 0x00097FD7 File Offset: 0x000961D7
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

		// Token: 0x0400114E RID: 4430
		private global::Infragistics.Windows.DataPresenter.DataRecord[] _records;

		// Token: 0x0400114F RID: 4431
		private bool _displayPromptMessage;

		// Token: 0x04001150 RID: 4432
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Windows.DataPresenter.Record> _readOnlyRecords;

		// Token: 0x04001151 RID: 4433
		private global::Infragistics.Windows.DataPresenter.UndeleteRecordsStrategy _undeleteStrategy;
	}
}
