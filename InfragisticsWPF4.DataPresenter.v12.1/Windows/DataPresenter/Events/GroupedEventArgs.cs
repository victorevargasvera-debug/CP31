using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000289 RID: 649
	public class GroupedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DE9 RID: 7657 RVA: 0x000813F8 File Offset: 0x0007F5F8
		public GroupedEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldSortDescription[] groups)
		{
			this._layout = layout;
			this._groups = groups;
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06001DEA RID: 7658 RVA: 0x0008140E File Offset: 0x0007F60E
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x00081416 File Offset: 0x0007F616
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription[] Groups
		{
			get
			{
				return this._groups;
			}
		}

		// Token: 0x04000EB6 RID: 3766
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;

		// Token: 0x04000EB7 RID: 3767
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription[] _groups;
	}
}
