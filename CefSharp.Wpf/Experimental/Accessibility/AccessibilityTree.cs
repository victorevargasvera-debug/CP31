using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Automation.Peers;

namespace CefSharp.Wpf.Experimental.Accessibility
{
	// Token: 0x0200002A RID: 42
	public class AccessibilityTree : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00007EEF File Offset: 0x000060EF
		public string Id { get; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00007EF7 File Offset: 0x000060F7
		// (set) Token: 0x0600022B RID: 555 RVA: 0x00007EFF File Offset: 0x000060FF
		public int RootNodeId { get; private set; } = -1;

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00007F08 File Offset: 0x00006108
		// (set) Token: 0x0600022D RID: 557 RVA: 0x00007F10 File Offset: 0x00006110
		public int FocusedNodeId { get; private set; } = -1;

		// Token: 0x0600022E RID: 558 RVA: 0x00007F19 File Offset: 0x00006119
		public AccessibilityTree(global::System.Windows.FrameworkElement owner, string Id) : base(owner)
		{
			this.Id = Id;
			this.accessibilityNodeMap = new global::System.Collections.Generic.Dictionary<int, global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode>();
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00007F44 File Offset: 0x00006144
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode rootNode = this.GetRootNode();
			if (rootNode == null)
			{
				return new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(0);
			}
			return new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(1)
			{
				rootNode
			};
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00007F6F File Offset: 0x0000616F
		protected virtual global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode GetRootNode()
		{
			return this.GetNode(this.RootNodeId);
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00007F7D File Offset: 0x0000617D
		protected virtual global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode GetFocusedNode()
		{
			return this.GetNode(this.FocusedNodeId);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00007F8C File Offset: 0x0000618C
		public virtual void Update(global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> accessibilityUpdateDictionary)
		{
			if (accessibilityUpdateDictionary == null || !accessibilityUpdateDictionary.ContainsKey("events") || !accessibilityUpdateDictionary.ContainsKey("updates"))
			{
				return;
			}
			global::System.Collections.Generic.IList<global::CefSharp.IValue> list = accessibilityUpdateDictionary["events"].GetList();
			global::System.Collections.Generic.IList<global::CefSharp.IValue> list2 = accessibilityUpdateDictionary["updates"].GetList();
			if (list == null || list2 == null)
			{
				return;
			}
			global::System.Collections.Generic.List<global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue>> list3 = (from x in list
			select x.GetDictionary() into y
			where y.ContainsKey("event_type")
			select y).ToList<global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue>>();
			global::System.Collections.Generic.List<global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue>> updateDictionaries = (from x in list2
			select x.GetDictionary()).ToList<global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue>>();
			foreach (global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> dictionary in list3)
			{
				string @string = dictionary["event_type"].GetString();
				if (@string == "layoutComplete")
				{
					this.UpdateLayout(dictionary, updateDictionaries);
				}
				else if (@string == "focus")
				{
					this.UpdateFocus(dictionary, updateDictionaries);
				}
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000080DC File Offset: 0x000062DC
		protected virtual void UpdateLayout(global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> eventDictionary, global::System.Collections.Generic.List<global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue>> updateDictionaries)
		{
			foreach (global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> dictionary in updateDictionaries)
			{
				bool flag = false;
				if (dictionary.ContainsKey("node_id_to_clear"))
				{
					int @int = dictionary["node_id_to_clear"].GetInt();
					if (@int == this.RootNodeId)
					{
						this.RootNodeId = -1;
					}
					global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode node = this.GetNode(@int);
					this.RemoveNode(node);
				}
				if (dictionary.ContainsKey("root_id"))
				{
					int int2 = dictionary["root_id"].GetInt();
					if (int2 != this.RootNodeId)
					{
						this.RootNodeId = int2;
						flag = true;
					}
				}
				this.UpdateNodes(dictionary);
				if (flag)
				{
					base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.StructureChanged);
				}
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000081B0 File Offset: 0x000063B0
		protected virtual void UpdateFocus(global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> eventDictionary, global::System.Collections.Generic.List<global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue>> updateDictionaries)
		{
			bool flag = false;
			if (eventDictionary.ContainsKey("id"))
			{
				int @int = eventDictionary["id"].GetInt();
				if (@int != this.FocusedNodeId)
				{
					this.FocusedNodeId = @int;
					flag = true;
				}
			}
			if (flag)
			{
				if (this.GetFocusedNode() == null)
				{
					foreach (global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> update in updateDictionaries)
					{
						this.UpdateNodes(update);
					}
				}
				global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode focusedNode = this.GetFocusedNode();
				if (focusedNode != null)
				{
					focusedNode.OnFocusChanged();
				}
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00008250 File Offset: 0x00006450
		protected virtual void RemoveNode(global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode node)
		{
			if (node == null)
			{
				return;
			}
			foreach (global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode node2 in node.GetChildAccessibilityNodes())
			{
				this.RemoveNode(node2);
			}
			this.accessibilityNodeMap.Remove(node.Id);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000082BC File Offset: 0x000064BC
		protected virtual void UpdateNodes(global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> update)
		{
			if (update == null || !update.ContainsKey("nodes"))
			{
				return;
			}
			global::System.Collections.Generic.IList<global::CefSharp.IValue> list = update["nodes"].GetList();
			foreach (global::CefSharp.IValue value in list)
			{
				global::System.Collections.Generic.IDictionary<string, global::CefSharp.IValue> dictionary = value.GetDictionary();
				if (dictionary != null)
				{
					int @int = dictionary["id"].GetInt();
					global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode accessibilityNode = this.GetNode(@int);
					if (accessibilityNode != null)
					{
						accessibilityNode.Update(dictionary);
					}
					else
					{
						accessibilityNode = new global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode((global::System.Windows.FrameworkElement)base.Owner, dictionary, this);
						this.accessibilityNodeMap[@int] = accessibilityNode;
					}
				}
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00008378 File Offset: 0x00006578
		internal global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode GetNode(int nodeId)
		{
			if (this.accessibilityNodeMap.ContainsKey(nodeId))
			{
				return this.accessibilityNodeMap[nodeId];
			}
			return null;
		}

		// Token: 0x040001B8 RID: 440
		private readonly global::System.Collections.Generic.Dictionary<int, global::CefSharp.Wpf.Experimental.Accessibility.AccessibilityNode> accessibilityNodeMap;
	}
}
