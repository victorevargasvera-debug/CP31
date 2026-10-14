using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000283 RID: 643
	public class FieldLayoutInitializingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DD7 RID: 7639 RVA: 0x00081320 File Offset: 0x0007F520
		public FieldLayoutInitializingEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this._layout = layout;
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0008132F File Offset: 0x0007F52F
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x04000EAC RID: 3756
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;
	}
}
