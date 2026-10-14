using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000017 RID: 23
	public class FixedRecordButtonAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00003FB1 File Offset: 0x000021B1
		public FixedRecordButtonAutomationPeer(global::Infragistics.Windows.DataPresenter.FixedRecordButton element) : base(element)
		{
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003FBA File Offset: 0x000021BA
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003FBE File Offset: 0x000021BE
		protected override string GetClassNameCore()
		{
			return "FixedRecordButton";
		}
	}
}
