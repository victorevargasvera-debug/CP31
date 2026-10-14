using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001D6 RID: 470
	[global::System.Serializable]
	public class UclDTMFCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060016D0 RID: 5840 RVA: 0x001F6104 File Offset: 0x001F4304
		internal UclDTMFCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톔쎖풘\udd9a붜\udc9e삠쾢즤螦쒪\ud9ac辮ﶰ\udab2운쎶", a_);
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요ﲘﺞ춠삤욦\udda8\udeaa\udfac쪮슰袲\ud8b6풸쮺튼톾꓀귂뇄諈꫊ꇌꏎ鿒볔ꓖ귘ﯚ黜냞迠藢賤胦鳨駪賬鯮飰鳲鯴\ud8f6뇸铺觼돾栀瀂焄⠆專栊愌䬎䔐帒匔吖砘眚焜圞丠圢椤並娨弪紬丮嘰嘲᬴伶堸嘺儼", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.UclDTMFCallHotListHotListSection(this));
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060016D1 RID: 5841 RVA: 0x001F6158 File Offset: 0x001F4358
		public global::SpecialFeatures.Ucl.HotList.UclDTMFCallHotListHotListSection DTMFCallHotList
		{
			get
			{
				short num = (short)317258016;
				short num2 = num;
				num = (short)258668832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1142816768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1056964609;
				if (num != 0)
				{
				}
				num = (short)1175257088;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.UclDTMFCallHotListHotListSection)base[10423];
			}
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x001F6210 File Offset: 0x001F4410
		protected UclDTMFCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶒ", a_));
			}
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햐잒\ud894톖릘\ud89aﲜ춠莢좦\udda8讪욮슰잲", a_);
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮\udcb2\ud8b4잶횸햺\ud8bc톾뗀蛄ꛆꗈꟊ菎룐ꃒꇔ高듚돜맞裠蓢郤闦裨鿪蓬胮鿰\udcf2뷴飶跸럺铼賾甀Ⰲ倄搆攈伊夌䈎圐倒琔笖甘匚爜欞洠䨢嘤匦礨䨪䨬䨮ἰ䬲吴娶唸", a_);
		}
	}
}
