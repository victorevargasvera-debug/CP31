using System;
using System.Windows;
using System.Windows.Input;
using Infragistics.Windows.Editors;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000010 RID: 16
	public static class FieldSelectedChanged
	{
		// Token: 0x0600002F RID: 47 RVA: 0x00004E58 File Offset: 0x00003058
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)279726437;
			short num2 = num;
			num = (short)2114341221;
			switch (num2 == num)
			{
			default:
			{
				num = (short)992411648;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)635568129;
			if (num != 0)
			{
			}
			num = (short)1578631168;
			if (num != 0)
			{
			}
			global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor = (global::Infragistics.Windows.Editors.XamComboEditor)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChangedCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChangedCommandBehavior(xamComboEditor)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			xamComboEditor.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChanged.aProperty, value);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004F28 File Offset: 0x00003128
		public static global::System.Windows.Input.ICommand GetCommand(global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor)
		{
			short num = (short)153167998;
			short num2 = num;
			num = (short)918497406;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1723858944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)142278657;
			if (num != 0)
			{
			}
			num = (short)2016477184;
			if (num != 0)
			{
			}
			return xamComboEditor.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChanged.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004FE0 File Offset: 0x000031E0
		public static void SetCommand(global::Infragistics.Windows.Editors.XamComboEditor xamComboEditor, global::System.Windows.Input.ICommand command)
		{
			short num = (short)511900297;
			short num2 = num;
			num = (short)604895881;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1441333248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)193855489;
			if (num != 0)
			{
			}
			num = (short)1389821952;
			if (num != 0)
			{
			}
			xamComboEditor.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChanged.CommandProperty, command);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005094 File Offset: 0x00003294
		// Note: this type is marked as 'beforefieldinit'.
		static FieldSelectedChanged()
		{
			int a_ = 8;
			short num = (short)403851370;
			short num2 = num;
			num = (short)2014398570;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1238302720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)34471937;
			if (num != 0)
			{
			}
			num = (short)74776576;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChanged.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("挟䴡䤣䬥䤧䐩䠫", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChanged), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChanged.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChanged.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䄟", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChangedCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.FieldSelectedChanged), null);
		}

		// Token: 0x0400000E RID: 14
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400000F RID: 15
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
