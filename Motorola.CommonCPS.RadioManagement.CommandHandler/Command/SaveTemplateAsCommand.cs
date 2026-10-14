using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000D2 RID: 210
	internal class SaveTemplateAsCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000441 RID: 1089 RVA: 0x00048E14 File Offset: 0x00047014
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1747666610;
			short num2 = num;
			num = (short)449791666;
			switch (num2 == num)
			{
			}
			num = (short)88604672;
			if (num != 0)
			{
			}
			num = (short)1879572480;
			short num3 = num;
			num = (short)128909313;
			if (num != 0)
			{
			}
			return !string.IsNullOrEmpty((paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext).DefaultTemplateName.Trim());
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00048ED8 File Offset: 0x000470D8
		protected override object ExecuteCmd(params object[] paras)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext saveTemplateAsContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext;
			saveTemplateAsContext.DefaultTemplateName = saveTemplateAsContext.DefaultTemplateName.Trim();
			if (global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).CheckTemplateNameDuplicate(saveTemplateAsContext.DefaultTemplateName))
			{
				short num = (short)2012697352;
				short num2 = num;
				num = (short)48976648;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)503644161;
					if (num != 0)
					{
					}
					num = (short)1543176192;
					if (num != 0)
					{
					}
					num = (short)1968635904;
					short num3 = num;
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.CodeplugSaveAsDlg_DuplicateNameError);
				}
				}
			}
			saveTemplateAsContext.IsCancel = false;
			return true;
		}
	}
}
