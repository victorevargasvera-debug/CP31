using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000093 RID: 147
	internal class UpdateAppFeatureCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600037C RID: 892 RVA: 0x0003777C File Offset: 0x0003597C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)804536883;
			short num2 = num;
			num = (short)1833910835;
			switch (num2 == num)
			{
			}
			num = (short)328007680;
			short num3 = num;
			num = (short)17956865;
			if (num != 0)
			{
			}
			num = (short)591921152;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo featureInfo = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo;
			string text = paras[2].ToString();
			global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary entitySummary = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.AppLicenseService.UpdateAppLicense(featureInfo.EntitySummary, text);
			featureInfo.AppComments = text;
			featureInfo.EntitySummary = entitySummary;
			return null;
		}
	}
}
