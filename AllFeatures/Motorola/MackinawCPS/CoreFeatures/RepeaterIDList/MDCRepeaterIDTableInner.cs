using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x0200051A RID: 1306
	[global::System.Serializable]
	public class MDCRepeaterIDTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170058F6 RID: 22774
		// (get) Token: 0x0600B133 RID: 45363 RVA: 0x00A44404 File Offset: 0x00A42604
		public global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerSection MDCRepeaterIDTableInnerSection
		{
			get
			{
				short num = (short)885547819;
				short num2 = num;
				num = (short)1794597675;
				switch (num2 == num)
				{
				}
				num = (short)223084545;
				if (num != 0)
				{
				}
				num = (short)956956672;
				if (num != 0)
				{
				}
				num = (short)183435264;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerSection)base[10078];
			}
		}

		// Token: 0x0600B134 RID: 45364 RVA: 0x00A444BC File Offset: 0x00A426BC
		public MDCRepeaterIDTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苎闐郒藖볘ꯚ룜뻞闠蛢韤쟦ꃨ꿪췬믮郰釲駴鋶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MDCREPEATERIDTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.MDCRepeaterIDTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600B135 RID: 45365 RVA: 0x00A44508 File Offset: 0x00A42708
		protected MDCRepeaterIDTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛊觌賎臒냔Ꟗ볘뫚꧜뫞鏠쏢곤ꏦ짨뿪賬跮鷰雲", a_);
		}
	}
}
