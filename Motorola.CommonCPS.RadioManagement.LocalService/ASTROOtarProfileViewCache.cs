using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000062 RID: 98
	public class ASTROOtarProfileViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x0600034B RID: 843 RVA: 0x000509FC File Offset: 0x0004EBFC
		public ASTROOtarProfileViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileViewProvider(groupId), null, 50)
		{
		}
	}
}
