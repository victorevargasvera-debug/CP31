using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200003F RID: 63
	internal class a : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x0600022B RID: 555 RVA: 0x000287F8 File Offset: 0x000269F8
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)1015073177;
			short num2 = num;
			num = (short)608225689;
			switch (num2 == num)
			{
			default:
			{
				num = (short)65470464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1058275329;
			if (num != 0)
			{
			}
			num = (short)1209729024;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.GetInstance(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance).ValidateDataProfileModel((global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile)uiModel);
		}
	}
}
