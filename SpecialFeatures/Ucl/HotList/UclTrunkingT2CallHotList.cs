using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001ED RID: 493
	[global::System.Serializable]
	public class UclTrunkingT2CallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060017B6 RID: 6070 RVA: 0x00202FE8 File Offset: 0x002011E8
		internal UclTrunkingT2CallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얐릘튚풜뾞톢키즦슨슪쎬좮醰﮲\udab4쎶馸풼첾뗀", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮\udcb2\ud8b4잶횸햺\ud8bc톾뗀蛄ꛆꗈꟊ菎룐ꃒꇔ高듚돜맞裠蓢郤闦裨鿪蓬胮鿰\udcf2뷴飶跸럺铼賾甀Ⰲ倄搆攈弊缌税缐砒簔礖縘会⼜尞䀠伢䤤漦䘨弪愬䘮䈰䜲攴嘶常帺ጼ䜾⁀⹂⥄", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListHotListSection(this));
		}

		// Token: 0x1700072C RID: 1836
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00203044 File Offset: 0x00201244
		public global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListHotListSection TrunkingT2CallHotList
		{
			get
			{
				short num = (short)1325727744;
				short num2 = num;
				num = (short)610729985;
				if (num != 0)
				{
				}
				num = (short)1617157986;
				short num3 = num;
				num = (short)273866594;
				switch (num3 == num)
				{
				}
				num = (short)1310720;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.UclTrunkingT2CallHotListHotListSection)base[10421];
			}
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x00203100 File Offset: 0x00201300
		protected UclTrunkingT2CallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킃ﾅ겋잍\ud98f늑삓캟얡蒣잧\udea9貫\ud9af솱삳", a_);
			base.UIName = global::CommonResources.AppResources.Type_II_Trunking_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힃ﲏ풑ﮝ펟馡즥얧\udaa9쎫삭햯\udcb1삳馵﮷\udbb9킻튽軁귃뗅볇迋ꇍ뻏듑뷓뇕귗꣙뷛ꫝ觟跡諣짥ꃧ藩飫ꋭ駯臱胳\ud9f5귷駹郻꫽狿省樃洅愇搉欋娍∏儑甓稕琗则猛樝氟䬡圣別砧䬩䬫䬭ḯ䨱唳嬵吷", a_);
		}
	}
}
