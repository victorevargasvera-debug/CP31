using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200008C RID: 140
	public class RadioToProfileViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x060003C8 RID: 968 RVA: 0x000575E4 File Offset: 0x000557E4
		public RadioToProfileViewCache(global::System.Guid radioUuid) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioToProfileViewProvider(radioUuid), null, 500)
		{
		}
	}
}
