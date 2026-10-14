using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Threading;
using Infragistics.Controls.Menus;
using Microsoft.Practices.Prism.Commands;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000026 RID: 38
	public class MenuItemClickCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Controls.Menus.XamMenuItem>
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00008BE0 File Offset: 0x00006DE0
		public MenuItemClickCommandBehavior(global::Infragistics.Controls.Menus.XamMenuItem menuItem) : base(menuItem)
		{
			if (global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior.a == null)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior.a = new global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamMenuItem>();
			}
			if (global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior.a.Contains(menuItem))
			{
				return;
			}
			menuItem.Click += this.a;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior.a.Add(menuItem);
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00008C38 File Offset: 0x00006E38
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00008CEC File Offset: 0x00006EEC
		public bool IsDelayExecuteCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1260355177;
				short num2 = num;
				num = (short)946830953;
				switch (num2 == num)
				{
				}
				num = (short)374538240;
				if (num != 0)
				{
				}
				num = (short)1697906689;
				if (num != 0)
				{
				}
				num = (short)1503133696;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)705560408;
				short num2 = num;
				num = (short)317980504;
				switch (num2 == num)
				{
				}
				num = (short)745668608;
				if (num != 0)
				{
				}
				num = (short)841023489;
				if (num != 0)
				{
				}
				num = (short)362545152;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00008D9C File Offset: 0x00006F9C
		private void a(object A_0, global::System.EventArgs A_1)
		{
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)A_0;
			if (!this.IsDelayExecuteCommand)
			{
				short num = (short)1395695084;
				short num2 = num;
				num = (short)481795564;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1989148672;
					if (num != 0)
					{
					}
					num = (short)675348481;
					if (num != 0)
					{
					}
					num = (short)192741376;
					short num3 = num;
					this.ExecuteCommand();
					return;
				}
				}
			}
			xamMenuItem.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.ApplicationIdle, new global::System.Action(this.a));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00008E74 File Offset: 0x00007074
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a()
		{
			short num = (short)1314459149;
			short num2 = num;
			num = (short)1724452365;
			switch (num2 == num)
			{
			}
			num = (short)1046478848;
			if (num != 0)
			{
			}
			num = (short)430768129;
			if (num != 0)
			{
			}
			num = (short)1916600320;
			short num3 = num;
			this.ExecuteCommand();
		}

		// Token: 0x04000026 RID: 38
		private static global::System.Collections.Generic.List<global::Infragistics.Controls.Menus.XamMenuItem> a;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;
	}
}
