using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000057 RID: 87
	public class ResetIdentifierValidationService : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x0600032A RID: 810 RVA: 0x0004EFFC File Offset: 0x0004D1FC
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService astrouivalidationService;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext resetIdentifiersContext;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (e == null)
					{
						num2 = (short)502792195;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string empty = string.Empty;
					num2 = (short)1868300289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("䰛缝匟儡匣䤥娧丩", a_))
					{
						num2 = (short)579010562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					string empty;
					astrouivalidationService.ValidatePassWord(resetIdentifiersContext.Password, out empty);
					resetIdentifiersContext.PasswordError = empty;
					num2 = (short)508526257;
					short num3 = num2;
					num2 = (short)1017216689;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1439170560;
						short num4 = num2;
						num2 = (short)1560870912;
						if (num2 != 0)
						{
						}
						num2 = (short)241762305;
						if (num2 != 0)
						{
						}
						num2 = (short)399704068;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					return;
				case 4:
					return;
				}
				goto IL_2D;
			}
			return;
			IL_2D:
			resetIdentifiersContext = (uiModel as global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext);
			astrouivalidationService = (global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService);
			num2 = (short)1058144256;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
