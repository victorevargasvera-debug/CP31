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
		// Token: 0x06000094 RID: 148 RVA: 0x00003E3D File Offset: 0x0000203D
		public FieldMenuItemAutomationPeer(global::Infragistics.Windows.DataPresenter.FieldMenuItem owner) : base(owner)
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00003E48 File Offset: 0x00002048
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
