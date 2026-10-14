using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000270 RID: 624
	public class CellActivatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001D7F RID: 7551 RVA: 0x00080E3A File Offset: 0x0007F03A
		internal CellActivatingEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this._cell = cell;
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00080E49 File Offset: 0x0007F049
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x04000E86 RID: 3718
		private global::Infragistics.Windows.DataPresenter.Cell _cell;
	}
}
