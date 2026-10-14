using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003B5 RID: 949
	[global::System.Serializable]
	public class O5NavigationControlsTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170045A6 RID: 17830
		// (get) Token: 0x0600892F RID: 35119 RVA: 0x007FBB20 File Offset: 0x007F9D20
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection O5NavigationControlsTableInnerSection
		{
			get
			{
				short num = (short)1150642024;
				short num2 = num;
				num = (short)101738344;
				switch (num2 == num)
				{
				}
				num = (short)1640693761;
				if (num != 0)
				{
				}
				num = (short)281608192;
				short num3 = num;
				num = (short)327286784;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection)base[10736];
			}
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x007FBBDC File Offset: 0x007F9DDC
		public O5NavigationControlsTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("迀ꋂ도껆껈꫊만ꛎ뻐뷒铖뛘뗚꧜귞軠迢雤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x007FBC28 File Offset: 0x007F9E28
		protected O5NavigationControlsTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菌껎Ꟑ뫒닔뛖귘닚닜뇞쇠ꃢ諤触鷨駪苬菮苰", a_);
		}
	}
}
