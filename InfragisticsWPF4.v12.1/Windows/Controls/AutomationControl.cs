using System;
using System.ComponentModel;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000DE RID: 222
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class AutomationControl : global::System.Windows.Controls.Control
	{
		// Token: 0x060007F8 RID: 2040 RVA: 0x0001B9AB File Offset: 0x00019BAB
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.AutomationControlPeer(this);
		}
	}
}
