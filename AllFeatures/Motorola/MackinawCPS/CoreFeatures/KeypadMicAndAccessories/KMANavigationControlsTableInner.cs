using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x0200031A RID: 794
	[global::System.Serializable]
	public class KMANavigationControlsTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003FA2 RID: 16290
		// (get) Token: 0x06007C35 RID: 31797 RVA: 0x0071F298 File Offset: 0x0071D498
		public global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection KMANavigationControlsTableInnerSection
		{
			get
			{
				short num = (short)2123164952;
				short num2 = num;
				num = (short)2041048344;
				switch (num2 == num)
				{
				}
				num = (short)1639251969;
				if (num != 0)
				{
				}
				num = (short)665452544;
				short num3 = num;
				num = (short)1736704000;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection)base[10754];
			}
		}

		// Token: 0x06007C36 RID: 31798 RVA: 0x0071F350 File Offset: 0x0071D550
		public KMANavigationControlsTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("迀ꋂ도껆껈꫊만ꛎ뻐뷒铖뛘뗚꧜귞軠迢雤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_NAVIGATIONCONTROLS;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007C37 RID: 31799 RVA: 0x0071F39C File Offset: 0x0071D59C
		protected KMANavigationControlsTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟈꫊믌ꛎ뛐닒ꇔ뻖뛘뗚﷜鳞軠跢釤闦蛨蟪黬", a_);
		}
	}
}
