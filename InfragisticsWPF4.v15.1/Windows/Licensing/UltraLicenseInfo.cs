using System;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x0200021B RID: 539
	internal struct UltraLicenseInfo
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x00048B92 File Offset: 0x00046D92
		internal UltraLicenseInfo(string componentName, global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions)
		{
			this = new global::Infragistics.Windows.Licensing.UltraLicenseInfo(componentName, productInfo, null, licenseOptions);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00048B9E File Offset: 0x00046D9E
		internal UltraLicenseInfo(string componentName, global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo, string key, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions)
		{
			this.ProductInfo = productInfo;
			this.ComponentName = componentName;
			this.Key = key;
			this.LicenseOptions = licenseOptions;
		}

		// Token: 0x04000AC0 RID: 2752
		public global::Infragistics.Windows.Licensing.UltraProductInfoBase ProductInfo;

		// Token: 0x04000AC1 RID: 2753
		public string Key;

		// Token: 0x04000AC2 RID: 2754
		public string ComponentName;

		// Token: 0x04000AC3 RID: 2755
		public global::Infragistics.Windows.Licensing.LicenseOptions LicenseOptions;
	}
}
