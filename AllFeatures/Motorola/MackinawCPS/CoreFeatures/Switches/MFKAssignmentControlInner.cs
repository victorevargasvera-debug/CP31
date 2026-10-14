using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002B6 RID: 694
	[global::System.Serializable]
	public class MFKAssignmentControlInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003C46 RID: 15430
		// (get) Token: 0x060074F3 RID: 29939 RVA: 0x0069892C File Offset: 0x00696B2C
		public global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection MFKAssignmentControlInnerSection
		{
			get
			{
				short num = (short)1166540801;
				if (num != 0)
				{
				}
				num = (short)1331713373;
				short num2 = num;
				num = (short)41375069;
				switch (num2 == num)
				{
				}
				num = (short)1305804800;
				if (num != 0)
				{
				}
				num = (short)88473600;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection)base[10638];
			}
		}

		// Token: 0x060074F4 RID: 29940 RVA: 0x006989E4 File Offset: 0x00696BE4
		public MFKAssignmentControlInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黒鏔鳖律觚닜ꯞ胠釢鳤쟦ꫨ蓪菬鯮菰鳲駴", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MFKROTARYCONTROL;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060074F5 RID: 29941 RVA: 0x00698A30 File Offset: 0x00696C30
		protected MFKAssignmentControlInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("背觎髐蟔룖귘뫚꿜ꛞ쇠ꃢ諤触鷨駪苬菮", a_);
		}
	}
}
