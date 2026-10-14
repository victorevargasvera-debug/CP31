using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000088 RID: 136
	public class ProfileRadioInfoViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROProfileRadioInfo>
	{
		// Token: 0x060003BE RID: 958 RVA: 0x00056DDC File Offset: 0x00054FDC
		public ProfileRadioInfoViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ProfileRadioInfoViewProvider(groupId), null, 500)
		{
		}
	}
}
