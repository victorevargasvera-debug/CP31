using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002CC RID: 716
	public class GroupedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002271 RID: 8817 RVA: 0x00097B89 File Offset: 0x00095D89
		public GroupedEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout, global::Infragistics.Windows.DataPresenter.FieldSortDescription[] groups)
		{
			this._layout = layout;
			this._groups = groups;
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x00097B9F File Offset: 0x00095D9F
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x00097BA7 File Offset: 0x00095DA7
		public global::Infragistics.Windows.DataPresenter.FieldSortDescription[] Groups
		{
			get
			{
				return this._groups;
			}
		}

		// Token: 0x04001120 RID: 4384
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;

		// Token: 0x04001121 RID: 4385
		private global::Infragistics.Windows.DataPresenter.FieldSortDescription[] _groups;
	}
}
