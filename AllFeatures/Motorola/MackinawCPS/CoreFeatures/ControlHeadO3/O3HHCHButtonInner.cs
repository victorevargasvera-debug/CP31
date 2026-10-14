using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003CB RID: 971
	[global::System.Serializable]
	public class O3HHCHButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700462B RID: 17963
		// (get) Token: 0x06008A5D RID: 35421 RVA: 0x00817404 File Offset: 0x00815604
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection O3HHCHButtonInnerSection
		{
			get
			{
				short num = (short)562783290;
				short num2 = num;
				num = (short)557474874;
				switch (num2 == num)
				{
				}
				num = (short)661258241;
				if (num != 0)
				{
				}
				num = (short)1310523392;
				short num3 = num;
				num = (short)468385792;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection)base[10210];
			}
		}

		// Token: 0x06008A5E RID: 35422 RVA: 0x008174BC File Offset: 0x008156BC
		public O3HHCHButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臍鳓黕鯗鋙ﳛ鳝闟雡郣觥蛧", a_);
			base.UIName = global::CommonResources.AcgResources.ID_O3HHCHBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008A5F RID: 35423 RVA: 0x00817508 File Offset: 0x00815708
		protected O3HHCHButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苌ﳎ鯒鷔铖釘ﯚ鿜꫞闠韢諤触", a_);
		}
	}
}
