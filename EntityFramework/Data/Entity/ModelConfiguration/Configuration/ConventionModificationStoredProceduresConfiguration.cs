using System;
using System.ComponentModel;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D3 RID: 467
	public class ConventionModificationStoredProceduresConfiguration
	{
		// Token: 0x06001870 RID: 6256 RVA: 0x000410FA File Offset: 0x0003F2FA
		internal ConventionModificationStoredProceduresConfiguration(global::System.Type type)
		{
			this._type = type;
		}

		// Token: 0x170005E0 RID: 1504
		// (get) Token: 0x06001871 RID: 6257 RVA: 0x00041114 File Offset: 0x0003F314
		internal global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration Configuration
		{
			get
			{
				return this._configuration;
			}
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x0004111C File Offset: 0x0003F31C
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProceduresConfiguration Insert(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration> modificationStoredProcedureConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration>>(modificationStoredProcedureConfigurationAction, "modificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration conventionInsertModificationStoredProcedureConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration(this._type);
			modificationStoredProcedureConfigurationAction(conventionInsertModificationStoredProcedureConfiguration);
			this._configuration.Insert(conventionInsertModificationStoredProcedureConfiguration.Configuration);
			return this;
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x0004115C File Offset: 0x0003F35C
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProceduresConfiguration Update(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration> modificationStoredProcedureConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration>>(modificationStoredProcedureConfigurationAction, "modificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration conventionUpdateModificationStoredProcedureConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration(this._type);
			modificationStoredProcedureConfigurationAction(conventionUpdateModificationStoredProcedureConfiguration);
			this._configuration.Update(conventionUpdateModificationStoredProcedureConfiguration.Configuration);
			return this;
		}

		// Token: 0x06001874 RID: 6260 RVA: 0x0004119C File Offset: 0x0003F39C
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProceduresConfiguration Delete(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration> modificationStoredProcedureConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration>>(modificationStoredProcedureConfigurationAction, "modificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration conventionDeleteModificationStoredProcedureConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration(this._type);
			modificationStoredProcedureConfigurationAction(conventionDeleteModificationStoredProcedureConfiguration);
			this._configuration.Delete(conventionDeleteModificationStoredProcedureConfiguration.Configuration);
			return this;
		}

		// Token: 0x06001875 RID: 6261 RVA: 0x000411DA File Offset: 0x0003F3DA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x000411E2 File Offset: 0x0003F3E2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x000411EB File Offset: 0x0003F3EB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001878 RID: 6264 RVA: 0x000411F3 File Offset: 0x0003F3F3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A65 RID: 2661
		private readonly global::System.Type _type;

		// Token: 0x04000A66 RID: 2662
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration _configuration = new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration();
	}
}
