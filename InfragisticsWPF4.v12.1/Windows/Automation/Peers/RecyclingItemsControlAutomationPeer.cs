using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using Infragistics.Windows.Controls;
using Infragistics.Windows.Virtualization;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E5 RID: 229
	public abstract class RecyclingItemsControlAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer
	{
		// Token: 0x06000819 RID: 2073 RVA: 0x0001BB3C File Offset: 0x00019D3C
		protected RecyclingItemsControlAutomationPeer(global::Infragistics.Windows.Virtualization.RecyclingItemsControl control) : base(control)
		{
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0001BB50 File Offset: 0x00019D50
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.List;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x0001BB53 File Offset: 0x00019D53
		protected override string GetClassNameCore()
		{
			return "RecyclingItemsControl";
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0001BB5C File Offset: 0x00019D5C
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Controls.ItemsControl itemsControl = (global::System.Windows.Controls.ItemsControl)base.Owner;
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenCoreBase = this.GetChildrenCoreBase(true);
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer> itemPeers = this._itemPeers;
			this._itemPeers = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer>();
			foreach (object obj in ((global::System.Collections.IEnumerable)itemsControl.Items))
			{
				if (obj != null)
				{
					global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer recycleableItemAutomationPeer;
					if (!itemPeers.TryGetValue(obj, out recycleableItemAutomationPeer))
					{
						recycleableItemAutomationPeer = this.CreateAutomationPeer(obj);
					}
					if (recycleableItemAutomationPeer != null)
					{
						global::System.Windows.Automation.Peers.AutomationPeer wrapperPeer = recycleableItemAutomationPeer.GetWrapperPeer();
						if (wrapperPeer != null)
						{
							wrapperPeer.EventsSource = recycleableItemAutomationPeer;
						}
					}
					list.Add(recycleableItemAutomationPeer);
					this._itemPeers[obj] = recycleableItemAutomationPeer;
				}
			}
			if (childrenCoreBase != null)
			{
				list.AddRange(childrenCoreBase);
			}
			return list;
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x0001BC34 File Offset: 0x00019E34
		internal global::System.Windows.Controls.Panel ItemsControlPanel
		{
			get
			{
				if (this._itemsControlPanel == null)
				{
					this._itemsControlPanel = this.FindPanel();
				}
				return this._itemsControlPanel;
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0001BC50 File Offset: 0x00019E50
		protected internal global::System.Windows.DependencyObject ContainerFromItem(object item)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemsControl recyclingItemsControl = (global::Infragistics.Windows.Virtualization.RecyclingItemsControl)base.Owner;
			global::Infragistics.Windows.Virtualization.RecyclingItemsPanel recyclingItemsPanel = this.ItemsControlPanel as global::Infragistics.Windows.Virtualization.RecyclingItemsPanel;
			if (recyclingItemsPanel != null && recyclingItemsPanel.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				return recyclingItemsControl.RecyclingItemContainerGenerator.ContainerFromItem(item);
			}
			return recyclingItemsControl.ItemContainerGenerator.ContainerFromItem(item);
		}

		// Token: 0x0600081F RID: 2079
		protected abstract global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer CreateAutomationPeer(object item);

		// Token: 0x06000820 RID: 2080 RVA: 0x0001BC9C File Offset: 0x00019E9C
		protected global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCoreBase(bool excludeItemElements)
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> childrenCore = base.GetChildrenCore();
			if (childrenCore != null && excludeItemElements)
			{
				for (int i = childrenCore.Count - 1; i >= 0; i--)
				{
					global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer frameworkElementAutomationPeer = childrenCore[i] as global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer;
					if (frameworkElementAutomationPeer != null && frameworkElementAutomationPeer.Owner is global::System.Windows.Controls.ScrollViewer)
					{
						global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> children = childrenCore[i].GetChildren();
						if (children != null)
						{
							for (int j = children.Count - 1; j >= 0; j--)
							{
								global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer frameworkElementAutomationPeer2 = children[j] as global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer;
								if (frameworkElementAutomationPeer2 != null)
								{
									if (frameworkElementAutomationPeer2.Owner is global::System.Windows.Controls.Primitives.ScrollBar)
									{
										children.RemoveAt(j);
									}
									else if (this.ItemFromContainer(frameworkElementAutomationPeer2.Owner) != global::System.Windows.DependencyProperty.UnsetValue)
									{
										children.RemoveAt(j);
									}
								}
							}
						}
						childrenCore.RemoveAt(i);
						if (children != null)
						{
							childrenCore.AddRange(children);
						}
					}
					else if (this.ItemFromContainer(frameworkElementAutomationPeer.Owner) != global::System.Windows.DependencyProperty.UnsetValue)
					{
						childrenCore.RemoveAt(i);
					}
				}
			}
			return childrenCore;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0001BD94 File Offset: 0x00019F94
		protected internal object GetItemOrContainerFromContainer(global::System.Windows.DependencyObject container)
		{
			object obj = this.ItemFromContainer(container);
			if (obj == global::System.Windows.DependencyProperty.UnsetValue && global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(container) == base.Owner && ((global::Infragistics.Windows.Virtualization.RecyclingItemsControl)base.Owner).IsItemItsOwnContainerInternal(container))
			{
				obj = container;
			}
			return obj;
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0001BDD8 File Offset: 0x00019FD8
		protected internal virtual global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer GetItemPeer(object item)
		{
			global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer result = null;
			if (this._itemPeers != null)
			{
				this._itemPeers.TryGetValue(item, out result);
			}
			return result;
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0001BE00 File Offset: 0x0001A000
		protected internal object ItemFromContainer(global::System.Windows.DependencyObject container)
		{
			global::Infragistics.Windows.Virtualization.RecyclingItemsControl recyclingItemsControl = (global::Infragistics.Windows.Virtualization.RecyclingItemsControl)base.Owner;
			global::Infragistics.Windows.Virtualization.RecyclingItemsPanel recyclingItemsPanel = this.ItemsControlPanel as global::Infragistics.Windows.Virtualization.RecyclingItemsPanel;
			if (recyclingItemsPanel != null && recyclingItemsPanel.ItemContainerGenerationModeResolved == global::Infragistics.Windows.Controls.ItemContainerGenerationMode.Recycle)
			{
				return recyclingItemsControl.RecyclingItemContainerGenerator.ItemFromContainer(container);
			}
			return recyclingItemsControl.ItemContainerGenerator.ItemFromContainer(container);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0001BE49 File Offset: 0x0001A049
		protected internal virtual void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x0001BE4B File Offset: 0x0001A04B
		protected internal virtual void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x0001BE60 File Offset: 0x0001A060
		private global::System.Windows.Controls.Panel FindPanel()
		{
			global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::System.Windows.Controls.Panel> callback = (global::System.Windows.Controls.Panel panel) => global::System.Windows.Controls.ItemsControl.GetItemsOwner(panel) == base.Owner;
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.Controls.Panel>(base.Owner, true, callback, new global::System.Type[]
			{
				typeof(global::System.Windows.Controls.ItemsControl)
			});
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x0001BE9C File Offset: 0x0001A09C
		internal void OnItemsPanelChanged()
		{
			this._itemsControlPanel = null;
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetUnderlyingPeer(object item)
		{
			global::System.Windows.UIElement uielement = this.ContainerFromItem(item) as global::System.Windows.UIElement;
			if (uielement == null)
			{
				return null;
			}
			return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(uielement);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x0001BECD File Offset: 0x0001A0CD
		global::System.Windows.DependencyObject global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.ContainerFromItem(object item)
		{
			return this.ContainerFromItem(item);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x0001BED6 File Offset: 0x0001A0D6
		object global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return this.GetPattern(patternInterface);
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x0001BEDF File Offset: 0x0001A0DF
		global::System.Windows.UIElement global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.Owner
		{
			get
			{
				return base.Owner;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x0001BEE7 File Offset: 0x0001A0E7
		global::System.Windows.Controls.Panel global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.ItemsControlPanel
		{
			get
			{
				return this.ItemsControlPanel;
			}
		}

		// Token: 0x04000392 RID: 914
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer> _itemPeers = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer>();

		// Token: 0x04000393 RID: 915
		private global::System.Windows.Controls.Panel _itemsControlPanel;
	}
}
