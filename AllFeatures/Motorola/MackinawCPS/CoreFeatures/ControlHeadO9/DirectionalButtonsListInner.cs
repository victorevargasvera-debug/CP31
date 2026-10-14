using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200036A RID: 874
	[global::System.Serializable]
	public class DirectionalButtonsListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004215 RID: 16917
		// (get) Token: 0x060081BC RID: 33212 RVA: 0x0078FC14 File Offset: 0x0078DE14
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection DirectionalButtonsListInnerSection
		{
			get
			{
				short num = (short)1194237592;
				short num2 = num;
				num = (short)140811928;
				switch (num2 == num)
				{
				}
				num = (short)370802688;
				if (num != 0)
				{
				}
				num = (short)481427456;
				short num3 = num;
				num = (short)1278803969;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection)base[10610];
			}
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x0078FCD0 File Offset: 0x0078DED0
		public DirectionalButtonsListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藀ꫂ럄ꋆ꫈뿊꓌ꃎ뿐닒맔鯘껚꧜ꯞ軠跢雤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DIRECTIONALBUTTONS;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x0078FD1C File Offset: 0x0078DF1C
		protected DirectionalButtonsListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铏믑ꛓ돕믗껙뗛뇝軟菡裣웥ꫧ鿩飫髭鿯鳱蟳", a_);
		}
	}
}
