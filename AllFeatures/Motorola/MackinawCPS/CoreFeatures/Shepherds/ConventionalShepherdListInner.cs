using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001CD RID: 461
	[global::System.Serializable]
	public class ConventionalShepherdListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002B20 RID: 11040
		// (get) Token: 0x06005349 RID: 21321 RVA: 0x004B9634 File Offset: 0x004B7834
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerSection ConventionalShepherdListInnerSection
		{
			get
			{
				short num = (short)820979213;
				short num2 = num;
				num = (short)1204168205;
				switch (num2 == num)
				{
				}
				num = (short)1502740481;
				if (num != 0)
				{
				}
				num = (short)449773568;
				if (num != 0)
				{
				}
				num = (short)2101149696;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerSection)base[10036];
			}
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x004B96EC File Offset: 0x004B78EC
		public ConventionalShepherdListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裊ꋌꇎꟐ뛒믔ꏖ냘듚돜뻞跠쏢뛤迦賨鯪藬諮菰韲헴믶郸裺觼", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSHEPHERDLIST;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x004B9738 File Offset: 0x004B7938
		protected ConventionalShepherdListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胂꫄꧆뿈껊ꏌ믎룐볒믔뛖뗘ﯚ軜럞蓠鏢跤苦鯨迪췬ꏮ飰胲致", a_);
		}
	}
}
