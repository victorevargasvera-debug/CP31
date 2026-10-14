using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000017 RID: 23
	public class FixedRecordButtonAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00003F89 File Offset: 0x00002189
		public FixedRecordButtonAutomationPeer(global::Infragistics.Windows.DataPresenter.FixedRecordButton element) : base(element)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00003F92 File Offset: 0x00002192
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00003F96 File Offset: 0x00002196
		protected override string GetClassNameCore()
		{
			return "FixedRecordButton";
		}
	}
}
