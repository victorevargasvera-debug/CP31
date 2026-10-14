using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200021F RID: 543
	[global::System.Serializable]
	public class ControlHeadAliasListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600652E RID: 25902 RVA: 0x005AAF44 File Offset: 0x005A9144
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerSection ControlHeadAliasListInnerSection
		{
			get
			{
				short num = (short)1197735936;
				short num2 = num;
				num = (short)183504339;
				short num3 = num;
				num = (short)770182611;
				switch (num3 == num)
				{
				}
				num = (short)2101346305;
				if (num != 0)
				{
				}
				num = (short)1158283264;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerSection)base[10205];
			}
		}

		// Token: 0x0600652F RID: 25903 RVA: 0x005AAFFC File Offset: 0x005A91FC
		public ControlHeadAliasListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 4;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛄꣆ꟈ뿊뿌ꃎ뷐鷔닖룘뿚﷜點跠諢蓤铦짨꟪蓬鳮藰", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADALIASLIST;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06006530 RID: 25904 RVA: 0x005AB048 File Offset: 0x005A9248
		protected ControlHeadAliasListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 5;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("藅Ꟈ꓉룋볍뿏뻑黕뷗믙룛ﻝꇟ軡跣蟥鯧쫩ꃫ蟭華蛱", a_);
		}
	}
}
