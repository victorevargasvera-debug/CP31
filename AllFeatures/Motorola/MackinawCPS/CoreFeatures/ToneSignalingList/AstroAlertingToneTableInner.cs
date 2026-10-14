using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ToneSignalingList
{
	// Token: 0x020001BC RID: 444
	[global::System.Serializable]
	public class AstroAlertingToneTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002A8E RID: 10894
		// (get) Token: 0x060051F6 RID: 20982 RVA: 0x004A8080 File Offset: 0x004A6280
		public global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerSection AstroAlertingToneTableInnerSection
		{
			get
			{
				short num = (short)171808058;
				short num2 = num;
				num = (short)120558906;
				switch (num2 == num)
				{
				}
				num = (short)608501760;
				short num3 = num;
				num = (short)922288129;
				if (num != 0)
				{
				}
				num = (short)1955790848;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerSection)base[10788];
			}
		}

		// Token: 0x060051F7 RID: 20983 RVA: 0x004A8138 File Offset: 0x004A6338
		public AstroAlertingToneTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鋅Ꟈ꓉꧋菏믑돓룕맗뛙뗛냝蟟싡냣蟥諧蛩觫", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TONESIGNALINGTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ToneSignalingList.AstroAlertingToneTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060051F8 RID: 20984 RVA: 0x004A8184 File Offset: 0x004A6384
		protected AstroAlertingToneTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胓맕뛗뿙ﳛ距觟藡諣蟥蓧菩苫觭탯꛱闳铵铷鿹", a_);
		}
	}
}
