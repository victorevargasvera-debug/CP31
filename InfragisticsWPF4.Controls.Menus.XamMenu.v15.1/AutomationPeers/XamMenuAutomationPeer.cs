using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Controls.Menus;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000004 RID: 4
	public class XamMenuAutomationPeer : global::System.Windows.Automation.Peers.ItemsControlAutomationPeer
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002452 File Offset: 0x00000652
		public XamMenuAutomationPeer(global::Infragistics.Controls.Menus.XamMenu owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002469 File Offset: 0x00000669
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Menu;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002470 File Offset: 0x00000670
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Controls.ItemCollection items = this.OwningMenu.Items;
			if (items.Count <= 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(items.Count);
			for (int i = 0; i < items.Count; i++)
			{
				global::System.Windows.UIElement uielement = this.OwningMenu.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.UIElement;
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

		// Token: 0x06000011 RID: 17 RVA: 0x000024EA File Offset: 0x000006EA
		protected override string GetClassNameCore()
		{
			return "XamMenu";
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000024F4 File Offset: 0x000006F4
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text) && this.OwningMenu.Header is string)
			{
				text = (string)this.OwningMenu.Header;
			}
			return text;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002534 File Offset: 0x00000734
		protected override global::System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item)
		{
			global::System.Windows.Automation.Peers.ItemAutomationPeer result = null;
			if (item is global::System.Windows.UIElement)
			{
				result = (global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement((global::System.Windows.UIElement)item) as global::System.Windows.Automation.Peers.ItemAutomationPeer);
			}
			return result;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000014 RID: 20 RVA: 0x0000255D File Offset: 0x0000075D
		private global::Infragistics.Controls.Menus.XamMenu OwningMenu
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamMenu)base.Owner;
			}
		}
	}
}
