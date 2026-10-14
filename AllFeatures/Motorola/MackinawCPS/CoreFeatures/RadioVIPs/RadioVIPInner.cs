using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002EC RID: 748
	[global::System.Serializable]
	public class RadioVIPInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003E6A RID: 15978
		// (get) Token: 0x06007974 RID: 31092 RVA: 0x006E681C File Offset: 0x006E4A1C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection RadioVIPInnerSection
		{
			get
			{
				short num = (short)1195704320;
				short num2 = num;
				num = (short)278462465;
				if (num != 0)
				{
				}
				num = (short)210070827;
				short num3 = num;
				num = (short)1608674603;
				switch (num3 == num)
				{
				}
				num = (short)777584640;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection)base[10207];
			}
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x006E68D8 File Offset: 0x006E4AD8
		public RadioVIPInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臒듔돖냘듚﷜觞꣠돢엤돦裨觪臬諮", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOVIPTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x006E6924 File Offset: 0x006E4B24
		protected RadioVIPInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛓럕볗동돛ﻝ뛟ꯡ듣웥볧诩軫苭闯", a_);
		}
	}
}
