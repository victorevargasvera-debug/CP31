using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x02000105 RID: 261
	public partial class FlashkeyConfiguration : FeatureNode
	{
		// Token: 0x06000E67 RID: 3687 RVA: 0x00146AA0 File Offset: 0x00144CA0
		internal FlashkeyConfiguration(Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = RptMgrErrorHandler.b("얂즄욆\uda88쎊뎒횔ﶚ풠톢쒤펦삨쒪쎬", a_);
			base.UIName = AppResources.FLASHkey_Configuration;
			base.AddFeatureSection(new FlashkeyConfigurationFeatures(this));
			base.AddFeatureSection(new General(this));
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x00146AF4 File Offset: 0x00144CF4
		public FlashkeyConfigurationFeatures FlashkeyConfigurationFeatures
		{
			get
			{
				short num = (short)296174567;
				short num2 = num;
				num = (short)1632322535;
				switch (num2 == num)
				{
				default:
				{
					num = (short)834469888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)989528065;
				if (num != 0)
				{
				}
				num = (short)45088768;
				if (num != 0)
				{
				}
				return (FlashkeyConfigurationFeatures)base[4];
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000E69 RID: 3689 RVA: 0x00146BA8 File Offset: 0x00144DA8
		public General General
		{
			get
			{
				short num = (short)218234881;
				if (num != 0)
				{
				}
				num = (short)520224768;
				short num2 = num;
				num = (short)2006155342;
				short num3 = num;
				num = (short)1007648846;
				switch (num3 == num)
				{
				}
				num = (short)1618804736;
				if (num != 0)
				{
				}
				return (General)base[5];
			}
		}
	}
}
