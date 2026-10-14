using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Controls.Menus;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000025 RID: 37
	public static class MenuItemClick
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000083D8 File Offset: 0x000065D8
		private static void b(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1707212801;
			if (num != 0)
			{
			}
			num = (short)1477017598;
			short num2 = num;
			num = (short)1106673662;
			switch (num2 == num)
			{
			}
			num = (short)920387584;
			if (num != 0)
			{
			}
			num = (short)1053687808;
			short num3 = num;
			global::Infragistics.Controls.Menus.XamMenuItem xamMenuItem = (global::Infragistics.Controls.Menus.XamMenuItem)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior(xamMenuItem)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand),
				CommandParameter = xamMenuItem.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.CommandParameterProperty),
				IsDelayExecuteCommand = global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.GetIsDelayExecuteCommand(xamMenuItem)
			};
			xamMenuItem.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.aProperty, value);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000084D0 File Offset: 0x000066D0
		public static bool GetIsDelayExecuteCommand(global::System.Windows.DependencyObject obj)
		{
			short num = (short)1285160961;
			if (num != 0)
			{
			}
			num = (short)1994894152;
			short num2 = num;
			num = (short)945662792;
			switch (num2 == num)
			{
			}
			num = (short)1228406784;
			if (num != 0)
			{
			}
			num = (short)410058752;
			short num3 = num;
			return (bool)obj.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.IsDelayExecuteCommandProperty);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008588 File Offset: 0x00006788
		public static void SetIsDelayExecuteCommand(global::System.Windows.DependencyObject obj, bool value)
		{
			short num = (short)932052993;
			if (num != 0)
			{
			}
			num = (short)2110247988;
			short num2 = num;
			num = (short)769184820;
			switch (num2 == num)
			{
			}
			num = (short)410255360;
			if (num != 0)
			{
			}
			num = (short)435945472;
			short num3 = num;
			obj.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.IsDelayExecuteCommandProperty, value);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008644 File Offset: 0x00006844
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior menuItemClickCommandBehavior;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_100;
				case 1:
					if (menuItemClickCommandBehavior != null)
					{
						num2 = (short)1635057666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_102;
				case 2:
				{
					num2 = (short)748299184;
					short num3 = num2;
					num2 = (short)1593254832;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1980039169;
						if (num2 != 0)
						{
						}
						num2 = (short)283836416;
						if (num2 != 0)
						{
						}
						menuItemClickCommandBehavior.IsDelayExecuteCommand = (bool)A_1.NewValue;
						num2 = (short)126812160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_100:
			IL_102:
			num2 = (short)1214971904;
			short num4 = num2;
			return;
			IL_1C:
			menuItemClickCommandBehavior = (((global::Infragistics.Controls.Menus.XamMenuItem)A_0).GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.aProperty) as global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior);
			num2 = (short)251396097;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000877C File Offset: 0x0000697C
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Controls.Menus.XamMenuItem menuItem)
		{
			short num = (short)2062712949;
			short num2 = num;
			num = (short)1380286581;
			switch (num2 == num)
			{
			}
			num = (short)2003566593;
			if (num != 0)
			{
			}
			num = (short)394723328;
			if (num != 0)
			{
			}
			num = (short)1823211520;
			short num3 = num;
			return menuItem.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008838 File Offset: 0x00006A38
		public static object GetCommandParameter(global::Infragistics.Controls.Menus.XamMenuItem menuItem)
		{
			short num = (short)807158722;
			short num2 = num;
			num = (short)1639728066;
			switch (num2 == num)
			{
			}
			num = (short)173342721;
			if (num != 0)
			{
			}
			num = (short)703070208;
			if (num != 0)
			{
			}
			num = (short)179240960;
			short num3 = num;
			return menuItem.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.CommandParameterProperty);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000088E8 File Offset: 0x00006AE8
		public static void SetCommand(global::Infragistics.Controls.Menus.XamMenuItem menuItem, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1611101952;
			short num2 = num;
			num = (short)697792256;
			switch (num2 == num)
			{
			}
			num = (short)1415053313;
			if (num != 0)
			{
			}
			num = (short)947126272;
			if (num != 0)
			{
			}
			num = (short)523501568;
			short num3 = num;
			menuItem.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.CommandProperty, command);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000899C File Offset: 0x00006B9C
		public static void SetCommandParameter(global::Infragistics.Controls.Menus.XamMenuItem menuItem, object commandParameter)
		{
			short num = (short)1945587055;
			short num2 = num;
			num = (short)1447054703;
			switch (num2 == num)
			{
			}
			num = (short)322437121;
			if (num != 0)
			{
			}
			num = (short)1939079168;
			if (num != 0)
			{
			}
			num = (short)299892736;
			short num3 = num;
			menuItem.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.CommandParameterProperty, commandParameter);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008A54 File Offset: 0x00006C54
		// Note: this type is marked as 'beforefieldinit'.
		static MenuItemClick()
		{
			int a_ = 5;
			short num = (short)1983729708;
			short num2 = num;
			num = (short)854085676;
			switch (num2 == num)
			{
			}
			num = (short)1648754688;
			if (num != 0)
			{
			}
			num = (short)795344897;
			if (num != 0)
			{
			}
			num = (short)1033895936;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("帜瀞䰠丢䐤䤦䴨", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.b)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.CommandParameterProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("帜瀞䰠丢䐤䤦䴨笪䰬崮倰帲倴䌶尸䤺", a_), typeof(object), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("簜", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClickCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick), null);
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.IsDelayExecuteCommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("吜氞攠䘢䤤䘦倨渪唬䨮到䘲䄴制稸吺值刾⁀ⵂ⅄", a_), typeof(bool), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick), new global::System.Windows.PropertyMetadata(false, new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MenuItemClick.a)));
		}

		// Token: 0x04000022 RID: 34
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000023 RID: 35
		public static readonly global::System.Windows.DependencyProperty CommandParameterProperty;

		// Token: 0x04000024 RID: 36
		private static readonly global::System.Windows.DependencyProperty aProperty;

		// Token: 0x04000025 RID: 37
		public static readonly global::System.Windows.DependencyProperty IsDelayExecuteCommandProperty;
	}
}
