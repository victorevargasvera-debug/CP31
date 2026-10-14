using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001DB RID: 475
	[global::System.Serializable]
	public class UclMDCCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x060016FF RID: 5887 RVA: 0x001F8178 File Offset: 0x001F6378
		internal UclMDCCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc90힒횔랖\uda98쒠춢톤캦욨얪첬쎮醰﮲\udab4쎶馸풼첾뗀", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슐漢\ud99e쒠슢톤튦\udba8캪\udeac钮\udcb2\ud8b4잶횸햺\ud8bc톾뗀蛄ꛆꗈꟊ菎룐ꃒꇔ高듚돜맞裠蓢郤闦裨鿪蓬胮鿰\udcf2뷴飶跸럺铼賾甀Ⰲ倄搆攈䘊䤌䰎刐爒礔笖儘琚検匞䠠倢儤眦䠨䰪䠬Į䤰刲場嬶", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListHotListSection(this));
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001700 RID: 5888 RVA: 0x001F81D4 File Offset: 0x001F63D4
		public global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListHotListSection MDCCallHotList
		{
			get
			{
				short num = (short)1067742767;
				short num2 = num;
				num = (short)1049458223;
				switch (num2 == num)
				{
				}
				num = (short)672858112;
				if (num != 0)
				{
				}
				num = (short)533921793;
				if (num != 0)
				{
				}
				num = (short)1551892480;
				short num3 = num;
				return (global::SpecialFeatures.Ucl.HotList.UclMDCCallHotListHotListSection)base[10419];
			}
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x001F828C File Offset: 0x001F648C
		protected UclMDCCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲔ練ﾘ", a_));
			}
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud894펖\uda98뮚\ude9c쾠햢삤즦\udda8슪슬솮킰\udfb2閴ﾶ횸쾺鶼ꣀ냂뇄", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("요ﲘﺞ춠삤욦\udda8\udeaa\udfac쪮슰袲\ud8b6풸쮺튼톾꓀귂뇄諈꫊ꇌꏎ鿒볔ꓖ귘ﯚ黜냞迠藢賤胦鳨駪賬鯮飰鳲鯴\ud8f6뇸铺觼돾栀瀂焄⠆專栊愌䈎唐倒嘔瘖甘眚唜瀞唠漢䰤否崨笪䰬䠮吰ᴲ䴴嘶吸场", a_);
		}
	}
}
