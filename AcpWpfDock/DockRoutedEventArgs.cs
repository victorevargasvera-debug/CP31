using System;
using System.Windows;

namespace DevComponents.WpfDock
{
	// Token: 0x02000033 RID: 51
	public class DockRoutedEventArgs : global::DevComponents.WpfDock.CancelSourceRoutedEventArgs
	{
		// Token: 0x06000262 RID: 610 RVA: 0x000407B8 File Offset: 0x0003E9B8
		public DockRoutedEventArgs(global::System.Windows.RoutedEvent e) : base(e)
		{
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000407CC File Offset: 0x0003E9CC
		public DockRoutedEventArgs(global::System.Windows.RoutedEvent e, object source) : base(e, source)
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000407E4 File Offset: 0x0003E9E4
		public DockRoutedEventArgs(global::System.Windows.RoutedEvent e, object source, object dockControl, global::DevComponents.WpfDock.eEventActionSource actionSource) : base(e, source)
		{
			this.DockControl = dockControl;
			this.EventActionSource = actionSource;
		}

		// Token: 0x04000192 RID: 402
		public readonly object DockControl;
	}
}
