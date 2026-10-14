using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001C RID: 28
	public class GroupByAreaMultiAutomationPeer : global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaBaseAutomationPeer
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x000040FC File Offset: 0x000022FC
		public GroupByAreaMultiAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByAreaMulti owner) : base(owner)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00004105 File Offset: 0x00002305
		protected override string GetClassNameCore()
		{
			return "GroupByAreaMulti";
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000410C File Offset: 0x0000230C
		protected override string GetNameCore()
		{
			return "GroupByAreaMulti";
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00004113 File Offset: 0x00002313
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return base.GetPattern(patternInterface);
		}
	}
}
