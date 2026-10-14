using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002BE RID: 702
	public class CellsInViewChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x0600223E RID: 8766 RVA: 0x000978F8 File Offset: 0x00095AF8
		public CellsInViewChangedEventArgs(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> currentCellsInView)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(currentCellsInView);
			this._currentCellsInView = currentCellsInView;
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x0009790D File Offset: 0x00095B0D
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> CurrentCellsInView
		{
			get
			{
				return this._currentCellsInView;
			}
		}

		// Token: 0x04001103 RID: 4355
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> _currentCellsInView;
	}
}
