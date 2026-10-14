using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E9 RID: 489
	[global::System.Serializable]
	public class TrunkingProductIndependentButtonListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x0600553A RID: 21818 RVA: 0x004D54E8 File Offset: 0x004D36E8
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerSection TrunkingProductIndependentButtonListInnerSection
		{
			get
			{
				short num = (short)1789750280;
				short num2 = num;
				num = (short)1096641544;
				switch (num2 == num)
				{
				}
				num = (short)360579072;
				short num3 = num;
				num = (short)664141825;
				if (num != 0)
				{
				}
				num = (short)1670905856;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerSection)base[10028];
			}
		}

		// Token: 0x0600553B RID: 21819 RVA: 0x004D55A0 File Offset: 0x004D37A0
		public TrunkingProductIndependentButtonListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯎ꏐꛒ믔볖냘뗚뫜￞뇠釢諤菦鳨裪駬쿮룰鷲釴鋶觸黺鏼鯾搀洂焄✆䬈縊礌笎縐紒㔔嬖瀘栚検", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGPRODUCTINDEPENDENTBUTTONLIST;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.TrunkingProductIndependentButtonListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600553C RID: 21820 RVA: 0x004D55EC File Offset: 0x004D37EC
		protected TrunkingProductIndependentButtonListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("駌뷎ꓐ뷒뻔뻖럘볚﷜连鏠賢臤鋦諨鿪췬ꛮ鿰韲郴蟶鳸闺駼髾漀眂┄䔆簈缊礌怎缐㌒夔縖樘漚", a_);
		}
	}
}
