using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000019 RID: 25
	public class GroupByAreaAutomationPeer : global::Infragistics.Windows.Automation.Peers.DataPresenter.GroupByAreaBaseAutomationPeer
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x00004064 File Offset: 0x00002264
		public GroupByAreaAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByArea owner) : base(owner)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000406D File Offset: 0x0000226D
		protected override string GetClassNameCore()
		{
			return "GroupByArea";
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00004074 File Offset: 0x00002274
		protected override string GetNameCore()
		{
			return "GroupByArea";
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000407B File Offset: 0x0000227B
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			return base.GetPattern(patternInterface);
		}
	}
}
