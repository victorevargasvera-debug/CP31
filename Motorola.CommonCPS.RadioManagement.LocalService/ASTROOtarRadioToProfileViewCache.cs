using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000065 RID: 101
	public class ASTROOtarRadioToProfileViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfile>
	{
		// Token: 0x06000353 RID: 851 RVA: 0x0005121C File Offset: 0x0004F41C
		public ASTROOtarRadioToProfileViewCache(global::System.Guid radioUuid) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarRadioToProfileViewProvider(radioUuid), null, 500)
		{
		}
	}
}
