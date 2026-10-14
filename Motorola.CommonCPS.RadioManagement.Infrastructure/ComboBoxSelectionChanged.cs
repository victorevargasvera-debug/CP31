using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000005 RID: 5
	public class ComboBoxSelectionChanged
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002ABC File Offset: 0x00000CBC
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1989706555;
			short num2 = num;
			num = (short)778797883;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1377042432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)31850497;
			if (num != 0)
			{
			}
			num = (short)703266816;
			if (num != 0)
			{
			}
			global::System.Windows.Controls.ComboBox comboBox = (global::System.Windows.Controls.ComboBox)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChangedCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChangedCommandBehavior(comboBox)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			comboBox.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChanged.aProperty, value);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B90 File Offset: 0x00000D90
		public static global::System.Windows.Input.ICommand GetCommand(global::System.Windows.Controls.ComboBox comboBox)
		{
			short num = (short)1442005534;
			short num2 = num;
			num = (short)519258654;
			switch (num2 == num)
			{
			default:
			{
				num = (short)839385088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1672806401;
			if (num != 0)
			{
			}
			num = (short)1317339136;
			if (num != 0)
			{
			}
			return comboBox.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChanged.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002C4C File Offset: 0x00000E4C
		public static void SetCommand(global::System.Windows.Controls.ComboBox comboBox, global::System.Windows.Input.ICommand command)
		{
			short num = (short)47693267;
			short num2 = num;
			num = (short)1042660819;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1641807872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2052456448;
			if (num != 0)
			{
			}
			num = (short)935591937;
			if (num != 0)
			{
			}
			comboBox.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChanged.CommandProperty, command);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002D18 File Offset: 0x00000F18
		// Note: this type is marked as 'beforefieldinit'.
		static ComboBoxSelectionChanged()
		{
			int a_ = 13;
			short num = (short)90104150;
			short num2 = num;
			num = (short)600564054;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1785462784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)678887425;
			if (num != 0)
			{
			}
			num = (short)2126315520;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChanged.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("昤䠦䐨䘪䰬䄮唰", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChanged), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChanged.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChanged.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䐤", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChangedCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectionChanged), null);
		}

		// Token: 0x04000004 RID: 4
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000005 RID: 5
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
