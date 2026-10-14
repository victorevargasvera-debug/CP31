using System;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Migrations;
using System.Data.Entity.Utilities;

namespace System.Data.Entity
{
	// Token: 0x02000069 RID: 105
	public class MigrateDatabaseToLatestVersion<TContext, TMigrationsConfiguration> : global::System.Data.Entity.IDatabaseInitializer<TContext> where TContext : global::System.Data.Entity.DbContext where TMigrationsConfiguration : global::System.Data.Entity.Migrations.DbMigrationsConfiguration<TContext>, new()
	{
		// Token: 0x06000367 RID: 871 RVA: 0x0000B100 File Offset: 0x00009300
		static MigrateDatabaseToLatestVersion()
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(typeof(TContext));
		}

		// Token: 0x06000368 RID: 872 RVA: 0x0000B116 File Offset: 0x00009316
		public MigrateDatabaseToLatestVersion() : this(false)
		{
		}

		// Token: 0x06000369 RID: 873 RVA: 0x0000B11F File Offset: 0x0000931F
		public MigrateDatabaseToLatestVersion(bool useSuppliedContext) : this(useSuppliedContext, global::System.Activator.CreateInstance<TMigrationsConfiguration>())
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x0000B12D File Offset: 0x0000932D
		public MigrateDatabaseToLatestVersion(bool useSuppliedContext, TMigrationsConfiguration configuration)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TMigrationsConfiguration>(configuration, "configuration");
			this._config = configuration;
			this._useSuppliedContext = useSuppliedContext;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0000B154 File Offset: 0x00009354
		public MigrateDatabaseToLatestVersion(string connectionStringName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(connectionStringName, "connectionStringName");
			TMigrationsConfiguration tmigrationsConfiguration = global::System.Activator.CreateInstance<TMigrationsConfiguration>();
			tmigrationsConfiguration.TargetDatabase = new global::System.Data.Entity.Infrastructure.DbConnectionInfo(connectionStringName);
			this._config = tmigrationsConfiguration;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000B18C File Offset: 0x0000938C
		public virtual void InitializeDatabase(TContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TContext>(context, "context");
			new global::System.Data.Entity.Migrations.DbMigrator(this._config, this._useSuppliedContext ? context : default(TContext)).Update();
		}

		// Token: 0x040000CA RID: 202
		private readonly global::System.Data.Entity.Migrations.DbMigrationsConfiguration _config;

		// Token: 0x040000CB RID: 203
		private readonly bool _useSuppliedContext;
	}
}
