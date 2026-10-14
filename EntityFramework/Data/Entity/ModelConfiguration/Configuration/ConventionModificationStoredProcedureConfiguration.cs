using System;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D2 RID: 466
	public abstract class ConventionModificationStoredProcedureConfiguration
	{
		// Token: 0x0600186E RID: 6254 RVA: 0x000410DF File Offset: 0x0003F2DF
		internal ConventionModificationStoredProcedureConfiguration()
		{
		}

		// Token: 0x170005DF RID: 1503
		// (get) Token: 0x0600186F RID: 6255 RVA: 0x000410F2 File Offset: 0x0003F2F2
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x04000A64 RID: 2660
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration _configuration = new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration();
	}
}
