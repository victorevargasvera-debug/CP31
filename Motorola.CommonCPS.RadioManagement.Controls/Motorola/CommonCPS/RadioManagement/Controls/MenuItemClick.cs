using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Controls.Menus;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000DA RID: 218
	public static class MenuItemClick
	{
		// Token: 0x06000619 RID: 1561 RVA: 0x000624DC File Offset: 0x000606DC
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)770703361;
			if (num != 0)
			{
			}
			num = (short)1686849287;
			short num2 = num;
			num = (short)500713223;
			switch (num2 == num)
			{
			}
			num = (short)582483968;
			if (num != 0)
			{
			}
			num = (short)164102144;
			short num3 = num;
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)A_0;
			global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior(xamMenuItem)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand),
				CommandParameter = xamMenuItem.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.CommandParameterProperty)
			};
			xamMenuItem.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.MenuItemClickCommandBehaviorProperty, value);
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x000625C8 File Offset: 0x000607C8
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior menuItemClickCommandBehavior;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					menuItemClickCommandBehavior.CommandParameter = A_1.NewValue;
					num2 = (short)1833304064;
					short num3 = num2;
					num2 = (short)1288044545;
					if (num2 != 0)
					{
					}
					num2 = (short)345229015;
					short num4 = num2;
					num2 = (short)99665623;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)690028544;
						if (num2 != 0)
						{
						}
						num2 = (short)244842496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (menuItemClickCommandBehavior != null)
					{
						num2 = (short)1838350337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)A_0;
			menuItemClickCommandBehavior = (xamMenuItem.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.MenuItemClickCommandBehaviorProperty) as global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior);
			num2 = (short)1050476546;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x000626FC File Offset: 0x000608FC
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Controls.Menus.XamMenuItem menuItem)
		{
			short num = (short)1212940289;
			if (num != 0)
			{
			}
			num = (short)936148302;
			short num2 = num;
			num = (short)438271310;
			switch (num2 == num)
			{
			}
			num = (short)1167982592;
			if (num != 0)
			{
			}
			num = (short)17432576;
			short num3 = num;
			return menuItem.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x000627B4 File Offset: 0x000609B4
		public static object GetCommandParameter(global::Infragistics.Controls.Menus.XamMenuItem menuItem)
		{
			short num = (short)417132737;
			short num2 = num;
			num = (short)1880879297;
			switch (num2 == num)
			{
			}
			num = (short)2099249152;
			if (num != 0)
			{
			}
			num = (short)1155137537;
			if (num != 0)
			{
			}
			num = (short)1397948416;
			short num3 = num;
			return menuItem.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.CommandParameterProperty);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00062868 File Offset: 0x00060A68
		public static void SetCommand(global::Infragistics.Controls.Menus.XamMenuItem menuItem, global::System.Windows.Input.ICommand command)
		{
			short num = (short)2072772609;
			if (num != 0)
			{
			}
			num = (short)1317058299;
			short num2 = num;
			num = (short)596948731;
			switch (num2 == num)
			{
			}
			num = (short)463077376;
			if (num != 0)
			{
			}
			num = (short)933298176;
			short num3 = num;
			menuItem.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.CommandProperty, command);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0006291C File Offset: 0x00060B1C
		public static void SetCommandParameter(global::Infragistics.Controls.Menus.XamMenuItem menuItem, object commandParameter)
		{
			short num = (short)55769418;
			short num2 = num;
			num = (short)136444234;
			switch (num2 == num)
			{
			}
			num = (short)1806368768;
			if (num != 0)
			{
			}
			num = (short)1784086529;
			if (num != 0)
			{
			}
			num = (short)484048896;
			short num3 = num;
			menuItem.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.CommandParameterProperty, commandParameter);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x000629D0 File Offset: 0x00060BD0
		// Note: this type is marked as 'beforefieldinit'.
		static MenuItemClick()
		{
			int a_ = 16;
			short num = (short)1554059136;
			short num2 = num;
			num = (short)847122304;
			switch (num2 == num)
			{
			}
			num = (short)1443102721;
			if (num != 0)
			{
			}
			num = (short)2100035584;
			if (num != 0)
			{
			}
			num = (short)1945698304;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얩솫쎭톯\udcb1킳", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.b)));
			global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.CommandParameterProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("얩솫쎭톯\udcb1킳\ud9b7좹\uddbb펽ꖿ뛁ꇃ듅", a_), typeof(object), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.a)));
			global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick.MenuItemClickCommandBehaviorProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾩슫\udbad羚욱톳\udbb5﮷횹햻\uddbdꮿ臁ꯃꯅꗇꯉꋋ꫍鋏럑볓럕껗동돛곝", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClickCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.MenuItemClick), null);
		}

		// Token: 0x040002A0 RID: 672
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x040002A1 RID: 673
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty;

		// Token: 0x040002A2 RID: 674
		private static readonly global::System.Windows.DependencyProperty MenuItemClickCommandBehaviorProperty;
	}
}
