using System;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000CB RID: 203
	internal class ASTROPrepareImportTemplateCommand : global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportTemplateCommand
	{
		// Token: 0x06000430 RID: 1072 RVA: 0x000478F4 File Offset: 0x00045AF4
		protected override void ExecuteCommand(global::Motorola.CommonCPS.RadioManagement.UIModels.ImportTemplatesContext context)
		{
			short num = (short)1989377569;
			short num2 = num;
			num = (short)733904417;
			switch (num2 == num)
			{
			}
			num = (short)884473857;
			if (num != 0)
			{
			}
			num = (short)1787166720;
			if (num != 0)
			{
			}
			num = (short)1226244096;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowImportTemplatesDialog(context);
		}
	}
}
