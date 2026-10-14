using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x02000248 RID: 584
	[global::System.Serializable]
	public class PerAccListTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600686F RID: 26735 RVA: 0x005D7980 File Offset: 0x005D5B80
		public global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerSection PerAccListTableInnerSection
		{
			get
			{
				short num = (short)1777173131;
				short num2 = num;
				num = (short)552174219;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1339228160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541589505;
				if (num != 0)
				{
				}
				num = (short)541327360;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerSection)base[10814];
			}
		}

		// Token: 0x06006870 RID: 26736 RVA: 0x005D7A3C File Offset: 0x005D5C3C
		public PerAccListTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闄ꋆ믈룊ꋌꇎ뿐뛒맔飘룚뻜냞铠跢釤蛦诨苪臬蛮藰諲헴믶郸裺觼", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYLIST;
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06006871 RID: 26737 RVA: 0x005D7A88 File Offset: 0x005D5C88
		protected PerAccListTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鋁ꇃ듅믇ꗉꋋꃍ뗏뻑韕믗맙돛ꯝ軟雡藣蓥臧蛩藫髭觯틱룳鿵请軹", a_);
		}
	}
}
