using System;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x02000012 RID: 18
	public class PaneTabItemWrapperAutomationPeer : global::System.Windows.Automation.Peers.TabItemWrapperAutomationPeer
	{
		// Token: 0x060000A5 RID: 165 RVA: 0x00004ABC File Offset: 0x00002CBC
		public PaneTabItemWrapperAutomationPeer(global::Infragistics.Windows.DockManager.PaneTabItem owner) : base(owner)
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00004AC8 File Offset: 0x00002CC8
		protected override bool IsOffscreenCore()
		{
			bool flag = base.IsOffscreenCore();
			if (flag)
			{
				global::Infragistics.Windows.DockManager.PaneTabItem container = base.Owner as global::Infragistics.Windows.DockManager.PaneTabItem;
				global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(container) as global::Infragistics.Windows.DockManager.TabGroupPane;
				if (tabGroupPane != null && tabGroupPane.IsVisible && !tabGroupPane.IsTabItemAreaVisible)
				{
					int num = tabGroupPane.ItemContainerGenerator.IndexFromContainer(container);
					if (num == tabGroupPane.SelectedIndex)
					{
						flag = false;
					}
				}
			}
			return flag;
		}
	}
}
