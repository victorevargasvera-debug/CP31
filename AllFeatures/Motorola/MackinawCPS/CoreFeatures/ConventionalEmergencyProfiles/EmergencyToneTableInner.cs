using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A2 RID: 1186
	[global::System.Serializable]
	public class EmergencyToneTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004DC5 RID: 19909
		// (get) Token: 0x06009B05 RID: 39685 RVA: 0x00914128 File Offset: 0x00912328
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection EmergencyToneTableInnerSection
		{
			get
			{
				short num = (short)352425454;
				short num2 = num;
				num = (short)1323341294;
				switch (num2 == num)
				{
				}
				num = (short)1367277568;
				if (num != 0)
				{
				}
				num = (short)40828929;
				if (num != 0)
				{
				}
				num = (short)1075118080;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection)base[10774];
			}
		}

		// Token: 0x06009B06 RID: 39686 RVA: 0x009141E4 File Offset: 0x009123E4
		public EmergencyToneTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 6;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苆꓈껊뿌꣎듐뷒뛔껖律迚닜뇞蓠쏢뇤蛦诨蟪裬", a_);
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONETABLE;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06009B07 RID: 39687 RVA: 0x00914230 File Offset: 0x00912430
		protected EmergencyToneTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 17;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韑맓돕꫗뷙맛냝菟鯡쓣닥蟧蓩觫컭ꓯ鏱雳髵鷷", a_);
		}
	}
}
