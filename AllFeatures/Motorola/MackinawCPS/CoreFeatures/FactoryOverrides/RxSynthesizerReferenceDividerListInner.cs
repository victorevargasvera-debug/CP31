using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200045F RID: 1119
	[global::System.Serializable]
	public class RxSynthesizerReferenceDividerListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004AD6 RID: 19158
		// (get) Token: 0x060094CA RID: 38090 RVA: 0x008C0764 File Offset: 0x008BE964
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerSection RxSynthesizerReferenceDividerListInnerSection
		{
			get
			{
				short num = (short)1339637128;
				short num2 = num;
				num = (short)1311456648;
				switch (num2 == num)
				{
				}
				num = (short)149028864;
				short num3 = num;
				num = (short)1677066240;
				if (num != 0)
				{
				}
				num = (short)395968513;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerSection)base[10007];
			}
		}

		// Token: 0x060094CB RID: 38091 RVA: 0x008C081C File Offset: 0x008BEA1C
		public RxSynthesizerReferenceDividerListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("飉듋菏ꯑ뫓ꋕ냗뿙꿛럝髟蟡難웥뫧迩諫语苯韱髳闵鷷\udaf9룻韽盿欁怃挅稇⨉䀋服挏昑", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RXSYNTHESIZERREFERENCEDIVIDERLIST;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060094CC RID: 38092 RVA: 0x008C0868 File Offset: 0x008BEA68
		protected RxSynthesizerReferenceDividerListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韄뿆飊듌ꇎꗐ믒냔ꓖ냘ꇚ룜귞쇠뇢胤臦賨駪裬臮鋰雲헴돶郸跺铼鯾搀焂┄䬆怈砊礌", a_);
		}
	}
}
