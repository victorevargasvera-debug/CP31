using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003DD RID: 989
	[global::System.Serializable]
	public class O2Inner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170046AF RID: 18095
		// (get) Token: 0x06008B8B RID: 35723 RVA: 0x0082B038 File Offset: 0x00829238
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection O2InnerSection
		{
			get
			{
				short num = (short)782551094;
				short num2 = num;
				num = (short)155306038;
				switch (num2 == num)
				{
				}
				num = (short)473432065;
				if (num != 0)
				{
				}
				num = (short)171311104;
				if (num != 0)
				{
				}
				num = (short)194510848;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection)base[10716];
			}
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x0082B0F4 File Offset: 0x008292F4
		public O2Inner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胎", a_);
			base.UIName = global::CommonResources.AcgResources.ID_O2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x0082B140 File Offset: 0x00829340
		protected O2Inner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿏", a_);
		}
	}
}
