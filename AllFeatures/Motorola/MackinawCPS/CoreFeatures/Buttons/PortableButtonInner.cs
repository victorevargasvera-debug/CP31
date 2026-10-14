using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000413 RID: 1043
	[global::System.Serializable]
	public class PortableButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x06008EB9 RID: 36537 RVA: 0x0086B244 File Offset: 0x00869444
		public global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection PortableButtonInnerSection
		{
			get
			{
				short num = (short)810024960;
				short num2 = num;
				num = (short)1901891817;
				short num3 = num;
				num = (short)275288297;
				switch (num3 == num)
				{
				}
				num = (short)1843855361;
				if (num != 0)
				{
				}
				num = (short)323682304;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection)base[10092];
			}
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x0086B300 File Offset: 0x00869500
		public PortableButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雅Ꟈ룉룋꿍닏뻑뇓髗꿙꣛ꫝ迟賡", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PORTABLEBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x0086B34C File Offset: 0x0086954C
		protected PortableButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("釀곂럄돆꣈꧊ꇌ꫎釒ꃔꏖ귘듚돜", a_);
		}
	}
}
