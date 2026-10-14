using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001E RID: 30
	public class HeaderPresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x000049ED File Offset: 0x00002BED
		public HeaderPresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.HeaderPresenter owner) : base(owner)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000049F6 File Offset: 0x00002BF6
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Header;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x000049FA File Offset: 0x00002BFA
		protected override string GetClassNameCore()
		{
			return "HeaderPresenter";
		}
	}
}
