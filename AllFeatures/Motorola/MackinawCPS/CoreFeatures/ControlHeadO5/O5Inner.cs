using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003B1 RID: 945
	[global::System.Serializable]
	public class O5Inner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700455A RID: 17754
		// (get) Token: 0x06008898 RID: 34968 RVA: 0x007F49B0 File Offset: 0x007F2BB0
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection O5InnerSection
		{
			get
			{
				short num = (short)1475149824;
				short num2 = num;
				num = (short)991056043;
				short num3 = num;
				num = (short)1825919147;
				switch (num3 == num)
				{
				}
				num = (short)1844314113;
				if (num != 0)
				{
				}
				num = (short)1988493312;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection)base[10211];
			}
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x007F4A6C File Offset: 0x007F2C6C
		public O5Inner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苌龜", a_);
			base.UIName = global::CommonResources.AcgResources.ID_O5;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600889A RID: 34970 RVA: 0x007F4AB8 File Offset: 0x007F2CB8
		protected O5Inner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓊", a_);
		}
	}
}
