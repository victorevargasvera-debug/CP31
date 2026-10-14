using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000093 RID: 147
	public class TemplateReferencedRadiosViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioOption>
	{
		// Token: 0x060003D7 RID: 983 RVA: 0x000580C4 File Offset: 0x000562C4
		public TemplateReferencedRadiosViewCache(global::System.Guid templateUuid) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateReferencedRadioProvider(templateUuid), null, 500)
		{
		}
	}
}
