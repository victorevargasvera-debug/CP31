using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls.Primitives;
using Infragistics.Controls.Menus;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000004 RID: 4
	public class XamDataTreeAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IScrollProvider, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x06000009 RID: 9 RVA: 0x00002368 File Offset: 0x00000568
		public XamDataTreeAutomationPeer(global::Infragistics.Controls.Menus.XamDataTree owner) : base(owner)
		{
			owner.LayoutUpdated += this.Owner_LayoutUpdated;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000238E File Offset: 0x0000058E
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Tree;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002392 File Offset: 0x00000592
		protected override bool IsContentElementCore()
		{
			return true;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002395 File Offset: 0x00000595
		protected override bool IsControlElementCore()
		{
			return true;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002398 File Offset: 0x00000598
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			if (this.OwningDataTree.Panel == null)
			{
				return null;
			}
			global::Infragistics.Controls.Menus.XamDataTreeNodesCollection nodes = this.OwningDataTree.Nodes;
			if (nodes.Count <= 0)
			{
				return null;
			}
			if (this._list == null)
			{
				this._list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(nodes.Count);
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in nodes)
				{
					if (xamDataTreeNode.Control != null || this.NodeHasVisibleChildren(xamDataTreeNode))
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
						if (this._peersCache.ContainsKey(xamDataTreeNode))
						{
							automationPeer = this._peersCache[xamDataTreeNode];
						}
						else
						{
							automationPeer = new global::Infragistics.AutomationPeers.XamDataTreeNodeAutomationPeer(xamDataTreeNode);
							this._peersCache.Add(xamDataTreeNode, automationPeer);
						}
						this._list.Add(automationPeer);
					}
				}
			}
			return this._list;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002478 File Offset: 0x00000678
		private bool NodeHasVisibleChildren(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			bool result = false;
			foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in node.Nodes)
			{
				if (xamDataTreeNode.Control != null)
				{
					result = true;
					break;
				}
				result = this.NodeHasVisibleChildren(xamDataTreeNode);
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000024D8 File Offset: 0x000006D8
		protected override string GetClassNameCore()
		{
			return this.OwningDataTree.GetType().Name;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000024EC File Offset: 0x000006EC
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			if (string.IsNullOrEmpty(nameCore))
			{
				return this.OwningDataTree.Name;
			}
			return nameCore;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002515 File Offset: 0x00000715
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Scroll)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000012 RID: 18 RVA: 0x0000252A File Offset: 0x0000072A
		private double HorizontalMaximum
		{
			get
			{
				return this.HorizontalScrollBar.Maximum;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002537 File Offset: 0x00000737
		private double HorizontalMinimum
		{
			get
			{
				return this.HorizontalScrollBar.Minimum;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002544 File Offset: 0x00000744
		private global::System.Windows.Controls.Primitives.ScrollBar HorizontalScrollBar
		{
			get
			{
				global::Infragistics.IProvideScrollInfo owningDataTree = this.OwningDataTree;
				if (owningDataTree != null)
				{
					return owningDataTree.HorizontalScrollBar;
				}
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002563 File Offset: 0x00000763
		private double HorizontalValue
		{
			get
			{
				return this.HorizontalScrollBar.Value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002570 File Offset: 0x00000770
		private global::Infragistics.Controls.Menus.XamDataTree OwningDataTree
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamDataTree)base.Owner;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000017 RID: 23 RVA: 0x0000257D File Offset: 0x0000077D
		private double VerticalMaximum
		{
			get
			{
				return this.VerticalScrollBar.Maximum;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000018 RID: 24 RVA: 0x0000258A File Offset: 0x0000078A
		private double VerticalMinimum
		{
			get
			{
				return this.VerticalScrollBar.Minimum;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002598 File Offset: 0x00000798
		private global::System.Windows.Controls.Primitives.ScrollBar VerticalScrollBar
		{
			get
			{
				global::Infragistics.IProvideScrollInfo owningDataTree = this.OwningDataTree;
				if (owningDataTree != null)
				{
					return owningDataTree.VerticalScrollBar;
				}
				return null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000025B7 File Offset: 0x000007B7
		private double VerticalValue
		{
			get
			{
				return this.VerticalScrollBar.Value;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000025C4 File Offset: 0x000007C4
		private void Owner_LayoutUpdated(object sender, global::System.EventArgs e)
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> nodesInView = this.GetNodesInView();
			if (this._oldNodesInView != null && !global::Infragistics.CoreUtilities.AreEqual<global::Infragistics.Controls.Menus.XamDataTreeNode>(nodesInView, this._oldNodesInView, null))
			{
				this._list = null;
				base.ResetChildrenCache();
			}
			this._oldNodesInView = nodesInView;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002604 File Offset: 0x00000804
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> GetNodesInView()
		{
			global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode>();
			if (this.OwningDataTree != null && this.OwningDataTree.Panel != null)
			{
				global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Menus.XamDataTreeNodeControl> enumerable = this.OwningDataTree.Panel.Children.OfType<global::Infragistics.Controls.Menus.XamDataTreeNodeControl>();
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNodeControl xamDataTreeNodeControl in enumerable)
				{
					global::Infragistics.Controls.Menus.XamDataTreeNode node = xamDataTreeNodeControl.Node;
					list.Add(node);
				}
			}
			return list;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000268C File Offset: 0x0000088C
		public void Scroll(global::System.Windows.Automation.ScrollAmount horizontalAmount, global::System.Windows.Automation.ScrollAmount verticalAmount)
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if ((horizontalAmount != global::System.Windows.Automation.ScrollAmount.NoAmount && !this.HorizontallyScrollable) || (verticalAmount != global::System.Windows.Automation.ScrollAmount.NoAmount && !this.VerticallyScrollable))
			{
				throw new global::System.InvalidOperationException("Cannot scroll because the XamGrid is not scrollable.");
			}
			switch (horizontalAmount)
			{
			case global::System.Windows.Automation.ScrollAmount.LargeDecrement:
				this.HorizontalScrollBar.Value -= this.HorizontalScrollBar.LargeChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.SmallDecrement:
				this.HorizontalScrollBar.Value -= this.HorizontalScrollBar.SmallChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.LargeIncrement:
				this.HorizontalScrollBar.Value += this.HorizontalScrollBar.LargeChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.SmallIncrement:
				this.HorizontalScrollBar.Value += this.HorizontalScrollBar.SmallChange;
				break;
			}
			switch (verticalAmount)
			{
			case global::System.Windows.Automation.ScrollAmount.LargeDecrement:
				this.VerticalScrollBar.Value -= this.VerticalScrollBar.LargeChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.SmallDecrement:
				this.VerticalScrollBar.Value -= this.VerticalScrollBar.SmallChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.LargeIncrement:
				this.VerticalScrollBar.Value += this.VerticalScrollBar.LargeChange;
				break;
			case global::System.Windows.Automation.ScrollAmount.SmallIncrement:
				this.VerticalScrollBar.Value += this.VerticalScrollBar.SmallChange;
				break;
			}
			this.OwningDataTree.NodesManager.InvalidateNodes();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000280C File Offset: 0x00000A0C
		public void SetScrollPercent(double horizontalPercent, double verticalPercent)
		{
			if ((horizontalPercent != -1.0 && !this.HorizontallyScrollable) || (verticalPercent != -1.0 && !this.VerticallyScrollable))
			{
				throw new global::System.InvalidOperationException("Cannot scroll because the GridViewScrollViewer is not scrollable.");
			}
			if (horizontalPercent != -1.0 && (horizontalPercent < 0.0 || horizontalPercent > 100.0))
			{
				throw new global::System.ArgumentOutOfRangeException("horizontalPercent", "The horizontal perecentage must be between 0.0 and 100.0.");
			}
			if (verticalPercent != -1.0 && (verticalPercent < 0.0 || verticalPercent > 100.0))
			{
				throw new global::System.ArgumentOutOfRangeException("verticalPercent", "The vertical perecentage must be between 0.0 and 100.0.");
			}
			if (horizontalPercent != -1.0 && this.HorizontalScrollBar != null)
			{
				this.HorizontalScrollBar.Value = 0.0;
				this.OwningDataTree.NodesManager.InvalidateNodes();
				double smallChange = this.HorizontalScrollBar.SmallChange;
				this.HorizontalScrollBar.SmallChange = (this.HorizontalMaximum - this.HorizontalMinimum) * horizontalPercent * 0.01;
				this.Scroll(global::System.Windows.Automation.ScrollAmount.SmallIncrement, global::System.Windows.Automation.ScrollAmount.NoAmount);
				this.HorizontalScrollBar.SmallChange = smallChange;
			}
			if (verticalPercent != -1.0 && this.VerticalScrollBar != null)
			{
				this.VerticalScrollBar.Value = 0.0;
				this.OwningDataTree.NodesManager.InvalidateNodes();
				double smallChange2 = this.VerticalScrollBar.SmallChange;
				this.VerticalScrollBar.SmallChange = (this.VerticalMaximum - this.VerticalMinimum) * verticalPercent * 0.01;
				this.Scroll(global::System.Windows.Automation.ScrollAmount.NoAmount, global::System.Windows.Automation.ScrollAmount.SmallIncrement);
				this.VerticalScrollBar.SmallChange = smallChange2;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000029AC File Offset: 0x00000BAC
		public double HorizontalScrollPercent
		{
			get
			{
				if (this.HorizontallyScrollable)
				{
					return (this.HorizontalValue - this.HorizontalMinimum) / (this.HorizontalMaximum - this.HorizontalMinimum) * 100.0;
				}
				return -1.0;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000020 RID: 32 RVA: 0x000029E5 File Offset: 0x00000BE5
		public double VerticalScrollPercent
		{
			get
			{
				if (this.VerticallyScrollable)
				{
					return (this.VerticalValue - this.VerticalMinimum) / (this.VerticalMaximum - this.VerticalMinimum) * 100.0;
				}
				return -1.0;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002A1E File Offset: 0x00000C1E
		public double HorizontalViewSize
		{
			get
			{
				if (this.HorizontalScrollBar != null)
				{
					return this.HorizontalMaximum - this.HorizontalMinimum;
				}
				return 0.0;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002A3F File Offset: 0x00000C3F
		public double VerticalViewSize
		{
			get
			{
				if (this.VerticalScrollBar != null)
				{
					return this.VerticalMaximum - this.VerticalMinimum;
				}
				return 0.0;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002A60 File Offset: 0x00000C60
		public bool HorizontallyScrollable
		{
			get
			{
				return this.HorizontalScrollBar != null;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002A6E File Offset: 0x00000C6E
		public bool VerticallyScrollable
		{
			get
			{
				return this.VerticalScrollBar != null;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002A7C File Offset: 0x00000C7C
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple[] GetSelection()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>();
			int count = this.OwningDataTree.SelectionSettings.SelectedNodes.Count;
			if (count > 0)
			{
				for (int i = 0; i < count; i++)
				{
					global::System.Windows.UIElement control = this.OwningDataTree.SelectionSettings.SelectedNodes[i].Control;
					if (control != null)
					{
						global::System.Windows.Automation.Peers.AutomationPeer peer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(control) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(control);
						list.Add(base.ProviderFromPeer(peer));
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002AFA File Offset: 0x00000CFA
		public bool CanSelectMultiple
		{
			get
			{
				return this.OwningDataTree.SelectionSettings.NodeSelection == global::Infragistics.Controls.Menus.TreeSelectionType.Multiple;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002B0F File Offset: 0x00000D0F
		public bool IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000003 RID: 3
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamDataTreeNode> _oldNodesInView;

		// Token: 0x04000004 RID: 4
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Menus.XamDataTreeNode, global::System.Windows.Automation.Peers.AutomationPeer> _peersCache = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Menus.XamDataTreeNode, global::System.Windows.Automation.Peers.AutomationPeer>();

		// Token: 0x04000005 RID: 5
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> _list;
	}
}
