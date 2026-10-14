using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000040 RID: 64
	internal class b : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x0600022D RID: 557 RVA: 0x000288CC File Offset: 0x00026ACC
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 12;
			short num = (short)266076163;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)972029953;
					if (num != 0)
					{
					}
					num = (short)1634467842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_83;
				case 2:
				{
					if (!e.PropertyName.Equals(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("椥尧䬩師札琯", a_)))
					{
						return;
					}
					num = (short)1520107520;
					short num3 = num;
					num = (short)1562690499;
					short num4 = num;
					num = (short)402244547;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1711079424;
						if (num != 0)
						{
						}
						num = (short)892076033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 4:
					return;
				}
				IL_41:
				if (e != null)
				{
					num = (short)240779264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_83:
				global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.GetInstance(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance).ValidateOtarProfileModel((global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile)uiModel);
				num = (short)1002897412;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
