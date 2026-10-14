using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200000C RID: 12
	public class DataGridEditModeStarted
	{
		// Token: 0x06000022 RID: 34 RVA: 0x000042D8 File Offset: 0x000024D8
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid grid)
		{
			short num = (short)454262818;
			short num2 = num;
			num = (short)1372356642;
			switch (num2 == num)
			{
			}
			num = (short)1575813121;
			if (num != 0)
			{
			}
			num = (short)875954176;
			if (num != 0)
			{
			}
			num = (short)233046016;
			short num3 = num;
			return grid.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004390 File Offset: 0x00002590
		public static void SetCommand(global::Infragistics.Windows.DataPresenter.XamDataGrid grid, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1761496451;
			short num2 = num;
			num = (short)680217987;
			switch (num2 == num)
			{
			}
			num = (short)579600385;
			if (num != 0)
			{
			}
			num = (short)1636499456;
			if (num != 0)
			{
			}
			num = (short)1947992064;
			short num3 = num;
			grid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.CommandProperty, command);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004444 File Offset: 0x00002644
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1092839453;
			short num2 = num;
			num = (short)36464669;
			switch (num2 == num)
			{
			}
			num = (short)490864641;
			if (num != 0)
			{
			}
			num = (short)833224704;
			if (num != 0)
			{
			}
			num = (short)2090401792;
			short num3 = num;
			global::Infragistics.Windows.DataPresenter.XamDataGrid xamDataGrid = A_0 as global::Infragistics.Windows.DataPresenter.XamDataGrid;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStartedCommandBehavior dataGridEditModeStartedCommandBehavior = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStartedCommandBehavior(xamDataGrid);
			xamDataGrid.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.a, dataGridEditModeStartedCommandBehavior);
			dataGridEditModeStartedCommandBehavior.Command = (A_1.NewValue as global::System.Windows.Input.ICommand);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000452C File Offset: 0x0000272C
		// Note: this type is marked as 'beforefieldinit'.
		static DataGridEditModeStarted()
		{
			int a_ = 7;
			short num = (short)2003258344;
			short num2 = num;
			num = (short)1596279784;
			switch (num2 == num)
			{
			}
			num = (short)138739712;
			if (num != 0)
			{
			}
			num = (short)1102118913;
			if (num != 0)
			{
			}
			num = (short)1812594688;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("尞丠丢䠤䘦䜨伪", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted.a = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("嬞䀠圢䐤怦嬨䈪䤬樮唰娲䄴稶嘸强堼氾㕀≂㝄㍆ⱈ⽊์⁎㱐㹒㑔㥖㵘ᥚ㡜㝞`ᕢ౤ࡦ᭨", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStartedCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.DataGridEditModeStarted), null);
		}

		// Token: 0x0400000A RID: 10
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400000B RID: 11
		private static readonly global::System.Windows.DependencyProperty a;
	}
}
