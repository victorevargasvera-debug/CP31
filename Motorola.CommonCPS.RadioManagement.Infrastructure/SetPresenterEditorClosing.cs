using System;
using System.Windows;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200001D RID: 29
	public static class SetPresenterEditorClosing
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000070C4 File Offset: 0x000052C4
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)651270076;
			short num2 = num;
			num = (short)1403033532;
			switch (num2 == num)
			{
			}
			num = (short)633339904;
			if (num != 0)
			{
			}
			num = (short)601161729;
			if (num != 0)
			{
			}
			num = (short)2145648640;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter rmsetPresenter = (global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosingCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosingCommandBehavior(rmsetPresenter)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			rmsetPresenter.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosing.aProperty, value);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007198 File Offset: 0x00005398
		public static global::System.Windows.Input.ICommand GetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter setPresenter)
		{
			short num = (short)110649758;
			short num2 = num;
			num = (short)1399546270;
			switch (num2 == num)
			{
			}
			num = (short)93847552;
			if (num != 0)
			{
			}
			num = (short)1100218369;
			if (num != 0)
			{
			}
			num = (short)1148387328;
			short num3 = num;
			return setPresenter.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosing.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007254 File Offset: 0x00005454
		public static void SetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMSetPresenter setPresenter, global::System.Windows.Input.ICommand command)
		{
			short num = (short)2016707255;
			short num2 = num;
			num = (short)813859511;
			switch (num2 == num)
			{
			}
			num = (short)418971648;
			if (num != 0)
			{
			}
			num = (short)502005761;
			if (num != 0)
			{
			}
			num = (short)1780809728;
			short num3 = num;
			setPresenter.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosing.CommandProperty, command);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007308 File Offset: 0x00005508
		// Note: this type is marked as 'beforefieldinit'.
		static SetPresenterEditorClosing()
		{
			int a_ = 12;
			short num = (short)1292966664;
			short num2 = num;
			num = (short)320871176;
			switch (num2 == num)
			{
			}
			num = (short)1944059904;
			if (num != 0)
			{
			}
			num = (short)382468097;
			if (num != 0)
			{
			}
			num = (short)75038720;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosing.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("朣䤥䔧䜩䴫䀭启", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosing), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosing.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosing.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䔣", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosingCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.SetPresenterEditorClosing), null);
		}

		// Token: 0x0400001B RID: 27
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400001C RID: 28
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
