using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x0200007A RID: 122
	public class FeatureSetInner : global::SpecialFeatures.Flashport.FeatureNode
	{
		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x000ACD90 File Offset: 0x000AAF90
		public global::SpecialFeatures.RadioFeatureSet.FeatureSetInnerSection FeatureSetInnerSection
		{
			get
			{
				short num = (short)1451742138;
				short num2 = num;
				num = (short)1491522490;
				switch (num2 == num)
				{
				}
				num = (short)572456961;
				if (num != 0)
				{
				}
				num = (short)834600960;
				if (num != 0)
				{
				}
				num = (short)1981612032;
				short num3 = num;
				return (global::SpecialFeatures.RadioFeatureSet.FeatureSetInnerSection)base[32];
			}
		}

		// Token: 0x060009BD RID: 2493 RVA: 0x000ACE44 File Offset: 0x000AB044
		internal FeatureSetInner(global::SpecialFeatures.Flashport.Recordset parent)
		{
			int a_ = 3;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삅ﮍ뒓얕ﶗ", a_);
			base.UIName = global::CommonResources.AppResources.Feature_Set;
			global::SpecialFeatures.RadioFeatureSet.FeatureSetInnerSection section = new global::SpecialFeatures.RadioFeatureSet.FeatureSetInnerSection(this);
			base.AddFeatureSection(section);
		}
	}
}
