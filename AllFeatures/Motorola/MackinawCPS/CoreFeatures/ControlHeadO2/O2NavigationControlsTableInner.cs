using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003E5 RID: 997
	[global::System.Serializable]
	public class O2NavigationControlsTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004706 RID: 18182
		// (get) Token: 0x06008C48 RID: 35912 RVA: 0x00833B48 File Offset: 0x00831D48
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection O2NavigationControlsTableInnerSection
		{
			get
			{
				short num = (short)1463574442;
				short num2 = num;
				num = (short)1380868010;
				switch (num2 == num)
				{
				}
				num = (short)1614610432;
				if (num != 0)
				{
				}
				num = (short)976027648;
				short num3 = num;
				num = (short)1855651841;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection)base[10725];
			}
		}

		// Token: 0x06008C49 RID: 35913 RVA: 0x00833C08 File Offset: 0x00831E08
		public O2NavigationControlsTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黏돑ꋓ뿕뿗믙꣛럝迟賡쓣ꗥ蟧蓩飫鳭鿯黱蟳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008C4A RID: 35914 RVA: 0x00833C54 File Offset: 0x00831E54
		protected O2NavigationControlsTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓉귋룍맏뗑뗓ꋕ뇗뗙닛ﻝꏟ跡諣鋥髧藩胫鷭", a_);
		}
	}
}
