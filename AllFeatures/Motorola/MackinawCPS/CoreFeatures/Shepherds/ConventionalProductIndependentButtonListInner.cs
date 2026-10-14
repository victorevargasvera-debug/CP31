using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001C9 RID: 457
	[global::System.Serializable]
	public class ConventionalProductIndependentButtonListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x06005313 RID: 21267 RVA: 0x004B7080 File Offset: 0x004B5280
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerSection ConventionalProductIndependentButtonListInnerSection
		{
			get
			{
				short num = (short)84279296;
				short num2 = num;
				num = (short)1505230849;
				if (num != 0)
				{
				}
				num = (short)1971618789;
				short num3 = num;
				num = (short)192054245;
				switch (num3 == num)
				{
				}
				num = (short)2093219840;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerSection)base[10026];
			}
		}

		// Token: 0x06005314 RID: 21268 RVA: 0x004B713C File Offset: 0x004B533C
		public ConventionalProductIndependentButtonListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胂꫄꧆뿈껊ꏌ믎룐볒믔뛖뗘ﯚ跜귞軠蟢郤蓦鷨쯪ꓬ臮闰雲藴鋶韸鿺飼釾甀⌂䜄爆紈缊戌愎ㄐ弒簔搖洘", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTONLIST;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalProductIndependentButtonListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06005315 RID: 21269 RVA: 0x004B7188 File Offset: 0x004B5388
		protected ConventionalProductIndependentButtonListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛄꣆ꟈ뷊꣌ꇎꗐ뫒뫔맖룘럚﷜连鏠賢臤鋦諨鿪췬ꛮ鿰韲郴蟶鳸闺駼髾漀眂┄䔆簈缊礌怎缐㌒夔縖樘漚", a_);
		}
	}
}
