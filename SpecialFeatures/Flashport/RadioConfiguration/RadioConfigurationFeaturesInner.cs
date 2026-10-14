using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.RadioConfiguration
{
	// Token: 0x020000CC RID: 204
	public class RadioConfigurationFeaturesInner : global::SpecialFeatures.Flashport.FeatureNode
	{
		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x00105E00 File Offset: 0x00104000
		public global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInnerSection RadioConfigurationFeaturesInnerSection
		{
			get
			{
				short num = (short)84926464;
				short num2 = num;
				num = (short)620027904;
				switch (num2 == num)
				{
				}
				num = (short)855965697;
				if (num != 0)
				{
				}
				num = (short)348585984;
				if (num != 0)
				{
				}
				num = (short)542834688;
				short num3 = num;
				return (global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInnerSection)base[3];
			}
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x00105EB4 File Offset: 0x001040B4
		internal RadioConfigurationFeaturesInner(global::SpecialFeatures.Flashport.Recordset parent)
		{
			int a_ = 19;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킕풗\udb99쾛횝쎟춡삣쎥袧즫쾭쒯잱욳펵쮷", a_);
			base.UIName = global::CommonResources.AppResources.FLASHcode_Features;
			global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInnerSection section = new global::SpecialFeatures.Flashport.RadioConfiguration.RadioConfigurationFeaturesInnerSection(this);
			base.AddFeatureSection(section);
		}
	}
}
