using System;
using System.Collections.Generic;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using Infragistics.Windows.DataPresenter;

namespace Infragistics.Windows.Automation.Peers.DataPresenter
{
	// Token: 0x02000014 RID: 20
	public class FieldMenuItemAutomationPeer : global::System.Windows.Automation.Peers.MenuItemAutomationPeer
	{
		// Token: 0x0600009F RID: 159 RVA: 0x00003E15 File Offset: 0x00002015
		public FieldMenuItemAutomationPeer(global::Infragistics.Windows.DataPresenter.FieldMenuItem owner) : base(owner)
		{
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003E20 File Offset: 0x00002020
		protected override global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> GetChildrenCore()
		{
			global::System.Collections.Generic.List<global::System.Windows.Automation.Peers.AutomationPeer> list = base.GetChildrenCore();
			if (list == null)
			{
				global::System.Windows.Controls.MenuItem menuItem = base.Owner as global::System.Windows.Controls.MenuItem;
				if (menuItem.Role == global::System.Windows.Controls.MenuItemRole.TopLevelItem || menuItem.Role == global::System.Windows.Controls.MenuItemRole.SubmenuItem)
				{
					list = new global::System.Windows.Automation.Peers.UIElementAutomationPeer(base.Owner).GetChildren();
				}
			}
			return list;
		}
	}
}
