using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000012 RID: 18
	public class CellValuePresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x06000088 RID: 136 RVA: 0x00003D04 File Offset: 0x00001F04
		public CellValuePresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.CellValuePresenter owner) : base(owner)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = owner.Cell;
			if (cell != null && owner.IsWithinRecord)
			{
				cell.AssociatedCellValuePresenterInternal = owner;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003D31 File Offset: 0x00001F31
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003D35 File Offset: 0x00001F35
		protected override string GetClassNameCore()
		{
			return "CellValuePresenter";
		}
	}
}
