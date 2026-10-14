using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000043 RID: 67
	internal class e : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00028C44 File Offset: 0x00026E44
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)271048040;
			short num2 = num;
			num = (short)90496360;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1387397120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1714880513;
			if (num != 0)
			{
			}
			num = (short)244645888;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService.ValidateTemplateModel((global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)uiModel);
			global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService.ValidateDVRSHashDVRSFile((global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase)uiModel);
		}
	}
}
