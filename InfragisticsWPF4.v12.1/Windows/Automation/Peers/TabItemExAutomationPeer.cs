using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E7 RID: 231
	public class TabItemExAutomationPeer : global::System.Windows.Automation.Peers.TabItemAutomationPeer
	{
		// Token: 0x06000836 RID: 2102 RVA: 0x0001BF5C File Offset: 0x0001A15C
		public TabItemExAutomationPeer(object item, global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer tabControlAutomationPeer) : base(item, tabControlAutomationPeer)
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0001BF68 File Offset: 0x0001A168
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = ((global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer)base.ItemsControlAutomationPeer).Owner as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.UpdateLayout();
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = base.GetChildrenCore();
			if (xamTabControl != null)
			{
				global::System.Windows.Controls.TabItem tabItem = xamTabControl.ItemContainerGenerator.ContainerFromItem(base.Item) as global::System.Windows.Controls.TabItem;
				if (tabItem != null && tabItem.IsSelected && xamTabControl.IsMinimized)
				{
					global::System.Windows.Controls.ContentPresenter minimizedContentPresenter = xamTabControl.MinimizedContentPresenter;
					if (minimizedContentPresenter != null)
					{
						global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> children = new global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer(minimizedContentPresenter).GetChildren();
						if (children != null)
						{
							if (list == null)
							{
								list = children;
							}
							else
							{
								list.AddRange(children);
							}
						}
					}
				}
			}
			return list;
		}
	}
}
