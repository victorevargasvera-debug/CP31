using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x02000399 RID: 921
	[global::System.Serializable]
	public class O7DataButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700448C RID: 17548
		// (get) Token: 0x060086C7 RID: 34503 RVA: 0x007DB0C8 File Offset: 0x007D92C8
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection O7DataButtonInnerSection
		{
			get
			{
				short num = (short)2032750758;
				short num2 = num;
				num = (short)1716539558;
				switch (num2 == num)
				{
				}
				num = (short)1955921921;
				if (num != 0)
				{
				}
				num = (short)280625152;
				if (num != 0)
				{
				}
				num = (short)243138560;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection)base[10713];
			}
		}

		// Token: 0x060086C8 RID: 34504 RVA: 0x007DB180 File Offset: 0x007D9380
		public O7DataButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诎냐꟒듔鯘껚꧜ꯞ軠跢", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON_1;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060086C9 RID: 34505 RVA: 0x007DB1CC File Offset: 0x007D93CC
		protected O7DataButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铏돑ꃓ럕飙꧛ꫝ铟跡諣", a_);
		}
	}
}
