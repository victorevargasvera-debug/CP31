using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200005D RID: 93
	public class ASTROOtarProfileRadioInfoViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROOtarProfileRadioInfo>
	{
		// Token: 0x0600033E RID: 830 RVA: 0x0004FE98 File Offset: 0x0004E098
		public ASTROOtarProfileRadioInfoViewCache(global::System.Guid? groupId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROOtarProfileRadioInfoViewProvider(groupId), null, 500)
		{
		}
	}
}
