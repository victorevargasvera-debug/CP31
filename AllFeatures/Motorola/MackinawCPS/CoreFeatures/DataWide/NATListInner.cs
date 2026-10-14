using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E6 RID: 1254
	[global::System.Serializable]
	public class NATListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700547E RID: 21630
		// (get) Token: 0x0600A83A RID: 43066 RVA: 0x009C5720 File Offset: 0x009C3920
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection NATListInnerSection
		{
			get
			{
				short num = (short)549903653;
				short num2 = num;
				num = (short)1954864421;
				switch (num2 == num)
				{
				}
				num = (short)403177473;
				if (num != 0)
				{
				}
				num = (short)151257088;
				short num3 = num;
				num = (short)1852637184;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection)base[10068];
			}
		}

		// Token: 0x0600A83B RID: 43067 RVA: 0x009C57DC File Offset: 0x009C39DC
		public NATListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 13;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胍量蛑髕뇗꧙꣛", a_);
			base.UIName = global::CommonResources.AcgResources.ID_NATLIST;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x009C5828 File Offset: 0x009C3A28
		protected NATListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 10;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藊賌鯎鿒볔ꓖ귘", a_);
		}
	}
}
