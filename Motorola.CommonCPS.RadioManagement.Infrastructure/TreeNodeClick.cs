using System;
using System.Windows;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200002F RID: 47
	public static class TreeNodeClick
	{
		// Token: 0x060000B2 RID: 178 RVA: 0x0000C310 File Offset: 0x0000A510
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree rmdataTree;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
						if (!(rmdataTree.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick.aProperty) is global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClickCommandBehavior))
						{
							num2 = (short)2018770946;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						num2 = (short)243859457;
						if (num2 != 0)
						{
						}
						num2 = (short)51648585;
						short num3 = num2;
						num2 = (short)1542592585;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23;
						default:
						{
							num2 = (short)362348544;
							if (num2 != 0)
							{
							}
							global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClickCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClickCommandBehavior(rmdataTree)
							{
								Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
							};
							rmdataTree.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick.aProperty, value);
							num2 = (short)2046558208;
							short num4 = num2;
							num2 = (short)312344576;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
				}
				return;
			}
			IL_1C:
			rmdataTree = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree)A_0;
			IL_23:
			num2 = (short)305266689;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000C45C File Offset: 0x0000A65C
		public static global::System.Windows.Input.ICommand GetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree dataTree)
		{
			short num = (short)484457711;
			short num2 = num;
			num = (short)1396325615;
			switch (num2 == num)
			{
			}
			num = (short)1962213376;
			short num3 = num;
			num = (short)347340801;
			if (num != 0)
			{
			}
			num = (short)1314062336;
			if (num != 0)
			{
			}
			return dataTree.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000C518 File Offset: 0x0000A718
		public static void SetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMDataTree dataTree, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1962271634;
			short num2 = num;
			num = (short)1221059474;
			switch (num2 == num)
			{
			}
			num = (short)318767104;
			short num3 = num;
			num = (short)2003238912;
			if (num != 0)
			{
			}
			num = (short)1132134401;
			if (num != 0)
			{
			}
			dataTree.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick.CommandProperty, command);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		// Note: this type is marked as 'beforefieldinit'.
		static TreeNodeClick()
		{
			int a_ = 7;
			short num = (short)690730836;
			short num2 = num;
			num = (short)1284945748;
			switch (num2 == num)
			{
			}
			num = (short)2086273024;
			short num3 = num;
			num = (short)1605500929;
			if (num != 0)
			{
			}
			num = (short)1524236288;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("尞丠丢䠤䘦䜨伪", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("縞", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClickCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TreeNodeClick), null);
		}

		// Token: 0x0400003D RID: 61
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400003E RID: 62
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
