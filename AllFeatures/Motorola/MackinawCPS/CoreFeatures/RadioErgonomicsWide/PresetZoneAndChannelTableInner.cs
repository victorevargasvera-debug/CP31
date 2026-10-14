using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200023D RID: 573
	[global::System.Serializable]
	public class PresetZoneAndChannelTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600679C RID: 26524 RVA: 0x005C8E50 File Offset: 0x005C7050
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerSection PresetZoneAndChannelTableInnerSection
		{
			get
			{
				short num = (short)588186385;
				short num2 = num;
				num = (short)505283345;
				switch (num2 == num)
				{
				}
				num = (short)528809984;
				short num3 = num;
				num = (short)1876426753;
				if (num != 0)
				{
				}
				num = (short)1394868224;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerSection)base[10641];
			}
		}

		// Token: 0x0600679D RID: 26525 RVA: 0x005C8F08 File Offset: 0x005C7108
		public PresetZoneAndChannelTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 17;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苑ꛓ돕ꯗ뿙꣛ﻝ뫟跡諣菥죧诩苫諭탯뇱鳳韵雷铹駻鋽⃿嘁攃搅搇漉", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PRESETZONEANDCHANNELTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600679E RID: 26526 RVA: 0x005C8F54 File Offset: 0x005C7154
		protected PresetZoneAndChannelTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏂럄ꋆ뫈껊만诐볒믔닖律뫚돜믞쇠ꃢ跤蛦蟨藪裬菮퇰ꟲ铴闶闸黺", a_);
		}
	}
}
