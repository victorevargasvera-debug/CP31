using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000370 RID: 880
	[global::System.Serializable]
	public class O9DataButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004273 RID: 17011
		// (get) Token: 0x06008277 RID: 33399 RVA: 0x00798790 File Offset: 0x00796990
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection O9DataButtonInnerSection
		{
			get
			{
				short num = (short)1388314624;
				short num2 = num;
				num = (short)2128238297;
				short num3 = num;
				num = (short)1378440921;
				switch (num3 == num)
				{
				}
				num = (short)1032978433;
				if (num != 0)
				{
				}
				num = (short)1663959040;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection)base[10608];
			}
		}

		// Token: 0x06008278 RID: 33400 RVA: 0x00798848 File Offset: 0x00796A48
		public O9DataButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 6;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菆꣈뿊곌鏐ꛒꇔꏖ뛘뗚", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON_1;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008279 RID: 33401 RVA: 0x00798894 File Offset: 0x00796A94
		protected O9DataButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛁ꗃ닅꧇軋믍꓏ꛑ믓룕", a_);
		}
	}
}
