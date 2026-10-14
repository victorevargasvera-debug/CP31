using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality
{
	// Token: 0x020005C6 RID: 1478
	[global::System.Serializable]
	public class OneTouchInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700649A RID: 25754
		// (get) Token: 0x0600C890 RID: 51344 RVA: 0x00BB72A8 File Offset: 0x00BB54A8
		public global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection OneTouchInnerSection
		{
			get
			{
				short num = (short)1212148939;
				short num2 = num;
				num = (short)769191115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124270080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1693122561;
				if (num != 0)
				{
				}
				num = (short)1550843904;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection)base[10146];
			}
		}

		// Token: 0x0600C891 RID: 51345 RVA: 0x00BB7360 File Offset: 0x00BB5560
		public OneTouchInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 7;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诇ꗉꋋ룍뗏병ꃓ뿕럗듙뷛닝샟귡諣菥죧뻩菫鯭鏯髱", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALONETOUCH;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.OneTouchInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x0600C892 RID: 51346 RVA: 0x00BB73AC File Offset: 0x00BB55AC
		protected OneTouchInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 17;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("金믓룕껗뿙닛ꫝ觟跡諣蟥蓧쫩ꏫ胭闯틱ꃳ駵跷駹铻", a_);
		}
	}
}
