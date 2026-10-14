using System;
using System.Windows;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000019 RID: 25
	public static class SetPresenterSelectSetRequested
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000067A8 File Offset: 0x000049A8
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1550231560;
			short num2 = num;
			num = (short)1278584840;
			switch (num2 == num)
			{
			}
			num = (short)1713831936;
			if (num != 0)
			{
			}
			num = (short)510328833;
			if (num != 0)
			{
			}
			num = (short)270991360;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter rmsetPresenter = (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequestedCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequestedCommandBehavior(rmsetPresenter)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			rmsetPresenter.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequested.aProperty, value);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000687C File Offset: 0x00004A7C
		public static global::System.Windows.Input.ICommand GetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter setPresenter)
		{
			short num = (short)1052882630;
			short num2 = num;
			num = (short)1485485766;
			switch (num2 == num)
			{
			}
			num = (short)1484980225;
			if (num != 0)
			{
			}
			num = (short)806420480;
			if (num != 0)
			{
			}
			num = (short)547291136;
			short num3 = num;
			return setPresenter.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequested.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006938 File Offset: 0x00004B38
		public static void SetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter setPresenter, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1003934057;
			short num2 = num;
			num = (short)265671017;
			switch (num2 == num)
			{
			}
			num = (short)1188560897;
			if (num != 0)
			{
			}
			num = (short)2023882752;
			if (num != 0)
			{
			}
			num = (short)1253834752;
			short num3 = num;
			setPresenter.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequested.CommandProperty, command);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000069EC File Offset: 0x00004BEC
		// Note: this type is marked as 'beforefieldinit'.
		static SetPresenterSelectSetRequested()
		{
			int a_ = 8;
			short num = (short)1496524659;
			short num2 = num;
			num = (short)275457907;
			switch (num2 == num)
			{
			}
			num = (short)1759117313;
			if (num != 0)
			{
			}
			num = (short)912916480;
			if (num != 0)
			{
			}
			num = (short)331546624;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequested.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("挟䴡䤣䬥䤧䐩䠫", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequested), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequested.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequested.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䄟", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequestedCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterSelectSetRequested), null);
		}

		// Token: 0x04000017 RID: 23
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000018 RID: 24
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
