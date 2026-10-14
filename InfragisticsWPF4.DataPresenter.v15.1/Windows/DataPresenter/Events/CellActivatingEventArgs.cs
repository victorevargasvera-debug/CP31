using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B3 RID: 691
	public class CellActivatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002203 RID: 8707 RVA: 0x0009759A File Offset: 0x0009579A
		internal CellActivatingEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this._cell = cell;
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06002204 RID: 8708 RVA: 0x000975A9 File Offset: 0x000957A9
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x040010ED RID: 4333
		private global::Infragistics.Windows.DataPresenter.Cell _cell;
	}
}
