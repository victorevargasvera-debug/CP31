using System;
using System.Windows;
using System.Windows.Automation.Peers;

namespace Infragistics.AutomationPeers
{
	// Token: 0x02000047 RID: 71
	public class FrameworkElementAutomationPeerBase : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060002C6 RID: 710 RVA: 0x0000BB9B File Offset: 0x00009D9B
		public FrameworkElementAutomationPeerBase(global::System.Windows.FrameworkElement owner) : base(owner)
		{
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000BBA4 File Offset: 0x00009DA4
		public sealed override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return this.GetPatternCore(patternInterface);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000BBAD File Offset: 0x00009DAD
		protected virtual object GetPatternCore(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return base.GetPattern(patternInterface);
		}
	}
}
