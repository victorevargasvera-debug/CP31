using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000463 RID: 1123
	[global::System.Serializable]
	public class SecondLOInjectionFrequencyListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004AF8 RID: 19192
		// (get) Token: 0x0600951A RID: 38170 RVA: 0x008C40A8 File Offset: 0x008C22A8
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerSection SecondLOInjectionFrequencyListInnerSection
		{
			get
			{
				short num = (short)1484674088;
				short num2 = num;
				num = (short)490099752;
				switch (num2 == num)
				{
				}
				num = (short)2095710209;
				if (num != 0)
				{
				}
				num = (short)340656128;
				if (num != 0)
				{
				}
				num = (short)1463418880;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerSection)base[10011];
			}
		}

		// Token: 0x0600951B RID: 38171 RVA: 0x008C4160 File Offset: 0x008C2360
		public SecondLOInjectionFrequencyListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 17;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臑뇓뗕럗듙룛ﻝ곟귡쓣꿥蛧胩觫跭蓯鯱鯳飵\ud8f7볹軻鯽燿省愃栅欇猉Ⰻ䈍礏愑怓", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SECONDLOINJECTIONFREQUENCYLIST;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600951C RID: 38172 RVA: 0x008C41AC File Offset: 0x008C23AC
		protected SecondLOInjectionFrequencyListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 17;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臑뇓뗕럗듙룛ﻝ곟귡쓣꿥蛧胩觫跭蓯鯱鯳飵\ud8f7볹軻鯽燿省愃栅欇猉Ⰻ䈍礏愑怓", a_);
		}
	}
}
