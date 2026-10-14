using System;
using System.Windows;

namespace Infragistics.Windows.DockManager.Events
{
	// Token: 0x0200006E RID: 110
	public class PaneToolWindowEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060003CF RID: 975 RVA: 0x00015019 File Offset: 0x00013219
		public PaneToolWindowEventArgs(global::Infragistics.Windows.DockManager.PaneToolWindow window)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(window, "window");
			this._window = window;
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00015033 File Offset: 0x00013233
		public global::Infragistics.Windows.DockManager.PaneToolWindow Window
		{
			get
			{
				return this._window;
			}
		}

		// Token: 0x0400027A RID: 634
		private global::Infragistics.Windows.DockManager.PaneToolWindow _window;
	}
}
