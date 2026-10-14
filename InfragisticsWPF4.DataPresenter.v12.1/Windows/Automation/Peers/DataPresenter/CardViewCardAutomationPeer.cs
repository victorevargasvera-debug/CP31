using System;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200000F RID: 15
	public class CardViewCardAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000060 RID: 96 RVA: 0x000036CD File Offset: 0x000018CD
		public CardViewCardAutomationPeer(global::System.Windows.FrameworkElement owner) : base(owner)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000036D6 File Offset: 0x000018D6
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000036DA File Offset: 0x000018DA
		protected override string GetClassNameCore()
		{
			return "CardViewCard";
		}
	}
}
