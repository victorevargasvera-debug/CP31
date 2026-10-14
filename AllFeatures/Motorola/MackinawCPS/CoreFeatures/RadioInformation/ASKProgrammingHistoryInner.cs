using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x02000196 RID: 406
	[global::System.Serializable]
	public class ASKProgrammingHistoryInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x060044C1 RID: 17601 RVA: 0x003FBBE8 File Offset: 0x003F9DE8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection ASKProgrammingHistoryInnerSection
		{
			get
			{
				short num = (short)1100028215;
				short num2 = num;
				num = (short)481433911;
				switch (num2 == num)
				{
				}
				num = (short)1198981120;
				if (num != 0)
				{
				}
				num = (short)61014017;
				if (num != 0)
				{
				}
				num = (short)342491136;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection)base[10113];
			}
		}

		// Token: 0x060044C2 RID: 17602 RVA: 0x003FBCA4 File Offset: 0x003F9EA4
		public ASKProgrammingHistoryInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("菒꟔룖뻘꧚볜닞賠諢诤胦짨ꏪ蓬鳮藰鳲蟴軶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PROGRAMMINGHISTORY;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.ASKProgrammingHistoryInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060044C3 RID: 17603 RVA: 0x003FBCF0 File Offset: 0x003F9EF0
		protected ASKProgrammingHistoryInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 17;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苑ꛓ맕뿗꣙뷛돝跟诡諣臥죧ꋩ藫鷭蓯鷱蛳迵", a_);
		}
	}
}
