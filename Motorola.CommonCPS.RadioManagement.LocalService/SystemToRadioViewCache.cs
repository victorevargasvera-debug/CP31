using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000A4 RID: 164
	public class SystemToRadioViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x06000403 RID: 1027 RVA: 0x0005A230 File Offset: 0x00058430
		public SystemToRadioViewCache(global::System.Guid? groupId, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROSystemInfo sysInfo) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.SystemToRadioViewProvider(groupId, sysInfo), null, 500)
		{
		}
	}
}
