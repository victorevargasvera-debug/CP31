using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E4 RID: 484
	[global::System.Serializable]
	public class UclQCIICallHotList : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06001758 RID: 5976 RVA: 0x001FDB88 File Offset: 0x001FBD88
		internal UclQCIICallHotList(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda8a캌욎\ud890뎒횔붜힞캠힢薤삨\ud8aa\ud9ac", a_);
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud88aﶌﲔﮖ\udf98ﺚﲜ풠톢삤풦銨슬슮솰\udcb2\udbb4튶ힸ쾺銼ﲾꃀ꿂꧄藈ꋊ뻌믎郒뫔맖뿘닚뫜꫞鏠苢釤軦蛨藪심꟮黰蟲맴黶諸迺틼꫾戀漂各䐆䀈䈊丌渎紐缒崔砖洘圚琜氞唠猢䐤䀦䰨Ԫ唬丮尰弲", a_);
			base.AddFeatureSection(new global::SpecialFeatures.Ucl.HotList.UclQCIICallHotListHotListSection(this));
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x001FDBDC File Offset: 0x001FBDDC
		public global::SpecialFeatures.Ucl.HotList.UclQCIICallHotListHotListSection QCIICallHotList
		{
			get
			{
				short num = (short)222167040;
				short num2 = num;
				num = (short)241303553;
				if (num != 0)
				{
				}
				num = (short)74230466;
				short num3 = num;
				num = (short)747154114;
				switch (num3 == num)
				{
				}
				num = (short)282198016;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Ucl.HotList.UclQCIICallHotListHotListSection)base[10425];
			}
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x001FDC98 File Offset: 0x001FBE98
		protected UclQCIICallHotList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_));
			}
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힅쮇쎉얋꺍펏歹뢗튙肟춣향\udca7", a_);
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햅ﺑ튓聯얟톡龣잧잩\udcab솭\udeafힱ\udab3습鞷惡\uddbb튽겿裃꿅믇뻉跍뿏병닓뿕뿗꿙껛뿝铟诡诣裥쟧ꋩ菫髭볯鯱蟳苵ퟷ꿹鿻鋽凿䄁䴃伅䬇欉怋戍堏紑怓娕焗椙栛丝䄟䔡䄣ࠥ倧䬩䄫䈭", a_);
		}
	}
}
