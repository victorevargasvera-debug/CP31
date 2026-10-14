using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Media;

namespace CefSharp.Wpf.Experimental.Accessibility
{
	// Token: 0x0200002C RID: 44
	public class TabControlAutomationPeer : global::System.Windows.Automation.Peers.UIElementAutomationPeer
	{
		// Token: 0x0600023D RID: 573 RVA: 0x00008426 File Offset: 0x00006626
		public TabControlAutomationPeer(global::System.Windows.UIElement owner) : base(owner)
		{
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00008430 File Offset: 0x00006630
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenCore = base.GetChildrenCore();
			childrenCore.AddRange(this.GetChildPeers(base.Owner));
			return childrenCore;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00008458 File Offset: 0x00006658
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildPeers(global::System.Windows.UIElement element)
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			for (int i = 0; i < global::System.Windows.Media.VisualTreeHelper.GetChildrenCount(element); i++)
			{
				global::System.Windows.UIElement uielement = global::System.Windows.Media.VisualTreeHelper.GetChild(element, i) as global::System.Windows.UIElement;
				if (uielement != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(uielement);
					if (automationPeer != null)
					{
						list.Add(automationPeer);
					}
					else
					{
						list.AddRange(this.GetChildPeers(uielement));
					}
				}
			}
			return list;
		}
	}
}
