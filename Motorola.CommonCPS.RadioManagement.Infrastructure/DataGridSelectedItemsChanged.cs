using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Microsoft.Practices.Prism.Commands;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200001F RID: 31
	public static class DataGridSelectedItemsChanged
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00007504 File Offset: 0x00005704
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid rmdataGrid;
			global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::Infragistics.Windows.DataPresenter.XamDataGrid> commandBehaviorBase;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_BA;
				case 1:
				{
					commandBehaviorBase = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridSelectedItemsChangedCommandBehavior(rmdataGrid);
					rmdataGrid.RegisterBehavior(commandBehaviorBase.GetType(), commandBehaviorBase);
					num2 = (short)1864499200;
					short num3 = num2;
					num2 = (short)550305792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (commandBehaviorBase == null)
					{
						goto IL_4C;
					}
					goto IL_BA;
				}
				goto IL_1C;
				IL_4C:
				num2 = (short)2123759617;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_BA:
				num2 = (short)1741291521;
				if (num2 != 0)
				{
				}
				num2 = (short)1569133098;
				short num4 = num2;
				num2 = (short)389943850;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_4C;
				default:
					goto IL_119;
				}
			}
			IL_119:
			num2 = (short)164167680;
			if (num2 != 0)
			{
			}
			commandBehaviorBase.Command = (A_1.NewValue as global::System.Windows.Input.ICommand);
			return;
			IL_1C:
			rmdataGrid = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)A_0;
			commandBehaviorBase = rmdataGrid.GetBehavior(typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridSelectedItemsChangedCommandBehavior));
			num2 = (short)557776898;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00007654 File Offset: 0x00005854
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid)
		{
			short num = (short)399421708;
			short num2 = num;
			num = (short)2116464908;
			switch (num2 == num)
			{
			}
			num = (short)43909121;
			if (num != 0)
			{
			}
			num = (short)646119424;
			if (num != 0)
			{
			}
			num = (short)584712192;
			short num3 = num;
			return dataGrid.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridSelectedItemsChanged.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000770C File Offset: 0x0000590C
		public static void SetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1310092655;
			short num2 = num;
			num = (short)597716335;
			switch (num2 == num)
			{
			default:
			{
				num = (short)270401536;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)310050817;
			if (num != 0)
			{
			}
			num = (short)1676279808;
			if (num != 0)
			{
			}
			dataGrid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridSelectedItemsChanged.CommandProperty, command);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000077C0 File Offset: 0x000059C0
		// Note: this type is marked as 'beforefieldinit'.
		static DataGridSelectedItemsChanged()
		{
			int a_ = 9;
			short num = (short)1092956152;
			short num2 = num;
			num = (short)535179256;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1756495872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1521156096;
			if (num != 0)
			{
			}
			num = (short)121503745;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridSelectedItemsChanged.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("戠䰢䠤䨦䠨䔪䤬", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridSelectedItemsChanged), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridSelectedItemsChanged.a)));
		}

		// Token: 0x0400001D RID: 29
		public static readonly global::System.Windows.DependencyProperty CommandProperty;
	}
}
