using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.Controls;

namespace Infragistics.Windows.Automation.Peers
{
	// Token: 0x020000FE RID: 254
	public class AutomationControlPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060008FB RID: 2299 RVA: 0x0001F58F File Offset: 0x0001D78F
		public AutomationControlPeer(global::Infragistics.Windows.Controls.AutomationControl control) : base(control)
		{
			this._control = control;
		}

		// Token: 0x060008FC RID: 2300 RVA: 0x0001F59F File Offset: 0x0001D79F
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x04000442 RID: 1090
		private global::Infragistics.Windows.Controls.AutomationControl _control;
	}
}
