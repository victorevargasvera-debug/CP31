using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200027B RID: 635
	public class CellsInViewChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06001DBA RID: 7610 RVA: 0x00081198 File Offset: 0x0007F398
		public CellsInViewChangedEventArgs(global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> currentCellsInView)
		{
			global::Infragistics.Windows.DataPresenter.GridUtilities.ValidateNotNull(currentCellsInView);
			this._currentCellsInView = currentCellsInView;
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x000811AD File Offset: 0x0007F3AD
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> CurrentCellsInView
		{
			get
			{
				return this._currentCellsInView;
			}
		}

		// Token: 0x04000E9C RID: 3740
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.VisibleDataBlock> _currentCellsInView;
	}
}
