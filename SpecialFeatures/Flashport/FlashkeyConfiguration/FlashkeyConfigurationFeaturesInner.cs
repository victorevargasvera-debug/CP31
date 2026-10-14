using System;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashkeyConfiguration
{
	// Token: 0x02000108 RID: 264
	public class FlashkeyConfigurationFeaturesInner : global::SpecialFeatures.Flashport.FeatureNode
	{
		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000E7B RID: 3707 RVA: 0x00147E88 File Offset: 0x00146088
		public global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInnerSection FlashkeyConfigurationFeaturesInnerSection
		{
			get
			{
				short num = (short)1120534528;
				short num2 = num;
				num = (short)941096961;
				if (num != 0)
				{
				}
				num = (short)142806674;
				short num3 = num;
				num = (short)2025721490;
				switch (num3 == num)
				{
				}
				num = (short)728694784;
				if (num != 0)
				{
				}
				return (global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInnerSection)base[6];
			}
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00147F40 File Offset: 0x00146140
		internal FlashkeyConfigurationFeaturesInner(global::SpecialFeatures.Flashport.Recordset parent)
		{
			int a_ = 19;
			base..ctor(parent);
			base.FeatureName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킕풗\udb99쾛횝쎟춡삣쎥袧즫쾭쒯잱욳펵쮷", a_);
			base.UIName = global::CommonResources.AppResources.FLASHcode_Features;
			global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInnerSection section = new global::SpecialFeatures.Flashport.FlashkeyConfiguration.FlashkeyConfigurationFeaturesInnerSection(this);
			base.AddFeatureSection(section);
		}
	}
}
