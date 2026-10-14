using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000402 RID: 1026
	[global::System.Serializable]
	public class DataButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170047A7 RID: 18343
		// (get) Token: 0x06008DF0 RID: 36336 RVA: 0x0085FD7C File Offset: 0x0085DF7C
		public global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection DataButtonInnerSection
		{
			get
			{
				short num = (short)1133445121;
				if (num != 0)
				{
				}
				num = (short)500746931;
				short num2 = num;
				num = (short)418958003;
				switch (num2 == num)
				{
				default:
				{
					num = (short)595329024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)404684800;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection)base[10090];
			}
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x0085FE34 File Offset: 0x0085E034
		public DataButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 14;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诎냐꟒듔律駚꣜ꯞ闠賢诤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATABUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x0085FE80 File Offset: 0x0085E080
		protected DataButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("郓럕곗믙ﳛﻝꋟ韡郣鋥蟧蓩", a_);
		}
	}
}
