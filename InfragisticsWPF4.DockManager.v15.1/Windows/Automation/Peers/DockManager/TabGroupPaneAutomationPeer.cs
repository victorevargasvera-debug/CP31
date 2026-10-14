using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.DockManager;
using Infragistics.Windows.Internal;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x02000015 RID: 21
	public class TabGroupPaneAutomationPeer : global::System.Windows.Automation.Peers.TabControlAutomationPeer
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00004B43 File Offset: 0x00002D43
		public TabGroupPaneAutomationPeer(global::Infragistics.Windows.DockManager.TabGroupPane owner) : base(owner)
		{
			this._selectedContentTracker = new global::Infragistics.Windows.Internal.PropertyValueTracker(owner, global::System.Windows.Controls.TabControl.SelectedContentProperty, new global::Infragistics.Windows.Internal.PropertyValueTracker.PropertyValueChangedHandler(this.OnSelectedContentChanged), true);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00004BC0 File Offset: 0x00002DC0
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = base.GetChildrenCore();
			global::Infragistics.Windows.DockManager.TabGroupPane tc = (global::Infragistics.Windows.DockManager.TabGroupPane)base.Owner;
			tc.ApplyTemplate();
			global::System.Windows.FrameworkElement headerArea = tc.HeaderArea;
			if (headerArea != null)
			{
				global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> children = new global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer(headerArea).GetChildren();
				if (children != null)
				{
					global::System.Predicate<global::System.Windows.Automation.Peers.AutomationPeer> match = delegate(global::System.Windows.Automation.Peers.AutomationPeer peer)
					{
						global::System.Windows.Automation.Peers.UIElementAutomationPeer uielementAutomationPeer = peer as global::System.Windows.Automation.Peers.UIElementAutomationPeer;
						if (uielementAutomationPeer == null)
						{
							return true;
						}
						global::System.Windows.UIElement owner = uielementAutomationPeer.Owner;
						if (global::System.Windows.Controls.ItemsControl.ItemsControlFromItemContainer(owner) == tc)
						{
							return false;
						}
						global::System.Windows.Controls.ScrollViewer scrollViewer = owner as global::System.Windows.Controls.ScrollViewer;
						return scrollViewer == null || scrollViewer.TemplatedParent != tc;
					};
					global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list2 = children.FindAll(match);
					if (list == null)
					{
						list = list2;
					}
					else
					{
						list.AddRange(list2);
					}
				}
			}
			return list;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00004C4C File Offset: 0x00002E4C
		protected override string GetClassNameCore()
		{
			return "TabGroupPane";
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00004C54 File Offset: 0x00002E54
		private void OnSelectedContentChanged()
		{
			global::Infragistics.Windows.DockManager.TabGroupPane tabGroupPane = base.Owner as global::Infragistics.Windows.DockManager.TabGroupPane;
			int selectedIndex = tabGroupPane.SelectedIndex;
			if (selectedIndex >= 0 && selectedIndex <= tabGroupPane.Items.Count)
			{
				global::System.Windows.Controls.TabItem tabItem = tabGroupPane.ItemContainerGenerator.ContainerFromIndex(selectedIndex) as global::System.Windows.Controls.TabItem;
				if (tabItem != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(tabItem);
					if (automationPeer != null && automationPeer.EventsSource != null)
					{
						automationPeer.EventsSource.ResetChildrenCache();
					}
				}
			}
		}

		// Token: 0x04000034 RID: 52
		private global::Infragistics.Windows.Internal.PropertyValueTracker _selectedContentTracker;
	}
}
