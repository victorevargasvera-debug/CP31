using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000A2 RID: 162
	public class SystemRadioInfoViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemRadioInfo>
	{
		// Token: 0x060003FE RID: 1022 RVA: 0x00059EB8 File Offset: 0x000580B8
		public SystemRadioInfoViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.SystemRadioInfoViewProvider(groupId), null, 500)
		{
		}
	}
}
