using System;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200000E RID: 14
	public class CardViewCardAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00003209 File Offset: 0x00001409
		public CardViewCardAutomationPeer(global::System.Windows.FrameworkElement owner) : base(owner)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00003212 File Offset: 0x00001412
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003216 File Offset: 0x00001416
		protected override string GetClassNameCore()
		{
			return "CardViewCard";
		}
	}
}
