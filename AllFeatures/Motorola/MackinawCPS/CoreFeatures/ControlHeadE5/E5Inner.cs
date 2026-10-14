using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F6 RID: 1014
	[global::System.Serializable]
	public class E5Inner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700475B RID: 18267
		// (get) Token: 0x06008D22 RID: 36130 RVA: 0x00846254 File Offset: 0x00844454
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection E5InnerSection
		{
			get
			{
				short num = (short)653121974;
				short num2 = num;
				num = (short)403495350;
				switch (num2 == num)
				{
				}
				num = (short)823263232;
				short num3 = num;
				num = (short)843907072;
				if (num != 0)
				{
				}
				num = (short)1439891457;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection)base[10901];
			}
		}

		// Token: 0x06008D23 RID: 36131 RVA: 0x00846310 File Offset: 0x00844510
		public E5Inner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賈ﻊ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_E5;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008D24 RID: 36132 RVA: 0x0084635C File Offset: 0x0084455C
		protected E5Inner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賈ﻊ", a_);
		}
	}
}
