using System;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Index;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001E6 RID: 486
	public class PrimaryKeyIndexConfiguration
	{
		// Token: 0x060019AA RID: 6570 RVA: 0x00044A60 File Offset: 0x00042C60
		internal PrimaryKeyIndexConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration configuration)
		{
			this._configuration = configuration;
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00044A6F File Offset: 0x00042C6F
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimaryKeyIndexConfiguration IsClustered()
		{
			return this.IsClustered(true);
		}

		// Token: 0x060019AC RID: 6572 RVA: 0x00044A78 File Offset: 0x00042C78
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimaryKeyIndexConfiguration IsClustered(bool clustered)
		{
			this._configuration.IsClustered = new bool?(clustered);
			return this;
		}

		// Token: 0x060019AD RID: 6573 RVA: 0x00044A8C File Offset: 0x00042C8C
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimaryKeyIndexConfiguration HasName(string name)
		{
			this._configuration.Name = name;
			return this;
		}

		// Token: 0x04000A82 RID: 2690
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Index.IndexConfiguration _configuration;
	}
}
