using System;
using System.Collections.Generic;
using Infragistics.Controls.Menus;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000DB RID: 219
	public class MenuItemClickCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Controls.Menus.XamMenuItem>
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x00062B2C File Offset: 0x00060D2C
		public MenuItemClickCommandBehavior(global::Infragistics.Controls.Menus.XamMenuItem menuItem) : base(menuItem)
		{
			if (global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior.a == null)
			{
				global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior.a = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamMenuItem>();
			}
			if (global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior.a.Contains(menuItem))
			{
				return;
			}
			menuItem.Click += this.a;
			global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior.a.Add(menuItem);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00062B84 File Offset: 0x00060D84
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1355217246;
			short num2 = num;
			num = (short)1835858270;
			switch (num2 == num)
			{
			}
			num = (short)1583874049;
			if (num != 0)
			{
			}
			num = (short)1854013440;
			if (num != 0)
			{
			}
			num = (short)5242880;
			short num3 = num;
			this.ExecuteCommand();
		}

		// Token: 0x040002A3 RID: 675
		private static global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamMenuItem> a;
	}
}
