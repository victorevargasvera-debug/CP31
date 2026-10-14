using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020001E9 RID: 489
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public class UltraLicense : global::System.ComponentModel.License
	{
		// Token: 0x06001274 RID: 4724 RVA: 0x00042C16 File Offset: 0x00040E16
		internal UltraLicense(string componentName, global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions) : this(new global::Infragistics.Windows.Licensing.UltraLicenseInfo(componentName, productInfo, licenseOptions))
		{
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00042C26 File Offset: 0x00040E26
		internal UltraLicense(string componentName, global::Infragistics.Windows.Licensing.UltraProductInfoBase productInfo, string key, global::Infragistics.Windows.Licensing.LicenseOptions licenseOptions) : this(new global::Infragistics.Windows.Licensing.UltraLicenseInfo(componentName, productInfo, key, licenseOptions))
		{
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00042C38 File Offset: 0x00040E38
		internal UltraLicense(global::Infragistics.Windows.Licensing.UltraLicenseInfo licenseInfo)
		{
			this.licenseInfo = licenseInfo;
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001277 RID: 4727 RVA: 0x00042C47 File Offset: 0x00040E47
		public global::Infragistics.Windows.Licensing.UltraProductInfoBase ProductInfo
		{
			get
			{
				return this.licenseInfo.ProductInfo;
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001278 RID: 4728 RVA: 0x00042C54 File Offset: 0x00040E54
		public string ComponentName
		{
			get
			{
				return this.licenseInfo.ComponentName;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001279 RID: 4729 RVA: 0x00042C64 File Offset: 0x00040E64
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

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x0600127A RID: 4730 RVA: 0x00042C98 File Offset: 0x00040E98
		public string LicenseKeyForDisplay
		{
			get
			{
				return this.licenseInfo.Key ?? this.licenseInfo.ProductInfo.Key;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x0600127B RID: 4731 RVA: 0x00042CBC File Offset: 0x00040EBC
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

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00042D0A File Offset: 0x00040F0A
		internal global::Infragistics.Windows.Licensing.UltraLicenseInfo LicenseInfo
		{
			get
			{
				return this.licenseInfo;
			}
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x00042D12 File Offset: 0x00040F12
		public override void Dispose()
		{
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x00042D14 File Offset: 0x00040F14
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

		// Token: 0x0600127F RID: 4735 RVA: 0x00042DA0 File Offset: 0x00040FA0
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

		// Token: 0x04000970 RID: 2416
		private global::Infragistics.Windows.Licensing.UltraLicenseInfo licenseInfo;
	}
}
