using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000343 RID: 835
	[global::System.Serializable]
	public class BottomFunctionButtonBCOListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004184 RID: 16772
		// (get) Token: 0x06008022 RID: 32802 RVA: 0x0075CA6C File Offset: 0x0075AC6C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection BottomFunctionButtonBCOListInnerSection
		{
			get
			{
				short num = (short)1044840449;
				if (num != 0)
				{
				}
				num = (short)1904464121;
				short num2 = num;
				num = (short)382783737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270270464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1019019264;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection)base[10629];
			}
		}

		// Token: 0x06008023 RID: 32803 RVA: 0x0075CB24 File Offset: 0x0075AD24
		public BottomFunctionButtonBCOListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 10;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("觊ꋌ믎ꗐ볒룔鿘껚돜볞闠諢諤触짨ꧪ飬鯮藰鳲鯴ퟶ미룺닼\udffe䴀樂瘄猆", a_);
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONBUTTONBCOLIST;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008024 RID: 32804 RVA: 0x0075CB70 File Offset: 0x0075AD70
		protected BottomFunctionButtonBCOListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("迌ꃎꗐ꟒뫔뫖律鷚꣜뇞苠韢賤裦蟨쯪꿬髮藰蟲髴駶\ud9f8맺뻼냾℀伂氄理紈", a_);
		}
	}
}
