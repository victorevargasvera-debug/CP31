using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200003D RID: 61
	public interface IASTROSystemService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060005E2 RID: 1506
		global::Motorola.CommonCPS.Server.EntityModel.APXRadio GetASTRORadioRawData(global::System.Guid deviceID, bool deepLoad = true);

		// Token: 0x060005E3 RID: 1507
		global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystemSummary EditSystemFields(global::Motorola.CommonCPS.Server.EntityModel.Radio apxRadio, global::System.Guid? systemID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioSystemFieldType, object>> fieldValues);

		// Token: 0x060005E4 RID: 1508
		bool ValidateASTROIndividualId(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem radioSys, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxCpg, string modelnumber, out string error);
	}
}
