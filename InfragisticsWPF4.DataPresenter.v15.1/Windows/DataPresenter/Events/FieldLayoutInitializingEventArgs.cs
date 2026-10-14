using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C6 RID: 710
	public class FieldLayoutInitializingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600225F RID: 8799 RVA: 0x00097AB1 File Offset: 0x00095CB1
		public FieldLayoutInitializingEventArgs(global::Infragistics.Windows.DataPresenter.FieldLayout layout)
		{
			this._layout = layout;
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06002260 RID: 8800 RVA: 0x00097AC0 File Offset: 0x00095CC0
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._layout;
			}
		}

		// Token: 0x04001116 RID: 4374
		private global::Infragistics.Windows.DataPresenter.FieldLayout _layout;
	}
}
