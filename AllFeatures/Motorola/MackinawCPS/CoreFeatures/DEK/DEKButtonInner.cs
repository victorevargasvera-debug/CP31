using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200032D RID: 813
	[global::System.Serializable]
	public class DEKButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004026 RID: 16422
		// (get) Token: 0x06007D5B RID: 32091 RVA: 0x0073B7E4 File Offset: 0x007399E4
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection DEKButtonInnerSection
		{
			get
			{
				short num = (short)1676476416;
				short num2 = num;
				num = (short)1885872846;
				short num3 = num;
				num = (short)683811534;
				switch (num3 == num)
				{
				}
				num = (short)1600847873;
				if (num != 0)
				{
				}
				num = (short)849215488;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection)base[10204];
			}
		}

		// Token: 0x06007D5C RID: 32092 RVA: 0x0073B89C File Offset: 0x00739A9C
		public DEKButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臄苆苈迌뫎ꗐ꟒뫔맖", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DEKBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007D5D RID: 32093 RVA: 0x0073B8E8 File Offset: 0x00739AE8
		protected DEKButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诎铐飒闖곘꿚꧜냞迠", a_);
		}
	}
}
