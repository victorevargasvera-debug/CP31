using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x0200006F RID: 111
	public class ExtendedFeatureSetInner : global::SpecialFeatures.Flashport.FeatureNode
	{
		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x000A57B8 File Offset: 0x000A39B8
		public global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInnerSection ExtendedFeatureSetInnerSection
		{
			get
			{
				short num = (short)1934555793;
				short num2 = num;
				num = (short)319552145;
				switch (num2 == num)
				{
				}
				num = (short)1247477761;
				if (num != 0)
				{
				}
				num = (short)665321472;
				if (num != 0)
				{
				}
				num = (short)1698758656;
				short num3 = num;
				return (global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInnerSection)base[34];
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000A5870 File Offset: 0x000A3A70
		internal ExtendedFeatureSetInner(global::SpecialFeatures.Flashport.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힑ﶗﮝ쒟芡쎥즧\udea9\ud9ab\udcad햯銱펵첷", a_);
			base.UIName = global::CommonResources.AppResources.Extended_Feature_Set;
			global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInnerSection section = new global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInnerSection(this);
			base.AddFeatureSection(section);
		}
	}
}
