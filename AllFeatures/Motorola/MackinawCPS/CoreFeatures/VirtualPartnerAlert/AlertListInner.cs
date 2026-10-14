using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001B1 RID: 433
	[global::System.Serializable]
	public class AlertListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x06005130 RID: 20784 RVA: 0x0049DB84 File Offset: 0x0049BD84
		public global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerSection AlertListInnerSection
		{
			get
			{
				short num = (short)1309409280;
				short num2 = num;
				num = (short)1465715647;
				short num3 = num;
				num = (short)892013503;
				switch (num3 == num)
				{
				}
				num = (short)37552129;
				if (num != 0)
				{
				}
				num = (short)971505664;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerSection)base[10892];
			}
		}

		// Token: 0x06005131 RID: 20785 RVA: 0x0049DC40 File Offset: 0x0049BE40
		public AlertListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 11;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("跋ꋍ뗏ꃑꃓ铗동꿛ꫝ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ALERTLIST;
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06005132 RID: 20786 RVA: 0x0049DC8C File Offset: 0x0049BE8C
		protected AlertListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軎뷐뛒꟔ꏖ律韚드곞闠", a_);
		}
	}
}
