using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200009E RID: 158
	public class RadioToSystemViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x000596A8 File Offset: 0x000578A8
		public RadioToSystemViewCache(global::System.Guid radioUuid) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioToSystemViewProvider(radioUuid), null, 500)
		{
		}
	}
}
