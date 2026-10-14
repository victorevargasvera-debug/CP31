using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000027 RID: 39
	public class RecordFilterTreeControlAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000138 RID: 312 RVA: 0x00005F21 File Offset: 0x00004121
		public RecordFilterTreeControlAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl owner) : base(owner)
		{
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00005F2A File Offset: 0x0000412A
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00005F2E File Offset: 0x0000412E
		protected override string GetClassNameCore()
		{
			return "RecordFilterTreeControl";
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00005F35 File Offset: 0x00004135
		protected override bool IsContentElementCore()
		{
			return false;
		}
	}
}
