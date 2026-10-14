using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Menus;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000005 RID: 5
	public class XamDataTreeNodeAutomationPeer : global::System.Windows.Automation.Peers.AutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x06000028 RID: 40 RVA: 0x00002B14 File Offset: 0x00000D14
		public XamDataTreeNodeAutomationPeer(global::Infragistics.Controls.Menus.XamDataTreeNode node)
		{
			this._node = node;
			this._node.PropertyChanged += this.Node_PropertyChanged;
			this._node.NodeRendered += this.Node_NodeRendered;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002B67 File Offset: 0x00000D67
		private void Node_NodeRendered(object sender, global::System.EventArgs e)
		{
			this._childNodes = null;
			base.InvalidatePeer();
			base.ResetChildrenCache();
			base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002B84 File Offset: 0x00000D84
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.TreeItem;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002B88 File Offset: 0x00000D88
		protected override string GetClassNameCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return "XamDataTreeNode";
			}
			return underlyingPeer.GetClassName();
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002BAC File Offset: 0x00000DAC
		protected override string GetAcceleratorKeyCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAcceleratorKey();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002BD0 File Offset: 0x00000DD0
		protected override string GetAccessKeyCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAccessKey();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002BF4 File Offset: 0x00000DF4
		protected override string GetAutomationIdCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetAutomationId();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002C18 File Offset: 0x00000E18
		protected override global::System.Windows.Rect GetBoundingRectangleCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return default(global::System.Windows.Rect);
			}
			return underlyingPeer.GetBoundingRectangle();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002C40 File Offset: 0x00000E40
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = (underlyingPeer != null) ? underlyingPeer.GetChildren() : null;
			if (this._node.IsExpanded && this._childNodes == null)
			{
				this._childNodes = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
				foreach (global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode in this._node.Nodes)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer;
					if (this._cachedPeers.ContainsKey(xamDataTreeNode))
					{
						automationPeer = this._cachedPeers[xamDataTreeNode];
					}
					else
					{
						automationPeer = new global::Infragistics.AutomationPeers.XamDataTreeNodeAutomationPeer(xamDataTreeNode);
						this._cachedPeers.Add(xamDataTreeNode, automationPeer);
					}
					if (xamDataTreeNode.Control != null)
					{
						this._childNodes.Add(automationPeer);
					}
					else
					{
						xamDataTreeNode.PropertyChanged -= this.item_PropertyChanged;
						xamDataTreeNode.PropertyChanged += this.item_PropertyChanged;
					}
				}
			}
			if (this._childNodes != null && this._childNodes.Count > 0)
			{
				if (list == null)
				{
					list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
				}
				list.InsertRange(list.Count, this._childNodes);
			}
			return list;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002D6C File Offset: 0x00000F6C
		private void item_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Control")
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode xamDataTreeNode = sender as global::Infragistics.Controls.Menus.XamDataTreeNode;
				if (xamDataTreeNode != null && xamDataTreeNode.Control != null)
				{
					this._childNodes = null;
					base.InvalidatePeer();
					base.ResetChildrenCache();
					base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
				}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002DB8 File Offset: 0x00000FB8
		protected override global::System.Windows.Point GetClickablePointCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return new global::System.Windows.Point(double.NaN, double.NaN);
			}
			return underlyingPeer.GetClickablePoint();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002DF0 File Offset: 0x00000FF0
		protected override string GetHelpTextCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetHelpText();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00002E14 File Offset: 0x00001014
		protected override string GetItemStatusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetItemStatus();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00002E38 File Offset: 0x00001038
		protected override string GetItemTypeCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetItemType();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002E58 File Offset: 0x00001058
		protected override global::System.Windows.Automation.Peers.AutomationPeer GetLabeledByCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return null;
			}
			return underlyingPeer.GetLabeledBy();
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002E78 File Offset: 0x00001078
		protected override string GetNameCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return string.Empty;
			}
			return underlyingPeer.GetName();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002E9C File Offset: 0x0000109C
		protected override global::System.Windows.Automation.Peers.AutomationOrientation GetOrientationCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer == null)
			{
				return global::System.Windows.Automation.Peers.AutomationOrientation.None;
			}
			return underlyingPeer.GetOrientation();
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002EBB File Offset: 0x000010BB
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			return null;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002ECC File Offset: 0x000010CC
		protected override bool HasKeyboardFocusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.HasKeyboardFocus();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002EEC File Offset: 0x000010EC
		protected override bool IsContentElementCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsContentElement();
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002F0C File Offset: 0x0000110C
		protected override bool IsControlElementCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsControlElement();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002F2C File Offset: 0x0000112C
		protected override bool IsEnabledCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsEnabled();
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002F4C File Offset: 0x0000114C
		protected override bool IsKeyboardFocusableCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsKeyboardFocusable();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002F6C File Offset: 0x0000116C
		protected override bool IsOffscreenCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer == null || underlyingPeer.IsOffscreen();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002F8C File Offset: 0x0000118C
		protected override bool IsPasswordCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsPassword();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002FAC File Offset: 0x000011AC
		protected override bool IsRequiredForFormCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			return underlyingPeer != null && underlyingPeer.IsRequiredForForm();
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002FCC File Offset: 0x000011CC
		protected override void SetFocusCore()
		{
			global::System.Windows.Automation.Peers.AutomationPeer underlyingPeer = this.GetUnderlyingPeer();
			if (underlyingPeer != null)
			{
				underlyingPeer.SetFocus();
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002FE9 File Offset: 0x000011E9
		private global::System.Windows.Automation.Peers.AutomationPeer GetUnderlyingPeer()
		{
			if (this._node.Control != null)
			{
				return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(this._node.Control);
			}
			return null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000300A File Offset: 0x0000120A
		public void ResetCachedPeers()
		{
			this._childNodes = null;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003014 File Offset: 0x00001214
		private void Node_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "IsExpanded")
			{
				this._childNodes = null;
				base.InvalidatePeer();
				base.ResetChildrenCache();
				base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
				return;
			}
			if (e.PropertyName == "Control")
			{
				this._childNodes = null;
				base.InvalidatePeer();
				base.ResetChildrenCache();
				base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000307C File Offset: 0x0000127C
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
			this._node.IsExpanded = false;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000030A7 File Offset: 0x000012A7
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
			this._node.IsExpanded = true;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000048 RID: 72 RVA: 0x000030D4 File Offset: 0x000012D4
		public global::System.Windows.Automation.ExpandCollapseState ExpandCollapseState
		{
			get
			{
				global::Infragistics.Controls.Menus.XamDataTreeNode node = this._node;
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

		// Token: 0x06000049 RID: 73 RVA: 0x00003102 File Offset: 0x00001302
		public void AddToSelection()
		{
			this._node.IsSelected = true;
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003110 File Offset: 0x00001310
		public bool IsSelected
		{
			get
			{
				return this._node.IsSelected;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000311D File Offset: 0x0000131D
		public void RemoveFromSelection()
		{
			this._node.IsSelected = false;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000312B File Offset: 0x0000132B
		public void Select()
		{
			this._node.IsSelected = true;
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004D RID: 77 RVA: 0x0000313C File Offset: 0x0000133C
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple SelectionContainer
		{
			get
			{
				global::Infragistics.Controls.Menus.XamDataTree tree = this._node.NodeLayout.Tree;
				if (tree != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(tree);
					if (automationPeer != null)
					{
						return base.ProviderFromPeer(automationPeer);
					}
				}
				return null;
			}
		}

		// Token: 0x04000006 RID: 6
		private global::Infragistics.Controls.Menus.XamDataTreeNode _node;

		// Token: 0x04000007 RID: 7
		private global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> _childNodes;

		// Token: 0x04000008 RID: 8
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Menus.XamDataTreeNode, global::System.Windows.Automation.Peers.AutomationPeer> _cachedPeers = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Menus.XamDataTreeNode, global::System.Windows.Automation.Peers.AutomationPeer>();
	}
}
