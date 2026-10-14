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
	// Token: 0x02000103 RID: 259
	public abstract class RecyclingItemsControlAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::Infragistics.Windows.Automation.Peers.IListAutomationPeer
	{
		// Token: 0x06000918 RID: 2328 RVA: 0x0001F704 File Offset: 0x0001D904
		protected RecyclingItemsControlAutomationPeer(global::Infragistics.Windows.Virtualization.RecyclingItemsControl control) : base(control)
		{
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x0001F718 File Offset: 0x0001D918
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.List;
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0001F71B File Offset: 0x0001D91B
		protected override string GetClassNameCore()
		{
			return "RecyclingItemsControl";
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x0001F724 File Offset: 0x0001D924
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

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0001F7FC File Offset: 0x0001D9FC
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

		// Token: 0x0600091D RID: 2333 RVA: 0x0001F818 File Offset: 0x0001DA18
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

		// Token: 0x0600091E RID: 2334
		protected abstract global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer CreateAutomationPeer(object item);

		// Token: 0x0600091F RID: 2335 RVA: 0x0001F864 File Offset: 0x0001DA64
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

		// Token: 0x06000920 RID: 2336 RVA: 0x0001F95C File Offset: 0x0001DB5C
		protected internal object GetItemOrContainerFromContainer(global::System.Windows.DependencyObject container)
		{
			object obj = this.ItemFromContainer(container);
			if (obj == global::System.Windows.DependencyProperty.UnsetValue && global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(container) == base.Owner && ((global::Infragistics.Windows.Virtualization.RecyclingItemsControl)base.Owner).IsItemItsOwnContainerInternal(container))
			{
				obj = container;
			}
			return obj;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x0001F9A0 File Offset: 0x0001DBA0
		protected internal virtual global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer GetItemPeer(object item)
		{
			global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer result = null;
			if (this._itemPeers != null)
			{
				this._itemPeers.TryGetValue(item, out result);
			}
			return result;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x0001F9C8 File Offset: 0x0001DBC8
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

		// Token: 0x06000923 RID: 2339 RVA: 0x0001FA11 File Offset: 0x0001DC11
		protected internal virtual void OnItemsChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x0001FA13 File Offset: 0x0001DC13
		protected internal virtual void OnItemsSourceChanged(global::System.Collections.IEnumerable oldValue, global::System.Collections.IEnumerable newValue)
		{
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x0001FA28 File Offset: 0x0001DC28
		private global::System.Windows.Controls.Panel FindPanel()
		{
			global::Infragistics.Windows.Utilities.DependencyObjectSearchCallback<global::System.Windows.Controls.Panel> callback = (global::System.Windows.Controls.Panel panel) => global::System.Windows.Controls.ItemsControl.GetItemsOwner(panel) == base.Owner;
			return global::Infragistics.Windows.Utilities.GetDescendantFromType<global::System.Windows.Controls.Panel>(base.Owner, true, callback, new global::System.Type[]
			{
				typeof(global::System.Windows.Controls.ItemsControl)
			});
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x0001FA64 File Offset: 0x0001DC64
		internal void OnItemsPanelChanged()
		{
			this._itemsControlPanel = null;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x0001FA70 File Offset: 0x0001DC70
		global::System.Windows.Automation.Peers.AutomationPeer global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetUnderlyingPeer(object item)
		{
			global::System.Windows.UIElement uielement = this.ContainerFromItem(item) as global::System.Windows.UIElement;
			if (uielement == null)
			{
				return null;
			}
			return global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(uielement);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0001FA95 File Offset: 0x0001DC95
		global::System.Windows.DependencyObject global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.ContainerFromItem(object item)
		{
			return this.ContainerFromItem(item);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0001FA9E File Offset: 0x0001DC9E
		object global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return this.GetPattern(patternInterface);
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0001FAA7 File Offset: 0x0001DCA7
		global::System.Windows.UIElement global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.Owner
		{
			get
			{
				return base.Owner;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0001FAAF File Offset: 0x0001DCAF
		global::System.Windows.Controls.Panel global::Infragistics.Windows.Automation.Peers.IListAutomationPeer.ItemsControlPanel
		{
			get
			{
				return this.ItemsControlPanel;
			}
		}

		// Token: 0x04000445 RID: 1093
		private global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer> _itemPeers = new global::System.Collections.Generic.Dictionary<object, global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer>();

		// Token: 0x04000446 RID: 1094
		private global::System.Windows.Controls.Panel _itemsControlPanel;
	}
}
