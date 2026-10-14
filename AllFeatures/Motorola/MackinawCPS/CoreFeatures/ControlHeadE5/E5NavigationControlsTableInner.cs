using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003FA RID: 1018
	[global::System.Serializable]
	public class E5NavigationControlsTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004786 RID: 18310
		// (get) Token: 0x06008D7F RID: 36223 RVA: 0x0084A5D8 File Offset: 0x008487D8
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection E5NavigationControlsTableInnerSection
		{
			get
			{
				short num = (short)1975261179;
				short num2 = num;
				num = (short)388438011;
				switch (num2 == num)
				{
				}
				num = (short)1435041792;
				short num3 = num;
				num = (short)1483210753;
				if (num != 0)
				{
				}
				num = (short)574816256;
				if (num != 0)
				{
				}
				return base[10897] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection;
			}
		}

		// Token: 0x06008D80 RID: 36224 RVA: 0x0084A690 File Offset: 0x00848890
		public E5NavigationControlsTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鷒듔ꇖ냘볚볜ꯞ裠賢诤쟦ꫨ蓪菬鯮菰鳲駴蓶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008D81 RID: 36225 RVA: 0x0084A6DC File Offset: 0x008488DC
		protected E5NavigationControlsTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諃Ʂ뻇ꏉꯋ꿍꓏믑믓룕駙돛냝铟郡诣諥鯧", a_);
		}
	}
}
