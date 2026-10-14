using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200016D RID: 365
	[global::System.Serializable]
	public class FCCNarrowBandingFrequencySplitInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06002FCA RID: 12234 RVA: 0x002ED250 File Offset: 0x002EB450
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection FCCNarrowBandingFrequencySplitInnerSection
		{
			get
			{
				short num = (short)2036006912;
				short num2 = num;
				num = (short)360601645;
				short num3 = num;
				num = (short)640899117;
				switch (num3 == num)
				{
				}
				num = (short)1477181440;
				if (num != 0)
				{
				}
				num = (short)180617217;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection)base[10635];
			}
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x002ED30C File Offset: 0x002EB50C
		public FCCNarrowBandingFrequencySplitInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("跊軌賎鷒듔ꗖꯘ듚ꫜ￞ꏠ苢诤菦胨藪諬쿮런臲郴蛶賸黺鏼鳾砀⌂嘄眆攈戊礌", a_);
			base.UIName = global::CommonResources.AcgResources.ID_FCCNARROWBANDINGFREQUENCYSPLIT;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x002ED358 File Offset: 0x002EB558
		protected FCCNarrowBandingFrequencySplitInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裍鏏金飕맗꣙껛뇝韟싡ꛣ蟥蛧軩藫胭韯틱닳蓵鷷诹觻鯽滿愁紃★嬇稉怋服搏", a_);
		}
	}
}
