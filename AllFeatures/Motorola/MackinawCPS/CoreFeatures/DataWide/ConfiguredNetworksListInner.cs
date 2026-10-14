using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004C3 RID: 1219
	[global::System.Serializable]
	public class ConfiguredNetworksListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005055 RID: 20565
		// (get) Token: 0x0600A020 RID: 40992 RVA: 0x00955B40 File Offset: 0x00953D40
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection ConfiguredNetworksListInnerSection
		{
			get
			{
				short num = (short)1840783869;
				short num2 = num;
				num = (short)834544125;
				switch (num2 == num)
				{
				}
				num = (short)2051538944;
				short num3 = num;
				num = (short)1623851009;
				if (num != 0)
				{
				}
				num = (short)1376452608;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection)base[10794];
			}
		}

		// Token: 0x0600A021 RID: 40993 RVA: 0x00955BF8 File Offset: 0x00953DF8
		public ConfiguredNetworksListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("賎뻐뷒돔뻖뻘껚꿜뫞藠쏢ꯤ苦鷨鳪苬鷮髰胲헴믶郸裺觼", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONFIGUREDNETWORKSLIST;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600A022 RID: 40994 RVA: 0x00955C44 File Offset: 0x00953E44
		protected ConfiguredNetworksListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏏뷑뫓냕뇗뷙꧛곝藟蛡쓣꣥跧黩鯫臭苯駱蟳훵듷鏹迻諽", a_);
		}
	}
}
