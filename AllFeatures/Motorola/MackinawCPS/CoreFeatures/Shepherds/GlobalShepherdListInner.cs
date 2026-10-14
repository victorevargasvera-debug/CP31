using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001DB RID: 475
	[global::System.Serializable]
	public class GlobalShepherdListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002B53 RID: 11091
		// (get) Token: 0x060053B9 RID: 21433 RVA: 0x004C00E8 File Offset: 0x004BE2E8
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerSection GlobalShepherdListInnerSection
		{
			get
			{
				short num = (short)1192493056;
				short num2 = num;
				num = (short)829526235;
				short num3 = num;
				num = (short)1908969691;
				switch (num3 == num)
				{
				}
				num = (short)1982201857;
				if (num != 0)
				{
				}
				num = (short)1766064128;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerSection)base[10034];
			}
		}

		// Token: 0x060053BA RID: 21434 RVA: 0x004C01A4 File Offset: 0x004BE3A4
		public GlobalShepherdListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 1;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藁ꣃ꧅꫇ꯉꃋ菏뫑뇓ꛕ냗뿙껛뫝샟껡跣闥鳧", a_);
			base.UIName = global::CommonResources.AcgResources.ID_GLOBALSHEPHERDLIST;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.GlobalShepherdListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060053BB RID: 21435 RVA: 0x004C01F0 File Offset: 0x004BE3F0
		protected GlobalShepherdListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诋ꋍ뿏냑뗓뫕觙듛믝郟諡臣铥賧쫩ꃫ蟭華蛱", a_);
		}
	}
}
