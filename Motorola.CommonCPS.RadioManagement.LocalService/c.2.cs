using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000041 RID: 65
	internal class c : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00028A6C File Offset: 0x00026C6C
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase astroSystem, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)1896324137;
			short num2 = num;
			num = (short)734108713;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1863122944;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)749142016;
			if (num != 0)
			{
			}
			num = (short)1918500865;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.GetInstance(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance).ValidateRadioSystemModel((global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem)astroSystem);
		}
	}
}
