using System;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200003D RID: 61
	public class ShowTemplateConversionDialogCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000256 RID: 598 RVA: 0x0001F384 File Offset: 0x0001D584
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)890754139;
			short num2 = num;
			num = (short)288478299;
			switch (num2 == num)
			{
			default:
			{
				num = (short)991625216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)423428096;
			if (num != 0)
			{
			}
			num = (short)1479540737;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext templateConversionContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateConversionContext();
			templateConversionContext.Templates = new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateViewCache();
			base.Interaction.ShowTemplateConversionDialog(templateConversionContext);
			return true;
		}
	}
}
