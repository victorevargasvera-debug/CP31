using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x02000296 RID: 662
	[global::System.Serializable]
	public class ConventionalSwitchTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003BEA RID: 15338
		// (get) Token: 0x0600743D RID: 29757 RVA: 0x0068C320 File Offset: 0x0068A520
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection ConventionalSwitchTableInnerSection
		{
			get
			{
				short num = (short)732274212;
				short num2 = num;
				num = (short)1927126564;
				switch (num2 == num)
				{
				}
				num = (short)1654784000;
				if (num != 0)
				{
				}
				num = (short)853409792;
				short num3 = num;
				num = (short)20709377;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection)base[10086];
			}
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x0068C3D8 File Offset: 0x0068A5D8
		public ConventionalSwitchTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 3;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟃꧅ꛇ볉꧋ꃍ꓏믑믓룕맗뛙ﳛ距韟诡郣藥胧쫩룫迭鋯黱釳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSWITCHTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x0068C424 File Offset: 0x0068A624
		protected ConventionalSwitchTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苀곂ꯄ뇆곈ꗊ만ꛎ뻐뷒듔믖律裚ꫜ뛞闠胢跤쟦뷨諪迬菮铰", a_);
		}
	}
}
