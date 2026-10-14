using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200000E RID: 14
	public static class FieldCheckChanged
	{
		// Token: 0x06000029 RID: 41 RVA: 0x000048B0 File Offset: 0x00002AB0
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)774569985;
			if (num != 0)
			{
			}
			num = (short)1429078498;
			short num2 = num;
			num = (short)966984162;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B4;
			case 1:
				break;
			default:
			{
				num = (short)142802944;
				short num3 = num;
				break;
			}
			}
			num = (short)1868234752;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.Editors.XamCheckEditor xamCheckEditor = (global::Infragistics.Windows.Editors.XamCheckEditor)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChangedCommandBehavior fieldCheckChangedCommandBehavior = xamCheckEditor.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged.a) as global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChangedCommandBehavior;
			if (fieldCheckChangedCommandBehavior != null)
			{
				fieldCheckChangedCommandBehavior.Command = (A_1.NewValue as global::System.Windows.Input.ICommand);
				return;
			}
			IL_B4:
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChangedCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChangedCommandBehavior(xamCheckEditor)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			xamCheckEditor.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged.a, value);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000049AC File Offset: 0x00002BAC
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Windows.Editors.XamCheckEditor checkBox)
		{
			short num = (short)1033561410;
			short num2 = num;
			num = (short)770106690;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1018036224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1873870848;
			if (num != 0)
			{
			}
			num = (short)2059010049;
			if (num != 0)
			{
			}
			return checkBox.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00004A68 File Offset: 0x00002C68
		public static void SetCommand(global::Infragistics.Windows.Editors.XamCheckEditor checkBox, global::System.Windows.Input.ICommand command)
		{
			short num = (short)410801442;
			short num2 = num;
			num = (short)1064195362;
			switch (num2 == num)
			{
			default:
			{
				num = (short)308412416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1128005633;
			if (num != 0)
			{
			}
			num = (short)1138360320;
			if (num != 0)
			{
			}
			checkBox.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged.CommandProperty, command);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004B1C File Offset: 0x00002D1C
		// Note: this type is marked as 'beforefieldinit'.
		static FieldCheckChanged()
		{
			int a_ = 3;
			short num = (short)134891929;
			short num2 = num;
			num = (short)101403033;
			switch (num2 == num)
			{
			default:
			{
				num = (short)655556608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)689045505;
			if (num != 0)
			{
			}
			num = (short)1003421696;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("堚爜爞䰠䈢䬤䌦", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged.a = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("崚琜稞䴠䜢昤伦䰨䠪䘬䨮唰瀲娴娶吸娺匼嬾̀♂ⵄ♆㽈≊≌㵎", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChangedCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldCheckChanged), null);
		}

		// Token: 0x0400000C RID: 12
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400000D RID: 13
		private static readonly global::System.Windows.DependencyProperty a;
	}
}
