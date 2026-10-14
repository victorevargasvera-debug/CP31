using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020001F4 RID: 500
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public sealed class UnlicensedProductInfo : global::Infragistics.Windows.Licensing.UltraProductInfoBase
	{
		// Token: 0x060012CC RID: 4812 RVA: 0x000449BC File Offset: 0x00042BBC
		public UnlicensedProductInfo(string productName) : base(productName)
		{
		}

		// Token: 0x060012CD RID: 4813 RVA: 0x000449D0 File Offset: 0x00042BD0
		public UnlicensedProductInfo(string productName, global::Infragistics.Windows.Licensing.ProductType productType) : base(productName, productType)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x000449E5 File Offset: 0x00042BE5
		public override string Expiration
		{
			get
			{
				return "N/A";
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x060012CF RID: 4815 RVA: 0x000449EC File Offset: 0x00042BEC
		public override bool RequiresActivation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x000449EF File Offset: 0x00042BEF
		public override global::Infragistics.Windows.Licensing.LicenseStatus Status
		{
			get
			{
				return global::Infragistics.Windows.Licensing.LicenseStatus.Licensed;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x000449F3 File Offset: 0x00042BF3
		public override string Key
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x000449FA File Offset: 0x00042BFA
		public override string CompanyName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x00044A01 File Offset: 0x00042C01
		public override string UserName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x060012D4 RID: 4820 RVA: 0x00044A08 File Offset: 0x00042C08
		protected internal override bool IsKeyValid(string key)
		{
			return key == null || key == this.key;
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x060012D5 RID: 4821 RVA: 0x00044A1B File Offset: 0x00042C1B
		public override bool Expired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x040009B3 RID: 2483
		private string key = string.Empty;
	}
}
