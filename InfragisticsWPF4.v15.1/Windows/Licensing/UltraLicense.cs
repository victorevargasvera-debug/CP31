using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x02000219 RID: 537
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class UltraLicense : global::System.ComponentModel.License
	{
		// Token: 0x06001451 RID: 5201 RVA: 0x00048972 File Offset: 0x00046B72
		internal UltraLicense(string componentName, global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions) : this(new global::Infragistics.Windows.Licensing.UltraLicenseInfo(componentName, productInfo, licenseOptions))
		{
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00048982 File Offset: 0x00046B82
		internal UltraLicense(string componentName, global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo, string key, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions) : this(new global::Infragistics.Windows.Licensing.UltraLicenseInfo(componentName, productInfo, key, licenseOptions))
		{
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00048994 File Offset: 0x00046B94
		internal UltraLicense(global::Infragistics.Windows.Licensing.UltraLicenseInfo licenseInfo)
		{
			this.licenseInfo = licenseInfo;
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001454 RID: 5204 RVA: 0x000489A3 File Offset: 0x00046BA3
		public global::Infragistics.Windows.Licensing.UltraProductInfoBase ProductInfo
		{
			get
			{
				return this.licenseInfo.ProductInfo;
			}
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x000489B0 File Offset: 0x00046BB0
		public string ComponentName
		{
			get
			{
				return this.licenseInfo.ComponentName;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001456 RID: 5206 RVA: 0x000489C0 File Offset: 0x00046BC0
		public override string LicenseKey
		{
			get
			{
				string licenseKeyForDisplay = this.LicenseKeyForDisplay;
				if (this.licenseInfo.Key == null)
				{
					global::Infragistics.Windows.Licensing.UltraLicense.AddLicenseOptionsTokensToKey(ref licenseKeyForDisplay, this.licenseInfo.LicenseOptions);
				}
				return licenseKeyForDisplay;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x000489F4 File Offset: 0x00046BF4
		public string LicenseKeyForDisplay
		{
			get
			{
				return this.licenseInfo.Key ?? this.licenseInfo.ProductInfo.Key;
			}
		}

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001458 RID: 5208 RVA: 0x00048A18 File Offset: 0x00046C18
		public global::Infragistics.Windows.Licensing.LicenseOptions LicenseOptions
		{
			get
			{
				if (this.licenseInfo.LicenseOptions == global::Infragistics.Windows.Licensing.LicenseOptions.All)
				{
					return global::Infragistics.Windows.Licensing.LicenseOptions.All;
				}
				global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo = this.ProductInfo;
				if (productInfo is global::Infragistics.Windows.Licensing.BetaProductInfo && productInfo.Status == global::Infragistics.Windows.Licensing.LicenseStatus.BetaValid)
				{
					return global::Infragistics.Windows.Licensing.LicenseOptions.All;
				}
				return this.licenseInfo.LicenseOptions;
			}
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x00048A66 File Offset: 0x00046C66
		internal global::Infragistics.Windows.Licensing.UltraLicenseInfo LicenseInfo
		{
			get
			{
				return this.licenseInfo;
			}
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00048A6E File Offset: 0x00046C6E
		public override void Dispose()
		{
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00048A70 File Offset: 0x00046C70
		internal static void AddLicenseOptionsTokensToKey(ref string key, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions)
		{
			if (key != null)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(key);
				global::System.Array values = global::System.Enum.GetValues(typeof(global::Infragistics.Windows.Licensing.LicenseOptions));
				string[] names = global::System.Enum.GetNames(typeof(global::Infragistics.Windows.Licensing.LicenseOptions));
				for (int i = 0; i < values.Length; i++)
				{
					global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions2 = (global::Infragistics.Windows.Licensing.LicenseOptions)values.GetValue(i);
					if (licenseOptions2 != global::Infragistics.Windows.Licensing.LicenseOptions.None && licenseOptions2 != global::Infragistics.Windows.Licensing.LicenseOptions.All && (licenseOptions & licenseOptions2) == licenseOptions2)
					{
						stringBuilder.Append("_");
						stringBuilder.Append(names[i]);
					}
				}
				key = stringBuilder.ToString();
			}
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00048AFC File Offset: 0x00046CFC
		internal static global::Infragistics.Windows.Licensing.LicenseOptions ParseLicenseOptionsTokensFromKey(ref string key)
		{
			global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions = global::Infragistics.Windows.Licensing.LicenseOptions.All;
			if (key != null)
			{
				licenseOptions = global::Infragistics.Windows.Licensing.LicenseOptions.None;
				global::System.Array values = global::System.Enum.GetValues(typeof(global::Infragistics.Windows.Licensing.LicenseOptions));
				string[] names = global::System.Enum.GetNames(typeof(global::Infragistics.Windows.Licensing.LicenseOptions));
				for (int i = 0; i < values.Length; i++)
				{
					global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions2 = (global::Infragistics.Windows.Licensing.LicenseOptions)values.GetValue(i);
					if (licenseOptions2 != global::Infragistics.Windows.Licensing.LicenseOptions.None && licenseOptions2 != global::Infragistics.Windows.Licensing.LicenseOptions.All)
					{
						string text = string.Format("_{0}", names[i]);
						if (key.IndexOf(text) >= 0)
						{
							licenseOptions |= licenseOptions2;
							key = key.Replace(text, string.Empty);
						}
					}
				}
			}
			return licenseOptions;
		}

		// Token: 0x04000ABB RID: 2747
		private global::Infragistics.Windows.Licensing.UltraLicenseInfo licenseInfo;
	}
}
