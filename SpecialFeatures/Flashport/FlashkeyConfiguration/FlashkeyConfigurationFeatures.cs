using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x02000107 RID: 263
	public sealed class FlashkeyConfigurationFeatures : global::SpecialFeatures.Flashport.FeatureSection
	{
		// Token: 0x06000E76 RID: 3702 RVA: 0x000032CB File Offset: 0x000014CB
		internal FlashkeyConfigurationFeatures(global::SpecialFeatures.Flashport.FeatureNode parent) : base(parent)
		{
			this.a = new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInnerRecset();
			base.EmbeddedRecset = this.a;
			this.a.ParentSection = this;
			this.Init();
			this.a();
			this.b = false;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00147BA8 File Offset: 0x00145DA8
		private void a()
		{
			short num = (short)1048903680;
			short num2 = num;
			num = (short)960888833;
			if (num != 0)
			{
			}
			num = (short)1897581963;
			short num3 = num;
			num = (short)1198968203;
			switch (num3 == num)
			{
			}
			num = (short)888864768;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00147C54 File Offset: 0x00145E54
		public override void Init()
		{
			int a_ = 10;
			short num = (short)1760231424;
			short num2 = num;
			num = (short)1381344603;
			short num3 = num;
			num = (short)465479003;
			switch (num3 == num)
			{
			}
			num = (short)1262682113;
			if (num != 0)
			{
			}
			num = (short)1004601344;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮌쎎킐삒\udd94ﾚ뾞욢쒤펦\udca8\ud9aa좬\udcae", a_);
			base.Id = 4;
			base.UIName = global::CommonResources.AppResources.FLASHcode_Features;
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000E79 RID: 3705 RVA: 0x00147D28 File Offset: 0x00145F28
		// (set) Token: 0x06000E7A RID: 3706 RVA: 0x00147DD8 File Offset: 0x00145FD8
		public bool IsVisible
		{
			get
			{
				short num = (short)956563456;
				short num2 = num;
				num = (short)692987177;
				short num3 = num;
				num = (short)1468933417;
				switch (num3 == num)
				{
				}
				num = (short)133955585;
				if (num != 0)
				{
				}
				num = (short)889716736;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)930807808;
				short num2 = num;
				num = (short)2116370584;
				short num3 = num;
				num = (short)682705048;
				switch (num3 == num)
				{
				}
				num = (short)440532993;
				if (num != 0)
				{
				}
				num = (short)1616838656;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x040007B7 RID: 1975
		private global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInnerRecset a;

		// Token: 0x040007B8 RID: 1976
		private bool b;
	}
}
