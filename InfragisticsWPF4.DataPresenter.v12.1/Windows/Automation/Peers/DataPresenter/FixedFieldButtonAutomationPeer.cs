using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000015 RID: 21
	public class FixedFieldButtonAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000096 RID: 150 RVA: 0x00003E8E File Offset: 0x0000208E
		public FixedFieldButtonAutomationPeer(global::Infragistics.Windows.DataPresenter.FixedFieldButton element) : base(element)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00003E97 File Offset: 0x00002097
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003E9B File Offset: 0x0000209B
		protected override string GetClassNameCore()
		{
			return "FixedFieldButton";
		}
	}
}
