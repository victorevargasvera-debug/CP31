using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000034 RID: 52
	public interface IRadioFeatureRequestProcessor
	{
		// Token: 0x06000578 RID: 1400
		void Process(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> radioLicenseRequestList);
	}
}
