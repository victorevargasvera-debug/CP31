using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001C RID: 28
	public class GroupByAreaMultiAutomationPeer : global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaBaseAutomationPeer
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x000040D4 File Offset: 0x000022D4
		public GroupByAreaMultiAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti owner) : base(owner)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000040DD File Offset: 0x000022DD
		protected override string GetClassNameCore()
		{
			return "GroupByAreaMulti";
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000040E4 File Offset: 0x000022E4
		protected override string GetNameCore()
		{
			return "GroupByAreaMulti";
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000040EB File Offset: 0x000022EB
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return base.GetPattern(patternInterface);
		}
	}
}
