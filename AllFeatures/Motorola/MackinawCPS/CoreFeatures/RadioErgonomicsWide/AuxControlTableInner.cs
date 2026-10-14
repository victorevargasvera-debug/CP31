using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200021A RID: 538
	[global::System.Serializable]
	public class AuxControlTableInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17003397 RID: 13207
		// (get) Token: 0x06006351 RID: 25425 RVA: 0x0058E928 File Offset: 0x0058CB28
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection AuxControlTableInnerSection
		{
			get
			{
				short num = (short)699072513;
				if (num != 0)
				{
				}
				num = (short)1832361431;
				short num2 = num;
				num = (short)121609687;
				switch (num2 == num)
				{
				}
				num = (short)1581973504;
				short num3 = num;
				num = (short)758710272;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection)base[10634];
			}
		}

		// Token: 0x06006352 RID: 25426 RVA: 0x0058E9E0 File Offset: 0x0058CBE0
		public AuxControlTableInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 17;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鏑ꇓ껕駙돛냝铟郡诣諥죧뻩跫賭鳯韱", a_);
			base.UIName = global::CommonResources.AcgResources.ID_AUXCONTROLTABLE;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x06006353 RID: 25427 RVA: 0x0058EA2C File Offset: 0x0058CC2C
		protected AuxControlTableInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 9;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诉맋뛍金믓룕곗꣙돛닝샟뛡藣蓥蓧迩", a_);
		}
	}
}
