using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003E0 RID: 992
	[global::System.Serializable]
	public class O2MFKAssignmentControlInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170046D9 RID: 18137
		// (get) Token: 0x06008BDF RID: 35807 RVA: 0x0082EE34 File Offset: 0x0082D034
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection O2MFKAssignmentControlInnerSection
		{
			get
			{
				short num = (short)1700659200;
				short num2 = num;
				num = (short)1384159579;
				short num3 = num;
				num = (short)588880219;
				switch (num3 == num)
				{
				}
				num = (short)1153040385;
				if (num != 0)
				{
				}
				num = (short)1031208960;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection)base[10726];
			}
		}

		// Token: 0x06008BE0 RID: 35808 RVA: 0x0082EEEC File Offset: 0x0082D0EC
		public O2MFKAssignmentControlInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黒鏔鳖律觚닜ꯞ胠釢鳤쟦ꫨ蓪菬鯮菰鳲駴", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008BE1 RID: 35809 RVA: 0x0082EF38 File Offset: 0x0082D138
		protected O2MFKAssignmentControlInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諆迈胊鷎뻐꟒듔ꗖꃘﯚ黜냞迠韢韤裦藨", a_);
		}
	}
}
