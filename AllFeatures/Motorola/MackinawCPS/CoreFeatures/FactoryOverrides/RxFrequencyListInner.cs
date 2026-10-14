using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000453 RID: 1107
	[global::System.Serializable]
	public class RxFrequencyListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004A7C RID: 19068
		// (get) Token: 0x060093EE RID: 37870 RVA: 0x008B6AB0 File Offset: 0x008B4CB0
		public global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerSection RxFrequencyListInnerSection
		{
			get
			{
				short num = (short)987148760;
				short num2 = num;
				num = (short)520663512;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1380188160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2052718593;
				if (num != 0)
				{
				}
				num = (short)561315840;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerSection)base[10906];
			}
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x008B6B6C File Offset: 0x008B4D6C
		public RxFrequencyListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 19;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛓껕鳙껛믝釟韡臣裥诧鏩쳫ꋭ駯臱胳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYLIST;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x008B6BB8 File Offset: 0x008B4DB8
		protected RxFrequencyListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("飉듋雏ꃑ뇓ꟕ귗뿙닛뷝駟싡꣣迥鯧黩", a_);
		}
	}
}
