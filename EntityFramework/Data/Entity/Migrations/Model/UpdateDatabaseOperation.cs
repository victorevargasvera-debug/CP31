using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Model
{
	// Token: 0x020000CB RID: 203
	public class UpdateDatabaseOperation : global::System.Data.Entity.Migrations.Model.MigrationOperation
	{
		// Token: 0x06000FE1 RID: 4065 RVA: 0x00020354 File Offset: 0x0001E554
		public UpdateDatabaseOperation(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree> historyQueryTrees) : base(null)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree>>(historyQueryTrees, "historyQueryTrees");
			this._historyQueryTrees = historyQueryTrees;
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x0002037B File Offset: 0x0001E57B
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree> HistoryQueryTrees
		{
			get
			{
				return this._historyQueryTrees;
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00020383 File Offset: 0x0001E583
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation.Migration> Migrations
		{
			get
			{
				return this._migrations;
			}
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x0002038B File Offset: 0x0001E58B
		public void AddMigration(string migrationId, global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(migrationId, "migrationId");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.MigrationOperation>>(operations, "operations");
			this._migrations.Add(new global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation.Migration(migrationId, operations));
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x000203B7 File Offset: 0x0001E5B7
		public override bool IsDestructiveChange
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000896 RID: 2198
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree> _historyQueryTrees;

		// Token: 0x04000897 RID: 2199
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation.Migration> _migrations = new global::System.Collections.Generic.List<global::System.Data.Entity.Migrations.Model.UpdateDatabaseOperation.Migration>();

		// Token: 0x02000758 RID: 1880
		public class Migration
		{
			// Token: 0x060055F4 RID: 22004 RVA: 0x00131DEC File Offset: 0x0012FFEC
			internal Migration(string migrationId, global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.MigrationOperation> operations)
			{
				this._migrationId = migrationId;
				this._operations = operations;
			}

			// Token: 0x1700101F RID: 4127
			// (get) Token: 0x060055F5 RID: 22005 RVA: 0x00131E02 File Offset: 0x00130002
			public string MigrationId
			{
				get
				{
					return this._migrationId;
				}
			}

			// Token: 0x17001020 RID: 4128
			// (get) Token: 0x060055F6 RID: 22006 RVA: 0x00131E0A File Offset: 0x0013000A
			public global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.MigrationOperation> Operations
			{
				get
				{
					return this._operations;
				}
			}

			// Token: 0x04001F08 RID: 7944
			private readonly string _migrationId;

			// Token: 0x04001F09 RID: 7945
			private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Migrations.Model.MigrationOperation> _operations;
		}
	}
}
