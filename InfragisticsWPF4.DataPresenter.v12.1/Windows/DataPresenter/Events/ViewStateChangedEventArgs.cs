using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002AC RID: 684
	public class ViewStateChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E5F RID: 7775 RVA: 0x00081A20 File Offset: 0x0007FC20
		public ViewStateChangedEventArgs(global::Infragistics.Windows.DataPresenter.ViewStateChangedAction action)
		{
			this._action = action;
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001E60 RID: 7776 RVA: 0x00081A2F File Offset: 0x0007FC2F
		public global::Infragistics.Windows.DataPresenter.ViewStateChangedAction Action
		{
			get
			{
				return this._action;
			}
		}

		// Token: 0x04000EFC RID: 3836
		private global::Infragistics.Windows.DataPresenter.ViewStateChangedAction _action;
	}
}
