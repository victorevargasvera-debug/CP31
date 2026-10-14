using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000509 RID: 1289
	[global::System.Serializable]
	public class EIDBypassListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005565 RID: 21861
		// (get) Token: 0x0600AAA1 RID: 43681 RVA: 0x009F2D14 File Offset: 0x009F0F14
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection EIDBypassListInnerSection
		{
			get
			{
				short num = (short)309198848;
				short num2 = num;
				num = (short)829993129;
				short num3 = num;
				num = (short)841068713;
				switch (num3 == num)
				{
				}
				num = (short)535887872;
				if (num != 0)
				{
				}
				num = (short)854261761;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection)base[10602];
			}
		}

		// Token: 0x0600AAA2 RID: 43682 RVA: 0x009F2DD0 File Offset: 0x009F0FD0
		public EIDBypassListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诈닊뷌껎ꋐꃒ鯖냘꣚꧜", a_);
			base.UIName = global::CommonResources.AcgResources.ID_BYPASSLIST;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600AAA3 RID: 43683 RVA: 0x009F2E1C File Offset: 0x009F101C
		protected EIDBypassListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 17;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("郑귓ꛕ맗꧙꿛ﻝ곟诡韣鋥", a_);
		}
	}
}
