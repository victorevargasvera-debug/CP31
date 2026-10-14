using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200006E RID: 110
	public class AppLicenseViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureInfo>
	{
		// Token: 0x06000369 RID: 873 RVA: 0x0005227C File Offset: 0x0005047C
		public AppLicenseViewCache() : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.AppLicenseViewProvider(), null, 500)
		{
		}
	}
}
