using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200039D RID: 925
	[global::System.Serializable]
	public class O7Inner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170044E4 RID: 17636
		// (get) Token: 0x06008772 RID: 34674 RVA: 0x007E312C File Offset: 0x007E132C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection O7InnerSection
		{
			get
			{
				short num = (short)2078788959;
				short num2 = num;
				num = (short)1832439135;
				switch (num2 == num)
				{
				}
				num = (short)404291585;
				if (num != 0)
				{
				}
				num = (short)709033984;
				if (num != 0)
				{
				}
				num = (short)1257373696;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection)base[10715];
			}
		}

		// Token: 0x06008773 RID: 34675 RVA: 0x007E31E4 File Offset: 0x007E13E4
		public O7Inner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軀", a_);
			base.UIName = global::CommonResources.AcgResources.ID_O7;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x007E3230 File Offset: 0x007E1430
		protected O7Inner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裆ﻈ", a_);
		}
	}
}
