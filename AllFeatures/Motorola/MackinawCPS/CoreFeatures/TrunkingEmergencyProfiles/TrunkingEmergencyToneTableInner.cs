using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x02000480 RID: 1152
	[global::System.Serializable]
	public class TrunkingEmergencyToneTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004C49 RID: 19529
		// (get) Token: 0x060097E7 RID: 38887 RVA: 0x008E9C24 File Offset: 0x008E7E24
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection TrunkingEmergencyToneTableInnerSection
		{
			get
			{
				short num = (short)1823702807;
				short num2 = num;
				num = (short)157122327;
				switch (num2 == num)
				{
				}
				num = (short)921632769;
				if (num != 0)
				{
				}
				num = (short)1157365760;
				short num3 = num;
				num = (short)1994457088;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection)base[10776];
			}
		}

		// Token: 0x060097E8 RID: 38888 RVA: 0x008E9CE0 File Offset: 0x008E7EE0
		public TrunkingEmergencyToneTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菅ꗇ꿉뻋꧍뗏병럓꿕軙돛냝藟싡냣蟥諧蛩觫", a_);
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyToneTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060097E9 RID: 38889 RVA: 0x008E9D2C File Offset: 0x008E7F2C
		protected TrunkingEmergencyToneTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓀껂ꃄ뗆껈껊ꏌ곎꣐臔룖럘뻚﷜诞胠臢觤苦", a_);
		}
	}
}
