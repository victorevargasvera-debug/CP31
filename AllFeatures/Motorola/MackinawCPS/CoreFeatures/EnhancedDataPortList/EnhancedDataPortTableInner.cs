using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004BF RID: 1215
	[global::System.Serializable]
	public class EnhancedDataPortTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700503E RID: 20542
		// (get) Token: 0x06009FE4 RID: 40932 RVA: 0x00952C80 File Offset: 0x00950E80
		public global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerSection EnhancedDataPortTableInnerSection
		{
			get
			{
				short num = (short)2029269334;
				short num2 = num;
				num = (short)331034966;
				switch (num2 == num)
				{
				}
				num = (short)1182007296;
				short num3 = num;
				num = (short)718274561;
				if (num != 0)
				{
				}
				num = (short)69992448;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerSection)base[10768];
			}
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x00952D3C File Offset: 0x00950F3C
		public EnhancedDataPortTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菅ꛇꋉ귋ꃍ돏럑냓鳗믙꣛뿝샟닡诣铥鳧쫩룫迭鋯黱釳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ENHANCEDDATAPORTTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x00952D88 File Offset: 0x00950F88
		protected EnhancedDataPortTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菅ꛇꋉ귋ꃍ돏럑냓鳗믙꣛뿝샟닡诣铥鳧쫩룫迭鋯黱釳", a_);
		}
	}
}
