using System;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000EA RID: 234
	public class CarouselListBoxItemAutomationPeer : global::Infragistics.Windows.Automation.Peers.RecycleableItemAutomationPeer, global::System.Windows.Automation.Provider.IScrollItemProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x0600084C RID: 2124 RVA: 0x0001C3AC File Offset: 0x0001A5AC
		public CarouselListBoxItemAutomationPeer(object item, global::Infragistics.Windows.Automation.Peers.XamCarouselListBoxAutomationPeer listAutomationPeer) : base(item, listAutomationPeer)
		{
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0001C3B6 File Offset: 0x0001A5B6
		protected override string GetClassNameCore()
		{
			return "CarouselListBoxItem";
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0001C3BD File Offset: 0x0001A5BD
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

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x0001C3D3 File Offset: 0x0001A5D3
		private global::Infragistics.Windows.Controls.XamCarouselListBox List
		{
			get
			{
				return (global::Infragistics.Windows.Controls.XamCarouselListBox)base.ListAutomationPeer.Owner;
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0001C3E8 File Offset: 0x0001A5E8
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

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0001C437 File Offset: 0x0001A637
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return base.Item == this.List.SelectedItem;
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0001C44C File Offset: 0x0001A64C
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			base.ThrowIfNotEnabled();
			if (((global::System.Windows.Automation.Provider.ISelectionItemProvider)this).IsSelected)
			{
				this.List.SelectedItem = null;
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0001C468 File Offset: 0x0001A668
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			base.ThrowIfNotEnabled();
			this.List.SelectedItem = base.Item;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x0001C481 File Offset: 0x0001A681
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				return base.ProviderFromPeer(base.ListAutomationPeer as global::System.Windows.Automation.Peers.AutomationPeer);
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0001C494 File Offset: 0x0001A694
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
