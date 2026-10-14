using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000067 RID: 103
	public class ASTROSystemViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroSystem>
	{
		// Token: 0x06000358 RID: 856 RVA: 0x0005162C File Offset: 0x0004F82C
		public ASTROSystemViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROSystemViewProvider(groupId), null, 500)
		{
		}
	}
}
