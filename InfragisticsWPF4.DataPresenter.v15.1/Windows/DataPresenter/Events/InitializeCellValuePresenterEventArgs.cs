using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002CD RID: 717
	public class InitializeCellValuePresenterEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002274 RID: 8820 RVA: 0x00097BAF File Offset: 0x00095DAF
		internal InitializeCellValuePresenterEventArgs(global::Infragistics.Windows.DataPresenter.CellValuePresenter cellValuePresenter, bool isNew)
		{
			this._cellValuePresenter = cellValuePresenter;
			this._isNew = isNew;
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06002275 RID: 8821 RVA: 0x00097BC5 File Offset: 0x00095DC5
		public global::Infragistics.Windows.DataPresenter.CellValuePresenter CellValuePresenter
		{
			get
			{
				return this._cellValuePresenter;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06002276 RID: 8822 RVA: 0x00097BCD File Offset: 0x00095DCD
		public bool IsNew
		{
			get
			{
				return this._isNew;
			}
		}

		// Token: 0x04001122 RID: 4386
		private global::Infragistics.Windows.DataPresenter.CellValuePresenter _cellValuePresenter;

		// Token: 0x04001123 RID: 4387
		private bool _isNew;
	}
}
