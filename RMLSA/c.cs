using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x0200000C RID: 12
	internal interface c
	{
		// Token: 0x0600003F RID: 63
		global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> a(global::Motorola.CommonCPS.Server.EntityModel.EntitlementList A_0, string A_1);

		// Token: 0x06000040 RID: 64
		global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense c(global::Motorola.CommonCPS.Server.EntityModel.FeatureList A_0, global::Motorola.CommonCPS.Server.EntityModel.FeatureItem A_1);
	}
}
