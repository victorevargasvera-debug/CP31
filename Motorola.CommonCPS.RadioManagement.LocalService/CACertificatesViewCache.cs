using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200007E RID: 126
	public class CACertificatesViewCache : global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates>
	{
		// Token: 0x0600039B RID: 923 RVA: 0x00055120 File Offset: 0x00053320
		public CACertificatesViewCache(global::Motorola.CommonCPS.RadioManagement.ViewCache.IFilter<global::Motorola.CommonCPS.RadioManagement.UIModels.CACertificates> filter = null) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.CACertificates, filter)
		{
		}
	}
}
