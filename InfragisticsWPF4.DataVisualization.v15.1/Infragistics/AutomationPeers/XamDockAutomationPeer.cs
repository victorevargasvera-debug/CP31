using System;
using System.Windows.Automation.Peers;
using Infragistics.Controls;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000006 RID: 6
	public class XamDockAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x0600002C RID: 44 RVA: 0x000029DB File Offset: 0x00000BDB
		public XamDockAutomationPeer(global::Infragistics.Controls.XamDock dock) : base(dock)
		{
			this.Dock = dock;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000029EB File Offset: 0x00000BEB
		// (set) Token: 0x0600002E RID: 46 RVA: 0x000029F3 File Offset: 0x00000BF3
		public global::Infragistics.Controls.XamDock Dock { get; set; }

		// Token: 0x0600002F RID: 47 RVA: 0x000029FC File Offset: 0x00000BFC
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return base.GetPattern(patternInterface);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002A05 File Offset: 0x00000C05
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002A09 File Offset: 0x00000C09
		protected override string GetClassNameCore()
		{
			return this.Dock.GetType().Name;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002A1B File Offset: 0x00000C1B
		protected override string GetNameCore()
		{
			if (string.IsNullOrEmpty(this.Dock.Name))
			{
				return this.Dock.GetType().Name;
			}
			return this.Dock.Name;
		}
	}
}
