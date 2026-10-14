using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002C1 RID: 705
	[global::System.Serializable]
	public class TrunkingSwitchTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003CF0 RID: 15600
		// (get) Token: 0x0600765C RID: 30300 RVA: 0x006ACA88 File Offset: 0x006AAC88
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection TrunkingSwitchTableInnerSection
		{
			get
			{
				short num = (short)1990456451;
				short num2 = num;
				num = (short)988083331;
				switch (num2 == num)
				{
				}
				num = (short)1047986176;
				short num3 = num;
				num = (short)83034112;
				if (num != 0)
				{
				}
				num = (short)410124289;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection)base[10084];
			}
		}

		// Token: 0x0600765D RID: 30301 RVA: 0x006ACB44 File Offset: 0x006AAD44
		public TrunkingSwitchTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("釄뗆볈ꗊꛌꛎ뿐듒蓖께닚꧜볞觠쏢뇤蛦诨蟪裬", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSWITCHTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600765E RID: 30302 RVA: 0x006ACB90 File Offset: 0x006AAD90
		protected TrunkingSwitchTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 4;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("釄뗆볈ꗊꛌꛎ뿐듒蓖께닚꧜볞觠쏢뇤蛦诨蟪裬", a_);
		}
	}
}
