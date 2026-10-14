using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000042 RID: 66
	internal class d : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x06000231 RID: 561 RVA: 0x00028B40 File Offset: 0x00026D40
		public d()
		{
			this.a = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance;
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00028B60 File Offset: 0x00026D60
		public d(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00028B7C File Offset: 0x00026D7C
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)1765429609;
			short num2 = num;
			num = (short)1925402985;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1323040768;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1871118336;
			if (num != 0)
			{
			}
			num = (short)1671757825;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Create(this.a).UIValidateService.ValidateDeviceModel((global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)uiModel);
		}

		// Token: 0x0400006A RID: 106
		private readonly global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer a;
	}
}
