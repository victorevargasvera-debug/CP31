using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x02000224 RID: 548
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public sealed class UnlicensedProductInfo : global::Infragistics.Windows.Licensing.UltraProductInfoBase
	{
		// Token: 0x060014A9 RID: 5289 RVA: 0x0004A6CC File Offset: 0x000488CC
		public UnlicensedProductInfo(string productName) : base(productName)
		{
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0004A6E0 File Offset: 0x000488E0
		public UnlicensedProductInfo(string productName, global::Infragistics.Windows.Licensing.ProductType productType) : base(productName, productType)
		{
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0004A6F5 File Offset: 0x000488F5
		public override string Expiration
		{
			get
			{
				return "N/A";
			}
		}

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x060014AC RID: 5292 RVA: 0x0004A6FC File Offset: 0x000488FC
		public override bool RequiresActivation
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0004A6FF File Offset: 0x000488FF
		public override global::Infragistics.Windows.Licensing.LicenseStatus Status
		{
			get
			{
				return global::Infragistics.Windows.Licensing.LicenseStatus.Licensed;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x060014AE RID: 5294 RVA: 0x0004A703 File Offset: 0x00048903
		public override string Key
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x0004A70A File Offset: 0x0004890A
		public override string CompanyName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0004A711 File Offset: 0x00048911
		public override string UserName
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0004A718 File Offset: 0x00048918
		protected internal override bool IsKeyValid(string key)
		{
			return key == null || key == this.key;
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0004A72B File Offset: 0x0004892B
		public override bool Expired
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000AFE RID: 2814
		private string key = string.Empty;
	}
}
