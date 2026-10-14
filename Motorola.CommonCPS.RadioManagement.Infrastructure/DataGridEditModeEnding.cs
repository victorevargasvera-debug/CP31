using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000021 RID: 33
	public static class DataGridEditModeEnding
	{
		// Token: 0x06000063 RID: 99 RVA: 0x000079C8 File Offset: 0x00005BC8
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)137035777;
			if (num != 0)
			{
			}
			num = (short)1202388992;
			short num2 = num;
			num = (short)1664006489;
			short num3 = num;
			num = (short)1123793241;
			switch (num3 == num)
			{
			}
			num = (short)1168048128;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid = (global::Infragistics.Windows.DataPresenter.XamDataGrid)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEndingCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEndingCommandBehavior(xamDataGrid)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			xamDataGrid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.aProperty, value);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007A9C File Offset: 0x00005C9C
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid)
		{
			short num = (short)1507822493;
			short num2 = num;
			num = (short)1479314333;
			switch (num2 == num)
			{
			default:
			{
				num = (short)952893440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1520500736;
			if (num != 0)
			{
			}
			num = (short)1549860865;
			if (num != 0)
			{
			}
			return dataGrid.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007B54 File Offset: 0x00005D54
		public static void SetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid dataGrid, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1035133131;
			short num2 = num;
			num = (short)2068897995;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1745879040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)287047681;
			if (num != 0)
			{
			}
			num = (short)950075392;
			if (num != 0)
			{
			}
			dataGrid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.CommandProperty, command);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007C0C File Offset: 0x00005E0C
		// Note: this type is marked as 'beforefieldinit'.
		static DataGridEditModeEnding()
		{
			int a_ = 14;
			short num = (short)2071137739;
			short num2 = num;
			num = (short)508825035;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2142699520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2125463553;
			if (num != 0)
			{
			}
			num = (short)1883832320;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("攥䜧䜩䄫伭帯嘱", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䜥", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEndingCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeEnding), null);
		}

		// Token: 0x0400001E RID: 30
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400001F RID: 31
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
