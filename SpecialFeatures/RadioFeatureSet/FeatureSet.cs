using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x02000079 RID: 121
	public sealed class FeatureSet : global::SpecialFeatures.Flashport.FeatureSection
	{
		// Token: 0x060009BA RID: 2490 RVA: 0x00002BA4 File Offset: 0x00000DA4
		internal FeatureSet(global::SpecialFeatures.Flashport.FeatureNode parent) : base(parent)
		{
			this.a = new global::SpecialFeatures.RadioFeatureSet.FeatureSetInnerRecset();
			base.EmbeddedRecset = this.a;
			this.a.ParentSection = this;
			this.Init();
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x000ACCB8 File Offset: 0x000AAEB8
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1607008257;
			if (num != 0)
			{
			}
			num = (short)1977405458;
			short num2 = num;
			num = (short)53399570;
			switch (num2 == num)
			{
			}
			num = (short)1105395712;
			if (num != 0)
			{
			}
			num = (short)807403520;
			short num3 = num;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튓聯얟芡쎥\udca7", a_);
			base.Id = 30;
			base.UIName = global::CommonResources.AppResources.Feature_Set;
		}

		// Token: 0x040003D9 RID: 985
		private global::SpecialFeatures.RadioFeatureSet.FeatureSetInnerRecset a;
	}
}
