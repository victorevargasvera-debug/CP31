using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.Wide
{
	// Token: 0x02000018 RID: 24
	public static class LOVs
	{
		// Token: 0x0600008C RID: 140 RVA: 0x000107D4 File Offset: 0x0000E9D4
		// Note: this type is marked as 'beforefieldinit'.
		static LOVs()
		{
			int a_ = 6;
			short num = (short)460500244;
			short num2 = num;
			num = (short)1480174868;
			switch (num2 == num)
			{
			}
			num = (short)791674881;
			if (num != 0)
			{
			}
			num = (short)1644494848;
			if (num != 0)
			{
			}
			num = (short)2100756480;
			short num3 = num;
			global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.VoiceAnnouncementPriority_A76515LovStrs = new string[]
			{
				global::CommonResources.AcgResources.ID_LOW,
				global::CommonResources.AcgResources.ID_HIGH
			};
			global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.idVoiceAnnouncementPriority_A76515LovStrs = new string[]
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌쎎\ude90쒒", a_),
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삈쾊튌잎\ud890풒\udd94", a_)
			};
			global::SpecialFeatures.VoiceAnnouncements.Wide.LOVs.indexVoiceAnnouncementPriority_A76515LovStrs = new int[]
			{
				0,
				1
			};
		}

		// Token: 0x0400005D RID: 93
		public static string[] VoiceAnnouncementPriority_A76515LovStrs;

		// Token: 0x0400005E RID: 94
		public static string[] idVoiceAnnouncementPriority_A76515LovStrs;

		// Token: 0x0400005F RID: 95
		public static int[] indexVoiceAnnouncementPriority_A76515LovStrs;
	}
}
