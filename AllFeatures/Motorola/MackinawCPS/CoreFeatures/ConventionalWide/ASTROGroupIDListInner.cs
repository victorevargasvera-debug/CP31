using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000541 RID: 1345
	[global::System.Serializable]
	public class ASTROGroupIDListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005AA2 RID: 23202
		// (get) Token: 0x0600B4B3 RID: 46259 RVA: 0x00A766FC File Offset: 0x00A748FC
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerSection ASTROGroupIDListInnerSection
		{
			get
			{
				short num = (short)660406273;
				if (num != 0)
				{
				}
				num = (short)1920967625;
				short num2 = num;
				num = (short)940549065;
				switch (num2 == num)
				{
				}
				num = (short)851181568;
				short num3 = num;
				num = (short)1557004288;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerSection)base[10054];
			}
		}

		// Token: 0x0600B4B4 RID: 46260 RVA: 0x00A767B8 File Offset: 0x00A749B8
		public ASTROGroupIDListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苂雄鏆鯈蓊裎ꏐ볒ꃔꟖ律鋚駜￞균諢雤鏦", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ASTROGROUPIDLIST;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROGroupIDListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600B4B5 RID: 46261 RVA: 0x00A76804 File Offset: 0x00A74A04
		protected ASTROGroupIDListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軎苐蟒蟔飖律鳚꿜냞铠鏢엤껦귨쯪ꇬ蛮苰蟲", a_);
		}
	}
}
