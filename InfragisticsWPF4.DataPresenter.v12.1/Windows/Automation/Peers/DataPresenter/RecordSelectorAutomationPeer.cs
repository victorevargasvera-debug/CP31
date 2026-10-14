using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002D RID: 45
	public class RecordSelectorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00007101 File Offset: 0x00005301
		public RecordSelectorAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordSelector owner) : base(owner)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000710A File Offset: 0x0000530A
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.HeaderItem;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000710E File Offset: 0x0000530E
		protected override string GetClassNameCore()
		{
			return "RecordSelector";
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00007115 File Offset: 0x00005315
		protected override bool IsContentElementCore()
		{
			return false;
		}
	}
}
