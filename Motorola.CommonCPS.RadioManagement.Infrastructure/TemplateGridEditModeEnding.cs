using System;
using System.Windows;
using System.Windows.Input;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200001B RID: 27
	public static class TemplateGridEditModeEnding
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00006BEC File Offset: 0x00004DEC
		public static global::System.Windows.Input.ICommand GetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList templateList)
		{
			short num = (short)887294142;
			short num2 = num;
			num = (short)1368000702;
			switch (num2 == num)
			{
			}
			num = (short)1665728512;
			if (num != 0)
			{
			}
			num = (short)690946049;
			if (num != 0)
			{
			}
			num = (short)934150144;
			short num3 = num;
			return templateList.GetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEnding.CommandProperty) as global::System.Windows.Input.ICommand;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006CA8 File Offset: 0x00004EA8
		public static void SetCommand(global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList templateList, global::System.Windows.Input.ICommand command)
		{
			short num = (short)2139930538;
			short num2 = num;
			num = (short)141213610;
			switch (num2 == num)
			{
			}
			num = (short)841940993;
			if (num != 0)
			{
			}
			num = (short)1358757888;
			if (num != 0)
			{
			}
			num = (short)1328349184;
			short num3 = num;
			templateList.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEnding.CommandProperty, command);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006D5C File Offset: 0x00004F5C
		private static void a(global::System.Windows.DependencyObject A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			short num = (short)1823048024;
			short num2 = num;
			num = (short)1668186456;
			switch (num2 == num)
			{
			}
			num = (short)1770258433;
			if (num != 0)
			{
			}
			num = (short)1328152576;
			if (num != 0)
			{
			}
			num = (short)1062207488;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList rmtemplateList = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTemplateList)A_0;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEndingCommandBehavior value = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEndingCommandBehavior(rmtemplateList)
			{
				Command = (A_1.NewValue as global::System.Windows.Input.ICommand)
			};
			rmtemplateList.SetValue(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEnding.aProperty, value);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006E30 File Offset: 0x00005030
		// Note: this type is marked as 'beforefieldinit'.
		static TemplateGridEditModeEnding()
		{
			int a_ = 12;
			short num = (short)1790729435;
			short num2 = num;
			num = (short)149445851;
			switch (num2 == num)
			{
			}
			num = (short)1662189569;
			if (num != 0)
			{
			}
			num = (short)1665073152;
			if (num != 0)
			{
			}
			num = (short)1970405376;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEnding.CommandProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("朣䤥䔧䜩䴫䀭启", a_), typeof(global::System.Windows.Input.ICommand), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEnding), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEnding.a)));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEnding.aProperty = global::System.Windows.DependencyProperty.RegisterAttached(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䔣", a_), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEndingCommandBehavior), typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.TemplateGridEditModeEnding));
		}

		// Token: 0x04000019 RID: 25
		public static readonly global::System.Windows.DependencyProperty CommandProperty;

		// Token: 0x0400001A RID: 26
		private static readonly global::System.Windows.DependencyProperty aProperty;
	}
}
