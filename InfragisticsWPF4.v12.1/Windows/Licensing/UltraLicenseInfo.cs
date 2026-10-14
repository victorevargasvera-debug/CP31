using System;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020001EB RID: 491
	internal struct UltraLicenseInfo
	{
		// Token: 0x06001280 RID: 4736 RVA: 0x00042E36 File Offset: 0x00041036
		internal UltraLicenseInfo(string componentName, global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions)
		{
			this = new global::Infragistics.Windows.Licensing.UltraLicenseInfo(componentName, productInfo, null, licenseOptions);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00042E42 File Offset: 0x00041042
		internal UltraLicenseInfo(string componentName, global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo, string key, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions)
		{
			this.ProductInfo = productInfo;
			this.ComponentName = componentName;
			this.Key = key;
			this.LicenseOptions = licenseOptions;
		}

		// Token: 0x04000975 RID: 2421
		public global::Infragistics.Windows.Licensing.UltraProductInfoBase ProductInfo;

		// Token: 0x04000976 RID: 2422
		public string Key;

		// Token: 0x04000977 RID: 2423
		public string ComponentName;

		// Token: 0x04000978 RID: 2424
		public global::Infragistics.Windows.Licensing.LicenseOptions LicenseOptions;
	}
}
