using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x02000221 RID: 545
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class BetaProductInfo : global::Infragistics.Windows.Licensing.UltraProductInfoBase
	{
		// Token: 0x06001479 RID: 5241 RVA: 0x000492BC File Offset: 0x000474BC
		public BetaProductInfo(string productName, global::System.DateTime expirationDate) : base(productName)
		{
			this.expirationDate = expirationDate;
		}

		// Token: 0x0600147A RID: 5242 RVA: 0x000492DC File Offset: 0x000474DC
		public BetaProductInfo(string productName, global::System.DateTime expirationDate, global::Infragistics.Windows.Licensing.ProductType productType) : base(productName, productType)
		{
			this.expirationDate = expirationDate;
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x000492FD File Offset: 0x000474FD
		public override string Expiration
		{
			get
			{
				return this.expirationDate.ToLongDateString();
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0004930A File Offset: 0x0004750A
		public override bool RequiresActivation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0004930D File Offset: 0x0004750D
		public override global::Infragistics.Windows.Licensing.LicenseStatus Status
		{
			get
			{
				if (this.Expired)
				{
					return global::Infragistics.Windows.Licensing.LicenseStatus.BetaExpired;
				}
				return global::Infragistics.Windows.Licensing.LicenseStatus.BetaValid;
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0004931A File Offset: 0x0004751A
		public override string Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x00049322 File Offset: 0x00047522
		public override string CompanyName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x00049329 File Offset: 0x00047529
		public override string UserName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x00049330 File Offset: 0x00047530
		protected internal override bool IsKeyValid(string key)
		{
			return key == null || key == this.key;
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x00049343 File Offset: 0x00047543
		public override bool Expired
		{
			get
			{
				return global::System.DateTime.Today > this.expirationDate;
			}
		}

		// Token: 0x04000ADD RID: 2781
		internal static readonly char[] BETAKEY = new char[]
		{
			'B',
			'e',
			't',
			'a'
		};

		// Token: 0x04000ADE RID: 2782
		private global::System.DateTime expirationDate;

		// Token: 0x04000ADF RID: 2783
		private string key = new string(global::Infragistics.Windows.Licensing.BetaProductInfo.BETAKEY);
	}
}
