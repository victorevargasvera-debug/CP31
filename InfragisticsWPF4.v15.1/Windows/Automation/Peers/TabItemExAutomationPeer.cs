using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000105 RID: 261
	public class TabItemExAutomationPeer : global::System.Windows.Automation.Peers.TabItemAutomationPeer
	{
		// Token: 0x06000935 RID: 2357 RVA: 0x0001FB24 File Offset: 0x0001DD24
		public TabItemExAutomationPeer(object item, global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer tabControlAutomationPeer) : base(item, tabControlAutomationPeer)
		{
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0001FB30 File Offset: 0x0001DD30
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::Infragistics.Windows.Controls.XamTabControl xamTabControl = ((global::Infragistics.Windows.Automation.Peers.XamTabControlAutomationPeer)base.ItemsControlAutomationPeer).Owner as global::Infragistics.Windows.Controls.XamTabControl;
			if (xamTabControl != null)
			{
				xamTabControl.ApplyTemplate();
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
