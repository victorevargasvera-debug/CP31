using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200045A RID: 1114
	[global::System.Serializable]
	public class RxSSIClockRateTXModeInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004AB4 RID: 19124
		// (get) Token: 0x06009471 RID: 38001 RVA: 0x008BC7D8 File Offset: 0x008BA9D8
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerSection RxSSIClockRateTXModeInnerSection
		{
			get
			{
				short num = (short)1740570625;
				if (num != 0)
				{
				}
				num = (short)1386204270;
				short num2 = num;
				num = (short)1608633454;
				switch (num2 == num)
				{
				}
				num = (short)857473024;
				short num3 = num;
				num = (short)734265344;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerSection)base[10802];
			}
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x008BC890 File Offset: 0x008BAA90
		public RxSSIClockRateTXModeInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("釂뷄髈飊蓌鋐뿒뫔듖님ﯚ远뻞闠蛢엤ꯦ胨飪駬쿮쯰폲ꇴ迶\ud9f8뛺鋼鯾搀", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RXSSICLOCKRATELISTTXMODE;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x008BC8DC File Offset: 0x008BAADC
		protected RxSSIClockRateTXModeInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏀믂铆髈苊賎뷐볒뛔볖律觚볜ꯞ蓠쏢ꧤ軦髨鿪췬헮퇰ꟲ跴ퟶ듸铺駼髾", a_);
		}
	}
}
