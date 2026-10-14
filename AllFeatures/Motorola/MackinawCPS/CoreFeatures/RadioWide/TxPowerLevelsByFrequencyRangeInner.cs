using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200018D RID: 397
	[global::System.Serializable]
	public class TxPowerLevelsByFrequencyRangeInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170020D9 RID: 8409
		// (get) Token: 0x0600402D RID: 16429 RVA: 0x003C3310 File Offset: 0x003C1510
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection TxPowerLevelsByFrequencyRangeInnerSection
		{
			get
			{
				short num = (short)1276903424;
				short num2 = num;
				num = (short)1574071384;
				short num3 = num;
				num = (short)1121086552;
				switch (num3 == num)
				{
				}
				num = (short)943521792;
				if (num != 0)
				{
				}
				num = (short)1893859329;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection)base[10104];
			}
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x003C33CC File Offset: 0x003C15CC
		public TxPowerLevelsByFrequencyRangeInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鋅냇鳋ꇍ꟏럑ꛓ铗뿙ꫛ믝賟釡쓣蓥釧쫩ꫫ鳭闯菱至鏵雷駹藻\udefd勿持樃愅洇", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TXPOWERLEVELSBYFREQUENCYRANGE;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600402F RID: 16431 RVA: 0x003C3418 File Offset: 0x003C1618
		protected TxPowerLevelsByFrequencyRangeInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駌럎菒뫔ꃖ볘꧚﷜鏞蓠闢胤详髨쯪迬雮퇰뗲蟴鋶裸軺飼釾戀稂┄唆栈攊樌樎", a_);
		}
	}
}
