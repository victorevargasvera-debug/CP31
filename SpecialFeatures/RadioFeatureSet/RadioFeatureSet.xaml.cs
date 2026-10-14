using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x02000078 RID: 120
	public partial class RadioFeatureSet : FeatureNode
	{
		// Token: 0x060009B6 RID: 2486 RVA: 0x000ACA34 File Offset: 0x000AAC34
		internal RadioFeatureSet(Recordset parent)
		{
			int a_ = 17;
			base..ctor(parent);
			base.FeatureName = RptMgrErrorHandler.b("힓秊ﲗﾙ햟얡蒣춧쮩\ud8ab\udbad슯ힱ钳\uddb7캹", a_);
			base.UIName = AppResources.Codeplug_Feature_Set;
			base.AddFeatureSection(new General(this));
			base.AddFeatureSection(new FeatureSet(this));
			base.AddFeatureSection(new ExtendedFeatureSet(this));
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000ACA94 File Offset: 0x000AAC94
		public FeatureSet FeatureSet
		{
			get
			{
				short num = (short)835006167;
				short num2 = num;
				num = (short)2136026839;
				switch (num2 == num)
				{
				}
				num = (short)1864499201;
				if (num != 0)
				{
				}
				num = (short)1758658560;
				if (num != 0)
				{
				}
				num = (short)1953824768;
				short num3 = num;
				return (FeatureSet)base[30];
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x000ACB48 File Offset: 0x000AAD48
		public General General
		{
			get
			{
				short num = (short)1495481172;
				short num2 = num;
				num = (short)486619988;
				switch (num2 == num)
				{
				}
				num = (short)1289289728;
				if (num != 0)
				{
				}
				num = (short)1730936833;
				if (num != 0)
				{
				}
				num = (short)1775173632;
				short num3 = num;
				return (General)base[31];
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x000ACC00 File Offset: 0x000AAE00
		public ExtendedFeatureSet ExtendedFeatureSet
		{
			get
			{
				short num = (short)1806839905;
				short num2 = num;
				num = (short)1634545761;
				switch (num2 == num)
				{
				}
				num = (short)273809409;
				if (num != 0)
				{
				}
				num = (short)1382744064;
				if (num != 0)
				{
				}
				num = (short)94044160;
				short num3 = num;
				return (ExtendedFeatureSet)base[33];
			}
		}
	}
}
