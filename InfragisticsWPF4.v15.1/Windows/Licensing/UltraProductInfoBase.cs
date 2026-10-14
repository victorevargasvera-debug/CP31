using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x02000220 RID: 544
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public abstract class UltraProductInfoBase
	{
		// Token: 0x0600146B RID: 5227 RVA: 0x00049134 File Offset: 0x00047334
		internal UltraProductInfoBase(string productName)
		{
			this.productName = productName;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00049143 File Offset: 0x00047343
		internal UltraProductInfoBase(string productName, global::Infragistics.Windows.Licensing.ProductType productType)
		{
			this.productName = productName;
			this.productType = productType;
		}

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x0600146D RID: 5229
		public abstract string Expiration { get; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x0600146E RID: 5230
		public abstract bool RequiresActivation { get; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x0600146F RID: 5231 RVA: 0x00049159 File Offset: 0x00047359
		public string ProductName
		{
			get
			{
				return this.productName;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001470 RID: 5232
		public abstract bool Expired { get; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001471 RID: 5233
		public abstract global::Infragistics.Windows.Licensing.LicenseStatus Status { get; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001472 RID: 5234
		public abstract string Key { get; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001473 RID: 5235
		public abstract string CompanyName { get; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001474 RID: 5236
		public abstract string UserName { get; }

		// Token: 0x06001475 RID: 5237
		protected internal abstract bool IsKeyValid(string key);

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x00049161 File Offset: 0x00047361
		public global::Infragistics.Windows.Licensing.ProductType Type
		{
			get
			{
				return this.productType;
			}
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0004916C File Offset: 0x0004736C
		public string GetStatusText()
		{
			switch (this.Status)
			{
			case global::Infragistics.Windows.Licensing.LicenseStatus.Unchecked:
			case global::Infragistics.Windows.Licensing.LicenseStatus.RegKeyNotFound:
			case global::Infragistics.Windows.Licensing.LicenseStatus.CDKeyInvalid:
				return global::SR.GetUncustomizedString("AboutDialogLicenseDescriptionUnknown");
			case global::Infragistics.Windows.Licensing.LicenseStatus.BetaExpired:
				return global::SR.GetUncustomizedString("AboutDialogLicenseDescriptionBetaExpired");
			case global::Infragistics.Windows.Licensing.LicenseStatus.BetaValid:
				return global::SR.GetUncustomizedString("AboutDialogLicenseDescriptionBeta");
			case global::Infragistics.Windows.Licensing.LicenseStatus.TrialExpired:
				return global::SR.GetUncustomizedString("AboutDialogLicenseDescriptionTrialExpired");
			case global::Infragistics.Windows.Licensing.LicenseStatus.ActivationGracePeriodExpired:
				return global::SR.GetUncustomizedString("LDR_About_GraceExpired");
			case global::Infragistics.Windows.Licensing.LicenseStatus.CDKeyValid:
			case global::Infragistics.Windows.Licensing.LicenseStatus.Licensed:
				return global::SR.GetUncustomizedString("AboutDialogLicenseDescriptionLicensed");
			case global::Infragistics.Windows.Licensing.LicenseStatus.TrialValid:
				return global::SR.GetUncustomizedString("AboutDialogLicenseDescriptionTrial");
			case global::Infragistics.Windows.Licensing.LicenseStatus.ActivationGracePeriodValid:
				return global::SR.GetUncustomizedString("LDR_About_InGrace");
			}
			return string.Empty;
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0004921C File Offset: 0x0004741C
		public string GetKeyText()
		{
			string text = string.Empty;
			if (!string.IsNullOrEmpty(this.Key))
			{
				if (this.Key.Length != 18)
				{
					text = this.Key;
					if (text == "{Trial}")
					{
						text = global::SR.GetString("TrialKey_AboutDialogLabel");
					}
				}
				else
				{
					text = string.Concat(new string[]
					{
						this.Key.Substring(0, 4),
						"-",
						this.Key.Substring(4, 7),
						"-",
						this.Key.Substring(11, 7)
					});
				}
			}
			return text;
		}

		// Token: 0x04000ADB RID: 2779
		private string productName;

		// Token: 0x04000ADC RID: 2780
		private global::Infragistics.Windows.Licensing.ProductType productType;
	}
}
