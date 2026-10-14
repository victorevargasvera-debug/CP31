using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000080 RID: 128
	internal class i : global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles>
	{
		// Token: 0x0600039E RID: 926 RVA: 0x00055178 File Offset: 0x00053378
		public i(global::Motorola.CommonCPS.RadioManagement.ViewCache.IFilter<global::Motorola.CommonCPS.RadioManagement.UIModels.DVRSFiles> A_0 = null) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.DVRSFiles, A_0)
		{
		}
	}
}
