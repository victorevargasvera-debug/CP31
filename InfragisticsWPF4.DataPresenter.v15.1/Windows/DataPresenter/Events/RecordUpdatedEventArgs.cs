using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002E6 RID: 742
	public class RecordUpdatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022C8 RID: 8904 RVA: 0x00098016 File Offset: 0x00096216
		internal RecordUpdatedEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060022C9 RID: 8905 RVA: 0x00098025 File Offset: 0x00096225
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04001154 RID: 4436
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
