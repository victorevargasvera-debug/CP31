using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000190 RID: 400
	[global::System.Serializable]
	public class TxPowerLevelsByFrequencyRangeNewBandPlanInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002178 RID: 8568
		// (get) Token: 0x06004154 RID: 16724 RVA: 0x003D1AD4 File Offset: 0x003CFCD4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection
		{
			get
			{
				short num = (short)45809664;
				short num2 = num;
				num = (short)106793771;
				short num3 = num;
				num = (short)1527417643;
				switch (num3 == num)
				{
				}
				num = (short)1964507136;
				if (num != 0)
				{
				}
				num = (short)204472321;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection)base[10762];
			}
		}

		// Token: 0x06004155 RID: 16725 RVA: 0x003D1B8C File Offset: 0x003CFD8C
		public TxPowerLevelsByFrequencyRangeNewBandPlanInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓏꫑蛕럗귙맛곝샟껡臣郥跧蛩鿫", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELS;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06004156 RID: 16726 RVA: 0x003D1BD8 File Offset: 0x003CFDD8
		protected TxPowerLevelsByFrequencyRangeNewBandPlanInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雁볃飇ꗉ믋ꯍꋏ飓돕껗뿙냛귝", a_);
		}
	}
}
