using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002D8 RID: 728
	public class RecordExpandedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002291 RID: 8849 RVA: 0x00097D44 File Offset: 0x00095F44
		internal RecordExpandedEventArgs(global::Infragistics.Windows.DataPresenter.Record record)
		{
			this._record = record;
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06002292 RID: 8850 RVA: 0x00097D53 File Offset: 0x00095F53
		public global::Infragistics.Windows.DataPresenter.Record Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04001131 RID: 4401
		private global::Infragistics.Windows.DataPresenter.Record _record;
	}
}
