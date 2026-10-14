using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200002D RID: 45
	public class RecordSelectorAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060001BE RID: 446 RVA: 0x00007525 File Offset: 0x00005725
		public RecordSelectorAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordSelector owner) : base(owner)
		{
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000752E File Offset: 0x0000572E
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.HeaderItem;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00007532 File Offset: 0x00005732
		protected override string GetClassNameCore()
		{
			return "RecordSelector";
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00007539 File Offset: 0x00005739
		protected override bool IsContentElementCore()
		{
			return false;
		}
	}
}
