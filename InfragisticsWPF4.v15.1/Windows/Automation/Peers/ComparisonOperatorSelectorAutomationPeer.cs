using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000FD RID: 253
	public class ComparisonOperatorSelectorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060008F8 RID: 2296 RVA: 0x0001F57B File Offset: 0x0001D77B
		public ComparisonOperatorSelectorAutomationPeer(global::Infragistics.Windows.Controls.ComparisonOperatorSelector element) : base(element)
		{
		}

		// Token: 0x060008F9 RID: 2297 RVA: 0x0001F584 File Offset: 0x0001D784
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060008FA RID: 2298 RVA: 0x0001F588 File Offset: 0x0001D788
		protected override string GetClassNameCore()
		{
			return "ComparisonOperatorSelector";
		}
	}
}
