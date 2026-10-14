using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000069 RID: 105
	[global::System.Serializable]
	public class ChannelRangesMHzInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000A7D RID: 2685 RVA: 0x0009B4D8 File Offset: 0x000996D8
		public global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection ChannelRangesMHzInnerSection
		{
			get
			{
				short num = (short)683001726;
				short num2 = num;
				num = (short)442877822;
				switch (num2 == num)
				{
				}
				num = (short)535363585;
				if (num != 0)
				{
				}
				num = (short)918224896;
				short num3 = num;
				num = (short)1692925952;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection)base[10168];
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x0009B590 File Offset: 0x00099790
		public ChannelRangesMHzInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 19;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韓뻕맗듙닛믝賟싡뛣蟥蛧跩觫鷭탯\udaf1맳뻵苷폹", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELRANGESMHZ;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0009B5DC File Offset: 0x000997DC
		protected ChannelRangesMHzInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 3;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟃껅꧇꓉ꋋꯍ볏蛓럕뛗뷙맛귝샟쫡ꧣ껥鋧쏩", a_);
		}
	}
}
