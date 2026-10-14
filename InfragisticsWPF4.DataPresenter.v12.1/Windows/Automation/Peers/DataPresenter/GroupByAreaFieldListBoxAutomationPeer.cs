using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001B RID: 27
	public class GroupByAreaFieldListBoxAutomationPeer : global::System.Windows.Automation.Peers.ListBoxAutomationPeer
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x000040E8 File Offset: 0x000022E8
		public GroupByAreaFieldListBoxAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldListBox owner) : base(owner)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000040F1 File Offset: 0x000022F1
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Header;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000040F5 File Offset: 0x000022F5
		protected override string GetClassNameCore()
		{
			return "GroupByAreaFieldListBox";
		}
	}
}
