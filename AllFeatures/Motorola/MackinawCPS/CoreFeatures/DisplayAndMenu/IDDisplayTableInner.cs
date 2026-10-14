using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x0200028E RID: 654
	[global::System.Serializable]
	public class IDDisplayTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003B6E RID: 15214
		// (get) Token: 0x06007316 RID: 29462 RVA: 0x00664094 File Offset: 0x00662294
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerSection IDDisplayTableInnerSection
		{
			get
			{
				short num = (short)1602748416;
				short num2 = num;
				num = (short)1398804162;
				short num3 = num;
				num = (short)23006914;
				switch (num3 == num)
				{
				}
				num = (short)1751515136;
				if (num != 0)
				{
				}
				num = (short)1310721;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerSection)base[10022];
			}
		}

		// Token: 0x06007317 RID: 29463 RVA: 0x0066414C File Offset: 0x0066234C
		public IDDisplayTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裀蟂菆ꃈ룊뷌ꏎ냐꫒菖룘맚뇜뫞", a_);
			base.UIName = global::CommonResources.AcgResources.ID_IDDISPLAYTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007318 RID: 29464 RVA: 0x00664198 File Offset: 0x00662398
		protected IDDisplayTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 13;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟍铏郓뿕ꯗ꫙냛뿝駟싡냣蟥諧蛩觫", a_);
		}
	}
}
