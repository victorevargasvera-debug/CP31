using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList
{
	// Token: 0x020005E5 RID: 1509
	[global::System.Serializable]
	public class TalkgroupTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17006856 RID: 26710
		// (get) Token: 0x0600CFBA RID: 53178 RVA: 0x00C14C58 File Offset: 0x00C12E58
		public global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection TalkgroupTableInnerSection
		{
			get
			{
				short num = (short)1470140162;
				short num2 = num;
				num = (short)2128973570;
				switch (num2 == num)
				{
				}
				num = (short)1857093632;
				short num3 = num;
				num = (short)1683554304;
				if (num != 0)
				{
				}
				num = (short)8716289;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection)base[10153];
			}
		}

		// Token: 0x0600CFBB RID: 53179 RVA: 0x00C14D14 File Offset: 0x00C12F14
		public TalkgroupTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駌껎뷐룒닔ꗖ뛘껚규￞뗠苢蟤详賨", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TALKGROUPTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600CFBC RID: 53180 RVA: 0x00C14D60 File Offset: 0x00C12F60
		protected TalkgroupTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鷈꫊ꇌ꓎뛐ꇒ뫔ꋖ꧘ﯚ觜뻞菠迢胤", a_);
		}
	}
}
