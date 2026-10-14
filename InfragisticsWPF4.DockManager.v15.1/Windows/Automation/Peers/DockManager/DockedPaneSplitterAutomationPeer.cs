using System;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x02000010 RID: 16
	public class DockedPaneSplitterAutomationPeer : global::Infragistics.Windows.Automation.Peers.DockManager.PaneSplitterAutomationPeer
	{
		// Token: 0x0600009C RID: 156 RVA: 0x00004A37 File Offset: 0x00002C37
		public DockedPaneSplitterAutomationPeer(global::Infragistics.Windows.DockManager.DockedPaneSplitter owner) : base(owner)
		{
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00004A40 File Offset: 0x00002C40
		protected override string GetClassNameCore()
		{
			return "DockedPaneSplitter";
		}
	}
}
