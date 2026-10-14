using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;

namespace CefSharp.Wpf.Experimental.Accessibility
{
	// Token: 0x0200002B RID: 43
	public class BrowserAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000238 RID: 568 RVA: 0x00008396 File Offset: 0x00006596
		public BrowserAutomationPeer(global::System.Windows.FrameworkElement owner) : base(owner)
		{
			this.accessibilityTrees = new global::System.Collections.Generic.Dictionary<string, global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityTree>();
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000083AC File Offset: 0x000065AC
		public virtual void OnAccessibilityTreeChange(string treeId, global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> accessibilityUpdateDictionary)
		{
			global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityTree accessibilityTree;
			if (this.accessibilityTrees.ContainsKey(treeId))
			{
				accessibilityTree = this.accessibilityTrees[treeId];
			}
			else
			{
				accessibilityTree = new global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityTree((global::System.Windows.FrameworkElement)base.Owner, treeId);
				this.accessibilityTrees.Add(treeId, accessibilityTree);
				base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
			}
			accessibilityTree.Update(accessibilityUpdateDictionary);
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00008404 File Offset: 0x00006604
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			return this.accessibilityTrees.Values.Cast<global::System.Windows.Automation.Peers.AutomationPeer>().ToList<global::System.Windows.Automation.Peers.AutomationPeer>();
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000841B File Offset: 0x0000661B
		protected override string GetNameCore()
		{
			return "Web Browser";
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00008422 File Offset: 0x00006622
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Group;
		}

		// Token: 0x040001B9 RID: 441
		private readonly global::System.Collections.Generic.Dictionary<string, global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityTree> accessibilityTrees;
	}
}
