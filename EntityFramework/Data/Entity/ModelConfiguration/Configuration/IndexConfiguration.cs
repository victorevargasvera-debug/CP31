using System;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Index;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001E5 RID: 485
	public class IndexConfiguration
	{
		// Token: 0x060019A4 RID: 6564 RVA: 0x00044A08 File Offset: 0x00042C08
		internal IndexConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration configuration)
		{
			this._configuration = configuration;
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00044A17 File Offset: 0x00042C17
		public global::System.Data.Entity.ModelConfiguration.Configuration.IndexConfiguration IsUnique()
		{
			return this.IsUnique(true);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00044A20 File Offset: 0x00042C20
		public global::System.Data.Entity.ModelConfiguration.Configuration.IndexConfiguration IsUnique(bool unique)
		{
			this._configuration.IsUnique = new bool?(unique);
			return this;
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x00044A34 File Offset: 0x00042C34
		public global::System.Data.Entity.ModelConfiguration.Configuration.IndexConfiguration IsClustered()
		{
			return this.IsClustered(true);
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x00044A3D File Offset: 0x00042C3D
		public global::System.Data.Entity.ModelConfiguration.Configuration.IndexConfiguration IsClustered(bool clustered)
		{
			this._configuration.IsClustered = new bool?(clustered);
			return this;
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x00044A51 File Offset: 0x00042C51
		public global::System.Data.Entity.ModelConfiguration.Configuration.IndexConfiguration HasName(string name)
		{
			this._configuration.Name = name;
			return this;
		}

		// Token: 0x04000A81 RID: 2689
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration _configuration;
	}
}
