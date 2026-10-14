using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000272 RID: 626
	public class CellDeactivatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001D84 RID: 7556 RVA: 0x00080E77 File Offset: 0x0007F077
		internal CellDeactivatingEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this._cell = cell;
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x00080E86 File Offset: 0x0007F086
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x04000E89 RID: 3721
		private global::Infragistics.Windows.DataPresenter.Cell _cell;
	}
}
