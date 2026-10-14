using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using Infragistics.Controls.Primitives;

namespace Infragistics.AutomationPeers
{
	// Token: 0x020000BD RID: 189
	public class ExpansionIndicatorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IToggleProvider
	{
		// Token: 0x0600070E RID: 1806 RVA: 0x00018DB1 File Offset: 0x00016FB1
		public ExpansionIndicatorAutomationPeer(global::Infragistics.Controls.Primitives.ExpansionIndicator owner) : base(owner)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00018DBA File Offset: 0x00016FBA
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.CheckBox;
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00018DBD File Offset: 0x00016FBD
		protected override string GetClassNameCore()
		{
			return "ExpansionIndicator";
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00018DC4 File Offset: 0x00016FC4
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Toggle)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00018DD4 File Offset: 0x00016FD4
		public void Toggle()
		{
			global::Infragistics.Controls.Primitives.ExpansionIndicator expansionIndicator = base.Owner as global::Infragistics.Controls.Primitives.ExpansionIndicator;
			if (expansionIndicator == null)
			{
				throw new global::System.InvalidOperationException();
			}
			if (!expansionIndicator.IsEnabled)
			{
				throw new global::System.Windows.Automation.ElementNotEnabledException();
			}
			expansionIndicator.IsExpanded = !expansionIndicator.IsExpanded;
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x00018E14 File Offset: 0x00017014
		public global::System.Windows.Automation.ToggleState ToggleState
		{
			get
			{
				global::Infragistics.Controls.Primitives.ExpansionIndicator expansionIndicator = base.Owner as global::Infragistics.Controls.Primitives.ExpansionIndicator;
				if (expansionIndicator == null)
				{
					throw new global::System.InvalidOperationException();
				}
				if (expansionIndicator.IsExpanded)
				{
					return global::System.Windows.Automation.ToggleState.On;
				}
				return global::System.Windows.Automation.ToggleState.Off;
			}
		}
	}
}
