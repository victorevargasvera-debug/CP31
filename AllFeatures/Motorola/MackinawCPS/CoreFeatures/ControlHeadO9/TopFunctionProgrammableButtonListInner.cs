using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000387 RID: 903
	[global::System.Serializable]
	public class TopFunctionProgrammableButtonListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700439F RID: 17311
		// (get) Token: 0x060084F0 RID: 34032 RVA: 0x007B59C0 File Offset: 0x007B3BC0
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection TopFunctionProgrammableButtonListInnerSection
		{
			get
			{
				short num = (short)607881911;
				short num2 = num;
				num = (short)1886554807;
				switch (num2 == num)
				{
				}
				num = (short)1421344768;
				short num3 = num;
				num = (short)1003880448;
				if (num != 0)
				{
				}
				num = (short)1702690817;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection)base[10617];
			}
		}

		// Token: 0x060084F1 RID: 34033 RVA: 0x007B5A7C File Offset: 0x007B3C7C
		public TopFunctionProgrammableButtonListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闀곂뗄迈뻊ꏌ곎ꗐ뫒뫔맖律诚꿜냞蛠釢蓤諦蓨諪迬菮铰폲럴苶跸迺鋼釾", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TOPFUNCTIONPROGRAMMABLEBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060084F2 RID: 34034 RVA: 0x007B5AC8 File Offset: 0x007B3CC8
		protected TopFunctionProgrammableButtonListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黉ꏋ뻍铑ꇓ룕믗껙뗛뇝軟싡듣铥蟧跩黫迭鷯鿱闳铵铷鿹\udcfb볽痿瘁瀃椅昇", a_);
		}
	}
}
