using System;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x02000108 RID: 264
	public class CarouselListBoxItemAutomationPeer : global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer, global::System.Windows.Automation.Provider.IScrollItemProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x0600094B RID: 2379 RVA: 0x0001FF74 File Offset: 0x0001E174
		public CarouselListBoxItemAutomationPeer(object item, global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer listAutomationPeer) : base(item, listAutomationPeer)
		{
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0001FF7E File Offset: 0x0001E17E
		protected override string GetClassNameCore()
		{
			return "CarouselListBoxItem";
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0001FF85 File Offset: 0x0001E185
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ScrollItem)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600094E RID: 2382 RVA: 0x0001FF9B File Offset: 0x0001E19B
		private global::Infragistics.Windows.Controls.XamCarouselListBox List
		{
			get
			{
				return (global::Infragistics.Windows.Controls.XamCarouselListBox)base.ListAutomationPeer.Owner;
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0001FFB0 File Offset: 0x0001E1B0
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			base.ThrowIfNotEnabled();
			global::System.Windows.Automation.Provider.ISelectionProvider selectionProvider = base.ListAutomationPeer.GetPattern(global::System.Windows.Automation.Peers.PatternInterface.Selection) as global::System.Windows.Automation.Provider.ISelectionProvider;
			if (selectionProvider != null && !selectionProvider.CanSelectMultiple && selectionProvider.GetSelection() != null)
			{
				throw new global::System.InvalidOperationException();
			}
			this.List.SelectedItem = base.Item;
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000950 RID: 2384 RVA: 0x0001FFFF File Offset: 0x0001E1FF
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return base.Item == this.List.SelectedItem;
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00020014 File Offset: 0x0001E214
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			base.ThrowIfNotEnabled();
			if (((global::System.Windows.Automation.Provider.ISelectionItemProvider)this).IsSelected)
			{
				this.List.SelectedItem = null;
			}
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00020030 File Offset: 0x0001E230
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			base.ThrowIfNotEnabled();
			this.List.SelectedItem = base.Item;
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000953 RID: 2387 RVA: 0x00020049 File Offset: 0x0001E249
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				return base.ProviderFromPeer(base.ListAutomationPeer as global::System.Windows.Automation.Peers.AutomationPeer);
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0002005C File Offset: 0x0001E25C
		void global::System.Windows.Automation.Provider.IScrollItemProvider.ScrollIntoView()
		{
			global::System.Windows.Controls.Panel itemsControlPanel = base.ListAutomationPeer.ItemsControlPanel;
			if (itemsControlPanel is global::Infragistics.Windows.Controls.XamCarouselPanel)
			{
				int itemIndex = this.List.Items.IndexOf(base.Item);
				((global::Infragistics.Windows.Controls.XamCarouselPanel)itemsControlPanel).EnsureItemIsVisible(itemIndex);
			}
		}
	}
}
