using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200006E RID: 110
	[global::System.Serializable]
	public class ControlChannelsInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170005C7 RID: 1479
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x000CAEA4 File Offset: 0x000C90A4
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection ControlChannelsInnerSection
		{
			get
			{
				short num = (short)1738399045;
				short num2 = num;
				num = (short)1964760389;
				switch (num2 == num)
				{
				}
				num = (short)1600782337;
				if (num != 0)
				{
				}
				num = (short)1475608576;
				if (num != 0)
				{
				}
				num = (short)369360896;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection)base[10170];
			}
		}

		// Token: 0x06000C25 RID: 3109 RVA: 0x000CAF5C File Offset: 0x000C915C
		public ControlChannelsInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏏뷑뫓ꋕ꫗뗙냛ﻝꏟ諡藣裥蛧迩胫鷭", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLCHANNELS;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06000C26 RID: 3110 RVA: 0x000CAFA8 File Offset: 0x000C91A8
		protected ControlChannelsInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賎뻐뷒ꇔꗖ뛘럚﷜鳞觠苢诤触賨蟪黬", a_);
		}
	}
}
