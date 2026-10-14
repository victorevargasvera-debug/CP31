using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000A6 RID: 166
	public class TemplateRelatedRadiosViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateRadioPair>
	{
		// Token: 0x06000408 RID: 1032 RVA: 0x0005A5D4 File Offset: 0x000587D4
		public TemplateRelatedRadiosViewCache(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> templateList) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateRelatedRadiosProvider(templateList), null, 500)
		{
		}
	}
}
