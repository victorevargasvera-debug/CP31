using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000107 RID: 263
	public class XamCarouselListBoxAutomationPeer : global::Infragistics.Windows.Automation.Peers.RecyclingItemsControlAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x06000941 RID: 2369 RVA: 0x0001FD32 File Offset: 0x0001DF32
		public XamCarouselListBoxAutomationPeer(global::Infragistics.Windows.Controls.XamCarouselListBox listBox) : base(listBox)
		{
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0001FD3B File Offset: 0x0001DF3B
		protected override string GetClassNameCore()
		{
			return "XamCarouselListBox";
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0001FD44 File Offset: 0x0001DF44
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

		// Token: 0x06000944 RID: 2372 RVA: 0x0001FDAD File Offset: 0x0001DFAD
		protected override global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer CreateAutomationPeer(object item)
		{
			return new global::Infragistics.Windows.Automation.Peers.CarouselListBoxItemAutomationPeer(item, this);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0001FDB8 File Offset: 0x0001DFB8
		private void RaiseAutomationEvent(object item, global::System.Windows.Automation.Peers.AutomationEvents eventId)
		{
			global::System.Windows.Automation.Peers.AutomationPeer itemPeer = this.GetItemPeer(item);
			if (itemPeer != null)
			{
				itemPeer.RaiseAutomationEvent(eventId);
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0001FDD8 File Offset: 0x0001DFD8
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

		// Token: 0x06000947 RID: 2375 RVA: 0x0001FE1C File Offset: 0x0001E01C
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

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0001FF28 File Offset: 0x0001E128
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0001FF2C File Offset: 0x0001E12C
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

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x0001FF71 File Offset: 0x0001E171
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}
	}
}
