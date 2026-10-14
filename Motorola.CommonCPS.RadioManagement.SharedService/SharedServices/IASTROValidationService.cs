using System;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200004F RID: 79
	public interface IASTROValidationService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IValidationServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600067B RID: 1659
		bool ValidatePassWord(string Password, out string err);

		// Token: 0x0600067C RID: 1660
		bool ValidateRadioIdRange(int? systemRadioId, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType systemType, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType systemSubType, bool expandedMDCIDRange, string codeplugVersion, out string error);

		// Token: 0x0600067D RID: 1661
		bool ValidateDateProfileValue(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxDataProfile, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cp, out string error);
	}
}
