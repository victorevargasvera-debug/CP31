using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200009B RID: 155
	public class LanguagePackViewCache : global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguagePack>
	{
		// Token: 0x060003F1 RID: 1009 RVA: 0x00059660 File Offset: 0x00057860
		public LanguagePackViewCache() : base(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.LanguagePack, null)
		{
		}
	}
}
