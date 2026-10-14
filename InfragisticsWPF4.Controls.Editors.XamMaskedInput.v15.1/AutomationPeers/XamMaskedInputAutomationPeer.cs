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
		// Token: 0x060004D7 RID: 1239 RVA: 0x0001984C File Offset: 0x00017A4C
		public XamMaskedInputAutomationPeer(global::Infragistics.Controls.Editors.XamMaskedInput owner) : base(owner)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00019855 File Offset: 0x00017A55
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Edit;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00019858 File Offset: 0x00017A58
		protected override string GetClassNameCore()
		{
			return "XamMaskedInput";
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0001985F File Offset: 0x00017A5F
		protected override object GetPatternCore(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Text)
			{
				return this;
			}
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPatternCore(patternInterface);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00019875 File Offset: 0x00017A75
		private global::Infragistics.Controls.Editors.XamMaskedInput Editor
		{
			get
			{
				return (global::Infragistics.Controls.Editors.XamMaskedInput)base.Owner;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00019882 File Offset: 0x00017A82
		private int LastCharacterIndex
		{
			get
			{
				return global::Infragistics.Controls.Editors.XamMaskedInput.InternalGetTotalNumberOfDisplayChars(this.Editor.Sections);
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00019894 File Offset: 0x00017A94
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

		// Token: 0x060004DE RID: 1246 RVA: 0x000198D4 File Offset: 0x00017AD4
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

		// Token: 0x060004DF RID: 1247 RVA: 0x0001992D File Offset: 0x00017B2D
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

		// Token: 0x060004E0 RID: 1248 RVA: 0x00019950 File Offset: 0x00017B50
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			this.VerifyCanExpandCollapse();
			if (this.Editor.HasOpenDropDown)
			{
				this.Editor.ToggleDropDown();
			}
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00019970 File Offset: 0x00017B70
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x000199A4 File Offset: 0x00017BA4
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

		// Token: 0x040001BF RID: 447
		private global::System.Windows.Automation.ExpandCollapseState? _lastReturnedExpandState;
	}
}
