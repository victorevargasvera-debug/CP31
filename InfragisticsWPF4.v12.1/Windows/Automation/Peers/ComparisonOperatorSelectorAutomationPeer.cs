using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000DF RID: 223
	public class ComparisonOperatorSelectorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x0001B9B3 File Offset: 0x00019BB3
		public ComparisonOperatorSelectorAutomationPeer(global::Infragistics.Windows.Controls.ComparisonOperatorSelector element) : base(element)
		{
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0001B9BC File Offset: 0x00019BBC
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0001B9C0 File Offset: 0x00019BC0
		protected override string GetClassNameCore()
		{
			return "ComparisonOperatorSelector";
		}
	}
}
