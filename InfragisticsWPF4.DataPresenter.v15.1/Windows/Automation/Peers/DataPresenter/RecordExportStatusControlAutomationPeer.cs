using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000026 RID: 38
	public class RecordExportStatusControlAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000135 RID: 309 RVA: 0x00005F0D File Offset: 0x0000410D
		public RecordExportStatusControlAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl owner) : base(owner)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005F16 File Offset: 0x00004116
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005F1A File Offset: 0x0000411A
		protected override string GetClassNameCore()
		{
			return "RecordExportStatusControl";
		}
	}
}
