using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000007 RID: 7
	public class ComboBoxSelectSetRequested
	{
		// Token: 0x06000012 RID: 18 RVA: 0x00002F94 File Offset: 0x00001194
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)784845853;
			short num2 = num;
			num = (short)807914525;
			switch (num2 == num)
			{
			default:
			{
				num = (short)92340224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)800653313;
			if (num != 0)
			{
			}
			num = (short)1042022400;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequestedCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequestedCommandBehavior(xamComboEditor)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			xamComboEditor.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequested.aProperty, value);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003068 File Offset: 0x00001268
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor)
		{
			short num = (short)34603009;
			if (num != 0)
			{
			}
			num = (short)283246592;
			short num2 = num;
			num = (short)1398686599;
			short num3 = num;
			num = (short)652034951;
			switch (num3 == num)
			{
			}
			num = (short)501743616;
			if (num != 0)
			{
			}
			return xamComboEditor.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequested.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003124 File Offset: 0x00001324
		public static void SetCommand(global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor, global::System.Windows.Input.ICommand command)
		{
			short num = (short)946069909;
			short num2 = num;
			num = (short)309977493;
			switch (num2 == num)
			{
			default:
			{
				num = (short)699334656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)931987457;
			if (num != 0)
			{
			}
			num = (short)1469906944;
			if (num != 0)
			{
			}
			xamComboEditor.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequested.CommandProperty, command);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000031F0 File Offset: 0x000013F0
		// Note: this type is marked as 'beforefieldinit'.
		static ComboBoxSelectSetRequested()
		{
			int a_ = 9;
			short num = (short)1774803604;
			short num2 = num;
			num = (short)1333287572;
			switch (num2 == num)
			{
			default:
			{
				num = (short)773521408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)562561025;
			if (num != 0)
			{
			}
			num = (short)827981824;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequested.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("戠䰢䠤䨦䠨䔪䤬", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequested), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequested.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequested.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䀠", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequestedCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.ComboBoxSelectSetRequested), null);
		}

		// Token: 0x04000006 RID: 6
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000007 RID: 7
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
