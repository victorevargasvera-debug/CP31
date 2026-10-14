using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000064 RID: 100
	[global::System.Serializable]
	public class ASTRO25ChannelIDInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00080E7C File Offset: 0x0007F07C
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection ASTRO25ChannelIDInnerSection
		{
			get
			{
				short num = (short)1182362114;
				short num2 = num;
				num = (short)180251138;
				switch (num2 == num)
				{
				}
				num = (short)822411264;
				if (num != 0)
				{
				}
				num = (short)1637548032;
				short num3 = num;
				num = (short)95617025;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection)base[10161];
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x00080F38 File Offset: 0x0007F138
		public ASTRO25ChannelIDInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("量臑胓蓕韗龎샟ꇡ賣蟥蛧蓩觫苭탯믱냳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ASTRO25CHANNELID;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00080F84 File Offset: 0x0007F184
		protected ASTRO25ChannelIDInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 16;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("郐胒臔藖雘ﯚ쇠ꃢ跤蛦蟨藪裬菮퇰뫲뇴", a_);
		}
	}
}
