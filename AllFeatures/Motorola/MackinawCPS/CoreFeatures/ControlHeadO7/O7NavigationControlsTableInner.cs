using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x020003A5 RID: 933
	[global::System.Serializable]
	public class O7NavigationControlsTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700453A RID: 17722
		// (get) Token: 0x0600882E RID: 34862 RVA: 0x007EBB30 File Offset: 0x007E9D30
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection O7NavigationControlsTableInnerSection
		{
			get
			{
				short num = (short)140783179;
				short num2 = num;
				num = (short)281357899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1960312832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1695219713;
				if (num != 0)
				{
				}
				num = (short)1508704256;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection)base[10728];
			}
		}

		// Token: 0x0600882F RID: 34863 RVA: 0x007EBBE8 File Offset: 0x007E9DE8
		public O7NavigationControlsTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("迀ꋂ도껆껈꫊만ꛎ뻐뷒铖뛘뗚꧜귞軠迢雤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008830 RID: 34864 RVA: 0x007EBC34 File Offset: 0x007E9E34
		protected O7NavigationControlsTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藊곌많룐듒듔ꏖ냘듚돜￞ꋠ賢诤鏦鯨蓪臬鳮", a_);
		}
	}
}
