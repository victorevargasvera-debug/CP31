using System;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000CD RID: 205
	internal class CancelSaveTemplateAsCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000435 RID: 1077 RVA: 0x00047D0C File Offset: 0x00045F0C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2007555417;
			short num2 = num;
			num = (short)1912331609;
			switch (num2 == num)
			{
			}
			num = (short)313786368;
			if (num != 0)
			{
			}
			num = (short)287506433;
			if (num != 0)
			{
			}
			num = (short)1435631616;
			short num3 = num;
			(paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SaveTemplateAsContext).IsCancel = true;
			return null;
		}
	}
}
