using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020000A4 RID: 164
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	public abstract class UltraLicenseBaseAttribute : global::System.Attribute
	{
		// Token: 0x0600062D RID: 1581 RVA: 0x00016A6A File Offset: 0x00014C6A
		protected UltraLicenseBaseAttribute(string componentName)
		{
			if (!global::Infragistics.Windows.Utilities.HasSamePublicKey(base.GetType()))
			{
				throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_17"));
			}
			this.componentName = componentName;
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600062E RID: 1582 RVA: 0x00016A96 File Offset: 0x00014C96
		public string ComponentName
		{
			get
			{
				return this.componentName;
			}
		}

		// Token: 0x0600062F RID: 1583
		public abstract global::Infragistics.Windows.Licensing.UltraProductInfoBase[] GetLicensedWithProducts();

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000630 RID: 1584 RVA: 0x00016A9E File Offset: 0x00014C9E
		internal global::Infragistics.Windows.Licensing.UltraProductInfoBase[] AllProducts
		{
			get
			{
				if (this.products == null)
				{
					this.products = new global::System.Collections.ArrayList(3);
					this.LoadProductArray();
				}
				return (global::Infragistics.Windows.Licensing.UltraProductInfoBase[])this.products.ToArray(typeof(global::Infragistics.Windows.Licensing.UltraProductInfoBase));
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00016AD4 File Offset: 0x00014CD4
		private void LoadProductArray()
		{
			global::Infragistics.Windows.Licensing.UltraProductInfoBase[] licensedWithProducts = this.GetLicensedWithProducts();
			if (licensedWithProducts == null || licensedWithProducts.Length == 0)
			{
				return;
			}
			foreach (global::Infragistics.Windows.Licensing.UltraProductInfoBase ultraProductInfoBase in licensedWithProducts)
			{
				global::Infragistics.Windows.Licensing.UltraProductInfo ultraProductInfo = ultraProductInfoBase as global::Infragistics.Windows.Licensing.UltraProductInfo;
				if (ultraProductInfo == null)
				{
					this.products.Add(ultraProductInfoBase);
				}
				else
				{
					this.products.Add(ultraProductInfo);
					global::Infragistics.Windows.Licensing.UltraProductInfoBase[] allNewerProducts = ultraProductInfo.AllNewerProducts;
					if (allNewerProducts != null && allNewerProducts.Length > 0)
					{
						this.products.AddRange(allNewerProducts);
					}
				}
			}
		}

		// Token: 0x040002F4 RID: 756
		private string componentName;

		// Token: 0x040002F5 RID: 757
		private global::System.Collections.ArrayList products;
	}
}
