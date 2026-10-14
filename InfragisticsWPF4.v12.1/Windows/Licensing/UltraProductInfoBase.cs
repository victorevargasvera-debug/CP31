using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020001F0 RID: 496
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public abstract class UltraProductInfoBase
	{
		// Token: 0x0600128E RID: 4750 RVA: 0x00043424 File Offset: 0x00041624
		internal UltraProductInfoBase(string productName)
		{
			this.productName = productName;
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00043433 File Offset: 0x00041633
		internal UltraProductInfoBase(string productName, global::Infragistics.Windows.Licensing.ProductType productType)
		{
			this.productName = productName;
			this.productType = productType;
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001290 RID: 4752
		public abstract string Expiration { get; }

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001291 RID: 4753
		public abstract bool RequiresActivation { get; }

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00043449 File Offset: 0x00041649
		public string ProductName
		{
			get
			{
				return this.productName;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001293 RID: 4755
		public abstract bool Expired { get; }

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001294 RID: 4756
		public abstract global::Infragistics.Windows.Licensing.LicenseStatus Status { get; }

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001295 RID: 4757
		public abstract string Key { get; }

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001296 RID: 4758
		public abstract string CompanyName { get; }

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001297 RID: 4759
		public abstract string UserName { get; }

		// Token: 0x06001298 RID: 4760
		protected internal abstract bool IsKeyValid(string key);

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001299 RID: 4761 RVA: 0x00043451 File Offset: 0x00041651
		public global::Infragistics.Windows.Licensing.ProductType Type
		{
			get
			{
				return this.productType;
			}
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0004345C File Offset: 0x0004165C
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

		// Token: 0x0600129B RID: 4763 RVA: 0x0004350C File Offset: 0x0004170C
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

		// Token: 0x04000990 RID: 2448
		private string productName;

		// Token: 0x04000991 RID: 2449
		private global::Infragistics.Windows.Licensing.ProductType productType;
	}
}
