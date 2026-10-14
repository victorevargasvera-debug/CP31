using System;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001EB RID: 491
	public abstract class CascadableNavigationPropertyConfiguration
	{
		// Token: 0x060019D6 RID: 6614 RVA: 0x00044EF4 File Offset: 0x000430F4
		internal CascadableNavigationPropertyConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration)
		{
			this._navigationPropertyConfiguration = navigationPropertyConfiguration;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x00044F03 File Offset: 0x00043103
		public void WillCascadeOnDelete()
		{
			this.WillCascadeOnDelete(true);
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x00044F0C File Offset: 0x0004310C
		public void WillCascadeOnDelete(bool value)
		{
			this._navigationPropertyConfiguration.DeleteAction = new global::System.Data.Entity.Core.Metadata.Edm.OperationAction?(value ? global::System.Data.Entity.Core.Metadata.Edm.OperationAction.Cascade : global::System.Data.Entity.Core.Metadata.Edm.OperationAction.None);
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x060019D9 RID: 6617 RVA: 0x00044F25 File Offset: 0x00043125
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration NavigationPropertyConfiguration
		{
			get
			{
				return this._navigationPropertyConfiguration;
			}
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x00044F2D File Offset: 0x0004312D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060019DB RID: 6619 RVA: 0x00044F35 File Offset: 0x00043135
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x00044F3E File Offset: 0x0004313E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x00044F46 File Offset: 0x00043146
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A86 RID: 2694
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration _navigationPropertyConfiguration;
	}
}
