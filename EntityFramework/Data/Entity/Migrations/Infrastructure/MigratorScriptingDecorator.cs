using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Migrations.Model;
using System.Data.Entity.Migrations.Sql;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Text;

namespace System.Data.Entity.Migrations.Infrastructure
{
	// Token: 0x020000D8 RID: 216
	public class MigratorScriptingDecorator : global::System.Data.Entity.Migrations.Infrastructure.MigratorBase
	{
		// Token: 0x0600109A RID: 4250 RVA: 0x00024A8C File Offset: 0x00022C8C
		public MigratorScriptingDecorator(global::System.Data.Entity.Migrations.Infrastructure.MigratorBase innerMigrator) : base(innerMigrator)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.Infrastructure.MigratorBase>(innerMigrator, "innerMigrator");
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00024AAC File Offset: 0x00022CAC
		public string ScriptUpdate(string sourceMigration, string targetMigration)
		{
			this._sqlBuilder.Clear();
			if (string.IsNullOrWhiteSpace(sourceMigration))
			{
				this.Update(targetMigration);
			}
			else
			{
				if (sourceMigration.IsAutomaticMigration())
				{
					throw global::System.Data.Entity.Resources.Error.AutoNotValidForScriptWindows(sourceMigration);
				}
				string sourceMigrationId = this.GetMigrationId(sourceMigration);
				global::System.Collections.Generic.IEnumerable<string> enumerable = from m in this.GetLocalMigrations()
				where string.CompareOrdinal(m, sourceMigrationId) > 0
				select m;
				string targetMigrationId = null;
				if (!string.IsNullOrWhiteSpace(targetMigration))
				{
					if (targetMigration.IsAutomaticMigration())
					{
						throw global::System.Data.Entity.Resources.Error.AutoNotValidForScriptWindows(targetMigration);
					}
					targetMigrationId = this.GetMigrationId(targetMigration);
					if (string.CompareOrdinal(sourceMigrationId, targetMigrationId) > 0)
					{
						throw global::System.Data.Entity.Resources.Error.DownScriptWindowsNotSupported();
					}
					enumerable = from m in enumerable
					where string.CompareOrdinal(m, targetMigrationId) <= 0
					select m;
				}
				this._updateDatabaseOperation = ((sourceMigration == "0") ? new global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation(base.CreateDiscoveryQueryTrees().ToList<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree>()) : null);
				this.Upgrade(enumerable, targetMigrationId, sourceMigrationId);
				if (this._updateDatabaseOperation != null)
				{
					this.ExecuteStatements(base.GenerateStatements(new global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation[]
					{
						this._updateDatabaseOperation
					}, null));
				}
			}
			return this._sqlBuilder.ToString();
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00024BD3 File Offset: 0x00022DD3
		internal override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> GenerateStatements(global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations, string migrationId)
		{
			if (this._updateDatabaseOperation == null)
			{
				return base.GenerateStatements(operations, migrationId);
			}
			this._updateDatabaseOperation.AddMigration(migrationId, operations);
			return global::System.Linq.Enumerable.Empty<global::System.Data.Entity.Migrations.Sql.MigrationStatement>();
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00024BF8 File Offset: 0x00022DF8
		internal override void EnsureDatabaseExists(global::System.Action mustSucceedToKeepDatabase)
		{
			mustSucceedToKeepDatabase();
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00024C00 File Offset: 0x00022E00
		internal override void ExecuteStatements(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements)
		{
			global::System.Data.Entity.Migrations.Infrastructure.MigratorScriptingDecorator.BuildSqlScript(migrationStatements, this._sqlBuilder);
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00024C10 File Offset: 0x00022E10
		internal static void BuildSqlScript(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> migrationStatements, global::System.Text.StringBuilder sqlBuilder)
		{
			foreach (global::System.Data.Entity.Migrations.Sql.MigrationStatement migrationStatement in migrationStatements)
			{
				if (!string.IsNullOrWhiteSpace(migrationStatement.Sql))
				{
					if (!string.IsNullOrWhiteSpace(migrationStatement.BatchTerminator) && sqlBuilder.Length > 0)
					{
						sqlBuilder.AppendLine(migrationStatement.BatchTerminator);
						sqlBuilder.AppendLine();
					}
					sqlBuilder.AppendLine(migrationStatement.Sql);
				}
			}
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00024C98 File Offset: 0x00022E98
		internal override void SeedDatabase()
		{
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00024C9A File Offset: 0x00022E9A
		internal override bool HistoryExists()
		{
			return false;
		}

		// Token: 0x040008A9 RID: 2217
		private readonly global::System.Text.StringBuilder _sqlBuilder = new global::System.Text.StringBuilder();

		// Token: 0x040008AA RID: 2218
		private global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation _updateDatabaseOperation;
	}
}
