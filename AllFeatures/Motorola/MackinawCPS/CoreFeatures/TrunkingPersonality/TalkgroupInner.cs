using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000CE RID: 206
	[global::System.Serializable]
	public class TalkgroupInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000E7E RID: 3710
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x001CA7A4 File Offset: 0x001C89A4
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection TalkgroupInnerSection
		{
			get
			{
				short num = (short)32916482;
				short num2 = num;
				num = (short)151012354;
				switch (num2 == num)
				{
				default:
				{
					num = (short)512688128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)676986881;
				if (num != 0)
				{
				}
				num = (short)914817024;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection)base[10180];
			}
		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x001CA860 File Offset: 0x001C8A60
		public TalkgroupInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駌껎뷐룒닔ꗖ뛘껚규", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUP;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06001CC0 RID: 7360 RVA: 0x001CA8AC File Offset: 0x001C8AAC
		protected TalkgroupInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("郃Ʂ꓇ꇉꯋ볍뿏ꟑꓓ", a_);
		}
	}
}
