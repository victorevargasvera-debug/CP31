using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x0200033A RID: 826
	[global::System.Serializable]
	public class DirectModeBCOListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x06007F4B RID: 32587 RVA: 0x00752C74 File Offset: 0x00750E74
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection DirectModeBCOListInnerSection
		{
			get
			{
				short num = (short)468349973;
				short num2 = num;
				num = (short)89420821;
				switch (num2 == num)
				{
				}
				num = (short)464125953;
				if (num != 0)
				{
				}
				num = (short)951189504;
				short num3 = num;
				num = (short)1694957568;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection)base[10238];
			}
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x00752D30 File Offset: 0x00750F30
		public DirectModeBCOListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("諍맏ꃑ뇓뗕곗龎釛뇝蓟蟡쓣ꓥꯧꗩ쳫ꋭ駯臱胳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTMODEBCOLIST;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x00752D7C File Offset: 0x00750F7C
		protected DirectModeBCOListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胃꿅뫇꿉꿋뫍鿑믓닕뷗龎黛鷝꿟싡꣣迥鯧黩", a_);
		}
	}
}
