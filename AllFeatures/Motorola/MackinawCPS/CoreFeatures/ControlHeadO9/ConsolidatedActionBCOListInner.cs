using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200034B RID: 843
	[global::System.Serializable]
	public class ConsolidatedActionBCOListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170041F5 RID: 16885
		// (get) Token: 0x06008111 RID: 33041 RVA: 0x00767B84 File Offset: 0x00765D84
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection ConsolidatedActionBCOListInnerSection
		{
			get
			{
				short num = (short)1817039392;
				short num2 = num;
				num = (short)1072747040;
				switch (num2 == num)
				{
				}
				num = (short)330694656;
				if (num != 0)
				{
				}
				num = (short)949288960;
				short num3 = num;
				num = (short)1603665921;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection)base[10623];
			}
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x00767C40 File Offset: 0x00765E40
		public ConsolidatedActionBCOListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胂꫄꧆뫈꓊ꇌꛎ뗐닒ꇔ닖뷘ﯚ鳜볞闠諢諤触짨ꧪ껬ꃮ퇰뿲鳴蓶跸", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONBCOLIST;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x00767C8C File Offset: 0x00765E8C
		protected ConsolidatedActionBCOListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 14;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賎뻐뷒ꛔ룖뗘닚맜뻞闠蛢臤쟦꣨裪駬蛮黰鷲헴뗶뫸듺\uddfc돾栀瀂焄", a_);
		}
	}
}
