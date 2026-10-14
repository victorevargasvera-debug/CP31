using System;
using System.Windows;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000018 RID: 24
	public static class RMTreeItemSelected
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00006448 File Offset: 0x00004648
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1343881217;
			if (num != 0)
			{
			}
			num = (short)186373412;
			short num2 = num;
			num = (short)2016990500;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1304363008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)362283008;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor rmtreeComboEditor = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeComboCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeComboCommandBehavior(rmtreeComboEditor)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			rmtreeComboEditor.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeItemSelected.aProperty, value);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000651C File Offset: 0x0000471C
		public static global::System.Windows.Input.ICommand GetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor editor)
		{
			short num = (short)795450961;
			short num2 = num;
			num = (short)737123921;
			switch (num2 == num)
			{
			}
			num = (short)1183776768;
			short num3 = num;
			num = (short)488046593;
			if (num != 0)
			{
			}
			num = (short)506658816;
			if (num != 0)
			{
			}
			return editor.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeItemSelected.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000065D8 File Offset: 0x000047D8
		public static void SetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMTreeComboEditor editor, global::System.Windows.Input.ICommand command)
		{
			short num = (short)1485533996;
			short num2 = num;
			num = (short)299987756;
			switch (num2 == num)
			{
			}
			num = (short)1680605185;
			if (num != 0)
			{
			}
			num = (short)635371520;
			if (num != 0)
			{
			}
			num = (short)1522139136;
			short num3 = num;
			editor.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeItemSelected.CommandProperty, command);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000668C File Offset: 0x0000488C
		// Note: this type is marked as 'beforefieldinit'.
		static RMTreeItemSelected()
		{
			int a_ = 7;
			short num = (short)1704994228;
			short num2 = num;
			num = (short)1376462260;
			switch (num2 == num)
			{
			}
			num = (short)473366528;
			if (num != 0)
			{
			}
			num = (short)1075052545;
			if (num != 0)
			{
			}
			num = (short)812580864;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeItemSelected.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("尞丠丢䠤䘦䜨伪", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeItemSelected), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeItemSelected.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeItemSelected.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("縞", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeComboCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.RMTreeItemSelected), null);
		}

		// Token: 0x04000015 RID: 21
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x04000016 RID: 22
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
