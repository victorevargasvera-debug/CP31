using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000C9 RID: 201
	public partial class RadioConfiguration : FeatureNode
	{
		// Token: 0x06000C93 RID: 3219 RVA: 0x00104BD8 File Offset: 0x00102DD8
		internal RadioConfiguration(Recordset parent)
		{
			int a_ = 7;
			base..ctor(parent);
			base.FeatureName = RptMgrErrorHandler.b("\ud889憐﶑뒓햕瀞잟힡횣장\udca7쎩쎫삭", a_);
			base.UIName = AppResources.Radio_Configuration;
			base.AddFeatureSection(new RadioConfigurationFeatures(this));
			base.AddFeatureSection(new General(this));
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00104C2C File Offset: 0x00102E2C
		public RadioConfigurationFeatures RadioConfigurationFeatures
		{
			get
			{
				short num = (short)1726205989;
				short num2 = num;
				num = (short)1687212069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1104871424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1010892800;
				if (num != 0)
				{
				}
				num = (short)245956609;
				if (num != 0)
				{
				}
				return (RadioConfigurationFeatures)base[1];
			}
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000C95 RID: 3221 RVA: 0x00104CE0 File Offset: 0x00102EE0
		public General General
		{
			get
			{
				short num = (short)1089986961;
				short num2 = num;
				num = (short)121823633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1647706112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)708378625;
				if (num != 0)
				{
				}
				num = (short)820379648;
				if (num != 0)
				{
				}
				return (General)base[2];
			}
		}
	}
}
