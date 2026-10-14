using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000CA RID: 202
	[global::System.Serializable]
	public class PreferredSitesInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06001C09 RID: 7177 RVA: 0x001C2164 File Offset: 0x001C0364
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerSection PreferredSitesInnerSection
		{
			get
			{
				short num = (short)252934206;
				short num2 = num;
				num = (short)782858302;
				switch (num2 == num)
				{
				}
				num = (short)911998976;
				if (num != 0)
				{
				}
				num = (short)1149239297;
				if (num != 0)
				{
				}
				num = (short)1023475712;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerSection)base[10183];
			}
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x001C221C File Offset: 0x001C041C
		public PreferredSitesInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闄뗆곈귊꣌뷎ꏐ뛒뇔諘닚꧜뫞鋠", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PREFERREDSITES;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x001C2268 File Offset: 0x001C0468
		protected PreferredSitesInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闄뗆곈귊꣌뷎ꏐ뛒뇔諘닚꧜뫞鋠", a_);
		}
	}
}
