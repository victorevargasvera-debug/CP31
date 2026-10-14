using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003CF RID: 975
	[global::System.Serializable]
	public class O3NavigationControlsTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700468D RID: 18061
		// (get) Token: 0x06008B1A RID: 35610 RVA: 0x008202AC File Offset: 0x0081E4AC
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection O3NavigationControlsTableInnerSection
		{
			get
			{
				short num = (short)1148012258;
				short num2 = num;
				num = (short)969819874;
				switch (num2 == num)
				{
				}
				num = (short)843579392;
				short num3 = num;
				num = (short)886964225;
				if (num != 0)
				{
				}
				num = (short)263979008;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection)base[10733];
			}
		}

		// Token: 0x06008B1B RID: 35611 RVA: 0x00820364 File Offset: 0x0081E564
		public O3NavigationControlsTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蓉귋룍맏뗑뗓ꋕ뇗뗙닛ﻝꏟ跡諣鋥髧藩胫鷭", a_);
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008B1C RID: 35612 RVA: 0x008203B0 File Offset: 0x0081E5B0
		protected O3NavigationControlsTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臎냐ꗒ볔냖룘꿚드냞迠쏢ꛤ裦蟨鿪鿬胮鷰胲", a_);
		}
	}
}
