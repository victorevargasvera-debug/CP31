using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.Controls.Menus;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000005 RID: 5
	public class XamMenuItemAutomationPeer : global::System.Windows.Automation.Peers.ItemsControlAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider, global::System.Windows.Automation.Provider.IToggleProvider, global::System.Windows.Automation.Provider.IInvokeProvider
	{
		// Token: 0x06000015 RID: 21 RVA: 0x0000256C File Offset: 0x0000076C
		public XamMenuItemAutomationPeer(global::Infragistics.Controls.Menus.XamMenuItem owner) : base(owner)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
			this.OwningMenuItem.Checked += this.OwningMenuItem_Checked;
			this.OwningMenuItem.SubmenuClosed += this.OwningMenuItem_SubmenuClosed;
			this.OwningMenuItem.SubmenuOpened += this.OwningMenuItem_SubmenuOpened;
			this.OwningMenuItem.Unchecked += this.OwningMenuItem_Unchecked;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000025EA File Offset: 0x000007EA
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.MenuItem;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000025F0 File Offset: 0x000007F0
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Controls.ItemCollection items = this.OwningMenuItem.Items;
			if (items.Count <= 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(items.Count);
			for (int i = 0; i < items.Count; i++)
			{
				global::System.Windows.UIElement uielement = this.OwningMenuItem.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.UIElement;
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

		// Token: 0x06000018 RID: 24 RVA: 0x0000266A File Offset: 0x0000086A
		protected override string GetClassNameCore()
		{
			return "XamMenuItem";
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002674 File Offset: 0x00000874
		protected override string GetNameCore()
		{
			string text = base.GetNameCore();
			if (string.IsNullOrEmpty(text) && this.OwningMenuItem.Header is string)
			{
				text = (string)this.OwningMenuItem.Header;
			}
			return text;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000026B4 File Offset: 0x000008B4
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Invoke && !this.OwningMenuItem.HasChildren)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse && this.OwningMenuItem.HasChildren)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Toggle && this.OwningMenuItem.IsCheckable)
			{
				return this;
			}
			return null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000026F0 File Offset: 0x000008F0
		protected override global::System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item)
		{
			global::System.Windows.Automation.Peers.ItemAutomationPeer result = null;
			if (item is global::System.Windows.UIElement)
			{
				result = (global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement((global::System.Windows.UIElement)item) as global::System.Windows.Automation.Peers.ItemAutomationPeer);
			}
			return result;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002719 File Offset: 0x00000919
		private global::Infragistics.Controls.Menus.XamMenuItem OwningMenuItem
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamMenuItem)base.Owner;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002726 File Offset: 0x00000926
		internal void RaiseExpandCollapseStatePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapseState oldValue, global::System.Windows.Automation.ExpandCollapseState newValue)
		{
			if (oldValue != newValue && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, oldValue, newValue);
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000274C File Offset: 0x0000094C
		internal void RaiseToggleStatePropertyChangedEvent(global::System.Windows.Automation.ToggleState oldValue, global::System.Windows.Automation.ToggleState newValue)
		{
			if (oldValue != newValue && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.TogglePatternIdentifiers.ToggleStateProperty, oldValue, newValue);
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002772 File Offset: 0x00000972
		private void OwningMenuItem_Checked(object sender, global::System.EventArgs e)
		{
			this.RaiseToggleStatePropertyChangedEvent(global::System.Windows.Automation.ToggleState.On, global::System.Windows.Automation.ToggleState.Off);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000277C File Offset: 0x0000097C
		private void OwningMenuItem_SubmenuClosed(object sender, global::System.EventArgs e)
		{
			this.RaiseExpandCollapseStatePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapseState.Expanded, global::System.Windows.Automation.ExpandCollapseState.Collapsed);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002786 File Offset: 0x00000986
		private void OwningMenuItem_SubmenuOpened(object sender, global::System.EventArgs e)
		{
			this.RaiseExpandCollapseStatePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapseState.Collapsed, global::System.Windows.Automation.ExpandCollapseState.Expanded);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002790 File Offset: 0x00000990
		private void OwningMenuItem_Unchecked(object sender, global::System.EventArgs e)
		{
			this.RaiseToggleStatePropertyChangedEvent(global::System.Windows.Automation.ToggleState.Off, global::System.Windows.Automation.ToggleState.On);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000279A File Offset: 0x0000099A
		public void Collapse()
		{
			if (!this.OwningMenuItem.HasChildren)
			{
				throw new global::System.InvalidOperationException();
			}
			this.OwningMenuItem.CloseSubmenu(false);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000027BB File Offset: 0x000009BB
		public void Expand()
		{
			if (!this.OwningMenuItem.HasChildren)
			{
				throw new global::System.InvalidOperationException();
			}
			this.OwningMenuItem.OpenSubmenu();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000027DB File Offset: 0x000009DB
		public global::System.Windows.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				if (!this.OwningMenuItem.HasChildren)
				{
					return global::System.Windows.Automation.ExpandCollapseState.LeafNode;
				}
				if (!this.OwningMenuItem.IsSubmenuOpen)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Expanded;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000027FC File Offset: 0x000009FC
		public void Invoke()
		{
			this.OwningMenuItem.AutomationMenuItemClick();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002809 File Offset: 0x00000A09
		public global::System.Windows.Automation.ToggleState ToggleState
		{
			get
			{
				if (!this.OwningMenuItem.IsChecked)
				{
					return global::System.Windows.Automation.ToggleState.Off;
				}
				return global::System.Windows.Automation.ToggleState.On;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000281B File Offset: 0x00000A1B
		public void Toggle()
		{
			if (!this.OwningMenuItem.IsCheckable)
			{
				throw new global::System.InvalidOperationException();
			}
			this.OwningMenuItem.IsChecked = !this.OwningMenuItem.IsChecked;
			this.OwningMenuItem.ChangeVisualState(false);
		}
	}
}
