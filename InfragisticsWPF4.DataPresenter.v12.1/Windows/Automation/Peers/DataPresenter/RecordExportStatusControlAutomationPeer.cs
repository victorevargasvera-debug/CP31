using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000026 RID: 38
	public class RecordExportStatusControlAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000126 RID: 294 RVA: 0x00005D65 File Offset: 0x00003F65
		public RecordExportStatusControlAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordExportStatusControl owner) : base(owner)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005D6E File Offset: 0x00003F6E
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005D72 File Offset: 0x00003F72
		protected override string GetClassNameCore()
		{
			return "RecordExportStatusControl";
		}
	}
}
