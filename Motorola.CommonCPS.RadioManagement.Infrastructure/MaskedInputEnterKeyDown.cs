using System;
using System.Windows;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000023 RID: 35
	public static class MaskedInputEnterKeyDown
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00007F18 File Offset: 0x00006118
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)534003275;
			short num2 = num;
			num = (short)2097692235;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1885143040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1159790592;
			if (num != 0)
			{
			}
			num = (short)1016987649;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput rmmaskedInput = (global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDownCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDownCommandBehavior(rmmaskedInput)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			rmmaskedInput.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDown.aProperty, value);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007FE8 File Offset: 0x000061E8
		public static global::System.Windows.Input.ICommand GetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput maskedInput)
		{
			short num = (short)2093871700;
			short num2 = num;
			num = (short)933491284;
			switch (num2 == num)
			{
			default:
			{
				num = (short)593297408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)722403328;
			if (num != 0)
			{
			}
			num = (short)1985544193;
			if (num != 0)
			{
			}
			return maskedInput.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDown.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000080A4 File Offset: 0x000062A4
		public static void SetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMMaskedInput maskedInput, global::System.Windows.Input.ICommand command)
		{
			short num = (short)2046635414;
			short num2 = num;
			num = (short)1703423382;
			switch (num2 == num)
			{
			default:
			{
				num = (short)642908160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)657260545;
			if (num != 0)
			{
			}
			num = (short)1792999424;
			if (num != 0)
			{
			}
			maskedInput.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDown.CommandProperty, command);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008158 File Offset: 0x00006358
		// Note: this type is marked as 'beforefieldinit'.
		static MaskedInputEnterKeyDown()
		{
			int a_ = 1;
			short num = (short)585940413;
			short num2 = num;
			num = (short)1177206205;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1287258112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1069744128;
			if (num != 0)
			{
			}
			num = (short)1433731073;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDown.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("娘琚瀜爞䀠䴢䄤", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDown), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDown.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDown.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("砘", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDownCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.MaskedInputEnterKeyDown), null);
		}

		// Token: 0x04000020 RID: 32
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000021 RID: 33
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
