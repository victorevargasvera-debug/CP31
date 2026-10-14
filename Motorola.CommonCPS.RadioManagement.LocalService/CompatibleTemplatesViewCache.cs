using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000084 RID: 132
	public class CompatibleTemplatesViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
	{
		// Token: 0x060003B4 RID: 948 RVA: 0x00056778 File Offset: 0x00054978
		public CompatibleTemplatesViewCache(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.CompatibleTemplatesViewProvider(radioUUIDList), null, 500)
		{
		}
	}
}
