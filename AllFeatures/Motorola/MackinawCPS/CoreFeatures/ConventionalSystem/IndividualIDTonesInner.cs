using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000572 RID: 1394
	[global::System.Serializable]
	public class IndividualIDTonesInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005F2A RID: 24362
		// (get) Token: 0x0600BD98 RID: 48536 RVA: 0x00AF4C98 File Offset: 0x00AF2E98
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection IndividualIDTonesInnerSection
		{
			get
			{
				short num = (short)1635316112;
				short num2 = num;
				num = (short)443609488;
				switch (num2 == num)
				{
				}
				num = (short)1954152448;
				short num3 = num;
				num = (short)697958400;
				if (num != 0)
				{
				}
				num = (short)150011905;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection)base[10783];
			}
		}

		// Token: 0x0600BD99 RID: 48537 RVA: 0x00AF4D54 File Offset: 0x00AF2F54
		public IndividualIDTonesInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛎뿐럒볔ꇖ냘뿚꣜뻞跠쏢곤ꏦ짨뿪苬臮铰胲", a_);
			base.UIName = global::CommonResources.AcgResources.ID_INDIVIDUALIDTONES;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600BD9A RID: 48538 RVA: 0x00AF4DA0 File Offset: 0x00AF2FA0
		protected IndividualIDTonesInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軆ꟈ꿊꓌많룐럒ꃔ뛖뗘ﯚ铜鯞쇠럢諤触賨飪", a_);
		}
	}
}
