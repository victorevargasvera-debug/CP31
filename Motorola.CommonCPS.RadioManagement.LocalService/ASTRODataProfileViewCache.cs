using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000059 RID: 89
	public class ASTRODataProfileViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x06000334 RID: 820 RVA: 0x0004F614 File Offset: 0x0004D814
		public ASTRODataProfileViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTRODataProfileViewProvider(groupId), null, 500)
		{
		}
	}
}
