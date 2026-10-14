using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200008A RID: 138
	public class ProfileToRadioViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x060003C3 RID: 963 RVA: 0x000571BC File Offset: 0x000553BC
		public ProfileToRadioViewCache(global::System.Guid? groupId, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileInfo profileInfo) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ProfileToRadioViewProvider(groupId, profileInfo), null, 500)
		{
		}
	}
}
