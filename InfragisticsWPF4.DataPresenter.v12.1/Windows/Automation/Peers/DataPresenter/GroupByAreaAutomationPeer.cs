using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000019 RID: 25
	public class GroupByAreaAutomationPeer : global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaBaseAutomationPeer
	{
		// Token: 0x060000AE RID: 174 RVA: 0x0000408C File Offset: 0x0000228C
		public GroupByAreaAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByArea owner) : base(owner)
		{
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00004095 File Offset: 0x00002295
		protected override string GetClassNameCore()
		{
			return "GroupByArea";
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000409C File Offset: 0x0000229C
		protected override string GetNameCore()
		{
			return "GroupByArea";
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000040A3 File Offset: 0x000022A3
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return base.GetPattern(patternInterface);
		}
	}
}
