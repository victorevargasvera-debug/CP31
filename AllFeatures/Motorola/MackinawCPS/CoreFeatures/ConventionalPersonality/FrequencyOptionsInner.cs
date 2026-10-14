using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005BF RID: 1471
	[global::System.Serializable]
	public class FrequencyOptionsInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17006277 RID: 25207
		// (get) Token: 0x0600C4A8 RID: 50344 RVA: 0x00B85C88 File Offset: 0x00B83E88
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection FrequencyOptionsInnerSection
		{
			get
			{
				short num = (short)1400391553;
				short num2 = num;
				num = (short)798246785;
				switch (num2 == num)
				{
				}
				num = (short)2041118721;
				if (num != 0)
				{
				}
				num = (short)276168704;
				if (num != 0)
				{
				}
				num = (short)801439744;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection)base[10149];
			}
		}

		// Token: 0x0600C4A9 RID: 50345 RVA: 0x00B85D40 File Offset: 0x00B83F40
		public FrequencyOptionsInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韐ꇒ냔ꛖ곘뻚돜볞飠쏢ꫤ韦鷨苪苬臮苰", a_);
			base.UIName = global::CommonResources.AcgResources.ID_FREQUENCYOPTIONS;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600C4AA RID: 50346 RVA: 0x00B85D8C File Offset: 0x00B83F8C
		protected FrequencyOptionsInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟀뇂ꃄ뛆볈껊ꏌ곎꣐體Ꟗ귘닚닜뇞鋠", a_);
		}
	}
}
