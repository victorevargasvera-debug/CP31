using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200008E RID: 142
	public class GeneralPackageViewCache : global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.GeneralPackage>
	{
		// Token: 0x060003CD RID: 973 RVA: 0x00057A48 File Offset: 0x00055C48
		public GeneralPackageViewCache() : base(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.GeneralPackage, null)
		{
		}
	}
}
