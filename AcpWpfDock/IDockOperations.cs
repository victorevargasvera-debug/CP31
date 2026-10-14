using System;
using System.Windows;

namespace DevComponents.WpfDock
{
	// Token: 0x02000039 RID: 57
	public interface IDockOperations
	{
		// Token: 0x06000286 RID: 646
		void BeginDockOperation(bool isFloatWindowOperation);

		// Token: 0x06000287 RID: 647
		global::DevComponents.WpfDock.DockWindowGroup TearOffSelectedDockWindow(global::DevComponents.WpfDock.DockWindowGroup currentGroup);

		// Token: 0x06000288 RID: 648
		void DockWindow(global::DevComponents.WpfDock.DockWindowGroup dragDockWindowGroup, global::DevComponents.WpfDock.eDockSide dockSide, bool fullSize);

		// Token: 0x06000289 RID: 649
		void DockWindow(global::DevComponents.WpfDock.DockWindowGroup dragDockWindowGroup, global::System.Windows.UIElement mouseOverElement, global::DevComponents.WpfDock.eDockSide dockSide);

		// Token: 0x0600028A RID: 650
		void FloatWindow(global::DevComponents.WpfDock.DockWindowGroup dragDockWindowGroup, global::System.Windows.Rect floatingRect);

		// Token: 0x0600028B RID: 651
		void EndDockOperation();
	}
}
