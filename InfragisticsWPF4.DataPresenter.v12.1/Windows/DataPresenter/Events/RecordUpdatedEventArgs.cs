using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A3 RID: 675
	public class RecordUpdatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E40 RID: 7744 RVA: 0x00081882 File Offset: 0x0007FA82
		internal RecordUpdatedEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x00081891 File Offset: 0x0007FA91
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EEA RID: 3818
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
