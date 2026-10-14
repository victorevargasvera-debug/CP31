using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000E0 RID: 224
	public class AutomationControlPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060007FC RID: 2044 RVA: 0x0001B9C7 File Offset: 0x00019BC7
		public AutomationControlPeer(global::Infragistics.Windows.Controls.AutomationControl control) : base(control)
		{
			this._control = control;
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0001B9D7 File Offset: 0x00019BD7
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0400038F RID: 911
		private global::Infragistics.Windows.Controls.AutomationControl _control;
	}
}
