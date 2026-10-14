using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.Automation.Peers.Editors
{
	// Token: 0x02000008 RID: 8
	public class XamComboEditorAutomationPeer : global::Infragistics.Windows.Automation.Peers.Editors.ValueEditorAutomationPeer, global::System.Windows.Automation.Provider.IExpandCollapseProvider
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00002621 File Offset: 0x00000821
		public XamComboEditorAutomationPeer(global::Infragistics.Windows.Editors.XamComboEditor owner) : base(owner)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000262A File Offset: 0x0000082A
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.ComboBox;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000262D File Offset: 0x0000082D
		protected override string GetClassNameCore()
		{
			return "XamComboEditor";
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002634 File Offset: 0x00000834
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.ExpandCollapse)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002643 File Offset: 0x00000843
		private global::Infragistics.Windows.Editors.XamComboEditor Editor
		{
			get
			{
				return (global::Infragistics.Windows.Editors.XamComboEditor)base.Owner;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002650 File Offset: 0x00000850
		internal void RaiseExpandCollapseStateChanged(bool oldValue, bool newValue)
		{
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ExpandCollapsePatternIdentifiers.ExpandCollapseStateProperty, oldValue ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed, newValue ? global::System.Windows.Automation.ExpandCollapseState.Expanded : global::System.Windows.Automation.ExpandCollapseState.Collapsed);
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000267E File Offset: 0x0000087E
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Collapse()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this.Editor.IsDropDownOpen = true;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000269A File Offset: 0x0000089A
		void global::System.Windows.Automation.Provider.IExpandCollapseProvider.Expand()
		{
			if (!base.IsEnabled())
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			this.Editor.IsDropDownOpen = false;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000026B6 File Offset: 0x000008B6
		global::System.Windows.Automation.ExpandCollapseState global::System.Windows.Automation.Provider.IExpandCollapseProvider.ExpandCollapseState
		{
			get
			{
				if (this.Editor.IsDropDownOpen)
				{
					return global::System.Windows.Automation.ExpandCollapseState.Expanded;
				}
				return global::System.Windows.Automation.ExpandCollapseState.Collapsed;
			}
		}
	}
}
