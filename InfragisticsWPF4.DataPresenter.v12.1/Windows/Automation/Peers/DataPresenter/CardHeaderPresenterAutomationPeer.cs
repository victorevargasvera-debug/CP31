using System;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200000E RID: 14
	public class CardHeaderPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x0600005D RID: 93 RVA: 0x000036B9 File Offset: 0x000018B9
		public CardHeaderPresenterAutomationPeer(global::System.Windows.FrameworkElement owner) : base(owner)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000036C2 File Offset: 0x000018C2
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000036C6 File Offset: 0x000018C6
		protected override string GetClassNameCore()
		{
			return "CardHeaderPresenter";
		}
	}
}
