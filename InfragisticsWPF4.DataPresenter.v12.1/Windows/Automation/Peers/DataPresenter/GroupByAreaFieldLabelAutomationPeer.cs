using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001A RID: 26
	public class GroupByAreaFieldLabelAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x000040AC File Offset: 0x000022AC
		public GroupByAreaFieldLabelAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel owner) : base(owner)
		{
			this._owner = owner;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000040BC File Offset: 0x000022BC
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.HeaderItem;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000040C0 File Offset: 0x000022C0
		protected override string GetClassNameCore()
		{
			return "GroupByAreaFieldLabel";
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000040C7 File Offset: 0x000022C7
		protected override string GetNameCore()
		{
			if (this._owner != null)
			{
				return this._owner.Field.Name;
			}
			return base.GetNameCore();
		}

		// Token: 0x0400002B RID: 43
		private global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel _owner;
	}
}
