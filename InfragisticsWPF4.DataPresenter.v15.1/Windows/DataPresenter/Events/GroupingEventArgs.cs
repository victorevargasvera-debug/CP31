using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002CB RID: 715
	public class GroupingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x0600226E RID: 8814 RVA: 0x00097B63 File Offset: 0x00095D63
		public GroupingEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldSortDescription[] groups)
		{
			this._groups = groups;
			this._layout = layout;
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x00097B79 File Offset: 0x00095D79
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x00097B81 File Offset: 0x00095D81
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription[] Groups
		{
			get
			{
				return this._groups;
			}
		}

		// Token: 0x0400111E RID: 4382
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;

		// Token: 0x0400111F RID: 4383
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription[] _groups;
	}
}
