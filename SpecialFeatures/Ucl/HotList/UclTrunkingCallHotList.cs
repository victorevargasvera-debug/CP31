using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E8 RID: 488
	[global::System.Serializable]
	public class UclTrunkingCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600177C RID: 6012 RVA: 0x001FF4B4 File Offset: 0x001FD6B4
		internal UclTrunkingCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풔쒖춘즚튜뾞鎠隢薤\udba8\udeaa쎬쒮\ud8b0\uddb2튴鞶풺즼龾跀ꫂ뛄돆", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요ﲘﺞ춠삤욦\udda8\udeaa\udfac쪮슰袲\ud8b6풸쮺튼톾꓀귂뇄諈꫊ꇌꏎ鿒볔ꓖ귘ﯚ黜냞迠藢賤胦鳨駪賬鯮飰鳲鯴\ud8f6뇸铺觼돾栀瀂焄⠆專栊愌嬎挐昒笔簖瀘甚稜尞䀠伢䤤漦䘨弪愬䘮䈰䜲攴嘶常帺ጼ䜾⁀⹂⥄", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListHotListSection(this));
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600177D RID: 6013 RVA: 0x001FF510 File Offset: 0x001FD710
		public global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListHotListSection TrunkingCallHotList
		{
			get
			{
				short num = (short)934346752;
				short num2 = num;
				num = (short)1029767169;
				if (num != 0)
				{
				}
				num = (short)80610507;
				short num3 = num;
				num = (short)1946879179;
				switch (num3 == num)
				{
				}
				num = (short)188743680;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.UclTrunkingCallHotListHotListSection)base[10415];
			}
		}

		// Token: 0x0600177E RID: 6014 RVA: 0x001FF5CC File Offset: 0x001FD7CC
		protected UclTrunkingCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲒ", a_));
			}
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌\udc8e얐솒\uda94랖ꮘ꺚붜쮞펠횢쮤첦삨얪쪬辮聆\udcb2솴鞶튺캼쮾", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8cﾎﲔ\udd9aﺞ햠횢힤슦\udaa8邪삮\udcb0쎲\udab4\ud9b6\udcb8햺즼邾苀ꋂ꧄ꯆ蟊꓌볎ꗐ雔룖럘뷚드룞铠釢蓤鏦胨蓪菬샮맰鳲致믶郸裺觼탾吀怂椄匆笈縊挌搎砐紒爔吖砘眚焜圞丠圢椤並娨弪紬丮嘰嘲᬴伶堸嘺儼", a_);
		}
	}
}
