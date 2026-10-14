using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000AA RID: 170
	public class TemplateRelatedRadiosViewCacheForPCRUpgarde : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>
	{
		// Token: 0x06000413 RID: 1043 RVA: 0x0005AD98 File Offset: 0x00058F98
		public TemplateRelatedRadiosViewCacheForPCRUpgarde(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> templateList, global::System.Guid firmwareID, bool isAllowDowngrade) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateRelatedRadiosProviderForPCRUpgrade(templateList, firmwareID, isAllowDowngrade), null, 500)
		{
		}
	}
}
