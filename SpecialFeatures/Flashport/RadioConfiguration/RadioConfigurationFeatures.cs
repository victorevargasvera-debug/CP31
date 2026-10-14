using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000CB RID: 203
	public sealed class RadioConfigurationFeatures : global::SpecialFeatures.Flashport.FeatureSection
	{
		// Token: 0x06000CA2 RID: 3234 RVA: 0x00002EEB File Offset: 0x000010EB
		internal RadioConfigurationFeatures(global::SpecialFeatures.Flashport.FeatureNode parent) : base(parent)
		{
			this.a = new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInnerRecset();
			base.EmbeddedRecset = this.a;
			this.a.ParentSection = this;
			this.Init();
			this.a();
			this.b = false;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00105B1C File Offset: 0x00103D1C
		private void a()
		{
			short num = (short)98262678;
			short num2 = num;
			num = (short)1630101142;
			switch (num2 == num)
			{
			}
			num = (short)1931542528;
			if (num != 0)
			{
			}
			num = (short)1483538433;
			if (num != 0)
			{
			}
			num = (short)1747124224;
			short num3 = num;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x00105BC4 File Offset: 0x00103DC4
		public override void Init()
		{
			int a_ = 0;
			short num = (short)1402212915;
			short num2 = num;
			num = (short)586879539;
			switch (num2 == num)
			{
			}
			num = (short)2074738689;
			if (num != 0)
			{
			}
			num = (short)233373696;
			if (num != 0)
			{
			}
			num = (short)964558848;
			short num3 = num;
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얂즄욆\uda88쎊떔톖ﲘ漢펠욢횤", a_);
			base.Id = 1;
			base.UIName = global::CommonResources.AppResources.FLASHcode_Features;
		}

		// Token: 0x17000466 RID: 1126
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x00105C9C File Offset: 0x00103E9C
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x00105D4C File Offset: 0x00103F4C
		public bool IsVisible
		{
			get
			{
				short num = (short)801949809;
				short num2 = num;
				num = (short)377473137;
				switch (num2 == num)
				{
				}
				num = (short)189923329;
				if (num != 0)
				{
				}
				num = (short)2103902208;
				if (num != 0)
				{
				}
				num = (short)1896808448;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)1760234654;
				short num2 = num;
				num = (short)235801758;
				switch (num2 == num)
				{
				}
				num = (short)1540947969;
				if (num != 0)
				{
				}
				num = (short)1476722688;
				if (num != 0)
				{
				}
				num = (short)673775616;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x0400062E RID: 1582
		private global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInnerRecset a;

		// Token: 0x0400062F RID: 1583
		private bool b;
	}
}
