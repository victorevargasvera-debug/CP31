using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x02000438 RID: 1080
	[global::System.Serializable]
	public class DTMFCodesInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170049B4 RID: 18868
		// (get) Token: 0x06009219 RID: 37401 RVA: 0x0089BCF8 File Offset: 0x00899EF8
		public global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerSection DTMFCodesInnerSection
		{
			get
			{
				short num = (short)837353472;
				short num2 = num;
				num = (short)1702165299;
				short num3 = num;
				num = (short)1412561715;
				switch (num3 == num)
				{
				}
				num = (short)38666240;
				if (num != 0)
				{
				}
				num = (short)177537025;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerSection)base[10001];
			}
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x0089BDB0 File Offset: 0x00899FB0
		public DTMFCodesInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韒臔髖鿘ﯚ黜냞藠蛢雤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DTMFCODES;
			global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.DTMFCodesInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x0089BDFC File Offset: 0x00899FFC
		protected DTMFCodesInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韒臔髖鿘ﯚ黜냞藠蛢雤", a_);
		}
	}
}
