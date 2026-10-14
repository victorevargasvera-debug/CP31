using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Xml.Linq;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000D7 RID: 215
	public class MigratorLoggingDecorator : global::System.Data.Entity.Migrations.Infrastructure.MigratorBase
	{
		// Token: 0x06001090 RID: 4240 RVA: 0x0002489F File Offset: 0x00022A9F
		public MigratorLoggingDecorator(global::System.Data.Entity.Migrations.Infrastructure.MigratorBase innerMigrator, global::System.Data.Entity.Migrations.Infrastructure.MigrationsLogger logger) : base(innerMigrator)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Infrastructure.MigratorBase>(innerMigrator, "innerMigrator");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Infrastructure.MigrationsLogger>(logger, "logger");
			this._logger = logger;
			this._logger.Verbose(global::System.Data.Entity.Resources.Strings.LoggingTargetDatabase(base.TargetDatabase));
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x000248DD File Offset: 0x00022ADD
		internal override void AutoMigrate(string migrationId, global::System.Data.Entity.Migrations.Infrastructure.VersionedModel sourceModel, global::System.Data.Entity.Migrations.Infrastructure.VersionedModel targetModel, bool downgrading)
		{
			this._logger.Info(downgrading ? global::System.Data.Entity.Resources.Strings.LoggingRevertAutoMigrate(migrationId) : global::System.Data.Entity.Resources.Strings.LoggingAutoMigrate(migrationId));
			base.AutoMigrate(migrationId, sourceModel, targetModel, downgrading);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00024908 File Offset: 0x00022B08
		internal override void ExecuteSql(global::System.Data.Entity.Migrations.Sql.MigrationStatement migrationStatement, global::System.Data.Common.DbConnection connection, global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			this._logger.Verbose(migrationStatement.Sql);
			global::System.Data.Entity.Core.Common.DbProviderServices providerServices = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(connection);
			if (providerServices != null)
			{
				providerServices.RegisterInfoMessageHandler(connection, delegate(string message)
				{
					if (!string.Equals(message, this._lastInfoMessage, global::System.StringComparison.OrdinalIgnoreCase))
					{
						this._logger.Warning(message);
						this._lastInfoMessage = message;
					}
				});
			}
			base.ExecuteSql(migrationStatement, connection, transaction, interceptionContext);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00024950 File Offset: 0x00022B50
		internal override void Upgrade(global::System.Collections.Generic.IEnumerable<string> pendingMigrations, string targetMigrationId, string lastMigrationId)
		{
			int num = pendingMigrations.Count<string>();
			this._logger.Info((num > 0) ? global::System.Data.Entity.Resources.Strings.LoggingPendingMigrations(num, pendingMigrations.Join(null, ", ")) : (string.IsNullOrWhiteSpace(targetMigrationId) ? global::System.Data.Entity.Resources.Strings.LoggingNoExplicitMigrations : global::System.Data.Entity.Resources.Strings.LoggingAlreadyAtTarget(targetMigrationId)));
			base.Upgrade(pendingMigrations, targetMigrationId, lastMigrationId);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000249AC File Offset: 0x00022BAC
		internal override void Downgrade(global::System.Collections.Generic.IEnumerable<string> pendingMigrations)
		{
			global::System.Collections.Generic.IEnumerable<string> enumerable = pendingMigrations.Take(pendingMigrations.Count<string>() - 1);
			this._logger.Info(global::System.Data.Entity.Resources.Strings.LoggingPendingMigrationsDown(enumerable.Count<string>(), enumerable.Join(null, ", ")));
			base.Downgrade(pendingMigrations);
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x000249F6 File Offset: 0x00022BF6
		internal override void ApplyMigration(global::System.Data.Entity.Migrations.DbMigration migration, global::System.Data.Entity.Migrations.DbMigration lastMigration)
		{
			this._logger.Info(global::System.Data.Entity.Resources.Strings.LoggingApplyMigration(((global::System.Data.Entity.Migrations.Infrastructure.IMigrationMetadata)migration).Id));
			base.ApplyMigration(migration, lastMigration);
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00024A1B File Offset: 0x00022C1B
		internal override void RevertMigration(string migrationId, global::System.Data.Entity.Migrations.DbMigration migration, global::System.Xml.Linq.XDocument targetModel)
		{
			this._logger.Info(global::System.Data.Entity.Resources.Strings.LoggingRevertMigration(migrationId));
			base.RevertMigration(migrationId, migration, targetModel);
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00024A37 File Offset: 0x00022C37
		internal override void SeedDatabase()
		{
			this._logger.Info(global::System.Data.Entity.Resources.Strings.LoggingSeedingDatabase);
			base.SeedDatabase();
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00024A4F File Offset: 0x00022C4F
		internal override void UpgradeHistory(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> upgradeOperations)
		{
			this._logger.Info(global::System.Data.Entity.Resources.Strings.UpgradingHistoryTable);
			base.UpgradeHistory(upgradeOperations);
		}

		// Token: 0x040008A7 RID: 2215
		private readonly global::System.Data.Entity.Migrations.Infrastructure.MigrationsLogger _logger;

		// Token: 0x040008A8 RID: 2216
		private string _lastInfoMessage;
	}
}
