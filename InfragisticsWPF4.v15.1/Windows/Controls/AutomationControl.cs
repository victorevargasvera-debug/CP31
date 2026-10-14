using System;
using System.ComponentModel;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.Automation.Peers;

namespace Infragistics.Windows.Controls
{
	// Token: 0x020000FC RID: 252
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class AutomationControl : global::System.Windows.Controls.Control
	{
		// Token: 0x060008F7 RID: 2295 RVA: 0x0001F573 File Offset: 0x0001D773
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.AutomationControlPeer(this);
		}
	}
}
