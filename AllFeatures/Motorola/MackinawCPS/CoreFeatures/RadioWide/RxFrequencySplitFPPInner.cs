using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000182 RID: 386
	[global::System.Serializable]
	public class RxFrequencySplitFPPInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06003E5B RID: 15963 RVA: 0x003ADAAC File Offset: 0x003ABCAC
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection RxFrequencySplitFPPInnerSection
		{
			get
			{
				short num = (short)1263730689;
				if (num != 0)
				{
				}
				num = (short)1466737398;
				short num2 = num;
				num = (short)1871094518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1981546496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)234553344;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection)base[10097];
			}
		}

		// Token: 0x06003E5C RID: 15964 RVA: 0x003ADB64 File Offset: 0x003ABD64
		public RxFrequencySplitFPPInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苏꫑郕꫗뿙귛ꯝ藟賡蟣鿥죧맩鳫苭駯蛱퓳\udef5뻷꫹곻퟽", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCYSPLITFPP;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x003ADBB0 File Offset: 0x003ABDB0
		protected RxFrequencySplitFPPInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("黋뛍铑ꛓ돕꧗꿙맛냝菟鯡쓣뗥飧蛩藫髭탯\udaf1닳꛵ꣷ폹", a_);
		}
	}
}
