using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000A0 RID: 160
	public class SystemInfoViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo>
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x00059AAC File Offset: 0x00057CAC
		public SystemInfoViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.SystemInfoViewProvider(groupId), null, 500)
		{
		}
	}
}
