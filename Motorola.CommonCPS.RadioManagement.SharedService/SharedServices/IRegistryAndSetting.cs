using System;
using System.Collections.Generic;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000B5 RID: 181
	public interface IRegistryAndSetting
	{
		// Token: 0x06000A83 RID: 2691
		string GetCurrentDisplayLanguage();

		// Token: 0x06000A84 RID: 2692
		global::System.Collections.Generic.IList<string> GetAllDisplayLanguage();

		// Token: 0x06000A85 RID: 2693
		string GetXferFolderPath();

		// Token: 0x06000A86 RID: 2694
		string GetLanguagePacksInstallPath(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac);

		// Token: 0x06000A87 RID: 2695
		string GetVoiceAnnouncementInstallPath(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType pac);

		// Token: 0x06000A88 RID: 2696
		string GetTextToSpeechInstallPath();

		// Token: 0x06000A89 RID: 2697
		global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetDefaultRegion();

		// Token: 0x06000A8A RID: 2698
		global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? GetRegion();
	}
}
