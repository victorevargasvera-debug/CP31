using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000553 RID: 1363
	[global::System.Serializable]
	public class OTACInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005B85 RID: 23429
		// (get) Token: 0x0600B696 RID: 46742 RVA: 0x00A8FF4C File Offset: 0x00A8E14C
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection OTACInnerSection
		{
			get
			{
				short num = (short)1685541698;
				short num2 = num;
				num = (short)395203394;
				switch (num2 == num)
				{
				}
				num = (short)271581184;
				short num3 = num;
				num = (short)623181824;
				if (num != 0)
				{
				}
				num = (short)324861953;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection)base[10056];
			}
		}

		// Token: 0x0600B697 RID: 46743 RVA: 0x00A90004 File Offset: 0x00A8E204
		public OTACInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("觅鳇诉迋", a_);
			base.UIName = global::CommonResources.AcgResources.ID_OTAC;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600B698 RID: 46744 RVA: 0x00A90050 File Offset: 0x00A8E250
		protected OTACInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("跁郃蟅诇", a_);
		}
	}
}
