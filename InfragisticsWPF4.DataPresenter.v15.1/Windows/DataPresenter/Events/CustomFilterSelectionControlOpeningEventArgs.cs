using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002BC RID: 700
	public class CustomFilterSelectionControlOpeningEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002233 RID: 8755 RVA: 0x00097861 File Offset: 0x00095A61
		internal CustomFilterSelectionControlOpeningEventArgs(global::Infragistics.Windows.DataPresenter.RecordFilter recordFilter, global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl control)
		{
			this._recordFilter = recordFilter;
			this._control = control;
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x00097877 File Offset: 0x00095A77
		public global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl Control
		{
			get
			{
				return this._control;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x0009787F File Offset: 0x00095A7F
		public global::Infragistics.Windows.DataPresenter.RecordFilter RecordFilter
		{
			get
			{
				return this._recordFilter;
			}
		}

		// Token: 0x04001100 RID: 4352
		private global::Infragistics.Windows.DataPresenter.RecordFilter _recordFilter;

		// Token: 0x04001101 RID: 4353
		private global::Infragistics.Windows.DataPresenter.CustomFilterSelectionControl _control;
	}
}
