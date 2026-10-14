using System;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200005B RID: 91
	internal class WiFiPasswordValidationCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002E0 RID: 736 RVA: 0x0002B590 File Offset: 0x00029790
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1559775418;
			short num2 = num;
			num = (short)1224886458;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1860894720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1384579073;
			if (num != 0)
			{
			}
			num = (short)870645760;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0002B63C File Offset: 0x0002983C
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1067170463;
			short num2 = num;
			num = (short)1634974367;
			switch (num2 == num)
			{
			default:
			{
				num = (short)890175488;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1718222849;
			if (num != 0)
			{
			}
			num = (short)1472528384;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext wiFiPasswordValidationContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext;
			global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation astrowiFiPWDValidation = new global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation(wiFiPasswordValidationContext);
			wiFiPasswordValidationContext.IsValidationPass = astrowiFiPWDValidation.ValidatePWD();
			wiFiPasswordValidationContext.HasInvalidPWD = astrowiFiPWDValidation.HasInvalidPWD;
			if (wiFiPasswordValidationContext.HasInvalidPWD)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.WiFi_Clone_Warning);
			}
			return wiFiPasswordValidationContext.IsValidationPass;
		}
	}
}
