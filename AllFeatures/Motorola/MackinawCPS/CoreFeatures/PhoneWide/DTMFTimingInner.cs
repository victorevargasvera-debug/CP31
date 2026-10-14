using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x0200043C RID: 1084
	[global::System.Serializable]
	public class DTMFTimingInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170049F9 RID: 18937
		// (get) Token: 0x060092A7 RID: 37543 RVA: 0x008A25E4 File Offset: 0x008A07E4
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerSection DTMFTimingInnerSection
		{
			get
			{
				short num = (short)76546048;
				short num2 = num;
				num = (short)1305862836;
				short num3 = num;
				num = (short)791208628;
				switch (num3 == num)
				{
				}
				num = (short)745734145;
				if (num != 0)
				{
				}
				num = (short)2017001472;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerSection)base[10003];
			}
		}

		// Token: 0x060092A8 RID: 37544 RVA: 0x008A269C File Offset: 0x008A089C
		public DTMFTimingInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟂釄諆迈駌ꛎ볐뫒믔냖", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DTMFTIMING;
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFTimingInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060092A9 RID: 37545 RVA: 0x008A26E8 File Offset: 0x008A08E8
		protected DTMFTimingInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("資黉臋裍蛑뷓믕뇗듙믛", a_);
		}
	}
}
