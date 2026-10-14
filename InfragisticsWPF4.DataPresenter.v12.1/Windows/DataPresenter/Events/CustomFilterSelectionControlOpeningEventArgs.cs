using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000279 RID: 633
	public class CustomFilterSelectionControlOpeningEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001DAF RID: 7599 RVA: 0x00081101 File Offset: 0x0007F301
		internal CustomFilterSelectionControlOpeningEventArgs(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter, global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl control)
		{
			this._recordFilter = recordFilter;
			this._control = control;
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06001DB0 RID: 7600 RVA: 0x00081117 File Offset: 0x0007F317
		public global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl Control
		{
			get
			{
				return this._control;
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0008111F File Offset: 0x0007F31F
		public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
		{
			get
			{
				return this._recordFilter;
			}
		}

		// Token: 0x04000E99 RID: 3737
		private global::Infragistics.Windows.DataPresenter.RecordFilter _recordFilter;

		// Token: 0x04000E9A RID: 3738
		private global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl _control;
	}
}
