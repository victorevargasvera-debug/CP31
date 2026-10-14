using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Editors;

namespace Infragistics.AutomationPeers
{
	// Token: 0x0200005C RID: 92
	public class XamMaskedInputAutomationPeer : global::Infragistics.AutomationPeers.ValueInputAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x0001943C File Offset: 0x0001763C
		public XamMaskedInputAutomationPeer(global::Infragistics.Controls.Editors.XamMaskedInput owner) : base(owner)
		{
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00019445 File Offset: 0x00017645
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Edit;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00019448 File Offset: 0x00017648
		protected override string GetClassNameCore()
		{
			return "XamMaskedInput";
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0001944F File Offset: 0x0001764F
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Text)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00019465 File Offset: 0x00017665
		private global::Infragistics.Controls.Editors.XamMaskedInput Editor
		{
			get
			{
				return (global::Infragistics.Controls.Editors.XamMaskedInput)base.Owner;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00019472 File Offset: 0x00017672
		private int LastCharacterIndex
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.GetTotalNumberOfDisplayChars(this.Editor.Sections);
			}
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00019484 File Offset: 0x00017684
		internal global::System.Windows.DependencyObject ElementFromProvider(global::System.Windows.Automation.Provider.IRawElementProviderSimple provider)
		{
			global::System.Windows.DependencyObject result = null;
			global::System.Windows.Automation.Peers.AutomationPeer automationPeer = base.PeerFromProvider(provider);
			if (automationPeer is global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer)
			{
				return ((global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer)automationPeer).Owner;
			}
			if (automationPeer is global::System.Windows.Automation.Peers.ContentElementAutomationPeer)
			{
				result = ((global::System.Windows.Automation.Peers.ContentElementAutomationPeer)automationPeer).Owner;
			}
			return result;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x000194C4 File Offset: 0x000176C4
		internal void RaiseExpandCollapseChanged()
		{
			if (this._lastReturnedExpandState != null && global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				global::System.Windows.Automation.ExpandCollapseState expandCollapseState = ((global::System.Windows.Automation.Provider.IExpandCollapseProvider)this).ExpandCollapseState;
				if (expandCollapseState != this._lastReturnedExpandState.Value)
				{
					base.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, this._lastReturnedExpandState.Value, expandCollapseState);
				}
			}
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001951D File Offset: 0x0001771D
		private void VerifyCanExpandCollapse()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			if (!this.Editor.HasDropDown)
			{
				throw new global::System.InvalidOperationException();
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00019540 File Offset: 0x00017740
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			this.VerifyCanExpandCollapse();
			if (this.Editor.HasOpenDropDown)
			{
				this.Editor.ToggleDropDown();
			}
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00019560 File Offset: 0x00017760
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			this.VerifyCanExpandCollapse();
			if (!this.Editor.HasDropDown)
			{
				throw new global::System.InvalidOperationException();
			}
			if (!this.Editor.HasOpenDropDown)
			{
				this.Editor.ToggleDropDown();
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00019594 File Offset: 0x00017794
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				if (!this.Editor.HasDropDown)
				{
					this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.LeafNode);
				}
				else if (this.Editor.HasOpenDropDown)
				{
					this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.Expanded);
				}
				else
				{
					this._lastReturnedExpandState = new global::System.Windows.Automation.ExpandCollapseState?(global::System.Windows.Automation.ExpandCollapseState.Collapsed);
				}
				return this._lastReturnedExpandState.Value;
			}
		}

		// Token: 0x040001B2 RID: 434
		private global::System.Windows.Automation.ExpandCollapseState? _lastReturnedExpandState;
	}
}
