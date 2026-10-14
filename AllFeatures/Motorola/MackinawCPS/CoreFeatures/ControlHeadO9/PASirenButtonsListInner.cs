using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200037B RID: 891
	[global::System.Serializable]
	public class PASirenButtonsListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004314 RID: 17172
		// (get) Token: 0x060083C0 RID: 33728 RVA: 0x007A7B28 File Offset: 0x007A5D28
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection PASirenButtonsListInnerSection
		{
			get
			{
				short num = (short)533790720;
				short num2 = num;
				num = (short)1354139121;
				short num3 = num;
				num = (short)289375729;
				switch (num3 == num)
				{
				}
				num = (short)1314455552;
				if (num != 0)
				{
				}
				num = (short)629538817;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection)base[10744];
			}
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x007A7BE0 File Offset: 0x007A5DE0
		public PASirenButtonsListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菒铔ﯚ軜뛞鏠蛢诤쟦ꯨ黪駬鯮黰鷲蛴", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PASIRENBUTTONS;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x007A7C2C File Offset: 0x007A5E2C
		protected PASirenButtonsListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("髉跋ￏ蟓뿕꫗뿙닛ﻝꋟ韡郣鋥蟧蓩鿫", a_);
		}
	}
}
