using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200009D RID: 157
	public class VoiceAnnouncementViewCache : global::Motorola.CommonCPS.RadioManagement.LocalService.PackageViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement>
	{
		// Token: 0x060003F3 RID: 1011 RVA: 0x00059690 File Offset: 0x00057890
		public VoiceAnnouncementViewCache(global::Motorola.CommonCPS.RadioManagement.ViewCache.IFilter<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceAnnouncement> filter = null) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.VoiceAnnouncement, filter)
		{
		}
	}
}
