using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Diagnostics;
using System.Xml.Linq;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000D6 RID: 214
	[global::System.Diagnostics.DebuggerStepThrough]
	public abstract class MigratorBase
	{
		// Token: 0x0600107A RID: 4218 RVA: 0x00024738 File Offset: 0x00022938
		protected MigratorBase(global::System.Data.Entity.Migrations.Infrastructure.MigratorBase innerMigrator)
		{
			if (innerMigrator == null)
			{
				this._this = this;
				return;
			}
			this._this = innerMigrator;
			global::System.Data.Entity.Migrations.Infrastructure.MigratorBase migratorBase = innerMigrator;
			while (migratorBase._this != innerMigrator)
			{
				migratorBase = migratorBase._this;
			}
			migratorBase._this = this;
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00024778 File Offset: 0x00022978
		public virtual global::System.Collections.Generic.IEnumerable<string> GetPendingMigrations()
		{
			return this._this.GetPendingMigrations();
		}

		// Token: 0x17000468 RID: 1128
		// (get) Token: 0x0600107C RID: 4220 RVA: 0x00024785 File Offset: 0x00022985
		public virtual global::System.Data.Entity.Migrations.DbMigrationsConfiguration Configuration
		{
			get
			{
				return this._this.Configuration;
			}
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x00024792 File Offset: 0x00022992
		public void Update()
		{
			this.Update(null);
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x0002479B File Offset: 0x0002299B
		public virtual void Update(string targetMigration)
		{
			this._this.Update(targetMigration);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x000247A9 File Offset: 0x000229A9
		internal virtual string GetMigrationId(string migration)
		{
			return this._this.GetMigrationId(migration);
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x000247B7 File Offset: 0x000229B7
		public virtual global::System.Collections.Generic.IEnumerable<string> GetLocalMigrations()
		{
			return this._this.GetLocalMigrations();
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x000247C4 File Offset: 0x000229C4
		public virtual global::System.Collections.Generic.IEnumerable<string> GetDatabaseMigrations()
		{
			return this._this.GetDatabaseMigrations();
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000247D1 File Offset: 0x000229D1
		internal virtual void AutoMigrate(string migrationId, global::System.Data.Entity.Migrations.Infrastructure.VersionedModel sourceModel, global::System.Data.Entity.Migrations.Infrastructure.VersionedModel targetModel, bool downgrading)
		{
			this._this.AutoMigrate(migrationId, sourceModel, targetModel, downgrading);
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x000247E3 File Offset: 0x000229E3
		internal virtual void ApplyMigration(global::System.Data.Entity.Migrations.DbMigration migration, global::System.Data.Entity.Migrations.DbMigration lastMigration)
		{
			this._this.ApplyMigration(migration, lastMigration);
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x000247F2 File Offset: 0x000229F2
		internal virtual void EnsureDatabaseExists(global::System.Action mustSucceedToKeepDatabase)
		{
			this._this.EnsureDatabaseExists(mustSucceedToKeepDatabase);
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00024800 File Offset: 0x00022A00
		internal virtual void RevertMigration(string migrationId, global::System.Data.Entity.Migrations.DbMigration migration, global::System.Xml.Linq.XDocument targetModel)
		{
			this._this.RevertMigration(migrationId, migration, targetModel);
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00024810 File Offset: 0x00022A10
		internal virtual void SeedDatabase()
		{
			this._this.SeedDatabase();
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x0002481D File Offset: 0x00022A1D
		internal virtual void ExecuteStatements(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements)
		{
			this._this.ExecuteStatements(migrationStatements);
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x0002482B File Offset: 0x00022A2B
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> GenerateStatements(global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, string migrationId)
		{
			return this._this.GenerateStatements(operations, migrationId);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x0002483A File Offset: 0x00022A3A
		internal virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree> CreateDiscoveryQueryTrees()
		{
			return this._this.CreateDiscoveryQueryTrees();
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00024847 File Offset: 0x00022A47
		internal virtual void ExecuteSql(global::System.Data.Entity.Migrations.Sql.MigrationStatement migrationStatement, global::System.Data.Common.DbConnection connection, global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			this._this.ExecuteSql(migrationStatement, connection, transaction, interceptionContext);
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00024859 File Offset: 0x00022A59
		internal virtual void Upgrade(global::System.Collections.Generic.IEnumerable<string> pendingMigrations, string targetMigrationId, string lastMigrationId)
		{
			this._this.Upgrade(pendingMigrations, targetMigrationId, lastMigrationId);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00024869 File Offset: 0x00022A69
		internal virtual void Downgrade(global::System.Collections.Generic.IEnumerable<string> pendingMigrations)
		{
			this._this.Downgrade(pendingMigrations);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00024877 File Offset: 0x00022A77
		internal virtual void UpgradeHistory(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> upgradeOperations)
		{
			this._this.UpgradeHistory(upgradeOperations);
		}

		// Token: 0x17000469 RID: 1129
		// (get) Token: 0x0600108E RID: 4238 RVA: 0x00024885 File Offset: 0x00022A85
		internal virtual string TargetDatabase
		{
			get
			{
				return this._this.TargetDatabase;
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00024892 File Offset: 0x00022A92
		internal virtual bool HistoryExists()
		{
			return this._this.HistoryExists();
		}

		// Token: 0x040008A6 RID: 2214
		private global::System.Data.Entity.Migrations.Infrastructure.MigratorBase _this;
	}
}
