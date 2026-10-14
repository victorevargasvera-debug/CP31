using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x0200041D RID: 1053
	[global::System.Serializable]
	public class ConsolidatedActionsInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170048AD RID: 18605
		// (get) Token: 0x06009005 RID: 36869 RVA: 0x0087D33C File Offset: 0x0087B53C
		public global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection ConsolidatedActionsInnerSection
		{
			get
			{
				short num = (short)425366787;
				short num2 = num;
				num = (short)545101059;
				switch (num2 == num)
				{
				}
				num = (short)441057280;
				short num3 = num;
				num = (short)1807482880;
				if (num != 0)
				{
				}
				num = (short)2124677121;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)base[10614];
			}
		}

		// Token: 0x06009006 RID: 36870 RVA: 0x0087D3F4 File Offset: 0x0087B5F4
		public ConsolidatedActionsInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苀곂ꯄ듆ꛈꟊ꓌ꯎ냐꟒냔돖律髚뻜ꯞ裠賢诤铦", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONS;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06009007 RID: 36871 RVA: 0x0087D440 File Offset: 0x0087B640
		protected ConsolidatedActionsInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韓맕뛗꧙돛닝觟蛡藣鋥跧軩쳫꿭鏯蛱鷳駵雷觹", a_);
		}
	}
}
