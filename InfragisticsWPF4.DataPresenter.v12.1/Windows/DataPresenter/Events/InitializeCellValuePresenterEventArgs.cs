using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200028A RID: 650
	public class InitializeCellValuePresenterEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DEC RID: 7660 RVA: 0x0008141E File Offset: 0x0007F61E
		internal InitializeCellValuePresenterEventArgs(global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter, bool isNew)
		{
			this._cellValuePresenter = cellValuePresenter;
			this._isNew = isNew;
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x00081434 File Offset: 0x0007F634
		public global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				return this._cellValuePresenter;
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x06001DEE RID: 7662 RVA: 0x0008143C File Offset: 0x0007F63C
		public bool IsNew
		{
			get
			{
				return this._isNew;
			}
		}

		// Token: 0x04000EB8 RID: 3768
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter _cellValuePresenter;

		// Token: 0x04000EB9 RID: 3769
		private bool _isNew;
	}
}
