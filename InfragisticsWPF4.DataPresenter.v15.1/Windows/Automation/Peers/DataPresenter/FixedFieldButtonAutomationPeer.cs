using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000015 RID: 21
	public class FixedFieldButtonAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x00003E66 File Offset: 0x00002066
		public FixedFieldButtonAutomationPeer(global::Infragistics.Windows.DataPresenter.FixedFieldButton element) : base(element)
		{
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003E6F File Offset: 0x0000206F
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003E73 File Offset: 0x00002073
		protected override string GetClassNameCore()
		{
			return "FixedFieldButton";
		}
	}
}
