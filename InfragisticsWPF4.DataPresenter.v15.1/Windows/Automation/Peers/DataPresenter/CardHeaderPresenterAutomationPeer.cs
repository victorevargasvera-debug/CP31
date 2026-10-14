using System;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200000D RID: 13
	public class CardHeaderPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000031F5 File Offset: 0x000013F5
		public CardHeaderPresenterAutomationPeer(global::System.Windows.FrameworkElement owner) : base(owner)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000031FE File Offset: 0x000013FE
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003202 File Offset: 0x00001402
		protected override string GetClassNameCore()
		{
			return "CardHeaderPresenter";
		}
	}
}
