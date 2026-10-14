using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002E9 RID: 745
	public class SelectedItemsChangingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x060022D0 RID: 8912 RVA: 0x0009806C File Offset: 0x0009626C
		internal SelectedItemsChangingEventArgs(global::System.Type type, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection)
		{
			this._type = type;
			this._newSelection = newSelection;
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x060022D1 RID: 8913 RVA: 0x00098082 File Offset: 0x00096282
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder NewSelection
		{
			get
			{
				return this._newSelection;
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x0009808A File Offset: 0x0009628A
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x04001158 RID: 4440
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _newSelection;

		// Token: 0x04001159 RID: 4441
		private global::System.Type _type;
	}
}
