using System;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200003C RID: 60
	public class ShowRadioConversionDialogCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000254 RID: 596 RVA: 0x0001F29C File Offset: 0x0001D49C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)250000477;
			short num2 = num;
			num = (short)36615261;
			switch (num2 == num)
			{
			default:
			{
				num = (short)953810944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1366622209;
			if (num != 0)
			{
			}
			num = (short)1403453440;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext radioConversionContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.RadioConversionContext();
			radioConversionContext.Radios = new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioViewCache(new global::Motorola.CommonCPS.RadioManagement.UIModels.Group(), global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template);
			base.Interaction.ShowRadioConversionDialog(radioConversionContext);
			return true;
		}
	}
}
