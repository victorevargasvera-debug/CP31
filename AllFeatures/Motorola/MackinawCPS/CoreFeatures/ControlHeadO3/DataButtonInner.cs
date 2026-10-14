using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003BC RID: 956
	[global::System.Serializable]
	public class DataButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170045C5 RID: 17861
		// (get) Token: 0x06008998 RID: 35224 RVA: 0x0080BF34 File Offset: 0x0080A134
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection DataButtonInnerSection
		{
			get
			{
				short num = (short)1349419110;
				short num2 = num;
				num = (short)424181862;
				switch (num2 == num)
				{
				}
				num = (short)1651965953;
				if (num != 0)
				{
				}
				num = (short)1143734272;
				if (num != 0)
				{
				}
				num = (short)1320681472;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection)base[10212];
			}
		}

		// Token: 0x06008999 RID: 35225 RVA: 0x0080BFF0 File Offset: 0x0080A1F0
		public DataButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("軀菆꣈뿊곌鏐ꛒꇔꏖ뛘뗚", a_);
			base.UIName = global::CommonResources.AcgResources.ID_O3DATABUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600899A RID: 35226 RVA: 0x0080C03C File Offset: 0x0080A23C
		protected DataButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鳒鷘뫚꧜뻞쇠ꇢ郤鏦鷨蓪菬", a_);
		}
	}
}
