using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x020003A0 RID: 928
	[global::System.Serializable]
	public class O7MFKAssignmentControlInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700450E RID: 17678
		// (get) Token: 0x060087C6 RID: 34758 RVA: 0x007E6F10 File Offset: 0x007E5110
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection O7MFKAssignmentControlInnerSection
		{
			get
			{
				short num = (short)203637040;
				short num2 = num;
				num = (short)2043953456;
				switch (num2 == num)
				{
				}
				num = (short)1938227201;
				if (num != 0)
				{
				}
				num = (short)1036713984;
				short num3 = num;
				num = (short)2065432576;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection)base[10724];
			}
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x007E6FC8 File Offset: 0x007E51C8
		public O7MFKAssignmentControlInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賀藂軄鯈꓊만껎ꏐ꫒铖뛘뗚꧜귞軠迢", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x007E7014 File Offset: 0x007E5214
		protected O7MFKAssignmentControlInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 16;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鳐闒黔诘듚꧜뻞鏠髢엤ꓦ蛨藪駬鷮黰鿲", a_);
		}
	}
}
