using System;
using System.Collections.Generic;
using System.Windows.Automation.Provider;
using System.Windows.Controls;

namespace System.Windows.Automation.Peers
{
	// Token: 0x02000015 RID: 21
	public sealed class AutoCompleteBoxAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider, global::System.Windows.Automation.Provider.IExpandCollapseProvider, global::System.Windows.Automation.Provider.ISelectionProvider
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000144 RID: 324 RVA: 0x00006307 File Offset: 0x00004507
		private global::System.Windows.Controls.AutoCompleteBox OwnerAutoCompleteBox
		{
			get
			{
				return (global::System.Windows.Controls.AutoCompleteBox)base.Owner;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000145 RID: 325 RVA: 0x00006314 File Offset: 0x00004514
		bool global::System.Windows.Automation.Provider.ISelectionProvider.CanSelectMultiple
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000146 RID: 326 RVA: 0x00006317 File Offset: 0x00004517
		bool global::System.Windows.Automation.Provider.ISelectionProvider.IsSelectionRequired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000631A File Offset: 0x0000451A
		public AutoCompleteBoxAutomationPeer(global::System.Windows.Controls.AutoCompleteBox owner) : base(owner)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006323 File Offset: 0x00004523
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.ComboBox;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00006326 File Offset: 0x00004526
		protected override string GetClassNameCore()
		{
			return "AutoCompleteBox";
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00006330 File Offset: 0x00004530
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			object obj = null;
			global::System.Windows.Controls.AutoCompleteBox ownerAutoCompleteBox = this.OwnerAutoCompleteBox;
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				obj = this;
			}
			else if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				obj = this;
			}
			else if (ownerAutoCompleteBox.SelectionAdapter != null)
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = ownerAutoCompleteBox.SelectionAdapter.CreateAutomationPeer();
				if (automationPeer != null)
				{
					obj = automationPeer.GetPattern(patternInterface);
				}
			}
			if (obj == null)
			{
				obj = base.GetPattern(patternInterface);
			}
			return obj;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006381 File Offset: 0x00004581
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this.OwnerAutoCompleteBox.IsDropDownOpen = true;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000639D File Offset: 0x0000459D
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this.OwnerAutoCompleteBox.IsDropDownOpen = false;
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600014D RID: 333 RVA: 0x000063B9 File Offset: 0x000045B9
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				if (!this.OwnerAutoCompleteBox.IsDropDownOpen)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Expanded;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000063CB File Offset: 0x000045CB
		internal void RaiseExpandCollapseAutomationEvent(bool oldValue, bool newValue)
		{
			base.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, oldValue ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed, newValue ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000063F0 File Offset: 0x000045F0
		void global::System.Windows.Automation.Provider.IValueProvider.SetValue(string value)
		{
			this.OwnerAutoCompleteBox.Text = value;
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000150 RID: 336 RVA: 0x000063FE File Offset: 0x000045FE
		bool global::System.Windows.Automation.Provider.IValueProvider.IsReadOnly
		{
			get
			{
				return !this.OwnerAutoCompleteBox.IsEnabled;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000640E File Offset: 0x0000460E
		string global::System.Windows.Automation.Provider.IValueProvider.Value
		{
			get
			{
				return this.OwnerAutoCompleteBox.Text ?? string.Empty;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006424 File Offset: 0x00004624
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = new global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer>();
			global::System.Windows.Controls.AutoCompleteBox ownerAutoCompleteBox = this.OwnerAutoCompleteBox;
			global::System.Windows.Controls.TextBox textBox = ownerAutoCompleteBox.TextBox;
			if (textBox != null)
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(textBox);
				if (automationPeer != null)
				{
					list.Insert(0, automationPeer);
				}
			}
			if (ownerAutoCompleteBox.SelectionAdapter != null)
			{
				global::System.Windows.Automation.Peers.AutomationPeer automationPeer2 = ownerAutoCompleteBox.SelectionAdapter.CreateAutomationPeer();
				if (automationPeer2 != null)
				{
					global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> children = automationPeer2.GetChildren();
					if (children != null)
					{
						foreach (global::System.Windows.Automation.Peers.AutomationPeer item in children)
						{
							list.Add(item);
						}
					}
				}
			}
			return list;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000064C8 File Offset: 0x000046C8
		global::System.Windows.Automation.Provider.IRawElementProviderSimple[] global::System.Windows.Automation.Provider.ISelectionProvider.GetSelection()
		{
			if (this.OwnerAutoCompleteBox.SelectionAdapter != null)
			{
				object selectedItem = this.OwnerAutoCompleteBox.SelectionAdapter.SelectedItem;
				if (selectedItem != null)
				{
					global::System.Windows.UIElement uielement = selectedItem as global::System.Windows.UIElement;
					if (uielement != null)
					{
						global::System.Windows.Automation.Peers.AutomationPeer automationPeer = global::System.Windows.Automation.Peers.UIElementAutomationPeer.CreatePeerForElement(uielement);
						if (automationPeer != null)
						{
							return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[]
							{
								base.ProviderFromPeer(automationPeer)
							};
						}
					}
				}
			}
			return new global::System.Windows.Automation.Provider.IRawElementProviderSimple[0];
		}

		// Token: 0x0400005A RID: 90
		private const string AutoCompleteBoxClassNameCore = "AutoCompleteBox";
	}
}
