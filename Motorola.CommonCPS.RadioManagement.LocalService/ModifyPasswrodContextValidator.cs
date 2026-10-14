using System;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000038 RID: 56
	public class ModifyPasswrodContextValidator : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x06000213 RID: 531 RVA: 0x0002481C File Offset: 0x00022A1C
		public void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 19;
			short num = (short)1476329476;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("挬䨮䘰愲吴匶倸吺洼帾㉀あ㉄⡆㭈⽊", a_))
					{
						num = (short)996868098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				case 1:
					goto IL_5A;
				case 2:
				{
					global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService astrouivalidationService = global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService;
					string newRadioPasswordError = "";
					global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext modifyCodeplugPasswordContext;
					astrouivalidationService.ValidatePassWord(modifyCodeplugPasswordContext.NewRadioPassword, out newRadioPasswordError);
					modifyCodeplugPasswordContext.NewRadioPasswordError = newRadioPasswordError;
					num = (short)2071330819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					goto IL_9E;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				}
				IL_42:
				if (e == null)
				{
					num = (short)1581842433;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext modifyCodeplugPasswordContext = uiModel as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROModifyCodeplugPasswordContext;
					num = (short)450953216;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_5A:
			return;
			IL_9E:
			IL_F7:
			num = (short)670438021;
			short num3 = num;
			num = (short)541594245;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num = (short)1241776128;
				if (num != 0)
				{
				}
				num = (short)653459457;
				if (num != 0)
				{
				}
				num = (short)1235615744;
				short num4 = num;
				return;
			}
			}
		}
	}
}
