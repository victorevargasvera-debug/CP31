using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001ED RID: 493
	[global::System.Serializable]
	public class TrunkingShepherdListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002C10 RID: 11280
		// (get) Token: 0x06005570 RID: 21872 RVA: 0x004D7AA0 File Offset: 0x004D5CA0
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerSection TrunkingShepherdListInnerSection
		{
			get
			{
				short num = (short)1970417384;
				short num2 = num;
				num = (short)1691496168;
				switch (num2 == num)
				{
				}
				num = (short)855703552;
				short num3 = num;
				num = (short)1094123521;
				if (num != 0)
				{
				}
				num = (short)110362624;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerSection)base[10038];
			}
		}

		// Token: 0x06005571 RID: 21873 RVA: 0x004D7B58 File Offset: 0x004D5D58
		public TrunkingShepherdListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藐ꇒꃔ맖님닚돜룞䇠냢跤苦駨菪裬鷮闰폲맴黶諸迺", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSHEPHERDLIST;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingShepherdListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06005572 RID: 21874 RVA: 0x004D7BA4 File Offset: 0x004D5DA4
		protected TrunkingShepherdListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闀뇂냄꧆ꋈꋊꏌ꣎燐胒뷔닖꧘돚룜귞藠쏢ꧤ軦髨鿪", a_);
		}
	}
}
