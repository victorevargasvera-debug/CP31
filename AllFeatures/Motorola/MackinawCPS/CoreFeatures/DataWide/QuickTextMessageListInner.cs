using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004EC RID: 1260
	[global::System.Serializable]
	public class QuickTextMessageListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17005519 RID: 21785
		// (get) Token: 0x0600A974 RID: 43380 RVA: 0x009D4494 File Offset: 0x009D2694
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerSection QuickTextMessageListInnerSection
		{
			get
			{
				short num = (short)713872312;
				short num2 = num;
				num = (short)1598477240;
				switch (num2 == num)
				{
				}
				num = (short)528154625;
				if (num != 0)
				{
				}
				num = (short)1133510656;
				short num3 = num;
				num = (short)341770240;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerSection)base[10072];
			}
		}

		// Token: 0x0600A975 RID: 43381 RVA: 0x009D454C File Offset: 0x009D274C
		public QuickTextMessageListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("郀뛂계꓆ꋈ駌꫎꧐꟒髖볘꣚껜뻞蛠蛢엤ꯦ胨飪駬", a_);
			base.UIName = global::CommonResources.AcgResources.ID_QUICKTEXTMESSAGELIST;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600A976 RID: 43382 RVA: 0x009D4598 File Offset: 0x009D2798
		protected QuickTextMessageListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鳌뫎룐냒뻔跘뻚ꗜꯞ쇠껢胤铦髨諪諬諮퇰뿲鳴蓶跸", a_);
		}
	}
}
