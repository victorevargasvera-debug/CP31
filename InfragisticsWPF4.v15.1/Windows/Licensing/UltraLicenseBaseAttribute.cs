using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Infragistics.Windows.Licensing
{
	// Token: 0x020000BE RID: 190
	[global::System.AttributeUsage(global::System.AttributeTargets.Class)]
	[global::System.Runtime.InteropServices.ComVisible(false)]
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	public abstract class UltraLicenseBaseAttribute : global::System.Attribute
	{
		// Token: 0x06000711 RID: 1809 RVA: 0x0001A18A File Offset: 0x0001838A
		protected UltraLicenseBaseAttribute(string componentName)
		{
			if (!global::Infragistics.Windows.Utilities.HasSamePublicKey(base.GetType()))
			{
				throw new global::System.NotSupportedException(global::SR.GetString("LE_NotSupportedException_17"));
			}
			this.componentName = componentName;
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000712 RID: 1810 RVA: 0x0001A1B6 File Offset: 0x000183B6
		public string ComponentName
		{
			get
			{
				return this.componentName;
			}
		}

		// Token: 0x06000713 RID: 1811
		public abstract global::Infragistics.Windows.Licensing.UltraProductInfoBase[] GetLicensedWithProducts();

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x0001A1BE File Offset: 0x000183BE
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

		// Token: 0x06000715 RID: 1813 RVA: 0x0001A1F4 File Offset: 0x000183F4
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

		// Token: 0x04000396 RID: 918
		private string componentName;

		// Token: 0x04000397 RID: 919
		private global::System.Collections.ArrayList products;
	}
}
