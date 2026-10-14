using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000027 RID: 39
	public class RecordFilterTreeControlAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000129 RID: 297 RVA: 0x00005D79 File Offset: 0x00003F79
		public RecordFilterTreeControlAutomationPeer(global::Infragistics.Windows.DataPresenter.RecordFilterTreeControl owner) : base(owner)
		{
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00005D82 File Offset: 0x00003F82
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00005D86 File Offset: 0x00003F86
		protected override string GetClassNameCore()
		{
			return "RecordFilterTreeControl";
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00005D8D File Offset: 0x00003F8D
		protected override bool IsContentElementCore()
		{
			return false;
		}
	}
}
