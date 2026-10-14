using System;
using System.Windows;

namespace Infragistics.Windows.DockManager.Events
{
	// Token: 0x0200006A RID: 106
	public class InitializePaneContentEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x00014FBC File Offset: 0x000131BC
		public InitializePaneContentEventArgs(global::Infragistics.Windows.DockManager.ContentPane newPane)
		{
			global::Infragistics.Windows.DockManager.DockManagerUtilities.ThrowIfNull(newPane, "newPane");
			this._pane = newPane;
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x00014FD6 File Offset: 0x000131D6
		// (set) Token: 0x060003CA RID: 970 RVA: 0x00014FDE File Offset: 0x000131DE
		public global::Infragistics.Windows.DockManager.ContentPane NewPane
		{
			get
			{
				return this._pane;
			}
			set
			{
				this._pane = value;
			}
		}

		// Token: 0x04000278 RID: 632
		private global::Infragistics.Windows.DockManager.ContentPane _pane;
	}
}
