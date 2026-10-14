using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200017E RID: 382
	[global::System.Serializable]
	public class RelockTimerInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06003E0C RID: 15884 RVA: 0x003AA1D8 File Offset: 0x003A83D8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerSection RelockTimerInnerSection
		{
			get
			{
				short num = (short)475806028;
				short num2 = num;
				num = (short)1448032588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)531824640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)880607232;
				if (num != 0)
				{
				}
				num = (short)1649868801;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerSection)base[10607];
			}
		}

		// Token: 0x06003E0D RID: 15885 RVA: 0x003AA290 File Offset: 0x003A8490
		public RelockTimerInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("飉꧋ꋍ뿏뇑뿓賗동뇛믝鋟", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RELOCKTIMER;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06003E0E RID: 15886 RVA: 0x003AA2DC File Offset: 0x003A84DC
		protected RelockTimerInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("釂ꃄꯆꛈ꣊ꛌ藐뫒룔닖ꯘ", a_);
		}
	}
}
