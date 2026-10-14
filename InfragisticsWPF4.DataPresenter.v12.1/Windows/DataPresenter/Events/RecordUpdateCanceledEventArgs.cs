using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A1 RID: 673
	public class RecordUpdateCanceledEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E3C RID: 7740 RVA: 0x00081854 File Offset: 0x0007FA54
		internal RecordUpdateCanceledEventArgs(global::Infragistics.Windows.DataPresenter.DataRecord record)
		{
			this._record = record;
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x00081863 File Offset: 0x0007FA63
		public global::Infragistics.Windows.DataPresenter.DataRecord Record
		{
			get
			{
				return this._record;
			}
		}

		// Token: 0x04000EE8 RID: 3816
		private global::Infragistics.Windows.DataPresenter.DataRecord _record;
	}
}
