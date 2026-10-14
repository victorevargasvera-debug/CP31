using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200018A RID: 394
	[global::System.Serializable]
	public class TxFrequencySplitFPPInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x003BEF68 File Offset: 0x003BD168
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection TxFrequencySplitFPPInnerSection
		{
			get
			{
				short num = (short)143148512;
				short num2 = num;
				num = (short)1754547680;
				switch (num2 == num)
				{
				}
				num = (short)538640384;
				if (num != 0)
				{
				}
				num = (short)1425342465;
				if (num != 0)
				{
				}
				num = (short)1462304768;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection)base[10095];
			}
		}

		// Token: 0x06003FD0 RID: 16336 RVA: 0x003BF020 File Offset: 0x003BD220
		public TxFrequencySplitFPPInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 1;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雁볃軇룉꧋뿍ꗏ럑뫓뗕ꇗ龎进껝賟诡郣웥샧곩볫뻭\ud9ef", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TXFREQUENCYSPLITFPP;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06003FD1 RID: 16337 RVA: 0x003BF06C File Offset: 0x003BD26C
		protected TxFrequencySplitFPPInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鋅냇請볍뗏ꏑꇓ돕뛗맙ꗛﻝ돟鋡裣迥鳧쫩쓫꣭ꃯꋱ\uddf3", a_);
		}
	}
}
