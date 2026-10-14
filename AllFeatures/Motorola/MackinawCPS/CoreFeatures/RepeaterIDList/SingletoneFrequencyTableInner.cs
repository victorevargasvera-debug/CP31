using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RepeaterIDList
{
	// Token: 0x02000520 RID: 1312
	[global::System.Serializable]
	public class SingletoneFrequencyTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005909 RID: 22793
		// (get) Token: 0x0600B179 RID: 45433 RVA: 0x00A48518 File Offset: 0x00A46718
		public global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerSection SingletoneFrequencyTableInnerSection
		{
			get
			{
				short num = (short)1373184431;
				short num2 = num;
				num = (short)498082223;
				switch (num2 == num)
				{
				}
				num = (short)1792802817;
				if (num != 0)
				{
				}
				num = (short)656932864;
				if (num != 0)
				{
				}
				num = (short)463077376;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerSection)base[10213];
			}
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x00A485D4 File Offset: 0x00A467D4
		public SingletoneFrequencyTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 11;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿋ꟍ뻏뗑룓돕곗뗙닛믝샟ꓡ難菥駧鿩觫胭鏯诱퓳ꋵ駷飹郻鯽", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SINGLETONEFREQUENCYTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RepeaterIDList.SingletoneFrequencyTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x00A48620 File Offset: 0x00A46820
		protected SingletoneFrequencyTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黌ꛎ뿐듒맔닖귘듚돜뫞쇠ꗢ韤苦飨黪裬臮鋰諲헴ꏶ飸駺釼髾", a_);
		}
	}
}
