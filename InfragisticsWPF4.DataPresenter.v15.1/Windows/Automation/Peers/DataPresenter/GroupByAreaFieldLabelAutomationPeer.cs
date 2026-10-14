using System;
using System.Windows.Automation.Peers;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x0200001A RID: 26
	public class GroupByAreaFieldLabelAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00004084 File Offset: 0x00002284
		public GroupByAreaFieldLabelAutomationPeer(global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel owner) : base(owner)
		{
			this._owner = owner;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00004094 File Offset: 0x00002294
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.HeaderItem;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00004098 File Offset: 0x00002298
		protected override string GetClassNameCore()
		{
			return "GroupByAreaFieldLabel";
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000409F File Offset: 0x0000229F
		protected override string GetNameCore()
		{
			if (this._owner != null)
			{
				return this._owner.Field.Name;
			}
			return base.GetNameCore();
		}

		// Token: 0x04000039 RID: 57
		private global::Infragistics.Windows.DataPresenter.GroupByAreaFieldLabel _owner;
	}
}
