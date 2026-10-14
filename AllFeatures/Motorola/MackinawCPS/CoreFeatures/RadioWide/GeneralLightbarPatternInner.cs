using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000174 RID: 372
	[global::System.Serializable]
	public class GeneralLightbarPatternInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x0600357E RID: 13694 RVA: 0x003323FC File Offset: 0x003305FC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection GeneralLightbarPatternInnerSection
		{
			get
			{
				short num = (short)1900937216;
				short num2 = num;
				num = (short)176872750;
				short num3 = num;
				num = (short)518774062;
				switch (num3 == num)
				{
				}
				num = (short)187105280;
				if (num != 0)
				{
				}
				num = (short)983040001;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection)base[10605];
			}
		}

		// Token: 0x0600357F RID: 13695 RVA: 0x003324B8 File Offset: 0x003306B8
		public GeneralLightbarPatternInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 16;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菐뛒맔뛖ꃘﯚ跜뻞闠韢胤闦蟨", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERN;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06003580 RID: 13696 RVA: 0x00332504 File Offset: 0x00330704
		protected GeneralLightbarPatternInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黋ꯍ볏돑귓裗믙꣛ꫝ藟郡諣", a_);
		}
	}
}
