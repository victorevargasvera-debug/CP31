using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000272 RID: 626
	[global::System.Serializable]
	public class BacklightColorsInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170039F7 RID: 14839
		// (get) Token: 0x0600702B RID: 28715 RVA: 0x0063D32C File Offset: 0x0063B52C
		public global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerSection BacklightColorsInnerSection
		{
			get
			{
				short num = (short)1125799883;
				short num2 = num;
				num = (short)1748719563;
				switch (num2 == num)
				{
				}
				num = (short)720830464;
				short num3 = num;
				num = (short)13762561;
				if (num != 0)
				{
				}
				num = (short)607387648;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerSection)base[10216];
			}
		}

		// Token: 0x0600702C RID: 28716 RVA: 0x0063D3E4 File Offset: 0x0063B5E4
		public BacklightColorsInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賍뇏뇑뿓뫕뇗뷙듛ꫝ샟ꇡ诣諥蟧飩", a_);
			base.UIName = global::CommonResources.AcgResources.ID_BACKLIGHTCOLOR;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600702D RID: 28717 RVA: 0x0063D430 File Offset: 0x0063B630
		protected BacklightColorsInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 6;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藆꣈꣊ꛌꏎ룐듒뷔ꏖ律飚닜돞軠釢", a_);
		}
	}
}
