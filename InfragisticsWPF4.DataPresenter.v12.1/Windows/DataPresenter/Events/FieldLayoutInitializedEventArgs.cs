using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000284 RID: 644
	public class FieldLayoutInitializedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DD9 RID: 7641 RVA: 0x00081337 File Offset: 0x0007F537
		public FieldLayoutInitializedEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this._layout = layout;
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x00081346 File Offset: 0x0007F546
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x04000EAD RID: 3757
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;
	}
}
