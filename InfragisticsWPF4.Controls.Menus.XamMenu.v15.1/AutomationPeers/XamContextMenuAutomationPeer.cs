using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Controls.Menus;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000003 RID: 3
	public class XamContextMenuAutomationPeer : global::System.Windows.Automation.Peers.ItemsControlAutomationPeer
	{
		// Token: 0x06000007 RID: 7 RVA: 0x0000233B File Offset: 0x0000053B
		public XamContextMenuAutomationPeer(global::Infragistics.Controls.Menus.XamContextMenu owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002352 File Offset: 0x00000552
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Menu;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002358 File Offset: 0x00000558
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Controls.ItemCollection items = this.OwningContextMenu.Items;
			if (items.Count <= 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(items.Count);
			for (int i = 0; i < items.Count; i++)
			{
				global::System.Windows.UIElement uielement = this.OwningContextMenu.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.UIElement;
				if (uielement != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(uielement) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(uielement);
					if (automationPeer != null)
					{
						list.Add(automationPeer);
					}
				}
			}
			return list;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023D2 File Offset: 0x000005D2
		protected override string GetClassNameCore()
		{
			return "XamContextMenu";
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023DC File Offset: 0x000005DC
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text) && this.OwningContextMenu.Header is string)
			{
				text = (string)this.OwningContextMenu.Header;
			}
			return text;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000241C File Offset: 0x0000061C
		protected override global::System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item)
		{
			global::System.Windows.Automation.Peers.ItemAutomationPeer result = null;
			if (item is global::System.Windows.UIElement)
			{
				result = (global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement((global::System.Windows.UIElement)item) as global::System.Windows.Automation.Peers.ItemAutomationPeer);
			}
			return result;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002445 File Offset: 0x00000645
		private global::Infragistics.Controls.Menus.XamContextMenu OwningContextMenu
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamContextMenu)base.Owner;
			}
		}
	}
}
