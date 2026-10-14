using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001E RID: 30
	public class HeaderPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060000E0 RID: 224 RVA: 0x000049DD File Offset: 0x00002BDD
		public HeaderPresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.HeaderPresenter owner) : base(owner)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000049E6 File Offset: 0x00002BE6
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Header;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000049EA File Offset: 0x00002BEA
		protected override string GetClassNameCore()
		{
			return "HeaderPresenter";
		}
	}
}
