using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000AE RID: 174
	public class TemplateViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
	{
		// Token: 0x0600041E RID: 1054 RVA: 0x0005B590 File Offset: 0x00059790
		public TemplateViewCache() : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.TemplateViewProvider(), null, 500)
		{
		}
	}
}
