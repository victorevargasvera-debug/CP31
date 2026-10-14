using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000514 RID: 1300
	[global::System.Serializable]
	public class TrunkingGroupIDListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170058DD RID: 22749
		// (get) Token: 0x0600B0EE RID: 45294 RVA: 0x00A412B8 File Offset: 0x00A3F4B8
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection TrunkingGroupIDListInnerSection
		{
			get
			{
				short num = (short)1069622629;
				short num2 = num;
				num = (short)1569989989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1718353920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)742260737;
				if (num != 0)
				{
				}
				num = (short)321912832;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection)base[10507];
			}
		}

		// Token: 0x0600B0EF RID: 45295 RVA: 0x00A41370 File Offset: 0x00A3F570
		public TrunkingGroupIDListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 12;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駌뷎ꓐ뷒뻔뻖럘볚﷜飞鏠賢郤韦짨ꋪꧬ쿮뷰髲蛴菶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGGROUPIDLIST;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600B0F0 RID: 45296 RVA: 0x00A413BC File Offset: 0x00A3F5BC
		protected TrunkingGroupIDListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雁뛃독ꛇꇉꗋꃍ럏鏓ꓕ럗꿙곛ﻝ꧟ꛡ쓣ꫥ臧駩飫", a_);
		}
	}
}
