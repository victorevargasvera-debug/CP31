using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000416 RID: 1046
	[global::System.Serializable]
	public class PortableSideUpDownArrowButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004875 RID: 18549
		// (get) Token: 0x06008F75 RID: 36725 RVA: 0x00874AE4 File Offset: 0x00872CE4
		public global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection PortableSideUpDownArrowButtonInnerSection
		{
			get
			{
				short num = (short)1102355648;
				short num2 = num;
				num = (short)187997376;
				switch (num2 == num)
				{
				}
				num = (short)1786839041;
				if (num != 0)
				{
				}
				num = (short)1511456768;
				short num3 = num;
				num = (short)1691090944;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection)base[10746];
			}
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x00874B9C File Offset: 0x00872D9C
		public PortableSideUpDownArrowButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闄꣆믈뿊곌귎뷐뛒蓖냘뿚룜￞든鏢엤ꏦ蛨鳪菬쿮냰臲蟴飶軸\udbfa뿼諾甀眂樄椆", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PORTABLESIDEUPDOWNARROWBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008F77 RID: 36727 RVA: 0x00874BE8 File Offset: 0x00872DE8
		protected PortableSideUpDownArrowButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駈꓊뿌믎냐뇒맔닖律裚드믞蓠쏢냤韦짨꿪苬飮鿰폲듴藶诸铺諼\udffe䌀瘂焄猆昈攊", a_);
		}
	}
}
