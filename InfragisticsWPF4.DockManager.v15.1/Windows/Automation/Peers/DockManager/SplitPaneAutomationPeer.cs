using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x02000013 RID: 19
	public class SplitPaneAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060000A7 RID: 167 RVA: 0x00004B23 File Offset: 0x00002D23
		public SplitPaneAutomationPeer(global::Infragistics.Windows.DockManager.SplitPane owner) : base(owner)
		{
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00004B2C File Offset: 0x00002D2C
		protected override string GetClassNameCore()
		{
			return "SplitPane";
		}
	}
}
