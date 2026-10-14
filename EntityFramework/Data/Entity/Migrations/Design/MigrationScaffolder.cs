using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Migrations.Design
{
	// Token: 0x020000E4 RID: 228
	public class MigrationScaffolder
	{
		// Token: 0x06001148 RID: 4424 RVA: 0x00029A71 File Offset: 0x00027C71
		public MigrationScaffolder(global::System.Data.Entity.Migrations.DbMigrationsConfiguration migrationsConfiguration)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Migrations.DbMigrationsConfiguration>(migrationsConfiguration, "migrationsConfiguration");
			this._migrator = new global::System.Data.Entity.Migrations.DbMigrator(migrationsConfiguration);
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06001149 RID: 4425 RVA: 0x00029A91 File Offset: 0x00027C91
		// (set) Token: 0x0600114A RID: 4426 RVA: 0x00029AB2 File Offset: 0x00027CB2
		public string Namespace
		{
			get
			{
				if (!this._namespaceSpecified)
				{
					return this._migrator.Configuration.MigrationsNamespace;
				}
				return this._namespace;
			}
			set
			{
				this._namespaceSpecified = (this._migrator.Configuration.MigrationsNamespace != value);
				this._namespace = value;
			}
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x00029AD7 File Offset: 0x00027CD7
		public virtual global::System.Data.Entity.Migrations.Design.ScaffoldedMigration Scaffold(string migrationName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(migrationName, "migrationName");
			return this._migrator.Scaffold(migrationName, this.Namespace, false);
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x00029AF8 File Offset: 0x00027CF8
		public virtual global::System.Data.Entity.Migrations.Design.ScaffoldedMigration Scaffold(string migrationName, bool ignoreChanges)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(migrationName, "migrationName");
			return this._migrator.Scaffold(migrationName, this.Namespace, ignoreChanges);
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00029B19 File Offset: 0x00027D19
		public virtual global::System.Data.Entity.Migrations.Design.ScaffoldedMigration ScaffoldInitialCreate()
		{
			return this._migrator.ScaffoldInitialCreate(this.Namespace);
		}

		// Token: 0x040008D6 RID: 2262
		private readonly global::System.Data.Entity.Migrations.DbMigrator _migrator;

		// Token: 0x040008D7 RID: 2263
		private string _namespace;

		// Token: 0x040008D8 RID: 2264
		private bool _namespaceSpecified;
	}
}
