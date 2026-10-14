using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002EF RID: 751
	public class ViewStateChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022E7 RID: 8935 RVA: 0x000981B4 File Offset: 0x000963B4
		public ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction action)
		{
			this._action = action;
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x000981C3 File Offset: 0x000963C3
		public global::Infragistics.Windows.DataPresenter.ViewStateChangedAction Action
		{
			get
			{
				return this._action;
			}
		}

		// Token: 0x04001166 RID: 4454
		private global::Infragistics.Windows.DataPresenter.ViewStateChangedAction _action;
	}
}
