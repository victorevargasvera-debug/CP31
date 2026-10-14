using System;
using System.Collections.Generic;
using System.Windows.Automation.Provider;
using System.Windows.Controls;

namespace System.Windows.Automation.Peers
{
	// Token: 0x0200000C RID: 12
	public class AccordionAutomationPeer : global::System.Windows.Automation.Peers.ItemsControlAutomationPeer, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000CB RID: 203 RVA: 0x00005F0C File Offset: 0x0000410C
		private global::System.Windows.Controls.Accordion OwnerAccordion
		{
			get
			{
				return (global::System.Windows.Controls.Accordion)base.Owner;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00005F19 File Offset: 0x00004119
		public AccordionAutomationPeer(global::System.Windows.Controls.Accordion owner) : base(owner)
		{
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00005F22 File Offset: 0x00004122
		protected override string GetClassNameCore()
		{
			return "Accordion";
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00005F29 File Offset: 0x00004129
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.List;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00005F2C File Offset: 0x0000412C
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Selection)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00005F3C File Offset: 0x0000413C
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Windows.Controls.Accordion ownerAccordion = this.OwnerAccordion;
			global::System.Windows.Controls.ItemCollection items = ownerAccordion.Items;
			if (items.Count <= 0)
			{
				return null;
			}
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>(items.Count);
			for (int i = 0; i < items.Count; i++)
			{
				global::System.Windows.Controls.AccordionItem accordionItem = ownerAccordion.ItemContainerGenerator.ContainerFromIndex(i) as global::System.Windows.Controls.AccordionItem;
				if (accordionItem != null)
				{
					list.Add(global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(accordionItem) ?? global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(accordionItem));
				}
			}
			return list;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00005FAF File Offset: 0x000041AF
		public bool CanSelectMultiple
		{
			get
			{
				return this.OwnerAccordion.SelectionMode == global::System.Windows.Controls.AccordionSelectionMode.OneOrMore || this.OwnerAccordion.SelectionMode == global::System.Windows.Controls.AccordionSelectionMode.ZeroOrMore;
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00005FD0 File Offset: 0x000041D0
		public global::System.Windows.Automation.Provider.IRawElementProviderSimple[] GetSelection()
		{
			global::System.Windows.Controls.Accordion ownerAccordion = this.OwnerAccordion;
			global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Provider.IRawElementProviderSimple>(ownerAccordion.SelectedIndices.Count);
			foreach (int index in ownerAccordion.SelectedIndices)
			{
				global::System.Windows.Controls.AccordionItem accordionItem = ownerAccordion.ItemContainerGenerator.ContainerFromIndex(index) as global::System.Windows.Controls.AccordionItem;
				if (accordionItem != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(accordionItem);
					if (automationPeer != null)
					{
						list.Add(base.ProviderFromPeer(automationPeer));
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00006068 File Offset: 0x00004268
		public bool IsSelectionRequired
		{
			get
			{
				return this.OwnerAccordion.SelectionMode == global::System.Windows.Controls.AccordionSelectionMode.One || this.OwnerAccordion.SelectionMode == global::System.Windows.Controls.AccordionSelectionMode.OneOrMore;
			}
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00006087 File Offset: 0x00004287
		protected override global::System.Windows.Automation.Peers.ItemAutomationPeer CreateItemAutomationPeer(object item)
		{
			return new global::System.Windows.Automation.Peers.AccordionItemAutomationPeer(item, this);
		}
	}
}
