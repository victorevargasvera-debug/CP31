using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DockManager;

namespace Infragistics.Windows.Automation.Peers.DockManager
{
	// Token: 0x0200000E RID: 14
	public class ContentPaneAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00004958 File Offset: 0x00002B58
		public ContentPaneAutomationPeer(global::Infragistics.Windows.DockManager.ContentPane owner) : base(owner)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004961 File Offset: 0x00002B61
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00004965 File Offset: 0x00002B65
		protected override string GetClassNameCore()
		{
			return "ContentPane";
		}
	}
}
