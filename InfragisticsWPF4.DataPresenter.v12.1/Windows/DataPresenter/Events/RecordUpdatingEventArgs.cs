using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A4 RID: 676
	public class RecordUpdatingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E42 RID: 7746 RVA: 0x00081899 File Offset: 0x0007FA99
		internal RecordUpdatingEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x000818A8 File Offset: 0x0007FAA8
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x000818B0 File Offset: 0x0007FAB0
		public global::Infragistics.Windows.DataPresenter.RecordUpdatingAction Action
		{
			get
			{
				return this._action;
			}
			set
			{
				this._action = value;
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x000818B9 File Offset: 0x0007FAB9
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EEB RID: 3819
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;

		// Token: 0x04000EEC RID: 3820
		private global::Infragistics.Windows.DataPresenter.RecordUpdatingAction _action;
	}
}
