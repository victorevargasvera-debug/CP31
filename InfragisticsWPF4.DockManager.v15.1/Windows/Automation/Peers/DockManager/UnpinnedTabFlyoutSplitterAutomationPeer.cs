using System;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x02000016 RID: 22
	public class UnpinnedTabFlyoutSplitterAutomationPeer : global::Infragistics.Windows.Automation.Peers.DockManager.PaneSplitterAutomationPeer
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00004CB8 File Offset: 0x00002EB8
		public UnpinnedTabFlyoutSplitterAutomationPeer(global::Infragistics.Windows.DockManager.UnpinnedTabFlyoutSplitter owner) : base(owner)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00004CC1 File Offset: 0x00002EC1
		protected override string GetClassNameCore()
		{
			return "UnpinnedTabFlyoutSplitter";
		}
	}
}
