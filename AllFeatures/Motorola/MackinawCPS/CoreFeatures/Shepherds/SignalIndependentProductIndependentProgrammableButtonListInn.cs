using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001E5 RID: 485
	[global::System.Serializable]
	public class SignalIndependentProductIndependentProgrammableButtonListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x060054B6 RID: 21686 RVA: 0x004CF10C File Offset: 0x004CD30C
		public global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerSection SignalIndependentProductIndependentProgrammableButtonListInnerSection
		{
			get
			{
				short num = (short)345700661;
				short num2 = num;
				num = (short)775289141;
				switch (num2 == num)
				{
				}
				num = (short)1231093760;
				short num3 = num;
				num = (short)1682374657;
				if (num != 0)
				{
				}
				num = (short)1693384704;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerSection)base[10030];
			}
		}

		// Token: 0x060054B7 RID: 21687 RVA: 0x004CF1C8 File Offset: 0x004CD3C8
		public SignalIndependentProductIndependentProgrammableButtonListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 7;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鯇ꏉꯋꃍ뇏뻑鿕뛗뻙맛껝藟賡胣菥蛧黩쳫뻭苯鷱郳菵鯷軹\udcfb럽滿昁愃瘅洇搉栋欍縏昑㐓䘕樗甙笛氝䄟伡䤣䜥䨧䘩䤫อ爯䜱䀳䈵圷吹᰻爽⤿ㅁぃ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SIGNALINDEPENDENTPRODUCTINDEPENDENTPROGRAMMABLEBUTTONLIST;
			global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060054B8 RID: 21688 RVA: 0x004CF214 File Offset: 0x004CD414
		protected SignalIndependentProductIndependentProgrammableButtonListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 15;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菏믑돓룕맗뛙ﳛ韝軟蛡臣雥跧蓩裫语黯蛱퓳꛵諷闹飻诽揿瘁␃伅昇渉椋縍甏簑瀓猕瘗渙㰛丝刟䴡䌣吥䤧䜩䄫伭刯帱儳ᘵ稷伹䠻䨽⼿ⱁ摃੅ⅇ㥉㡋", a_);
		}
	}
}
