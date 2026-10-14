using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200037F RID: 895
	[global::System.Serializable]
	public class RelayPatternBCOListListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700433F RID: 17215
		// (get) Token: 0x0600841E RID: 33822 RVA: 0x007ABFEC File Offset: 0x007AA1EC
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection RelayPatternBCOListListInnerSection
		{
			get
			{
				short num = (short)1543833300;
				short num2 = num;
				num = (short)1887962836;
				switch (num2 == num)
				{
				}
				num = (short)2085093377;
				if (num != 0)
				{
				}
				num = (short)1497956352;
				if (num != 0)
				{
				}
				num = (short)285343744;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection)base[10621];
			}
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x007AC0A4 File Offset: 0x007AA2A4
		public RelayPatternBCOListListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿌꫎뷐닒곔觘뫚꧜ꯞ蓠釢诤쟦ꯨ꣪ꋬ쿮뷰髲蛴菶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERNBCOLIST;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x007AC0F0 File Offset: 0x007AA2F0
		protected RelayPatternBCOListListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏀ꛂ꧄ꛆ냈鷌껎ꗐ꟒냔ꗖ럘ﯚ鿜鳞껠쏢ꧤ軦髨鿪", a_);
		}
	}
}
