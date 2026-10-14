using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002E8 RID: 744
	[global::System.Serializable]
	public class GCAIVIPInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x060078D6 RID: 30934 RVA: 0x006DF200 File Offset: 0x006DD400
		public global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection GCAIVIPInnerSection
		{
			get
			{
				short num = (short)1379156362;
				short num2 = num;
				num = (short)775307658;
				switch (num2 == num)
				{
				}
				num = (short)2131755008;
				if (num != 0)
				{
				}
				num = (short)1607729153;
				if (num != 0)
				{
				}
				num = (short)955121664;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection)base[10798];
			}
		}

		// Token: 0x060078D7 RID: 30935 RVA: 0x006DF2B8 File Offset: 0x006DD4B8
		public GCAIVIPInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雐郒铔黖律跚铜连쇠럢蓤藦藨軪", a_);
			base.UIName = global::CommonResources.AcgResources.ID_GCAIVIPTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060078D8 RID: 30936 RVA: 0x006DF304 File Offset: 0x006DD504
		protected GCAIVIPInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏓闕駗鏙ﳛ裝꧟닡쓣닥觧裩胫语", a_);
		}
	}
}
