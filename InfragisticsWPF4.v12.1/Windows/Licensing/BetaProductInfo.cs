using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020001F1 RID: 497
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class BetaProductInfo : global::Infragistics.Windows.Licensing.UltraProductInfoBase
	{
		// Token: 0x0600129C RID: 4764 RVA: 0x000435AC File Offset: 0x000417AC
		public BetaProductInfo(string productName, global::System.DateTime expirationDate) : base(productName)
		{
			this.expirationDate = expirationDate;
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x000435CC File Offset: 0x000417CC
		public BetaProductInfo(string productName, global::System.DateTime expirationDate, global::Infragistics.Windows.Licensing.ProductType productType) : base(productName, productType)
		{
			this.expirationDate = expirationDate;
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x0600129E RID: 4766 RVA: 0x000435ED File Offset: 0x000417ED
		public override string Expiration
		{
			get
			{
				return this.expirationDate.ToLongDateString();
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x0600129F RID: 4767 RVA: 0x000435FA File Offset: 0x000417FA
		public override bool RequiresActivation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x000435FD File Offset: 0x000417FD
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

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x060012A1 RID: 4769 RVA: 0x0004360A File Offset: 0x0004180A
		public override string Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00043612 File Offset: 0x00041812
		public override string CompanyName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00043619 File Offset: 0x00041819
		public override string UserName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x060012A4 RID: 4772 RVA: 0x00043620 File Offset: 0x00041820
		protected internal override bool IsKeyValid(string key)
		{
			return key == null || key == this.key;
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x060012A5 RID: 4773 RVA: 0x00043633 File Offset: 0x00041833
		public override bool Expired
		{
			get
			{
				return global::System.DateTime.Today > this.expirationDate;
			}
		}

		// Token: 0x04000992 RID: 2450
		internal static readonly char[] BETAKEY = new char[]
		{
			'B',
			'e',
			't',
			'a'
		};

		// Token: 0x04000993 RID: 2451
		private global::System.DateTime expirationDate;

		// Token: 0x04000994 RID: 2452
		private string key = new string(global::Infragistics.Windows.Licensing.BetaProductInfo.BETAKEY);
	}
}
