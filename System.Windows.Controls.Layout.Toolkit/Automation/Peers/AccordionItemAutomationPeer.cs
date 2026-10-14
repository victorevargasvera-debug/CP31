using System;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Properties;

namespace System.Windows.Automation.Peers
{
	// Token: 0x02000012 RID: 18
	public class AccordionItemAutomationPeer : global::System.Windows.Automation.Peers.ItemAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider, global::System.Windows.Automation.Provider.ISelectionItemProvider
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00006F31 File Offset: 0x00005131
		private global::System.Windows.Controls.AccordionItem OwnerAccordionItem
		{
			get
			{
				return base.Item as global::System.Windows.Controls.AccordionItem;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00006F3E File Offset: 0x0000513E
		public AccordionItemAutomationPeer(object item, global::System.Windows.Automation.Peers.ItemsControlAutomationPeer itemsControlAutomationPeer) : base(item, itemsControlAutomationPeer)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00006F48 File Offset: 0x00005148
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.ListItem;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00006F4B File Offset: 0x0000514B
		protected override string GetClassNameCore()
		{
			return "AccordionItem";
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00006F52 File Offset: 0x00005152
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse || patternInterface == global::System.Windows.Automation.Peers.PatternInterface.SelectionItem)
			{
				return this;
			}
			return null;
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000133 RID: 307 RVA: 0x00006F60 File Offset: 0x00005160
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				if (!this.OwnerAccordionItem.IsSelected)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Expanded;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00006F74 File Offset: 0x00005174
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::System.Windows.Controls.AccordionItem ownerAccordionItem = this.OwnerAccordionItem;
			if (ownerAccordionItem.IsLocked)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Automation_OperationCannotBePerformed);
			}
			ownerAccordionItem.IsSelected = false;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00006FB0 File Offset: 0x000051B0
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			global::System.Windows.Controls.AccordionItem ownerAccordionItem = this.OwnerAccordionItem;
			if (ownerAccordionItem.IsLocked)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Automation_OperationCannotBePerformed);
			}
			ownerAccordionItem.IsSelected = true;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00006FEC File Offset: 0x000051EC
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.AddToSelection()
		{
			global::System.Windows.Controls.AccordionItem ownerAccordionItem = this.OwnerAccordionItem;
			global::System.Windows.Controls.Accordion parentAccordion = ownerAccordionItem.ParentAccordion;
			if (parentAccordion == null)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Automation_OperationCannotBePerformed);
			}
			parentAccordion.SelectedItems.Add(ownerAccordionItem);
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000137 RID: 311 RVA: 0x00007022 File Offset: 0x00005222
		bool global::System.Windows.Automation.Provider.ISelectionItemProvider.IsSelected
		{
			get
			{
				return this.OwnerAccordionItem.IsSelected;
			}
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00007030 File Offset: 0x00005230
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.RemoveFromSelection()
		{
			global::System.Windows.Controls.AccordionItem ownerAccordionItem = this.OwnerAccordionItem;
			global::System.Windows.Controls.Accordion parentAccordion = ownerAccordionItem.ParentAccordion;
			if (parentAccordion == null)
			{
				throw new global::System.InvalidOperationException(global::System.Windows.Controls.Properties.Resources.Automation_OperationCannotBePerformed);
			}
			parentAccordion.SelectedItems.Remove(ownerAccordionItem);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00007065 File Offset: 0x00005265
		void global::System.Windows.Automation.Provider.ISelectionItemProvider.Select()
		{
			this.OwnerAccordionItem.IsSelected = true;
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600013A RID: 314 RVA: 0x00007074 File Offset: 0x00005274
		global::System.Windows.Automation.Provider.IRawElementProviderSimple global::System.Windows.Automation.Provider.ISelectionItemProvider.SelectionContainer
		{
			get
			{
				global::System.Windows.Controls.Accordion parentAccordion = this.OwnerAccordionItem.ParentAccordion;
				if (parentAccordion != null)
				{
					global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.FromElement(parentAccordion);
					if (automationPeer != null)
					{
						return base.ProviderFromPeer(automationPeer);
					}
				}
				return null;
			}
		}
	}
}
