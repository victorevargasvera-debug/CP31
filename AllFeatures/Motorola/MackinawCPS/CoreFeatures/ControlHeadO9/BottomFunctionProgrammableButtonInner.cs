using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000347 RID: 839
	[global::System.Serializable]
	public class BottomFunctionProgrammableButtonInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x170041BE RID: 16830
		// (get) Token: 0x0600809F RID: 32927 RVA: 0x00762620 File Offset: 0x00760820
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection BottomFunctionProgrammableButtonInnerSection
		{
			get
			{
				short num = (short)301531136;
				short num2 = num;
				num = (short)1796378988;
				short num3 = num;
				num = (short)2013237612;
				switch (num3 == num)
				{
				}
				num = (short)356909057;
				if (num != 0)
				{
				}
				num = (short)209190912;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection)base[10619];
			}
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x007626D8 File Offset: 0x007608D8
		public BottomFunctionProgrammableButtonInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 9;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("裉ꏋ뫍꓏뷑맓黗꿙닛뷝铟诡诣裥죧뫩黫臭韯胱闳鯵闷鯹黻鋽旿∁䘃猅簇縉挋怍", a_);
			base.UIName = global::CommonResources.AcgResources.ID_BOTTOMFUNCTIONPROGRAMMABLEBUTTON;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x00762724 File Offset: 0x00760924
		protected BottomFunctionProgrammableButtonInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 7;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("談ꗉ룋뫍뿏뿑郕귗듙뿛ꫝ觟跡諣웥룧飩菫觭苯鏱駳鯵駷飹郻鯽⃿䀁焃爅簇攉戋", a_);
		}
	}
}
