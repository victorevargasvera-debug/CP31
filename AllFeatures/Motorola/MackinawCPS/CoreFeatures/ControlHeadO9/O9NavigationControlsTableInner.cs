using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000377 RID: 887
	[global::System.Serializable]
	public class O9NavigationControlsTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170042F5 RID: 17141
		// (get) Token: 0x06008376 RID: 33654 RVA: 0x007A4630 File Offset: 0x007A2830
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection O9NavigationControlsTableInnerSection
		{
			get
			{
				short num = (short)1795015965;
				short num2 = num;
				num = (short)608748829;
				switch (num2 == num)
				{
				}
				num = (short)1749221377;
				if (num != 0)
				{
				}
				num = (short)539951104;
				if (num != 0)
				{
				}
				num = (short)696647680;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection)base[10734];
			}
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x007A46E8 File Offset: 0x007A28E8
		public O9NavigationControlsTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("跂꓄뇆ꃈ곊곌믎룐볒믔高듚돜ꯞ鏠賢觤铦", a_);
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x007A4734 File Offset: 0x007A2934
		protected O9NavigationControlsTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諃Ʂ뻇ꏉꯋ꿍꓏믑믓룕駙돛냝铟郡诣諥鯧", a_);
		}
	}
}
