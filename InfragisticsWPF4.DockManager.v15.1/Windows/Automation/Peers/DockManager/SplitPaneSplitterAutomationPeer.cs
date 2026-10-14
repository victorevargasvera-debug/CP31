using System;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x02000014 RID: 20
	public class SplitPaneSplitterAutomationPeer : global::Infragistics.Windows.Automation.Peers.DockManager.PaneSplitterAutomationPeer
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00004B33 File Offset: 0x00002D33
		public SplitPaneSplitterAutomationPeer(global::Infragistics.Windows.DockManager.SplitPaneSplitter owner) : base(owner)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00004B3C File Offset: 0x00002D3C
		protected override string GetClassNameCore()
		{
			return "SplitPaneSplitter";
		}
	}
}
