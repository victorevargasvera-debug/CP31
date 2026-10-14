using System;
using System.Globalization;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Menus;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000006 RID: 6
	public class XamDataTreeNodeControlAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider
	{
		// Token: 0x0600004E RID: 78 RVA: 0x00003170 File Offset: 0x00001370
		public XamDataTreeNodeControlAutomationPeer(global::Infragistics.Controls.Menus.XamDataTreeNodeControl owner) : base(owner)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003179 File Offset: 0x00001379
		protected override string GetClassNameCore()
		{
			return base.Owner.GetType().Name;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000318C File Offset: 0x0000138C
		protected override string GetNameCore()
		{
			string nameCore = base.GetNameCore();
			if (string.IsNullOrEmpty(nameCore) && this.OwningNode.Node != null)
			{
				return this.OwningNode.Node.Index.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			}
			return nameCore;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000031D4 File Offset: 0x000013D4
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.TreeItem;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000031D8 File Offset: 0x000013D8
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000031DB File Offset: 0x000013DB
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000031EC File Offset: 0x000013EC
		protected override bool IsOffscreenCore()
		{
			global::System.Windows.Rect boundingRectangleCore = this.GetBoundingRectangleCore();
			return boundingRectangleCore.Bottom < 0.0 || boundingRectangleCore.Right < 0.0 || base.IsOffscreenCore();
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000322C File Offset: 0x0000142C
		private global::Infragistics.Controls.Menus.XamDataTreeNodeControl OwningNode
		{
			get
			{
				return (global::Infragistics.Controls.Menus.XamDataTreeNodeControl)base.Owner;
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00003239 File Offset: 0x00001439
		public void Expand()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState == global::System.Windows.Automation.ExpandCollapseState.LeafNode)
			{
				throw new global::System.InvalidOperationException();
			}
			this.OwningNode.Node.IsExpanded = true;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00003269 File Offset: 0x00001469
		public void Collapse()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState == global::System.Windows.Automation.ExpandCollapseState.LeafNode)
			{
				throw new global::System.InvalidOperationException();
			}
			this.OwningNode.Node.IsExpanded = false;
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000329C File Offset: 0x0000149C
		public global::System.Windows.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode node = this.OwningNode.Node;
				if (node == null)
				{
					return global::System.Windows.Automation.ExpandCollapseState.LeafNode;
				}
				if (!node.HasChildren)
				{
					return global::System.Windows.Automation.ExpandCollapseState.LeafNode;
				}
				if (!node.IsExpanded)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Expanded;
			}
		}
	}
}
