using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200026F RID: 623
	public class CellActivatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001D7D RID: 7549 RVA: 0x00080E23 File Offset: 0x0007F023
		internal CellActivatedEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this._cell = cell;
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x00080E32 File Offset: 0x0007F032
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x04000E85 RID: 3717
		private global::Infragistics.Windows.DataPresenter.Cell _cell;
	}
}
