using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000457 RID: 1111
	[global::System.Serializable]
	public class RxSSIClockRateListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004A93 RID: 19091
		// (get) Token: 0x0600942B RID: 37931 RVA: 0x008B9560 File Offset: 0x008B7760
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerSection RxSSIClockRateListInnerSection
		{
			get
			{
				short num = (short)1125646336;
				short num2 = num;
				num = (short)1690642038;
				short num3 = num;
				num = (short)585180790;
				switch (num3 == num)
				{
				}
				num = (short)319684608;
				if (num != 0)
				{
				}
				num = (short)1123549185;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerSection)base[10792];
			}
		}

		// Token: 0x0600942C RID: 37932 RVA: 0x008B9618 File Offset: 0x008B7818
		public RxSSIClockRateListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯈돊鳎苐髒铖뗘듚뻜듞쇠뇢蓤鏦賨쯪ꇬ蛮苰蟲", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELIST;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600942D RID: 37933 RVA: 0x008B9664 File Offset: 0x008B7864
		protected RxSSIClockRateListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雃뻅駉鿋蟍金룓맕믗뇙ﳛ賝臟雡臣웥ꓧ菩鿫髭", a_);
		}
	}
}
