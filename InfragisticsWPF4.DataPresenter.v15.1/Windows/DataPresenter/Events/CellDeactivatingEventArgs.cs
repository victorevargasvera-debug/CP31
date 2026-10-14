using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B5 RID: 693
	public class CellDeactivatingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002208 RID: 8712 RVA: 0x000975D7 File Offset: 0x000957D7
		internal CellDeactivatingEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this._cell = cell;
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002209 RID: 8713 RVA: 0x000975E6 File Offset: 0x000957E6
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x040010F0 RID: 4336
		private global::Infragistics.Windows.DataPresenter.Cell _cell;
	}
}
