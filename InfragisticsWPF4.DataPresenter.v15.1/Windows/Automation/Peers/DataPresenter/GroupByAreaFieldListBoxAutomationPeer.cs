using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001B RID: 27
	public class GroupByAreaFieldListBoxAutomationPeer : global::System.Windows.Automation.Peers.ListBoxAutomationPeer
	{
		// Token: 0x060000C1 RID: 193 RVA: 0x000040C0 File Offset: 0x000022C0
		public GroupByAreaFieldListBoxAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldListBox owner) : base(owner)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000040C9 File Offset: 0x000022C9
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Header;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000040CD File Offset: 0x000022CD
		protected override string GetClassNameCore()
		{
			return "GroupByAreaFieldListBox";
		}
	}
}
