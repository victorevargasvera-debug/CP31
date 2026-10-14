using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000332 RID: 818
	[global::System.Serializable]
	public class DEKVIPInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700409B RID: 16539
		// (get) Token: 0x06007E3D RID: 32317 RVA: 0x0074625C File Offset: 0x0074445C
		public global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection DEKVIPInnerSection
		{
			get
			{
				short num = (short)1586233344;
				short num2 = num;
				num = (short)1562249031;
				short num3 = num;
				num = (short)322963271;
				switch (num3 == num)
				{
				}
				num = (short)2044592129;
				if (num != 0)
				{
				}
				num = (short)120455168;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection)base[10206];
			}
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x00746314 File Offset: 0x00744514
		public DEKVIPInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藀蛂軄鿈苊鷌", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DEKVIP;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x00746360 File Offset: 0x00744560
		protected DEKVIPInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("郓鏕鏗龎諛韝냟", a_);
		}
	}
}
