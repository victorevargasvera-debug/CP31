using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000015 RID: 21
	public static class ListBoxSelectionChanged
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00005E1C File Offset: 0x0000401C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1668651048;
			short num2 = num;
			num = (short)1480038440;
			switch (num2 == num)
			{
			}
			num = (short)552009728;
			short num3 = num;
			num = (short)1627062273;
			if (num != 0)
			{
			}
			num = (short)167247872;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.ListBox listBox = (global::System.Windows.Controls.ListBox)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChangedCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChangedCommandBehavior(listBox)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			listBox.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChanged.a, value);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00005EF0 File Offset: 0x000040F0
		public static global::System.Windows.Input.ICommand GetCommand(global::System.Windows.Controls.ListBox listBox)
		{
			short num = (short)718678482;
			short num2 = num;
			num = (short)2042322;
			switch (num2 == num)
			{
			}
			num = (short)1143603200;
			short num3 = num;
			num = (short)467140609;
			if (num != 0)
			{
			}
			num = (short)1108082688;
			if (num != 0)
			{
			}
			return listBox.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChanged.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00005FA8 File Offset: 0x000041A8
		public static void SetCommand(global::System.Windows.Controls.ListBox listBox, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1127897492;
			short num2 = num;
			num = (short)1921145236;
			switch (num2 == num)
			{
			}
			num = (short)1164836864;
			short num3 = num;
			num = (short)994508800;
			if (num != 0)
			{
			}
			num = (short)578748417;
			if (num != 0)
			{
			}
			listBox.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChanged.CommandProperty, command);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006060 File Offset: 0x00004260
		// Note: this type is marked as 'beforefieldinit'.
		static ListBoxSelectionChanged()
		{
			int a_ = 2;
			short num = (short)1794723091;
			short num2 = num;
			num = (short)665472275;
			switch (num2 == num)
			{
			}
			num = (short)1593442304;
			short num3 = num;
			num = (short)600571904;
			if (num != 0)
			{
			}
			num = (short)2017525761;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChanged.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("夙猛猝䴟䌡䨣䈥", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChanged), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChanged.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChanged.a = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("尙甛笝䰟䘡朣严䴧䤩䜫䬭启焱嬳嬵唷嬹刻娽ȿ❁ⱃ❅㹇⍉⍋㱍", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChangedCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ListBoxSelectionChanged), null);
		}

		// Token: 0x04000013 RID: 19
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000014 RID: 20
		private static readonly global::System.Windows.DependencyProperty a;
	}
}
