using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000383 RID: 899
	[global::System.Serializable]
	public class ResponseSelectorListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700435E RID: 17246
		// (get) Token: 0x0600846A RID: 33898 RVA: 0x007AF64C File Offset: 0x007AD84C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection ResponseSelectorListInnerSection
		{
			get
			{
				short num = (short)1087028536;
				short num2 = num;
				num = (short)1962065208;
				switch (num2 == num)
				{
				}
				num = (short)362610688;
				if (num != 0)
				{
				}
				num = (short)1861419009;
				if (num != 0)
				{
				}
				num = (short)720044032;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection)base[10625];
			}
		}

		// Token: 0x0600846B RID: 33899 RVA: 0x007AF704 File Offset: 0x007AD904
		public ResponseSelectorListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铅귇막볋ꇍ뻏ꇑ뇓诗뿙냛믝菟雡诣铥", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RESPONSESELECTOR;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelectorListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x007AF750 File Offset: 0x007AD950
		protected ResponseSelectorListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("釂ꃄ듆마꓊ꏌ볎듐蛔닖뗘뻚뻜ꯞ軠釢", a_);
		}
	}
}
