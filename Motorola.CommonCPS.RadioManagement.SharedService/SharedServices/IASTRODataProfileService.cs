using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200003E RID: 62
	public interface IASTRODataProfileService : global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x060005E5 RID: 1509
		global::Motorola.CommonCPS.Server.EntityModel.APXDataProfileSummary EditDataProfileFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::System.Guid? DataProfileID, global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.ProfileFieldType, object>> fieldValues);
	}
}
