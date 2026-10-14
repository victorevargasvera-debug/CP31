using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E9 RID: 233
	public class XamCarouselListBoxAutomationPeer : global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x06000842 RID: 2114 RVA: 0x0001C16A File Offset: 0x0001A36A
		public XamCarouselListBoxAutomationPeer(global::Infragistics.Windows.Controls.XamCarouselListBox listBox) : base(listBox)
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0001C173 File Offset: 0x0001A373
		protected override string GetClassNameCore()
		{
			return "XamCarouselListBox";
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0001C17C File Offset: 0x0001A37C
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Scroll)
			{
				global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = (global::Infragistics.Windows.Controls.XamCarouselListBox)base.Owner;
				if (xamCarouselListBox != null && xamCarouselListBox.ScrollInfo != null && xamCarouselListBox.ScrollInfo.ScrollOwner != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(xamCarouselListBox.ScrollInfo.ScrollOwner);
					if (automationPeer != null && automationPeer is global::System.Windows.Automation.Provider.IScrollProvider)
					{
						automationPeer.EventsSource = this;
						return automationPeer;
					}
				}
				return null;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0001C1E5 File Offset: 0x0001A3E5
		protected override global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer CreateAutomationPeer(object item)
		{
			return new global::Infragistics.Windows.Automation.Peers.CarouselListBoxItemAutomationPeer(item, this);
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0001C1F0 File Offset: 0x0001A3F0
		private void RaiseAutomationEvent(object item, global::System.Windows.Automation.Peers.AutomationEvents eventId)
		{
			global::System.Windows.Automation.Peers.AutomationPeer itemPeer = this.GetItemPeer(item);
			if (itemPeer != null)
			{
				itemPeer.RaiseAutomationEvent(eventId);
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0001C210 File Offset: 0x0001A410
		internal void RaiseIsSelectedChanged(global::System.Windows.DependencyObject container, bool isSelected)
		{
			object itemOrContainerFromContainer = base.GetItemOrContainerFromContainer(container);
			if (itemOrContainerFromContainer != null)
			{
				global::Infragistics.Windows.Automation.Peers.CarouselListBoxItemAutomationPeer carouselListBoxItemAutomationPeer = this.GetItemPeer(itemOrContainerFromContainer) as global::Infragistics.Windows.Automation.Peers.CarouselListBoxItemAutomationPeer;
				if (carouselListBoxItemAutomationPeer != null)
				{
					carouselListBoxItemAutomationPeer.RaisePropertyChangedEvent(global::System.Windows.Automation.SelectionItemPatternIdentifiers.IsSelectedProperty, !isSelected, isSelected);
				}
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0001C254 File Offset: 0x0001A454
		internal void RaiseSelectionChanged(global::System.Windows.Controls.SelectionChangedEventArgs args)
		{
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionPatternOnInvalidated) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection) || global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected))
			{
				if (args.AddedItems.Count == 1)
				{
					this.RaiseAutomationEvent(args.AddedItems[0], global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementSelected);
					return;
				}
				if (args.AddedItems.Count + args.RemovedItems.Count > 20)
				{
					base.RaiseAutomationEvent(global::System.Windows.Automation.Peers.AutomationEvents.SelectionPatternOnInvalidated);
					return;
				}
				foreach (object item in args.RemovedItems)
				{
					this.RaiseAutomationEvent(item, global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementRemovedFromSelection);
				}
				foreach (object item2 in args.AddedItems)
				{
					this.RaiseAutomationEvent(item2, global::System.Windows.Automation.Peers.AutomationEvents.SelectionItemPatternOnElementAddedToSelection);
				}
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0001C360 File Offset: 0x0001A560
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0001C364 File Offset: 0x0001A564
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			global::Infragistics.Windows.Controls.XamCarouselListBox xamCarouselListBox = (global::Infragistics.Windows.Controls.XamCarouselListBox)base.Owner;
			if (xamCarouselListBox.SelectedItem != null)
			{
				global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer itemPeer = this.GetItemPeer(xamCarouselListBox.SelectedItem);
				if (itemPeer != null)
				{
					return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[]
					{
						base.ProviderFromPeer(itemPeer)
					};
				}
			}
			return null;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0001C3A9 File Offset: 0x0001A5A9
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}
	}
}
