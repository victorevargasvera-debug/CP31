using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E1 RID: 481
	[global::System.Serializable]
	public class SignalIndependentProductIndependentNonProgrammableButtonListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002B7F RID: 11135
		// (get) Token: 0x06005432 RID: 21554 RVA: 0x004C8E04 File Offset: 0x004C7004
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection SignalIndependentProductIndependentNonProgrammableButtonListInnerSection
		{
			get
			{
				short num = (short)1725562880;
				short num2 = num;
				num = (short)472776705;
				if (num != 0)
				{
				}
				num = (short)437751319;
				short num3 = num;
				num = (short)456560151;
				switch (num3 == num)
				{
				}
				num = (short)354091008;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection)base[10032];
			}
		}

		// Token: 0x06005433 RID: 21555 RVA: 0x004C8EBC File Offset: 0x004C70BC
		public SignalIndependentProductIndependentNonProgrammableButtonListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 5;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("闅ꇇ귉ꋋ꿍볏鷓룕볗뿙곛믝軟蛡臣裥鳧쫩볫鳭鿯雱至闵賷\udaf9뗻都擿朁球挅昇渉椋怍搏㈑娓礕瘗㜙䰛氝伟䔡嘣䜥䔧䜩䴫䰭尯圱ᐳ琵䴷丹䠻儽⸿扁ࡃ⽅㭇㹉", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTNONPROGRAMMABLEBUTTONLIST;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06005434 RID: 21556 RVA: 0x004C8F08 File Offset: 0x004C7108
		protected SignalIndependentProductIndependentNonProgrammableButtonListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("釁귃ꇅꛇꯉꃋ駏병냓돕꣗뿙닛뫝藟賡郣웥룧飩菫諭藯釱胳훵뇷铹飻鯽烿朁樃戅洇搉砋⸍帏紑稓㬕䠗栙猛礝刟䌡䤣䬥䤧䠩䀫䬭ု瀱䄳䈵䰷唹刻ḽి⭁㝃㉅", a_);
		}
	}
}
