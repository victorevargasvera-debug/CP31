using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002A6 RID: 678
	public class SelectedItemsChangingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001E48 RID: 7752 RVA: 0x000818D8 File Offset: 0x0007FAD8
		internal SelectedItemsChangingEventArgs(global::System.Type type, global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder newSelection)
		{
			this._type = type;
			this._newSelection = newSelection;
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x000818EE File Offset: 0x0007FAEE
		public global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder NewSelection
		{
			get
			{
				return this._newSelection;
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x000818F6 File Offset: 0x0007FAF6
		public global::System.Type Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x04000EEE RID: 3822
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _newSelection;

		// Token: 0x04000EEF RID: 3823
		private global::System.Type _type;
	}
}
