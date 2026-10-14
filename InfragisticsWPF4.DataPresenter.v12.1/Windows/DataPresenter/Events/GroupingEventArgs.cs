using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000288 RID: 648
	public class GroupingEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001DE6 RID: 7654 RVA: 0x000813D2 File Offset: 0x0007F5D2
		public GroupingEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldSortDescription[] groups)
		{
			this._groups = groups;
			this._layout = layout;
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x000813E8 File Offset: 0x0007F5E8
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001DE8 RID: 7656 RVA: 0x000813F0 File Offset: 0x0007F5F0
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription[] Groups
		{
			get
			{
				return this._groups;
			}
		}

		// Token: 0x04000EB4 RID: 3764
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;

		// Token: 0x04000EB5 RID: 3765
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription[] _groups;
	}
}
