using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200007F RID: 127
	public class PackageViewCache<T> : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<T> where T : global::Motorola.CommonCPS.RadioManagement.UIModels.PackageBase
	{
		// Token: 0x0600039C RID: 924 RVA: 0x00055138 File Offset: 0x00053338
		public PackageViewCache(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, global::Motorola.CommonCPS.RadioManagement.ViewCache.IFilter<T> filter = null) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewProvider<T>(type), filter, 500)
		{
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00055158 File Offset: 0x00053358
		public PackageViewCache(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType type, int? region) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewProvider<T>(type, region), null, 500)
		{
		}
	}
}
