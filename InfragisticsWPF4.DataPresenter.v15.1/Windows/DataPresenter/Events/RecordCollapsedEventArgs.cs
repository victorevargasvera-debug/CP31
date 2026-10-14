using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D5 RID: 725
	public class RecordCollapsedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600228B RID: 8843 RVA: 0x00097CFF File Offset: 0x00095EFF
		internal RecordCollapsedEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x0600228C RID: 8844 RVA: 0x00097D0E File Offset: 0x00095F0E
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x0400112E RID: 4398
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
