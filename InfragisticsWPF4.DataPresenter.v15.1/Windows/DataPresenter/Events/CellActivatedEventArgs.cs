using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B2 RID: 690
	public class CellActivatedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002201 RID: 8705 RVA: 0x00097583 File Offset: 0x00095783
		internal CellActivatedEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell)
		{
			this._cell = cell;
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002202 RID: 8706 RVA: 0x00097592 File Offset: 0x00095792
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x040010EC RID: 4332
		private global::Infragistics.Windows.DataPresenter.Cell _cell;
	}
}
