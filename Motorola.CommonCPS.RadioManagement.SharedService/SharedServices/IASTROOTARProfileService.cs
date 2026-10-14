using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DataTransferObjects;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200000F RID: 15
	public interface IASTROOTARProfileService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x0600007F RID: 127
		global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.DataTransferObjects.APXOtarProfileDTO> EditOTARProfilesFields(global::Motorola.CommonCPS.Server.EntityModel.Radio apxRadio, global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.EntityModel.APXOtarProfile> otarProfiles, global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OtarFieldType, object> fieldValues);
	}
}
