using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000012 RID: 18
	public class CellValuePresenterAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x0600008A RID: 138 RVA: 0x000038B8 File Offset: 0x00001AB8
		public CellValuePresenterAutomationPeer(global::Infragistics.Windows.DataPresenter.CellValuePresenter owner) : base(owner)
		{
			global::Infragistics.Windows.DataPresenter.Cell cell = owner.Cell;
			if (cell != null && owner.IsWithinRecord)
			{
				cell.AssociatedCellValuePresenterInternal = owner;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000038E5 File Offset: 0x00001AE5
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000038E9 File Offset: 0x00001AE9
		protected override string GetClassNameCore()
		{
			return "CellValuePresenter";
		}
	}
}
