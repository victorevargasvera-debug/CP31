using System;
using System.Windows;

namespace DevComponents.WpfDock
{
	// Token: 0x02000032 RID: 50
	public class BeforeDockedRoutedEventArgs : global::DevComponents.WpfDock.DockRoutedEventArgs
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00040748 File Offset: 0x0003E948
		public BeforeDockedRoutedEventArgs(global::System.Windows.RoutedEvent e) : base(e)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00040764 File Offset: 0x0003E964
		public BeforeDockedRoutedEventArgs(global::System.Windows.RoutedEvent e, object source) : base(e, source)
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00040780 File Offset: 0x0003E980
		public BeforeDockedRoutedEventArgs(global::System.Windows.RoutedEvent e, object source, object dockControl, global::DevComponents.WpfDock.eEventActionSource actionSource, bool isFloating, global::DevComponents.WpfDock.eDockSide dockSide, global::DevComponents.WpfDock.DockWindowGroup refGroup) : base(e, source, dockControl, actionSource)
		{
			this.IsFloating = isFloating;
			this.DockSide = dockSide;
			this.ReferenceDockGroup = refGroup;
		}

		// Token: 0x0400018F RID: 399
		public readonly bool IsFloating;

		// Token: 0x04000190 RID: 400
		public readonly global::DevComponents.WpfDock.eDockSide DockSide = global::DevComponents.WpfDock.eDockSide.Left;

		// Token: 0x04000191 RID: 401
		public readonly global::DevComponents.WpfDock.DockWindowGroup ReferenceDockGroup;
	}
}
