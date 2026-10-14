using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001D1 RID: 465
	[global::System.Serializable]
	public class UclAstroCallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06001696 RID: 5782 RVA: 0x001F2618 File Offset: 0x001F0818
		internal UclAstroCallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 3;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("입\udb87\ude89\ude8b속낏톑ﮓﾙ즟춡쪣장쒧誩솭쒯銱\udfb5쮷캹", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햅ﺑ튓聯얟톡龣잧잩\udcab솭\udeafힱ\udab3습鞷惡\uddbb튽겿裃꿅믇뻉跍뿏병닓뿕뿗꿙껛뿝铟诡诣裥쟧ꋩ菫髭볯鯱蟳苵ퟷ꿹鿻鋽䇿焁瀃琅朇䤉洋戍簏娑笓戕吗猙漛樝瀟䌡䌣䌥ا利䴫䌭尯", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListHotListSection(this));
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001697 RID: 5783 RVA: 0x001F2674 File Offset: 0x001F0874
		public global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListHotListSection AstroCallHotList
		{
			get
			{
				short num = (short)1030323980;
				short num2 = num;
				num = (short)653491980;
				switch (num2 == num)
				{
				}
				num = (short)1262485504;
				short num3 = num;
				num = (short)690094080;
				if (num != 0)
				{
				}
				num = (short)207945729;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListHotListSection)base[10417];
			}
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x001F272C File Offset: 0x001F092C
		protected UclAstroCallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("입\udb87\ude89\ude8b속낏톑ﮓﾙ즟춡쪣장쒧誩솭쒯銱\udfb5쮷캹", a_);
			base.UIName = global::CommonResources.AppResources.ASTRO_Conventional_Hot_List;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햅ﺑ튓聯얟톡龣잧잩\udcab솭\udeafힱ\udab3습鞷惡\uddbb튽겿裃꿅믇뻉跍뿏병닓뿕뿗꿙껛뿝铟诡诣裥쟧ꋩ菫髭볯鯱蟳苵ퟷ꿹鿻鋽䇿焁瀃琅朇䤉洋戍簏娑笓戕吗猙漛樝瀟䌡䌣䌥ا利䴫䌭尯", a_);
		}
	}
}
