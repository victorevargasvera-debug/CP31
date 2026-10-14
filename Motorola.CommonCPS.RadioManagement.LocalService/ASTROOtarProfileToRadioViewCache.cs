using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200005F RID: 95
	public class ASTROOtarProfileToRadioViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x06000343 RID: 835 RVA: 0x00050280 File Offset: 0x0004E480
		public ASTROOtarProfileToRadioViewCache(global::System.Guid? groupId, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileInfo profileInfo) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileToRadioViewProvider(groupId, profileInfo), null, 50)
		{
		}
	}
}
