using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x020004F2 RID: 1266
	[global::System.Serializable]
	public class DACListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005543 RID: 21827
		// (get) Token: 0x0600AA2C RID: 43564 RVA: 0x009E7978 File Offset: 0x009E5B78
		public global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection DACListInnerSection
		{
			get
			{
				short num = (short)1948643438;
				short num2 = num;
				num = (short)1939861614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1979514880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)228524033;
				if (num != 0)
				{
				}
				num = (short)423821312;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection)base[10506];
			}
		}

		// Token: 0x0600AA2D RID: 43565 RVA: 0x009E7A30 File Offset: 0x009E5C30
		public DACListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藅诇诉鳋铏鏑韓铗동꿛ꫝ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CCAPDACLIST;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600AA2E RID: 43566 RVA: 0x009E7A7C File Offset: 0x009E5C7C
		protected DACListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藅诇诉鳋铏鏑韓铗동꿛ꫝ", a_);
		}
	}
}
