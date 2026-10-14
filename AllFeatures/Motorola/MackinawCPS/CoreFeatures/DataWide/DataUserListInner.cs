using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004CF RID: 1231
	[global::System.Serializable]
	public class DataUserListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170051B6 RID: 20918
		// (get) Token: 0x0600A310 RID: 41744 RVA: 0x00980BA4 File Offset: 0x0097EDA4
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerSection DataUserListInnerSection
		{
			get
			{
				short num = (short)1218702269;
				short num2 = num;
				num = (short)167766973;
				switch (num2 == num)
				{
				}
				num = (short)1291780096;
				short num3 = num;
				num = (short)1885011969;
				if (num != 0)
				{
				}
				num = (short)214237184;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerSection)base[10070];
			}
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x00980C60 File Offset: 0x0097EE60
		public DataUserListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("铏돑ꃓ럕这꿛믝鋟싡꣣迥鯧黩", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATAUSERLIST;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x00980CAC File Offset: 0x0097EEAC
		protected DataUserListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軉귋뫍뇏臓ꗕ뷗꣙ﳛ鋝觟釡郣", a_);
		}
	}
}
