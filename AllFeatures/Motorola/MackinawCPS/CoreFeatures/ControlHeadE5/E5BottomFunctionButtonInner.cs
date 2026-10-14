using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003F2 RID: 1010
	[global::System.Serializable]
	public class E5BottomFunctionButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17004725 RID: 18213
		// (get) Token: 0x06008CB2 RID: 36018 RVA: 0x00840F70 File Offset: 0x0083F170
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection E5BottomFunctionButtonInnerSection
		{
			get
			{
				short num = (short)594804736;
				short num2 = num;
				num = (short)2005337777;
				short num3 = num;
				num = (short)338101937;
				switch (num3 == num)
				{
				}
				num = (short)200998912;
				if (num != 0)
				{
				}
				num = (short)1309016065;
				if (num != 0)
				{
				}
				return base[10904] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection;
			}
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x00841028 File Offset: 0x0083F228
		public E5BottomFunctionButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诈꓊만믎뻐뻒釖곘뗚뻜ꯞ裠賢诤쟦맨駪苬裮菰鋲飴髶飸駺釼髾℀䄂瀄猆紈搊挌", a_);
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x00841074 File Offset: 0x0083F274
		protected E5BottomFunctionButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 12;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("迌ꃎꗐ꟒뫔뫖律鷚꣜뇞苠韢賤裦蟨쯪뷬鷮黰铲蟴零铸雺鳼鷾洀昂┄䔆簈缊礌怎缐", a_);
		}
	}
}
