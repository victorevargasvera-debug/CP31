using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000094 RID: 148
	internal class UpdateRadioFeatureCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600037E RID: 894 RVA: 0x00037874 File Offset: 0x00035A74
		protected override object ExecuteCmd(params object[] paras)
		{
			short num;
			try
			{
				num = (short)1792326191;
				short num2 = num;
				num = (short)201243183;
				switch (num2 == num)
				{
				}
				num = (short)362086400;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase radioLicenseBase = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioLicenseBase;
				string comments = paras[2].ToString();
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioLicenseService.UpdateRadioFeatureComments(radioLicenseBase.RadioLicenseUuid, comments);
				radioLicenseBase.Comments = comments;
			}
			catch
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError);
			}
			num = (short)576847873;
			if (num != 0)
			{
			}
			num = (short)2123104256;
			short num3 = num;
			return null;
		}
	}
}
