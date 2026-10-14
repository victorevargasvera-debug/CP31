using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000373 RID: 883
	[global::System.Serializable]
	public class O9Inner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170042CA RID: 17098
		// (get) Token: 0x06008318 RID: 33560 RVA: 0x007A015C File Offset: 0x0079E35C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection O9InnerSection
		{
			get
			{
				short num = (short)587294424;
				short num2 = num;
				num = (short)326002392;
				switch (num2 == num)
				{
				}
				num = (short)142999552;
				short num3 = num;
				num = (short)1834090497;
				if (num != 0)
				{
				}
				num = (short)1582170112;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection)base[10627];
			}
		}

		// Token: 0x06008319 RID: 33561 RVA: 0x007A0214 File Offset: 0x0079E414
		public O9Inner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苌", a_);
			base.UIName = global::CommonResources.AcgResources.ID_O9;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600831A RID: 33562 RVA: 0x007A0260 File Offset: 0x0079E460
		protected O9Inner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胎", a_);
		}
	}
}
