using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x0200003A RID: 58
	[global::System.Serializable]
	public class SiteSelectableAlertTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060006E8 RID: 1768 RVA: 0x00066F7C File Offset: 0x0006517C
		public global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerSection SiteSelectableAlertTableInnerSection
		{
			get
			{
				short num = (short)1495183667;
				short num2 = num;
				num = (short)630829363;
				switch (num2 == num)
				{
				}
				num = (short)947388416;
				if (num != 0)
				{
				}
				num = (short)1327104000;
				short num3 = num;
				num = (short)177078273;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerSection)base[10766];
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00067034 File Offset: 0x00065234
		public SiteSelectableAlertTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udf8b뒓얕ﶗ鍊ﶝ풟쎡욣쪥춧誩슭햯삱삳隵\udbb9\udebb튽ꖿ", a_);
			base.UIName = global::CommonResources.AppResources.ID_SITESELECTABLEALERTTABLE;
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerSection section = new global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x00067080 File Offset: 0x00065280
		protected SiteSelectableAlertTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요ﺖﺚ붜첞쒠쾢삤쒦\udda8쪪쾬쎮풰鎲\udbb6\udcb8즺즼龾闀ꋂꟄꯆ곈", a_);
		}
	}
}
