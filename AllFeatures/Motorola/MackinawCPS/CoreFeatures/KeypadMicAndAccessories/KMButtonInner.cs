using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x0200031D RID: 797
	[global::System.Serializable]
	public class KMButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x06007C74 RID: 31860 RVA: 0x00721FBC File Offset: 0x007201BC
		public global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection KMButtonInnerSection
		{
			get
			{
				short num = (short)1424113971;
				short num2 = num;
				num = (short)30163251;
				switch (num2 == num)
				{
				}
				num = (short)2028797952;
				short num3 = num;
				num = (short)608894977;
				if (num != 0)
				{
				}
				num = (short)521338880;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection)base[10239];
			}
		}

		// Token: 0x06007C75 RID: 31861 RVA: 0x00722074 File Offset: 0x00720274
		public KMButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯏鿑铕귗껙꣛뇝軟", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KMBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007C76 RID: 31862 RVA: 0x007220C0 File Offset: 0x007202C0
		protected KMButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裂裄诈뻊만믎뻐뷒", a_);
		}
	}
}
