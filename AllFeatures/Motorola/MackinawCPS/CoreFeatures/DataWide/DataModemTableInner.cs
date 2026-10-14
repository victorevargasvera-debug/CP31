using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004CA RID: 1226
	[global::System.Serializable]
	public class DataModemTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005096 RID: 20630
		// (get) Token: 0x0600A0F3 RID: 41203 RVA: 0x009672D0 File Offset: 0x009654D0
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection DataModemTableInnerSection
		{
			get
			{
				short num = (short)1816288753;
				short num2 = num;
				num = (short)1851284977;
				switch (num2 == num)
				{
				}
				num = (short)1755054080;
				short num3 = num;
				num = (short)1445789697;
				if (num != 0)
				{
				}
				num = (short)1795227648;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection)base[10851];
			}
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x00967390 File Offset: 0x00965590
		public DataModemTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏駓맕볗뿙뇛ﻝ듟菡蛣諥跧", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATAMODEMTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x009673DC File Offset: 0x009655DC
		protected DataModemTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蟂꓄돆꣈背ꃎ뗐뛒룔跘뫚뿜돞蓠", a_);
		}
	}
}
